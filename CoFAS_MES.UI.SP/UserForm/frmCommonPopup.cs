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
using CoFAS_MES.UI.SP.UserControls;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;

namespace CoFAS_MES.UI.SP.UserForm
{
    public partial class frmCommonPopup : frmBaseSingle
    {
        #region ○ 전역변수 영역

        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)     
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭 
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private static string _pCRUD = "";
        private static Font fntPARENT_FONT = null;
        private string _pFindControl = "";
        
        private static object[] _pARRAY = null;
        private static object[] _pARRAY_CODE = null;

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
            get { return _dtreturn; }
            set { _dtreturn = value; }
        }

        #endregion

        #region ○ 생성자

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
                case "ShipmentRegister":
                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucShipmentRegisterInfoPopup";

                    ucShipmentRegisterInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucShipmentRegisterInfoPopup.USER_CODE = _pUSER_CODE;
                    ucShipmentRegisterInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucShipmentRegisterInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucShipmentRegisterInfoPopup.ARRAY = _pARRAY;
                    ucShipmentRegisterInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucShipmentRegisterInfoPopup();
                    ucShipmentRegisterInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucShipmentRegisterInfoPopup._OnDoubleClick += ucShipmentRegisterInfoPopup__OnDoubleClick;
                    this.Width = _uc.Width+300;
                    this.Height = _uc.Height + 75;
                    break;
                case "ShipmentRegister_T01":
                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucShipmentRegisterInfoPopup_T01";

                    ucShipmentRegisterInfoPopup_T01.CORP_CDDE = _pCORP_CODE;
                    ucShipmentRegisterInfoPopup_T01.USER_CODE = _pUSER_CODE;
                    ucShipmentRegisterInfoPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucShipmentRegisterInfoPopup_T01.FONT_TYPE = fntPARENT_FONT;

                    ucShipmentRegisterInfoPopup_T01.ARRAY = _pARRAY;
                    ucShipmentRegisterInfoPopup_T01.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucShipmentRegisterInfoPopup_T01();
                    ucShipmentRegisterInfoPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;
                    ucShipmentRegisterInfoPopup_T01._OnDoubleClick += ucShipmentRegisterInfoPopup__OnDoubleClick;
                    this.Width = _uc.Width + 300;
                    this.Height = _uc.Height + 75;
                    break;
                //제품출고용 수주찾기팝업
                case "ProductionInfo_Out_Popup":

                    Child_WindowName = "ucProductionOrderInfoPopup_T05";

                    ucProductionOrderInfoPopup_T05.CORP_CDDE = _pCORP_CODE;
                    ucProductionOrderInfoPopup_T05.USER_CODE = _pUSER_CODE;
                    ucProductionOrderInfoPopup_T05.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucProductionOrderInfoPopup_T05.FONT_TYPE = fntPARENT_FONT;

                    ucProductionOrderInfoPopup_T05.ARRAY = _pARRAY;
                    ucProductionOrderInfoPopup_T05.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucProductionOrderInfoPopup_T05();
                    ucProductionOrderInfoPopup_T05._OnDoubleClick += UcProductionOrderInfoPopup_T05__OnDoubleClick;
                    ucProductionOrderInfoPopup_T05._Close_Click += ucCommonCodePopup_Close_OnClick;
                    this.Width = _uc.Width + 420;
                    this.Height = _uc.Height + 75;
                    break;

                case "SemiProduct_Stock":
                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucSemiProductStockInfoPopup";

                    ucSemiProductStockInfoPopup.CORP_CDDE = _pCORP_CODE;
                    ucSemiProductStockInfoPopup.USER_CODE = _pUSER_CODE;
                    ucSemiProductStockInfoPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucSemiProductStockInfoPopup.FONT_TYPE = fntPARENT_FONT;

                    ucSemiProductStockInfoPopup.ARRAY = _pARRAY;
                    ucSemiProductStockInfoPopup.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucSemiProductStockInfoPopup();

                    ucSemiProductStockInfoPopup._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucSemiProductStockInfoPopup._Close_Click += ucCommonCodePopup_Close_OnClick;

                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    break;
                default:break;
            }

            _uc.CreateControl();
            _pnSINGLE_MAIN.Controls.Add(_uc);
            _uc.Dock = DockStyle.Fill;


        }
        private void ucCommonCodePopup__OnDoubleClick(object sender, EventArgs e)
        {
            GridView gv = sender as GridView;
            _dtreturn = new DataTable();

            switch (_pFindControl)
            {
                case "SemiProduct_Stock":
                   
                    break;


            }



            Close();
        }
        private void UcProductionOrderInfoPopup_T05__OnDoubleClick(object sender, EventArgs e)
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

        #endregion

        #region ○ 초기화 영역

        private void InitializeSetting()
        {
            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }
        }

        #endregion

        #region ○ UserControl 별 이벤트 데이터
        private void ucShipmentRegisterInfoPopup__OnDoubleClick(object sender, EventArgs e)
        {
            GridView gv = sender as GridView;
            _dtreturn = new DataTable();

            switch (_pFindControl)
            {
                case "ShipmentRegister":
                    _dtreturn.Columns.Add("CONTRACT_ID", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    _dtreturn.Columns.Add("CONTRACT_QTY", typeof(string));
                    _dtreturn.Columns.Add("TOTAL_SHIPMENT_QTY", typeof(string));
                    _dtreturn.Columns.Add("LEAVE_QTY", typeof(string));
                    _dtreturn.Columns.Add("PART_UNIT", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CONTRACT_ID").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString(), gv.GetFocusedRowCellValue("CONTRACT_QTY").ToString(), gv.GetFocusedRowCellValue("TOTAL_SHIPMENT_QTY").ToString(), gv.GetFocusedRowCellValue("LEAVE_QTY").ToString(), gv.GetFocusedRowCellValue("PART_UNIT").ToString() });
                    //user Control 생성시 고정 ==
                    break;
                case "ShipmentRegister_T01":
                    _dtreturn.Columns.Add("CONTRACT_ID", typeof(string));
                    _dtreturn.Columns.Add("PART_CODE", typeof(string));
                    _dtreturn.Columns.Add("PART_NAME", typeof(string));
                    _dtreturn.Columns.Add("VEND_CODE", typeof(string));
                    _dtreturn.Columns.Add("VEND_NAME", typeof(string));
                    _dtreturn.Columns.Add("CONTRACT_QTY", typeof(string));
                    _dtreturn.Columns.Add("TOTAL_SHIPMENT_QTY", typeof(string));
                    _dtreturn.Columns.Add("LEAVE_QTY", typeof(string));
                    _dtreturn.Columns.Add("PART_UNIT", typeof(string));

                    _dtreturn.Rows.Add(new Object[] { gv.GetFocusedRowCellValue("CONTRACT_ID").ToString(), gv.GetFocusedRowCellValue("PART_CODE").ToString(), gv.GetFocusedRowCellValue("PART_NAME").ToString(), gv.GetFocusedRowCellValue("VEND_CODE").ToString(), gv.GetFocusedRowCellValue("VEND_NAME").ToString(), gv.GetFocusedRowCellValue("CONTRACT_QTY").ToString(), gv.GetFocusedRowCellValue("TOTAL_SHIPMENT_QTY").ToString(), gv.GetFocusedRowCellValue("LEAVE_QTY").ToString(), gv.GetFocusedRowCellValue("PART_UNIT").ToString() });
                    //user Control 생성시 고정 ==
                    break;
            }

            Close();
        }

        #endregion
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

        private void ucCommonCodePopup_Close_OnClick(object sender, EventArgs e)
        {
            _dtreturn = new DataTable();

            switch (_pFindControl)
            {
               // case "ProductPlanInfo":
               //     _dtreturn.Columns.Add("PRODUCTION_PLAN_ID", typeof(string));
               //     _dtreturn.Rows.Add(new Object[] { _pARRAY_CODE[0] });
               //     break;
            }

            Close();
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
