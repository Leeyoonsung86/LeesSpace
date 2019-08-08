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
using CoFAS_MES.UI.EM.UserControls;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using DevExpress.XtraEditors.Controls;
using CoFAS_MES.UI.EM.Entity;

namespace CoFAS_MES.UI.EM.UserForm
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

        private static EquipmentCodeMstRegisterEntity _pEquipmentCodeMstRegisterEntity = null; // 엔티티 생성

        private static Font fntPARENT_FONT = null;

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

        
        public static EquipmentCodeMstRegisterEntity EquipmentCodeMstRegisterEntity
        {
            get { return _pEquipmentCodeMstRegisterEntity; }
            set { _pEquipmentCodeMstRegisterEntity = value; }
        }

        public static string FTP_IP_PORT
        {
            get { return _pFTP_IP_PORT; }
            set { _pFTP_IP_PORT = value; }
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

            InitializeSetting();

            switch (_pFindControl)
            {

                case "ucEquipmentDocumentListPopup":  // 설비 서류등록
                    // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경

                    //user Control 생성시 고정 ==
                    ucEquipmentDocumentListPopup.CORP_CDDE = _pCORP_CODE;
                    ucEquipmentDocumentListPopup.USER_CODE = _pUSER_CODE;
                    ucEquipmentDocumentListPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucEquipmentDocumentListPopup.FONT_TYPE = fntPARENT_FONT;

                    ucEquipmentDocumentListPopup.ARRAY = _pARRAY;
                    ucEquipmentDocumentListPopup.ARRAY_CODE = _pARRAY_CODE;

                    ucEquipmentDocumentListPopup.FTP_ID = _pFTP_ID;
                    ucEquipmentDocumentListPopup.FTP_PATH = _pFTP_PATH;
                    ucEquipmentDocumentListPopup.FTP_PW = _pFTP_PW;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = "ucEquipmentDocumentListPopup";
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucEquipmentDocumentListPopup();

                    //  ucWorkOrderInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucEquipmentDocumentListPopup._Close_Click += ucCommonCodePopup_Close_OnClick;
                    //user Control 생성시 고정 ==
                    this.Width = _uc.Width+150;
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

                case "ucEquipmentDocumentListPopup":
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
            }
            
            Close();
        }
        private void ucCommonCodePopup_Close_OnClick(object sender, EventArgs e)
        {
            _dtreturn = new DataTable();
            
            switch (_pFindControl)
            {
                case "ucEquipmentDocumentListPopup":
                    
                        _dtreturn = null;
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
                case "ucEquipmentDocumentListPopup":
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

