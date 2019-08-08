using CoFAS_MES.CORE.BaseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.UI.PM.Business;
using CoFAS_MES.UI.PM.Entity;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Business;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.UserForm;

namespace CoFAS_MES.UI.PM
{ 
    public partial class ProductOutRegister_T05 : frmBaseNone
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
        private bool _pLocation_YN = true;              // 저장위치 사용여부
        private string _pUSER_GRANT = string.Empty; // 사용자 권한
        public string _p_Saved_YN = string.Empty;       // 삭제된건지 아닌지

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

        private decimal _pLEAVE_QTY = 0;                     //남은 수주수량
        private decimal _pCONTRACT_QTY = 0;                  //수주수량
        private decimal _pTOTAL_INOUT_QTY = 0;               //총 출고수량
        private decimal _pBefore_inout_Qty = 0;               //기존 출고수량

        private ProductOutRegister_T05Entity _pProductOutRegister_T05Entity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private DataTable _dtList2 = null;//바코드 정보

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용


        public ProductOutRegister_T05()
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
                AddItemButtonClicked += new EventHandler(Form_AddItemButtonClicked);
                DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
                PrintButtonClicked += new EventHandler(Form_PrintButtonClicked);
                ExportButtonClicked += new EventHandler(Form_ExportButtonClicked);
                ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                SettingButtonClicked += new EventHandler(Form_SettingButtonClicked);

                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);

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
                _pnLeft.Visible = false;
                _pnLeft.Width = 500;

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
                _pProductOutRegister_T05Entity = new ProductOutRegister_T05Entity();
                _pProductOutRegister_T05Entity.CORP_CODE = _pCORP_CODE;
                _pProductOutRegister_T05Entity.USER_CODE = _pUSER_CODE;
                _pProductOutRegister_T05Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;


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

            

                if (_pFirstYN)
                {
                    //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                    _pProductOutRegister_T05Entity.CRUD = "";
                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                    _pFirstYN = false;
                }
             

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

                //그리드 버튼추가 시 클릭 이벤트 처리 
                // CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;
                //CoFAS_ControlManager.SetFontInControls(this.Controls, new Font("Arial", 8, FontStyle.Bold));
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

                //_gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pCORP_CDDE, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
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
                _luTINOUT_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luTINOUT_DATE.ToDateTime = DateTime.Today;  //조회 종료일


                _luTPART_ALL.CodeText = "";
                _luTPART_ALL.NameText = "";
                _luTVEND_ALL.CodeText = "";
                _luTVEND_ALL.NameText = "";

                _luTINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code_PD", "", "", "").Tables[0], 0, 0, "", true);
                _luTINOUT_CODE.ItemIndex = 0;

                _luTUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                _luTUSE_YN.ItemIndex = 0;
                _luTREFERENCE_ID.Text = "";
                _luTINOUT_ID.Text = "";

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");

                _luLOCATION.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "COMMON_CODE", "CD24", "", "").Tables[0], 0, 0, "");
                _luLOCATION.ItemIndex = 0;

                //데이터 영역
                _luINOUT_ID.Text = "";
                _luINOUT_ID.ReadOnly = true;

                _luINOUT_DATE.DateTime = DateTime.Today;  //조회 종료일, 당일 설정

                _luPART_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                _luPART_UNIT.ReadOnly = true;

                //_luREFERENCE_ID.Text = "";
                //_luREFERENCE_ID.ReadOnly = true;

                _luPART_ALL.CodeText = "";
                _luPART_ALL.NameText = "";
                _luPART_ALL.CodeReadOnly = true;
                _luPART_ALL.NameReadOnly = true;
                _luVEND_ALL.CodeText = "";
                _luVEND_ALL.NameText = "";
                _luVEND_ALL.CodeReadOnly = true;
                _luVEND_ALL.NameReadOnly = true;

                _luINOUT_QTY.Text = "0";
                _luUNITCOST.Text = "0";

                _luUNITCOST.Properties.MaxLength = 11;
                _luINOUT_QTY.Properties.MaxLength = 11;

                _luCOST.Text = "0";
                _luCOST.ReadOnly = true;

                _luREMARK.Text = "";
                _luREMARK.ReadOnly = false;

                _luREFERENCE_ID.Text = "";
                _luREFERENCE_ID.ReadOnly = true;

                //_luINOUT_CODE.ReadOnly = false;
                _luINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code_PD", "", "", "").Tables[0], 0, 0, "");
                _luINOUT_CODE.ItemIndex = 2;
                //_luINOUT_CODE.ReadOnly = true;

                _gdMAIN.DataSource = null;

                _pLEAVE_QTY = 0;
                _pCONTRACT_QTY = 0;
                _pTOTAL_INOUT_QTY = 0;

                _luLEAVE_QTY.ReadOnly = true;
                _luLEAVE_QTY.Text = "";

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

        #region ○ 조회 후 초기화 - InitializeSearch()

        private void InitializeSearch()
        {
            try
            {

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");

                //데이터 영역
                _luINOUT_ID.Text = "";
                _luINOUT_ID.ReadOnly = true;

                _luINOUT_DATE.DateTime = DateTime.Today;  //조회 종료일, 당일 설정

                _luPART_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                _luPART_UNIT.ReadOnly = true;

                //_luREFERENCE_ID.Text = "";
                //_luREFERENCE_ID.ReadOnly = true;

                _luPART_ALL.CodeText = "";
                _luPART_ALL.NameText = "";
                _luPART_ALL.CodeReadOnly = true;
                _luPART_ALL.NameReadOnly = true;
                _luVEND_ALL.CodeText = "";
                _luVEND_ALL.NameText = "";
                _luVEND_ALL.CodeReadOnly = true;
                _luVEND_ALL.NameReadOnly = true;

                _luINOUT_QTY.Text = "0";
                _luUNITCOST.Text = "0";

                _luUNITCOST.Properties.MaxLength = 11;
                _luINOUT_QTY.Properties.MaxLength = 11;

                _luCOST.Text = "0";
                _luCOST.ReadOnly = true;

                _luREMARK.Text = "";
                _luREMARK.ReadOnly = false;

                _luREFERENCE_ID.Text = "";
                _luREFERENCE_ID.ReadOnly = true;

                //_luINOUT_CODE.ReadOnly = false;
                _luINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code_PD", "", "", "").Tables[0], 0, 0, "");
                _luINOUT_CODE.ItemIndex = 2;
                //_luINOUT_CODE.ReadOnly = true;

                _pLEAVE_QTY = 0;
                _pCONTRACT_QTY = 0;
                _pTOTAL_INOUT_QTY = 0;

                _luLEAVE_QTY.ReadOnly = true;
                _luLEAVE_QTY.Text = "";
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
                CoFAS_ControlManager.Controls_Binding(gv, false, this); //
                _pProductOutRegister_T05Entity.CRUD = "R";
                _pCONTRACT_QTY = Convert.ToDecimal(gv.GetFocusedRowCellValue("CONTRACT_QTY").ToString());
                _pTOTAL_INOUT_QTY = Convert.ToDecimal(gv.GetFocusedRowCellValue("TOTAL_INOUT_QTY").ToString());
                _pLEAVE_QTY = _pCONTRACT_QTY - _pTOTAL_INOUT_QTY;
                _pBefore_inout_Qty = Convert.ToDecimal(gv.GetFocusedRowCellValue("INOUT_QTY").ToString());

                _p_Saved_YN = gv.GetFocusedRowCellValue("USE_YN").ToString();

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
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


        // 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                if (_luTINOUT_DATE.FromDateTime > _luTINOUT_DATE.ToDateTime)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 일자를 확인해 주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_SEARCH_DATE);
                    return;
                }
                _pProductOutRegister_T05Entity.CRUD = "R";
                _pProductOutRegister_T05Entity.DATE_FROM = DateTime.Parse(_luTINOUT_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");// Convert.ToString(_luTINOUT_DATE.FromDateTime).Substring(0, 10).Replace("-", "");
                _pProductOutRegister_T05Entity.DATE_TO = DateTime.Parse(_luTINOUT_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");// Convert.ToString(_luTINOUT_DATE.ToDateTime).Substring(0, 10).Replace("-", "");
                _pProductOutRegister_T05Entity.VEND_CODE = _luTVEND_ALL.CodeText;
                _pProductOutRegister_T05Entity.VEND_NAME = _luTVEND_ALL.NameText;
                _pProductOutRegister_T05Entity.PART_CODE = _luTPART_ALL.CodeText;
                _pProductOutRegister_T05Entity.PART_NAME = _luTPART_ALL.NameText;
                _pProductOutRegister_T05Entity.REFERENCE_ID = _luTREFERENCE_ID.Text;
                _pProductOutRegister_T05Entity.INOUT_ID = _luTINOUT_ID.Text;
                _pProductOutRegister_T05Entity.INOUT_CODE = _luTINOUT_CODE.GetValue();
                _pProductOutRegister_T05Entity.USE_YN = _luTUSE_YN.GetValue();
                MainFind_DisplayData();
                InitializeSearch();

                _pLEAVE_QTY = 0;
                _pCONTRACT_QTY = 0;
                _pTOTAL_INOUT_QTY = 0;

                //DisplayMessage("조회 되었습니다.");
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

        #region ○ 입력 데이터 조사하기 - CheckInputData()

        private bool CheckInputData()
        {
            bool pErrorYN = false;
            string pErrName = string.Empty;

            try
            {

                if (_luPART_ALL.CodeText == "")
                    pErrName += "품목코드. ";
                //일반출고는 거래처 없이도 출고 가능하게

                //생산출고
                if(_luINOUT_CODE.Text.Trim() != "일반출고")
                { 
                    if (_luVEND_ALL.CodeText == "")
                        pErrName += "거래처코드. ";
                }

                if (_luINOUT_QTY.Text == "" || _luINOUT_QTY.Text == "0" || Convert.ToDecimal(_luINOUT_QTY.Text) < 1)
                    pErrName += "출고수량. ";

                if (pErrName != "")
                {
                    pErrorYN = true;
                    // DisplayMessage(pErrName);
                     DisplayMessage(_pMSG_CHECK_VALID_ITEM);
                    
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

        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                    return;

                //190322
                /*
                    if (_luINOUT_CODE.Text.Trim() == "생산출고"&& _luINOUT_ID.Text != "")
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("생산출고 데이터는 수정할 수 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_MODIFY_DATA_OUT);
                    return;
                }
                */

                if (_luUNITCOST.Text == "")
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("단가를 입력해주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }
                if (!dxValidationProvider.Validate())
                {
                    return;
                }
                if (CheckInputData())
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("필수항목을 확인해주시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }

             string before_qty = _luINOUT_QTY.Text;
                //if (_luINOUT_CODE.Text.Trim() == "수주출고" || _gdMAIN_VIEW.GetFocusedRowCellValue("INOUT_CODE").ToString()=="1001")
                if (_luINOUT_CODE.Text.Trim() == "수주출고" )
                {
                 decimal pQTY = Convert.ToDecimal(_luINOUT_QTY.Text == "" ? "0.00" : _luINOUT_QTY.Text);

              if (pQTY > _pLEAVE_QTY+ _pBefore_inout_Qty)
                 {
                        //CoFAS_DevExpressManager.ShowInformationMessage("미출고수량보다 작게 입력해주세요.\n미출고수량 : " + _pLEAVE_QTY.ToString());
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_LESS_THAN_NOTOUTQTY + _pLEAVE_QTY.ToString());
                        // _luINOUT_QTY.Text = before_qty.ToString();
                        return;
                 }
             }
               

                //확인
                if (_luINOUT_ID.Text != "")
                {
                    _pProductOutRegister_T05Entity.CRUD = "U";
                }
                else
                {
                    _pProductOutRegister_T05Entity.CRUD = "C";
                }
             
                _pProductOutRegister_T05Entity.INOUT_ID = _luINOUT_ID.Text;
                _pProductOutRegister_T05Entity.INOUT_DATE = _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                _pProductOutRegister_T05Entity.INOUT_TYPE = "O";  //무조건 입력
                _pProductOutRegister_T05Entity.INOUT_CODE = _luINOUT_CODE.GetValue();
                _pProductOutRegister_T05Entity.REFERENCE_ID = _luREFERENCE_ID.Text;
                _pProductOutRegister_T05Entity.PART_CODE = _luPART_ALL.CodeText;
                _pProductOutRegister_T05Entity.PART_NAME = _luPART_ALL.NameText;
                _pProductOutRegister_T05Entity.VEND_CODE = _luVEND_ALL.CodeText;
                _pProductOutRegister_T05Entity.VEND_NAME = _luVEND_ALL.NameText;
                _pProductOutRegister_T05Entity.INOUT_QTY = _luINOUT_QTY.Text;
                _pProductOutRegister_T05Entity.UNITCOST = _luUNITCOST.Text;
                _pProductOutRegister_T05Entity.COST = _luCOST.Text;
                _pProductOutRegister_T05Entity.REMARK = _luREMARK.Text;
                _pProductOutRegister_T05Entity.USE_YN = _luUSE_YN.GetValue();


                _pProductOutRegister_T05Entity.LOCATION = _luLOCATION.GetValue();


                if (_p_Saved_YN == "Y")
                {
                    if (_pProductOutRegister_T05Entity.USE_YN == "N")
                        _pProductOutRegister_T05Entity.CRUD = "D";
                }
                if (_p_Saved_YN == "N")
                {
                    if (_pProductOutRegister_T05Entity.USE_YN == "Y")
                        _pProductOutRegister_T05Entity.CRUD = "Y";
                }

                InputData_Save(_pProductOutRegister_T05Entity);
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
                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                    return;
                //확인
                if (_luINOUT_ID.Text == "")  //출고번호가 없는 것 신규등록 경우 
                {
                    //삭제 못함
                    //CoFAS_DevExpressManager.ShowInformationMessage("삭제할 데이터가 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE_ERROR_NO_DATA);
                    return;
                }
                else
                {
                    _pProductOutRegister_T05Entity.CRUD = "D";
                }

                //190322
                /*
                if (_luINOUT_CODE.Text.Trim() == "생산출고")
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("생산출고 데이터는 삭제할 수 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_DELETE_DATA_OUT);
                    return;
                }
                */
                //if (CoFAS_DevExpressManager.ShowQuestionMessage("출고 데이터를 삭제하시겠습니까? \n입고번호 : " + _luINOUT_ID.Text) == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_DELETE_QUESTION + _luINOUT_ID.Text) == DialogResult.No)
                {
                    return;
                }

                

                _pProductOutRegister_T05Entity.INOUT_ID = _luINOUT_ID.Text;
                _pProductOutRegister_T05Entity.INOUT_DATE = _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                _pProductOutRegister_T05Entity.INOUT_TYPE = "O";  //무조건 입력
                _pProductOutRegister_T05Entity.INOUT_CODE = _luINOUT_CODE.GetValue();
                _pProductOutRegister_T05Entity.REFERENCE_ID = _luREFERENCE_ID.Text;
                _pProductOutRegister_T05Entity.PART_CODE = _luPART_ALL.CodeText;
                _pProductOutRegister_T05Entity.PART_NAME = _luPART_ALL.NameText;
                _pProductOutRegister_T05Entity.VEND_CODE = _luVEND_ALL.CodeText;
                _pProductOutRegister_T05Entity.VEND_NAME = _luVEND_ALL.NameText;
                _pProductOutRegister_T05Entity.INOUT_QTY = _luINOUT_QTY.Text;
                _pProductOutRegister_T05Entity.UNITCOST_CURRENCY_CODE = _luPART_UNIT.GetValue();
                _pProductOutRegister_T05Entity.UNITCOST = _luUNITCOST.Text;
                _pProductOutRegister_T05Entity.COST = _luCOST.Text;
                _pProductOutRegister_T05Entity.REMARK = _luREMARK.Text;
                _pProductOutRegister_T05Entity.USE_YN = "N";
                InputData_Save(_pProductOutRegister_T05Entity);

                InitializeControl();
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

                InitializeSetting();
                GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                CoFAS_ControlManager.Controls_Binding(gv, true, this);
                //_luINOUT_CODE.ReadOnly = false;
                //재고조정 :0  -> 일반출고 : 2
                _luINOUT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code_PD", "", "", "").Tables[0], 0, 0, "");
                _luINOUT_CODE.ItemIndex = 2;
                //_luINOUT_CODE.ReadOnly = true;

                _luPART_UNIT.ReadOnly = false;
                _luPART_UNIT.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                _luPART_UNIT.ReadOnly = true;

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");

                //DisplayMessage("초기화했습니다.");
                DisplayMessage(_pMSG_RESET_COMPLETE);
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
        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ProductOutRegister_T05Business().ProductOutRegister_T05_Info(_pProductOutRegister_T05Entity);

                if (_pProductOutRegister_T05Entity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductOutRegister_T05Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("INOUT_ID", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        {
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;
                            _luINOUT_ID.Text = _pLocation_Code;
                        }
                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtList.Rows.Clear();
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

        #region ○ 서브조회 - SubFind_DisplayData() 사용 X

        //private void SubFind_DisplayData(string strWINDOW_NAME, string strGRID_NAME)
        //{
        //    try
        //    {
        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

        //        //_pGridInfoRegisterEntity.WINDOW_NAME = strWINDOW_NAME;
        //        //_pGridInfoRegisterEntity.GRID_NAME = strGRID_NAME;

        //        _dtList = new ProductOutRegister_T05Business().Sample_Info_Sub(_pProductOutRegister_T05Entity);

        //        if (_pProductOutRegister_T05Entity.CRUD == "") _dtList.Rows.Clear();

        //        if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductOutRegister_T05Entity.CRUD == ""))
        //        {
        //            // CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
        //        }
        //        else
        //        {
        //            CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
        //    }
        //    finally
        //    {
        //        // _gdSUB_VIEW.BestFitColumns();

        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
        //    }
        //}

        #endregion

        #region ○ 저장 - InputData_Save(ProductOutRegister_T05Entity _pProductOutRegister_T05Entity) 

        private void InputData_Save(ProductOutRegister_T05Entity _pProductOutRegister_T05Entity)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;



                    isError = new ProductOutRegister_T05Business().ProductOutRegister_T05_Info_Save(_pProductOutRegister_T05Entity);

                if (isError)
                {
                    //오류 발생.
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.
                }
                else
                {
                   
                        
                    _pLocation_Code = _pProductOutRegister_T05Entity.RTN_KEY;  //저장 위치 

                    //InitializeSetting(); //초기화

                    //InitializeControl();

                    // 화면 갱신
                    _pProductOutRegister_T05Entity.CRUD = "R";
                    _pProductOutRegister_T05Entity.DATE_FROM = DateTime.Parse(_luTINOUT_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");// Convert.ToString(_luTINOUT_DATE.FromDateTime).Substring(0, 10).Replace("-", "");
                    _pProductOutRegister_T05Entity.DATE_TO = DateTime.Parse(_luTINOUT_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");// Convert.ToString(_luTINOUT_DATE.ToDateTime).Substring(0, 10).Replace("-", "");
                    _pProductOutRegister_T05Entity.VEND_CODE = _luTVEND_ALL.CodeText;
                    _pProductOutRegister_T05Entity.VEND_NAME = _luTVEND_ALL.NameText;
                    _pProductOutRegister_T05Entity.PART_CODE = _luTPART_ALL.CodeText;
                    _pProductOutRegister_T05Entity.PART_NAME = _luTPART_ALL.NameText;
                    _pProductOutRegister_T05Entity.REFERENCE_ID = _luTREFERENCE_ID.Text;
                    _pProductOutRegister_T05Entity.INOUT_ID = _luINOUT_ID.Text;
                    _pProductOutRegister_T05Entity.INOUT_CODE = _luTINOUT_CODE.GetValue();
                    _pProductOutRegister_T05Entity.USE_YN = _luTUSE_YN.GetValue();
                    Form_SearchButtonClicked(null, null);
                    //MainFind_DisplayData();

                    //정상 처리
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_QUESTION);


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

        #region ○ 버튼 클릭 팝업처리
        private void _btPRODUCTION_ORDER_Click(object sender, EventArgs e)
        {
            try
            {
                //frmCommonPopup.CORP_CDDE = _pCORP_CODE;
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                //frmCommonPopup.ARRAY = new object[2] { "common_code", "CD99" }; //넘기는 파라메터 에 따라 설정

                frmCommonPopup xfrmcommonPopup = new CORE.UserForm.frmCommonPopup("ContractInfo"); //유저컨트롤러 설정 부분

                xfrmcommonPopup.ShowDialog();

                if (xfrmcommonPopup.dtReturn == null) return;

                xfrmcommonPopup.dtReturn.Rows[0][0].ToString();
                // 리턴 받는 데이터의 값은 해당 그리드 뷰 필드에 설정.
                //_gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["TEST1"], xfrmcommonPopup.dtReturn.Rows[0]["CD"].ToString());
                //_gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["TEST2"], xfrmcommonPopup.dtReturn.Rows[0]["CD_NM"].ToString());
                xfrmcommonPopup.Dispose();
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

        private void _btTPART_Click(object sender, EventArgs e)
        {
            /*
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            frmCommonPopup.ARRAY = new object[2] { "Product_Code", _luPART_ALL.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기

            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("VendCostInfo"); //유저컨트롤러 설정 부분

            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn == null)
            {
                xfrmCommonPopup.Dispose();
                return;
            }

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luTVEND_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_CODE"].ToString();
                _luTVEND_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_NAME"].ToString();
                _luTPART_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                _luTPART_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
            }

            xfrmCommonPopup.Dispose();
            */
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            frmCommonPopup.ARRAY = new object[2] { "Product_Code", _luTPART_ALL.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
            frmCommonPopup.ARRAY_CODE = new object[2] { _luTPART_ALL.CodeText, _luTPART_ALL.NameText };
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("PartCodeInfo"); //유저컨트롤러 설정 부분

            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn == null)
            {
                xfrmCommonPopup.Dispose();
                return;
            }

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luTPART_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                _luTPART_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
            }

            xfrmCommonPopup.Dispose();

        }

        private void _btPART_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                frmCommonPopup.ARRAY = new object[2] { "Product_Code", _luPART_ALL.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기

                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("VendCostInfo"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luVEND_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_CODE"].ToString();
                    _luVEND_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_NAME"].ToString();
                    _luPART_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                    _luPART_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                    _luUNITCOST.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_UNITCOST"].ToString();
                    //_luPART_UNIT.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_UNITCOST_CURRENCY_CODE"].ToString();
                    _luPART_UNIT.SetValue(xfrmCommonPopup.dtReturn.Rows[0]["PART_UNIT"].ToString());
                    //_luPART_UNIT.SetValueByDisplayName(xfrmCommonPopup.dtReturn.Rows[0]["PART_UNITCOST_CURRENCY_CODE"].ToString());
                    //_luPART_UNIT.SetValueByDisplayName(xfrmCommonPopup.dtReturn.Rows[0]["PART_UNITCOST_CURRENCY_CODE"].ToString());
                    _luINOUT_CODE.ReadOnly = false;
                    _luINOUT_CODE.ItemIndex =2;
                    _luINOUT_CODE.ReadOnly = true;
                    _luREFERENCE_ID.Text = "";
                }

                xfrmCommonPopup.Dispose();
                */

                frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            frmCommonPopup.ARRAY = new object[2] { "Product_Code_02", _luPART_ALL.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
            frmCommonPopup.ARRAY_CODE = new object[2] { _luPART_ALL.CodeText, _luPART_ALL.NameText };
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("PartCodeInfo"); //유저컨트롤러 설정 부분

            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn == null)
            {
                xfrmCommonPopup.Dispose();
                return;
            }

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                    _luPART_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                    _luPART_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                _luUNITCOST.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_COST"].ToString();
                   // _luPART_UNIT.SetValue(xfrmCommonPopup.dtReturn.Rows[0]["PART_UNITCOST_CURRENCY_CODE"].ToString());

            }

            xfrmCommonPopup.Dispose();

        }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
}

        private void _btTVEND_Click(object sender, EventArgs e)
        {
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            frmCommonPopup.ARRAY = new object[2] { "vend_code_O", _luVEND_ALL.NameText }; //넘기는 파라메터 에 따라 설정
            frmCommonPopup.ARRAY_CODE = new object[2] { _luTVEND_ALL.CodeText, _luTVEND_ALL.NameText };

            
            //frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("VendInfo"); //유저컨트롤러 설정 부분
            
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn == null)
            {
                xfrmCommonPopup.Dispose();
                return;
            }

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luTVEND_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luTVEND_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
            }
            xfrmCommonPopup.Dispose();

        }

        private void _btVEND_Click(object sender, EventArgs e)
        {
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
            
            frmCommonPopup.ARRAY = new object[2] { "vend_code_O", _luVEND_ALL.NameText}; //넘기는 파라메터 에 따라 설정
            frmCommonPopup.ARRAY_CODE = new object[2] { _luVEND_ALL.CodeText, _luVEND_ALL.NameText };
            //frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("VendInfo"); //유저컨트롤러 설정 부분
            
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn == null)
            {
                xfrmCommonPopup.Dispose();
                return;
            }

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luVEND_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luVEND_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
                //_luINOUT_CODE.ReadOnly = false;
                _luINOUT_CODE.ItemIndex = 2;
                //_luINOUT_CODE.ReadOnly = true;
                _luREFERENCE_ID.Text = "";
            }
            xfrmCommonPopup.Dispose();

        }
        #endregion

        #region ○ 수량 자동 계산

        private void _luINOUT_QTY__OnKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b' && e.KeyChar != (char)13)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("숫자를 입력하시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_NUMERIC);
                    return;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        private void _luINOUT_QTY__OnTextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal pCOST = 0;
                decimal pQTY = 0;
                decimal pUNITCOST = 0;


                pUNITCOST = Convert.ToDecimal(_luUNITCOST.Text == "" ? "0.00" : _luUNITCOST.Text);
                pQTY = Convert.ToDecimal(_luINOUT_QTY.Text == "" ? "0.00" : _luINOUT_QTY.Text);

                pCOST = pUNITCOST * pQTY;
                pCOST = Math.Round(pCOST, 2);
                string[] qCOST = pCOST.ToString().Split('.');

                if (qCOST.Length > 1 && qCOST[1].Length > 2)
                    pCOST = Convert.ToDecimal(qCOST[0] + qCOST[1].Substring(0, 2));

                _luCOST.Text = pCOST.ToString();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _luUNITCOST__OnTextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal pCOST = 0;
                decimal pQTY = 0;
                decimal pUNITCOST = 0;

                pUNITCOST = Convert.ToDecimal(_luUNITCOST.Text == "" ? "0.00" : _luUNITCOST.Text);
                pQTY = Convert.ToDecimal(_luINOUT_QTY.Text == "" ? "0.00" : _luINOUT_QTY.Text);
                pCOST = pUNITCOST * pQTY;
                pCOST = Math.Round(pCOST, 2);
                string[] qCOST = pCOST.ToString().Split('.');

                if (qCOST.Length > 1 && qCOST[1].Length > 2)
                    pCOST = Convert.ToDecimal(qCOST[0] + qCOST[1].Substring(0, 2));

                _luCOST.Text = pCOST.ToString();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

       private void _luREFERENCE_ID__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                try
                {
                    frmCommonPopup.USER_CODE = _pUSER_CODE;
                    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    frmCommonPopup.ARRAY = new object[2] { "ContractInfo_Out_Popup", "" }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                    frmCommonPopup.ARRAY_CODE = new object[2] { _luREFERENCE_ID.Text, "" };
                    frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("ContractInfo_Out_Popup"); //유저컨트롤러 설정 부분

                    xfrmCommonPopup.ShowDialog();

                    if (xfrmCommonPopup.dtReturn == null)
                    {
                        xfrmCommonPopup.Dispose();
                        return;
                    }

                    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                    {
                        _luREFERENCE_ID.Text = xfrmCommonPopup.dtReturn.Rows[0]["CONTRACT_ID"].ToString();
                        _luPART_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                        _luPART_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                        _luVEND_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_CODE"].ToString();
                        _luVEND_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_NAME"].ToString();
                        _luUNITCOST.Text = xfrmCommonPopup.dtReturn.Rows[0]["UNITCOST"].ToString();
                        //_luPART_UNIT.Text = xfrmCommonPopup.dtReturn.Rows[0]["UNIT_CODE"].ToString();
                        _luPART_UNIT.SetValue(xfrmCommonPopup.dtReturn.Rows[0]["UNIT_CODE"].ToString());
                        // BOM 조회하기
                        //MainFind_DisplayData();
                        //_luINOUT_CODE.ReadOnly = false;
                        _luINOUT_CODE.ItemIndex = 1;
                        //_luINOUT_CODE.ReadOnly = true;
                        _luINOUT_ID.Text="";
                        _luREMARK.Text = "";
                        _luLEAVE_QTY.Text = xfrmCommonPopup.dtReturn.Rows[0]["LEAVE_QTY"].ToString();// Convert.ToDecimal(xfrmCommonPopup.dtReturn.Rows[0]["CONTRACT_QTY"].ToString()) - Convert.ToDecimal(xfrmCommonPopup.dtReturn.Rows[0]["INOUT_QTY"].ToString());
                        _pLEAVE_QTY = Convert.ToDecimal(xfrmCommonPopup.dtReturn.Rows[0]["LEAVE_QTY"].ToString());// Convert.ToDecimal(xfrmCommonPopup.dtReturn.Rows[0]["CONTRACT_QTY"].ToString()) - Convert.ToDecimal(xfrmCommonPopup.dtReturn.Rows[0]["INOUT_QTY"].ToString());
                        _luINOUT_QTY.Text = _pLEAVE_QTY.ToString();// xfrmCommonPopup.dtReturn.Rows[0]["INOUT_QTY"].ToString();
                    }

                    xfrmCommonPopup.Dispose();
                }
                catch (ExceptionManager pExceptionManager)
                {
                    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _ucbtLABEL_PRINT_Click(object sender, EventArgs e)
        {
            try
            {
                    if (_luINOUT_ID.Text == "")
                    {

                        CoFAS_DevExpressManager.ShowInformationMessage("출고번호를 선택하세요");
                        return;
                    }
                    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                    _dtList = new ProductOutRegister_T05Business().ProductOutRegister_T05_COM_Info(_pProductOutRegister_T05Entity.LANGUAGE_TYPE, "TD010001");//TP010001 : 공장 / TP010002 : 본사
                    //바코드스캐너는 1번
                    //string COM_PORT = _dtList.Rows[0]["COM_PORT"].ToString();
                    //라벨프린터는 2번
                    string COM_PORT = _dtList.Rows[1]["COM_PORT"].ToString();

                    _dtList2 = new ProductOutRegister_T05Business().ProductOutRegister_T05_COM_Info2(_pProductOutRegister_T05Entity.LANGUAGE_TYPE, "TP010002");//TP010001 : 공장 / TP010002 : 본사
                    string CMD = _dtList2.Rows[0]["PRINT_CMD"].ToString();


                if (_pProductOutRegister_T05Entity.CRUD == "") _dtList.Rows.Clear();


                    if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductOutRegister_T05Entity.CRUD == ""))
                    {


                        UI.PM.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                        UI.PM.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                        UI.PM.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                        UI.PM.UserForm.frmCommonPopup.ARRAY = new object[4] { CMD, _luINOUT_ID.Text, COM_PORT, _luINOUT_QTY.Text }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                        UI.PM.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _luREFERENCE_ID.Text, "" };
                        UI.PM.UserForm.frmCommonPopup xfrmCommonPopup = new UI.PM.UserForm.frmCommonPopup("ucLabelPrint"); //유저컨트롤러 설정 부분

                        xfrmCommonPopup.ShowDialog();

                        if (xfrmCommonPopup.dtReturn == null)
                        {
                            xfrmCommonPopup.Dispose();
                            return;
                        }

                        if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                        {

                        }

                        xfrmCommonPopup.Dispose();
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
    }
}