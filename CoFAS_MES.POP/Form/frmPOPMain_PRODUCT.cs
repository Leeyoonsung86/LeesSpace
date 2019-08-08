using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraPdfViewer.Commands;

using System.IO;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Entity;

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraEditors;

namespace CoFAS_MES.POP
{
    public partial class frmPOPMain_PRODUCT : frmBasePOP
    {
        
       // private System.Threading.Timer tmrTime; //시간 타이머 스레드
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); //시간 타이머 스레드

        public string _pCORP_CDDE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        private string _pMSG_EXIT_QUESTION = string.Empty;   // 종료 하겠습니까?
        public int _pFONT_SIZE = 21;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private bool exitflag = false;
        private string Image_nm = null;
        private string Image_nm_2 = null;
        private string Image_nm2 = null;
        private string Image_nm3 = null;
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보

        private static MemoryStream _pStream2 = null;
        private static MemoryStream _pStream3 = null;
        private static Image _pIMAGE_DATA = null;
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtList_print = null; //조회 데이터 리스트 (바코드 발행)
        private DataTable _dtList_terminal = null; //터미널 상세정보 리스트

        private CoFAS_Serial _pCoFAS_Serial = null;  // 시리얼 생성

        public UserEntity _pUserEntity = null;
        //private POPSelect_INSPECT_MIXEntity _pPOPWorkResult_MIXEntity = null; // 엔티티 생성
        private POPWorkResult_MIXEntity _pPOPWorkResult_MIXEntity = null;

        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티
        private string _pMSG_NOT_DISPLAY_NOT_SAVE = string.Empty;    //저장하지 않아서 볼 수 없습니다. 

        private int ok_num = 0; // 양품수량
        private int ng_num = 0; // NG수량

        private int re_num = 0; // 작업수량
        private int or_num = 0; // 목표수량

        private string Print_cmd = null; // 바코드 CMD
        private string unit = null; // 표시 단위
        private string c_yn = null;
        private string _pTerminal_code = null;
        private string _pTerminal_name = null;
        private string _pOrder_id = null;
        private string _pPart_code2 = null;

        PdfViewerCommand zoomIn;
        PdfViewerCommand zoomOut;
        PdfHandToolCommand handtool;

        private string _pP_Name = null;
        private string _pP_Code = null;
        private string _pP_Vend = null;
        private string _pP_SEQ = null;
        private string _pP_QTY = null;

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

        public static Image IMAGE_DATA
        {
            get { return _pIMAGE_DATA; }
            set { _pIMAGE_DATA = value; }
        }

        public static MemoryStream MS
        {
            get { return _pStream2; }
            set { _pStream2 = value; }
        }

        public static MemoryStream MS2
        {
            get { return _pStream3; }
            set { _pStream3 = value; }
        }

