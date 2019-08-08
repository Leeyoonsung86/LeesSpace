using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static CoFAS_MES.CORE.BaseControls.ucSpreadSheetControl;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;

using CoFAS_MES.UI.SM.Business;
using CoFAS_MES.UI.SM.Entity;

using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraGrid.Views.Base;
using System.Net;

namespace CoFAS_MES.UI.SM
{
    public partial class SheetInfoRegister : frmBaseNone
    {
        private string _pCORP_CODE = string.Empty;       // 회사코드       
        private string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private string _pUSER_NAME = string.Empty;       // 사용자이름
        private string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        private string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        private int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;              // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장

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

        private string _pFTP_BEFROE_FILENAME = string.Empty;    //업로드 파일을 변경할경우, 이전파일명 가지고 있고 이전파일명으로 삭제하기

        private SheetInfoRegisterEntity _pSheetInfoRegisterEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트
        private object _ojList = null; //엑셀 파일

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        // 코에버 frp 관련 변수
        private string _pFileName = "";                                 //local 파일이름   //ofd로 받아서 넣기 safe~
        private string _pFullName = "";                                 //localfile 파일명 포함 전체 경로        
        private string _pFTP_DOWNLOAD_PATH = ""; // ftp download에 사용


        public SheetInfoRegister()
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
                //그리드 작업 정보 확인 하기
                //if (_gdSUB_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                //{
                //    if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
                //    {
                //        pFormClosingEventArgs.Cancel = true;
                //        return;
                //    }
                //}
                //else
                //{
                //    pFormClosingEventArgs.Cancel = true;
                //}
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
                DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
                PrintButtonClicked += new EventHandler(Form_PrintButtonClicked);
                ExportButtonClicked += new EventHandler(Form_ExportButtonClicked);
                ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                SettingButtonClicked += new EventHandler(Form_SettingButtonClicked);

                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);

                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

                _luUSE_TYPE.ValueChanged += _luUSE_TYPE_ValueChanged;

                _luFILE_NAME._OnOpenClick += _luFILE_NAME__OnOpenClick;
                _luFILE_NAME._OnDownloadClick += _luFILE_NAME__OnDownloadClick;
                _luFILE_NAME._OnDeleteClick += _luFILE_NAME__OnDeleteClick;

                //Form_SearchButtonClicked(null, null);
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
                _pnLeft.Width = 500;

                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_IP_PORT = MainForm.UserEntity.FTP_IP_PORT; //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //발주서는 ORDER_FORM // 화면조회용 PROGRAM_VIEW
                _pFTP_PW = MainForm.UserEntity.FTP_PW;

                _pUSER_GRANT = MainForm.UserEntity.USER_GRANT;

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

                //메뉴 화면 엔티티 설정
                _pSheetInfoRegisterEntity = new SheetInfoRegisterEntity();
                //_pSheetInfoRegisterEntity.CORP_CODE = _pCORP_CODE;
                _pSheetInfoRegisterEntity.USER_CODE = _pUSER_CODE;
                _pSheetInfoRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;


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
                _gdMAIN.DataSource = null;
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pSheetInfoRegisterEntity.CRUD = "";
                if (_pFirstYN)
                {
                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                    _pFirstYN = false;
                }

                //SpreadSheet 초기화 _sdMAIN
                //SpreadSheetControl1.CreateNewDocument();
                _sdMAIN.ClearSheet();//uc

                ////컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                //_gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

                //_luUSE_TYPE.ValueChanged += _luUSE_TYPE_ValueChanged;

