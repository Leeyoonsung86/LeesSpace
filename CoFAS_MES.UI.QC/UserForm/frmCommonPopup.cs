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
using CoFAS_MES.UI.QC.UserControls;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using DevExpress.XtraEditors.Controls;

namespace CoFAS_MES.UI.QC.UserForm
{
    public partial class frmCommonPopup : frmBaseSingle
    {
        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)     
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭 
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private static string _pFTP_ID = string.Empty;          // FTP ID 정보
        private static string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private static string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private static string _pFTP_PW = string.Empty;          //FTP PW 정보
        private static Font fntPARENT_FONT = null;

        private string _pFindControl = "";

        //private static DataTable _pDATATABLE_VALUE = null;
        private static string _strFTP_PATH = string.Empty;
        private static string _strFILE_NAME = string.Empty;
        private static string _pCRUD = "";


        private static object[] _pARRAY = null;

        private static object[] _pARRAY_CODE = null;
        public static string FTP_ID
        {
            get { return _pFTP_ID; }
            set { _pFTP_ID = value; }
        }

        public static string FTP_IP_PORT
        {
            get { return _pFTP_IP_PORT; }
            set { _pFTP_IP_PORT = value; }
        }
        public static string strFTP_PATH
        {
            get { return _strFTP_PATH; }
            set { _strFTP_PATH = value; }
        }
        public static string strFile_NAME
        {
            get { return _strFILE_NAME; }
            set { _strFILE_NAME = value; }
        }
        public static string FTP_PATH
        {
            get { return _pFTP_PATH; }
            set { _pFTP_PATH = value; }
        }

        public static string FTP_PW
        {
            get { return _pFTP_PW; }
            set { _pFTP_PW = value; }
        }
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

                case "InspectRequest":  // 발주 찾기 팝업
                                        // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucInspectRequestInfoPopup";

                    ucInspectRequestInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucInspectRequestInfoPopup.USER_CODE = _pUSER_CODE;
                    ucInspectRequestInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucInspectRequestInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucInspectRequestInfoPopup.ARRAY = _pARRAY;
                    ucInspectRequestInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucInspectRequestInfoPopup();

                    ucInspectRequestInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucInspectRequestInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width+100;
                    this.Height = _uc.Height + 75;
                    break;

                case "InspectRequest_T01":  // 발주 찾기 팝업
                                            // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucInspectRequestInfoPopup_T01";

                    ucInspectRequestInfoPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucInspectRequestInfoPopup_T01.USER_CODE = _pUSER_CODE;
                    ucInspectRequestInfoPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucInspectRequestInfoPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucInspectRequestInfoPopup_T01.ARRAY = _pARRAY;
                    ucInspectRequestInfoPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucInspectRequestInfoPopup_T01();

                    ucInspectRequestInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucInspectRequestInfoPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "Calendar":  // 달력 팝업
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucCalendar";

                    ucCalendar.CORP_CDDE = _pCORP_CODE;
                    ucCalendar.USER_CODE = _pUSER_CODE;
                    ucCalendar.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucCalendar.FONT_TYPE = fntPARENT_FONT;

                    ucCalendar.ARRAY = _pARRAY;
                    ucCalendar.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucCalendar();

                    ucCalendar._OnDoubleClick += ucCommonCodePopup_Calendar_OnDoubleClick;
                    ucCalendar._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = 327;
                    this.Height = 300;
                    break;

                case "ImportInspectOrder": // 발주조회
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucImportInspectInfoPopup";

                    ucImportInspectInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucImportInspectInfoPopup.USER_CODE = _pUSER_CODE;
                    ucImportInspectInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucImportInspectInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucImportInspectInfoPopup.ARRAY = _pARRAY;
                    ucImportInspectInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucImportInspectInfoPopup();

                    ucImportInspectInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucImportInspectInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "ucProductionOrderInfoPopup_T08":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProductionOrderInfoPopup_T08";

                    ucProductionOrderInfoPopup_T08.CORP_CDDE = _pCORP_CODE;
                    ucProductionOrderInfoPopup_T08.USER_CODE = _pUSER_CODE;
                    ucProductionOrderInfoPopup_T08.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductionOrderInfoPopup_T08.FONT_TYPE = fntPARENT_FONT;

                    ucProductionOrderInfoPopup_T08.ARRAY = _pARRAY;
                    ucProductionOrderInfoPopup_T08.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductionOrderInfoPopup_T08();
                    ucProductionOrderInfoPopup_T08._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProductionOrderInfoPopup_T08._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "ucInspectPartListPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucInspectPartListPopup";

                    ucInspectPartListPopup.CORP_CDDE = _pCORP_CODE;
                    ucInspectPartListPopup.USER_CODE = _pUSER_CODE;
                    ucInspectPartListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucInspectPartListPopup.FONT_TYPE = fntPARENT_FONT;

                    ucInspectPartListPopup.ARRAY = _pARRAY;
                    ucInspectPartListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucInspectPartListPopup();

                    ucInspectPartListPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucInspectPartListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "ucQCMaterialPartListPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucQCMaterialPartListPopup";

                    ucQCMaterialPartListPopup.CORP_CDDE = _pCORP_CODE;
                    ucQCMaterialPartListPopup.USER_CODE = _pUSER_CODE;
                    ucQCMaterialPartListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucQCMaterialPartListPopup.FONT_TYPE = fntPARENT_FONT;

