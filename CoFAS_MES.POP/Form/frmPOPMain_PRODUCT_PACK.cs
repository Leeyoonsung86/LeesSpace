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

namespace CoFAS_MES.POP
{
    public partial class frmPOPMain_PRODUCT_PACK : frmBasePOP
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

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtList_print = null; //조회 데이터 리스트 (바코드 발행)
        private DataTable _dtList_terminal = null; //터미널 상세정보 리스트

        private CoFAS_Serial _pCoFAS_Serial = null;  // 시리얼 생성

        public UserEntity _pUserEntity = null;
        private POPSelect_INSPECT_MIXEntity _pPOPSelect_INSPECT_MIXEntity = null; // 엔티티 생성

        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티
        
        private int ok_num = 0; // 양품수량
        private int ng_num = 0; // NG수량

        private int re_num = 0; // 작업수량
        private int or_num = 0; // 목표수량

        private string Print_cmd = null; // 바코드 CMD
        private string unit = null; // 표시 단위
        private string c_yn = null;
        private string _pTerminal_code = null;

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

        public frmPOPMain_PRODUCT_PACK(UserEntity pUserEntity, string termial_code)
        {
            InitializeComponent();

            _pUserEntity = pUserEntity;
            _pTerminal_code = termial_code;

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
                InitializeCorporationCI();
                Initialize();
                InitializeSetting();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 화면 로고 초기화 - InitializeCorporationCI()
        private void InitializeCorporationCI()
        {
            DataTable dtCI = new SystemSettingBusiness().CI_Download();
            if (dtCI != null && (dtCI.Rows[0]["LOGO_SECOND"]).ToString().Length > 0 && (((byte[])dtCI.Rows[0]["LOGO_SECOND"]).Length > 0 && dtCI.Rows.Count > 0))
            {
                if (System.IO.File.Exists(Application.StartupPath + "\\" + "logo2.png"))
                {
                    _peCI.Image.Dispose();
                    _peCI.Image = null;
                    System.IO.File.Delete(Application.StartupPath + "\\" + "logo2.png");
                }

                Image imgCI = CoFAS_ConvertManager.byteArrayToImage((byte[])dtCI.Rows[0]["LOGO_SECOND"]);
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
                _luORDER_ID.Text = "";
                _luORDER_DATE.Text = "";
                _luORDER_QTY.Text = "";
                _luNG_QTY.Text = "";
                _luRESULT_QTY.Text = "";
                _luOK_QTY.Text = "";

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

                _pPOPSelect_INSPECT_MIXEntity = new POPSelect_INSPECT_MIXEntity();
                _pPOPSelect_INSPECT_MIXEntity.CORP_CODE = _pCORP_CDDE;
                _pPOPSelect_INSPECT_MIXEntity.USER_CODE = _pUSER_CODE;
                _pPOPSelect_INSPECT_MIXEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pPOPSelect_INSPECT_MIXEntity.PROCESS_CODE = "";
                _pPOPSelect_INSPECT_MIXEntity.RESOURCE_CODE = "";

                //그리드 설정

                //   double ddd = Math.Acos(0.912);


                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _pPOPSelect_INSPECT_MIXEntity.USER_CODE = _pUserEntity.USER_CODE;
                    _pFirstYN = false;
                }

                //버튼 세팅
                if (_pUserEntity.PROCESS_CODE == "frmPOPMain_PRODUCT_PACKET")
                {
                    _ucbtPRINT_REG.Visible = true;

                    SetHardware();
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
                _pPOPSelect_INSPECT_MIXEntity.TERMINAL_CODE = _pTerminal_code;

                _dtList_terminal = new frmPOPMain_PRODUCT_MIXBusiness().frmPOPMain_PRODUCT_MIX_terminal_Info(_pPOPSelect_INSPECT_MIXEntity);

                string partName = _dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString();
                int baudRate = Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString());
                string parity = _dtList_terminal.Rows[0]["INFO_PARITY"].ToString();
                int dataBits = Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString());
                string stopBits = _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString();

                _pCoFAS_Serial = new CoFAS_Serial(partName, baudRate, parity, dataBits, stopBits);
                _pCoFAS_Serial.Open();

                // 연결할 H/W 연결상태 표시. (연동시 변경)
                lc_0.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;

                //CoFAS_DevExpressManager.ShowInformationMessage("POP Start Complete");
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
            frmPOPOrder_T01 frmOr = new frmPOPOrder_T01(_pUserEntity);
            frmOr.ShowDialog();
            if (frmOr.dtReturn == null)
            {
                frmOr.Dispose();
                return;
            }

            if (frmOr.dtReturn != null && frmOr.dtReturn.Rows.Count > 0)
            {
                _luORDER_ID.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_ID"].ToString();
                _luORDER_DATE.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_DATE"].ToString();
                _luORDER_QTY.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_QTY"].ToString() + " (" + frmOr.dtReturn.Rows[0]["CODE_UNIT"].ToString() + ") ";
                _luPART_NAME.Text = frmOr.dtReturn.Rows[0]["PART_NAME"].ToString();
                _luPART_CODE.Text = frmOr.dtReturn.Rows[0]["PART_CODE"].ToString();

                _luOK_QTY.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_OK_QTY"].ToString() + " (" + frmOr.dtReturn.Rows[0]["CODE_UNIT"].ToString() + ") ";
                _luNG_QTY.Text = frmOr.dtReturn.Rows[0]["PRODUCTION_NG_QTY"].ToString() + " (" + frmOr.dtReturn.Rows[0]["CODE_UNIT"].ToString() + ") ";

                or_num = (int)Convert.ToDouble(frmOr.dtReturn.Rows[0]["PRODUCTION_ORDER_QTY"].ToString());
                ok_num = (int)Convert.ToDouble(frmOr.dtReturn.Rows[0]["PRODUCTION_OK_QTY"].ToString());
                ng_num = (int)Convert.ToDouble(frmOr.dtReturn.Rows[0]["PRODUCTION_NG_QTY"].ToString());

                unit = frmOr.dtReturn.Rows[0]["CODE_UNIT"].ToString();
                c_yn = frmOr.dtReturn.Rows[0]["COMPLETE_YN"].ToString();

                Print_cmd = frmOr.dtReturn.Rows[0]["PRINT_CMD"].ToString();

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

            }


            frmOr.Dispose();
        }
        #endregion

