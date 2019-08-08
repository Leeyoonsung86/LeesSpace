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
using System.IO;
using System.Net;
using DevExpress.XtraSpreadsheet;
using DevExpress.Spreadsheet;
using static CoFAS_MES.CORE.BaseControls.ucSpreadSheetControl;

namespace CoFAS_MES.UI.PO.UserControls
{
    public partial class ucWorkOrderInfoPopup_T01 : UserControl
    {
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private static string _pFTP_ID = string.Empty;          // FTP ID 정보
        private static string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private static string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private static string _pFTP_PW = string.Empty;          //FTP PW 정보

        private static string _pFILE_NAME = string.Empty;
        private string _pFile_Attr = string.Empty;
        private static CORE.BaseControls.ucSpreadSheetControl _sdMAIN = null;

        decimal before_qty = 0;

        private ucWorkOrderInfoPopup_T01Entity _pWorkOrderInfoPopupEntity = null;

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

        public static string FTP_ID
        {
            get { return _pFTP_ID; }
            set { _pFTP_ID = value; }
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

        public ucWorkOrderInfoPopup_T01()
        {
            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();
        }

        private void ucProductPlanInfoPopup_Load(object sender, EventArgs e)
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

                InitializeSetting();

                if (_pARRAY_CODE != null && _pARRAY_CODE.Length > 1)
                {
                    _luTPART_CODE.Text = _pARRAY_CODE[0].ToString();
                    _luTPART_NAME.Text = _pARRAY_CODE[1].ToString();
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


            _pWorkOrderInfoPopupEntity = new ucWorkOrderInfoPopup_T01Entity();

            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }

            _pWorkOrderInfoPopupEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            //화면 컨트롤러 설정
            InitializeControl();
            _sdMAIN = new CORE.BaseControls.ucSpreadSheetControl();
            if (DBManager.InitDatabaseName != "coever_mes_glenzen")
            {
                SheetFind_DisplayData();
                 layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            
            //그리드 설정 ==고정==
            _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
            _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
            _gdMAIN_VIEW.CellValueChanged += _gdMAIN_VIEW_CellValueChanged;
            



        }

        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                int qRowIndex = gv.FocusedRowHandle;
                string qColumnHeader = e.Column.Caption;
                before_qty = Convert.ToDecimal(gv.GetRowCellValue(qRowIndex, "IN_QTY").ToString());
                 
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _gdMAIN_VIEW_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gv = sender as GridView;

            int qRowIndex = gv.FocusedRowHandle;
            string qColumnHeader = e.Column.Caption;
           // string qWorkOrderID = gv.GetRowCellValue(qRowIndex, "IN_QTY").ToString();
            decimal contract_qty = Convert.ToDecimal(gv.GetRowCellValue(qRowIndex, "CONTRACT_QTY").ToString());
            decimal order_qty = Convert.ToDecimal(gv.GetRowCellValue(qRowIndex, "ORDER_QTY").ToString());
            decimal input_qty = Convert.ToDecimal(gv.GetRowCellValue(qRowIndex, "IN_QTY").ToString());
            //18.11.21초과하여 내릴수있게
            //대신 초과하여 내리고 나면 지시를 다내린걸로 간주하고 수주리스트에서 안보임
            /*
            if(qColumnHeader != "*")
            { 
                if(input_qty>(contract_qty- order_qty))
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("입력가능 지시수량을 초과했습니다. \n지시가능 수량 :"+ (contract_qty -order_qty)+" 입니다");
                    gv.SetFocusedRowCellValue("IN_QTY", (contract_qty - order_qty).ToString());
                }
            }
            */
            //before_qty
            //CONTRACT_QTY : 수주수량
            //IN_QTY : 등록가능수량
            //ORDER_QTY : 등록된수량
        }

        private void InitializeControl()
        {
            try
            {
                _pCRUD = "";
                _luTPART_CODE.Text = "";
                _luTPART_NAME.Text = "";

                _luPLAN_ORDER_ID.Text = "";
                _luPLAN_ORDER_ID.ReadOnly = true;

               //_luREFERENCE_ID.Text = "";
               //_luREFERENCE_ID.ReadOnly = true;

                _luCUT_COUNT.Text = "0";

                _luPLAN_COUNT.Text = "0";
                _luPLAN_COUNT.ReadOnly = true;

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _gdMAIN.DataSource = null;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {

            }
        }

        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pCRUD = "R";

                string pPLAN_ORDER = _luPLAN_ORDER_ID.Text;
                string pPART_CODE = _luTPART_CODE.Text;
                _dtList = new ucWorkOrderInfoPopup_T01Business().ucWorkOrderInfoPopup_T01_Return(_pCRUD, pPLAN_ORDER, pPART_CODE).Tables[0];
                if (_pCRUD == "")
                    _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pCRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);

