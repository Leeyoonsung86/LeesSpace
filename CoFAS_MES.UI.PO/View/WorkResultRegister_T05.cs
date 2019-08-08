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

using CoFAS_MES.UI.PO.Business;
using CoFAS_MES.UI.PO.Entity;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Business;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.UserForm;

namespace CoFAS_MES.UI.PO
{ 
    public partial class WorkResultRegister_T05 : frmBaseNone
    {
        #region ○ 기본 전역변수

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
        private string _pUSER_GRANT = string.Empty;     // 사용자 권한
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보

        private WorkResultRegister_T05Entity _pWorkResultRegister_T05Entity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtList_binding = null;
        private DataTable _dtSub = null;
        private DataTable _dtSub_Ng = null;
        private DataTable _dtSub_Status = null;
        private DataTable _dtSub_Pack = null;
        private DataTable _dtEquip = null;
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private int _gdMAIN_index = -1;
        public string oPRODUCTION_ORDER_ID = string.Empty;
        CoFAS_DevGridManager _gdSUB_GRID_VIEW = null;

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
        private string _pMSG_PROCESS_CODE = string.Empty;   // 작업장선택이 안되어 실적등록을 할 수 없습니다.
        private string _pMSG_STATUS_OK = string.Empty;      // 작업이 완료되어 실적등록을 할 수 없습니다.

        //알림창메시지 복사 끝

        #endregion

        #region ○ 생성자

