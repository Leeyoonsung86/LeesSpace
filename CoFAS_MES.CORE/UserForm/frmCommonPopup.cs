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
using CoFAS_MES.CORE.UserControls;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;

namespace CoFAS_MES.CORE.UserForm
{
    public partial class frmCommonPopup : frmBaseSingle
    {
        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)     
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭 
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private static Font fntPARENT_FONT = null;

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
                case "CommonCode":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucCommonCodePopup";

                    ucCommonCodePopup.CRUD = _pCRUD;
                    ucCommonCodePopup.CORP_CDDE = _pCORP_CODE; 
                    ucCommonCodePopup.USER_CODE = _pUSER_CODE;
                    ucCommonCodePopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucCommonCodePopup.FONT_TYPE = fntPARENT_FONT;

                    ucCommonCodePopup.ARRAY = _pARRAY;

                    ucCommonCodePopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucCommonCodePopup();

                    ucCommonCodePopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucCommonCodePopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "CommonCode_Equipment":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucCommonCodePopup_Equipment";

                    ucCommonCodePopup_Equipment.CRUD = _pCRUD;
                    ucCommonCodePopup_Equipment.CORP_CDDE = _pCORP_CODE;
                    ucCommonCodePopup_Equipment.USER_CODE = _pUSER_CODE;
                    ucCommonCodePopup_Equipment.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucCommonCodePopup_Equipment.FONT_TYPE = fntPARENT_FONT;

                    ucCommonCodePopup_Equipment.ARRAY = _pARRAY;

                    ucCommonCodePopup_Equipment.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucCommonCodePopup_Equipment();

                    ucCommonCodePopup_Equipment._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucCommonCodePopup_Equipment._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "CommonCode_BadCod":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucCommonCodePopup_BadCode";

                    ucCommonCodePopup_BadCode.CRUD = _pCRUD;
                    ucCommonCodePopup_BadCode.CORP_CDDE = _pCORP_CODE;
                    ucCommonCodePopup_BadCode.USER_CODE = _pUSER_CODE;
                    ucCommonCodePopup_BadCode.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucCommonCodePopup_BadCode.FONT_TYPE = fntPARENT_FONT;

                    ucCommonCodePopup_BadCode.ARRAY = _pARRAY;

                    ucCommonCodePopup_BadCode.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucCommonCodePopup_BadCode();

                    ucCommonCodePopup_BadCode._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucCommonCodePopup_BadCode._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "CommonCode_ProcessGroup":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucCommonCodePopup_ProcessGroup";

                    ucCommonCodePopup_ProcessGroup.CRUD = _pCRUD;
                    ucCommonCodePopup_ProcessGroup.CORP_CDDE = _pCORP_CODE;
                    ucCommonCodePopup_ProcessGroup.USER_CODE = _pUSER_CODE;
                    ucCommonCodePopup_ProcessGroup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucCommonCodePopup_ProcessGroup.FONT_TYPE = fntPARENT_FONT;

                    ucCommonCodePopup_ProcessGroup.ARRAY = _pARRAY;

                    ucCommonCodePopup_ProcessGroup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucCommonCodePopup_ProcessGroup();

                    ucCommonCodePopup_ProcessGroup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucCommonCodePopup_ProcessGroup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "CommonCode_StopCode":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucCommonCodePopup_StopCode";

                    ucCommonCodePopup_StopCode.CRUD = _pCRUD;
                    ucCommonCodePopup_StopCode.CORP_CDDE = _pCORP_CODE;
                    ucCommonCodePopup_StopCode.USER_CODE = _pUSER_CODE;
                    ucCommonCodePopup_StopCode.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucCommonCodePopup_StopCode.FONT_TYPE = fntPARENT_FONT;

                    ucCommonCodePopup_StopCode.ARRAY = _pARRAY;

                    ucCommonCodePopup_StopCode.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucCommonCodePopup_StopCode();

                    ucCommonCodePopup_StopCode._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucCommonCodePopup_StopCode._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "CommonCode_Terminal":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucCommonCodePopup_Terminal";

                    ucCommonCodePopup_Terminal.CRUD = _pCRUD;
                    ucCommonCodePopup_Terminal.CORP_CDDE = _pCORP_CODE;
                    ucCommonCodePopup_Terminal.USER_CODE = _pUSER_CODE;
                    ucCommonCodePopup_Terminal.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucCommonCodePopup_Terminal.FONT_TYPE = fntPARENT_FONT;

                    ucCommonCodePopup_Terminal.ARRAY = _pARRAY;

                    ucCommonCodePopup_Terminal.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucCommonCodePopup_Terminal();

