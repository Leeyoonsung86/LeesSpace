using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CoFAS_MES.UI.SA.Entity;
using CoFAS_MES.UI.SA.Business;

using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Business;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using CoFAS_MES.CORE.BaseForm;

namespace CoFAS_MES.UI.SA
{
    public partial class SystemCodeRegister : frmBaseNone
    {

        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
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


        private SystemCodeRegisterEntity _pSystemCodeRegisterEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        private int _iLastRowIndex = -1;

        public SystemCodeRegister()
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
                if (_gdSECOND_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSECOND_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_EXIT_QUESTION) == DialogResult.No)
                    {
                        pFormClosingEventArgs.Cancel = true;
                        return;
                    }
                }
                pFormClosingEventArgs.Cancel = false;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));

                throw pExceptionManager;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InputData_Save(DataTable dtSave)", pException);
            }
        }

        #endregion

        #region ○ Form_FormClosed

        private void Form_FormClosed(object pSender, FormClosedEventArgs pFormClosedEventArgs)
        {
            try
            {
                //화면 레이아웃 저장 ?

                _gdFIRST_VIEW.InitNewRow -= _gdFIRST_VIEW_InitNewRow;
                _gdSECOND_VIEW.InitNewRow -= _gdSECOND_VIEW_InitNewRow;
                _gdTHIRD_VIEW.InitNewRow -= _gdTHIRD_VIEW_InitNewRow;

                _gdFIRST_VIEW.RowCellClick -= _gdFIRST_VIEW_RowCellClick;
                _gdSECOND_VIEW.RowCellClick -= _gdSECOND_VIEW_RowCellClick;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));

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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = _pFONT_SETTING;//화면에 모든 항목 폰트 재설정
            }

        }
        #endregion

        protected override bool ProcessDialogKey(Keys keyData)
        {
            Keys keyCode = keyData & Keys.KeyCode;
            if ((keyCode == Keys.Return) && ((keyData & Keys.Modifiers) == Keys.None))
            {
                Control activeControl = GetActiveControl(this);
                if (activeControl != null)
                {
                    return SelectNextControl(activeControl, true, true, true, true);
                }
            }
            return base.ProcessDialogKey(keyData);
        }
        private Control GetActiveControl(ContainerControl containerControl)
        {
            Control result = containerControl.ActiveControl;
            if ((result != null) && (result is ContainerControl))
            {
                result = GetActiveControl((ContainerControl)result);
            }
            return result;
        }

        // 초기화 처리 영역
        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
               // _pnHeader.Visible = true;
               // _pnContent.Visible = true;
               // _pnLeft.Visible = true;

              //  _pnLeft.Width = 250;

              //  _pnContent.Width = 250;

                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);

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
                _pSystemCodeRegisterEntity = new SystemCodeRegisterEntity();
                //_pCommonCodeRegisterEntity.CORP_CODE = _pCORP_CODE;
                _pSystemCodeRegisterEntity.USER_CODE = _pUSER_CODE;
                _pSystemCodeRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

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
                _pSystemCodeRegisterEntity.CRUD = "";

                FirstFind_DisplayData();
                SecondFind_DisplayData(""); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
                ThirdFind_DisplayData("");
                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                if (_pFirstYN)
                {
                    _gdFIRST_VIEW.InitNewRow += _gdFIRST_VIEW_InitNewRow;
                    _gdSECOND_VIEW.InitNewRow += _gdSECOND_VIEW_InitNewRow;
                    _gdTHIRD_VIEW.InitNewRow += _gdTHIRD_VIEW_InitNewRow;

                    _gdFIRST_VIEW.RowCellClick += _gdFIRST_VIEW_RowCellClick;
                    _gdSECOND_VIEW.RowCellClick += _gdSECOND_VIEW_RowCellClick;

                    //  _gdFIRST_VIEW.OptionsBehavior.EditingMode = GridEditingMode.EditForm;
                }

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
                    _gdFIRST_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdFIRST, _gdFIRST_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdFIRST.Name.ToString()));

                }
                _gdSECOND_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSECOND, _gdSECOND_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSECOND.Name.ToString()));

                _gdTHIRD_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdTHIRD, _gdTHIRD_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdTHIRD.Name.ToString()));

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
                _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "", true);
                _luT_USE_YN.ItemIndex = 1;
                _luT_CODE.Text = "";
                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();
                //_luCODE_L.ValueChanged += _luCODE_L_ValueChanged; ;
                //dxValidationProvider.SetValidationRule(_luUSER_MAIL, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _gdFIRST.DataSource = null;
                }

                _gdSECOND.DataSource = null;

                _gdTHIRD.DataSource = null;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {

            }
        }

        #endregion


        // 추가 이벤트 생성
        #region ○ 대분류 그리드 로우 선택 이벤트 생성 - _gdFIRST_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdFIRST_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                if (CoFAS_ConvertManager.DataTable_FindCount(_gdSECOND_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_WORKING);
                    return;
                }

                if (CoFAS_ConvertManager.DataTable_FindCount(_gdTHIRD_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_WORKING);
                    return;
                }

                if (e.RowHandle < 0) return;

                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                string strCODE_TYPE = gv.GetFocusedRowCellValue("CODE").ToString();

                _pSystemCodeRegisterEntity.CRUD = "R";

                SecondFind_DisplayData(strCODE_TYPE);

                _iLastRowIndex = e.RowHandle;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }
        #endregion

        #region ○ 중분류 그리드 로우 선택 이벤트 생성 - _gdSECOND_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdSECOND_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                if (CoFAS_ConvertManager.DataTable_FindCount(_gdFIRST_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_WORKING);
                    return;
                }

                if (CoFAS_ConvertManager.DataTable_FindCount(_gdTHIRD_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_WORKING);
                    return;
                }

                if (e.RowHandle < 0) return;

                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                string strCODE_TYPE = gv.GetFocusedRowCellValue("CODE").ToString();

                _pSystemCodeRegisterEntity.CRUD = "R";

                ThirdFind_DisplayData(strCODE_TYPE);

                _iLastRowIndex = e.RowHandle;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }
        #endregion

        #region ○ 대분류 그리드 신규로우 생성시 이벤트 생성 - _gdFIRST_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdFIRST_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            //중분류 소분류 작업 데이터 있으면 리턴

            if (CoFAS_ConvertManager.DataTable_FindCount(_gdSECOND_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
            {
                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_WORKING);
                return;
            }

            if (CoFAS_ConvertManager.DataTable_FindCount(_gdTHIRD_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
            {
                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_WORKING);
                return;
            }

            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            view.SetRowCellValue(e.RowHandle, view.Columns["CODE_TYPE"], "*");

            view.SetRowCellValue(e.RowHandle, view.Columns["DSP_SEQ"], 0);

            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
        }
        #endregion

        #region ○ 중분류 그리드 신규로우 생성시 이벤트 생성 - _gdSECOND_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdSECOND_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            //소분류 작업 데이터 있으면 리턴

            if (CoFAS_ConvertManager.DataTable_FindCount(_gdFIRST_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
            {
                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_WORKING);

                _gdFIRST_VIEW.FocusedRowHandle = _iLastRowIndex;

                return;
            }

            if (CoFAS_ConvertManager.DataTable_FindCount(_gdTHIRD_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
            {
                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_WORKING);

                _gdFIRST_VIEW.FocusedRowHandle = _iLastRowIndex;

                return;
            }

            if (_gdFIRST_VIEW.FocusedRowHandle < 0)
            {

                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SELECT);

                return;
            }

            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            view.SetRowCellValue(e.RowHandle, view.Columns["CODE_TYPE"], _gdFIRST_VIEW.GetFocusedRowCellValue("CODE").ToString());

            view.SetRowCellValue(e.RowHandle, view.Columns["DSP_SEQ"], 0);

            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
        }
        #endregion

        #region ○ 소분류 그리드 신규로우 생성시 이벤트 생성 - _gdTHIRD_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdTHIRD_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            if (CoFAS_ConvertManager.DataTable_FindCount(_gdFIRST_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
            {
                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_WORKING);

                _gdSECOND_VIEW.FocusedRowHandle = _iLastRowIndex;

                return;
            }

            if (CoFAS_ConvertManager.DataTable_FindCount(_gdSECOND_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
            {
                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_WORKING);

                _gdSECOND_VIEW.FocusedRowHandle = _iLastRowIndex;

                return;
            }

            if (_gdSECOND_VIEW.FocusedRowHandle < 0)
            {
                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SELECT);

                return;
            }

            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            view.SetRowCellValue(e.RowHandle, view.Columns["CODE_TYPE"], _gdSECOND_VIEW.GetFocusedRowCellValue("CODE").ToString());

            view.SetRowCellValue(e.RowHandle, view.Columns["DSP_SEQ"], 0);

            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
        }
        #endregion

        // 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (CoFAS_ConvertManager.DataTable_FindCount(_gdFIRST_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("작업 중인 데이터가 있습니다.");
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_RESET_QUESTION) == DialogResult.Yes)
                    {
                        _pSystemCodeRegisterEntity.CRUD = "R";

                        FirstFind_DisplayData();

                        //SecondFind_DisplayData(_gdFIRST_VIEW.GetRowCellValue(0, "CODE").ToString());
                        //DisplayMessage("조회 되었습니다.");
                        DisplayMessage(_pMSG_SEARCH);
                    }
                }
                else
                {
                    _pSystemCodeRegisterEntity.CRUD = "R";

                    FirstFind_DisplayData();

                    //SecondFind_DisplayData(_gdFIRST_VIEW.GetRowCellValue(0,"CODE").ToString());
                    //DisplayMessage("조회 되었습니다.");
                    DisplayMessage(_pMSG_SEARCH);
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

        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                {
                    return;
                }
                else
                {

                    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                    //if (_gdSECOND_VIEW.RowCount < 1)
                    //{
                    //    //CoFAS_DevExpressManager.ShowInformationMessage("그룹명을 선택해 주세요.");
                    //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SELECT);

                    //    return;
                    //}
                    //if (!dxValidationProvider.Validate())
                    //{
                    //    //MessageBox.Show("빈값이 있음");
                    //    MessageBox.Show(_pMSG_REG_DATA);

                    //    return;
                    //}
                    //if (_gdSECOND_VIEW.GetFocusedRowCellDisplayText("CODE_NAME").ToString() == "")
                    //{
                    //    //CoFAS_DevExpressManager.ShowInformationMessage("코드명을 입력하시길 바랍니다.");//
                    //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_DATA);

                    //    return;
                    //}

                    DataTable _dtFirst = _gdFIRST_VIEW.GridControl.DataSource as DataTable;
                    DataTable _dtSecond = _gdSECOND_VIEW.GridControl.DataSource as DataTable;
                    DataTable _dtThird = _gdTHIRD_VIEW.GridControl.DataSource as DataTable;

                    InputData_Save(_dtFirst, _dtSecond, _dtThird);

                    //InputData_Save(_gdSECOND_VIEW.GridControl.DataSource as DataTable);
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

                if (_gdSECOND_VIEW.GetFocusedRowCellValue(_gdSECOND_VIEW.Columns["CRUD"]).ToString() == "C")
                {
                    // 신규 데이터는 로우 삭제
                    _gdSECOND_VIEW.DeleteRow(_gdSECOND_VIEW.FocusedRowHandle);
                }
                else
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("데이터를 삭제하시겠습니까? \n코드명 : " + _gdSUB_VIEW.GetFocusedRowCellValue(_gdSUB_VIEW.Columns["CODE_NAME"]).ToString()) == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_DELETE_QUESTION) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        // 수정 데이터는 "CRUD" 처리
                        _pSystemCodeRegisterEntity.CRUD = "D";
                        _gdSECOND_VIEW.SetRowCellValue(_gdSECOND_VIEW.FocusedRowHandle, _gdSECOND_VIEW.Columns["CRUD"], "D");
                        InputData_Save(_gdSECOND_VIEW.GridControl.DataSource as DataTable);
                        _gdSECOND_VIEW.GetFocusedDataRow().EndEdit();
                    }
                }

                // 수정 후 포커스 이동 안되면 데이터 반영 안됨. 
                // 삭제 버튼 클릭시에는 GetFocusedDataRow().EndEdit() 처리 해야됨.
                // 마우스 팝업 메뉴에서 처리는 자동으로 처리됨.
                // _gdSUB_VIEW.GetFocusedDataRow().EndEdit(); 

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

                if (_gdSECOND_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdSECOND_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
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

                    }
                }
                else
                {
                    InitializeSetting();

                    //DisplayMessage("초기화했습니다.");
                    DisplayMessage(_pMSG_RESET_COMPLETE);
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

        #region ○ 화면 설정 버튼 클릭시 처리하기 - 언어 및 화면 컨트롤러 명칭 변경 설정
        private void Form_SettingButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                CoFAS_MES.CORE.UserForm.frmPageSetting xfrmPageSetting = new CORE.UserForm.frmPageSetting();
                //xfrmPageSetting.PASS_CORP_CODE = _pCommonCodeRegisterEntity.CORP_CODE;
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
        #region ○ 대분류 조회 - MainFind_DisplayData()

        private void FirstFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pSystemCodeRegisterEntity.CODE = _luT_CODE.Text.ToString();
                _pSystemCodeRegisterEntity.USE_YN = _luT_USE_YN.GetValue();

                _dtList = new SystemCodeRegisterBusiness().SystemCode_Info_First(_pSystemCodeRegisterEntity);

                if (_pSystemCodeRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pSystemCodeRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdFIRST, _gdFIRST_VIEW, _dtList);

                    if (_pLocation_Code != "")
                    {
                        int rowHandle = _gdFIRST_VIEW.LocateByValue("CODE", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        {
                            _gdFIRST_VIEW.FocusedRowHandle = rowHandle;
                        }
                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }


                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    CoFAS_DevExpressManager.BindGridControl(_gdFIRST, _gdFIRST_VIEW, _dtList);
                    CoFAS_DevExpressManager.BindGridControl(_gdSECOND, _gdSECOND_VIEW, _dtList);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {
                _gdSECOND_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 중분류 조회 - SecondFind_DisplayData(string strCODE_TYPE)

        private void SecondFind_DisplayData(string strCODE_TYPE)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pSystemCodeRegisterEntity.CODE_TYPE = strCODE_TYPE;
                _pSystemCodeRegisterEntity.USE_YN = _luT_USE_YN.GetValue();// "Y";

                _dtList = new SystemCodeRegisterBusiness().SystemCode_Info_Second(_pSystemCodeRegisterEntity);

                if (_pSystemCodeRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pSystemCodeRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSECOND, _gdSECOND_VIEW, _dtList);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);

                    _pSystemCodeRegisterEntity.CRUD = "";
                    SecondFind_DisplayData(_pSystemCodeRegisterEntity.CODE_TYPE);
                    ThirdFind_DisplayData(_pSystemCodeRegisterEntity.CODE_TYPE);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {
                _gdSECOND_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        #region ○ 소분류 조회 - ThirdFind_DisplayData(string strCODE_TYPE)

        private void ThirdFind_DisplayData(string strCODE_TYPE)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pSystemCodeRegisterEntity.CODE_TYPE = strCODE_TYPE;
                _pSystemCodeRegisterEntity.USE_YN = _luT_USE_YN.GetValue();// "Y";

                _dtList = new SystemCodeRegisterBusiness().SystemCode_Info_Third(_pSystemCodeRegisterEntity);

                if (_pSystemCodeRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pSystemCodeRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdTHIRD, _gdTHIRD_VIEW, _dtList);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);

                    _pSystemCodeRegisterEntity.CRUD = "";
                    ThirdFind_DisplayData(_pSystemCodeRegisterEntity.CODE_TYPE);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {
                _gdTHIRD_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        #region ○ 저장 - InputData_Save(DataTable dtSave)

        private void InputData_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);


                bool isError = false;
                string strCODE_TYPE = string.Empty;

                if (_gdFIRST_VIEW.GetFocusedRowCellValue("CODE").ToString().Length > 1)
                {
                    strCODE_TYPE = _gdFIRST_VIEW.GetFocusedRowCellValue("CODE").ToString();
                }

                if (_gdSECOND_VIEW.RowCount < 1)
                { return; }


                isError = new SystemCodeRegisterBusiness().SystemCode_Info_Save(_pSystemCodeRegisterEntity, dtSave, strCODE_TYPE);

                if (isError)
                {
                    //오류 발생.
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");

                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.
                }
                else
                {
                    _pLocation_Code = strCODE_TYPE;  //저장 위치 


                    if (_pSystemCodeRegisterEntity.CRUD == "D")
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("삭제 되었습니다.");

                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE);
                    }
                    else
                    {       //정상 처리
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 되었습니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    }

                    strCODE_TYPE = _gdFIRST_VIEW.GetFocusedRowCellValue("CODE").ToString();

                    _pSystemCodeRegisterEntity.CRUD = "R";
                    FirstFind_DisplayData();
                    SecondFind_DisplayData(strCODE_TYPE);
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

        private void InputData_Save(DataTable dtFirst, DataTable dtSecond, DataTable dtThird)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);


                bool isError = false;
                //string strCODE_TYPE = string.Empty;

                //if (_gdFIRST_VIEW.GetFocusedRowCellValue("CODE").ToString().Length > 1)
                //{
                //    strCODE_TYPE = _gdFIRST_VIEW.GetFocusedRowCellValue("CODE").ToString();
                //}

                //if (_gdSECOND_VIEW.RowCount < 1)
                //{ return; }


                isError = new SystemCodeRegisterBusiness().SystemCode_Info_Save(_pSystemCodeRegisterEntity, dtFirst, dtSecond, dtThird);

                if (isError)
                {
                    //오류 발생.
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");

                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.
                }
                else
                {
                    //_pLocation_Code = strCODE_TYPE;  //저장 위치 


                    if (_pSystemCodeRegisterEntity.CRUD == "D")
                    {
                        //CoFAS_DevExpressManager.ShowInformationMessage("삭제 되었습니다.");

                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE);
                    }
                    else
                    {       //정상 처리
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 되었습니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    }

                    //strCODE_TYPE = _gdFIRST_VIEW.GetFocusedRowCellValue("CODE").ToString();

                    _pSystemCodeRegisterEntity.CRUD = "R";
                    FirstFind_DisplayData();
                    _pSystemCodeRegisterEntity.CRUD = "";
                    SecondFind_DisplayData("");
                    ThirdFind_DisplayData("");
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
