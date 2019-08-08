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

using CoFAS_MES.UI.MM.Business;
using CoFAS_MES.UI.MM.Entity;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Business;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using CoFAS_MES.CORE.UserForm;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;

namespace CoFAS_MES.UI.MM
{
    public partial class MaterialInRegister_Request_T01 : frmBaseNone
    {

        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭
        private string _pUSER_GRANT = string.Empty;
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

        private MaterialInRegister_Request_T01Entity _pMaterialInRegister_Request_T01Entity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtList2 = null; //서브 조회 데이터 리스트
        private DataTable _dtList3 = null; //하위품목 조회 데이터 리스트

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        private decimal in_qty = 0;
        public MaterialInRegister_Request_T01()
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
                CoFAS_DevExpressManager._OnButtonPressed -= CoFAS_DevExpressManager__OnButtonPressed;
                _gdSUB_VIEW.CellValueChanged -= _gdSUB_VIEW_CellValueChanged;
                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;
                _gdSUB_VIEW.RowCellClick -= _gdSUB_VIEW_RowCellClick;
                //_gdMAIN_VIEW.InitNewRow -= _gdMAIN_VIEW_InitNewRow;
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

                _pWINDOW_NAME = this.Name;
                _pMENU_NAME = this.Text;

                //메뉴 화면 엔티티 설정
                _pMaterialInRegister_Request_T01Entity = new MaterialInRegister_Request_T01Entity();
                _pMaterialInRegister_Request_T01Entity.USER_CODE = _pUSER_CODE;
                _pMaterialInRegister_Request_T01Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

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
                _pMaterialInRegister_Request_T01Entity.CRUD = "";
                _pMaterialInRegister_Request_T01Entity.MATSTOCK_CODE = "1002"; // COMMON_CODE = MR02 일반입고가 기본

                _gdTHIRD.DataSource = null;
                layoutControlGroup8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                if (_pFirstYN)
                {

                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    _gdSUB_VIEW.RowCellClick += _gdSUB_VIEW_RowCellClick;
                    

                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
                    SubFind_DisplayData_init();
                    _pFirstYN = false;
                }

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행


                //_luUNITCOST.Properties.MaxLength = 10;
                //_luINOUT_QTY.Properties.MaxLength = 10;
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
            try
            {
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                    _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
                    _gdTHIRD_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdTHIRD, _gdTHIRD_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdTHIRD.Name.ToString()));

                    CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;
                    _gdSUB_VIEW.CellValueChanged += _gdSUB_VIEW_CellValueChanged;
                    _gdTHIRD_VIEW.InitNewRow += _gdTHIRD_VIEW_InitNewRow;
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
                _luTMATSTOCK_DATE.FromDateTime = Convert.ToDateTime("2000-01-01"); //new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luTMATSTOCK_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정

                _luMATSTOCK_ID.Text = "";
                _luMATSTOCK_SEQ.Text = "";
                _luMATSTOCK_DATE.DateTime = DateTime.Today;
                _luTVEND_CODE.NameText = "";
                _luTVEND_CODE.CodeText = "";
                _luVEND_CODE.NameText = "";
                _luVEND_CODE.CodeText = "";
                _luREMARK.Text = "";
                //_luTPART.NameText = "";
                //_luTPART.CodeText = "";
                _gdSUB.DataSource = null;
                _gdMAIN.DataSource = null;
                _luMATSTOCK_DATE.ReadOnly = false;
                _ucbtMATREFER.Visible = true;
                _pMaterialInRegister_Request_T01Entity.MATSTOCK_ID = "";
                _pMaterialInRegister_Request_T01Entity.REFERENCE_ID = "";
                _pMaterialInRegister_Request_T01Entity.ORDER_ID = "";