        public frmPOPMain_PRODUCT(UserEntity pUserEntity, string termial_code, string terminal_name)
        {

            InitializeComponent();

            _pUserEntity = pUserEntity;
            _pTerminal_code = termial_code;
            _pTerminal_name = terminal_name;

            _pMessageEntity = new MessageEntity();

            _pFONT_SETTING = new Font(_pUserEntity.FONT_TYPE, _pUserEntity.FONT_SIZE);

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
        //#region 타이머
        //private void time_tick(object sender, EventArgs e)
        //{
            
        //    timer.Tick -= new EventHandler(time_tick);
        //    timer.Interval = 1;
        //    if(Image_nm == null)
        //    {
        //        timer.Enabled = true;
        //        tabControl1.SelectTab(tabPage4);
        //        timer.Tick += new EventHandler(time_tick4);
        //        timer.Start();
        //    }
        //    else if (Image_nm.Contains(".pdf"))
        //    {
                
        //        _pdfViewer.Visible = true;
        //        timer.Enabled = true;
        //        timer.Interval = 60000;
        //        tabControl1.SelectTab(tabPage5);
                
        //        zoomIn = new PdfZoomInCommand(_pdfViewer);
        //        zoomOut = new PdfZoomOutCommand(_pdfViewer);
        //        _pdfViewer.CursorMode = PdfCursorMode.HandTool;
        //        timer.Tick += new EventHandler(time_tick4);
        //        timer.Start();
        //    }
                   
        //}
        //private void time_tick2(object sender, EventArgs e)
        //{
        //    timer.Tick -= new EventHandler(time_tick2);
        //    timer.Interval = 1;
        //    if (Image_nm_2 == null)
        //    {
        //        if (Image_nm == null)
        //        {
        //            timer.Enabled = true;
        //            tabControl1.SelectTab(tabPage4);
        //            timer.Tick += new EventHandler(time_tick4);
        //            timer.Start();
        //        }
        //        else
        //        {
        //            timer.Enabled = true;
        //            tabControl1.SelectTab(tabPage5);
        //            timer.Tick += new EventHandler(time_tick);
        //            timer.Start();
        //        }

        //    }
        //    else if (Image_nm_2.Contains(".pdf"))
        //    {
               
        //        _pdfViewer2.Visible = true;
        //        timer.Enabled = true;
        //        timer.Interval = 300000;
        //        tabControl1.SelectTab(tabPage6);
                
        //        zoomIn = new PdfZoomInCommand(_pdfViewer2);
        //        zoomOut = new PdfZoomOutCommand(_pdfViewer2);
        //        _pdfViewer2.CursorMode = PdfCursorMode.HandTool;
        //        timer.Tick += new EventHandler(time_tick);
        //        timer.Start();

        //    }

        //}
        //private void time_tick3(object sender, EventArgs e)
        //{
        //    timer.Interval = 1;
        //    timer.Tick -= new EventHandler(time_tick3);
        //    timer.Enabled = true;
        //    timer.Interval = 10000;
        //    tabControl1.SelectTab(tabPage3);
        //    timer.Tick += new EventHandler(time_tick2);
        //    timer.Start();
        //}
        //private void time_tick4(object sender, EventArgs e)
        //{
        //    timer.Interval = 1;
        //    timer.Tick -= new EventHandler(time_tick4);
        //    timer.Enabled = true;
        //    timer.Interval = 60000;
        //    tabControl1.SelectTab(tabPage4);
        //    timer.Tick += new EventHandler(time_tick3);
        //    timer.Start();
        //}
        //#endregion
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
                if (CoFAS_DevExpressManager.ShowQuestionMessage("終了しますか？") == DialogResult.No)
                {
                    pFormClosingEventArgs.Cancel = true;
                    return ;
                }

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
                InitializeCorporationCI();
                Initialize();
                InitializeSetting();
             //   SetHardware();
             //   Send_Notice();
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                


            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = _pFONT_SETTING;//화면에 모든 항목 폰트 재설정
                //dxWaitViewManager.CloseWaitForm();
            }
        }
        #endregion

        #region ○ Label 내 AutoFontSize
        public void FontResize(LabelControl lbl)
        {

            Font ft = lbl.Font;

            try
            {
                if (lbl.Height > 4)
                {
                    string[] str = lbl.Text.Split('\n');

                    string maxText = string.Empty;
                    int maxlength = 0;

                    if (str.Length > 0)
                    {
                        maxText = str[0].Replace("\n", string.Empty);
                        maxlength = str[0].Replace("\n", string.Empty).Length + 1;
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (str[i].Replace("\n", string.Empty).Length > maxlength)
                            {
                                maxlength = str[i].Replace("\n", string.Empty).Length;
                                maxText = str[i].Replace("\n", string.Empty);
                            }
                        }

                        if (maxText == "") return;

                        int textWidth = System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Width;

                        //if ((textWidth > 0 && (fnt.Size * lbl.Width / 72 / 2) - 2 < lbl.Height) && lbl.Width > textWidth)

                        int textHeight = System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Height * str.Length;
                        if (textHeight < lbl.Height && lbl.Width > textWidth)
                        {
                            bool result = false;

                            //크게 해준다.
                            while (lbl.Width > System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Width && lbl.Height > (ft.Height * str.Length) && lbl.Height > System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Height * str.Length)
                            {
                                result = true;
                                ft = new Font(ft.FontFamily, ft.Size + 0.5f, ft.Style);
                                //lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size + 0.5f, lbl.Font.Style);
                            }
                            if (result)
                            {
                                ft = new Font(ft.FontFamily, ft.Size - 0.5f, ft.Style);
                                //lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size - 0.5f, lbl.Font.Style);
                            }
                        }
                        else
                        {
                            //작게 해준다
                            while (lbl.Width < System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Width || lbl.Height < System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Height * str.Length)
                            {
                                if (ft.Size >= 0.6)
                                {
                                    ft = new Font(ft.FontFamily, ft.Size - 0.5f, ft.Style);
                                    //lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size - 0.5f, lbl.Font.Style);
                                }
                                else
                                    break;
                            }
                        }
                    }
                }
                else
                    return;

                lbl.Font = ft;
            }
            catch (Exception ex)
            {
                //LogManager.Error(this.GetType(), ex.ToString(), ex);
            }
        }
        #endregion
     
        #region ○ 화면 로고 초기화 - InitializeCorporationCI()
        private void InitializeCorporationCI()
        {
            //DataTable dtCI = new SystemSettingBusiness().CI_Download();
            //if (dtCI != null && (dtCI.Rows[0]["LOGO_FIRST"]).ToString().Length > 0 && (((byte[])dtCI.Rows[0]["LOGO_FIRST"]).Length > 0 && dtCI.Rows.Count > 0))
            //{
            //    if (System.IO.File.Exists(Application.StartupPath + "\\" + "logo.png"))
            //    {
            //        _peCI.Image.Dispose();
            //        _peCI.Image = null;
            //        System.IO.File.Delete(Application.StartupPath + "\\" + "logo.png");
            //    }

            //    Image imgCI = CoFAS_ConvertManager.byteArrayToImage((byte[])dtCI.Rows[0]["LOGO_FIRST"]);
            //    if (imgCI != null)
            //    {
            //        imgCI.Save(Application.StartupPath + "\\" + "logo.png");
            //    }
            //}

            if (System.IO.File.Exists(Application.StartupPath + "\\" + "logo.png"))
            {
                _peCI.Image = Image.FromFile(Application.StartupPath + "\\" + "logo.png");                
            }
            else
            {
                _peCI.Image = Properties.Resources.None;
            }
        }
        #endregion

        #region ○ DB연결 초기화 - Initialize()
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
                   //"0we11Passw0rd!@#dbmes"
               );

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Initialize()", pException);
            }
        }
        #endregion

        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
                _pnRight.Visible = false;

                //메인 화면 전역 변수 처리
                
                //회사코드
                _pCORP_CDDE = "0319965552";//MainForm.UserEntity.CORP_CODE;
                //_pUSER_CODE = "admin@coever.co.kr";// MainForm.UserEntity.USER_CODE;
                //_pUSER_NAME = "";//MainForm.UserEntity.USER_NAME;
                //_pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                //_pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFTP_ID = _pUserEntity.FTP_ID;
                _pFTP_PATH = _pUserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PW = _pUserEntity.FTP_PW;

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
                _lbTitle.Text = _pUserEntity.POP_TITLE + " " + _pTerminal_name;
                _lbHeader.Text = "";
                DisplayMessage("");
                Image_nm = null;

                _luPART_NAME.Text = "";
                _luPART_CODE.Text = "";
                _luORDER_ID.Text = "";
                _luORDER_DATE.Text = "";
                _luORDER_QTY.Text = "";
                _luNG_QTY.Text = "";
                _luRESULT_QTY.Text = "";
                _luOK_QTY.Text = "";

                _luPART_CODE.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                _luPART_NAME.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


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
                InitializeControl();
                //화면 설정 언어 & 명칭 변경. ==고정==

                _pPOPWorkResult_MIXEntity = new POPWorkResult_MIXEntity();
                _pPOPWorkResult_MIXEntity.CORP_CODE = _pCORP_CDDE;
                _pPOPWorkResult_MIXEntity.USER_CODE = _pUSER_CODE;
                _pPOPWorkResult_MIXEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pPOPWorkResult_MIXEntity.PROCESS_CODE = "";
                _pPOPWorkResult_MIXEntity.RESOURCE_CODE = "";

                //그리드 설정

                //   double ddd = Math.Acos(0.912);

                
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _pPOPWorkResult_MIXEntity.USER_CODE = _pUserEntity.USER_CODE;
                    _pFirstYN = false;
                }

                //버튼 세팅
                //if (_pUserEntity.PROCESS_CODE == "frmPOPMain_PRODUCT_PACKET")
                //{
                //    _ucbtPRINT_REG.Visible = true;

                    SetHardware();
                //}

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

        #region ○ H/W 세팅시
        private void SetHardware()
        {
            try
            {
                if (_dtList_terminal == null)
                {
                    
                    _pPOPWorkResult_MIXEntity.TERMINAL_CODE = _pTerminal_code;

                    _dtList_terminal = new frmPOPMain_PRODUCT_Work_MIXBusiness().frmPOPMain_PRODUCT_Work_MIX_terminal_Info(_pPOPWorkResult_MIXEntity);

                    for (int i = 0; i < _dtList_terminal.Rows.Count; i++)
                    {

                        string infoName = _dtList_terminal.Rows[i]["INFO_NAME"].ToString();
                        string partName = _dtList_terminal.Rows[i]["INFO_PORTNAME"].ToString();
                        int baudRate = Convert.ToInt32(_dtList_terminal.Rows[i]["INFO_BAUDRATE"].ToString());
                        string parity = _dtList_terminal.Rows[i]["INFO_PARITY"].ToString();
                        int dataBits = Convert.ToInt32(_dtList_terminal.Rows[i]["INFO_DATABITS"].ToString());
                        string stopBits = _dtList_terminal.Rows[i]["INFO_STOPBITS"].ToString();

                        _pCoFAS_Serial = new CoFAS_Serial(partName, baudRate, parity, dataBits, stopBits);
                        _pCoFAS_Serial.Open();

                        if (infoName.Contains("스캐너"))
                        {
                            // 연결할 H/W 연결상태 표시. (연동시 변경)
                            lc_1.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;
                        }
                        else if (infoName.Contains("프린터"))
                        {
                            lc_0.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;
                        }
                        //CoFAS_DevExpressManager.ShowInformationMessage("POP Start Complete");
                    }
                }

            }
            catch (Exception ex)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("POP Serial Error");
            }
        }

        #endregion

        #region ○ 버튼 클릭시

        private void btnCmd_Click(object pSender, EventArgs pEventArgs)
        {
            SimpleButton pCmd = pSender as SimpleButton;

            string sCls = pCmd.Name.Substring(6, 2);

            

            switch (sCls)
            {

                case "10":
                    // 실적등록
                    frmPopupKeypad frmkey = new frmPopupKeypad();
                    frmkey.titleName = pCmd.Text;
                    if(frmkey.ShowDialog() == DialogResult.OK)
                    {
                        string PopupValue = frmkey.ReturnValue1;
                        DisplayMessage(pCmd.Text + " -> " + PopupValue);
                    }
                    
                    break;

                case "20":
                    // 불량처리
                    frmPOPBad frmb = new frmPOPBad();
                    frmb.titleName = pCmd.Text;
                    if (frmb.ShowDialog() == DialogResult.OK)
                    {
                        string PopupValue = frmb.ReturnValue1;
                        DisplayMessage(pCmd.Text + " -> " + PopupValue);
                    }
                    break;

                case "30":
                    // 비가동 등록
                    frmPOPStop frmStop = new frmPOPStop();
                    if(frmStop.ShowDialog() == DialogResult.OK)
                    {

                    }

                    break;

                case "40":
                    //작업표준서
                    frmPOPDocument frmdoc = new frmPOPDocument();
                    if(frmdoc.ShowDialog() == DialogResult.OK)
                    {

                    }

                    break;

                case "50":
                    //작업지시
                    frmPOPOrder_T01 frmOr = new frmPOPOrder_T01(_pUserEntity);
                    if(frmOr.ShowDialog() == DialogResult.OK)
                    {

                    }

                    break;

                default: break;
            }

        }

        #endregion
        
        #region ○ 공정정보 받고 실행
        private void ReceivePrint(byte[] PrintCode)  // 프로세스코드로 구분
        {
            //제브라 프린터 출력 로직
        }
        #endregion

        #region ○ 작업지시 등록 버튼
        private void _ucbtWORK_ORDER_Click(object sender, EventArgs e)
        {
            //_pPOPProductionOrderCommonEntity.COMMON_TYPE = "frmPOPMain_PRODUCT_MIX";

           
            //작업지시
            frmPOPOrder_T02 frmOr = new frmPOPOrder_T02(_pUserEntity, _pTerminal_code);
            frmOr.ShowDialog();
            if (frmOr.dtReturn == null)
            {
                frmOr.Dispose();
                return;
            }
            
            // 넘겨받은 Data를 각 labelControl로 뿌림
            if (frmOr.dtReturn != null && frmOr.dtReturn.Rows.Count > 0)
            {
                unit = frmOr.dtReturn.Rows[0]["단위"].ToString();
                _luORDER_ID.Text = frmOr.dtReturn.Rows[0]["작업지시번호"].ToString();
                _luORDER_DATE.Text = frmOr.dtReturn.Rows[0]["지시일자"].ToString();
                _luORDER_QTY.Text = frmOr.dtReturn.Rows[0]["목표"].ToString() + " (" + unit + ") "; // + " (" + frmOr.dtReturn.Rows[0]["CODE_UNIT"].ToString() + ") ";
                _luPART_NAME.Text = frmOr.dtReturn.Rows[0]["품목명"].ToString();
                _luPART_CODE.Text = frmOr.dtReturn.Rows[0]["품목코드"].ToString();

                _luOK_QTY.Text = frmOr.dtReturn.Rows[0]["양품"].ToString() + " (" + unit + ") "; // + " (" + frmOr.dtReturn.Rows[0]["CODE_UNIT"].ToString() + ") ";
                _luNG_QTY.Text = frmOr.dtReturn.Rows[0]["불량"].ToString() + " (" + unit + ") "; // + " (" + frmOr.dtReturn.Rows[0]["CODE_UNIT"].ToString() + ") ";

                or_num = (int)Convert.ToDouble(frmOr.dtReturn.Rows[0]["목표"].ToString());
                ok_num = (int)Convert.ToDouble(frmOr.dtReturn.Rows[0]["양품"].ToString());
                ng_num = (int)Convert.ToDouble(frmOr.dtReturn.Rows[0]["불량"].ToString());
      
                //c_yn = frmOr.dtReturn.Rows[0]["COMPLETE_YN"].ToString();

                //Print_cmd = frmOr.dtReturn.Rows[0]["PRINT_CMD"].ToString();

                re_num = (int)Convert.ToDouble(ok_num.ToString()) + (int)Convert.ToDouble(ng_num.ToString());
                _luRESULT_QTY.Text = re_num.ToString() + " (" + unit + ") ";

                if (or_num <= re_num)
                {
                    _luRESULT_QTY.ForeColor = Color.Red;
                }
                else
                {
                    _luRESULT_QTY.ForeColor = Color.Black;
                }
                FontResize(_luORDER_ID);
                FontResize(_luORDER_DATE);
                FontResize(_luPART_CODE);
                FontResize(_luPART_NAME);
                FontResize(_luORDER_QTY);
                FontResize(_luRESULT_QTY);
                FontResize(_luOK_QTY);
                FontResize(_luNG_QTY);
                //FontResize(_luNOTICE_TITLE);
                //FontResize(_luNotice_Contents);

                _pOrder_id = frmOr.dtReturn.Rows[0]["작업지시번호"].ToString();
                _pPart_code2 = frmOr.dtReturn.Rows[0]["품목코드"].ToString();

            }
            
            frmOr.Dispose();
            
            //if (exitflag == false)
            //{
            //    timer.Enabled = true;
            //  //  Send_Image(_luPART_CODE.Text, _luPART_NAME.Text);
            //    Send_Notice();
            //    timer.Tick += new EventHandler(time_tick3);
            //    timer.Start();
            //}
            //else if (exitflag == true)
            //{
            //    timer.Stop();
            //    timer = new System.Windows.Forms.Timer();
            //    _pdfViewer.CloseDocument();
            //    _pdfViewer2.CloseDocument();
            //    //0we11Passw0rd!@#dbmes  Send_Image(_luPART_CODE.Text, _luPART_NAME.Text);
            //    Send_Notice();
            //    timer.Tick -= new EventHandler(time_tick3);
            //    timer.Tick += new EventHandler(time_tick3);
            //    timer.Start();

            //}

        }
        #endregion

        #region ○ BOM 버튼 
        private void _ucbtBOM_Click(object sender, EventArgs e)
        {
            if (_luORDER_ID.Text == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요.");
                return;
            }

            //BOM 구성보기
            frmPOPBOM frmBOM = new frmPOPBOM(_pUserEntity, _luPART_CODE.Text);
            frmBOM.ShowDialog();
            if (frmBOM.dtReturn == null)
            {
                frmBOM.Dispose();
                return;
            }
        }
        #endregion

        #region ○ 실적등록 버튼(현재 사용 x)
        /*
        private void _ucbtRESULT_REG_Click(object sender, EventArgs e)
        {
            if (_luORDER_ID.Text == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요.");
                return;
            }

            // 실적등록
            frmPopupKeypad_T01 frmkey = new frmPopupKeypad_T01();
            frmkey.titleName = _luORDER_ID.Text;

            //실적등록
            string PopupValue = string.Empty;
            if (frmkey.ShowDialog() == DialogResult.OK)
            {

                PopupValue = frmkey.ReturnValue1;

                InputResultData_Save(PopupValue);
            }
        }
        */
        #endregion

        #region ○ 불량등록 버튼(현재 사용x)
        /*
    private void _ucbtNG_REG_Click(object sender, EventArgs e)
    {
        if (_luORDER_ID.Text == "")
        {
            CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요.");
            return;
        }

        // 불량등록
        frmPOPBad_T01 frmb = new frmPOPBad_T01();
        frmb.titleName = _luORDER_ID.Text;

        string PopupValue = string.Empty;
        string PopupValue2 = string.Empty;

        if (frmb.ShowDialog() == DialogResult.OK)
        {

            PopupValue = frmb.ReturnValue1;
            PopupValue2 = frmb.ReturnValue2;

            InputBadData_Save(PopupValue, PopupValue2);

        }
    }
    */
        #endregion

        #region ○ 라벨발행 버튼
        private void _ucbtPRINT_REG_Click(object sender, EventArgs e)
        {
            try
            {
                //작지 선택 여부 
                if (_luORDER_ID.Text == "")
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 확인해주세요.");
                    return;
                }

                //양품 목표 0 걸러내기
                if (or_num <= 0 && ok_num <= 0)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 확인해주세요.");
                    return;
                }
                
                frmPOPComplete frmComplete = new frmPOPComplete(Print_cmd, _pUserEntity);
                frmComplete.titleName = _luORDER_ID.Text;
                frmComplete.ShowDialog();

                _pP_Name = frmComplete._pPrintName;
                _pP_Code = frmComplete._pPrintCode;
                _pP_SEQ = frmComplete._pPrintSEQ;
                _pP_QTY = frmComplete._pPrintQTY;
                _pP_Vend = frmComplete._pVendCode;

                InputData_Save();
            }
            catch(Exception ex)
            {
                DisplayMessage(ex.ToString());
            }
        }
        #endregion

        #region ○ 완료 버튼
        private void _ucbtCOMPLETE_REG_Click(object sender, EventArgs e)
        {
            //작지 선택 여부 
            if (_luORDER_ID.Text == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("作業指示を確認してください。");
                return;
            }

            if (c_yn == "Y")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("完了した作業指示です。");
                return;
            }

            if (CoFAS_DevExpressManager.ShowQuestionMessage("作業指示を完了しますか？") == DialogResult.Yes)
            {

                _pPOPWorkResult_MIXEntity.CRUD = "U";
                _pPOPWorkResult_MIXEntity.PRODUCTION_ORDER_ID = _luORDER_ID.Text;
                _pPOPWorkResult_MIXEntity.COMPLETE_YN = "Y";

                bool isError2 = false;
                isError2 = new frmPOPMain_PRODUCT_Work_MIXBusiness().usWorkResultPopup_Save_01(_pPOPWorkResult_MIXEntity);
                
                CoFAS_DevExpressManager.ShowInformationMessage("保存された。");
                InitializeSetting();
            }

        }
        #endregion

        #region ○ 발행 등록 저장 - InputData_Save()
        private void InputData_Save()
        {
            _pPOPWorkResult_MIXEntity.PRINT_CODE = "BAR000001";

            _dtList_print = new frmPOPMain_PRODUCT_Work_MIXBusiness().frmPOPMain_PRODUCT_MIX_barcode_Info(_pPOPWorkResult_MIXEntity);

            // 시리얼 연결 여부 확인
            if (_pCoFAS_Serial.IsOpen)
            {
                try
                {
                    //라벨 공정에서 가져오기
                    string _Barcode = string.Empty;

                    //byte[] bytes = Encoding.Default.GetBytes(_Barcode);
                    //_Barcode = Encoding.Default.GetString(bytes);

                    string cmd = null;

                    for (int j = 0; j < Convert.ToInt32(_pP_SEQ); j++)
                    {
                        _Barcode = _dtList_print.Rows[0]["PRINT_CMD"].ToString();
                        cmd = (j+1).ToString("D3");

                        // 푸른들식품 기준 10x5 라벨
                        _Barcode = _Barcode.Replace("@PNAME", _pP_Name); // 제품명
                        _Barcode = _Barcode.Replace("@PQTY", _pP_QTY); // 목표수량
                        _Barcode = _Barcode.Replace("@PDATE", DateTime.Now.ToString("yyyy-MM-dd")); // 날짜
                        _Barcode = _Barcode.Replace("@PBARCODE", _pP_Vend + cmd + DateTime.Now.ToString("yyMMdd").ToString()); // 바코드
                        _Barcode = _Barcode.Replace("@PCODE", _pP_Code); // 제품코드

                        byte[] bytes = Encoding.Default.GetBytes(_Barcode);
                        _pCoFAS_Serial.Write(bytes, 0, bytes.Length);

                    }
                }
                catch (Exception ex)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("라벨발행 오류");

                    _pCoFAS_Serial.Dispose();
                    _pCoFAS_Serial.Close();
                }
            }
            else  //연결 끊긴 여부
            {
                CoFAS_DevExpressManager.ShowInformationMessage("시리얼 확인");
            }
        }
        #endregion

        #region ○ 양품실적 등록 저장 - InputResultData_Save(string strValue, int comCheck)

        private void InputResultData_Save(string strValue)
        {
            
            //리턴값이 빈값이 아니고 0도 아닐경우 실적등록
            if (strValue != "0" && strValue != "")
            {
                _pPOPWorkResult_MIXEntity.RESOURCE_CODE = _pTerminal_code;// _luPROCESS_CODE.GetValue();
                _pPOPWorkResult_MIXEntity.COLLECTION_DATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                _pPOPWorkResult_MIXEntity.PROPERTY_VALUE = _luORDER_ID.Text;
                //CD501001 : 양품
                //CD501002 : 불량
                _pPOPWorkResult_MIXEntity.CONDITION_CODE = "CD501001";
                _pPOPWorkResult_MIXEntity.OPTION_CODE = "";
                _pPOPWorkResult_MIXEntity.COLLECTION_VALUE = strValue.Replace(",", "");
                _pPOPWorkResult_MIXEntity.COLLECTION_VALUE_STR = "";

                bool isError = false;
                isError = new frmPOPMain_PRODUCT_Work_MIXBusiness().frmPOPMain_PRODUCT_Work_MIX_Save(_pPOPWorkResult_MIXEntity);

                if (!isError)
                    this.DialogResult = DialogResult.OK;

                //작업지시상태 업데이트
                ok_num = ok_num + (int)Convert.ToDouble(_pPOPWorkResult_MIXEntity.COLLECTION_VALUE.ToString());
                _luOK_QTY.Text = (int)Convert.ToDouble(ok_num.ToString()) + " (" + unit + ") ";

                re_num = (int)Convert.ToDouble(ok_num.ToString()) + (int)Convert.ToDouble(ng_num.ToString());
                _luRESULT_QTY.Text = Convert.ToDouble(re_num.ToString()) + " (" + unit + ") ";

                if (or_num <= re_num) // 목표수량 이상
                {
                    _luRESULT_QTY.ForeColor = Color.Red;

                    //// 작업지시 완료 처리
                    //_pPOPWorkResult_MIXEntity.CRUD = "U";
                    //_pPOPWorkResult_MIXEntity.PRODUCTION_ORDER_ID = _luORDER_ID.Text;

                    //if (or_num <= ok_num)
                    //{
                    //    _pPOPWorkResult_MIXEntity.COMPLETE_YN = "Y";
                    //}
                    //else
                    //{
                    //    _pPOPWorkResult_MIXEntity.COMPLETE_YN = "N";
                    //}

                    //bool isError2 = false;

                    //isError2 = new frmPOPMain_PRODUCT_Work_MIXBusiness().usWorkResultPopup_Save_01(_pPOPWorkResult_MIXEntity);
                    //CoFAS_DevExpressManager.ShowInformationMessage("작업이 완료되었습니다.");
                    //InitializeSetting();
                }
                else
                {
                    _luRESULT_QTY.ForeColor = Color.Black;
                }
            }
        }

        #endregion

        #region ○ 불량실적 등록
        private void InputBadData_Save(string strValue, string strValue2)
        {
            //리턴값이 빈값이 아니고 0도 아닐경우 실적등록
            if (strValue != "0" && strValue != "")
            {
                _pPOPWorkResult_MIXEntity.RESOURCE_CODE = _pTerminal_code;// _luPROCESS_CODE.GetValue();
                _pPOPWorkResult_MIXEntity.COLLECTION_DATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                _pPOPWorkResult_MIXEntity.PROPERTY_VALUE = _luORDER_ID.Text;
                //CD501001 : 양품
                //CD501002 : 불량
                _pPOPWorkResult_MIXEntity.CONDITION_CODE = strValue2.Replace(",", ""); // 불량코드 (BC---)
                _pPOPWorkResult_MIXEntity.OPTION_CODE = "";
                _pPOPWorkResult_MIXEntity.COLLECTION_VALUE = strValue.Replace(",", "");
                _pPOPWorkResult_MIXEntity.COLLECTION_VALUE_STR = "";

                bool isError = false;
                isError = new frmPOPMain_PRODUCT_Work_MIXBusiness().frmPOPMain_PRODUCT_Work_MIX_Save(_pPOPWorkResult_MIXEntity);

                if (!isError)
                    this.DialogResult = DialogResult.OK;

                //작업지시상태 업데이트
                ng_num = ng_num + (int)Convert.ToDouble(_pPOPWorkResult_MIXEntity.COLLECTION_VALUE.ToString());
                _luNG_QTY.Text = ng_num.ToString() + " (" + unit + ") ";

                re_num = (int)Convert.ToDouble(ng_num.ToString()) + (int)Convert.ToDouble(ok_num.ToString());
                _luRESULT_QTY.Text = re_num.ToString() + " (" + unit + ") ";

                if (or_num <= re_num) // 목표수량 이상
                {
                    _luRESULT_QTY.ForeColor = Color.Red;

                    //// 작업지시 완료 처리
                    //_pPOPWorkResult_MIXEntity.CRUD = "U";
                    //_pPOPWorkResult_MIXEntity.PRODUCTION_ORDER_ID = _luORDER_ID.Text;

                    //if (or_num <= ok_num)
                    //{
                    //    _pPOPWorkResult_MIXEntity.COMPLETE_YN = "Y";
                    //}
                    //else
                    //{
                    //    _pPOPWorkResult_MIXEntity.COMPLETE_YN = "N";
                    //}

                    //bool isError2 = false;

                    //isError2 = new frmPOPMain_PRODUCT_Work_MIXBusiness().usWorkResultPopup_Save_01(_pPOPWorkResult_MIXEntity);
                }
                else
                {
                    _luRESULT_QTY.ForeColor = Color.Black;
                }

            }

        }
        #endregion

        #region ○ 실적 등록 저장(양품,불량)

        // Result에서 값을 넘겨받고, 해당 값을 양품실적 등록함수와 불량실적 등록함수 인자로 내보냄
        private void _ucbRESULT_REG_Click(object sender, EventArgs e)
        {
            if (_luORDER_ID.Text == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("作業指示を先に選択してください。");
                return;
            }

            frmPOPResult frmkey = new frmPOPResult(_luPART_NAME.Text, _luPART_CODE.Text, _luORDER_ID.Text);
            frmkey.titleName = _luORDER_ID.Text;

            string ResultQTY = string.Empty;
            string PopupValue2 = string.Empty;
            string PopupValue3 = string.Empty;

            if (frmkey.ShowDialog() == DialogResult.OK)
            {
                ResultQTY = frmkey.ReturnValue4;
                PopupValue2 = frmkey.ReturnValue5;
                PopupValue3 = frmkey.ReturnValue6;

                InputBadData_Save(ResultQTY, PopupValue2);
                InputResultData_Save(PopupValue3);
            }
        }

        #endregion

        #region ○ 예방점검 등록
        private void _ucbtCHECK_REG_Click(object sender, EventArgs e)
        {
            frmPOPCheck frmCheck = new frmPOPCheck(_pUserEntity, _pTerminal_code);
            frmCheck.ShowDialog();
            if (frmCheck.dtReturn == null)
            {
                frmCheck.Dispose();
                return;
            }
        }
        #endregion

        #region ○ 프로그램 종료
        private void _ucbtCLOSE_Click(object sender, EventArgs e)
        {
            try
            {
                //pFormClosingEventArgs.Cancel = false;
                if (CoFAS_DevExpressManager.ShowQuestionMessage("終了しますか？") == DialogResult.Yes)
                {
                    System.Environment.Exit(0);
                }

           
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

            }
        }
        #endregion

        #region ○ 이미지 뿌리기 
        private void Send_Image(string part_code, string part_name)
        {
            exitflag = true;
            Image_nm = null;
            Image_nm_2 = null;
            Image_nm2 = null;
            Image_nm3 = null;
            
            //try
           // {
                _pPOPWorkResult_MIXEntity.PART_CODE = part_code;
                _pPOPWorkResult_MIXEntity.DOCUMENT_TYPE = "CD050008";

            //#region Q-포인트 가져오기              
            //    //CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

            //    _dtList = new frmPOPMain_PRODUCT_Work_MIXBusiness().POPProductBOM_Image_Info(_pPOPWorkResult_MIXEntity);

            //    if (_pPOPWorkResult_MIXEntity.CRUD == "") _dtList.Rows.Clear();
            //    if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pPOPWorkResult_MIXEntity.CRUD == ""))
            //    {
            //        Image_nm2 = _dtList.Rows[0]["file2"].ToString();
            //        Image_nm = _dtList.Rows[0]["file1"].ToString();
            //        string document_type = _dtList.Rows[0]["Document_type"].ToString();
            //        if (Image_nm != null)
            //        {
            //            if (Image_nm.Contains(".pdf"))
            //            {


            //                if (Image_nm.IndexOf("*NoSave*") > -1 || Image_nm.Trim().Length < 4)
            //                {
            //                    //CoFAS_DevExpressManager.ShowInformationMessage("저장하지 않아서 볼 수 없습니다.");
            //                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_DISPLAY_NOT_SAVE);
            //                }
            //                else
            //                {
            //                    MemoryStream STR = null;
            //                    string strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "FILE_DATA", document_type);

            //                    var stream = CoFAS_FTPManager.FTPImage(strFTP_PATH, Image_nm2, _pFTP_ID, _pFTP_PW);

            //                    MemoryStream _ms = new MemoryStream();

            //                    byte[] buffer = new byte[16 * 1024];
            //                    int read;
            //                    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
            //                    {
            //                        _ms.Write(buffer, 0, read);
            //                    }


            //                    _pPOPWorkResult_MIXEntity.CORP_CODE = _pCORP_CDDE;
            //                    _pPOPWorkResult_MIXEntity.USER_CODE = _pUSER_CODE;
            //                    _pPOPWorkResult_MIXEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

            //                    MS = _ms;
            //                    _pdfViewer.LoadDocument(_pStream2);
            //                }

            //            }
            //            //else
            //            //{
            //            //    if (Image_nm2.IndexOf(" * NoSave*") > -1 || Image_nm2.Trim().Length < 4)
            //            //    {
            //            //        //CoFAS_DevExpressManager.ShowInformationMessage("저장하지 않아서 볼 수 없습니다.");
            //            //        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_DISPLAY_NOT_SAVE);
            //            //    }
            //            //    else
            //            //    {
            //            //        string strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "FILE_DATA", document_type);

            //            //        _pPOPWorkResult_MIXEntity.CORP_CODE = _pCORP_CDDE;
            //            //        _pPOPWorkResult_MIXEntity.USER_CODE = _pUSER_CODE;
            //            //        _pPOPWorkResult_MIXEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

            //            //        IMAGE_DATA = Image.FromStream(CoFAS_FTPManager.FTPImage(strFTP_PATH, Image_nm2, _pFTP_ID, _pFTP_PW));

            //            //        ucPictureEdit1.Image = _pIMAGE_DATA;
            //            //    }
            //            //}
            //        }
            //    }
                
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

            //}
            //#endregion

            //#region 작업표준서 가져오기

            //_pPOPWorkResult_MIXEntity.DOCUMENT_TYPE = "CD050007";
            ////CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

            //_dtList = new frmPOPMain_PRODUCT_Work_MIXBusiness().POPProductBOM_Image_Info(_pPOPWorkResult_MIXEntity);

            //if (_pPOPWorkResult_MIXEntity.CRUD == "") _dtList.Rows.Clear();
            //if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pPOPWorkResult_MIXEntity.CRUD == ""))
            //{
            //    Image_nm3 = _dtList.Rows[0]["file2"].ToString();
            //    Image_nm_2 = _dtList.Rows[0]["file1"].ToString();
            //    string document_type = _dtList.Rows[0]["Document_type"].ToString();
            //    if (Image_nm_2 != null)
            //    {
            //        if (Image_nm_2.Contains(".pdf"))
            //        {


            //            if (Image_nm_2.IndexOf("*NoSave*") > -1 || Image_nm_2.Trim().Length < 4)
            //            {
            //                //CoFAS_DevExpressManager.ShowInformationMessage("저장하지 않아서 볼 수 없습니다.");
            //                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_DISPLAY_NOT_SAVE);
            //            }
            //            else
            //            {
            //                MemoryStream STR = null;
            //                string strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "FILE_DATA", document_type);

            //                var stream = CoFAS_FTPManager.FTPImage(strFTP_PATH, Image_nm3, _pFTP_ID, _pFTP_PW);

            //                MemoryStream _ms = new MemoryStream();

            //                byte[] buffer = new byte[16 * 1024];
            //                int read;
            //                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
            //                {
            //                    _ms.Write(buffer, 0, read);
            //                }


            //                _pPOPWorkResult_MIXEntity.CORP_CODE = _pCORP_CDDE;
            //                _pPOPWorkResult_MIXEntity.USER_CODE = _pUSER_CODE;
            //                _pPOPWorkResult_MIXEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

            //                MS2 = _ms;
            //                _pdfViewer2.LoadDocument(_pStream3);
            //            }

            //        }
            //        //else
            //        //{
            //        //    if (Image_nm2.IndexOf(" * NoSave*") > -1 || Image_nm2.Trim().Length < 4)
            //        //    {
            //        //        //CoFAS_DevExpressManager.ShowInformationMessage("저장하지 않아서 볼 수 없습니다.");
            //        //        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_DISPLAY_NOT_SAVE);
            //        //    }
            //        //    else
            //        //    {
            //        //        string strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "FILE_DATA", document_type);

            //        //        _pPOPWorkResult_MIXEntity.CORP_CODE = _pCORP_CDDE;
            //        //        _pPOPWorkResult_MIXEntity.USER_CODE = _pUSER_CODE;
            //        //        _pPOPWorkResult_MIXEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

            //        //        IMAGE_DATA = Image.FromStream(CoFAS_FTPManager.FTPImage(strFTP_PATH, Image_nm2, _pFTP_ID, _pFTP_PW));

            //        //        ucPictureEdit2.Image = _pIMAGE_DATA;
            //        //    }
            //        //}
            //    }
            //    #endregion
            //}
        }
        #endregion

        #region ○ 공지사항 불러오기
        public void Send_Notice()
        {
           
            //CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);    

            //_dtList = new frmPOPMain_PRODUCT_Work_MIXBusiness().POPProduct_notice_Info(_pPOPWorkResult_MIXEntity);

            //if (_pPOPWorkResult_MIXEntity.CRUD == "") _dtList.Rows.Clear();
            //if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pPOPWorkResult_MIXEntity.CRUD == ""))
            //{
            //    _luNotice_Contents.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            //    _luNotice_Contents.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            //    _luNOTICE_TITLE.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            //    //_luNOTICE_HEADER.Text = _dtList.Rows[0]["title"].ToString();
            //    _luNOTICE_TITLE.Text = _dtList.Rows[0]["title"].ToString();
            //    _luNotice_Contents.Text = _dtList.Rows[0]["contents"].ToString();
            //}
        }
        #endregion

        #region ○ 비가동등록
        private void _ucbtSTOP_REG_Click(object sender, EventArgs e)
        {
            frmPOPStop_T01 frmStop = new frmPOPStop_T01(_pUserEntity, _pTerminal_code);
            frmStop.ShowDialog();
            if (frmStop.dtReturn == null)
            {
                frmStop.Dispose();
                return;
            }
        }
        #endregion

        #region ○ 초/중/종물 등록
        private void _ucbFIRSTMIDDLELAST_REG_Click(object sender, EventArgs e)
        {
            if (_luORDER_ID.Text == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요.");
                return;
            }

            frmPOPFirstMiddleLast frmFirstMiddleLast = new frmPOPFirstMiddleLast(_pUserEntity, _pTerminal_code, _pOrder_id, _pPart_code2);
            frmFirstMiddleLast.ShowDialog();
            if(frmFirstMiddleLast.dtReturn == null)
            {
                frmFirstMiddleLast.Dispose();
                return;
            }
        }
        #endregion
    }
}