                    ucCommonCodePopup_Terminal._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucCommonCodePopup_Terminal._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "CommonCode_Tool":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucCommonCodePopup_Tool";

                    ucCommonCodePopup_Tool.CRUD = _pCRUD;
                    ucCommonCodePopup_Tool.CORP_CDDE = _pCORP_CODE;
                    ucCommonCodePopup_Tool.USER_CODE = _pUSER_CODE;
                    ucCommonCodePopup_Tool.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucCommonCodePopup_Tool.FONT_TYPE = fntPARENT_FONT;

                    ucCommonCodePopup_Tool.ARRAY = _pARRAY;

                    ucCommonCodePopup_Tool.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucCommonCodePopup_Tool();

                    ucCommonCodePopup_Tool._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucCommonCodePopup_Tool._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "InputEquipmentIspectInfo":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucInputEquipmentIspectInfoPopup";

                    ucEquipmentInspectInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucEquipmentInspectInfoPopup.USER_CODE = _pUSER_CODE;
                    ucEquipmentInspectInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucEquipmentInspectInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucEquipmentInspectInfoPopup.ARRAY = _pARRAY;
                    ucEquipmentInspectInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;

                    _uc = new ucEquipmentInspectInfoPopup();

                    ucEquipmentInspectInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucEquipmentInspectInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width + 300;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "ContractInfo":
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProductionOrderInfoPopup_T01";

                    ucProductionOrderInfoPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucProductionOrderInfoPopup_T01.USER_CODE = _pUSER_CODE;
                    ucProductionOrderInfoPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductionOrderInfoPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucProductionOrderInfoPopup_T01.ARRAY = _pARRAY;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductionOrderInfoPopup_T01();

                    ucProductionOrderInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProductionOrderInfoPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

               case "VendInfo":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendCodePopup";

                    ucVendCodePopup.CRUD = _pCRUD;
                    ucVendCodePopup.CORP_CDDE = _pCORP_CODE;
                    ucVendCodePopup.USER_CODE = _pUSER_CODE;
                    ucVendCodePopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucVendCodePopup.FONT_TYPE = fntPARENT_FONT;

                    ucVendCodePopup.ARRAY = _pARRAY;

                    ucVendCodePopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucVendCodePopup();

                    ucVendCodePopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucVendCodePopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "ProductionOrderInfo":
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    //Child_WindowName = "ucProductionOrderInfoPopup";
                    //ucProductionOrderInfoPopup.CORP_CDDE = _pCORP_CODE;
                    //ucProductionOrderInfoPopup.USER_CODE = _pUSER_CODE;
                    //ucProductionOrderInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    //ucProductionOrderInfoPopup.FONT_TYPE = fntPARENT_FONT;
                    //
                    //ucProductionOrderInfoPopup.ARRAY = _pARRAY;
                    //
                    ////언어설정 창 표시 정보
                    //PageSetting_WINDOW_NAME = Child_WindowName;
                    //PageSetting_USER_CODE = _pUSER_CODE;
                    //PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    //PageSetting_FONT = fntPARENT_FONT;
                    ////
                    //_uc = new ucProductionOrderInfoPopup();
                    //
                    //ucProductionOrderInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    //ucProductionOrderInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;
                case "PartCodeInfo":
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendCodeInfoPopup_T01";

                    ucVendCodeInfoPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucVendCodeInfoPopup_T01.USER_CODE = _pUSER_CODE;
                    ucVendCodeInfoPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucVendCodeInfoPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucVendCodeInfoPopup_T01.ARRAY = _pARRAY;
                    ucVendCodeInfoPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucVendCodeInfoPopup_T01();

                    ucVendCodeInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucVendCodeInfoPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width+200;
                    this.Height = _uc.Height + 75;
                    break;
                case "PartCodeInfo2":
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendCodeInfoPopup_T01";

                    ucVendCodeInfoPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucVendCodeInfoPopup_T01.USER_CODE = _pUSER_CODE;
                    ucVendCodeInfoPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucVendCodeInfoPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucVendCodeInfoPopup_T01.ARRAY = _pARRAY;
                    ucVendCodeInfoPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucVendCodeInfoPopup_T01();

                    ucVendCodeInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucVendCodeInfoPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    break;
                case "VendCostInfo":
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendCostInfoPopup";

                    ucVendCostInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucVendCostInfoPopup.USER_CODE = _pUSER_CODE;
                    ucVendCostInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucVendCostInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucVendCostInfoPopup.ARRAY = _pARRAY;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucVendCostInfoPopup();

