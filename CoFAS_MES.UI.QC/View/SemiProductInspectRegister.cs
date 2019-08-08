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
using DevExpress.Utils.Menu;

namespace CoFAS_MES.UI.QC
{
    public partial class SemiProductInspectRegister : frmBaseNone
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
        private bool _pApproval_YN = true;              // 승인여부 사용여부(빈값이면 수정, 빈값이 아니면 수정안됨)
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭

        private SemiProductInspectRegisterEntity _pSemiProductInspectRegisterEntity = null; // 엔티티 생성


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
        private DataTable _dtList_02 = null; //사용자 데이터 리스트
        public string signature_user = string.Empty;

        public SemiProductInspectRegister()
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
                _pnLeft.Width = 810;
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

                _pUSER_GRANT = MainForm.UserEntity.USER_GRANT;

                _pWINDOW_NAME = this.Name;
                _pMENU_NAME = this.Text;

                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_IP_PORT = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PATH = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
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

                //메뉴 화면 엔티티 설정
                _pSemiProductInspectRegisterEntity = new SemiProductInspectRegisterEntity();
                //_pProcessCodeMstRegisterEntity.CORP_CODE = _pCORP_CODE;
                _pSemiProductInspectRegisterEntity.USER_CODE = _pUSER_CODE;
                _pSemiProductInspectRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pSemiProductInspectRegisterEntity.WINDOW_NAME = _pWINDOW_NAME;

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
                //_ucbtINSPECT_REQUEST.BackColor = Color.LightSkyBlue;
                //그리드 초기화 
                //메인 그리드
                _gdMAIN.DataSource = null;

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pSemiProductInspectRegisterEntity.CRUD = "";

                //MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                //SubFind_DisplayData();

