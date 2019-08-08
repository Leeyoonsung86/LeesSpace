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
    public partial class Gathering_Test : System.Windows.Forms.Form
    {

        public string _pCORP_CODE = string.Empty;       // 회사코드       
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



        public Gathering_Test()
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ Form_Closing

        private void Form_Closing(object pSender, FormClosingEventArgs pFormClosingEventArgs)
        {
            try
            {
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ Form_Load
        private void Form_Load(object pSender, EventArgs pEventArgs)
        {
            try
            {


                Initialize();
                //InitializeSetting();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
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
                   Properties.Settings.Default.CORP_CODE.ToString(),
                   Properties.Settings.Default.SERVER_IP.ToString(),
                   Properties.Settings.Default.DB_NAME.ToString(),
                   "0we11Passw0rd!@#dbmes"
               );

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Initialize()", pException);
            }
        }
        /*
        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
                _pnRight.Visible = false;

                //메인 화면 전역 변수 처리
                _pCORP_CODE = "9999999999";//MainForm.UserEntity.CORP_CODE;
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
                _pDQGatheringEntity.CORP_CODE = _pCORP_CODE;
                _pDQGatheringEntity.USER_CODE = _pUSER_CODE;

                //화면 설정 언어 & 명칭 변경. ==고정==
                //DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
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

                StartQueueThread();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {

            }
        }

        #endregion

        private void Serial_Data(byte[] data)
        {

            if (data.Length < 12) return;

            string strData = "";

            double d1 = 32768; //고정
            double d2 = 65535; //고정
            double d3 = 16485; //설정 값 나누기
            double d4 = 0.048; //설정 값 빼기

            //string decimalNumber = "32768";
            //int number = int.Parse(decimalNumber);
            //string hex = number.ToString("x");


            string strHex = int.Parse(data[5].ToString()).ToString("x") + int.Parse(data[6].ToString()).ToString("x");

            string strDec = Convert.ToInt32(strHex, 16).ToString();

            double dm1 = double.Parse(strDec);

            double dm2 = 0;

            double dm3 = 0; //각도 값 , 행거 각도 값

            string strSign = ""; //변위 부호

            double dbDisplacement = 0; //변위 값

            string strMesage = "";

            string strTime = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTime).Replace("-", "").Replace(" ", "").Replace(":", "");

            switch (data[3].ToString())
            {
                case "0": //행거 각도

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
                case "3": //각도 변위

                    strMesage = "";

                    if (dm1 > d1)
                    {
                        dm2 = ((dm1 - d2) / d3) - d4;
                    }
                    else
                    {
                        dm2 = (dm1 / d3) - d4;
                    }

                    dm3 = Math.Asin(dm2) * (180 / 3.14); //각도 


                    strMesage = "03:" + strTime + ":0000:1006:" + dm3.ToString() + ":,";

                    //==================================================================================

                    if (int.Parse(data[8].ToString()) != 0)
                    {
                        //음수
                        strSign = "-";
                    }

                    // 변경

                    string strBinary1 = (Convert.ToString(int.Parse(data[9].ToString()), 2)).PadLeft(8, '0');
                    string strTemp1 = "";

                    for (int a = 8; a > 0; a--)
                    {
                        strTemp1 += strBinary1[a - 1];
                    }

                    //strTemp1 = new String(strBinary1.ToCharArray().Reverse().ToArray());

                    //strTemp1 = Convert.ToInt32(strTemp1, 2).ToString();

                    string strBinary2 = (Convert.ToString(int.Parse(data[10].ToString()), 2)).PadLeft(8, '0');
                    string strTemp2 = "";

                    for (int a = 8; a > 0; a--)
                    {
                        strTemp2 += strBinary2[a - 1];
                    }

                    //strTemp2 = new String(strBinary2.ToCharArray().Reverse().ToArray());

                    //strTemp2 = Convert.ToInt32(strTemp2, 2).ToString();

                    string strTemp3 = "";
                    strTemp3 = strTemp1 + strTemp2;

                    double dbTemp = 0.0;

                    dbTemp = double.Parse(Convert.ToInt32(strTemp3, 2).ToString());



                    dbDisplacement = dbTemp / 100;

                    strMesage = strMesage + "03:" + strTime + ":0000:1007:" + strSign + dbDisplacement.ToString() + ":,";
                    break;


            }



            // string binary = Convert.ToString(128, 2);

            //strData = CoFAS_ConvertManager.Bytes2String(data,0,0);

            for (int a = 0; a < 12; a++)
            {
                strData += data[a].ToString() + " ";
            }

            strData = "[ " + strData + " ] [";

            for (int b = 0; b < 12; b++)
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
                    InsertQueueData(strRData[a]);
                }
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


            }
            catch (Exception ex)
            {
            }
        }
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Server_Open();

            _pCoFAS_Serial = new CoFAS_Serial(textEdit1.Text.ToString(), 115200, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);

            _pCoFAS_Serial.evtReceived += new CoFAS_Serial.delReceive(Serial_Data);

            _pCoFAS_Serial.Open();


            DisplayMessage(textEdit1.Text.ToString() + " Open");
        }

        #region 스레드 생성
        private void StartQueueThread()
        {
            try
            {
                DataQueue.Clear();
                if (DataQueueThread == null)
                {
                    DataQueueThread = new Thread(new ThreadStart(DeleteQueueData));
                    DataQueueThread.Priority = ThreadPriority.Normal;
                    isRunDataQueueThread = true;
                    DataQueueThread.Start();
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
            while (isRunDataQueueThread)
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
                        _pDQGatheringEntity.COLLECTION_VALUE = Math.Round(Convert.ToSingle(strTemp[4].ToString()), 4).ToString();

                        InputData_Save(_pDQGatheringEntity);
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
                _pCoFAS_SocketServer = new CoFAS_SocketServer(int.Parse(textEdit2.Text.ToString()), 100);
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

                if (data[data.Length - 1] != bytEnd[0])
                {
                    dicBuffer.Add(soc, data);
                    dicBufferTime.Add(soc, DateTime.Now);
                    return;
                }

                string str = Encoding.UTF8.GetString(data, 0, data.Length - 1);

                Add_ListView(str, "");

                string[] strRData = new string[ProcGetStringcount(str, ",")];

                strRData = str.Split(',');

                for (int a = 0; a < strRData.Length; a++)
                {
                    InsertQueueData(strRData[a]);
                }

                _pCoFAS_SocketServer.m_socWorker.Send(Encoding.UTF8.GetBytes("1"));
            }
            catch (SocketException pSocketException)
            {
                //_pCoFASLog.WLog_Exception("ReceiveRequest : SocketException", pSocketException);
                _pCoFAS_SocketServer.m_socWorker.Send(Encoding.UTF8.GetBytes("-1"));
            }
            catch (Exception ex)
            {
                //_pCoFASLog.WLog_Exception("ReceiveRequest", ex);
                _pCoFAS_SocketServer.m_socWorker.Send(Encoding.UTF8.GetBytes("-1"));
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
                //CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion
        */
    }
}
