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
using CoFAS_MES.CORE.UserForm;
using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraEditors;
using System.IO;
using System.IO.Ports;
using System.Data.SqlClient;
using CoFAS_MES.POP.Function;

namespace CoFAS_MES.POP
{
    public partial class frmPOPMain_T50 : frmBasePOP
    {

        public string _pCORP_CDDE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        private string _pMSG_EXIT_QUESTION = string.Empty;   // 종료 하겠습니까?
        public int _pFONT_SIZE = 12;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private string Image_nm = null;
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtList_print = null; //조회 데이터 리스트 (바코드 발행)
        private DataTable _dtList_terminal = null; //터미널 상세정보 리스트

        private CoFAS_Serial _pCoFAS_Serial = null;  // 시리얼 생성

        public UserEntity _pUserEntity = null;
        //private POPSelect_INSPECT_MIXEntity _pPOPWorkResult_T50Entity = null; // 엔티티 생성
        private POPWorkResult_T50Entity _pPOPWorkResult_T50Entity = null;

        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티
        private POPCheckEntity _pPOPCheckEntity = null; // 엔티티 생성
        private int ok_num = 0; // 양품수량
        private int ng_num = 0; // NG수량

        private int re_num = 0; // 작업수량
        private int or_num = 0; // 목표수량

        private string Print_cmd = null; // 바코드 CMD
        private string unit = null; // 표시 단위
        private string c_yn = null;
        private string _pTerminal_code = null;
        private string _pOrder_SEQ = "";
        private string _pOrder_STATUS = "";
        private string _pP_Name = null;
        private string _pP_Code = null;
        private string _pP_Vend = null;
        private string _pP_SEQ = null;
        private string _pP_QTY = null;
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string orderid = string.Empty;

        private string _equipment_state = "";

        public Timer timer = new Timer();
        public DateTime dtT;

        delegate void CrossThreadSafetySetText(Control ctl, String text);
        delegate void CrossThreadSafetySetColor(Control ctl, Color text);

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

