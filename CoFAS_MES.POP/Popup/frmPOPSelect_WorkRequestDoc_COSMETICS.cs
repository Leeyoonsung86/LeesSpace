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
using CoFAS_MES.POP.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.POP.Entity;
using CoFAS_MES.CORE.Entity;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

using CoFAS_MES.CORE.BaseForm;


//using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;
using static CoFAS_MES.CORE.BaseControls.ucSpreadSheetControl;
using DevExpress.XtraSpreadsheet.Commands;
using DevExpress.XtraSpreadsheet.Menu;
using DevExpress.Spreadsheet;

namespace CoFAS_MES.POP.Popup
{
    public partial class frmPOPSelect_WorkRequestDoc_COSMETICS : frmBaseSingle
    {
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pUSER_NAME = string.Empty;       // 사용자이름
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private static string _pPROCESS_CODE_MST= string.Empty;     // 공정코드

        private static string _pFTP_ID = string.Empty;          // FTP ID 정보
        private static string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private static string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private static string _pFTP_PW = string.Empty;          //FTP PW 정보
        private static string _pCONTRACT_ID = string.Empty;          //FTP PW 정보
        private static string pPRODUCTION_ORDER_ID = string.Empty; 


        private static string _pFILE_NAME = string.Empty;
        private string _pFile_Attr = string.Empty;


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
        public string signature_user = string.Empty;
        //private static DataTable _pDATATABLE_VALUE = null;

        private frmPOPSelect_WorkRequestDoc_COSMETICSEntity _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity = null; // 엔티티 생성
       // private WorkResultRegister_T01Entity _pWorkResultRegister_T01Entity = null; // 엔티티 생성

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

        public static string PROCESS_CODE_MST
        {
            get { return _pPROCESS_CODE_MST; }
            set { _pPROCESS_CODE_MST = value; }
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

        public frmPOPSelect_WorkRequestDoc_COSMETICS(string strFindControl)
        {
            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();
            switch (strFindControl)
            {

                case "WorkOrderInfoPopup_T01":  // 발주 찾기 팝업
                   // // _btPOPUP_SELECT.Enabled = false; //userControl 별 복수 로우 선택 데이터 리던시 사용으로 변경
                   // 
                   // //user Control 생성시 고정 ==
                   // ucWorkOrderInfoPopup_T01.CORP_CDDE = _pCORP_CODE;
                   // ucWorkOrderInfoPopup_T01.USER_CODE = _pUSER_CODE;
                   // ucWorkOrderInfoPopup_T01.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                   // ucWorkOrderInfoPopup_T01.FONT_TYPE = fntPARENT_FONT;
                   // 
                   // ucWorkOrderInfoPopup_T01.ARRAY = _pARRAY;
                   // ucWorkOrderInfoPopup_T01.ARRAY_CODE = _pARRAY_CODE;
                   // 
                   // ucWorkOrderInfoPopup_T01.FTP_ID = _pFTP_ID;
                   // ucWorkOrderInfoPopup_T01.FTP_IP_PORT = _pFTP_IP_PORT;
                   // ucWorkOrderInfoPopup_T01.FTP_PATH = _pFTP_PATH;
                   // ucWorkOrderInfoPopup_T01.FTP_PW = _pFTP_PW;
                   // 
                   // 
                   // _uc = new ucWorkOrderInfoPopup_T01();
                   // 
                   // //  ucWorkOrderInfoPopup_T01._OnDoubleClick += ucCommonCodePopup__OnDoubleClick;
                   // ucWorkOrderInfoPopup_T01._Close_Click += ucCommonCodePopup_Close_OnClick;
                   // //user Control 생성시 고정 ==
                   // this.Width = _uc.Width + 5;
                   // this.Height = _uc.Height + 75;
                    break;

                case "ProductionOrderInfo_Popup":  // 발주 찾기 팝업
                    break;
            }
            }

        private void frmPOPSelect_WorkRequestDoc_COSMETICS_Load(object sender, EventArgs e)
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
            ////메인 화면 전역 변수 처리

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

            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }

            DateTime pDateTime = DateTime.Today;
            DateTime pFirstDateTime = pDateTime.AddDays(1 - pDateTime.Day);
            //_luORDER_DATE1.DateTime = pFirstDateTime; //from
            //_luORDER_DATE2.DateTime = DateTime.Now; //to
            _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity = new frmPOPSelect_WorkRequestDoc_COSMETICSEntity();
            //그리드 설정 ==고정==
            _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PART_TYPE = _pARRAY_CODE[2].ToString();
            pPRODUCTION_ORDER_ID = _pARRAY[2].ToString();
            _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME = _pARRAY[3].ToString();

