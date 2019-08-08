using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

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
using System.Net.Sockets;

namespace CoFAS_MES.UI.QC
{
    public partial class RawMaterialInspectRegister_T01 : frmBaseNone
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

        private string serial_check = string.Empty; // 연결체크용
        private CoFAS_Serial _pCoFAS_Serial = null;  // 시리얼 생성
        CoFAS_SocketServer _pCoFASSocketServer = null;  //서버 오픈
        private string _sControl = string.Empty;
        private string[] serial_port = SerialPort.GetPortNames();

        private RawMaterialInspectRegisterT01Entity _pRawMaterialInspectRegisterT01Entity = null; // 엔티티 생성


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
        private DataTable _dtList_sub = null; //조회 데이터 리스트
        private Stream responseStream_tmp = null;
        public RawMaterialInspectRegister_T01()
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

                CoFAS_DevExpressManager._OnButtonPressed -= CoFAS_DevExpressManager_OnButtonPressed;
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

                if (_pCoFAS_Serial == null) return;
                if(_pCoFAS_Serial.IsOpen)
                {
                    _pCoFAS_Serial.Dispose();
                }
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
                _pnLeft.Visible = false;
                _pnRight.Visible = true;

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
                _pRawMaterialInspectRegisterT01Entity = new RawMaterialInspectRegisterT01Entity();
                //_pProcessCodeMstRegisterEntity.CORP_CODE = _pCORP_CODE;
                _pRawMaterialInspectRegisterT01Entity.USER_CODE = _pUSER_CODE;
                _pRawMaterialInspectRegisterT01Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pRawMaterialInspectRegisterT01Entity.WINDOW_NAME = _pWINDOW_NAME;
                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                // _sdMAIN.CellBeginEdit += _sdMAIN_CellBeginEdit1;
                //그리드 설정
                InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 
                //메인 그리드
                _gdMAIN.DataSource = null;

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pRawMaterialInspectRegisterT01Entity.CRUD = "";
                _pRawMaterialInspectRegisterT01Entity.INSPECT_ID = "";
                _sControl = string.Empty;
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

