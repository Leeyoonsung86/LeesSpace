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

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using System.Threading;

namespace CoFAS_MES.POP
{
    public partial class DBInterface : frmBasePOP
    {
        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정

        private DBInterfaceEntity _pDBInterfaceEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private DataTable _dtListOrder = null; //오더 데이터 리스트

        private DataTable _dtListSensor = null; //센서 데이터 리스트

        private DataTable _dtListbokang = null; //조회 항목 데이터 리스트

        private DataTable _dtListminwon = null; //민원 데이터 리스트

        private DataTable _dtListworkorder = null; //작업지시 데이터 리스트

        private DataTable _dtListcolor = null; //작업지시 데이터 리스트

        private DataTable _dtListplan = null; //작업계획 데이터 리스트

        private bool isStop = false; // 타이머 중지
        private bool isRunning = false; // 디비처리중


        //private Thread DataInterfaceThread = null; // 인터페이스 스레드
        //private bool isRunDataThread = true; //스레드 상태

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        private System.Threading.Timer tmrInterface; //인터페이스 타이머

        public DBInterface()
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
                Initialize("1");
                InitializeSetting();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        // 초기화 처리 영역
        private void Initialize(string strType)
        {
            try
            {
                switch ("SQLServer")//Properties.Settings.Default.DB_TYPE.ToString())
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

                switch(strType)
                {
                    case "1":
                            DBManager.PrimaryConnectionString = string.Format
                           (
                               //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                               "Server={0};Database={1};UID={2};PWD={3}",
                               "db2.coever.co.kr,1897",//Properties.Settings.Default.SERVER_IP.ToString(),
                               "CoFAS_TAEKWANG",//Properties.Settings.Default.DB_NAME.ToString(),
                               "sa",//Properties.Settings.Default.DB_ID.ToString(),
                               "Codb89897788!#%"
                           );

                        break;

                    case "2":
                            DBManager.PrimaryConnectionString = string.Format
                           (
                               //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                               "Server={0};Database={1};UID={2};PWD={3}",
                               "210.123.142.144,1514",//Properties.Settings.Default.SERVER_IP.ToString(),
                               "INTER_DB",//Properties.Settings.Default.DB_NAME.ToString(),
                               "coever",//Properties.Settings.Default.DB_ID.ToString(),
                               "coever2018`"
                           );
                        break;

                    case "3":
                            DBManager.PrimaryConnectionString = string.Format
                           (
                               //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                               "Server={0};Database={1};UID={2};PWD={3}",
                               "210.123.142.144,1514",//Properties.Settings.Default.SERVER_IP.ToString(),
                               "TEMPER_DB",//Properties.Settings.Default.DB_NAME.ToString(),
                               "coever",//Properties.Settings.Default.DB_ID.ToString(),
                               "coever2018`"
                           );

                        break;

                    case "4": // 사림
                        DBManager.PrimaryConnectionString = string.Format
                       (
                           //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                           "Server={0};Database={1};UID={2};PWD={3}",
                           "210.123.142.133,2544",//Properties.Settings.Default.SERVER_IP.ToString(),
                           "TEMPER",//Properties.Settings.Default.DB_NAME.ToString(),
                           "coever",//Properties.Settings.Default.DB_ID.ToString(),
                           "coever2018`"
                       );

                        break;
                    case "5": // 코파스_우일
                        DBManager.PrimaryConnectionString = string.Format
                       (
                           //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                           "Server={0};Database={1};UID={2};PWD={3}",
                           "db2.coever.co.kr,1897",//Properties.Settings.Default.SERVER_IP.ToString(),
                           "CoFAS_WOOIL",//Properties.Settings.Default.DB_NAME.ToString(),
                           "sa",//Properties.Settings.Default.DB_ID.ToString(),
                           "Codb89897788!#%"
                       );

                        break;
                    case "6": // 보강 작업지시 전송
                        DBManager.PrimaryConnectionString = string.Format
                       (
                           //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                           "Server={0};Database={1};UID={2};PWD={3}",
                           "210.123.142.224,1514",//Properties.Settings.Default.SERVER_IP.ToString(),
                           "DYETEC_DB",//Properties.Settings.Default.DB_NAME.ToString(),
                           "coever",//Properties.Settings.Default.DB_ID.ToString(),
                           "coever2018`"
                       );

                        break;
                    case "7": // 다이텍 작업지시 전송
                        DBManager.PrimaryConnectionString = string.Format
                       (
                           //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                           "Server={0};Database={1};UID={2};PWD={3}",
                           "db2.coever.co.kr,1897",//Properties.Settings.Default.SERVER_IP.ToString(),
                           "CoFAS_DYETEC",//Properties.Settings.Default.DB_NAME.ToString(),
                           "sa",//Properties.Settings.Default.DB_ID.ToString(),
                           "Codb89897788!#%"
                       );

                        break;
                }

                

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
                _pCORP_CODE = "9999999999";//MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = "admin@coever.co.kr";// MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = "";//MainForm.UserEntity.USER_NAME;
                //_pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                //_pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;

                _pWINDOW_NAME = this.Name;

                _lbTitle.Text = "Interface Programe";
                _lbHeader.Text = "데이터 수집 프로그램 v1.0";
                DisplayMessage("");


                //메뉴 화면 엔티티 설정
                _pDBInterfaceEntity = new DBInterfaceEntity();
                _pDBInterfaceEntity.CORP_CODE = _pCORP_CODE;
                _pDBInterfaceEntity.USER_CODE = _pUSER_CODE;

                //화면 설정 언어 & 명칭 변경. ==고정==
                //DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                //if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                //{
                //    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                //}
                //화면 설정 언어 & 명칭 변경. ==고정==


                //그리드 설정

                tmrInterface = new System.Threading.Timer(new TimerCallback(Start_tmr), null, Timeout.Infinite, Timeout.Infinite);

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

                //StartThread();
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

        private void Start_tmr(object obj)
        {
            if (isStop)
            {
                return;
            }

            string strMessage = "";
            try
            {
                tmrInterface.Change(Timeout.Infinite, Timeout.Infinite);

                isRunning = true;

                Initialize("1");

                _dtList = new DBInterfaceBusiness().Interface_Data_Order();
                if (_dtList != null || _dtList.Rows.Count > 0)
                {
                    CoFAS_ControlManager.InvokeIfNeeded(_luJSNO, () => _luJSNO.Text = _dtList.Rows[0]["JSNO"].ToString());
                }

                _dtList = new DBInterfaceBusiness().Interface_Data_Sensor();
                if (_dtList != null || _dtList.Rows.Count > 0)
                {
                    CoFAS_ControlManager.InvokeIfNeeded(_luWORK_DATE, () => _luWORK_DATE.Text = _dtList.Rows[0]["WORK_DATE"].ToString());
                    CoFAS_ControlManager.InvokeIfNeeded(_luPROC_DATE, () => _luPROC_DATE.Text = _dtList.Rows[0]["PROC_DATE"].ToString());
                    CoFAS_ControlManager.InvokeIfNeeded(_luPROC_TIME, () => _luPROC_TIME.Text = _dtList.Rows[0]["PROC_TIME"].ToString());
                }
                strMessage = "01";
                DisplayMessage("1. Interface Data Search");

                Initialize("2");

                _dtListOrder = new DBInterfaceBusiness().Interface_Data_Order_MST(_luJSNO.Text.ToString());
                if (_dtListOrder != null || _dtListOrder.Rows.Count > 0)
                {
                    Initialize("1");
                    //저장
                    bool isOrder = false;
                    isOrder = new DBInterfaceBusiness().Interface_Data_Order_Save(_pDBInterfaceEntity, _dtListOrder);
                }

                strMessage = "02";
                DisplayMessage("2. Interface Order MST Data Search & Save");


                Initialize("3");

                _dtListSensor = new DBInterfaceBusiness().Interface_Data_Sensor_MST(_luWORK_DATE.Text.ToString(), _luPROC_DATE.Text.ToString(), _luPROC_TIME.Text.ToString());
                string str = _dtListSensor.Rows.Count.ToString() + " / " + _luWORK_DATE.Text.ToString() + " / " + _luPROC_DATE.Text.ToString() + " / " + _luPROC_TIME.Text.ToString();

                Add_ListView(str, "");

                if (_dtListSensor != null || _dtListSensor.Rows.Count > 0)
                {
                    Initialize("1");
                    //저장
                    bool isSensor = false;
                    isSensor = new DBInterfaceBusiness().Interface_Data_Sensor_Save(_pDBInterfaceEntity, _dtListSensor);
                }

                strMessage = "03";
                DisplayMessage("3. Interface Sensor MST Data Search & Save");

                // 보강 작업지시 추가 로직

                Initialize("7");  //Cofas_dyt DB

                _dtListbokang = new DBInterfaceBusiness().Interface_Data_Order_Bokang();

                Thread.Sleep(1000);
                if (_dtListbokang.Rows.Count > 0)
                {
                    Initialize("6"); //우일 DB

                    DBManager.PrimaryConnectionString = string.Format
                    (
                        //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                        "Server={0};Database={1};UID={2};PWD={3}",
                        "210.123.142.224,1514",//Properties.Settings.Default.SERVER_IP.ToString(),
                        "DYETEC_DB",//Properties.Settings.Default.DB_NAME.ToString(),
                        "coever",//Properties.Settings.Default.DB_ID.ToString(),
                        "coever2018`"
                    );

                    _dtListminwon = new DBInterfaceBusiness().Interface_Data_minwon(_dtListbokang.Rows[0][0].ToString());  //민원
                    _dtListworkorder = new DBInterfaceBusiness().Interface_Data_workorder(_dtListbokang.Rows[0][1].ToString()); // 작업지시
                    _dtListcolor = new DBInterfaceBusiness().Interface_Data_color(_dtListbokang.Rows[0][2].ToString()); // 색상정보
                    _dtListplan = new DBInterfaceBusiness().Interface_Data_workplan(_dtListbokang.Rows[0][3].ToString()); // 작업계획
                }
                if (_dtListminwon.Rows.Count > 0)
                {
                    Initialize("7");  //Cofas_dyt DB
                    new DBInterfaceBusiness().Interface_Data_Sensor_Save_Bokang_minwon(_pDBInterfaceEntity, _dtListminwon);
                }
                if (_dtListworkorder.Rows.Count > 0)
                {
                    Initialize("7");  //Cofas_dyt DB
                    new DBInterfaceBusiness().Interface_Data_Sensor_Save_Bokang_workorder(_pDBInterfaceEntity, _dtListworkorder);
                }
                if (_dtListcolor.Rows.Count > 0)
                {
                    Initialize("7");  //Cofas_dyt DB
                    new DBInterfaceBusiness().Interface_Data_Sensor_Save_Bokang_color(_pDBInterfaceEntity, _dtListcolor);
                }
                if (_dtListplan.Rows.Count > 0)
                {
                    Initialize("7");  //Cofas_dyt DB
                    new DBInterfaceBusiness().Interface_Data_Sensor_Save_Bokang_workplan(_pDBInterfaceEntity, _dtListplan);
                }
                strMessage = "07";
                DisplayMessage("7. Interface Bokang Data Search & Save");

                Initialize("4");

                _dtListSensor = new DBInterfaceBusiness().Interface_Data_Sensor_MST_sarim(_luWORK_DATE.Text.ToString(), _luPROC_DATE.Text.ToString(), _luPROC_TIME.Text.ToString());
                string str4 = _dtListSensor.Rows.Count.ToString() + " / " + _luWORK_DATE.Text.ToString() + " / " + _luPROC_DATE.Text.ToString() + " / " + _luPROC_TIME.Text.ToString();

                Add_ListView(str4, "");

                /////
                if (_dtListSensor != null || _dtListSensor.Rows.Count > 0)
                {
                    Initialize("5");
                    //저장
                    bool isSensor = false;
                    isSensor = new DBInterfaceBusiness().Interface_Data_Sensor_Save_sarim(_pDBInterfaceEntity, _dtListSensor);
                }

                strMessage = "04";
                DisplayMessage("4. Interface Sensor MST Data Search & Save");

             

                tmrInterface.Change(60000, 0);

                isRunning = false;
            }
            catch (Exception ex)
            {
                tmrInterface.Change(60000, 0);
                isRunning = false;
                DisplayMessage(strMessage + " Interface : " + ex.ToString());
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

        private void _btSTART_Click(object sender, EventArgs e)
        {
            if(isRunning)
            {
                DisplayMessage("DB 작업중...");
                return;
            }

            isStop = false;
            tmrInterface.Change(0, 60000);
        }

        private void _btSTOP_Click(object sender, EventArgs e)
        {
            isStop = true;

        }
    }
}