        #region ○ 실적등록 버튼
        private void _ucbtRESULT_REG_Click(object sender, EventArgs e)
        {
            if (_luORDER_ID.Text == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요.");
                return;
            }

            // 실적등록
            frmPopupKeypad frmkey = new frmPopupKeypad();
            frmkey.titleName = _luORDER_ID.Text;

            //실적등록
            string PopupValue = string.Empty;
            if (frmkey.ShowDialog() == DialogResult.OK)
            {

                PopupValue = frmkey.ReturnValue1;

                InputResultData_Save(PopupValue);
            }
        }
        #endregion

        #region ○ 불량등록 버튼
        private void _ucbtNG_REG_Click(object sender, EventArgs e)
        {
            if (_luORDER_ID.Text == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 먼저 선택해주세요.");
                return;
            }

            // 불량등록
            frmPOPBad frmb = new frmPOPBad();
            frmb.titleName = _luORDER_ID.Text;

            string PopupValue = string.Empty;
            string PopupValue2 = string.Empty;

            if (frmb.ShowDialog() == DialogResult.OK)
            {

                PopupValue = frmb.ReturnValue1;
                PopupValue2 = frmb.ReturnValue2;

                //리턴값이 빈값이 아니고 0도 아닐경우 실적등록
                if (PopupValue != "0" && PopupValue != "")
                {
                    _pPOPSelect_INSPECT_MIXEntity.RESOURCE_CODE = "";// _luPROCESS_CODE.GetValue();
                    _pPOPSelect_INSPECT_MIXEntity.COLLECTION_DATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    _pPOPSelect_INSPECT_MIXEntity.PROPERTY_VALUE = _luORDER_ID.Text;
                    //CD501001 : 양품
                    //CD501002 : 불량
                    _pPOPSelect_INSPECT_MIXEntity.CONDITION_CODE = PopupValue2.Replace(",", ""); // 불량코드 (BC---)
                    _pPOPSelect_INSPECT_MIXEntity.COLLECTION_VALUE = PopupValue.Replace(",", "");

                    bool isError = false;
                    isError = new frmPOPMain_PRODUCT_MIXBusiness().frmPOPMain_PRODUCT_MIX_Save(_pPOPSelect_INSPECT_MIXEntity);

                    if (!isError)
                        this.DialogResult = DialogResult.OK;

                    //작업지시상태 업데이트
                    ng_num = ng_num + (int)Convert.ToDouble(_pPOPSelect_INSPECT_MIXEntity.COLLECTION_VALUE.ToString());
                    _luNG_QTY.Text = ng_num.ToString() + " (" + unit + ") ";

                    re_num = (int)Convert.ToDouble(ng_num.ToString()) + (int)Convert.ToDouble(ok_num.ToString());
                    _luRESULT_QTY.Text = re_num.ToString() + " (" + unit + ") ";

                    if (or_num <= re_num) // 목표수량 이상
                    {
                        _luRESULT_QTY.ForeColor = Color.Red;

                        // 작업지시 완료 처리
                        _pPOPSelect_INSPECT_MIXEntity.CRUD = "U";
                        _pPOPSelect_INSPECT_MIXEntity.PRODUCTION_ORDER_ID = _luORDER_ID.Text;

                        if (or_num <= ok_num)
                        {
                            _pPOPSelect_INSPECT_MIXEntity.COMPLETE_YN = "Y";
                        }
                        else
                        {
                            _pPOPSelect_INSPECT_MIXEntity.COMPLETE_YN = "N";
                        }

                        bool isError2 = false;

                        isError2 = new frmPOPMain_PRODUCT_MIXBusiness().usWorkResultPopup_Save_01(_pPOPSelect_INSPECT_MIXEntity);
                    }
                    else
                    {
                        _luRESULT_QTY.ForeColor = Color.Black;
                    }

                }
            }
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

        #region ○ 강제완료 버튼
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

            if (CoFAS_DevExpressManager.ShowQuestionMessage("'" + _luPART_NAME.Text + "'을(를) 강제완료 하시겠습니까?") == DialogResult.Yes)
            {

                _pPOPSelect_INSPECT_MIXEntity.CRUD = "U";
                _pPOPSelect_INSPECT_MIXEntity.PRODUCTION_ORDER_ID = _luORDER_ID.Text;
                _pPOPSelect_INSPECT_MIXEntity.COMPLETE_YN = "Y";

                bool isError2 = false;
                isError2 = new frmPOPMain_PRODUCT_MIXBusiness().usWorkResultPopup_Save_01(_pPOPSelect_INSPECT_MIXEntity);
                
                CoFAS_DevExpressManager.ShowInformationMessage("저장 되었습니다.");
            }
        }
        #endregion

