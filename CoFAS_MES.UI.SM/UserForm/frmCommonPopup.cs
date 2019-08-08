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
using CoFAS_MES.UI.SM.UserControls;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;

namespace CoFAS_MES.UI.SM.UserForm
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

                case "ucUserAuthorityCopy":

                    //user Control 생성시 고정 ==
                    Child_WindowName = "ucUserAuthorityCopy";

                    ucUserAuthorityCopy.CORP_CDDE = _pCORP_CODE;
                    ucUserAuthorityCopy.USER_CODE = _pUSER_CODE;
                    ucUserAuthorityCopy.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    ucUserAuthorityCopy.FONT_TYPE = fntPARENT_FONT;

                    ucUserAuthorityCopy.ARRAY = _pARRAY;
                    ucUserAuthorityCopy.ARRAY_CODE = _pARRAY_CODE;

                    //언어설정 창 표시 정보
                    PageSetting_WINDOW_NAME = Child_WindowName;
                    PageSetting_USER_CODE = _pUSER_CODE;
                    PageSetting_LANGUAGE = _pLANGUAGE_TYPE;
                    PageSetting_FONT = fntPARENT_FONT;
                    //

                    _uc = new ucUserAuthorityCopy();

                   // ucUserAuthorityCopy._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                    ucUserAuthorityCopy._Close_Click += ucCommonCodePopup_Close_OnClick;

                    this.Width = _uc.Width + 200;
                    this.Height = _uc.Height + 75;
                    //user Control 생성시 고정 ==
                    break;

                    
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

            }

            Close();
        }
        private void ucCommonCodePopup_Request_Click(object sender, EventArgs e)
        {
            GridView gv = sender as GridView;
            _dtreturn = new DataTable();

            switch (_pFindControl)
            {
               
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