        public WorkResultRegister_T05()
        {
            InitializeComponent();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        #endregion

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
                CoFAS_DevExpressManager._OnButtonPressed -= CoFAS_DevExpressManager_OnButtonPressed;
                _gdMAIN_VIEW.FocusedRowChanged -= new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(_gdMAIN_VIEW_RowChange);

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

                Form_SearchButtonClicked(null, null);
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
                _pnLeft.Visible = true;
                layoutControl2.Visible = false;
                //_pnRight.Width = 600;

                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                _pUSER_GRANT = MainForm.UserEntity.USER_GRANT;
                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_PATH = MainForm.UserEntity.FTP_IP_PORT; //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //발주서는 ORDER_FORM // 화면조회용 PROGRAM_VIEW
                _pFTP_PW = MainForm.UserEntity.FTP_PW;

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
                _pMSG_PROCESS_CODE = MainForm.MessageEntity.MSG_PROCESS_CODE;
                _pMSG_STATUS_OK = MainForm.MessageEntity.MSG_STATUS_OK;

                _pWINDOW_NAME = this.Name;

                //메뉴 화면 엔티티 설정
                _pWorkResultRegister_T05Entity = new WorkResultRegister_T05Entity();
                _pWorkResultRegister_T05Entity.USER_CODE = _pUSER_CODE;
                _pWorkResultRegister_T05Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

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

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pWorkResultRegister_T05Entity.CRUD = "";
                if (_pFirstYN)
                {
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    _gdSUB_VIEW.RowCellClick += _gdSUB_VIEW_RowCellClick;
                    _gdSUB_VIEW.ShowingEditor += showingTest;
                    _gdSUB_VIEW.RowStyle += rowcellstyle;
                    CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager_OnButtonPressed;
                    _gdMAIN_VIEW.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(_gdMAIN_VIEW_RowChange);
                    _pFirstYN = false;
                }

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행

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
                pButtonSetting.UseYNSettingButton = false; // 설정
                pButtonSetting.UseYNFormCloseButton = true; // 폼닫기

                if (_pUSER_GRANT == "PC160001")
                {
                    pButtonSetting.UseYNSettingButton = true; // 설정
                }
                else
                {
                    pButtonSetting.UseYNSettingButton = false; // 설정
                }


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
            _gdSUB_GRID_VIEW = new CoFAS_DevGridManager();
            try
            {
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                    _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
                    _gdSUB_NG_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB_NG, _gdSUB_NG_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB_NG.Name.ToString()));
                    _gdSUB_STATUS_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB_STATUS, _gdSUB_STATUS_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB_STATUS.Name.ToString()));
                    _gdSUB_PACK_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB_PACK, _gdSUB_PACK_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB_PACK.Name.ToString()));
                    _gdSUB_VIEW.CellValueChanged += _gdSUB_VIEW_CellValueChanged;
                    _gdSUB_PACK_VIEW.InitNewRow += _gdSUB_PACK_VIEW_InitNewRow;
                }
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


                //_luTWC_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "WORKCENTER", "", "", "").Tables[0], 0, 0, "", true);
                //_luTPC_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "PROCESSCODE_MAIN", "", "", "").Tables[0], 0, 0, "", true);

                _luPROCESS_LIST.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "POP_PROCESS_MSELECT", "", "", "").Tables[0], 0, 0, "", false);
                _luEQUIPMENT_LIST.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "POP_PROCESS_DSELECT", "", "", "").Tables[0], 0, 0, "", false);

                _luTORDER_DATE.FromDateTime = Convert.ToDateTime("2000-01-01");  //조회 시작일, 매월 초 날짜로 설정
                _luTORDER_DATE.ToDateTime = DateTime.Today.AddDays(1);  //조회 종료일, 당일 설정

                //데이터 영역

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                _luFA_CODE.ReadOnly = true;
                _luLOT_NO.ReadOnly = true;
                _luMTC_NO.Text = "";

                _luTPART_HIGH.Text = "";
                _luTPART_MIDDLE.Text = "";
                _luTPART_LOW.Text = "";
                _luTPART.CodeText = "";
                _luTPART.NameText = "";

                _luTORDER_NUMBER.CodeText = "";
                _luTORDER_NUMBER.NameText = "";

                _luLOT_NO.Text = "";
                _luSPEC_NO.Text = "";
                _luDRAWING_NO.Text = "";
                _luPURCHASE_SPEC_NO.Text = "";
                _luWO_NO.Text = "";
                _luITEM_NO.Text = "";
                _luWO_QTY.Text = "";
                _luPO_NO.Text = "";
                _luMATERAL_TRS_NO.Text = "";
                _luTOTAL_COUNT.Text = "";
                _luFA_CODE.Text = "";

                _luSPEC_NO.ReadOnly = true;
                _luDRAWING_NO.ReadOnly = true;
                _luPURCHASE_SPEC_NO.ReadOnly = true;
                _luWO_NO.ReadOnly = true;
                _luITEM_NO.ReadOnly = true;
                _luWO_QTY.ReadOnly = true;
                _luPO_NO.ReadOnly = true;
                _luMATERAL_TRS_NO.Text = "";
                _luTOTAL_COUNT.ReadOnly = true;

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화

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
                
                int qRowIndex = gv.FocusedRowHandle;
                if (qRowIndex < 0) return;

                _gdSUB.DataSource = null;
                _gdSUB_NG.DataSource = null;
                _gdSUB_STATUS.DataSource = null;
                oPRODUCTION_ORDER_ID = gv.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString();
                if (oPRODUCTION_ORDER_ID != "")
                {
                    _pWorkResultRegister_T05Entity.CRUD = "R";
                    _pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID = oPRODUCTION_ORDER_ID;
                    _dtEquip = new WorkResultRegister_T05Business().WorkResultRegister_Info_Equip(_pWorkResultRegister_T05Entity);

                    if (_pWorkResultRegister_T05Entity.CRUD == "")
                        _dtEquip.Rows.Clear();
                }
                MainBindingFind_DisplayData(gv.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString(), gv.GetFocusedRowCellValue("LOT_ID").ToString());
                SubFind_DisplayData(gv.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString(), gv.GetFocusedRowCellValue("LOT_ID").ToString());
                SubFind_Packing_DisplayData(gv.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString(), _pWorkResultRegister_T05Entity.LOT_ID);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region 설비선택
        private void _luEQUIPMENT_LIST_ValueChanging(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (_gdMAIN_VIEW.FocusedRowHandle >= 0)
                {
                    _gdSUB.DataSource = null;
                    _gdSUB_NG.DataSource = null;
                    _gdSUB_STATUS.DataSource = null;
                    _gdSUB_PACK.DataSource = null;

                    oPRODUCTION_ORDER_ID = _gdMAIN_VIEW.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString();

                    _pWorkResultRegister_T05Entity.CRUD = "R";
                    _pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID = oPRODUCTION_ORDER_ID;

                    _gdMAIN_VIEW_RowCellClick(_gdMAIN_VIEW, null);
                }

                if (oPRODUCTION_ORDER_ID != "")
                {
                    _dtEquip = new WorkResultRegister_T05Business().WorkResultRegister_Info_Equip(_pWorkResultRegister_T05Entity);

                    if (_pWorkResultRegister_T05Entity.CRUD == "")
                        _dtEquip.Rows.Clear();
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

        private void _luEQUIPMENT_LIST_ValueChanged(object sender, EventArgs e)
        {

            string sRoutingCheck = string.Empty;
            if (CoFAS_ConvertManager.DataTable_FindCount(_dtEquip, "ROUTING_CODE = '" + _luEQUIPMENT_LIST.GetValue() + "'", ""))
            {
                _pWorkResultRegister_T05Entity.PROCESS_CODE = _luEQUIPMENT_LIST.GetValue();
                sRoutingCheck = CoFAS_ConvertManager.DataTable_FindValue(_dtEquip, "ROUTING_CODE = '" + _luEQUIPMENT_LIST.GetValue() + "'", "").Rows[0]["CONFIGURATION_CODE"].ToString();
                _pWorkResultRegister_T05Entity.CONFIGURATION_CODE = sRoutingCheck;
                if (sRoutingCheck.ToString().Substring(0, 2) == "PK")
                {
                    layoutControl2.Visible = true;
                }
                else
                {
                    layoutControl2.Visible = false;
                }
            }
        }
        #endregion


        #region ○ 서브 그리드 로우 선택 이벤트 생성 - _gdSUB_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdSUB_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                int qRowIndex = gv.FocusedRowHandle;
                if (qRowIndex < 0) return;

                _gdSUB_NG.DataSource = null;
                _gdSUB_STATUS.DataSource = null;

                SubFind_Bad_DisplayData(gv.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString(), gv.GetFocusedRowCellValue("CONFIGURATION_CODE").ToString());
                SubFind_Status_DisplayData(gv.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString(), gv.GetFocusedRowCellValue("CONFIGURATION_CODE").ToString());
                SubFind_Packing_DisplayData(gv.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString(), _pWorkResultRegister_T05Entity.LOT_ID);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 메인 그리드(LOT) 로우 선택 이벤트 생성 - _gdMAIN_LOT_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_LOT_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 서브 디테일 그리드 신규로우 생성시 이벤트 생성 - _gdSUB1_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdSUB_PACK_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;


            view.SetRowCellValue(e.RowHandle, view.Columns["PACKING_ID"], "");
            view.SetRowCellValue(e.RowHandle, view.Columns["PACKING_DATE"], DateTime.Now.ToString("yyyyMMdd"));
            view.SetRowCellValue(e.RowHandle, view.Columns["LOT_ID"], _pWorkResultRegister_T05Entity.LOT_ID);
            view.SetRowCellValue(e.RowHandle, view.Columns["PACKING_SEQ"], "");
            view.SetRowCellValue(e.RowHandle, view.Columns["PACKING_NO"], "");
            view.SetRowCellValue(e.RowHandle, view.Columns["PACKING_QTY"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
            view.SetRowCellValue(e.RowHandle, view.Columns["P_PACKING_ID"], "");
        }
        #endregion

        #region ○ 서브 그리드 버튼 클릭 이벤트 생성 - CoFAS_DevExpressManager_OnOpenButton(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        private void CoFAS_DevExpressManager_OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = null;
            string strFTP_PATH = string.Empty;
            string tempFolderPath = string.Empty;

            switch (e.Button.Caption.ToString())
            {
                case "WORKRESULT5_DOCUMENT_VIEW_SUB_BTN":

                    dr = _gdSUB_VIEW.GetFocusedDataRow();
                    if (dr == null) return;

                    if (dr["DOCUMENT_FILE_NAME"].ToString() == "")
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("등록된 파일이 없습니다");
                        return;
                    }

                    strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_IP_PORT, "FILE_DATA", dr["DOCUMENT_TYPE"].ToString());

                    tempFolderPath = System.IO.Path.GetTempPath() + dr["DOCUMENT_FILE_NAME"].ToString();

                    CoFAS_FTPManager.FTPFileView(strFTP_PATH, dr["DOCUMENT_FILE_NAME"].ToString(), _pFTP_ID, _pFTP_PW, tempFolderPath);

                    break;

                case "WORKRESULT5_MAT_USAGE_BTN": //사용량


                    PO.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                    PO.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    PO.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    PO.UserForm.frmCommonPopup.ARRAY = new object[4] { "", "", "", "" }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                    PO.UserForm.frmCommonPopup.ARRAY_CODE = new object[4] { _pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID.ToString(), _pWorkResultRegister_T05Entity.LOT_ID, _pWorkResultRegister_T05Entity.CONFIGURATION_CODE, _pWorkResultRegister_T05Entity.PART_CODE };
                    PO.UserForm.frmCommonPopup xfrmCommonPopup = new PO.UserForm.frmCommonPopup("ucMeterialUsagePopup"); //유저컨트롤러 설정 부분

                    xfrmCommonPopup.ShowDialog();

                    if (xfrmCommonPopup.dtReturn == null)
                    {
                        xfrmCommonPopup.Dispose();
                        return;
                    }

                    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                    {
                    }

                    xfrmCommonPopup.Dispose();
                    _pWorkResultRegister_T05Entity.CRUD = "R";
                    MainBindingFind_DisplayData(_pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID.ToString(), _pWorkResultRegister_T05Entity.LOT_ID);
                    SubFind_DisplayData(_pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID.ToString(), _pWorkResultRegister_T05Entity.LOT_ID);
                    SubFind_Packing_DisplayData(_pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID.ToString(), _pWorkResultRegister_T05Entity.LOT_ID);
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

                _pWorkResultRegister_T05Entity.CRUD = "R";

                MainFind_DisplayData();

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

        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (!dxValidationProvider.Validate())
                {
                    return;
                }

                InputData_Save(_pWorkResultRegister_T05Entity);
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

                if (!dxValidationProvider.Validate())
                {
                    //MessageBox.Show("빈값이 있음");
                    MessageBox.Show(_pMSG_CHECK_VALID_ITEM);
                    return;
                }

                //InputData_Save(_pContractMstRegisterEntity);
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

                if (_pWorkResultRegister_T05Entity.LOT_ID == "") return;

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                string strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pWINDOW_NAME);
                //string strFTP_PATH = string.Format()



                PO.UserForm.frmCommonPopup.CRUD = "R";
                PO.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                PO.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                PO.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
                PO.UserForm.frmCommonPopup.FTP_ID = _pFTP_ID;
                PO.UserForm.frmCommonPopup.FTP_PW = _pFTP_PW;
                PO.UserForm.frmCommonPopup.strFile_NAME = "WorkResultRegister_T05Report.xlsx";
                PO.UserForm.frmCommonPopup.strFTP_PATH = strFTP_PATH;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                PO.UserForm.frmCommonPopup.ARRAY = new object[3] { "", "", "" };
                PO.UserForm.frmCommonPopup.ARRAY_CODE = new object[5] { _pWINDOW_NAME, _pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID, _pWorkResultRegister_T05Entity.LOT_ID, 12, 0 };
                PO.UserForm.frmCommonPopup xfrmCommonPopup = new PO.UserForm.frmCommonPopup("ucExcelViewPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

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

        #region ○ 내보내기 버튼 클릭시 처리하기
        private void Form_ExportButtonClicked(object pSender, EventArgs pEventArgs)
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
                //확인

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업 초기화 하겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_RESET_QUESTION) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    InitializeSetting();
                    //GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                    //DisplayMessage("초기화했습니다.");
                    DisplayMessage(_pMSG_RESET_COMPLETE);
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
                _pWorkResultRegister_T05Entity.CRUD = "R";
                _pWorkResultRegister_T05Entity.DATE_FROM = _luTORDER_DATE.FromDateTime.ToString("yyyyMMdd");
                _pWorkResultRegister_T05Entity.DATE_TO = _luTORDER_DATE.ToDateTime.ToString("yyyyMMdd");
                _pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID = "";
                _pWorkResultRegister_T05Entity.PART_CODE = _pWorkResultRegister_T05Entity.PART_CODE == null ? "" : _pWorkResultRegister_T05Entity.PART_CODE;
                _pWorkResultRegister_T05Entity.VEND_PART_CODE = _luTPART.CodeText.ToString();
                _pWorkResultRegister_T05Entity.PART_NAME = _luTPART.NameText.ToString();
                _pWorkResultRegister_T05Entity.PART_HIGH = _luTPART_HIGH.Text.ToString();
                _pWorkResultRegister_T05Entity.PART_MIDDLE = _luTPART_MIDDLE.Text.ToString();
                _pWorkResultRegister_T05Entity.PART_LOW = _luTPART_LOW.Text.ToString();
                _pWorkResultRegister_T05Entity.LOT_ID = "";
                _pWorkResultRegister_T05Entity.ORDER_NUMBER = _luTORDER_NUMBER.CodeText;
                _dtList = new WorkResultRegister_T05Business().WorkResultRegister_Info_Mst(_pWorkResultRegister_T05Entity);

                if (_pWorkResultRegister_T05Entity.CRUD == "")
                    _dtList.Rows.Clear();

                if((_dtList != null && _dtList.Rows.Count > 0) || (_dtList !=null && _pWorkResultRegister_T05Entity.CRUD == ""))
                {
                    //데이터 필드에 맞춰 자동 바인딩
                    //CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);

                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    //_dtList.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
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

        #region ○ 메인바인딩조회 - MainBindingFind_DisplayData()

        private void MainBindingFind_DisplayData(string qWorkOrder, string qLot_id)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pWorkResultRegister_T05Entity.CRUD = "R";
                _pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID = qWorkOrder;
                _pWorkResultRegister_T05Entity.LOT_ID = qLot_id;
                _dtList_binding = new WorkResultRegister_T05Business().WorkResultRegister_Info_Mst_Binding(_pWorkResultRegister_T05Entity);
                _luLOT_NO.Text = "";
                _luSPEC_NO.Text = "";
                _luDRAWING_NO.Text = "";
                _luPURCHASE_SPEC_NO.Text = "";
                _luWO_NO.Text = "";
                _luITEM_NO.Text = "";
                _luWO_QTY.Text = "";
                _luPO_NO.Text = "";
                _luMATERAL_TRS_NO.Text = "";
                _luMTC_NO.Text = "";
                _luTOTAL_COUNT.Text = "";

                if (_pWorkResultRegister_T05Entity.CRUD == "")
                    _dtList_binding.Rows.Clear();

                if (_dtList_binding != null && _dtList_binding.Rows.Count > 0)
                {

                    for(int i=0;i< _dtList_binding.Rows.Count;i++)
                    {
                        _luFA_CODE.Text = _dtList_binding.Rows[i]["PART_HIGH"].ToString();
                        _luLOT_NO.Text = "";
                        //_luMTC_NO.Text = "";

                        switch (_dtList_binding.Rows[i]["DOCUMENT_TYPE"].ToString())
                        {
                            case "CD050007": // 구매시방서
                                _luSPEC_NO.Text = _dtList_binding.Rows[i]["DOCUMENT_NAME"].ToString();
                                _pWorkResultRegister_T05Entity.SPEC_NO_FILENAME = _dtList_binding.Rows[i]["DOCUMENT_FILE_NAME"].ToString();
                                _pWorkResultRegister_T05Entity.SPEC_NO_TYPE = _dtList_binding.Rows[i]["DOCUMENT_TYPE"].ToString();
                                break;
                            case "CD050003": // 도면
                                _luDRAWING_NO.Text = _dtList_binding.Rows[i]["DOCUMENT_NAME"].ToString();
                                _pWorkResultRegister_T05Entity.DRAWING_NO_FILENAME = _dtList_binding.Rows[i]["DOCUMENT_FILE_NAME"].ToString();
                                _pWorkResultRegister_T05Entity.DRAWING_NO_TYPE = _dtList_binding.Rows[i]["DOCUMENT_TYPE"].ToString();
                                break;
                            case "CD050002": // 공통시방서
                                _luPURCHASE_SPEC_NO.Text = _dtList_binding.Rows[i]["DOCUMENT_NAME"].ToString();
                                _pWorkResultRegister_T05Entity.PURCHASE_SPEC_NO_FILENAME = _dtList_binding.Rows[i]["DOCUMENT_FILE_NAME"].ToString();
                                _pWorkResultRegister_T05Entity.PURCHASE_SPEC_NO_TYPE = _dtList_binding.Rows[i]["DOCUMENT_TYPE"].ToString();
                                break;
                        }
                        _luWO_NO.Text = _dtList_binding.Rows[i]["PRODUCTION_ORDER_ID"].ToString();
                        _luITEM_NO.Text = _dtList_binding.Rows[i]["VEND_PART_CODE"].ToString();
                        _luWO_QTY.Text = _dtList_binding.Rows[i]["PRODUCTION_ORDER_QTY"].ToString();
                        _luPO_NO.Text = _dtList_binding.Rows[i]["ORDER_NUMBER"].ToString();
                        //_luMATERAL_TRS_NO.Text = "";
                        _luTOTAL_COUNT.Text = _dtList_binding.Rows[i]["PRODUCTION_OK_QTY"].ToString();
                    }
                    //CoFAS_ControlManager.Controls_Binding(_dtList_binding, false, this);
                }
                else
                {
                    _dtList_binding.Rows.Clear();
                    //CoFAS_ControlManager.Controls_Binding(_dtList_binding, false, this);
                    _luLOT_NO.Text = "";
                    _luSPEC_NO.Text = "";
                    _luDRAWING_NO.Text = "";
                    _luPURCHASE_SPEC_NO.Text = "";
                    _luWO_NO.Text = "";
                    _luITEM_NO.Text = "";
                    _luWO_QTY.Text = "";
                    _luPO_NO.Text = "";
                    _luMATERAL_TRS_NO.Text = "";
                    _luTOTAL_COUNT.Text = "";
                    _luMTC_NO.Text = "";
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

        #region ○ 메인(LOT)조회 - SubFind_DisplayData()

        private void SubFind_DisplayData(string qWorkOrder, string qLot_id)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pWorkResultRegister_T05Entity.CRUD = "R";
                _pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID = qWorkOrder;
                _pWorkResultRegister_T05Entity.LOT_ID = qLot_id;
                _dtSub = new WorkResultRegister_T05Business().WorkResultRegister_Info_Mst_Lot(_pWorkResultRegister_T05Entity);

                if (_pWorkResultRegister_T05Entity.CRUD == "")
                    _dtSub.Rows.Clear();
                
                if (_dtSub != null && _dtSub.Rows.Count > 0)
                {
                    _pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID = _dtSub.Rows[0]["PRODUCTION_ORDER_ID"].ToString();
                    _pWorkResultRegister_T05Entity.PART_CODE = _dtSub.Rows[0]["PART_CODE"].ToString();
                    _pWorkResultRegister_T05Entity.LOT_ID = _dtSub.Rows[0]["LOT_ID"].ToString();
                    _luLOT_NO.Text = _dtSub.Rows[0]["LOT_NO"].ToString();
                    _luMTC_NO.Text = _dtSub.Rows[0]["MOVE_DOCUMENT_ID"].ToString();
                    _luMATERAL_TRS_NO.Text = _dtSub.Rows[0]["REFERENCE_ID"].ToString();
                    if (_luLOT_NO.Text.ToString().Equals(""))
                    {
                        _ucbtLOT_CREATE.Enabled = false;
                    }
                    else
                    {
                        _ucbtLOT_CREATE.Enabled = true;
                    }
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtSub); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtSub.Rows.Clear();
                    _ucbtLOT_CREATE.Enabled = true;
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtSub); //데이터 필드에 맞춰 자동 바인딩
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

        private void showingTest(object sender, CancelEventArgs e)
        {
            bool isChecked = true;
            if (this.Name == "WorkResultRegister_T05")
            {

                DataRow focusRow = _gdSUB_VIEW.GetFocusedDataRow();
                if (CoFAS_ConvertManager.DataTable_FindCount(_dtEquip, "ROUTING_CODE = '" + _luEQUIPMENT_LIST.GetValue().ToString() + "' AND CONFIGURATION_CODE = '" + focusRow["CONFIGURATION_CODE"].ToString() + "'", ""))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }


        private void rowcellstyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused) != 0) && ((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.GridFocused) != 0))
                e.Appearance.Assign(view.PaintAppearance.FocusedRow);

            if (e.RowHandle >= 0)
            {

                if (!CoFAS_ConvertManager.DataTable_FindCount(_dtEquip, "ROUTING_CODE = '" + _luEQUIPMENT_LIST.GetValue().ToString() + "' AND CONFIGURATION_CODE = '" + view.GetRowCellValue(e.RowHandle, "CONFIGURATION_CODE").ToString() + "'", ""))
                {
                    e.Appearance.BackColor = Color.FromArgb(100, Color.DarkSeaGreen);
                    e.Appearance.BackColor2 = Color.White;
                }
                else
                {
                    _gdSUB_VIEW_RowCellClick(view, null);
                }
            }
        }

        #endregion

        #region ○ 포장조회 - SubFind_Packing_DisplayData()
        private void SubFind_Packing_DisplayData(string qWorkOrder, string qlot_id)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _gdSUB_PACK.DataSource = null;
                _pWorkResultRegister_T05Entity.CRUD = "R";
                _pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID = qWorkOrder;
                _pWorkResultRegister_T05Entity.LOT_ID = qlot_id;

                _dtSub_Pack = new WorkResultRegister_T05Business().WorkResultRegister_Info_Sub_Packing(_pWorkResultRegister_T05Entity);

                if (_pWorkResultRegister_T05Entity.CRUD == "")
                    _dtSub_Pack.Rows.Clear();

                if (_dtSub_Pack != null && _dtSub_Pack.Rows.Count > 0)
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB_PACK, _gdSUB_PACK_VIEW, _dtSub_Pack); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    //_dtSub_Pack.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB_PACK, _gdSUB_PACK_VIEW, _dtSub_Pack); //데이터 필드에 맞춰 자동 바인딩
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

        #region ○ 불량 조회 - SubFind_Bad_DisplayData()
        private void SubFind_Bad_DisplayData(string qWorkOrder, string qProcessCode)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _gdSUB_NG.DataSource = null;
                _pWorkResultRegister_T05Entity.CRUD = "R";
                _pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID = qWorkOrder;
                _pWorkResultRegister_T05Entity.PROCESS_CODE = _luEQUIPMENT_LIST.GetValue().ToString();

                _dtSub_Ng = new WorkResultRegister_T05Business().WorkResultRegister_Info_Sub_Bad(_pWorkResultRegister_T05Entity);

                if (_pWorkResultRegister_T05Entity.CRUD == "")
                    _dtSub_Ng.Rows.Clear();

                if (_dtSub_Ng != null && _dtSub_Ng.Rows.Count > 0)
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB_NG, _gdSUB_NG_VIEW, _dtSub_Ng); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtSub_Ng.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB_NG, _gdSUB_NG_VIEW, _dtSub_Ng); //데이터 필드에 맞춰 자동 바인딩
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

        #region ○ 상태 조회 - SubFind_Status_DisplayData()
        private void SubFind_Status_DisplayData(string qWorkOrder, string qProcessCode)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pWorkResultRegister_T05Entity.CRUD = "R";
                _pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID = qWorkOrder;
                _pWorkResultRegister_T05Entity.PROCESS_CODE = _luEQUIPMENT_LIST.GetValue().ToString();

                _dtSub_Status = new WorkResultRegister_T05Business().WorkResultRegister_Info_Sub_Status(_pWorkResultRegister_T05Entity);

                if (_pWorkResultRegister_T05Entity.CRUD == "")
                    _dtSub_Status.Rows.Clear();

                if (_dtSub_Status != null && _dtSub_Status.Rows.Count > 0)
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB_STATUS, _gdSUB_STATUS_VIEW, _dtSub_Status); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtSub_Status.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB_STATUS, _gdSUB_STATUS_VIEW, _dtSub_Status); //데이터 필드에 맞춰 자동 바인딩
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

        #region ○ 저장 - InputData_Save(DataTable dtSave)  

        private void InputData_Save(WorkResultRegister_T05Entity _pWorkResultRegister_T05Entity)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                using (DBManager pDBManager = new DBManager())
                {
                    bool isError = false;

                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                    {
                        #region Validation

                        DataTable dtsub = _gdSUB.DataSource as DataTable;
                        DataTable dtsub_Temp = null;

                        DataTable dtNg = _gdSUB_NG.DataSource as DataTable;
                        DataTable dtNg_Temp = null;

                        DataTable dtPacking = _gdSUB_PACK.DataSource as DataTable;
                        DataTable dtPacking_Temp = null;

                        string sConfiguration_code = string.Empty;
                        decimal ok_qty = 0;
                        decimal Inspect_qty = 0;
                        decimal pass_qty = 0;
                        decimal Ng_qty = 0;
                        decimal Packing_qty = 0;

                        // 실적, 검사, 합격수량 Check Validation
                        if (CoFAS_ConvertManager.DataTable_FindCount(dtsub, "CONFIGURATION_CODE = '" + _luPROCESS_LIST.GetValue().ToString() + "'", ""))
                        {

                            dtsub_Temp = CoFAS_ConvertManager.DataTable_FindValue(dtsub, "CONFIGURATION_CODE = '" + _luPROCESS_LIST.GetValue().ToString() + "'", "");
                            for (int i = 0; i < dtsub_Temp.Rows.Count; i++)
                            {
                                if (dtsub_Temp.Rows[i]["PRODUCTION_DATE"].ToString().Equals(""))
                                {
                                    CoFAS_DevExpressManager.ShowErrorMessage("검사/제조일자를 입력해주세요");
                                    CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
                                    return;
                                }

                                sConfiguration_code = dtsub_Temp.Rows[i]["CONFIGURATION_CODE"].ToString().Substring(0, 2);
                                ok_qty += Convert.ToDecimal(dtsub_Temp.Rows[i]["PRODUCTION_OK_QTY"].ToString());
                                Inspect_qty += Convert.ToDecimal(dtsub_Temp.Rows[i]["PRODUCTION_INSPECTION_QTY"].ToString());
                                pass_qty += Convert.ToDecimal(dtsub_Temp.Rows[i]["PRODUCTION_PASS_QTY"].ToString());
                            }

                            // 실적수량 < 검사수량
                            if (ok_qty < Inspect_qty)
                            {
                                CoFAS_DevExpressManager.ShowErrorMessage("검사수량은 실적수량보다 클 수 없습니다");
                                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
                                return;
                            }

                            // 실적수량 < 합격수량
                            if (ok_qty < pass_qty)
                            {
                                CoFAS_DevExpressManager.ShowErrorMessage("합격수량은 실적수량보다 클 수 없습니다");
                                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
                                return;
                            }




                            // 불량수량 Check Validation
                            if (CoFAS_ConvertManager.DataTable_FindCount(dtNg, "(CRUD IN ('U') AND BAD_GROUP_CODE = 'BC01') OR (PRODUCTION_NG_RESULT > 0 AND BAD_GROUP_CODE NOT IN('BC02','BC03'))", ""))
                            {
                                dtNg_Temp = CoFAS_ConvertManager.DataTable_FindValue(dtNg, "(CRUD IN ('U') AND BAD_GROUP_CODE = 'BC01') OR (PRODUCTION_NG_RESULT > 0 AND BAD_GROUP_CODE NOT IN('BC02','BC03'))", "");
                                for (int i = 0; i < dtNg_Temp.Rows.Count; i++)
                                {
                                    Ng_qty += Convert.ToDecimal(dtNg_Temp.Rows[i]["PRODUCTION_NG_RESULT"].ToString());
                                }
                            }

                            // 불량수량 < 합격수량
                            if (Ng_qty > pass_qty)
                            {
                                CoFAS_DevExpressManager.ShowErrorMessage("불량수량은 합격수량보다 클 수 없습니다");
                                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
                                return;
                            }

                            // 합격수량 = 실적수량 - 불량수량
                            if (pass_qty != (ok_qty - Ng_qty))
                            {
                                CoFAS_DevExpressManager.ShowErrorMessage("합격수량과 불량수량의 합이 실적수량과 상이합니다");
                                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
                                return;
                            }


                            // 합격수량 <= 1000
                            if ((pass_qty - Ng_qty) > 1000)
                            {
                                CoFAS_DevExpressManager.ShowErrorMessage("합격수량은 1000개를 넘을 수 없습니다.");
                                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
                                return;
                            }

                            // 포장수량 Check Validation
                            string sRoutingCheck = string.Empty;
                            if (CoFAS_ConvertManager.DataTable_FindCount(_dtEquip, "ROUTING_CODE = '" + _luEQUIPMENT_LIST.GetValue() + "'", ""))
                            {
                                sRoutingCheck = CoFAS_ConvertManager.DataTable_FindValue(_dtEquip, "ROUTING_CODE = '" + _luEQUIPMENT_LIST.GetValue() + "'", "").Rows[0]["CONFIGURATION_CODE"].ToString();

                                if (sRoutingCheck.ToString().Substring(0, 2) == "PK")
                                {

                                    if (CoFAS_ConvertManager.DataTable_FindCount(dtPacking, "PACKING_QTY = 0", ""))
                                    {
                                        for (int i = 0; i < dtPacking.Rows.Count; i++)
                                        {
                                            if (dtPacking.Rows[i]["PACKING_QTY"].ToString().Equals("0"))
                                            {
                                                dtPacking.Rows[i]["CRUD"] = "D";
                                            }
                                        }
                                    }

                                    if (CoFAS_ConvertManager.DataTable_FindCount(dtPacking, "CRUD IN ('C','U','D')", ""))
                                    {
                                        dtPacking_Temp = CoFAS_ConvertManager.DataTable_FindValue(dtPacking, "CRUD IN ('C','U','D')", "");
                                        for (int i = 0; i < dtPacking_Temp.Rows.Count; i++)
                                        {
                                            Packing_qty += Convert.ToDecimal(dtPacking_Temp.Rows[i]["PACKING_QTY"].ToString());
                                        }
                                    }

                                    // 포장수량 <= 합격수량
                                    if (Packing_qty > pass_qty)
                                    {
                                        CoFAS_DevExpressManager.ShowErrorMessage("포장수량은 양품수량보다 많을 수 없습니다.");
                                        CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
                                        return;
                                    }
                                    else
                                    {
                                        dtPacking_Temp = CoFAS_ConvertManager.DataTable_FindValue(dtPacking, "CRUD IN ('C','U','D')", "");
                                    }
                                }
                            }
                        }

                        #endregion


                        #region 테이블 데이터호출 초기화
                        DataTable dt1;
                        DataTable dtTemp1 = null;

                        DataTable dt2;
                        DataTable dtTemp2 = null;

                        DataTable dt3;
                        DataTable dtTemp3 = null;

                        DataTable dt4;
                        DataTable dtTemp4 = null;
                        #endregion

                        #region 결과테이블 생성
                        DataTable resultdt = new DataTable();
                        resultdt.Columns.Add(new DataColumn("RESOURCE_CODE", typeof(string)));
                        resultdt.Columns.Add(new DataColumn("COLLECTION_DATE", typeof(string)));
                        resultdt.Columns.Add(new DataColumn("PROPERTY_VALUE", typeof(string)));
                        resultdt.Columns.Add(new DataColumn("CONDITION_CODE", typeof(string)));
                        resultdt.Columns.Add(new DataColumn("OPTION_CODE", typeof(string)));
                        resultdt.Columns.Add(new DataColumn("COLLECTION_VALUE", typeof(string)));
                        resultdt.Columns.Add(new DataColumn("COLLECTION_VALUE_STR", typeof(string)));
                        resultdt.Columns.Add(new DataColumn("USER_CODE", typeof(string)));
                        DataRow row = null;
                        #endregion

                        #region 생성데이터 확인

                        #region 실적 수량

                        dt1 = _gdSUB.DataSource as DataTable;
                        if (CoFAS_ConvertManager.DataTable_FindCount(dt1, "CRUD IN ('U')", ""))
                        {
                            dtTemp1 = CoFAS_ConvertManager.DataTable_FindValue(dt1, "CRUD IN ('U')", "");

                            for (int i = 0; i < dtTemp1.Rows.Count; i++)
                            {
                                if (Convert.ToDecimal(dtTemp1.Rows[i]["ORIGIN_PRODUCTION_OK_QTY"].ToString()) == 0)
                                {
                                    row = resultdt.NewRow();
                                    row["RESOURCE_CODE"] = _luEQUIPMENT_LIST.GetValue().ToString();
                                    row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                    row["PROPERTY_VALUE"] = _pWorkResultRegister_T05Entity.LOT_ID;
                                    row["CONDITION_CODE"] = "CD501001";
                                    row["OPTION_CODE"] = "";  // 검사코드 PC190001
                                    row["COLLECTION_VALUE"] = dtTemp1.Rows[i]["PRODUCTION_OK_QTY"].ToString();
                                    row["COLLECTION_VALUE_STR"] = "";
                                    row["USER_CODE"] = _pWorkResultRegister_T05Entity.USER_CODE;
                                    resultdt.Rows.Add(row);
                                }
                                else
                                {

                                    row = resultdt.NewRow();
                                    row["RESOURCE_CODE"] = _luEQUIPMENT_LIST.GetValue().ToString();
                                    row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                    row["PROPERTY_VALUE"] = _pWorkResultRegister_T05Entity.LOT_ID;
                                    row["CONDITION_CODE"] = "CD501001";
                                    row["OPTION_CODE"] = "";  // 검사코드 PC190001
                                    row["COLLECTION_VALUE"] = (Convert.ToDecimal(dtTemp1.Rows[i]["ORIGIN_PRODUCTION_OK_QTY"].ToString()) * -1);
                                    row["COLLECTION_VALUE_STR"] = "";
                                    row["USER_CODE"] = _pWorkResultRegister_T05Entity.USER_CODE;
                                    resultdt.Rows.Add(row);

                                    row = resultdt.NewRow();
                                    row["RESOURCE_CODE"] = _luEQUIPMENT_LIST.GetValue().ToString();
                                    row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                    row["PROPERTY_VALUE"] = _pWorkResultRegister_T05Entity.LOT_ID;
                                    row["CONDITION_CODE"] = "CD501001";
                                    row["OPTION_CODE"] = "";  // 검사코드 PC190001
                                    row["COLLECTION_VALUE"] = Convert.ToDecimal(dtTemp1.Rows[i]["PRODUCTION_OK_QTY"].ToString());
                                    row["COLLECTION_VALUE_STR"] = "";
                                    row["USER_CODE"] = _pWorkResultRegister_T05Entity.USER_CODE;
                                    resultdt.Rows.Add(row);
                                }
                            }
                        }
                        #endregion

                        #region 검사 수량
                        dt2 = _gdSUB.DataSource as DataTable;
                        if (CoFAS_ConvertManager.DataTable_FindCount(dt2, "CRUD IN ('U')", ""))
                        {
                            dtTemp2 = CoFAS_ConvertManager.DataTable_FindValue(dt2, "CRUD IN ('U')", "");

                            for (int i = 0; i < dtTemp2.Rows.Count; i++)
                            {
                                if (Convert.ToDecimal(dtTemp1.Rows[i]["ORIGIN_PRODUCTION_INSPECTION_QTY"].ToString()) == 0)
                                {
                                    row = resultdt.NewRow();
                                    row["RESOURCE_CODE"] = _luEQUIPMENT_LIST.GetValue().ToString();
                                    row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                    row["PROPERTY_VALUE"] = _pWorkResultRegister_T05Entity.LOT_ID;
                                    row["CONDITION_CODE"] = "";
                                    row["OPTION_CODE"] = "PC190001";  // 검사코드 PC190001
                                    row["COLLECTION_VALUE"] = dtTemp2.Rows[i]["PRODUCTION_INSPECTION_QTY"].ToString();
                                    row["COLLECTION_VALUE_STR"] = "";
                                    row["USER_CODE"] = _pWorkResultRegister_T05Entity.USER_CODE;
                                    resultdt.Rows.Add(row);
                                }
                                else
                                {
                                    row = resultdt.NewRow();
                                    row["RESOURCE_CODE"] = _luEQUIPMENT_LIST.GetValue().ToString();
                                    row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                    row["PROPERTY_VALUE"] = _pWorkResultRegister_T05Entity.LOT_ID;
                                    row["CONDITION_CODE"] = "";
                                    row["OPTION_CODE"] = "PC190001";  // 검사코드 PC190001
                                    row["COLLECTION_VALUE"] = (Convert.ToDecimal(dtTemp2.Rows[i]["ORIGIN_PRODUCTION_INSPECTION_QTY"].ToString()) * -1);
                                    row["COLLECTION_VALUE_STR"] = "";
                                    row["USER_CODE"] = _pWorkResultRegister_T05Entity.USER_CODE;
                                    resultdt.Rows.Add(row);

                                    row = resultdt.NewRow();
                                    row["RESOURCE_CODE"] = _luEQUIPMENT_LIST.GetValue().ToString();
                                    row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                    row["PROPERTY_VALUE"] = _pWorkResultRegister_T05Entity.LOT_ID;
                                    row["CONDITION_CODE"] = "";
                                    row["OPTION_CODE"] = "PC190001";  // 검사코드 PC190001
                                    row["COLLECTION_VALUE"] = Convert.ToDecimal(dtTemp2.Rows[i]["PRODUCTION_INSPECTION_QTY"].ToString());
                                    row["COLLECTION_VALUE_STR"] = "";
                                    row["USER_CODE"] = _pWorkResultRegister_T05Entity.USER_CODE;
                                    resultdt.Rows.Add(row);
                                }
                            }
                        }
                        #endregion

                        #region 합격 수량 Validation

                        #endregion

                        #region 불량 수량 
                        dt3 = _gdSUB_NG.DataSource as DataTable;
                        if (CoFAS_ConvertManager.DataTable_FindCount(dt3, "CRUD IN ('U')", ""))
                        {
                            dtTemp3 = CoFAS_ConvertManager.DataTable_FindValue(dt3, "CRUD IN ('U')", "");
                            for (int i = 0; i < dtTemp3.Rows.Count; i++)
                            {
                                if (Convert.ToDecimal(dtTemp3.Rows[i]["ORIGIN_PRODUCTION_NG_RESULT"].ToString()) == 0)
                                {
                                    row = resultdt.NewRow();
                                    row["RESOURCE_CODE"] = _luEQUIPMENT_LIST.GetValue().ToString();
                                    row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                    row["PROPERTY_VALUE"] = _pWorkResultRegister_T05Entity.LOT_ID;
                                    row["CONDITION_CODE"] = dtTemp3.Rows[i]["BAD_CODE"].ToString();
                                    row["OPTION_CODE"] = "";
                                    row["COLLECTION_VALUE"] = dtTemp3.Rows[i]["PRODUCTION_NG_RESULT"].ToString();
                                    row["COLLECTION_VALUE_STR"] = "";
                                    row["USER_CODE"] = _pWorkResultRegister_T05Entity.USER_CODE;
                                    resultdt.Rows.Add(row);
                                }
                                else
                                {
                                    row = resultdt.NewRow();
                                    row["RESOURCE_CODE"] = _luEQUIPMENT_LIST.GetValue().ToString();
                                    row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                    row["PROPERTY_VALUE"] = _pWorkResultRegister_T05Entity.LOT_ID;
                                    row["CONDITION_CODE"] = dtTemp3.Rows[i]["BAD_CODE"].ToString();
                                    row["OPTION_CODE"] = "";
                                    row["COLLECTION_VALUE"] = (Convert.ToDecimal(dtTemp3.Rows[i]["ORIGIN_PRODUCTION_NG_RESULT"].ToString()) * -1);
                                    row["COLLECTION_VALUE_STR"] = "";
                                    row["USER_CODE"] = _pWorkResultRegister_T05Entity.USER_CODE;
                                    resultdt.Rows.Add(row);

                                    row = resultdt.NewRow();
                                    row["RESOURCE_CODE"] = _luEQUIPMENT_LIST.GetValue().ToString();
                                    row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                    row["PROPERTY_VALUE"] = _pWorkResultRegister_T05Entity.LOT_ID;
                                    row["CONDITION_CODE"] = dtTemp3.Rows[i]["BAD_CODE"].ToString();
                                    row["OPTION_CODE"] = "";
                                    row["COLLECTION_VALUE"] = Convert.ToDecimal(dtTemp3.Rows[i]["PRODUCTION_NG_RESULT"].ToString());
                                    row["COLLECTION_VALUE_STR"] = "";
                                    row["USER_CODE"] = _pWorkResultRegister_T05Entity.USER_CODE;
                                    resultdt.Rows.Add(row);
                                }

                            }
                        }
                        #endregion

                        #region 상태 수량
                        dt4 = _gdSUB_STATUS.DataSource as DataTable;
                        if (CoFAS_ConvertManager.DataTable_FindCount(dt4, "CRUD IN ('U')", ""))
                        {
                            dtTemp4 = CoFAS_ConvertManager.DataTable_FindValue(dt4, "CRUD IN ('U')", "");
                            for (int i = 0; i < dtTemp4.Rows.Count; i++)
                            {
                                if (Convert.ToDecimal(dtTemp4.Rows[i]["ORIGIN_STATUS_MIN"].ToString()) == 0)
                                {
                                    row = resultdt.NewRow();
                                    row["RESOURCE_CODE"] = _luEQUIPMENT_LIST.GetValue().ToString();
                                    row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                    row["PROPERTY_VALUE"] = _pWorkResultRegister_T05Entity.LOT_ID;
                                    row["CONDITION_CODE"] = dtTemp4.Rows[i]["EQUIPMENT_STOP_CODE"].ToString();
                                    row["OPTION_CODE"] = "PC190002";
                                    row["COLLECTION_VALUE"] = dtTemp4.Rows[i]["STATUS_MIN"].ToString();
                                    row["COLLECTION_VALUE_STR"] = "";
                                    row["USER_CODE"] = _pWorkResultRegister_T05Entity.USER_CODE;
                                    resultdt.Rows.Add(row);
                                }
                                else
                                {
                                    row = resultdt.NewRow();
                                    row["RESOURCE_CODE"] = _luEQUIPMENT_LIST.GetValue().ToString();
                                    row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                    row["PROPERTY_VALUE"] = _pWorkResultRegister_T05Entity.LOT_ID;
                                    row["CONDITION_CODE"] = dtTemp4.Rows[i]["EQUIPMENT_STOP_CODE"].ToString();
                                    row["OPTION_CODE"] = "PC190002";
                                    row["COLLECTION_VALUE"] = (Convert.ToDecimal(dtTemp4.Rows[i]["ORIGIN_STATUS_MIN"].ToString()) * -1);
                                    row["COLLECTION_VALUE_STR"] = "";
                                    row["USER_CODE"] = _pWorkResultRegister_T05Entity.USER_CODE;
                                    resultdt.Rows.Add(row);

                                    row = resultdt.NewRow();
                                    row["RESOURCE_CODE"] = _luEQUIPMENT_LIST.GetValue().ToString();
                                    row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                    row["PROPERTY_VALUE"] = _pWorkResultRegister_T05Entity.LOT_ID;
                                    row["CONDITION_CODE"] = dtTemp4.Rows[i]["EQUIPMENT_STOP_CODE"].ToString();
                                    row["OPTION_CODE"] = "PC190002";
                                    row["COLLECTION_VALUE"] = Convert.ToDecimal(dtTemp4.Rows[i]["STATUS_MIN"].ToString());
                                    row["COLLECTION_VALUE_STR"] = "";
                                    row["USER_CODE"] = _pWorkResultRegister_T05Entity.USER_CODE;
                                    resultdt.Rows.Add(row);
                                }

                            }
                        }
                        #endregion

                        #endregion

                        //#endregion
                        _pWorkResultRegister_T05Entity.MTC_NO = _luMTC_NO.Text;
                        _pWorkResultRegister_T05Entity.MATERAL_TRS_NO = _luMATERAL_TRS_NO.Text;
                        string sCheckMessage = "공정 : " + _luPROCESS_LIST.GetDisplayName().ToString();
                        sCheckMessage += "\n수량 : " + ok_qty + "\n검사수량 :" + Inspect_qty + "\n합격수량 :" + pass_qty;
                        if (Ng_qty > 0)
                        {
                            sCheckMessage += "\n불량수량 :" + Ng_qty;
                        }

                        if (Packing_qty > 0)
                        {
                            sCheckMessage += "\n포장수량 :" + Packing_qty;
                            sCheckMessage += "\n 입력하신 수량으로 등록하고 \n포장되지 않은 제품을 재고처리 하시겠습니까?";
                        }
                        else
                        {
                            sCheckMessage += "\n 입력하신 수량으로 등록하시겠습니까?";
                        }

                        if (CoFAS_DevExpressManager.ShowQuestionMessage(sCheckMessage) == DialogResult.Yes)
                        {
                            isError = new WorkResultRegister_T05Business().WorkResultRegister_Save(_pWorkResultRegister_T05Entity, resultdt, dtPacking_Temp, dtsub_Temp);

                            if (!isError)
                            {
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                _gdSUB.DataSource = null;
                                _gdSUB_NG.DataSource = null;
                                _gdSUB_STATUS.DataSource = null;
                                _gdSUB_PACK.DataSource = null;

                                _luFA_CODE.Text = "";
                                _luLOT_NO.Text = "";
                                _luMTC_NO.Text = "";
                                _luSPEC_NO.Text = "";
                                _luDRAWING_NO.Text = "";
                                _luPURCHASE_SPEC_NO.Text = "";
                                _luWO_NO.Text = "";
                                _luITEM_NO.Text = "";
                                _luWO_QTY.Text = "";
                                _luPO_NO.Text = "";
                                _luMATERAL_TRS_NO.Text = "";
                                _luTOTAL_COUNT.Text = "";
                                MainFind_DisplayData();

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
            finally
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 팝업 이벤트

        #region ● 품목찾기 팝업
        private void _luTPART__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "Product_Code_R2", "" };
                frmCommonPopup.ARRAY_CODE = new object[2] { "","" };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {

                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        #endregion

        #endregion


        #region LOT 생성(사용안함X)
        private void _ucbtLOT_CREATE_Click(object sender, EventArgs e)
        {
            //CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
            //if (_pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID.ToString().Equals(""))
            //{
            //    CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            //    return;
            //}

            
            //bool isError = false;
            //_pWorkResultRegister_T05Entity.CRUD = "C";

            //if (_ckUAE_LOT.Checked)
            //{
            //    _pWorkResultRegister_T05Entity.USA_LOT_CHECK = "Y";
            //}
            //else
            //{
            //    _pWorkResultRegister_T05Entity.USA_LOT_CHECK = "N";
            //}
            
            //try
            //{
            //    isError = new WorkResultRegister_T05Business().WorkResultRegister_Mst_Lot_save(_pWorkResultRegister_T05Entity);

            //    if (!isError)
            //    {
            //        _luLOT_NO.Text = _pWorkResultRegister_T05Entity.RTN_LOT_NO.ToString();
            //        SubFind_DisplayData(_pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID, _pWorkResultRegister_T05Entity.LOT_ID);
            //        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
            //    }
            //    else
            //    {
            //        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
            //    }
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
            //finally
            //{
            //    CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            //}
        }
        #endregion

        #region 자동계산(검사)
        private void _gdSUB_VIEW_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            _gdSUB_VIEW.CellValueChanged -= _gdSUB_VIEW_CellValueChanged;
            //ChangeValues(sender, e);
            _gdSUB_VIEW.CellValueChanged += _gdSUB_VIEW_CellValueChanged;
        }

        private void ChangeValues(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //GridView g = sender as GridView;

            //int selectedRowNum = g.FocusedRowHandle;
            //int selectedCellNum = g.FocusedColumn.VisibleIndex;

            //if (Convert.ToInt32(g.GetRowCellDisplayText(selectedRowNum, "PRODUCTION_OK_QTY")) <= 0) return;


            //decimal ok_qty = Convert.ToDecimal(g.GetRowCellDisplayText(selectedRowNum, "PRODUCTION_OK_QTY") == "" ? "0" : g.GetRowCellDisplayText(selectedRowNum, "PRODUCTION_OK_QTY"));
            //decimal inspect_qty = Convert.ToDecimal(g.GetRowCellDisplayText(selectedRowNum, "PRODUCTION_INSPECTION_QTY") == "" ? "0" : g.GetRowCellDisplayText(selectedRowNum, "PRODUCTION_INSPECTION_QTY"));
            //decimal cost = 0;

            //cost = ok_qty - inspect_qty;
            //if(cost < 0)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage("검사수량이 실적수량보다 클 수 없습니다.");
            //    g.SetFocusedRowCellValue("PRODUCTION_INSPECTION_QTY", 0);
            //}
        }
        #endregion

        #region 조회 - 제품검색 PART EVENT
        
        private void _luTPART__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                PO.UserForm.frmCommonPopup.CRUD = "R";
                PO.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                PO.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                PO.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                PO.UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" };
                PO.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _luTPART.CodeText.ToString(), _luTPART.NameText.ToString() };
                PO.UserForm.frmCommonPopup xfrmCommonPopup = new PO.UserForm.frmCommonPopup("ucProductionPartListPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luTPART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();
                    _luTPART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();

                    _pWorkResultRegister_T05Entity.PART_CODE = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region 조회 - 주문번호 검색 ORDER NUMBER EVENT

        private void _luTORDER_NUMBER__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                PO.UserForm.frmCommonPopup.CRUD = "R";
                PO.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                PO.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                PO.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                PO.UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" };
                PO.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _luTORDER_NUMBER.CodeText.ToString(), _luTORDER_NUMBER.NameText.ToString() };
                PO.UserForm.frmCommonPopup xfrmCommonPopup = new PO.UserForm.frmCommonPopup("ucOrderNumberInfoListPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luTORDER_NUMBER.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["ORDER_NUMBER"].ToString();
                    _luTORDER_NUMBER.NameText = xfrmCommonPopup.dtReturn.Rows[0]["ORDER_NAME"].ToString();
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region 문서보기
        public void DocumentView(string sFileName, string sType)
        {
            string tempFolderPath = "";
            string strFTP_PATH = "";

            strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_IP_PORT, "FILE_DATA", sType);

            tempFolderPath = System.IO.Path.GetTempPath() + sFileName;

            CoFAS_FTPManager.FTPFileView(strFTP_PATH, sFileName, _pFTP_ID, _pFTP_PW, tempFolderPath);
        }
        

        private void _luSPEC_NO__OnMouseUp(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                if (_pWorkResultRegister_T05Entity.SPEC_NO_FILENAME == null || _luSPEC_NO.Text == "") return;

                DocumentView(_pWorkResultRegister_T05Entity.SPEC_NO_FILENAME, _pWorkResultRegister_T05Entity.SPEC_NO_TYPE);
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

        private void _luDRAWING_NO__OnMouseUp(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                if (_pWorkResultRegister_T05Entity.DRAWING_NO_FILENAME == null || _luDRAWING_NO.Text == "") return;
                DocumentView(_pWorkResultRegister_T05Entity.DRAWING_NO_FILENAME, _pWorkResultRegister_T05Entity.DRAWING_NO_TYPE);
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

        private void _luPURCHASE_SPEC_NO__OnMouseUp(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                if (_pWorkResultRegister_T05Entity.PURCHASE_SPEC_NO_FILENAME == null || _luPURCHASE_SPEC_NO.Text == "") return;
                DocumentView(_pWorkResultRegister_T05Entity.PURCHASE_SPEC_NO_FILENAME, _pWorkResultRegister_T05Entity.PURCHASE_SPEC_NO_TYPE);
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

        #region 키보드 이동
        private void _gdMAIN_VIEW_RowChange(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                if ((gv.DataSource as DataTable) == null) return;
                int qRowIndex = gv.FocusedRowHandle;
                if (qRowIndex < 0) return;

                _gdSUB.DataSource = null;
                _gdSUB_NG.DataSource = null;
                _gdSUB_STATUS.DataSource = null;
                oPRODUCTION_ORDER_ID = gv.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString();
                if (oPRODUCTION_ORDER_ID != "")
                {
                    _pWorkResultRegister_T05Entity.CRUD = "R";
                    _pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID = oPRODUCTION_ORDER_ID;
                    _dtEquip = new WorkResultRegister_T05Business().WorkResultRegister_Info_Equip(_pWorkResultRegister_T05Entity);

                    if (_pWorkResultRegister_T05Entity.CRUD == "")
                        _dtEquip.Rows.Clear();
                }
                MainBindingFind_DisplayData(gv.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString(), gv.GetFocusedRowCellValue("LOT_ID").ToString());
                SubFind_DisplayData(gv.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString(), gv.GetFocusedRowCellValue("LOT_ID").ToString());
                SubFind_Packing_DisplayData(gv.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString(), _pWorkResultRegister_T05Entity.LOT_ID);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion
    }
}
