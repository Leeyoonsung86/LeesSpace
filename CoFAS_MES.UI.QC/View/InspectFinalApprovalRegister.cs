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
using CoFAS_MES.UI.QC.Business;
using CoFAS_MES.UI.QC.Data;
using CoFAS_MES.UI.QC.Entity;
using DevExpress.XtraGrid.Views.Grid;
//엑셀관련
using DevExpress.Spreadsheet;
using System.IO;
using static CoFAS_MES.CORE.BaseControls.ucSpreadSheetControl;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraSpreadsheet.Commands;
using DevExpress.XtraSpreadsheet.Menu;


namespace CoFAS_MES.UI.QC
{
    public partial class InspectFinalApprovalRegister : frmBaseNone
    {
        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭
        private static string _pFILE_NAME = string.Empty;

        private InspectFinalApprovalRegisterEntity _pInspectFinalApprovalRegisterEntity = null; // 엔티티 생성


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

        //엑셀관련
        IWorkbook workbook = null;                       //워크시트 전역변수
        private DataSet _dsList = null; //조회 데이터 리스트 데이터셋
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtList_01 = null; //조회 데이터 리스트
        private DataTable _dtList_02 = null; //조회 데이터 리스트
        private DataTable _dtList_03 = null; //조회 데이터 리스트
        private DataTable _dtList_04 = null; //조회 데이터 리스트
        private Stream responseStream_tmp = null;
        private string part_type = null;
        private string _pFile_Attr = string.Empty;

        public InspectFinalApprovalRegister()
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
                //if (CoFAS_DevExpressManager.ShowQuestionMessage("종료 하겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                {
                    pFormClosingEventArgs.Cancel = true;
                    return;
                }

                //그리드 작업 정보 확인 하기
                // if (_gdSUB_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                // {
                //     //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
                //     if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_EXIT_QUESTION) == DialogResult.No)
                //     {
                //         pFormClosingEventArgs.Cancel = true;
                //         return;
                //     }
                // }
                // else
                // {
                //     //if (CoFAS_DevExpressManager.ShowQuestionMessage("종료 하겠습니까?") == DialogResult.No)
                //     if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                //     {
                //         pFormClosingEventArgs.Cancel = true;
                //         return;
                //     }
                // }
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

                //이벤트 해제
                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;
                //
                // _gdSUB_VIEW.InitNewRow -= _gdSUB_VIEW_InitNewRow;
                // _luT_PROCESS._OnOpenClick -= _luT_PROCESS_OnOpenClick;

                //    CoFAS_DevExpressManager._OnButtonPressed -= CoFAS_DevExpressManager__OnButtonPressed;

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
                _pnLeft.Width = 900;
                _pnRight.Visible = false;

                //버튼 폰트색상 및 배경색상
                _ucbtINSPECT_REQUEST.BackColor = Color.LightBlue;

                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_IP_PORT = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PW = MainForm.UserEntity.FTP_PW;

                _pWINDOW_NAME = this.Name;
                _pMENU_NAME = this.Text;

                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_IP_PORT = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PATH = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
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

                //메뉴 화면 엔티티 설정
                _pInspectFinalApprovalRegisterEntity = new InspectFinalApprovalRegisterEntity();
                //_pProcessCodeMstRegisterEntity.CORP_CODE = _pCORP_CODE;
                _pInspectFinalApprovalRegisterEntity.USER_CODE = _pUSER_CODE;
                _pInspectFinalApprovalRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pInspectFinalApprovalRegisterEntity.WINDOW_NAME = _pWINDOW_NAME;
                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //_sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
                _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
                //그리드 설정
                InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 
                //메인 그리드
                _gdMAIN.DataSource = null;

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pInspectFinalApprovalRegisterEntity.CRUD = "";

                //MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                //SubFind_DisplayData();

