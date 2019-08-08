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
    public partial class WorkResultRegister_T03 : frmBaseNone
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

        private WorkResultRegister_T03Entity _pWorkResultRegister_T03Entity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtSub = null;
        private DataTable _dtSub_detail1 = null;
        private DataTable _dtSub_detail2 = null;
        private DataTable _dtSub_detail3 = null;
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private int _gdMAIN_index = -1;

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

        public WorkResultRegister_T03()
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
                _gdSUB1_VIEW.InitNewRow -= _gdSUB_VIEW_InitNewRow;
                _gdSUB2_VIEW.InitNewRow -= _gdSUB_VIEW_InitNewRow;
                _gdSUB3_VIEW.InitNewRow -= _gdSUB_VIEW_InitNewRow;
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
                _pWorkResultRegister_T03Entity = new WorkResultRegister_T03Entity();
                _pWorkResultRegister_T03Entity.USER_CODE = _pUSER_CODE;
                _pWorkResultRegister_T03Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

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
                _pWorkResultRegister_T03Entity.CRUD = "";
                if (_pFirstYN)
                {
                    xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
                    Form_SearchButtonClicked(null,null); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
                    _pFirstYN = false;
                }

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                _gdMAIN_LOT_VIEW.RowCellClick += _gdMAIN_LOT_VIEW_RowCellClick;
                _gdSUB1_VIEW.InitNewRow += _gdSUB_VIEW_InitNewRow;
                _gdSUB2_VIEW.InitNewRow += _gdSUB_VIEW_InitNewRow;
                _gdSUB3_VIEW.InitNewRow += _gdSUB_VIEW_InitNewRow;
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
                    _gdMAIN_LOT_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN_LOT, _gdMAIN_LOT_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN_LOT.Name.ToString()));
                    _gdSUB1_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB1, _gdSUB1_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB1.Name.ToString()));
                    _gdSUB2_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB2, _gdSUB2_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB2.Name.ToString()));
                    _gdSUB3_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB3, _gdSUB3_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB3.Name.ToString()));
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
                _luTORDER_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luTORDER_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                _luTWORK_ORDER.Text = "";
                _luTPART.NameText = "";
                _luTPART.CodeText = "";
                _luPRODUCTION_ORDER_ID.Text = "";
                _luPART_NAME.Text = "";
                _luLOT_NO.Text = "";
                _ckUSA_LOT.Checked = false;

                //_luTWC_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "WORKCENTER", "", "", "").Tables[0], 0, 0, "", true);
                //_luTPC_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "PROCESSCODE_MAIN", "", "", "").Tables[0], 0, 0, "", true);

                //데이터 영역

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _gdMAIN.DataSource = null;
                _gdMAIN_LOT.DataSource = null;
                _gdSUB1.DataSource = null;
                _gdSUB2.DataSource = null;
                _gdSUB3.DataSource = null;
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

                //CoFAS_ControlManager.Controls_Binding(gv, false, this);

                int qRowIndex = gv.FocusedRowHandle;
                if (qRowIndex < 0) return;
                //string qColumnHeader = e.Column.Caption;
                string qWorkOrderID = gv.GetRowCellValue(qRowIndex, "PRODUCTION_ORDER_ID").ToString();
                string qPART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                string qPART_NAME = gv.GetFocusedRowCellValue("PART_NAME").ToString();

                _pWorkResultRegister_T03Entity.PART_CODE = qPART_CODE;
                _pWorkResultRegister_T03Entity.PART_NAME = qPART_NAME;

                _luPRODUCTION_ORDER_ID.Text = qWorkOrderID;
                _luPART_NAME.Text = _pWorkResultRegister_T03Entity.PART_NAME;
                _luLOT_NO.Text = "";
                _gdSUB1.DataSource = null;
                _gdSUB2.DataSource = null;
                _gdSUB3.DataSource = null;

                //_gdMAIN_index = qRowIndex;
                //_pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID = gv.GetRowCellValue(qRowIndex, "PRODUCTION_ORDER_ID").ToString();
                //_pWorkResultRegister_T03Entity.PART_CODE = gv.GetRowCellValue(qRowIndex, "PART_CODE").ToString();
                //_pWorkResultRegister_T03Entity.PART_NAME = gv.GetRowCellValue(qRowIndex, "PART_NAME").ToString(); ;
                //_pWorkResultRegister_T03Entity.PROCESS_CODE = gv.GetRowCellValue(qRowIndex, "PROCESS_CODE").ToString();
                //_pWorkResultRegister_T03Entity.USE_YN = gv.GetRowCellValue(qRowIndex, "PRODUCTION_STATUS").ToString();

                //switch (qColumnHeader)
                //{
                //    case "양품":
                //    case "불량":
                //    case "상태":
                //        SubFind_DisplayData(qWorkOrderID, qColumnHeader);
                //        break;
                //    default:
                //        break;
                //}

                SubFind_DisplayData(qWorkOrderID);
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

                //CoFAS_ControlManager.Controls_Binding(gv, false, this);

                int qRowIndex = gv.FocusedRowHandle;
                if (qRowIndex < 0) return;

                string qWorkOrderID = gv.GetRowCellValue(qRowIndex, "PRODUCTION_ORDER_ID").ToString();
                string qLotno = gv.GetRowCellValue(qRowIndex, "LOT_NO").ToString();
                string qLotid = gv.GetRowCellValue(qRowIndex, "LOT_ID").ToString();


                _luLOT_NO.Text = qLotno;
                


                SubFind_DisplayData_sub1(qWorkOrderID, qLotid);
                SubFind_DisplayData_sub2(qWorkOrderID, qLotid);
                SubFind_DisplayData_sub3(qWorkOrderID, qLotid);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 서브 디테일 그리드 신규로우 생성시 이벤트 생성 - _gdSUB1_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdSUB_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            //_gdSUB1_VIEW.InitNewRow += _gdSUB_VIEW_InitNewRow;
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_CODE"], _pWorkResultRegister_T03Entity.PART_CODE);
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_NAME"], _pWorkResultRegister_T03Entity.PART_NAME);
        }
        #endregion

        // 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pWorkResultRegister_T03Entity.CRUD = "R";
                _pWorkResultRegister_T03Entity.DATE_FROM = DateTime.Parse(_luTORDER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");
                _pWorkResultRegister_T03Entity.DATE_TO = DateTime.Parse(_luTORDER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");
                _pWorkResultRegister_T03Entity.PART_CODE = _luTPART.CodeText;
                _pWorkResultRegister_T03Entity.PART_NAME = _luTPART.NameText;
                _pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID = _luTWORK_ORDER.Text;
                _pWorkResultRegister_T03Entity.VEND_PART_CODE = "";
                //_pWorkResultRegister_T03Entity.PROCESS_CODE_MST = _luTPC_CODE.GetValue();
                //_pWorkResultRegister_T03Entity.PROCESS_CODE = _luTWC_CODE.GetValue();

                MainFind_DisplayData();

                _pWorkResultRegister_T03Entity.PART_NAME = "";
                _pWorkResultRegister_T03Entity.PART_CODE = "";

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

                InputData_Save(_pWorkResultRegister_T03Entity);
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
                //CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //if(_gdMAIN_index > -1)
                //{
                //    //// 작업장 필수항목 체크 - 팝업 불필요
                //    //if(_pWorkResultRegisterEntity.PROCESS_CODE == "")
                //    //{
                //    //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PROCESS_CODE);
                //    //    return;
                //    //}
                //    // 작업상태 완료시 체크 - 수정불가
                //    if(_pWorkResultRegister_T03Entity.USE_YN == "ES011003")
                //    {
                //        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_STATUS_OK);
                //        return;
                //    }

                //    // 팝업에 파라미터 전송
                //    frmCommonPopup.USER_CODE = _pUSER_CODE;
                //    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                //    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                //    _pLocation_Code = _pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID;
                //    frmCommonPopup.ARRAY_CODE = new object[4] { _pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID, _pWorkResultRegister_T03Entity.PART_CODE, _pWorkResultRegister_T03Entity.PART_NAME , _pWorkResultRegister_T03Entity.PROCESS_CODE };
                //    frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("WorkResult"); //유저컨트롤러 설정 부분

                //    xfrmCommonPopup.ShowDialog();
                //    xfrmCommonPopup.Dispose();

                //    _gdMAIN_index = -1;

                //    Form_SearchButtonClicked(null, null);
                //}
                //else
                //{
                //    //CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 선택하여주시기 바랍니다.");
                //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SELECT);
                //    return;
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
                _pWorkResultRegister_T03Entity.CRUD = "R";
                _dtList = new WorkResultRegister_T03Business().WorkResultRegister_Info_Mst(_pWorkResultRegister_T03Entity);

                if (_pWorkResultRegister_T03Entity.CRUD == "")
                    _dtList.Rows.Clear();

                if((_dtList != null && _dtList.Rows.Count > 0) || (_dtList !=null && _pWorkResultRegister_T03Entity.CRUD == ""))
                {
                    //데이터 필드에 맞춰 자동 바인딩
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("PRODUCTION_ORDER_ID", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;


                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }

                    //xtraTabControl1.SelectedTabPageIndex = 0;
                    //CoFAS_DevExpressManager.BindGridControl(_gdSUB1, _gdSUB1_VIEW, null);
                    //CoFAS_DevExpressManager.BindGridControl(_gdSUB2, _gdSUB2_VIEW, null);
                    //CoFAS_DevExpressManager.BindGridControl(_gdSUB3, _gdSUB3_VIEW, null);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtList.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    //CoFAS_DevExpressManager.BindGridControl(_gdSUB1, _gdSUB1_VIEW, _dtList);
                    //CoFAS_DevExpressManager.BindGridControl(_gdSUB2, _gdSUB2_VIEW, _dtList);
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

        private void SubFind_DisplayData(string qWorkOrder)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pWorkResultRegister_T03Entity.CRUD = "R";
                _pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID = qWorkOrder;
                _dtSub = new WorkResultRegister_T03Business().WorkResultRegister_Info_Mst_Lot(_pWorkResultRegister_T03Entity);

                if (_pWorkResultRegister_T03Entity.CRUD == "")
                    _dtSub.Rows.Clear();

                if (_dtSub != null && _dtSub.Rows.Count > 0)
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN_LOT, _gdMAIN_LOT_VIEW, _dtSub); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtSub.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN_LOT, _gdMAIN_LOT_VIEW, _dtSub); //데이터 필드에 맞춰 자동 바인딩
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

        #region 서브1조회 - 합격
        private void SubFind_DisplayData_sub1(string qWorkOrder, string qLotid)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pWorkResultRegister_T03Entity.CRUD = "R";
                _pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID = qWorkOrder;
                _pWorkResultRegister_T03Entity.LOT_ID = qLotid;
                _dtSub_detail1 = new WorkResultRegister_T03Business().WorkResultRegister_Info_Sub_Detail1(_pWorkResultRegister_T03Entity);

                if (_pWorkResultRegister_T03Entity.CRUD == "")
                    _dtSub_detail1.Rows.Clear();

                if (_dtSub_detail1 != null && _dtSub_detail1.Rows.Count > 0)
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB1, _gdSUB1_VIEW, _dtSub_detail1); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtSub_detail1.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB1, _gdSUB1_VIEW, _dtSub_detail1); //데이터 필드에 맞춰 자동 바인딩
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

        #region 서브2조회 - 불량
        private void SubFind_DisplayData_sub2(string qWorkOrder, string qLotid)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pWorkResultRegister_T03Entity.CRUD = "R";
                _pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID = qWorkOrder;
                _pWorkResultRegister_T03Entity.LOT_ID = qLotid;
                _dtSub_detail2 = new WorkResultRegister_T03Business().WorkResultRegister_Info_Sub_Detail2(_pWorkResultRegister_T03Entity);

                if (_pWorkResultRegister_T03Entity.CRUD == "")
                    _dtSub_detail2.Rows.Clear();

                if (_dtSub_detail2 != null && _dtSub_detail2.Rows.Count > 0)
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB2, _gdSUB2_VIEW, _dtSub_detail2); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtSub_detail2.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB2, _gdSUB2_VIEW, _dtSub_detail2); //데이터 필드에 맞춰 자동 바인딩
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

        #region 서브3조회 - 상태
        private void SubFind_DisplayData_sub3(string qWorkOrder, string qLotid)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pWorkResultRegister_T03Entity.CRUD = "R";
                _pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID = qWorkOrder;
                _pWorkResultRegister_T03Entity.LOT_ID = qLotid;
                _dtSub_detail3 = new WorkResultRegister_T03Business().WorkResultRegister_Info_Sub_Detail3(_pWorkResultRegister_T03Entity);

                if (_pWorkResultRegister_T03Entity.CRUD == "")
                    _dtSub_detail3.Rows.Clear();

                if (_dtSub_detail3 != null && _dtSub_detail3.Rows.Count > 0)
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB3, _gdSUB3_VIEW, _dtSub_detail3); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtSub_detail3.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB3, _gdSUB3_VIEW, _dtSub_detail3); //데이터 필드에 맞춰 자동 바인딩
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

        private void InputData_Save(WorkResultRegister_T03Entity _pWorkResultRegister_T03Entity)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                using (DBManager pDBManager = new DBManager())
                {
                    bool isError = false;

                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                    {

                        #region SUB테이블 데이터호출 초기화
                        DataTable dt1;
                        DataTable dtTemp1 = null;

                        DataTable dt2;
                        DataTable dtTemp2 = null;

                        DataTable dt3;
                        DataTable dtTemp3 = null;
                        #endregion

                        #region 결과테이블 생성
                        DataTable resultdt = new DataTable();
                        resultdt.Columns.Add(new DataColumn("RESOURCE_CODE", typeof(string)));
                        resultdt.Columns.Add(new DataColumn("COLLECTION_DATE", typeof(string)));
                        resultdt.Columns.Add(new DataColumn("PROPERTY_VALUE", typeof(string)));
                        resultdt.Columns.Add(new DataColumn("CONDITION_CODE", typeof(string)));
                        resultdt.Columns.Add(new DataColumn("COLLECTION_VALUE", typeof(string)));

                        DataRow row = null;
                        #endregion


                        #region 생성데이터 확인

                        dt1 = _gdSUB1.DataSource as DataTable;
                        if (CoFAS_ConvertManager.DataTable_FindCount(dt1, "CRUD IN ('C')", ""))
                        {
                            dtTemp1 = CoFAS_ConvertManager.DataTable_FindValue(dt1, "CRUD IN ('C','U','D')", "");
                            
                            for(int i = 0;i< dtTemp1.Rows.Count;i++)
                            {
                                
                                row = resultdt.NewRow(); 
                                row["RESOURCE_CODE"] = dtTemp1.Rows[i]["PROCESS_CODE"].ToString();
                                row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                row["PROPERTY_VALUE"] = _pWorkResultRegister_T03Entity.LOT_ID;
                                row["CONDITION_CODE"] = "CD501001";
                                row["COLLECTION_VALUE"] = dtTemp1.Rows[i]["PRODUCTION_RESULT"].ToString();
                                resultdt.Rows.Add(row);
                            }
                        }

                        dt2 = _gdSUB2.DataSource as DataTable;
                        if (CoFAS_ConvertManager.DataTable_FindCount(dt2, "CRUD IN ('C')", ""))
                        {
                            dtTemp2 = CoFAS_ConvertManager.DataTable_FindValue(dt2, "CRUD IN ('C')", "");

                            for (int i = 0; i < dtTemp2.Rows.Count; i++)
                            {

                                row = resultdt.NewRow();
                                row["RESOURCE_CODE"] = dtTemp2.Rows[i]["PROCESS_CODE"].ToString();
                                row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                row["PROPERTY_VALUE"] = _pWorkResultRegister_T03Entity.LOT_ID;
                                row["CONDITION_CODE"] = dtTemp2.Rows[i]["BAD_CODE"].ToString();
                                row["COLLECTION_VALUE"] = dtTemp2.Rows[i]["PRODUCTION_NG_RESULT"].ToString();
                                resultdt.Rows.Add(row);
                            }
                        }

                        dt3 = _gdSUB3.DataSource as DataTable;
                        if (CoFAS_ConvertManager.DataTable_FindCount(dt3, "CRUD IN ('C')", ""))
                        {
                            dtTemp3 = CoFAS_ConvertManager.DataTable_FindValue(dt3, "CRUD IN ('C')", "");

                            for (int i = 0; i < dtTemp3.Rows.Count; i++)
                            {

                                row = resultdt.NewRow();
                                row["RESOURCE_CODE"] = dtTemp3.Rows[i]["PROCESS_CODE"].ToString();
                                row["COLLECTION_DATE"] = DateTime.Now.ToString("yyyyMMddHHmmss");
                                row["PROPERTY_VALUE"] = _pWorkResultRegister_T03Entity.LOT_ID;
                                row["CONDITION_CODE"] = dtTemp3.Rows[i]["PRODUCTION_STATUS"].ToString();

                                DateTime pDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                                TimeSpan pTimeSpan = Convert.ToDateTime(dtTemp3.Rows[i]["STATUS_TIME"].ToString().Replace("/ ", "")) - pDateTime;

                                row["COLLECTION_VALUE"] = pTimeSpan.TotalSeconds.ToString();
                                resultdt.Rows.Add(row);
                            }
                        }

                        #endregion

                        isError = new WorkResultRegister_T03Business().WorkResultRegister_Save(_pWorkResultRegister_T03Entity, resultdt);

                        if (!isError)
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                        }
                        else
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
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
                frmCommonPopup.ARRAY_CODE = new object[2] { _luTPART.CodeText.ToString(), _luTPART.NameText.ToString() };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luTPART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                    _luTPART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
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

        #region LOT 생성
        private void _ucbtCREATE_Click(object sender, EventArgs e)
        {

            CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
            int rowhandle = 0;
            if (_pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID.ToString().Equals(""))
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
                return;
            }

            

            bool isError = false;
            _pWorkResultRegister_T03Entity.CRUD = "C";

            if (_ckUSA_LOT.Checked)
            {
                _pWorkResultRegister_T03Entity.USA_LOT_CHECK = "Y";
            }else
            {
                _pWorkResultRegister_T03Entity.USA_LOT_CHECK = "N";
            }
            try
            {
                rowhandle = _gdMAIN_LOT_VIEW.GetFocusedDataSourceRowIndex();
                isError = new WorkResultRegister_T03Business().WorkResultRegister_Mst_Lot_save(_pWorkResultRegister_T03Entity);

                if (!isError)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    _gdMAIN_LOT_VIEW.FocusedRowHandle = rowhandle;
                    _gdSUB1.DataSource = "";
                    _gdSUB2.DataSource = "";
                    _gdSUB3.DataSource = "";
                    SubFind_DisplayData(_pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID);
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
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
    }
}
