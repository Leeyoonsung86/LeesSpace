using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Entity;
using DevExpress.XtraGrid.Views.Grid;

using CoFAS_MES.UI.PO.Entity;
using CoFAS_MES.UI.PO.Business;

namespace CoFAS_MES.UI.PO.UserControls
{
    public partial class ucWorkResultPopUp_T02 : UserControl
    {
        #region ○ 기본 전역변수 영역

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
        private ucWorkResultPopUp_T02_Entity _pucWorkResultPopUp_T02_Entity = null;

        private string qWORK_ORDERID = string.Empty;
        private string qPART_CODE = string.Empty;
        private string qPART_NAME = string.Empty;
        private string qPROCESS_CODE = string.Empty;
        //private string qTERMINAL_CODE = string.Empty;

        private static object[] _pARRAY = null;
        private static object[] _pARRAY_CODE = null;

        #endregion

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

        #region ○ 생성자 영역

        public ucWorkResultPopUp_T02()
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
        private void ucWorkResultPopUp_T02_Load(object sender, EventArgs e)
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

                _pucWorkResultPopUp_T02_Entity = new ucWorkResultPopUp_T02_Entity();
                _pucWorkResultPopUp_T02_Entity.CORP_CODE = _pCORP_CODE;
                _pucWorkResultPopUp_T02_Entity.USER_CODE = _pUSER_CODE;
                _pucWorkResultPopUp_T02_Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

                qWORK_ORDERID = _pARRAY_CODE[0].ToString();
                qPART_CODE = _pARRAY_CODE[1].ToString();
                qPART_NAME = _pARRAY_CODE[2].ToString();
                qPROCESS_CODE = _pARRAY_CODE[3].ToString();
                //qTERMINAL_CODE = _pARRAY_CODE[4].ToString();
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

        }

        #endregion

        #region ○ InitializeControl()