                    ucVendCostInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucVendCostInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;
                // 케이스별 userControl 추가

                case "VendCodeInfo":
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendCodeInfoPopup";
                    //중복오류 나는 위치
                    ucVendCodeInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucVendCodeInfoPopup.USER_CODE = _pUSER_CODE;
                    ucVendCodeInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucVendCodeInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucVendCodeInfoPopup.ARRAY = _pARRAY;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucVendCodeInfoPopup();

                    ucVendCodeInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucVendCodeInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;
                // 케이스별 userControl 추가

                case "MaterialOrder":  // 발주 찾기 팝업
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucMaterialOrderInfoPopup";

                    ucMaterialOrderInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucMaterialOrderInfoPopup.USER_CODE = _pUSER_CODE;
                    ucMaterialOrderInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMaterialOrderInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucMaterialOrderInfoPopup.ARRAY = _pARRAY;
                    ucMaterialOrderInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMaterialOrderInfoPopup();

                    ucMaterialOrderInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMaterialOrderInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width+300;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;
                case "ProductPlanInfo":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProductPlanInfoPopup";
                    
                    ucProductPlanInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucProductPlanInfoPopup.USER_CODE = _pUSER_CODE;
                    ucProductPlanInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductPlanInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucProductPlanInfoPopup.ARRAY = _pARRAY;
                    ucProductPlanInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductPlanInfoPopup();
                    ucProductPlanInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width+50;
                    this.Height = _uc.Height + 75;
                    break;

                case "ProductPlanInfo_T50":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProductPlanInfoPopup_T50";

                    ucProductPlanInfoPopup_T50.CORP_CDDE = _pCORP_CODE;
                    ucProductPlanInfoPopup_T50.USER_CODE = _pUSER_CODE;
                    ucProductPlanInfoPopup_T50.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductPlanInfoPopup_T50.FONT_TYPE = fntPARENT_FONT;

                    ucProductPlanInfoPopup_T50.ARRAY = _pARRAY;
                    ucProductPlanInfoPopup_T50.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductPlanInfoPopup_T50();
                    ucProductPlanInfoPopup_T50._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width + 50;
                    this.Height = _uc.Height + 75;
                    break;

                //생산계획용 수주찾기팝업             
                case "ContractInfo_Popup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProductionOrderInfoPopup_T02";

                    ucProductionOrderInfoPopup_T02.CORP_CDDE = _pCORP_CODE;
                    ucProductionOrderInfoPopup_T02.USER_CODE = _pUSER_CODE;
                    ucProductionOrderInfoPopup_T02.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductionOrderInfoPopup_T02.FONT_TYPE = fntPARENT_FONT;

                    ucProductionOrderInfoPopup_T02.ARRAY = _pARRAY;
                    ucProductionOrderInfoPopup_T02.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductionOrderInfoPopup_T02();
                    ucProductionOrderInfoPopup_T02._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProductionOrderInfoPopup_T02._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                //제품출고용 수주찾기팝업
                case "ContractInfo_Out_Popup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucProductionOrderInfoPopup_T03";

                    ucProductionOrderInfoPopup_T03.CORP_CDDE = _pCORP_CODE;
                    ucProductionOrderInfoPopup_T03.USER_CODE = _pUSER_CODE;
                    ucProductionOrderInfoPopup_T03.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductionOrderInfoPopup_T03.FONT_TYPE = fntPARENT_FONT;

                    ucProductionOrderInfoPopup_T03.ARRAY = _pARRAY;
                    ucProductionOrderInfoPopup_T03.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductionOrderInfoPopup_T03();
                    ucProductionOrderInfoPopup_T03._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucProductionOrderInfoPopup_T03._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width+300;
                    this.Height = _uc.Height + 75;
                    break;
                case "WorkOrderInfo":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucWorkOrderInfoPopup";

                    ucWorkOrderInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucWorkOrderInfoPopup.USER_CODE = _pUSER_CODE;
                    ucWorkOrderInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkOrderInfoPopup.FONT_TYPE = fntPARENT_FONT;
                    ucWorkOrderInfoPopup.ARRAY = _pARRAY;
                    ucWorkOrderInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucWorkOrderInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucWorkOrderInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkOrderInfoPopup();
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "WorkOrderInfo_T50":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucWorkOrderInfoPopup_T50";

                    ucWorkOrderInfoPopup_T50.CORP_CDDE = _pCORP_CODE;
                    ucWorkOrderInfoPopup_T50.USER_CODE = _pUSER_CODE;
                    ucWorkOrderInfoPopup_T50.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkOrderInfoPopup_T50.FONT_TYPE = fntPARENT_FONT;
                    ucWorkOrderInfoPopup_T50.ARRAY = _pARRAY;
                    ucWorkOrderInfoPopup_T50._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucWorkOrderInfoPopup_T50._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucWorkOrderInfoPopup_T50.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkOrderInfoPopup_T50();
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;
                case "PlanOrderInfo_Popup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucPlanOrderinfoPopup";

                    ucPlanOrderinfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucPlanOrderinfoPopup.USER_CODE = _pUSER_CODE;
                    ucPlanOrderinfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucPlanOrderinfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucPlanOrderinfoPopup.ARRAY = _pARRAY;
                    ucPlanOrderinfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucPlanOrderinfoPopup();
                    ucPlanOrderinfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucPlanOrderinfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;
                case "PlanOrderInfo_Popup_T50":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucPlanOrderinfoPopup_T50";

                    ucPlanOrderinfoPopup_T50.CORP_CDDE = _pCORP_CODE;
                    ucPlanOrderinfoPopup_T50.USER_CODE = _pUSER_CODE;
                    ucPlanOrderinfoPopup_T50.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucPlanOrderinfoPopup_T50.FONT_TYPE = fntPARENT_FONT;

                    ucPlanOrderinfoPopup_T50.ARRAY = _pARRAY;
                    ucPlanOrderinfoPopup_T50.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucPlanOrderinfoPopup_T50();
                    ucPlanOrderinfoPopup_T50._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucPlanOrderinfoPopup_T50._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;
                case "WorkResult":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucWorkResultPopUp";

                    ucWorkResultPopUp.CORP_CDDE = _pCORP_CODE;
                    ucWorkResultPopUp.USER_CODE = _pUSER_CODE;
                    ucWorkResultPopUp.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucWorkResultPopUp.FONT_TYPE = fntPARENT_FONT;

                    ucWorkResultPopUp.ARRAY = _pARRAY;
                    ucWorkResultPopUp.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucWorkResultPopUp();
                    ucWorkResultPopUp._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = 600;
                    this.Height = 500;
                    break;

                case "NoticeDetail":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucNoticeDetailPopup";

                    ucNoticeDetailPopup.CORP_CDDE = _pCORP_CODE;
                    ucNoticeDetailPopup.USER_CODE = _pUSER_CODE;
                    ucNoticeDetailPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucNoticeDetailPopup.FONT_TYPE = fntPARENT_FONT;

                    ucNoticeDetailPopup.ARRAY = _pARRAY;
                    ucNoticeDetailPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucNoticeDetailPopup();
                    ucNoticeDetailPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = 800;
                    this.Height = 700;
                    break;
                case "VendCodeInfo_T02":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendCodeInfoPopup_T02";

                    ucVendCodeInfoPopup_T02.CORP_CDDE = _pCORP_CODE;
                    ucVendCodeInfoPopup_T02.USER_CODE = _pUSER_CODE;
                    ucVendCodeInfoPopup_T02.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucVendCodeInfoPopup_T02.FONT_TYPE = fntPARENT_FONT;

                    ucVendCodeInfoPopup_T02.ARRAY = _pARRAY;
                    ucVendCodeInfoPopup_T02.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucVendCodeInfoPopup_T02();

                    ucVendCodeInfoPopup_T02._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucVendCodeInfoPopup_T02._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "VendCodeInfo_T04":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendCodeInfoPopup_T04";

                    ucVendCodeInfoPopup_T04.CORP_CDDE = _pCORP_CODE;
                    ucVendCodeInfoPopup_T04.USER_CODE = _pUSER_CODE;
                    ucVendCodeInfoPopup_T04.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucVendCodeInfoPopup_T04.FONT_TYPE = fntPARENT_FONT;

                    ucVendCodeInfoPopup_T04.ARRAY = _pARRAY;
                    ucVendCodeInfoPopup_T04.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucVendCodeInfoPopup_T04();

                    ucVendCodeInfoPopup_T04._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucVendCodeInfoPopup_T04._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;
                    
                 case "VendCodeInfo_T04_biocerra":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendCodeInfoPopup_T04";

                    ucVendCodeInfoPopup_T04.CORP_CDDE = _pCORP_CODE;
                    ucVendCodeInfoPopup_T04.USER_CODE = _pUSER_CODE;
                    ucVendCodeInfoPopup_T04.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucVendCodeInfoPopup_T04.FONT_TYPE = fntPARENT_FONT;