        public frmPOPMain_T50(UserEntity pUserEntity)
        {
            InitializeComponent();

            _pUserEntity = pUserEntity;
            //
            //_luRESOURCE_NAME.Text = _pUserEntity.PROCESS_NAME;
            _pTerminal_code = pUserEntity.RESOURCE_CODE;
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

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            dtT = DateTime.Now;
            if (dtT.Hour == 0 && dtT.Minute == 0 && dtT.Second == 0)
            {
                frmPOPEquipmentCheck frmCheck = new frmPOPEquipmentCheck(_pUserEntity, _pUserEntity.POP_TITLE);
                frmCheck.ShowDialog();
                if (frmCheck.dtReturn == null)
                {
                    frmCheck.Dispose();
                    return;
                }
            }
            timer.Start();
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
                if (CoFAS_DevExpressManager.ShowQuestionMessage("종료하시겠습니까?") == DialogResult.No)
                {
                    pFormClosingEventArgs.Cancel = true;
                    return;
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
                //가동 비가동 등록
                _pPOPWorkResult_T50Entity.TERMINAL_CODE = _pUserEntity.PROCESS_CODE;

                _pPOPWorkResult_T50Entity.TERMINAL_CODE = _pUserEntity.PROCESS_CODE;//설비코드
                _pPOPWorkResult_T50Entity.PROCESS_CODE = _pUserEntity.RESOURCE_CODE;//POP코드
                _pPOPWorkResult_T50Entity.USER_NAME = _pUSER_NAME;
                _pPOPWorkResult_T50Entity.PROPERTY_VALUE = "EM020002";//가동 비가동 코드

                new frmPOPMain_PRODUCT_Work_T50Business().USP_equipment_running_I10(_pPOPWorkResult_T50Entity, "작업완료");
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
                SetHardware();
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

                _luUSER_INFO.Text = _pUserEntity.USER_NAME;

                #region 작업자 교체 팝업
                frmPOPWorker_T50 frmPOPWorker_T50 = new frmPOPWorker_T50(_pUserEntity);
                frmPOPWorker_T50.ShowDialog();
                if (frmPOPWorker_T50.dtReturn == null || frmPOPWorker_T50.dtReturn.Rows.Count == 0)
                {
                    frmPOPWorker_T50.Dispose();                  
                }
                else
                {
                    _pUSER_NAME = frmPOPWorker_T50.dtReturn.Rows[0]["USER_NAME"].ToString();
                    _pUSER_CODE = frmPOPWorker_T50.dtReturn.Rows[0]["USER_ACCOUNT"].ToString();
                    _luUSER_INFO.Text = frmPOPWorker_T50.dtReturn.Rows[0]["USER_NAME"].ToString();
                    _pUserEntity.USER_NAME = frmPOPWorker_T50.dtReturn.Rows[0]["USER_NAME"].ToString();
                    _pUserEntity.USER_CODE = frmPOPWorker_T50.dtReturn.Rows[0]["USER_ACCOUNT"].ToString();
                    CoFAS_DevExpressManager.ShowInformationMessage("작업자가 변경되었습니다.");
                }

                
                #endregion

                #region 설비점검표 띄우기
                //POP를 켰을때 하나라도 점검표에 등록이 되어있지 않다면(하루 단위 점검 기준만..) 점검표 등록 팝업 띄우기
                DataTable dt = new DataTable();
                _pPOPCheckEntity = new POPCheckEntity();
                _pPOPCheckEntity.PROCESS_CODE = _pUserEntity.PROCESS_CODE;//설비코드

                dt = new POPEquipmentCheckBusiness().POPEquipmentCheck_Info(_pPOPCheckEntity, DateTime.Now.ToShortDateString());

                if (dt.Rows.Count > 0)
                {
                    var QueryTable = (from row in dt.AsEnumerable()
                                      where row["CODE3"].ToString() == "일"
                                      select row).CopyToDataTable();

                    foreach (DataRow dr in QueryTable.Rows)
                    {
                        if (dr["CODE5"].ToString() == "")
                        {
                            frmPOPEquipmentCheck frmCheck = new frmPOPEquipmentCheck(_pUserEntity, _pUserEntity.POP_TITLE);
                            frmCheck.ShowDialog();
                            if (frmCheck.dtReturn == null)
                            {
                                frmCheck.Dispose();
                                return;
                            }
                            break;
                        }
                    }
                }
                #endregion

                #region 가동 비가동 팝업 띄우기
                //가동 비가동 등록
                _pPOPWorkResult_T50Entity.TERMINAL_CODE = _pUserEntity.PROCESS_CODE;

                _pPOPWorkResult_T50Entity.TERMINAL_CODE = _pUserEntity.PROCESS_CODE;//설비코드
                _pPOPWorkResult_T50Entity.PROCESS_CODE = _pUserEntity.RESOURCE_CODE;//POP코드
                _pPOPWorkResult_T50Entity.USER_NAME = _pUSER_NAME;
                _pPOPWorkResult_T50Entity.PROPERTY_VALUE = "EM020001";//가동 비가동 코드

                new frmPOPMain_PRODUCT_Work_T50Business().USP_equipment_running_I10(_pPOPWorkResult_T50Entity, "");
                #endregion

                #region 작업중인 지시 띄우기
                DataTable dt2 = new frmPOPMain_PRODUCT_Work_T50Business().USP_production_order_detail_t50_R10(_pUserEntity.PROCESS_CODE);

                if (dt2.Rows.Count > 0)
                {
                    or_num = Convert.ToInt32(dt2.Rows[0]["production_order_qty"]);
                    ok_num = Convert.ToInt32(dt2.Rows[0]["OK_QTY"]);
                    ng_num = Convert.ToInt32(dt2.Rows[0]["NG_QTY"]);
                    _pOrder_SEQ = dt2.Rows[0]["production_order_seq"].ToString();
                    _pOrder_STATUS = dt2.Rows[0]["production_order_status"].ToString();
                    orderid = dt2.Rows[0]["production_order_id"].ToString();
                    _luORDER_ID.Text = dt2.Rows[0]["vend_part_code"].ToString();//
                    _luORDER_DATE.Text = dt2.Rows[0]["production_order_date"].ToString();
                    _luPART_CODE.Text = dt2.Rows[0]["part_code"].ToString();
                    _luPART_NAME.Text = dt2.Rows[0]["part_name"].ToString();
                    _luSEQ.Text = dt2.Rows[0]["SEQ"].ToString();
                    _luORDER_QTY.Text = dt2.Rows[0]["production_order_qty"].ToString();
                    _luOK_QTY.Text = dt2.Rows[0]["OK_QTY"].ToString();
                    _luNG_QTY.Text = dt2.Rows[0]["NG_QTY"].ToString();
                    _luRESULT_QTY.Text = (Convert.ToInt32(dt2.Rows[0]["OK_QTY"]) + Convert.ToInt32(dt2.Rows[0]["NG_QTY"])).ToString();
                    _luPROCESS_GUBUN.Text = dt2.Rows[0]["PROCESS_GUBUN2"].ToString();
                    _luPROCESS_CODE.Text = dt2.Rows[0]["PROCESS_NAME2"].ToString();
                    _luPROCESS_NAME.Text = dt2.Rows[0]["PROCESS_CODE2"].ToString();
                    _luREMARK.Text = dt2.Rows[0]["remark"].ToString();
                    _luOK_QTY.Text = ok_num.ToString();
                    _luNG_QTY.Text = ng_num.ToString();
                    _luRESOURCE_NAME.Text = dt2.Rows[0]["part_standard"].ToString();

                    re_num = (int)Convert.ToDouble(ok_num.ToString()) + (int)Convert.ToDouble(ng_num.ToString());


                    if (or_num <= re_num)
                    {
                        CSafeSetColor(_luRESULT_QTY, Color.Red);
                    }
                    else
                    {
                        CSafeSetColor(_luRESULT_QTY, Color.Black);
                    }
                }
                #endregion

                
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

        #region Label 내 AutoFontSize
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
            DataTable dtCI = new SystemSettingBusiness().CI_Download();
            if (dtCI != null && (dtCI.Rows[0]["LOGO_FIRST"]).ToString().Length > 0 && (((byte[])dtCI.Rows[0]["LOGO_FIRST"]).Length > 0 && dtCI.Rows.Count > 0))
            {
                if (System.IO.File.Exists(Application.StartupPath + "\\" + "logo2.png"))
                {
                    _peCI.Image.Dispose();
                    _peCI.Image = null;
                    System.IO.File.Delete(Application.StartupPath + "\\" + "logo2.png");
                }

                Image imgCI = CoFAS_ConvertManager.byteArrayToImage((byte[])dtCI.Rows[0]["LOGO_FIRST"]);
                if (imgCI != null)
                {
                    imgCI.Save(Application.StartupPath + "\\" + "logo2.png");
                }
            }

            if (System.IO.File.Exists(Application.StartupPath + "\\" + "logo2.png"))
            {
                _peCI.Image = Image.FromFile(Application.StartupPath + "\\" + "logo2.png");
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
                _pCORP_CDDE = "0313533074";//MainForm.UserEntity.CORP_CODE;
                                           //_pUSER_CODE = "admin@coever.co.kr";// MainForm.UserEntity.USER_CODE;
                                           //_pUSER_NAME = "";//MainForm.UserEntity.USER_NAME;
                                           //_pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                                           //_pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFTP_ID = _pUserEntity.FTP_ID;
                _pFTP_PATH = _pUserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PW = _pUserEntity.FTP_PW;
                //메인 화면 전역 변수 처리
                //_pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = _pUserEntity.USER_CODE;
                _pUSER_NAME = _pUserEntity.USER_NAME;
                //_pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                //_pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                //_pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                //_pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                _pOrder_STATUS = "";
                _pWINDOW_NAME = this.Name;
                _pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _lbTitle.Text = _pUserEntity.POP_TITLE;//"대성 POP 시스템"; //_pUserEntity.POP_TITLE;
                _lbHeader.Text = "";
                DisplayMessage("");

                _luPART_NAME.Text = "";
                _luPART_CODE.Text = "";
                _luORDER_ID.Text = "";
                _luORDER_DATE.Text = "";
                _luORDER_QTY.Text = "";
                _luNG_QTY.Text = "";
                _luRESULT_QTY.Text = "";
                _luPROCESS_GUBUN.Text = "";
                _luPROCESS_NAME.Text = "";
                _luPROCESS_CODE.Text = "";
                _luSEQ.Text = "";
                _luREMARK.Text = "";

                _luOK_QTY.Text = "";
                _pOrder_SEQ = "";
                _luRESOURCE_NAME.Text = "";
                //_luPART_CODE.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                //_luPART_NAME.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


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

                _pPOPWorkResult_T50Entity = new POPWorkResult_T50Entity();
                _pPOPWorkResult_T50Entity.CORP_CODE = _pCORP_CDDE;
                _pPOPWorkResult_T50Entity.USER_CODE = _pUSER_CODE;
                _pPOPWorkResult_T50Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pPOPWorkResult_T50Entity.PROCESS_CODE = "";
                _pPOPWorkResult_T50Entity.RESOURCE_CODE = "";

                //그리드 설정

                //   double ddd = Math.Acos(0.912);


                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _pPOPWorkResult_T50Entity.USER_CODE = _pUserEntity.USER_CODE;
                    _pFirstYN = false;
                }

                //버튼 세팅
                //if (_pUserEntity.PROCESS_CODE == "frmPOPMain_PRODUCT_PACKET")
                //{
                //    _ucbtPRINT_REG.Visible = true;

                //    SetHardware();
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
                _dtList_terminal = new DataTable();

                if (_dtList_terminal != null)
                {
                    //_pPOPWorkResult_T50Entity.TERMINAL_CODE = _pTerminal_code;
                    _pPOPWorkResult_T50Entity.TERMINAL_CODE = _pTerminal_code;
                    _dtList_terminal = new frmPOPMain_PRODUCT_Work_T50Business().frmPOPMain_PRODUCT_Work_T50_terminal_Info(_pPOPWorkResult_T50Entity);

                    if(_dtList_terminal.Rows.Count > 0)
                    { 
                        string partName = _dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString();
                        int baudRate = Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString());
                        string parity = _dtList_terminal.Rows[0]["INFO_PARITY"].ToString();
                        int dataBits = Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString());
                        string stopBits = _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString();

                        _pCoFAS_Serial = new CoFAS_Serial(partName, baudRate, parity, dataBits, stopBits);
                        _pCoFAS_Serial.evtReceived += new CoFAS_Serial.delReceive(Serial_Data);
                        _pCoFAS_Serial.Open();

                        // 연결할 H/W 연결상태 표시. (연동시 변경)
                        lc_0.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;

                            //CoFAS_DevExpressManager.ShowInformationMessage("POP Start Complete");
                    }
                }

            }
            catch (Exception ex)
            {
                CoFAS_DevExpressManager.ShowInformationMessage(_dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString()+"의 " + _dtList_terminal.Rows[0]["INFO_NAME"].ToString() + "을(를) 확인해주시기 바랍니다.");
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
                    if (frmkey.ShowDialog() == DialogResult.OK)
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
                    if (frmStop.ShowDialog() == DialogResult.OK)
                    {

                    }

                    break;

                case "40":
                    //작업표준서
                    frmPOPDocument frmdoc = new frmPOPDocument();
                    if (frmdoc.ShowDialog() == DialogResult.OK)
                    {

                    }

                    break;

                case "50":
                    //작업지시
                    frmPOPOrder_T01 frmOr = new frmPOPOrder_T01(_pUserEntity);
                    if (frmOr.ShowDialog() == DialogResult.OK)
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

        #region ○ 작업지시 버튼
        private void _ucbtWORK_ORDER_Click(object sender, EventArgs e)
        {
            if (_luORDER_ID.Text != "" || _pOrder_STATUS == "P")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("진행중인 작업을 보류/취소 후 가능합니다.");
                return;
            }

            //_pPOPProductionOrderCommonEntity.COMMON_TYPE = "frmPOPMain_PRODUCT_MIX";

            //작업지시
            frmPOPOrder_T50 frmOr = new frmPOPOrder_T50(_pUserEntity);                        
            frmOr.ShowDialog();
            
            if (frmOr.dtReturn == null)
            {
                frmOr.Dispose();
                return;
            }

            // 넘겨받은 Data를 각 labelControl로 뿌림 20190130
            if (frmOr.dtReturn != null && frmOr.dtReturn.Rows.Count > 0)
            {

                bool tf = false;

                string processNum = frmOr.dtReturn.Rows[0]["SEQ"].ToString().Replace("#", "");
                int _intprocessNum = Convert.ToInt32(processNum);
                _intprocessNum -= 10;

                if (_intprocessNum == 0)
                {
                    tf = true;
                    //goto EXIT;
                }
                else
                {
                    //전공정 작업 완료 여부
                    DataTable d = new POPProductionOrder_T50Business().USP_production_order_detail_t50_check_R10(frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_ID"].ToString(), "#" + _intprocessNum.ToString());

                    if(d.Rows[0]["production_order_status"].ToString() == "N")
                    {
                        tf = false;
                        CoFAS_DevExpressManager.ShowErrorMessage("이전 공정이 완료되지 않았습니다.");
                    }
                    else
                    {
                        tf = true;
                    }

                }



                if (tf)
                {
                    //EXIT:
                    orderid = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_ID"].ToString();
                    or_num = (int)Convert.ToDouble(frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_QTY"].ToString());
                    ok_num = (int)Convert.ToDouble(frmOr.dtReturn.Rows[0]["PRODUCTION_OK_QTY"].ToString());
                    ng_num = (int)Convert.ToDouble(frmOr.dtReturn.Rows[0]["PRODUCTION_NG_QTY"].ToString());
                    _pOrder_SEQ = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_SEQ"].ToString();
                    _pOrder_STATUS = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_STATUS"].ToString();
                    _luORDER_ID.Text = frmOr.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();//frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_ID"].ToString();
                    _luORDER_DATE.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_DATE"].ToString();
                    _luORDER_QTY.Text = or_num.ToString();
                    _luPART_NAME.Text = frmOr.dtReturn.Rows[0]["PART_NAME"].ToString();
                    _luPART_CODE.Text = frmOr.dtReturn.Rows[0]["PART_CODE"].ToString();
                    _luSEQ.Text = frmOr.dtReturn.Rows[0]["SEQ"].ToString();
                    //명칭
                    _luPROCESS_GUBUN.Text = frmOr.dtReturn.Rows[0]["PROCESS_GUBUN2"].ToString();
                    _luPROCESS_CODE.Text = frmOr.dtReturn.Rows[0]["PROCESS_NAME2"].ToString();
                    _luPROCESS_NAME.Text = frmOr.dtReturn.Rows[0]["PROCESS_CODE2"].ToString();
                    //코드
                    //_luPROCESS_GUBUN.Text = frmOr.dtReturn.Rows[0]["PROCESS_GUBUN"].ToString();
                    //_luPROCESS_CODE.Text = frmOr.dtReturn.Rows[0]["PROCESS_CODE"].ToString();
                    //_luPROCESS_NAME.Text = frmOr.dtReturn.Rows[0]["PROCESS_NAME"].ToString();
                    _luREMARK.Text = frmOr.dtReturn.Rows[0]["REMARK"].ToString();
                    _luOK_QTY.Text = ok_num.ToString();
                    _luNG_QTY.Text = ng_num.ToString();

                    _luRESOURCE_NAME.Text = frmOr.dtReturn.Rows[0]["PART_STANDARD"].ToString();


                    re_num = (int)Convert.ToDouble(ok_num.ToString()) + (int)Convert.ToDouble(ng_num.ToString());
                    _luRESULT_QTY.Text = re_num.ToString();

                    if (or_num <= re_num)
                    {
                        _luRESULT_QTY.ForeColor = Color.Red;
                    }
                    else
                    {
                        _luRESULT_QTY.ForeColor = Color.Black;
                    }
                    //FontResize(_luORDER_ID);
                    //FontResize(_luORDER_DATE);
                    //FontResize(_luPART_CODE);
                    //FontResize(_luPART_NAME);
                    //FontResize(_luORDER_QTY);
                    //FontResize(_luRESULT_QTY);
                    //FontResize(_luOK_QTY);
                    //FontResize(_luNG_QTY);



                    _pPOPWorkResult_T50Entity.CRUD = "W"; //작업중으로 변경
                    _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_ID = orderid;
                    _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_SEQ = _pOrder_SEQ;

                    bool isError2 = false;
                    isError2 = new frmPOPMain_PRODUCT_Work_T50Business().usWorkResultPopup_Save_02(_pPOPWorkResult_T50Entity);

                    //CoFAS_DevExpressManager.ShowInformationMessage("작업 시작.");
                }
            }


            frmOr.Dispose();
        }
        #endregion

        #region ○ BOM 버튼 
        private void _ucbtBOM_Click(object sender, EventArgs e)
        {

        }
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
            catch (Exception ex)
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
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 확인해주세요.");
                return;
            }

            if (c_yn == "Y")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("이미 완료된 작업지시입니다.");
                return;
            }