        private void InitializeControl()
        {
            try
            {
                _luRESULT_GUBN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "RESULT_GUBN_BUMAH", "", "", "").Tables[0], 0, 0, "", false);
                _luPROCESS_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "WORKCENTER_BUMA", "", "", "").Tables[0], 0, 0, "", false);
                _luPROCESS_CODE.ReadOnly = true;

                String ProcessCode = _luPROCESS_CODE.GetValue();
                _luTERMINAL_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "POP_TERMINALE_DETAIL3", ProcessCode, "", "").Tables[0], 0, 0, "", false);
                _luTERMINAL_CODE.ReadOnly = false;                  

                _luBAD_GROUP.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "POP_BAD1_CODE", "", "", "").Tables[0], 0, 0, "", false);
                _luSTATUS_GROUP.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "POP_STOP1_CODE", "", "", "").Tables[0], 0, 0, "", false);

                _luWORKORDERID.Text = qWORK_ORDERID;
                _luPART_CODE.Text = qPART_CODE;
                _luPART_NAME.Text = qPART_NAME;
                _luPROCESS_CODE.SetValue(qPROCESS_CODE);
                //_luTERMINAL_CODE.SetValue(qTERMINAL_CODE);
                _luRESULT_QTY.Text = "0";
                _luSTATUS_TIME.Text = "";
                _luSTATUS_TIME.UseMaskAsDisplayFormat = true;
                _luSTATUS_TIME.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                _luSTATUS_TIME.EditMask = "\\d\\d\\d\\d-\\d\\d-\\d\\d / \\d\\d:\\d\\d:\\d\\d";
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ LookupEdit ValueChanged event

        private void _luBAD_GROUP_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _luBAD_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "POP_BAD2_CODE", _luBAD_GROUP.GetValue(), "", "").Tables[0], 0, 0, "", false);
            }
            catch (ExceptionManager pExceptionManager)
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

                switch (pResult_Gubn)
                {
                    case "양품실적":
                        _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        _lciBAD_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        _lciBAD_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        _lciSTATUS_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        _lciSTATUS_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        _lciSTATUS_TIME.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        break;
                    case "불량실적":
                        _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        _lciBAD_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        _lciBAD_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        _lciSTATUS_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        _lciSTATUS_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        _lciSTATUS_TIME.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        break;
                    case "상태":
                        _lciRESULT_QTY.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        _lciBAD_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        _lciBAD_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        _lciSTATUS_GROUP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        _lciSTATUS_CODE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        _lciSTATUS_TIME.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        break;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);
        private void _ucbtCancle_Click(object sender, EventArgs e)
        {
            if (_Close_Click != null)
                _Close_Click(sender, e);
        }

        private void _ucbtSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                //DialogResult pDialogResult = CoFAS_DevExpressManager.ShowQuestionMessage("실적을 저장하시겠습니까?");
                DialogResult pDialogResult = CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION);

                if (pDialogResult == DialogResult.Yes)
                {
                    //_pucWorkResultPopUp_T02_Entity.RESOURCE_CODE = _luPROCESS_CODE.GetValue();
                    _pucWorkResultPopUp_T02_Entity.RESOURCE_CODE = _luTERMINAL_CODE.GetValue();                    
                    _pucWorkResultPopUp_T02_Entity.COLLECTION_DATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                    _pucWorkResultPopUp_T02_Entity.PROPERTY_VALUE = _luWORKORDERID.Text;

                    switch (_luRESULT_GUBN.GetValue().ToString())
                    {
                        case "CD501001":
                            _pucWorkResultPopUp_T02_Entity.CONDITION_CODE = _luRESULT_GUBN.GetValue();
                            _pucWorkResultPopUp_T02_Entity.COLLECTION_VALUE = _luRESULT_QTY.Text.Replace(",", "");
                            //_pucWorkResultPopUp_T02_Entity.CONDITION_CODE = "CD501001";
                            break;
                        case "CD501002":
                            _pucWorkResultPopUp_T02_Entity.CONDITION_CODE = _luBAD_CODE.GetValue();
                            _pucWorkResultPopUp_T02_Entity.COLLECTION_VALUE = _luRESULT_QTY.Text.Replace(",", "");
                            break;
                        case "CD501003":
                            _pucWorkResultPopUp_T02_Entity.CONDITION_CODE = _luSTATUS_CODE.GetValue();
                            DateTime pDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                            TimeSpan pTimeSpan = Convert.ToDateTime(_luSTATUS_TIME.Text.Replace("/ ", "")) - pDateTime;
                            _pucWorkResultPopUp_T02_Entity.COLLECTION_VALUE = pTimeSpan.TotalSeconds.ToString(); // Math.Floor(pTimeSpan.TotalSeconds).ToString(); // _luSTATUS_TIME.Text.Replace("-", "").Replace(" / ", "").Replace(":", "");
                            break;
                    }

                    //if (_luRESULT_GUBN.GetValue().ToString() == "CD501001")
                    //{
                    //    _pucWorkResultPopUp_T02_Entity.CONDITION_CODE = _luRESULT_GUBN.GetValue();
                    //    //_pucWorkResultPopUp_T02_Entity.CONDITION_CODE = "CD501001";
                    //}
                    //else if(_luRESULT_GUBN.GetValue().ToString() == "CD501002")
                    //{
                    //    _pucWorkResultPopUp_T02_Entity.CONDITION_CODE = _luBAD_CODE.GetValue();
                    //}
                    //else if(_luRESULT_GUBN.GetValue().ToString() == "CD501003")
                    //{

                    //}

                    bool isError = false;
                    isError = new ucWorkResultPopUp_T02Business().ucWorkResultPopUp_T02_Save(_pucWorkResultPopUp_T02_Entity);

                    if (!isError)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                        // 상태 - 완료 코드 입력시 
                        // 작업지시테이블에 업데이트 하기 완료여부 플래그
                        if (_luRESULT_GUBN.GetValue().ToString() == "CD501003" && _pucWorkResultPopUp_T02_Entity.CONDITION_CODE == "ES011003")
                        {
                            _pucWorkResultPopUp_T02_Entity.CRUD = "U";
                            _pucWorkResultPopUp_T02_Entity.PRODUCTION_ORDER_ID = _pucWorkResultPopUp_T02_Entity.PROPERTY_VALUE;
                            _pucWorkResultPopUp_T02_Entity.COMPLETE_YN = "Y";

                            isError = new ucWorkResultPopUp_T02Business().usWorkResultPopUp_T02_Save_01(_pucWorkResultPopUp_T02_Entity);

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
    }
    }