                    ucVendCodeInfoPopup_T04.ARRAY = _pARRAY;
                    ucVendCodeInfoPopup_T04.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucVendCodeInfoPopup_T04();

                    ucVendCodeInfoPopup_T04._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucVendCodeInfoPopup_T04._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width+170;
                    this.Height = _uc.Height + 75;
                    break;

                case "VENDPARTCODE_POPUP":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucPartCodePopup";

                    ucPartCodePopup.CORP_CDDE = _pCORP_CODE;
                    ucPartCodePopup.USER_CODE = _pUSER_CODE;
                    ucPartCodePopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucPartCodePopup.FONT_TYPE = fntPARENT_FONT;

                    ucPartCodePopup.ARRAY = _pARRAY;
                    ucPartCodePopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucPartCodePopup();

                    ucPartCodePopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucPartCodePopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "TEAMVIEWER_Info":
                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucPartCodePopup";

                    ucPartCodePopup.CORP_CDDE = _pCORP_CODE;
                    ucPartCodePopup.USER_CODE = _pUSER_CODE;
                    ucPartCodePopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucPartCodePopup.FONT_TYPE = fntPARENT_FONT;

                    ucPartCodePopup.ARRAY = _pARRAY;
                    ucPartCodePopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucPartCodePopup();

                    ucPartCodePopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucPartCodePopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "MaterialCodeInfo":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendCodeInfoPopup_T03";

                    ucVendCodeInfoPopup_T03.CORP_CDDE = _pCORP_CODE;
                    ucVendCodeInfoPopup_T03.USER_CODE = _pUSER_CODE;
                    ucVendCodeInfoPopup_T03.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucVendCodeInfoPopup_T03.FONT_TYPE = fntPARENT_FONT;

                    ucVendCodeInfoPopup_T03.ARRAY = _pARRAY;
                    ucVendCodeInfoPopup_T03.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucVendCodeInfoPopup_T03();

                    ucVendCodeInfoPopup_T03._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucVendCodeInfoPopup_T03._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;
                case "PartMove":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucVendCodeInfoPopup_T04";

                    ucVendCodeInfoPopup_T04.CORP_CDDE = _pCORP_CODE;
                    ucVendCodeInfoPopup_T04.USER_CODE = _pUSER_CODE;
                    ucVendCodeInfoPopup_T04.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucVendCodeInfoPopup_T04.FONT_TYPE = fntPARENT_FONT;

                    ucVendCodeInfoPopup_T04.ARRAY = _pARRAY;
                    ucVendCodeInfoPopup_T04.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucVendCodeInfoPopup_T04();

                    ucVendCodeInfoPopup_T04._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucVendCodeInfoPopup_T04._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;
                case "ucReversBOMInfoPopup":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucReversBOMInfoPopup";

                    ucReversBOMInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucReversBOMInfoPopup.USER_CODE = _pUSER_CODE;
                    ucReversBOMInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucReversBOMInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucReversBOMInfoPopup.ARRAY = _pARRAY;
                    ucReversBOMInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucReversBOMInfoPopup();

                    ucReversBOMInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucReversBOMInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;
                case "ucTabletBasedSensorInfo":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucTabletBasedSensorInfoPopup";

                    ucTabletBasedSensorInfoPopup.CRUD = _pCRUD;
                    ucTabletBasedSensorInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucTabletBasedSensorInfoPopup.USER_CODE = _pUSER_CODE;
                    ucTabletBasedSensorInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucTabletBasedSensorInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucTabletBasedSensorInfoPopup.ARRAY = _pARRAY;

                    ucTabletBasedSensorInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucTabletBasedSensorInfoPopup();

                    ucTabletBasedSensorInfoPopup._OnClick += ucCommonCodePopup__OnDoubleClick;
                    ucTabletBasedSensorInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width + 65;
                    this.Height = _uc.Height + 50;
                    break;

                case "ucTabletBasedSensorInfo_T01":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucTabletBasedSensorInfoPopup_T01";

                    ucTabletBasedSensorInfoPopup_T01.CRUD = _pCRUD;
                    ucTabletBasedSensorInfoPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucTabletBasedSensorInfoPopup_T01.USER_CODE = _pUSER_CODE;
                    ucTabletBasedSensorInfoPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucTabletBasedSensorInfoPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucTabletBasedSensorInfoPopup_T01.ARRAY = _pARRAY;

                    ucTabletBasedSensorInfoPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucTabletBasedSensorInfoPopup_T01();

                    ucTabletBasedSensorInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucTabletBasedSensorInfoPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width + 250;
                    this.Height = _uc.Height + 50;
                    break;