        #region ○ 발행 등록 저장 - InputData_Save()
        private void InputData_Save()
        {
            _pPOPSelect_INSPECT_MIXEntity.PRINT_CODE = "BAR000001";

            _dtList_print = new frmPOPMain_PRODUCT_MIXBusiness().frmPOPMain_PRODUCT_MIX_barcode_Info(_pPOPSelect_INSPECT_MIXEntity);

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

        #region ○ 실적 등록 저장 - InputResultData_Save(string strValue, int comCheck)

        private void InputResultData_Save(string strValue)
        {
            
            //리턴값이 빈값이 아니고 0도 아닐경우 실적등록
            if (strValue != "0" && strValue != "")
            {
                _pPOPSelect_INSPECT_MIXEntity.RESOURCE_CODE = "";// _luPROCESS_CODE.GetValue();
                _pPOPSelect_INSPECT_MIXEntity.COLLECTION_DATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                _pPOPSelect_INSPECT_MIXEntity.PROPERTY_VALUE = _luORDER_ID.Text;
                //CD501001 : 양품
                //CD501002 : 불량
                _pPOPSelect_INSPECT_MIXEntity.CONDITION_CODE = "CD501001";
                _pPOPSelect_INSPECT_MIXEntity.COLLECTION_VALUE = strValue.Replace(",", "");

                bool isError = false;
                isError = new frmPOPMain_PRODUCT_MIXBusiness().frmPOPMain_PRODUCT_MIX_Save(_pPOPSelect_INSPECT_MIXEntity);

                if (!isError)
                    this.DialogResult = DialogResult.OK;

                //작업지시상태 업데이트
                ok_num = ok_num + (int)Convert.ToDouble(_pPOPSelect_INSPECT_MIXEntity.COLLECTION_VALUE.ToString());
                _luOK_QTY.Text = ok_num.ToString() + " (" + unit + ") ";

                re_num = (int)Convert.ToDouble(ok_num.ToString()) + (int)Convert.ToDouble(ng_num.ToString());
                _luRESULT_QTY.Text = re_num.ToString() + " (" + unit + ") ";

                if (or_num <= re_num) // 목표수량 이상
                {
                    _luRESULT_QTY.ForeColor = Color.Red;

                    // 작업지시 완료 처리
                    _pPOPSelect_INSPECT_MIXEntity.CRUD = "U";
                    _pPOPSelect_INSPECT_MIXEntity.PRODUCTION_ORDER_ID = _luORDER_ID.Text;

                    if (or_num <= ok_num)
                    {
                        _pPOPSelect_INSPECT_MIXEntity.COMPLETE_YN = "Y";
                    }
                    else
                    {
                        _pPOPSelect_INSPECT_MIXEntity.COMPLETE_YN = "N";
                    }

                    bool isError2 = false;

                    isError2 = new frmPOPMain_PRODUCT_MIXBusiness().usWorkResultPopup_Save_01(_pPOPSelect_INSPECT_MIXEntity);
                }
                else
                {
                    _luRESULT_QTY.ForeColor = Color.Black;
                }
            }
        }
        #endregion
    }
}
