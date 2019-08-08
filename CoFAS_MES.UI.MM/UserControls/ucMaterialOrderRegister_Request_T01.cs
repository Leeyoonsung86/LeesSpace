using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.BaseControls;
using CoFAS_MES.CORE.UserForm;
using CoFAS_MES.CORE.UserControls;

using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.UI.MM.Business;
using CoFAS_MES.UI.MM.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace CoFAS_MES.UI.MM.UserControls
{
    public partial class ucMaterialOrderRegister_Request_T01 : UserControl
    {
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어


        //알림창메시지 복사 시작
        private string _pMSG_SEARCH = string.Empty;   // 조회 되었습니다.
        private string _pMSG_SEARCH_EMPT = string.Empty;   // 조회 항목이 없습니다.
        private string _pMSG_SAVE_QUESTION = string.Empty;   // 데이터 저장 처리 하겠습니까?
        private string _pMSG_SAVE = string.Empty;   // 저장 처리 되었습니다.
        private string _pMSG_SAVE_ERROR = string.Empty;   // 저장 처리 중 오류가 발생 하였습니다.
        private string _pMSG_DELETE_QUESTION = string.Empty;   // 데이터 삭제 처리 하겠습니까?
        private string _pMSG_DELETE = string.Empty;   // 삭제 처리 되었습니다.
        private string _pMSG_DELETE_ERROR = string.Empty;   // 삭제 처리 중 오류가 발생 하였습니다.
        private string _pMSG_DELETE_COMPLETE = string.Empty;   // 삭제된 데이터 입니다.
        private string _pMSG_INPUT_DATA = string.Empty;   // 데이터를 입력 해 주세요.
        private string _pMSG_INPUT_DATA_ERROR = string.Empty;   // 데이터 입력이 잘못되었습니다.
        private string _pMSG_WORKING = string.Empty;   // 작업중인 항목이 있습니다.
        private string _pMSG_RESET_QUESTION = string.Empty;   // 초기화 하시겠습니까?
        private string _pMSG_EXIT_QUESTION = string.Empty;   // 종료 하겠습니까?
        private string _pMSG_SELECT = string.Empty;   // 데이터를 선택해주세요.
        private string _pMSG_RESET_COMPLETE = string.Empty;     //초기화 하였습니다.  

        private ucMaterialOrderRegister_Request_T01Entity _pucMaterialOrderRegister_Request_T01Entity = null; // 엔티티 생성

        private CoFAS_DevGridManager _TempGridView;
        private CoFAS_DevGridManager _TempGridView2;

        private static Font fntPARENT_FONT = null;       // 시스템 폰트 설정


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
        private DataTable _dtList2 = null; //서브 조회 데이터 리스트
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

        public ucMaterialOrderRegister_Request_T01()
        {
            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();
        }

        public ucMaterialOrderRegister_Request_T01(DataTable dt)
        {
            InitializeComponent();
            _dtreturn = dt;
            _pWINDOW_NAME = this.Name.ToString();
            
        }

        private void ucMaterialOrderRegister_Request_T01_Load(object sender, EventArgs e)
        {
            try
            {
                _pMessageEntity = new MessageEntity();
                DataTable dtMessage = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE);
                if (dtMessage != null)
                {
                    _pMessageEntity.MSG_SEARCH = dtMessage.Rows[0]["MSG_SEARCH"].ToString();
                    _pMessageEntity.MSG_SEARCH_EMPT = dtMessage.Rows[0]["MSG_SEARCH_EMPT"].ToString();
                    _pMessageEntity.MSG_SAVE_QUESTION = dtMessage.Rows[0]["MSG_SAVE_QUESTION"].ToString();
                    _pMessageEntity.MSG_SAVE = dtMessage.Rows[0]["MSG_SAVE"].ToString();
                    _pMessageEntity.MSG_SAVE_ERROR = dtMessage.Rows[0]["MSG_SAVE_ERROR"].ToString();
                    _pMessageEntity.MSG_DELETE_QUESTION = dtMessage.Rows[0]["MSG_DELETE_QUESTION"].ToString();
                    _pMessageEntity.MSG_DELETE = dtMessage.Rows[0]["MSG_DELETE"].ToString();
                    _pMessageEntity.MSG_DELETE_ERROR = dtMessage.Rows[0]["MSG_DELETE_ERROR"].ToString();
                    _pMessageEntity.MSG_DELETE_COMPLETE = dtMessage.Rows[0]["MSG_DELETE_COMPLETE"].ToString();
                    _pMessageEntity.MSG_INPUT_DATA = dtMessage.Rows[0]["MSG_INPUT_DATA"].ToString();
                    _pMessageEntity.MSG_INPUT_DATA_ERROR = dtMessage.Rows[0]["MSG_INPUT_DATA_ERROR"].ToString();
                    _pMessageEntity.MSG_WORKING = dtMessage.Rows[0]["MSG_WORKING"].ToString();
                    _pMessageEntity.MSG_RESET_QUESTION = dtMessage.Rows[0]["MSG_RESET_QUESTION"].ToString();
                    _pMessageEntity.MSG_EXIT_QUESTION = dtMessage.Rows[0]["MSG_EXIT_QUESTION"].ToString();
                    _pMessageEntity.MSG_SELECT = dtMessage.Rows[0]["MSG_SELECT"].ToString();
                    _pMessageEntity.MSG_RESET_COMPLETE = dtMessage.Rows[0]["MSG_RESET_COMPLETE"].ToString();
                }

                _TempGridView = new CoFAS_DevGridManager();
                _TempGridView2 = new CoFAS_DevGridManager();

                InitializeSetting();
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
            //메인 화면 공통 메세지 처리           _아래애 MainForm지우기
            _pMSG_SEARCH = _pMessageEntity.MSG_SEARCH;
            _pMSG_SEARCH_EMPT = _pMessageEntity.MSG_SEARCH_EMPT;
            _pMSG_SAVE_QUESTION = _pMessageEntity.MSG_SAVE_QUESTION;
            _pMSG_SAVE = _pMessageEntity.MSG_SAVE;
            _pMSG_SAVE_ERROR = _pMessageEntity.MSG_SAVE_ERROR;
            _pMSG_DELETE_QUESTION = _pMessageEntity.MSG_DELETE_QUESTION;
            _pMSG_DELETE = _pMessageEntity.MSG_DELETE;
            _pMSG_DELETE_ERROR = _pMessageEntity.MSG_DELETE_ERROR;
            _pMSG_DELETE_COMPLETE = _pMessageEntity.MSG_DELETE_COMPLETE;
            _pMSG_INPUT_DATA = _pMessageEntity.MSG_INPUT_DATA;
            _pMSG_INPUT_DATA_ERROR = _pMessageEntity.MSG_INPUT_DATA_ERROR;
            _pMSG_WORKING = _pMessageEntity.MSG_WORKING;
            _pMSG_RESET_QUESTION = _pMessageEntity.MSG_RESET_QUESTION;
            _pMSG_EXIT_QUESTION = _pMessageEntity.MSG_EXIT_QUESTION;
            _pMSG_SELECT = _pMessageEntity.MSG_SELECT;
            _pMSG_RESET_COMPLETE = _pMessageEntity.MSG_RESET_COMPLETE;

            //메뉴 화면 엔티티 설정
            _pucMaterialOrderRegister_Request_T01Entity = new ucMaterialOrderRegister_Request_T01Entity();
            _pucMaterialOrderRegister_Request_T01Entity.CORP_CODE = _pCORP_CODE;
            _pucMaterialOrderRegister_Request_T01Entity.USER_CODE = _pUSER_CODE;
            _pucMaterialOrderRegister_Request_T01Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }


            //그리드 설정 ==고정==
            _gdMAIN_VIEW = _TempGridView.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
            _gdSUB_VIEW = _TempGridView2.Grid_Setting(_gdSUB, _gdSUB_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));

            _luTORDER_DATE.FromDateTime = Convert.ToDateTime("2000-01-01"); //new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
            _luTORDER_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
            _luTVEND_CODE.CodeText = "";
            _luTVEND_CODE.NameText = "";

            _pucMaterialOrderRegister_Request_T01Entity.CRUD = "R";
            MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
            
            _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
            _gdMAIN_VIEW.DoubleClick += _gdMAIN_VIEW_DoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수
            _gdSUB_VIEW.RowCellClick += _gdSUB_VIEW_RowCellClick;

        }

        public static event OnDoubleClickEventHandler _OnDoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수
        public delegate void OnDoubleClickEventHandler(object sender, EventArgs e); //그리드 로우 마우스 선택으로 값 넘길경우 필수

        private void _gdMAIN_VIEW_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                //if (_pucMaterialOrderRegister_Request_T01Entity.ORDER_ID.ToString().Equals("")) return;

                //if (_OnDoubleClick != null)
                //    _OnDoubleClick(sender, e);

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }

        }



        #region 메인그리드 로우 선택
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                

                _pucMaterialOrderRegister_Request_T01Entity.ORDER_ID = gv.GetFocusedRowCellValue("ORDER_ID").ToString();
                CoFAS_ControlManager.Controls_Binding(gv, false, this);
                SubFind_DisplayData();
                //if (gv.FocusedRowHandle < 0) return;
                //if (gv.GetFocusedRowCellValue("CRUD").ToString().Equals("Y"))
                //{
                //    gv.SetFocusedRowCellValue("CRUD", "N");
                //}
                //else
                //{
                //    gv.SetFocusedRowCellValue("CRUD", "Y");
                //}
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            //try
            //{
            //    GridView gv = sender as GridView;
            //    _pucMaterialOrderRegister_Request_T01Entity.ORDER_ID = gv.GetFocusedRowCellValue("ORDER_ID").ToString();
            //    CoFAS_ControlManager.Controls_Binding(gv, false, this);
            //    SubFind_DisplayData();
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
        }
        #endregion

        private void _gdSUB_VIEW_RowCellClick(object sender, EventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                if (gv.FocusedRowHandle < 0) return;
                if (gv.GetFocusedRowCellValue("CRUD").ToString().Equals("Y"))
                {
                    gv.SetFocusedRowCellValue("CRUD", "N");
                }
                else
                {
                    gv.SetFocusedRowCellValue("CRUD", "Y");
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pucMaterialOrderRegister_Request_T01Entity.CRUD = "R";
                _pucMaterialOrderRegister_Request_T01Entity.DATE_FROM = DateTime.Parse(_luTORDER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");
                _pucMaterialOrderRegister_Request_T01Entity.DATE_TO = DateTime.Parse(_luTORDER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");
                _pucMaterialOrderRegister_Request_T01Entity.VEND_CODE = _luTVEND_CODE.CodeText.ToString();
                _pucMaterialOrderRegister_Request_T01Entity.USE_YN = "Y";

                _dtList = new ucMaterialOrderRegister_Request_T01Business().ucMaterialOrderRegister_Request_T01_R10(_pucMaterialOrderRegister_Request_T01Entity);

                if (_pucMaterialOrderRegister_Request_T01Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pucMaterialOrderRegister_Request_T01Entity.CRUD == ""))
                {
                    _TempGridView.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                }
                if (_dtList.Rows.Count == 0)
                {
                    _TempGridView.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                //_gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 서브조회 - SubFind_DisplayData()
        private void SubFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pucMaterialOrderRegister_Request_T01Entity.CRUD = "R";

                using (DBManager pDBManager = new DBManager())
                {

                    _dtList2 = new ucMaterialOrderRegister_Request_T01Business().ucMaterialOrderRegister_Request_T01_R20(_pucMaterialOrderRegister_Request_T01Entity);

                    if (_pucMaterialOrderRegister_Request_T01Entity.CRUD == "")
                        _dtList2.Rows.Clear();

                    if (_dtList2 != null && _dtList2.Rows.Count > 0)
                    {
                        _TempGridView2.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList2); //데이터 필드에 맞춰 자동 바인딩
                    }
                    else
                    {

                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                        _dtList2.Rows.Clear();
                        _TempGridView2.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList2); //데이터 필드에 맞춰 자동 바인딩
                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                //_gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        private void _ucbtCLEAR_Click(object sender, EventArgs e)
        {
            _luTORDER_DATE.FromDateTime = Convert.ToDateTime("2000-01-01"); //new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
            _luTORDER_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
            _luTVEND_CODE.CodeText = "";
            _luTVEND_CODE.NameText = "";
            _ckALLCHECK.Checked = false;
            MainFind_DisplayData();
        }

        private void _ucbtSELECT_Click(object sender, EventArgs e)
        {
            MainFind_DisplayData();
        }
        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);
        private void _ucbtCANCLE_Click(object sender, EventArgs e)
        {
            if (_Close_Click != null)
            {
                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;
                _Close_Click(sender, e);
            }
                
        }

        #region 저장
        private void _ucbtSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt;
                dt = _gdSUB.DataSource as DataTable;

                _gdSUB_VIEW.FocusedRowHandle = -1;
                if ((CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD = 'Y'", "")))
                {
                    dtReturn = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD = 'Y'", "");
                    MM.UserForm.frmCommonPopup._DataTable = dtReturn;

                    if (_Close_Click != null)
                    {
                        _Close_Click(sender, e);
                    }
                }
                

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region 조회조건 거래처검색
        private void _luTVEND_CODE__OnOpenClick(object sender, EventArgs e)
        {
            //VendCostInfo
            frmCommonPopup.CRUD = "R";
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = fntPARENT_FONT;



            // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            frmCommonPopup.ARRAY = new object[2] { "Vend_Code_I", "" };

            //검색조건 전달 0 코드 1 명칭
            frmCommonPopup.ARRAY_CODE = new object[2] { _luTVEND_CODE.CodeText.ToString(), _luTVEND_CODE.NameText.ToString() };

            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luTVEND_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luTVEND_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

                //데이터 세팅
            }

            xfrmCommonPopup.Dispose();
        }
        #endregion

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            DataTable _dtTemp = _gdSUB.DataSource as DataTable;
            if (_dtTemp == null) return;
            if (_dtTemp.Rows.Count <= 0) return;
            for (int i = 0; i < _dtTemp.Rows.Count; i++)
            {
                _dtTemp.Rows[i]["CRUD"] = _ckALLCHECK.Checked == true ? "Y" : "N";
            }
        }
    }
}