                case "ucTabletBasedSensorInfo_T02":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucTabletBasedSensorInfoPopup_T02";

                    ucTabletBasedSensorInfoPopup_T02.CRUD = _pCRUD;
                    ucTabletBasedSensorInfoPopup_T02.CORP_CDDE = _pCORP_CODE;
                    ucTabletBasedSensorInfoPopup_T02.USER_CODE = _pUSER_CODE;
                    ucTabletBasedSensorInfoPopup_T02.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucTabletBasedSensorInfoPopup_T02.FONT_TYPE = fntPARENT_FONT;

                    ucTabletBasedSensorInfoPopup_T02.ARRAY = _pARRAY;

                    ucTabletBasedSensorInfoPopup_T02.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucTabletBasedSensorInfoPopup_T02();

                    //ucTabletBasedSensorInfoPopup_T02._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucTabletBasedSensorInfoPopup_T02._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width + 7;
                    this.Height = _uc.Height + 50;
                    break;

                case "ucTabletBasedSensorInfo_T03":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucTabletBasedSensorInfoPopup_T03";

                    ucTabletBasedSensorInfoPopup_T03.CRUD = _pCRUD;
                    ucTabletBasedSensorInfoPopup_T03.CORP_CDDE = _pCORP_CODE;
                    ucTabletBasedSensorInfoPopup_T03.USER_CODE = _pUSER_CODE;
                    ucTabletBasedSensorInfoPopup_T03.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucTabletBasedSensorInfoPopup_T03.FONT_TYPE = fntPARENT_FONT;

                    ucTabletBasedSensorInfoPopup_T03.ARRAY = _pARRAY;

                    ucTabletBasedSensorInfoPopup_T03.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucTabletBasedSensorInfoPopup_T03();

                    //ucTabletBasedSensorInfoPopup_T02._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucTabletBasedSensorInfoPopup_T03._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width + 7;
                    this.Height = _uc.Height + 50;
                    break;

                case "InputIspectInfo":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucInputIspectInfoPopup";

                    ucMaterialOrderInfoPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucMaterialOrderInfoPopup_T01.USER_CODE = _pUSER_CODE;
                    ucMaterialOrderInfoPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucMaterialOrderInfoPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucMaterialOrderInfoPopup_T01.ARRAY = _pARRAY;
                    ucMaterialOrderInfoPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucMaterialOrderInfoPopup_T01();

                    ucMaterialOrderInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucMaterialOrderInfoPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width + 300;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                case "PartCodeInfo_T02":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucPartCodePopup_T02";

                    ucPartCodePopup_T02.CORP_CDDE = _pCORP_CODE;
                    ucPartCodePopup_T02.USER_CODE = _pUSER_CODE;
                    ucPartCodePopup_T02.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucPartCodePopup_T02.FONT_TYPE = fntPARENT_FONT;

                    ucPartCodePopup_T02.ARRAY = _pARRAY;
                    ucPartCodePopup_T02.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucPartCodePopup_T02();

                    ucPartCodePopup_T02._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucPartCodePopup_T02._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width;
                    this.Height = _uc.Height + 75;
                    break;

                case "CommonCode_ResourceCode":

                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucCommonCodePopup_ResourceCode";

                    ucCommonCodePopup_ResourceCode.CRUD = _pCRUD;
                    ucCommonCodePopup_ResourceCode.CORP_CDDE = _pCORP_CODE;
                    ucCommonCodePopup_ResourceCode.USER_CODE = _pUSER_CODE;
                    ucCommonCodePopup_ResourceCode.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucCommonCodePopup_ResourceCode.FONT_TYPE = fntPARENT_FONT;

                    ucCommonCodePopup_ResourceCode.ARRAY = _pARRAY;

                    ucCommonCodePopup_ResourceCode.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucCommonCodePopup_ResourceCode();

