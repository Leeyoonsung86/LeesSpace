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
using CoFAS_MES.CORE.UserForm;
using DevExpress.XtraGrid.Columns;
using CoFAS_MES.UI.PO.Entity;
using CoFAS_MES.UI.PO.Business;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace CoFAS_MES.UI.PO.UserControls
{
    public partial class ucWorkResultPopUp_T01 : UserControl
    {
        #region ○ 기본 전역변수 영역

        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보

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
        //추가
        private string _pMSG_PLZ_CONNECT_FTP = string.Empty;    //FTP 연결을 확인해주세요.  
        private string _pMSG_AGAIN_INPUT_DATA = string.Empty;    //생산계획데이터는 다시 입력하여야 합니다  
        private string _pMSG_DOWNLOAD_COMPLETE = string.Empty;    //다운로드 되었습니다.  
        private string _pMSG_SEARCH_EMPT_DETAIL = string.Empty;    //상세 조회 내역이 없습니다.  
        private string _pMSG_SPLITQTY_LARGE_MORE = string.Empty;    //분할수량이 더 큽니다.  
        private string _pMSG_DELETE_ERROR_NO_DATA = string.Empty;    //삭제할 데이터가 없습니다.  
        private string _pMSG_ORDERQTY_LARGE_THAN_0 = string.Empty;    //발주수량이 0보다 작을 수 없습니다.  
        private string _pMSG_PLAN_LARGE_THAN_ORDER = string.Empty;    //등록할 지시수량이 계획수량보다 큽니다.  
        private string _pMSG_DELETE_ERROR_CONNECT_FTP = string.Empty;    //"삭제 처리 중 에러가 발생했습니다. FTP 연결을 확인해주세요."  
        private string _pMSG_INPUT_LESS_THAN_NOTOUTQTY = string.Empty;    //"미출고수량보다 작게 입력해주세요.미출고수량"  
        private string _pMSG_LOAD_DATA = string.Empty;    //생산계획을 불러오십시오.  
        private string _pMSG_NEW_REG_GUBN = string.Empty;    //신규등록 부분입니다.  
        private string _pMSG_INPUT_NUMERIC = string.Empty;    //숫자를 입력하시기 바랍니다.  
        private string _pMSG_NO_SELETED_ITEM = string.Empty;    //선택한 파일이 없습니다  
        private string _pMSG_EXIST_COMPANY_ID = string.Empty;    //이미 등록된 사업자등록번호 입니다.  
        private string _pMSG_NOT_DELETE_DATA_IN = string.Empty;    //생산입고 데이터는 삭제할 수 없습니다.  
        private string _pMSG_NOT_MODIFY_DATA_IN = string.Empty;    //생산입고 데이터는 수정할 수 없습니다.  
        private string _pMSG_SELECT_NEWREG_SAVE = string.Empty;    //"신규 등록을 선택하셨습니다.저장하겠습니까?"  
        private string _pMSG_INPUT_LARGER_THAN_0 = string.Empty;    //입고수량이 0보다 작을 수 없습니다.  
        private string _pMSG_NOT_DELETE_DATA_OUT = string.Empty;    //생산출고 데이터는 삭제할 수 없습니다.  
        private string _pMSG_NOT_MODIFY_DATA_OUT = string.Empty;    //생산출고 데이터는 수정할 수 없습니다.  
        private string _pMSG_CANCLE_NEWREG_MODIFY = string.Empty;    //"신규 등록을 해제하셨습니다.기존 파일을 수정하겠습니까?"  
        private string _pMSG_NO_SELETED_ITEM_OR_NO_SAVE = string.Empty;    //선택한 파일이 없거나 저장하지 않았습니다.  
        private string _pMSG_NO_INPUT_LAGER_THAN_NOTINQTY = string.Empty;    //입고 수량이 미입고 수량보다 많을 수 없습니다.  
        private string _pMSG_REG_DATA = string.Empty;    //데이터를 등록해주세요.  
        private string _pMSG_ADD_FAVORITE_ITEM = string.Empty;    //즐겨찾기에 추가 되었습니다.  
        private string _pMSG_CHECK_SEARCH_DATE = string.Empty;    //조회 일자를 확인해 주세요.  
        private string _pMSG_NOT_DISPLAY_ERROR = string.Empty;    //저장된 파일에 문제가 발생해 볼수 없습니다.  
        private string _pMSG_NO_EXIST_INPUT_DATA = string.Empty;    //입력된 조건값이 없습니다.  
        private string _pMSG_NOT_DISPLAY_NOT_SAVE = string.Empty;    //저장하지 않아서 볼 수 없습니다.  
        private string _pMSG_CHECK_VALID_ITEM = string.Empty;    //필수항목을 확인해주시기 바랍니다.  
        private string _pMSG_DELETE_FAVORITE_ITEM = string.Empty;    //즐겨찾기에서 삭제 되었습니다.  
        private string _pMSG_NOT_EXIST_PRINTING_EXCEL = string.Empty;    //해당 거래처로 저장된 인쇄용 엑셀 파일이 없습니다.  
        private string _pMSG_SELECT_DOWNLOAD_TEMPLETE = string.Empty;     //템플릿을 다운로드할 메뉴를 선택해주세요.  
        private string _pMSG_RESET_COMPLETE = string.Empty;     //초기화 하였습니다.  
        

        private static Font fntPARENT_FONT = null;       // 시스템 폰트 설정
        private ucWorkResultPopUp_T01_Entity _pucWorkResultPopUp_T01_Entity = null;
        RepositoryItemLookUpEdit pColumnType_temp = null;
        DataTable tmp_comBoBox = null;
        int select_row_index = 0;
        private DataTable _dtSub = null;
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        private string qWORK_ORDERID = string.Empty;
        private string qPART_CODE = string.Empty;
        private string qPART_NAME = string.Empty;
        private string qPROCESS_CODE = string.Empty;

        private static object[] _pARRAY = null;
        private static object[] _pARRAY_CODE = null;

        #endregion
        private static string _pPROCESS_NAME = string.Empty;   // 시스템 언어
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

        public static string PROCESS_NAME
        {
            get { return _pPROCESS_NAME; }
            set { _pPROCESS_NAME = value; }
        }

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtreturn = null; // 선택 데이터 리턴

        #region ○ 생성자 영역

        public ucWorkResultPopUp_T01()
        {
            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();
        }

        #endregion

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

        #region ○ 폼 로드 이벤트
        private void ucWorkResultPopUp_T01_Load(object sender, EventArgs e)
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

                    //추가
                    _pMessageEntity.MSG_PLZ_CONNECT_FTP = dtMessage.Rows[0]["MSG_PLZ_CONNECT_FTP"].ToString();
                    _pMessageEntity.MSG_AGAIN_INPUT_DATA = dtMessage.Rows[0]["MSG_AGAIN_INPUT_DATA"].ToString();
                    _pMessageEntity.MSG_DOWNLOAD_COMPLETE = dtMessage.Rows[0]["MSG_DOWNLOAD_COMPLETE"].ToString();
                    _pMessageEntity.MSG_SEARCH_EMPT_DETAIL = dtMessage.Rows[0]["MSG_SEARCH_EMPT_DETAIL"].ToString();
                    _pMessageEntity.MSG_SPLITQTY_LARGE_MORE = dtMessage.Rows[0]["MSG_SPLITQTY_LARGE_MORE"].ToString();
                    _pMessageEntity.MSG_DELETE_ERROR_NO_DATA = dtMessage.Rows[0]["MSG_DELETE_ERROR_NO_DATA"].ToString();
                    _pMessageEntity.MSG_ORDERQTY_LARGE_THAN_0 = dtMessage.Rows[0]["MSG_ORDERQTY_LARGE_THAN_0"].ToString();
                    _pMessageEntity.MSG_PLAN_LARGE_THAN_ORDER = dtMessage.Rows[0]["MSG_PLAN_LARGE_THAN_ORDER"].ToString();
                    _pMessageEntity.MSG_DELETE_ERROR_CONNECT_FTP = dtMessage.Rows[0]["MSG_DELETE_ERROR_CONNECT_FTP"].ToString();
                    _pMessageEntity.MSG_INPUT_LESS_THAN_NOTOUTQTY = dtMessage.Rows[0]["MSG_INPUT_LESS_THAN_NOTOUTQTY"].ToString();
                    _pMessageEntity.MSG_LOAD_DATA = dtMessage.Rows[0]["MSG_LOAD_DATA"].ToString();
                    _pMessageEntity.MSG_NEW_REG_GUBN = dtMessage.Rows[0]["MSG_NEW_REG_GUBN"].ToString();
                    _pMessageEntity.MSG_INPUT_NUMERIC = dtMessage.Rows[0]["MSG_INPUT_NUMERIC"].ToString();
                    _pMessageEntity.MSG_NO_SELETED_ITEM = dtMessage.Rows[0]["MSG_NO_SELETED_ITEM"].ToString();
                    _pMessageEntity.MSG_EXIST_COMPANY_ID = dtMessage.Rows[0]["MSG_EXIST_COMPANY_ID"].ToString();
                    _pMessageEntity.MSG_NOT_DELETE_DATA_IN = dtMessage.Rows[0]["MSG_NOT_DELETE_DATA_IN"].ToString();
                    _pMessageEntity.MSG_NOT_MODIFY_DATA_IN = dtMessage.Rows[0]["MSG_NOT_MODIFY_DATA_IN"].ToString();
                    _pMessageEntity.MSG_SELECT_NEWREG_SAVE = dtMessage.Rows[0]["MSG_SELECT_NEWREG_SAVE"].ToString();
                    _pMessageEntity.MSG_INPUT_LARGER_THAN_0 = dtMessage.Rows[0]["MSG_INPUT_LARGER_THAN_0"].ToString();
                    _pMessageEntity.MSG_NOT_DELETE_DATA_OUT = dtMessage.Rows[0]["MSG_NOT_DELETE_DATA_OUT"].ToString();
                    _pMessageEntity.MSG_NOT_MODIFY_DATA_OUT = dtMessage.Rows[0]["MSG_NOT_MODIFY_DATA_OUT"].ToString();
                    _pMessageEntity.MSG_CANCLE_NEWREG_MODIFY = dtMessage.Rows[0]["MSG_CANCLE_NEWREG_MODIFY"].ToString();
                    _pMessageEntity.MSG_NO_SELETED_ITEM_OR_NO_SAVE = dtMessage.Rows[0]["MSG_NO_SELETED_ITEM_OR_NO_SAVE"].ToString();
                    _pMessageEntity.MSG_NO_INPUT_LAGER_THAN_NOTINQTY = dtMessage.Rows[0]["MSG_NO_INPUT_LAGER_THAN_NOTINQTY"].ToString();
                    _pMessageEntity.MSG_REG_DATA = dtMessage.Rows[0]["MSG_REG_DATA"].ToString();
                    _pMessageEntity.MSG_ADD_FAVORITE_ITEM = dtMessage.Rows[0]["MSG_ADD_FAVORITE_ITEM"].ToString();
                    _pMessageEntity.MSG_CHECK_SEARCH_DATE = dtMessage.Rows[0]["MSG_CHECK_SEARCH_DATE"].ToString();
                    _pMessageEntity.MSG_NOT_DISPLAY_ERROR = dtMessage.Rows[0]["MSG_NOT_DISPLAY_ERROR"].ToString();
                    _pMessageEntity.MSG_NO_EXIST_INPUT_DATA = dtMessage.Rows[0]["MSG_NO_EXIST_INPUT_DATA"].ToString();
                    _pMessageEntity.MSG_NOT_DISPLAY_NOT_SAVE = dtMessage.Rows[0]["MSG_NOT_DISPLAY_NOT_SAVE"].ToString();
                    _pMessageEntity.MSG_CHECK_VALID_ITEM = dtMessage.Rows[0]["MSG_CHECK_VALID_ITEM"].ToString();
                    _pMessageEntity.MSG_DELETE_FAVORITE_ITEM = dtMessage.Rows[0]["MSG_DELETE_FAVORITE_ITEM"].ToString();
                    _pMessageEntity.MSG_NOT_EXIST_PRINTING_EXCEL = dtMessage.Rows[0]["MSG_NOT_EXIST_PRINTING_EXCEL"].ToString();
                    _pMessageEntity.MSG_SELECT_DOWNLOAD_TEMPLETE = dtMessage.Rows[0]["MSG_SELECT_DOWNLOAD_TEMPLETE"].ToString();
                    _pMessageEntity.MSG_RESET_COMPLETE = dtMessage.Rows[0]["MSG_RESET_COMPLETE"].ToString();
                }

                _pucWorkResultPopUp_T01_Entity = new ucWorkResultPopUp_T01_Entity();
                _pucWorkResultPopUp_T01_Entity.CORP_CODE = _pCORP_CODE;
                _pucWorkResultPopUp_T01_Entity.USER_CODE = _pUSER_CODE;
                _pucWorkResultPopUp_T01_Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

                qWORK_ORDERID = _pARRAY_CODE[0].ToString();
                qPART_CODE = _pARRAY_CODE[1].ToString();
                qPART_NAME = _pARRAY_CODE[2].ToString();
                qPROCESS_CODE = _pARRAY_CODE[3].ToString();

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

        #endregion

        #region ○ InitializeSetting()

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
            //추가
            _pMSG_PLZ_CONNECT_FTP = _pMessageEntity.MSG_PLZ_CONNECT_FTP;
            _pMSG_AGAIN_INPUT_DATA = _pMessageEntity.MSG_AGAIN_INPUT_DATA;
            _pMSG_DOWNLOAD_COMPLETE = _pMessageEntity.MSG_DOWNLOAD_COMPLETE;
            _pMSG_SEARCH_EMPT_DETAIL = _pMessageEntity.MSG_SEARCH_EMPT_DETAIL;
            _pMSG_SPLITQTY_LARGE_MORE = _pMessageEntity.MSG_SPLITQTY_LARGE_MORE;
            _pMSG_DELETE_ERROR_NO_DATA = _pMessageEntity.MSG_DELETE_ERROR_NO_DATA;
            _pMSG_ORDERQTY_LARGE_THAN_0 = _pMessageEntity.MSG_ORDERQTY_LARGE_THAN_0;
            _pMSG_PLAN_LARGE_THAN_ORDER = _pMessageEntity.MSG_PLAN_LARGE_THAN_ORDER;
            _pMSG_DELETE_ERROR_CONNECT_FTP = _pMessageEntity.MSG_DELETE_ERROR_CONNECT_FTP;
            _pMSG_INPUT_LESS_THAN_NOTOUTQTY = _pMessageEntity.MSG_INPUT_LESS_THAN_NOTOUTQTY;
            _pMSG_LOAD_DATA = _pMessageEntity.MSG_LOAD_DATA;
            _pMSG_NEW_REG_GUBN = _pMessageEntity.MSG_NEW_REG_GUBN;
            _pMSG_INPUT_NUMERIC = _pMessageEntity.MSG_INPUT_NUMERIC;
            _pMSG_NO_SELETED_ITEM = _pMessageEntity.MSG_NO_SELETED_ITEM;
            _pMSG_EXIST_COMPANY_ID = _pMessageEntity.MSG_EXIST_COMPANY_ID;
            _pMSG_NOT_DELETE_DATA_IN = _pMessageEntity.MSG_NOT_DELETE_DATA_IN;
            _pMSG_NOT_MODIFY_DATA_IN = _pMessageEntity.MSG_NOT_MODIFY_DATA_IN;
            _pMSG_SELECT_NEWREG_SAVE = _pMessageEntity.MSG_SELECT_NEWREG_SAVE;
            _pMSG_INPUT_LARGER_THAN_0 = _pMessageEntity.MSG_INPUT_LARGER_THAN_0;
            _pMSG_NOT_DELETE_DATA_OUT = _pMessageEntity.MSG_NOT_DELETE_DATA_OUT;
            _pMSG_NOT_MODIFY_DATA_OUT = _pMessageEntity.MSG_NOT_MODIFY_DATA_OUT;
            _pMSG_CANCLE_NEWREG_MODIFY = _pMessageEntity.MSG_CANCLE_NEWREG_MODIFY;
            _pMSG_NO_SELETED_ITEM_OR_NO_SAVE = _pMessageEntity.MSG_NO_SELETED_ITEM_OR_NO_SAVE;
            _pMSG_NO_INPUT_LAGER_THAN_NOTINQTY = _pMessageEntity.MSG_NO_INPUT_LAGER_THAN_NOTINQTY;
            _pMSG_REG_DATA = _pMessageEntity.MSG_REG_DATA;
            _pMSG_ADD_FAVORITE_ITEM = _pMessageEntity.MSG_ADD_FAVORITE_ITEM;
            _pMSG_CHECK_SEARCH_DATE = _pMessageEntity.MSG_CHECK_SEARCH_DATE;
            _pMSG_NOT_DISPLAY_ERROR = _pMessageEntity.MSG_NOT_DISPLAY_ERROR;
            _pMSG_NO_EXIST_INPUT_DATA = _pMessageEntity.MSG_NO_EXIST_INPUT_DATA;
            _pMSG_NOT_DISPLAY_NOT_SAVE = _pMessageEntity.MSG_NOT_DISPLAY_NOT_SAVE;
            _pMSG_CHECK_VALID_ITEM = _pMessageEntity.MSG_CHECK_VALID_ITEM;
            _pMSG_DELETE_FAVORITE_ITEM = _pMessageEntity.MSG_DELETE_FAVORITE_ITEM;
            _pMSG_NOT_EXIST_PRINTING_EXCEL = _pMessageEntity.MSG_NOT_EXIST_PRINTING_EXCEL;
            _pMSG_SELECT_DOWNLOAD_TEMPLETE = _pMessageEntity.MSG_SELECT_DOWNLOAD_TEMPLETE;
            _pMSG_RESET_COMPLETE = _pMessageEntity.MSG_RESET_COMPLETE;


            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }

            InitializeControl();

            if (_pFirstYN)
            {

                tmp_comBoBox = new DataTable();

                string pParameterData = "BAD_CODE;;;";
                string[] strParameterData = new string[pParameterData.Count(f => f == ';')];
                strParameterData = pParameterData.Split(';');
                tmp_comBoBox= new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, strParameterData[0].ToString(), strParameterData[1].ToString(), strParameterData[2].ToString(), strParameterData[3].ToString()).Tables[0];
                _pFirstYN = false;
            }

            _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));

           // _gdMAIN_VIEW.CellValueChanged += _gdMAIN_VIEW_CellValueChanged;
           // _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
           // _gdMAIN_VIEW.CustomRowCellEdit += _gdMAIN_VIEW_CustomRowCellEdit;
            _gdMAIN_VIEW.ShownEditor += _gdMAIN_VIEW_ShownEditor;
           // _gdMAIN_VIEW.CellValueChanging += _gdMAIN_VIEW_CellValueChanging;
            //_pCRUD = "";


            // MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

        }

        private void _gdMAIN_VIEW_ShownEditor(object sender, EventArgs e)
        {
            ColumnView view = (ColumnView)sender;
            int qRowIndex = view.FocusedRowHandle;

            string select_bad_group = view.GetRowCellValue(qRowIndex, "BAD_GROUP").ToString();
            if (view.FocusedColumn.FieldName == "BAD_CODE" && view.ActiveEditor is LookUpEdit)
           {
               LookUpEdit edit = (LookUpEdit)view.ActiveEditor;
                if(select_bad_group=="")
                {
                    DataTable empty_table = new DataTable();
                    DataRow row = null;

                    empty_table.Columns.Add(new DataColumn("CD", typeof(string)));
                    empty_table.Columns.Add(new DataColumn("CD_NM", typeof(string)));

                    row = empty_table.NewRow();

                    row["CD"] = "";
                    row["CD_NM"] = "";

                    empty_table.Rows.Add(row);
                    edit.Properties.DataSource = empty_table;
                    edit.Properties.DropDownRows = empty_table.Rows.Count;
                }
                else
                {
                    DataTable tmp = tmp_comBoBox.Select("CD like'" + select_bad_group + "%'").CopyToDataTable();
                    edit.Properties.DataSource = tmp;
                    edit.Properties.DropDownRows = tmp.Rows.Count;
                }
                edit.Properties.ShowHeader = false;
                edit.Properties.ShowFooter = false;
                view.ShowEditor();
                view.GetFocusedDataRow().EndEdit();
               

            }

        }




        #endregion

        #region ○ InitializeControl()

        private void InitializeControl()
        {
            try
            {


                _luRESULT_GUBN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "RESULT_REG_NO_STATUS", "", "", "").Tables[0], 0, 0, "", false);
               // _luPROCESS_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "WORKCENTER", "", "", "").Tables[0], 0, 0, "", false);
               // _luPROCESS_CODE.ReadOnly = true;
                _luBAD_GROUP.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "POP_BAD1_CODE", "", "", "").Tables[0], 0, 0, "", false);
                _luSTATUS_GROUP.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "POP_STOP1_CODE_T01", "", "", "").Tables[0], 0, 0, "", false);

                _luWORKORDERID.Text = qWORK_ORDERID;
                _luPART_CODE.Text = qPART_CODE;
                _luPART_NAME.Text = qPART_NAME;
               // _luPROCESS_CODE.SetValue(qPROCESS_CODE);
                _luRESULT_QTY.Text = "0";
                _luSTATUS_TIME.Text = "";
                _luSTATUS_TIME.UseMaskAsDisplayFormat = true;
                _luSTATUS_TIME.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                _luSTATUS_TIME.EditMask = "\\d\\d\\d\\d-\\d\\d-\\d\\d / \\d\\d:\\d\\d:\\d\\d";
                //제조 포장에 따라 다름
                //PC01 / PT040001 : 제조
                //PC03 / PT040002 : 포장
                //if ((_pWorkResultRegister_T01Entity.PROCESS_CODE_MST == "PC03") || _pWorkResultRegister_T01Entity.PROCESS_CODE_MST == "PT040002")

                //제조
                if ((_pPROCESS_NAME == "PC01")||(_pPROCESS_NAME == "PT040001"))
                {
                    // _gdMAIN.Visible = false;
                    //_gdMAIN.Visible = false;
                    layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    
                }
                else
                {

                }
                }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _gdMAIN_VIEW_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //throw new NotImplementedException();
            GridView gv = sender as GridView;

            int qRowIndex = gv.FocusedRowHandle;
            string qColumnHeader = e.Column.Caption;

            string select_bad_group = gv.GetRowCellValue(qRowIndex, "BAD_GROUP").ToString();
            RepositoryItemLookUpEdit pColumnType = new RepositoryItemLookUpEdit();


            string pParameterData = "BAD_CODE;" + select_bad_group + ";;";

            string[] strParameterData = new string[pParameterData.Count(f => f == ';')];
            if (qColumnHeader == "BAD_GROUP")
            {

                if (pParameterData.IndexOf(';') != -1)
                {
                    strParameterData = pParameterData.Split(';');

                    DataTable dtComboBox = new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, strParameterData[0].ToString(), strParameterData[1].ToString(), strParameterData[2].ToString(), strParameterData[3].ToString()).Tables[0];

                    if (dtComboBox != null)
                    {
                        pColumnType.DataSource = dtComboBox;
                        pColumnType.ValueMember = "CD";
                        pColumnType.DisplayMember = "CD_NM";

                        pColumnType.BestFitMode = BestFitMode.BestFitResizePopup;
                        pColumnType.ShowHeader = false;
                        //pColumnType.SearchMode = SearchMode.AutoFilter;
                        pColumnType.ShowFooter = false;
                        if (strParameterData[2].ToString() != "")
                        {
                            pColumnType.DropDownRows = Convert.ToInt32(strParameterData[2].ToString());
                        }
                        else
                        {
                            pColumnType.DropDownRows = dtComboBox.Rows.Count;
                        }
                    }

                }
                pColumnType.NullText = "";
                //pGridColumn.ColumnEdit = pColumnType;
                gv.SetRowCellValue(qRowIndex, "BAD_CODE", pColumnType);
            }
        }

        #endregion
        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pucWorkResultPopUp_T01_Entity.CRUD = "R";
                _pucWorkResultPopUp_T01_Entity.PART_CODE = qPART_CODE;

                _dtList =  new ucWorkResultPopUp_T01Business().ucWorkResultPopUp_T01_Info(_pucWorkResultPopUp_T01_Entity);

                if (_pucWorkResultPopUp_T01_Entity.CRUD == "")
                    _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pucWorkResultPopUp_T01_Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                }
                else
                {

                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtList.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
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
        #region ○ LookupEdit ValueChanged event

        private void _luBAD_GROUP_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _luBAD_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "POP_BAD2_CODE", _luBAD_GROUP.GetValue(), "", "").Tables[0], 0, 0, "", false);
            }
            catch(ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _luSTATUS_GROUP_ValueChanged(object pSender, EventArgs pEventArgs)
        {
            try
            {
                _luSTATUS_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "POP_STOP2_CODE", _luSTATUS_GROUP.GetValue(), "", "").Tables[0], 0, 0, "", false);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _luRESULT_GUBN_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string pResult_Gubn = _luRESULT_GUBN.GetDisplayName();
                //제조 포장에 따라 다름
                //PC01 / PT040001 : 제조
                //PC03 / PT040002 : 포장
                //if ((_pWorkResultRegister_T01Entity.PROCESS_CODE_MST == "PC03") || _pWorkResultRegister_T01Entity.PROCESS_CODE_MST == "PT040002")

                //포장
                if ((_pPROCESS_NAME == "PC03") |(_pPROCESS_NAME == "PT040002"))
                {
                    // _gdMAIN.Visible = false;
                 //   _gdMAIN.IsVisibleView = false;
                    switch (pResult_Gubn)
                    {
                        case "양품실적":
                            _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                            _lciBAD_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciBAD_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_TIME.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _luRESULT_QTY.ReadOnly = false;
                            _gdMAIN.Enabled = false;
                            break;
                        case "불량실적":
                            _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                            _lciBAD_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciBAD_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_TIME.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _luRESULT_QTY.ReadOnly = true;
                            _gdMAIN.Enabled = true;
                            MainFind_DisplayData();
                            break;
                        case "상태":
                            _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciBAD_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciBAD_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                            _lciSTATUS_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                            _lciSTATUS_TIME.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            break;
                        case "이월":
                            _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                            _lciBAD_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciBAD_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_TIME.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _gdMAIN.Enabled = false;
                            break;
                    }
                }
                else
                {
                    switch (pResult_Gubn)
                    {
                        case "양품실적":
                            _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                            _lciBAD_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciBAD_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_TIME.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _btSAVE.Enabled = true;
                            _luRESULT_QTY.ReadOnly = false;
                            break;
                        case "불량실적":
                            _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                            _lciBAD_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciBAD_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_TIME.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _btSAVE.Enabled = false;
                            _luRESULT_QTY.ReadOnly = true;
                            break;
                        case "상태":
                            _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciBAD_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciBAD_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                            _lciSTATUS_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                            _lciSTATUS_TIME.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _btSAVE.Enabled = true;
                            break;
                        case "이월":
                            _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                            _lciBAD_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciBAD_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciSTATUS_TIME.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            _gdMAIN.Enabled = false;
                            break;
                    }
                }
            }catch(ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);
        private void _btCancle_Click(object sender, EventArgs e)
        {
            if (_Close_Click != null)
                _Close_Click(sender, e);
        }

        private void _btSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                //DialogResult pDialogResult = CoFAS_DevExpressManager.ShowQuestionMessage("실적을 저장하시겠습니까?");
                DialogResult pDialogResult = CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION);

                if (pDialogResult == DialogResult.Yes)
                {
                    _pucWorkResultPopUp_T01_Entity.RESOURCE_CODE = "";// _luPROCESS_CODE.GetValue();
                    _pucWorkResultPopUp_T01_Entity.COLLECTION_DATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    _pucWorkResultPopUp_T01_Entity.PROPERTY_VALUE = _luWORKORDERID.Text;

                    switch (_luRESULT_GUBN.GetValue().ToString())
                    {
                        case "CD501001":
                            _pucWorkResultPopUp_T01_Entity.CONDITION_CODE = _luRESULT_GUBN.GetValue();
                            _pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE = _luRESULT_QTY.Text.Replace(",", "");
                            //_pucWorkResultPopUp_T01_Entity.CONDITION_CODE = "CD501001";
                            break;
                        case "CD501002":
                            _pucWorkResultPopUp_T01_Entity.CONDITION_CODE = _luBAD_CODE.GetValue();
                            _pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE = _luRESULT_QTY.Text.Replace(",", "");
                            break;
                        case "CD501003":
                            _pucWorkResultPopUp_T01_Entity.CONDITION_CODE = _luSTATUS_CODE.GetValue();
                            DateTime pDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                            if(_luSTATUS_TIME.Text=="")
                            {
                                _pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE = "201811101514";
                            }
                            else
                            {
                                TimeSpan pTimeSpan = Convert.ToDateTime(_luSTATUS_TIME.Text.Replace("/ ", "")) - pDateTime;
                                _pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE = pTimeSpan.TotalSeconds.ToString(); // Math.Floor(pTimeSpan.TotalSeconds).ToString(); // _luSTATUS_TIME.Text.Replace("-", "").Replace(" / ", "").Replace(":", "");
                            }
                            
                            break;
                    }

                    //if (_luRESULT_GUBN.GetValue().ToString() == "CD501001")
                    //{
                    //    _pucWorkResultPopUp_T01_Entity.CONDITION_CODE = _luRESULT_GUBN.GetValue();
                    //    //_pucWorkResultPopUp_T01_Entity.CONDITION_CODE = "CD501001";
                    //}
                    //else if(_luRESULT_GUBN.GetValue().ToString() == "CD501002")
                    //{
                    //    _pucWorkResultPopUp_T01_Entity.CONDITION_CODE = _luBAD_CODE.GetValue();
                    //}
                    //else if(_luRESULT_GUBN.GetValue().ToString() == "CD501003")
                    //{

                    //}
                    //제조 포장에 따라 다름
                    //PC01 / PT040001 : 제조
                    //PC03 / PT040002 : 포장
                    //if ((_pWorkResultRegister_T01Entity.PROCESS_CODE_MST == "PC03") || _pWorkResultRegister_T01Entity.PROCESS_CODE_MST == "PT040002")

                    //이월일경우
                    if (_luRESULT_GUBN.GetValue().ToString() == "PO011004")
                    {
                        _pucWorkResultPopUp_T01_Entity.CRUD = "U";
                        _pucWorkResultPopUp_T01_Entity.PRODUCTION_ORDER_ID = _pucWorkResultPopUp_T01_Entity.PROPERTY_VALUE;
                        _pucWorkResultPopUp_T01_Entity.COMPLETE_YN = "P";

                        bool isError = false;

                        isError = new ucWorkResultPopUp_T01Business().usWorkResultPopup_Save_02(_pucWorkResultPopUp_T01_Entity);

                        if (!isError)
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                        else
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                        //제조실적등록 : 양품
                        //반제품입고
                        _Close_Click(null, null);
                    }
                    else
                    {
                        //포장
                        if ((_pPROCESS_NAME == "PC03") || (_pPROCESS_NAME == "PT040002"))
                        {
                            //포장일경우 저장 프로시져


                            DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;

                            //포장에서 양품실적은 제품으로
                            _pucWorkResultPopUp_T01_Entity.PART_CODE = _luPART_CODE.Text;
                            bool isError = false;


                            //1. data_collection에 실적 등록함(불량/양품)
                            if (_luRESULT_GUBN.GetValue().ToString() == "CD501002")//불량등록 일경우
                                isError = new ucWorkResultPopUp_T01Business().ucWorkResultPopUp_T01_Save_2(_pucWorkResultPopUp_T01_Entity, tDataTable);
                            //else//불량등록 아닐경우
                            //양품일경우
                            if (_luRESULT_GUBN.GetValue().ToString() == "CD501001")//양품등록 일경우
                                isError = new ucWorkResultPopUp_T01Business().ucWorkResultPopUp_T01_Save(_pucWorkResultPopUp_T01_Entity);
                            /////////////////////


                            //////////////
                            if (!isError)
                            {
                                // CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                // 상태 - 완료 코드 입력시 
                                // 작업지시테이블에 업데이트 하기 완료여부 플래그
                                //작업완료일경우
                                if (_luRESULT_GUBN.GetValue().ToString() == "CD501003" && _pucWorkResultPopUp_T01_Entity.CONDITION_CODE == "ES011003")
                                {
                                    _pucWorkResultPopUp_T01_Entity.CRUD = "U";
                                    _pucWorkResultPopUp_T01_Entity.PRODUCTION_ORDER_ID = _pucWorkResultPopUp_T01_Entity.PROPERTY_VALUE;
                                    _pucWorkResultPopUp_T01_Entity.COMPLETE_YN = "Y";

                                    isError = new ucWorkResultPopUp_T01Business().usWorkResultPopup_Save_01(_pucWorkResultPopUp_T01_Entity);

                                    if (!isError)
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                    else
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);

                                }//포장등록 : 
                                 //제품입고(반제품출고, 부자재 출고)
                                else
                                {
                                    //semi_mate_out_p_in : 반제품출고, 부자재출고,제품입고
                                    _pucWorkResultPopUp_T01_Entity.CRUD = "semi_mate_out_p_in";

                                    _pucWorkResultPopUp_T01_Entity.INOUT_TYPE = "O";
                                    _pucWorkResultPopUp_T01_Entity.INOUT_ID = "";
                                    _pucWorkResultPopUp_T01_Entity.INOUT_DATE = DateTime.Now.ToString("yyyyMMdd");// _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                                    _pucWorkResultPopUp_T01_Entity.INOUT_SEQ = "000000";
                                    _pucWorkResultPopUp_T01_Entity.INOUT_CODE = "PD040020"; //  PD040020 = 생산출고 INOUT_CODE -> TYPE
                                    _pucWorkResultPopUp_T01_Entity.VEND_CODE = "V00000";
                                    _pucWorkResultPopUp_T01_Entity.PART_CODE = _luPART_CODE.Text;
                                    _pucWorkResultPopUp_T01_Entity.INOUT_QTY = _luRESULT_QTY.Text.Replace(",", "").ToString() == "" ? "0" : _luRESULT_QTY.Text.Replace(",", "").ToString();
                                    _pucWorkResultPopUp_T01_Entity.PART_UNIT = "";// _luUNIT_CODE.GetValue();
                                    _pucWorkResultPopUp_T01_Entity.UNITCOST = "0";// _luUNITCOST.Text.ToString() == "" ? "0" : _luUNITCOST.Text.ToString().ToString();
                                    _pucWorkResultPopUp_T01_Entity.COST = "0";// _luCOST.Text.ToString() == "" ? "0" : _luCOST.Text.ToString().ToString();
                                    _pucWorkResultPopUp_T01_Entity.REFERENCE_ID = _luWORKORDERID.Text.ToString();   //포장지시번호로 BOM에서 떨구기
                                    _pucWorkResultPopUp_T01_Entity.REMARK = "";// _luREMARK.Text.ToString();
                                    _pucWorkResultPopUp_T01_Entity.USE_YN = "Y";// _luUSE_YN.GetValue();

                                    isError = new ucWorkResultPopUp_T01Business().ucWorkResultPopup_T01_Info_Save(_pucWorkResultPopUp_T01_Entity);
                                    if (!isError)
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                    else
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);

                                }

                                _Close_Click(null, null);
                            }
                            else
                            {
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                            }
                        }
                        //////////////////////////////////////////
                        //제조
                        //////////////////////////////////////////
                        else
                        {
                            //제조일경우 저장 프로시져
                            _pucWorkResultPopUp_T01_Entity.PART_CODE = _luPART_CODE.Text;

                            bool isError = false;
                            //설비 상태는 data collection 안탐
                            if (_luRESULT_GUBN.GetValue().ToString() == "CD501003" && _pucWorkResultPopUp_T01_Entity.CONDITION_CODE == "ES011003")
                            {

                            }
                            //불량/양품  실적저장
                            else
                            {
                                if (_luRESULT_GUBN.GetValue().ToString() == "CD501002")//불량등록 일경우
                                {

                                }
                                else
                                    isError = new ucWorkResultPopUp_T01Business().ucWorkResultPopUp_T01_Save(_pucWorkResultPopUp_T01_Entity);
                            }

                            if (!isError)
                            {
                                // CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                // 상태 - 완료 코드 입력시 
                                // 작업지시테이블에 업데이트 하기 완료여부 플래그
                                if (_luRESULT_GUBN.GetValue().ToString() == "CD501003" && _pucWorkResultPopUp_T01_Entity.CONDITION_CODE == "ES011003")
                                {
                                    _pucWorkResultPopUp_T01_Entity.CRUD = "U";
                                    _pucWorkResultPopUp_T01_Entity.PRODUCTION_ORDER_ID = _pucWorkResultPopUp_T01_Entity.PROPERTY_VALUE;
                                    _pucWorkResultPopUp_T01_Entity.COMPLETE_YN = "Y";

                                    isError = new ucWorkResultPopUp_T01Business().usWorkResultPopup_Save_01(_pucWorkResultPopUp_T01_Entity);

                                    if (!isError)
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                    else
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                                }


                                //제조실적등록 : 양품
                                //반제품입고
                                //시험검사후 통과된것만 입고하기 때문에 재고 감소는 없음
                                else
                                {
                                    //semi_in : 반제품입고
                                    _pucWorkResultPopUp_T01_Entity.CRUD = "semi_in";

                                    _pucWorkResultPopUp_T01_Entity.INOUT_TYPE = "I";
                                    _pucWorkResultPopUp_T01_Entity.INOUT_ID = "";
                                    _pucWorkResultPopUp_T01_Entity.INOUT_DATE = DateTime.Now.ToString("yyyyMMdd");// _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                                    _pucWorkResultPopUp_T01_Entity.INOUT_SEQ = "000000";
                                    _pucWorkResultPopUp_T01_Entity.INOUT_CODE = "PD031014"; //  PD031014 = 생산입고 INOUT_CODE -> TYPE
                                    _pucWorkResultPopUp_T01_Entity.VEND_CODE = "V00000";
                                    _pucWorkResultPopUp_T01_Entity.PART_CODE = _luPART_CODE.Text;
                                    _pucWorkResultPopUp_T01_Entity.INOUT_QTY = _luRESULT_QTY.Text.Replace(",", "").ToString() == "" ? "0" : _luRESULT_QTY.Text.Replace(",", "").ToString();
                                    _pucWorkResultPopUp_T01_Entity.PART_UNIT = "";// _luUNIT_CODE.GetValue();
                                    _pucWorkResultPopUp_T01_Entity.UNITCOST = "0";// _luUNITCOST.Text.ToString() == "" ? "0" : _luUNITCOST.Text.ToString().ToString();
                                    _pucWorkResultPopUp_T01_Entity.COST = "0";// _luCOST.Text.ToString() == "" ? "0" : _luCOST.Text.ToString().ToString();
                                    _pucWorkResultPopUp_T01_Entity.REFERENCE_ID = _luWORKORDERID.Text.ToString();
                                    _pucWorkResultPopUp_T01_Entity.REMARK = "";// _luREMARK.Text.ToString();
                                    _pucWorkResultPopUp_T01_Entity.USE_YN = "Y";// _luUSE_YN.GetValue();

                                    isError = new ucWorkResultPopUp_T01Business().ucWorkResultPopup_T01_Info_Save(_pucWorkResultPopUp_T01_Entity);
                                    if (!isError)
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                    else
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                                }
                                //제조실적등록 : 양품
                                //반제품입고
                                _Close_Click(null, null);
                            }
                            else
                            {
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                            }
                        }
                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _luRESULT_QTY__OnKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && (int)e.KeyChar != 45)
                {
                    e.Handled = true;
                    //CoFAS_DevExpressManager.ShowInformationMessage("숫자를 입력하시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_NUMERIC);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        //불량그룹 변경
        private void _gdMAIN_VIEW_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {



            /*
                GridView gv = sender as GridView;

                int qRowIndex = gv.FocusedRowHandle;
                string qColumnHeader = e.Column.Caption;
                e.Column.GetCaption();
                string select_bad_group= gv.GetRowCellValue(qRowIndex, "BAD_GROUP").ToString();
                RepositoryItemLookUpEdit pColumnType = new RepositoryItemLookUpEdit();
                pColumnType_temp = new RepositoryItemLookUpEdit();


                string pParameterData = "BAD_CODE;"+select_bad_group+";;";

                string[] strParameterData = new string[pParameterData.Count(f => f == ';')];
                if (gv.FocusedColumn.Name == "BAD_GROUP")
                {

                if (pParameterData.IndexOf(';') != -1)
                {
                    strParameterData = pParameterData.Split(';');

                    DataTable dtComboBox = new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, strParameterData[0].ToString(), strParameterData[1].ToString(), strParameterData[2].ToString(), strParameterData[3].ToString()).Tables[0];

                    if (dtComboBox != null)
                    {
                        pColumnType.DataSource = dtComboBox;
                        pColumnType.ValueMember = "CD";
                        pColumnType.DisplayMember = "CD_NM";

                        pColumnType.BestFitMode = BestFitMode.BestFitResizePopup;
                        pColumnType.ShowHeader = false;
                        //pColumnType.SearchMode = SearchMode.AutoFilter;
                        pColumnType.ShowFooter = false;
                        if (strParameterData[2].ToString() != "")
                        {
                            pColumnType.DropDownRows = Convert.ToInt32(strParameterData[2].ToString());
                        }
                        else
                        {
                            pColumnType.DropDownRows = dtComboBox.Rows.Count;
                        }
                    }

                }
                    pColumnType.NullText = "";
                    pColumnType_temp = pColumnType;
                    //pGridColumn.ColumnEdit = pColumnType;
                   // gv.SetRowCellValue(qRowIndex, "BAD_CODE", pColumnType);
                    //gv.data
                   // gv.SelectCell.=pColumnType;
                    gv.Columns["BAD_CODE"].ColumnEdit = pColumnType;
                }

                //pColumnType.AllowNullInput = DefaultBoolean.True;

                */

            GridView gv = sender as GridView;
            RepositoryItemLookUpEdit pColumnType = new RepositoryItemLookUpEdit();

            int qRowIndex = gv.FocusedRowHandle;
            string select_bad_group = gv.GetRowCellValue(qRowIndex, "BAD_GROUP").ToString();
            string pParameterData = "BAD_CODE;" + select_bad_group + ";;";

            string[] strParameterData = new string[pParameterData.Count(f => f == ';')];
            if (gv.FocusedColumn.Name == "BAD_GROUP")
            {

                if (pParameterData.IndexOf(';') != -1)
                {
                    strParameterData = pParameterData.Split(';');
                }
                    DataTable dtComboBox = new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, strParameterData[0].ToString(), strParameterData[1].ToString(), strParameterData[2].ToString(), strParameterData[3].ToString()).Tables[0];

                if (dtComboBox != null)
                {
                    pColumnType.DataSource = dtComboBox;
                    pColumnType.ValueMember = "CD";
                    pColumnType.DisplayMember = "CD_NM";

                    pColumnType.BestFitMode = BestFitMode.BestFitResizePopup;
                    pColumnType.ShowHeader = false;
                    //pColumnType.SearchMode = SearchMode.AutoFilter;
                    pColumnType.ShowFooter = false;
                    if (strParameterData[2].ToString() != "")
                    {
                        pColumnType.DropDownRows = Convert.ToInt32(strParameterData[2].ToString());
                    }
                    else
                    {
                        pColumnType.DropDownRows = dtComboBox.Rows.Count;
                    }
                }

                tmp_comBoBox = dtComboBox;
                pColumnType_temp = pColumnType;
                // gv.getfocus
                var edit = (LookUpEdit)gv.ActiveEditor;
                edit.Properties.DataSource = dtComboBox;// this.stratenBindingSource;
                // if (gv.FocusedColumn.Name == "BAD_CODE" && gv.ActiveEditor is LookUpEdit)
                // {
                //     // GET SELECTED DATAROW OF LookupEdit City here
                //
                //     DataRow row = gv.GetDataRow(gv.FocusedRowHandle);
                //     var edit = (LookUpEdit)gv.ActiveEditor;
                //         edit.Properties.DataSource = dtComboBox;// this.stratenBindingSource;
                // }
            }
            gv.GetFocusedDataRow().EndEdit(); 
        }
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GridView gv = sender as GridView;
            //   
            select_row_index = gv.FocusedRowHandle;
            // GridView gv = sender as GridView;
            //
            //
            // DataRow row = gv.GetDataRow(gv.FocusedRowHandle);
            // var edit = (LookUpEdit)gv.ActiveEditor;
            // edit.Properties.DataSource = tmp_comBoBox;
            // this.stratenBindingSource;
            //  if (tmp_comBoBox != null)
            //  {
            //      //if (gv.FocusedColumn.Name == "BAD_GROUP" && gv.ActiveEditor is LookUpEdit)
            //      if(gv.FocusedColumn.FieldName == "BAD_CODE" && gv.FocusedRowHandle==e.RowHandle)
            //      {
            //          DataRow row = gv.GetDataRow(gv.FocusedRowHandle);
            //          var edit = (LookUpEdit)gv.ActiveEditor;
            //          edit.Properties.DataSource = tmp_comBoBox;// this.stratenBindingSource;
            //      }
            //       
            //  }
            //
            //  tmp_comBoBox = null;

        }

        private void _gdMAIN_VIEW_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {

                GridView gv = sender as GridView;
            //   
               // int qRowIndex = gv.FocusedRowHandle;
            //   // string qColumnHeader = e.Column.Caption;
            //  //  e.Column.GetCaption();
            //    string select_bad_group = gv.GetRowCellValue(qRowIndex, "BAD_GROUP").ToString();
            //    RepositoryItemLookUpEdit pColumnType = new RepositoryItemLookUpEdit();
            //    // if (gv.FocusedColumn.Name == "BAD_CODE" && e.RowHandle  ==gv.FocusedRowHandle)
            //    // {
            //    //     e.RepositoryItem.CreateEditor();
            //    //     e.RepositoryItem.
            //    //     //e.RepositoryItem.GetType = pColumnType;
            //    //     // gv.FocusedColumn.ColumnEdit = pColumnType;
            //    // }
            //    if (gv.GetRowCellValue(gv.FocusedRowHandle, "BAD_CODE").ToString().Equals(""))
            //        e.RepositoryItem = pColumnType;
            //    gv.ActiveEditor.EditValue = "2";

            //GridView gv = sender as GridView;
            string fieldName = gv.GetRowCellValue(select_row_index, gv.Columns["BAD_CODE"]).ToString();
            //gv
            //switch (fieldName)
            //{
            //    case "":
            //        e.RepositoryItem = pColumnType_temp;
            //        break;
            //    //case "Country":
            //    //    e.RepositoryItem = pColumnType_temp;
            //    //    break;
            //    //case "Capital":
            //    //    e.RepositoryItem = pColumnType_temp;
            //    //    break;
            //}

        }
    }
}
