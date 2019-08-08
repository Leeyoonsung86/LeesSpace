using CoFAS_MES.CORE.BaseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using CoFAS_MES.UI.PM.Business;
using CoFAS_MES.UI.PM.Entity;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Business;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.UserForm;
using DevExpress.XtraSpreadsheet;
using DevExpress.Spreadsheet;

namespace CoFAS_MES.UI.PM
{ 
    public partial class ProductOutRegister_T04 : frmBaseNone
    {

        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭
        public string _p_Saved_YN = string.Empty;       // 삭제된건지 아닌지
        private bool _pOpenPopup_YN = false;              // 저장위치 사용여부
        private string _pUSER_GRANT = string.Empty; // 사용자 권한

        private string _pINOUT_CODE_LIST = string.Empty;     // 출력용 선택 품목 리스트

        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보
        private SpreadsheetControl _sdMAIN = null;
        private Object _ojList = null;    //엑셀파일  //추가
        private DataSet _stList = null;   //DataSet  //추가
        private DataSet _dsList = null; //조회 데이터 리스트 데이터셋
        private DataTable _dtList2 = null; //조회 발신 데이터 리스트

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

        //알림창메시지 복사 끝

        private decimal _pLEAVE_QTY = 0;                     //남은 수주수량
        private decimal _pSHIPMENT_ORDER_QTY = 0;                  //수주수량
        private decimal _pTOTAL_INOUT_QTY = 0;               //총 출고수량
        private decimal _pBefore_inout_Qty = 0;               //기존 출고수량

        private ProductOutRegister_T04Entity _pProductOutRegister_T04Entity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용



        public ProductOutRegister_T04()
        {
            InitializeComponent();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }


        //폼 이벤트 처리 영역
        #region ○ Form_Activated
        private void Form_Activated(object pSender, EventArgs pEventArgs)
        {
            try
            {
                InitializeButtons();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ Form_Closing

        private void Form_Closing(object pSender, FormClosingEventArgs pFormClosingEventArgs)
        {
            try
            {

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업 종료 하겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                {
                    pFormClosingEventArgs.Cancel = true;
                    return;
                }

                pFormClosingEventArgs.Cancel = false;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ Form_FormClosed

        private void Form_FormClosed(object pSender, FormClosedEventArgs pFormClosedEventArgs)
        {
            try
            {
                //화면 레이아웃 저장 ?
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ Form_Load
        private void Form_Load(object pSender, EventArgs pEventArgs)
        {
            try
            {
                InitializeSetting();

                //버튼이벤트 생성
                SearchButtonClicked += new EventHandler(Form_SearchButtonClicked);
                SaveButtonClicked += new EventHandler(Form_SaveButtonClicked);
                AddItemButtonClicked += new EventHandler(Form_AddItemButtonClicked);
                DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
                PrintButtonClicked += new EventHandler(Form_PrintButtonClicked);
                ExportButtonClicked += new EventHandler(Form_ExportButtonClicked);
                ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                SettingButtonClicked += new EventHandler(Form_SettingButtonClicked);

                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = _pFONT_SETTING;//화면에 모든 항목 폰트 재설정
            }
        }
        #endregion

        // 초기화 처리 영역
        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
                _pnHeader.Visible = true;
                _pnContent.Visible = true;
                _pnLeft.Visible = false;
                _pnLeft.Width = 500;
                _ucbtSTOCK_SEARCH.Visible = false;
                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;

                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_PATH = MainForm.UserEntity.FTP_IP_PORT; //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //발주서는 ORDER_FORM // 화면조회용 PROGRAM_VIEW
                _pFTP_PW = MainForm.UserEntity.FTP_PW;
                _pUSER_GRANT = MainForm.UserEntity.USER_GRANT;

                //메인 화면 공통 메세지 처리

                _pMSG_SEARCH = MainForm.MessageEntity.MSG_SEARCH;
                _pMSG_SEARCH_EMPT = MainForm.MessageEntity.MSG_SEARCH_EMPT;
                _pMSG_SAVE_QUESTION = MainForm.MessageEntity.MSG_SAVE_QUESTION;
                _pMSG_SAVE = MainForm.MessageEntity.MSG_SAVE;
                _pMSG_SAVE_ERROR = MainForm.MessageEntity.MSG_SAVE_ERROR;
                _pMSG_DELETE_QUESTION = MainForm.MessageEntity.MSG_DELETE_QUESTION;
                _pMSG_DELETE = MainForm.MessageEntity.MSG_DELETE;
                _pMSG_DELETE_ERROR = MainForm.MessageEntity.MSG_DELETE_ERROR;
                _pMSG_DELETE_COMPLETE = MainForm.MessageEntity.MSG_DELETE_COMPLETE;
                _pMSG_INPUT_DATA = MainForm.MessageEntity.MSG_INPUT_DATA;
                _pMSG_INPUT_DATA_ERROR = MainForm.MessageEntity.MSG_INPUT_DATA_ERROR;
                _pMSG_WORKING = MainForm.MessageEntity.MSG_WORKING;
                _pMSG_RESET_QUESTION = MainForm.MessageEntity.MSG_RESET_QUESTION;
                _pMSG_EXIT_QUESTION = MainForm.MessageEntity.MSG_EXIT_QUESTION;
                _pMSG_SELECT = MainForm.MessageEntity.MSG_SELECT;
                //추가
                _pMSG_PLZ_CONNECT_FTP = MainForm.MessageEntity.MSG_PLZ_CONNECT_FTP;
                _pMSG_AGAIN_INPUT_DATA = MainForm.MessageEntity.MSG_AGAIN_INPUT_DATA;
                _pMSG_DOWNLOAD_COMPLETE = MainForm.MessageEntity.MSG_DOWNLOAD_COMPLETE;
                _pMSG_SEARCH_EMPT_DETAIL = MainForm.MessageEntity.MSG_SEARCH_EMPT_DETAIL;
                _pMSG_SPLITQTY_LARGE_MORE = MainForm.MessageEntity.MSG_SPLITQTY_LARGE_MORE;
                _pMSG_DELETE_ERROR_NO_DATA = MainForm.MessageEntity.MSG_DELETE_ERROR_NO_DATA;
                _pMSG_ORDERQTY_LARGE_THAN_0 = MainForm.MessageEntity.MSG_ORDERQTY_LARGE_THAN_0;
                _pMSG_PLAN_LARGE_THAN_ORDER = MainForm.MessageEntity.MSG_PLAN_LARGE_THAN_ORDER;
                _pMSG_DELETE_ERROR_CONNECT_FTP = MainForm.MessageEntity.MSG_DELETE_ERROR_CONNECT_FTP;
                _pMSG_INPUT_LESS_THAN_NOTOUTQTY = MainForm.MessageEntity.MSG_INPUT_LESS_THAN_NOTOUTQTY;
                _pMSG_LOAD_DATA = MainForm.MessageEntity.MSG_LOAD_DATA;
                _pMSG_NEW_REG_GUBN = MainForm.MessageEntity.MSG_NEW_REG_GUBN;
                _pMSG_INPUT_NUMERIC = MainForm.MessageEntity.MSG_INPUT_NUMERIC;
                _pMSG_NO_SELETED_ITEM = MainForm.MessageEntity.MSG_NO_SELETED_ITEM;
                _pMSG_EXIST_COMPANY_ID = MainForm.MessageEntity.MSG_EXIST_COMPANY_ID;
                _pMSG_NOT_DELETE_DATA_IN = MainForm.MessageEntity.MSG_NOT_DELETE_DATA_IN;
                _pMSG_NOT_MODIFY_DATA_IN = MainForm.MessageEntity.MSG_NOT_MODIFY_DATA_IN;
                _pMSG_SELECT_NEWREG_SAVE = MainForm.MessageEntity.MSG_SELECT_NEWREG_SAVE;
                _pMSG_INPUT_LARGER_THAN_0 = MainForm.MessageEntity.MSG_INPUT_LARGER_THAN_0;
                _pMSG_NOT_DELETE_DATA_OUT = MainForm.MessageEntity.MSG_NOT_DELETE_DATA_OUT;
                _pMSG_NOT_MODIFY_DATA_OUT = MainForm.MessageEntity.MSG_NOT_MODIFY_DATA_OUT;
                _pMSG_CANCLE_NEWREG_MODIFY = MainForm.MessageEntity.MSG_CANCLE_NEWREG_MODIFY;
                _pMSG_NO_SELETED_ITEM_OR_NO_SAVE = MainForm.MessageEntity.MSG_NO_SELETED_ITEM_OR_NO_SAVE;
                _pMSG_NO_INPUT_LAGER_THAN_NOTINQTY = MainForm.MessageEntity.MSG_NO_INPUT_LAGER_THAN_NOTINQTY;
                _pMSG_REG_DATA = MainForm.MessageEntity.MSG_REG_DATA;
                _pMSG_ADD_FAVORITE_ITEM = MainForm.MessageEntity.MSG_ADD_FAVORITE_ITEM;
                _pMSG_CHECK_SEARCH_DATE = MainForm.MessageEntity.MSG_CHECK_SEARCH_DATE;
                _pMSG_NOT_DISPLAY_ERROR = MainForm.MessageEntity.MSG_NOT_DISPLAY_ERROR;
                _pMSG_NO_EXIST_INPUT_DATA = MainForm.MessageEntity.MSG_NO_EXIST_INPUT_DATA;
                _pMSG_NOT_DISPLAY_NOT_SAVE = MainForm.MessageEntity.MSG_NOT_DISPLAY_NOT_SAVE;
                _pMSG_CHECK_VALID_ITEM = MainForm.MessageEntity.MSG_CHECK_VALID_ITEM;
                _pMSG_DELETE_FAVORITE_ITEM = MainForm.MessageEntity.MSG_DELETE_FAVORITE_ITEM;
                _pMSG_NOT_EXIST_PRINTING_EXCEL = MainForm.MessageEntity.MSG_NOT_EXIST_PRINTING_EXCEL;
                _pMSG_SELECT_DOWNLOAD_TEMPLETE = MainForm.MessageEntity.MSG_SELECT_DOWNLOAD_TEMPLETE;
                _pMSG_RESET_COMPLETE = MainForm.MessageEntity.MSG_RESET_COMPLETE;

                _pWINDOW_NAME = this.Name;
                _pMENU_NAME = this.Text;

                //메뉴 화면 엔티티 설정
                _pProductOutRegister_T04Entity = new ProductOutRegister_T04Entity();
                _pProductOutRegister_T04Entity.CORP_CODE = _pCORP_CODE;
                _pProductOutRegister_T04Entity.USER_CODE = _pUSER_CODE;
                _pProductOutRegister_T04Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                //_pProductOutRegister_T04Entity.WINDOW_NAME = _pWINDOW_NAME;
                

                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //그리드 설정
                InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 

            

                if (_pFirstYN)
                {
                    //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                    _pProductOutRegister_T04Entity.CRUD = "";
                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                    _pFirstYN = false;
                }
             

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

                //그리드 버튼추가 시 클릭 이벤트 처리 
                // CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;
                //CoFAS_ControlManager.SetFontInControls(this.Controls, new Font("Arial", 8, FontStyle.Bold));
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 버튼 초기화 하기 - InitializeButtons()

        private void InitializeButtons()
        {
            try
            {
                MainFormButtonSetting pButtonSetting = new MainFormButtonSetting();

                pButtonSetting.UseYNSearchButton = _pMenuSettingEntity.MENU_SEARCH == "Y" ? true : false; // 조회
                pButtonSetting.UseYNExportButton = _pMenuSettingEntity.MENU_EXPORT == "Y" ? true : false; // 내보내기
                pButtonSetting.UseYNImportButton = _pMenuSettingEntity.MENU_IMPORT == "Y" ? true : false; // 가져오기
                pButtonSetting.UseYNPrintButton = _pMenuSettingEntity.MENU_PRINT == "Y" ? true : false; // 프린터
                pButtonSetting.UseYNSaveButton = _pMenuSettingEntity.MENU_SAVE == "Y" ? true : false; // 저장
                pButtonSetting.UseYNAddItemButton = _pMenuSettingEntity.MENU_ADDITEM == "Y" ? true : false; // 신규
                pButtonSetting.UseYNDeleteButton = _pMenuSettingEntity.MENU_DELETE == "Y" ? true : false; // 삭제

                pButtonSetting.UseYNInitialButton = true; // 초기화
                if (_pUSER_GRANT == "PC160001")
                {
                    pButtonSetting.UseYNSettingButton = true; // 설정
                }
                else
                {
                    pButtonSetting.UseYNSettingButton = false; // 설정
                }

                pButtonSetting.UseYNFormCloseButton = true; // 폼닫기

                MainForm.SetButtonSetting(pButtonSetting);

                

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 그리드 초기화 하기 - InitializeGrid()
        private void InitializeGrid()
        {
            try
            {
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                }

                //_gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pCORP_CDDE, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        #endregion

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl()
        {
            try
            {
                //조회조건 영역 
                _luTINOUT_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luTINOUT_DATE.ToDateTime = DateTime.Today;  //조회 종료일


                _luTPART_ALL.CodeText = "";
                _luTPART_ALL.NameText = "";
                _luTVEND_ALL.CodeText = "";
                _luTVEND_ALL.NameText = "";

                //_luTINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code_PD_T01", "", "", "").Tables[0], 0, 0, "", true);
                _luTINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "PD02", "", "").Tables[0], 0, 0, "", true);
                _luTINOUT_CODE.ItemIndex = 0;

                
                _luINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "PD02", "", "").Tables[0], 0, 0, "");
                _luINOUT_CODE.ItemIndex = 0;

                _luTUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                _luTUSE_YN.ItemIndex = 0;
                _luTREFERENCE_ID.Text = "";
                _luTINOUT_ID.Text = "";

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");

                //데이터 영역
                _luINOUT_ID.Text = "";
                _luINOUT_ID.ReadOnly = true;

                _luINOUT_DATE.DateTime = DateTime.Today;  //조회 종료일, 당일 설정

                _luPART_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                _luPART_UNIT.ReadOnly = true;

                //_luREFERENCE_ID.Text = "";
                //_luREFERENCE_ID.ReadOnly = true;

                _luPART_ALL.CodeText = "";
                _luPART_ALL.NameText = "";
                _luPART_ALL.CodeReadOnly = true;
                _luPART_ALL.NameReadOnly = true;
                _luVEND_ALL.CodeText = "";
                _luVEND_ALL.NameText = "";
                _luVEND_ALL.CodeReadOnly = true;
                _luVEND_ALL.NameReadOnly = true;

                _luINOUT_QTY.Text = "0";
                _luUNITCOST.Text = "0";

                _luUNITCOST.Properties.MaxLength = 11;
                _luINOUT_QTY.Properties.MaxLength = 11;

                _luCOST.Text = "0";
                _luCOST.ReadOnly = true;

                _luREMARK.Text = "";
                _luREMARK.ReadOnly = false;

                _luREFERENCE_ID.Text = "";
                _luREFERENCE_ID.ReadOnly = true;

                _luINOUT_CODE.ReadOnly = false;
                //_luINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code_PD_T01", "", "", "").Tables[0], 0, 0, "");
                //_luINOUT_CODE.ItemIndex = 0;
                //_luINOUT_CODE.ReadOnly = true;

                _gdMAIN.DataSource = null;

                _pLEAVE_QTY = 0;
                _pSHIPMENT_ORDER_QTY = 0;
                _pTOTAL_INOUT_QTY = 0;

                _luLEAVE_QTY.ReadOnly = true;
                _luLEAVE_QTY.Text = "";

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {

            }
        }

        #endregion

        #region ○ 조회 후 초기화 - InitializeSearch()

        private void InitializeSearch()
        {
            try
            {

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");

                //데이터 영역
                _luINOUT_ID.Text = "";
                _luINOUT_ID.ReadOnly = true;

                _luINOUT_DATE.DateTime = DateTime.Today;  //조회 종료일, 당일 설정

                _luPART_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                _luPART_UNIT.ReadOnly = true;

                //_luREFERENCE_ID.Text = "";
                //_luREFERENCE_ID.ReadOnly = true;

                _luPART_ALL.CodeText = "";
                _luPART_ALL.NameText = "";
                _luPART_ALL.CodeReadOnly = true;
                _luPART_ALL.NameReadOnly = true;
                _luVEND_ALL.CodeText = "";
                _luVEND_ALL.NameText = "";
                _luVEND_ALL.CodeReadOnly = true;
                _luVEND_ALL.NameReadOnly = true;

                _luINOUT_QTY.Text = "0";
                _luUNITCOST.Text = "0";

                _luUNITCOST.Properties.MaxLength = 11;
                _luINOUT_QTY.Properties.MaxLength = 11;

                _luCOST.Text = "0";
                _luCOST.ReadOnly = true;

                _luREMARK.Text = "";
                _luREMARK.ReadOnly = false;

                _luREFERENCE_ID.Text = "";
                _luREFERENCE_ID.ReadOnly = true;

                _luINOUT_CODE.ReadOnly = false;
                _luINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "PD02", "", "").Tables[0], 0, 0, "");
                _luINOUT_CODE.ItemIndex = 2;
                _luINOUT_CODE.ReadOnly = true;

                _pLEAVE_QTY = 0;
                _pSHIPMENT_ORDER_QTY = 0;
                _pTOTAL_INOUT_QTY = 0;

                _luLEAVE_QTY.ReadOnly = true;
                _luLEAVE_QTY.Text = "";
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {

            }
        }

        #endregion

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                CoFAS_ControlManager.Controls_Binding(gv, false, this); //
                _pProductOutRegister_T04Entity.CRUD = "R";
                _pSHIPMENT_ORDER_QTY = Convert.ToDecimal(gv.GetFocusedRowCellValue("SHIPMENT_ORDER_QTY").ToString());
                _pTOTAL_INOUT_QTY = Convert.ToDecimal(gv.GetFocusedRowCellValue("TOTAL_INOUT_QTY").ToString());
                _pLEAVE_QTY = _pSHIPMENT_ORDER_QTY - _pTOTAL_INOUT_QTY;
                _pBefore_inout_Qty = Convert.ToDecimal(gv.GetFocusedRowCellValue("INOUT_QTY").ToString());
                _p_Saved_YN = gv.GetFocusedRowCellValue("USE_YN").ToString();
                _pOpenPopup_YN = false;
                //if(_luINOUT_CODE.GetValue()=="PD040020")
                //    _luINOUT_CODE.ReadOnly = true;
                //else
                //    _luINOUT_CODE.ReadOnly = false;

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 그리드 버튼추가 시 클릭 이벤트 생성 - CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        private void CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //_gdMAIN_VIEW.EditingValue = "";
            switch (e.Button.Caption.ToString())
            {
                case "TEST": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.
                    frmCommonPopup.CORP_CDDE = _pCORP_CODE;
                    frmCommonPopup.USER_CODE = _pUSER_CODE;
                    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    frmCommonPopup.ARRAY = new object[2] { "common_code", "CD99" }; //넘기는 파라메터 에 따라 설정

                    frmCommonPopup xfrmcommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                    xfrmcommonPopup.ShowDialog();

                    if (xfrmcommonPopup.dtReturn == null) return;

                    xfrmcommonPopup.dtReturn.Rows[0][0].ToString();
                    // 리턴 받는 데이터의 값은 해당 그리드 뷰 필드에 설정.
                    //_gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["TEST1"], xfrmcommonPopup.dtReturn.Rows[0]["CD"].ToString());
                    //_gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["TEST2"], xfrmcommonPopup.dtReturn.Rows[0]["CD_NM"].ToString());
                    xfrmcommonPopup.Dispose();
                    break;

            }
        }

        #endregion


        // 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                if (_luTINOUT_DATE.FromDateTime > _luTINOUT_DATE.ToDateTime)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 일자를 확인해 주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_SEARCH_DATE);
                    return;
                }
                _pProductOutRegister_T04Entity.CRUD = "R";
                _pProductOutRegister_T04Entity.DATE_FROM = DateTime.Parse(_luTINOUT_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");// Convert.ToString(_luTINOUT_DATE.FromDateTime).Substring(0, 10).Replace("-", "");
                _pProductOutRegister_T04Entity.DATE_TO = DateTime.Parse(_luTINOUT_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");// Convert.ToString(_luTINOUT_DATE.ToDateTime).Substring(0, 10).Replace("-", "");
                _pProductOutRegister_T04Entity.VEND_CODE = _luTVEND_ALL.CodeText;
                _pProductOutRegister_T04Entity.VEND_NAME = _luTVEND_ALL.NameText;
                _pProductOutRegister_T04Entity.PART_CODE = _luTPART_ALL.CodeText;
                _pProductOutRegister_T04Entity.PART_NAME = _luTPART_ALL.NameText;
                _pProductOutRegister_T04Entity.REFERENCE_ID = _luTREFERENCE_ID.Text;
                _pProductOutRegister_T04Entity.INOUT_ID = _luTINOUT_ID.Text;
                _pProductOutRegister_T04Entity.INOUT_CODE = _luTINOUT_CODE.GetValue();
                _pProductOutRegister_T04Entity.USE_YN = _luTUSE_YN.GetValue();
                MainFind_DisplayData();
                InitializeSearch();

                _pLEAVE_QTY = 0;
                _pSHIPMENT_ORDER_QTY = 0;
                _pTOTAL_INOUT_QTY = 0;

                //DisplayMessage("조회 되었습니다.");
                DisplayMessage(_pMSG_SEARCH);
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
        #region ○ 입력 데이터 조사하기 - CheckInputData()

        private bool CheckInputData()
        {
            bool pErrorYN = false;
            string pErrName = string.Empty;

            try
            {

                if (_luPART_ALL.CodeText == "")
                    pErrName += "품목코드. ";

                //일반출고는 거래처 없이도 출고 가능하게

                //생산출고
                if (_luINOUT_CODE.Text.Trim() != "일반출고")
                {
                    if (_luVEND_ALL.CodeText == "")
                        pErrName += "거래처코드. ";
                }
                if (_luINOUT_QTY.Text == "" || _luINOUT_QTY.Text == "0" || Convert.ToDecimal(_luINOUT_QTY.Text) < 1)
                    pErrName += "출고수량. ";

                if (pErrName != "")
                {
                    pErrorYN = true;
                    DisplayMessage(pErrName);
                }
            }
            catch (Exception pException)
            {
                pErrorYN = true;
                CoFAS_DevExpressManager.ShowErrorMessage(pException);
            }
            return pErrorYN;
        }

        #endregion
        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                    return;

                if (_luINOUT_CODE.Text.Trim() == "생산출고" && _luINOUT_ID.Text != "")
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("생산출고 데이터는 수정할 수 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_MODIFY_DATA_OUT);
                    return;
                }

                if (_luUNITCOST.Text == "")
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("단가를 입력해주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }
                if (!dxValidationProvider.Validate())
                {
                    return;
                }
                if (CheckInputData())
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("필수항목을 확인해주시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }

                string before_qty = _luINOUT_QTY.Text;

                //20181123 초과하여 출고가능하게
                /*
                if (_pOpenPopup_YN == true)
                    {
                        if (_luINOUT_CODE.Text.Trim() == "수주출고")
                        {
                            decimal pQTY = Convert.ToDecimal(_luINOUT_QTY.Text == "" ? "0.00" : _luINOUT_QTY.Text);

                            if (pQTY > _pLEAVE_QTY + _pBefore_inout_Qty)
                            {
                                //CoFAS_DevExpressManager.ShowInformationMessage("미출고수량보다 작게 입력해주세요.\n미출고수량 : " + _pLEAVE_QTY.ToString());
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_LESS_THAN_NOTOUTQTY + _pLEAVE_QTY.ToString());
                                // _luINOUT_QTY.Text = before_qty.ToString();
                                return;
                            }
                        }
                    }
                */
               

                //확인
                if (_luINOUT_ID.Text != "")
                {
                    _pProductOutRegister_T04Entity.CRUD = "U";
                }
                else
                {
                    _pProductOutRegister_T04Entity.CRUD = "C";
                }
             
                _pProductOutRegister_T04Entity.INOUT_ID = _luINOUT_ID.Text;
                _pProductOutRegister_T04Entity.INOUT_DATE = _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                _pProductOutRegister_T04Entity.INOUT_TYPE = "O";  //무조건 입력
                _pProductOutRegister_T04Entity.INOUT_CODE = _luINOUT_CODE.GetValue();
                _pProductOutRegister_T04Entity.REFERENCE_ID = _luREFERENCE_ID.Text;
                _pProductOutRegister_T04Entity.PART_CODE = _luPART_ALL.CodeText;
                _pProductOutRegister_T04Entity.PART_NAME = _luPART_ALL.NameText;
                _pProductOutRegister_T04Entity.VEND_CODE = _luVEND_ALL.CodeText;
                _pProductOutRegister_T04Entity.VEND_NAME = _luVEND_ALL.NameText;
                _pProductOutRegister_T04Entity.INOUT_QTY = _luINOUT_QTY.Text;
                _pProductOutRegister_T04Entity.UNITCOST = _luUNITCOST.Text;
                _pProductOutRegister_T04Entity.COST = _luCOST.Text;
                _pProductOutRegister_T04Entity.REMARK = _luREMARK.Text;
                _pProductOutRegister_T04Entity.USE_YN = _luUSE_YN.GetValue();

                if (_p_Saved_YN == "Y")
                {
                    if (_pProductOutRegister_T04Entity.USE_YN == "N")
                        _pProductOutRegister_T04Entity.CRUD = "D";
                }
                if (_p_Saved_YN == "N")
                {
                    if (_pProductOutRegister_T04Entity.USE_YN == "Y")
                        _pProductOutRegister_T04Entity.CRUD = "Y";
                }

                InputData_Save(_pProductOutRegister_T04Entity);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            catch (Exception pException)
            {
                DisplayMessage(string.Format("{0}", pException));
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        #region ○ 신규 버튼 클릭시 처리하기
        private void Form_AddItemButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

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

        #region ○ 삭제 버튼 클릭시 처리하기
        private void Form_DeleteButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                    return;
                //확인
                if (_luINOUT_ID.Text == "")  //출고번호가 없는 것 신규등록 경우 
                {
                    //삭제 못함
                    //CoFAS_DevExpressManager.ShowInformationMessage("삭제할 데이터가 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE_ERROR_NO_DATA);
                    return;
                }
                else
                {
                    _pProductOutRegister_T04Entity.CRUD = "D";
                }
                if (_luINOUT_CODE.Text.Trim() == "생산출고")
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("생산출고 데이터는 삭제할 수 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_DELETE_DATA_OUT);
                    return;
                }
                //if (CoFAS_DevExpressManager.ShowQuestionMessage("출고 데이터를 삭제하시겠습니까? \n입고번호 : " + _luINOUT_ID.Text) == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_DELETE_QUESTION + _luINOUT_ID.Text) == DialogResult.No)
                {
                    return;
                }

                

                _pProductOutRegister_T04Entity.INOUT_ID = _luINOUT_ID.Text;
                _pProductOutRegister_T04Entity.INOUT_DATE = _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                _pProductOutRegister_T04Entity.INOUT_TYPE = "O";  //무조건 입력
                _pProductOutRegister_T04Entity.INOUT_CODE = _luINOUT_CODE.GetValue();
                _pProductOutRegister_T04Entity.REFERENCE_ID = _luREFERENCE_ID.Text;
                _pProductOutRegister_T04Entity.PART_CODE = _luPART_ALL.CodeText;
                _pProductOutRegister_T04Entity.PART_NAME = _luPART_ALL.NameText;
                _pProductOutRegister_T04Entity.VEND_CODE = _luVEND_ALL.CodeText;
                _pProductOutRegister_T04Entity.VEND_NAME = _luVEND_ALL.NameText;
                _pProductOutRegister_T04Entity.INOUT_QTY = _luINOUT_QTY.Text;
                _pProductOutRegister_T04Entity.UNITCOST_CURRENCY_CODE = _luPART_UNIT.GetValue();
                _pProductOutRegister_T04Entity.UNITCOST = _luUNITCOST.Text;
                _pProductOutRegister_T04Entity.COST = _luCOST.Text;
                _pProductOutRegister_T04Entity.REMARK = _luREMARK.Text;
                _pProductOutRegister_T04Entity.USE_YN = "N";
                InputData_Save(_pProductOutRegister_T04Entity);

                InitializeControl();
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

        #region ○ 인쇄 버튼 클릭시 처리하기
        private void Form_PrintButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;


                //같은 없체인지 체크
                string before_vend = string.Empty;
                int cnt = 0;

                _pINOUT_CODE_LIST = "AND A.inout_id IN (";

                for (int i = 0; i < tDataTable.Rows.Count; i++)
                {
                    if (tDataTable.Rows[i]["CRUD"].ToString() == "Y")
                    {
                        ////처음꺼 업체코드 저장
                        //if (cnt == 0)

                        //{
                        //    before_vend = tDataTable.Rows[i]["PART_CODE"].ToString();
                        //}


                        //if (tDataTable.Rows[i]["PART_CODE"].ToString() != before_vend)
                        //{
                        //    CoFAS_DevExpressManager.ShowInformationMessage("동일한 자재만 입고일지를 발급할 수 있습니다.");
                        //    return;
                        //}

                        _pINOUT_CODE_LIST = _pINOUT_CODE_LIST + "'" + tDataTable.Rows[i]["INOUT_ID"].ToString() + "'";

                        if (i + 1 < tDataTable.Rows.Count)
                        {
                            if (tDataTable.Rows[i + 1]["INOUT_ID"].ToString() != null || tDataTable.Rows[i + 1]["INOUT_ID"].ToString() != "")
                            {
                                _pINOUT_CODE_LIST = _pINOUT_CODE_LIST + ",";
                            }
                        }

                        cnt++;
                    }
                }

                _pINOUT_CODE_LIST = _pINOUT_CODE_LIST + ")";

                if (_pINOUT_CODE_LIST.Contains(",)"))
                {
                    _pINOUT_CODE_LIST = _pINOUT_CODE_LIST.Remove(_pINOUT_CODE_LIST.Length - 1, 1);
                    _pINOUT_CODE_LIST = _pINOUT_CODE_LIST.Remove(_pINOUT_CODE_LIST.Length - 1, 1);
                    _pINOUT_CODE_LIST = _pINOUT_CODE_LIST + ")";
                }

                if (cnt == 0)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SELECT);
                    return;
                }

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                string strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pWINDOW_NAME);
                //string strFTP_PATH = string.Format()

                PM.UserForm.frmCommonPopup.CRUD = "R";
                PM.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                PM.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                PM.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
                PM.UserForm.frmCommonPopup.FTP_ID = _pFTP_ID;
                PM.UserForm.frmCommonPopup.FTP_PW = _pFTP_PW;
                PM.UserForm.frmCommonPopup.strFile_NAME = "ProductOutRegister_T04.xlsx";
                PM.UserForm.frmCommonPopup.strFTP_PATH = strFTP_PATH;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                PM.UserForm.frmCommonPopup.ARRAY = new object[3] { "", "", "" };
                PM.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { 'R', _pINOUT_CODE_LIST };
                PM.UserForm.frmCommonPopup xfrmCommonPopup = new PM.UserForm.frmCommonPopup("ucExcelViewPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }
                if (xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                }

                xfrmCommonPopup.Dispose();
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

        #region 숫자 -> 한글로
        static public string Number2Hangle(Double lngNumber)
        {
            bool UseDecimal = false;
            string Sign = "";
            int i = 0;
            int Level = 0;

            string[] NumberChar = new string[] { "", "일", "이", "삼", "사", "오", "육", "칠", "팔", "구" };
            string[] LevelChar = new string[] { "", "십", "백", "천" };
            string[] DecimalChar = new string[] { "", "만", "억", "조", "경" };

            string strValue = string.Format("{0}", lngNumber);
            string NumToKorea = Sign;
            UseDecimal = false;

            for (i = 0; i < strValue.Length; i++)
            {
                Level = strValue.Length - i;
                if (strValue.Substring(i, 1) != "0")
                {
                    UseDecimal = true;
                    if (((Level - 1) % 4) == 0)
                    {
                        NumToKorea = NumToKorea + NumberChar[int.Parse(strValue.Substring(i, 1))] + DecimalChar[(Level - 1) / 4];
                        UseDecimal = false;
                    }
                    else
                    {
                        if (strValue.Substring(i, 1) == "1")
                        {
                            NumToKorea = NumToKorea + LevelChar[(Level - 1) % 4];
                        }
                        else
                        {
                            NumToKorea = NumToKorea + NumberChar[int.Parse(strValue.Substring(i, 1))] + LevelChar[(Level - 1) % 4];
                        }
                    }
                }
                else
                {
                    if ((Level % 4 == 0) && UseDecimal)
                    {
                        NumToKorea = NumToKorea + DecimalChar[Level / 4];
                        UseDecimal = false;
                    }
                }
            }
            return NumToKorea;
        }
        #endregion

        #region ○ 내보내기 버튼 클릭시 처리하기
        private void Form_ExportButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //if (fpMain.ActiveSheet.RowCount > 0)
                //{
                //    SaveFileDialog mDlg = new SaveFileDialog();
                //    mDlg.InitialDirectory = Application.StartupPath;
                //    mDlg.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
                //    mDlg.FilterIndex = 1;
                //    if (mDlg.ShowDialog() == DialogResult.OK)
                //    {
                //        fpMain.SaveExcel(mDlg.FileName, FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders);
                //        DevExpressManager.ShowInformationMessage("저장이 완료 되었습니다.");
                //    }
                //}
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

        #region ○ 가져오기 버튼 클릭시 처리하기
        private void Form_ImportButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);


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

        #region ○ 초기화 버튼 클릭시 처리하기
        private void Form_InitialButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                InitializeSetting();
                GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                CoFAS_ControlManager.Controls_Binding(gv, true, this);
                //_luINOUT_CODE.ReadOnly = false;
                _luINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "PD02", "", "").Tables[0], 0, 0, "");
                _luINOUT_CODE.ItemIndex = 1;
                //_luINOUT_CODE.ReadOnly = true;

                _luPART_UNIT.ReadOnly = false;
                _luPART_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                _luPART_UNIT.ReadOnly = true;

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");

                _p_Saved_YN = string.Empty;
                //DisplayMessage("초기화했습니다.");
                DisplayMessage(_pMSG_RESET_COMPLETE);
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

        #region ○ 화면 설정 버튼 클릭시 처리하기 - 언어 및 화면 컨트롤러 명칭 변경 설정
        private void Form_SettingButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                CoFAS_MES.CORE.UserForm.frmPageSetting xfrmPageSetting = new CORE.UserForm.frmPageSetting();
                //xfrmPageSetting.PASS_CORP_CODE = _pCORP_CODE;
                xfrmPageSetting.PASS_PARENT_WINDOW_NAME = _pWINDOW_NAME;
                xfrmPageSetting.PASS_USER_CODE = _pUSER_CODE;
                xfrmPageSetting.PASS_PARENT_LANGUAGE = _pLANGUAGE_TYPE;
                xfrmPageSetting.PASS_PARENT_FONT = _pFONT_SETTING;
                xfrmPageSetting.ShowDialog();

                if (xfrmPageSetting.PASS_RESULT)
                {
                    InitializeSetting();

                    xfrmPageSetting.Dispose();
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

        #region ○ 닫기 버튼 클릭시 처리하기
        private void Form_FormCloseButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUSER_CODE, _pMENU_NAME, _pWINDOW_NAME, "Menu Close Event", "Form_FormCloseButton", "Button event is executed");
                Close(); //탭 화면 닫기
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

                _dtList = new ProductOutRegister_T04Business().ProductOutRegister_T04_Info(_pProductOutRegister_T04Entity);

                if (_pProductOutRegister_T04Entity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductOutRegister_T04Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("INOUT_ID", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        {
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;
                            _luINOUT_ID.Text = _pLocation_Code;
                        }
                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }
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

        #region ○ 서브조회 - SubFind_DisplayData() 사용 X

        //private void SubFind_DisplayData(string strWINDOW_NAME, string strGRID_NAME)
        //{
        //    try
        //    {
        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

        //        //_pGridInfoRegisterEntity.WINDOW_NAME = strWINDOW_NAME;
        //        //_pGridInfoRegisterEntity.GRID_NAME = strGRID_NAME;

        //        _dtList = new ProductOutRegister_T04Business().Sample_Info_Sub(_pProductOutRegister_T04Entity);

        //        if (_pProductOutRegister_T04Entity.CRUD == "") _dtList.Rows.Clear();

        //        if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductOutRegister_T04Entity.CRUD == ""))
        //        {
        //            // CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
        //        }
        //        else
        //        {
        //            CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
        //    }
        //    finally
        //    {
        //        // _gdSUB_VIEW.BestFitColumns();

        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
        //    }
        //}

        #endregion

        #region ○ 저장 - InputData_Save(ProductOutRegister_T04Entity _pProductOutRegister_T04Entity) 

        private void InputData_Save(ProductOutRegister_T04Entity _pProductOutRegister_T04Entity)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;



                    isError = new ProductOutRegister_T04Business().ProductOutRegister_T04_Info_Save(_pProductOutRegister_T04Entity);

                if (isError)
                {
                    //오류 발생.
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.
                }
                else
                {
                   
                        
                    _pLocation_Code = _pProductOutRegister_T04Entity.RTN_KEY;  //저장 위치 

                    //InitializeSetting(); //초기화

                    //InitializeControl();

                    // 화면 갱신
                    _pProductOutRegister_T04Entity.CRUD = "R";
                    _pProductOutRegister_T04Entity.DATE_FROM = DateTime.Parse(_luTINOUT_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");// Convert.ToString(_luTINOUT_DATE.FromDateTime).Substring(0, 10).Replace("-", "");
                    _pProductOutRegister_T04Entity.DATE_TO = DateTime.Parse(_luTINOUT_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");// Convert.ToString(_luTINOUT_DATE.ToDateTime).Substring(0, 10).Replace("-", "");
                    _pProductOutRegister_T04Entity.VEND_CODE = _luTVEND_ALL.CodeText;
                    _pProductOutRegister_T04Entity.VEND_NAME = _luTVEND_ALL.NameText;
                    _pProductOutRegister_T04Entity.PART_CODE = _luTPART_ALL.CodeText;
                    _pProductOutRegister_T04Entity.PART_NAME = _luTPART_ALL.NameText;
                    _pProductOutRegister_T04Entity.REFERENCE_ID = _luTREFERENCE_ID.Text;
                    _pProductOutRegister_T04Entity.INOUT_ID = _luINOUT_ID.Text;
                    _pProductOutRegister_T04Entity.INOUT_CODE = _luTINOUT_CODE.GetValue();
                    _pProductOutRegister_T04Entity.USE_YN = _luTUSE_YN.GetValue();
                    Form_SearchButtonClicked(null, null);
                    //MainFind_DisplayData();

                    //정상 처리
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);


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

        #region ○ 버튼 클릭 팝업처리
        private void _btPRODUCTION_ORDER_Click(object sender, EventArgs e)
        {
            try
            {
                //frmCommonPopup.CORP_CDDE = _pCORP_CODE;
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                //frmCommonPopup.ARRAY = new object[2] { "common_code", "CD99" }; //넘기는 파라메터 에 따라 설정

                frmCommonPopup xfrmcommonPopup = new CORE.UserForm.frmCommonPopup("ContractInfo"); //유저컨트롤러 설정 부분

                xfrmcommonPopup.ShowDialog();

                if (xfrmcommonPopup.dtReturn == null) return;

                xfrmcommonPopup.dtReturn.Rows[0][0].ToString();
                // 리턴 받는 데이터의 값은 해당 그리드 뷰 필드에 설정.
                //_gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["TEST1"], xfrmcommonPopup.dtReturn.Rows[0]["CD"].ToString());
                //_gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["TEST2"], xfrmcommonPopup.dtReturn.Rows[0]["CD_NM"].ToString());
                xfrmcommonPopup.Dispose();
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

        private void _btTPART_Click(object sender, EventArgs e)
        {
            /*
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            frmCommonPopup.ARRAY = new object[2] { "Product_Code", _luPART_ALL.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기

            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("VendCostInfo"); //유저컨트롤러 설정 부분

            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn == null)
            {
                xfrmCommonPopup.Dispose();
                return;
            }

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luTVEND_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_CODE"].ToString();
                _luTVEND_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_NAME"].ToString();
                _luTPART_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                _luTPART_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
            }

            xfrmCommonPopup.Dispose();
            */
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            frmCommonPopup.ARRAY = new object[2] { "Product_Code", _luTPART_ALL.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
            frmCommonPopup.ARRAY_CODE = new object[2] { _luTPART_ALL.CodeText, _luTPART_ALL.NameText };
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("PartCodeInfo"); //유저컨트롤러 설정 부분

            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn == null)
            {
                xfrmCommonPopup.Dispose();
                return;
            }

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luTPART_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                _luTPART_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
            }

            xfrmCommonPopup.Dispose();

        }

        private void _btPART_Click(object sender, EventArgs e)
        {
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            frmCommonPopup.ARRAY = new object[2] { "PART_TYPE_PRODUCT_T01", _luPART_ALL.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기

            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("VendCostInfo"); //유저컨트롤러 설정 부분

            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn == null)
            {
                xfrmCommonPopup.Dispose();
                return;
            }

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luVEND_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_CODE"].ToString();
                _luVEND_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_NAME"].ToString();
                _luPART_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                _luPART_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                _luUNITCOST.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_UNITCOST"].ToString();
                //_luPART_UNIT.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_UNITCOST_CURRENCY_CODE"].ToString();
                _luPART_UNIT.SetValue(xfrmCommonPopup.dtReturn.Rows[0]["PART_UNIT"].ToString());
                //_luPART_UNIT.SetValueByDisplayName(xfrmCommonPopup.dtReturn.Rows[0]["PART_UNITCOST_CURRENCY_CODE"].ToString());
                //_luPART_UNIT.SetValueByDisplayName(xfrmCommonPopup.dtReturn.Rows[0]["PART_UNITCOST_CURRENCY_CODE"].ToString());
                _luINOUT_CODE.ReadOnly = false;
                //_luINOUT_CODE.ItemIndex = 2;
                //_luINOUT_CODE.ReadOnly = true;
                _luREFERENCE_ID.Text = "";
            }

            xfrmCommonPopup.Dispose();
        }

        private void _btTVEND_Click(object sender, EventArgs e)
        {
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            frmCommonPopup.ARRAY = new object[2] { "vend_code_O", _luVEND_ALL.NameText }; //넘기는 파라메터 에 따라 설정
            frmCommonPopup.ARRAY_CODE = new object[2] { _luTVEND_ALL.CodeText, _luTVEND_ALL.NameText };

            
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn == null)
            {
                xfrmCommonPopup.Dispose();
                return;
            }

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luTVEND_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luTVEND_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
            }
            xfrmCommonPopup.Dispose();

        }

        private void _btVEND_Click(object sender, EventArgs e)
        {
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
            
            frmCommonPopup.ARRAY = new object[2] { "vend_code_O", _luVEND_ALL.NameText}; //넘기는 파라메터 에 따라 설정
            frmCommonPopup.ARRAY_CODE = new object[2] { _luVEND_ALL.CodeText, _luVEND_ALL.NameText };
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn == null)
            {
                xfrmCommonPopup.Dispose();
                return;
            }

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luVEND_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luVEND_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
                _luINOUT_CODE.ReadOnly = false;
                //_luINOUT_CODE.ItemIndex = 2;
                //_luINOUT_CODE.ReadOnly = true;
                _luREFERENCE_ID.Text = "";
            }
            xfrmCommonPopup.Dispose();

        }
        #endregion

        #region ○ 수량 자동 계산

        private void _luINOUT_QTY__OnKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b' && e.KeyChar != (char)13)
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

        private void _luINOUT_QTY__OnTextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal pCOST = 0;
                decimal pQTY = 0;
                decimal pUNITCOST = 0;


                pUNITCOST = Convert.ToDecimal(_luUNITCOST.Text == "" ? "0.00" : _luUNITCOST.Text);
                pQTY = Convert.ToDecimal(_luINOUT_QTY.Text == "" ? "0.00" : _luINOUT_QTY.Text);

                pCOST = pUNITCOST * pQTY;
                pCOST = Math.Round(pCOST, 2);
                string[] qCOST = pCOST.ToString().Split('.');

                if (qCOST.Length > 1 && qCOST[1].Length > 2)
                    pCOST = Convert.ToDecimal(qCOST[0] + qCOST[1].Substring(0, 2));

                _luCOST.Text = pCOST.ToString();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        private void _ucbtSTOCK_SEARCH_Click(object sender, EventArgs e)
        {
            /*

            // 거래처 없음 체크박스에 따라 팝업 호출 변경

            // 거래처 없음
            CoFAS_MES.UI.SP.UserForm.frmCommonPopup.CRUD = "R";
            CoFAS_MES.UI.SP.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
            CoFAS_MES.UI.SP.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            CoFAS_MES.UI.SP.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            CoFAS_MES.UI.SP.UserForm.frmCommonPopup.ARRAY = new object[2] { "SemiProduct_Stock", "" };

            //검색조건 전달 0 코드 1 명칭
            //frmCommonPopup.ARRAY_CODE = new object[2] { _luPART.CodeText.ToString(), _luPART.NameText.ToString() };
            CoFAS_MES.UI.SP.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { "", "" };

            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            CoFAS_MES.UI.SP.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.SP.UserForm.frmCommonPopup("SemiProduct_Stock"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                // _luPART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                // _luPART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
                // _luVEND.CodeText = "";
                // _luVEND.NameText = "";
                // _luUNIT_COST.Text = "0";

                //데이터 세팅
            }

            xfrmCommonPopup.Dispose();
            Form_SearchButtonClicked(null, null);

            */

        }
        private void _luUNITCOST__OnTextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal pCOST = 0;
                decimal pQTY = 0;
                decimal pUNITCOST = 0;

                pUNITCOST = Convert.ToDecimal(_luUNITCOST.Text == "" ? "0.00" : _luUNITCOST.Text);
                pQTY = Convert.ToDecimal(_luINOUT_QTY.Text == "" ? "0.00" : _luINOUT_QTY.Text);
                pCOST = pUNITCOST * pQTY;
                pCOST = Math.Round(pCOST, 2);
                string[] qCOST = pCOST.ToString().Split('.');

                if (qCOST.Length > 1 && qCOST[1].Length > 2)
                    pCOST = Convert.ToDecimal(qCOST[0] + qCOST[1].Substring(0, 2));

                _luCOST.Text = pCOST.ToString();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

       private void _luREFERENCE_ID__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                try
                {

                    
                    CoFAS_MES.UI.PM.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                    CoFAS_MES.UI.PM.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    CoFAS_MES.UI.PM.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    CoFAS_MES.UI.PM.UserForm.frmCommonPopup.ARRAY = new object[2] { "ProductionInfo_Out_Popup", "" }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                    CoFAS_MES.UI.PM.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _luREFERENCE_ID.Text, "" };
                    CoFAS_MES.UI.PM.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.PM.UserForm.frmCommonPopup("ProductionInfo_Out_Popup"); //유저컨트롤러 설정 부분

                    xfrmCommonPopup.ShowDialog();

                    if (xfrmCommonPopup.dtReturn == null)
                    {
                        _pOpenPopup_YN = false;
                        xfrmCommonPopup.Dispose();
                        return;
                    }

                    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                    {
                        _luREFERENCE_ID.Text = xfrmCommonPopup.dtReturn.Rows[0]["SHIPMENT_ID"].ToString();
                        _luPART_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                        _luPART_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                        _luVEND_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_CODE"].ToString();
                        _luVEND_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_NAME"].ToString();
                        _luUNITCOST.Text = xfrmCommonPopup.dtReturn.Rows[0]["UNITCOST"].ToString();
                        //_luPART_UNIT.Text = xfrmCommonPopup.dtReturn.Rows[0]["UNIT_CODE"].ToString();
                        _luPART_UNIT.SetValue(xfrmCommonPopup.dtReturn.Rows[0]["PART_UNIT"].ToString());
                        // BOM 조회하기
                        //MainFind_DisplayData();
                        _luINOUT_CODE.ReadOnly = false;
                        //_luINOUT_CODE.ItemIndex = 1;
                        //_luINOUT_CODE.ReadOnly = true;
                        _luINOUT_ID.Text="";
                        _luREMARK.Text = "";
                        _luLEAVE_QTY.Text = xfrmCommonPopup.dtReturn.Rows[0]["LEAVE_QTY"].ToString();// Convert.ToDecimal(xfrmCommonPopup.dtReturn.Rows[0]["SHIPMENT_ORDER_QTY"].ToString()) - Convert.ToDecimal(xfrmCommonPopup.dtReturn.Rows[0]["INOUT_QTY"].ToString());
                        _pLEAVE_QTY = Convert.ToDecimal(xfrmCommonPopup.dtReturn.Rows[0]["LEAVE_QTY"].ToString());// Convert.ToDecimal(xfrmCommonPopup.dtReturn.Rows[0]["SHIPMENT_ORDER_QTY"].ToString()) - Convert.ToDecimal(xfrmCommonPopup.dtReturn.Rows[0]["INOUT_QTY"].ToString());
                        _luINOUT_QTY.Text = _pLEAVE_QTY.ToString();// xfrmCommonPopup.dtReturn.Rows[0]["INOUT_QTY"].ToString();
                        _pOpenPopup_YN = true;
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
    }
}