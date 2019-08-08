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
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Entity;

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Spreadsheet;

using System.IO.Ports;

//using DarrenLee.Bluetooth;

namespace CoFAS_MES.POP
{
    public partial class frmPOPMain_WEIGHING_COSMETICS : frmBasePOP
    {
        public string _pCORP_CDDE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private bool _pINSPECT_CHECK_YN = false;        // 중복 시험의뢰 방지
        private decimal _Bom_Qty = 0;        // 중복 시험의뢰 방지
        private decimal _Input_Qty = 0;        // 중복 시험의뢰 방지

        private bool _pPART_STOCK_YN = false;        // 재고확인용 바코드 스캔

        private string[] PC_serial_port = SerialPort.GetPortNames();

        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부

        private bool _pWeighing_chk = false;              //저울에서 값이 적히는지 체크

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _rt_dtList = null; //조회 데이터 리스트
        DataTable Weighting_Insert_Temp = new DataTable();

        private CoFAS_Serial _pBarcode_Serial = null;  // 바코드 시리얼 생성
        private CoFAS_Serial _pWeighing_Serial = null;  // 저울시리얼 생성 블루투스
        private CoFAS_Serial _pWeighing_Serial2 = null;  // 저울시리얼 생성 매립형

        private string COM_PORT = string.Empty; //스캐너 포트
        private string COM_PORT2 = string.Empty; //저울 포트 블루투수
        private string COM_PORT3 = string.Empty; //저울 포트 매립형

        private string _pTERMINAL_CODE = string.Empty; //단말기코드 : TP010003(구)  / TP010006(신규)

        public UserEntity _pUserEntity = null;
        private POPSelect_INSPECT_COSMETICSEntity _pPOPSelect_INSPECT_COSMETICSEntity = null; // 엔티티 생성

        private POPProductionOrderEntity _pPOPProductionOrderEntity = null; // 엔티티 생성
        private frmPOPMain_WEIGHING_COSMETICSEntity pfrmPOPMain_WEIGHING_COSMETICSEntity=null;

        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        //Bluetooth_Server blue_Server = new Bluetooth_Server();
     //   Bluetooth_Client blue_Client = new Bluetooth_Client();

        private static string _pPROCESS_CODE_MST = string.Empty;     // 공정코드
        public static string PROCESS_CODE_MST
        {
            get { return _pPROCESS_CODE_MST; }
            set { _pPROCESS_CODE_MST = value; }
        }

        #region 사용자 개체 - UserEntity

        public UserEntity UserEntity
        {
            get
            {
                return _pUserEntity;
            }
            set
            {
                _pUserEntity = value;
            }
        }

        #endregion


        #region 메세지 개체 - MessageEntity

        public MessageEntity MessageEntity
        {
            get
            {
                return _pMessageEntity;
            }
            set
            {
                _pMessageEntity = value;
            }
        }

        #endregion

        public frmPOPMain_WEIGHING_COSMETICS(UserEntity pUserEntity, string pTerminalCode)
        {
            InitializeComponent();

            _pUserEntity = pUserEntity;
            //_pUserEntity.PROCESS_CODE = "PC010002";
            _pMessageEntity = new MessageEntity();

            _pPOPProductionOrderEntity = new POPProductionOrderEntity();
            _pFONT_SETTING = new Font(_pUserEntity.FONT_TYPE, _pUserEntity.FONT_SIZE);

            _pUSER_CODE = _pUserEntity.USER_CODE;
            _pUSER_NAME = _pUserEntity.USER_NAME;
            _pTERMINAL_CODE = pTerminalCode;
            _pPROCESS_CODE_MST = "PC01";
            //_lbUserName.Text = _pUserEntity.USER_NAME;


            //시스템 세팅 버튼
            /*
                if (_pUserEntity.USER_GRANT == "PC160001")
                {
                    _btSystem_Setting.Visible = true;
                }
                else
                {
                    _btSystem_Setting.Visible = false;
                }
            */

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        private void InitializeLanguage()
        {



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
                //pFormClosingEventArgs.Cancel = false;
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
                InitializeSetting();
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
                //_pUSER_CODE = "admin@coever.co.kr";// MainForm.UserEntity.USER_CODE;
                //_pUSER_NAME = "";//MainForm.UserEntity.USER_NAME;
                //_pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                //_pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;

                //메인 화면 전역 변수 처리
                //_pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                //_pUSER_CODE = MainForm.UserEntity.USER_CODE;
                //_pUSER_NAME = MainForm.UserEntity.USER_NAME;
                //_pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                //_pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                //_pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                //_pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                

                _pWINDOW_NAME = this.Name;
                _pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _lbTitle.Text = _pUserEntity.POP_TITLE;
                _lbHeader.Text = "";
                DisplayMessage("");

                _luPART_NAME.Text = "";
                _luPART_CODE.Text = "";
                _luORDER_DATE.Text = "";
                _luORDER_QTY.Text = "";
                _luORDER_QTY.Text = "";

                //메뉴 화면 엔티티 설정
                //_pDQGatheringEntity = new DQGatheringEntity();
                //_pDQGatheringEntity.CORP_CODE = _pCORP_CDDE;
                //_pDQGatheringEntity.USER_CODE = _pUSER_CODE;

                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);


                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }
                //화면 컨트롤러 설정
                //_gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                //_gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
                InitializeGrid();

                InitializeControl();
                //화면 설정 언어 & 명칭 변경. ==고정==

                _pPOPSelect_INSPECT_COSMETICSEntity = new POPSelect_INSPECT_COSMETICSEntity();
                _pPOPSelect_INSPECT_COSMETICSEntity.CORP_CODE = _pCORP_CDDE;
                _pPOPSelect_INSPECT_COSMETICSEntity.USER_CODE = _pUSER_CODE;
                _pPOPSelect_INSPECT_COSMETICSEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pPOPSelect_INSPECT_COSMETICSEntity.PROCESS_CODE = "";
                _pPOPSelect_INSPECT_COSMETICSEntity.RESOURCE_CODE = "";
                //단말기코드 : TP010003(구)  / TP010006(신규)
                _pPOPSelect_INSPECT_COSMETICSEntity.TERMINAL_CODE = _pTERMINAL_CODE;
                //_pPOPSelect_INSPECT_COSMETICSEntity.TERMINAL_CODE = "TP010003";

