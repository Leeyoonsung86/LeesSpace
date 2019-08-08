using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.UserForm;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.UI.PM.Business;
using CoFAS_MES.UI.PM.Entity;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.DashboardCommon;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using DevExpress.SpreadsheetSource;
using static CoFAS_MES.CORE.BaseControls.ucSpreadSheetControl;
using DevExpress.DataAccess.ConnectionParameters;

using System.IO;


namespace CoFAS_MES.UI.PM
{
    public partial class ProductInOutStatus_T50 : frmBaseNone
    {

        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
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
        private string _pMSG_NO_SELECT_FILEFORM = string.Empty; // 등록된 현황형식이 없습니다.

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

        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보

        private ProductInOutStatus_T50Entity _pProductInOutStatus_T50Entity = null; // 엔티티 생성

        
        private DataSet _dsList = null; //조회 데이터 리스트 데이터셋
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtList_01 = null; //조회 데이터 리스트
        private DataTable _dtList_02 = null; //조회 데이터 리스트
        private DataTable _dtList_03 = null; //조회 데이터 리스트
        private DataTable _dtList_04 = null; //조회 데이터 리스트
        private object _obList = null;

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        IWorkbook workbook = null;                       //워크시트 전역변수

        public ProductInOutStatus_T50()
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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
                _pnLeft.Width = 250;

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
                _pMSG_NO_SELECT_FILEFORM = MainForm.MessageEntity.MSG_NO_SELECT_FILEFORM;
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

                //메뉴 화면 엔티티 설정
                _pProductInOutStatus_T50Entity = new ProductInOutStatus_T50Entity();
                _pProductInOutStatus_T50Entity.CORP_CODE = _pCORP_CODE;
                _pProductInOutStatus_T50Entity.USER_CODE = _pUSER_CODE;
                _pProductInOutStatus_T50Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

                //엑셀샘플불러오기 변수
                _pProductInOutStatus_T50Entity.WINDOW_NAME = _pWINDOW_NAME;
                _pProductInOutStatus_T50Entity.CORP_CODE = "";
                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_IP_PORT = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PATH = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PW = MainForm.UserEntity.FTP_PW;

                //컨트롤 초기화
                _luPART.CodeText = "";
                _luPART.NameText = "";
                //_luVEND.CodeText = "";
                //_luVEND.NameText = "";

                //날짜초기화
                //_luINOUT_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luINOUT_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luINOUT_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                
                //_luINOUT_ID.Text = "";

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

                //SpreadSheet 초기화 _sdMAIN
                // _sdMAIN.ClearSheet();

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pProductInOutStatus_T50Entity.CRUD = "";
                if (_pFirstYN)
                {

                    // MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
                   // SheetFind_DisplayData();  // DB에 저장된 해당 화면의 엑셀파일 불러오기
                   // Sheet_Info_Sheet_Data();  // 데이터 바인딩
                    _pFirstYN = false;
                }

                //SubFind_DisplayData("", ""); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                //_gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                //그리드 버튼추가 시 클릭 이벤트 처리 
                // CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;
                // MainFind_DisplayData();