                    //GridColumn colName = _gdMAIN_VIEW.Columns["CONTRACT_QTY"];
                    GridColumn colName = _gdMAIN_VIEW.Columns["PRODUCT_ORDER_DATE"];
                    colName.AppearanceCell.BackColor = Color.Brown;
                    colName.AppearanceCell.ForeColor = Color.Yellow;

                    colName = _gdMAIN_VIEW.Columns["IN_QTY"];
                    colName.AppearanceCell.BackColor = Color.Brown;
                    colName.AppearanceCell.ForeColor = Color.Yellow;

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

        #endregion

        #region ○ InputData_Save(DataTable pDataTable)

        private void InputData_Save(DataTable pDataTable)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pWorkOrderInfoPopupEntity.CRUD = "C";
                DataTable temp_chk = _gdMAIN_VIEW.GridControl.DataSource as DataTable;
                DataSet tmp_DataSet = null;
                DataTable tmp_RequestList = null;
                for (int i = 0; i < temp_chk.Rows.Count; i++)
                {
                    if (pDataTable.Rows[i]["PROCESS_CODE"].ToString() == "")
                    { 
                        CoFAS_DevExpressManager.ShowInformationMessage("공정구성을 먼저 등록해주세요.");
                        return;
                    }
                }
            
                bool isError = false;
                _pWorkOrderInfoPopupEntity.CRUD = "C";
                _pWorkOrderInfoPopupEntity.USER_CODE = _pUSER_CODE;
                string _ptime = System.DateTime.Now.ToString("yyyyMMddHHmmss");