                pfrmPOPMain_WEIGHING_COSMETICSEntity  = new frmPOPMain_WEIGHING_COSMETICSEntity();
                pfrmPOPMain_WEIGHING_COSMETICSEntity.CORP_CODE = _pCORP_CDDE;
                pfrmPOPMain_WEIGHING_COSMETICSEntity.USER_CODE = _pUSER_CODE;
                pfrmPOPMain_WEIGHING_COSMETICSEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                pfrmPOPMain_WEIGHING_COSMETICSEntity.PROCESS_CODE = "";
                pfrmPOPMain_WEIGHING_COSMETICSEntity.RESOURCE_CODE = "";
                pfrmPOPMain_WEIGHING_COSMETICSEntity.CRUD = "";
                //단말기코드 : TP010003(구)  / TP010006(신규)
                pfrmPOPMain_WEIGHING_COSMETICSEntity.TERMINAL_CODE = _pTERMINAL_CODE;
                //pfrmPOPMain_WEIGHING_COSMETICSEntity.TERMINAL_CODE = "TP010003";

                // MainFind_DisplayData();

                //그리드 설정

                //   double ddd = Math.Acos(0.912);


                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _pFirstYN = false;

                    //칭량한 값 임시 저장
                    
                    Weighting_Insert_Temp.Columns.Add(new DataColumn("CRUD", typeof(string)));
                    Weighting_Insert_Temp.Columns.Add(new DataColumn("PART_CODE", typeof(string)));
                    Weighting_Insert_Temp.Columns.Add(new DataColumn("SPEND_QTY", typeof(string)));
                    Weighting_Insert_Temp.Columns.Add(new DataColumn("INOUT_ID", typeof(string)));
                    Weighting_Insert_Temp.Columns.Add(new DataColumn("INPUT_QTY", typeof(string)));
                    Weighting_Insert_Temp.Columns.Add(new DataColumn("PROCESS_SEQ", typeof(string)));

                }
                GetBarcodeComPort();
                // H/W 연결 설정
                SetHardware();
                _gdSUB_VIEW.CellValueChanged += _gdSUB_VIEW_CellValueChanged;

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


        #region ○ 버튼 클릭시

        private void btnCmd_Click(object pSender, EventArgs pEventArgs)
        {

        }

        #endregion