                    _luT_INSPECT_STATUS.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "INSPECT_STATUS_AC", "", "", "").Tables[0], 0, 0, "");

                    _luT_INSPECT_STATUS.ItemIndex = 0;

                    _pFirstYN = false;

                    // 사용 가능한 COM 조회
                    for (int i = 0; i < serial_port.Length; i++)
                    {
                        _luCOM_TYPE.ItemAdd(serial_port[i]);
                    }
                    _luCOM_TYPE.SelectedIndex = 0;
                }

            }
            catch (Exception e)
            {

            }
        }

        private void _luT_PART__OnOpenClick(object sender, EventArgs e)
        {
            try
            {

                //VendCostInfo
                UserForm.frmCommonPopup.CRUD = "R";
                UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" };
                UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _luT_PART.CodeText.ToString(), _luT_PART.NameText.ToString() };
                UserForm.frmCommonPopup xfrmCommonPopup = new UserForm.frmCommonPopup("ucInspectPartListPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luT_PART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();
                    _luT_PART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                    
                }

                xfrmCommonPopup.Dispose();

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
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



                    _pRawMaterialInspectRegisterT01Entity.CRUD = "R";
                    _pRawMaterialInspectRegisterT01Entity.DATE_FROM = DateTime.Parse(_luT_ACCEPT_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luTORDER_DATE.FromDateTime).Replace("-", "").Substring(0, 8);//
                    _pRawMaterialInspectRegisterT01Entity.DATE_TO = DateTime.Parse(_luT_ACCEPT_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luTORDER_DATE.ToDateTime).Replace("-", "").Substring(0, 8);//
                    //_pRawMaterialInspectRegisterEntity.VEND_NAME = _luTVEND.NameText;
                    //_pRawMaterialInspectRegisterEntity.VEND_CODE = _luTVEND.CodeText;
                    _pRawMaterialInspectRegisterT01Entity.PART_NAME = _luT_PART.NameText;
                    //_pRawMaterialInspectRegisterT01Entity.PART_CODE = 
                    _pRawMaterialInspectRegisterT01Entity.VEND_PART_CODE = _luT_PART.CodeText;
                    //_pRawMaterialInspectRegisterEntity.USE_YN = _luTUSE_YN.GetValue();
                    _pRawMaterialInspectRegisterT01Entity.INSPECT_STATUS = _luT_INSPECT_STATUS.GetValue();
                    //
                    _luPART_LOT_ID.Text = "";
                    _luWEIGHT.Text = "";
                    _gdSUB.DataSource = null;
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

                GridView g = pSender as GridView;

                _pRawMaterialInspectRegisterT01Entity.CRUD = "U";
                _pRawMaterialInspectRegisterT01Entity.PART_LOT_ID = _luPART_LOT_ID.Text.ToString();
                _pRawMaterialInspectRegisterT01Entity.WEIGHT = _luWEIGHT.Text.ToString();
                

                // sheet_1.DataBindings.BindToDataSource(_dtList, 1, 0, dsOptions);
                //DataTable pSheet_1_Convert = workbook.Worksheets[2];
                //DataTable pSheet_1_Convert = sheet_1.DataBindings.CreateDataSource(data_range);
                //BindingSource bs = (BindingSource)sheet_1.DataBindings.GetDataBindings(data_range);
                //BindingSource bs = (BindingSource)sheet_1.DataBindings.CreateDataSource(data_range);

                InputData_Save(_pRawMaterialInspectRegisterT01Entity);

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
                //{
                //    return;
                //}
                //else
                //{
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

        private void InputData_Save(RawMaterialInspectRegisterT01Entity _pRawMaterialInspectRegisterT01Entity)
        {
            try
            {


                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;
                DataTable dt;
                DataTable dtTemp = null;

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.Yes)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                {
                    //승인/미승인상태면 수정x, 빈값이면 ok
                    if (_pApproval_YN)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("승인/미승인 상태는 수정불가 합니다.");
                        return;
                    }
                    

                    dt = _gdSUB.DataSource as DataTable;
                    if ((CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "")))
                    {
                        dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", "");
                    }

                    isError = new RawMaterialInspectRegisterT01Business().RawMaterialInspectRegisterT01_Info_Mst_Save(_pRawMaterialInspectRegisterT01Entity, dtTemp);

                    if (isError)
                    {
                        //오류 발생.
                        //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    }
                    else
                    {
                        _pLocation_Code = _pRawMaterialInspectRegisterT01Entity.RTN_KEY;  //저장 위치
                        

                        //정상 처리
                        //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                        InitializeSetting();
                        Form_SearchButtonClicked(null, null);
                    }
                    //isError = new RawMaterialInspectRegisterT01Business().RawMaterialInspectRegisterT01_Info_Mst_Save();
                    //isError = new RawMaterialInspectRegisterT01Business().RawMaterialInspectRegisterT01_Info_Mst_Save(_pRawMaterialInspectRegisterT01Entity);
                    //// 자재입고
                    //if (isError)
                    //{
                    //    //오류 발생.
                    //    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //}
                    //else
                    //{

                    //    isError = new RawMaterialInspectRegisterT01Business().RawMaterialInspectRegisterT01_Info_Detail_Save(_pRawMaterialInspectRegisterT01Entity);
                    //    if (isError)
                    //    {
                    //        //오류 발생.
                    //        //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    //        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //    }
                    //    else
                    //    {
                    //        _pLocation_Code = _pRawMaterialInspectRegisterT01Entity.RTN_KEY;  //저장 위치
                    //        Form_SearchButtonClicked(null, null);

                    //        //정상 처리
                    //        //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    //        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    //        //InitializeControl(false);

                    //    }


                    //}
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
            try
            {

                //QC020001 : 승인
                //QC020002 : 미승인
                //승인인경우 수정x
                if (gv.GetFocusedRowCellValue("APPROVAL").ToString() != "QC020001")
                    _pApproval_YN = false;
                else
                    _pApproval_YN = true;


                int qRowIndex = gv.FocusedRowHandle;
                if (qRowIndex < 0) return;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);


                _gdSUB.DataSource = null;
                _pRawMaterialInspectRegisterT01Entity.INSPECT_ID = gv.GetFocusedRowCellValue("INSPECT_ID").ToString();
                _pRawMaterialInspectRegisterT01Entity.REFERENCE_ID = gv.GetFocusedRowCellValue("REFERENCE_ID").ToString();
                _pRawMaterialInspectRegisterT01Entity.PART_WEIGHT_ID = gv.GetFocusedRowCellValue("PART_WEIGHT_ID").ToString();
                _pRawMaterialInspectRegisterT01Entity.CRUD = "R";
                SubFind_DisplayData();


            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
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
                    _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));

                    CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager_OnButtonPressed;
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

                _luPART_LOT_ID.Text = "";
                _luWEIGHT.Text = "";

                _gdMAIN.DataSource = null;
                _gdSUB.DataSource = null;

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //dxValidationProvider.SetValidationRule(_luGRID_NAME, NotEmptyValidationRule);
                //dxValidationProvider.SetValidationRule(_luGRIDVIEW_NAME, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                _luCOM_TYPE.DisableTextEditor();
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
                _dtList = new RawMaterialInspectRegisterT01Business().Sample_Info(_pRawMaterialInspectRegisterT01Entity);

                if (_pRawMaterialInspectRegisterT01Entity.CRUD == "")
                    _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pRawMaterialInspectRegisterT01Entity.CRUD == ""))
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

        #region 서브조회
        private void SubFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList_sub = new RawMaterialInspectRegisterT01Business().Sample_Info_Sub(_pRawMaterialInspectRegisterT01Entity);

                if (_pRawMaterialInspectRegisterT01Entity.CRUD == "")
                    _dtList_sub.Rows.Clear();

                if ((_dtList_sub != null && _dtList_sub.Rows.Count > 0) || (_dtList_sub != null && _pRawMaterialInspectRegisterT01Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList_sub); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList_sub); //데이터 필드에 맞춰 자동 바인딩
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

        #region ○ H/W 세팅시
        private void SetHardware()
        {
            try
            {
                //_pBarcodePrintRegisterEntity.TERMINAL_NAME = _luCOM_TYPE.Text;

                //_dtList_terminal = new BarcodePrintRegisterBusiness().BarcodePrintRegister_Info_sub(_pBarcodePrintRegisterEntity);

                if (serial_port.Length < 0) return;

                if (serial_check == "")
                {
                    //_pCoFAS_Serial = new CoFAS_Serial(_dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString()), _dtList_terminal.Rows[0]["INFO_PARITY"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString()), _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString());
                    _pCoFAS_Serial = new CoFAS_Serial(_luCOM_TYPE.SelectedItem.ToString(), 9600, "NONE", 8, "ONE");

                    _pCoFAS_Serial.Open();
                    _pCoFAS_Serial.evtReceived += new CoFAS_Serial.delReceive(Serial_DataReceived);

                    // 연결할 H/W 연결상태 표시. (연동시 변경)
                    lc_0.Appearance.Image = global::CoFAS_MES.UI.QC.Properties.Resources.plug_Green;

                    //serial_check = _dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString();
                    serial_check = _luCOM_TYPE.SelectedItem.ToString();

                    CoFAS_DevExpressManager.ShowInformationMessage("연결 되었습니다.");
                }
                else //값이 있으면
                {
                    //컴포트값이 다르면
                    //if (serial_check != _dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString())
                    if (serial_check != _luCOM_TYPE.SelectedItem.ToString())
                    {
                        //연결 끊고 새로운거로 연결

                        _pCoFAS_Serial.evtReceived -= new CoFAS_Serial.delReceive(Serial_DataReceived);
                        _pCoFAS_Serial.Dispose();
                        _pCoFAS_Serial.Close();

                        //_pCoFAS_Serial = new CoFAS_Serial(_dtList_terminal.Rows[0]["INFO_PORTNAME"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_BAUDRATE"].ToString()), _dtList_terminal.Rows[0]["INFO_PARITY"].ToString(), Convert.ToInt32(_dtList_terminal.Rows[0]["INFO_DATABITS"].ToString()), _dtList_terminal.Rows[0]["INFO_STOPBITS"].ToString());
                        _pCoFAS_Serial = new CoFAS_Serial(_luCOM_TYPE.SelectedItem.ToString(), 9600, "NONE", 8, "ONE");

                        _pCoFAS_Serial.evtReceived -= new CoFAS_Serial.delReceive(Serial_DataReceived);
                        _pCoFAS_Serial.Dispose();

                        //_pCoFAS_Serial = new CoFAS_Serial("com3", 9600, "NONE", 8, "ONE");
                        _pCoFAS_Serial.Open();
                        _pCoFAS_Serial.evtReceived += new CoFAS_Serial.delReceive(Serial_DataReceived);

                        // 연결할 H/W 연결상태 표시. (연동시 변경)
                        lc_0.Appearance.Image = global::CoFAS_MES.UI.QC.Properties.Resources.plug_Green;

                        serial_check = _luCOM_TYPE.SelectedItem.ToString();

                        CoFAS_DevExpressManager.ShowInformationMessage("연결 되었습니다.");
                    }
                    else
                    {
                        //연결되어있는 상태니 재연결 할 필요 없음
                        CoFAS_DevExpressManager.ShowInformationMessage("이미 연결된 포트입니다.");
                    }
                }

            }
            catch (Exception ex)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("POP Serial Error");
            }
        }

        #endregion


        #region 시험의뢰 불러오기
        private void _ucbtINSPECT_REQUEST_Click(object sender, EventArgs e)
        {
            try
            {
                string part_type = "1004";
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.ARRAY = new object[2] { "Material_Code", _luT_PART.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup.ARRAY_CODE = new object[3] { _luT_PART.CodeText, _luT_PART.NameText, part_type };
                CoFAS_MES.UI.QC.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.QC.UserForm.frmCommonPopup("InspectRequest_T01"); //유저컨트롤러 설정 부분

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

        #region H/W 연결확인
        private void _luCONNECTION_Click(object sender, EventArgs e)
        {
            SetHardware();
        }
        #endregion

        #region Serial_DataReceived
        private void Serial_DataReceived(byte[] byReceiveData)
        {
            string sReceiveData = string.Empty;
            string sWeightMeter = string.Empty;
            try
            {
                if(byReceiveData.Length > 0)
                {
                    sReceiveData = CoFAS_ConvertManager.Bytes2String(byReceiveData, 0, 0);
                    //MessageBox.Show("" + sReceiveData);
                    //MessageBox.Show("" + sReceiveData.ToString().Substring(11, 5).Trim());
                    sWeightMeter = sReceiveData.ToString().Substring(11, 5).Trim();

                    if (_sControl == "MAINGRID")
                    {
                        CoFAS_ControlManager.InvokeIfNeeded(_luWEIGHT, () => { _luWEIGHT.Text = sWeightMeter; });
                    }
                    else if(_sControl == "SUBGRID")
                    {
                        CoFAS_ControlManager.InvokeIfNeeded(_gdSUB, () => _gdSUB_VIEW.SetFocusedRowCellValue(_gdSUB_VIEW.Columns["WEIGHT"], sWeightMeter));
                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region 무게 측정 (MAIN)
        private void _ucbtWeightRequest_Click(object sender, EventArgs e)
        {
            if(_pRawMaterialInspectRegisterT01Entity.INSPECT_ID == "" || _pRawMaterialInspectRegisterT01Entity.INSPECT_ID == null) 
            {
                CoFAS_DevExpressManager.ShowInformationMessage("접수된 자재를 선택해주세요.");
                return;
            }

            CheckWeight("MAINGRID");
        }

        #endregion

        #region ○ 그리드 버튼추가 ( SUB 무게 측정)
        private void CoFAS_DevExpressManager_OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = null;
            string strFTP_PATH = "";
            string tempFolderPath = "";

            switch (e.Button.Caption.ToString())
            {
                case "BTN_WEIGHT":
                    CheckWeight("SUBGRID");
                    break;
                //case "VEND_DOCUMENT_VIEW_SUB_BTN":

                //    dr = _gdSUB_VIEW.GetFocusedDataRow();
                //    if (dr == null) return;
                //    strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "FILE_DATA", dr["DOCUMENT_TYPE"].ToString());

                //    tempFolderPath = System.IO.Path.GetTempPath() + dr["DOCUMENT_FILE_NAME"].ToString();

                //    CoFAS_FTPManager.FTPFileView(strFTP_PATH, dr["DOCUMENT_FILE_NAME"].ToString(), _pFTP_ID, _pFTP_PW, tempFolderPath);

                //    break;
            }
        }
        #endregion

        private void CheckWeight(string _sControl)
        {
            try
            {
                if (_pCoFAS_Serial == null)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("Serial 연결을 확인해주세요");
                    return;
                }

                if (_sControl == null || _sControl == "")
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("무게 측정을 위한 정보를 선택해주세요");
                    return;
                }
                this._sControl = _sControl;
                if (_pCoFAS_Serial.IsOpen)
                {
                    _pCoFAS_Serial.Write("01RW");
                    //CRLF
                    _pCoFAS_Serial.Write("\r\n");
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
    }
}



