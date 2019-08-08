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
using CoFAS_MES.UI.PO.UserControls;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using DevExpress.XtraEditors.Controls;
using CoFAS_MES.UI.PO.Entity;

namespace CoFAS_MES.UI.PO.UserForm
{
    public partial class frmCommonPopup : frmBaseSingle
    {
        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)     
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭 
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private static string _pPROCESS_NAME = string.Empty;   // 공정정보

        private static string _pFTP_ID = string.Empty;          // FTP ID 정보
        private static string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private static string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private static string _pFTP_PW = string.Empty;          //FTP PW 정보

        private static  WorkResultRegister_T01Entity _pWorkResultRegister_T01Entity = null; // 엔티티 생성

        private static Font fntPARENT_FONT = null;
        private static string _strFTP_PATH = string.Empty;
        private static string _strFILE_NAME = string.Empty;
        private static DataTable _pDataTable = null;


        private string _pFindControl = "";

        //private static DataTable _pDATATABLE_VALUE = null;

        private static string _pCRUD = "";


        private static object[] _pARRAY = null;

        private static object[] _pARRAY_CODE = null;

        public static string FTP_ID
        {
            get { return _pFTP_ID; }
            set { _pFTP_ID = value; }
        }
        public static DataTable _DataTable
        {
            get { return _pDataTable; }
            set { _pDataTable = value; }
        }

        
        public static WorkResultRegister_T01Entity WorkResultRegister_T01Entity
        {
            get { return _pWorkResultRegister_T01Entity; }
            set { _pWorkResultRegister_T01Entity = value; }
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

        public static string PROCESS_NAME
        {
            get { return _pPROCESS_NAME; }
            set { _pPROCESS_NAME = value; }
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

                case "WorkOrderInfoPopup_T01":  // 발주 찾기 팝업
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucWorkOrderInfoPopup_T01";

                    ucWorkOrderInfoPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucWorkOrderInfoPopup_T01.USER_CODE = _pUSER_CODE;
                    ucWorkOrderInfoPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkOrderInfoPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucWorkOrderInfoPopup_T01.ARRAY = _pARRAY;
                    ucWorkOrderInfoPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    ucWorkOrderInfoPopup_T01.FTP_ID = _pFTP_ID;
                    ucWorkOrderInfoPopup_T01.FTP_IP_PORT = _pFTP_IP_PORT;
                    ucWorkOrderInfoPopup_T01.FTP_PATH = _pFTP_PATH;
                    ucWorkOrderInfoPopup_T01.FTP_PW = _pFTP_PW;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkOrderInfoPopup_T01();

                  //  ucWorkOrderInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucWorkOrderInfoPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width+150;
                    this.Height = _uc.Height + 75;
                    break;

                case "ProductionOrderInfo_Popup":  // 수주 찾기 팝업
                                                   // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProductionOrderInfoPopup_T04";

                    ucProductionOrderInfoPopup_T04.CORP_CDDE = _pCORP_CODE;
                    ucProductionOrderInfoPopup_T04.USER_CODE = _pUSER_CODE;
                    ucProductionOrderInfoPopup_T04.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductionOrderInfoPopup_T04.FONT_TYPE = fntPARENT_FONT;

                    ucProductionOrderInfoPopup_T04.ARRAY = _pARRAY;
                    ucProductionOrderInfoPopup_T04.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductionOrderInfoPopup_T04();

                    ucProductionOrderInfoPopup_T04._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProductionOrderInfoPopup_T04._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width + 550;
                    this.Height = _uc.Height + 75;
                    break;
                case "ProductionOrderInfo_Popup_T07":  // 수주 찾기 팝업
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProductionOrderInfoPopup_T07";

                    ucProductionOrderInfoPopup_T07.CORP_CDDE = _pCORP_CODE;
                    ucProductionOrderInfoPopup_T07.USER_CODE = _pUSER_CODE;
                    ucProductionOrderInfoPopup_T07.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductionOrderInfoPopup_T07.FONT_TYPE = fntPARENT_FONT;

                    ucProductionOrderInfoPopup_T07.ARRAY = _pARRAY;
                    ucProductionOrderInfoPopup_T07.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductionOrderInfoPopup_T07();

                    ucProductionOrderInfoPopup_T07._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProductionOrderInfoPopup_T07._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width + 300;
                    this.Height = _uc.Height + 75;
                    break;
                case "WorkResult":

                    Child_WindowName = "ucWorkResultPopUp_T01";

                    ucWorkResultPopUp_T01.CORP_CDDE = _pCORP_CODE;
                    ucWorkResultPopUp_T01.USER_CODE = _pUSER_CODE;
                    ucWorkResultPopUp_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkResultPopUp_T01.FONT_TYPE = fntPARENT_FONT;

                    ucWorkResultPopUp_T01.ARRAY = _pARRAY;
                    ucWorkResultPopUp_T01.ARRAY_CODE = _pARRAY_CODE;

                    ucWorkResultPopUp_T01.PROCESS_NAME = _pPROCESS_NAME;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkResultPopUp_T01();
                    ucWorkResultPopUp_T01._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //제조 포장에 따라 다름
                    //PC010001 / PT040001 : 제조
                    //PC010002 / PT040002 : 포장
                    //if ((_pWorkResultRegister_T01Entity.PROCESS_CODE_MST == "PC010002") || _pWorkResultRegister_T01Entity.PROCESS_CODE_MST == "PT040002")
                    //제조
                    if ((_pPROCESS_NAME== "PC010001") ||( _pPROCESS_NAME == "PT040001"))
                    {
                        this.Width = 600;
                        this.Height = 240;
                    }
                    else
                    {
                        this.Width = 700;
                        this.Height = 500;
                    }
                    break;
                case "WorkRequestInfo":  // 작업요청서 찾기 팝업
                                         // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucWorkRequestInfoPopup";

                    ucWorkRequestInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucWorkRequestInfoPopup.USER_CODE = _pUSER_CODE;
                    ucWorkRequestInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkRequestInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucWorkRequestInfoPopup.ARRAY = _pARRAY;
                    ucWorkRequestInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkRequestInfoPopup();

                    ucWorkRequestInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucWorkRequestInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==

                    this.Width = _uc.Width+100;
                    this.Height = _uc.Height + 75;

                    break;
                case "MakeNoMapping":  // 작업요청서에서 제조지시서 매핑 팝업
                                         // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucMakeNoMappingPopup";

                    ucMakeNoMappingPopup.CORP_CDDE = _pCORP_CODE;
                    ucMakeNoMappingPopup.USER_CODE = _pUSER_CODE;
                    ucMakeNoMappingPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMakeNoMappingPopup.FONT_TYPE = fntPARENT_FONT;

                    ucMakeNoMappingPopup.ARRAY = _pARRAY;
                    ucMakeNoMappingPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMakeNoMappingPopup();

                    ucMakeNoMappingPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMakeNoMappingPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==

                    this.Width = _uc.Width + 100;
                    this.Height = _uc.Height + 75;

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

                case "ProductPlanInfo_T01": //생산계획 팝업_T01

                    Child_WindowName = "ucProductPlanInfoPopup_T01";

                    ucProductPlanInfoPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucProductPlanInfoPopup_T01.USER_CODE = _pUSER_CODE;
                    ucProductPlanInfoPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductPlanInfoPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucProductPlanInfoPopup_T01.ARRAY = _pARRAY;
                    ucProductPlanInfoPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductPlanInfoPopup_T01();
                    ucProductPlanInfoPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width + 150;
                    this.Height = _uc.Height + 75;
                    break;

                //생산계획_T01 용 수주찾기팝업_T06             
                case "ContractInfo_Popup_T06":

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
                    ucProductionOrderInfoPopup_T06._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProductionOrderInfoPopup_T06._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width + 150;
                    this.Height = _uc.Height + 75;
                    break;

                case "contract_number_info":
                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucOrderNumberInfoPopup";

                    ucOrderNumberInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucOrderNumberInfoPopup.USER_CODE = _pUSER_CODE;
                    ucOrderNumberInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucOrderNumberInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucOrderNumberInfoPopup.ARRAY = _pARRAY;
                    ucOrderNumberInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    //user Control 생성시 고정 ==
                    _uc = new ucOrderNumberInfoPopup();
                    ucOrderNumberInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucOrderNumberInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                //작업지시등록T03 신규추가팝업
                case "WorkOrderInfo_T02":
                    Child_WindowName = "ucWorkOrderInfoPopup_T02";

                    ucWorkOrderInfoPopup_T02.CORP_CDDE = _pCORP_CODE;
                    ucWorkOrderInfoPopup_T02.USER_CODE = _pUSER_CODE;
                    ucWorkOrderInfoPopup_T02.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkOrderInfoPopup_T02.FONT_TYPE = fntPARENT_FONT;
                    ucWorkOrderInfoPopup_T02.ARRAY = _pARRAY;
                    ucWorkOrderInfoPopup_T02._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucWorkOrderInfoPopup_T02._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucWorkOrderInfoPopup_T02.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkOrderInfoPopup_T02();
                    this.Width = _uc.Width+150;
                    this.Height = _uc.Height + 75;
                    break;


                //작업지시등록T03 신규추가팝업 - 생산계획찾기 팝업
                case "PlanOrderInfo_Popup_T01":
                    Child_WindowName = "ucPlanOrderinfoPopup_T01";

                    ucPlanOrderinfoPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucPlanOrderinfoPopup_T01.USER_CODE = _pUSER_CODE;
                    ucPlanOrderinfoPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucPlanOrderinfoPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucPlanOrderinfoPopup_T01.ARRAY = _pARRAY;
                    ucPlanOrderinfoPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucPlanOrderinfoPopup_T01();
                    ucPlanOrderinfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucPlanOrderinfoPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width + 150;
                    this.Height = _uc.Height + 75;
                    break;

                //작업일보등록T02 신규추가팝업
                case "WorkResult_T02":
                    Child_WindowName = "ucWorkResultPopUp_T02";

                    ucWorkResultPopUp_T02.CORP_CDDE = _pCORP_CODE;
                    ucWorkResultPopUp_T02.USER_CODE = _pUSER_CODE;
                    ucWorkResultPopUp_T02.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkResultPopUp_T02.FONT_TYPE = fntPARENT_FONT;

                    ucWorkResultPopUp_T02.ARRAY = _pARRAY;
                    ucWorkResultPopUp_T02.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkResultPopUp_T02();
                    ucWorkResultPopUp_T02._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = 500;
                    this.Height = 500;
                    break;

                //작업일보등록T03 신규추가팝업
                case "WorkResult_T03":
                    Child_WindowName = "ucWorkResultPopUp_T03";

                    ucWorkResultPopUp_T03.CORP_CDDE = _pCORP_CODE;
                    ucWorkResultPopUp_T03.USER_CODE = _pUSER_CODE;
                    ucWorkResultPopUp_T03.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkResultPopUp_T03.FONT_TYPE = fntPARENT_FONT;

                    ucWorkResultPopUp_T03.ARRAY = _pARRAY;
                    ucWorkResultPopUp_T03.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkResultPopUp_T03();
                    ucWorkResultPopUp_T03._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = 500;
                    this.Height = 500;
                    break;

                //작업지시등록T03 신규추가팝업
                case "WorkOrderInfo_T03":
                    Child_WindowName = "ucWorkOrderInfoPopup_T03";

                    ucWorkOrderInfoPopup_T03.CORP_CDDE = _pCORP_CODE;
                    ucWorkOrderInfoPopup_T03.USER_CODE = _pUSER_CODE;
                    ucWorkOrderInfoPopup_T03.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkOrderInfoPopup_T03.FONT_TYPE = fntPARENT_FONT;
                    ucWorkOrderInfoPopup_T03.ARRAY = _pARRAY;
                    ucWorkOrderInfoPopup_T03._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucWorkOrderInfoPopup_T03._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucWorkOrderInfoPopup_T03.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkOrderInfoPopup_T03();
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                //작업일보등록T02 신규추가팝업
                case "WorkResult_T50":
                    Child_WindowName = "ucWorkResultPopUp_T50";

                    ucWorkResultPopUp_T50.CORP_CDDE = _pCORP_CODE;
                    ucWorkResultPopUp_T50.USER_CODE = _pUSER_CODE;
                    ucWorkResultPopUp_T50.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkResultPopUp_T50.FONT_TYPE = fntPARENT_FONT;

                    ucWorkResultPopUp_T50.ARRAY = _pARRAY;
                    ucWorkResultPopUp_T50.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkResultPopUp_T50();
                    ucWorkResultPopUp_T50._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = 600;
                    this.Height = 500;
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

                case "Calendar_T01":  // 달력 팝업
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
                case "ucContractDocumentListPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucContractDocumentListPopup";

                    ucContractDocumentListPopup.CORP_CDDE = _pCORP_CODE;
                    ucContractDocumentListPopup.USER_CODE = _pUSER_CODE;
                    ucContractDocumentListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucContractDocumentListPopup.FONT_TYPE = fntPARENT_FONT;
                    ucContractDocumentListPopup.FTP_PATH = _pFTP_PATH;
                    ucContractDocumentListPopup.FTP_ID = _pFTP_ID;
                    ucContractDocumentListPopup.FTP_PW = _pFTP_PW;

                    ucContractDocumentListPopup.ARRAY = _pARRAY;
                    ucContractDocumentListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucContractDocumentListPopup();

                    //ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucContractDocumentListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;
                case "ucProductPlanDocumentListPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProductPlanDocumentListPopup";

                    ucProductPlanDocumentListPopup.CORP_CDDE = _pCORP_CODE;
                    ucProductPlanDocumentListPopup.USER_CODE = _pUSER_CODE;
                    ucProductPlanDocumentListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductPlanDocumentListPopup.FONT_TYPE = fntPARENT_FONT;
                    ucProductPlanDocumentListPopup.FTP_PATH = _pFTP_PATH;
                    ucProductPlanDocumentListPopup.FTP_ID = _pFTP_ID;
                    ucProductPlanDocumentListPopup.FTP_PW = _pFTP_PW;

                    ucProductPlanDocumentListPopup.ARRAY = _pARRAY;
                    ucProductPlanDocumentListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductPlanDocumentListPopup();

                    //ucMaterialOrderInfoPopup_Request._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProductPlanDocumentListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
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
                case "ucProductionPartListPopup":
                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProductionPartListPopup_T01";

                    ucProductionPartListPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucProductionPartListPopup_T01.USER_CODE = _pUSER_CODE;
                    ucProductionPartListPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductionPartListPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucProductionPartListPopup_T01.ARRAY = _pARRAY;
                    ucProductionPartListPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductionPartListPopup_T01();
                    
                    ucProductionPartListPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProductionPartListPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;
                case "ucOrderNumberInfoListPopup":
                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucOrderNumberInfoListPopup";

                    ucOrderNumberInfoListPopup.CORP_CDDE = _pCORP_CODE;
                    ucOrderNumberInfoListPopup.USER_CODE = _pUSER_CODE;
                    ucOrderNumberInfoListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucOrderNumberInfoListPopup.FONT_TYPE = fntPARENT_FONT;

                    ucOrderNumberInfoListPopup.ARRAY = _pARRAY;
                    ucOrderNumberInfoListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucOrderNumberInfoListPopup();

                    ucOrderNumberInfoListPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucOrderNumberInfoListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    break;
                case "ucOutsourcingInfoPopup":

                    Child_WindowName = "ucOutsourcingInfoPopup";

                    ucOutsourcingInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucOutsourcingInfoPopup.USER_CODE = _pUSER_CODE;
                    ucOutsourcingInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucOutsourcingInfoPopup.FONT_TYPE = fntPARENT_FONT;
                    

                    ucOutsourcingInfoPopup.ARRAY = _pARRAY;
                    ucOutsourcingInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucOutsourcingInfoPopup(_pDataTable);

                    ucOutsourcingInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucOutsourcingInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
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

                    this.Width = _uc.Width * 6;
                    this.Height = _uc.Height * 2;

                    // 창 크기 최대화 처리
                    this.WindowState = FormWindowState.Maximized;
                    
                    break;
                case "ucShipmentInfoPopup":

                    Child_WindowName = "ucShipmentInfoPopup";

                    ucShipmentInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucShipmentInfoPopup.USER_CODE = _pUSER_CODE;
                    ucShipmentInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucShipmentInfoPopup.FONT_TYPE = fntPARENT_FONT;
                    ucShipmentInfoPopup.FTP_ID = _pFTP_ID;
                    ucShipmentInfoPopup.FTP_PW = _pFTP_PW;

                    ucShipmentInfoPopup.ARRAY = _pARRAY;
                    ucShipmentInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucShipmentInfoPopup(_pDataTable);

                    ucShipmentInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucShipmentInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    break;
                case "ucMaterialUsagePartListPopup":
                    Child_WindowName = "ucMaterialUsagePartListPopup";

                    ucMaterialUsagePartListPopup.CORP_CDDE = _pCORP_CODE;
                    ucMaterialUsagePartListPopup.USER_CODE = _pUSER_CODE;
                    ucMaterialUsagePartListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMaterialUsagePartListPopup.FONT_TYPE = fntPARENT_FONT;

                    ucMaterialUsagePartListPopup.ARRAY = _pARRAY;
                    ucMaterialUsagePartListPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMaterialUsagePartListPopup(_pDataTable);

                    ucMaterialUsagePartListPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMaterialUsagePartListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    break;
                case "ucMeterialUsagePopup":
                    Child_WindowName = "ucMeterialUsagePopup";

                    ucMeterialUsagePopup.CORP_CDDE = _pCORP_CODE;
                    ucMeterialUsagePopup.USER_CODE = _pUSER_CODE;
                    ucMeterialUsagePopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMeterialUsagePopup.FONT_TYPE = fntPARENT_FONT;

                    ucMeterialUsagePopup.ARRAY = _pARRAY;
                    ucMeterialUsagePopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMeterialUsagePopup();

                    //ucMeterialUsagePopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMeterialUsagePopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    break;
                case "WorkOrderInfo":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucWorkOrderInfoPopup";

                    ucWorkOrderInfoPopup_T04.CORP_CDDE = _pCORP_CODE;
                    ucWorkOrderInfoPopup_T04.USER_CODE = _pUSER_CODE;
                    ucWorkOrderInfoPopup_T04.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkOrderInfoPopup_T04.FONT_TYPE = fntPARENT_FONT;
                    ucWorkOrderInfoPopup_T04.ARRAY = _pARRAY;
                    ucWorkOrderInfoPopup_T04._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucWorkOrderInfoPopup_T04._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucWorkOrderInfoPopup_T04.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkOrderInfoPopup_T04();
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "VendCodeInfo_T04":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendCodeInfoPopup_T04";

                    CORE.UserControls.ucVendCodeInfoPopup_T04.CORP_CDDE = _pCORP_CODE;
                    CORE.UserControls.ucVendCodeInfoPopup_T04.USER_CODE = _pUSER_CODE;
                    CORE.UserControls.ucVendCodeInfoPopup_T04.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    CORE.UserControls.ucVendCodeInfoPopup_T04.FONT_TYPE = fntPARENT_FONT;

                    CORE.UserControls.ucVendCodeInfoPopup_T04.ARRAY = _pARRAY;
                    CORE.UserControls.ucVendCodeInfoPopup_T04.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new CORE.UserControls.ucVendCodeInfoPopup_T04();

                    CORE.UserControls.ucVendCodeInfoPopup_T04._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    CORE.UserControls.ucVendCodeInfoPopup_T04._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
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

                case "ProductionOrderInfo_Popup":
                    _dtreturn.Columns.Add("CONTRACT_ID", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("CONTRACT_QTY", typeof(string));
                    _dtreturn.Columns.Add("INOUT_QTY", typeof(string));
                    _dtreturn.Columns.Add("LEAVE_QTY", typeof(string));
                    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    _dtreturn.Columns.Add("UNIT_CODE", typeof(string));
                    _dtreturn.Columns.Add("UNITCOST", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CONTRACT_ID").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("CONTRACT_QTY").ToString(), gv.GetFocusedRowCellValue("INOUT_QTY").ToString(), gv.GetFocusedRowCellValue("LEAVE_QTY").ToString(), gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString(), gv.GetFocusedRowCellValue("UNIT_CODE").ToString(), gv.GetFocusedRowCellValue("UNITCOST").ToString() });
                    break;

                case "ProductionOrderInfo_Popup_T07":
                    _dtreturn.Columns.Add("CONTRACT_ID", typeof(string));
                    _dtreturn.Columns.Add("CONTRACT_NUMBER", typeof(string));
                    _dtreturn.Columns.Add("CONTRACT_NAME", typeof(string));
                    _dtreturn.Columns.Add("PRODUCTION_PLAN_ID", typeof(string));
                    _dtreturn.Columns.Add("PRODUCTION_PLAN_DATE", typeof(string));
                    _dtreturn.Columns.Add("PRODUCTION_PLAN_SEQ", typeof(string));
                    _dtreturn.Columns.Add("ORDER_NUMBER", typeof(string));
                    _dtreturn.Columns.Add("ORDER_NAME", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CONTRACT_ID").ToString(), gv.GetFocusedRowCellValue("CONTRACT_NUMBER").ToString(), gv.GetFocusedRowCellValue("CONTRACT_NAME").ToString(), gv.GetFocusedRowCellValue("PRODUCTION_PLAN_ID").ToString(), gv.GetFocusedRowCellValue("PRODUCTION_PLAN_DATE").ToString(), gv.GetFocusedRowCellValue("PRODUCTION_PLAN_SEQ").ToString(), gv.GetFocusedRowCellValue("ORDER_NUMBER").ToString(), gv.GetFocusedRowCellValue("ORDER_NAME").ToString() });
                    break;

                case "WorkRequestInfo":
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

                //생산계획_T01 용 수주찾기팝업_T06
                case "ContractInfo_Popup_T06":
                    _dtreturn.Columns.Add("CONTRACT_ID", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("CONTRACT_QTY", typeof(string));
                    _dtreturn.Columns.Add("PRODUCTION_PLAN_QTY", typeof(string));
                    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CONTRACT_ID").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("CONTRACT_QTY").ToString(), gv.GetFocusedRowCellValue("PRODUCTION_PLAN_QTY").ToString(), gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString() });
                    break;

                //작업지시등록T03 신규추가팝업 - 생산계획찾기 팝업
                case "PlanOrderInfo_Popup_T01":
                    _dtreturn.Columns.Add("PLAN_ORDER", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PLAN_ORDER_QTY", typeof(string));
                    _dtreturn.Columns.Add("REFERENCE_ID", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("PLAN_ORDER").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PLAN_ORDER_QTY").ToString(), gv.GetFocusedRowCellValue("REFERENCE_ID").ToString() });
                    break;

                case "ucProductionPartListPopup":
                    _dtreturn.Columns.Add("VEND_PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("VEND_PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString() });
                    //user Control 생성시 고정 ==
                    break;
                case "ucOrderNumberInfoListPopup":
                    _dtreturn.Columns.Add("ORDER_NUMBER", typeof(string));
                    _dtreturn.Columns.Add("ORDER_NAME", typeof(string));
                    _dtreturn.Columns.Add("ORDER_REVISION", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("ORDER_NUMBER").ToString(), gv.GetFocusedRowCellValue("ORDER_NAME").ToString(), gv.GetFocusedRowCellValue("ORDER_REVISION").ToString() });
                    break;

                    

                case "MakeNoMapping":
                    _dtreturn.Columns.Add("REFERENCE_ID", typeof(string));
                    _dtreturn.Columns.Add("MAKE_NO", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("REFERENCE_ID").ToString(), gv.GetFocusedRowCellValue("MAKE_NO").ToString() });
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
                case "ucOutsourcingInfoPopup":
                    if(_pDataTable.Rows.Count > 0)
                    {
                        _dtreturn = _pDataTable;
                    }
                    break;
                case "ucShipmentInfoPopup":
                    if (_pDataTable.Rows.Count > 0)
                    {
                        _dtreturn = _pDataTable;
                    }
                    break;
                case "ucMaterialUsagePartListPopup":
                    if(_pDataTable != null)
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

                case "Calendar_T01":
                    _dtreturn.Columns.Add("DATE", typeof(string));

                    //_dtreturn.Rows.Add(new Object[] { Calendar.SelectionRange.Start.ToString("dd MMM yyyy")});
                    _dtreturn.Rows.Add(new Object[] { Calendar.SelectedRanges.Start.ToString("yyyy년 MM월 dd일") });
                    //user Control 생성시 고정 ==
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

        private void frmCommonPopup_FormClosed(object sender, FormClosedEventArgs e)
        {
            //_dtreturn = null;
        }
    }
}

