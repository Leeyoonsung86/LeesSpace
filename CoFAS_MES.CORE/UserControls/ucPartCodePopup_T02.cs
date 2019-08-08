using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace CoFAS_MES.CORE
{
    public partial class ucPartCodePopup_T02 : UserControl
    {
        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어



        private static Font fntPARENT_FONT = null;       // 시스템 폰트 설정

        //private static DataTable _pDATATABLE_VALUE = null;

        private static object[] _pARRAY = null;
        private static object[] _pARRAY_CODE = null;
        private string _pCRUD = ""; //CRUD

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


        private DataTable _dtList = null; //조회 데이터 리스트

        private DataTable _dtreturn = null; // 선택 데이터 리턴

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

        public ucPartCodePopup_T02()
        {

            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();
        }
        private void ucPartCodeInfoPopup_Load(object sender, EventArgs e)
        {
            try
            {

                InitializeSetting();
                if (_pARRAY_CODE != null && _pARRAY_CODE.Length > 1)
                {
                    _luCD.Text = _pARRAY_CODE[0].ToString();
                    _luCD_NM.Text = _pARRAY_CODE[1].ToString();
                }
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


        private void InitializeSetting()
        {
            //상속 화면 패널 사용 유무



            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }

            //그리드 설정 ==고정==

            _luPART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PART_TYPE_PRODUCT_T01", "", "", "").Tables[0], 0, 0, "");
            _luPART_TYPE.ItemIndex = 0;

            _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
            _luCD_NM.Text = ARRAY[1].ToString();
            _pCRUD = "R";

            MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

            _gdMAIN_VIEW.DoubleClick += _gdMAIN_VIEW_DoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수

            //그리드 설정 ==고정==
        }

        public static event OnDoubleClickEventHandler _OnDoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수
        public delegate void OnDoubleClickEventHandler(object sender, EventArgs e); //그리드 로우 마우스 선택으로 값 넘길경우 필수

        private void _gdMAIN_VIEW_DoubleClick(object sender, EventArgs e)
        {
            if (_OnDoubleClick != null)
                _OnDoubleClick(sender, e);
        }

        private void _ucbtSELECT_Click(object sender, EventArgs e)
        {
            _pCRUD = "R";

            MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
        }

        private void _ucbtCLEAR_Click(object sender, EventArgs e)
        {
            _luCD.Text = "";
            _luCD_NM.Text = "";

            _gdMAIN.DataSource = null;
        }

        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                string strCODE = _luCD.Text.ToString();
                string strNAME = _luCD_NM.Text.ToString();
                string strTYPE = _luPART_TYPE.GetValue();

                //ucPartCodePopup_T02로 생성할것!!

                _dtList = new CodePopUpBusiness().CodePopUp_Return(_pCRUD, _pLANGUAGE_TYPE, _pARRAY[0].ToString(), _pARRAY[1].ToString(), strCODE, strNAME, strTYPE, "", "", "").Tables[0];

                if (_pCRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pCRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage("조회내역이 없습니다.");
                    _dtList.Rows.Clear();                    
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }



        #endregion

        //닫기버튼
        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);
        private void _ucbtCancle_Click(object sender, EventArgs e)
        {
            if (_Close_Click != null)
                _Close_Click(sender, e);
        }

    }

}
