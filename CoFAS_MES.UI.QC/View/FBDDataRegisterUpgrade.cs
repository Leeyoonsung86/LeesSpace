using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.UI.QC.Business;
using CoFAS_MES.UI.QC.Entity;
using DevExpress.Spreadsheet;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoFAS_MES.UI.QC
{
    public partial class FBDDataRegisterUpgrade : frmBaseNone
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

        private FBDDataRegisterEntity _pFBDDataRegisterEntity = null; // 엔티티 생성

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
        IWorkbook wb = null;
        Worksheet worksheet = null;
        string worksheetName = string.Empty;

        object[,] data;
        DataTable tempDataTable = new DataTable();
        //string[] columnList = { "회사 코드", "결과", "피쉬본이름", "부모피쉬본이름", "레벨", "표시순서", "사용 여부", "등록일자", "등록자", "수정일자", "수정자", "부모코드", "랭킹", "일본어이름" };
        string[] _columnList = { "assignment", "fbd_name", "fbd_pname", "presently_data", "iiot_data", "remarks1", "remarks2", "ranking", "user", "excelfile", "excel_code" };
        string[] temp_columnList = { "fbdName", "fbdCode" };

        string[] comminInfo = { "assignment", "standard_process", "work_center", "equipment", "tool", "resource", "ranking", "4m1e", "user" };
        private string processName = string.Empty;

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

        private CoFAS_Log _pCoFAS_Log = new CoFAS_Log(Application.StartupPath + "//LOG", "", 30, true);

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

        public FBDDataRegisterUpgrade()
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
                //상속 화면 패널 사용 유무
                _pnHeader.Visible = true;
                _pnContent.Visible = true;
                _pnLeft.Visible = true;

                listBox1.Items.Clear();
                listBox1.Items.Clear();

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
                _pFBDDataRegisterEntity = new FBDDataRegisterEntity();
                _pFBDDataRegisterEntity.USER_CODE = _pUSER_CODE;
                _pFBDDataRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;


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
                _pFBDDataRegisterEntity.CRUD = "";

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

                //pButtonSetting.UseYNSearchButton = _pMenuSettingEntity.MENU_SEARCH == "Y" ? true : false; // 조회
                //pButtonSetting.UseYNExportButton = _pMenuSettingEntity.MENU_EXPORT == "Y" ? true : false; // 내보내기
                pButtonSetting.UseYNImportButton = _pMenuSettingEntity.MENU_IMPORT == "Y" ? true : false; // 가져오기
                //pButtonSetting.UseYNPrintButton = _pMenuSettingEntity.MENU_PRINT == "Y" ? true : false; // 프린터
                pButtonSetting.UseYNSaveButton = _pMenuSettingEntity.MENU_SAVE == "Y" ? true : false; // 저장
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

                _luFBDFILE_MEMO.Enabled = false;

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

        // 메인 버튼 영역
        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            bool pErrorYN = false;
            try
            {
                CoFAS_DevExpressManager.ShowInformationMessage("しばらくお待ちください。");
                StructureCode = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString()
                       + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                {
                    pErrorYN = true;
                    return;
                }

                if (listBoxControl1.Items.Count > 0)
                {
                    if (_luFBDFILE_NAME.Text != "")
                    {
                        DataTable dt = new FBDDataRegisterBusiness().Structure_Data_Read(_pFBDDataRegisterEntity, _luFBDFILE_NAME.Text, 4);

                        //파일 이름 중복방지
                        if (dt.Rows.Count < 1)
                        {                          
                            data = null;
                            //for문으로 파일 개수만큼 스프레드에 로드하고 처리하기.
                            for (int filecount = 0; filecount < listBoxControl1.Items.Count; filecount++)
                            {
                                CustomFileEntity cu = (CustomFileEntity)listBoxControl1.Items[filecount];
                                spreadsheetControl1.LoadDocument(cu.FullFileName);
                                ExcelFileName = cu.FullFileName;
                                worksheetName = spreadsheetControl1.ActiveSheet.Name;

                                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);



                                wb = spreadsheetControl1.Document;
                                worksheet = wb.Worksheets[worksheetName];

                                //worksheet.Cells[row,col] 0,0 시작

                                //Range usedRange = spreadsheetControl1.Document.Worksheets[worksheetName].GetUsedRange();
                                Range usedRange = spreadsheetControl1.Document.Worksheets[worksheetName].GetDataRange();
                                int row = usedRange.RowCount;
                                int col = usedRange.ColumnCount;

                                data = new object[row + 1, col + 1];

                                for (int i = 0; i < row; i++)
                                {
                                    for (int j = 0; j < col; j++)
                                    {
                                        data[i + 1, j + 1] = worksheet.Cells[i, j].Value;
                                    }
                                }

                                //END 로우, 컬럼 찾기
                                for (int a = 0; a <= row; a++)
                                {
                                    if (data[a, 1] != null)
                                    {
                                        if (data[a, 1].ToString() == "END")
                                        {
                                            EndRow = a - 1;
                                            break;
                                        }
                                    }
                                }
                                for (int b = 0; b <= col; b++)
                                {
                                    if (data[1, b] != null)
                                    {
                                        if (data[1, b].ToString() == "END")
                                        {
                                            EndCol = b;
                                            break;
                                        }
                                    }
                                }

                                ///데이터 체크는 data[,]으로 한다.

                                #region 공백 항목 체크
                                //4m1e 공백 체크 
                                for (int r = StartDataRow; r <= EndRow; r++)
                                {
                                    int rck = 0;
                                    for (int c = 1; c <= 5; c++)
                                    {
                                        if (data[r, c].ToString() != "")
                                        {
                                            rck++;
                                            break;
                                        }
                                    }
                                    if (rck == 0)
                                    {
                                        pErrorYN = true;

                                        dtMSG = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                                        if (dtMSG != null && dtMSG.Rows[0][0].ToString() != "")
                                        {
                                            _pMSG_File_Error = dtMSG.Rows[0]["MSG_4M1E_ERROR"].ToString();
                                            CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_File_Error + cu.FileName + "\r\n\r\n[ROW : " + r.ToString() + "]");
                                        }

                                        return;
                                    }
                                }

                                ////code 공백 체크
                                //for (int w = StartDataRow; w <= EndRow; w++)
                                //{
                                //    for (int q = 23; q <= 27; q++)
                                //    {
                                //        if (data[w, q].ToString() == "")
                                //        {
                                //            pErrorYN = true;

                                //            dtMSG = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                                //            if (dtMSG != null && dtMSG.Rows[0][0].ToString() != "")
                                //            {
                                //                _pMSG_File_Error = dtMSG.Rows[0]["MSG_CodeNumber_ERROR"].ToString();
                                //                CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_File_Error + cu.FileName + "\r\n\r\n[" + data[4, q].ToString() + " / ROW : " + w.ToString() + "]");
                                //            }

                                //            return;
                                //        }
                                //    }
                                //}

                                ////code 중복 체크
                                //List<string> cdlist = new List<string>();
                                //string cd = string.Empty;

                                //for (int w = StartDataRow; w <= EndRow; w++)
                                //{
                                //    for (int q = 23; q <= 27; q++)
                                //    {
                                //        cd += data[w, q].ToString();
                                //    }
                                //    cdlist.Add(cd);
                                //    cd = string.Empty;
                                //}

                                //if (cdlist.Distinct().Count() != cdlist.Count)
                                //{
                                //    for (int rr = 0; rr < cdlist.Count; rr++)
                                //    {
                                //        for (int yy = rr + 1; yy < cdlist.Count; yy++)
                                //        {
                                //            if (cdlist[rr].ToString() == cdlist[yy].ToString())
                                //            {
                                //                pErrorYN = true;

                                //                dtMSG = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                                //                if (dtMSG != null && dtMSG.Rows[0][0].ToString() != "")
                                //                {
                                //                    _pMSG_File_Error = dtMSG.Rows[0]["MSG_CodeNumber_ERROR"].ToString();
                                //                    CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_File_Error + cu.FileName + "\r\n\r\n" + cdlist[yy].ToString().Insert(4, "-"));
                                //                }

                                //                return;
                                //            }
                                //        }
                                //    }
                                //}


                                //품질 랭킹 공백 체크 
                                for (int r = StartDataRow; r <= EndRow; r++)
                                {
                                    for (int c = StartAssignCol; c <= EndCol; c++)
                                    {
                                        if (data[r, c].ToString() == "")
                                        {
                                            pErrorYN = true;

                                            dtMSG = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                                            if (dtMSG != null && dtMSG.Rows[0][0].ToString() != "")
                                            {
                                                _pMSG_File_Error = dtMSG.Rows[0]["MSG_HOMEWORK_ERROR"].ToString();
                                                CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_File_Error + cu.FileName + "\r\n\r\n[" + data[4, c].ToString() + " / ROW : " + r.ToString() + "]");
                                            }

                                            return;
                                        }
                                    }
                                }

                                //과제 항목 공백 체크
                                //여기 작업 해야함

                                #endregion

                                //FBD 마스터 코드 등록
                                MstCodeCreate(data);

                                //리커시브 구조 등록
                                if(RecursiveCreate(data, _luFBDFILE_NAME.Text))
                                {
                                    throw new Exception();
                                }

                                //fbd 메모 등록
                                FBDMemmoCreate(data, _luFBDFILE_NAME.Text);
                            }
                        }
                        else
                        {
                            //파일 이름 이미 존재 다른 이름으로 고쳐주세요.
                            dtMSG = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                            if (dtMSG != null && dtMSG.Rows[0][0].ToString() != "")
                            {
                                pErrorYN = true;
                                _pMSG_File_Error = dtMSG.Rows[0]["MSG_FILENAME_DUPLICATION"].ToString();
                                CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_File_Error);
                            }
                            return;
                        }
                    }
                    else
                    {
                        dtMSG = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                        if (dtMSG != null && dtMSG.Rows[0][0].ToString() != "")
                        {
                            pErrorYN = true;
                            _pMSG_File_Error = dtMSG.Rows[0]["MSG_FILENAME_ERROR"].ToString();
                            CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_File_Error);
                        }
                        return;
                    }
                    
                }
                else
                {
                    dtMSG = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                    if (dtMSG != null && dtMSG.Rows[0][0].ToString() != "")
                    {
                        pErrorYN = true;
                        _pMSG_File_Error = dtMSG.Rows[0]["MSG_FILE_ERROR"].ToString();
                        CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_File_Error);
                    }
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
                _pFBDDataRegisterEntity.CRUD = "R";
                _pFBDDataRegisterEntity.RTN_KEY = "";
                _pFBDDataRegisterEntity.RTN_SEQ = "";
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
                OpenFileDialog opd = new OpenFileDialog();
                opd.Multiselect = true;
                opd.FileName = "";
                opd.Filter = "xlsx File(*.xlsx)|*.xlsx|xls File(*.xls)|*.xls";
                opd.Title = "Excel File Select";

                if (opd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string a in opd.SafeFileNames)
                    {                         
                        FilesCount++;
                    }

                    listBoxControl1.DisplayMember = "FileName";
                    listBox1.DisplayMember = "AssignmentName";

                    for (int i=0; i < FilesCount; i++)
                    {
                        listBoxControl1.Items.Add(new CustomFileEntity()
                        {
                            FileName = opd.SafeFileNames[i].ToString(),
                            FullFileName = opd.FileNames[i].ToString()
                        });                        
                    }


                    fileName = opd.SafeFileName;
                    fileFullName = opd.FileName;

                    //ExcelFileName
                    ForderPath = string.Empty;
                    savefilename.Clear();
                    string[] file_groupName = fileName.Split('.');
                    string[] fileNameStrings = fileFullName.Split('.');
                    StringBuilder txtReportFileName;

                    //ExcelFileName = fileFullName;

                    //컨트롤 추가해야함
                    _luFBDFILE_NAME.Text = file_groupName[0];
                    txtReportFileName = new StringBuilder(string.Empty, 64);
                    foreach (string str in fileNameStrings)
                    {
                        txtReportFileName.Append(str + ".");
                    }
                    

                    //ForderPath = ReturnForderName(XmindFileName);
                           
                    //파일 과제 개수 비교
                    for(int ii = 0; ii< FilesCount; ii++)
                    {
                        spreadsheetControl1.LoadDocument(opd.FileNames[ii].ToString());

                        wb = spreadsheetControl1.Document;
                        worksheetName = spreadsheetControl1.ActiveSheet.Name;
                        worksheet = wb.Worksheets[worksheetName];

                        Range usedRange = spreadsheetControl1.Document.Worksheets[worksheetName].GetDataRange();
                        int row = usedRange.RowCount;
                        int col = usedRange.ColumnCount;

                        data = new object[row + 1, col + 1];
                      
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                data[i + 1, j + 1] = worksheet.Cells[i, j].Value;
                            }
                        }


                        for(int r=0; r <= row; r++)
                        {
                            if(data[r, 1] != null)
                            {
                                if(data[r, 1].ToString() == "END")
                                {
                                    EndRow = r;
                                    break;
                                }
                            }
                        }

                        if(EndRow == 0)
                        {
                            throw new Exception("END 로우가 없습니다.\r\nFile Name: " + opd.SafeFileNames[ii].ToString());
                        }

                        for (int b = 0; b <= col; b++)
                        {
                            if (data[1, b] != null)
                            {
                                if (data[1, b].ToString() == "END")
                                {
                                    EndCol = b;
                                    break;
                                }
                            }
                        }

                        if(EndCol == 0)
                        {
                            throw new Exception("END 컬럼이 없습니다.\r\nFile Name: " + opd.SafeFileNames[ii].ToString());
                        }

                        if (ii > 0)
                        {
                            if (Redcolbak != EndCol)
                            {
                                string a = opd.SafeFileNames[ii].ToString();
                                spreadsheetControl1.CreateNewDocument();
                                listBox1.Items.Clear();

                                dtMSG = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                                if (dtMSG != null && dtMSG.Rows[0][0].ToString() != "")
                                {
                                    _pMSG_File_Error = dtMSG.Rows[0]["MSG_ASSI_ERROR"].ToString();

                                    throw new Exception(_pMSG_File_Error/* + "\r\nFile Name: " + a*/);
                                }
                            }
                        }
                        else
                        {
                            Redcolbak = EndCol;
                        }
                    }

                    for(int z = 17; z <= EndCol/*Redcolbak*/; z++)
                    {
                        listBox1.Items.Add(new CustomAssiEntity()
                        {
                            AssignmentName = data[5, z].ToString()
                        });
                    }                    

                    //SELECTFILE_NAME.Text = ExcelFileName;                    
                }
               
                if (FilesCount > 0)
                {
                    listBoxControl1.SelectedIndex = 0;
                    listBox1.SelectedIndex = 0;
                    listBox1.HorizontalScrollbar = true;
                    listBoxControl1.HorizontalScrollbar = true;

                    _luFBDFILE_MEMO.Enabled = true;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                listBoxControl1.Items.Clear();
                listBox1.Items.Clear();
                spreadsheetControl1.CreateNewDocument();
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            catch (Exception ex)
            {
                listBoxControl1.Items.Clear();
                listBox1.Items.Clear();
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

                listBoxControl1.Items.Clear();
                listBox1.Items.Clear();
                _luFBDFILE_NAME.Text = "";
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



        #region # 메인로직 메소드 #
        private bool MstCodeCreate(object[,] data)
        {
            bool pErrorYN = false;
             
            try
            {
                string fbdcode = string.Empty;
                string fbdname = string.Empty;
                string fbdmiddle = string.Empty;
                string Excel_code = string.Empty;
                int c = 0;

                tempDataTable = new DataTable();

                //임시 데이터 테이블 생성          
                for (int colCount = 0; colCount < temp_columnList.Count(); colCount++)
                {
                    tempDataTable.Columns.Add(new DataColumn(temp_columnList[colCount]));
                }

                #region 4M1E코드 추가
                for (int x = 1; x <= 5; x++)
                {
                    c = 0;
                    DataRow dtrow = tempDataTable.NewRow();
                    fbdname = data[5, x].ToString();
                    //문자열 공백 제거 
                    fbdname = fbdname.Trim();

                    _pFBDDataRegisterEntity.fbdName = fbdname;

                    if (data[5, x] != null)
                    {
                        if (data[5, x].ToString() == "MEN")
                        {
                            fbdcode = "4M1E-01000000";
                        }
                        else if (data[5, x].ToString() == "MAC")
                        {
                            fbdcode = "4M1E-02000000";
                        }
                        else if (data[5, x].ToString() == "MAT")
                        {
                            fbdcode = "4M1E-03000000";
                        }
                        else if (data[5, x].ToString() == "MET")
                        {
                            fbdcode = "4M1E-04000000";
                        }
                        else
                        {
                            fbdcode = "4M1E-05000000";
                        }
                        dtrow["fbdName"] = fbdname;
                        dtrow["fbdCode"] = fbdcode;
                        _pFBDDataRegisterEntity.fbdName = data[5, x].ToString();
                        _pFBDDataRegisterEntity.fbdcode = fbdcode;
                        _pFBDDataRegisterEntity.Level = 1;
                        new FBDDataRegisterBusiness().FBDExcel_Data_Save(_pFBDDataRegisterEntity);

                        if (tempDataTable.Rows.Count == 0)
                        {
                            tempDataTable.Rows.Add(dtrow);
                        }

                        for (int t = 0; t < tempDataTable.Rows.Count; t++)
                        {
                            if (tempDataTable.Rows[t]["fbdCode"].ToString() == fbdcode)
                            {
                                c++;
                                break;
                            }
                        }
                        if (c == 0)
                        {
                            tempDataTable.Rows.Add(dtrow);
                        }
                    }
                }
                fbdname = "";
                fbdcode = "";
                #endregion

                #region 과제코드 추가                
                for (int col = StartAssignCol; col <= EndCol; col++)
                {
                    c = 0;
                    DataRow dtrow = tempDataTable.NewRow();

                    //과제 소분류 항목 일본어 이름
                    if (data[5, col] != null)
                    {
                        if (data[5, col].ToString() != "")
                        {
                            fbdname += data[5, col].ToString();
                        }
                    }

                    _pFBDDataRegisterEntity.fbdName = fbdname;

                    //과제 소분류 항목 코드
                    DataTable dt = new FBDDataRegisterBusiness().FBDExcel_Data_Read(_pFBDDataRegisterEntity, "S");
                    int cnt = Convert.ToInt32(dt.Rows[0]["COUNT(*)"]);

                    fbdcode = "ASSI-";
                    for (int z = 0; z < 8 - ((cnt + 1).ToString()).Length; z++)
                    {
                        fbdcode += "0";
                    }
                    fbdcode += (cnt + 1).ToString();

                    _pFBDDataRegisterEntity.fbdcode = fbdcode;

                    if (new FBDDataRegisterBusiness().FBDExcel_Data_Save(_pFBDDataRegisterEntity))
                    {
                        throw new Exception();
                    }

                    fbdname = "";
                    fbdcode = "";


                    //과제 중분류 항목 일본어 이름
                    if (data[4, col] != null)
                    {
                        if (data[4, col].ToString() != "")
                        {
                            fbdmiddle = data[4, col].ToString();
                        }
                    }

                    _pFBDDataRegisterEntity.fbdName = fbdmiddle;

                    //과제 중분류 항목 코드
                    DataTable dt2 = new FBDDataRegisterBusiness().FBDExcel_Data_Read(_pFBDDataRegisterEntity, "M");
                    int cnt2 = Convert.ToInt32(dt2.Rows[0]["COUNT(*)"]);

                    fbdcode = "ASSI-1";
                    for (int z = 0; z < 7 - ((cnt2 + 1).ToString()).Length; z++)
                    {
                        fbdcode += "0";
                    }
                    fbdcode += (cnt2 + 1).ToString();

                    _pFBDDataRegisterEntity.fbdcode = fbdcode;

                    if (new FBDDataRegisterBusiness().FBDExcel_Data_Save(_pFBDDataRegisterEntity))
                    {
                        throw new Exception();
                    }

                    //과제 중분류, 소분류 맵핑
                    string middleclass = string.Empty;
                    string smallclass = string.Empty;

                    if (data[4, col] != null)
                    {
                        if (data[4, col].ToString() != "")
                        {
                            middleclass = data[4, col].ToString();
                            _pFBDDataRegisterEntity.MiddleClass = middleclass;
                        }
                    }
                    if (data[5, col] != null)
                    {
                        if (data[5, col].ToString() != "")
                        {
                            smallclass = data[5, col].ToString();
                            _pFBDDataRegisterEntity.SmallClass = smallclass;
                        }
                    }

                    if (new FBDDataRegisterBusiness().FBDExcel_ClassificationData_Save(_pFBDDataRegisterEntity))
                    {
                        throw new Exception();
                    }

                }
                #endregion

                #region 공정코드 추가
                for(int row = StartDataRow; row <= EndRow; row++)
                {
                    c = 0;
                    DataRow dtrow = tempDataTable.NewRow();

                    fbdname = "";
                    fbdname = data[row, 8].ToString();
                    _pFBDDataRegisterEntity.fbdName = fbdname;

                    fbdcode = string.Empty;
                    DataTable dt = new FBDDataRegisterBusiness().FBDExcel_Data_Read(_pFBDDataRegisterEntity, "P");
                    int cnt = Convert.ToInt32(dt.Rows[0]["COUNT(*)"]);

                    fbdcode = "PRCS-";
                    for (int z = 0; z < 8 - ((cnt + 1).ToString()).Length; z++)
                    {
                        fbdcode += "0";
                    }
                    fbdcode += (cnt + 1).ToString();

                    _pFBDDataRegisterEntity.fbdcode = fbdcode;

                    if (new FBDDataRegisterBusiness().FBDExcel_Data_Save(_pFBDDataRegisterEntity))
                    {
                        throw new Exception();
                    }

                    dtrow["fbdName"] = fbdname;
                    dtrow["fbdCode"] = fbdcode;

                    if (tempDataTable.Rows.Count == 0)
                    {
                        tempDataTable.Rows.Add(dtrow);
                    }

                    for (int t = 0; t < tempDataTable.Rows.Count; t++)
                    {
                        if (tempDataTable.Rows[t]["fbdCode"].ToString() == fbdcode)
                        {
                            c++;
                            break;
                        }
                    }
                    if (c == 0)
                    {
                        tempDataTable.Rows.Add(dtrow);
                    }

                    fbdname = "";
                    fbdcode = "";
                }
                #endregion

                #region 원인코드 추가     
                for (int row = StartDataRow; row <= EndRow; row++)
                {                   
                    for (int col = 9; col <= 12; col++)
                    {
                        c = 0;
                        DataRow dtrow = tempDataTable.NewRow();
                        if (data[row, col] != null)
                        {
                            if (data[row, col].ToString() != "")
                            {
                                fbdname = data[row, col].ToString();
                                                
                                _pFBDDataRegisterEntity.fbdName = fbdname;

                                fbdcode = string.Empty;
                                DataTable dt = new FBDDataRegisterBusiness().FBDExcel_Data_Read(_pFBDDataRegisterEntity, "C");
                                int cnt = Convert.ToInt32(dt.Rows[0]["COUNT(*)"]);

                                fbdcode = "CAUS-";
                                for (int z = 0; z < 8 - ((cnt + 1).ToString()).Length; z++)
                                {
                                    fbdcode += "0";
                                }
                                fbdcode += (cnt + 1).ToString();

                                _pFBDDataRegisterEntity.fbdcode = fbdcode;

                                if (new FBDDataRegisterBusiness().FBDExcel_Data_Save(_pFBDDataRegisterEntity))
                                {
                                    throw new Exception();
                                }

                                dtrow["fbdName"] = fbdname;
                                dtrow["fbdCode"] = fbdcode;

                                if (tempDataTable.Rows.Count == 0)
                                {
                                    tempDataTable.Rows.Add(dtrow);
                                }

                                for (int t = 0; t < tempDataTable.Rows.Count; t++)
                                {
                                    if (tempDataTable.Rows[t]["fbdCode"].ToString() == fbdcode)
                                    {
                                        c++;
                                        break;
                                    }
                                }
                                if (c == 0)
                                {
                                    tempDataTable.Rows.Add(dtrow);
                                }

                                fbdname = "";
                                fbdcode = "";
                            }
                        }
                    }
                }
                #endregion                
               
            }
            catch (Exception ex)
            {
                throw new Exception("MST code create error\r\n" + ex.Message);
            }

            return pErrorYN;
        }

        private bool RecursiveCreate(object[,] data, string filename)
        {
           
            bool pErrorYN = false;
            string fbdname = string.Empty;

           
            for (int centralTopicColumn = StartAssignCol; centralTopicColumn <= EndCol; centralTopicColumn++) //센트럴 토픽 = 결과
            {
                try
                {
                    if (data[5, centralTopicColumn] != null)
                    {
                        string cnetralTopic = data[5, centralTopicColumn].ToString(); //로우 번호를 Central Topic 명으로 변환.

                        DataTable dbDataTable = new DataTable();
                        DataRow dataRow;
                        for (int colCount = 0; colCount < _columnList.Count(); colCount++)
                        {
                            dbDataTable.Columns.Add(new DataColumn(_columnList[colCount]));
                        }

                        for (int row = StartDataRow; row <= EndRow; row++)
                        {
                            dataRow = dbDataTable.NewRow();
                            string ranking = "";

                            ArrayList upLayerArray = new ArrayList();
                            ArrayList valueArray = new ArrayList(); //자식코드, 부모코드 - DB(fbd_code,fbd_p_code)

                            if (data[row, centralTopicColumn] != null) //0,1,2,3,4,5 선호도 읽기  - 랭킹
                            {
                                switch (data[row, centralTopicColumn].ToString())
                                {
                                    case "x": case "×":
                                        break;
                                    case "0":
                                    case "1":
                                    case "2":
                                    case "3":
                                    case "4":
                                    case "5":
                                        dataRow["assignment"] = cnetralTopic;
                                        dataRow["excelfile"] = ExcelFileName;
                                        ranking = data[row, centralTopicColumn].ToString();
                                        dataRow["ranking"] = ranking;
                                        //4M1E 
                                        for (int _4M1Ecol = 1; _4M1Ecol <= 5; _4M1Ecol++)
                                        {
                                            if (data[row, _4M1Ecol] != null)
                                            {
                                                if (data[row, _4M1Ecol].ToString().Equals("○") || data[row, _4M1Ecol].ToString().Equals("〇"))
                                                {
                                                    dataRow["fbd_pname"] = data[5, _4M1Ecol].ToString();

                                                    fbdname = "";
                                                    for (int dataCol = 8; dataCol <= 12; dataCol++)
                                                    {
                                                        if (data[row, dataCol] != null)
                                                        {
                                                            if (data[row, dataCol].ToString() != "")
                                                            {
                                                                //if ((dataCol % 2) == 0)
                                                                //{
                                                                    fbdname += data[row, dataCol].ToString() + "_";
                                                                //}
                                                            }
                                                        }
                                                    }
                                                    fbdname = fbdname.Substring(0, fbdname.Length - 1);
                                                    dataRow["fbd_name"] = fbdname;

                                                    for (int sensorcol = 13; sensorcol <= 16; sensorcol++)
                                                    {
                                                        if (data[row, sensorcol] != null)
                                                        {
                                                            if (data[row, sensorcol].ToString() != "")
                                                            {
                                                                if (sensorcol == 13)
                                                                {
                                                                    dataRow["presently_data"] = data[row, sensorcol].ToString();
                                                                }
                                                                else if (sensorcol == 14)
                                                                {
                                                                    dataRow["iiot_data"] = data[row, sensorcol].ToString();
                                                                }
                                                                else if (sensorcol == 15)
                                                                {
                                                                    dataRow["remarks1"] = data[row, sensorcol].ToString();
                                                                }
                                                                else
                                                                {
                                                                    dataRow["remarks2"] = data[row, sensorcol].ToString();
                                                                }
                                                            }
                                                        }
                                                    }
                                                    
                                                    string Excel_code = string.Empty;
                                                    //for (int col = 23; col <= 27; col++)
                                                    //{
                                                    //    if (data[row, col] != null)
                                                    //    {
                                                    //        if (col == 23)
                                                    //        {
                                                    //            Excel_code += data[row, col] + "-";
                                                    //        }
                                                    //        else
                                                    //        {
                                                    //            if (data[row, col].ToString().Length == 1)
                                                    //            {
                                                    //                Excel_code += "0" + data[row, col];
                                                    //            }
                                                    //            else
                                                    //            {
                                                    //                Excel_code += data[row, col];
                                                    //            }
                                                    //        }
                                                    //    }
                                                    //}
                                                    dataRow["excel_code"] = Excel_code;

                                                    dataRow["user"] = _pUSER_CODE;
                                                    dbDataTable.Rows.Add(dataRow);
                                                    fbdname = "";
                                                    break;
                                                }
                                            }
                                        }
                                        break;
                                }
                            }
                        }//Row For문 END


                        #region DB 저장
                        //if (dbDataTable.Rows.Count > 0)
                        //{
                        //    bool checkContinue = new FBDDataRegisterBusiness().FBDStructure_Save(_pFBDDataRegisterEntity, dbDataTable, filename);
                        //    // true : fbd_p_code not exist. 공정정보 없음
                        //    if (checkContinue)
                        //    {
                        //        throw new Exception();
                        //    }

                        //}
                        #endregion                       
                    }
                }
                catch (Exception ex)
                {
                    //throw new Exception("리커시브 저장 오류");
                }
            }

            try
            {
                //컨설팅프로그램을 위한 기준정보 밀어넣는 로직
                //리커시브 구조임

                DataTable commondbDataTable = new DataTable();
                DataRow commondataRow = commondbDataTable.NewRow();
                int ccol = 0;
                for (int colCount = 0; colCount < comminInfo.Count(); colCount++)
                {
                    commondbDataTable.Columns.Add(new DataColumn(comminInfo[colCount]));
                }


                #region 사용안함
                //for (int assi_col = 17; assi_col <= EndCol; assi_col++)
                //{
                //    if (commondataRow["oneself"].ToString() != "")
                //    {
                //        #region 이번 로직
                //        for (int row = StartDataRow; row <= EndRow; row++)
                //        {
                //            for (int dataCol = 8; dataCol <= 12; dataCol++)
                //            {
                //                commondataRow["assigment"] = data[5, assi_col];

                //                if (dataCol == 8)
                //                {
                //                    commondataRow["gparents"] = "N/A";
                //                    commondataRow["parents"] = "N/A";
                //                    commondataRow["oneself"] = data[row, dataCol];
                //                    commondataRow["depth"] = "1";
                //                    commondataRow["last_yn"] = "N";
                //                }
                //                else if (dataCol == 9)
                //                {
                //                    commondataRow["gparents"] = "N/A";
                //                    commondataRow["parents"] = data[row, dataCol - 1];
                //                    commondataRow["oneself"] = data[row, dataCol];
                //                    commondataRow["depth"] = "2";
                //                    commondataRow["last_yn"] = "N";
                //                    if (data[row, dataCol + 1].ToString() == "" && data[row, dataCol + 2].ToString() == "" && data[row, dataCol + 3].ToString() == "")
                //                    {
                //                        commondataRow["last_yn"] = "Y";

                //                        for (int ii = 1; ii <= 5; ii++)
                //                        {
                //                            if (data[row, ii] != null)
                //                            {
                //                                if (data[row, ii].ToString().Equals("○") || data[row, ii].ToString().Equals("〇"))
                //                                {
                //                                    commondataRow["4m1e"] = data[4, ii].ToString();
                //                                    break;
                //                                }
                //                            }
                //                        }
                //                    }
                //                }
                //                else if (dataCol == 10)
                //                {
                //                    if (data[row, dataCol].ToString() != "")
                //                    {

                //                    }
                //                }
                //                else if (dataCol == 11)
                //                {
                //                    if (data[row, dataCol].ToString() != "")
                //                    {

                //                    }
                //                }
                //                else if (dataCol == 12)
                //                {
                //                    if (data[row, dataCol].ToString() != "")
                //                    {

                //                    }
                //                }


                //                else if (dataCol == 10)
                //                {
                //                    commondataRow["gparents"] = data[row, dataCol - 2];
                //                    commondataRow["parents"] = data[row, dataCol - 1];
                //                    commondataRow["oneself"] = data[row, dataCol];
                //                    commondataRow["depth"] = dataCol - 7;
                //                    commondataRow["last_yn"] = "N";
                //                    if (data[row, dataCol + 1].ToString() == "" && data[row, dataCol + 2].ToString() == "")
                //                    {
                //                        commondataRow["last_yn"] = "Y";

                //                        for (int ii = 1; ii <= 5; ii++)
                //                        {
                //                            if (data[row, ii] != null)
                //                            {
                //                                if (data[row, ii].ToString().Equals("○") || data[row, ii].ToString().Equals("〇"))
                //                                {
                //                                    commondataRow["4m1e"] = data[5, ii].ToString();
                //                                    break;
                //                                }
                //                            }
                //                        }
                //                    }
                //                }
                //                else if (dataCol == 11)
                //                {
                //                    commondataRow["gparents"] = data[row, dataCol - 2];
                //                    commondataRow["parents"] = data[row, dataCol - 1];
                //                    commondataRow["oneself"] = data[row, dataCol];
                //                    commondataRow["depth"] = dataCol - 7;
                //                    commondataRow["last_yn"] = "N";
                //                    if (data[row, dataCol + 1].ToString() == "")
                //                    {
                //                        commondataRow["last_yn"] = "Y";

                //                        for (int ii = 1; ii <= 5; ii++)
                //                        {
                //                            if (data[row, ii] != null)
                //                            {
                //                                if (data[row, ii].ToString().Equals("○") || data[row, ii].ToString().Equals("〇"))
                //                                {
                //                                    commondataRow["4m1e"] = data[5, ii].ToString();
                //                                    break;
                //                                }
                //                            }
                //                        }
                //                    }
                //                }
                //                else
                //                {
                //                    if (data[row, dataCol].ToString() != "")
                //                    {
                //                        commondataRow["gparents"] = data[row, dataCol - 2];
                //                        commondataRow["parents"] = data[row, dataCol - 1];
                //                        commondataRow["oneself"] = data[row, dataCol];
                //                        commondataRow["depth"] = dataCol - 7;
                //                        commondataRow["last_yn"] = "Y";

                //                        for (int ii = 1; ii <= 5; ii++)
                //                        {
                //                            if (data[row, ii] != null)
                //                            {
                //                                if (data[row, ii].ToString().Equals("○") || data[row, ii].ToString().Equals("〇"))
                //                                {
                //                                    commondataRow["4m1e"] = data[5, ii].ToString();
                //                                    break;
                //                                }
                //                            }
                //                        }
                //                    }
                //                }





                //                commondbDataTable.Rows.Add(commondataRow);

                //                if (commondataRow["oneself"].ToString() != "")
                //                {
                //                    commondataRow = commondbDataTable.NewRow();
                //                }
                //            }
                //        }
                //        #endregion
                //    }
                //}
                #endregion

                
                for (int assicol = 17; assicol <= EndCol; assicol++)
                {
                    for (int row = StartDataRow; row <= EndRow; row++)
                    {
                        commondataRow = commondbDataTable.NewRow();

                        commondataRow["assignment"] = data[5, assicol].ToString();
                        commondataRow["standard_process"] = data[row, 8].ToString();
                        commondataRow["work_center"] = data[row, 9].ToString();
                        commondataRow["equipment"] = data[row, 10].ToString();
                        commondataRow["tool"] = data[row, 11].ToString();
                        commondataRow["resource"] = data[row, 12].ToString();
                        commondataRow["ranking"] = data[row, assicol].ToString();
                        commondataRow["user"] = "admin";
                        for (int ii = 1; ii <= 5; ii++)
                        {
                            if (data[row, ii] != null)
                            {
                                if (data[row, ii].ToString().Equals("○") || data[row, ii].ToString().Equals("〇"))
                                {
                                    commondataRow["4m1e"] = data[5, ii].ToString();
                                    break;
                                }
                            }
                        }
                        commondbDataTable.Rows.Add(commondataRow);
                    }
                }



                #region DB 저장
                //if (commondbDataTable.Rows.Count > 0)
                //{
                //    DataView view = commondbDataTable.DefaultView;
                //    commondbDataTable = view.ToTable(true, "gparents", "parents", "oneself", "depth", "last_yn", "4m1e");
                //    bool checkContinue = new FBDDataRegisterBusiness().USP_recursive_test_I10(commondbDataTable);
                //    // true : fbd_p_code not exist. 공정정보 없음
                //    if (checkContinue)
                //    {
                //        throw new Exception();
                //    }
                //}

                //if (commondbDataTable.Rows.Count > 0)
                //{
                //    DataView view = commondbDataTable.DefaultView;
                //    commondbDataTable = view.ToTable(true, "gparents", "parents", "oneself", "depth", "last_yn", "4m1e", "ranking", "assigment");
                //    bool checkContinue = new FBDDataRegisterBusiness().USP_recursive_test_I10(commondbDataTable);
                //    // true : fbd_p_code not exist. 공정정보 없음
                //    if (checkContinue)
                //    {
                //        throw new Exception();
                //    }
                //}
                double value = 0;


                if (commondbDataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < commondbDataTable.Rows.Count; i++)
                    {
                        DataRow dr = commondbDataTable.Rows[i];
                        Debug.WriteLine(i.ToString() + " / " + commondbDataTable.Rows.Count.ToString());
                        DisplayMessage("データを保存しています。  " + i.ToString() + " / " + commondbDataTable.Rows.Count.ToString());
                        value = ((double)1 / (double)commondbDataTable.Rows.Count) * 100;
                        lbl_message.Text = (i + 1).ToString() + "/" + commondbDataTable.Rows.Count;


                        //DataView view = commondbDataTable.DefaultView;
                        //commondbDataTable = view.ToTable(true, "assignment", "standard_process", "work_center", "equipment", "tool", "resource", "ranking", "4m1e", "user");
                        bool checkContinue = new FBDDataRegisterBusiness().USP_fbd_standard_structure_I10(dr);

                        if (checkContinue)
                        {
                            throw new Exception("USP_fbd_standard_structure_I10 Error");
                        }
                    }
                }

                progressbar.Value = 100;
                #endregion
            }
            catch(Exception ex)
            {
                pErrorYN = true;
            }
            return pErrorYN;
        }

        private void FBDMemmoCreate(object[,] data, string filename)
        {
            for (int centralTopicColumn = StartAssignCol; centralTopicColumn <= EndCol; centralTopicColumn++) //센트럴 토픽 = 결과
            {
                string assignmentName = data[5, centralTopicColumn].ToString(); //로우 번호를 Central Topic 명으로 변환.

                foreach(CustomAssiEntity cu in listBox1.Items)
                {
                    if(cu.AssignmentName == assignmentName)
                    {
                        if (cu.FileMemo != null)
                        {
                            new FBDDataRegisterBusiness().FBDMemo_Save(assignmentName, filename, cu.FileMemo, _pUSER_CODE);
                            break;
                        }
                    }
                }                
            }
        }


        public string ReturnForderName(string fileName)
        {
            int ascii = 92;
            string[] forderName = fileName.Split(Convert.ToChar(ascii));

            string forderNameStr = null;
            for (int i = 0; i < forderName.Length - 1; i++)
            {
                forderNameStr += forderName[i].ToString();

                if (i != forderName.Length - 2)
                    forderNameStr += Convert.ToChar(ascii);
            }

            return forderNameStr;
        }

        void setDBDataTableSeq(DataTable dataTable)
        {
            int allRowNumber = dataTable.Rows.Count;
            int tempNumber = 1;
            foreach (DataRow dtRow in dataTable.Rows)
            {
                dtRow["표시순서"] = tempNumber++;
            }
        }


        #endregion




        #region # 리스트 박스 이벤트 #
        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomFileEntity cf = (CustomFileEntity)listBoxControl1.SelectedItem;
            spreadsheetControl1.LoadDocument(cf.FullFileName);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomAssiEntity ca = (CustomAssiEntity)listBox1.SelectedItem;
            _luFBDFILE_MEMO.Text = ca.FileMemo;

            _luFBDFILE_MEMO.Focus();
        }

        private void _luFBDFILE_MEMO__OnTextChanged(object sender, EventArgs e)
        {
            CustomAssiEntity ca = (CustomAssiEntity)listBox1.SelectedItem;
            ca.FileMemo = _luFBDFILE_MEMO.Text;
        }
        #endregion
      
    }
}