                    ucQCMaterialPartListPopup.ARRAY = _pARRAY;
                    ucQCMaterialPartListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucQCMaterialPartListPopup();

                    ucQCMaterialPartListPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucQCMaterialPartListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;
                case "ucMatInspectDocumentListPopup":
                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucMatInspectDocumentListPopup";

                    ucMatInspectDocumentListPopup.CORP_CDDE = _pCORP_CODE;
                    ucMatInspectDocumentListPopup.USER_CODE = _pUSER_CODE;
                    ucMatInspectDocumentListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMatInspectDocumentListPopup.FONT_TYPE = fntPARENT_FONT;
                    ucMatInspectDocumentListPopup.FTP_PATH = _pFTP_PATH;
                    ucMatInspectDocumentListPopup.FTP_ID = _pFTP_ID;
                    ucMatInspectDocumentListPopup.FTP_PW = _pFTP_PW;

                    ucMatInspectDocumentListPopup.ARRAY = _pARRAY;
                    ucMatInspectDocumentListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMatInspectDocumentListPopup();

                    //ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMatInspectDocumentListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
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

                case "MaterialOrder":
                    _dtreturn.Columns.Add("ORDER_DATE", typeof(string));
                    _dtreturn.Columns.Add("ORDER_ID", typeof(string));
                    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("ORDER_QTY", typeof(string));
                    _dtreturn.Columns.Add("UNITCOST", typeof(string));
                    _dtreturn.Columns.Add("COST", typeof(string));
                    _dtreturn.Columns.Add("PART_UNIT", typeof(string));
                    _dtreturn.Columns.Add("NIN_QTY", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("ORDER_DATE").ToString(), gv.GetFocusedRowCellValue("ORDER_ID").ToString(), gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("ORDER_QTY").ToString(), gv.GetFocusedRowCellValue("UNITCOST").ToString(), gv.GetFocusedRowCellValue("COST").ToString(), gv.GetFocusedRowCellValue("PART_UNIT").ToString(), gv.GetFocusedRowCellValue("NIN_QTY").ToString() });
                    //user Control 생성시 고정 ==
                    break;

                case "ucProductionOrderInfoPopup_T08":
                    _dtreturn.Columns.Add("PLAN_ORDER", typeof(string));
                    _dtreturn.Columns.Add("PLAN_ORDER_DATE", typeof(string));                    
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));                    
                    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    _dtreturn.Columns.Add("PLAN_ORDER_QTY", typeof(string));
                    //_dtreturn.Columns.Add("REFERENCE_ID", typeof(string));
                    //_dtreturn.Columns.Add("FIRSTMIDDLELAST", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("PLAN_ORDER").ToString(),
                                                      gv.GetFocusedRowCellValue("PLAN_ORDER_DATE").ToString(),
                                                      gv.GetFocusedRowCellValue("PART_CODE").ToString(),
                                                      gv.GetFocusedRowCellValue("PART_NAME").ToString(),
                                                      gv.GetFocusedRowCellValue("VEND_CODE").ToString(),
                                                      gv.GetFocusedRowCellValue("PLAN_ORDER_QTY").ToString()  });
                    break;

                case "ImportInspectOrder":
                    _dtreturn.Columns.Add("ORDER_ID", typeof(string));
                    _dtreturn.Columns.Add("ORDER_DATE", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("ORDER_QTY", typeof(string));
                   
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("ORDER_ID").ToString(), gv.GetFocusedRowCellValue("ORDER_DATE").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("ORDER_QTY").ToString() });
                    //user Control 생성시 고정 ==
                    break;

                case "ucInspectPartListPopup":
                    _dtreturn.Columns.Add("VEND_PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("VEND_PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString() });
                    //user Control 생성시 고정 ==
                    break;
                case "ucQCMaterialPartListPopup":
                    _dtreturn.Columns.Add("VEND_PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("VEND_PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString() });
                    //user Control 생성시 고정 ==
                    break;

            }



            Close();
        }

        //UserControl 별 이벤트 데이터
        private void ucCommonCodePopup_Calendar_OnDoubleClick(object sender, EventArgs e)
        {
            CalendarControl Calendar = sender as CalendarControl;
            _dtreturn = new DataTable();

            switch (_pFindControl)
            {

                case "Calendar":
                    _dtreturn.Columns.Add("DATE", typeof(string));

                    //_dtreturn.Rows.Add(new Object[] { Calendar.SelectionRange.Start.ToString("dd MMM yyyy")});
                    _dtreturn.Rows.Add(new Object[] { Calendar.SelectedRanges.Start.ToString("yyyy-MM-dd") });
                    //user Control 생성시 고정 ==
                    break;

            }



            Close();
        }
        private void ucCommonCodePopup_Close_OnClick(object sender, EventArgs e)
        {
            _dtreturn = new DataTable();
            
            switch (_pFindControl)
            {
                case "ProductPlanInfo":
                    _dtreturn.Columns.Add("PRODUCTION_PLAN_ID", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { _pARRAY_CODE[0] });
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

        /*
        private void frmCommonPopup_KeyDown(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            // 여기에 처리코드를 넣는다.
            if (e.Equals(Keys.Escape))
            {
                // 대충 이런 식으로 처리한다.
                Close();
            }
            else
            {
                
            }
        }
        */
    }
}