                if (_pFirstYN)
                {
                    //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

                    //Sheet_Info_Sheet_Data();  // 데이터 바인딩
                    //그리드 버튼추가 시 클릭 이벤트 처리 
                    // CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;

                    //조회조건 영역 
                    //_luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "");

                    _luT_PART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "INSPECT_PART_TYPE", "", "", "").Tables[0], 0, 0, "",true);
                    _luT_PART_TYPE.ItemIndex = 0;

                    _luT_INSPECT_APPROVAL.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "INSPECT_APPROVAL_YN", "", "", "").Tables[0], 0, 0, "",true);
                    _luT_INSPECT_APPROVAL.ItemIndex = 0;
                    _pInspectFinalApprovalRegisterEntity.FILE_NAME = "";
                    part_type = _luT_PART_TYPE.GetValue();
                    SheetFind_DisplayData();  // DB에 저장된 해당 화면의 엑셀파일 불러오기

                    _pFirstYN = false;

                }

            }
            catch (Exception e)
            {

            }
        }

        private void _luT_PART__OnOpenClick(object sender, EventArgs e)
        {

        }

        // 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                if (_luT_APPROVAL_DATE.FromDateTime > _luT_APPROVAL_DATE.ToDateTime)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 일자를 확인해 주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_SEARCH_DATE);
                }
                else
                {
                    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);



                    _pInspectFinalApprovalRegisterEntity.CRUD = "R";
                    _pInspectFinalApprovalRegisterEntity.DATE_FROM = DateTime.Parse(_luT_APPROVAL_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luTORDER_DATE.FromDateTime).Replace("-", "").Substring(0, 8);//
                    _pInspectFinalApprovalRegisterEntity.DATE_TO = DateTime.Parse(_luT_APPROVAL_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luTORDER_DATE.ToDateTime).Replace("-", "").Substring(0, 8);//
                    //_pInspectFinalApprovalRegisterEntity.VEND_NAME = _luTVEND.NameText;
                    //_pInspectFinalApprovalRegisterEntity.VEND_CODE = _luTVEND.CodeText;
                    _pInspectFinalApprovalRegisterEntity.PART_NAME = _luT_PART.NameText;
                    _pInspectFinalApprovalRegisterEntity.PART_CODE = _luT_PART.CodeText;
                    //_pInspectFinalApprovalRegisterEntity.USE_YN = _luTUSE_YN.GetValue();
                    _pInspectFinalApprovalRegisterEntity.PART_TYPE = _luT_PART_TYPE.GetValue();
                    _pInspectFinalApprovalRegisterEntity.APPROVAL_YN = _luT_INSPECT_APPROVAL.GetValue();
                    _ckDelayChk.Checked = false;
                    //
                    part_type = _luT_PART_TYPE.GetValue();
                    MainFind_DisplayData();


                    //DisplayMessage("조회 되었습니다.");
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
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);


                _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.SelectedCells);

                InputData_Save(_pInspectFinalApprovalRegisterEntity);

                //InitializeControl2();
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

                //InputData_Save(_pMaterialInRegisterEntity);
                InitializeControl();
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
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

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
        #endregion

        #region ○ 내보내기 버튼 클릭시 처리하기
        private void Form_ExportButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (_gdMAIN_VIEW.FocusedRowHandle > -1)
                {
                    SaveFileDialog mDlg = new SaveFileDialog();
                    mDlg.InitialDirectory = Application.StartupPath;
                    mDlg.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    mDlg.FilterIndex = 1;
                    if (mDlg.ShowDialog() == DialogResult.OK)
                    {
                        //_sdMAIN.SaveDocumentAs();
                        _sdMAIN.SaveDocument(mDlg.FileName);
                        CoFAS_DevExpressManager.ShowInformationMessage("저장이 완료 되었습니다.");
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
                //{
                //    return;
                //}
                //else
                //{
                
                InitializeControl();
                part_type = _luT_PART_TYPE.GetValue();
                SheetFind_DisplayData();  // DB에 저장된 해당 화면의 엑셀파일 불러오기
                                          // Sheet_Info_Sheet_Data();  // 데이터 바인딩

                //DisplayMessage("초기화했습니다.");
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

        #region ○ 화면 설정 버튼 클릭시 처리하기 - 언어 및 화면 컨트롤러 명칭 변경 설정
        private void Form_SettingButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
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
        #region ○ 저장 - InputData_Save(DataTable dtSave)

        private void InputData_Save(InspectFinalApprovalRegisterEntity _pInspectFinalApprovalRegisterEntity)
        {
            try
            {


                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.Yes)
                 if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                {
                    //실제데이터
                    IWorkbook workbook = _sdMAIN.Document;
                    Worksheet sheet_1 = workbook.Worksheets[0];
                    string approval_chk = "";
                    //sheet_1.Cells.EndUpdate();
                    //시험상태체크 : 완료만 저장가능
                    if (_pInspectFinalApprovalRegisterEntity.INSPECT_STATUS != "QC010004")
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("시험이 미완료 상태입니다.");
                        return;
                    }
                    //2019.01.10
                    //보류에 체크가 됬으면 보류만 업데이트
                    //보류체크를 하고 저장할 때는 승인이 한번이라도 된상태여야 가능(approval = 승인자 서명)
                    //보류를 승인으로 바꾸는 경우는 시험성적서 선택후 그냥 저장 -> 승인이 한번도 된상태(서명된)에서만 승인으로 바뀜
                    //                                                          -> 승인이 없는 상태에서 저장누르면 기존 프로시져
                    if(_ckDelayChk.Checked == true)
                    {
                        if (_pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER == "")
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage("보류는 승인상태에서만 진행이 가능합니다.");
                            return;
                        }
                        if (CoFAS_DevExpressManager.ShowQuestionMessage("상태를 보류로 변경하시겠습니까?") == DialogResult.Yes)
                        {

                            _pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER = "QC020002"; //QC020001 : 승인, QC020002 : 미승인, QC030003 : 보류
                            isError = new InspectFinalApprovalRegisterBusiness().InspectFinalApprovalRegister_Info_Delay_Save(_pInspectFinalApprovalRegisterEntity, sheet_1);
                            // 자재입고
                            if (isError)
                            {
                                //오류 발생.
                                //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                            }
                            else
                            {
                                if (part_type == "1005")
                                {
                                    InspectDoc_Create();
                                }
                                _pLocation_Code = _pInspectFinalApprovalRegisterEntity.RTN_KEY;  //저장 위치
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                Form_SearchButtonClicked(null, null);

                                part_type = _luT_PART_TYPE.GetValue();
                                SheetFind_DisplayData();

                            }
                        }
                        _pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER = "";
                        _pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER_SIGN = "";
                        return;
                    }
                    else
                    {
                        
                        if ((_pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER_SIGN != "") && (_pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER== "QC020002"))
                        {

                            
                            if (CoFAS_DevExpressManager.ShowQuestionMessage("상태를 승인으로 변경하시겠습니까?") == DialogResult.Yes)
                            {
                                _pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER = "QC020001"; //QC020001 : 승인, QC020002 : 미승인, QC030003 : 보류
                                isError = new InspectFinalApprovalRegisterBusiness().InspectFinalApprovalRegister_Info_Delay_Save(_pInspectFinalApprovalRegisterEntity, sheet_1);
                                // 자재입고
                                if (isError)
                                {
                                    //오류 발생.
                                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                                }
                                else
                                {
                                    if (part_type == "1005")
                                    {
                                        InspectDoc_Create();
                                    }
                                    _pLocation_Code = _pInspectFinalApprovalRegisterEntity.RTN_KEY;  //저장 위치
                                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                    Form_SearchButtonClicked(null, null);

                                    part_type = _luT_PART_TYPE.GetValue();
                                    SheetFind_DisplayData();

                                }
                            }
                            _pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER = "";
                            _pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER_SIGN = "";
                            return;
                        }
                      
                    }

                    //승인체크 : 승인에 체크가되야 저장
                    if (part_type == "1001")
                    {
                        approval_chk=sheet_1.GetCellValue(14, 29).ToString();
                    }
                    else if (part_type == "1003")
                    {
                        approval_chk = sheet_1.GetCellValue(14, 29).ToString();
                    }
                    else if (part_type == "1004")
                    {
                        approval_chk = sheet_1.GetCellValue(11, 40).ToString();
                    }
                    else if (part_type == "1005")
                    {
                        approval_chk = sheet_1.GetCellValue(9, 33).ToString();
                    }

                    if (approval_chk == "")
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("먼저 승인상태를 선택해주세요.");
                        return;
                    }

                    _pInspectFinalApprovalRegisterEntity.CRUD = "U";


                    _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.SelectedCells);
                    //결과 저장용 시트
                    Worksheet sheet_2 = workbook.Worksheets["저장용 데이터"];
                    /*
                    pInspectFinalApprovalRegisterEntity.PART_CODE
                    pInspectFinalApprovalRegisterEntity.PART_NAME
                    pInspectFinalApprovalRegisterEntity.INSPECT_STATUS
                    pInspectFinalApprovalRegisterEntity.INSPECT_ID
                    pInspectFinalApprovalRegisterEntity.INSPECT__DATE
                    pInspectFinalApprovalRegisterEntity.INSPECT_SEQ
                    pInspectFinalApprovalRegisterEntity.VEND_PART_CODE
                    pInspectFinalApprovalRegisterEntity.PART_TYPE
                    pInspectFinalApprovalRegisterEntity.REFERENCE_ID
                    pInspectFinalApprovalRegisterEntity.MAKE_VEND
                    pInspectFinalApprovalRegisterEntity.MAKE_VEND_NAME
                    pInspectFinalApprovalRegisterEntity.VEND_CODE
                    pInspectFinalApprovalRegisterEntity.VEND_NAME
                    pInspectFinalApprovalRegisterEntity.REQUEST_DEPT
                    pInspectFinalApprovalRegisterEntity.CODE_NAME
                    pInspectFinalApprovalRegisterEntity.INOUT_DATE
                    pInspectFinalApprovalRegisterEntity.INOUT_QTY
                        */
                    //_pInspectFinalApprovalRegisterEntity.PACKING_REMARK  = sheet_1.GetCellValue(4, 6).TextValue;
                    //_pInspectFinalApprovalRegisterEntity.SAMPLE_DATE     = sheet_1.GetCellValue(4, 7).TextValue;
                    //_pInspectFinalApprovalRegisterEntity.SAMPLE_LOCATION = sheet_1.GetCellValue(6, 4).TextValue;
                    //_pInspectFinalApprovalRegisterEntity.SAMPLE_USER     = sheet_1.GetCellValue(6, 5).TextValue;
                    //_pInspectFinalApprovalRegisterEntity.SAMPLE_METHOD   = sheet_1.GetCellValue(6, 6).TextValue;
                    //_pInspectFinalApprovalRegisterEntity.SAMPLE_QTY      = sheet_1.GetCellValue(6, 7).TextValue;
                    /*
                pInspectFinalApprovalRegisterEntity.MAKE_NO
                pInspectFinalApprovalRegisterEntity.STANDARD
                pInspectFinalApprovalRegisterEntity.REQUEST_DATE
                pInspectFinalApprovalRegisterEntity.REQUEST_USER
                pInspectFinalApprovalRegisterEntity.END_DATE
                pInspectFinalApprovalRegisterEntity.TOTAL_RESULT
                pInspectFinalApprovalRegisterEntity.TOTAL_DATE
                pInspectFinalApprovalRegisterEntity.TOTAL_USER
                pInspectFinalApprovalRegisterEntity.COMPLETE_YN
                pInspectFinalApprovalRegisterEntity.REMARK
                pInspectFinalApprovalRegisterEntity.USER_YN
                */

                    isError = new InspectFinalApprovalRegisterBusiness().InspectFinalApprovalRegister_Info_Mst_Save(_pInspectFinalApprovalRegisterEntity, sheet_1);
                    // 자재입고
                    if (isError)
                    {
                        //오류 발생.
                        //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    }
                    else
                    {

                        // isError = new InspectFinalApprovalRegisterBusiness().InspectFinalApprovalRegister_Info_Detail_Save(_pInspectFinalApprovalRegisterEntity, sheet_2);
                        // if (isError)
                        // {
                        //     //오류 발생.
                        //     //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                        //     CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                        // }
                        // else
                        // {
                        //     _pLocation_Code = _pInspectFinalApprovalRegisterEntity.RTN_KEY;  //저장 위치
                        //     Form_SearchButtonClicked(null, null);
                        //
                        //     //정상 처리
                        //     //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                        //     CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                        //     part_type = _luT_PART_TYPE.GetValue();
                        //     SheetFind_DisplayData();
                        //     //InitializeControl(false);
                        //
                        // }
                        //자재일경우만
                        //추후 전부다 할경우, 조건 없애기
                        if (part_type == "1005")
                        {
                            InspectDoc_Create();
                        }
                        _pLocation_Code = _pInspectFinalApprovalRegisterEntity.RTN_KEY;  //저장 위치
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                        Form_SearchButtonClicked(null, null);


                       
                        part_type = _luT_PART_TYPE.GetValue();
                        SheetFind_DisplayData();

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
        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GridView gv = sender as GridView;

            _pInspectFinalApprovalRegisterEntity.INSPECT_ID = gv.GetFocusedRowCellValue("INSPECT_ID").ToString();
            _pInspectFinalApprovalRegisterEntity.INSPECT_STATUS = gv.GetFocusedRowCellValue("INSPECT_STATUS").ToString();
            _pInspectFinalApprovalRegisterEntity.FILE_NAME = gv.GetFocusedRowCellValue("FILE_NAME").ToString();
            part_type = gv.GetFocusedRowCellValue("PART_TYPE").ToString();
            _pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER_SIGN = gv.GetFocusedRowCellValue("APPROVAL_SIGN").ToString();
            _pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER = gv.GetFocusedRowCellValue("APPROVAL").ToString();
            _ckDelayChk.Checked = false;
            SheetFind_DisplayData();
            _pInspectFinalApprovalRegisterEntity.PART_TYPE = part_type;
            Sheet_Info_Sheet_Data();  // 데이터 바인딩
        }

        #endregion
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
                //데이터 영역
                //_luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "");

                _luT_PART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PART_TYPE", "", "", "").Tables[0], 0, 0, "",true);
                _luT_PART_TYPE.ItemIndex = 0;

                _luT_INSPECT_APPROVAL.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "INSPECT_APPROVAL_YN", "", "", "").Tables[0], 0, 0, "",true);
                _luT_INSPECT_APPROVAL.ItemIndex = 0;


                _luT_APPROVAL_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luT_APPROVAL_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정

                _luT_PART.CodeText = "";
                _luT_PART.NameText = "";
                _pInspectFinalApprovalRegisterEntity.FILE_NAME = "";
                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //dxValidationProvider.SetValidationRule(_luGRID_NAME, NotEmptyValidationRule);
                //dxValidationProvider.SetValidationRule(_luGRIDVIEW_NAME, NotEmptyValidationRule);
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

        private void InspectDoc_Create()
        {

            //_sdMAIN = new CORE.BaseControls.ucSpreadSheetControl();1
            string strFTP_PATH = "";
            string strFILE_NAME = _pFILE_NAME;// _pWorkOrderInfoPopupEntity.FILE_NAME;

            // strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW",_pWINDOW_NAME);
            string curfile = "ftp://";// Application.StartupPath + "\\Template\\" + strFILE_NAME;
            CoFAS_FTPUtilManager qFTPUtil;

            byte[] data = _sdMAIN.SaveDocument(DocumentFormat.Xlsx); // 일반 컨트롤 일때 : DocumentFormat.Xls   // UC일때,  enFileFormat.Xls

            strFTP_PATH = string.Format(@"{0}{1}/", _pFTP_PATH, "INSPECT");
            // _pWorkRequestRegisterEntity.PRODUCTION_FILE = "ftp://"+strFTP_PATH +_ptime + "_" + _pWorkRequestRegisterEntity.PRODUCTION_ORDER_ID+'.'+ _pFile_Attr;
            //서버주소는 제외
            // string _ptime = System.DateTime.Now.ToString("yyyyMMddHHmmss");
            // if(_pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST== "PT040001")
            //     _pucWorkOrderDocRegPopupEntity.FILE_NAME = _ptime + "_" + pPRODUCTION_ORDER_ID + "_제조." + _pFile_Attr;
            // else
            //     _pucWorkOrderDocRegPopupEntity.FILE_NAME = _ptime + "_" + pPRODUCTION_ORDER_ID + "_포장." + _pFile_Attr;
            //
            //파일업로드
            //if (_pMaterialInspectRegisterEntity.CRUD == "C") // 업데이트
            //{
            //업데이트는, 이전파일명으로 삭제하기
            //qFileName -> _pFTP_BEFROE_FILENAME
            //if (CoFAS_FTPManager.FTPDelete(qFileName, strFTP_PATH + _pSheetInfoRegisterEntity.WINDOW_NAME + "/", _pFTP_ID, _pFTP_PW))
            //qFTPUtil = new CoFAS_FTPUtilManager(strFTP_PATH, _pFTP_ID, _pFTP_PW);
            qFTPUtil = new CoFAS_FTPUtilManager(_pFTP_PATH, _pFTP_ID, _pFTP_PW);

            //_pFTP_BEFROE_FILENAME

            if (CoFAS_FTPManager.FTPDelete(_pInspectFinalApprovalRegisterEntity.FILE_NAME, _pFTP_PATH, _pFTP_ID, _pFTP_PW))
            {
                if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory(_pInspectFinalApprovalRegisterEntity.FILE_NAME, _pFTP_ID, _pFTP_PW, _pFTP_PATH, "", data)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                {
                    //oFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                    //  CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                }

                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);

                }
            }
            //파일이 없는지 체크
            else if (!qFTPUtil.IsFTPFileExsit(_pFTP_PATH + _pInspectFinalApprovalRegisterEntity.FILE_NAME))
            {
                //정상 처리

                if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory(_pInspectFinalApprovalRegisterEntity.FILE_NAME, _pFTP_ID, _pFTP_PW, _pFTP_PATH, "", data)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                    //  CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                }
            }
            else
            {
                //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
            }

            // }
        }

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _ckDelayChk.Checked = false;
                _pInspectFinalApprovalRegisterEntity.FILE_NAME = "";
                SheetFind_DisplayData();  // DB에 저장된 해당 화면의 엑셀파일 불러오기

                _dtList = new InspectFinalApprovalRegisterBusiness().Sample_Info(_pInspectFinalApprovalRegisterEntity);
                if (_pInspectFinalApprovalRegisterEntity.PART_TYPE != "")
                {
                    if (_pInspectFinalApprovalRegisterEntity.CRUD == "")
                        _dtList.Rows.Clear();
                    else
                    {
                        IWorkbook workbook = _sdMAIN.Document;
                        Worksheet sheet_1 = workbook.Worksheets["데이터"];
                        Range data_range = sheet_1.GetDataRange();
                        sheet_1.Clear(data_range);
                    }
                }


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("INSPECT_ID", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;
                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtList.Rows.Clear();
                    //Form_InitialButtonClicked(null, null);
                    _gdMAIN.DataSource = null;
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


        #region 시험의뢰 불러오기
        private void _ucbtINSPECT_REQUEST_Click(object sender, EventArgs e)
        {
            try
            {
                string part_type = "1005";
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.ARRAY = new object[2] { "Material_Code", _luT_PART.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.ARRAY_CODE = new object[3] { _luT_PART.CodeText, _luT_PART.NameText, part_type };
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.QC.UserForm.frmCommonPopup("InspectRequest"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luT_PART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["ORDER_ID"].ToString();
                    _luT_PART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion
        #region ○ 시트조회 - SheetFind_DisplayData()

        private void SheetFind_DisplayData()

        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                string strFTP_PATH = "";
                string strUSE_TYPE = "";
                string strFILE_NAME = "";

                if (part_type != "")
                {
                    _pInspectFinalApprovalRegisterEntity.CRUD = "R";
                    //string part_type = _luT_PART_TYPE.GetValue();
                    string p_window_name = "";
                    if (part_type == "1001")
                    {
                        p_window_name = "ProductInspectRegister";
                    }
                    else if (part_type == "1003")
                    {
                        p_window_name = "SemiProductInspectRegister";
                    }
                    else if (part_type == "1004")
                    {
                        p_window_name = "RawMaterialInspectRegister";
                    }
                    else if (part_type == "1005")
                    {
                        p_window_name = "MaterialInspectRegister";
                    }
                    //조회할거 프로시져
                    _dtList = new InspectFinalApprovalRegisterBusiness().Sheet_Info_Sheet(_pInspectFinalApprovalRegisterEntity.CRUD, p_window_name, _pInspectFinalApprovalRegisterEntity.LANGUAGE_TYPE);   //엑셀 시트 조회하기

                    //엑셀서식관리 되면 다시 설정하기

                    strUSE_TYPE = _dtList.Rows[0]["USE_TYPE"].ToString();
                    strFILE_NAME = _dtList.Rows[0]["FILE_NAME"].ToString();

                    string[] tmp = strFILE_NAME.Split('.');
                    _pFile_Attr = tmp[tmp.Length - 1];
                    // strUSE_TYPE = "VIEW";
                    // strFILE_NAME = "InspectFinalApprovalRegister_Sample_v1.xlsx";

                    switch (strUSE_TYPE)
                    {

                        case "PRINT":
                            //strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "ORDER_FORM", _pWINDOW_NAME);
                            strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "ORDER_FORM", p_window_name);
                            break;
                        case "VIEW":
                            //strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pWINDOW_NAME);
                            strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", p_window_name);
                            break;
                        case "REGIT":
                            //strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pWINDOW_NAME);
                            strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", p_window_name);
                            break;

                    }

                    string curfile = Application.StartupPath + "\\Template\\" + strFILE_NAME;
                    string[] tmp2;

                    // 같은 것이 있으면, 폴더에서 해당 파일명을 불러와서 SpreadSheet에 띄우기 / 없으면, 폴더에 다운
                    if (_pInspectFinalApprovalRegisterEntity.FILE_NAME == "")

                    {
                    if (!File.Exists(curfile))
                        {
                            CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW, curfile, false);

                        }
                        //using (FileStream file = File.OpenWrite(curfile))
                        using (Stream file = File.Open(curfile, FileMode.Open))
                        {
                            if (file != null)

                            {
                                _sdMAIN.LoadDocument(file, DocumentFormat.Xlsx);

                                // 일반 컨트롤 일때 : DocumentFormat.Xls   // UC일때,  enFileFormat.Xls


                                try
                                {
                                    _sdMAIN.CellBeginEdit -= _sdMAIN_CellBeginEdit;
                                    _sdMAIN.CellBeginEdit += _sdMAIN_CellBeginEdit;

                                    _sdMAIN.PopupMenuShowing -= _sdMAIN_PopupMenuShowing;
                                    _sdMAIN.PopupMenuShowing += _sdMAIN_PopupMenuShowing;
                                }
                                catch
                                {
                                    _sdMAIN.CellBeginEdit += _sdMAIN_CellBeginEdit;
                                    _sdMAIN.PopupMenuShowing += _sdMAIN_PopupMenuShowing;
                                }


                            }
                            else
                            {
                                _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.Default);
                                _sdMAIN.CreateNewDocument();
                            }
                        }
                    }
                    else
                    //저장된거일경우, 자재만 해당
                    {
                        //확장자 자르기
                        tmp = _pInspectFinalApprovalRegisterEntity.FILE_NAME.Split('.');
                        _pFile_Attr = tmp[tmp.Length - 1];

                        //파일명 자르기
                        tmp2 = _pInspectFinalApprovalRegisterEntity.FILE_NAME.Split('/');
                        strFTP_PATH = string.Format(@"{0}{1}/", _pFTP_PATH, "INSPECT");
                        strFILE_NAME = tmp2[tmp2.Length - 1];

                        using (Stream file = CoFAS_FTPManager.FTPFileBinding(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW))
                        {
                            if (file != null)

                            {
                                _sdMAIN.LoadDocument(file, DocumentFormat.Xlsx);

                                // 일반 컨트롤 일때 : DocumentFormat.Xls   // UC일때,  enFileFormat.Xls


                                try
                                {
                                    _sdMAIN.CellBeginEdit -= _sdMAIN_CellBeginEdit;
                                    _sdMAIN.CellBeginEdit += _sdMAIN_CellBeginEdit;

                                    _sdMAIN.PopupMenuShowing -= _sdMAIN_PopupMenuShowing;
                                    _sdMAIN.PopupMenuShowing += _sdMAIN_PopupMenuShowing;
                                }
                                catch
                                {
                                    _sdMAIN.CellBeginEdit += _sdMAIN_CellBeginEdit;
                                    _sdMAIN.PopupMenuShowing += _sdMAIN_PopupMenuShowing;
                                }


                            }
                            else
                            {
                                _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.Default);
                                _sdMAIN.CreateNewDocument();
                            }
                        }
                    }
            }
                else
                {
                    _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.Default);
                    _sdMAIN.CreateNewDocument();
                }
                //  }
                //  else
                //  {
                //      CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                //  }

                //_ojList = new ProcessMaterialStockStatusBusiness().Sheet_Info_Sheet(_pProcessMaterialStockStatusEntity);

                //if (_ojList != null)
                //{
                //    _sdMAIN.LoadDocument((byte[])_ojList, DocumentFormat.Xlsx);    // 일반 컨트롤 일때 : DocumentFormat.Xls   // UC일때,  enFileFormat.Xls
                //}
                //else
                //{
                //    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
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

        private void _sdMAIN_PopupMenuShowing(object sender, DevExpress.XtraSpreadsheet.PopupMenuShowingEventArgs e)
        {
            IWorkbook workbook = _sdMAIN.Document;
            Worksheet activeSheet = workbook.Worksheets.ActiveWorksheet;
            string Select_PartType = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_TYPE").ToString();
            if (e.MenuType == SpreadsheetMenuType.Cell)
            {
                //제품 : 1001
                if (Select_PartType == "1001")
                {
                    if ((_sdMAIN.ActiveCell == activeSheet.Cells["O30"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["O31"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["P30"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["P31"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["Q30"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["Q31"]))
                    {
                        _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                      //  e.Menu.RemoveMenuItem(SpreadsheetCommandId.pick);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Add(myItem);
                    }
                    else
                    {
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Remove(myItem);
                    }
                }
                //반제품 : 1003
                else if (Select_PartType == "1003")
                {

                    if ((_sdMAIN.ActiveCell == activeSheet.Cells["O30"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["O31"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["P30"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["P31"]))
                    {
                        _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);

                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Add(myItem);
                    }
                    else
                    {
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Remove(myItem);
                    }
                }
                //원료 : 1004
                else if (Select_PartType == "1004")
                {
                    //if ((_sdMAIN.ActiveCell == activeSheet.Cells["H28"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["I28"]) )
                    if (
                        (_sdMAIN.ActiveCell == activeSheet.Cells["L41"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["M41"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["N41"])||
                        (_sdMAIN.ActiveCell == activeSheet.Cells["L42"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["M42"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["N42"])
                        )

                    {
                        _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
                    
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);

                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Add(myItem);
                    }
                    else
                    {
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Remove(myItem);
                    }
                }
                //자재 : 1005
                else if (Select_PartType == "1005")
                {
                    if ((_sdMAIN.ActiveCell == activeSheet.Cells["J34"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["J35"]))
                    {
                        _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);

                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Add(myItem);
                    }
                    else
                    {
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("승인", new EventHandler(InsertSignImage));
                        e.Menu.Items.Remove(myItem);

              
                    }
                }
               
                
                
            }

        }

        public void InsertSignImage(object sender, EventArgs e)
        {

            if (CoFAS_DevExpressManager.ShowQuestionMessage("승인하시겠습니까?") == DialogResult.No)
            {
                return;
            }
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pInspectFinalApprovalRegisterEntity.CRUD = "R";
                _dtList = new InspectFinalApprovalRegisterBusiness().GetUserImage("R", _pInspectFinalApprovalRegisterEntity.USER_CODE);
                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                {
                    IWorkbook workbook = _sdMAIN.Document;
                    Worksheet sheet_0 = workbook.Worksheets[0];
                    Image img = null;
                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList.Rows[0]["USER_IMAGE"]);
                    Stream memstr = new MemoryStream((byte[])_dtList.Rows[0]["USER_IMAGE"]);
                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);

                    string Select_PartType = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_TYPE").ToString();
                    //이미지 넣을 범위
                    //제품 : 1001
                    if(Select_PartType=="1001")
                    {
                        sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["O30:Q31"]);
                        sheet_0.Cells["O30"].SetValue(_pUSER_CODE);
                        _pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER_SIGN = _pUSER_CODE;
                        //sheet_1.GetCellValue(14, 29).ToString();
                        //sheet_0.Cells["O30"].DisplayText();
                    }
                    //반제품 : 1003
                    else if (Select_PartType == "1003")
                    {
                        sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["O30:P31"]);
                        sheet_0.Cells["O30"].SetValue(_pUSER_CODE);
                        //pDataParametersA[3].Value = sheet_1.GetCellValue(14, 29).ToString();
                        _pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER_SIGN= _pUSER_CODE;
                    }
                    //원료 : 1004
                    else if (Select_PartType == "1004")
                    {
                        sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["L41:N42"]);
                        sheet_0.Cells["L41"].SetValue(_pUSER_CODE);
                        // pDataParametersA[3].Value = sheet_1.GetCellValue(7, 27).ToString();
                        _pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER_SIGN = _pUSER_CODE;
                    }
                    //자재 : 1005
                    else if (Select_PartType == "1005")
                    {
                        sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["J34:J35"]);
                        sheet_0.Cells["J34"].SetValue(_pUSER_CODE);
                        //pDataParametersA[3].Value = sheet_1.GetCellValue(9, 33).ToString();
                        _pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER_SIGN = _pUSER_CODE;
                    }
                  
                }
                else
                {
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

        private void _sdMAIN_CellBeginEdit(object sender, SpreadsheetCellCancelEventArgs e)
        {
           // string part_type = _luT_PART_TYPE.GetValue();

             if (part_type != "")
            {
                IWorkbook workbook = _sdMAIN.Document;
                Worksheet sheet_0 = workbook.Worksheets[0];
                Worksheet sheet_2 = workbook.Worksheets[2];
                Range rg;
                Range rg2;
           
                if (part_type == "1001")    //제품
                {/*
                sheet_0.Range["O30:Q31"].Protection.Locked = false;

                if (!sheet_0.IsProtected)
                    sheet_0.Protect("password", WorksheetProtectionPermissions.Default);
                    */

                    rg = sheet_2.Range["J2:J4"];    //판정유무
                    sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["B34"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg));
                    sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["F11:F27"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg));
                    rg2 = sheet_2.Range["K2:K3"];//승인여부
                    sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["O30:Q31"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg2));

                    if (!((e.ColumnIndex == 14 && e.RowIndex == 29) || (e.ColumnIndex == 14 && e.RowIndex == 30) || (e.ColumnIndex == 15 && e.RowIndex == 29) || (e.ColumnIndex == 15 && e.RowIndex == 30) || (e.ColumnIndex == 16 && e.RowIndex == 29) || (e.ColumnIndex == 16 && e.RowIndex == 30)))
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("데이터 수정은 불가하고 승인만 가능합니다.");
                        e.Cancel = true;
                    }

                }
                else if (part_type == "1003")   //반제품
                {
                    /*
                    sheet_0.Range["O30:P31"].Protection.Locked = false;

                    if (!sheet_0.IsProtected)
                        sheet_0.Protect("password", WorksheetProtectionPermissions.Default);
                        */
                    rg = sheet_2.Range["J2:J4"];    //판정유무
                    sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["B34"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg));
                    sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["F11:F27"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg));
                    rg2 = sheet_2.Range["K2:K3"];//승인여부
                    sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["O30:P31"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg2));


                    if (!((e.ColumnIndex == 14 && e.RowIndex == 29) || (e.ColumnIndex == 14 && e.RowIndex == 30) || (e.ColumnIndex == 15 && e.RowIndex == 29) || (e.ColumnIndex == 15 && e.RowIndex == 30)))
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("데이터 수정은 불가하고 승인만 가능합니다.");
                        e.Cancel = true;
                    }

                }
                else if (part_type == "1004")   //원자재
                {



                    /*
                    sheet_0.Range["H28:H28"].Protection.Locked = false;

                    if (!sheet_0.IsProtected)
                        sheet_0.Protect("password", WorksheetProtectionPermissions.Default);
                        */
                    rg = sheet_2.Range["J2:J4"];    //판정유무
                    sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["D40"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg));
                    sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["I13:K25"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg));
                    rg2 = sheet_2.Range["K2:K3"];//승인여부
                    sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["H28:I28"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg2));

                    if (!
                        (
                        (e.ColumnIndex == 11 && e.RowIndex == 40) || (e.ColumnIndex == 12 && e.RowIndex == 40) || (e.ColumnIndex == 13 && e.RowIndex == 40)||
                        (e.ColumnIndex == 11 && e.RowIndex == 41) || (e.ColumnIndex == 12 && e.RowIndex == 41) || (e.ColumnIndex == 13 && e.RowIndex == 41)
                        )
                        )
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("데이터 수정은 불가하고 승인만 가능합니다.");
                        e.Cancel = true;
                    }
                }
                else if (part_type == "1005")   //부자재
                {
                    /*

                        sheet_0.Range["J34:J35"].Protection.Locked = false;

                        if (!sheet_0.IsProtected)
                            sheet_0.Protect("password", WorksheetProtectionPermissions.Default);
                          }
                */
                    rg = sheet_2.Range["J2:J4"];    //판정유무
                    sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["C32"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg));
                    sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["F8:F13"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg));
                    rg2 = sheet_2.Range["K2:K3"];//승인여부
                    sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["J34:J35"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg2));

                    if (!((e.ColumnIndex == 9 && e.RowIndex == 33) || (e.ColumnIndex == 9 && e.RowIndex == 34)))
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("데이터 수정은 불가하고 승인만 가능합니다.");
                        e.Cancel = true;
                    }
                }
            }

        }

        #region ○ new 시트에 서브그리드에서 선택한 프로시저 정보 바인딩 - SubFind_DisplayData(string strWINDOW_NAME, string strFILE_NAME)

        #region ○ 화면명과 선택한 발주번호에 맞는 정보 바인딩 - Sheet_Info_Sheet_Data()  //추가

        private void Sheet_Info_Sheet_Data()   //추가
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                // _pInspectFinalApprovalRegisterEntity.ORDER_ID = _luORDER_ID.Text.ToString();

                IWorkbook workbook = _sdMAIN.Document;

                using (DBManager pDBManager = new DBManager())
                {

                    // _dtList = new MaterialOrderRegisterProvider(pDBManager).Sheet_Info_Sheet_Data(_pInspectFinalApprovalRegisterEntity);
                    _dsList = new InspectFinalApprovalRegisterProvider(pDBManager).InspectFinalApprovalRegister_info_ExcelBinding(_pInspectFinalApprovalRegisterEntity);
                    //품목정보용
                    _dtList = _dsList.Tables[0];
                    //시험항목검사결과(엑셀바인딩용)
                    _dtList_01 = _dsList.Tables[1];
                    _pInspectFinalApprovalRegisterEntity.dtListCnt = _dtList_01.Rows.Count;
                    if (_dtList != null && _dtList.Rows.Count > 0)
                    {

                        Worksheet sheet_1 = workbook.Worksheets["데이터"];
                        Worksheet sheet_0 = workbook.Worksheets[0];
                        Worksheet sheet_2 = workbook.Worksheets["저장용 데이터"];
                        Range data_range = sheet_1.GetDataRange();
                        sheet_1.Clear(data_range);
                        ExternalDataSourceOptions dsOptions = new ExternalDataSourceOptions();
                        dsOptions.ImportHeaders = true;
                        /*
                        string part_type = _luT_PART_TYPE.GetValue();
                        if (part_type == "1001")
                        {
                            sheet_0.Range["O30:Q31"].Protection.Locked = false;

                            if (!sheet_0.IsProtected)
                                sheet_0.Protect("password", WorksheetProtectionPermissions.Default);
                        }
                        else if (part_type == "1003")
                        {
                            sheet_0.Range["O30:P31"].Protection.Locked = false;

                            if (!sheet_0.IsProtected)
                                sheet_0.Protect("password", WorksheetProtectionPermissions.Default);
                        }
                        else if (part_type == "1004")
                        {
                            sheet_0.Range["H28:H28"].Protection.Locked = false;

                            if (!sheet_0.IsProtected)
                                sheet_0.Protect("password", WorksheetProtectionPermissions.Default);
                        }
                        else if (part_type == "1005")
                        {
                            sheet_0.Range["J34:J35"].Protection.Locked = false;

                            if (!sheet_0.IsProtected)
                                sheet_0.Protect("password", WorksheetProtectionPermissions.Default);
                        }
                        */

                        /* 
                         * 발주서 양식에 데이터를 바인딩할 때, row와 column의 인덱스 또는 범위(range)를 직접 지정하여 바인딩해야 한다.
                         * 현재, 발주번호 1건에 1개의 품목이 정의된 상태에서는 'data' 시트에 '기본 정보'와 '품목 조회 부분'을 같이 불러왔다. 
                         * 그리고 엑셀의 참조 기능을 이용하여 발주서 양식을 완성했다. 
                         * 
                         * 하지만, 발주번호 1건에 여러 개의 품목이 정의된 상태는 바인딩 방법을 다르게 해야 한다.
                         * DataSet으로 '기본 정보'와 '품목 조회 부분'을 따로 불러와야 한다.
                         * '기본 정보'는 'data' 시트에 바인딩한 후, 엑셀의 참조 기능을 이용한다.
                         * 그리고, '품목 조회 부분'은 rows.count()를 이용해 row의 수를 파악하여 발주서 양식에 행을 추가한다.
                         * 그 후, 행을 추가한 부분에 '품목 조회 부분'의 위치를 직접 지정하여 바인딩해야 한다.
                         * 
                        */
                        sheet_1.DataBindings.BindToDataSource(_dtList, 1, 0, dsOptions);
                        sheet_1.DataBindings.BindToDataSource(_dtList_01, 4, 0, dsOptions);

                        string Select_PartType = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_TYPE").ToString();
                        string name_tmp = string.Empty;
                        //이미지 넣을 범위
                        //제품 : 1001
                        if (Select_PartType == "1001")
                        {
                            DataTable _dtList2 = null;
                            /*
                            name_tmp = _dtList.Rows[0]["담당자"].ToString();
                            if (name_tmp != "")
                            { 
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["D31:G31"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);
                                }
                           }
                            */
                            name_tmp = _dtList.Rows[0]["작성자"].ToString();
                            if (name_tmp != "")
                            {
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["I30:K31"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                            name_tmp = _dtList.Rows[0]["검토자"].ToString();
                            if (name_tmp != "")
                            {
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["L30:N31"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                            //name_tmp = _dtList.Rows[0]["승인자"].ToString();
                            name_tmp = _dtList.Rows[0]["서명자"].ToString();
                            if (name_tmp != "")
                            {
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["O30:Q31"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                        }
                        //반제품 : 1003
                        else if (Select_PartType == "1003")
                        {
                            DataTable _dtList2 = null;
                            /*
                            name_tmp = _dtList.Rows[0]["담당자"].ToString();
                            if (name_tmp != "")
                            {
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["C31:G31"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                            */
                            name_tmp = _dtList.Rows[0]["작성자"].ToString();
                            if (name_tmp != "")
                            {
                                 _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["I30:K31"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                            name_tmp = _dtList.Rows[0]["검토자"].ToString();
                            if (name_tmp != "")
                            {
                                 _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["L30:N31"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                            //name_tmp = _dtList.Rows[0]["승인자"].ToString();
                            name_tmp = _dtList.Rows[0]["서명자"].ToString();
                            if (name_tmp != "")
                            {
                                 _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["O30:P31"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                        }
                        //원료 : 1004
                        else if (Select_PartType == "1004")
                        {
                            DataTable _dtList2 = null;
                            //name_tmp = _dtList.Rows[0]["담당자"].ToString();
                            name_tmp = _dtList.Rows[0]["작성자"].ToString();
                            if (name_tmp != "")
                            {
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["I41:K42"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                            /*
                            name_tmp = _dtList.Rows[0]["작성자"].ToString();
                            if (name_tmp != "")
                            {
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["I30:K31"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                            name_tmp = _dtList.Rows[0]["검토자"].ToString();
                            if (name_tmp != "")
                            {
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["L30:N31"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                            */
                            //승인자 = 확인자
                            //name_tmp = _dtList.Rows[0]["승인자"].ToString();
                            name_tmp = _dtList.Rows[0]["서명자"].ToString();
                            if (name_tmp != "")
                            {
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["L41:N42"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                        }
                        //자재 : 1005
                        else if (Select_PartType == "1005")
                        {
                            DataTable _dtList2 = null;
                            /*
                            name_tmp = _dtList.Rows[0]["담당자"].ToString();
                            if (name_tmp != "")
                            {
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["C35:F35"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                            */
                            name_tmp = _dtList.Rows[0]["작성자"].ToString();
                            if (name_tmp != "")
                            {
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["H34:H35"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                            name_tmp = _dtList.Rows[0]["검토자"].ToString();
                            if (name_tmp != "")
                            {
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["I34:I35"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                            //승인자 = 확인자
                            //name_tmp = _dtList.Rows[0]["승인자"].ToString();
                            name_tmp = _dtList.Rows[0]["서명자"].ToString();
                            if (name_tmp != "")
                            {
                                _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pInspectFinalApprovalRegisterEntity.CRUD, name_tmp);
                                if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pInspectFinalApprovalRegisterEntity.CRUD == ""))
                                {
                                    Image img = null;
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                    sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["J34:J35"]);
                                    //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

                                }
                            }
                        }
                        //DataValidation validation = sheet_0.DataValidations.Add(sheet_0["F11:F27"], DataValidationType.List, "적합, 부적합");
                        //validation = sheet_0.DataValidations.Add(sheet_0["I11:I27"], DataValidationType.List, "적합, 부적합");



                        // validation = sheet_0.DataValidations.Add()
                        // validation.ShowDropDown = true;
                        //sheet_0.DataValidations.GetInvalidCells();

                        //sheet_0.DataValidations.

                        // Range unlockedRange = sheet_0["I11:I27"];
                        // unlockedRange.Protection.Locked = false;


                        //sheet_0.DataValidations.Add(sheet_0["J11:I27"], DataValidationType.List, ValueObject.FromRange(sheet_0["J6:J7"].GetRangeWithAbsoluteReference()));
                    }
                    else
                    {

                        CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    }
                }

                workbook.Worksheets.ActiveWorksheet = workbook.Worksheets[0];

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


        /*
private void _sdMAIN_CausesValidationChanged(object sender, EventArgs e)
{
  // throw new NotImplementedException();
}
*/
        #endregion


        #endregion


    }
}

