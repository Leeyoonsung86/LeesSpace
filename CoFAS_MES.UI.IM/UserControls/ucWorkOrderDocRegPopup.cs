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
using CoFAS_MES.UI.IM.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.UI.IM.Entity;
using CoFAS_MES.CORE.Entity;


using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;
using static CoFAS_MES.CORE.BaseControls.ucSpreadSheetControl;
using DevExpress.XtraSpreadsheet.Commands;
using DevExpress.XtraSpreadsheet.Menu;
using DevExpress.Utils.Menu;

namespace CoFAS_MES.UI.IM.UserControls
{
    public partial class ucWorkOrderDocRegPopup : UserControl
    {
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pUSER_NAME = string.Empty;       // 사용자이름
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pMENU_NAME = string.Empty;     // 메뉴명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private static string _pPROCESS_CODE_MST= string.Empty;     // 공정코드

        private static string _pFTP_ID = string.Empty;          // FTP ID 정보
        private static string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private static string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private static string _pFTP_PW = string.Empty;          //FTP PW 정보
        private static string _pCONTRACT_ID = string.Empty;          //FTP PW 정보
        private static string pPRODUCTION_ORDER_ID = string.Empty;
        private static string pPART_CODE = string.Empty;


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

        //private static DataTable _pDATATABLE_VALUE = null;
        public string signature_user = string.Empty;
        private ucWorkOrderDocRegPopupEntity _pucWorkOrderDocRegPopupEntity = null; // 엔티티 생성
        private static WorkResultRegister_T01Entity _pWorkResultRegister_T01Entity = null; // 엔티티 생성

        private static object[] _pARRAY = null;
        private static object[] _pARRAY_CODE = null;
        private string _pCRUD = ""; //CRUD
        private bool _pBoldType = true; //CRUD

        public static WorkResultRegister_T01Entity WorkResultRegister_T01Entity
        {
            get { return _pWorkResultRegister_T01Entity; }
            set { _pWorkResultRegister_T01Entity = value; }
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

        private DataSet _dsList = null; //조회 데이터 리스트
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtList2 = null; //조회 데이터 리스트
        private DataTable _dtList4 = null; //제조공정 리스트
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

        public ucWorkOrderDocRegPopup()
        {
            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();
            _pMENU_NAME = this.Text;
        }

        private void ucWorkOrderDocRegPopup_Load(object sender, EventArgs e)
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
            layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
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
            _pucWorkOrderDocRegPopupEntity = new ucWorkOrderDocRegPopupEntity();
            //그리드 설정 ==고정==
            //_pucWorkOrderDocRegPopupEntity.PART_TYPE = _pARRAY_CODE[2].ToString();
            //pPRODUCTION_ORDER_ID = _pARRAY[2].ToString();
            pPART_CODE = _pARRAY[1].ToString();
            _pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST = _pARRAY[3].ToString();   //프로세스코드
            _pucWorkOrderDocRegPopupEntity.PART_CODE = pPART_CODE;
            //_pucWorkOrderDocRegPopupEntity.FILE_NAME = _pARRAY[3].ToString();
            _pucWorkOrderDocRegPopupEntity.FILE_NAME = _pARRAY[2].ToString();
            //_pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST = _pARRAY[4].ToString();

            _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, fntPARENT_FONT, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));

            _pCRUD = "";
            _pWINDOW_NAME = this.Name;
             _pucWorkOrderDocRegPopupEntity.WINDOW_NAME = _pWINDOW_NAME;
            SheetFind_DisplayData();
            MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
            
            _gdMAIN_VIEW.DoubleClick += _gdMAIN_VIEW_DoubleClick; //그리드 로우 마우스 선택으로 값 넘길경우 필수




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




                _pucWorkOrderDocRegPopupEntity.CRUD = "R";
                _pucWorkOrderDocRegPopupEntity.WINDOW_NAME = _pWINDOW_NAME;
                
                

                //조회할거 프로시져
                _dtList = new ucWorkOrderDocRegPopupBusiness().Sheet_Info_Sheet(_pucWorkOrderDocRegPopupEntity);   //엑셀 시트 조회하기