        #region ○ H/W 세팅시
        private void GetBarcodeComPort()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_COM_Info(pfrmPOPMain_WEIGHING_COSMETICSEntity.LANGUAGE_TYPE, pfrmPOPMain_WEIGHING_COSMETICSEntity.TERMINAL_CODE);
                _rt_dtList = _dtList;
                COM_PORT = "";
                COM_PORT2 = "";
                if (_dtList != null && _dtList.Rows.Count > 0)//&& _dtList.Rows.Count > 0) )|| (_dtList != null && _pBarcodeLabelPrintEntity.CRUD == ""))
                {
                  //  CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    //조회 후 초기화 
                    COM_PORT = _dtList.Rows[0]["COM_PORT"].ToString();  //스캐너 포트
                    COM_PORT2 = _dtList.Rows[1]["COM_PORT"].ToString(); //저울 포트 블루투스
                }
                    //구 칭량실일경우
                    if(_pTERMINAL_CODE=="TP010003")
                    {
                     COM_PORT3 = _dtList.Rows[2]["COM_PORT"].ToString(); //저울 포트 매립형
                     }
                else
                {

                }

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
        private void SetHardware()
        {

            try
            {
                // 연결 표기 부분 초기화
                //pnlDeviceConnect.Controls.Clear();

                // 연결할 H/W 갯수만큼 돌린다. (연동시 변경)
                
                //for (int i = 0; i < 5; i++)
                for (int i = 0; i < _rt_dtList.Rows.Count; i++)
                {
                    LabelControl lc = new LabelControl();
                    lc.Name = "lc_" + _rt_dtList.Rows[i]["PORT_NAME"].ToString().ToString();
                    lc.Font = new Font("Tahoma", 9, FontStyle.Bold); // Font 설정
                    // lc.Text = "프린터" + i.ToString();
                    lc.Text = (_rt_dtList.Rows[i]["PORT_NAME"].ToString() + "_" + _rt_dtList.Rows[i]["COM_PORT"].ToString()).ToString();
                    lc.Padding = new Padding(10, 0, 10, 0);
                    lc.Margin = new Padding(0);
                    lc.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                    lc.ImageAlignToText = ImageAlignToText.LeftCenter;
                    lc.Dock = DockStyle.Right;


                    pnlDeviceConnect.Controls.Add(lc);

                    DisplayMessage(lc.Text + " OK");

                    DisplayMessage("POP Start Complete");

                }

                //_pCoFAS_Serial = new CoFAS_Serial(_dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString()), _dtList_terminal.Rows[0]["INFO_PARITY"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString()), _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString());
                //_pBarcode_Serial = new CoFAS_Serial("COM3", 9600, "NONE", 8, "ONE");
                //_pBarcode_Serial = new CoFAS_Serial(COM_PORT, 9600, "NONE", 8, "ONE");


                LabelControl xlb0 = this.Controls.Find("lc_" + _rt_dtList.Rows[0]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                xlb0.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;

                LabelControl xlb1 = this.Controls.Find("lc_" + _rt_dtList.Rows[1]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                xlb1.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;

                //구 칭량실일경우
                if (_pTERMINAL_CODE == "TP010003")
                {
                    LabelControl xlb2 = this.Controls.Find("lc_" + _rt_dtList.Rows[2]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                    xlb2.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                }
                //포트1 : 바코드포트가 존재하는지
                if (Array.Exists(PC_serial_port, port => port == COM_PORT))
                {
                    _pBarcode_Serial = new CoFAS_Serial(COM_PORT, 9600, "NONE", 8, "ONE");
                    if(!_pBarcode_Serial.IsOpen)
                        _pBarcode_Serial.Open();
                    _pBarcode_Serial.evtReceived += new CoFAS_Serial.delReceive(_Barcode_Received_Data);

                    if (_pBarcode_Serial.IsOpen)
                    {
                        LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[0]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                        xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;
                    }
                    else
                    {
                        LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[0]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                        xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                    }

                }
                //포트2 : 저울포트가 존재하는지
                if (Array.Exists(PC_serial_port, port => port == COM_PORT2))
                {
                    string portName = COM_PORT2;
                    BaudRate baudRate = BaudRate.b9600;
                    Parity parity = Parity.None;
                    DataBits dataBits = DataBits.Bit8;
                    StopBits stopBits = StopBits.One;
                   
                  //  _pWeighing_Serial = new CoFAS_Serial(COM_PORT2, 9600, "NONE", 8, "ONE");
                    _pWeighing_Serial = new CoFAS_Serial(portName, baudRate, parity, dataBits, stopBits);

                    if (!_pWeighing_Serial.IsOpen)
                        _pWeighing_Serial.Open();
                    _pWeighing_Serial.evtReceived += new CoFAS_Serial.delReceive(_Weighing_Received_Data);

                    if (_pWeighing_Serial.IsOpen)
                    {
                        LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[1]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                        xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;
                    }
                    else
                    {
                        LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[1]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                        xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                    }


                }
                //포트3 :매립형 저울 포트가 존재하는지
                if (Array.Exists(PC_serial_port, port => port == COM_PORT3))
                {
                    _pWeighing_Serial2 = new CoFAS_Serial(COM_PORT3, 9600, "NONE", 8, "ONE");
                    if (!_pWeighing_Serial2.IsOpen)
                        _pWeighing_Serial2.Open();
                  
                    if (_pWeighing_Serial2.IsOpen)
                    {
                        _pWeighing_Serial2.Close();
                        LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[2]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                        xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;
                    }
                    else
                    {
                        LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[2]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                        xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                    }

                }
                /*
                                 //구 칭량실일경우
                if (_pTERMINAL_CODE == "TP010003")
                {
                    LabelControl xlb2 = this.Controls.Find("lc_" + _rt_dtList.Rows[2]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                    xlb2.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                }
                 * */



            }
            catch (Exception ex)
            {

                CoFAS_DevExpressManager.ShowInformationMessage("포트 연결을 실패했습니다.");
              /*
                // _pBarcode_Serial = new CoFAS_Serial();

                if (_pBarcode_Serial.IsOpen)
                {
                   //Control _cWeighing_ctn = this.Controls["lc_" + _rt_dtList.Rows[0]["PORT_NAME"].ToString()];
                   //_cWeighing_ctn.BackgroundImage = global::CoFAS_MES.POP.Properties.Resources.plug_Green;


                    LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[0]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                    xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;
                }
                else
                {
                    LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[0]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                    xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;


                }

                if (_pWeighing_Serial.IsOpen)
                {
                    LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[1]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                    xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;
                }
                else
                {
                    LabelControl xlb = this.Controls.Find("lc_" + _rt_dtList.Rows[1]["PORT_NAME"].ToString(), true).FirstOrDefault() as LabelControl;
                    xlb.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Gray;
                }

                */

            }
            
        }

        void _Barcode_Received_Data(byte[] yReceiveData)
        {
            try
            {
                if (yReceiveData.Length > 0)
                {

                    if (!_pPART_STOCK_YN)
                    {
                        string pFindData = string.Empty;
                        string vPart_code = string.Empty;
                        string vMake_no = string.Empty;
                        string vInspect_no = string.Empty;
                        string vVend_Part_Code = string.Empty;
                        string vReference_id = string.Empty;

                        pFindData = CoFAS_ConvertManager.Bytes2String(yReceiveData, 0, 0);
                        //pFindData = pFindData.Substring(0, pFindData.Length - 4);//뒤에 개행문자 지울경우(2자리)
                        pFindData = pFindData.Substring(0, 14);//뒤에 개행문자 지울경우(2자리)
                        DataSet pDataSet = new DataSet();
                        pDataSet = new BarcodeLabelPrintBusiness().BarcodeLabelPrint_inspect_Info(pfrmPOPMain_WEIGHING_COSMETICSEntity.LANGUAGE_TYPE, "DOC", pFindData);
                        _dtList = pDataSet.Tables[0];
                        if (_dtList != null && _dtList.Rows.Count > 0)
                        {
                            vPart_code = _dtList.Rows[0]["part_code"].ToString();
                            vMake_no = _dtList.Rows[0]["make_no"].ToString();
                            vInspect_no = _dtList.Rows[0]["inspect_no"].ToString();
                            vVend_Part_Code = _dtList.Rows[0]["vend_part_code"].ToString();
                            vReference_id = _dtList.Rows[0]["reference_id"].ToString();
                            //제조
                            if (_pPROCESS_CODE_MST == "PC01")
                                FindPartCode(vPart_code, vVend_Part_Code, vInspect_no, vReference_id);
                            else
                                FindPartCode(vPart_code, vVend_Part_Code, vMake_no, vReference_id);

                        }
                        else
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage("등록되지 않은 바코드입니다.");
                        }

                    //종료시 close시키기
                    //엑셀로 커서가게
                    //바코드세팅 com번호 가져오게하기
                    //기존 USP_BarcodeLabelPrint_R30를 수정하여 같이쓰게 하든가 아니면 별도로 가져오게하기
                    //dispose 예외처리하기
                }

                    //재고확인
                    else
                    {
                        string pFindData = string.Empty;
                        string vPart_code = string.Empty;
                        string vMake_no = string.Empty;
                        string vInspect_no = string.Empty;
                        string vVend_Part_Code = string.Empty;
                        string vReference_id = string.Empty;

                        pfrmPOPMain_WEIGHING_COSMETICSEntity.CRUD = "R";
                        pfrmPOPMain_WEIGHING_COSMETICSEntity.USER_CODE = _pUSER_CODE;
                        //_pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = _luPART_CODE.Text;
                        pFindData = CoFAS_ConvertManager.Bytes2String(yReceiveData, 0, 0);
                        pFindData = pFindData.Substring(0, pFindData.Length - 4);//뒤에 개행문자 지울경우(2자리)
                        frmPOPPartStockCheck frmkey = new frmPOPPartStockCheck(_pUserEntity);
                        frmkey.titleName = "반제품재고확인";
                        frmkey._pBARCODE_NO = pFindData;// "MI181128000001";

                        // if (_pBarcode_Serial.IsOpen)
                        //     _pBarcode_Serial.Close();

                        if (frmkey.ShowDialog() == DialogResult.OK)
                        {
                            // if (!_pBarcode_Serial.IsOpen)
                            //     _pBarcode_Serial.Open() ;

                            string PopupValue = frmkey.ReturnValue1;        //검체채취량
                            string PopupValue2 = frmkey.ReturnValue2;       //검체채취일
                            
                        }
                    }
                }

                //Application.DoEvents(); //화면초기화
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void _Weighing_Received_Data(byte[] yReceiveData)
        {
            try
            {
                if(_gdSUB_VIEW.FocusedRowHandle<0)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("바코드 스캔 또는 원료를 먼저 선택해주세요");
                    return;
                }
                if (yReceiveData.Length > 0)
                {
                    _pWeighing_chk = true;
                    string temp = string.Empty;
                    string weight = string.Empty;

                    temp = CoFAS_ConvertManager.Bytes2String(yReceiveData, 0, 0);
                    temp = temp.Substring(0, temp.Length - 4);//뒤에 개행문자 지울경우(2자리)
                                                              // FindPartCode(temp);
                                                              //종료시 close시키기
                                                              //엑셀로 커서가게
                                                              //바코드세팅 com번호 가져오게하기
                                                              //기존 USP_BarcodeLabelPrint_R30를 수정하여 같이쓰게 하든가 아니면 별도로 가져오게하기
                                                              //dispose 예외처리하기
                                                              //_gdSUB_VIEW.SetFocusedRowCellValue(_gdSUB_VIEW.Columns["INPUT_QTY"], temp);
                    string[   ] kg_split = temp.Split(',');

                    //CI-200A 모델일 경우
                     weight = kg_split[1].Trim().Substring(0, kg_split[1].Trim().Length - 2).Trim();
                   // weight = kg_split[0].Trim().Substring(0, kg_split[0].Trim().Length - 2).Trim();

                    ////NEWTON 모델일 경우
                    //weight = kg_split[2].Trim().Substring(0, kg_split[2].Trim().Length - 3).Trim();

                    //_pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = _luPART_CODE.Text;

                    // 실적등록
                    _pUserEntity.PRODUCTION_ORDER_ID = _luORDER_DATE.Text;
                    frmPOPWeightValuePanel frmkey = new frmPOPWeightValuePanel(_pUserEntity, weight);

                    frmkey.ShowDialog();

                    decimal find_value = 0;
                    find_value = Convert.ToDecimal(weight);
                    string temp_date = _gdSUB_VIEW.GetFocusedRowCellValue("END_DATE").ToString().Replace(".", "");
                    //if (Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"))>Convert.ToInt32(_gdSUB_VIEW.GetFocusedRowCellValue("END_DATE").ToString()))
                    if (Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")) > Convert.ToInt32(temp_date))
                    {
                        if (CoFAS_DevExpressManager.ShowQuestionMessage("유효기한을 초과하였습니다.("+ _gdSUB_VIEW.GetFocusedRowCellValue("END_DATE").ToString() + ")\n그대로 출고하시겠습니까?") == DialogResult.No)
                        {
                            return;
                        }
                    }
                    if (
                        find_value > (_Bom_Qty + (_Bom_Qty * (decimal)0.05))
                        ||
                        ((_Bom_Qty - (_Bom_Qty * (decimal)0.05)) > find_value)
                       )
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("칭량값을 초과했습니다.\n 범위 : "+ (_Bom_Qty + (_Bom_Qty * (decimal)0.05))+" ~ "+ (_Bom_Qty - (_Bom_Qty * (decimal)0.05)));
                        if (CoFAS_DevExpressManager.ShowQuestionMessage("칭량값을 초과했습니다.\n 범위 : " + (_Bom_Qty + (_Bom_Qty * (decimal)0.05)) + " ~ " + (_Bom_Qty - (_Bom_Qty * (decimal)0.05)) + "\n그대로 출고하시겠습니까?") == DialogResult.No)
                        {
                            return;
                        }
                    }

                    
                    CoFAS_ControlManager.InvokeIfNeeded(_gdSUB, () => _gdSUB_VIEW.SetFocusedRowCellValue(_gdSUB_VIEW.Columns["INPUT_QTY"], weight));
                     CoFAS_ControlManager.InvokeIfNeeded(_gdMAIN, () => _gdMAIN_VIEW.SetFocusedRowCellValue(_gdMAIN_VIEW.Columns["INPUT_CHK"], "OK"));



                        DataRow row = null;
                        row = Weighting_Insert_Temp.NewRow();//행추가
                        row["CRUD"]      = "U";
                        row["PART_CODE"] = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_CODE").ToString();
                        row["SPEND_QTY"] = _gdMAIN_VIEW.GetFocusedRowCellValue("SPEND_QTY").ToString();
                        row["INOUT_ID"]  = _gdSUB_VIEW.GetFocusedRowCellValue("INOUT_ID").ToString();
                        row["INPUT_QTY"] = _gdSUB_VIEW.GetFocusedRowCellValue("INPUT_QTY").ToString();
                        row["PROCESS_SEQ"] = _gdMAIN_VIEW.GetFocusedRowCellValue("PROCESS_SEQ").ToString();
                    

                        Weighting_Insert_Temp.Rows.Add(row);

                    _pWeighing_chk = false;
                }

                //Application.DoEvents(); //화면초기화
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //품목코드 찾기(저울스캔시) 
           private void FindPartCode(string pPart_code, string pVend_Part_code,string make_inspect_code ,string pReference_id)
           {
            bool find_cnt = false;

            //제조
            if (_pPROCESS_CODE_MST == "PC01")
            {

                int rowHandle = _gdMAIN_VIEW.LocateByValue("PART_CODE", pPart_code);
                if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                {
                    CoFAS_ControlManager.InvokeIfNeeded(_gdMAIN, () => _gdMAIN_VIEW.FocusedRowHandle = rowHandle);
                    //_gdMAIN_VIEW.FocusedRowHandle = rowHandle;
                    SubFind_DisplayData("R", _gdMAIN_VIEW.GetFocusedRowCellValue("PART_CODE").ToString());
                    find_cnt = true;
                    int rowHandle2 = _gdSUB_VIEW.LocateByValue("INOUT_ID", pReference_id);
                    if (rowHandle2 != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    {
                       //     _gdSUB_VIEW.FocusedRowHandle = rowHandle2;
                        CoFAS_ControlManager.InvokeIfNeeded(_gdSUB, () => _gdSUB_VIEW.FocusedRowHandle = rowHandle2);
                        find_cnt = true;
                        
                    }
                    else
                    {
                        find_cnt = false;
                    }

                }
                else
                {
                    find_cnt = false;
                }
                    //cell.RowIndex

                if (!find_cnt)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("일치하지 않는 시험번호입니다.");
                }
            }
            //포장
            else
            {
                /*
                rg = sheet_0.Range["C12:C27"];    //판정유무, 24 -> 39 (반제품때문에

                IEnumerable<Cell> searchResult = rg.Search(pVend_Part_Code);
                foreach (Cell cell in searchResult)
                {
                   
                        //바코드 자재번호 -> 로트번호(제조번호)를 가져와서 LOT-NO에 입력
                        sheet_0.Cells[cell.RowIndex, 7].SetValue(pFindValue);
                        find_cnt = true;
                }

                if (!find_cnt)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("일치하는 자재코드가 없습니다.");
                }
                */
            }

            find_cnt = false;
            /*
               IWorkbook workbook = _sdMAIN.Document;
               Worksheet sheet_0 = workbook.Worksheets[0];
               Range rg;
        
               rg = sheet_0.Range["D11:D42"];    //판정유무
        
               IEnumerable<Cell> searchResult = rg.Search(pPart_code);
               foreach (Cell cell in searchResult)
               {
                   sheet_0.Cells[cell.RowIndex, 8].SetValue("450.1");
                   //cell.RowIndex
               }
               */

           }

        #endregion


        #region ○ 그리드 초기화 하기 - InitializeGrid()
        private void InitializeGrid()
        {
            try
            {
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                   
                    _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                    _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));

                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick; ;
                }

                //_gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pWINDOW_NAME, _gdSUB.Name.ToString()));
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _gdMAIN_VIEW_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                string strPART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                _Bom_Qty = Convert.ToDecimal(gv.GetFocusedRowCellValue("SPEND_QTY").ToString());
                //  string strPART_TYPE = gv.GetFocusedRowCellValue("PART_TYPE").ToString();
                string strCRUD = "R";
               // decimal pQTY = Convert.ToDecimal(gv.GetFocusedRowCellValue("CONTRACT_QTY").ToString());
                pfrmPOPMain_WEIGHING_COSMETICSEntity.PART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                pfrmPOPMain_WEIGHING_COSMETICSEntity.PROCESS_SEQ = gv.GetFocusedRowCellValue("PROCESS_SEQ").ToString();
                
                SubFind_DisplayData(strCRUD, strPART_CODE);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        #endregion


        #region ○ 서브조회 - SubFind_DisplayData()
        //(string pCRUD, string pPART_CODE, string pPART_NAME)
        private void SubFind_DisplayData(string strCRUD, string strPART_CODE)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new frmPOPMain_WEIGHING_COSMETICSBusiness().frmPOPMain_WEIGHING_COSMETICS_Sub_Return(strCRUD, strPART_CODE).Tables[0];

                if (strCRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && strCRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
                }
                else
                {
                    // CoFAS_DevExpressManager.BindGridControl(_gdVEND, _gdVEND_VIEW, null);
                    CoFAS_ControlManager.InvokeIfNeeded(_gdSUB, () => _gdSUB.DataSource = null);
                    //_gdSUB.DataSource = null;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                // _gdSUB_VIEW.BestFitColumns();
                CoFAS_ControlManager.InvokeIfNeeded(_gdSUB, () => _gdSUB_VIEW.BestFitColumns());

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }


        #endregion
        private void _ucbtRESULT_REG_Click(object sender, EventArgs e)
        {
            // 실적등록
            _pUserEntity.PRODUCTION_ORDER_ID = _luORDER_DATE.Text;
            frmPOPSelect_INSPECT_COSMETICS frmkey = new frmPOPSelect_INSPECT_COSMETICS(_pUserEntity);
            if (frmkey.ShowDialog() == DialogResult.OK)
            {
                //string PopupValue = frmkey.ReturnValue1;
                //DisplayMessage(_ucbtRESULT_REG.Text + " -> " + PopupValue);
                MainFind_DisplayData();
            }
        }

        //BOM조회
        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pPOPProductionOrderEntity.CORP_CODE = _pUserEntity.CORP_CODE;
                _pPOPProductionOrderEntity.USER_CODE = _pUserEntity.USER_CODE;
                _pPOPProductionOrderEntity.CRUD = "R";//
                _pPOPProductionOrderEntity.LANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _pPOPProductionOrderEntity.PROCESS_CODE = _pUserEntity.PROCESS_CODE;
                _pPOPProductionOrderEntity.RESOURCE_CODE = _pUserEntity.RESOURCE_CODE;
                _pPOPProductionOrderEntity.PRODUCTION_ORDER_ID = pfrmPOPMain_WEIGHING_COSMETICSEntity.PRODUCTION_ORDER_ID;// _luORDER_DATE.Text;
                //string pCRUD, string pPART_CODE, string pPART_TYPE, string pLANGUAGE_TYPE, decimal pQTY
                _dtList = new frmPOPMain_WEIGHING_COSMETICSBusiness().frmPOPMain_WEIGHING_COSMETICS_Main_Return("R", pfrmPOPMain_WEIGHING_COSMETICSEntity.PART_CODE, pfrmPOPMain_WEIGHING_COSMETICSEntity.LANGUAGE_TYPE, pfrmPOPMain_WEIGHING_COSMETICSEntity.PRODUCTION_ORDER_QTY, pfrmPOPMain_WEIGHING_COSMETICSEntity.PRODUCTION_ORDER_ID);

                if (_pPOPProductionOrderEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pPOPProductionOrderEntity.CRUD == ""))
                {
                    //데이터 필드에 맞춰 자동 바인딩
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                    _gdMAIN_VIEW.RowHeight = 35;
                    _gdMAIN_VIEW.Appearance.Row.Font = new Font("굴림", 15);
                    _gdMAIN_VIEW.RowStyle += new RowStyleEventHandler(gdMAIN_VIEW_RowStyle);

                    _gdSUB_VIEW.RowHeight = 20;
                    _gdSUB_VIEW.Appearance.Row.Font = new Font("굴림", 13);
                    _gdSUB_VIEW.RowCellStyle += new RowCellStyleEventHandler(gdSUB_VIEW_RowCellStyle);
                    pfrmPOPMain_WEIGHING_COSMETICSEntity.ORDER_FILE = _dtList.Rows[0]["ORDER_FILE"].ToString();
                    _gdSUB.DataSource = null;
                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("PART_CODE", pfrmPOPMain_WEIGHING_COSMETICSEntity.PART_CODE);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;

                        SubFind_DisplayData("R", pfrmPOPMain_WEIGHING_COSMETICSEntity.PART_CODE);
                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }


                    //  _pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_ORDER_ID = _dtList.Rows[0]["PRODUCTION_ORDER_ID"].ToString();
                    //  _luORDER_DATE.Text = _dtList.Rows[0]["PRODUCTION_ORDER_DATE"].ToString();
                    //  _luORDER_QTY.Text = _dtList.Rows[0]["PRODUCTION_ORDER_QTY"].ToString();
                    //  _luPART_NAME.Text = _dtList.Rows[0]["PART_NAME"].ToString();
                    //  // _luPART_CODE.Text = frmOr.dtReturn.Rows[0]["PART_CODE"].ToString();
                    //  _luPART_CODE.Text = _dtList.Rows[0]["VEND_PART_CODE"].ToString();
                    //  _pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = _dtList.Rows[0]["PART_CODE"].ToString();
                    //  _pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_ORDER_ID = _dtList.Rows[0]["PRODUCTION_ORDER_ID"].ToString();
                    //  pfrmPOPMain_WEIGHING_COSMETICSEntity.PRODUCTION_ORDER_QTY = _dtList.Rows[0]["PRODUCTION_ORDER_QTY"].ToString();
                }
                else
                {
                    _gdMAIN.DataSource = null;
                    _gdSUB.DataSource = null;
                    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                }
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

        private void gdMAIN_VIEW_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            // if (((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused) != 0) && ((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.GridFocused) != 0))
            //     e.Appearance.Assign(view.PaintAppearance.FocusedRow);
            if (view.FocusedRowHandle == e.RowHandle)
            {
                e.Appearance.BackColor = Color.Orange;
                e.Appearance.Font = new Font("굴림", 15, FontStyle.Bold);
            }
        }
        private void gdSUB_VIEW_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.FocusedRowHandle == e.RowHandle)
            {
                e.Appearance.BackColor = Color.Orange;
                e.Appearance.Font = new Font("굴림", 10, FontStyle.Bold);

                //if (e.Column != view.Columns["INPUT_QTY"])
                //    return;

                e.Appearance.BackColor = Color.LightSkyBlue;
                e.Appearance.Font = new Font("굴림", 10, FontStyle.Bold);

            }