                _luTUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "",true);
                _luTUSE_YN.ItemIndex = 1;

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "", false);
                _luUSE_YN.ItemIndex = 0;
                

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();
                // 컨트롤러 유효성 검증 처리
                

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

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                _luMATSTOCK_DATE.ReadOnly = true;
                _ucbtMATREFER.Visible = false;
                _luVEND_CODE.CodeText = gv.GetFocusedRowCellValue("VEND_CODE").ToString();
                _luVEND_CODE.NameText = gv.GetFocusedRowCellValue("VEND_NAME").ToString();
                _pMaterialInRegister_Request_T01Entity.MATSTOCK_ID = gv.GetFocusedRowCellValue("MATSTOCK_ID").ToString();
                _gdTHIRD.DataSource = null;
                layoutControlGroup8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                SubFind_DisplayData();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region 서브 그리드 로우 선택
        private void _gdSUB_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                
                if(layoutControlGroup8.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
                {
                    _pMaterialInRegister_Request_T01Entity.MATSTOCK_ID = gv.GetFocusedRowCellValue("MATSTOCK_ID").ToString();
                    _pMaterialInRegister_Request_T01Entity.MATSTOCK_DETAIL_SEQ = gv.GetFocusedRowCellValue("MATSTOCK_DETAIL_SEQ").ToString();
                    ThirdFind_DisplayData();
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            //try
            //{
            //    GridView gv = sender as GridView;

            //    if (gv.FocusedRowHandle < 0) return;
            //    if (gv.GetFocusedRowCellValue("MATSTOCK_ID").ToString().Equals(""))
            //    {
            //        return;
            //    }

            //    if (gv.GetFocusedRowCellValue("INSPECT_CHECK").ToString().Equals("Y"))
            //    {
            //        gv.SetFocusedRowCellValue("INSPECT_CHECK", "N");
            //    }
            //    else
            //    {
            //        gv.SetFocusedRowCellValue("INSPECT_CHECK", "Y");
            //    }
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
        }
        #endregion

        #region ○ 메인 그리드 신규로우 생성시 이벤트 생성 - _gdMAIN_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdTHIRD_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
        }
        #endregion

        // 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                //if (_luTMATSTOCK_DATE.FromDateTime > _luTMATSTOCK_DATE.ToDateTime)
                //{
                //    //CoFAS_DevExpressManager.ShowInformationMessage("조회 일자를 확인해 주세요.");
                //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_SEARCH_DATE);
                //}
                //else
                //{
                //    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //    InitializeControl();

                //    _pMaterialInRegister_Request_T01Entity.CRUD = "R";
                //    _pMaterialInRegister_Request_T01Entity.DATE_FROM = DateTime.Parse(_luTMATSTOCK_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luTORDER_DATE.FromDateTime).Replace("-", "").Substring(0, 8);//
                //    _pMaterialInRegister_Request_T01Entity.DATE_TO = DateTime.Parse(_luTMATSTOCK_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luTORDER_DATE.ToDateTime).Replace("-", "").Substring(0, 8);//
                //    _pMaterialInRegister_Request_T01Entity.VEND_NAME = _luTVEND_CODE.NameText;
                //    _pMaterialInRegister_Request_T01Entity.VEND_CODE = _luTVEND_CODE.CodeText;
                //    //_pMaterialInRegister_Request_T01Entity.PART_NAME = _luTPART.NameText;
                //    _pMaterialInRegister_Request_T01Entity.PART_CODE = "";
                //    //_pMaterialInRegister_Request_T01Entity.VEND_PART_CODE = _luTPART.CodeText;
                //    _pMaterialInRegister_Request_T01Entity.USE_YN = _luTUSE_YN.GetValue();

                    MainFind_DisplayData();


                    //DisplayMessage("조회 되었습니다.");
                    DisplayMessage(_pMSG_SEARCH);
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

        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                
                InputData_Save(_pMaterialInRegister_Request_T01Entity);
                
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

        }
        #endregion

        #region ○ 삭제 버튼 클릭시 처리하기
        private void Form_DeleteButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //if (!dxValidationProvider.Validate())
                //{
                //    //MessageBox.Show("빈값이 있음");
                //    MessageBox.Show(_pMSG_CHECK_VALID_ITEM);
                //    return;
                //}
               

                //InputData_Save(_pMaterialInRegister_Request_T01Entity);
                //InitializeControl();
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

        #region ○ 인쇄 버튼 클릭시 처리하기
        private void Form_PrintButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                if (_pMaterialInRegister_Request_T01Entity.MATSTOCK_ID == "") return;

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                string strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pWINDOW_NAME);
                //string strFTP_PATH = string.Format()
                string strFILE_NAME = "MaterialInRegister_Request_T01_Report.xlsx";

                MM.UserForm.frmCommonPopup.CRUD = "R";
                MM.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                MM.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                MM.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
                MM.UserForm.frmCommonPopup.FTP_ID = _pFTP_ID;
                MM.UserForm.frmCommonPopup.FTP_PW = _pFTP_PW;

                MM.UserForm.frmCommonPopup.strFTP_PATH = strFTP_PATH;
                MM.UserForm.frmCommonPopup.strFile_NAME = strFILE_NAME;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                MM.UserForm.frmCommonPopup.ARRAY = new object[3] { "", "", "" };
                MM.UserForm.frmCommonPopup.ARRAY_CODE = new object[5] { _pWINDOW_NAME, "", _pMaterialInRegister_Request_T01Entity.MATSTOCK_ID, 30, 0 };
                MM.UserForm.frmCommonPopup xfrmCommonPopup = new MM.UserForm.frmCommonPopup("ucExcelViewPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

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
                //확인
                if (_gdSUB_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n초기화 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_RESET_QUESTION) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        InitializeSetting();

                        //DisplayMessage("초기화했습니다.");
                        DisplayMessage(_pMSG_RESET_COMPLETE);
                        MainFind_DisplayData();
                        SubFind_DisplayData_init();
                    }
                }
                else
                {
                    InitializeSetting();

                    //DisplayMessage("초기화했습니다.");
                    DisplayMessage(_pMSG_RESET_COMPLETE);
                    MainFind_DisplayData();
                    SubFind_DisplayData_init();
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
                //xfrmPageSetting.PASS_CORP_CODE = _pCORP_CDDE;
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
                _pMaterialInRegister_Request_T01Entity.CRUD = "R";

                _pMaterialInRegister_Request_T01Entity.DATE_FROM = DateTime.Parse(_luTMATSTOCK_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");
                _pMaterialInRegister_Request_T01Entity.DATE_TO = DateTime.Parse(_luTMATSTOCK_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");
                _pMaterialInRegister_Request_T01Entity.VEND_CODE = _luTVEND_CODE.CodeText.ToString();
                _pMaterialInRegister_Request_T01Entity.USE_YN = _luTUSE_YN.GetValue().ToString();

                _dtList = new MaterialInRegister_Request_T01Business().Material_In_Mst(_pMaterialInRegister_Request_T01Entity);

                if (_pMaterialInRegister_Request_T01Entity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pMaterialInRegister_Request_T01Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
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

                _pMaterialInRegister_Request_T01Entity.CRUD = "R";
                _dtList2 = new MaterialInRegister_Request_T01Business().Material_In_Sub(_pMaterialInRegister_Request_T01Entity);

                if (_pMaterialInRegister_Request_T01Entity.CRUD == "")
                    _dtList2.Rows.Clear();


                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pMaterialInRegister_Request_T01Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList2); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtList2.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList2); //데이터 필드에 맞춰 자동 바인딩
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

        #region ○ 서브조회 - SubFind_DisplayData_init()
        private void SubFind_DisplayData_init()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pMaterialInRegister_Request_T01Entity.CRUD = "";
                _dtList2 = new MaterialInRegister_Request_T01Business().Material_In_Sub(_pMaterialInRegister_Request_T01Entity);

                if (_pMaterialInRegister_Request_T01Entity.CRUD == "")
                    _dtList2.Rows.Clear();


                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pMaterialInRegister_Request_T01Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList2); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    _dtList2.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList2); //데이터 필드에 맞춰 자동 바인딩
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

        #region 하위품목 조회
        private void ThirdFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pMaterialInRegister_Request_T01Entity.CRUD = "R";

                if(_pMaterialInRegister_Request_T01Entity.MATSTOCK_ID == "" || _pMaterialInRegister_Request_T01Entity.MATSTOCK_DETAIL_SEQ == "")
                {
                    return;
                }

                _dtList3 = new MaterialInRegister_Request_T01Business().Material_In_Thrid(_pMaterialInRegister_Request_T01Entity);

                if (_pMaterialInRegister_Request_T01Entity.CRUD == "")
                    _dtList3.Rows.Clear();


                if ((_dtList3 != null && _dtList3.Rows.Count > 0) || (_dtList3 != null && _pMaterialInRegister_Request_T01Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdTHIRD, _gdTHIRD_VIEW, _dtList3); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    _dtList3.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdTHIRD, _gdTHIRD_VIEW, _dtList3); //데이터 필드에 맞춰 자동 바인딩
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

        private void InputData_Save(MaterialInRegister_Request_T01Entity _pMaterialInRegister_Request_T01Entity)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                bool isError = false;
                DataTable dt = null;
                DataTable dtTemp = null;
                DataTable dtThird = null;
                DataTable dtThird_Temp = null;

                using (DBManager pDBManager = new DBManager())
                {
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                    {
                        dt = _gdSUB.DataSource as DataTable;
                        dtThird = _gdTHIRD.DataSource as DataTable;

                        if (_luMATSTOCK_ID.Text.ToString().Equals(""))
                        {
                            _pMaterialInRegister_Request_T01Entity.CRUD = "C";
                        }
                        else
                        {
                            _pMaterialInRegister_Request_T01Entity.CRUD = "U";
                        }

                        _pMaterialInRegister_Request_T01Entity.MATSTOCK_ID = _luMATSTOCK_ID.Text.ToString();
                        _pMaterialInRegister_Request_T01Entity.MATSTOCK_SEQ = _luMATSTOCK_SEQ.Text.ToString();
                        _pMaterialInRegister_Request_T01Entity.MATSTOCK_DATE = _luMATSTOCK_DATE.DateTime.ToString("yyyyMMdd");
                        _pMaterialInRegister_Request_T01Entity.USE_YN = _luUSE_YN.GetValue().ToString();
                        _pMaterialInRegister_Request_T01Entity.VEND_CODE = _luVEND_CODE.CodeText.ToString();
                        _pMaterialInRegister_Request_T01Entity.REMARK = _luREMARK.Text.ToString();


                        if (CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", ""))
                        {
                            dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", "");

                            for (int i = 0; i < dtTemp.Rows.Count; i++)
                            {
                                if (dtTemp.Rows[i]["LOT_ID"].ToString().Equals(""))
                                {
                                    CoFAS_DevExpressManager.ShowInformationMessage("LOT_ID를 입력해주시기 바랍니다.");
                                    return;
                                }

                                if (dtTemp.Rows[i]["MATSTOCK_DETAIL_QTY"].ToString().Equals(""))
                                {
                                    CoFAS_DevExpressManager.ShowInformationMessage("입고수량을 공란으로 설정할 수 없습니다.");
                                    return;
                                }
                                if (Convert.ToDecimal(dtTemp.Rows[i]["MATSTOCK_DETAIL_QTY"].ToString()) <= 0)
                                {
                                    CoFAS_DevExpressManager.ShowInformationMessage("입고수량을 0으로 설정할 수 없습니다.");
                                    return;
                                }
                                if (dtTemp.Rows[i]["UNITCOST"].ToString().Equals(""))
                                {
                                    CoFAS_DevExpressManager.ShowInformationMessage("단가 공란으로 설정할 수 없습니다.");
                                    return;
                                }
                                if (Convert.ToDecimal(dtTemp.Rows[i]["UNITCOST"].ToString()) <= 0)
                                {
                                    CoFAS_DevExpressManager.ShowInformationMessage("단가를 0으로 설정할 수 없습니다.");
                                    return;
                                }
                            }
                        }

                        if (CoFAS_ConvertManager.DataTable_FindCount(dtThird, "CRUD IN ('C','U','D')", ""))
                        {
                            dtThird_Temp = CoFAS_ConvertManager.DataTable_FindValue(dtThird, "CRUD IN ('C','U','D')", "");

                            for (int i = 0; i < dtThird_Temp.Rows.Count; i++)
                            {
                                if (dtThird_Temp.Rows[i]["MATSTOCK_SUB_NAME"].ToString().Equals(""))
                                {
                                    CoFAS_DevExpressManager.ShowInformationMessage("품목명을 입력해주세요.");
                                    return;
                                }

                                if (Convert.ToDecimal(dtThird_Temp.Rows[i]["MATSTOCK_SUB_QTY"].ToString()) <= 0)
                                {
                                    CoFAS_DevExpressManager.ShowInformationMessage("단가를 0으로 설정할 수 없습니다.");
                                    return;
                                }
                            }
                        }

                        isError = new MaterialInRegister_Request_T01Business().MaterialInRegister_Request_T01_Info_Save(_pMaterialInRegister_Request_T01Entity, dtTemp, dtThird_Temp);


                        if (isError)
                        {
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                        }
                        else
                        {
                            //정상 처리
                            InitializeSetting();
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                            MainFind_DisplayData();
                        }
                    }
                    else
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_DATA);
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

        #region ○ 메인 그리드 신규로우 생성시 이벤트 생성 - _gdMAIN_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdMAIN_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
        }
        #endregion

        #region ○ 팝업 불러오기

        #region ○ 팝업 거래처코드
        private void _luVEND_CODE__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                frmCommonPopup.ARRAY = new object[2] { "vend_code_I", "" };
                frmCommonPopup.ARRAY_CODE = new object[2] { _luVEND_CODE.CodeText, _luVEND_CODE.NameText };
                frmCommonPopup xfrmcommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmcommonPopup.ShowDialog();

                if (xfrmcommonPopup.dtReturn == null)
                {
                    xfrmcommonPopup.Dispose();
                    return;
                }

                if (xfrmcommonPopup.dtReturn != null && xfrmcommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luVEND_CODE.CodeText = xfrmcommonPopup.dtReturn.Rows[0]["CD"].ToString();        // 거래처코드 : 거래처명
                    _luVEND_CODE.NameText = xfrmcommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
                }

                xfrmcommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 조회조건 팝업 거래처코드

        private void _luTVEND__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                frmCommonPopup.ARRAY = new object[2] { "vend_code_I", "" };
                frmCommonPopup.ARRAY_CODE = new object[2] { _luTVEND_CODE.CodeText, _luTVEND_CODE.NameText };
                frmCommonPopup xfrmcommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmcommonPopup.ShowDialog();

                if (xfrmcommonPopup.dtReturn == null)
                {
                    xfrmcommonPopup.Dispose();
                    return;
                }

                if (xfrmcommonPopup.dtReturn != null && xfrmcommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luTVEND_CODE.CodeText = xfrmcommonPopup.dtReturn.Rows[0]["CD"].ToString();        // 거래처코드 : 거래처명
                    _luTVEND_CODE.NameText = xfrmcommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
                }

                xfrmcommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #endregion

        #region 시험접수
        private void _ucbtINSPECT_REQUEST_Click(object sender, EventArgs e)
        {

            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                DataTable dt = null;
                DataTable dtTemp = null;

                _pMaterialInRegister_Request_T01Entity.MATSTOCK_ID = _luMATSTOCK_ID.Text;
                
                bool isError = false;

                dt = _gdSUB.DataSource as DataTable;

                if (CoFAS_ConvertManager.DataTable_FindCount(dt, "INSPECT_CHECK = 'Y'", ""))
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "INSPECT_CHECK = 'Y'", "");
                    using (DBManager pDBManager = new DBManager())
                    {
                        if (CoFAS_DevExpressManager.ShowQuestionMessage("시험의뢰를 하시겠습니까?") == DialogResult.Yes)
                        {
                            //시험접수(완료) 자재 체크
                            for(int i=0;i<dtTemp.Rows.Count;i++)
                            {
                                if(dtTemp.Rows[i]["INSPECT_STATUS"].ToString().Equals("QC010003") ||
                                    dtTemp.Rows[i]["INSPECT_STATUS"].ToString().Equals("QC010004"))
                                {
                                    CoFAS_DevExpressManager.ShowErrorMessage("이미 시험의뢰를 맡긴 자재가 있습니다.");
                                    return;
                                }

                                if (dtTemp.Rows[i]["MATSTOCK_DETAIL_SEQ"].ToString().Equals(""))
                                {
                                    CoFAS_DevExpressManager.ShowErrorMessage("정보가 저장되지 않은 자재 있습니다.");
                                    return;
                                }

                                if (dtTemp.Rows[i]["USE_YN"].ToString().Equals("N"))
                                {
                                    CoFAS_DevExpressManager.ShowErrorMessage("사용여부가 미사용으로 되어있는 자재가 있습니다.");
                                    return;
                                }
                            }
                            _pMaterialInRegister_Request_T01Entity.CRUD = "C";
                            isError = new MaterialInRegister_Request_T01Business().MaterialInRegister_Request_T01_Info_Check_Save(_pMaterialInRegister_Request_T01Entity, dtTemp);

                            if (isError)
                            {
                                //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                            }
                            else
                            {
                                //정상 처리
                                InitializeSetting();
                                //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                MainFind_DisplayData();
                            }
                        }
                    }
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("하나 이상의 자재를 선택하세요 ");
                    return;
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
        
        #region 금액 계산
        private void _gdSUB_VIEW_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            _gdSUB_VIEW.CellValueChanged -= _gdSUB_VIEW_CellValueChanged;
            ChangeValues(sender, e);
            _gdSUB_VIEW.CellValueChanged += _gdSUB_VIEW_CellValueChanged;
        }

        private void ChangeValues(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView g = sender as GridView;

            int selectedRowNum = g.FocusedRowHandle;
            int selectedCellNum = g.FocusedColumn.VisibleIndex;

            if (g.GetRowCellDisplayText(selectedRowNum, "MATSTOCK_DETAIL_QTY").Equals("")) return;

            decimal order_qty = Convert.ToDecimal(g.GetRowCellDisplayText(selectedRowNum, "MATSTOCK_DETAIL_QTY") == "" ? "0" : g.GetRowCellDisplayText(selectedRowNum, "MATSTOCK_DETAIL_QTY"));
            decimal unit_cost = Convert.ToDecimal(g.GetRowCellDisplayText(selectedRowNum, "UNITCOST") == "" ? "0" : g.GetRowCellDisplayText(selectedRowNum, "UNITCOST"));
            decimal cost = 0;

            cost = order_qty * unit_cost;
            g.SetFocusedRowCellValue("COST", cost);
        }
        #endregion

        #region ○ 그리드 버튼추가 시 클릭 이벤트 생성 - CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        private void CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CoFAS_DevExpressManager._OnButtonPressed -= CoFAS_DevExpressManager__OnButtonPressed;
            btnEvent(sender, e);
            CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;
        }

        private void btnEvent(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btnedit = sender as ButtonEdit;
            GridView g = null;
            string _sFCode = string.Empty;
            string _sFName = string.Empty;
            string _sFVendCode = string.Empty;


            string _sResultCode = string.Empty;
            string _sResultName = string.Empty;
            string _sResultVendPartCode = string.Empty;

            if (btnedit != null)
            {
                var gridControl = btnedit.Parent as DevExpress.XtraGrid.GridControl;
                if (gridControl == null)
                    return;

                var gridView = gridControl.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
                g = gridView;
                if (gridView == null)
                    return;

                var dataRow = gridView.GetFocusedDataRow();
                if (dataRow == null)
                    return;
            }


            //switch (e.Button.Caption.ToString())
            switch (g.FocusedColumn.FieldName)
            {
                case "BTN_SUB":
                    if(g.GetFocusedRowCellValue("MATSTOCK_DETAIL_SEQ").ToString().Equals("") || g.GetFocusedRowCellValue("USE_YN").ToString().Equals("N"))
                    {
                        return;
                    }

                    if(layoutControlGroup8.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
                    {
                        _gdTHIRD.DataSource = null;
                        layoutControlGroup8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    }else
                    {
                        layoutControlGroup8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    }
                    
                    break;

                //case "BTN_INMAT": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.

                //    _sFCode = g.GetFocusedRowCellValue("PART_CODE").ToString();
                //    _sFName = g.GetFocusedRowCellValue("PART_NAME").ToString();
                //    _sFVendCode = g.GetFocusedRowCellValue("VEND_PART_CODE").ToString();


                //    UserForm.frmCommonPopup.CRUD = "R";
                //    UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                //    UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                //    UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                //    // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                //    UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" };
                //    UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _sFVendCode, _sFName };
                //    UserForm.frmCommonPopup xfrmCommonPopup = new UserForm.frmCommonPopup("ucMaterialPartListPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                //    xfrmCommonPopup.ShowDialog();

                //    if (xfrmCommonPopup.dtReturn == null)
                //    {
                //        xfrmCommonPopup.Dispose();
                //        return;
                //    }

                //    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                //    {
                //        //_luTPART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();
                //        //_luTPART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();

                //        _sResultVendPartCode = xfrmCommonPopup.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();
                //        _sResultName = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                //        _sResultCode = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                //        //_luPART_CODE.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                //    }

                //    if (!_sResultCode.Equals("") && !_sResultName.Equals(""))
                //    {
                //        g.SetFocusedRowCellValue("PART_CODE", _sResultCode);
                //        g.SetFocusedRowCellValue("PART_NAME", _sResultName);
                //        g.SetFocusedRowCellValue("VEND_PART_CODE", _sResultVendPartCode);
                //    }

                //    xfrmCommonPopup.Dispose();

                //    break;
                //case "BTN_INVEND":
                //    _sFCode = g.GetFocusedRowCellValue("VEND_CODE").ToString();
                //    _sFName = g.GetFocusedRowCellValue("VEND_NAME").ToString();

                //    frmCommonPopup.CRUD = "R";
                //    frmCommonPopup.USER_CODE = _pUSER_CODE;
                //    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                //    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                //    frmCommonPopup.ARRAY = new object[2] { "vend_code", "" };
                //    frmCommonPopup.ARRAY_CODE = new object[2] { _sFCode, _sFName };
                //    frmCommonPopup xfrmCommonPopup2 = new frmCommonPopup("CommonCode");

                //    xfrmCommonPopup2.ShowDialog();

                //    if (xfrmCommonPopup2.dtReturn == null)
                //    {
                //        xfrmCommonPopup2.Dispose();
                //        return;
                //    }
                //    if (xfrmCommonPopup2.dtReturn.Rows.Count > 0)
                //    {
                //        _sResultCode = xfrmCommonPopup2.dtReturn.Rows[0]["CD"].ToString();
                //        _sResultName = xfrmCommonPopup2.dtReturn.Rows[0]["CD_NM"].ToString();
                //    }

                //    xfrmCommonPopup2.Dispose();

                //    if (!_sResultCode.Equals("") && !_sResultName.Equals(""))
                //    {
                //        g.SetFocusedRowCellValue("VEND_CODE", _sResultCode);
                //        g.SetFocusedRowCellValue("VEND_NAME", _sResultName);
                //    }
                //    break;
                //case "BTN_MATREFER":
                //    _sFCode = g.GetFocusedRowCellValue("REFERENCE_ID").ToString();
                //    //_sFName = g.GetFocusedRowCellValue("VEND_NAME").ToString();

                //    frmCommonPopup.CRUD = "R";
                //    frmCommonPopup.USER_CODE = _pUSER_CODE;
                //    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                //    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                //    frmCommonPopup.ARRAY = new object[2] { "order_id", "" }; //넘기는 파라메터 에 따라 설정
                //    frmCommonPopup.ARRAY_CODE = new object[1] { "material" };
                //    frmCommonPopup xfrmCommonPopup3 = new CORE.UserForm.frmCommonPopup("MaterialOrder"); //유저컨트롤러 설정 부분

                //    xfrmCommonPopup3.ShowDialog();

                //    if (xfrmCommonPopup3.dtReturn == null)
                //    {
                //        xfrmCommonPopup3.Dispose();
                //        return;
                //    }
                //    if (xfrmCommonPopup3.dtReturn.Rows.Count > 0)
                //    {
                //        g.SetFocusedRowCellValue("REFERENCE_ID", xfrmCommonPopup3.dtReturn.Rows[0]["ORDER_ID"].ToString());
                //        g.SetFocusedRowCellValue("PART_CODE", xfrmCommonPopup3.dtReturn.Rows[0]["PART_CODE"].ToString());
                //        g.SetFocusedRowCellValue("PART_NAME", xfrmCommonPopup3.dtReturn.Rows[0]["PART_NAME"].ToString());
                //        g.SetFocusedRowCellValue("VEND_CODE", xfrmCommonPopup3.dtReturn.Rows[0]["VEND_CODE"].ToString());
                //        g.SetFocusedRowCellValue("VEND_NAME", xfrmCommonPopup3.dtReturn.Rows[0]["VEND_NAME"].ToString());

                //        g.SetFocusedRowCellValue("INOUT_QTY", xfrmCommonPopup3.dtReturn.Rows[0]["ORDER_QTY"].ToString());
                //        g.SetFocusedRowCellValue("NIN_QTY", xfrmCommonPopup3.dtReturn.Rows[0]["NIN_QTY"].ToString());
                //        g.SetFocusedRowCellValue("UNITCOST", xfrmCommonPopup3.dtReturn.Rows[0]["UNITCOST"].ToString());
                //        g.SetFocusedRowCellValue("COST", xfrmCommonPopup3.dtReturn.Rows[0]["COST"].ToString());
                //        g.SetFocusedRowCellValue("PART_UNIT", xfrmCommonPopup3.dtReturn.Rows[0]["PART_UNIT"].ToString());
                //    }

                //    xfrmCommonPopup3.Dispose();
                //    return;
                    
                //    break;
            }
        }

        #endregion
        
        #region 발주입고
        private void _ucbtMATREFER_Click(object sender, EventArgs e)
        {
            DataTable _dtRefer_mst = null;
            DataTable _dtRefer_sub = null;
            DataTable _oriSub = _gdSUB.DataSource as DataTable;

            try
            {
                
                
                UserForm.frmCommonPopup.CRUD = "R";
                UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" };
                UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { "", "" };
                UserForm.frmCommonPopup xfrmCommonPopup = new UserForm.frmCommonPopup("ucMaterialOrderRegister_Request_T01");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    // ORDER_ID 받음

                    if(xfrmCommonPopup.dtReturn.Rows[0]["ORDER_ID"].ToString().Equals(""))
                    {
                        xfrmCommonPopup.Dispose();
                        return;
                    }
                    else
                    {
                        _pMaterialInRegister_Request_T01Entity.ORDER_ID = xfrmCommonPopup.dtReturn.Rows[0]["ORDER_ID"].ToString();

                        CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                        _pMaterialInRegister_Request_T01Entity.CRUD = "R";

                        _dtRefer_mst = new MaterialInRegister_Request_T01Business().Material_Order_Mst(_pMaterialInRegister_Request_T01Entity);

                        //_dtRefer_sub = new MaterialInRegister_Request_T01Business().Material_Order_Sub(_pMaterialInRegister_Request_T01Entity);

                        //_dtRefer_sub.Columns["ORDER_QTY"].ColumnName = "MATSTOCK_DETAIL_QTY";

                        _pMaterialInRegister_Request_T01Entity.REFERENCE_ID = _pMaterialInRegister_Request_T01Entity.ORDER_ID;
                        _luMATSTOCK_DATE.DateTime = DateTime.Today;
                        _luVEND_CODE.CodeText = _dtRefer_mst.Rows[0]["VEND_CODE"].ToString();
                        _luVEND_CODE.NameText = _dtRefer_mst.Rows[0]["VEND_NAME"].ToString();
                        _luUSE_YN.SetValue("Y");
                        _luREMARK.Text = _dtRefer_mst.Rows[0]["REMARK"].ToString();
                        _pMaterialInRegister_Request_T01Entity.MATSTOCK_CODE = "1001"; // COMMON_CODE = MR02 // 발주입고를 누르면 코드값이 발주입고로 변함

                        DataTable dt = (_gdSUB.DataSource as DataTable);

                        for (int i=0;i< xfrmCommonPopup.dtReturn.Rows.Count;i++)
                        {
                            if (!(CoFAS_ConvertManager.DataTable_FindCount(dt, "PART_CODE = '" + xfrmCommonPopup.dtReturn.Rows[i]["PART_CODE"].ToString() + "'", "")))
                            {
                                xfrmCommonPopup.dtReturn.Rows[i]["CRUD"] = "C";
                                dt.ImportRow(xfrmCommonPopup.dtReturn.Rows[i]);
                            }
                                
                        }

                        //CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtRefer_sub); //데이터 필드에 맞춰 자동 바인딩

                    }
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

        #region 일반입고
        private void _ucbtMATIN_Click(object sender, EventArgs e)
        {
            try
            {
                UserForm.frmCommonPopup.CRUD = "R";
                UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" };
                UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { "", "" };
                UserForm.frmCommonPopup xfrmCommonPopup = new UserForm.frmCommonPopup("ucMaterialPartListPopup_T01");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    DataTable dt = (_gdSUB.DataSource as DataTable);

                    if (!xfrmCommonPopup.dtReturn.Columns.Contains("MATSTOCK_DETAIL_QTY"))
                    {
                        xfrmCommonPopup.dtReturn.Columns.Add(new DataColumn("MATSTOCK_DETAIL_QTY", typeof(string)));
                    }
                    if (!xfrmCommonPopup.dtReturn.Columns.Contains("COST"))
                    {
                        xfrmCommonPopup.dtReturn.Columns.Add(new DataColumn("COST", typeof(string)));
                    }
                    if (!xfrmCommonPopup.dtReturn.Columns.Contains("USE_YN"))
                    {
                        xfrmCommonPopup.dtReturn.Columns.Add(new DataColumn("USE_YN", typeof(string)));
                    }


                    for (int i = 0; i < xfrmCommonPopup.dtReturn.Rows.Count; i++)
                    {
                        xfrmCommonPopup.dtReturn.Rows[i]["CRUD"] = "C";
                        xfrmCommonPopup.dtReturn.Rows[i]["MATSTOCK_DETAIL_QTY"] = 0;
                        xfrmCommonPopup.dtReturn.Rows[i]["COST"] = 0;
                        xfrmCommonPopup.dtReturn.Rows[i]["USE_YN"] = "Y";
                        ////dt.NewRow();
                        if (!(CoFAS_ConvertManager.DataTable_FindCount(dt, "PART_CODE = '" + xfrmCommonPopup.dtReturn.Rows[i]["PART_CODE"].ToString() + "'", "")))
                            dt.ImportRow(xfrmCommonPopup.dtReturn.Rows[i]);
                    }
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, dt);
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

    }
}