using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Business;

namespace CoFAS_MES.UI.IM.UserView
{
    public partial class ucResourceSensor : UserControl
    {
        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private static Font fntPARENT_FONT = null;       // 시스템 폰트 설정

        private static string _pCRUD = ""; //CRUD

        private static object[] _pARRAY_DATA = null;

        private static DataTable _pDATA_TABLE = null;

        public string strTest = "";

        private static string _pM_LIMIT_HIGH = string.Empty;

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

        public static object[] ARRAY_DATA
        {
            get { return _pARRAY_DATA; }
            set { _pARRAY_DATA = value; }
        }

        public static DataTable DATA_TABLE
        {
            get { return _pDATA_TABLE; }
            set {
                    _pDATA_TABLE = null;
                    _pDATA_TABLE = value;
                }
        }

        public static string M_LIMIT_HIGH
        {
            get {return _pM_LIMIT_HIGH;   }
            set { _pM_LIMIT_HIGH = value; }
        }


        private DataTable _dtList = new DataTable(); //조회 데이터

        private DataTable _dtreturn = new DataTable(); // 데이터 리턴

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

        public ucResourceSensor()
        {
            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();

            InitializeSetting();

        }

        private void InitializeSetting()
        {
            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }

            _luSENSOR_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "SENSOR_UNIT", "", "", "").Tables[0], 0, 0, "");

            _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "");

            _luSENSOR_FLOAT_DIGIT.Text = "0";

            _luM_LIMIT_HIGH.Text = "0.00";
            _luM_LIMIT_LOW.Text = "0.00";
            _luLIMIT_HIGH.Text = "0.00";
            _luLIMIT_LOW.Text = "0.00";

            _luREMARK.Text = "";


        }

        private void ucResourceSensor_Load(object sender, EventArgs e)
        {
            _luM_LIMIT_HIGH.Text = _pM_LIMIT_HIGH;

            //if (_pDATA_TABLE != null && _pDATA_TABLE.Rows.Count > 0)
            //{
            //    CoFAS_ControlManager.Controls_Binding(_pDATA_TABLE, false, this);
            //}
            //else
            //{

            //    _luSENSOR_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "SENSOR_UNIT", "", "", "").Tables[0], 0, 0, "");

            //    _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "USE_YN", "", "", "").Tables[0], 0, 0, "");

            //    _luSENSOR_FLOAT_DIGIT.Text = "0";

            //    _luM_LIMIT_HIGH.Text = "0.00";
            //    _luM_LIMIT_LOW.Text = "0.00";
            //    _luLIMIT_HIGH.Text = "0.00";
            //    _luLIMIT_LOW.Text = "0.00";

            //    _luREMARK.Text = "";


            //    //CoFAS_ControlManager.Controls_Binding(_pDATA_TABLE, true, this);
            //}

        }

        private void _luM_LIMIT_HIGH__OnTextChanged(object sender, EventArgs e)
        {
            _pM_LIMIT_HIGH = _luM_LIMIT_HIGH.Text.ToString();
        }
    }
}