                if (_pFirstYN)
                {
                    //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    SheetFind_DisplayData();  // DB에 저장된 해당 화면의 엑셀파일 불러오기
                    //Sheet_Info_Sheet_Data();  // 데이터 바인딩
                    //그리드 버튼추가 시 클릭 이벤트 처리 
                    // CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;

                    //조회조건 영역 
                    //_luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "");

                    _luT_INSPECT_STATUS.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "INSPECT_STATUS_AC", "", "", "").Tables[0], 0, 0, "");

                    _luT_INSPECT_STATUS.ItemIndex = 0;
                    
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
                if (_luT_ACCEPT_DATE.FromDateTime > _luT_ACCEPT_DATE.ToDateTime)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 일자를 확인해 주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_SEARCH_DATE);
                }
                else
                {
                    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);



                    _pSemiProductInspectRegisterEntity.CRUD = "R";
                    _pSemiProductInspectRegisterEntity.DATE_FROM = DateTime.Parse(_luT_ACCEPT_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luTORDER_DATE.FromDateTime).Replace("-", "").Substring(0, 8);//
                    _pSemiProductInspectRegisterEntity.DATE_TO = DateTime.Parse(_luT_ACCEPT_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luTORDER_DATE.ToDateTime).Replace("-", "").Substring(0, 8);//
                    //_pSemiProductInspectRegisterEntity.VEND_NAME = _luTVEND.NameText;
                    //_pSemiProductInspectRegisterEntity.VEND_CODE = _luTVEND.CodeText;
                    _pSemiProductInspectRegisterEntity.PART_NAME = _luT_PART.NameText;
                    _pSemiProductInspectRegisterEntity.PART_CODE = _luT_PART.CodeText;
                    //_pSemiProductInspectRegisterEntity.USE_YN = _luTUSE_YN.GetValue();
                    _pSemiProductInspectRegisterEntity.INSPECT_STATUS = _luT_INSPECT_STATUS.GetValue();
                   //
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


                // sheet_1.DataBindings.BindToDataSource(_dtList, 1, 0, dsOptions);
                //DataTable pSheet_1_Convert = workbook.Worksheets[2];
                //DataTable pSheet_1_Convert = sheet_1.DataBindings.CreateDataSource(data_range);
                //BindingSource bs = (BindingSource)sheet_1.DataBindings.GetDataBindings(data_range);
                //BindingSource bs = (BindingSource)sheet_1.DataBindings.CreateDataSource(data_range);
                _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.SelectedCells);

                InputData_Save(_pSemiProductInspectRegisterEntity);

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
                _sdMAIN.ShowRibbonPrintPreview();
               // _sdMAIN.ShowPrintPreview();

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
                SheetFind_DisplayData();  // DB에 저장된 해당 화면의 엑셀파일 불러오기
               // Sheet_Info_Sheet_Data();  // 데이터 바인딩
                

                InitializeControl();

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

        private void InputData_Save(SemiProductInspectRegisterEntity _pSemiProductInspectRegisterEntity)
        {
            try
            {
               

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.Yes)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                {

                    //승인/미승인상태면 수정x, 빈값이면 ok
                    if (_pApproval_YN)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("승인/미승인 상태는 수정불가 합니다.");
                        return;
                    }

                    _pSemiProductInspectRegisterEntity.CRUD = "U";
                   
                    //실제데이터
                    IWorkbook workbook = _sdMAIN.Document;
                    Worksheet sheet_1 = workbook.Worksheets[0];
                    _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.SelectedCells);
                    //결과 저장용 시트
                    Worksheet sheet_2 = workbook.Worksheets["저장용 데이터"];
                    /*
                    pSemiProductInspectRegisterEntity.PART_CODE
                    pSemiProductInspectRegisterEntity.PART_NAME
                    pSemiProductInspectRegisterEntity.INSPECT_STATUS
                    pSemiProductInspectRegisterEntity.INSPECT_ID
                    pSemiProductInspectRegisterEntity.INSPECT__DATE
                    pSemiProductInspectRegisterEntity.INSPECT_SEQ
                    pSemiProductInspectRegisterEntity.VEND_PART_CODE
                    pSemiProductInspectRegisterEntity.PART_TYPE
                    pSemiProductInspectRegisterEntity.REFERENCE_ID
                    pSemiProductInspectRegisterEntity.MAKE_VEND
                    pSemiProductInspectRegisterEntity.MAKE_VEND_NAME
                    pSemiProductInspectRegisterEntity.VEND_CODE
                    pSemiProductInspectRegisterEntity.VEND_NAME
                    pSemiProductInspectRegisterEntity.REQUEST_DEPT
                    pSemiProductInspectRegisterEntity.CODE_NAME
                    pSemiProductInspectRegisterEntity.INOUT_DATE
                    pSemiProductInspectRegisterEntity.INOUT_QTY
                        */
                    //_pSemiProductInspectRegisterEntity.PACKING_REMARK  = sheet_1.GetCellValue(4, 6).TextValue;
                    //_pSemiProductInspectRegisterEntity.SAMPLE_DATE     = sheet_1.GetCellValue(4, 7).TextValue;
                    //_pSemiProductInspectRegisterEntity.SAMPLE_LOCATION = sheet_1.GetCellValue(6, 4).TextValue;
                    //_pSemiProductInspectRegisterEntity.SAMPLE_USER     = sheet_1.GetCellValue(6, 5).TextValue;
                    //_pSemiProductInspectRegisterEntity.SAMPLE_METHOD   = sheet_1.GetCellValue(6, 6).TextValue;
                    //_pSemiProductInspectRegisterEntity.SAMPLE_QTY      = sheet_1.GetCellValue(6, 7).TextValue;
                    /*
                pSemiProductInspectRegisterEntity.MAKE_NO
                pSemiProductInspectRegisterEntity.STANDARD
                pSemiProductInspectRegisterEntity.REQUEST_DATE
                pSemiProductInspectRegisterEntity.REQUEST_USER
                pSemiProductInspectRegisterEntity.END_DATE
                pSemiProductInspectRegisterEntity.TOTAL_RESULT
                pSemiProductInspectRegisterEntity.TOTAL_DATE
                pSemiProductInspectRegisterEntity.TOTAL_USER
                pSemiProductInspectRegisterEntity.COMPLETE_YN
                pSemiProductInspectRegisterEntity.REMARK
                pSemiProductInspectRegisterEntity.USER_YN
                */

                    isError = new SemiProductInspectRegisterBusiness().SemiProductInspectRegister_Info_Mst_Save(_pSemiProductInspectRegisterEntity, sheet_1);
                    // 자재입고
                    if (isError)
                    {
                        //오류 발생.
                        //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    }
                    else
                    {

                        isError = new SemiProductInspectRegisterBusiness().SemiProductInspectRegister_Info_Detail_Save(_pSemiProductInspectRegisterEntity, sheet_2);
                        if (isError)
                        {
                            //오류 발생.
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                        }
                        else
                        {
                            _pLocation_Code = _pSemiProductInspectRegisterEntity.RTN_KEY;  //저장 위치
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                            Form_SearchButtonClicked(null, null);
                            
                            //정상 처리
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                            
                            SheetFind_DisplayData();
                            //InitializeControl(false);

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
        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GridView gv = sender as GridView;

            _pSemiProductInspectRegisterEntity.INSPECT_ID= gv.GetFocusedRowCellValue("INSPECT_ID").ToString();

            //QC020001 : 승인
            //QC020002 : 미승인
            //승인인경우 수정x
            if (gv.GetFocusedRowCellValue("APPROVAL").ToString() != "QC020001")
                _pApproval_YN = false;
            else
                _pApproval_YN = true;

            SheetFind_DisplayData();

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

                _luT_INSPECT_STATUS.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "INSPECT_STATUS_AC", "", "", "").Tables[0], 0, 0, "");

                _luT_INSPECT_STATUS.ItemIndex = 0;

                _luT_ACCEPT_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luT_ACCEPT_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                
                _luT_PART.CodeText = "";
                _luT_PART.NameText = "";

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

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _dtList = new SemiProductInspectRegisterBusiness().Sample_Info(_pSemiProductInspectRegisterEntity);

                if (_pSemiProductInspectRegisterEntity.CRUD == "")
                    _dtList.Rows.Clear();
                else
                {
                    IWorkbook workbook = _sdMAIN.Document;
                    Worksheet sheet_1 = workbook.Worksheets["데이터"];
                    Range data_range = sheet_1.GetDataRange();
                    sheet_1.Clear(data_range);
                }

               
                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pSemiProductInspectRegisterEntity.CRUD == ""))
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
                string part_type = "1003";
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
                    MainFind_DisplayData();
                    return;
                 }

                 if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                 {
                     _luT_PART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["ORDER_ID"].ToString();
                     _luT_PART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                 }
                //MainFind_DisplayData();
                 xfrmCommonPopup.Dispose();
                Form_SearchButtonClicked(null, null);
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
                _pSemiProductInspectRegisterEntity.CRUD = "R";

                //조회할거 프로시져
                _dtList = new SemiProductInspectRegisterBusiness().Sheet_Info_Sheet(_pSemiProductInspectRegisterEntity);   //엑셀 시트 조회하기

                //엑셀서식관리 되면 다시 설정하기
                
                strUSE_TYPE = _dtList.Rows[0]["USE_TYPE"].ToString();
                strFILE_NAME = _dtList.Rows[0]["FILE_NAME"].ToString();
                /*
                strUSE_TYPE = "VIEW";
                strFILE_NAME = "SemiProductInspectRegister_Sample_v1.xlsx";
                */
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

                // 같은 것이 있으면, 폴더에서 해당 파일명을 불러와서 SpreadSheet에 띄우기 / 없으면, 폴더에 다운
                if (!File.Exists(curfile))
                {
                    CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW, curfile,false);

                }
                //using (FileStream file = File.OpenWrite(curfile))
                using (Stream file = File.Open(curfile, FileMode.Open))
                {
                        if (file != null)

                        {
                            _sdMAIN.LoadDocument(file, DocumentFormat.Xlsx);

                            // 일반 컨트롤 일때 : DocumentFormat.Xls   // UC일때,  enFileFormat.Xls
                            IWorkbook workbook = _sdMAIN.Document;
                            Worksheet sheet_0 = workbook.Worksheets[0];
                            Worksheet sheet_2 = workbook.Worksheets[2];
                            Range rg = sheet_2.Range["J2:J3"];
                            //sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["C29"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg));
                            //sheet_0.CustomCellInplaceEditors.Add(sheet_0.Range["O9:P21"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(rg));

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
           // string Select_PartType = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_TYPE").ToString();
            if (e.MenuType == SpreadsheetMenuType.Cell)
            {
                int click_col = _sdMAIN.ActiveWorksheet[_sdMAIN.ActiveCell.GetReferenceA1()].RightColumnIndex;
                int click_row = _sdMAIN.ActiveWorksheet[_sdMAIN.ActiveCell.GetReferenceA1()].TopRowIndex;

                //제품 : 1001
                //판정자 = 담당자
                /*
                    if ((_sdMAIN.ActiveCell == activeSheet.Cells["C31"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["D31"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["E31"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["F31"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["G31"]))
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
                    //
                    // total_user		: 담당자
                    // total_writer	: 작성자
                    // total_checker	: 검토자
                    // total_approver	: 승인자 
                    //
                        signature_user = "total_user";
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
                    */
                //작성 = 작성자
                if ((_sdMAIN.ActiveCell == activeSheet.Cells["I30"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["J30"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["K30"])|| (_sdMAIN.ActiveCell == activeSheet.Cells["I31"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["J31"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["K31"]))
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
                    /*
                        total_user		: 담당자
                        total_writer	: 작성자
                        total_checker	: 검토자
                        total_approver	: 승인자 
                     */
                    signature_user = "total_writer";
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
                //검토 = 검토자
                if ((_sdMAIN.ActiveCell == activeSheet.Cells["L30"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["M30"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["N30"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["L31"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["M31"]) || (_sdMAIN.ActiveCell == activeSheet.Cells["N31"]))
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
                    /*
                        total_user		: 담당자
                        total_writer	: 작성자
                        total_checker	: 검토자
                        total_approver	: 승인자 
                     */
                    signature_user = "total_checker";
                }
                //판정
                else if (((7 < click_row) && (click_row < 21)) && (15 == click_col))
                {
                    _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);

                    SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("적합", new EventHandler(InsertResult));
                    SpreadsheetMenuItem myItem2 = new SpreadsheetMenuItem("부적합", new EventHandler(InsertResult));

                    e.Menu.Items.Add(myItem);
                    e.Menu.Items.Add(myItem2);

                }
                //종합판정
                else if ( (28 == click_row) && ((1 < click_col) && (click_col < 7)))
                {
                    _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);

                    SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("적합", new EventHandler(InsertResult));
                    SpreadsheetMenuItem myItem2 = new SpreadsheetMenuItem("부적합", new EventHandler(InsertResult));

                    e.Menu.Items.Add(myItem);
                    e.Menu.Items.Add(myItem2);

                }
                //시험결과
                else if (((7 < click_row) && (click_row < 21)) && ((4 < click_col) && (click_col < 10)))
                {
                    _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);

                    SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("적합", new EventHandler(InsertResult));
                    SpreadsheetMenuItem myItem2 = new SpreadsheetMenuItem("부적합", new EventHandler(InsertResult));

                    e.Menu.Items.Add(myItem);
                    e.Menu.Items.Add(myItem2);

                }
                //검체채취자
                else if (((5 < click_col) && (click_col < 9)) && (click_row == 4))
                {
                    _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                    for (int i = 0; i < _dtList_02.Rows.Count; i++)
                    {
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem(_dtList_02.Rows[i]["사용자"].ToString(), new EventHandler(InsertUserList));
                        e.Menu.Items.Add(myItem);
                    }

                }
                //상단 시험자
                else if (((12 < click_col) && (click_col < 16)) && (click_row == 1))
                {
                    _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                    for (int i = 0; i < _dtList_02.Rows.Count; i++)
                    {
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem(_dtList_02.Rows[i]["사용자"].ToString(), new EventHandler(InsertUserList));
                        e.Menu.Items.Add(myItem);
                    }

                }
                //시험자
                else if (((7 < click_row) && (click_row < 21)) && ((9 < click_col) && (click_col < 12)))
                {
                    _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                    for (int i = 0; i < _dtList_02.Rows.Count; i++)
                    {
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem(_dtList_02.Rows[i]["사용자"].ToString(), new EventHandler(InsertUserList));
                        e.Menu.Items.Add(myItem);
                    }

                }
                //판정자
                else if ((click_row == 30) && ((1 < click_col) && (click_col < 7)) )
                {
                    _sdMAIN.Options.Behavior.ShowPopupMenu = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;

                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.ReviewInsertCommentContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                    e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                    for (int i = 0; i < _dtList_02.Rows.Count; i++)
                    {
                        SpreadsheetMenuItem myItem = new SpreadsheetMenuItem(_dtList_02.Rows[i]["사용자"].ToString(), new EventHandler(InsertUserList));
                        e.Menu.Items.Add(myItem);
                    }

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
        public void InsertSignImage(object sender, EventArgs e)
        {
            if (CoFAS_DevExpressManager.ShowQuestionMessage("승인하시겠습니까?") == DialogResult.No)
            {
                return;
            }
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pSemiProductInspectRegisterEntity.CRUD = "R";
                _dtList = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pSemiProductInspectRegisterEntity.CRUD, _pSemiProductInspectRegisterEntity.USER_CODE);
                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pSemiProductInspectRegisterEntity.CRUD == ""))
                {
                    IWorkbook workbook = _sdMAIN.Document;
                    Worksheet sheet_0 = workbook.Worksheets[0];
                    Image img = null;
                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList.Rows[0]["USER_IMAGE"]);
                    Stream memstr = new MemoryStream((byte[])_dtList.Rows[0]["USER_IMAGE"]);
                    SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);

                    //이미지 넣을 범위
                    if (signature_user == "total_user")
                    {
                        sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["C31:G31"]);
                        sheet_0.Cells["C31"].SetValue(_pUSER_NAME);
                    }
                    else if (signature_user == "total_writer")
                    {
                        sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["I30:K31"]);
                        sheet_0.Cells["I30"].SetValue(_pUSER_CODE);
                    }
                    else if (signature_user == "total_checker")
                    {
                        sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["L30:N31"]);
                        sheet_0.Cells["L30"].SetValue(_pUSER_CODE);
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
        //사용자
        public void InsertUserList(object sender, EventArgs e)
        {
            try
            {
                DXMenuItem item = sender as DXMenuItem;

                IWorkbook workbook = _sdMAIN.Document;
                Worksheet activeSheet = workbook.Worksheets.ActiveWorksheet;
                Worksheet sheet_1 = workbook.Worksheets["데이터"];
                Worksheet sheet_0 = workbook.Worksheets[0];
                Worksheet sheet_2 = workbook.Worksheets["저장용 데이터"];
                int click_col = _sdMAIN.ActiveWorksheet[_sdMAIN.ActiveCell.GetReferenceA1()].RightColumnIndex;
                int click_row = _sdMAIN.ActiveWorksheet[_sdMAIN.ActiveCell.GetReferenceA1()].TopRowIndex;

                //검체채취자
                if (((5 < click_col) && (click_col < 9)) && (click_row == 4))
                {
                    sheet_0.Cells[click_row, 6].SetValue(item.Caption);
                }
                //시험자
                else if (((7 < click_row) && (click_row < 21)) && ((9 < click_col) && (click_col < 12)))
                {
                    sheet_0.Cells[click_row, 10].SetValue(item.Caption);
                }
                //상단 시험자
                else if (((12 < click_col) && (click_col < 16)) && (click_row == 1))
                {
                    sheet_0.Cells[click_row, 13].SetValue(item.Caption);
                }
                //판정자
                else if ((click_row == 30) && ((1 < click_col) && (click_col < 7)))
                {
                    sheet_0.Cells[click_row, 2].SetValue(item.Caption);
                }
                    //시험결과
                    //else if ((click_row == 27) && ((0 < click_col) && (click_col < 3)))
                    //{
                    //    sheet_0.Cells[click_row, 1].SetValue(item.Caption);
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
        //결과넣기
        public void InsertResult(object sender, EventArgs e)
        {
            try
            {
                DXMenuItem item = sender as DXMenuItem;

                IWorkbook workbook = _sdMAIN.Document;
                Worksheet activeSheet = workbook.Worksheets.ActiveWorksheet;
                Worksheet sheet_1 = workbook.Worksheets["데이터"];
                Worksheet sheet_0 = workbook.Worksheets[0];
                Worksheet sheet_2 = workbook.Worksheets["저장용 데이터"];
                int click_col = _sdMAIN.ActiveWorksheet[_sdMAIN.ActiveCell.GetReferenceA1()].RightColumnIndex;
                int click_row = _sdMAIN.ActiveWorksheet[_sdMAIN.ActiveCell.GetReferenceA1()].TopRowIndex;
                
                 //판정
              if (((7 < click_row) && (click_row < 21)) && (15 == click_col))
                {
                    sheet_0.Cells[click_row, 15].SetValue(item.Caption);
                }
                //시험결과
                else if ((28 == click_row) && ((1 < click_col) && (click_col < 7)))
                {
                    sheet_0.Cells[click_row, 2].SetValue(item.Caption);
                }
                else if (((7 < click_row) && (click_row < 21)) && ((4 < click_col) && (click_col < 10)))
                {
                    sheet_0.Cells[click_row, 5].SetValue(item.Caption);
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

        private void _sdMAIN_CellBeginEdit(object sender, SpreadsheetCellCancelEventArgs e)
        {

            if (((e.ColumnIndex == 14 && e.RowIndex == 29) || (e.ColumnIndex == 14 && e.RowIndex == 30) || (e.ColumnIndex == 15 && e.RowIndex == 29) || (e.ColumnIndex == 15 && e.RowIndex == 30)))
            {
                CoFAS_DevExpressManager.ShowInformationMessage("승인은 승인자만 가능합니다.");
                e.Cancel = true;
            }
            //제조일자
            if (((e.RowIndex == 2)) && ((5 < e.ColumnIndex) && (e.ColumnIndex < 9)))
            {
                IWorkbook workbook = _sdMAIN.Document;
                Worksheet sheet_0 = workbook.Worksheets[0];

                // 팝업에 파라미터 전송
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.ARRAY_CODE = new object[4] { "", "", "", "" };
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.QC.UserForm.frmCommonPopup("Calendar"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();
                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    sheet_0.Cells[e.RowIndex, 6].SetValue(xfrmCommonPopup.dtReturn.Rows[0]["DATE"].ToString());
                }

                xfrmCommonPopup.Dispose();
            }
            //검체채취일
            if (((e.RowIndex == 4)) && ((12 < e.ColumnIndex) && (e.ColumnIndex < 16)))
            {
                IWorkbook workbook = _sdMAIN.Document;
                Worksheet sheet_0 = workbook.Worksheets[0];

                // 팝업에 파라미터 전송
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.ARRAY_CODE = new object[4] { "", "", "", "" };
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.QC.UserForm.frmCommonPopup("Calendar"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();
                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    sheet_0.Cells[e.RowIndex, 13].SetValue(xfrmCommonPopup.dtReturn.Rows[0]["DATE"].ToString());
                }

                xfrmCommonPopup.Dispose();
            }
            //시험의뢰일
            if (((e.RowIndex == 3)) && ((12 < e.ColumnIndex) && (e.ColumnIndex < 16)))
            {
                IWorkbook workbook = _sdMAIN.Document;
                Worksheet sheet_0 = workbook.Worksheets[0];

                // 팝업에 파라미터 전송
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.ARRAY_CODE = new object[4] { "", "", "", "" };
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.QC.UserForm.frmCommonPopup("Calendar"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();
                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    sheet_0.Cells[e.RowIndex, 13].SetValue(xfrmCommonPopup.dtReturn.Rows[0]["DATE"].ToString());
                }

                xfrmCommonPopup.Dispose();
            }
            //시험일
            if (((7 < e.RowIndex) && (e.RowIndex < 21)) && ((11 < e.ColumnIndex) && (e.ColumnIndex < 15)))
            {
                IWorkbook workbook = _sdMAIN.Document;
                Worksheet sheet_0 = workbook.Worksheets[0];

                // 팝업에 파라미터 전송
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.ARRAY_CODE = new object[4] { "", "", "", "" };
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.QC.UserForm.frmCommonPopup("Calendar"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();
                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    sheet_0.Cells[e.RowIndex, 12].SetValue(xfrmCommonPopup.dtReturn.Rows[0]["DATE"].ToString());
                }

                xfrmCommonPopup.Dispose();
            }
            //종합판정
            if (((e.RowIndex == 29)) && ((1 < e.ColumnIndex) && (e.ColumnIndex < 7)))
            {
                IWorkbook workbook = _sdMAIN.Document;
                Worksheet sheet_0 = workbook.Worksheets[0];

                // 팝업에 파라미터 전송
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.ARRAY_CODE = new object[4] { "", "", "", "" };
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.QC.UserForm.frmCommonPopup("Calendar"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();
                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    sheet_0.Cells[e.RowIndex, 2].SetValue(xfrmCommonPopup.dtReturn.Rows[0]["DATE"].ToString());
                }

                xfrmCommonPopup.Dispose();
            }
        }
        #endregion

        #region ○ new 시트에 서브그리드에서 선택한 프로시저 정보 바인딩 - SubFind_DisplayData(string strWINDOW_NAME, string strFILE_NAME)

        #region ○ 화면명과 선택한 발주번호에 맞는 정보 바인딩 - Sheet_Info_Sheet_Data()  //추가

        private void Sheet_Info_Sheet_Data()   //추가
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

               // _pSemiProductInspectRegisterEntity.ORDER_ID = _luORDER_ID.Text.ToString();

                IWorkbook workbook = _sdMAIN.Document;

                using (DBManager pDBManager = new DBManager())
                {

                    // _dtList = new MaterialOrderRegisterProvider(pDBManager).Sheet_Info_Sheet_Data(_pSemiProductInspectRegisterEntity);
                    _dsList = new SemiProductInspectRegisterProvider(pDBManager).SemiProductInspectRegister_info_ExcelBinding(_pSemiProductInspectRegisterEntity);
                    //품목정보용
                    _dtList = _dsList.Tables[0];
                    //시험항목검사결과(엑셀바인딩용)
                    _dtList_01 = _dsList.Tables[1];
                    _dtList_02 = _dsList.Tables[2];

                    _pSemiProductInspectRegisterEntity.dtListCnt = _dtList_01.Rows.Count;
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
                        string name_tmp = string.Empty;

                        DataTable _dtList2 = null;
                        /*
                        name_tmp = _dtList.Rows[0]["담당자"].ToString();
                        if (name_tmp != "")
                        {
                            _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pSemiProductInspectRegisterEntity.CRUD, name_tmp);
                            if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pSemiProductInspectRegisterEntity.CRUD == ""))
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
                            _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pSemiProductInspectRegisterEntity.CRUD, name_tmp);
                            if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pSemiProductInspectRegisterEntity.CRUD == ""))
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
                            _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pSemiProductInspectRegisterEntity.CRUD, name_tmp);
                            if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pSemiProductInspectRegisterEntity.CRUD == ""))
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
                            _dtList2 = new InspectFinalApprovalRegisterBusiness().GetUserImage(_pSemiProductInspectRegisterEntity.CRUD, name_tmp);
                            if ((_dtList2 != null && _dtList2.Rows.Count > 0) || (_dtList2 != null && _pSemiProductInspectRegisterEntity.CRUD == ""))
                            {
                                Image img = null;
                                img = CoFAS_ConvertManager.byteArrayToImage((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                Stream memstr = new MemoryStream((byte[])_dtList2.Rows[0]["USER_IMAGE"]);
                                SpreadsheetImageSource imageSource = SpreadsheetImageSource.FromStream(memstr);
                                sheet_0.Pictures.AddPicture(imageSource, sheet_0.Range["O30:P31"]);
                                //  sheet_0.Cells["C35"].SetValue(_pUSER_NAME);

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

        //시트가 바뀔때마다 새로고침
        
       // private void Workbook_ActiveSheetChanged(object sender, ActiveSheetChangedEventArgs e)
       // {
       //     /*
       //     //피벗테이블이 있는 시트번호
       //     Worksheet worksheet_2 = workbook.Worksheets[1];
       //     Worksheet worksheet_3 = workbook.Worksheets[0]; //보여줄것
       //                                                     //피벗테이블이 있는 시트번호
       //     Worksheet worksheet_PivotTable_01 = workbook.Worksheets["Pivot_01"];
       //     Worksheet worksheet_PivotTable_02 = workbook.Worksheets["Pivot_02"];
       //     Worksheet worksheet_PivotTable_03 = workbook.Worksheets["Pivot_03"];
       //     Worksheet worksheet_PivotTable_04 = workbook.Worksheets["Pivot_04"];
       //
       //     //보여줄 현황 시트(차트있는 시트)
       //     Worksheet worksheet_Chart_01 = workbook.Worksheets["제품입고현황"];
       //     Worksheet worksheet_Chart_02 = workbook.Worksheets["기간별생산실적현황"];
       //     Worksheet worksheet_Chart_03 = workbook.Worksheets["제품미출고현황"];
       //     Worksheet worksheet_Chart_04 = workbook.Worksheets["제품재고현황"];
       //
       //     // 피벗시트에서 피벗테이블 범위 알아오기 -> 차트에 범위 갱신
       //     Range PivotTable_range_01 = worksheet_PivotTable_01.GetDataRange();
       //     Range PivotTable_range_02 = worksheet_PivotTable_02.GetDataRange();
       //     Range PivotTable_range_03 = worksheet_PivotTable_03.GetDataRange();
       //     Range PivotTable_range_04 = worksheet_PivotTable_04.GetDataRange();
       //
       //     //범위 재정의 저장
       //     ////피벗테이블쪽 차트
       //     worksheet_PivotTable_01.Charts[0].SelectData(PivotTable_range_01);
       //     worksheet_PivotTable_02.Charts[0].SelectData(PivotTable_range_02);
       //     worksheet_PivotTable_03.Charts[0].SelectData(PivotTable_range_03);
       //     worksheet_PivotTable_04.Charts[0].SelectData(PivotTable_range_04);
       //     ////실제 사용자용 차트
       //     worksheet_Chart_01.Charts[0].SelectData(PivotTable_range_01);
       //     worksheet_Chart_02.Charts[0].SelectData(PivotTable_range_02);
       //     worksheet_Chart_03.Charts[0].SelectData(PivotTable_range_03);
       //     worksheet_Chart_04.Charts[0].SelectData(PivotTable_range_04);
       //
       //     */
       //
       //     workbook.Worksheets.ActiveWorksheet = workbook.Worksheets[0];
       //
       //     workbook.PivotCaches.RefreshAll();
       // }
        
        
        //피벗테이블 수정될때마다 차트 업데이트
      //  private void Workbook_ModifiedChanged(object sender, EventArgs e)
      //  {
      //      workbook.PivotCaches.RefreshAll();
      //  }

        #endregion
    }
}

/*

 		SELECT 		
						A.inspect_id				AS 시험검사번호,	
						A.inspect_date			AS 시험검사일자 ,
						A.inspect_seq				AS 순번,
						A.part_code				AS 품목코드,
						A.part_type				AS 품목구분,
						A.reference_id			AS 참조번호,
						A.make_vend				AS 제조원,
						A.vend_code				AS 납품처,
						A.request_dept			AS 시험의뢰부서,
						A.inout_date				AS 입고일자,
						A.inout_qty				AS 입고수량,
						A.packing_remark			AS 포장상태,
						A.sample_date				AS 검체채취일,
						A.sample_location		AS 검체채취장소,
						A.sample_user				AS 검체채취자,
						A.sample_method			AS 검체채취방법,
						A.sample_qty				AS 검체채취량,
						A.make_no					AS 제조번호,
						A.standard					AS 규격,
						A.request_date			AS 시험일,
						A.request_user			AS 시험자,
						A.end_date					AS 사용기간,
						A.total_result			AS 종합판정,
						A.total_date				AS 판정일자,
						A.total_user				AS 담당자,
						A.complete_yn				AS 완료유무,
						A.remark					AS 비고,
						A.use_yn					AS 사용유무,
						A.reg_date					AS 등록일,
						A.reg_user					AS 등록자,
						A.up_date					AS 수정일,
						A.up_user					AS 수정자
						
		FROM inspect_request A
		WHERE A.INSPECT_ID =v_inspect_id
		; 
 
 */