                    ucCommonCodePopup_ResourceCode._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucCommonCodePopup_ResourceCode._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width + 300;
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
            if (gv.FocusedRowHandle < 0) return;
            switch (_pFindControl)
            {
                case "CommonCode":

                    _dtreturn.Columns.Add("CD", typeof(string));
                    _dtreturn.Columns.Add("CD_NM", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CD").ToString(), gv.GetFocusedRowCellValue("CD_NM").ToString() });
                    break;

                case "CommonCode_Equipment":

                    _dtreturn.Columns.Add("CD", typeof(string));
                    _dtreturn.Columns.Add("CD_NM", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CD").ToString(), gv.GetFocusedRowCellValue("CD_NM").ToString() });
                    break;

                case "CommonCode_BadCod":

                    _dtreturn.Columns.Add("CD", typeof(string));
                    _dtreturn.Columns.Add("CD_NM", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CD").ToString(), gv.GetFocusedRowCellValue("CD_NM").ToString() });
                    break;

                case "CommonCode_ProcessGroup":

                    _dtreturn.Columns.Add("CD", typeof(string));
                    _dtreturn.Columns.Add("CD_NM", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CD").ToString(), gv.GetFocusedRowCellValue("CD_NM").ToString() });
                    break;

                case "CommonCode_StopCode":

                    _dtreturn.Columns.Add("CD", typeof(string));
                    _dtreturn.Columns.Add("CD_NM", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CD").ToString(), gv.GetFocusedRowCellValue("CD_NM").ToString() });
                    break;

                case "CommonCode_Terminal":

                    _dtreturn.Columns.Add("CD", typeof(string));
                    _dtreturn.Columns.Add("CD_NM", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CD").ToString(), gv.GetFocusedRowCellValue("CD_NM").ToString() });
                    break;

                case "CommonCode_Tool":

                    _dtreturn.Columns.Add("CD", typeof(string));
                    _dtreturn.Columns.Add("CD_NM", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CD").ToString(), gv.GetFocusedRowCellValue("CD_NM").ToString() });
                    break;

                case "ContractInfo":

                    //_dtreturn.Columns.Add("CD", typeof(string));
                    //_dtreturn.Columns.Add("CD_NM", typeof(string));
                    //
                    //_dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CD").ToString(), gv.GetFocusedRowCellValue("CD_NM").ToString() });
                    break;

                case "ProductionOrderInfo":
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==


                    //user Control 생성시 고정 ==
                    break;
                case "VendInfo":
                    _dtreturn.Columns.Add("CD", typeof(string));
                    _dtreturn.Columns.Add("CD_NM", typeof(string));

                    _dtreturn.Rows.Add(new object[] { gv.GetFocusedRowCellValue("CD").ToString(), gv.GetFocusedRowCellValue("CD_NM").ToString() });
                    break;
                case "PartCodeInfo":
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_TYPE", typeof(string));
                    _dtreturn.Columns.Add("PART_COST", typeof(string));
                    _dtreturn.Columns.Add("PART_UNITCOST_CURRENCY_CODE", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_TYPE").ToString(), gv.GetFocusedRowCellValue("PART_COST").ToString(), gv.GetFocusedRowCellValue("PART_UNITCOST_CURRENCY_CODE").ToString() });

                    break;
                case "PartCodeInfo2":
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_TYPE", typeof(string));
                    _dtreturn.Columns.Add("PART_IN_COST", typeof(string));
                    _dtreturn.Columns.Add("PART_UNITCOST_CURRENCY_CODE", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_TYPE").ToString(), gv.GetFocusedRowCellValue("PART_IN_COST").ToString(), gv.GetFocusedRowCellValue("PART_UNITCOST_CURRENCY_CODE").ToString() });

                    break;

                case "MaterialCodeInfo":
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_COST", typeof(string));
                    _dtreturn.Columns.Add("PART_UNITCOST_CURRENCY_CODE", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_COST").ToString(), gv.GetFocusedRowCellValue("PART_UNITCOST_CURRENCY_CODE").ToString() });

                    break;
                case "VendCostInfo":
                    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    _dtreturn.Columns.Add("VEND_TYPE", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_UNITCOST", typeof(string));
                    _dtreturn.Columns.Add("PART_UNITCOST_CURRENCY_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_UNIT", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString(), gv.GetFocusedRowCellValue("VEND_TYPE").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_UNITCOST").ToString(), gv.GetFocusedRowCellValue("PART_UNITCOST_CURRENCY_CODE").ToString(), gv.GetFocusedRowCellValue("PART_UNIT").ToString() }); 
                    //user Control 생성시 고정 ==
                    break;
                // 케이스별 userControl 추가

                case "VendCodeInfo":
                    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    _dtreturn.Columns.Add("VEND_TYPE", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString(), gv.GetFocusedRowCellValue("VEND_TYPE").ToString()});
                    //user Control 생성시 고정 ==
                    break;

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
                // 수정시 김정호부장님에게 말씀드리고 수정해주세요. < 2019.03.07 >
                case "ContractInfo_Popup":
                    _dtreturn.Columns.Add("CONTRACT_ID", typeof(string));
                    _dtreturn.Columns.Add("CONTRACT_DATE", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("CONTRACT_QTY", typeof(string));
                    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    _dtreturn.Columns.Add("PRODUCTION_PLAN_QTY", typeof(string));
                    //_dtreturn.Columns.Add("REMAIN_QTY", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CONTRACT_ID").ToString(), gv.GetFocusedRowCellValue("CONTRACT_DATE").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("CONTRACT_QTY").ToString(), gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString(), gv.GetFocusedRowCellValue("PRODUCTION_PLAN_QTY").ToString() });
                    break;
                case "ContractInfo_Out_Popup":
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
                    
                case "PlanOrderInfo_Popup":
                    _dtreturn.Columns.Add("PLAN_ORDER", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PLAN_ORDER_QTY", typeof(string));
                    _dtreturn.Columns.Add("REFERENCE_ID", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("PLAN_ORDER").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PLAN_ORDER_QTY").ToString(), gv.GetFocusedRowCellValue("REFERENCE_ID").ToString() });
                    break;
                case "PlanOrderInfo_Popup_T50":
                    _dtreturn.Columns.Add("PLAN_ORDER", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PLAN_ORDER_QTY", typeof(string));
                    _dtreturn.Columns.Add("REFERENCE_ID", typeof(string));
                    _dtreturn.Columns.Add("CONFIGURATION_MST_NAME", typeof(string));
                    _dtreturn.Columns.Add("CONFIGURATION_NAME", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("PLAN_ORDER").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PLAN_ORDER_QTY").ToString(), gv.GetFocusedRowCellValue("REFERENCE_ID").ToString(), gv.GetFocusedRowCellValue("CONFIGURATION_MST_NAME").ToString(), gv.GetFocusedRowCellValue("CONFIGURATION_NAME").ToString() });
                    break;
                case "VendCodeInfo_T02":
                    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    _dtreturn.Columns.Add("VEND_TYPE", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString(), gv.GetFocusedRowCellValue("VEND_TYPE").ToString() });
                    break;

                case "VendCodeInfo_T04":
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_VEND", typeof(string));
                    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_VEND").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString()});
                    break;

                case "VendCodeInfo_T04_biocerra":
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_TYPE", typeof(string));
                    _dtreturn.Columns.Add("PART_COST", typeof(string));
                    _dtreturn.Columns.Add("PART_UNITCOST_CURRENCY_CODE", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_TYPE").ToString(), gv.GetFocusedRowCellValue("PART_COST").ToString(), gv.GetFocusedRowCellValue("PART_UNITCOST_CURRENCY_CODE").ToString() });

                    break;
                case "VENDPARTCODE_POPUP":
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("VEND_PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_PART_CODE").ToString(),  gv.GetFocusedRowCellValue("PART_NAME").ToString() });
                    break;

                case "TEAMVIEWER_Info":
                    _dtreturn.Columns.Add("TEAMVIEWER_ID", typeof(string));
                    _dtreturn.Columns.Add("TEAMVIEWER_NAME", typeof(string));       
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("TEAMVIEWER_ID").ToString(),gv.GetFocusedRowCellValue("TEAMVIEWER_NAME").ToString()});
                    break;

                case "Gathering_Info":
                    _dtreturn.Columns.Add("RESOURCE_CODE", typeof(string));
                    _dtreturn.Columns.Add("RESOURCE_NAME", typeof(string));
                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("RESOURCE_CODE").ToString(), gv.GetFocusedRowCellValue("RESOURCE_NAME").ToString() });
                    break;

                case "ucTabletBasedSensorInfo":

                    _dtreturn.Columns.Add("CD", typeof(string));
                    _dtreturn.Columns.Add("CD_NM", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CD").ToString(), gv.GetFocusedRowCellValue("CD_NM").ToString() });
                    break;

                case "PartCodeInfo_T02":
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("PART_TYPE", typeof(string));
                    _dtreturn.Columns.Add("PART_COST", typeof(string));
                    _dtreturn.Columns.Add("PART_UNITCOST_CURRENCY_CODE", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("PART_TYPE").ToString(), gv.GetFocusedRowCellValue("PART_COST").ToString(), gv.GetFocusedRowCellValue("PART_UNITCOST_CURRENCY_CODE").ToString() });

                    //break;

                    //_dtreturn.Columns.Add("CD", typeof(string));
                    //_dtreturn.Columns.Add("CD_NM", typeof(string));

                    //_dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CD").ToString(), gv.GetFocusedRowCellValue("CD_NM").ToString() });
                    break;

                case "CommonCode_ResourceCode":

                    _dtreturn.Columns.Add("CD", typeof(string));
                    _dtreturn.Columns.Add("CD_NM", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CD").ToString(), gv.GetFocusedRowCellValue("CD_NM").ToString() });
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
                case "MaterialOrder":
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