           // _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));

            _pCRUD = "";
            _pWINDOW_NAME = this.Name;
             _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.WINDOW_NAME = _pWINDOW_NAME;
          //  MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
            SheetFind_DisplayData();
           // _gdMAIN_VIEW.DoubleClick += _gdMAIN_VIEW_DoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수




            //그리드 설정 ==고정==
        }

     //   public static event OnDoubleClickEventHandler _OnDoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수
     //    public delegate void OnDoubleClickEventHandler(object sender, EventArgs e); //그리드 로우 마우스 선택으로 값 넘길경우 필수
        
        
        #region 작업지시서 신규 저장
        private void SheetFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //_sdMAIN = new CORE.BaseControls.ucSpreadSheetControl();
                // _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;

                string strFTP_PATH = "";
                string strUSE_TYPE = "";
                string strFILE_NAME = "";




                _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.CRUD = "R";
                _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.WINDOW_NAME = "WorkRequestRegister";// _pWINDOW_NAME;
                _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PROCESS_CODE_MST = _pARRAY[1].ToString();   //프로세스코드


                //조회할거 프로시져
                _dtList = new frmPOPSelect_WorkRequestDoc_COSMETICSBusiness().frmWorkOrderDocRegPopup_COSMETICS_sheet_Info(_pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity);   //엑셀 시트 조회하기
                                                                                                                                                                             //엑셀서식관리 되면 다시 설정하기
                                                                                                                                                                             //제조 : 0 ( PT040001)
                                                                                                                                                                             //     if (_pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PROCESS_CODE_MST == "PT040001" || _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PROCESS_CODE_MST == "PC010001")
                                                                                                                                                                             //    if (_pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST == "PC010001")
                {
                    strUSE_TYPE = _dtList.Rows[0]["USE_TYPE"].ToString();
                    strFILE_NAME = _dtList.Rows[0]["FILE_NAME"].ToString();
                    //   }
                    //   else
                    //   {
                    //       strUSE_TYPE = _dtList.Rows[1]["USE_TYPE"].ToString();
                    //       strFILE_NAME = _dtList.Rows[1]["FILE_NAME"].ToString();
                    //   }
                    //포장 : 1
                    _pFILE_NAME = strFILE_NAME;

                    string[] tmp = strFILE_NAME.Split('.');
                    _pFile_Attr = tmp[tmp.Length - 1];

                    switch (strUSE_TYPE)
                    {

                        case "PRINT":
                            strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "ORDER_FORM", _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.WINDOW_NAME);
                            break;
                        case "VIEW":
                            strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.WINDOW_NAME);
                            break;
                        case "REGIT":
                            strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.WINDOW_NAME);
                            break;
                    }
                    string[] tmp2;
                    if (_pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME != "")

                    {
                        //확장자 자르기
                        tmp = _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME.Split('.');
                        _pFile_Attr = tmp[tmp.Length - 1];

                        //파일명 자르기
                        tmp2 = _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME.Split('/');
                        strFTP_PATH = string.Format(@"{0}{1}/", _pFTP_PATH, "PRODUCTION");
                        strFILE_NAME = tmp2[tmp2.Length - 1];
                        // _luFILE_NAME.Text = strFILE_NAME;

                    }
                    _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.WINDOW_NAME = _pWINDOW_NAME;
                    // string curfile = Application.StartupPath + "\\Template\\" + strFILE_NAME;
                    //
                    // // 같은 것이 있으면, 폴더에서 해당 파일명을 불러와서 SpreadSheet에 띄우기 / 없으면, 폴더에 다운
                    // if (!File.Exists(curfile))
                    // {
                    //     CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW, curfile, false);
                    //
                    // }

                    using (Stream responseStream = CoFAS_FTPManager.FTPFileBinding(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW))
                    {
                        if (responseStream != null)
                        {
                            _sdMAIN.LoadDocument(responseStream, DocumentFormat.Xlsx);
                            //_sdMAIN.LoadDocument(responseStream, enFileFormat.Xlsx);

                        }
                        else
                        {
                            //_sdMAIN.ClearSheet();
                            //_sdMAIN.CloseCellEditor(CellEditorEnterValueMode.Default);
                            //_sdMAIN.CreateNewDocument();
                            _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.Default);
                            _sdMAIN.CreateNewDocument();
                        }
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
        private void _sdMAIN_PopupMenuShowing(object sender, DevExpress.XtraSpreadsheet.PopupMenuShowingEventArgs e)
        {
            IWorkbook workbook = _sdMAIN.Document;
            Worksheet activeSheet = workbook.Worksheets.ActiveWorksheet;
            //string Select_PartType = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_TYPE").ToString();
            Worksheet sheet_1 = workbook.Worksheets["데이터"];
            string Select_PartType = sheet_1.GetCellValue(8, 1).ToString();//_gdMAIN_VIEW.GetFocusedRowCellValue("PART_TYPE").ToString();
            if (e.MenuType == SpreadsheetMenuType.Cell)
            {
                //    total_user		: 담당자
                //    total_writer	: 작성자
                //   total_checker	: 검토자
                //    total_approver	: 승인자 

                signature_user = "total_user";
                //제품 : 1001
                //포장
                if (Select_PartType == "1001")
                {
                    if (
                          (_sdMAIN.ActiveCell == activeSheet.Cells["M3"])
                       || (_sdMAIN.ActiveCell == activeSheet.Cells["M4"])
                       || (_sdMAIN.ActiveCell == activeSheet.Cells["M5"])
                       )
                    {
                        _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        //  e.Menu.RemoveMenuItem(SpreadsheetCommandId.pick);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Add(myItem);
                        //    total_user		: 담당자
                        //    total_writer	: 작성자
                        //   total_checker	: 검토자
                        //    total_approver	: 승인자 

                        signature_user = "total_writer";
                    }
                    else
                    {
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Remove(myItem);
                    }
                    if (
                          (_sdMAIN.ActiveCell == activeSheet.Cells["N3"])
                        || (_sdMAIN.ActiveCell == activeSheet.Cells["N4"])
                        || (_sdMAIN.ActiveCell == activeSheet.Cells["N5"])
                        )
                    {
                        _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        //  e.Menu.RemoveMenuItem(SpreadsheetCommandId.pick);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Add(myItem);
                        //    total_user		: 담당자
                        //    total_writer	: 작성자
                        //   total_checker	: 검토자
                        //    total_approver	: 승인자 

                        signature_user = "total_checker";
                    }
                    else
                    {
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Remove(myItem);
                    }
                    if (
                          (_sdMAIN.ActiveCell == activeSheet.Cells["O3"])
                       || (_sdMAIN.ActiveCell == activeSheet.Cells["O4"])
                       || (_sdMAIN.ActiveCell == activeSheet.Cells["O5"])
                        )
                    {
                        _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        //  e.Menu.RemoveMenuItem(SpreadsheetCommandId.pick);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Add(myItem);
                        //    total_user		: 담당자
                        //    total_writer	: 작성자
                        //   total_checker	: 검토자
                        //    total_approver	: 승인자 

                        signature_user = "total_approver";
                    }
                    else
                    {
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Remove(myItem);
                    }
                    //////

                }
                //제조
                else if (Select_PartType == "1003")
                {

                    if (
                         (_sdMAIN.ActiveCell == activeSheet.Cells["V3"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["W3"])
                      || (_sdMAIN.ActiveCell == activeSheet.Cells["V4"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["W4"])
                      || (_sdMAIN.ActiveCell == activeSheet.Cells["V5"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["W5"])
                      )
                    {
                        _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        //  e.Menu.RemoveMenuItem(SpreadsheetCommandId.pick);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Add(myItem);
                        //    total_user		: 담당자
                        //    total_writer	: 작성자
                        //   total_checker	: 검토자
                        //    total_approver	: 승인자 

                        signature_user = "total_writer";
                    }
                    else
                    {
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Remove(myItem);
                    }
                    if (
                          (_sdMAIN.ActiveCell == activeSheet.Cells["X3"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["Y3"])
                        || (_sdMAIN.ActiveCell == activeSheet.Cells["X4"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["Y4"])
                        || (_sdMAIN.ActiveCell == activeSheet.Cells["X5"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["Y5"])
                        )
                    {
                        _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        //  e.Menu.RemoveMenuItem(SpreadsheetCommandId.pick);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Add(myItem);
                        //    total_user		: 담당자
                        //    total_writer	: 작성자
                        //   total_checker	: 검토자
                        //    total_approver	: 승인자 

                        signature_user = "total_checker";
                    }
                    else
                    {
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Remove(myItem);
                    }
                    if (
                          (_sdMAIN.ActiveCell == activeSheet.Cells["Z3"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["AA3"])
                       || (_sdMAIN.ActiveCell == activeSheet.Cells["Z4"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["AA4"])
                       || (_sdMAIN.ActiveCell == activeSheet.Cells["Z5"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["AA5"])
                        )
                    {
                        _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        //  e.Menu.RemoveMenuItem(SpreadsheetCommandId.pick);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Add(myItem);
                        //    total_user		: 담당자
                        //    total_writer	: 작성자
                        //   total_checker	: 검토자
                        //    total_approver	: 승인자 

                        signature_user = "total_approver";
                    }
                    else
                    {
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Remove(myItem);
                    }
                }
            }
        }
        public void InsertSignImage(object sender, EventArgs e)
        {

            if (CoFAS_DevExpressManager.ShowQuestionMessage("승인하시겠습니까?") == DialogResult.No)
            {
                return;
            }
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.CRUD = "R";
                _dtList = new frmPOPSelect_WorkRequestDoc_COSMETICSBusiness().GetUserImage(_pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.CRUD, _pUSER_CODE);
                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.CRUD == ""))
                {
                    IWorkbook workbook = _sdMAIN.Document;
                    Worksheet sheet_0 = workbook.Worksheets[0];
                    Image img = null;
                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList.Rows[0]["USER_IMAGE"]);
                    Stream memstr = new MemoryStream((byte[])_dtList.Rows[0]["USER_IMAGE"]);
                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);

                    //string Select_PartType = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_TYPE").ToString();
                    Worksheet sheet_1 = workbook.Worksheets["데이터"];
                    string Select_PartType = sheet_1.GetCellValue(8, 1).ToString();//_gdMAIN_VIEW.GetFocusedRowCellValue("PART_TYPE").ToString();
                                                                                   //이미지 넣을 범위
                                                                                   //제품 : 1001
                    if (Select_PartType == "1001")
                    {

                        //sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["O30:P31"]);
                        //sheet_0.Cells["O30"].SetValue(_pUSER_CODE);
                        ////pDataParametersA[3].Value = sheet_1.GetCellValue(14, 29).ToString();
                        //_pucWorkOrderDocRegPopupEntity.TOTAL_APPROVER_SIGN = _pUSER_CODE;
                        if (signature_user == "total_writer")
                        {
                            sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["M3:M5"]);
                            sheet_0.Cells["M3"].SetValue(_pUSER_NAME);
                        }
                        else if (signature_user == "total_checker")
                        {
                            sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["N3:N5"]);
                            sheet_0.Cells["N3"].SetValue(_pUSER_CODE);
                        }
                        else if (signature_user == "total_approver")
                        {
                            sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["O3:O5"]);
                            sheet_0.Cells["O3"].SetValue(_pUSER_CODE);
                        }
                    }
                    //반제품 : 1003
                    else if (Select_PartType == "1003")
                    {
                        //sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["O30:Q31"]);
                        //sheet_0.Cells["V3"].SetValue(_pUSER_CODE);
                        //_pucWorkOrderDocRegPopupEntity.TOTAL_APPROVER_SIGN = _pUSER_CODE;
                        //sheet_1.GetCellValue(14, 29).ToString();
                        //sheet_0.Cells["O30"].DisplayText();
                        if (signature_user == "total_writer")
                        {
                            sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["V3:W5"]);
                            sheet_0.Cells["V3"].SetValue(_pUSER_NAME);
                        }
                        else if (signature_user == "total_checker")
                        {
                            sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["X3:Y5"]);
                            sheet_0.Cells["X3"].SetValue(_pUSER_CODE);
                        }
                        else if (signature_user == "total_approver")
                        {
                            sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["Z3:AA5"]);
                            sheet_0.Cells["Z3"].SetValue(_pUSER_CODE);
                        }
                    }


                }
                else
                {
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
               // _gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }

        }
        private void _gdMAIN_VIEW_DoubleClick(object sender, EventArgs e)
        {
           // if (_OnDoubleClick != null)
           //     _OnDoubleClick(sender, e);
        }
        
        //닫기버튼
        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);
        private void _btCancle_Click(object sender, EventArgs e)
        {
            //   if (_Close_Click != null)
            //       _Close_Click(sender, e);
            Close();
        }

        #region 접수_프로시져
        private void _ucbtAccept_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void _ucbtSave_Click(object sender, EventArgs e)
        {
            _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.CRUD = "C";
         //   InputData_Save(_gdMAIN_VIEW.GridControl.DataSource as DataTable);


        }

        private void InputData_Save(DataTable pDataTable)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.CRUD = "C";
                bool isError = false;
                _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.CRUD = "C";
                _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.USER_CODE = _pUSER_CODE;
                _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PRODUCTION_ORDER_ID = pPRODUCTION_ORDER_ID;
                string _ptime = System.DateTime.Now.ToString("yyyyMMddHHmmss");

               // if (_pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PROCESS_CODE_MST == "PT040001")
               //     _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME = "PRODUCTION/"+_ptime + "_" + pPRODUCTION_ORDER_ID + "_제조지시서." + _pFile_Attr;
               // else
               //     _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME = "PRODUCTION/"+ _ptime + "_" + pPRODUCTION_ORDER_ID + "_포장지시서." + _pFile_Attr;

                isError = new frmPOPSelect_WorkRequestDoc_COSMETICSBusiness().frmWorkOrderDocRegPopup_COSMETICS_Save(_pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity, pDataTable);

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
                        JobOrderDoc_Create();

                    }


                   // CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                   // _gdMAIN.DataSource = null;

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

        private void JobOrderDoc_Create()
        {

            //_sdMAIN = new CORE.BaseControls.ucSpreadSheetControl();
            string strFTP_PATH = "";
            string strFILE_NAME = _pFILE_NAME;// _pWorkOrderInfoPopupEntity.FILE_NAME;

           // strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW",_pWINDOW_NAME);
            string curfile = "ftp://";// Application.StartupPath + "\\Template\\" + strFILE_NAME;
            CoFAS_FTPUtilManager qFTPUtil;
          
            byte[] data =_sdMAIN.SaveDocument(DocumentFormat.Xlsx); //(enFileFormat.Xlsx);

            strFTP_PATH = string.Format(@"{0}{1}/", _pFTP_PATH, "PRODUCTION");
            // _pWorkRequestRegisterEntity.PRODUCTION_FILE = "ftp://"+strFTP_PATH +_ptime + "_" + _pWorkRequestRegisterEntity.PRODUCTION_ORDER_ID+'.'+ _pFile_Attr;
            //서버주소는 제외
           // string _ptime = System.DateTime.Now.ToString("yyyyMMddHHmmss");
           // if(_pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PROCESS_CODE_MST== "PT040001")
           //     _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME = _ptime + "_" + pPRODUCTION_ORDER_ID + "_제조." + _pFile_Attr;
           // else
           //     _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME = _ptime + "_" + pPRODUCTION_ORDER_ID + "_포장." + _pFile_Attr;
           //
            //파일업로드
            if (_pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.CRUD == "C") // 업데이트
            {
                //업데이트는, 이전파일명으로 삭제하기
                //qFileName -> _pFTP_BEFROE_FILENAME
                //if (CoFAS_FTPManager.FTPDelete(qFileName, strFTP_PATH + _pSheetInfoRegisterEntity.WINDOW_NAME + "/", _pFTP_ID, _pFTP_PW))
                //qFTPUtil = new CoFAS_FTPUtilManager(strFTP_PATH, _pFTP_ID, _pFTP_PW);
                qFTPUtil = new CoFAS_FTPUtilManager(_pFTP_PATH, _pFTP_ID, _pFTP_PW);

                //_pFTP_BEFROE_FILENAME

                if (CoFAS_FTPManager.FTPDelete(_pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME, _pFTP_PATH, _pFTP_ID, _pFTP_PW))
                {
                    if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory(_pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME, _pFTP_ID, _pFTP_PW, _pFTP_PATH, "", data)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                    {
                        //oFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    }

                    else
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);

                    }
                }
                //파일이 없는지 체크
                else if (!qFTPUtil.IsFTPFileExsit(_pFTP_PATH + _pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME))
                {
                    //정상 처리

                    if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory(_pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME, _pFTP_ID, _pFTP_PW, _pFTP_PATH, "", data)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                        this.Close();
                    }
                    else
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                    }
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                }

            }
        }

        private void _ucbtPCSave_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                
                    SaveFileDialog mDlg = new SaveFileDialog();
                    mDlg.InitialDirectory = Application.StartupPath;
                    mDlg.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    mDlg.FilterIndex = 1;
                    if (mDlg.ShowDialog() == DialogResult.OK)
                    {
                        //_sdMAIN.SaveDocumentAs();
                        _sdMAIN.SaveDocument(mDlg.FileName);
                        CoFAS_DevExpressManager.ShowInformationMessage("저장이 완료 되었습니다.");
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

        private void _ucbtPrint_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _sdMAIN.ShowPrintPreview();

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
    }
}