                //엑셀서식관리 되면 다시 설정하기
                //제조 : 0 ( PT040001)
                if (_pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST == "PT040001" || _pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST == "PC01")
                //    if (_pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST == "PC01")
                    {
                    strUSE_TYPE = _dtList.Rows[0]["USE_TYPE"].ToString();
                    strFILE_NAME = _dtList.Rows[0]["FILE_NAME"].ToString();
                }
                else
                {
                    strUSE_TYPE = _dtList.Rows[1]["USE_TYPE"].ToString();
                    strFILE_NAME = _dtList.Rows[1]["FILE_NAME"].ToString();
                }
                //포장 : 1
                    _pFILE_NAME = strFILE_NAME;

                string[] tmp = strFILE_NAME.Split('.');
                _pFile_Attr = tmp[tmp.Length - 1];

                switch (strUSE_TYPE)
                {

                    case "PRINT":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "ORDER_FORM", _pWINDOW_NAME);
                        break;
                    case "VIEW":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pWINDOW_NAME);
                        break;
                    case "REGIT":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pWINDOW_NAME);
                        break;
                }
                string[] tmp2;
                if (_pucWorkOrderDocRegPopupEntity.FILE_NAME != "")

                {
                    //확장자 자르기
                    tmp = _pucWorkOrderDocRegPopupEntity.FILE_NAME.Split('.');
                    _pFile_Attr = tmp[tmp.Length - 1];

                    //파일명 자르기
                    tmp2 = _pucWorkOrderDocRegPopupEntity.FILE_NAME.Split('/');
                    strFTP_PATH = string.Format(@"{0}{1}/", _pFTP_PATH, "PRODUCTION");
                    strFILE_NAME = tmp2[tmp2.Length - 1];
                    _luFILE_NAME.Text = strFILE_NAME;

                }

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
                        // _sdMAIN.LoadDocument(responseStream, DocumentFormat.Xlsx);
                        //_sdMAIN.LoadDocument(responseStream, enFileFormat.Xlsx);
                        _sdMAIN.LoadDocument(responseStream, DocumentFormat.Xlsx);
                        try
                        {
                            _sdMAIN.CellBeginEdit -= _sdMAIN_CellBeginEdit;
                            _sdMAIN.CellBeginEdit += _sdMAIN_CellBeginEdit;

                          //  _sdMAIN.PopupMenuShowing -= _sdMAIN_PopupMenuShowing;
                           // _sdMAIN.PopupMenuShowing += _sdMAIN_PopupMenuShowing;
                        }
                        catch
                        {
                           _sdMAIN.CellBeginEdit += _sdMAIN_CellBeginEdit;
                        //    _sdMAIN.PopupMenuShowing += _sdMAIN_PopupMenuShowing;
                        }
                    }
                    else
                    {
                        //_sdMAIN.ClearSheet();
                        _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.Default);
                        _sdMAIN.CreateNewDocument();
                       // _sdMAIN.ClearSheet();
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
        private void _sdMAIN_CellBeginEdit(object sender, SpreadsheetCellCancelEventArgs e)
        {
            try
            {
                //제조
                if ((_pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST == "PC01") || _pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST == "PT040001")
                {
                    //제조년월일
                    //if (((e.RowIndex == 4)) && ((7 < e.ColumnIndex) && (e.ColumnIndex < 11)))
                    if (((5 < e.RowIndex) && (e.RowIndex < 8)) && ((9 < e.ColumnIndex) && (e.ColumnIndex < 13)))
                    {
                        IWorkbook workbook = _sdMAIN.Document;
                        Worksheet sheet_0 = workbook.Worksheets[0];

                        // 팝업에 파라미터 전송
                        CoFAS_MES.UI.IM.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                        CoFAS_MES.UI.IM.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                        CoFAS_MES.UI.IM.UserForm.frmCommonPopup.FONT_TYPE = fntPARENT_FONT;

                        CoFAS_MES.UI.IM.UserForm.frmCommonPopup.ARRAY_CODE = new object[4] { "", "", "", "" };
                        CoFAS_MES.UI.IM.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.IM.UserForm.frmCommonPopup("Calendar_T01"); //유저컨트롤러 설정 부분

                        xfrmCommonPopup.ShowDialog();
                        if (xfrmCommonPopup.dtReturn == null)
                        {
                            xfrmCommonPopup.Dispose();
                            return;
                        }

                        if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                        {
                            sheet_0.Cells[6, 10].SetValue(xfrmCommonPopup.dtReturn.Rows[0]["DATE"].ToString());
                        }

                        xfrmCommonPopup.Dispose();
                    }
                    //계량년월일
                    if (((5 < e.RowIndex) && (e.RowIndex < 8)) && ((7 < e.ColumnIndex) && (e.ColumnIndex < 10)))
                    {
                        IWorkbook workbook = _sdMAIN.Document;
                        Worksheet sheet_0 = workbook.Worksheets[0];

                        // 팝업에 파라미터 전송
                        CoFAS_MES.UI.IM.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                        CoFAS_MES.UI.IM.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                        CoFAS_MES.UI.IM.UserForm.frmCommonPopup.FONT_TYPE = fntPARENT_FONT;

                        CoFAS_MES.UI.IM.UserForm.frmCommonPopup.ARRAY_CODE = new object[4] { "", "", "", "" };
                        CoFAS_MES.UI.IM.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.IM.UserForm.frmCommonPopup("Calendar_T01"); //유저컨트롤러 설정 부분

                        xfrmCommonPopup.ShowDialog();
                        if (xfrmCommonPopup.dtReturn == null)
                        {
                            xfrmCommonPopup.Dispose();
                            return;
                        }

                        if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                        {
                            sheet_0.Cells[6, 8].SetValue(xfrmCommonPopup.dtReturn.Rows[0]["DATE"].ToString());
                        }

                        xfrmCommonPopup.Dispose();
                    }
                }
                //포장
                else
                {
                    
                }
            }
            catch(Exception ex)
            {

            }
        }
     

        //사용자


        public void InsertBoldLine(object sender, EventArgs e)
        {

           
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                DXMenuItem item = sender as DXMenuItem;

                if (CoFAS_DevExpressManager.ShowQuestionMessage(item.Caption + "하시겠습니까?") == DialogResult.No)
                {
                    return;
                }

                _pucWorkOrderDocRegPopupEntity.CRUD = "R";

                IWorkbook workbook = _sdMAIN.Document;
                Worksheet sheet_0 = workbook.Worksheets[0];

                //Range range4 = sheet_0.Range["A21:K21"];
                // A rectangular range whose left column index is 0, top row index is 0, 
                // right column index is 3 and bottom row index is 2. This is the A1:D3 cell range.
                Range range4 = sheet_0.Range.FromLTRB(1, _sdMAIN.ActiveCell.RowIndex - 1, 10, _sdMAIN.ActiveCell.RowIndex);
                Formatting range4Formatting = range4.BeginUpdateFormatting();
                Borders range4Borders = range4Formatting.Borders;
                

                if (item.Caption == "굵은선 추가")
                {
                    range4Borders.BottomBorder.LineStyle = BorderLineStyle.Thick;
                 
                }
                else
                {
                    range4Borders.BottomBorder.LineStyle = BorderLineStyle.Dotted;
                }   
                range4.EndUpdateFormatting(range4Formatting);
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
       

        private void _gdMAIN_VIEW_DoubleClick(object sender, EventArgs e)
        {
           // if (_OnDoubleClick != null)
           //     _OnDoubleClick(sender, e);
        }

        private void _btSELECT_Click(object sender, EventArgs e)
        {
            
                _pCRUD = "R";

                MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
 
        }

        private void _btCLEAR_Click(object sender, EventArgs e)
        {
           // _luCD.Text = "";
           // _luCD_NM.Text = "";

            _gdMAIN.DataSource = null;
        }

        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                // string strPART_TYPE = _luPART_TYPE.GetValue();
                // pPRODUCTION_ORDER_ID = "";
                //string pPART_NAME = _luCD_NM.Text;
                // string pPART_CODE = _luCD.Text;
                string pPROCESS_CODE_MST = "";
                string pFROM_DATE = "";
                string pTO_DATE = "";

                _pCRUD = "R";
                //_dtList = new ucWorkOrderDocRegPopupBusiness().ucWorkOrderDocRegPopup_Return(_pCRUD, _pLANGUAGE_TYPE,  pPRODUCTION_ORDER_ID,  pPART_NAME,  pPART_CODE,  pPROCESS_CODE_MST).Tables[0];
                // _dtList = new ucWorkOrderDocRegPopupBusiness().ucWorkOrderDocRegPopup_Return(_pCRUD, _pLANGUAGE_TYPE, pPRODUCTION_ORDER_ID, "", "", pPROCESS_CODE_MST).Tables[0];
                _dsList = new ucWorkOrderDocRegPopupBusiness().ucWorkOrderDocRegPopup_Return2(_pCRUD, _pLANGUAGE_TYPE, _pucWorkOrderDocRegPopupEntity.PART_CODE, _pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST);
                _dtList = _dsList.Tables[0];
                _dtList2 = _dsList.Tables[1];
                

                if (_pCRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pCRUD == ""))
                {
                    //  CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);

                    IWorkbook workbook = _sdMAIN.Document;
                    //Worksheet sheet_1 = workbook.Worksheets["데이터"];
                    Worksheet sheet_1 = workbook.Worksheets[1];
                    Worksheet sheet_0 = workbook.Worksheets[0];
                    // Worksheet sheet_2 = workbook.Worksheets["저장용 데이터"];
                    Range data_range = sheet_1.GetDataRange();
                    sheet_1.Clear(data_range);
                    ExternalDataSourceOptions dsOptions = new ExternalDataSourceOptions();
                    dsOptions.ImportHeaders = true;
                    sheet_1.DataBindings.BindToDataSource(_dtList, 3, 0, dsOptions);
                    sheet_1.DataBindings.BindToDataSource(_dtList2, 0, 0, dsOptions);
                    //string Select_PartType = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_TYPE").ToString();
                    //Worksheet sheet_1 = workbook.Worksheets["데이터"];
                    string Select_PartType = "1003";// sheet_1.GetCellValue(8, 1).ToString();//_gdMAIN_VIEW.GetFocusedRowCellValue("PART_TYPE").ToString();
                    string name_tmp = string.Empty;
                    if (Select_PartType == "1001")
                    {
                        
                    }
                    else if (Select_PartType == "1003")
                    {
                      //  sheet_0.Cells["G7"].SetValue(_dtList2.Rows[0]["make_no"]);
                        _dtList4 = _dsList.Tables[2];
                        string menufacture_data = string.Empty;
                        //제조공정
                        //고도화 이후, 품목마다 공정 매핑 수정필요
                        /*
                         * 
                         string menufacture_seq = string.Empty;
                        for (int i =0; i< _dtList4.Rows.Count;i++)
                        {
                            menufacture_seq +="공정 " + (i + 1) + ":" + _dtList4.Rows[i]["PROCESS_NAME"] + "\n" + _dtList4.Rows[i]["PROCESS_VALUE"] + "\n";
                            sheet_0.Cells["M11"].SetValue(menufacture_seq);
                        }
                        */
                        menufacture_data = _dtList4.Rows[0]["PROCESS_VALUE"].ToString();
                        sheet_0.Cells["M11"].SetValue(menufacture_data);
                       
                        
                    }
                    if (_dtList.Rows.Count == 0)
                    {
                        // CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                    }
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
        private void _btCancle_Click(object sender, EventArgs e)
        {
            if (_Close_Click != null)
                _Close_Click(sender, e);
        }

        #region 접수_프로시져
        private void _ucbtAccept_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void _ucbtSave_Click(object sender, EventArgs e)
        {
            _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.SelectedCells);
            _pucWorkOrderDocRegPopupEntity.CRUD = "C";
          //  InputData_Save(_gdMAIN_VIEW.GridControl.DataSource as DataTable);


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
                    new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUSER_CODE, "제조/작업지시서", _pWINDOW_NAME, "PC Save Event", "_ucbtPCSave", "Button event is executed " + "작업지시번호 : " + pPRODUCTION_ORDER_ID);

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
                //this.Text
                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUSER_CODE, "제조/작업지시서", _pWINDOW_NAME, "Print Event", "_ucbtPrint", "Button event is executed "+"작업지시번호 : "+ pPRODUCTION_ORDER_ID);
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