                //_luFILE_NAME._OnOpenClick += _luFILE_NAME__OnOpenClick;
                //_luFILE_NAME._OnDownloadClick += _luFILE_NAME__OnDownloadClick;
                //_luFILE_NAME._OnDeleteClick += _luFILE_NAME__OnDeleteClick;

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
                _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "",true);
                _luT_USE_YN.ItemIndex = 1;
                if (_pFirstYN)
                {
                    //조회조건 영역 
                    _luT_WINDOW_NAME.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "MENU_LIST", "", "", "").Tables[0], 0, 0, "");
                    
                    _luT_USE_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD98", "", "").Tables[0], 0, 0, "");
                    //_luT_FILE_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "COMMON_CODE", "CD95", "", "").Tables[0], 0, -1, "");
                }

                //데이터 영역
                _luWINDOW_NAME.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "MENU_LIST", "", "", "").Tables[0], 0, 0, "");     //사용 화면명
                _luWINDOW_NAME.ReadOnly = false;

                _luUSE_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD98", "", "").Tables[0], 0, -1, "");   //사용 용도 구분
                _luUSE_TYPE.SetValue("");

                _luUSE_VEND_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "VEND_CODE", "", "", "").Tables[0], 0, -1, "");   //사용 업체명
                _luUSE_VEND_CODE.ReadOnly = false;

                _luPROCESS_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "processcode", "", "", "").Tables[0], 0, -1, "");
                _luPROCESS_CODE.ReadOnly = false;

                _luFILE_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD95", "", "").Tables[0], 0, 0, "");
                _luFILE_TYPE.ReadOnly = false;

                _luFILE_NAME.Text = "";
                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");    //사용 유무

                // 컨트롤러 유효성 검증 처리
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                _pFTP_BEFROE_FILENAME = "";
                //dxValidationProvider.SetValidationRule(_luUSER_MAIL, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //콤보박스 초기화
                _luUSE_TYPE.ItemIndex = 0;
                _luUSE_YN.ItemIndex = 0;
                _luUSE_VEND_CODE.ItemIndex = 0;
                _luPROCESS_CODE.ItemIndex = 0;
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _gdMAIN.DataSource = null;
                }

                //시트부분
                //_sdMAIN.Options.View.ShowColumnHeaders = true;
                //_sdMAIN.Options.View.ShowRowHeaders = true;
                //splitContainerControl1.Visible = false;

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

                string strFILE_NAME = gv.GetFocusedRowCellValue("FILE_NAME").ToString();
                string strWINDOW_NAME = gv.GetFocusedRowCellValue("WINDOW_NAME").ToString();
                string strFTP_PATH = "";

                _pSheetInfoRegisterEntity.SHEETINFO_ID = gv.GetFocusedRowCellValue("SHEETINFO_ID").ToString();
                _pFTP_BEFROE_FILENAME= gv.GetFocusedRowCellValue("FILE_NAME").ToString();
                _luWINDOW_NAME.ReadOnly = true;
                _luUSE_VEND_CODE.ReadOnly = false;

                //USE_TYPE에 따라 FTP 폴더 경로 선택
                switch (gv.GetFocusedRowCellValue("USE_TYPE").ToString())
                {
                    case "PRINT":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_IP_PORT, "ORDER_FORM", strWINDOW_NAME);
                        break;
                    case "VIEW":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_IP_PORT, "USER", "PROGRAM_VIEW", strWINDOW_NAME);
                        break;
                    case "REGIT":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_IP_PORT,"USER", "PROGRAM_VIEW", strWINDOW_NAME);
                        break;
                }

                //FTP의 엑셀 파일 control에 바인딩
                using (Stream responseStream = CoFAS_FTPManager.FTPFileBinding(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW))
                {
                    if(responseStream != null)
                    {
                        _sdMAIN.LoadDocument(responseStream, enFileFormat.Xlsx);
                    }
                    else
                    {
                        _sdMAIN.ClearSheet();
                    }
                }


                UseType_Setting();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion


        #region ○  ucOpenButtonEdit _luFILE_NAME 엑셀파일 가져오기, 내려받기, 저장하기 기능
        private void _luFILE_NAME__OnDownloadClick(object sender, EventArgs e)
        {
            string strFTP_PATH = "";

            //ftp에서 local로 다운로드 
            if (_luFILE_NAME.Text != "")
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.InitialDirectory = @"C:\";
                saveFile.Filter = "Excel.XLSX(*.xlsx) | *.xls | ALL(*.*) | *.*";
                saveFile.FileName = _luFILE_NAME.Text.ToString();

                switch (_luUSE_TYPE.GetValue())
                {
                    case "PRINT":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_IP_PORT, "ORDER_FORM", _luWINDOW_NAME.GetValue());
                        break;
                    case "VIEW":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_IP_PORT, "PROGRAM_VIEW", _luWINDOW_NAME.GetValue());
                        break;
                    case "REGIT":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_IP_PORT, "PROGRAM_VIEW", _luWINDOW_NAME.GetValue());
                        break;
                }

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    _pFTP_DOWNLOAD_PATH = saveFile.FileName;

                    CoFAS_FTPManager.FTPDownLoad(strFTP_PATH, _luFILE_NAME.Text, _pFTP_ID, _pFTP_PW, _pFTP_DOWNLOAD_PATH);

                    //DisplayMessage("선택한 파일이 지정한 폴더(" + _pFTP_DOWNLOAD_PATH + ")에 저장되었습니다.");
                    DisplayMessage(_pMSG_SAVE+"(path:" + _pFTP_DOWNLOAD_PATH + ")");
                }
            }
            else
            {
                //CoFAS_DevExpressManager.ShowErrorMessage("선택한 파일이 없습니다");
                CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_NO_SELETED_ITEM);
                
            }

        }

        private void _luFILE_NAME__OnDeleteClick(object sender, EventArgs e)
        {
            string strFTP_PATH = "";

            // ftp에서 삭제
            if (_luFILE_NAME.Text != "")
            {
                switch (_luUSE_TYPE.GetValue())
                {
                    case "PRINT":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_IP_PORT, "ORDER_FORM", _luWINDOW_NAME.GetValue());
                        break;
                    case "VIEW":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_IP_PORT, "PROGRAM_VIEW", _luWINDOW_NAME.GetValue());
                        break;
                    case "REGIT":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_IP_PORT, "PROGRAM_VIEW", _luWINDOW_NAME.GetValue());
                        break;
                }

                /*
                //FTP파일은 살려두고 dB에서 yn으로 변경
                 CoFAS_FTPManager.FTPDelete(_luFILE_NAME.Text, strFTP_PATH, _pFTP_ID, _pFTP_PW);
                 CoFAS_DevExpressManager.ShowInformationMessage("선택한 파일이 FTP 서버에서 삭제되었습니다.");

                _luFILE_NAME.Text = "";
                _sdMAIN.ClearSheet();
                */
                //Form_SearchButtonClicked(null, null);
                //저장되어 있는 것인지, 확인하는 과정 - 저장된 파일만 삭제
                if (_luWINDOW_NAME.ReadOnly)
                {
                    _pSheetInfoRegisterEntity.CRUD = "D";
                    Form_DeleteButtonClicked(null, null);
                 
                }
                else
                {
                   // CoFAS_DevExpressManager.ShowErrorMessage("삭제할 파일을 선택해주세요.");
                    CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_SELECT);
                    
                }

                _gdMAIN_VIEW.KeyPress += _gdMAIN_VIEW_KeyPress;
                
            }
            else
            {
                //CoFAS_DevExpressManager.ShowErrorMessage("선택한 파일이 FTP 서버에 없습니다");
                CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_NO_SELETED_ITEM_OR_NO_SAVE);
                

            }
        }

        private void _gdMAIN_VIEW_KeyPress(object sender, KeyPressEventArgs e)
        {
            GridView g = sender as GridView;

            //    gv.GetFocusedRowCellValue("FILE_NAME").ToString();
            int selectedRowNum = g.FocusedRowHandle;
            int selectedCellNum = g.FocusedColumn.VisibleIndex;
        }

        private void _luFILE_NAME__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.DefaultExt = "*";
                ofd.Filter = "Excel.XLSX(*.xlsx)|*.xlsx|ALL(*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _pFullName = ofd.FileName;    // FTP업로드 확인용, 새로운 파일을 올렸을 때만 데이터 입력됨
                    _pFileName = ofd.SafeFileName;

                    _luFILE_NAME.Text = _pFileName;

                    // 선택한 엑셀 파일 spread control에 바인딩
                    using (FileStream stream = new FileStream(ofd.FileName.ToString(), FileMode.Open, FileAccess.Read))
                    {
                        _sdMAIN.LoadDocument(stream, enFileFormat.Xlsx); 
                    }
                }

                for(int i = 1; i < _sdMAIN.Document.Worksheets.Count; i++) 
                {
                    _sdMAIN.Document.Worksheets[i].Visible = false; 
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ _luUSE_TYPE 값 변경 시 이벤트
        private void _luUSE_TYPE_ValueChanged(object sender, EventArgs e)
        {
            UseType_Setting();
        }

        public void UseType_Setting()
        {
            if (_luWINDOW_NAME.ReadOnly)
            {   
                //조회
                string strUSE_TYPE = _luUSE_TYPE.GetValue();
                if (strUSE_TYPE == "VIEW")
                {
                    _luUSE_VEND_CODE.ReadOnly = true;
                    _luPROCESS_CODE.ReadOnly = true;
                    _luFILE_TYPE.ReadOnly = true;


                    _luUSE_VEND_CODE.ItemIndex = 0;
                    _luPROCESS_CODE.ItemIndex = 0;
                }
                else if (strUSE_TYPE == "REGIT")
                {
                    _luUSE_VEND_CODE.ReadOnly = true;
                    _luPROCESS_CODE.ReadOnly = false;
                    _luFILE_TYPE.ReadOnly = false;

                    _luUSE_VEND_CODE.ItemIndex = 0;
                }
                else   // PRINT
                {
                    _luUSE_VEND_CODE.ReadOnly = false;
                    _luPROCESS_CODE.ReadOnly = true;
                    _luFILE_TYPE.ReadOnly = true;

                    _luUSE_VEND_CODE.ItemIndex = 0;
                    _luPROCESS_CODE.ItemIndex = 0;

                }
            }
            else
            {
                //신규저장
                string strUSE_TYPE = _luUSE_TYPE.GetValue();
                if (strUSE_TYPE == "VIEW")
                {
                    _luUSE_VEND_CODE.SetValue("");
                    _luUSE_VEND_CODE.ReadOnly = true;
                    _luPROCESS_CODE.SetValue("");
                    _luPROCESS_CODE.ReadOnly = true;
                    _luFILE_TYPE.SetValue("");
                    _luFILE_TYPE.ReadOnly = true;
                }
                else if (strUSE_TYPE == "REGIT")
                {
                    _luUSE_VEND_CODE.SetValue("");
                    _luUSE_VEND_CODE.ReadOnly = true;
                    _luPROCESS_CODE.ReadOnly = false;
                    _luFILE_TYPE.ReadOnly = false;
                }
                else   // PRINT
                {
                    _luUSE_VEND_CODE.ReadOnly = false;
                    _luPROCESS_CODE.SetValue("");
                    _luPROCESS_CODE.ReadOnly = true;
                    _luFILE_TYPE.SetValue("");
                    _luFILE_TYPE.ReadOnly = true;
                }
            }
        }
        #endregion

        #region ○ 시작위치 cellindex에 맞춰 DB의 list(pDataTable) 바인딩
        public void BindDataSourceToWorksheet(DataTable pDataTable, string cellindex)
        {
            try
            {
                //IWorkbook workbook = _sdMAIN.Document;
                IWorkbook workbook = _sdMAIN.Document;      //uc 기능 필요 .Document
                Worksheet sheet = workbook.Worksheets[0];



                // 1. 데이터가 들어갈 row 삽입
                string row = cellindex.Substring(1);
                int row_num = Convert.ToInt32(row);
                int end_row_num = Convert.ToInt32(row) + pDataTable.Rows.Count;

                sheet.Rows.Insert(row_num, pDataTable.Rows.Count);


                // 2. 시작 위치 셀의 row 전체 양식 복사
                sheet[row_num + ":" + end_row_num].CopyFrom(sheet.Rows[row], PasteSpecial.All);


                // 3. Binding
                ExternalDataSourceOptions dsOptions = new ExternalDataSourceOptions();
                dsOptions.ImportHeaders = false;

                Range range = sheet.Range.Parse(cellindex);
                sheet.DataBindings.BindToDataSource(pDataTable, range, dsOptions);

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


                ////확인
                //if (CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                //{
                //    CoFAS_DevExpressManager.ShowInformationMessage("작업 중인 데이터가 있습니다.");
                //}
                //else
                //{
               
                _pSheetInfoRegisterEntity.WINDOW_NAME = _luT_WINDOW_NAME.GetValue();
                _pSheetInfoRegisterEntity.USE_YN = _luT_USE_YN.GetValue();
                _pSheetInfoRegisterEntity.USE_TYPE = _luT_USE_TYPE.GetValue();
                //_pSheetInfoRegisterEntity.FILE_TYPE = _luT_FILE_TYPE.GetValue();

                _pSheetInfoRegisterEntity.CRUD = "R";

                MainFind_DisplayData();

                UseType_Setting();

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
            ////추가
            //MySqlConnection conn = new MySqlConnection();
            //MySqlCommand cmd = new MySqlCommand();
            ////여기까지

            try
            {
                

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)

                {
                    return;
                }
                else
                {
                    if (!dxValidationProvider.Validate())
                    {
                        //MessageBox.Show("빈값이 있음");
                        return;
                    }

                    //확인
                    //DB에 정보 저장 > 
                    if (_luWINDOW_NAME.ReadOnly)
                    {
                        _pSheetInfoRegisterEntity.CRUD = "U";
                        //_pFTP_BEFROE_FILENAME = _pSheetInfoRegisterEntity.FILE_NAME;
                        _pSheetInfoRegisterEntity.FILE_NAME = _luFILE_NAME.Text.ToString();

                    }
                    else
                    {
                        _pSheetInfoRegisterEntity.CRUD = "C";
                        string _ptime = System.DateTime.Now.ToString("yyyyMMddHHmmss");
                        _pSheetInfoRegisterEntity.FILE_NAME = _ptime + "_" + _luFILE_NAME.Text.ToString();
                    }


                    //_pSheetInfoRegisterEntity.FILE_NAME = _luFILE_NAME.Text.ToString();


                    _pSheetInfoRegisterEntity.WINDOW_NAME = _luWINDOW_NAME.GetValue();
                    _pSheetInfoRegisterEntity.PROCESS_CODE = _luPROCESS_CODE.GetValue();
                    _pSheetInfoRegisterEntity.FILE_TYPE = _luFILE_TYPE.GetValue();
                    _pSheetInfoRegisterEntity.USE_VEND_CODE = _luUSE_VEND_CODE.GetValue();
                    _pSheetInfoRegisterEntity.USE_TYPE = _luUSE_TYPE.GetValue();
                    _pSheetInfoRegisterEntity.USE_YN = _luUSE_YN.GetValue();

                    InputData_Save(_pSheetInfoRegisterEntity.FILE_NAME);

                }
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

        #region ○ 삭제 버튼 클릭시 처리하기
        private void Form_DeleteButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                //Form_SearchButtonClicked(null, null);
                //저장되어 있는 것인지, 확인하는 과정 - 저장된 파일만 삭제
                if (_luWINDOW_NAME.ReadOnly)
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("삭제 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_DELETE_QUESTION) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        _pSheetInfoRegisterEntity.CRUD = "D";
                        InputData_Save(_luFILE_NAME.Text.ToString());
                    }
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowErrorMessage("삭제할 파일을 선택해주세요.");
                    CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_SELECT);
                    
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
                //if (_gdSUB_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSUB_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                //{
                //    if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n초기화 하겠습니까?") == DialogResult.No)
                //    {
                //        return;
                //    }
                //    else
                //    {
                InitializeSetting();
                //조회조건 영역 
                _luT_WINDOW_NAME.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "MENU_LIST", "", "", "").Tables[0], 0, 0, "");
                _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                _luT_USE_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD98", "", "").Tables[0], 0, 0, "");
                _luPROCESS_CODE.ReadOnly = false;
                _luFILE_TYPE.ReadOnly = false;
                _luPROCESS_CODE.ItemIndex = 0;
                _luFILE_TYPE.ItemIndex = 0;
                GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                                            //CoFAS_ControlManager.Controls_Binding(gv, true, this);

                //DisplayMessage("초기화했습니다.");
                DisplayMessage(_pMSG_RESET_COMPLETE);
                //    }
                //}
                //else
                //{
                //    InitializeSetting();
                //    GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                //    CoFAS_ControlManager.Controls_Binding(gv, true, this);

                //    DisplayMessage("초기화했습니다.");
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
        #region ○ 메인조회 - MainFind_DisplayData(bool isBegin)

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new SheetInfoRegisterBusiness().Sheet_Info_Mst(_pSheetInfoRegisterEntity);

                if (_pSheetInfoRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                _lcgMST_VALUE.Text = _luT_WINDOW_NAME.Text.ToString();
                
                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pSheetInfoRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);

                    if (_pLocation_Code != "")
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("SHEETINFO_ID", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        {
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;
                            _luWINDOW_NAME.SetValue(_pLocation_Code);
                        }
                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }



                }
                else
                {
                    _pSheetInfoRegisterEntity.CRUD = "";
                    MainFind_DisplayData();

                    _luT_WINDOW_NAME.Select();

                    InitializeSetting();
                    GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정

                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    
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

        #region ○ 저장 - InputData_Save(string qFileName)

        private void InputData_Save(string qFileName)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                isError = new SheetInfoRegisterBusiness().Sheet_Info_Save(_pSheetInfoRegisterEntity);

                if (isError)
                {
                    //오류 발생.
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    
                    //화면 표시.

                }
                else
                {
                    //정상 처리
                    string strFTP_PATH = "";

                    switch (_luUSE_TYPE.GetValue())
                    {
                        case "PRINT":
                            strFTP_PATH = string.Format(@"{0}{1}/", _pFTP_IP_PORT, "ORDER_FORM");
                            break;
                        case "VIEW":
                            strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_IP_PORT, "USER", "PROGRAM_VIEW");
                            break;
                        case "REGIT":
                            strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_IP_PORT,"USER", "PROGRAM_VIEW");
                            break;
                        default: break;

                    }

                    byte[] data = _sdMAIN.SaveDocument(enFileFormat.Xlsx);



                    if (_pSheetInfoRegisterEntity.CRUD == "C" && _pFullName != null ) // 저장, 추가 생성
                    {
                        //정상 처리

                        if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory(qFileName, _pFTP_ID, _pFTP_PW, strFTP_PATH, _pSheetInfoRegisterEntity.WINDOW_NAME, data)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                        {
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 되었습니다.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                        }
                        else
                        {
                            //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                        }

                    }
                    else if (_pSheetInfoRegisterEntity.CRUD == "U" || _pFullName == null) // 업데이트
                    {
                        //업데이트는, 이전파일명으로 삭제하기
                        //qFileName -> _pFTP_BEFROE_FILENAME
                        //if (CoFAS_FTPManager.FTPDelete(qFileName, strFTP_PATH + _pSheetInfoRegisterEntity.WINDOW_NAME + "/", _pFTP_ID, _pFTP_PW))
                        CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(strFTP_PATH + _pSheetInfoRegisterEntity.WINDOW_NAME + "/", _pFTP_ID, _pFTP_PW);
                        

                        if (CoFAS_FTPManager.FTPDelete(_pFTP_BEFROE_FILENAME, strFTP_PATH + _pSheetInfoRegisterEntity.WINDOW_NAME + "/", _pFTP_ID, _pFTP_PW))
                        {
                            if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory(qFileName, _pFTP_ID, _pFTP_PW, strFTP_PATH, _pSheetInfoRegisterEntity.WINDOW_NAME, data)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                            {
                                //oFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                            }

                            else
                            {
                                //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PLZ_CONNECT_FTP);
                                
                            }
                        }
                        //파일이 없는지 체크
                        else if (!qFTPUtil.IsFTPFileExsit(strFTP_PATH + _pSheetInfoRegisterEntity.WINDOW_NAME + "/" + qFileName))
                        {
                            //정상 처리

                            if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory(qFileName, _pFTP_ID, _pFTP_PW, strFTP_PATH, _pSheetInfoRegisterEntity.WINDOW_NAME, data)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                            {
                                //CoFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
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

                    }
                    else if (_pSheetInfoRegisterEntity.CRUD == "D" || _pFullName == null) // 삭제
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("삭제 되었습니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE);

                        // InitializeSetting();
                        //삭제시 FTP파일은 그대로
                        //  if (CoFAS_FTPManager.FTPDelete(qFileName, strFTP_PATH + _pSheetInfoRegisterEntity.WINDOW_NAME + "/", _pFTP_ID, _pFTP_PW))
                        //  {
                        //      CoFAS_DevExpressManager.ShowInformationMessage("삭제 되었습니다.");
                        //      InitializeSetting();
                        //  }
                        //  else
                        //  {
                        //      //CoFAS_DevExpressManager.ShowErrorMessage("FTP 연결을 확인해주세요.");
                        //      _pSheetInfoRegisterEntity.CRUD = "Y";
                        //      InputData_Save(qFileName);
                        //  }

                    }
                    else if (_pSheetInfoRegisterEntity.CRUD == "Y" || _pFullName == null ) // ftp 삭제 중 에러 발행으로 다시 Y로 돌리기
                    {
                        //CoFAS_DevExpressManager.ShowErrorMessage("삭제 처리 중 에러가 발생했습니다. \nFTP 연결을 확인해주세요.");
                        CoFAS_DevExpressManager.ShowErrorMessage(_pMSG_DELETE_ERROR);
                        
                    }
                    _pLocation_Code = _pSheetInfoRegisterEntity.RTN_KEY;  //저장 위치 



                    _pSheetInfoRegisterEntity.WINDOW_NAME = _luWINDOW_NAME.GetValue();
                    _pSheetInfoRegisterEntity.FILE_NAME = _luFILE_NAME.Text.ToString();
                    _pSheetInfoRegisterEntity.CRUD = "R";
                    _pSheetInfoRegisterEntity.USE_YN = _luT_USE_YN.GetValue();
                    InitializeControl();
                    MainFind_DisplayData();

                    _sdMAIN.ClearSheet();//uc
                                         // InitializeSetting();
                                         //   _gdMAIN.DataSource = null;
                    GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정

                    //_luWINDOW_NAME.ReadOnly = true;
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