                _pWorkOrderInfoPopupEntity.REFERENCE_ID = _luPLAN_ORDER_ID.Text;  //계획정보를 레퍼런스에 담음
                _pWorkOrderInfoPopupEntity.FILE_NAME = "PRODUCTION/"+_ptime + "_" + _pWorkOrderInfoPopupEntity.REFERENCE_ID + "_작업요청서." + _pFile_Attr;
                //isError = new ucWorkOrderInfoPopup_T01Business().ucWorkOrderInfoPopup_T01_Save(_pWorkOrderInfoPopupEntity, pDataTable);
                tmp_DataSet = new ucWorkOrderInfoPopup_T01Business().ucWorkOrderInfoPopup_T01_Save(_pWorkOrderInfoPopupEntity, pDataTable);
                tmp_RequestList = tmp_DataSet.Tables[1];
                if (tmp_DataSet.Tables[0].Rows[0][0].ToString() != "00")
                {
                    isError = true;
                }
                if (isError)
                {
                    //오류 발생.
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                }
                else
                {
                    //정상 처리
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    if (DBManager.InitDatabaseName != "coever_mes_glenzen")
                    {
                        //WorkRequestDoc_Create(_ptime);
                        WorkRequestDoc_Create(tmp_RequestList);


                    }


                    // CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    _gdMAIN.DataSource = null;

                    //팝업 닫기
                    _btCancle_Click(null, null);
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
        #region 작업요청서 신규 저장
        //private void WorkRequestDoc_Create(string _ptime)
        private void WorkRequestDoc_Create(DataTable _ptimeList)
        {

            //_sdMAIN = new CORE.BaseControls.ucSpreadSheetControl();
            string strFTP_PATH = "";
            string strFILE_NAME = _pFILE_NAME;// _pWorkOrderInfoPopupEntity.FILE_NAME;

            strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", "WorkRequestRegister");
            string curfile = "ftp://";// Application.StartupPath + "\\Template\\" + strFILE_NAME;
            CoFAS_FTPUtilManager qFTPUtil;
            /*
                Stream responseStream = null;

                CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(strFTP_PATH, _pFTP_ID, _pFTP_PW);
                if (!qFTPUtil.IsFTPFileExsit(strFTP_PATH + strFILE_NAME))
                {

                    FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create("ftp://" + strFTP_PATH + strFILE_NAME);
                    requestFileDownload.Credentials = new NetworkCredential(_pFTP_ID, _pFTP_PW);
                    requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;

                    FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();

                    responseStream = responseFileDownload.GetResponseStream();

                    if (responseStream != null)

                    {
                        _sdMAIN.LoadDocument(responseStream, DocumentFormat.Xlsx);
                    
                    }
                    else
                    {
                        _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.Default);
                        _sdMAIN.CreateNewDocument();
                    }
                }
                else
                {
                // CoFAS_DevExpressManager.ShowErrorMessage("FTP서버에 저장되지 않은 파일입니다. 저장을 먼저 해주세요.");
                //return null;
                 }
                */
            // _sdMAIN = new CORE.BaseControls.ucSpreadSheetControl();
            byte[] data = _sdMAIN.SaveDocument(enFileFormat.Xlsx);

            //strFTP_PATH = string.Format(@"{0}{1}/", _pFTP_PATH, "PRODUCTION");
            strFTP_PATH = string.Format(@"{0}", _pFTP_PATH);
            // _pWorkRequestRegisterEntity.PRODUCTION_FILE = "ftp://"+strFTP_PATH +_ptime + "_" + _pWorkRequestRegisterEntity.PRODUCTION_ORDER_ID+'.'+ _pFile_Attr;
            //서버주소는 제외
            // string _ptime = System.DateTime.Now.ToString("yyyyMMddHHmmss");
            int chk = 0;
            if (_ptimeList.Rows.Count>0)
            { 
                for(int i=0; i < _ptimeList.Rows.Count; i++)
                {

                    //_pWorkOrderInfoPopupEntity.FILE_NAME = _ptime + "_" + _pWorkOrderInfoPopupEntity.REFERENCE_ID + "_작업요청서." + _pFile_Attr;
                    _pWorkOrderInfoPopupEntity.FILE_NAME = _ptimeList.Rows[i]["production_request_file"].ToString();

            //파일업로드
            if (_pWorkOrderInfoPopupEntity.CRUD == "C") // 업데이트
            {
                //업데이트는, 이전파일명으로 삭제하기
                //qFileName -> _pFTP_BEFROE_FILENAME
                //if (CoFAS_FTPManager.FTPDelete(qFileName, strFTP_PATH + _pSheetInfoRegisterEntity.WINDOW_NAME + "/", _pFTP_ID, _pFTP_PW))
                qFTPUtil = new CoFAS_FTPUtilManager(strFTP_PATH, _pFTP_ID, _pFTP_PW);

                //_pFTP_BEFROE_FILENAME

                if (CoFAS_FTPManager.FTPDelete(_pWorkOrderInfoPopupEntity.FILE_NAME, strFTP_PATH, _pFTP_ID, _pFTP_PW))
                {
                    if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory(_pWorkOrderInfoPopupEntity.FILE_NAME, _pFTP_ID, _pFTP_PW, strFTP_PATH, "", data)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                    {
                        //oFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                        //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    }

                    else
                    {
                                //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                                //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                                chk++;

                            }
                }
                //파일이 없는지 체크
                else if (!qFTPUtil.IsFTPFileExsit(strFTP_PATH + _pWorkOrderInfoPopupEntity.FILE_NAME))
                {
                    //정상 처리

                    if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory(_pWorkOrderInfoPopupEntity.FILE_NAME, _pFTP_ID, _pFTP_PW, strFTP_PATH, "", data)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                      //  CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                
                    }
                    else
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                       // CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                                chk++;
                     }
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                            chk++;
                        }
            }
        }

                if (chk>0)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                }
            }
        }

        private void SheetFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

               
               // _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;

                string strFTP_PATH = "";
                string strUSE_TYPE = "";
                string strFILE_NAME = "" ;



                
                _pWorkOrderInfoPopupEntity.CRUD = "R";
                _pWorkOrderInfoPopupEntity.WINDOW_NAME = "WorkRequestRegister";

                //조회할거 프로시져
                _dtList = new ucWorkOrderInfoPopup_T01Business().Sheet_Info_Sheet(_pWorkOrderInfoPopupEntity);   //엑셀 시트 조회하기

                _pWorkOrderInfoPopupEntity.WINDOW_NAME = this.Name;
                //엑셀서식관리 되면 다시 설정하기

                strUSE_TYPE = _dtList.Rows[0]["USE_TYPE"].ToString();
                strFILE_NAME = _dtList.Rows[0]["FILE_NAME"].ToString();
                _pFILE_NAME = strFILE_NAME;

                string[] tmp = strFILE_NAME.Split('.');
                _pFile_Attr = tmp[tmp.Length - 1];

