using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
using CoFAS_MES.UI.MM.Business;
using CoFAS_MES.UI.MM.Data;
using CoFAS_MES.UI.MM.Entity;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Spreadsheet;
using System.IO;
using static CoFAS_MES.CORE.BaseControls.ucSpreadSheetControl;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraEditors;

namespace CoFAS_MES.UI.MM
{
    public partial class MaterialOrderRegister_Request_T01 : frmBaseNone
    {
        #region ○ 변수선언

        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭
        private string _pUSER_GRANT = string.Empty; // 사용자 권한
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

        private DataTable _dtList = null; //조회 메인 데이터 리스트
        private DataTable _dtList2 = null; //조회 서브 데이터 리스트
        private MaterialOrderRegisterEntity_Request_T01 _pMaterialOrderRegister_Request_T01Entity = null; // 엔티티 생성


        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장

        #endregion

        #region ○ 생성자

        public MaterialOrderRegister_Request_T01()
        {
            InitializeComponent();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        #endregion

        #region ● 폼 이벤트 처리 영역

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

                throw pExceptionManager;

            }
        }
        #endregion

        #region ○ Form_Closing

        private void Form_Closing(object pSender, FormClosingEventArgs pFormClosingEventArgs)
        {
            try
            {
                //그리드 작업 정보 확인 하기
                if (_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_EXIT_QUESTION) == DialogResult.No)
                    {
                        pFormClosingEventArgs.Cancel = true;
                        return;
                    }
                }
                else
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업 종료 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                    {
                        pFormClosingEventArgs.Cancel = true;
                        return;
                    }
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