                //CoFAS_ControlManager.SetFontInControls(this.Controls, new Font("Arial", 8, FontStyle.Bold));
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }
        private void DashboardViewer_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e)
        {
            try
            {
                switch (DBManager.PrimaryDBManagerType)
                {
                    case DBManagerType.MySql:
                        e.ConnectionParameters = new MySqlConnectionParameters(DBManager.InitDatabaseServer, DBManager.InitDatabaseName, DBManager.InitDatabaseID, DBManager.InitDatabasePass, 3306);
                        break;
                    case DBManagerType.SQLServer:
                        e.ConnectionParameters = new MsSqlConnectionParameters();
                        break;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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
                     //_gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                }

                //_gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pCORP_CDDE, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pCORP_CDDE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }


        #endregion

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl()
        {
            try
            {
                //조회조건 영역 
                //_luT_WINDOW_NAME.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "MENU_LIST", "", "", "").Tables[0], 0, 0, "");
                //_luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                //_luINOUT_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "INOUT_TYPE", "PD00", "", "").Tables[0], 0, 0, "", true);

                //_luINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "INOUT_CODE", "", "", "").Tables[0], 0, 0, "", true);

                //_luINOUT_TYPE.ValueChanged += _luINOUT_TYPE_ValueChanged;

                //데이터 영역
                //_luWINDOW_NAME.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "MENU_LIST", "", "", "").Tables[0], 0, -1, "");
                //_luWINDOW_NAME.ReadOnly = false;

                //_luGRID_NAME.Text = "";
                //_luGRID_NAME.ReadOnly = false;

                //_luGRIDVIEW_NAME.Text = "";
                //_luGRIDVIEW_NAME.ReadOnly = false;

                //_luEDIT_ABLE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                //_luEDITOR_SHOWMODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "COMMON_CODE", "MM20", "", "").Tables[0], 0, 0, "");

                //_luVEND.NameText = "";
                //_luVEND.CodeText = "";
                _luPART.NameText = "";
                _luPART.CodeText = "";
                //_luINOUT_ID.Text = "";
                //_luTREFERENCE_ID.Text = "";

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //dxValidationProvider.SetValidationRule(_luGRID_NAME, NotEmptyValidationRule);
                //dxValidationProvider.SetValidationRule(_luGRIDVIEW_NAME, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                     //_gdMAIN.DataSource = null;
                }

                _pProductInOutStatus_T50Entity.CRUD = "";
                Dashboard_DisplayData();

                //_gdSUB.DataSource = null;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {

            }
        }

        //#region ○INOU_TYPE이 변하면 INOUT_CODE같이 변하게
        //private void _luINOUT_TYPE_ValueChanged(object sender, EventArgs e)
        //{
        //    switch (_luINOUT_TYPE.GetValue())
        //    {
                
        //        case ""://전체
                    
        //            _luINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "INOUT_CODE", "", "", "").Tables[0], 0, 0, "", true);
        //            break;
        //        case "PD01"://입고
        //            _luINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "INOUT_CODE", "PD01", "", "").Tables[0], 0, 0, "", true);
        //            break;
        //        case "PD02"://출고
        //            _luINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "INOUT_CODE", "PD02", "", "").Tables[0], 0, 0, "", true);
        //            break;
        //        default:
        //            break;
        //    }
        //}
        //#endregion


#endregion

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this); //

                string strWINDOW_NAME = gv.GetFocusedRowCellValue("WINDOW_NAME").ToString();
                string strGRID_NAME = gv.GetFocusedRowCellValue("GRID_NAME").ToString();

                _pProductInOutStatus_T50Entity.CRUD = "R";
                //SubFind_DisplayData(strWINDOW_NAME, strGRID_NAME);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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

        #region ○ 팝업이벤트
        //private void _luVEND__OnOpenClick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        frmCommonPopup.USER_CODE = _pUSER_CODE;
        //        frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
        //        frmCommonPopup.FONT_TYPE = _pFONT_SETTING;


        //        // ( Vend_In_Code 매입, 공통, Vend_Out_Code 매출 공통 ) 코드  
        //        frmCommonPopup.ARRAY = new object[2] { "Vend_InOut_Code", "" }; //넘기는 파라메터 에 따라 설정 

        //        frmCommonPopup xfrmcommonPopup = new CORE.UserForm.frmCommonPopup("VendCodeInfo"); //유저컨트롤러 설정 부분

        //        xfrmcommonPopup.ShowDialog();

        //        if (xfrmcommonPopup.dtReturn == null)
        //        {
        //            xfrmcommonPopup.Dispose();
        //            return;
        //        }

        //        if (xfrmcommonPopup.dtReturn != null && xfrmcommonPopup.dtReturn.Rows.Count > 0)
        //        {
        //            _luVEND.CodeText = xfrmcommonPopup.dtReturn.Rows[0]["VEND_CODE"].ToString();        // 거래처코드 : 거래처명
        //            _luVEND.NameText = xfrmcommonPopup.dtReturn.Rows[0]["VEND_NAME"].ToString();
        //        }

        //        xfrmcommonPopup.Dispose();
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
        //    }
        //}

        private void _luPART__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                frmCommonPopup.ARRAY = new object[2] { "Product_Code", _luPART.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                frmCommonPopup.ARRAY_CODE = new object[2] { _luPART.CodeText, _luPART.NameText };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("PartCodeInfo"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luPART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                    _luPART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
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


                _pProductInOutStatus_T50Entity.CRUD = "R";

                MainFind_DisplayData();
                //Dashboard_DisplayData();
                //DisplayMessage("조회 되었습니다.");
                DisplayMessage(_pMSG_SEARCH);
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
        #region ○ Dashboard 조회 - Dashboard_DisplayData()

        private void Dashboard_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                string strFTP_PATH = "";
                string sfilename = "";

                _dtList = new ProductInOutStatus_T50Business().ProductInOutStatus_T50_Info_Filename(_pProductInOutStatus_T50Entity); //Entity에 WINDOW_NAME 추가

                if (_dtList == null)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    return;
                }

                if (_dtList.Rows.Count == 0)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NO_SELECT_FILEFORM);
                    return;
                }


                for (int i = 0; i < _dtList.Rows.Count; i++)
                {
                    string menu_no = _dtList.Rows[i]["MENU_NO"].ToString();
                    string dsp_sort = _dtList.Rows[i]["DSP_SORT"].ToString();
                    string curfile = Application.StartupPath + "\\Template\\" + _dtList.Rows[i][2].ToString();

                    sfilename = _dtList.Rows[i][2].ToString();
                }

                strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_IP_PORT, "USER", "PROGRAM_VIEW", _pProductInOutStatus_T50Entity.WINDOW_NAME);
                //CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, (saveFile.FileName.ToString().Split('\\')).Last(), _pFTP_ID, _pFTP_PW, strLOCAL_PATH);


                Dashboard dashboard = new Dashboard();

                //FTP의 엑셀 파일 control에 바인딩
                using (Stream responseStream = CoFAS_FTPManager.FTPFileBinding(strFTP_PATH, sfilename, _pFTP_ID, _pFTP_PW))
                {
                    if (responseStream != null)
                    {
                        dashboard.LoadFromXml(responseStream); //xml 파일 로드
                    }
                }

                dashboard.ConfigureDataConnection += DashboardViewer_ConfigureDataConnection;
                //dashboard.LoadFromXml(curfile); //xml 파일 로드

                // xml의 parameter 설정
               // dashboard.Parameters[0].Value = _pProductInOutStatus_T50Entity.CRUD; ;// "R";
                                                                               //dashboard.Parameters[1].Value =_luINOUT_DATE.FromDateTime.ToString().Substring(0, 10).Replace("-", "");
                                                                               //dashboard.Parameters[2].Value =_luINOUT_DATE.ToDateTime.ToString().Substring(0, 10).Replace("-", "");

                dashboard.Parameters[0].Value = DateTime.Parse(_luINOUT_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");//_luT_ORDER_DATE.FromDateTime.ToString().Substring(0, 10).Replace("-", "");
                dashboard.Parameters[1].Value = DateTime.Parse(_luINOUT_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");//_luT_ORDER_DATE.ToDateTime.ToString().Substring(0, 10).Replace("-", "");

                dashboard.Parameters[2].Value = _luPART.CodeText;
                dashboard.Parameters[3].Value = _luPART.NameText;
            //    dashboard.Parameters[4].Value = _pProductInOutStatus_T50Entity.LANGUAGE_TYPE;//production_order_id

                //dashboardViewer
                // Title 설정
                dashboard.Title.Visible = false;

                dashboardViewer.Dashboard = dashboard;

                dashboardViewer.Refresh();

                //DisplayMessage("조회 되었습니다.");
                DisplayMessage(_pMSG_SEARCH);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {
                // _gdSUB_VIEW.BestFitColumns();

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

                //확인
                //if (_luGRID_NAME.ReadOnly)
                //{
                //    _pSampleRegisterEntity.CRUD = "U";
                //}
                //else
                //{
                //    _pSampleRegisterEntity.CRUD = "C";
                //}

                //InputData_Save(_gdSUB_VIEW.GridControl.DataSource as DataTable);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));

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
                //확인
                //if (_gdSUB_VIEW.GetFocusedRowCellValue(_gdSUB_VIEW.Columns["CRUD"]).ToString() == "C")
                //{
                //    // 신규 데이터는 로우 삭제
                //    _gdSUB_VIEW.DeleteRow(_gdSUB_VIEW.FocusedRowHandle);
                //}
                //else
                //{
                //    // 수정 데이터는 "CRUD" 처리
                //    _gdSUB_VIEW.SetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["CRUD"], "D");
                //}

                // 수정 후 포커스 이동 안되면 데이터 반영 안됨. 
                // 삭제 버튼 클릭시에는 GetFocusedDataRow().EndEdit() 처리 해야됨.
                // 마우스 팝업 메뉴에서 처리는 자동으로 처리됨.
                //_gdSUB_VIEW.GetFocusedDataRow().EndEdit();

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

        #region ○ 인쇄 버튼 클릭시 처리하기
        private void Form_PrintButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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

                //컨트롤 초기화
                // _luPART.CodeText = "";
                // _luPART.NameText = "";
                // _luVEND.CodeText = "";
                // _luVEND.NameText = "";
                // _luTINOUT_ID.Text = "";
                //
                // //날짜초기화
                 _luINOUT_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                 _luINOUT_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                //
                // _pProductInStatusEntity.CRUD = "";
                // Dashboard_DisplayData();
                // DisplayMessage("조회 되었습니다.");
                _pFirstYN = true;
                InitializeControl();
                


                //DisplayMessage("초기화했습니다.");
                DisplayMessage(_pMSG_RESET_COMPLETE);
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
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
                /*

                _pProductInOutStatus_T50Entity.CRUD = "R";
                _pProductInOutStatus_T50Entity.DATE_FROM = Convert.ToString(_luINOUT_DATE.FromDateTime).Substring(0, 10).Replace("-", "");
                _pProductInOutStatus_T50Entity.DATE_TO = Convert.ToString(_luINOUT_DATE.ToDateTime).Substring(0, 10).Replace("-", "");
                //_pProductInOutStatus_T50Entity.VEND_CODE = _luVEND.CodeText;
                // _pProductInOutStatus_T50Entity.PART_NAME =
                _pProductInOutStatus_T50Entity.PART_CODE = _luPART.CodeText;
                //_pProductInOutStatus_T50Entity.INOUT_TYPE = _luINOUT_TYPE.GetValue();
                //_pProductInOutStatus_T50Entity.INOUT_ID = _luINOUT_ID.Text;
                _pProductInOutStatus_T50Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

                _dtList = new ProductInOutStatus_T50Business().ProductInOut_Info(_pProductInOutStatus_T50Entity);

                if (_pProductInOutStatus_T50Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductInOutStatus_T50Entity.CRUD == ""))
                {
                     CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _pFirstYN = true;
                    InitializeControl();
                }
                
                //Dashboard_DisplayData();
                //DisplayMessage("조회 되었습니다.");
                DisplayMessage(_pMSG_SEARCH);

                */

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {
                //_gdMAIN_VIEW.BestFitColumns();

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

        //        _dtList = new ProductInStatusBusiness().Sample_Info_Sub(_pProductInStatusEntity);

        //        if (_pProductInOutStatus_T50Entity.CRUD == "") _dtList.Rows.Clear();

        //        if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductInOutStatus_T50Entity.CRUD == ""))
        //        {
        //            // CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
        //        }
        //        else
        //        {
        //            //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
        //            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
        //    }
        //    finally
        //    {
        //        // _gdSUB_VIEW.BestFitColumns();

        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
        //    }
        //}

        #endregion

        #region ○ 저장 - InputData_Save(DataTable dtSave)  사용 X

        //private void InputData_Save(DataTable dtSave)
        //{
        //    try
        //    {
        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

        //        bool isError = false;


        //        isError = new ProductInStatusBusiness().Sample_Info_Save(_pProductInStatusEntity, dtSave);

        //        if (isError)
        //        {
        //            //오류 발생.
        //            //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
        //            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
        //            //화면 표시.

        //        }
        //        else
        //        {
        //            //정상 처리
        //            //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
        //            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

        //            // 화면 갱신
        //            _pProductInOutStatus_T50Entity.CRUD = "R";

        //            MainFind_DisplayData();

        //            // SubFind_DisplayData(_pSampleRegisterEntity.WINDOW_NAME, _pSampleRegisterEntity.GRID_NAME);
        //        }

        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
        //    }
        //    finally
        //    {

        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
        //    }
        //}

        #endregion

        #region ○ 시트조회 - SheetFind_DisplayData()

        //private void SheetFind_DisplayData()
        //{
        //    try
        //    {
        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

        //        string strFTP_PATH = "";
        //        string strUSE_TYPE = "";
        //        string strFILE_NAME = "";


        //        _dtList = new ProductInStatusBusiness().Sheet_Info_Sheet(_pProductInStatusEntity);   //엑셀 시트 조회하기

        //        strUSE_TYPE = _dtList.Rows[0][1].ToString();
        //        strFILE_NAME = _dtList.Rows[0][0].ToString();

        //        switch (strUSE_TYPE)
        //        {
        //            case "PRINT":
        //                strFTP_PATH = string.Format(@"{0}{1}/", _pFTP_PATH, "ORDER_FORM");
        //                break;
        //            case "VIEW":
        //                strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "PROGRAM_VIEW", _pWINDOW_NAME);
        //                break;
        //        }

        //        if (_dtList != null)
        //        {
        //            using (Stream responseStream = CoFAS_FTPManager.FTPFileBinding(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW))
        //            {
        //               // if (responseStream != null)
        //               // {
        //               //     _sdMAIN.LoadDocument(responseStream, enFileFormat.Xlsx);
        //               //     //_sdMAIN.LoadDocument((byte[])_ojList, DocumentFormat.Xlsx);    // 일반 컨트롤 일때 : DocumentFormat.Xls   // UC일때,  enFileFormat.Xls
        //               // }
        //               // else
        //               // {
        //               //     _sdMAIN.ClearSheet();
        //               // }
        //            }
        //        }
        //        else
        //        {
        //            //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
        //            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
        //        }






        //        //_ojList = new ProcessMaterialStockStatusBusiness().Sheet_Info_Sheet(_pProcessMaterialStockStatusEntity);

        //        //if (_ojList != null)
        //        //{
        //        //    _sdMAIN.LoadDocument((byte[])_ojList, DocumentFormat.Xlsx);    // 일반 컨트롤 일때 : DocumentFormat.Xls   // UC일때,  enFileFormat.Xls
        //        //}
        //        //else
        //        //{
        //        //    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
        //        //}
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
        //    }
        //    finally
        //    {
        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
        //    }
        //}
        #endregion

        #region ○ new 시트에 서브그리드에서 선택한 프로시저 정보 바인딩 - SubFind_DisplayData(string strWINDOW_NAME, string strFILE_NAME)

        //private void Sheet_Info_Sheet_Data()
        //{
        //    try
        //    {
        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

        //        _pProductInOutStatus_T50Entity.CRUD = "R";// pCRUD;
        //        _pProductInOutStatus_T50Entity.DATE_FROM = Convert.ToString(_luINOUT_DATE.FromDateTime).Substring(0, 10).Replace("-", "");
        //        _pProductInOutStatus_T50Entity.DATE_TO = Convert.ToString(_luINOUT_DATE.ToDateTime).Substring(0, 10).Replace("-", "");
        //        _pProductInOutStatus_T50Entity.PART_CODE = _luPART.CodeText;
        //        _pProductInOutStatus_T50Entity.PART_NAME = _luPART.NameText;
        //        _pProductInOutStatus_T50Entity.VEND_CODE = _luVEND.CodeText = "";// _luVEND_CODE.Text;
        //        _pProductInOutStatus_T50Entity.VEND_NAME = _luVEND.NameText = "";

               

        //        //new sheet에 dt 바인딩
        //        //_dtList = new ProductInStatusBusiness().Sheet_Info_Sheet_Data(_pProductInStatusEntity);
        //        _dsList = new ProductInStatusBusiness().Sheet_Info_Sheet_Data(_pProductInOutStatus_T50Entity);

        //        //각각 필요한 현황들 바인딩
        //        _dtList_01 = _dsList.Tables[0];
        //        _dtList_02 = _dsList.Tables[1];
        //        _dtList_03 = _dsList.Tables[2];
        //        _dtList_04 = _dsList.Tables[3];
        //        //IWorkbook workbook = _sdMAIN.Document;
        //      //  workbook = _sdMAIN.Document;

        //        //원본 데이터 바인딩할 엑셀Sheet명
        //        //Worksheet worksheet_1 = workbook.Worksheets["Data"];        //sample
        //        Worksheet worksheet_BackData_01 = workbook.Worksheets["Back_Data_01"];
        //        Worksheet worksheet_BackData_02 = workbook.Worksheets["Back_Data_02"];
        //        Worksheet worksheet_BackData_03 = workbook.Worksheets["Back_Data_03"];
        //        Worksheet worksheet_BackData_04 = workbook.Worksheets["Back_Data_04"];

        //        // if (_dtList != null)
        //        if (_dsList!=null)
        //        {
        //            ExternalDataSourceOptions dsOptions = new ExternalDataSourceOptions();
        //            dsOptions.ImportHeaders = false;
        //            // worksheet_1.DataBindings.BindToDataSource(_dtList, 1, 0, dsOptions);

        //            //피벗테이블에 들어갈 각 표들의 원본 데이터 바인딩
        //            // 1.제품입고현황
        //            worksheet_BackData_01.DataBindings.BindToDataSource(_dtList_01, 1, 0, dsOptions);
        //            // 2.기간별생산실적현황
        //            worksheet_BackData_02.DataBindings.BindToDataSource(_dtList_02, 1, 0, dsOptions);
        //            // 3.제품미출고현황
        //            worksheet_BackData_03.DataBindings.BindToDataSource(_dtList_03, 1, 0, dsOptions);
        //            // 4.제품재고현황
        //            worksheet_BackData_04.DataBindings.BindToDataSource(_dtList_04, 1, 0, dsOptions);

        //        }
        //        else
        //        {
        //            //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
        //            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
        //        }

        //        //18.06.22 원본 : 현황하나만 보여주는 경우
        //        /*
        //         //피벗테이블이 있는 시트번호
        //         Worksheet worksheet_2 = workbook.Worksheets[1];
        //         Worksheet worksheet_3 = workbook.Worksheets[0]; //보여줄것

        //         //백데이터 범위
        //         Range backdata_range = worksheet_1.GetDataRange();
        //         worksheet_2.PivotTables[0].ChangeDataSource(backdata_range);

        //         // 피벗시트에서 피벗테이블 범위 알아오기 -> 차트에 범위 갱신
        //         Range PivotTable_range = worksheet_2.GetDataRange();

        //         //변경된 차트의 데이터범위를 조정
        //         //worksheet_2.Charts[0].SelectData(worksheet_2[pivotdata_range]);
        //         //worksheet_3.Charts[0].SelectData(worksheet_2[pivotdata_range]);
        //         worksheet_2.Charts[0].SelectData(PivotTable_range);
        //         worksheet_3.Charts[0].SelectData(PivotTable_range);

        //         workbook.Worksheets.ActiveWorksheet = workbook.Worksheets[0];
        //         workbook.PivotCaches.RefreshAll();
        //         //수정될경우 이벤트 호출 
        //         workbook.ActiveSheetChanged += Workbook_ActiveSheetChanged; ;
        //         //workbook.change
        //         */
                 
        //        //피벗테이블이 있는 시트번호
        //        Worksheet worksheet_PivotTable_01 = workbook.Worksheets["Pivot_01"];
        //        Worksheet worksheet_PivotTable_02 = workbook.Worksheets["Pivot_02"];
        //        Worksheet worksheet_PivotTable_03 = workbook.Worksheets["Pivot_03"];
        //        Worksheet worksheet_PivotTable_04 = workbook.Worksheets["Pivot_04"];

        //        //보여줄 현황 시트(차트있는 시트)
        //        Worksheet worksheet_Chart_01 = workbook.Worksheets["제품입고현황"];
        //        Worksheet worksheet_Chart_02 = workbook.Worksheets["기간별생산실적현황"];
        //        Worksheet worksheet_Chart_03 = workbook.Worksheets["제품미출고현황"];
        //        Worksheet worksheet_Chart_04 = workbook.Worksheets["제품재고현황"];


        //        //백데이터 범위 재지정
        //        Range backdata_range_01 = worksheet_PivotTable_01.GetDataRange();
        //        Range backdata_range_02 = worksheet_PivotTable_02.GetDataRange();
        //        Range backdata_range_03 = worksheet_PivotTable_03.GetDataRange();
        //        Range backdata_range_04 = worksheet_PivotTable_04.GetDataRange();

        //               worksheet_PivotTable_01.Charts[0].SelectData(backdata_range_01);
        //        worksheet_PivotTable_02.Charts[0].SelectData(backdata_range_02);
        //        worksheet_PivotTable_03.Charts[0].SelectData(backdata_range_03);
        //        worksheet_PivotTable_04.Charts[0].SelectData(backdata_range_04);

        //        //worksheet_PivotTable_01.Charts[0].ChangeDataSource(worksheet_BackData_01.GetDataRange());
        //        //worksheet_PivotTable_02.Charts[0].ChangeDataSource(worksheet_BackData_02.GetDataRange());
        //        //worksheet_PivotTable_03.Charts[0].ChangeDataSource(worksheet_BackData_03.GetDataRange());
        //        //worksheet_PivotTable_04.Charts[0].ChangeDataSource(worksheet_BackData_04.GetDataRange());

        //        //변경된 차트의 데이터범위를 조정
        //        worksheet_Chart_01.Charts[0].SelectData(backdata_range_01);
        //        worksheet_Chart_02.Charts[0].SelectData(backdata_range_02);
        //        worksheet_Chart_03.Charts[0].SelectData(backdata_range_03);
        //        worksheet_Chart_04.Charts[0].SelectData(backdata_range_04);

        //        workbook.Worksheets.ActiveWorksheet = workbook.Worksheets[0];
        //        workbook.PivotCaches.RefreshAll();
        //        //수정될경우 이벤트 호출 
        //        workbook.ActiveSheetChanged += Workbook_ActiveSheetChanged; ;

        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
        //    }
        //    finally
        //    {
        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
        //    }
        //}
        ////시트가 바뀔때마다 새로고침
        //private void Workbook_ActiveSheetChanged(object sender, ActiveSheetChangedEventArgs e)
        //{
        //    //피벗테이블이 있는 시트번호
        //    Worksheet worksheet_2 = workbook.Worksheets[1];
        //    Worksheet worksheet_3 = workbook.Worksheets[0]; //보여줄것
        //   //피벗테이블이 있는 시트번호
        //    Worksheet worksheet_PivotTable_01 = workbook.Worksheets["Pivot_01"];
        //    Worksheet worksheet_PivotTable_02 = workbook.Worksheets["Pivot_02"];
        //    Worksheet worksheet_PivotTable_03 = workbook.Worksheets["Pivot_03"];
        //    Worksheet worksheet_PivotTable_04 = workbook.Worksheets["Pivot_04"];

        //    //보여줄 현황 시트(차트있는 시트)
        //    Worksheet worksheet_Chart_01 = workbook.Worksheets["제품입고현황"];
        //    Worksheet worksheet_Chart_02 = workbook.Worksheets["기간별생산실적현황"];
        //    Worksheet worksheet_Chart_03 = workbook.Worksheets["제품미출고현황"];
        //    Worksheet worksheet_Chart_04 = workbook.Worksheets["제품재고현황"];

        //    // 피벗시트에서 피벗테이블 범위 알아오기 -> 차트에 범위 갱신
        //    Range PivotTable_range_01 =worksheet_PivotTable_01.GetDataRange();
        //    Range PivotTable_range_02 =worksheet_PivotTable_02.GetDataRange();
        //    Range PivotTable_range_03 =worksheet_PivotTable_03.GetDataRange();
        //    Range PivotTable_range_04 =worksheet_PivotTable_04.GetDataRange();

        //    //범위 재정의 저장
        //    ////피벗테이블쪽 차트
        //    worksheet_PivotTable_01.Charts[0].SelectData(PivotTable_range_01);
        //    worksheet_PivotTable_02.Charts[0].SelectData(PivotTable_range_02);
        //    worksheet_PivotTable_03.Charts[0].SelectData(PivotTable_range_03);
        //    worksheet_PivotTable_04.Charts[0].SelectData(PivotTable_range_04);
        //    ////실제 사용자용 차트
        //    worksheet_Chart_01.Charts[0].SelectData(PivotTable_range_01);
        //    worksheet_Chart_02.Charts[0].SelectData(PivotTable_range_02);
        //    worksheet_Chart_03.Charts[0].SelectData(PivotTable_range_03);
        //    worksheet_Chart_04.Charts[0].SelectData(PivotTable_range_04);

        //    workbook.PivotCaches.RefreshAll();
        //}

        ////피벗테이블 수정될때마다 차트 업데이트
        //private void Workbook_ModifiedChanged(object sender, EventArgs e)
        //{
        //    workbook.PivotCaches.RefreshAll();
        //}



        #endregion

      
    }
}
