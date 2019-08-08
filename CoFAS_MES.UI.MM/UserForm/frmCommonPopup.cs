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
using CoFAS_MES.UI.MM.UserControls;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using DevExpress.XtraEditors.Controls;
using CoFAS_MES.UI.MM.Entity;

namespace CoFAS_MES.UI.MM.UserForm
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
        public static DataTable _DataTable
        {
            get { return _pDataTable; }
            set { _pDataTable = value; }
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
                case "ucMaterialVendCostInfoListPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucMaterialVendCostInfoListPopup";

                    ucMaterialVendCostInfoListPopup.CORP_CDDE = _pCORP_CODE;
                    ucMaterialVendCostInfoListPopup.USER_CODE = _pUSER_CODE;
                    ucMaterialVendCostInfoListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMaterialVendCostInfoListPopup.FONT_TYPE = fntPARENT_FONT;

                    ucMaterialVendCostInfoListPopup.ARRAY = _pARRAY;
                    ucMaterialVendCostInfoListPopup.ARRAY_CODE = _pARRAY_CODE;
                    
                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMaterialVendCostInfoListPopup();

                    //ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMaterialVendCostInfoListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "ucMaterialContractInfoPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucMaterialContractinfoPopup";

                    ucMaterialContractinfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucMaterialContractinfoPopup.USER_CODE = _pUSER_CODE;
                    ucMaterialContractinfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMaterialContractinfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucMaterialContractinfoPopup.ARRAY = _pARRAY;
                    ucMaterialContractinfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMaterialContractinfoPopup();

                    ucMaterialContractinfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMaterialContractinfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "ucMaterialPartListPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucMaterialPartListPopup";

                    ucMaterialPartListPopup.CORP_CDDE = _pCORP_CODE;
                    ucMaterialPartListPopup.USER_CODE = _pUSER_CODE;
                    ucMaterialPartListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMaterialPartListPopup.FONT_TYPE = fntPARENT_FONT;

                    ucMaterialPartListPopup.ARRAY = _pARRAY;
                    ucMaterialPartListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMaterialPartListPopup();

                    ucMaterialPartListPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMaterialPartListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "ucMaterialPartListPopup_T01":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucMaterialPartListPopup_T01";

                    ucMaterialPartListPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucMaterialPartListPopup_T01.USER_CODE = _pUSER_CODE;
                    ucMaterialPartListPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMaterialPartListPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucMaterialPartListPopup_T01.ARRAY = _pARRAY;
                    ucMaterialPartListPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMaterialPartListPopup_T01(_pDataTable);

                    ucMaterialPartListPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMaterialPartListPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;

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

                    //ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucPartDocumentListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "ucMaterialPartDocumentListPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucMaterialPartDocumentListPopup";

                    ucMaterialPartDocumentListPopup.CORP_CDDE = _pCORP_CODE;
                    ucMaterialPartDocumentListPopup.USER_CODE = _pUSER_CODE;
                    ucMaterialPartDocumentListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMaterialPartDocumentListPopup.FONT_TYPE = fntPARENT_FONT;
                    ucMaterialPartDocumentListPopup.FTP_PATH = _pFTP_PATH;
                    ucMaterialPartDocumentListPopup.FTP_ID = _pFTP_ID;
                    ucMaterialPartDocumentListPopup.FTP_PW = _pFTP_PW;

                    ucMaterialPartDocumentListPopup.ARRAY = _pARRAY;
                    ucMaterialPartDocumentListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMaterialPartDocumentListPopup();

                    //ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMaterialPartDocumentListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "MaterialOrder_Request":  // 발주 찾기 팝업
                                               // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucMaterialOrderInfoPopup_Request";

                    ucMaterialOrderInfoPopup_Request.CORP_CDDE = _pCORP_CODE;
                    ucMaterialOrderInfoPopup_Request.USER_CODE = _pUSER_CODE;
                    ucMaterialOrderInfoPopup_Request.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMaterialOrderInfoPopup_Request.FONT_TYPE = fntPARENT_FONT;

                    ucMaterialOrderInfoPopup_Request.ARRAY = _pARRAY;
                    ucMaterialOrderInfoPopup_Request.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMaterialOrderInfoPopup_Request();

                    ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMaterialOrderInfoPopup_Request._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "Material_Stock":  // 발주 찾기 팝업
                                        // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucMaterialStockInfoPopup";

                    ucMaterialStockInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucMaterialStockInfoPopup.USER_CODE = _pUSER_CODE;
                    ucMaterialStockInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMaterialStockInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucMaterialStockInfoPopup.ARRAY = _pARRAY;
                    ucMaterialStockInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMaterialStockInfoPopup();

                    ucMaterialStockInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMaterialStockInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    break;
                case "Material_Stock_T01":

                    Child_WindowName = "ucMaterialStockInfoPopup_T01";

                    ucMaterialStockInfoPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucMaterialStockInfoPopup_T01.USER_CODE = _pUSER_CODE;
                    ucMaterialStockInfoPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMaterialStockInfoPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucMaterialStockInfoPopup_T01.ARRAY = _pARRAY;
                    ucMaterialStockInfoPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMaterialStockInfoPopup_T01();

                    ucMaterialStockInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMaterialStockInfoPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    break;
                case "BOM_SpendQtyCalc":  // 발주 찾기 팝업
                                          // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucBOM_SpendQtyCalcPop";

                    ucBOM_SpendQtyCalcPop.CORP_CDDE = _pCORP_CODE;
                    ucBOM_SpendQtyCalcPop.USER_CODE = _pUSER_CODE;
                    ucBOM_SpendQtyCalcPop.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucBOM_SpendQtyCalcPop.FONT_TYPE = fntPARENT_FONT;

                    ucBOM_SpendQtyCalcPop.ARRAY = _pARRAY;
                    ucBOM_SpendQtyCalcPop.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucBOM_SpendQtyCalcPop();

                    //ucBOM_SpendQtyCalcPop._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucBOM_SpendQtyCalcPop._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width + 450;
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

                case "ucPartDocumentListPopup_T02":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucPartDocumentListPopup_T02";

                    ucPartDocumentListPopup_T02.CORP_CDDE = _pCORP_CODE;
                    ucPartDocumentListPopup_T02.USER_CODE = _pUSER_CODE;
                    ucPartDocumentListPopup_T02.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucPartDocumentListPopup_T02.FONT_TYPE = fntPARENT_FONT;
                    ucPartDocumentListPopup_T02.FTP_PATH = _pFTP_PATH;
                    ucPartDocumentListPopup_T02.FTP_ID = _pFTP_ID;
                    ucPartDocumentListPopup_T02.FTP_PW = _pFTP_PW;

                    ucPartDocumentListPopup_T02.ARRAY = _pARRAY;
                    ucPartDocumentListPopup_T02.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucPartDocumentListPopup_T02();

                    //ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucPartDocumentListPopup_T02._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;
                //MaterialCollectAndPay_Detail
                case "MaterialCollectAndPay_Detail":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "MaterialCollectAndPay_Detail";

                    MaterialCollectAndPay_Detail.CORP_CDDE = _pCORP_CODE;
                    MaterialCollectAndPay_Detail.USER_CODE = _pUSER_CODE;
                    MaterialCollectAndPay_Detail.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    MaterialCollectAndPay_Detail.FONT_TYPE = fntPARENT_FONT;
                    MaterialCollectAndPay_Detail.ARRAY = _pARRAY;
                    MaterialCollectAndPay_Detail.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new MaterialCollectAndPay_Detail();

                    ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    MaterialCollectAndPay_Detail._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width +400;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
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
                case "ucOrderExcelView":

                    Child_WindowName = "ucOrderExcelView";

                    ucOrderExcelView.CORP_CDDE = _pCORP_CODE;
                    ucOrderExcelView.USER_CODE = _pUSER_CODE;
                    ucOrderExcelView.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucOrderExcelView.FONT_TYPE = fntPARENT_FONT;
                    ucOrderExcelView.strFTP_PATH = _strFTP_PATH;
                    ucOrderExcelView.strFILE_NAME = _strFILE_NAME;
                    ucOrderExcelView.FTP_ID = _pFTP_ID;
                    ucOrderExcelView.FTP_PW = _pFTP_PW;

                    ucOrderExcelView.ARRAY = _pARRAY;
                    ucOrderExcelView.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucOrderExcelView();

                    ucOrderExcelView._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucOrderExcelView._Close_Click += ucCommonCodePopup_Close_OnClick;

                    /*this.Width = Screen.PrimaryScreen.Bounds.Width;
                    this.Height = Screen.PrimaryScreen.Bounds.Height;*/
                    this.Width = 1000;
                    this.Height = 1000;

                    break;
                case "ucMaterialOrderRegister_Request_T01":
                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucMaterialOrderRegister_Request_T01";

                    ucMaterialOrderRegister_Request_T01.CORP_CDDE = _pCORP_CODE;
                    ucMaterialOrderRegister_Request_T01.USER_CODE = _pUSER_CODE;
                    ucMaterialOrderRegister_Request_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMaterialOrderRegister_Request_T01.FONT_TYPE = fntPARENT_FONT;

                    ucMaterialOrderRegister_Request_T01.ARRAY = _pARRAY;
                    ucMaterialOrderRegister_Request_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMaterialOrderRegister_Request_T01(_pDataTable);

                    ucMaterialOrderRegister_Request_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMaterialOrderRegister_Request_T01._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    
                    break;

                    /*
                    case "ucMaterialOutPrintPopup":

                        //user Control 생성시 고정 ==

                        MaterialOutRegister_T01_Print.CORP_CDDE = _pCORP_CODE;
                        MaterialOutRegister_T01_Print.USER_CODE = _pUSER_CODE;
                        MaterialOutRegister_T01_Print.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                        MaterialOutRegister_T01_Print.FONT_TYPE = fntPARENT_FONT;
                        MaterialOutRegister_T01_Print.FTP_PATH = _pFTP_PATH;
                        MaterialOutRegister_T01_Print.FTP_ID = _pFTP_ID;
                        MaterialOutRegister_T01_Print.FTP_PW = _pFTP_PW;

                        MaterialOutRegister_T01_Print.ARRAY = _pARRAY;
                        MaterialOutRegister_T01_Print.ARRAY_CODE = _pARRAY_CODE;

                        MaterialOutRegister_T01_Print _uc2 = new MaterialOutRegister_T01_Print();


                        ucMaterialOutPrintPopup.CORP_CDDE = _pCORP_CODE;
                        ucMaterialOutPrintPopup.USER_CODE = _pUSER_CODE;
                        ucMaterialOutPrintPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                        ucMaterialOutPrintPopup.FONT_TYPE = fntPARENT_FONT;
                        ucMaterialOutPrintPopup.FTP_PATH = _pFTP_PATH;
                        ucMaterialOutPrintPopup.FTP_ID = _pFTP_ID;
                        ucMaterialOutPrintPopup.FTP_PW = _pFTP_PW;

                        ucMaterialOutPrintPopup.ARRAY = _pARRAY;
                        ucMaterialOutPrintPopup.ARRAY_CODE = _pARRAY_CODE;

                        //언어설정 창 표시 정보
                        PageSetting_WINDOW_NAME = Child_WindowName;
                        PageSetting_USER_CODE = _pUSER_CODE;
                        PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                        PageSetting_FONT = fntPARENT_FONT;
                        //

                        _uc = new ucMaterialOutPrintPopup();
                        //ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                        // ucMaterialOutPrintPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                        this.Width = _uc.Width + 200;
                        this.Height = _uc.Height + 75;
                        //user Control 생성시 고정 ==
                        break;
                        */

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

                case "MaterialOrder_Request":
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
                case "Material_Stock_T01":

                    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    _dtreturn.Columns.Add("VEND_NAME", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString() });
                    break;
                case "ucMaterialContractInfoPopup":
                    _dtreturn.Columns.Add("CONTRACT_ID", typeof(string));
                    _dtreturn.Columns.Add("CONTRACT_NUMBER", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CONTRACT_ID").ToString(), gv.GetFocusedRowCellValue("CONTRACT_NUMBER").ToString() });
                    //user Control 생성시 고정 ==
                    break;

                case "ucMaterialPartListPopup":
                    _dtreturn.Columns.Add("VEND_PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("VEND_PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString() });
                    //user Control 생성시 고정 ==
                    break;

                case "ucMaterialOrderRegister_Request_T01":
                    _dtreturn.Columns.Add("ORDER_ID", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("ORDER_ID").ToString()});
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
                case "InputSamplingReseult":

                    _dtreturn = null;
                    break;
                case "ucMaterialPartListPopup_T01":
                    if (_pDataTable != null)
                    {
                        if (_pDataTable.Rows.Count > 0)
                        {
                            _dtreturn = _pDataTable;
                            //_pDataTable = null;
                        }

                    }
                    break;
                case "ucMaterialOrderRegister_Request_T01":
                    if (_pDataTable != null)
                    {
                        if (_pDataTable.Rows.Count > 0)
                        {
                            _dtreturn = _pDataTable;
                            //_pDataTable = null;
                        }

                    }
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
