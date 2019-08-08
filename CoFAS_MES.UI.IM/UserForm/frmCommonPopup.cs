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
using CoFAS_MES.UI.IM.UserControls;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.UI.IM.Entity;

namespace CoFAS_MES.UI.IM.UserForm
{
    public partial class frmCommonPopup : frmBaseSingle
    {
        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)     
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭 
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private static string _pFTP_ID = string.Empty;          // FTP ID 정보
        private static string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private static string _pFTP_PW = string.Empty;          //FTP PW 정보
        private static string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보

        private static Font fntPARENT_FONT = null;

        private string _pFindControl = "";

        private static string _pCRUD = "";
        private static WorkResultRegister_T01Entity _pWorkResultRegister_T01Entity = null; // 엔티티 생성

        private static object[] _pARRAY = null;

        private static object[] _pARRAY_CODE = null;

        public static string CRUD
        {
            get { return _pCRUD; }
            set { _pCRUD = value; }
        }
        public static string CORP_CDDE
        {
            get{ return _pCORP_CODE; }
            set{ _pCORP_CODE = value; }
        }
        public static string USER_CODE
        {
            get { return _pUSER_CODE; }
            set { _pUSER_CODE = value; }
        }
        public static string LANGUAGE_TYPE
        {
            get { return _pLANGUAGE_TYPE; }
            set { _pLANGUAGE_TYPE = value; }
        }
        public static Font FONT_TYPE
        {
            get { return fntPARENT_FONT; }
            set { fntPARENT_FONT = value; }
        }

        public static string FTP_PATH
        {
            get { return _pFTP_PATH; }
            set { _pFTP_PATH = value; }
        }
        public static string FTP_ID
        {
            get { return _pFTP_ID; }
            set { _pFTP_ID = value; }
        }
        public static string FTP_PW
        {
            get { return _pFTP_PW; }
            set { _pFTP_PW = value; }
        }
        public static string FTP_IP_PORT
        {
            get { return _pFTP_IP_PORT; }
            set { _pFTP_IP_PORT = value; }
        }
        public static object[] ARRAY
        {
            get { return _pARRAY; }
            set { _pARRAY = value; }
        }

        public static object[] ARRAY_CODE
        {
            get { return _pARRAY_CODE; }
            set { _pARRAY_CODE = value; }
        }
        public static WorkResultRegister_T01Entity WorkResultRegister_T01Entity
        {
            get { return _pWorkResultRegister_T01Entity; }
            set { _pWorkResultRegister_T01Entity = value; }
        }
        private UserControl _uc = new UserControl();

        private DataTable _dtreturn = new DataTable();

        public DataTable dtReturn
        {
            get
            {
                return _dtreturn;

            }
            set
            {
                _dtreturn = value;
            }

        }