            /*
            if (e.Column != view.Columns["INPUT_QTY"])
                return;
            
                e.Appearance.BackColor = Color.LightSkyBlue;
                e.Appearance.Font = new Font("굴림", 10, FontStyle.Bold);
                */

        }

        private void _ucbtOUT_REG_Click(object sender, EventArgs e)
        {
           // pfrmPOPMain_WEIGHING_COSMETICSEntity.CORP_CODE = _pCORP_CODE;
            pfrmPOPMain_WEIGHING_COSMETICSEntity.USER_CODE = _pUserEntity.USER_CODE;
            int cnt = 0;
            int input_qty_cnt = 0;
            
            DataTable tDataTable = _gdSUB_VIEW.GridControl.DataSource as DataTable;
            DataTable tTempData2 = new DataTable();
            DataTable tTempData = new DataTable();

            cnt = Weighting_Insert_Temp.Rows.Count;
            if (CoFAS_DevExpressManager.ShowQuestionMessage(cnt+"건 출고를 하시겠습니까?") == DialogResult.Yes)
            {
                    pfrmPOPMain_WEIGHING_COSMETICSEntity.CRUD = "C";
                    pfrmPOPMain_WEIGHING_COSMETICSEntity.INOUT_CODE = "MR050020"; //MR050020 = 생산출고
                    bool isError;
                    isError = new frmPOPMain_WEIGHING_COSMETICSBusiness().frmPOPMain_WEIGHING_COSMETICS_Save(pfrmPOPMain_WEIGHING_COSMETICSEntity, Weighting_Insert_Temp);

                    if (isError)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                        //      CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    }
                    else
                    {
                        //정상 처리
                        CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                        //       CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                        _pLocation_Code = pfrmPOPMain_WEIGHING_COSMETICSEntity.RTN_KEY;  //저장 위치 
                        Weighting_Insert_Temp.Rows.Clear();
                        MainFind_DisplayData();
                    
                }
            }

            //한건씩 입력
            //20190123
            /*
            decimal find_value = 0;
            input_qty_cnt =Convert.ToInt32(CoFAS_ConvertManager.DataTable_FindCount(tDataTable, "CRUD ='U'", ""));
            if(input_qty_cnt>1)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("칭량은 한건씩 해주세요.");
                return;
            }
            tTempData2 = CoFAS_ConvertManager.DataTable_FindValue(tDataTable, "CRUD ='U'", "");
            foreach (DataRow row in tTempData2.Rows)
            {
                find_value = Convert.ToDecimal(row["INPUT_QTY"].ToString());
            }

                if (CoFAS_DevExpressManager.ShowQuestionMessage("출고를 하시겠습니까?") == DialogResult.Yes)
            {
                if(
                    find_value > (_Bom_Qty+(_Bom_Qty * (decimal)0.05))
                    ||
                    ((_Bom_Qty - (_Bom_Qty * (decimal)0.05)) > find_value)
                   )
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("칭량값을 초과했습니다.\n 범위 : "+ (_Bom_Qty + (_Bom_Qty * (decimal)0.05))+" ~ "+ (_Bom_Qty - (_Bom_Qty * (decimal)0.05)));
                    if (CoFAS_DevExpressManager.ShowQuestionMessage("칭량값을 초과했습니다.\n 범위 : " + (_Bom_Qty + (_Bom_Qty * (decimal)0.05)) + " ~ " + (_Bom_Qty - (_Bom_Qty * (decimal)0.05)) + "\n그대로 출고하시겠습니까?") == DialogResult.No)
                    {
                        return;
                    }
                }

                { 
                pfrmPOPMain_WEIGHING_COSMETICSEntity.CRUD = "C";
                pfrmPOPMain_WEIGHING_COSMETICSEntity.INOUT_CODE = "MR050020"; //MR050020 = 생산출고
                bool isError;
                isError = new frmPOPMain_WEIGHING_COSMETICSBusiness().frmPOPMain_WEIGHING_COSMETICS_Save(pfrmPOPMain_WEIGHING_COSMETICSEntity, tDataTable);

                if (isError)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    //      CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    //       CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    _pLocation_Code = pfrmPOPMain_WEIGHING_COSMETICSEntity.RTN_KEY;  //저장 위치 
                    MainFind_DisplayData();



                }
            }
            }
                */
        }
        private void _ucbtWORK_ORDER_Click(object sender, EventArgs e)
        {

            //작업지시
            frmPOPOrder.PROCESS_MST_CODE_COSMETICS = "PC01";
            frmPOPOrder frmOr = new frmPOPOrder(_pUserEntity);
            frmOr.ShowDialog();
            if (frmOr.dtReturn == null)
            {
                frmOr.Dispose();
                return;
            }

            if (frmOr.dtReturn != null && frmOr.dtReturn.Rows.Count > 0)
            {
                _luORDER_DATE.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_DATE"].ToString();
                _luORDER_QTY.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_QTY"].ToString();
                _luPART_NAME.Text = frmOr.dtReturn.Rows[0]["PART_NAME"].ToString();
                // _luPART_CODE.Text = frmOr.dtReturn.Rows[0]["PART_CODE"].ToString();
                _luPART_CODE.Text = frmOr.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();

                pfrmPOPMain_WEIGHING_COSMETICSEntity.PART_CODE = frmOr.dtReturn.Rows[0]["PART_CODE"].ToString();
                pfrmPOPMain_WEIGHING_COSMETICSEntity.PRODUCTION_ORDER_ID = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_ID"].ToString();

                pfrmPOPMain_WEIGHING_COSMETICSEntity.PROCESS_CODE_MST = frmOr.dtReturn.Rows[0]["PROCESS_CODE_MST"].ToString();// _pUserEntity.PROCESS_CODE;

                pfrmPOPMain_WEIGHING_COSMETICSEntity.PRODUCTION_ORDER_QTY = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_QTY"].ToString();
                pfrmPOPMain_WEIGHING_COSMETICSEntity.ORDER_FILE = frmOr.dtReturn.Rows[0]["ORDER_FILE"].ToString();
                pfrmPOPMain_WEIGHING_COSMETICSEntity.CRUD = "R";
                MainFind_DisplayData();
                Weighting_Insert_Temp.Rows.Clear();

            }


            frmOr.Dispose();
        }

        private void _ucbtKEYPAD_Click(object sender, EventArgs e)
        {
            //키패드 호출
            frmPopupKeypad frmkey = new frmPopupKeypad();
           // frmkey.titleName ="수량입력";
            if (frmkey.ShowDialog() == DialogResult.OK)
            {
                string PopupValue = frmkey.ReturnValue1;
                //_gdSUB_VIEW.GetFocusedRowCellValue(_gdSUB_VIEW.Columns["INPUT_QTY"]).ToString()
                _gdSUB_VIEW.SetFocusedRowCellValue(_gdSUB_VIEW.Columns["INPUT_QTY"], PopupValue);
            }

        }

        private void _ucbtORDERDOC_REG_Click(object sender, EventArgs e)
        {
            try
            {
                if (pfrmPOPMain_WEIGHING_COSMETICSEntity.PRODUCTION_ORDER_ID != "" && pfrmPOPMain_WEIGHING_COSMETICSEntity.PRODUCTION_ORDER_ID != null)
                {
                    string part_type = "1005";
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.USER_CODE = _pUSER_CODE;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.FONT_TYPE = _pFONT_SETTING;


                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.FTP_ID = _pUserEntity.FTP_ID;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.FTP_IP_PORT = _pUserEntity.FTP_IP_PORT;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.FTP_PATH = _pUserEntity.FTP_IP_PORT;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.FTP_PW = _pUserEntity.FTP_PW;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.USER_CODE = _pUserEntity.USER_CODE;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.USER_NAME = _pUserEntity.USER_NAME;
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.P_WINDOW_NAME = this._pWINDOW_NAME;

                    //구 칭량실일경우
                    if (_pTERMINAL_CODE == "TP010003")
                    {
                        CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.pCOM_PORT = COM_PORT3;
                    }
                    else
                    {
                        CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.pCOM_PORT = COM_PORT2;
                    }
                    //CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.pCOM_PORT = COM_PORT2;

                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.ARRAY = new object[5] { "ucWorkOrderDocRegPopup", pfrmPOPMain_WEIGHING_COSMETICSEntity.PROCESS_CODE_MST, pfrmPOPMain_WEIGHING_COSMETICSEntity.PRODUCTION_ORDER_ID, pfrmPOPMain_WEIGHING_COSMETICSEntity.ORDER_FILE, pfrmPOPMain_WEIGHING_COSMETICSEntity.TERMINAL_CODE}; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS.ARRAY_CODE = new object[3] { "", "", part_type };
                    CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS xfrmCommonPopup = new CoFAS_MES.POP.Popup.frmPOPSelect_WorkOrderDoc_COSMETICS("ucWorkOrderDocRegPopup"); //유저컨트롤러 설정 부분

                    //구 칭량실일경우
                    if (_pTERMINAL_CODE == "TP010003")
                    {
                        if (Array.Exists(PC_serial_port, port => port == COM_PORT3))
                        {
                            if (_pWeighing_Serial2.IsOpen)
                                _pWeighing_Serial2.Close();

                        }

                    }
                    else
                    {
                        if (Array.Exists(PC_serial_port, port => port == COM_PORT2))
                        {
                            if (_pWeighing_Serial.IsOpen)
                                _pWeighing_Serial.Close();

                        }
                    }
                    
                    xfrmCommonPopup.ShowDialog();


                    if (xfrmCommonPopup.dtReturn == null)
                    {
                        xfrmCommonPopup.Dispose();
                        MainFind_DisplayData();
                        return;
                    }

                    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                    {
                        //_luT_PART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["ORDER_ID"].ToString();
                        //_luT_PART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                    }

                    xfrmCommonPopup.Dispose();
                    _pPOPSelect_INSPECT_COSMETICSEntity.CRUD = "R";
                    _pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_ORDER_ID = "";
                    _pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = "";
                    // _pPOPSelect_INSPECT_COSMETICSEntity.PART_NAME = "";
                    MainFind_DisplayData();
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 선택하여주시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 선택하여주시기 바랍니다.");
                    return;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        //블루투스 연결
        private void _ucbtBLUETOOTH_PAIRING_Click(object sender, EventArgs e)
        {
            //blue_Server.Start();

        }

        private void _ucbtPART_STOCK_Click(object sender, EventArgs e)
        {
            _pPART_STOCK_YN = _pPART_STOCK_YN == false ? true : false;
        }


        private void _gdSUB_VIEW_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //저울에서 이미 입력했기때문에 패스
            if (_pWeighing_chk)
            {
                _pWeighing_chk = false;
                return;
            }
            if (e.Column.Caption == "*")
                return;
            decimal find_value = 0;
            decimal stock_value = 0;
            string process_seq = string.Empty;

            //입력수량(또는 저울값)
            find_value = Convert.ToDecimal(_gdSUB_VIEW.GetFocusedRowCellValue("INPUT_QTY").ToString());
            //재고
            stock_value = Convert.ToDecimal(_gdSUB_VIEW.GetFocusedRowCellValue("POSSIBLE_QTY").ToString());

            process_seq = _gdMAIN_VIEW.GetFocusedRowCellValue("PROCESS_SEQ").ToString();

            string temp_date = _gdSUB_VIEW.GetFocusedRowCellValue("END_DATE").ToString().Replace(".", "");
            //if (Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"))>Convert.ToInt32(_gdSUB_VIEW.GetFocusedRowCellValue("END_DATE").ToString()))
            //문자가 포함된 유효기간이여서 수동으로 확인해야함
            /*
            if (Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")) > Convert.ToInt32(temp_date))
            {
                if (CoFAS_DevExpressManager.ShowQuestionMessage("유효기한을 초과하였습니다.(" + _gdSUB_VIEW.GetFocusedRowCellValue("END_DATE").ToString() + ")\n그대로 출고하시겠습니까?") == DialogResult.No)
                {
                   // _gdMAIN_VIEW.SetFocusedRowCellValue(_gdMAIN_VIEW.Columns["INPUT_QTY"], "0");
                   // _gdMAIN_VIEW.SetFocusedRowCellValue(_gdMAIN_VIEW.Columns["CRUD"], "");
                    return;
                }
            }
            */
            if (CoFAS_DevExpressManager.ShowQuestionMessage("유효기한은 (" + _gdSUB_VIEW.GetFocusedRowCellValue("END_DATE").ToString() + ")입니다.\n 출고하시겠습니까?") == DialogResult.No)
            {
                // _gdMAIN_VIEW.SetFocusedRowCellValue(_gdMAIN_VIEW.Columns["INPUT_QTY"], "0");
                // _gdMAIN_VIEW.SetFocusedRowCellValue(_gdMAIN_VIEW.Columns["CRUD"], "");
                return;
            }
            //수동으로 입력할때 재고보다 많이 입력됬을경우
            if (find_value> stock_value)
            {
                if (CoFAS_DevExpressManager.ShowQuestionMessage("입력수량이 재고량보다 많습니다. \n그대로 입력하시겠습니까?") == DialogResult.No)
                {
                   // _gdMAIN_VIEW.SetFocusedRowCellValue(_gdMAIN_VIEW.Columns["INPUT_QTY"], "0");
                   // _gdMAIN_VIEW.SetFocusedRowCellValue(_gdMAIN_VIEW.Columns["CRUD"], "");
                    return;
                }
            }

            if (
                find_value > (_Bom_Qty + (_Bom_Qty * (decimal)0.05))
                ||
                ((_Bom_Qty - (_Bom_Qty * (decimal)0.05)) > find_value)
               )
            {
                //CoFAS_DevExpressManager.ShowInformationMessage("칭량값을 초과했습니다.\n 범위 : "+ (_Bom_Qty + (_Bom_Qty * (decimal)0.05))+" ~ "+ (_Bom_Qty - (_Bom_Qty * (decimal)0.05)));
                if (CoFAS_DevExpressManager.ShowQuestionMessage("칭량값을 초과했습니다.\n 범위 : " + (_Bom_Qty + (_Bom_Qty * (decimal)0.05)) + " ~ " + (_Bom_Qty - (_Bom_Qty * (decimal)0.05)) + "\n그대로 출고하시겠습니까?") == DialogResult.No)
                {
                    return;
                }
            }
            CoFAS_ControlManager.InvokeIfNeeded(_gdMAIN, () => _gdMAIN_VIEW.SetFocusedRowCellValue(_gdMAIN_VIEW.Columns["INPUT_CHK"], "OK"));

            decimal input_value = 0;
            decimal before_input_value = 0;
            decimal temp_total = 0;
            input_value =Convert.ToDecimal(_gdSUB_VIEW.GetFocusedRowCellValue("INPUT_QTY").ToString());
            before_input_value = Convert.ToDecimal((_gdMAIN_VIEW.GetFocusedRowCellValue("INPUT_TOTAL").ToString()==""?"0": _gdMAIN_VIEW.GetFocusedRowCellValue("INPUT_TOTAL").ToString()));
            temp_total = input_value + before_input_value;
            CoFAS_ControlManager.InvokeIfNeeded(_gdMAIN, () => _gdMAIN_VIEW.SetFocusedRowCellValue(_gdMAIN_VIEW.Columns["INPUT_TOTAL"], temp_total.ToString()));

            DataRow row = null;
            row = Weighting_Insert_Temp.NewRow();//행추가
            row["CRUD"] = "U";
            row["PART_CODE"] = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_CODE").ToString();
            row["SPEND_QTY"] = _gdMAIN_VIEW.GetFocusedRowCellValue("SPEND_QTY").ToString();
            row["INOUT_ID"] = _gdSUB_VIEW.GetFocusedRowCellValue("INOUT_ID").ToString();
            row["INPUT_QTY"] = _gdSUB_VIEW.GetFocusedRowCellValue("INPUT_QTY").ToString();
            row["PROCESS_SEQ"] = _gdMAIN_VIEW.GetFocusedRowCellValue("PROCESS_SEQ").ToString();
            

            Weighting_Insert_Temp.Rows.Add(row);
            _pWeighing_chk = false;
        }

        private void _ucbtINSPECT_REG_Click(object sender, EventArgs e)
        {

        }
    }
}
