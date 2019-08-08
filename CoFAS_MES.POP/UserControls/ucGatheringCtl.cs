using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.BaseForm;

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace CoFAS_MES.POP.UserControls
{
    public partial class ucGatheringCtl : UserControl
    {
        private string _pCORP_CODE = string.Empty;       // 회사코드       
        private string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private string _pUSER_NAME = string.Empty;       // 사용자이름
        private string sensortype = string.Empty;

        //서버
        CoFAS_SocketServer _pCoFASSocketServer = null;  //서버 오픈

        private Socket SS; //소켓
        private Encoding _pEncoding = Encoding.ASCII;
        private string _IP = string.Empty;  //server IP
        private bool isServerOpen = false;



        CoFAS_SocketClient _pCoFASSocketClinet = null;
        private Socket SC; //소켓

        //서브 데이터 저장
        private DataTable _subData = null;

        //코아칩스 데이터 저장
        private DataTable _CoreChipsElectricDT = null;
        private string _HwID = string.Empty;  //H/W 아이디 변경될 때마다 테이블에 저장
        private DataRow _DrSum = null;

        //경광등 데이터 조회
        private DataTable _dtalarm = null;

        private bool limecolor = false;
        //게더링 min max
        private DataTable _dtMN = null;

        GatheringUcCtlEntity _pGatheringUcCtlEntity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _DtSum = null;
        private string _pMessage = string.Empty; //메세지 처리

        private ModbusTCP.Master MBT;

        private byte[] data;  // modbus TCP 데이터 처리

        System.Threading.Timer _tmrWork;

        System.Threading.Timer _tmrAlarm;  //Q-light 경광등 알람 

        System.Threading.Timer _tmrStart;  //Clinet 설정 

        [DllImport("Qtvc_dll.dll", CallingConvention = CallingConvention.Cdecl)]

        public static unsafe extern bool Tcp_Qu_RW(int iPort, byte* pbIp, byte* pbData);

        private CoFAS_Log _pCoFASLog = new CoFAS_Log(Application.StartupPath + "\\LOG", "", 30, true);




        public ucGatheringCtl()
        {
            InitializeComponent();
        }

        private void InitializeSetting()  //데이터 베이스 세팅
        {
            try
            {
                //메뉴 화면 엔티티 설정
                _pGatheringUcCtlEntity = new GatheringUcCtlEntity();
                _pGatheringUcCtlEntity.CORP_CODE = _pCORP_CODE;
                _pGatheringUcCtlEntity.USER_CODE = _pUSER_CODE;
                Message_Log("세팅", true, true);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        public ucGatheringCtl(DataRow drSetting, DataTable dtSubsetting, DataTable dtMinMax)
        {
            try
            {
                InitializeSetting();
                InitializeComponent();

                _dtMN = dtMinMax;  // DT MinMax 값 설정


                _pGatheringUcCtlEntity.CORP_CODE = drSetting[0].ToString();

                _subData = dtSubsetting;  // 전달받은 서브 데이터 디비에 저장

                _DtSum = new DataTable();
                DataRow _DrSum = null;
                string localIP = string.Empty;

                if (drSetting["RESOURCE_CODE"].ToString() == "RS0002") //코아칩스 서버
                {
                    IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (IPAddress ip in host.AddressList)
                    {
                        if (ip.AddressFamily == AddressFamily.InterNetwork)
                        {
                            localIP = ip.ToString();

                            string[] temp = localIP.Split('.');
                            if (ip.AddressFamily == AddressFamily.InterNetwork && temp[2] == "0")
                            {
                                break;
                            }
                            else
                            {
                                localIP = null;
                            }
                        }
                    }
                }
                //////////////////////DATA SETTING///////////////////////////////////
                _pGatheringUcCtlEntity.RESOURCE_CODE = drSetting["RESOURCE_CODE"].ToString(); // 리소스 코드 세팅
                _pGatheringUcCtlEntity.RESOURCE_NAME = drSetting["RESOURCE_NAME"].ToString(); // 리소스 코드 세팅
                //_pGatheringUcCtlEntity.PROCESS_CODE = drSetting["PROCESS_CODE"].ToString(); // 공정 코드
                //_pGatheringUcCtlEntity.PROCESS_NAME = drSetting["PROCESS_NAME"].ToString(); // 공정 이름
                _pGatheringUcCtlEntity.RESOURCE_TYPE = drSetting["RESOURCE_TYPE"].ToString(); // 리소스 타입
                sensortype = _pGatheringUcCtlEntity.RESOURCE_TYPE;
                _pGatheringUcCtlEntity.RESOURCE_SERIAL = drSetting["RESOURCE_SERIAL"].ToString(); // 리소스 시리얼
                _pGatheringUcCtlEntity.RESOURCE_IP = drSetting["RESOURCE_IP"].ToString() == "" ? localIP : drSetting["RESOURCE_IP"].ToString(); // 리소스 아이피
                _pGatheringUcCtlEntity.RESOURCE_PORT = drSetting["RESOURCE_PORT"].ToString(); // 리소스 포트
                _pGatheringUcCtlEntity.RESOURCE_INTERVAL = drSetting["RESOURCE_INTERVAL"].ToString(); // 리소스 인터벌
                _pGatheringUcCtlEntity.SETTING_YN = drSetting["SETTING_YN"].ToString(); // 리소스 설정 여부
                //_pGatheringUcCtlEntity.GROUP_CNT = drSetting["GROUPCNT"].ToString(); // 리소스 설정 여부


                _CoreChipsElectricDT = new DataTable();
                //코아칩스 데이터 수집 테이블 생성
                _CoreChipsElectricDT.Columns.Add("id", typeof(string));
                _CoreChipsElectricDT.Columns.Add("TE", typeof(string));
                _CoreChipsElectricDT.Columns.Add("HU", typeof(string));
                _CoreChipsElectricDT.Columns.Add("G", typeof(string));
                _CoreChipsElectricDT.Columns.Add("WW", typeof(string));
                _CoreChipsElectricDT.Columns.Add("AS", typeof(string));
                _CoreChipsElectricDT.Columns.Add("AW", typeof(string));
                _CoreChipsElectricDT.Columns.Add("VS", typeof(string));
                _CoreChipsElectricDT.Columns.Add("AV", typeof(string));
                _CoreChipsElectricDT.Columns.Add("AA", typeof(string));
                _CoreChipsElectricDT.Columns.Add("RV", typeof(string));
                _CoreChipsElectricDT.Columns.Add("SV", typeof(string));
                _CoreChipsElectricDT.Columns.Add("TV", typeof(string));
                _CoreChipsElectricDT.Columns.Add("RA", typeof(string));
                _CoreChipsElectricDT.Columns.Add("SA", typeof(string));
                _CoreChipsElectricDT.Columns.Add("TA", typeof(string));


                /////LABEL SETTING////////
                CoFAS_ControlManager.InvokeIfNeeded(_TProcessName, () => _TProcessName.Text = _pGatheringUcCtlEntity.RESOURCE_NAME);

                _DtSum.Columns.Add("RESOURCE_CODE", typeof(string));
                _DtSum.Columns.Add("RESOURCE_NAME", typeof(string));
                //_DtSum.Columns.Add("PROCESS_CODE", typeof(string));
                //_DtSum.Columns.Add("PROCESS_NAME", typeof(string));
                _DtSum.Columns.Add("RESOURCE_TYPE", typeof(string));
                _DtSum.Columns.Add("RESOURCE_SERIAL", typeof(string));
                _DtSum.Columns.Add("RESOURCE_IP", typeof(string));
                _DtSum.Columns.Add("RESOURCE_PORT", typeof(string));
                _DtSum.Columns.Add("RESOURCE_INTERVAL", typeof(string));
                _DtSum.Columns.Add("SETTING_YN", typeof(string));


                _DrSum = _DtSum.NewRow();

                _DrSum["RESOURCE_CODE"] = _pGatheringUcCtlEntity.RESOURCE_CODE;
                _DrSum["RESOURCE_NAME"] = _pGatheringUcCtlEntity.RESOURCE_NAME;
                //_DrSum["PROCESS_CODE"] = _pGatheringUcCtlEntity.PROCESS_CODE;
                //_DrSum["PROCESS_NAME"] = _pGatheringUcCtlEntity.PROCESS_NAME;
                _DrSum["RESOURCE_TYPE"] = _pGatheringUcCtlEntity.RESOURCE_TYPE;
                _DrSum["RESOURCE_SERIAL"] = _pGatheringUcCtlEntity.RESOURCE_SERIAL;
                _DrSum["RESOURCE_IP"] = _pGatheringUcCtlEntity.RESOURCE_IP;
                _DrSum["RESOURCE_PORT"] = _pGatheringUcCtlEntity.RESOURCE_PORT;
                _DrSum["RESOURCE_INTERVAL"] = _pGatheringUcCtlEntity.RESOURCE_INTERVAL;
                _DrSum["SETTING_YN"] = _pGatheringUcCtlEntity.SETTING_YN;


                //switch (drSetting["RESOURCE_TYPE"].ToString())
                //{
                //    case "CD150002":
                //        _DtSum.Columns.Add("Image", typeof(Image));


                //        Image img = new Bitmap((Application.StartupPath + "\\image" + "\\Gathering.png"));
                //        var c_img =  imageToByteArray(img);
                //        var r_img = DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(c_img as byte[]);

                //        _DrSum["Image"] = new Bitmap(r_img, new Size(351, 234));
                //        break;
                //    case "CD150003":
                //        _DtSum.Columns.Add("Image", typeof(Image));


                //        Image img1 = new Bitmap((Application.StartupPath + "\\image" + "\\GatheringServer.png"));
                //        var c_img1 = imageToByteArray(img1);
                //        var r_img1 = DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(c_img1 as byte[]);

                //        _DrSum["Image"] = new Bitmap(r_img1, new Size(351, 234));
                //        break;


                //    default:



                //        break;
                //}


                _DtSum.Rows.Add(_DrSum);

                _gdMAIN.DataSource = _DtSum;

                if (_DtSum != null && _DtSum.Rows.Count > 0)  //타이틀뷰에 데이터 바인딩
                {
                    SetupView();
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                }

                if (_pGatheringUcCtlEntity.RESOURCE_CODE.Length > 0)  // 센서 별 세팅
                {
                    reSourceType_Setting(_pGatheringUcCtlEntity.RESOURCE_CODE);
                }
                else  //default
                {

                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }  //DB 실행


        public ucGatheringCtl(DataRow drSetting)  //로컬 실행
        {
            InitializeSetting();
            InitializeComponent();

            //////////////////////DATA SETTING///////////////////////////////////
            _pGatheringUcCtlEntity.RESOURCE_CODE = drSetting["RESOURCE_CODE"].ToString(); // 리소스 코드 세팅
            _pGatheringUcCtlEntity.RESOURCE_NAME = drSetting["RESOURCE_NAME"].ToString(); // 리소스 코드 세팅
            _pGatheringUcCtlEntity.RESOURCE_TYPE = drSetting["RESOURCE_TYPE"].ToString(); // 리소스 타입
            //_pGatheringUcCtlEntity.RESOURCE_SERIAL = drSetting["RESOURCE_SERIAL"].ToString(); // 리소스 시리얼
            _pGatheringUcCtlEntity.RESOURCE_IP = drSetting["RESOURCE_IP"].ToString(); // 리소스 아이피
            _pGatheringUcCtlEntity.RESOURCE_PORT = drSetting["RESOURCE_PORT"].ToString(); // 리소스 포트
            _pGatheringUcCtlEntity.RESOURCE_INTERVAL = drSetting["RESOURCE_INTERVAL"].ToString(); // 리소스 인터벌

            /////LABEL SETTING////////
            CoFAS_ControlManager.InvokeIfNeeded(_TProcessName, () => _TProcessName.Text = _pGatheringUcCtlEntity.RESOURCE_NAME);


        }


        private void reSourceType_Setting(string RsType)
        {
            switch (RsType)
            {
                case "RS0099": // Modbus TCP  - FEMS
                    _tmrWork = new System.Threading.Timer(new TimerCallback(WorkTimer), null, 10000, Timeout.Infinite);  //초기 10초 후 동작

                    // // 데이터 통신
                    break;

                case "RS9999": // Q-Light 경광등 알람
                    _tmrAlarm = new System.Threading.Timer(new TimerCallback(AlarmTimer), null, 10000, Timeout.Infinite);  //초기 10초 후 동작

                    // // 데이터 통신
                    break;
                case "RS0004":
                    if (_pGatheringUcCtlEntity.RESOURCE_TYPE == "2000")
                    {
                        try
                        {
                            _pCoFASSocketClinet = new CoFAS_SocketClient(_pGatheringUcCtlEntity.RESOURCE_IP, Convert.ToInt32(_pGatheringUcCtlEntity.RESOURCE_PORT));
                            _pCoFASSocketClinet.evtReceived = new CoFAS_SocketClient.delReceive(evtReceiveSend);
                            _pCoFASSocketClinet.Open();

                            //연결 완료
                            _tmrStart = new System.Threading.Timer(new TimerCallback(ClinetTimer), null, 2000, Timeout.Infinite);  //초기 10초 후 동작

                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    else // server
                    {
                        _pCoFASSocketServer = new CoFAS_SocketServer(Convert.ToInt32(_pGatheringUcCtlEntity.RESOURCE_PORT), 100);
                        _pCoFASSocketServer.evtReceiveRequest = new CoFAS_SocketServer.delReceiveRequest(evtReceiveRequest);
                        try
                        {
                            Server_Open();
                        }
                        catch (Exception ex)
                        {
                            // Message_Log(ex.ToString(), true, true);
                        }
                    }
                    break;

                default:
                    _pCoFASSocketServer = new CoFAS_SocketServer(Convert.ToInt32(_pGatheringUcCtlEntity.RESOURCE_PORT), 100);
                    _pCoFASSocketServer.evtReceiveRequest = new CoFAS_SocketServer.delReceiveRequest(evtReceiveRequest);
                    try
                    {
                        Server_Open();
                    }
                    catch (Exception ex)
                    {
                        // Message_Log(ex.ToString(), true, true);
                    }
                    break;

            }
        }


        #region U.S.A 소켓통신

        private void CilentSend(Socket soc, byte[] bytdata)
        {
            try
            {
                IPEndPoint ip = (IPEndPoint)soc.RemoteEndPoint;
                _IP = ip.Address.ToString();
                string str = _pEncoding.GetString(bytdata);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void evtReceiveRequest(Socket soc, byte[] byt)
        {
            try
            {
                byte[] byteresult = byt;  //테스트 bytData  // 실적용 byt

                byte[] ByteArray_ReceiveData = byt;  //코아칩스 수집용 1006

                string strCheck = CoFAS_ConvertManager.ByteArray2HexString(byteresult, "");
                string strSTR = System.Text.Encoding.Default.GetString(byt);

                //하드코딩 min max 데이터 10건 

                string min1 = string.Empty;
                string min2 = string.Empty;
                string min3 = string.Empty;
                string min4 = string.Empty;
                string min5 = string.Empty;
                string max1 = string.Empty;
                string max2 = string.Empty;
                string max3 = string.Empty;
                string max4 = string.Empty;
                string max5 = string.Empty;
                bool minmaxcheck = false;

                #region 코아칩스 전력 프로토콜
                if (_pGatheringUcCtlEntity.RESOURCE_CODE == "RS0002")  // 코아칩스 전력 서버 타입
                {
                    try
                    {
                        // 데이터가 있다면
                        if (ByteArray_ReceiveData.Length != 0)
                        {


                            //Message_Log("data to " + ByteArray_ReceiveData.Length.ToString(), false, true);
                            //Message_Log("length1 to  " + Encoding.UTF8.GetString(ByteArray_ReceiveData, 6, 1), false, true);
                            //Message_Log("length2 to  " + Encoding.UTF8.GetString(ByteArray_ReceiveData, 7, 1), false, true);

                            var Stx = Encoding.UTF8.GetString(ByteArray_ReceiveData, 0, 1);
                            var Type = Encoding.UTF8.GetString(ByteArray_ReceiveData, 1, 2);
                            var PointNumber = Encoding.UTF8.GetString(ByteArray_ReceiveData, 3, 2);
                            var Reserve1 = Encoding.UTF8.GetString(ByteArray_ReceiveData, 5, 1);
                            //var Reserve2 = Encoding.UTF8.GetString(ByteArray_ReceiveData, 6, 1);
                            var Length = Encoding.UTF8.GetString(ByteArray_ReceiveData, 6, 1);
                            var Length2 = Encoding.UTF8.GetString(ByteArray_ReceiveData, 7, 1);
                            string strLength = Length + Length2;
                            //Message_Log("length total to  " + strLength, false, true);

                            var Value = Encoding.UTF8.GetString(ByteArray_ReceiveData, 8, Convert.ToInt32(strLength));
                            var TypeText = string.Empty;

                            //Row 생성
                            if (_HwID == "") //첫 스타트
                            {
                                _HwID = PointNumber;
                                _pGatheringUcCtlEntity.E_EQUIPMENT_CODE = _HwID;
                                _DrSum = _CoreChipsElectricDT.NewRow();
                                _DrSum["id"] = _HwID;
                                _CoreChipsElectricDT.Rows.Add(_DrSum);
                            }
                            else if (_HwID != "") // 값이 들어있음.
                            {
                                if (PointNumber != _HwID)  // 동일한 패킷의 데이터가 다를경우
                                {
                                    //전 저장
                                    bool isError = false;
                                    isError = new GatheringUcCtlBusiness().CoreChips_Data_Save(_pGatheringUcCtlEntity);
                                    // 후 초기화 
                                    _CoreChipsElectricDT.Clear();
                                    // 후 신규 저장
                                    _HwID = PointNumber;
                                    _DrSum = _CoreChipsElectricDT.NewRow();
                                    _DrSum["id"] = _HwID;
                                    _CoreChipsElectricDT.Rows.Add(_DrSum);


                                }
                            }


                            this.Invoke(new MethodInvoker(delegate
                            {
                                switch (Type)
                                {
                                    case "TE":
                                        _CoreChipsElectricDT.Rows[0]["TE"] = Value;
                                        _pGatheringUcCtlEntity.E_TEMP = Value;
                                        //Label_Temp.Text = Value + "℃";
                                        //TypeText = "센서번호 :: " + PointNumber + ", 온도 :: " + Value;
                                        break;
                                    case "HU":
                                        _CoreChipsElectricDT.Rows[0]["HU"] = Value;
                                        _pGatheringUcCtlEntity.E_HUMI = Value;
                                        //Label_Humi.Text = Value + "%";
                                        //TypeText = "센서번호 :: " + PointNumber + ", 습도 :: " + Value;
                                        break;
                                    case "G":
                                        _CoreChipsElectricDT.Rows[0]["G"] = Value;
                                        _pGatheringUcCtlEntity.E_VOC = Value;
                                        //Label_VOC.Text = Value + "㎍";
                                        //TypeText = "센서번호 :: " + PointNumber + ", VOC  :: " + Value;
                                        break;
                                    case "WW":
                                        _CoreChipsElectricDT.Rows[0]["WW"] = Value;
                                        _pGatheringUcCtlEntity.E_ACTIVE_POWER = Value;
                                        //Label_W.Text = Value + "W";
                                        //TypeText = "센서번호 :: " + PointNumber + ", 순시전력 :: " + Value;
                                        break;
                                    case "AS":
                                        _CoreChipsElectricDT.Rows[0]["AS"] = Value;
                                        _pGatheringUcCtlEntity.E_AVG_P_CURRENT = Value;
                                        //Label_W.Text = Value + "A";
                                        //TypeText = "센서번호 :: " + PointNumber + ", 전체전류 :: " + Value;
                                        break;

                                    case "AW":
                                        _CoreChipsElectricDT.Rows[0]["AW"] = Value;
                                        _pGatheringUcCtlEntity.E_POWER_CONSUMPTION = Value;
                                        //Label_W.Text = Value + "W";
                                        //TypeText = "센서번호 :: " + PointNumber + ", 누적전력 :: " + Value;
                                        break;
                                    case "VS":
                                        _CoreChipsElectricDT.Rows[0]["VS"] = Value;
                                        _pGatheringUcCtlEntity.E_AVG_P_VOLTAGE = Value;
                                        //Label_W.Text = Value + "A";
                                        //TypeText = "센서번호 :: " + PointNumber + ", 전체전압 :: " + Value;
                                        break;
                                    case "AV":
                                        _CoreChipsElectricDT.Rows[0]["AV"] = Value;
                                        _pGatheringUcCtlEntity.E_AVG_VOLTAGE = Value;
                                        //Label_W.Text = Value + "V";
                                        //TypeText = "센서번호 :: " + PointNumber + ", 평균전압 :: " + Value;
                                        break;
                                    case "AA":
                                        _CoreChipsElectricDT.Rows[0]["AA"] = Value;
                                        _pGatheringUcCtlEntity.E_AVG_CURRENT = Value;
                                        //Label_W.Text = Value + "A";
                                        //TypeText = "센서번호 :: " + PointNumber + ", 평균전류 :: " + Value;
                                        break;

                                    case "RV":
                                        _CoreChipsElectricDT.Rows[0]["RV"] = Value;
                                        _pGatheringUcCtlEntity.E_R_VOLTAGE = Value;
                                        //Label_W.Text = Value + "V";
                                        //TypeText = "센서번호 :: " + PointNumber + ", R상전압 :: " + Value;
                                        break;
                                    case "SV":
                                        _CoreChipsElectricDT.Rows[0]["SV"] = Value;
                                        _pGatheringUcCtlEntity.E_S_VOLTAGE = Value;
                                        //Label_W.Text = Value + "V";
                                        //TypeText = "센서번호 :: " + PointNumber + ", S상전압 :: " + Value;
                                        break;
                                    case "TV":
                                        _CoreChipsElectricDT.Rows[0]["TV"] = Value;
                                        _pGatheringUcCtlEntity.E_T_VOLTAGE = Value;
                                        //Label_W.Text = Value + "V";
                                        //TypeText = "센서번호 :: " + PointNumber + ", T상전압 :: " + Value;
                                        break;
                                    case "RA":
                                        _CoreChipsElectricDT.Rows[0]["RA"] = Value;
                                        _pGatheringUcCtlEntity.E_R_CURRENT = Value;
                                        //Label_W.Text = Value + "A";
                                        //TypeText = "센서번호 :: " + PointNumber + ", R상전류 :: " + Value;
                                        break;
                                    case "SA":
                                        _CoreChipsElectricDT.Rows[0]["SA"] = Value;
                                        _pGatheringUcCtlEntity.E_S_CURRENT = Value;
                                        //Label_W.Text = Value + "A";
                                        //TypeText = "센서번호 :: " + PointNumber + ", S상전류 :: " + Value;
                                        break;
                                    case "TA":
                                        _CoreChipsElectricDT.Rows[0]["TA"] = Value;
                                        _pGatheringUcCtlEntity.E_T_CURRENT = Value;
                                        //Label_W.Text = Value + "A";
                                        //TypeText = "센서번호 :: " + PointNumber + ", T상전류 :: " + Value;
                                        break;
                                    default:
                                        throw new InvalidEnumArgumentException();
                                        //break;
                                }
                            }));

                            // 데이터 저장 및 UI 표시
                            //Message_Log(System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss:fff]") + " " + TypeText, true, true);
                            // 데이터 받았다는 신호 전송
                            byte[] ByteArray_Complet = { 79, 75 };
                            soc.Send(ByteArray_Complet);

                            // $T03000526.56
                            // 01234567 89123
                            // $T030005 26.56 << 이런의미
                            // var ReceiveValue = "더하기" + Stx;

                            // byte[] 배열 데이터 꺼내오기
                            // 전체 값
                            // Encoding.UTF8.GetString(byteArray);
                            // Encoding.ASCII.GetString(byteArray);
                            // Encoding.Default.GetString(byteArray);

                            // 개별 원하는 만큼만
                            // Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);
                            // Encoding.ASCII.GetString(byteArray, 0, byteArray.Length);
                            // Encoding.Default.GetString(byteArray, 0, byteArray.Length);

                            // csv 저장 방법
                            //using (Stream stream = File.OpenWrite("aa.csv"))
                            //{
                            //    stream.SetLength(0);
                            //    using (StreamWriter writer = new StreamWriter(stream))
                            //    {
                            //        // loop through each row of our DataGridView
                            //        //foreach (DataGridViewRow row in dataGridView1.Rows)
                            //        //{
                            //        // string line = string.Join(",", row.Cells.Select(x => $"{x}"));
                            //        string csv = string.Format("{0},{1}{2}", Value, Value, Environment.NewLine);
                            //        writer.WriteLine(csv);
                            //
                            // 
                            //        //StreamWriter sw = new StreamWriter("aa.csv", false, Encoding.Unicode);
                            //        //sw.WriteLine(Value + "\t" + Value);
                            //        //sw.WriteLine(csv);
                            //        //sw.Close();
                            //        //}

                            //        writer.Flush();
                            //    }
                            //};
                        }

                        // CoFASControl.Invoke_Control_Text(textBox1, str);
                    }
                    catch (Exception ex)
                    {
                        // 데이터 저장 및 UI 표시

                        //Message_Log("ERROR::" + ex.Message, true, true);

                        // 데이터 실패 신호 전송
                        byte[] ByteArray_Complet = { 110, 111 };
                        soc.Send(ByteArray_Complet);
                        //MessageBox.Show("데이터 형식이 잘 못 되었습니다.");
                    }
                }
                #endregion

                #region 코에버 온습도센서 프로토콜
                else if (_pGatheringUcCtlEntity.RESOURCE_CODE == "RS0003")  //온습도 서버 타입
                {
                    if (strSTR.Length > 20)   //최대 30 이상..
                    {
                        //먼저 설정값을 세팅한다.
                        string tempDatacode = string.Empty;
                        string humiDatacode = string.Empty;


                        //먼저 # 기준으로 자른다.
                        string[] sp = strSTR.Split('#');
                        for (int i = 0; i < sp.Length; i++)
                        {
                            if (sp[i].ToString() != "") //시작이 공백이면 패스
                            {
                                string[] val = sp[i].Split(':');  //,없으면 에러

                                if (val[0].Length == 6) //serial 정보가 입력이 되어야 함. ( 자동 채번으로 등록은 안됨) Resource_sensor에 등록되있어야함. iotCode 필
                                {
                                    for (int t = 0; t < _subData.Rows.Count; t++)
                                    {
                                        if (val[1].ToString() == _subData.Rows[t]["iot_code"].ToString() && _subData.Rows[t]["sensor_unit"].ToString() == "1001")  // iot 코드가 같은거만 등록처리 온도
                                        {
                                            tempDatacode = _subData.Rows[t]["resource_code"].ToString();
                                        }
                                        else if (val[1].ToString() == _subData.Rows[t]["iot_code"].ToString() && _subData.Rows[t]["sensor_unit"].ToString() == "1002")  // iot 코드 습도
                                        {
                                            humiDatacode = _subData.Rows[t]["resource_code"].ToString();
                                        }
                                    }
                                }
                                else
                                {
                                    if (val[0].ToString() == "tem")  //온도
                                    {
                                        _pGatheringUcCtlEntity.RESOURCE_SERVER = tempDatacode;  //SENSOR COLLECTION DATA
                                        _pGatheringUcCtlEntity.ATTR1 = "";  //미사용컬럼
                                        _pGatheringUcCtlEntity.ATTR2 = "";  //미사용컬럼
                                        _pGatheringUcCtlEntity.VALUES = decimal.Parse(val[1].ToString()); //센서 수집 데이터( 형변환 문의)

                                        bool isError = false;
                                        isError = new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);

                                        if (isError)
                                        {
                                            //에러
                                        }
                                        else
                                        {
                                            //정상 처리
                                        }
                                    }
                                    else if (val[0].ToString() == "hum") //습도
                                    {
                                        _pGatheringUcCtlEntity.RESOURCE_SERVER = humiDatacode;  //SENSOR COLLECTION DATA
                                        _pGatheringUcCtlEntity.ATTR1 = "";  //미사용컬럼
                                        _pGatheringUcCtlEntity.ATTR2 = "";  //미사용컬럼
                                        _pGatheringUcCtlEntity.VALUES = decimal.Parse(val[1].ToString()); //센서 수집 데이터( 형변환 문의)

                                        bool isError = false;
                                        isError = new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);

                                        if (isError)
                                        {
                                            //에러
                                        }
                                        else
                                        {
                                            //정상 처리
                                        }
                                    }
                                    else
                                    {
                                        //오류
                                    }
                                }

                            }
                        }
                    }
                    else
                    {

                    }

                }
                #endregion

                #region 코아칩스 FEMS 프로토콜
                else if (_pGatheringUcCtlEntity.RESOURCE_CODE == "RS0005")  //코아칩스
                {
                    Message_Log(strSTR, true, true);
                    if (strSTR.Length < 20) //온도
                    {
                        string[] sp = strSTR.Split(',');
                        //sp[0] == H/W 구분 
                        //sp[1] == H/W ID
                        //sp[2] == Value
                        _pGatheringUcCtlEntity.E_GROUP_CODE = sp[0].Substring(1, 2).ToString();
                        _pGatheringUcCtlEntity.E_EQUIPMENT_CODE = sp[1].ToString();
                        _pGatheringUcCtlEntity.E_TEMP = sp[2].ToString();
                        bool isError = false;
                        isError = new GatheringUcCtlBusiness().DQ_TOP_Data_Save(_pGatheringUcCtlEntity);

                        if (isError)
                        {
                            //에러
                        }
                        else
                        {
                            Add_ListView(strSTR.ToString(), "");
                            //정상 처리
                        }
                    }
                    else  // 전력
                    {
                        string[] sp = strSTR.Split(',');
                        _pGatheringUcCtlEntity.E_STATUS_CODE = sp[0].Substring(1, 2).ToString();
                        _pGatheringUcCtlEntity.E_HW_CODE = sp[1].ToString();    // hwid
                        _pGatheringUcCtlEntity.E_R_VOLTAGE = sp[2].ToString();  // r전압
                        _pGatheringUcCtlEntity.E_S_VOLTAGE = sp[3].ToString();  // s전압
                        _pGatheringUcCtlEntity.E_T_VOLTAGE = sp[4].ToString();  // t전압
                        _pGatheringUcCtlEntity.E_R_CURRENT = sp[5].ToString();  // r전류
                        _pGatheringUcCtlEntity.E_S_CURRENT = sp[6].ToString();  // s전류
                        _pGatheringUcCtlEntity.E_T_CURRENT = sp[7].ToString();  // t전류
                        _pGatheringUcCtlEntity.E_POWER_FACTOR = sp[8].ToString(); // 역률
                        _pGatheringUcCtlEntity.E_ACTIVE_POWER = sp[9].ToString(); // 유효전력
                        _pGatheringUcCtlEntity.E_POWER_CONSUMPTION = sp[10].ToString();  //누적전력


                        bool isError = false;
                        isError = new GatheringUcCtlBusiness().DQ_TOP_elec_Data_Save(_pGatheringUcCtlEntity);

                        if (isError)
                        {
                            //에러
                        }
                        else
                        {
                            Add_ListView(strSTR.ToString(), "");
                            //정상 처리
                        }
                    }
                }
                #endregion

                #region 바이오세라 김기환대리 수정 버전 온습도
                else if (_pGatheringUcCtlEntity.RESOURCE_CODE == "RS0011")  //온습도 서버 타입_바이오세라
                {
                    if (strSTR.Length > 20)   //최대 30 이상..
                    {
                        //먼저 설정값을 세팅한다.
                        string tempDatacode = string.Empty;
                        string humiDatacode = string.Empty;


                        //먼저 # 기준으로 자른다.
                        string[] sp = strSTR.Split('#');
                        for (int i = 0; i < sp.Length; i++)
                        {
                            if (sp[i].ToString() != "") //시작이 공백이면 패스
                            {
                                string[] val = sp[i].Split(':');  //,없으면 에러

                                if (val[0].Length == 6) //serial 정보가 입력이 되어야 함. ( 자동 채번으로 등록은 안됨) Resource_sensor에 등록되있어야함. iotCode 필
                                {
                                    for (int t = 0; t < _subData.Rows.Count; t++)
                                    {
                                        if (val[1].ToString() == _subData.Rows[t]["iot_code"].ToString() && _subData.Rows[t]["sensor_unit"].ToString() == "1001")  // iot 코드가 같은거만 등록처리 온도
                                        {
                                            tempDatacode = _subData.Rows[t]["resource_code"].ToString();
                                        }
                                        else if (val[1].ToString() == _subData.Rows[t]["iot_code"].ToString() && _subData.Rows[t]["sensor_unit"].ToString() == "1002")  // iot 코드 습도
                                        {
                                            humiDatacode = _subData.Rows[t]["resource_code"].ToString();
                                        }
                                    }
                                }
                                else
                                {
                                    if (val[0].ToString() == "tem")  //온도
                                    {
                                        _pGatheringUcCtlEntity.RESOURCE_SERVER = tempDatacode;  //SENSOR COLLECTION DATA
                                        _pGatheringUcCtlEntity.ATTR1 = "";  //미사용컬럼
                                        _pGatheringUcCtlEntity.ATTR2 = "";  //미사용컬럼
                                        _pGatheringUcCtlEntity.VALUES = decimal.Parse(val[1].ToString()); //센서 수집 데이터( 형변환 문의)

                                        bool isError = false;
                                        isError = new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);

                                        if (isError)
                                        {
                                            //에러
                                        }
                                        else
                                        {
                                            //정상 처리
                                        }
                                    }
                                    else if (val[0].ToString() == "hum") //습도
                                    {
                                        _pGatheringUcCtlEntity.RESOURCE_SERVER = humiDatacode;  //SENSOR COLLECTION DATA
                                        _pGatheringUcCtlEntity.ATTR1 = "";  //미사용컬럼
                                        _pGatheringUcCtlEntity.ATTR2 = "";  //미사용컬럼
                                        _pGatheringUcCtlEntity.VALUES = decimal.Parse(val[1].ToString()); //센서 수집 데이터( 형변환 문의)

                                        bool isError = false;
                                        isError = new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);

                                        if (isError)
                                        {
                                            //에러
                                        }
                                        else
                                        {
                                            //정상 처리
                                        }
                                    }
                                    else
                                    {
                                        //오류
                                    }
                                }

                            }
                        }
                    }
                    else
                    {

                    }

                }
                #endregion

                #region 하이월드테크 수정 버전 온습도
                else if (_pGatheringUcCtlEntity.RESOURCE_CODE == "RS0051")  //온습도 서버 타입_하이월드테크
                {
                    if (strSTR.Length > 20)   //최대 30 이상..
                    {
                        //먼저 설정값을 세팅한다.
                        string tempDatacode = string.Empty;
                        string humiDatacode = string.Empty;


                        //먼저 # 기준으로 자른다.
                        string[] sp = strSTR.Split('#');
                        for (int i = 0; i < sp.Length; i++)
                        {
                            if (sp[i].ToString() != "") //시작이 공백이면 패스
                            {
                                string[] val = sp[i].Split(':');  //,없으면 에러

                                if (val[0].Length == 6) //serial 정보가 입력이 되어야 함. ( 자동 채번으로 등록은 안됨) Resource_sensor에 등록되있어야함. iotCode 필
                                {
                                    Add_ListView(strSTR, "");
                                    for (int t = 0; t < _subData.Rows.Count; t++)
                                    {
                                        if (val[1].ToString() == _subData.Rows[t]["iot_code"].ToString() && _subData.Rows[t]["sensor_unit"].ToString() == "1001")  // iot 코드가 같은거만 등록처리 온도
                                        {
                                            tempDatacode = _subData.Rows[t]["resource_code"].ToString();
                                        }
                                        else if (val[1].ToString() == _subData.Rows[t]["iot_code"].ToString() && _subData.Rows[t]["sensor_unit"].ToString() == "1002")  // iot 코드 습도
                                        {
                                            humiDatacode = _subData.Rows[t]["resource_code"].ToString();
                                        }
                                    }
                                }
                                else
                                {
                                    if (val[0].ToString() == "tem")  //온도
                                    {
                                        _pGatheringUcCtlEntity.RESOURCE_SERVER = tempDatacode;  //SENSOR COLLECTION DATA
                                        _pGatheringUcCtlEntity.ATTR1 = "";  //미사용컬럼
                                        _pGatheringUcCtlEntity.ATTR2 = "";  //미사용컬럼
                                        _pGatheringUcCtlEntity.VALUES = decimal.Parse(val[1].ToString()); //센서 수집 데이터( 형변환 문의)

                                        bool isError = false;
                                        isError = new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);

                                        if (isError)
                                        {
                                            //에러
                                        }
                                        else
                                        {
                                            //정상 처리
                                        }
                                    }
                                    else if (val[0].ToString() == "hum") //습도
                                    {
                                        _pGatheringUcCtlEntity.RESOURCE_SERVER = humiDatacode;  //SENSOR COLLECTION DATA
                                        _pGatheringUcCtlEntity.ATTR1 = "";  //미사용컬럼
                                        _pGatheringUcCtlEntity.ATTR2 = "";  //미사용컬럼
                                        _pGatheringUcCtlEntity.VALUES = decimal.Parse(val[1].ToString()); //센서 수집 데이터( 형변환 문의)

                                        bool isError = false;
                                        isError = new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);

                                        if (isError)
                                        {
                                            //에러
                                        }
                                        else
                                        {
                                            //정상 처리
                                        }
                                    }
                                    else
                                    {
                                        //오류
                                    }
                                }

                            }
                        }
                    }
                    else
                    {

                    }

                }
                #endregion

                #region 오웰 KV7000 PLC 데이터수집

                else if (_pGatheringUcCtlEntity.RESOURCE_CODE == "RS0001")  // KV7500 PLC 데이터 수집
                {
                    if (strSTR.Length > 15)
                    {
                        //처음 입력된 패킷을 잘라서 필요한 데이터 생성
                        string CutPacket = strSTR.Substring(8, strSTR.Length - 8);
                        // 구분자 : 로 패킷 분할
                        string[] _CutP = CutPacket.Split(':');

                        _pGatheringUcCtlEntity.RESOURCE_SERVER = _CutP[0];  //Name
                        _pGatheringUcCtlEntity.ATTR1 = _CutP[1];  //Memory address
                        _pGatheringUcCtlEntity.ATTR2 = _CutP[2];  //Memory Size
                        _pGatheringUcCtlEntity.STRING_VALUES = _CutP[3].ToString(); //결과 값( 형변환 문의)
                        bool isError = false;
                        Add_ListView(_CutP[0].ToString() + "|" + _CutP[1].ToString() + "|" + _CutP[2].ToString() + "|" + _CutP[3].ToString(), "");
                        Message_Log(strSTR, true, true);
                        isError = new GatheringUcCtlBusiness().DQ_Data_Save_Str(_pGatheringUcCtlEntity);  //String 값으로 저장 프로시저

                        if (isError)
                        {
                            //에러
                        }
                        else
                        {
                            //정상 처리
                        }

                    }
                }
                #endregion

                #region 니노미야
                else if (_pGatheringUcCtlEntity.RESOURCE_CODE == "RS0004") // Ninomiya Data 
                {

                    if (strSTR.Length > 6)
                    {
                        //먼저 $ 기준으로 자른다.

                        string[] sp = strSTR.Split('$');


                        for (int i = 0; i < sp.Length; i++)
                        {
                            if (sp[i].ToString() != "") //시작이 공백이면 패스
                            {
                                string[] val = sp[i].Split(',');  //,없으면 에러

                                if (val[0].Length >= 4)
                                {
                                    _pGatheringUcCtlEntity.RESOURCE_SERVER = val[0].ToString().Substring(2, val[0].Length - 2);  //SENSOR COLLECTION DATA
                                    _pGatheringUcCtlEntity.ATTR1 = "";  //미사용컬럼
                                    _pGatheringUcCtlEntity.ATTR2 = "";  //미사용컬럼
                                    _pGatheringUcCtlEntity.VALUES = decimal.Parse(val[1].ToString()); //센서 수집 데이터( 형변환 문의)
                                    Add_ListView(strSTR, "");
                                    Message_Log(strSTR, true, true);
                                    bool isError = false;


                                    #region @ MinMax 값 확인
                                    //data 설정값
                                    for (int z = 0; z < _dtMN.Rows.Count; z++)
                                    {
                                        //iotcode 값 같은 것을 설정
                                        if (_dtMN.Rows[z]["iot_code"].ToString() == _pGatheringUcCtlEntity.RESOURCE_SERVER)
                                        {
                                            min1 = _dtMN.Rows[z]["resource_min_1"].ToString();
                                            min2 = _dtMN.Rows[z]["resource_min_2"].ToString();
                                            min3 = _dtMN.Rows[z]["resource_min_3"].ToString();
                                            min4 = _dtMN.Rows[z]["resource_min_4"].ToString();
                                            min5 = _dtMN.Rows[z]["resource_min_5"].ToString();
                                            max1 = _dtMN.Rows[z]["resource_max_1"].ToString();
                                            max2 = _dtMN.Rows[z]["resource_max_2"].ToString();
                                            max3 = _dtMN.Rows[z]["resource_max_3"].ToString();
                                            max4 = _dtMN.Rows[z]["resource_max_4"].ToString();
                                            max5 = _dtMN.Rows[z]["resource_max_5"].ToString();
                                            
                                            minmaxcheck = _ruledata(min1, min2, min3, min4, min5, max1, max2, max3, max4, max5);

                                            if (minmaxcheck)
                                            {
                                                new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);
                                            }
                                            else
                                            {
                                                isError = new GatheringUcCtlBusiness().DQ_Data_Trash_Save(_pGatheringUcCtlEntity);
                                            }

                                         }
                                        else
                                        {
                                            new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);
                                        }
                                    }
                                    #endregion
                                }
                                else
                                {
                                       Message_Log("Data Length Error", true, true);
                                }

                            }
                        }
                    }
                    else  //데이터 오류
                    {
                         Message_Log("Data Error", true, true);
                    }

                }
                #endregion
                else
                {
                    //$tAn01,23.56       --테스트 데이터

                    if (strSTR.Length > 6)
                    {
                        //먼저 $ 기준으로 자른다.

                        string[] sp = strSTR.Split('$');


                        for (int i = 0; i < sp.Length; i++)
                        {
                            if (sp[i].ToString() != "") //시작이 공백이면 패스
                            {
                                string[] val = sp[i].Split(',');  //,없으면 에러

                                if (val[0].Length >= 4)
                                {
                                    _pGatheringUcCtlEntity.RESOURCE_SERVER = val[0].ToString().Substring(2, val[0].Length - 2);  //SENSOR COLLECTION DATA
                                    _pGatheringUcCtlEntity.ATTR1 = "";  //미사용컬럼
                                    _pGatheringUcCtlEntity.ATTR2 = "";  //미사용컬럼
                                    _pGatheringUcCtlEntity.VALUES = decimal.Parse(val[1].ToString()); //센서 수집 데이터( 형변환 문의)
                                    Add_ListView(strSTR, "");
                                    Message_Log(strSTR, true, true);
                                    bool isError = false;

                                    #region @ MinMax 값 확인
                                    //data 설정값
                                    for (int z = 0; z < _dtMN.Rows.Count; z++)
                                    {
                                        //iotcode 값 같은 것을 설정
                                        if (_dtMN.Rows[z]["iot_code"].ToString() == _pGatheringUcCtlEntity.RESOURCE_SERVER)
                                        {
                                            min1 = _dtMN.Rows[z]["resource_min_1"].ToString();
                                            min2 = _dtMN.Rows[z]["resource_min_2"].ToString();
                                            min3 = _dtMN.Rows[z]["resource_min_3"].ToString();
                                            min4 = _dtMN.Rows[z]["resource_min_4"].ToString();
                                            min5 = _dtMN.Rows[z]["resource_min_5"].ToString();
                                            max1 = _dtMN.Rows[z]["resource_max_1"].ToString();
                                            max2 = _dtMN.Rows[z]["resource_max_2"].ToString();
                                            max3 = _dtMN.Rows[z]["resource_max_3"].ToString();
                                            max4 = _dtMN.Rows[z]["resource_max_4"].ToString();
                                            max5 = _dtMN.Rows[z]["resource_max_5"].ToString();

                                            minmaxcheck = _ruledata(min1, min2, min3, min4, min5, max1, max2, max3, max4, max5);

                                            if (minmaxcheck)
                                            {
                                                new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);
                                            }
                                            else
                                            {
                                                isError = new GatheringUcCtlBusiness().DQ_Data_Trash_Save(_pGatheringUcCtlEntity);
                                            }

                                        }
                                        else
                                        {
                                            new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);
                                        }
                                    }
                                    #endregion


                                    if (isError)
                                    {
                                        //에러
                                    }
                                    else
                                    {
                                        //정상 처리
                                    }
                                }
                                else
                                {
                                    //   Message_Log("Data Length Error", true, true);
                                }

                            }
                        }
                    }
                    else  //데이터 오류
                    {
                        // Message_Log("Data Error", true, true);
                    }
                }
            }
            catch (Exception pException)
            {
                Message_Log("Request Error : " + pException.ToString(), true, true);
            }
        }

        private void evtReceiveSend(byte[] byt) // 클라이언트
        {
            try
            {
                //하드코딩 min max 데이터 10건 

                string min1 = string.Empty;
                string min2 = string.Empty;
                string min3 = string.Empty;
                string min4 = string.Empty;
                string min5 = string.Empty;
                string max1 = string.Empty;
                string max2 = string.Empty;
                string max3 = string.Empty;
                string max4 = string.Empty;
                string max5 = string.Empty;
                bool minmaxcheck = false;

                byte[] byteresult = byt;  //테스트 bytData  // 실적용 byt

                byte[] ByteArray_ReceiveData = byt;  //코아칩스 수집용 1006

                string strCheck = CoFAS_ConvertManager.ByteArray2HexString(byteresult, "");
                string strSTR = System.Text.Encoding.Default.GetString(byt);

                if (_pGatheringUcCtlEntity.RESOURCE_CODE == "RS0004") // Ninomiya Data 
                {

                    if (strSTR.Length > 6)
                    {
                        //먼저 $ 기준으로 자른다.

                        string[] sp = strSTR.Split('$');


                        for (int i = 0; i < sp.Length; i++)
                        {
                            if (sp[i].ToString() != "") //시작이 공백이면 패스
                            {
                                string[] val = sp[i].Split(',');  //,없으면 에러

                                if (val[0].Length >= 1)
                                {
                                    _pGatheringUcCtlEntity.RESOURCE_SERVER = val[0].ToString() + "_" + val[1].ToString();  //SENSOR COLLECTION DATA
                                    _pGatheringUcCtlEntity.ATTR1 = "";  //미사용컬럼
                                    _pGatheringUcCtlEntity.ATTR2 = "";  //미사용컬럼
                                    _pGatheringUcCtlEntity.VALUES = decimal.Parse(val[2].ToString()); //센서 수집 데이터( 형변환 문의)
                                    Add_ListView(strSTR, "");
                                    Message_Log(strSTR, true, true);
                                    bool isError = false;

                                    #region @ MinMax 값 확인
                                    //data 설정값
                                    for (int z = 0; z < _dtMN.Rows.Count; z++)
                                    {
                                        //iotcode 값 같은 것을 설정
                                        if (_dtMN.Rows[z]["iot_code"].ToString() == _pGatheringUcCtlEntity.RESOURCE_SERVER)
                                        {
                                            min1 = _dtMN.Rows[z]["resource_min_1"].ToString();
                                            min2 = _dtMN.Rows[z]["resource_min_2"].ToString();
                                            min3 = _dtMN.Rows[z]["resource_min_3"].ToString();
                                            min4 = _dtMN.Rows[z]["resource_min_4"].ToString();
                                            min5 = _dtMN.Rows[z]["resource_min_5"].ToString();
                                            max1 = _dtMN.Rows[z]["resource_max_1"].ToString();
                                            max2 = _dtMN.Rows[z]["resource_max_2"].ToString();
                                            max3 = _dtMN.Rows[z]["resource_max_3"].ToString();
                                            max4 = _dtMN.Rows[z]["resource_max_4"].ToString();
                                            max5 = _dtMN.Rows[z]["resource_max_5"].ToString();

                                            minmaxcheck = _ruledata(min1, min2, min3, min4, min5, max1, max2, max3, max4, max5);

                                            if (minmaxcheck)
                                            {
                                                new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);
                                            }
                                            else
                                            {
                                                isError = new GatheringUcCtlBusiness().DQ_Data_Trash_Save(_pGatheringUcCtlEntity);
                                            }

                                        }
                                        else
                                        {
                                            new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);
                                        }
                                    }
                                    #endregion
                                    //isError = new GatheringUcCtlBusiness().DQ_Data_Save(_pGatheringUcCtlEntity);

                                    //if (isError)
                                    //{
                                    //    //에러
                                    //}
                                    //else
                                    //{
                                    //    //정상 처리
                                    //}
                                }
                                else
                                {
                                    //   Message_Log("Data Length Error", true, true);
                                }

                            }
                        }
                    }
                    else  //데이터 오류
                    {
                        // Message_Log("Data Error", true, true);
                    }

                }
            }
            catch (Exception ex)
            {

            }


        }

        // ■ TCP 연결

        #region ○ Server_Open TCP/IP 연결 서버 오픈
        private void Server_Open()
        {
            if (!isServerOpen)
            {	//서버시작
                try
                {
                    _pCoFASSocketServer.Start();
                    isServerOpen = true;
                }
                catch (Exception pException)
                {
                }
            }
            else
            {
                try
                {
                    _pCoFASSocketServer.Stop();
                    isServerOpen = false;
                }
                catch (Exception pException)
                {

                }
            }
        }
        #endregion

        #endregion


        void SetupView()
        {
            try
            {
                // Setup tiles options
                tileView1.BeginUpdate();
                tileView1.OptionsTiles.RowCount = 3;
                tileView1.OptionsTiles.ItemPadding = new Padding(10);
                tileView1.OptionsTiles.IndentBetweenItems = 20;

                tileView1.OptionsTiles.ItemSize = new Size(220, 200);
                tileView1.Appearance.ItemNormal.ForeColor = Color.White;
                tileView1.Appearance.ItemNormal.BorderColor = Color.Transparent;
                //Setup tiles template
                TileViewItemElement leftPanel = new TileViewItemElement();
                TileViewItemElement splitLine = new TileViewItemElement();
                TileViewItemElement addressCaption = new TileViewItemElement();
                TileViewItemElement addressValue = new TileViewItemElement();
                TileViewItemElement yearBuiltCaption = new TileViewItemElement();
                TileViewItemElement yearBuiltValue = new TileViewItemElement();
                TileViewItemElement connect = new TileViewItemElement();
                //  TileViewItemElement image = new TileViewItemElement();
                tileView1.TileTemplate.Add(leftPanel);
                tileView1.TileTemplate.Add(splitLine);
                tileView1.TileTemplate.Add(addressCaption);
                tileView1.TileTemplate.Add(addressValue);
                tileView1.TileTemplate.Add(yearBuiltCaption);
                tileView1.TileTemplate.Add(yearBuiltValue);
                tileView1.TileTemplate.Add(connect);
                //  tileView1.TileTemplate.Add(image);
                //126, 328
                leftPanel.StretchVertical = true;
                leftPanel.Width = 122;
                leftPanel.TextLocation = new Point(-10, 0);
                leftPanel.Appearance.Normal.BackColor = Color.FromArgb(58, 166, 101);
                //
                splitLine.StretchVertical = true;
                splitLine.Width = 3;
                splitLine.TextAlignment = TileItemContentAlignment.Manual;
                splitLine.TextLocation = new Point(130, 0);
                splitLine.Appearance.Normal.BackColor = Color.White;
                //
                addressCaption.Text = "ADDRESS";
                addressCaption.TextAlignment = TileItemContentAlignment.TopLeft;
                addressCaption.Appearance.Normal.FontSizeDelta = -1;
                //
                addressValue.Column = tileView1.Columns["RESOURCE_IP"];
                addressValue.AnchorElement = addressCaption;
                addressValue.AnchorIndent = 2;
                addressValue.MaxWidth = 100;
                addressValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                //
                yearBuiltCaption.Text = "PORT";
                yearBuiltCaption.AnchorElement = addressValue;
                yearBuiltCaption.AnchorIndent = 10;
                yearBuiltCaption.Appearance.Normal.FontSizeDelta = -1;
                //
                yearBuiltValue.Column = tileView1.Columns["RESOURCE_PORT"];
                yearBuiltValue.AnchorElement = yearBuiltCaption;
                yearBuiltValue.AnchorIndent = 2;
                yearBuiltValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                //
                connect.Column = tileView1.Columns["SETTING_YN"];
                connect.TextAlignment = TileItemContentAlignment.BottomLeft;
                connect.Appearance.Normal.Font = new Font("Segoe UI Semilight", 25.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                //image.Column = tileView1.Columns["Image"];
                //image.ImageSize = new Size(210, 200);
                //image.ImageAlignment = TileItemContentAlignment.Default;

                //image.ImageScaleMode = TileItemImageScaleMode.StretchHorizontal;
                //image.ImageLocation = new Point(58, 0);
            }
            finally
            {
                tileView1.EndUpdate();
            }
        }

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new GatheringUcCtlBusiness().Gathering_Binding_Mst(_pGatheringUcCtlEntity);  // 센서 세팅 데이터
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                //_gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        #region ○ Ping Test
        public void SimplePing()  //핑테스트
        {

            try
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(_pGatheringUcCtlEntity.RESOURCE_IP);

                if (reply.Status == IPStatus.Success) //핑이 제대로 들어가고 있을 경우
                {
                    // tcp 통신 시작
                    ModBusTcp_Connect();
                }
                else //핑이 제대로 들어가지 않고 있을 경우 
                {
                    //1분 타이머 후 핑 테스트 
                    //Console.WriteLine(reply.Status);
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region ○ Modbus TCP
        private void MBT_OnResponseData(ushort ID, byte unit, byte function, byte[] values)
        {
            // ------------------------------------------------------------------
            // Seperate calling threads
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new ModbusTCP.Master.ResponseData(MBT_OnResponseData), new object[] { ID, unit, function, values });
                return;
            }

            data = values;
        }

        private void MBT_OnException(ushort id, byte unit, byte function, byte exception)
        {
            string exc = "Modbus error: ";
            switch (exception)
            {
                case ModbusTCP.Master.excIllegalFunction: exc += "Illegal function!"; break;
                case ModbusTCP.Master.excIllegalDataAdr: exc += "Illegal data adress!"; break;
                case ModbusTCP.Master.excIllegalDataVal: exc += "Illegal data value!"; break;
                case ModbusTCP.Master.excSlaveDeviceFailure: exc += "Slave device failure!"; break;
                case ModbusTCP.Master.excAck: exc += "Acknoledge!"; break;
                case ModbusTCP.Master.excGatePathUnavailable: exc += "Gateway path unavailbale!"; break;
                case ModbusTCP.Master.excExceptionTimeout: exc += "Slave timed out!"; break;
                case ModbusTCP.Master.excExceptionConnectionLost: exc += "Connection is lost!"; break;
                case ModbusTCP.Master.excExceptionNotConnected: exc += "Not connected!"; break;
            }

            // MessageBox.Show(exc, "Modbus slave exception");
        }
        #endregion

        #region ○ Modbus TCP Timer
        private void WorkTimer(object obj)  //시작과 동시에 핑테스트
        {
            try
            {
                SimplePing();
            }
            catch (Exception ex)
            {

            }

        }
        #endregion


        #region ○ Q-Light 경광등 Timer
        private void AlarmTimer(object obj)  //시작과 동시에 핑테스트
        {
            try
            {
                _tmrAlarm.Change(Timeout.Infinite, Timeout.Infinite);
                _dtalarm = new GatheringUcCtlBusiness().Gathering_Alarm_Mst(_pGatheringUcCtlEntity);  // 경광등 알람 데이터 

                for (int i = 0; i < _dtalarm.Rows.Count; i++)
                {
                    unsafe
                    {
                        //10초 후 프로시저 조회 (Status에 설정된 데이터가 초과 되면 화면에 표시)
                        const byte D_not = 100;            // Don't care  // Do not change before state
                        const byte C_lampoff = 0;
                        const byte C_lampon = 1;
                        const byte C_lampblink = 2;

                        bool b_chk = false;
                        int iPort = 0;
                        byte* c_pIdata = stackalloc byte[10];
                        byte* c_pIpadd = stackalloc byte[6];

                        c_pIdata[0] = 1;        // 1-write  0-read
                        c_pIdata[1] = 0;
                        //sound 25ea model group select   0-4:
                        //c_pIdata[1]  = 3;	

                        switch (_dtalarm.Rows[i]["alarm_level"].ToString())
                        {
                            case "0":
                                c_pIdata[2] = C_lampoff;         // lamp1 RED
                                c_pIdata[3] = C_lampoff;        // lamp2 Yellow
                                c_pIdata[4] = C_lampon;        // lamp3 Green
                                c_pIdata[5] = C_lampon;         // lamp4 Blue
                                c_pIdata[6] = C_lampoff;        // lamp4 White
                                c_pIdata[7] = 0;                // so   0 소리OFF /  1 단음 띠~띠 / 2 띠~띠띠
                                break;
                            case "1":
                                c_pIdata[2] = C_lampoff;         // lamp1 RED
                                c_pIdata[3] = C_lampon;        // lamp2 Yellow
                                c_pIdata[4] = C_lampoff;        // lamp3 Green
                                c_pIdata[5] = C_lampoff;            // lamp4 Blue
                                c_pIdata[6] = C_lampoff;        // lamp4 White
                                c_pIdata[7] = 1;                // so   0 소리OFF /  1 단음 띠~띠 / 2 띠~띠띠
                                break;
                            case "2":
                                c_pIdata[2] = C_lampon;         // lamp1 RED
                                c_pIdata[3] = C_lampoff;        // lamp2 Yellow
                                c_pIdata[4] = C_lampoff;        // lamp3 Green
                                c_pIdata[5] = C_lampoff;            // lamp4 Blue
                                c_pIdata[6] = C_lampoff;        // lamp4 White
                                c_pIdata[7] = 2;                // so   0 소리OFF /  1 단음 띠~띠 / 2 띠~띠띠
                                break;
                        }

                        string[] _ip = _dtalarm.Rows[i]["routing_ip"].ToString().Split('.');
                        iPort = int.Parse(_dtalarm.Rows[i]["routing_port"].ToString());
                        if (_ip.Length == 4) //IP 주소는 4개로 구성되어야 함.
                        {
                            c_pIpadd[0] = byte.Parse(_ip[0].ToString());
                            c_pIpadd[1] = byte.Parse(_ip[1].ToString());
                            c_pIpadd[2] = byte.Parse(_ip[2].ToString());
                            c_pIpadd[3] = byte.Parse(_ip[3].ToString());
                        }
                        else
                        {
                            _tmrAlarm.Change(int.Parse("10") * 1000, int.Parse("10") * 1000);
                            Message_Log("check your IP adress: " + _dtalarm.Rows[i]["routing_ip"].ToString(), true, true);
                            break;
                        }
                        b_chk = Tcp_Qu_RW(iPort, c_pIpadd, c_pIdata);
                        if (_dtalarm.Rows[i]["alarm_level"].ToString() != "0")
                        {
                            limecolor = true;
                            Add_ListView(_dtalarm.Rows[i]["routing_ip"].ToString() + "|" + _dtalarm.Rows[i]["routing_mst_code"].ToString() + "|" + _dtalarm.Rows[i]["alarm_level"].ToString(), _dtalarm.Rows[i]["alarm_level"].ToString());
                        }
                        else
                        {
                            if(limecolor == true && _dtalarm.Rows[i]["alarm_level"].ToString() =="0")  //값이 바뀐거.. 비정상이었다가 정상으로
                            {
                                Add_ListView(_dtalarm.Rows[i]["routing_ip"].ToString() + "|" + _dtalarm.Rows[i]["routing_mst_code"].ToString() + "|" + _dtalarm.Rows[i]["alarm_level"].ToString(), _dtalarm.Rows[i]["alarm_level"].ToString());
                                limecolor = false;
                            }
                        }
                    }
                    _tmrAlarm.Change(int.Parse("10") * 1000, int.Parse("10") * 1000);
                }
            }
            catch (Exception ex)
            {
                _tmrAlarm.Change(int.Parse("10") * 1000, int.Parse("10") * 1000);
            }

        }
        #endregion

        #region ○ Q-Light 경광등 Timer
        private void ClinetTimer(object obj)  //시작과 동시에 핑테스트
        {
            try
            {
                _tmrStart.Change(Timeout.Infinite, Timeout.Infinite);
                _pCoFASSocketClinet.Send("START");
            }
            catch (Exception ex)
            {

            }

        }
        #endregion

        #region ○ Modbus TCP 연결
        private void ModBusTcp_Connect()
        {
            try
            {
                if (MBT != null)
                {
                    if (MBT.connected)
                    {
                        MBT.Dispose();
                        MBT = new ModbusTCP.Master(_pGatheringUcCtlEntity.RESOURCE_IP, ushort.Parse(_pGatheringUcCtlEntity.RESOURCE_PORT));

                        MBT.OnResponseData += new ModbusTCP.Master.ResponseData(MBT_OnResponseData);
                        MBT.OnException += new ModbusTCP.Master.ExceptionData(MBT_OnException);

                        Read_Data();
                        //CoFASControl.Invoke_PictureBox_Image(_picBox, Properties.Resources.Ok);  색 변경
                        //Message_Log("Network Connected...", false, true);  로그
                        //_tmrWork.Change(int.Parse(strTimerInterval) * 1000, int.Parse(strTimerInterval) * 1000); 타이머
                        //isStop = false; 플레그
                        //isWorkCheck = false; 플레그
                    }
                }
                else
                {
                    MBT = new ModbusTCP.Master(_pGatheringUcCtlEntity.RESOURCE_IP, ushort.Parse(_pGatheringUcCtlEntity.RESOURCE_PORT));
                    MBT.OnResponseData += new ModbusTCP.Master.ResponseData(MBT_OnResponseData);
                    MBT.OnException += new ModbusTCP.Master.ExceptionData(MBT_OnException);

                    Read_Data();

                    //CoFASControl.Invoke_PictureBox_Image(_picBox, Properties.Resources.Ok);  색 변경
                    //Message_Log("Network Connected...", false, true);  로그
                    //_tmrWork.Change(int.Parse(strTimerInterval) * 1000, int.Parse(strTimerInterval) * 1000); 타이머
                    //isStop = false; 플레그
                    //isWorkCheck = false; 플레그
                }
            }
            catch (Exception error)
            {
                // MessageBox.Show(error.Message);
            }
        }

        #endregion

        #region ○ Modbus TCP Send
        private void Read_Data()
        {
            try
            {
                _tmrWork.Change(Timeout.Infinite, Timeout.Infinite);  //타이머 정지
                string text = System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");

                if (MBT == null || !MBT.connected)
                {
                    //CoFASControl.Invoke_PictureBox_Image(_picBox, Properties.Resources.Ng); 색변경
                    //Message_Log("Network Disconnect...", false, true); 로그
                    //isWorkCheck = false; 플래그
                    // _tmrWork.Change(int.Parse(strTimerInterval) * 1000, Timeout.Infinite);  // 타이머 재시작 
                    return;
                }

                byte[] byteresult = new byte[1];

                //그룹별 스타트 위치 지정 4496
                //for (int b = 1; b <= int.Parse(strGroup); b++)
                //{

                //    ushort StartAddress = Convert.ToUInt16(Group_Return_Data(b.ToString()));

                //    object Result = null;

                //    // 검침기 ID  값 표시
                //    MBT.ReadHoldingRegister(Convert.ToUInt16(strID), Convert.ToByte("1"), StartAddress, Convert.ToUInt16("46"), ref byteresult);


                //    if (MBT.AddressReti.ToString() == "1")  //4496 이면 StartAddress
                //    {

                //    }
                //    //object   Result = MBT.ByteToData(byteresult);

                //    if (byteresult != null)
                //    {
                //        Result = MBT.ByteToData(byteresult);

                //        //Message_Log("리시브 데이터 총 길이 :  " + byteresult.Length.ToString(), true, true);
                //        if (Result != null && (Result as Array).Length == 23)
                //        {
                //            DataTable StackData = new DataTable();

                //            for (int i = 0; i < (Result as Array).Length; i++)
                //            {
                //                StackData.Columns.Add(("col" + i), typeof(string));
                //            }

                //            DataRow temprow = StackData.NewRow();

                //            //Message_Log("receive_data ", true, true);
                //            for (int i = 0; i < (Result as Array).Length; i++)
                //            {
                //                temprow["col" + i] = (Result as Array).GetValue(i).ToString();
                //            }

                //            StackData.Rows.Add(temprow);

                //            CoFASControl.Invoke_ListView_AddItemString(_lvData, false, new string[] { strID + "|" + b.ToString(), StackData.Rows[0][3].ToString().Trim(), StackData.Rows[0][1].ToString().Trim(), StackData.Rows[0][5].ToString().Trim() }, true, 50);

                //            _DataMessage = "[전압 :" + StackData.Rows[0][1].ToString().Trim() + " ]" +
                //                           "[전류 :" + StackData.Rows[0][3].ToString().Trim() + " ]" +
                //                           "[역률 :" + StackData.Rows[0][7].ToString().Trim() + " ]" +
                //                           "[유효전력량 : " + StackData.Rows[0][5].ToString().Trim() + " ]" +
                //                           "[누적 전력 :" + StackData.Rows[0][17].ToString().Trim() + " ]" +
                //                           "[월간 누적 전력 :" + StackData.Rows[0][19].ToString().Trim() + " ]";

                //            Message_Log(_DataMessage, true, true);
                //            DB_Insert(StackData, strID, b.ToString()); //임시 주석 20160630 해제해야해
                //        }
                //        else
                //        {
                //            Message_Log(Result.ToString() + "구분", true, false);
                //        }
                //    }
                //    else
                //    {
                //        btnBox01_Click(null, null);
                //    }
                //    Thread.Sleep(500);
                //}

                //다 돌면 타이머 생성
                //  _tmrWork.Change(int.Parse(strTimerInterval) * 1000, int.Parse(strTimerInterval) * 1000);
            }
            catch (Exception ex)
            {
                //Message_Log(ex.ToString(), true, false);
                //MBT.Dispose();
                //MBT = null;
                //isWorkCheck = false;
                //string text = System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
                //_pCoFASLog.WLog("ex read " + ex.ToString() + text);
            }
        }
        #endregion


        // ■ 메세지 처리
        #region ○ 메세지 처리
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strMessage">메세지 표시</param>
        /// <param name="isLog">로그 저장 유무</param>
        /// <param name="isView">화면 표시 유무</param>
        private void Message_Log(string strMessage, bool isLog, bool isView)
        {
            DateTime dt = DateTime.Now;

            _pMessage = string.Format("[{0}:{1}:{2}] {3}\r\n", dt.ToString("HH"), dt.ToString("mm"), dt.ToString("ss"), strMessage);

            if (isView)
            {
            }

            if (isLog)
            {
                _pCoFASLog.WLog(_pMessage);
            }
        }
        #endregion

        private void _gdMAIN_Click(object sender, EventArgs e)  //클릭하면 설정 팝업 및 데이터 조회
        {
            //frmGatherSetting _fGS = new frmGatherSetting("리소스");
            //_fGS.ShowDialog();
        }

        // ■ 리스트 뷰 추가
        #region ○ 리스트 뷰 추가
        public void Add_ListView(string strMsg, string color)
        {
            try
            {
                string strDate = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTimeShort);

                string[] stritem = new string[] { strDate, strMsg };//, strLine };

                CoFAS_ControlManager.InvokeIfNeeded(USAList, () =>
                {
                    ListViewItem li = new ListViewItem(stritem);

                    USAList.Items.Insert(0, li);

                    switch (color)
                    {
                        case "1": // Yellow
                            USAList.ForeColor = Color.Yellow;
                            break;
                        case "2": // Red
                            USAList.ForeColor = Color.Red;
                            break;
                        default:
                            USAList.ForeColor = Color.Lime;
                            break;
                    }


                    while (USAList.Items.Count > 9)  //화면 리스트 표시때문에 
                    {
                        int intIndex = 0;
                        intIndex = USAList.Items.Count - 1;
                        CoFAS_ControlManager.InvokeIfNeeded(USAList, () => USAList.Items.RemoveAt(intIndex));
                    };
                }
                );


            }
            catch (Exception ex)
            {
            }
        }
        #endregion


        private bool _ruledata(string min1, string min2, string min3, string min4, string min5, string max1, string max2, string max3, string max4, string max5)
        {
            bool minmaxcheck = false;
            #region
            if (min1 == "" && max1 == "")
            {
                //일반 룰
                minmaxcheck = true;
            
                //DATA SAVE logic

            }
            else  // 룰 생성된 데이터
            {

                if (min1 != "" && !minmaxcheck)
                {
                    if (_pGatheringUcCtlEntity.VALUES >= Convert.ToDecimal(min1))
                    {
                        if (max1 != "")
                        {
                            if (_pGatheringUcCtlEntity.VALUES >= Convert.ToDecimal(min1) && _pGatheringUcCtlEntity.VALUES <= Convert.ToDecimal(max1))
                            {
                                minmaxcheck = true;
                            }
                            else
                            {
                                minmaxcheck = false;
                            }
                        }
                        else
                        {
                            minmaxcheck = true;
                        }
                    }
                    else
                    {
                        minmaxcheck = false;
                    }
                }
                else
                {
                    if (max1 != "" && !minmaxcheck)
                    {
                        if (_pGatheringUcCtlEntity.VALUES <= Convert.ToDecimal(max1))
                        {
                            minmaxcheck = true;
                        }
                        else
                        {
                            minmaxcheck = false;
                        }
                    }
                    else
                    {
                        if (!minmaxcheck)
                            minmaxcheck = false;
                    }
                }

                if (min2 != "" && !minmaxcheck)
                {
                    if (_pGatheringUcCtlEntity.VALUES >= Convert.ToDecimal(min2))
                    {
                        if (max2 != "")
                        {
                            if (_pGatheringUcCtlEntity.VALUES >= Convert.ToDecimal(min2) && _pGatheringUcCtlEntity.VALUES <= Convert.ToDecimal(max2))
                            {
                                minmaxcheck = true;
                            }
                            else
                            {
                                minmaxcheck = false;
                            }
                        }
                        else
                        {
                            minmaxcheck = true;
                        }
                    }
                    else
                    {
                        minmaxcheck = false;
                    }
                }
                else
                {
                    if (max2 != "" && !minmaxcheck)
                    {
                        if (_pGatheringUcCtlEntity.VALUES <= Convert.ToDecimal(max2))
                        {
                            minmaxcheck = true;
                        }
                        else
                        {
                            minmaxcheck = false;
                        }
                    }
                    else
                    {
                        if (!minmaxcheck)
                            minmaxcheck = false;
                    }
                }

                if (min3 != "" && !minmaxcheck)
                {
                    if (_pGatheringUcCtlEntity.VALUES >= Convert.ToDecimal(min3))
                    {
                        if (max3 != "")
                        {
                            if (_pGatheringUcCtlEntity.VALUES >= Convert.ToDecimal(min3) && _pGatheringUcCtlEntity.VALUES <= Convert.ToDecimal(max3))
                            {
                                minmaxcheck = true;
                            }
                            else
                            {
                                minmaxcheck = false;
                            }
                        }
                        else
                        {
                            minmaxcheck = true;
                        }
                    }
                    else
                    {
                        minmaxcheck = false;
                    }
                }
                else
                {
                    if (max3 != "" && !minmaxcheck)
                    {
                        if (_pGatheringUcCtlEntity.VALUES <= Convert.ToDecimal(max3))
                        {
                            minmaxcheck = true;
                        }
                        else
                        {
                            minmaxcheck = false;
                        }
                    }
                    else
                    {
                        if (!minmaxcheck)
                            minmaxcheck = false;
                    }
                }

                if (min4 != "" && !minmaxcheck)
                {
                    if (_pGatheringUcCtlEntity.VALUES >= Convert.ToDecimal(min4))
                    {
                        if (max4 != "")
                        {
                            if (_pGatheringUcCtlEntity.VALUES >= Convert.ToDecimal(min4) && _pGatheringUcCtlEntity.VALUES <= Convert.ToDecimal(max4))
                            {
                                minmaxcheck = true;
                            }
                            else
                            {
                                minmaxcheck = false;
                            }
                        }
                        else
                        {
                            minmaxcheck = true;
                        }
                    }
                    else
                    {
                            minmaxcheck = false;
                    }
                }
                else
                {
                    if (max4 != "" && !minmaxcheck)
                    {
                        if (_pGatheringUcCtlEntity.VALUES <= Convert.ToDecimal(max4))
                        {
                            minmaxcheck = true;
                        }
                        else
                        {
                            minmaxcheck = false;
                        }
                    }
                    else
                    {
                        if(!minmaxcheck)
                        minmaxcheck = false;
                    }
                }

                if (min5 != "" && !minmaxcheck)
                {
                    if (_pGatheringUcCtlEntity.VALUES >= Convert.ToDecimal(min5))
                    {
                        if (max5 != "")
                        {
                            if (_pGatheringUcCtlEntity.VALUES >= Convert.ToDecimal(min5) && _pGatheringUcCtlEntity.VALUES <= Convert.ToDecimal(max5))
                            {
                                minmaxcheck = true;
                            }
                            else
                            {
                                minmaxcheck = false;
                            }
                        }
                        else
                        {
                            minmaxcheck = true;
                        }
                    }
                    else
                    {
                        if (!minmaxcheck)
                            minmaxcheck = false;
                    }
                }
                else
                {
                    if (max5 != "" && !minmaxcheck)
                    {
                        if (_pGatheringUcCtlEntity.VALUES <= Convert.ToDecimal(max5))
                        {
                            minmaxcheck = true;
                        }
                        else
                        {
                            minmaxcheck = false;
                        }
                    }
                    else
                    {
                        if (!minmaxcheck)
                            minmaxcheck = false;
                    }
                }


                #endregion
            }
            return minmaxcheck;
        }
    }
}