        public frmCommonPopup(string strFindControl)
        {
            InitializeComponent();

            _pFindControl = strFindControl;

            _pWINDOW_NAME = this.Name.ToString();

            Child_WindowName = "";
            Child_User_Code = _pUSER_CODE;
            Child_Language_Type = _pLANGUAGE_TYPE;
            Child_Font_Setting = fntPARENT_FONT;


            InitializeSetting();

            switch (_pFindControl)
            {
                case "PartProcessMapping":  // 파트 별 프로세스 맵핑


                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucPartProcessMapping_Popup";

                    ucPartProcessMapping_Popup.CORP_CDDE = _pCORP_CODE;
                    ucPartProcessMapping_Popup.USER_CODE = _pUSER_CODE;
                    ucPartProcessMapping_Popup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucPartProcessMapping_Popup.FONT_TYPE = fntPARENT_FONT;

                    ucPartProcessMapping_Popup.ARRAY = _pARRAY;
                    ucPartProcessMapping_Popup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucPartProcessMapping_Popup();

                    //  ucWorkOrderInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucPartProcessMapping_Popup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "PartProcessMapping_T01":  // 파트 별 프로세스 맵핑

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucPartProcessMapping_Popup_T01";

                    ucPartProcessMapping_Popup_T01.CORP_CDDE = _pCORP_CODE;
                    ucPartProcessMapping_Popup_T01.USER_CODE = _pUSER_CODE;
                    ucPartProcessMapping_Popup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucPartProcessMapping_Popup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucPartProcessMapping_Popup_T01.ARRAY = _pARRAY;
                    ucPartProcessMapping_Popup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucPartProcessMapping_Popup_T01();

                    //  ucWorkOrderInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucPartProcessMapping_Popup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "TerminalDetailInfo":  // 발주 찾기 팝업
                                            // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucTerminalDetailInfoPopup";

                    ucTerminalDetailInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucTerminalDetailInfoPopup.USER_CODE = _pUSER_CODE;
                    ucTerminalDetailInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucTerminalDetailInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucTerminalDetailInfoPopup.ARRAY = _pARRAY;
                    ucTerminalDetailInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucTerminalDetailInfoPopup();

                    //  ucWorkOrderInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucTerminalDetailInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "ucContractInfoPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucContractInfoPopup";

                    ucContractInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucContractInfoPopup.USER_CODE = _pUSER_CODE;
                    ucContractInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucContractInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucContractInfoPopup.ARRAY = _pARRAY;
                    ucContractInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucContractInfoPopup();

                    ucContractInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucContractInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "ucProcessDocumentListPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProcessDocumentListPopup";

                    ucProcessDocumentListPopup.CORP_CDDE = _pCORP_CODE;
                    ucProcessDocumentListPopup.USER_CODE = _pUSER_CODE;
                    ucProcessDocumentListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProcessDocumentListPopup.FONT_TYPE = fntPARENT_FONT;
                    ucProcessDocumentListPopup.FTP_PATH = _pFTP_PATH;
                    ucProcessDocumentListPopup.FTP_ID = _pFTP_ID;
                    ucProcessDocumentListPopup.FTP_PW = _pFTP_PW;

                    ucProcessDocumentListPopup.ARRAY = _pARRAY;
                    ucProcessDocumentListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProcessDocumentListPopup();

                    //ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProcessDocumentListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "ucToolDocumentListPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucToolDocumentListPopup";

                    ucToolDocumentListPopup.CORP_CDDE = _pCORP_CODE;
                    ucToolDocumentListPopup.USER_CODE = _pUSER_CODE;
                    ucToolDocumentListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucToolDocumentListPopup.FONT_TYPE = fntPARENT_FONT;
                    ucToolDocumentListPopup.FTP_PATH = _pFTP_PATH;
                    ucToolDocumentListPopup.FTP_ID = _pFTP_ID;
                    ucToolDocumentListPopup.FTP_PW = _pFTP_PW;

                    ucToolDocumentListPopup.ARRAY = _pARRAY;
                    ucToolDocumentListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucToolDocumentListPopup();

                    //ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucToolDocumentListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;
                case "ucVendInfoDocumentListPopup":
                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendInfoDocumentListPopup";

                    ucVendInfoDocumentListPopup.CORP_CDDE = _pCORP_CODE;
                    ucVendInfoDocumentListPopup.USER_CODE = _pUSER_CODE;
                    ucVendInfoDocumentListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucVendInfoDocumentListPopup.FONT_TYPE = fntPARENT_FONT;
                    ucVendInfoDocumentListPopup.FTP_PATH = _pFTP_PATH;
                    ucVendInfoDocumentListPopup.FTP_ID = _pFTP_ID;
                    ucVendInfoDocumentListPopup.FTP_PW = _pFTP_PW;

                    ucVendInfoDocumentListPopup.ARRAY = _pARRAY;
                    ucVendInfoDocumentListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucVendInfoDocumentListPopup();

                    //ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucVendInfoDocumentListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;
                    
                case "ucProRoutingDocumentListPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProRoutingDocumentListPopup";

                    ucProRoutingDocumentListPopup.CORP_CDDE = _pCORP_CODE;
                    ucProRoutingDocumentListPopup.USER_CODE = _pUSER_CODE;
                    ucProRoutingDocumentListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProRoutingDocumentListPopup.FONT_TYPE = fntPARENT_FONT;
                    ucProRoutingDocumentListPopup.FTP_PATH = _pFTP_PATH;
                    ucProRoutingDocumentListPopup.FTP_ID = _pFTP_ID;
                    ucProRoutingDocumentListPopup.FTP_PW = _pFTP_PW;

                    ucProRoutingDocumentListPopup.ARRAY = _pARRAY;
                    ucProRoutingDocumentListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProRoutingDocumentListPopup();

                    //ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProRoutingDocumentListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;
                case "ucWorkOrderDocRegPopup":  //제조/포장 지시서 팝업
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucWorkOrderDocRegPopup";

                    ucWorkOrderDocRegPopup.CORP_CDDE = _pCORP_CODE;
                    ucWorkOrderDocRegPopup.USER_CODE = _pUSER_CODE;
                    ucWorkOrderDocRegPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkOrderDocRegPopup.FONT_TYPE = fntPARENT_FONT;

                    ucWorkOrderDocRegPopup.WorkResultRegister_T01Entity = _pWorkResultRegister_T01Entity;

                    ucWorkOrderDocRegPopup.ARRAY = _pARRAY;
                    ucWorkOrderDocRegPopup.ARRAY_CODE = _pARRAY_CODE;

                    ucWorkOrderDocRegPopup.FTP_ID = _pFTP_ID;
                    ucWorkOrderDocRegPopup.FTP_IP_PORT = _pFTP_IP_PORT;
                    ucWorkOrderDocRegPopup.FTP_PATH = _pFTP_PATH;
                    ucWorkOrderDocRegPopup.FTP_PW = _pFTP_PW;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkOrderDocRegPopup();

                    // ucWorkOrderDocRegPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucWorkOrderDocRegPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==

                    this.Width = _uc.Width + 500;
                    this.Height = _uc.Height + 300;

                    break;

            }

            _uc.CreateControl();
            _pnSINGLE_MAIN.Controls.Add(_uc);
            _uc.Dock = DockStyle.Fill;
            
        }

