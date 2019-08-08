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
using CoFAS_MES.UI.MM.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.UI.MM.Entity;
using CoFAS_MES.CORE.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace CoFAS_MES.UI.MM.UserControls
{
    public partial class ucBOM_SpendQtyCalcPop : UserControl 
    {
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private static Font fntPARENT_FONT = null;       // 시스템 폰트 설정

        ucBOM_SpendQtyCalcPopEntity _ucBOM_SpendQtyCalcPopEntity;

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

        public ucBOM_SpendQtyCalcPop()
        {

            InitializeComponent();

          //  _gdCONTRACT.Width = 100;
            _pWINDOW_NAME = this.Name.ToString();
        }

        private void ucBOM_SpendQtyCalcPop_Load(object sender, EventArgs e)
        {
            try
            {

                InitializeSetting();
                if (_pARRAY_CODE != null && _pARRAY_CODE.Length > 1)
                {
                    
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
            _ucBOM_SpendQtyCalcPopEntity = new ucBOM_SpendQtyCalcPopEntity();
            _ucBOM_SpendQtyCalcPopEntity.CRUD = "R";
            _ucBOM_SpendQtyCalcPopEntity.USER_CODE = _pUSER_CODE;
            _ucBOM_SpendQtyCalcPopEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            _ucBOM_SpendQtyCalcPopEntity.WINDOW_NAME = this.Name;
           // _ucbtCalc.Visible = false;
            //LEFT 품목코드 그리드
            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }

            //그리드 설정 ==고정==

            _gdCONTRACT_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdCONTRACT, _gdCONTRACT_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdCONTRACT.Name.ToString()));
            //조회조건 영역
            _luTORDER_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
            _luTORDER_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
            _pCRUD = "";

           // MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

            //_gdPART_VIEW.DoubleClick += _gdMAIN_VIEW_DoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수

            //그리드 설정 ==고정==
            //RIGHT 거래처코드 정보(단가)
            //그리드 설정 ==고정==
            //20190214
            //소요량 계산으로 변경
            _gdCONTRACT_VIEW.RowCellClick += _gdCONTRACT_VIEW_RowCellClick;

            _gdBOM_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdBOM, _gdBOM_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdBOM.Name.ToString()));

            _pCRUD = "R";
            
            MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

            _gdBOM_VIEW.DoubleClick += _gdVEND_VIEW_DoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수
            _gdCONTRACT_VIEW.DoubleClick += _gdPART_VIEW_DoubleClick;
        }



        public static event OnDoubleClickEventHandler _OnDoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수
        //public static event OnDoubleClickEventHandler _OnDoubleClick2; //그리드 로우 마우스 선택으로 값 넘길경우 필수
        public delegate void OnDoubleClickEventHandler(object sender, EventArgs e); //그리드 로우 마우스 선택으로 값 넘길경우 필수

        private void _gdPART_VIEW_DoubleClick(object sender, EventArgs e)
        {
            if (_OnDoubleClick != null)
                _OnDoubleClick(sender, e);
        }

        private void _gdVEND_VIEW_DoubleClick(object sender, EventArgs e)
        {
            if (_OnDoubleClick != null)
                _OnDoubleClick(sender, e);
        }


        private void _btSELECT_Click(object sender, EventArgs e)
        {
            _pCRUD = "R";

            MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
        }

        private void _ucbtSave_Click(object sender, EventArgs e)
        {
            //DialogResult pDialogResult = CoFAS_DevExpressManager.ShowQuestionMessage("실적을 저장하시겠습니까?");

            DialogResult pDialogResult = CoFAS_DevExpressManager.ShowQuestionMessage("발주를 저장하시겠습니까?");

            _ucBOM_SpendQtyCalcPopEntity.CRUD = "C";
            _ucBOM_SpendQtyCalcPopEntity.ORDER_DATE = DateTime.Now.ToString("yyyyMMdd");
            _ucBOM_SpendQtyCalcPopEntity.REQUEST_DATE = "";
            if (pDialogResult == DialogResult.Yes)
            {

                    DataTable tDataTable = _gdBOM_VIEW.GridControl.DataSource as DataTable;

                //포장에서 양품실적은 제품으로
              //  _ucBOM_SpendQtyCalcPopEntity.CONTRACT_ID = _luPART_CODE.Text;
                    bool isError = false;

                        isError = new ucBOM_SpendQtyCalcPopBusiness().ucBOM_SpendQtyCalcPop_Save(_ucBOM_SpendQtyCalcPopEntity, tDataTable);

                    if (!isError)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("저장되었습니다.");


                        _Close_Click(null, null);
                    }
                    else
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("오류가 발생했습니다.");
                    }
            }
        }

        private void _btCLEAR_Click(object sender, EventArgs e)
        {
            _luTPART.CodeText = "";
            _luTPART.NameText = "";

            _luTVEND.CodeText = "";
            _luTVEND.NameText = "";


            //_luT_PART_TYPE.ItemIndex = 0;
            _gdBOM.DataSource = null;
            _gdCONTRACT.DataSource = null;
        }
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdCONTRACT_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdCONTRACT_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                string strPART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                string strPART_TYPE = gv.GetFocusedRowCellValue("PART_TYPE").ToString();
                string strCONTRACT_ID = gv.GetFocusedRowCellValue("CONTRACT_ID").ToString();
                string strCRUD = "R";
                decimal pQTY= Convert.ToDecimal(gv.GetFocusedRowCellValue("CONTRACT_QTY").ToString());
                _ucBOM_SpendQtyCalcPopEntity.CONTRACT_ID = gv.GetFocusedRowCellValue("CONTRACT_ID").ToString();
                _ucBOM_SpendQtyCalcPopEntity.VEND_CODE = gv.GetFocusedRowCellValue("VEND_CODE").ToString();

                SubFind_DisplayData(strCRUD, strCONTRACT_ID,strPART_CODE, strPART_TYPE, pQTY);
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
                

                string strCODE = "";//_luCD.Text.ToString();
                string strNAME = "";// _luCD_NM.Text.ToString();
                //string strTYPE = _luT_PART_TYPE.GetValue();
                string pCRUD = "R";
                string pDATE_FROM = DateTime.Parse(_luTORDER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");
                string pDATE_TO = DateTime.Parse(_luTORDER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");
                string pPART_TYPE = "";
                string pPART_CODE = _luTPART.CodeText.ToString();
                string pPART_NAME = _luTPART.NameText.ToString();
                string pVEND_CODE = _luTVEND.CodeText.ToString();
                string pVEND_NAME = _luTVEND.NameText.ToString();
                string pLANGUAGE_TYPE= _pLANGUAGE_TYPE;

                
                //string pCRUD, string pDATE_FROM, string pDATE_TO, string pPART_TYPE, string pPART_CODE, string pPART_NAME, string pVEND_CODE, string pVEND_NAME, string pLANGUAGE_TYPE
                _dtList = new ucBOM_SpendQtyCalcPopBusiness().ucBOM_SpendQtyCalcPop_Main_Return(pCRUD, pDATE_FROM, pDATE_TO,  pPART_TYPE,  pPART_CODE,  pPART_NAME,  pVEND_CODE,  pVEND_NAME,  pLANGUAGE_TYPE).Tables[0];

                if (_pCRUD == "") _dtList.Rows.Clear();
                
                 if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pCRUD == ""))
                 {
                     CoFAS_DevExpressManager.BindGridControl(_gdCONTRACT, _gdCONTRACT_VIEW, _dtList);
                    CoFAS_DevExpressManager.BindGridControl(_gdBOM, _gdBOM_VIEW, null); //데이터 필드에 맞춰 자동 바인딩
                    _gdCONTRACT_VIEW.Columns["CRUD"].AppearanceCell.BackColor = Color.Red;
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    _dtList.Rows.Clear();
                    //Form_InitialButtonClicked(null, null);
                    CoFAS_DevExpressManager.BindGridControl(_gdCONTRACT, _gdCONTRACT_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdCONTRACT_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 서브조회 - SubFind_DisplayData()

        private void SubFind_DisplayData(string strCRUD,string strCONTRACT_ID,string strPART_CODE, string strPART_TYPE, decimal pQTY)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                
                _dtList = new ucBOM_SpendQtyCalcPopBusiness().VendCost_Sub_Return(strCRUD, strCONTRACT_ID,strPART_CODE, strPART_TYPE,_pLANGUAGE_TYPE, pQTY);

                if (_pCRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pCRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdBOM, _gdBOM_VIEW, _dtList);

                  //  _gdBOM_VIEW.Columns["SPEND_QTY"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                  //  _gdBOM_VIEW.Columns["LACK_QTY"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                  //  _gdBOM_VIEW.Columns["STOCK"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                  //  _gdBOM_VIEW.Columns["UNITCOST"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                  //  _gdBOM_VIEW.Columns["ORDER_QTY"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                  //
                  //  _gdBOM_VIEW.Columns["SPEND_QTY"].DisplayFormat.FormatString = "{0:#,###.##0}";
                  //  _gdBOM_VIEW.Columns["LACK_QTY"].DisplayFormat.FormatString = "{0:#,###.##0}";
                  //  _gdBOM_VIEW.Columns["STOCK"].DisplayFormat.FormatString = "{0:#,###.##0}";
                  //  _gdBOM_VIEW.Columns["UNITCOST"].DisplayFormat.FormatString = "{0:#,###.##0}";
                  //  _gdBOM_VIEW.Columns["ORDER_QTY"].DisplayFormat.FormatString = "{0:#,###.##0}";
                    
                        
                        
                        
                }
                else
                {
                    // CoFAS_DevExpressManager.BindGridControl(_gdVEND, _gdVEND_VIEW, null);
                    _gdBOM.DataSource = null;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdBOM_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }


        #endregion

        //닫기버튼
        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);

        private void _btCancle_Click(object sender, EventArgs e)
        {
            if (_Close_Click != null)
                _Close_Click(sender, e);
        }

        private void _luTVEND__OnOpenClick(object sender, EventArgs e)
        {
            //VendCostInfo
            CoFAS_MES.CORE.UserForm.frmCommonPopup.CRUD = "R";
            CoFAS_MES.CORE.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
            CoFAS_MES.CORE.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            CoFAS_MES.CORE.UserForm.frmCommonPopup.FONT_TYPE = fntPARENT_FONT;



            // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            CoFAS_MES.CORE.UserForm.frmCommonPopup.ARRAY = new object[2] { "Vend_Code_I", "" }; 

            //검색조건 전달 0 코드 1 명칭
            CoFAS_MES.CORE.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _luTVEND.CodeText.ToString(), _luTVEND.NameText.ToString() };

            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            CoFAS_MES.CORE.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luTVEND.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luTVEND.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

                //데이터 세팅
            }

            xfrmCommonPopup.Dispose();
        }

        private void _luTPART__OnOpenClick(object sender, EventArgs e)
        {
            //VendCostInfo
            CoFAS_MES.CORE.UserForm.frmCommonPopup.CRUD = "R";
            CoFAS_MES.CORE.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
            CoFAS_MES.CORE.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            CoFAS_MES.CORE.UserForm.frmCommonPopup.FONT_TYPE =fntPARENT_FONT;
;



            // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            CoFAS_MES.CORE.UserForm.frmCommonPopup.ARRAY = new object[2] { "Material_Code", "" };

            //검색조건 전달 0 코드 1 명칭
            CoFAS_MES.CORE.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _luTPART.CodeText.ToString(), _luTPART.NameText.ToString() };

            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            CoFAS_MES.CORE.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {

                
                

                _luTPART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luTPART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

                //데이터 세팅
            }

            xfrmCommonPopup.Dispose();
        }

      
        private void _ucbtCalc2_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                DataTable tDataTable = _gdCONTRACT_VIEW.GridControl.DataSource as DataTable;
                //_ucBOM_SpendQtyCalcPopEntity.CRUD = "R";
                _ucBOM_SpendQtyCalcPopEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

                //check_yn : false = 개별
                //check_yn: : true = 합계
                _ucBOM_SpendQtyCalcPopEntity.check_yn = true;
                   bool isError = false;



                //먼저 초기화
                _ucBOM_SpendQtyCalcPopEntity.CRUD = "D";
               isError = new ucBOM_SpendQtyCalcPopBusiness().ucBOM_SpendQtyCalcPop_Save2(_ucBOM_SpendQtyCalcPopEntity, tDataTable);

                if (!isError)
                {
                    _ucBOM_SpendQtyCalcPopEntity.CRUD = "C";
                    isError = new ucBOM_SpendQtyCalcPopBusiness().ucBOM_SpendQtyCalcPop_Save2(_ucBOM_SpendQtyCalcPopEntity, tDataTable);
                    if (!isError)
                    {
                        
                        //체크하기
                        _ucBOM_SpendQtyCalcPopEntity.CRUD = "R";

                        //_dtList = new ucBOM_SpendQtyCalcPopBusiness().VendCost_Sub_Return2(_ucBOM_SpendQtyCalcPopEntity, tDataTable);
                        _dtList = new ucBOM_SpendQtyCalcPopBusiness().VendCost_Sub_Return(_ucBOM_SpendQtyCalcPopEntity, tDataTable);
                        //CoFAS_DevExpressManager.ShowInformationMessage("저장되었습니다.");
                        //_Close_Click(null, null);
                    }
                    else
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("오류가 발생했습니다.");
                    }
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("오류가 발생했습니다.");
                }



                if (_pCRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pCRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdBOM, _gdBOM_VIEW, _dtList);
                }
                else
                {
                    // CoFAS_DevExpressManager.BindGridControl(_gdVEND, _gdVEND_VIEW, null);
                    _gdBOM.DataSource = null;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdBOM_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        private void _ucbtCalc_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                DataTable tDataTable = _gdCONTRACT_VIEW.GridControl.DataSource as DataTable;
                _ucBOM_SpendQtyCalcPopEntity.CRUD = "R";
                _ucBOM_SpendQtyCalcPopEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _ucBOM_SpendQtyCalcPopEntity.check_yn = false;
                _dtList = new ucBOM_SpendQtyCalcPopBusiness().VendCost_Sub_Return(_ucBOM_SpendQtyCalcPopEntity, tDataTable);

                if (_pCRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pCRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdBOM, _gdBOM_VIEW, _dtList);
                }
                else
                {
                    // CoFAS_DevExpressManager.BindGridControl(_gdVEND, _gdVEND_VIEW, null);
                    _gdBOM.DataSource = null;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdBOM_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

    }
}