            if (CoFAS_DevExpressManager.ShowQuestionMessage("해당 작업지시를 완료 하시겠습니까?") == DialogResult.Yes)
            {

                _pPOPWorkResult_T50Entity.CRUD = "U";
                _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_ID = orderid;
                _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_SEQ = _pOrder_SEQ;
                _pPOPWorkResult_T50Entity.COMPLETE_YN = "Y";

                bool isError2 = false;
                isError2 = new frmPOPMain_PRODUCT_Work_T50Business().usWorkResultPopup_Save_01(_pPOPWorkResult_T50Entity);

                CoFAS_DevExpressManager.ShowInformationMessage("저장 되었습니다.");
                InitializeSetting();
                _ucbtWORK_ORDER_Click(null, null);
            }

        }
        #endregion

        #region ○ 발행 등록 저장 - InputData_Save()
        private void InputData_Save()
        {
            _pPOPWorkResult_T50Entity.PRINT_CODE = "BAR000001";

            _dtList_print = new frmPOPMain_PRODUCT_Work_T50Business().frmPOPMain_PRODUCT_MIX_barcode_Info(_pPOPWorkResult_T50Entity);

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
                        cmd = (j + 1).ToString("D3");

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

        private void InputResultData_Save(string strValue) //양품등록
        {

            //리턴값이 빈값이 아니고 0도 아닐경우 실적등록
            if (strValue != "0" && strValue != "")
            {
                _pPOPWorkResult_T50Entity.RESOURCE_CODE = _pTerminal_code;// _luPROCESS_CODE.GetValue();
                _pPOPWorkResult_T50Entity.COLLECTION_DATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                _pPOPWorkResult_T50Entity.PROPERTY_VALUE = orderid + _pOrder_SEQ;
                //CD501001 : 양품
                //CD501002 : 불량
                _pPOPWorkResult_T50Entity.CONDITION_CODE = "CD501001";

                //첫공정일떄 옵션 코드 던지기
                DataTable dtt = new frmPOPMain_PRODUCT_Work_T50Business().USP_production_order_t50_R60(orderid);

                //if (_pOrder_SEQ == dtt.Rows[0]["production_order_seq"].ToString())
                //{
                //    _pPOPWorkResult_T50Entity.OPTION_CODE = "PC190006";
                //}
                //else
                //{
                    _pPOPWorkResult_T50Entity.OPTION_CODE = "";
                //}

                _pPOPWorkResult_T50Entity.COLLECTION_VALUE = strValue.Replace(",", "");
                _pPOPWorkResult_T50Entity.COLLECTION_VALUE_STR = "";
                _pPOPWorkResult_T50Entity.USER_NAME = _luUSER_INFO.Text;

                bool isError = false;
                isError = new frmPOPMain_PRODUCT_Work_T50Business().frmPOPMain_PRODUCT_Work_T50_Save(_pPOPWorkResult_T50Entity);

                if (!isError)
                    this.DialogResult = DialogResult.OK;

                //작업지시상태 업데이트
                ok_num = ok_num + (int)Convert.ToDouble(_pPOPWorkResult_T50Entity.COLLECTION_VALUE.ToString());
                _luOK_QTY.Text = ok_num.ToString();

                re_num = (int)Convert.ToDouble(ok_num.ToString()) + (int)Convert.ToDouble(ng_num.ToString());
                _luRESULT_QTY.Text = re_num.ToString();

                if (or_num <= re_num) // 목표수량 이상
                {
                    _luRESULT_QTY.ForeColor = Color.Red;

                    // 작업지시 완료 처리
                    _pPOPWorkResult_T50Entity.CRUD = "U";
                    _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_ID = orderid;

                    if (or_num <= re_num)
                    {
                        _pPOPWorkResult_T50Entity.COMPLETE_YN = "Y";
                    }
                    else
                    {
                        _pPOPWorkResult_T50Entity.COMPLETE_YN = "N";
                    }

                    bool isError2 = false;

                    isError2 = new frmPOPMain_PRODUCT_Work_T50Business().usWorkResultPopup_Save_01(_pPOPWorkResult_T50Entity);
                    CoFAS_DevExpressManager.ShowInformationMessage("작업이 완료되었습니다.");
                    InitializeSetting();
                    _ucbtWORK_ORDER_Click(null, null);
                }
                else
                {
                    _luRESULT_QTY.ForeColor = Color.Black;
                }
            }
        }

        #endregion

        #region 불량실적 등록
        private void InputBadData_Save(string strValue, string strValue2) //불량등록
        {
            //리턴값이 빈값이 아니고 0도 아닐경우 실적등록
            if (strValue != "0" && strValue != "")
            {
                _pPOPWorkResult_T50Entity.RESOURCE_CODE = _pTerminal_code;// _luPROCESS_CODE.GetValue();
                _pPOPWorkResult_T50Entity.COLLECTION_DATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                _pPOPWorkResult_T50Entity.PROPERTY_VALUE = orderid + _pOrder_SEQ;
                //CD501001 : 양품
                //CD501002 : 불량
                _pPOPWorkResult_T50Entity.CONDITION_CODE = strValue2.Replace(",", ""); // 불량코드 (BC---)

                //첫공정일떄 옵션 코드 던지기
                DataTable dtt = new frmPOPMain_PRODUCT_Work_T50Business().USP_production_order_t50_R60(orderid);

                //if (_pOrder_SEQ == dtt.Rows[0]["production_order_seq"].ToString())
                //{
                //    _pPOPWorkResult_T50Entity.OPTION_CODE = "PC190006";
                //}
                //else
                //{
                    _pPOPWorkResult_T50Entity.OPTION_CODE = "";
                //}
                
                _pPOPWorkResult_T50Entity.COLLECTION_VALUE = strValue.Replace(",", "");
                _pPOPWorkResult_T50Entity.COLLECTION_VALUE_STR = "";
                _pPOPWorkResult_T50Entity.USER_NAME = _luUSER_INFO.Text;
                bool isError = false;
                isError = new frmPOPMain_PRODUCT_Work_T50Business().frmPOPMain_PRODUCT_Work_T50_Save(_pPOPWorkResult_T50Entity);

                if (!isError)
                    this.DialogResult = DialogResult.OK;

                //작업지시상태 업데이트
                ng_num = ng_num + (int)Convert.ToDouble(_pPOPWorkResult_T50Entity.COLLECTION_VALUE.ToString());
                _luNG_QTY.Text = ng_num.ToString();

                re_num = (int)Convert.ToDouble(ng_num.ToString()) + (int)Convert.ToDouble(ok_num.ToString());
                _luRESULT_QTY.Text = re_num.ToString();

                if (or_num <= re_num) // 목표수량 이상
                {
                    _luRESULT_QTY.ForeColor = Color.Red;

                    // 작업지시 완료 처리
                    _pPOPWorkResult_T50Entity.CRUD = "U";
                    _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_ID = orderid;
                    _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_SEQ = _pOrder_SEQ;
                    if (or_num <= re_num)
                    {
                        _pPOPWorkResult_T50Entity.COMPLETE_YN = "Y";
                    }
                    else
                    {
                        _pPOPWorkResult_T50Entity.COMPLETE_YN = "N";
                    }

                    bool isError2 = false;

                    isError2 = new frmPOPMain_PRODUCT_Work_T50Business().usWorkResultPopup_Save_01(_pPOPWorkResult_T50Entity);
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
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요.");
                return;
            }

            frmPOPResult_T50 frmkey = new frmPOPResult_T50(_luPART_NAME.Text, _luPART_CODE.Text, orderid);
            frmkey.titleName = orderid;

            string ResultQTY = string.Empty;
            string PopupValue2 = string.Empty;
            string PopupValue3 = string.Empty;

            if (frmkey.ShowDialog() == DialogResult.OK)
            {
                ResultQTY = frmkey.ReturnValue4; //불량수량
                PopupValue2 = frmkey.ReturnValue5; //불량원인코드
                PopupValue3 = frmkey.ReturnValue6; //양품수량

                if(Convert.ToInt32(Convert.ToDouble(_luORDER_QTY.Text)) < Convert.ToInt32(_luRESULT_QTY.Text) + Convert.ToInt32(ResultQTY) + Convert.ToInt32(PopupValue3))
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("총 작업수량이 지시수량보다 많을 수 없습니다.\r\n다시 입력해주세요.\r\n입력 가능 작업 수량 : " + (Convert.ToInt32(Convert.ToDouble(_luORDER_QTY.Text)) - Convert.ToInt32(_luRESULT_QTY.Text)).ToString());

                    return;
                }

                InputBadData_order(ResultQTY);
                InputBadData_Save(ResultQTY, PopupValue2); //불량 데이터 등록
                InputResultData_Save(PopupValue3); //양품 데이터 등록
            }
        }

        #endregion

        #region 불량 발생시 뒷공정 작업수량에서 빼주기
        private void InputBadData_order(string badqty)
        {
            if (badqty != "0" && badqty != "")
            {
                new frmPOPMain_PRODUCT_Work_T50Business().USP_PRODUCTION_ORDER_T50_U10(orderid, _luSEQ.Text, badqty);
            }
        }
        #endregion

        #region 설비점검 등록
        private void _ucbtCHECK_REG_Click(object sender, EventArgs e)
        {
            frmPOPEquipmentCheck frmCheck = new frmPOPEquipmentCheck(_pUserEntity, _pUserEntity.POP_TITLE);
            frmCheck.ShowDialog();
            if (frmCheck.dtReturn == null)
            {
                frmCheck.Dispose();
                return;
            }
        }
        #endregion

        private void _ucbtIMAGE_Click(object sender, EventArgs e)
        {
            if (_luORDER_ID.Text == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요.");
                return;
            }
            
            #region 이미지 뷰어 관련
            _pPOPWorkResult_T50Entity.PART_CODE = _luPART_CODE.Text;
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //DataTable dt = dtdt(_luORDER_ID.Text);
                DataTable dt = MS_DBClass.USP_POP_FILE(_luORDER_ID.Text);

                //_dtList = new POPProductImageCommonBusiness().POPProductImage_Info(_pPOPWorkResult_T50Entity);

                if (_pPOPWorkResult_T50Entity.CRUD == "") _dtList.Rows.Clear();


                if (dt != null && dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][5] != null)
                    {
                        MemoryStream _ms = new MemoryStream();

                        if (dt != null && dt.Rows.Count > 0)
                        {
                            _ms = new MemoryStream((byte[])dt.Rows[0][5]);

                            frmPdfView_T50.CORP_CDDE = _pCORP_CDDE;
                            frmPdfView_T50.USER_CODE = _pUSER_CODE;
                            frmPdfView_T50.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                            frmPdfView_T50.FONT_TYPE = _pFONT_SETTING;
                            frmPdfView_T50.MS = _ms;
                            frmPdfView_T50.PART_CODE = _luPART_CODE.Text;
                            frmPdfView_T50.FTP_ID = _pFTP_ID;
                            frmPdfView_T50.FTP_PATH = _pFTP_PATH;
                            frmPdfView_T50.FTP_PW = _pFTP_PW;
                            frmPdfView_T50 xfrmImageView = new frmPdfView_T50();
                            CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
                            xfrmImageView.ShowDialog();
                        }
                    }
                    else
                    {
                        NoimageView();
                    }
                }
                //이미지 없음
                else
                {
                    NoimageView();
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }

            #endregion

        }

        private void _ucbCANCEL_REG_Click(object sender, EventArgs e)
        {
            if (_luORDER_ID.Text == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요.");
                return;
            }


            frmPOPCancel_T50 frmCancel = new frmPOPCancel_T50(orderid, _pOrder_SEQ);
            frmCancel.ShowDialog();

            if (frmCancel.ReturnValue1 == "P")
            {
                //보류 : 선택작업지시 초기화 , FLAG UPDATE : P, 현재시간 - 시작시간 으로 Detail_T50 에 total_time update

                _pPOPWorkResult_T50Entity.CRUD = "P";
                _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_ID = orderid;
                _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_SEQ = _pOrder_SEQ;

                bool isError2 = false;
                isError2 = new frmPOPMain_PRODUCT_Work_T50Business().usWorkResultPopup_Save_02(_pPOPWorkResult_T50Entity);

                CoFAS_DevExpressManager.ShowInformationMessage("작업보류 되었습니다.");
                InitializeSetting();
            }
            else if (frmCancel.ReturnValue2 == "N")
            {

                //보류 : 선택작업지시 초기화 , FLAG UPDATE : N , 현재시간 : (null) 로 UPDATE

                _pPOPWorkResult_T50Entity.CRUD = "N";
                _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_ID = orderid;
                _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_SEQ = _pOrder_SEQ;

                bool isError2 = false;
                isError2 = new frmPOPMain_PRODUCT_Work_T50Business().usWorkResultPopup_Save_02(_pPOPWorkResult_T50Entity);

                CoFAS_DevExpressManager.ShowInformationMessage("선택취소 되었습니다.");
                InitializeSetting();


                //
            }



        }

        private void Serial_Data(byte[] data)
        {
            //DataTable dt;
            //POPProductionOrder_T50Entity _pPOPProductionOrder_T50Entity = new POPProductionOrder_T50Entity(); ; // 엔티티 생성
            //_pPOPProductionOrder_T50Entity.RESOURCE_CODE = _pTerminal_code;
            //_pPOPProductionOrder_T50Entity.PROCESS_CODE = _pUserEntity.PROCESS_CODE;
            bool tf = true;
            if (_luORDER_ID.Text != "" || _pOrder_STATUS == "P")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("진행중인 작업을 보류/취소 후 가능합니다.");
                return;
            }
            
            if (data.Length < 2)
            {            
                return;
            }
            else
            {
                string str = Encoding.Default.GetString(data);
                orderid = str.Replace("\r\n", "");
                DataTable dt = new POPProductionOrder_T50Business().POPProductionOrder_Info_3(orderid);

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["equipment_code"].ToString() != _pUserEntity.PROCESS_CODE)
                    {
                        DialogResult dialogResult = CoFAS_DevExpressManager.ShowQuestionMessage("다른 설비에 할당된 작업입니다. 계속하시겠습니까?");

                        if(dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
                        {
                            tf = false;                           
                        }
                    }


                    if (tf)
                    {
                        //작지 설비 변경
                        new POPProductionOrder_T50Business().POPProductionOrder_Info_4(str, dt.Rows[0]["PRODUCTION_ORDER_SEQ"].ToString(), _pUserEntity.PROCESS_CODE);

                        or_num = (int)Convert.ToDouble(dt.Rows[0]["PRODUCTION_ORDER_QTY"].ToString());
                        ok_num = (int)Convert.ToDouble(dt.Rows[0]["OK_QTY"].ToString());
                        ng_num = (int)Convert.ToDouble(dt.Rows[0]["NG_QTY"].ToString());
                        _pOrder_SEQ = dt.Rows[0]["PRODUCTION_ORDER_SEQ"].ToString();
                        _pOrder_STATUS = dt.Rows[0]["PRODUCTION_ORDER_STATUS"].ToString();
                        CSafeSetText(_luORDER_ID, dt.Rows[0]["production_order_id"].ToString());
                        CSafeSetText(_luORDER_DATE, dt.Rows[0]["PRODUCTION_ORDER_DATE"].ToString());
                        CSafeSetText(_luORDER_QTY, or_num.ToString());
                        CSafeSetText(_luPART_NAME, dt.Rows[0]["PART_NAME"].ToString());
                        CSafeSetText(_luPART_CODE, dt.Rows[0]["PART_CODE"].ToString());
                        CSafeSetText(_luSEQ, dt.Rows[0]["SEQ"].ToString());
                        CSafeSetText(_luPROCESS_GUBUN, dt.Rows[0]["PROCESS_GUBUN2"].ToString());
                        CSafeSetText(_luPROCESS_CODE, dt.Rows[0]["PROCESS_NAME2"].ToString());
                        CSafeSetText(_luPROCESS_NAME, dt.Rows[0]["PROCESS_CODE2"].ToString());
                        CSafeSetText(_luREMARK, dt.Rows[0]["remark"].ToString());
                        CSafeSetText(_luOK_QTY, ok_num.ToString());
                        CSafeSetText(_luNG_QTY, ng_num.ToString());
                        CSafeSetText(_luRESOURCE_NAME, dt.Rows[0]["PART_STANDARD"].ToString());

                        re_num = (int)Convert.ToDouble(ok_num.ToString()) + (int)Convert.ToDouble(ng_num.ToString());
                        CSafeSetText(_luRESULT_QTY, re_num.ToString());

                        if (or_num <= re_num)
                        {
                            CSafeSetColor(_luRESULT_QTY, Color.Red);
                        }
                        else
                        {
                            CSafeSetColor(_luRESULT_QTY, Color.Black);
                        }

                        _pPOPWorkResult_T50Entity.CRUD = "W"; //작업중으로 변경
                        _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_ID = orderid;
                        _pPOPWorkResult_T50Entity.PRODUCTION_ORDER_SEQ = _pOrder_SEQ;

                        bool isError2 = false;
                        isError2 = new frmPOPMain_PRODUCT_Work_T50Business().usWorkResultPopup_Save_02(_pPOPWorkResult_T50Entity);

                        bool tf2 = true;

                        DialogResult dialogResult = CoFAS_DevExpressManager.ShowQuestionMessage("현재 작업자 : " + _luUSER_INFO.Text + "\r\n현재 작업자를 교체하시겠습니까?");

                        if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
                        {
                            tf2 = false;
                        }

                        if (tf2)
                        {
                            frmPOPWorker_T50 frmPOPWorker_T50 = new frmPOPWorker_T50(_pUserEntity);
                            frmPOPWorker_T50.ShowDialog();
                            if (frmPOPWorker_T50.dtReturn == null)
                            {
                                frmPOPWorker_T50.Dispose();
                                return;
                            }

                            _pUSER_NAME = frmPOPWorker_T50.dtReturn.Rows[0]["USER_NAME"].ToString();
                            _pUSER_CODE = frmPOPWorker_T50.dtReturn.Rows[0]["USER_ACCOUNT"].ToString();
                            CSafeSetText(_luUSER_INFO, frmPOPWorker_T50.dtReturn.Rows[0]["USER_NAME"].ToString());
                            CoFAS_DevExpressManager.ShowInformationMessage("작업자가 변경되었습니다.");
                        }
                    }
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                }
            }
        }

        private void CSafeSetText(Control ctl, String text)
        {
            if (ctl.InvokeRequired)
                ctl.Invoke(new CrossThreadSafetySetText(CSafeSetText), ctl, text);
            else
                ctl.Text = text;
        }

        private void CSafeSetColor(Control ctl, Color color)
        {
            if (ctl.InvokeRequired)
                ctl.Invoke(new CrossThreadSafetySetColor(CSafeSetColor), ctl, color);
            else
                ctl.ForeColor = color;
        }

        //작업자 리스트
        private void _luUSER_INFO_Click(object sender, EventArgs e)
        {
            bool tf = true;
            
            DialogResult dialogResult = CoFAS_DevExpressManager.ShowQuestionMessage("현재 작업자 : " + _luUSER_INFO.Text + "\r\n현재 작업자를 교체하시겠습니까?");

            if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
            {
                tf = false;
            }

            if (tf)
            {
                frmPOPWorker_T50 frmPOPWorker_T50 = new frmPOPWorker_T50(_pUserEntity);
                frmPOPWorker_T50.ShowDialog();
                if (frmPOPWorker_T50.dtReturn == null || frmPOPWorker_T50.dtReturn.Rows.Count == 0)
                {
                    frmPOPWorker_T50.Dispose();
                    return;
                }

                _pUSER_NAME = frmPOPWorker_T50.dtReturn.Rows[0]["USER_NAME"].ToString();
                _pUSER_CODE = frmPOPWorker_T50.dtReturn.Rows[0]["USER_ACCOUNT"].ToString();
                _luUSER_INFO.Text = frmPOPWorker_T50.dtReturn.Rows[0]["USER_NAME"].ToString();

                CoFAS_DevExpressManager.ShowInformationMessage("작업자가 변경되었습니다.");
            }            
        }

        private void _ucbtDowntime_Click(object sender, EventArgs e)
        {
            _pPOPWorkResult_T50Entity.TERMINAL_CODE = _pUserEntity.PROCESS_CODE;
            frmPOPDowntime frmPOPDowntime = new frmPOPDowntime();
            

            if(frmPOPDowntime.ShowDialog() == DialogResult.OK)
            {
                //가동 비가동 테이블에 데이터 넣어야함.
                ///ReturnValue1 = 가동, 비가동 여부
                ///ReturnValue2 = 비가동 사유
               
                DataTable dt = new frmPOPMain_PRODUCT_Work_T50Business().USP_equipment_running_R10(_pPOPWorkResult_T50Entity);

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["equipment_state"].ToString() == frmPOPDowntime.ReturnValue1)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("설비가 이미 " + dt.Rows[0]["code_name"].ToString() + " 상태입니다.");
                        _ucbtDowntime_Click(null, null);
                        return;
                    }
                }


                _pPOPWorkResult_T50Entity.TERMINAL_CODE = _pUserEntity.PROCESS_CODE;//설비코드
                _pPOPWorkResult_T50Entity.PROCESS_CODE = _pUserEntity.RESOURCE_CODE;//POP코드
                _pPOPWorkResult_T50Entity.USER_NAME = _pUSER_NAME;
                _pPOPWorkResult_T50Entity.PROPERTY_VALUE = frmPOPDowntime.ReturnValue1;//가동 비가동 코드

                new frmPOPMain_PRODUCT_Work_T50Business().USP_equipment_running_I10(_pPOPWorkResult_T50Entity, frmPOPDowntime.ReturnValue2);
            }
        }

        private DataTable dtdt(string code)
        {
            try
            {
                SqlConnection con;
                //con = new SqlConnection("Data Source=db3.coever.co.kr;Initial Catalog=DTISFILEDB;User ID=sa; Password=Codb89897788@$^;");
                con = new SqlConnection("Data Source=192.168.123.252;Initial Catalog=DTISFILEDB;User ID=pmo; Password=semids1357!;");
                SqlCommand cmd;
                cmd = new SqlCommand();
                cmd.CommandText = "USP_POP_FILE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DOCNO", SqlDbType.VarChar, 50));

                // 값할당
                cmd.Parameters["@DOCNO"].Value = code;


                SqlDataReader dr;
                DataTable dt;
                dt = new DataTable();
                con.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();
                return dt;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public void NoimageView()
        {
            string strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/{3}/", _pFTP_PATH, "ITEM", "ITEM_IMAGE", "ProductInformationRegister");

            var stream = CoFAS_FTPManager.FTPImage(strFTP_PATH, "Noimage.pdf", _pFTP_ID, _pFTP_PW);

            MemoryStream _ms = new MemoryStream();
            byte[] buffer = new byte[16 * 1024];
            int read;
            while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                _ms.Write(buffer, 0, read);
            }

            frmPdfView_T50.CORP_CDDE = _pCORP_CDDE;
            frmPdfView_T50.USER_CODE = _pUSER_CODE;
            frmPdfView_T50.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmPdfView_T50.FONT_TYPE = _pFONT_SETTING;
            frmPdfView_T50.MS = _ms;
            frmPdfView_T50.PART_CODE = _luPART_CODE.Text;
            frmPdfView_T50.FTP_ID = _pFTP_ID;
            frmPdfView_T50.FTP_PATH = _pFTP_PATH;
            frmPdfView_T50.FTP_PW = _pFTP_PW;
            frmPdfView_T50 xfrmImageView = new frmPdfView_T50();
            CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            xfrmImageView.ShowDialog();
        }

        
    }
}
