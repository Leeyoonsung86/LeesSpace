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
using DevExpress.XtraEditors.Repository;

namespace CoFAS_MES.CORE.UserControls
{
    public partial class ucVendCostInfoPopup : UserControl 
    {
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

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

        public ucVendCostInfoPopup()
        {


            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();
        }

        private void ucVendCostInfoPopup_Load(object sender, EventArgs e)
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


            //LEFT 품목코드 그리드
            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }

            //그리드 설정 ==고정==

            _gdPART_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdPART, _gdPART_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdPART.Name.ToString()));

            _pCRUD = "";
            switch(ARRAY[0].ToString())
                {
                case "Material_Code":
                    _luT_PART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "MATERIAL_CHECK", "CD90", "", "").Tables[0], 0, 0, ""); //자재만 조회 꼼보빡쑤
                    break;
                case "Product_Code":
                    _luT_PART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PRODUCT_CHECK", "CD90", "", "").Tables[0], 0, 0, ""); //자재만 조회 꼼보빡쑤
                    break;
                case "PART_TYPE_PRODUCT_T01":
                    _luT_PART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PART_TYPE_PRODUCT_T01", "CD90", "", "").Tables[0], 0, 0, ""); //제품/반제품 조회 꼼보빡쑤
                    break;
                case "PRODUCT_TYPE_T01":
                    _luT_PART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PRODUCT_TYPE_T01", "CD90", "", "").Tables[0], 0, 0, ""); //제품/반제품 조회 꼼보빡쑤
                    break;
                default:
                    _luT_PART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD90", "", "").Tables[0], 0, 0, ""); //자재만 조회 꼼보빡쑤
                    break;
                   

            }
            _luCD_NM.Text = ARRAY[1].ToString();
           // MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

            //_gdPART_VIEW.DoubleClick += _gdMAIN_VIEW_DoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수

            //그리드 설정 ==고정==
            //RIGHT 거래처코드 정보(단가)
            //그리드 설정 ==고정==
            _gdPART_VIEW.RowCellClick += _gdPART_VIEW_RowCellClick;

            _gdVEND_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdVEND, _gdVEND_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdVEND.Name.ToString()));

            _pCRUD = "R";
            
            MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

            _gdVEND_VIEW.DoubleClick += _gdVEND_VIEW_DoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수
            _gdPART_VIEW.DoubleClick += _gdPART_VIEW_DoubleClick;
        }



        public static event OnDoubleClickEventHandler _OnDoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수
        //public static event OnDoubleClickEventHandler _OnDoubleClick2; //그리드 로우 마우스 선택으로 값 넘길경우 필수
        public delegate void OnDoubleClickEventHandler(object sender, EventArgs e); //그리드 로우 마우스 선택으로 값 넘길경우 필수

        private void _gdPART_VIEW_DoubleClick(object sender, EventArgs e)
        {
            if (_gdPART_VIEW.RowCount == 0)
            {
                return;
            }
            else
            {
                if (_OnDoubleClick != null)
                    _OnDoubleClick(sender, e);
            }                       
        }

        private void _gdVEND_VIEW_DoubleClick(object sender, EventArgs e)
        {

            if (_gdVEND_VIEW.RowCount == 0)
            {
                return;
            }
            else
            {
                if (_OnDoubleClick != null)
                    _OnDoubleClick(sender, e);
            }            
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
            _luT_PART_TYPE.ItemIndex = 0;
            _gdVEND.DataSource = null;
            _gdPART.DataSource = null;
        }
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdPART_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdPART_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                string strPART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                string strPART_TYPE = gv.GetFocusedRowCellValue("PART_TYPE").ToString();
                string strCRUD = "R";

                SubFind_DisplayData(strCRUD,strPART_CODE, strPART_TYPE);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion


        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                string strCODE = _luCD.Text.ToString();
                string strNAME = _luCD_NM.Text.ToString();
                string strTYPE = _luT_PART_TYPE.GetValue();

                string pLANGUAGE_TYPE = _pLANGUAGE_TYPE;
                if (_dtList != null)
                {
                    _dtList.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdVEND, _gdVEND_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
                _dtList = new VendCostPopUpBusiness().VendCost_Main_Return(_pCRUD, strTYPE, strCODE, strNAME, "", "", "", "", "", pLANGUAGE_TYPE).Tables[0];
                
                 if (_pCRUD == "") _dtList.Rows.Clear();
                
                 if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pCRUD == ""))
                 {
                     CoFAS_DevExpressManager.BindGridControl(_gdPART, _gdPART_VIEW, _dtList);
                    RepositoryItemMemoEdit noteMemo = new RepositoryItemMemoEdit();
                    noteMemo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                  //   noteMemo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    //  noteMemo.apprea
                    _gdPART_VIEW.Columns["PART_NAME"].ColumnEdit = noteMemo;
                  //  _gdPART_VIEW.Appearance.Row.TextOptions.VAlignment= DevExpress.Utils.VertAlignment.Center;
                    this._gdPART_VIEW.OptionsView.RowAutoHeight = true;

                }
                 else
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdPART, _gdPART_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    CoFAS_DevExpressManager.BindGridControl(_gdVEND, _gdVEND_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdPART_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 서브조회 - SubFind_DisplayData()

        private void SubFind_DisplayData(string strCRUD, string strPART_CODE, string strPART_TYPE)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                
                _dtList = new VendCostPopUpBusiness().VendCost_Sub_Return(strCRUD,strPART_CODE, strPART_TYPE,_pLANGUAGE_TYPE).Tables[0];

                if (_pCRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pCRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdVEND, _gdVEND_VIEW, _dtList);
                }
                else
                {
                    // CoFAS_DevExpressManager.BindGridControl(_gdVEND, _gdVEND_VIEW, null);
                    _gdVEND.DataSource = null;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdVEND_VIEW.BestFitColumns();

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
