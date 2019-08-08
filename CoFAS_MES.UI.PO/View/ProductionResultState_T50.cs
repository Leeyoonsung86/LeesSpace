using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.UI.PO.Business;
using CoFAS_MES.UI.PO.Entity;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoFAS_MES.UI.PO
{
    public partial class ProductionResultState_T50 : frmBaseNone
    {
        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pCULTURE_INFO = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private System.Drawing.Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부
        private ProductionResultState_T50Entity _pProductionResultState_T50Entity = null; // 엔티티 생성

        private System.Data.DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

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

        private string _pUSER_GRANT = string.Empty;

        //알림창메시지 복사 끝

        private string _pMSG_File_Error = string.Empty;     //초기화 하였습니다.
        private string _pMSG_Change_Ok = string.Empty;


        System.Data.DataTable dt_MTemp = null;
        System.Data.DataTable dt_STemp = null;

        private DataTable dtMSG = null;

        string fileName = "";
        string fileFullName = "";
        string filePath = "";
        IWorkbook workbook = null;
        Worksheet worksheet = null;
        string worksheetName = string.Empty;

        Dictionary<string, string> topicDic = new Dictionary<string, string>(); 

        //topicDic (레이어 별로 분류)
        Dictionary<string, string> topicDicL1 = new Dictionary<string, string>();
        Dictionary<string, string> topicDicL2 = new Dictionary<string, string>();
        Dictionary<string, string> topicDicL3 = new Dictionary<string, string>();
        Dictionary<string, string> topicDicL4 = new Dictionary<string, string>();
        Dictionary<string, string> topicDicL5 = new Dictionary<string, string>();
        Dictionary<string, string> topicDicL6 = new Dictionary<string, string>();

        private string ExcelFileName;
        private string ForderPath = string.Empty;
        private List<string> savefilename;
        private int FilesCount = 0;
        private int StartDataRow = 6;
        private int StartAssignCol = 17;
        private string StructureCode;

        private class CustomFileEntity
        {
            public CustomFileEntity() { }

            public string FileName { set; get; }
            public string FullFileName { set; get; }
        }
        private class CustomAssiEntity
        {
            public CustomAssiEntity() { }
            public string AssignmentName { get; set; }
            public string FileMemo { get; set; }
        }
        private class FileMemoInfo
        {
            public FileMemoInfo(string filename, string assignmentname, string filememo)
            {
                this.FileName = filename;
                this.AssignmentName = assignmentname;
                this.FileMemo = filememo;
            }
            public string FileName { get; set; }
            public string AssignmentName { get; set; }
            public string FileMemo { get; set; }
        }

        private List<FileMemoInfo> list_filememo;

        public ProductionResultState_T50()
        {
            InitializeComponent();
            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);

            //Xmind 파일 리스트 생성
            savefilename = new List<string>();
        }

        private int EndRow = 0;
        private int EndCol = 0;
        
        #region ○ Form_Load
        private void Form_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                InitializeSetting();
                //버튼이벤트 생성
                SearchButtonClicked += new EventHandler(Form_SearchButtonClicked);
                SaveButtonClicked += new EventHandler(Form_SaveButtonClicked);
                ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);

                CoFAS_ControlManager.SetFontInControls(this.Controls, _pFONT_SETTING);

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

        #region ○ Form_FormClosed
        private void Form_FormClosed(object sender, FormClosedEventArgs pFormClosedEventArgs)
        {
            //throw new NotImplementedException();
            try
            {
                //화면 레이아웃 저장 
                //KillSpecificExcelFileProcess(fileFullName.Replace(filePath,""));
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ Form_Closing
        private void Form_Closing(object sender, FormClosingEventArgs pFormClosingEventArgs)
        {
            //throw new NotImplementedException();
            try
            {
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ Form_Activated
        private void Form_Activated(object sender, EventArgs pEventArgs)
        {
            //throw new NotImplementedException();
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

        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                _pProductionResultState_T50Entity = new ProductionResultState_T50Entity();
                //상속 화면 패널 사용 유무
                _pnHeader.Visible = true;
                _pnContent.Visible = true;
                _pnLeft.Visible = true;

                //메인 화면 전역 변수 처리
                _pCULTURE_INFO = MainForm.UserEntity.CULTURE_INFO;
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new System.Drawing.Font(_pFONT_TYPE, _pFONT_SIZE);
                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_IP_PORT = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PATH = MainForm.UserEntity.FTP_IP_PORT;
                _pFTP_PW = MainForm.UserEntity.FTP_PW;


                _pWINDOW_NAME = this.Name;

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

                _pUSER_GRANT = MainForm.UserEntity.USER_GRANT;

                //메뉴 화면 엔티티 설정
                //_pFBDDataRegisterEntity = new FBDDataRegisterEntity();
                //_pFBDDataRegisterEntity.USER_CODE = _pUSER_CODE;
                //_pFBDDataRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;


                //화면 설정 언어 & 명칭 변경.
                System.Data.DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                

                //그리드 설정
                //InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                //_pFBDDataRegisterEntity.CRUD = "";

                //MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                //SubFind_DisplayData();

                if (_pFirstYN)
                {
                    //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행


                    //그리드 버튼추가 시 클릭 이벤트 처리 
                    _pFirstYN = false;
                }
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
                //pButtonSetting.UseYNImportButton = _pMenuSettingEntity.MENU_IMPORT == "Y" ? true : false; // 가져오기
                //pButtonSetting.UseYNPrintButton = _pMenuSettingEntity.MENU_PRINT == "Y" ? true : false; // 프린터
                //pButtonSetting.UseYNSaveButton = _pMenuSettingEntity.MENU_SAVE == "Y" ? true : false; // 저장
                //pButtonSetting.UseYNAddItemButton = _pMenuSettingEntity.MENU_ADDITEM == "Y" ? true : false; // 신규
                //pButtonSetting.UseYNDeleteButton = _pMenuSettingEntity.MENU_DELETE == "Y" ? true : false; // 삭제

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

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl()
        {
            try
            {
                //조회조건 영역 
                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

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

        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //_pProductionResultState_T50Entity.DATE_FROM = DateTime.Parse(_luTORDER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");
                //_pProductionResultState_T50Entity.DATE_TO = DateTime.Parse(_luTORDER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");

                layoutControl2.Visible = false;

                SetExcel();

                SetData();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
                layoutControl2.Visible = true;

                _pProductionResultState_T50Entity.CRUD = "R";

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
        // 메인 버튼 영역

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            //try
            //{
            //    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

            //    _dtList = new WorkOrdersRegister_T50Business().Sample_Info(_pWorkOrdersRegister_T50Entity);

            //    if (_pWorkOrdersRegister_T50Entity.CRUD == "") _dtList.Rows.Clear();


            //    if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pWorkOrdersRegister_T50Entity.CRUD == ""))
            //    {
            //        CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

            //        if (_pLocation_Code != "")
            //        {
            //            int rowHandle = _gdMAIN_VIEW.LocateByValue("ORDER_ID", _pLocation_Code);
            //            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            //            {
            //                _gdMAIN_VIEW.FocusedRowHandle = rowHandle;
            //                _luORDER_ID.Text = _pLocation_Code;
            //            }
            //            //조회 후 초기화 
            //            _pLocation_Code = "";
            //            _luTPART_ALL.CodeText = "";
            //            _luTPART_ALL.NameText = "";
            //        }


            //    }
            //    else
            //    {
            //        //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
            //        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
            //        _dtList.Rows.Clear();
            //        CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
            //    }
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
            //finally
            //{
            //    //_gdMAIN_VIEW.BestFitColumns();

            //    CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            //}
        }

        #endregion

        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            bool pErrorYN = false;
            try
            {
                StructureCode = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString()
                       + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                {
                    pErrorYN = true;
                    return;
                }

                
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            catch (Exception pException)
            {
                pErrorYN = true;
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}", pException));                
            }
            finally
            {
                //_pFBDDataRegisterEntity.CRUD = "R";
                //_pFBDDataRegisterEntity.RTN_KEY = "";
                //_pFBDDataRegisterEntity.RTN_SEQ = "";
                //Form_InitialButtonClicked(null, null);
                

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);

                if(!pErrorYN)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장완료");//保存完了

                    dtMSG = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                    if (dtMSG != null && dtMSG.Rows[0][0].ToString() != "")
                    {
                        _pMSG_File_Error = dtMSG.Rows[0]["MSG_CHANGE_OK"].ToString();
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_File_Error);

                        //fbd 프로그램 띄우기
                        ProcessStartInfo startInfo = new ProcessStartInfo(Application.StartupPath + "\\FBD\\WpfAppFishBone.exe");
                        startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                        startInfo.Arguments = string.Format("{0}#{1}#{2}#{3}#{4}", DBManager.PrimaryConnectionString, _pUSER_CODE, _pFONT_TYPE, _pFONT_SIZE, _pCULTURE_INFO);
                        new SystemLogInfoBusiness().SystemEventLog_Info_Save("C", _pUSER_CODE, "QC", _pWINDOW_NAME, "Open Screen", "ShowWindow", "Run screen open");
                        Process.Start(startInfo);                        
                    }
                }
            }
        }

        #endregion

        #region ○ 가져오기 버튼 클릭시 처리하기
        private void Form_ImportButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                int Redcolbak = 0;
                FilesCount = 0;
                list_filememo = new List<FileMemoInfo>();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                
            }
            catch (ExceptionManager pExceptionManager)
            {
                spreadsheetControl1.CreateNewDocument();
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            catch (Exception ex)
            {
                spreadsheetControl1.CreateNewDocument();
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}", ex.Message.ToString()));
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

                DisplayMessage(_pMSG_RESET_COMPLETE);
                
                spreadsheetControl1.CreateNewDocument();

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

        #region Excel Process Kill
        private void KillSpecificExcelFileProcess(string excelFileName)
        {
            var processes = from p in Process.GetProcessesByName("EXCEL")
                            select p;

            foreach (var process in processes)
            {
                if (process.MainWindowTitle == "Microsoft Excel - " + excelFileName)
                    process.Kill();
            }
        }
        #endregion                    

        public void SetExcel()
        {
            _pProductionResultState_T50Entity.WINDOW_NAME = this.Name;

            string strUSE_TYPE = "";
            string strFILE_NAME = "";
            string strFTP_PATH = "";

            _dtList = new ProductionResultState_T50Business().Sheet_Info_Sheet(_pProductionResultState_T50Entity);

            strUSE_TYPE = _dtList.Rows[0]["USE_TYPE"].ToString();
            strFILE_NAME = _dtList.Rows[0]["FILE_NAME"].ToString();

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

            string curfile = Application.StartupPath + "\\Template\\" + strFILE_NAME;

            if (!File.Exists(curfile))
            {
                CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW, curfile, false);
            }


            spreadsheetControl1.LoadDocument(curfile);
        }

        public void SetData()
        {
            workbook = spreadsheetControl1.Document;
            worksheetName = spreadsheetControl1.ActiveSheet.Name;
            worksheet = workbook.Worksheets[worksheetName];

            worksheet.Range["D18:P18"].ColumnWidth = 310;
            worksheet.Cells["B3"].Value = _luDATE.DateTime.Year.ToString() + "년 정밀가공부 실적 집계표";
            worksheet.Cells["B4"].Value = _luDATE.DateTime.Year.ToString() + "년 목표 및 누적실적";
            worksheet.Cells["G4"].Value = _luDATE.DateTime.Year.ToString() + "년 월별 목표 및 실적";

            #region 목표금액
            //COK 목표실적 = 소형 목표실적
            string where_cok = "goal_type = \'PD030001\' and goal_month like \'" + _luDATE.DateTime.Year.ToString() + "%\'";

            DataTable dt_cok = new ProductionResultState_T50Business().SSP_PIVOT_RETURN_R10(where_cok);

            for (int dt_col = 1; dt_col < dt_cok.Columns.Count; dt_col++)
            {
                worksheet.Cells[16, dt_col + 2].Value = Convert.ToInt64(dt_cok.Rows[0][dt_col]);               
            }

            //FPD 목표실적
            string where_fpd = "goal_type = \'PD030002\' and goal_month like \'" + _luDATE.DateTime.Year.ToString() + "%\'";
            DataTable dt_fpd = new ProductionResultState_T50Business().SSP_PIVOT_RETURN_R10(where_fpd);

            for (int dt_col = 1; dt_col < dt_fpd.Columns.Count; dt_col++)
            {
                worksheet.Cells[19, dt_col + 2].Value = Convert.ToInt64(dt_fpd.Rows[0][dt_col]);
            }

            //SYS 목표실적
            string where_sys = "goal_type = \'PD030003\' and goal_month like \'" + _luDATE.DateTime.Year.ToString() + "%\'";
            DataTable dt_sys = new ProductionResultState_T50Business().SSP_PIVOT_RETURN_R10(where_sys);

            for (int dt_col = 1; dt_col < dt_sys.Columns.Count; dt_col++)
            {
                worksheet.Cells[22, dt_col + 2].Value = Convert.ToInt64(dt_sys.Rows[0][dt_col]);
            }
            #endregion

            #region 생산실적
            //생산 실적

            DataTable dt_cok_result = new ProductionResultState_T50Business().USP_product_inout_R10("C");
         
            int cok_col = 3;
            for (int cok_result_row = 0; cok_result_row < dt_cok_result.Rows.Count; cok_result_row++)
            {
                if (int.Parse(worksheet.Cells[11, cok_col].Value.ToString().Substring(0, 1)) == int.Parse(dt_cok_result.Rows[cok_result_row]["year_month"].ToString().Substring(4, 2)))
                {
                    worksheet.Cells[17, cok_col].Value = Convert.ToInt64(dt_cok_result.Rows[cok_result_row]["sum"]);
                }
                else
                {
                    cok_result_row--;
                }
                cok_col++;
            }



            DataTable dt_fpd_result = new ProductionResultState_T50Business().USP_product_inout_R10("F");

            int fpd_col = 3;
            for (int fpd_result_row = 0; fpd_result_row < dt_fpd_result.Rows.Count; fpd_result_row++)
            {
                if (int.Parse(worksheet.Cells[11, fpd_col].Value.ToString().Substring(0, 1)) == int.Parse(dt_fpd_result.Rows[fpd_result_row]["year_month"].ToString().Substring(4, 2)))
                {
                    worksheet.Cells[20, fpd_col].Value = Convert.ToInt64(dt_fpd_result.Rows[fpd_result_row]["sum"]);
                }
                else
                {
                    fpd_result_row--;
                }
                fpd_col++;
            }



            DataTable dt_sys_result = new ProductionResultState_T50Business().USP_product_inout_R10("S");
            int sys_col = 3;
            for (int sys_result_row = 0; sys_result_row < dt_sys_result.Rows.Count; sys_result_row++)
            {
                if (int.Parse(worksheet.Cells[11, fpd_col].Value.ToString().Substring(0, 1)) == int.Parse(dt_sys_result.Rows[sys_result_row]["year_month"].ToString().Substring(4, 2)))
                {
                    worksheet.Cells[23, sys_col].Value = Convert.ToInt64(dt_sys_result.Rows[sys_result_row]["sum"]);
                }
                else
                {
                    sys_result_row--;
                }
                sys_col++;
            }
            #endregion

            #region chart
            //상단 왼쪽
            Chart chart_top_left = worksheet.Charts.Add(ChartType.ColumnClustered);
            chart_top_left.TopLeftCell = worksheet.Cells["B5"];
            chart_top_left.BottomRightCell = worksheet.Cells["F11"];

            Series series_goal_tatol = chart_top_left.Series.Add(worksheet.Range["P12"], worksheet.Range["P13"]);
            series_goal_tatol.SeriesName.SetValue("목표");
            series_goal_tatol.Fill.SetSolidFill(Color.SkyBlue);

            Series series_result_total = chart_top_left.Series.Add(worksheet.Range["P12"], worksheet.Range["P14"]);
            series_result_total.SeriesName.SetValue("실적");
            series_result_total.Fill.SetSolidFill(Color.OrangeRed);

            Series series_result_percent = chart_top_left.Series.Add(worksheet.Range["P12"], worksheet.Range["P15"]);
            series_result_percent.SeriesName.SetValue("달성율");
            series_result_percent.ChangeType(ChartType.LineMarker);
            series_result_percent.Marker.Symbol = MarkerStyle.Triangle;
            series_result_percent.Fill.SetSolidFill(Color.DarkOliveGreen);

            chart_top_left.Series[2].AxisGroup = AxisGroup.Secondary;

            //상단 오른쪽
            Chart chart_top_right = worksheet.Charts.Add(ChartType.ColumnClustered);
            chart_top_right.TopLeftCell = worksheet.Cells["G5"];
            chart_top_right.BottomRightCell = worksheet.Cells["P11"];

            Series series_goal = chart_top_right.Series.Add(worksheet.Range["D12:O12"], worksheet.Range["D13:O13"]);
            series_goal.SeriesName.SetValue("목표");
            series_goal.Fill.SetSolidFill(Color.SkyBlue);

            Series series_result = chart_top_right.Series.Add(worksheet.Range["D12:O12"], worksheet.Range["D14:O14"]);
            series_result.SeriesName.SetValue("실적");
            series_result.Fill.SetSolidFill(Color.OrangeRed);

            Series series_result_percent2 = chart_top_right.Series.Add(worksheet.Range["D12:O12"], worksheet.Range["D15:O15"]);
            series_result_percent2.SeriesName.SetValue("달성율");
            series_result_percent2.ChangeType(ChartType.LineMarker);
            series_result_percent2.Marker.Symbol = MarkerStyle.Triangle;
            series_result_percent2.Fill.SetSolidFill(Color.DarkOliveGreen);

            chart_top_right.Series[2].AxisGroup = AxisGroup.Secondary;

            //하단 왼쪽
            Chart chart_bottom_left = worksheet.Charts.Add(ChartType.ColumnClustered);
            chart_bottom_left.TopLeftCell = worksheet.Cells["B37"];
            chart_bottom_left.BottomRightCell = worksheet.Cells["D47"];

            Series series_small_goal = chart_bottom_left.Series.Add(worksheet.Range["P12"], worksheet.Range["P29"]);
            series_small_goal.SeriesName.SetValue("목표");
            series_small_goal.Fill.SetSolidFill(Color.SkyBlue);

            Series series_small_result = chart_bottom_left.Series.Add(worksheet.Range["P12"], worksheet.Range["P30"]);
            series_small_result.SeriesName.SetValue("실적");
            series_small_result.Fill.SetSolidFill(Color.OrangeRed);

            Series series_result_percent3 = chart_bottom_left.Series.Add(worksheet.Range["P12"], worksheet.Range["P31"]);
            series_result_percent3.SeriesName.SetValue("달성율");
            series_result_percent3.ChangeType(ChartType.LineMarker);
            series_result_percent3.Marker.Symbol = MarkerStyle.Triangle;
            series_result_percent3.Fill.SetSolidFill(Color.DarkOliveGreen);

            chart_bottom_left.Series[2].AxisGroup = AxisGroup.Secondary;

            Chart chart_bottom_left2 = worksheet.Charts.Add(ChartType.ColumnClustered);
            chart_bottom_left2.TopLeftCell = worksheet.Cells["E37"];
            chart_bottom_left2.BottomRightCell = worksheet.Cells["I47"];

            Series series_small_goal2 = chart_bottom_left2.Series.Add(worksheet.Range["D12:O12"], worksheet.Range["D29:O29"]);
            series_small_goal2.SeriesName.SetValue("목표");
            series_small_goal2.Fill.SetSolidFill(Color.SkyBlue);

            Series series_small_result2 = chart_bottom_left2.Series.Add(worksheet.Range["D12:O12"], worksheet.Range["D30:O30"]);
            series_small_result2.SeriesName.SetValue("실적");
            series_small_result2.Fill.SetSolidFill(Color.OrangeRed);

            Series series_result_percent4 = chart_bottom_left2.Series.Add(worksheet.Range["D12:O12"], worksheet.Range["D31:O31"]);
            series_result_percent4.SeriesName.SetValue("달성율");
            series_result_percent4.ChangeType(ChartType.LineMarker);
            series_result_percent4.Marker.Symbol = MarkerStyle.Triangle;
            series_result_percent4.Fill.SetSolidFill(Color.DarkOliveGreen);

            chart_bottom_left2.Series[2].AxisGroup = AxisGroup.Secondary;

            //하단 오른쪽
            Chart chart_bottom_right = worksheet.Charts.Add(ChartType.ColumnClustered);
            chart_bottom_right.TopLeftCell = worksheet.Cells["J37"];
            chart_bottom_right.BottomRightCell = worksheet.Cells["L47"];

            Series series_big_goal = chart_bottom_right.Series.Add(worksheet.Range["P12"], worksheet.Range["P32"]);
            series_big_goal.SeriesName.SetValue("목표");
            series_big_goal.Fill.SetSolidFill(Color.SkyBlue);

            Series series_big_result = chart_bottom_right.Series.Add(worksheet.Range["P12"], worksheet.Range["P33"]);
            series_big_result.SeriesName.SetValue("실적");
            series_big_result.Fill.SetSolidFill(Color.OrangeRed);

            Series series_result_percent5 = chart_bottom_right.Series.Add(worksheet.Range["P12"], worksheet.Range["P34"]);
            series_result_percent5.SeriesName.SetValue("달성율");
            series_result_percent5.ChangeType(ChartType.LineMarker);
            series_result_percent5.Marker.Symbol = MarkerStyle.Triangle;
            series_result_percent5.Fill.SetSolidFill(Color.DarkOliveGreen);

            chart_bottom_right.Series[2].AxisGroup = AxisGroup.Secondary;


            Chart chart_bottom_right2 = worksheet.Charts.Add(ChartType.ColumnClustered);
            chart_bottom_right2.TopLeftCell = worksheet.Cells["M37"];
            chart_bottom_right2.BottomRightCell = worksheet.Cells["P47"];

            Series series_big_goal2 = chart_bottom_right2.Series.Add(worksheet.Range["D12:O12"], worksheet.Range["D32:O32"]);
            series_big_goal2.SeriesName.SetValue("목표");
            series_big_goal2.Fill.SetSolidFill(Color.SkyBlue);

            Series series_big_result2 = chart_bottom_right2.Series.Add(worksheet.Range["D12:O12"], worksheet.Range["D33:O33"]);
            series_big_result2.SeriesName.SetValue("실적");
            series_big_result2.Fill.SetSolidFill(Color.OrangeRed);

            Series series_result_percent6 = chart_bottom_right2.Series.Add(worksheet.Range["D12:O12"], worksheet.Range["D34:O34"]);
            series_result_percent6.SeriesName.SetValue("달성율");
            series_result_percent6.ChangeType(ChartType.LineMarker);
            series_result_percent6.Marker.Symbol = MarkerStyle.Triangle;
            series_result_percent6.Fill.SetSolidFill(Color.DarkOliveGreen);

            chart_bottom_right2.Series[2].AxisGroup = AxisGroup.Secondary;
            #endregion
        }
    }
}