        private void InitializeSetting()
        {
            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }
        }

        //UserControl 별 이벤트 데이터
        private void ucCommonCodePopup__OnDoubleClick(object sender, EventArgs e)
        {
            GridView gv = sender as GridView;
            _dtreturn = new DataTable();

            switch (_pFindControl)
            {
                case "ucContractInfoPopup":
                    _dtreturn.Columns.Add("CONTRACT_ID", typeof(string));
                    _dtreturn.Columns.Add("CONTRACT_NUMBER", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CONTRACT_ID").ToString(), gv.GetFocusedRowCellValue("CONTRACT_NUMBER").ToString() });
                    //user Control 생성시 고정 ==
                    break;


                    //case "MaterialOrder":
                    //    _dtreturn.Columns.Add("ORDER_DATE", typeof(string));
                    //    _dtreturn.Columns.Add("ORDER_ID", typeof(string));
                    //    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    //    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    //    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    //    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    //    _dtreturn.Columns.Add("ORDER_QTY", typeof(string));
                    //    _dtreturn.Columns.Add("UNITCOST", typeof(string));
                    //    _dtreturn.Columns.Add("COST", typeof(string));
                    //    _dtreturn.Columns.Add("PART_UNIT", typeof(string));
                    //    _dtreturn.Columns.Add("NIN_QTY", typeof(string));

                    //    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("ORDER_DATE").ToString(), gv.GetFocusedRowCellValue("ORDER_ID").ToString(), gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("ORDER_QTY").ToString(), gv.GetFocusedRowCellValue("UNITCOST").ToString(), gv.GetFocusedRowCellValue("COST").ToString(), gv.GetFocusedRowCellValue("PART_UNIT").ToString(), gv.GetFocusedRowCellValue("NIN_QTY").ToString() });
                    //    user Control 생성시 고정 ==
                    //    break;

                    //case "ProductionOrderInfo_Popup":
                    //    _dtreturn.Columns.Add("CONTRACT_ID", typeof(string));
                    //    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    //    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    //    _dtreturn.Columns.Add("CONTRACT_QTY", typeof(string));
                    //    _dtreturn.Columns.Add("INOUT_QTY", typeof(string));
                    //    _dtreturn.Columns.Add("LEAVE_QTY", typeof(string));
                    //    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    //    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    //    _dtreturn.Columns.Add("UNIT_CODE", typeof(string));
                    //    _dtreturn.Columns.Add("UNITCOST", typeof(string));
                    //    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CONTRACT_ID").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("CONTRACT_QTY").ToString(), gv.GetFocusedRowCellValue("INOUT_QTY").ToString(), gv.GetFocusedRowCellValue("LEAVE_QTY").ToString(), gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString(), gv.GetFocusedRowCellValue("UNIT_CODE").ToString(), gv.GetFocusedRowCellValue("UNITCOST").ToString() });
                    //    break;

            }



            Close();
        }
        private void ucCommonCodePopup_Close_OnClick(object sender, EventArgs e)
        {
            _dtreturn = new DataTable();
            
            switch (_pFindControl)
            {
                case "":
                    //_dtreturn.Columns.Add("PRODUCTION_PLAN_ID", typeof(string));
                    //_dtreturn.Rows.Add(new Object[] { _pARRAY_CODE[0] });
                    break;
            }

            Close();
        }

        private void frmCommonPopup_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = fntPARENT_FONT;//화면에 모든 항목 폰트 재설정
            }
        }

        private void _btPOPUP_SELECT_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void _btPOPUP_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