                switch (strUSE_TYPE)
                {

                    case "PRINT":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "ORDER_FORM", "WorkRequestRegister");
                        break;
                    case "VIEW":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", "WorkRequestRegister");
                        break;
                    case "REGIT":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", "WorkRequestRegister");
                        break;
                }

                string curfile = Application.StartupPath + "\\Template\\" + strFILE_NAME;

                // 같은 것이 있으면, 폴더에서 해당 파일명을 불러와서 SpreadSheet에 띄우기 / 없으면, 폴더에 다운
                if (!File.Exists(curfile))
                {
                    CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW, curfile, false);

                }

                using (Stream responseStream = CoFAS_FTPManager.FTPFileBinding(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW))
                {
                    if (responseStream != null)
                    {
                        _sdMAIN.LoadDocument(responseStream, enFileFormat.Xlsx);
                    }
                    else
                    {
                        _sdMAIN.ClearSheet();
                    }
                }




            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion
        #region ○ 버튼클릭조회

        #region ● 품목조회

        private void _btSELECT_Click(object sender, EventArgs e)
        {
            try
            {
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = fntPARENT_FONT;

                frmCommonPopup.ARRAY = new object[2] { "Product_Code", _luTPART_NAME.Text }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                frmCommonPopup.ARRAY_CODE = new object[2] { _luTPART_CODE.Text, _luTPART_NAME.Text };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("PartCodeInfo"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luTPART_CODE.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                    _luTPART_NAME.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                    // BOM 조회하기
                    MainFind_DisplayData();
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ● 소요량 적용

        private void _btAPPLY_Click(object sender, EventArgs e)
        {
            try
            {
                int pRowCount = _gdMAIN_VIEW.RowCount;

                if (pRowCount > 0)
                {
                    for (int i = 0; i < pRowCount; i++)
                    {
                        _gdMAIN_VIEW.SetRowCellValue(i, "IN_QTY", Convert.ToDecimal(_gdMAIN_VIEW.GetRowCellValue(i, "PLAN_ORDER_QTY")));
                    }
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("생산계획을 불러오십시오.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_LOAD_DATA);
                    return;
                }

                for (int i = 0; i < pRowCount; i++)
                {
                    if (Convert.ToDecimal(_gdMAIN_VIEW.GetRowCellValue(i, "PLAN_ORDER_QTY")) < Convert.ToDecimal(_gdMAIN_VIEW.GetRowCellValue(i, "IN_QTY")) + Convert.ToDecimal(_gdMAIN_VIEW.GetRowCellValue(i, "ORDER_QTY")))
                    {
                        for (int j = 0; j < pRowCount; j++)
                        {
                            _gdMAIN_VIEW.SetRowCellValue(j, "IN_QTY", "0");
                        }

                        //CoFAS_DevExpressManager.ShowInformationMessage("등록할 지시수량이 계획수량보다 큽니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLAN_LARGE_THAN_ORDER);
                        return;
                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ● 계획등록

        private void _ucbtPLAN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (_gdMAIN_VIEW.RowCount > 0)
                {
                   // for(int i =0; i < _gdMAIN_VIEW.RowCount; i++ )
                   // {
                   //     if(_gdMAIN_VIEW.GetRowCellValue(i, "WORKCENTER_CODE").ToString() =="")
                   //     {
                   //         CoFAS_DevExpressManager.ShowInformationMessage("WORKCENTERCODE NOT INPUT");
                   //         return;
                   //     }
                   // }



                    InputData_Save(_gdMAIN_VIEW.GridControl.DataSource as DataTable);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("BOM 정보가 없습니다. ");
                    CoFAS_DevExpressManager.ShowInformationMessage("BOM "+_pMSG_SEARCH_EMPT);
                    return;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ● 생산계획찾기

        private void _luCONTRACT_ID__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                try
                {
                    CoFAS_MES.UI.PO.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                    CoFAS_MES.UI.PO.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    CoFAS_MES.UI.PO.UserForm.frmCommonPopup.FONT_TYPE = fntPARENT_FONT;

                    CoFAS_MES.UI.PO.UserForm.frmCommonPopup.ARRAY = new object[2] { "ProductionOrderInfo_Popup", _luTPART_NAME.Text }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                    CoFAS_MES.UI.PO.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _luTPART_CODE.Text, _luTPART_NAME.Text };
                    CoFAS_MES.UI.PO.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.PO.UserForm.frmCommonPopup("ProductionOrderInfo_Popup"); //유저컨트롤러 설정 부분

                    xfrmCommonPopup.ShowDialog();

                    if (xfrmCommonPopup.dtReturn == null)
                    {
                        xfrmCommonPopup.Dispose();
                        return;
                    }

                    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                    {
                        _luPLAN_ORDER_ID.Text = xfrmCommonPopup.dtReturn.Rows[0]["CONTRACT_ID"].ToString();

                       // _luREFERENCE_ID.Text = xfrmCommonPopup.dtReturn.Rows[0]["REFERENCE_ID"].ToString();
                        _luPLAN_COUNT.Text = xfrmCommonPopup.dtReturn.Rows[0]["CONTRACT_QTY"].ToString();

                        // BOM 조회하기
                        MainFind_DisplayData();


                    }

                    xfrmCommonPopup.Dispose();
                }
                catch (ExceptionManager pExceptionManager)
                {
                    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #endregion

        private void _luPLAN_QTY__OnTextChanged(object sender, EventArgs e)
        {
            try
            {
                int pRowCount = _gdMAIN_VIEW.RowCount;
                // decimal pPLANQTY = Convert.ToDecimal(_luPLAN_QTY.Text.Replace(",", ""));

                for (int i = 0; i < pRowCount; i++)
                {
                    decimal pPARTQTY = Convert.ToDecimal(_gdMAIN_VIEW.GetRowCellValue(i, "PART_QTY"));
                    //  decimal pSUMQTY = pPLANQTY * pPARTQTY;
                    //  _gdMAIN_VIEW.SetRowCellValue(i, "PLAN_QTY", pSUMQTY);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        //닫기버튼
        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);

        private void _btCancle_Click(object sender, EventArgs e)
        {
            if (_Close_Click != null)
                _Close_Click(sender, e);
            this.Dispose();
        }

        #region ○ 숫자만 입력

        private void _luTextEdit__OnKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("숫자를 입력하시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_NUMERIC);
                    return;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        #endregion

        private void _ucbtCUTBTN_Click(object sender, EventArgs e)
        {
            try
            {

                if(Convert.ToDecimal(_luPLAN_COUNT.Text) < Convert.ToDecimal(_luCUT_COUNT.Text))
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("분할수량이 더 큽니다..");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SPLITQTY_LARGE_MORE);
                    return;
                }
                if(_luPLAN_COUNT.Text =="0")
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("분할수량이 더 큽니다..");
                    CoFAS_DevExpressManager.ShowInformationMessage("분할 수량이 0입니다.");
                    return;
                }

                int pRowCount = _gdMAIN_VIEW.RowCount;
                decimal plancount = Convert.ToDecimal(_luPLAN_COUNT.Text); //계획수량
                decimal _Agv = Convert.ToDecimal(_luCUT_COUNT.Text); // 변경수량

                if (pRowCount > 0)
                {
                    for (int i = 0; i < pRowCount; i++)
                    {
                        _gdMAIN_VIEW.SetRowCellValue(i, "IN_QTY", ((Convert.ToInt32(_gdMAIN_VIEW.GetRowCellValue(i, "PLAN_ORDER_QTY"))) / plancount) * _Agv);
                    }
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_LOAD_DATA);
                    return;
                }


                for (int i = 0; i < pRowCount; i++)
                {
                    if (Convert.ToDecimal(_gdMAIN_VIEW.GetRowCellValue(i, "PLAN_ORDER_QTY")) < Convert.ToDecimal(_gdMAIN_VIEW.GetRowCellValue(i, "IN_QTY")) + Convert.ToDecimal(_gdMAIN_VIEW.GetRowCellValue(i, "ORDER_QTY")))
                    {
                        for (int j = 0; j < pRowCount; j++)
                        {
                            _gdMAIN_VIEW.SetRowCellValue(j, "IN_QTY", "0");
                        }

                        //CoFAS_DevExpressManager.ShowInformationMessage("등록할 지시수량이 계획수량보다 큽니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLAN_LARGE_THAN_ORDER);
                        return;
                    }
                }



            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }

        }

        private void _ucbtCUTALL_Click(object sender, EventArgs e)
        {
            try
            {

                int pRowCount = _gdMAIN_VIEW.RowCount;

                if (pRowCount > 0)
                {
                    for (int i = 0; i < pRowCount; i++)
                    {
                        _gdMAIN_VIEW.SetRowCellValue(i, "IN_QTY", (Convert.ToInt32(_gdMAIN_VIEW.GetRowCellValue(i, "PLAN_ORDER_QTY"))) - (Convert.ToInt32(_gdMAIN_VIEW.GetRowCellValue(i, "ORDER_QTY"))));
                    }
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("생산계획을 불러오십시오.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_LOAD_DATA);
                    return;
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
    }
    }
