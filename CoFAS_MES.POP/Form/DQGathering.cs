using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Function;
using System.Net.Sockets;
using System.Net;
using System.Threading;

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;

namespace CoFAS_MES.POP
{
    public partial class DQGathering : frmBasePOP
    {

        public string _pCORP_CDDE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정

        private DQGatheringEntity _pDQGatheringEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        private CoFAS_SocketServer _pCoFAS_SocketServer = null;
        Dictionary<Socket, byte[]> dicBuffer = new Dictionary<Socket, byte[]>();
        Dictionary<Socket, DateTime> dicBufferTime = new Dictionary<Socket, DateTime>();

        private byte[] bytEnd = new byte[] { 0x2C };


        private CoFAS_Serial _pCoFAS_Serial = null; //시리얼 통신

        private Queue<string> DataQueue = new Queue<string>();
        private Thread DataQueueThread = null;
        private bool isRunDataQueueThread = true;
        private AutoResetEvent DataQueueThreadEvent = new AutoResetEvent(false);


        private CoFAS_Log _pCoFAS_Log = new CoFAS_Log(Application.StartupPath + "//LOG", "", 30, true);

        private string str = "";
        private byte[] btArry = new byte[16];

        private byte[] btArryAll = new byte[] { 0x01, 0x03, 0x00, 0x03, 0x00, 0x12, 0x35, 0xC7 }; //전체

        private byte[] btArryOneDay = new byte[] { 0x01, 0x03, 0x07, 0xD0, 0x00, 0x23, 0x04, 0x9E }; //전체

        private byte[] btValue = new byte[] { 0x01, 0x03, 0x00, 0x00, 0x00, 0x03, 0x05, 0xCB }; //환산 측정부피
        private byte[] btValue1 = new byte[] { 0x01, 0x03, 0x00, 0x03, 0x00, 0x04, 0xB4, 0x09 }; //환산 측정부피
        private byte[] btValue2 = new byte[] { 0x01, 0x03, 0x00, 0x07, 0x00, 0x02, 0x75, 0xCA }; //측정 부피
        private byte[] btValue3 = new byte[] { 0x01, 0x03, 0x00, 0x09, 0x00, 0x02, 0x14, 0x09 }; //측정 압력
        private byte[] btValue4 = new byte[] { 0x01, 0x03, 0x00, 0x0B, 0x00, 0x02, 0xB5, 0xC9 }; //측정 온도
        private byte[] btValue5 = new byte[] { 0x01, 0x03, 0x00, 0x0D, 0x00, 0x02, 0x55, 0xC8 }; //측정 유량
        private byte[] btValue6 = new byte[] { 0x01, 0x03, 0x00, 0x0F, 0x00, 0x02, 0xF4, 0x08 }; //환산 측정유량


        public DQGathering()
        {
            InitializeComponent();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        //폼 이벤트 처리 영역
        #region ○ Form_Activated
        private void Form_Activated(object pSender, EventArgs pEventArgs)
        {
            try
            {

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }
        #endregion

        #region ○ Form_Closing

        private void Form_Closing(object pSender, FormClosingEventArgs pFormClosingEventArgs)
        {
            try
            {

                if (_pCoFAS_SocketServer != null)
                {
                    _pCoFAS_SocketServer.Stop();
                }
                    //그리드 작업 정보 확인 하기
                //if (_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                //{
                //    if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
                //    {
                //        pFormClosingEventArgs.Cancel = true;
                //        return;
                //    }
                //}
                pFormClosingEventArgs.Cancel = false;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));

            }
        }

        #endregion

        #region ○ Form_FormClosed

