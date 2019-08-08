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

namespace CoFAS_MES.UI.MM
{
    public partial class MaterialOrderRegister : frmBaseNone
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

        private MaterialOrderRegisterEntity _pMaterialOrderRegisterEntity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private Object _ojList = null;    //엑셀파일  //추가
        private DataSet _stList = null;   //DataSet  //추가

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부


        #endregion

        #region ○ 생성자

        public MaterialOrderRegister()
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
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING+"\n"+ _pMSG_EXIT_QUESTION) == DialogResult.No)
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

                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);
                //_luORDER_QTY._OnKeyDown += new ucTextEdit.OnKeyDownEventHandler(_luORDER_QTY__OnKeyDown);
                _luORDER_QTY._OnTextChanged += new EventHandler(_luORDER_QTY__OnTextChanged);
                _luUNIT_COST._OnTextChanged += new EventHandler(_luORDER_QTY__OnTextChanged);
                // _luUNIT_COST.KeyPress += new KeyPressEventHandler(_luUNIT_COST_KeyPress);
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
                _pnContent.Width = 200;
                _luORDER_DATE.ReadOnly = false;
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

                //메뉴 화면 엔티티 설정
                _pMaterialOrderRegisterEntity = new MaterialOrderRegisterEntity();
                //_pMaterialOrderRegisterEntity.CORP_CODE = _pCORP_CODE;
                _pMaterialOrderRegisterEntity.USER_CODE = _pUSER_CODE;
                _pMaterialOrderRegisterEntity.WINDOW_NAME = _pWINDOW_NAME;
                _pMaterialOrderRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                
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
                InitializeControl(true);

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                //if (_pFirstYN)
                //{
                    MainFind_DisplayData("");
                    _pFirstYN = false;
                //}

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
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
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl(bool FirstChk)
        {
            try
            {
                //조회조건 영역
                _luT_ORDER_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luT_ORDER_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                _luT_PART_CODE.CodeText = "";
                _luT_PART_CODE.NameText = "";
                _luT_VEND_CODE.CodeText = "";
                _luT_VEND_CODE.NameText = "";

                _luTORDER_ID.Text = "";
                _luTREFERENCE_ID.Text = "";
                _luTVEND_PART_CODE.Text = "";

                _luTUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                _luTUSE_YN.ItemIndex = 0;

                //데이터 영역


                _luORDER_DATE.DateTime = DateTime.Today;

                _luORDER_ID.Text = "";
                _luORDER_ID.ReadOnly = true;

                _luREFERENCE_ID.Text = "";   // 수주번호
                _luREFERENCE_ID.ReadOnly = true;

                _luUNIT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                _luUNIT_CODE.ReadOnly = true;

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                _luUSE_YN.ItemIndex = 0;

                _luPART.CodeText = "";
                _luPART.NameText = "";
                _luPART.CodeReadOnly = true;
                _luPART.NameReadOnly = true;

                _luVEND.CodeText = "";
                _luVEND.NameText = "";
                _luVEND.CodeReadOnly = true;
                _luVEND.NameReadOnly = true;

                _luSTOCK_QTY.Text = "0";
                _luSTOCK_QTY.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

                _luORDER_QTY.Text = "0";
                _luORDER_QTY.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                _luORDER_QTY.ReadOnly = false;

                _luUNIT_COST.Text = "0";
                _luUNIT_COST.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                _luUNIT_COST.ReadOnly = false;

                _luCOST.Text = "0";
                _luCOST.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                _luCOST.EditMask = "n2";
                _luCOST.ReadOnly = true;

                _luREQUEST_DATE.DateTime = DateTime.Today;


                _luREQUEST_LOCATION.Text = "";
                _luUNIT_COST.ReadOnly = false;

                _luREMARK.Text = "";
                _luREMARK.ReadOnly = false;

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                dxValidationProvider.SetValidationRule(_luORDER_QTY, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _gdMAIN.DataSource = null;
                }

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

        // 추가이벤트 설정
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;


                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                if (gv.FocusedRowHandle < 0) return;

                string pORDER_ID = gv.GetFocusedRowCellValue("ORDER_ID").ToString();
                if (pORDER_ID != null)
                    _luORDER_DATE.ReadOnly = true;
                //SubFind_DisplayData(pORDER_ID);

                
                if (gv.GetFocusedRowCellValue("CRUD").ToString().Equals("Y"))
                {
                    gv.SetFocusedRowCellValue("CRUD", "N");
                }
                else
                {
                    gv.SetFocusedRowCellValue("CRUD", "Y");
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 입력 데이터 조사하기 - CheckInputData()

        private bool CheckInputData()
        {
            bool pErrorYN = false;
            string pErrName = string.Empty;

            try
            {

                if (_luPART.CodeText == "")
                    pErrName += "材料, "; //품목코드

                if (_luVEND.CodeText == "")
                    pErrName += "取引先, ";//거래처코드

                if (_luORDER_QTY.Text == "" || _luORDER_QTY.Text == "0" || Convert.ToDecimal(_luORDER_QTY.Text) < 1)
                    pErrName += "数量 "; //입고수량

                if (pErrName != "")
                {
                    pErrorYN = true;
                    // DisplayMessage(pErrName);
                    // DisplayMessage(_pMSG_CHECK_VALID_ITEM);
                    DisplayMessage(_pMSG_CHECK_VALID_ITEM + "(" + pErrName + ")");
                }
            }
            catch (Exception pException)
            {
                pErrorYN = true;
                CoFAS_DevExpressManager.ShowErrorMessage(pException);
            }
            return pErrorYN;
        }

        #endregion

        #region ● 메인 버튼 처리영역

        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                if (_luT_ORDER_DATE.FromDateTime > _luT_ORDER_DATE.ToDateTime)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 일자를 확인해 주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_SEARCH_DATE);
                    return;
                }
                if (CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                        // CoFAS_DevExpressManager.ShowInformationMessage("작업 중인 데이터가 있습니다.");
                        if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING+"\n"+ _pMSG_RESET_QUESTION) == DialogResult.No)
                        {
                        MainFind_DisplayData("R");

                        //DisplayMessage("조회 되었습니다.");
                        DisplayMessage(_pMSG_SEARCH);
                    }

                }
                else
                {
                    MainFind_DisplayData("R");

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

                if (CheckInputData())
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("필수항목을 확인해주시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }

                if (!dxValidationProvider.Validate())
                {
                    //MessageBox.Show("빈값이 있음");
                    MessageBox.Show(_pMSG_CHECK_VALID_ITEM);
                    return;
                }

                decimal intQty_chk = Convert.ToDecimal(_luORDER_QTY.Text);

                if (intQty_chk < 0)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("발주수량이 0보다 작을 수 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_ORDERQTY_LARGE_THAN_0);
                    return;
                }

                //확인
                if (_luORDER_ID.Text.ToString() != "")
                {
                    _pMaterialOrderRegisterEntity.CRUD = "U";
                }
                else
                {
                    _pMaterialOrderRegisterEntity.CRUD = "C";
                }

           
                _pMaterialOrderRegisterEntity.USER_CODE = _pUSER_CODE;
                _pMaterialOrderRegisterEntity.ORDER_ID = _luORDER_ID.Text;
                //_pMaterialOrderRegisterEntity.ORDER_DATE = _luORDER_DATE.DateTime.ToString().Substring(0,10).Replace("-", "").ToString();
                _pMaterialOrderRegisterEntity.ORDER_DATE = DateTime.Parse(_luORDER_DATE.DateTime.ToString()).ToString("yyyyMMdd");

                _pMaterialOrderRegisterEntity.ORDER_SEQ = "";
                _pMaterialOrderRegisterEntity.VEND_CODE = _luVEND.CodeText;
                _pMaterialOrderRegisterEntity.PART_CODE = _luPART.CodeText;
                _pMaterialOrderRegisterEntity.ORDER_QTY = _luORDER_QTY.Text;
                //_pMaterialOrderRegisterEntity.REQUEST_DATE = _luREQUEST_DATE.DateTime.ToString().Substring(0, 10).Replace("-", "").ToString();
                _pMaterialOrderRegisterEntity.REQUEST_DATE = DateTime.Parse(_luREQUEST_DATE.DateTime.ToString()).ToString("yyyyMMdd");
                _pMaterialOrderRegisterEntity.REQUEST_LOCATION = _luREQUEST_LOCATION.Text;
                _pMaterialOrderRegisterEntity.UNIT_CODE = _luUNIT_CODE.GetValue();
                _pMaterialOrderRegisterEntity.UNITCODT_CURRENCY_CODE = _luREQUEST_LOCATION.Text; 
                _pMaterialOrderRegisterEntity.UNITCOST = _luUNIT_COST.Text;
                _pMaterialOrderRegisterEntity.COST = _luCOST.Text;
                _pMaterialOrderRegisterEntity.CONTRACT_ID = _luREFERENCE_ID.Text;
                _pMaterialOrderRegisterEntity.REMARK = _luREMARK.Text;
                _pMaterialOrderRegisterEntity.USE_YN = _luUSE_YN.GetValue();


                InputData_Save(_pMaterialOrderRegisterEntity);
               

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

                //확인
                if (_luORDER_ID.Text.ToString() != "")
                {
                    _pMaterialOrderRegisterEntity.CRUD = "D";
                }
                else
                {
                    //MessageBox.Show("발주 정보를 선택하세요.");
                    MessageBox.Show(_pMSG_CHECK_VALID_ITEM);
                    return;
                }
                //if (CoFAS_DevExpressManager.ShowQuestionMessage("발주 데이터를 삭제하시겠습니까? \n 발주번호 : " + _luORDER_ID.Text) == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_DELETE_QUESTION + " : " + _luORDER_ID.Text) == DialogResult.No)
                {
                    return;
                }



                _pMaterialOrderRegisterEntity.USER_CODE = _pUSER_CODE;
                _pMaterialOrderRegisterEntity.ORDER_ID = _luORDER_ID.Text;
                //_pMaterialOrderRegisterEntity.ORDER_DATE = _luORDER_DATE.DateTime.ToString().Substring(0, 10).Replace("-", "").ToString();
                _pMaterialOrderRegisterEntity.ORDER_DATE = DateTime.Parse(_luORDER_DATE.DateTime.ToString()).ToString("yyyyMMdd");

                _pMaterialOrderRegisterEntity.ORDER_SEQ = "";
                _pMaterialOrderRegisterEntity.VEND_CODE = _luVEND.CodeText;
                _pMaterialOrderRegisterEntity.PART_CODE = _luPART.CodeText;
                _pMaterialOrderRegisterEntity.ORDER_QTY = _luORDER_QTY.Text;
                //_pMaterialOrderRegisterEntity.REQUEST_DATE = _luREQUEST_DATE.DateTime.ToString().Substring(0, 10).Replace("-", "").ToString();
                _pMaterialOrderRegisterEntity.REQUEST_DATE = DateTime.Parse(_luREQUEST_DATE.DateTime.ToString()).ToString("yyyyMMdd");
                _pMaterialOrderRegisterEntity.REQUEST_LOCATION = _luREQUEST_LOCATION.Text;
                _pMaterialOrderRegisterEntity.UNIT_CODE = _luUNIT_CODE.GetValue();
                _pMaterialOrderRegisterEntity.UNITCODT_CURRENCY_CODE = _luREQUEST_LOCATION.Text;
                _pMaterialOrderRegisterEntity.UNITCOST = _luUNIT_COST.Text;
                _pMaterialOrderRegisterEntity.COST = _luCOST.Text;
                _pMaterialOrderRegisterEntity.CONTRACT_ID = _luREFERENCE_ID.Text;
                _pMaterialOrderRegisterEntity.REMARK = _luREMARK.Text;
                _pMaterialOrderRegisterEntity.USE_YN = "Y";


                InputData_Save(_pMaterialOrderRegisterEntity);
                MainFind_DisplayData("R");
                //InitializeControl(false);


             

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

        //#region ○ 내보내기 버튼 클릭시 처리하기
        //private void Form_ExportButtonClicked(object pSender, EventArgs pEventArgs)
        //{
        //    try
        //    {
        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

        //        //if (fpMain.ActiveSheet.RowCount > 0)
        //        //{
        //        //    SaveFileDialog mDlg = new SaveFileDialog();
        //        //    mDlg.InitialDirectory = Application.StartupPath;
        //        //    mDlg.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
        //        //    mDlg.FilterIndex = 1;
        //        //    if (mDlg.ShowDialog() == DialogResult.OK)
        //        //    {
        //        //        fpMain.SaveExcel(mDlg.FileName, FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders);
        //        //        DevExpressManager.ShowInformationMessage("저장이 완료 되었습니다.");
        //        //    }
        //        //}
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
        //    }
        //    finally
        //    {
        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
        //    }
        //}

        //#endregion

        #region ○ 내보내기 버튼 클릭시 처리하기
        private void Form_ExportButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (_gdMAIN_VIEW.RowCount > 0)//if (fpMain.ActiveSheet.RowCount > 0)
                {
                    SaveFileDialog mDlg = new SaveFileDialog();
                    mDlg.InitialDirectory = Application.StartupPath;
                    mDlg.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
                    mDlg.FilterIndex = 1;
                    if (mDlg.ShowDialog() == DialogResult.OK)
                    {
                        //string FileName = "C:\\Users\\kjh\\Desktop\\COMES_EXPORT\\Grid.xls";//"C:\\MyFiles\\Grid.xls";
                        //_gdMAIN_VIEW.ExportToXls(FileName);

                        _gdMAIN_VIEW.ExportToXls(mDlg.FileName);
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE); //저장 처리 되었습니다.
                    }
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT); //조회항목이 없습니다.
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

                if (_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n초기화 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING+"\n"+ _pMSG_RESET_QUESTION) == DialogResult.No)
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
                //xfrmPageSetting.PASS_CORP_CODE = _pMaterialOrderRegisterEntity.CORP_CODE;
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

        #endregion

        #region ● DB 처리

        #region ○ 메인조회 - MainFind_DisplayData(string pCRUD)

        private void MainFind_DisplayData(string pCRUD)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pMaterialOrderRegisterEntity.CRUD = pCRUD;
                //_pMaterialOrderRegisterEntity.DATE_FROM = Convert.ToString(_luT_ORDER_DATE.FromDateTime).Substring(0, 10).Replace("-", "");
                //_pMaterialOrderRegisterEntity.DATE_TO = Convert.ToString(_luT_ORDER_DATE.ToDateTime).Substring(0, 10).Replace("-", "");
                _pMaterialOrderRegisterEntity.DATE_FROM = DateTime.Parse(_luT_ORDER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");
                _pMaterialOrderRegisterEntity.DATE_TO   = DateTime.Parse(_luT_ORDER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");

                _pMaterialOrderRegisterEntity.ORDER_ID = _luTORDER_ID.Text;
                _pMaterialOrderRegisterEntity.REFERENCE_ID = _luTREFERENCE_ID.Text;
                _pMaterialOrderRegisterEntity.VEND_PART_CDOE = _luTVEND_PART_CODE.Text;
                _pMaterialOrderRegisterEntity.USE_YN = _luTUSE_YN.GetValue();
                _pMaterialOrderRegisterEntity.VEND_CODE = _luT_VEND_CODE.CodeText.ToString() ;
                _pMaterialOrderRegisterEntity.VEND_NAME = _luT_VEND_CODE.NameText.ToString();
                _pMaterialOrderRegisterEntity.PART_CODE = _luT_PART_CODE.CodeText.ToString();
                _pMaterialOrderRegisterEntity.PART_NAME = _luT_PART_CODE.NameText.ToString();

           


                using (DBManager pDBManager = new DBManager())
                {

                    _dtList = new MaterialOrderRegisterProvider(pDBManager).MaterialOrderRegister_R10(_pMaterialOrderRegisterEntity);

                    if (_dtList != null && _dtList.Rows.Count > 0)
                    {
                        if (pCRUD == "")
                            _dtList.Rows.Clear();

                        CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);

                        if (_pLocation_Code != "" && _pLocation_YN)
                        {
                            int rowHandle = _gdMAIN_VIEW.LocateByValue("ORDER_ID", _pLocation_Code);
                            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                                _gdMAIN_VIEW.FocusedRowHandle = rowHandle;


                            //조회 후 초기화 
                            _pLocation_Code = "";
                        }



                    }
                    else
                    {
                        if(pCRUD == "R")
                        //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                        _dtList.Rows.Clear();
                        CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    }
                }

             

                //데이터 영역


                _luORDER_DATE.DateTime = DateTime.Today;

                _luORDER_ID.Text = "";
                _luORDER_ID.ReadOnly = true;

                _luREFERENCE_ID.Text = "";   // 수주번호
                _luREFERENCE_ID.ReadOnly = true;

                _luUNIT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                _luUNIT_CODE.ReadOnly = true;

                _luPART.CodeText = "";
                _luPART.NameText = "";
                _luPART.CodeReadOnly = true;
                _luPART.NameReadOnly = true;

                _luVEND.CodeText = "";
                _luVEND.NameText = "";
                _luVEND.CodeReadOnly = true;
                _luVEND.NameReadOnly = true;

                _luSTOCK_QTY.Text = "0";
                _luSTOCK_QTY.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

                _luORDER_QTY.Text = "0";
                _luORDER_QTY.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                _luORDER_QTY.ReadOnly = false;

                _luUNIT_COST.Text = "0";
                _luUNIT_COST.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                _luUNIT_COST.ReadOnly = false;

                _luCOST.Text = "0";
                _luCOST.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                _luCOST.EditMask = "n2";
                _luCOST.ReadOnly = true;

                _luREQUEST_DATE.DateTime = DateTime.Today;


                _luREQUEST_LOCATION.Text = "";
                _luUNIT_COST.ReadOnly = false;

                _luREMARK.Text = "";
                _luREMARK.ReadOnly = false;

                _luUSE_YN.ItemIndex = 0;

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

        #region ○ 서브조회 - SubFind_DisplayData(string pORDERID)   //사용X

        private void SubFind_DisplayData(string pORDERID)  //사용X
        {


        }
        #endregion

        #region ○ 시트조회 - SheetFind_DisplayData()   //추가

        private void SheetFind_DisplayData()   //추가
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                string strFTP_PATH = "";
                string strUSE_TYPE = "";
                string strFILE_NAME = "";

                _dtList = new MaterialOrderRegisterBusiness().Sheet_Info_Sheet(_pMaterialOrderRegisterEntity);

                strUSE_TYPE = _dtList.Rows[0][1].ToString();
                strFILE_NAME = _dtList.Rows[0][0].ToString();

                switch (strUSE_TYPE)
                {
                    case "PRINT":
                        strFTP_PATH = string.Format(@"{0}{1}/", _pFTP_PATH, "ORDER_FORM");
                        break;
                    case "VIEW":
                        strFTP_PATH = string.Format(@"{0}{1}/", _pFTP_PATH, "PROGRAM_VIEW");
                        break;
                }

                if (_dtList != null)
                {
                    using (Stream responseStream = CoFAS_FTPManager.FTPFileBinding(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW))
                    {

                    }
                }
                else
                {
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
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion



        #region ○ 저장 - InputData_Save(DataTable dtSave)

        private void InputData_Save(MaterialOrderRegisterEntity _pMaterialOrderRegisterEntityt)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                using (DBManager pDBManager = new DBManager())
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.Yes)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                    {

                        isError = new MaterialOrderRegisterBusiness().MaterialOrderRegister_Info_Save(_pMaterialOrderRegisterEntity);

                    if (isError)
                    {
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    }
                    else
                    {
                            //정상 처리
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                            _pLocation_Code = _pMaterialOrderRegisterEntity.RTN_KEY;  //저장 위치 
                            MainFind_DisplayData("R");
                        }
                    }
                    else
                    {
                        return;
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




        //private void _luUNIT_COST_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != 8)

        //    {
        //        e.Handled = true;
        //    }
        //    int orderqty;
        //    int unitcost;
        //    int cost;
        //    int summary;
        //    orderqty = Convert.ToInt32(_luORDER_QTY.Text);
        //    unitcost = Convert.ToInt32(_luUNIT_COST.Text);
        //    cost = Convert.ToInt32(_luCOST.Text);
        //    summary = (orderqty * unitcost);
        //    _luCOST.Text = Convert.ToString(summary);
        //}

        private void _luORDER_QTY__OnTextChanged(object sender, EventArgs e)
        {
            decimal orderqty;
            decimal unitcost;
            decimal cost;
            decimal summary;
            
            orderqty = Convert.ToDecimal(_luORDER_QTY.Text.Replace(",", ""));
            unitcost = Convert.ToDecimal(_luUNIT_COST.Text.Replace(",", ""));
            cost = Convert.ToDecimal(_luCOST.Text);
            summary = (orderqty * unitcost);
            _luCOST.Text = Convert.ToString(summary);
        }

        //private void _luORDER_QTY__OnKeyDown(object sender, KeyEventArgs e)
        //{
        //    string test1 = "";
        //    string test2 = "";
        //    test1 = e.KeyValue.ToString();
        //    test2 = e.KeyData.ToString();
        //    if (e.KeyValue != '.' && e.KeyValue != 8)
        //    {
        //        e.Handled = true;
        //    }
        //    decimal orderqty;
        //    decimal unitcost;
        //    decimal cost;
        //    decimal summary;
        //    orderqty = Convert.ToDecimal(_luORDER_QTY.Text.Replace(",", ""));
        //    unitcost = Convert.ToDecimal(_luUNIT_COST.Text.Replace(",", ""));
        //    cost = Convert.ToDecimal(_luCOST.Text);
        //    summary = (orderqty * unitcost);
        //    _luCOST.Text = Convert.ToString(summary);
        //}

        #region ○ 자재조회팝업호출 - _luT_PART_CODE__OnOpenClick()   //추가

        private void _luT_PART_CODE__OnOpenClick(object sender, EventArgs e)
        {

            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            frmCommonPopup.ARRAY = new object[2] { "Material_Code", _luPART.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
            frmCommonPopup.ARRAY_CODE = new object[2] { _luPART.CodeText, _luPART.NameText };
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("MaterialCodeInfo"); //유저컨트롤러 설정 부분

            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn == null)
            {
                xfrmCommonPopup.Dispose();
                return;
            }

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luT_PART_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                _luT_PART_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
            }
            xfrmCommonPopup.Dispose();
        }

        #endregion

        #region ○ 거래처조회팝업호출 - _luT_VEND_CODE__OnOpenClick()  
        private void _luT_VEND_CODE__OnOpenClick(object sender, EventArgs e)
        {
          
                //VendCostInfo
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;



                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "vend_code_I", "" };

                //검색조건 전달 0 코드 1 명칭
                frmCommonPopup.ARRAY_CODE = new object[2] { _luT_VEND_CODE.CodeText.ToString(), _luT_VEND_CODE.NameText.ToString() };

                //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("VendInfo"); //유저컨트롤러 설정 부분
                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luT_VEND_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                    _luT_VEND_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

                    //데이터 세팅
                }

                xfrmCommonPopup.Dispose();
           
        }
        #endregion


        #region ○ 자재 거래처별 단가 조회팝업호출 - _btPART_Click()  
        private void _luPART_CODE__OnOpenClick(object sender, EventArgs e)
        {

            // 거래처 없음 체크박스에 따라 팝업 호출 변경

            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            frmCommonPopup.ARRAY = new object[2] { "Material_Code", _luPART.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
            frmCommonPopup.ARRAY_CODE = new object[2] { _luPART.CodeText, _luPART.NameText };
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("MaterialCodeInfo"); //유저컨트롤러 설정 부분

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
                _luUNIT_COST.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_COST"].ToString();
                _luUNIT_CODE.SetValue(xfrmCommonPopup.dtReturn.Rows[0]["PART_UNITCOST_CURRENCY_CODE"].ToString());

            }
            xfrmCommonPopup.Dispose();      
        }

        #endregion


        #region ○  거래처 조회팝업호출 - _btPART_Click()  
        private void _luVEND__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            { 
                //VendCostInfo
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;



                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "vend_code_I", "" };

                //검색조건 전달 0 코드 1 명칭
                frmCommonPopup.ARRAY_CODE = new object[2] { _luVEND.CodeText.ToString(), _luVEND.NameText.ToString() };

                //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("VendInfo"); //유저컨트롤러 설정 부분
                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luVEND.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                    _luVEND.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

                    //데이터 세팅
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
    //20190621
    //기존 공통코드팝업 사용
    /*
    try
    {
        frmCommonPopup.USER_CODE = _pUSER_CODE;
        frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
        frmCommonPopup.FONT_TYPE = _pFONT_SETTING;


        frmCommonPopup.ARRAY = new object[2] { "vend_code_I", "" };
        frmCommonPopup.ARRAY_CODE = new object[2] { _luVEND.CodeText.ToString(), _luVEND.NameText.ToString() };
        frmCommonPopup xfrmcommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분


        //// ( Vend_In_Code 매입, 공통, Vend_Out_Code 매출 공통 ) 코드  
        //frmCommonPopup.ARRAY = new object[2] { "Vend_In_Code", "" }; //넘기는 파라메터 에 따라 설정 
        //frmCommonPopup xfrmcommonPopup = new CORE.UserForm.frmCommonPopup("VendCodeInfo"); //유저컨트롤러 설정 부분

        xfrmcommonPopup.ShowDialog();

        if (xfrmcommonPopup.dtReturn == null)
        {
            xfrmcommonPopup.Dispose();
            return;
        }

        if (xfrmcommonPopup.dtReturn != null && xfrmcommonPopup.dtReturn.Rows.Count > 0)
        {
            _luVEND.CodeText = xfrmcommonPopup.dtReturn.Rows[0]["CD"].ToString();        // 거래처코드 : 거래처명
            _luVEND.NameText = xfrmcommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

            //_luVEND.CodeText = xfrmcommonPopup.dtReturn.Rows[0]["VEND_CODE"].ToString();        // 거래처코드 : 거래처명
            //_luVEND.NameText = xfrmcommonPopup.dtReturn.Rows[0]["VEND_NAME"].ToString();
        }

        xfrmcommonPopup.Dispose();
    }
    catch (ExceptionManager pExceptionManager)
    {
        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
    }
    */
}

        #endregion

        private void _luREFERENCE_ID__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                frmCommonPopup.ARRAY = new object[2] { "PlanOrderInfo_Popup", "" }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                frmCommonPopup.ARRAY_CODE = new object[2] { _luREFERENCE_ID.Text, "" };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("PlanOrderInfo_Popup"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luREFERENCE_ID.Text = xfrmCommonPopup.dtReturn.Rows[0]["PLAN_ORDER"].ToString();
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _gdMAIN_VIEW_RowCellClick_1(object sender, RowCellClickEventArgs e)
        {
 
        }
    }
}