                throw pExceptionManager;

            }
            catch (Exception pException)
            {
                //throw new ExceptionManager(this, "InputData_Save(DataTable dtSave)", pException);
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
                _gdMAIN_VIEW.InitNewRow -= _gdMAIN_VIEW_InitNewRow;

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

                throw pExceptionManager;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InputData_Save(DataTable dtSave)", pException);
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
                DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
                PrintButtonClicked += new EventHandler(Form_PrintButtonClicked);
                ExportButtonClicked += new EventHandler(Form_ExportButtonClicked);
                ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                SettingButtonClicked += new EventHandler(Form_SettingButtonClicked);
                AddItemButtonClicked += new EventHandler(Form_AddItemButtonClicked);
                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);

                //Form_SearchButtonClicked(null, null);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

                throw pExceptionManager;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InputData_Save(DataTable dtSave)", pException);
            }

        }
        #endregion

        #endregion

        #region ● 초기화영역

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
                //_pnContent.Width = 200;

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
                _pMaterialOrderRegister_Request_T01Entity = new MaterialOrderRegisterEntity_Request_T01();
                //_pMaterialOrderRegister_RequestEntity.CORP_CODE = _pCORP_CODE;
                _pMaterialOrderRegister_Request_T01Entity.USER_CODE = _pUSER_CODE;
                _pMaterialOrderRegister_Request_T01Entity.USER_NAME = _pUSER_NAME;
                _pMaterialOrderRegister_Request_T01Entity.WINDOW_NAME = _pWINDOW_NAME;
                _pMaterialOrderRegister_Request_T01Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;


                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //메인 화면 공용 버튼 설정
                //if (_pFirstYN)
                //{
                //    InitializeButtons();
                //}

                //그리드 설정
                InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                //if (_pFirstYN)
                //{

                //}

                if (_pFirstYN)
                {

                    _pFirstYN = false;
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    _gdMAIN_VIEW.InitNewRow += _gdMAIN_VIEW_InitNewRow;
                    MainFind_DisplayData();
                    SubFind_DisplayData_init();
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
                pButtonSetting.UseYNDeleteButton = _pMenuSettingEntity.MENU_DELETE == "Y" ? true : false; // 삭제
                pButtonSetting.UseYNAddItemButton = _pMenuSettingEntity.MENU_ADDITEM == "Y" ? true : false; // 신규추가
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
                    CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;
                    _gdSUB_VIEW.CellValueChanged += _gdSUB_VIEW_CellValueChanged;

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
                _luTORDER_DATE.FromDateTime = Convert.ToDateTime("2000-01-01"); //new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luTORDER_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                _luTVEND_CODE.CodeText = "";
                _luTVEND_CODE.NameText = "";
                _luORDER_DATE.DateTime = Convert.ToDateTime("2000-01-01");
                //_luTORDER_ID.Text = "";
                //_luTVEND_PART_CODE.Text = "";

                _luTUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "", true);
                _luTUSE_YN.ItemIndex = 1;
                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "", false);
                _luUSE_YN.ItemIndex = 0;
                //데이터 영역

                _luORDER_ID.Text = "";
                _luORDER_SEQ.Text = "";
                _luORDER_DATE.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                _luVEND_CODE.CodeText = "";
                _luVEND_CODE.NameText = "";
                _luREMARK.Text = "";
                _gdSUB.DataSource = null;
                _gdMAIN.DataSource = null;
                _luORDER_DATE.ReadOnly = false;
                _pMaterialOrderRegister_Request_T01Entity.ORDER_ID = "";

                _luPLACE_DELIVERY.Text = "진영정기 지정 장소";
                _luTRANS_CONDITION.Text = "공급업체 납품";
                _luTERMS_PAYMENT.Text = "진영정기의 협력업체 지불조건";
                _luTAX_CLASSIFICATION.Text = "VAT 별도";
                _luCONTENTS.Text = "공급업체로 아래의 발주 목록을 발주하오니 납기일을 준수하여 지정된 납품장소에 납품하여 주세요." + "\n" +
                                    "단가 및 금액이 표기 되지 않은 품목은 견적서를 보내주세요." + "\n" +
                                    "기타 문의 사항이 있으면 발주 담당자에게 연락 바랍니다.";


                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //dxValidationProvider.SetValidationRule(_luORDER_QTY, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _gdMAIN.DataSource = null;
                }

                //MainFind_DisplayData();

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


        #endregion


        #region 메인그리드 로우 선택
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                _luORDER_DATE.ReadOnly = true;
                _luVEND_CODE.CodeText = gv.GetFocusedRowCellValue("VEND_CODE").ToString();
                _luVEND_CODE.NameText = gv.GetFocusedRowCellValue("VEND_NAME").ToString();
                _pMaterialOrderRegister_Request_T01Entity.ORDER_ID = gv.GetFocusedRowCellValue("ORDER_ID").ToString();
                CoFAS_ControlManager.Controls_Binding(gv, false, this);
                SubFind_DisplayData();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ● 메인 버튼 처리영역

        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_RESET_QUESTION) == DialogResult.No)
                    {
                        MainFind_DisplayData();
                        DisplayMessage(_pMSG_SEARCH);
                    }

                }
                else
                {
                    MainFind_DisplayData();
                    DisplayMessage(_pMSG_SEARCH);
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

        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                InputData_Save(_pMaterialOrderRegister_Request_T01Entity);
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

        #region ○ 신규 버튼 클릭시 처리하기
        private void Form_AddItemButtonClicked(object pSender, EventArgs pEventArgs)
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

                    if (!xfrmCommonPopup.dtReturn.Columns.Contains("ORDER_QTY"))
                    {
                        xfrmCommonPopup.dtReturn.Columns.Add(new DataColumn("ORDER_QTY", typeof(string)));
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
                        xfrmCommonPopup.dtReturn.Rows[i]["ORDER_QTY"] = 0;
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
            catch (Exception ex)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}", ex.ToString()));
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

                ////확인
                //if (_luORDER_ID.Text.ToString() != "")
                //{
                //    _pMaterialOrderRegister_RequestEntity.CRUD = "D";
                //}
                //else
                //{
                //    MessageBox.Show(_pMSG_CHECK_VALID_ITEM);
                //    return;
                //}

                //if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_DELETE_QUESTION + " : " + _luORDER_ID.Text) == DialogResult.No)
                //{
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

        #region ○ 인쇄 버튼 클릭시 처리하기
        private void Form_PrintButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                if (_pMaterialOrderRegister_Request_T01Entity.ORDER_ID == "") return;

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                string strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pWINDOW_NAME);
                //string strFTP_PATH = string.Format()
                string strFILE_NAME = "MaterialOrderRegister_Request_T01_Report.xlsx";

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
                MM.UserForm.frmCommonPopup.ARRAY_CODE = new object[5] { _pWINDOW_NAME, _pMaterialOrderRegister_Request_T01Entity.ORDER_ID, "Y", 30, 0 };
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
                //xfrmPageSetting.PASS_CORP_CODE = _pMaterialOrderRegister_RequestEntity.CORP_CODE;
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

        #endregion

        #region ○ 메인 그리드 신규로우 생성시 이벤트 생성 - _gdMAIN_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdMAIN_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
        }
        #endregion


        #region ● DB 처리

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pMaterialOrderRegister_Request_T01Entity.CRUD = "R";
                _pMaterialOrderRegister_Request_T01Entity.DATE_FROM = DateTime.Parse(_luTORDER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");
                _pMaterialOrderRegister_Request_T01Entity.DATE_TO = DateTime.Parse(_luTORDER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");
                _pMaterialOrderRegister_Request_T01Entity.VEND_CODE = _luTVEND_CODE.CodeText.ToString();
                _pMaterialOrderRegister_Request_T01Entity.USE_YN = _luTUSE_YN.GetValue();

                using (DBManager pDBManager = new DBManager())
                {

                    _dtList = new MaterialOrderRegister_Request_T01Business().MaterialOrderRegister_Request_T01_R10(_pMaterialOrderRegister_Request_T01Entity);

                    if (_pMaterialOrderRegister_Request_T01Entity.CRUD == "")
                        _dtList.Rows.Clear();

                    if (_dtList != null && _dtList.Rows.Count > 0)
                    {
                        CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                    }
                    else
                    {

                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                        _dtList.Rows.Clear();
                        CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
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

        #region ○ 서브조회 - SubFind_DisplayData()
        private void SubFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pMaterialOrderRegister_Request_T01Entity.CRUD = "R";

                using (DBManager pDBManager = new DBManager())
                {

                    _dtList2 = new MaterialOrderRegister_Request_T01Business().MaterialOrderRegister_Request_T01_R20(_pMaterialOrderRegister_Request_T01Entity);

                    if (_pMaterialOrderRegister_Request_T01Entity.CRUD == "")
                        _dtList2.Rows.Clear();

                    if (_dtList2 != null && _dtList2.Rows.Count > 0)
                    {
                        CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList2); //데이터 필드에 맞춰 자동 바인딩
                    }
                    else
                    {

                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                        _dtList2.Rows.Clear();
                        CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList2); //데이터 필드에 맞춰 자동 바인딩
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

        #region ○ 서브조회(초기화) - SubFind_DisplayData()
        private void SubFind_DisplayData_init()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pMaterialOrderRegister_Request_T01Entity.CRUD = "";

                using (DBManager pDBManager = new DBManager())
                {

                    _dtList2 = new MaterialOrderRegister_Request_T01Business().MaterialOrderRegister_Request_T01_R20(_pMaterialOrderRegister_Request_T01Entity);

                    if (_pMaterialOrderRegister_Request_T01Entity.CRUD == "")
                        _dtList2.Rows.Clear();

                    if (_dtList2 != null && _dtList2.Rows.Count > 0)
                    {
                        CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList2); //데이터 필드에 맞춰 자동 바인딩
                    }
                    else
                    {

                        _dtList2.Rows.Clear();
                        CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList2); //데이터 필드에 맞춰 자동 바인딩
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

        #region ○ 저장 - InputData_Save(DataTable dtSave)

        private void InputData_Save(MaterialOrderRegisterEntity_Request_T01 _pMaterialOrderRegister_Request_T01Entity)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                bool isError = false;

                DataTable dt = null;
                DataTable dtTemp = null;

                using (DBManager pDBManager = new DBManager())
                {
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                    {
                        dt = _gdSUB.DataSource as DataTable;

                        if (_luORDER_ID.Text.ToString().Equals(""))
                        {
                            _pMaterialOrderRegister_Request_T01Entity.CRUD = "C";
                        }
                        else
                        {
                            _pMaterialOrderRegister_Request_T01Entity.CRUD = "U";
                        }

                        _pMaterialOrderRegister_Request_T01Entity.ORDER_ID = _luORDER_ID.Text.ToString();
                        _pMaterialOrderRegister_Request_T01Entity.ORDER_SEQ = _luORDER_SEQ.Text.ToString();
                        _pMaterialOrderRegister_Request_T01Entity.ORDER_DATE = _luORDER_DATE.DateTime.ToString("yyyyMMdd");
                        _pMaterialOrderRegister_Request_T01Entity.USE_YN = _luUSE_YN.GetValue().ToString();
                        _pMaterialOrderRegister_Request_T01Entity.VEND_CODE = _luVEND_CODE.CodeText.ToString();
                        _pMaterialOrderRegister_Request_T01Entity.REMARK = _luREMARK.Text.ToString();

                        _pMaterialOrderRegister_Request_T01Entity.PLACE_DELIVERY = _luPLACE_DELIVERY.Text.ToString();
                        _pMaterialOrderRegister_Request_T01Entity.TRANS_CONDITION = _luTRANS_CONDITION.Text.ToString();
                        _pMaterialOrderRegister_Request_T01Entity.TERMS_PAYMENT = _luTERMS_PAYMENT.Text.ToString();
                        _pMaterialOrderRegister_Request_T01Entity.TAX_CLASSIFICATON = _luTAX_CLASSIFICATION.Text.ToString();
                        _pMaterialOrderRegister_Request_T01Entity.CONTENTS = _luCONTENTS.Text.ToString();


                        if (CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", ""))
                        {
                            dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", "");

                            for (int i = 0; i < dtTemp.Rows.Count; i++)
                            {
                                if (dtTemp.Rows[i]["ORDER_QTY"].ToString().Equals(""))
                                {
                                    CoFAS_DevExpressManager.ShowInformationMessage("발주수량을 공란으로 설정할 수 없습니다.");
                                    return;
                                }
                                if (Convert.ToDecimal(dtTemp.Rows[i]["ORDER_QTY"].ToString()) <= 0)
                                {
                                    CoFAS_DevExpressManager.ShowInformationMessage("발주수량을 0으로 설정할 수 없습니다.");
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

                        isError = new MaterialOrderRegister_Request_T01Business().MaterialOrderRegisterEntity_Request_T01_Save(_pMaterialOrderRegister_Request_T01Entity, dtTemp);

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
                            //_pLocation_Code = _pMaterialOrderRegister_Request_T01Entity.RTN_KEY;  //저장 위치 
                            MainFind_DisplayData();
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

        #endregion

        #region 팝업

        #region 거래처선택(조회)
        private void _luTVEND_CODE__OnOpenClick(object sender, EventArgs e)
        {
            //VendCostInfo
            frmCommonPopup.CRUD = "R";
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;



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

        #region 거래처선택(입력)
        private void _luVEND_CODE__OnOpenClick(object sender, EventArgs e)
        {
            //VendCostInfo
            frmCommonPopup.CRUD = "R";
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;



            // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            frmCommonPopup.ARRAY = new object[2] { "Vend_Code_I", "" };

            //검색조건 전달 0 코드 1 명칭
            frmCommonPopup.ARRAY_CODE = new object[2] { _luVEND_CODE.CodeText.ToString(), _luVEND_CODE.NameText.ToString() };

            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luVEND_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luVEND_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

                //데이터 세팅
            }

            xfrmCommonPopup.Dispose();
        }
        #endregion


        #endregion

        #region ○ 수량 / 단가 계산
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

            if (g.GetRowCellDisplayText(selectedRowNum, "ORDER_QTY").Equals("")) return;

            decimal order_qty = Convert.ToDecimal(g.GetRowCellDisplayText(selectedRowNum, "ORDER_QTY") == "" ? "0" : g.GetRowCellDisplayText(selectedRowNum, "ORDER_QTY"));
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
            string _sFRev = string.Empty;
            string _sFVCode = string.Empty;

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
                case "BTN_ORDERMAT": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.
                    _sFCode = g.GetFocusedRowCellValue("PART_CODE").ToString();
                    _sFName = g.GetFocusedRowCellValue("PART_NAME").ToString();
                    _sFVendCode = g.GetFocusedRowCellValue("VEND_PART_CODE").ToString();


                    UserForm.frmCommonPopup.CRUD = "R";
                    UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                    UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                    UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" };
                    UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _sFCode, _sFName };
                    UserForm.frmCommonPopup xfrmCommonPopup = new UserForm.frmCommonPopup("ucMaterialPartListPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                    xfrmCommonPopup.ShowDialog();

                    if (xfrmCommonPopup.dtReturn == null)
                    {
                        xfrmCommonPopup.Dispose();
                        return;
                    }

                    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                    {
                        //_luTPART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();
                        //_luTPART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();

                        _sResultVendPartCode = xfrmCommonPopup.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();
                        _sResultName = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                        _sResultCode = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                        //_luPART_CODE.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                    }

                    if (!_sResultCode.Equals("") && !_sResultName.Equals(""))
                    {
                        g.SetFocusedRowCellValue("PART_CODE", _sResultCode);
                        g.SetFocusedRowCellValue("PART_NAME", _sResultName);
                        g.SetFocusedRowCellValue("VEND_PART_CODE", _sResultVendPartCode);
                    }

                    xfrmCommonPopup.Dispose();

                    break;
                case "BTN_ORDERVEND":
                    _sFCode = g.GetFocusedRowCellValue("VEND_CODE").ToString();
                    _sFName = g.GetFocusedRowCellValue("VEND_NAME").ToString();

                    frmCommonPopup.CRUD = "R";
                    frmCommonPopup.USER_CODE = _pUSER_CODE;
                    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    frmCommonPopup.ARRAY = new object[2] { "vend_code", "" };
                    frmCommonPopup.ARRAY_CODE = new object[2] { _sFCode, _sFName };
                    frmCommonPopup xfrmCommonPopup2 = new frmCommonPopup("CommonCode");

                    xfrmCommonPopup2.ShowDialog();

                    if (xfrmCommonPopup2.dtReturn == null)
                    {
                        xfrmCommonPopup2.Dispose();
                        return;
                    }
                    if (xfrmCommonPopup2.dtReturn.Rows.Count > 0)
                    {
                        _sResultCode = xfrmCommonPopup2.dtReturn.Rows[0]["CD"].ToString();
                        _sResultName = xfrmCommonPopup2.dtReturn.Rows[0]["CD_NM"].ToString();
                    }

                    xfrmCommonPopup2.Dispose();

                    if (!_sResultCode.Equals("") && !_sResultName.Equals(""))
                    {
                        g.SetFocusedRowCellValue("VEND_CODE", _sResultCode);
                        g.SetFocusedRowCellValue("VEND_NAME", _sResultName);
                    }
                    break;

                case "BTN_ORDER_DOCUMENT": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.
                    if (g.GetFocusedRowCellValue("PART_CODE").ToString() == "") return;
                    _sFCode = g.GetFocusedRowCellValue("PART_CODE").ToString();
                    _sFName = g.GetFocusedRowCellValue("PART_NAME").ToString();
                    _sFRev = g.GetFocusedRowCellValue("PART_REVISION_NO").ToString();
                    _sFVCode = g.GetFocusedRowCellValue("VEND_PART_CODE").ToString();

                    UserForm.frmCommonPopup.CORP_CDDE = _pCORP_CODE;
                    UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                    UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
                    UserForm.frmCommonPopup.FTP_PATH = _pFTP_PATH;
                    UserForm.frmCommonPopup.FTP_ID = _pFTP_ID;
                    UserForm.frmCommonPopup.FTP_PW = _pFTP_PW;

                    UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정
                    UserForm.frmCommonPopup.ARRAY_CODE = new object[6] { _sFCode, _sFName, _sFRev, _sFVCode, "", "" }; //넘기는 파라메터 에 따라 설정

                    UserForm.frmCommonPopup xfrmcommonPopup2 = new UserForm.frmCommonPopup("ucMaterialPartDocumentListPopup"); //유저컨트롤러 설정 부분

                    xfrmcommonPopup2.ShowDialog();

                    xfrmcommonPopup2.Dispose();


                    break;

            }
        }
        #endregion


    }


}