        private void Form_FormClosed(object pSender, FormClosedEventArgs pFormClosedEventArgs)
        {
            try
            {
                //화면 레이아웃 저장 ?
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }

        #endregion

        #region ○ Form_Load
        private void Form_Load(object pSender, EventArgs pEventArgs)
        {
            try
            {
                
               
                Initialize();
                InitializeSetting();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }
        #endregion

        // 초기화 처리 영역
        private void Initialize()
        {
            try
            {
                switch (Properties.Settings.Default.DB_ID.ToString())
                {
                    case "MySql":
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.SQLServer;
                        break;
                    case "SQLServer":
                        DBManager.PrimaryDBManagerType = DBManagerType.SQLServer;//.SQLServer;
                        break;
                    default:
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.SQLServer;
                        break;
                }

                DBManager.PrimaryConnectionString = string.Format
               (
                   //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                   "Server={0};Database={1};UID={2};PWD={3}",
                   Properties.Settings.Default.SERVER_IP.ToString(),
                   Properties.Settings.Default.DB_NAME.ToString(),
                   Properties.Settings.Default.DB_ID.ToString(),
                   "0we11Passw0rd!@#dbmes"
               );

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Initialize()", pException);
            }
        }

        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
                _pnRight.Visible = false;

                //메인 화면 전역 변수 처리
                _pCORP_CDDE = "9999999999";//MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = "admin@coever.co.kr";// MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = "";//MainForm.UserEntity.USER_NAME;
                //_pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                //_pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;

                _pWINDOW_NAME = this.Name;

                _lbTitle.Text = "Gateway Program";
                _lbHeader.Text = "";
                DisplayMessage("");


                //메뉴 화면 엔티티 설정
                _pDQGatheringEntity = new DQGatheringEntity();
                _pDQGatheringEntity.CORP_CODE = _pCORP_CDDE;
                _pDQGatheringEntity.USER_CODE = _pUSER_CODE;

                //화면 설정 언어 & 명칭 변경. ==고정==
                //DataTable dtLanguage = new LanguageBusiness().Language_Info(_pCORP_CDDE, _pWINDOW_NAME, _pLANGUAGE_TYPE);

                //if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                //{
                //    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                //}
                //화면 설정 언어 & 명칭 변경. ==고정==


                //그리드 설정

                //   double ddd = Math.Acos(0.912);

          

                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {

                    _pFirstYN = false;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }

        #endregion

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl()
        {
            try
            {
              

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {

                }

                ucTextEdit1.Text = "127.0.0.1";
                ucTextEdit2.Text = "8704";

                //_pCoFAS_Log = new CoFAS_Log(Application.StartupPath+"\\Log",)

                StartQueueThread();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {

            }
        }

        #endregion

        bool isWorkData = true;
        private void Serial_Data(byte[] data)
        {

            if (data.Length < 2)
            {

                return;
            }



            if (isWorkData)
            {
                isWorkData = false;

                string strData = "";

                double d1 = 32768; //고정
                double d2 = 65535; //고정
                double d3 = 16485; //설정 값 나누기 20181016 사용 안함.
                double d4 = 0.048; //설정 값 빼기 20181016 사용 안함.

                //string decimalNumber = "32768";
                //int number = int.Parse(decimalNumber);
                //string hex = number.ToString("x");


                string strHex = "";
                string strDec = "";

                string strXHex = "";
                string strXDec = "";

                string strYHex = "";
                string strYDec = "";

                double dm1 = 0;
                double dm1X = 0;
                double dm1Y = 0;

                double dm2 = 0;
                double dm2X = 0;
                double dm2Y = 0;

                double dm3 = 0; //각도 값
                double dm3X = 0; //각도 값
                double dm3Y = 0; //각도 값

                double dm4 = 0; //백분율
                double dm4X = 0; //백분율
                double dm4Y = 0; //백분율



                string strSign = ""; //변위 부호

                double dbDisplacement = 0; //변위 값

                string strMesage = "";


                switch (data[3].ToString())
                {
                    case "48":

                        strXHex = int.Parse(data[5].ToString()).ToString("x").PadLeft(2, '0') + int.Parse(data[6].ToString()).ToString("x").PadLeft(2,'0');
                        strXDec = Convert.ToInt32(strXHex, 16).ToString();
                        dm1X = double.Parse(strXDec);

                        strYHex = int.Parse(data[8].ToString()).ToString("x").PadLeft(2, '0') + int.Parse(data[9].ToString()).ToString("x").PadLeft(2, '0');
                        strYDec = Convert.ToInt32(strYHex, 16).ToString();
                        dm1Y = double.Parse(strYDec);

                        break;

                    case "49":

                        strHex = int.Parse(data[5].ToString()).ToString("x").PadLeft(2, '0') + int.Parse(data[6].ToString()).ToString("x").PadLeft(2, '0');
                        strDec = Convert.ToInt32(strHex, 16).ToString();
                        dm1 = double.Parse(strDec);

                        break;
                }


                //strHex = int.Parse(data[5].ToString()).ToString("x") + int.Parse(data[6].ToString()).ToString("x");

                //strDec = Convert.ToInt32(strHex, 16).ToString();

                //double dm1 = double.Parse(strDec);

                //double dm2 = 0;

                //double dm3 = 0; //각도 값

                //double dm4 = 0; //백분율

                //string strSign = ""; //변위 부호

                //double dbDisplacement = 0; //변위 값

                //string strMesage = "";

                string strTime = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTime).Replace("-", "").Replace(" ", "").Replace(":", "");

                switch (data[3].ToString())
                {

                    case "48": //행거 X , Y

                        strMesage = "";

                        /*
                        if (dm1 > d1)
                        {
                            double _dm2 = 0;
                            _dm2 = (dm1 - d2);

                            //((4.147 * (Math.Pow(10, -13)) * (Math.Pow(_dm2, 3))) + (-1.764 * (Math.Pow(10, -10)) * (Math.Pow(_dm2, 2))) + (5.577 * (Math.Pow(10, -4)) * (_dm2)) + 1.845);

                            if (_dm2 < 0)
                            {
                                dm2 = ((2.516 * (Math.Pow(10, -13)) * (Math.Pow(_dm2, 3))) + (4.248 * (Math.Pow(10, -9)) * (Math.Pow(_dm2, 2))) + (0.0005628 * _dm2) + 2.796);
                            }
                            else
                            {
                                dm2 = ((2.516 * (Math.Pow(10, -13)) * Math.Pow(_dm2, 3)) + (4.248 * (Math.Pow(10, -9)) * Math.Pow(_dm2, 2)) + (0.0005628 * _dm2) + 2.796);
                            }


                        }
                        else
                        {


                            dm2 = ((2.516 * (Math.Pow(10, -13)) * Math.Pow(dm1, 3)) + (4.248 * (Math.Pow(10, -9)) * Math.Pow(dm1, 2)) + (0.0005628 * dm1) + 2.796);
                        }

                        dm3 = Math.Round(dm2 * 10) + 2;
                        */

                        dm3X = (1.126 * (((dm1X * 4.9996) / 65536 - 2.341) / 0.075)) - 0.06351;

                        dm4X = 1550 * Math.Sin(dm3X * (3.14159 / 180)); // + 1550 * Math.Sin(dm3X * (3.14159 / 180)) * Math.Tan(dm3X / 2) * (3.14159 / 180) * Math.Tan(dm3X * (3.14159 / 180));


                        dm3Y = (1.126 * (((dm1Y * 4.9996) / 65536 - 2.5811) / 0.075)) - 0.06351;

                        dm4Y = 1100 * Math.Sin(dm3Y * (3.14159 / 180)); // + 1100 * Math.Sin(dm3Y * (3.14159 / 180 )) * Math.Tan(dm3Y / 2) * (3.14159 / 180) * Math.Tan(dm3Y * (3.14159 / 180));

                        //dm4Y = 1100 * Math.Sin(dm1Y) * (3.14 / 180) + 1100 * Math.Sin(dm1Y) * (3.14 / 180) * Math.Tan(dm1Y / 2) * (3.14 / 180) * Math.Tan(dm1) * (3.14 / 180);


                        strMesage = data[2].ToString().PadLeft(2, '0') + ":" + strTime + ":0000:1006:" + dm3X.ToString() + ":," + dm3Y.ToString() + ":,";

                        //  txt2XV.Text = dm3X.ToString();
                        // txt2XP.Text = "0";

                        CoFAS_ControlManager.InvokeIfNeeded(txt2XV, () => { txt2XV.Text = Math.Round(dm3X, 2).ToString(); });
                        CoFAS_ControlManager.InvokeIfNeeded(txt2XP, () => { txt2XP.Text = Math.Round(dm4X, 2).ToString(); });

                        //txt2YV.Text = dm3Y.ToString();
                        //txt2YP.Text = "0";


                        CoFAS_ControlManager.InvokeIfNeeded(txt2YV, () => { txt2YV.Text = Math.Round(dm3Y, 2).ToString(); });
                        CoFAS_ControlManager.InvokeIfNeeded(txt2YP, () => { txt2YP.Text = Math.Round(dm4Y, 2).ToString(); });

                        break;
                    case "49": //각도 변위

                        strMesage = "";

                        if (dm1 > d1)
                        {
                            //dm2 = ((dm1 - d2) / d3) - d4;
                            dm2 = (dm1 - d2);
                        }
                        else
                        {
                            //dm2 = (dm1 / d3) - d4;
                            dm2 = dm1;
                        }
                        dm4 = ((0.00061 * dm2) + 4.994) * 10;
                        //dm3 = Math.Asin(dm2) * (180 / 3.14); //각도 
                        dm3 = 30.5 - Math.Asin(dm2 / 16000) * (180 / 3.14); //각도 


                        strMesage = data[2].ToString().PadLeft(2, '0') + ":" + strTime + ":0000:1007:" + dm3.ToString() + ":," + dm4.ToString() + ":,";

                        // txt1V.Text = dm3.ToString();
                        // txt1P.Text = dm4.ToString();

                        CoFAS_ControlManager.InvokeIfNeeded(txt1V, () => { txt1V.Text = Math.Round(dm3).ToString(); });
                        CoFAS_ControlManager.InvokeIfNeeded(txt1P, () => { txt1P.Text = Math.Round(dm4) > 100 ? "100" : Math.Round(dm4).ToString(); });




                        //==================================================================================
                        /*
                        if (int.Parse(data[8].ToString()) != 0)
                        {
                            //음수
                            strSign = "-";
                        }

                        // 변경

                        string strBinary1 = (Convert.ToString(int.Parse(data[9].ToString()), 2)).PadLeft(8,'0');
                        string strTemp1 = "";

                        for(int a = 8; a > 0; a--)
                        {
                            strTemp1 += strBinary1[a-1];
                        }

                        //strTemp1 = new String(strBinary1.ToCharArray().Reverse().ToArray());

                        //strTemp1 = Convert.ToInt32(strTemp1, 2).ToString();

                        string strBinary2 = (Convert.ToString(int.Parse(data[10].ToString()), 2)).PadLeft(8,'0');
                        string strTemp2 = "";

                        for (int a = 8; a > 0; a--)
                        {
                            strTemp2 += strBinary2[a-1];
                        }

                        //strTemp2 = new String(strBinary2.ToCharArray().Reverse().ToArray());

                        //strTemp2 = Convert.ToInt32(strTemp2, 2).ToString();

                        string strTemp3 = "";
                        strTemp3 = strTemp1 + strTemp2;

                        double dbTemp = 0.0;

                        dbTemp = double.Parse(Convert.ToInt32(strTemp3, 2).ToString());



                        dbDisplacement = dbTemp / 100;

                        strMesage = strMesage + "03:" + strTime + ":0000:1007:" + strSign + dbDisplacement.ToString() + ":,";
                        */
                        break;
                    case "3": //행거 각도

                        strMesage = "";


                        if (dm1 > d1)
                        {
                            double _dm2 = 0;
                            _dm2 = (dm1 - d2);

                            //((4.147 * (Math.Pow(10, -13)) * (Math.Pow(_dm2, 3))) + (-1.764 * (Math.Pow(10, -10)) * (Math.Pow(_dm2, 2))) + (5.577 * (Math.Pow(10, -4)) * (_dm2)) + 1.845);

                            if (_dm2 < 0)
                            {
                                dm2 = ((2.516 * (Math.Pow(10, -13)) * (Math.Pow(_dm2, 3))) + (4.248 * (Math.Pow(10, -9)) * (Math.Pow(_dm2, 2))) + (0.0005628 * _dm2) + 2.796);
                            }
                            else
                            {
                                dm2 = ((2.516 * (Math.Pow(10, -13)) * Math.Pow(_dm2, 3)) + (4.248 * (Math.Pow(10, -9)) * Math.Pow(_dm2, 2)) + (0.0005628 * _dm2) + 2.796);
                            }


                        }
                        else
                        {


                            dm2 = ((2.516 * (Math.Pow(10, -13)) * Math.Pow(dm1, 3)) + (4.248 * (Math.Pow(10, -9)) * Math.Pow(dm1, 2)) + (0.0005628 * dm1) + 2.796);
                        }

                        dm3 = Math.Round(dm2 * 10) + 2;

                        strMesage = "10:" + strTime + ":0000:1006:" + dm3.ToString() + ":,";

                        break;

                }

                Add_ListView(strMesage, ""); //로그 데이터

                // string binary = Convert.ToString(128, 2);

                //strData = CoFAS_ConvertManager.Bytes2String(data,0,0);

                for (int a = 0; a < 11; a++)
                {
                    strData += data[a].ToString() + " ";
                }

                strData = "[ " + strData + " ] [";

                for (int b = 0; b < 11; b++)
                {
                    strData += int.Parse(data[b].ToString()).ToString("x") + " ";
                }

                strData = strData + " ] ";

                //foreach(byte bt in data)
                //{

                //}

                strData += "  [  " + dm3.ToString() + "     " + strSign + dbDisplacement.ToString() + "  ]  ";

                //strData = Encoding.UTF8.GetString(data, 0, data.Length - 1);

                Add_ListView(strData.ToUpper(), ""); //로그 데이터



                string[] strRData = new string[ProcGetStringcount(strMesage, ",")];

                if (strRData.Length <= 0) return;

                strRData = strMesage.Split(',');

                for (int a = 0; a < strRData.Length; a++)
                {
                    if (strRData[a].Length > 0)
                    {
                        // InsertQueueData(strRData[a]);
                    }
                }



                //string[] strHex = BitConverter.ToString(data, 3, 10).Split('-');

                //string strHex1 = CoFAS_ConvertManager.Hex2Double(strHex[0] + strHex[1] + strHex[2] + strHex[3] + strHex[4] + strHex[5] + strHex[6] + strHex[7]).ToString();


                //string strMsg = "";

                //strMsg += string.Format("환산 측정 부피 : {0} m3", strHex1);


                //Add_ListView("수신 : " + strMsg, "");

                //string str = Encoding.UTF8.GetString(data, 0, data.Length - 1);

                //str = CoFAS_ConvertManager.ByteArray2HexString(data, "");

                //Add_ListView("수신 : " + str, "");


                isWorkData = true;
            }
        }

        // ■ 리스트 뷰 추가
        #region ○ 리스트 뷰 추가
        public void Add_ListView(string strMsg, string strLine)
        {
            try
            {
                string strDate = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTimeShort);

                string[] stritem = new string[] { strDate, strMsg };//, strLine };

                CoFAS_ControlManager.InvokeIfNeeded(_lvLog, () =>
                                                                  {
                                                                      ListViewItem li = new ListViewItem(stritem);

                                                                      _lvLog.Items.Insert(0, li);

                                                                      while (_lvLog.Items.Count > 100)
                                                                      {
                                                                          int intIndex = 0;
                                                                          intIndex = _lvLog.Items.Count - 1;
                                                                          CoFAS_ControlManager.InvokeIfNeeded(_lvLog, () => _lvLog.Items.RemoveAt(intIndex));
                                                                      };

                                                                  }
                );


                _pCoFAS_Log.WLog(strMsg);
                
            }
            catch (Exception ex)
            {
            }
        }

        //public void Add_ListView2(string strMsg, string strLine)
        //{
        //    try
        //    {
        //        string strDate = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTimeShort);

        //        string[] stritem = new string[] { strDate, strMsg };//, strLine };

        //        CoFAS_ControlManager.InvokeIfNeeded(_lvLog2, () =>
        //        {
        //            ListViewItem li = new ListViewItem(stritem);

        //            _lvLog2.Items.Insert(0, li);

        //            while (_lvLog2.Items.Count > 100)
        //            {
        //                int intIndex = 0;
        //                intIndex = _lvLog.Items.Count - 1;
        //                CoFAS_ControlManager.InvokeIfNeeded(_lvLog2, () => _lvLog2.Items.RemoveAt(intIndex));
        //            };

        //        }
        //        );


        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Server_Open();
            DisplayMessage(string.Format("IP - {0} : {1} Open", ucTextEdit1.Text.ToString(), ucTextEdit2.Text.ToString()));

            //_pCoFAS_Serial = new CoFAS_Serial(textEdit1.Text.ToString(), 115200, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);

            //_pCoFAS_Serial.evtReceived += new CoFAS_Serial.delReceive(Serial_Data);

            //_pCoFAS_Serial.Open();



        }

