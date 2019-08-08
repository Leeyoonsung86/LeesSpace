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
using CoFAS_MES.UI.PM.UserControls;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;

namespace CoFAS_MES.UI.PM.UserForm
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

        private static Font fntPARENT_FONT = null;
        private static string _strFTP_PATH = string.Empty;
        private static string _strFILE_NAME = string.Empty;
        private static DataTable _pDataTable = null;

        private string _pFindControl = "";

        //private static DataTable _pDATATABLE_VALUE = null;

        private static string _pCRUD = "";


        private static object[] _pARRAY = null;

        private static object[] _pARRAY_CODE = null;

        public static DataTable _DataTable
        {
            get { return _pDataTable; }
            set { _pDataTable = value; }
        }

        public static string CRUD
        {
            get { return _pCRUD; }
            set { _pCRUD = value; }
        }
        public static string CORP_CDDE
        {
            get { return _pCORP_CODE; }
            set { _pCORP_CODE = value; }
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

                case "ucProductionPartListPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProductionPartListPopup";

                    ucProductionPartListPopup.CORP_CDDE = _pCORP_CODE;
                    ucProductionPartListPopup.USER_CODE = _pUSER_CODE;
                    ucProductionPartListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductionPartListPopup.FONT_TYPE = fntPARENT_FONT;

                    ucProductionPartListPopup.ARRAY = _pARRAY;
                    ucProductionPartListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductionPartListPopup();

                    ucProductionPartListPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProductionPartListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
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

                case "ucVendCostInfoPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendCostInfoListPopup";

                    ucVendCostInfoListPopup.CORP_CDDE = _pCORP_CODE;
                    ucVendCostInfoListPopup.USER_CODE = _pUSER_CODE;
                    ucVendCostInfoListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucVendCostInfoListPopup.FONT_TYPE = fntPARENT_FONT;

                    ucVendCostInfoListPopup.ARRAY = _pARRAY;
                    ucVendCostInfoListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucVendCostInfoListPopup();

                    //ucProductOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucVendCostInfoListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "ucPartDocumentListPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucPartDocumentListPopup";

                    ucPartDocumentListPopup.CORP_CDDE = _pCORP_CODE;
                    ucPartDocumentListPopup.USER_CODE = _pUSER_CODE;
                    ucPartDocumentListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucPartDocumentListPopup.FONT_TYPE = fntPARENT_FONT;
                    ucPartDocumentListPopup.FTP_PATH = _pFTP_PATH;
                    ucPartDocumentListPopup.FTP_ID = _pFTP_ID;
                    ucPartDocumentListPopup.FTP_PW = _pFTP_PW;

                    ucPartDocumentListPopup.ARRAY = _pARRAY;
                    ucPartDocumentListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucPartDocumentListPopup();

                    //ucProductOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucPartDocumentListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "ucPartDocumentListPopup_T01":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucPartDocumentListPopup_T01";

                    ucPartDocumentListPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucPartDocumentListPopup_T01.USER_CODE = _pUSER_CODE;
                    ucPartDocumentListPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucPartDocumentListPopup_T01.FONT_TYPE = fntPARENT_FONT;
                    ucPartDocumentListPopup_T01.FTP_PATH = _pFTP_PATH;
                    ucPartDocumentListPopup_T01.FTP_ID = _pFTP_ID;
                    ucPartDocumentListPopup_T01.FTP_PW = _pFTP_PW;

                    ucPartDocumentListPopup_T01.ARRAY = _pARRAY;
                    ucPartDocumentListPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucPartDocumentListPopup_T01();

                    //ucProductOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucPartDocumentListPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "ProductOrder":  // 발주 찾기 팝업
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProductOrderInfoPopup";

                    ucProductOrderInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucProductOrderInfoPopup.USER_CODE = _pUSER_CODE;
                    ucProductOrderInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductOrderInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucProductOrderInfoPopup.ARRAY = _pARRAY;
                    ucProductOrderInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductOrderInfoPopup();

                    ucProductOrderInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProductOrderInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width + 300;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                //제품출고용 수주찾기팝업
                case "ProductionInfo_Out_Popup":

                    Child_WindowName = "ucProductionOrderInfoPopup_T06";

                    ucProductionOrderInfoPopup_T06.CORP_CDDE = _pCORP_CODE;
                    ucProductionOrderInfoPopup_T06.USER_CODE = _pUSER_CODE;
                    ucProductionOrderInfoPopup_T06.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductionOrderInfoPopup_T06.FONT_TYPE = fntPARENT_FONT;
                                                 
                    ucProductionOrderInfoPopup_T06.ARRAY = _pARRAY;
                    ucProductionOrderInfoPopup_T06.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductionOrderInfoPopup_T06();
                    ucProductionOrderInfoPopup_T06._OnDoubleClick += UcProductionOrderInfoPopup_T06__OnDoubleClick;
                    ucProductionOrderInfoPopup_T06._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width + 420;
                    this.Height = _uc.Height + 75;
                    break;

                //샘플링입력_HPNC
                case "InputSamplingReseult":
                    Child_WindowName = "ucInputSamplingResult";

                    ucInputSamplingResult.CORP_CDDE = _pCORP_CODE;
                    ucInputSamplingResult.USER_CODE = _pUSER_CODE;
                    ucInputSamplingResult.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucInputSamplingResult.FONT_TYPE = fntPARENT_FONT;

                    ucInputSamplingResult.ARRAY = _pARRAY;
                    ucInputSamplingResult.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucInputSamplingResult(_pDataTable);

                    //ucInputSamplingResult._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucInputSamplingResult._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucInputSamplingResult._Request_Click += ucCommonCodePopup_Request_Click;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "ucLabelPrint":
                    Child_WindowName = "ucLabelPrint";

                    ucLabelPrint.CORP_CDDE = _pCORP_CODE;
                    ucLabelPrint.USER_CODE = _pUSER_CODE;
                    ucLabelPrint.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucLabelPrint.FONT_TYPE = fntPARENT_FONT;

                    ucLabelPrint.ARRAY = _pARRAY;
                    ucLabelPrint.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucLabelPrint();

                    //ucInputSamplingResult._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucLabelPrint._Close_Click += ucCommonCodePopup_Close_OnClick;
                  //  ucLabelPrint._Request_Click += ucCommonCodePopup_Request_Click;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width+15;
                    this.Height = _uc.Height+45;
                    break;

                    
                case "ucExcelViewPopup":

                    Child_WindowName = "ucExcelViewPopup";

                    ucExcelViewPopup.CORP_CDDE = _pCORP_CODE;
                    ucExcelViewPopup.USER_CODE = _pUSER_CODE;
                    ucExcelViewPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucExcelViewPopup.FONT_TYPE = fntPARENT_FONT;
                    ucExcelViewPopup.strFTP_PATH = _strFTP_PATH;
                    ucExcelViewPopup.strFILE_NAME = _strFILE_NAME;
                    ucExcelViewPopup.FTP_ID = _pFTP_ID;
                    ucExcelViewPopup.FTP_PW = _pFTP_PW;

                    ucExcelViewPopup.ARRAY = _pARRAY;
                    ucExcelViewPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucExcelViewPopup();

                    ucExcelViewPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucExcelViewPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = Screen.PrimaryScreen.Bounds.Width;
                    this.Height = Screen.PrimaryScreen.Bounds.Height;
                    break;

                    //case "PartCodePopup_T01":

                    //    //user Control 생성시 고정 ==
                    //    Child_WindowName = "ucPartCodePopup_T01";

                    //    ucPartCodePopup_T01.CORP_CDDE = _pCORP_CODE;
                    //    ucPartCodePopup_T01.USER_CODE = _pUSER_CODE;
                    //    ucPartCodePopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    //    ucPartCodePopup_T01.FONT_TYPE = fntPARENT_FONT;

                    //    ucPartCodePopup_T01.ARRAY = _pARRAY;
                    //    ucPartCodePopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //    //언어설정 창 표시 정보
                    //    PageSetting_WINDOW_NAME = Child_WindowName;
                    //    PageSetting_USER_CODE = _pUSER_CODE;
                    //    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    //    PageSetting_FONT = fntPARENT_FONT;                    

                    //    _uc = new ucPartCodePopup_T01();

                    //    ucPartCodePopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    //    ucPartCodePopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //    //user Control 생성시 고정 ==
                    //    this.Width = _uc.Width;
                    //    this.Height = _uc.Height + 75;
                    //    break;
            }

            _uc.CreateControl();
            _pnSINGLE_MAIN.Controls.Add(_uc);
            _uc.Dock = DockStyle.Fill;




        }

        private void UcProductionOrderInfoPopup_T06__OnDoubleClick(object sender, EventArgs e)
        {
            GridView gv = sender as GridView;
            _dtreturn = new DataTable();

            switch (_pFindControl)
            {
                case "ProductionInfo_Out_Popup":
                    _dtreturn.Columns.Add("SHIPMENT_ID", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    _dtreturn.Columns.Add("SHIPMENT_ORDER_QTY", typeof(string));
                    _dtreturn.Columns.Add("PART_UNIT", typeof(string));
                    _dtreturn.Columns.Add("UNITCOST", typeof(string));
                    _dtreturn.Columns.Add("LEAVE_QTY", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("SHIPMENT_ID").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString(), gv.GetFocusedRowCellValue("SHIPMENT_ORDER_QTY").ToString(), gv.GetFocusedRowCellValue("PART_UNIT").ToString(), gv.GetFocusedRowCellValue("UNITCOST").ToString(), gv.GetFocusedRowCellValue("LEAVE_QTY").ToString() });
                    //user Control 생성시 고정 ==
                    break;
            }

            Close();
        }
        private void ucCommonCodePopup_Request_Click(object sender, EventArgs e)
        {
            GridView gv = sender as GridView;
            _dtreturn = new DataTable();

            switch (_pFindControl)
            {
                case "ProductPlanInfo":
                    Close();
                    break;
                //에이치피앤씨_샘플링수량
                case "InputSamplingReseult":
                    if (gv != null)
                    {
                        DataTable tDataTable = gv.GridControl.DataSource as DataTable;
                        DataTable data = new DataTable();
                        DataTable empty_qty = new DataTable();
                        data = tDataTable;
                        //  
                        //
                        //  //tDataTable.Select("INPUT ='124'", "").CopyToDataTable();
                        //
                        // // empty_qty = CoFAS_ConvertManager.DataTable_FindValue(tDataTable, "INPUT =''", "");
                        //  if(CoFAS_ConvertManager.DataTable_FindCount(tDataTable, "INPUT=''","")|| CoFAS_ConvertManager.DataTable_FindCount(tDataTable, "INPUT<'0'", "") || CoFAS_ConvertManager.DataTable_FindCount(tDataTable, "INPUT='0'", ""))
                        //  {
                        //      empty_qty = CoFAS_ConvertManager.DataTable_FindValue(tDataTable, "INPUT =''", "");
                        //      CoFAS_DevExpressManager.ShowInformationMessage("검체채취량을 입력하지 않은 것이 " + empty_qty.Rows.Count.ToString() + "건 있습니다.");
                        //      break;
                        //  }
                        //  if (CoFAS_ConvertManager.DataTable_FindCount(tDataTable, "INPUT>'0'", ""))
                        //      data = CoFAS_ConvertManager.DataTable_FindValue(tDataTable, "INPUT >'0'", "");
                        //
                        _dtreturn = data;
                        Close();
                    }
                    else
                        _dtreturn = null;
                    Close();
                    break;
            }


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
                    _dtreturn.Columns.Add("CONTRACT_NAME", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CONTRACT_ID").ToString(), gv.GetFocusedRowCellValue("CONTRACT_NUMBER").ToString(), gv.GetFocusedRowCellValue("CONTRACT_NAME").ToString() });
                    //user Control 생성시 고정 ==
                    break;

                //case "ucMaterialPartListPopup":
                //    _dtreturn.Columns.Add("VEND_PART_CODE", typeof(string));
                //    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                //    _dtreturn.Columns.Add("PART_CODE", typeof(string));

                //    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("VEND_PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString() });
                //    //user Control 생성시 고정 ==
                //    break;
                case "ucProductionPartListPopup":
                    _dtreturn.Columns.Add("VEND_PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("VEND_PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString() });
                    //user Control 생성시 고정 ==
                    break;
                case "ProductOrder":
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

                //case "PartCodePopup_T01":
                //    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                //    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                //    _dtreturn.Columns.Add("PART_COST", typeof(string));
                //    _dtreturn.Columns.Add("PART_UNITCOST_CURRENCY_CODE", typeof(string));

                //    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_COST").ToString(), gv.GetFocusedRowCellValue("PART_UNITCOST_CURRENCY_CODE").ToString() });

                //    break;

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


    }
}