        #region 스레드 생성
        private void StartQueueThread()
        {
            //DataQueueThread = CoFAS_ThreadManager.ThreadStart(CoFAS_ThreadManager.enThreadPriority.Normal, new Action(DeleteQueueData));



            try
            {
                DataQueue.Clear();
                if (DataQueueThread == null)
                {
                   // DataQueueThread = new Thread(new ThreadStart(DeleteQueueData));
                   // DataQueueThread.Priority = ThreadPriority.Normal;
                   // isRunDataQueueThread = true;
                   // DataQueueThread.Start();

                    DataQueueThread = CoFAS_ThreadManager.ThreadStart(CoFAS_ThreadManager.enThreadPriority.Normal, new Action(DeleteQueueData));
                }
            }
            catch (Exception ex)
            {
                DisplayMessage("StarThread_RT : " + ex.ToString());
            }
        }

        #region Queue에 데이터 넣기
        public void InsertQueueData(String strRT)
        {
            try
            {
                lock (DataQueue)
                {
                    DataQueue.Enqueue(strRT);
                }
                DataQueueThreadEvent.Set();
            }
            catch (Exception ex)
            {
               // Message_Log("InsertQueueData_RT : " + ex.ToString(), true, true);
            }
        }
        #endregion

        #region Queue에 데이터 삭제
        private void DeleteQueueData()
        {
            while (DataQueueThread.IsAlive) //isRunDataQueueThread)
            {
                try
                {
                    int queueCount = 0;
                    lock (DataQueue)
                    {
                        queueCount = DataQueue.Count;
                        //CoFASControl.Invoke_Control_Text(lblBox_02, DataQueue_RT.Count.ToString());
                    }

                    if (queueCount <= 0)
                    {
                        DataQueueThreadEvent.WaitOne(); // 큐 데이터 없으면 호출 하지 않음
                    }
                    else
                    {

                        string str = string.Empty;
                        lock (DataQueue)
                        {
                            str = DataQueue.Dequeue();
                        }

                        string[] strTemp = new string[ProcGetStringcount(str, ":")];

                        if (strTemp.Length < 5) return;

                        strTemp = str.Split(':');

                        _pDQGatheringEntity.CRUD = "C";
                        _pDQGatheringEntity.COLLECTION_CODE = strTemp[0].ToString();
                        _pDQGatheringEntity.COLLECTION_DATE = strTemp[1].ToString();
                        _pDQGatheringEntity.PROPERTY_VALUE = strTemp[2].ToString();
                        _pDQGatheringEntity.CONDITION_CODE = strTemp[3].ToString();
                        _pDQGatheringEntity.COLLECTION_VALUE = Math.Round(Convert.ToSingle(strTemp[4].ToString()),4).ToString();

                       // InputData_Save(_pDQGatheringEntity);
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        #endregion

        #endregion

        private void Server_Open()
        {
            try
            {
                // PPC -> IPC
                _pCoFAS_SocketServer = new CoFAS_SocketServer(int.Parse(ucTextEdit2.Text.ToString()), 100);
                _pCoFAS_SocketServer.evtClentConnect = new CoFAS_SocketServer.delClientConnect(CilentConnected);
                _pCoFAS_SocketServer.evtClientDisconnect = new CoFAS_SocketServer.delClientDisconnect(ClientDisconnect);
                _pCoFAS_SocketServer.evtReceiveRequest = new CoFAS_SocketServer.delReceiveRequest(ReceiveRequest);
                _pCoFAS_SocketServer.Start();
                //CoFASControl.Invoke_PictureBox_Image(imgCmd_01, _pGreen);
            }
            catch (Exception ex)
            {
            }
        }


        //클라이언트 연결 상태 확인
        private void CilentConnected(Socket soc)
        {
            try
            {
                IPEndPoint ip = (IPEndPoint)soc.RemoteEndPoint;
                string str = string.Format("{0}:{1} 접속 확인", ip.Address.ToString(), ip.Port);

                DisplayMessage(str);
            }
            catch (Exception ex)
            {
                //_pCoFASLog.WLog_Exception("CilentConnected", ex);
            }
        }

        //클라이언트 종료 처리
        private void ClientDisconnect(Socket soc)
        {
            try
            {
                //IPEndPoint endip = (IPEndPoint)soc.RemoteEndPoint;
                //string sss = endip.Address.ToString();

            }
            catch (Exception ex)
            {
                //_pCoFASLog.WLog_Exception("ClientDisconnect", ex);
            }
        }

        //클라이언트 에서 보낸 데이터 확인 처리
        private void ReceiveRequest(Socket soc, byte[] data)
        {
            try
            {
                //신호가 길어지면 잘라서 들어옴..
                if (dicBuffer.ContainsKey(soc))
                {
                    byte[] temp = new byte[0];
                    DateTime dt;

                    dicBufferTime.TryGetValue(soc, out dt);

                    //5초 이내 신호만 같은 신호
                    if ((DateTime.Now) - dt < new TimeSpan(0, 0, 5))
                    {
                        dicBuffer.TryGetValue(soc, out temp);

                        data = CoFAS_ConvertManager.BytesMerge(temp, data);
                    }

                    dicBufferTime.Remove(soc);
                    dicBuffer.Remove(soc);
                }
                

                //마지막에 [0x2C] == [','] 가 없으면 신호는 더들어 온다.

                ////if (data[data.Length - 1] != bytEnd[0])
                ////{
                ////    dicBuffer.Add(soc, data);
                ////    dicBufferTime.Add(soc, DateTime.Now);
                ////    return;
                ////}

                //string strMesage = "";

                //string strTime = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTime).Replace("-", "").Replace(" ", "").Replace(":", "");

                //string[] strHex = BitConverter.ToString(data, 12, 30).Split('-');

                string[] strHex = BitConverter.ToString(data, 12, 20).Split('-');
                //string[] strHex = BitConverter.ToString(data, 12, 70).Split('-');

                string strHex1 = CoFAS_ConvertManager.Hex2Double(strHex[0] + strHex[1] + strHex[2] + strHex[3] + strHex[4] + strHex[5] + strHex[6] + strHex[7]).ToString();

                //strMesage = "1001:" + strTime + ":3001:4001:" + strHex1 + ":,";
                //InsertQueueData(strMesage);

                //string strHex2 = CoFAS_ConvertManager.Hex2Integer(strHex[8] + strHex[9] + strHex[10] + strHex[11]).ToString();

                //strMesage = "1002:" + strTime + ":3002:4002:" + strHex2 + ":,";
                //InsertQueueData(strMesage);

                //string strHex3 = CoFAS_ConvertManager.Hex2Float(strHex[12] + strHex[13] + strHex[14] + strHex[15]).ToString();

                //strMesage = "1003:" + strTime + ":3003:4003:" + strHex3 + ":,";
                //InsertQueueData(strMesage);

                //string strHex4 = CoFAS_ConvertManager.Hex2Float(strHex[16] + strHex[17] + strHex[18] + strHex[19]).ToString();

                //strMesage = "1004:" + strTime + ":3004:4004:" + strHex4 + ":,";
                //InsertQueueData(strMesage);

                //string strHex5 = CoFAS_ConvertManager.Hex2Float(strHex[20] + strHex[21] + strHex[22] + strHex[23]).ToString();

                //strMesage = "1005:" + strTime + ":3005:4005:" + strHex5 + ":,";
                //InsertQueueData(strMesage);

                //string strHex6 = CoFAS_ConvertManager.Hex2Float(strHex[24] + strHex[25] + strHex[26] + strHex[27]).ToString();

                //strMesage = "1006:" + strTime + ":3006:4006:" + strHex6 + ":,";
                //InsertQueueData(strMesage);

                string strMsg = "";

                strMsg += string.Format("환산 측정 부피 : {0} m3", strHex1);
                //strMsg += string.Format(" | 측정 부피 : {0} m3", strHex2);
                //strMsg += string.Format(" | 측정 압력 : {0} bar", strHex3);
                //strMsg += string.Format(" | 측정 온도 : {0}", strHex4);
                //strMsg += string.Format(" | 측정 유량 : {0}", strHex5);
                //strMsg += string.Format(" | 환산 측정 유량 : {0}", strHex6);

                Add_ListView("수신 : " + strMsg, "");

                string str = Encoding.UTF8.GetString(data, 0, data.Length - 1);

                str = CoFAS_ConvertManager.ByteArray2HexString(data, "");

                Add_ListView("수신 : " + str, "");

                //string[] strRData = new string[ProcGetStringcount(str, ",")];

                //strRData = str.Split(',');

                //for (int a = 0; a < strRData.Length; a++)
                //{
                //    InsertQueueData(strRData[a]);
                //}

                //_pCoFAS_SocketServer.m_socWorker.Send(Encoding.UTF8.GetBytes("1"));
            }
            catch (SocketException pSocketException)
            {
                //_pCoFASLog.WLog_Exception("ReceiveRequest : SocketException", pSocketException);
                //_pCoFAS_SocketServer.m_socWorker.Send(Encoding.UTF8.GetBytes("-1"));
            }
            catch (Exception ex)
            {
                //_pCoFASLog.WLog_Exception("ReceiveRequest", ex);
               // _pCoFAS_SocketServer.m_socWorker.Send(Encoding.UTF8.GetBytes("-1"));
            }
            finally
            {
                //soc.Shutdown(SocketShutdown.Both);
                //if (soc.Connected) soc.Disconnect(false);
            }
        }

        public static int ProcGetStringcount(string strTotal, string strFind)
        {
            System.Text.RegularExpressions.Regex cntStr = new System.Text.RegularExpressions.Regex(strFind);
            return int.Parse(cntStr.Matches(strTotal, 0).Count.ToString());
        }


        #region ○ 저장 - InputData_Save(DQGatheringEntity _pDQGatheringEntity)

        private void InputData_Save(DQGatheringEntity _pDQGatheringEntity)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                isError = new DQGatheringBusiness().DQ_Data_Save(_pDQGatheringEntity);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    //화면 표시.

                }
                else
                {
                    //정상 처리
                    DisplayMessage("저장 처리 되었습니다.");
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                //CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        private void send_data(byte[] btData)
        {
            btArry = null;

            btArry = CoFAS_ConvertManager.BytesMerge(Encoding.UTF8.GetBytes("$GS,4,8,"), btData);

            str = CoFAS_ConvertManager.ByteArray2HexString(btArry, " ");

            Add_ListView("송신 : " + str, "");

            _pCoFAS_SocketServer.m_socWorker.Send(btArry);
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            send_data(btArryOneDay);

            //send_data(btArry);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            send_data(btValue1);


            //_pCoFAS_Serial.Write(btArryOneDay, 0, btArryOneDay.Count());

            //str = CoFAS_ConvertManager.ByteArray2HexString(btArryOneDay, " ");

            //Add_ListView("송신 : " + str, "");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            send_data(btValue2);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            send_data(btValue3);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            send_data(btValue4);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            send_data(btValue5);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            send_data(btValue6);
        }
    }
}
