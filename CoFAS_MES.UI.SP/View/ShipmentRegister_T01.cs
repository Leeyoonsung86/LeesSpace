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

using CoFAS_MES.UI.SP.Business;
using CoFAS_MES.UI.SP.Entity;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Business;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.UserForm;
using System.Data.SqlClient;

namespace CoFAS_MES.UI.SP
{
    public partial class ShipmentRegister_T01 : frmBaseNone
    {
        #region ○ 전역변수

        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pFTPIP = string.Empty;           // FTP IP
        public string _pCONNECTION = string.Empty;      //DB CONNECTION 정보
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭
        public decimal _pLeave_QTY = 0;       // 메뉴명칭
        public string _p_Saved_YN = string.Empty;       // 삭제된건지 아닌지
        private bool _pOpenPopup_YN = false;              // 저장위치 사용여부
        private string _pPONO = string.Empty;           // PONO
        private string _pINDATE = string.Empty;           // INDATE
        private string _pINVSTCD = string.Empty;           // INVSTCD
        private string _pVENDNM = string.Empty;           // INVSTCD
        private decimal _pCONTRACTQTY = 0;           // PONO
        private decimal _pOUTQTY = 0;           // OUTQTY
        private decimal _pREMAINQTY = 0;           // REMAINQTY
        #region 알림창메시지 복사 시작

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

        #endregion 

        private ShipmentRegister_T01Entity _pShipmentRegister_T01Entity = null;
        private DataTable _dtList = null; //조회 데이터 리스트
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        #endregion

        #region ○ 생성자

        public ShipmentRegister_T01()
        {
            InitializeComponent();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        #endregion

        #region ○ 폼이벤트 영역

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
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = _pFONT_SETTING;//화면에 모든 항목 폰트 재설정
            }
        }
        #endregion

        #endregion

        #region ○ 초기화 영역

        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
                _pnHeader.Visible = false;
                _pnContent.Visible = true;
                _pnLeft.Visible = false;

                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                _pFTPIP = MainForm.UserEntity.FTP_IP_PORT;
                #region 메인 화면 공통 메세지 처리

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

                #endregion

                _pWINDOW_NAME = this.Name;
                _pMENU_NAME = this.Text;

                //메뉴 화면 엔티티 설정
                _pShipmentRegister_T01Entity = new ShipmentRegister_T01Entity();
                _pShipmentRegister_T01Entity.USER_CODE = _pUSER_CODE;
                _pShipmentRegister_T01Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //그리드 설정
                InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl(true);

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pShipmentRegister_T01Entity.CRUD = "";

                if (_pFirstYN)
                {
                    MainFind_DisplayData(_pShipmentRegister_T01Entity.CRUD); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
                    _pFirstYN = false;
                }

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                _gdMAIN_VIEW2.RowCellClick += _gdMAIN_VIEW2_RowCellClick;
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
                pButtonSetting.UseYNSettingButton = false; // 설정
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
                    _gdMAIN_VIEW2 = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN2, _gdMAIN_VIEW2, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN2.Name.ToString()));
                    _gdMAIN_VIEW3 = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN3, _gdMAIN_VIEW3, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN3.Name.ToString()));
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }


        #endregion

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl(bool bSearch)
        {
            try
            {
                //조회조건 영역
                if (bSearch)
                {
                    //_luTSHIP_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                    //_luTSHIP_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                    //_luTVEND.NameText = "";
                    //_luTVEND.CodeText = "";
                    //_luTPART.NameText = "";
                    //_luTPART.CodeText = "";

                    //_luTUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                    //_luTUSE_YN.ItemIndex = 0;
                }


                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //그리드 초기화 
                _gdMAIN.DataSource = null;
                _gdMAIN2.DataSource = null;
                _gdMAIN3.DataSource = null;
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

        #endregion

        #region ○ 추가이벤트 영역

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)

        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                int qRowIndex = gv.FocusedRowHandle;
                string qColumnHeader = e.Column.Caption;

                _pShipmentRegister_T01Entity.CRUD = "R";
                _pShipmentRegister_T01Entity.PART_CODE = gv.GetFocusedRowCellValue("ITMNO").ToString();
                _pCONTRACTQTY =  Convert.ToDecimal(gv.GetFocusedRowCellValue("POTCNT").ToString());
                _pOUTQTY = Convert.ToDecimal(gv.GetFocusedRowCellValue("PRDCNT").ToString());
                _pVENDNM = gv.GetFocusedRowCellValue("VNDNM").ToString();
                _pREMAINQTY = _pCONTRACTQTY - _pOUTQTY;
                _pINVSTCD = gv.GetFocusedRowCellValue("INVSTCD").ToString();
                _pPONO = gv.GetFocusedRowCellValue("PONO").ToString();
                _pINDATE = gv.GetFocusedRowCellValue("INDATE").ToString();
                //MainFind_DisplayData();
                SubFind_DisplayData(gv.GetFocusedRowCellValue("ITMNO").ToString());
                BottomFind_DisplayData(_pPONO, gv.GetFocusedRowCellValue("ITMNO").ToString());

                _pShipmentRegister_T01Entity.CRUD = "U";

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 서브 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW2_RowCellClick(object sender, RowCellClickEventArgs e)

        private void _gdMAIN_VIEW2_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                int qRowIndex = gv.FocusedRowHandle;
                string qColumnHeader = e.Column.Caption;

                //_pShipmentRegister_T01Entity.CRUD = "R";
                //_pShipmentRegister_T01Entity.PART_CODE = gv.GetFocusedRowCellValue("ITMNO").ToString();

                //MainFind_DisplayData();
                //SubFind_DisplayData(gv.GetFocusedRowCellValue("ITMNO").ToString());
                //BottomFind_DisplayData();

                //_pShipmentRegister_T01Entity.CRUD = "U";

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #endregion

        #region ○ 메인버튼이벤트 영역

        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //if (_luTSHIP_DATE.FromDateTime > _luTSHIP_DATE.ToDateTime)
                //{
                //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_SEARCH_DATE);
                //    return;
                //}

                InitializeControl(false);
                _pShipmentRegister_T01Entity.CRUD = "R";
                _pShipmentRegister_T01Entity.PART_CODE = _luPART_CD.Text.ToString();
                _pShipmentRegister_T01Entity.PART_NAME = _luPART_NM.Text.ToString();
                _pShipmentRegister_T01Entity.VEND_NAME = _luVEND_NM.Text.ToString();
                _pShipmentRegister_T01Entity.CONTRACT_ID = _luCONTRACT_ID.Text.ToString();
                _pShipmentRegister_T01Entity.USER_CODE = _pUSER_CODE;
                MainFind_DisplayData("R");
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

                 if (!dxValidationProvider.Validate())
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }
                DataTable tDataTable = _gdMAIN_VIEW2.GridControl.DataSource as DataTable;
                int cnt = 0;
                decimal outqty = 0;
                for (int a = 0; a < tDataTable.Rows.Count; a++)
                {
                    if (tDataTable.Rows[a]["CRUD"].ToString() == "U")
                    {
                        outqty += Convert.ToDecimal(tDataTable.Rows[a]["OUT_QTY"].ToString()); //총 출고수량
                    }
                }
                //_pCONTRACTQTY 총 수주수량
                // 남은수량 _pREMAINQTY
                //_pCONTRACTQTY 총 수주수량 보다 더 많이 출고할경우
                if (outqty > _pCONTRACTQTY)
                {

                }
                //_pREMAINQTY 수주의 남은수량 보다 더 많이 출고할경우
                if (outqty > _pREMAINQTY)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("출하지시량이 남은 수주량을 초과할 수 없습니다.\n출하가능량 : " + Convert.ToInt32(_pREMAINQTY).ToString());
                    return;
                }
                _pShipmentRegister_T01Entity.INVSTCD = _pINVSTCD;
                _pShipmentRegister_T01Entity.CONTRACT_ID = _pPONO; //PONO
                _pShipmentRegister_T01Entity.USER_CODE = _pUSER_CODE;
                _pShipmentRegister_T01Entity.VEND_NAME = _pVENDNM;
                _pShipmentRegister_T01Entity.INDATE = _pINDATE;
                //_pShipmentRegister_T01Entity.LOT_NO = "";
                // _pShipmentRegister_T01Entity.PART_CODE = "";
                _pShipmentRegister_T01Entity.OUT_QTY = outqty.ToString();

                InputData_Save(tDataTable);
                
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

                if (!dxValidationProvider.Validate())
                {
                    MessageBox.Show(_pMSG_CHECK_VALID_ITEM);
                    return;
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

                InitializeControl(true);
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

        #endregion

        #region ○ 팝업이벤트 영역

        #region ○ 수주정보 찾기 

        private void _luREFERENCE_ID__OnOpenClick(object sender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_MES.UI.SP.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                CoFAS_MES.UI.SP.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                CoFAS_MES.UI.SP.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
                CoFAS_MES.UI.SP.UserForm.frmCommonPopup.ARRAY = new object[2] {"Contract_Info", "" };
                CoFAS_MES.UI.SP.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { "", "" };
                CoFAS_MES.UI.SP.UserForm.frmCommonPopup pfrmCommonPopup = new CoFAS_MES.UI.SP.UserForm.frmCommonPopup("ShipmentRegister_T01");

                pfrmCommonPopup.ShowDialog();

                if (pfrmCommonPopup.dtReturn == null)
                {
                    _pOpenPopup_YN = false;
                    pfrmCommonPopup.Dispose();
                    return;
                }

                if (pfrmCommonPopup.dtReturn != null && pfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    //_luREFERENCE_ID.Text = pfrmCommonPopup.dtReturn.Rows[0]["CONTRACT_ID"].ToString();
                    //_luPART.CodeText = pfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                    //_luPART.NameText = pfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                    //_luVEND.CodeText = pfrmCommonPopup.dtReturn.Rows[0]["VEND_CODE"].ToString();
                    //_luVEND.NameText = pfrmCommonPopup.dtReturn.Rows[0]["VEND_NAME"].ToString();
                    //_pLeave_QTY = Convert.ToDecimal(pfrmCommonPopup.dtReturn.Rows[0]["LEAVE_QTY"].ToString());
                    //_luSHIPMENT_ORDER_QTY.Text = pfrmCommonPopup.dtReturn.Rows[0]["LEAVE_QTY"].ToString();// pfrmCommonPopup.dtReturn.Rows[0]["CONTRACT_QTY"].ToString();
                    //_luPART_UNIT.SetValue(pfrmCommonPopup.dtReturn.Rows[0]["PART_UNIT"].ToString());
                    //_pOpenPopup_YN = true;
                }
                
                pfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 조회조건 품목찾기

        private void _luTPART__OnOpenClick(object sender, EventArgs pEventArgs)
        {
            try
            {
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 조회조건 거래처찾기

        private void _luTVEND__OnOpenClick(object sender, EventArgs pEventArgs)
        {
            try
            {
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 상세내역 품목찾기

        private void _luPART__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 상세내역 거래처찾기

        private void _luVEND__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                /*
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;


                // ( Vend_In_Code 매입, 공통, Vend_Out_Code 매출 공통 ) 코드  
                frmCommonPopup.ARRAY = new object[2] { "vend_code_I", "" }; //넘기는 파라메터 에 따라 설정 
                frmCommonPopup.ARRAY_CODE = new object[2] { _luTVEND.CodeText, _luTVEND.NameText };
                frmCommonPopup xfrmcommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmcommonPopup.ShowDialog();

                if (xfrmcommonPopup.dtReturn == null)
                {
                    xfrmcommonPopup.Dispose();
                    return;
                }

                if (xfrmcommonPopup.dtReturn != null && xfrmcommonPopup.dtReturn.Rows.Count > 0)
                {
                    //_luVEND.CodeText = xfrmcommonPopup.dtReturn.Rows[0]["CD"].ToString();        // 거래처코드 : 거래처명
                    //_luVEND.NameText = xfrmcommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
                }

                xfrmcommonPopup.Dispose();
                */
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #endregion

        #region ○ 데이터베이스 영역

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData(string crud)
        {
            try
            {





                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);


                /*
                _dtList = new ShipmentRegister_T01Business().ShipmentRegister_T01_Info_Mst(_pShipmentRegister_T01Entity);

                if (_pShipmentRegister_T01Entity.CRUD == "")
                    _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pShipmentRegister_T01Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    _dtList.Rows.Clear();

                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
                */

                SqlConnection con;
                if (_pFTPIP == "192.168.123.246:8500/")
                {
                    _pCONNECTION = "Data Source=192.168.123.252;Initial Catalog=DTISDB;User ID=pmo; Password=semids1357!;";
                }
                else
                {
                    _pCONNECTION = "Data Source=db3.coever.co.kr;Initial Catalog=DTISDB;User ID=sa; Password=Codb89897788@$^;";
                }
                con = new SqlConnection(_pCONNECTION);
                //con = new SqlConnection("Data Source=db3.coever.co.kr;Initial Catalog=DTISDB;User ID=sa; Password=Codb89897788@$^;");
                //con = new SqlConnection("Data Source=192.168.123.252;Initial Catalog=DTISDB;User ID=pmo; Password=semids1357!;");
                SqlCommand cmd;
                cmd = new SqlCommand();
                cmd.CommandText = "usp_pop_sal008d";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@crud", SqlDbType.VarChar, 1));
                cmd.Parameters.Add(new SqlParameter("@item_code", SqlDbType.VarChar, 50));
                cmd.Parameters.Add(new SqlParameter("@item_name", SqlDbType.VarChar, 50));
                cmd.Parameters.Add(new SqlParameter("@vend_name", SqlDbType.VarChar, 50));
                cmd.Parameters.Add(new SqlParameter("@pono", SqlDbType.VarChar, 50));

                // 값할당
                cmd.Parameters["@crud"].Value = crud;
                cmd.Parameters["@item_code"].Value = _luPART_CD.Text;
                cmd.Parameters["@item_name"].Value = _luPART_NM.Text;
                cmd.Parameters["@vend_name"].Value = _luVEND_NM.Text;
                cmd.Parameters["@pono"].Value = _luCONTRACT_ID.Text;
                SqlDataReader dr;
                DataTable dt;
                dt = new DataTable();
                con.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();
                // return dt;

                if (crud == "")
                { dt.Rows.Clear(); }

                if ((dt != null && dt.Rows.Count > 0) || (dt != null && crud == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, dt); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, dt);
                    DisplayMessage(_pMSG_SEARCH_EMPT_DETAIL);
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

        #region ○ 메인재고조회 - SubFind_DisplayData()

        private void SubFind_DisplayData(string PART_CD)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pShipmentRegister_T01Entity.PART_CODE = PART_CD;
                _dtList = new ShipmentRegister_T01Business().ShipmentRegister_T01_Info_Sub(_pShipmentRegister_T01Entity);

                if (_pShipmentRegister_T01Entity.CRUD == "")
                    _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pShipmentRegister_T01Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN2, _gdMAIN_VIEW2, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    _dtList.Rows.Clear();

                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN2, _gdMAIN_VIEW2, _dtList); //데이터 필드에 맞춰 자동 바인딩
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

        #region ○ 메인상세조회 - BottomFind_DisplayData()

        private void BottomFind_DisplayData(string PONO, string PART_CD)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pShipmentRegister_T01Entity.CONTRACT_ID = PONO;
                _pShipmentRegister_T01Entity.PART_CODE = PART_CD;
                _dtList = new ShipmentRegister_T01Business().ShipmentRegister_T01_Info_Bot(_pShipmentRegister_T01Entity);

                if (_pShipmentRegister_T01Entity.CRUD == "")
                    _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pShipmentRegister_T01Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN3, _gdMAIN_VIEW3, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
                else
                {
                    _dtList.Rows.Clear();

                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN3, _gdMAIN_VIEW3, _dtList); //데이터 필드에 맞춰 자동 바인딩
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

        #region ○ 저장 - InputData_Save

        // 저장-수정후 상세내역만 초기화
        // ini(false)
        private void InputData_Save(DataTable tDataTable)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                
                bool isError = false;

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                {

                    isError = new ShipmentRegister_T01Business().ShipmentRegister_T01_Info_Save(_pShipmentRegister_T01Entity, tDataTable);


                    if (isError)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                        return;
                    }

                    else
                    {

                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

                        //대성수주 UPDATE 

                        //update
                        SqlConnection con;
                        if (_pFTPIP == "192.168.123.246:8500/")
                        {
                            _pCONNECTION = "Data Source=192.168.123.252;Initial Catalog=DTISDB;User ID=pmo; Password=semids1357!;";
                        }
                        else
                        {
                            _pCONNECTION = "Data Source=db3.coever.co.kr;Initial Catalog=DTISDB;User ID=sa; Password=Codb89897788@$^;";
                        }
                        con = new SqlConnection(_pCONNECTION);
                        //con = new SqlConnection("Data Source=192.168.123.252;Initial Catalog=DTISDB;User ID=pmo; Password=semids1357!;");
                        //con = new SqlConnection("Data Source=db3.coever.co.kr;Initial Catalog=DTISDB;User ID=sa; Password=Codb89897788@$^;");
                        SqlCommand cmd;
                        cmd = new SqlCommand();
                        cmd.CommandText = "usp_pop_sal008d_Sync";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        cmd.Parameters.Add(new SqlParameter("@pono", SqlDbType.VarChar, 50));
                        cmd.Parameters.Add(new SqlParameter("@cnt", SqlDbType.Decimal));

                        // 값할당
                        cmd.Parameters["@pono"].Value = _pPONO;
                        cmd.Parameters["@cnt"].Value = _pShipmentRegister_T01Entity.OUT_QTY;
                        SqlDataReader dr;
                        DataTable dt;
                        dt = new DataTable();
                        con.Open();
                        dr = cmd.ExecuteReader();
                        dt.Load(dr);
                        con.Close();



                        _pShipmentRegister_T01Entity.CRUD = "R";
                        Form_SearchButtonClicked(null, null);
                        SubFind_DisplayData(_pShipmentRegister_T01Entity.RTN_KEY);
                        BottomFind_DisplayData(_pShipmentRegister_T01Entity.RTN_OTHERS, _pShipmentRegister_T01Entity.RTN_KEY);

                    }
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

        #endregion

        private void _luSHIPMENT_ORDER_QTY__OnTextChanged(object sender, EventArgs e)
        {
            try
            {
                //decimal pQTY = 0;
                //pQTY = Convert.ToDecimal(_luSHIPMENT_ORDER_QTY.Text == "" ? "0" : _luSHIPMENT_ORDER_QTY.Text);
                //if (_pOpenPopup_YN == true)
                //{
                //    if (pQTY > _pLeave_QTY)
                //    {
                //        CoFAS_DevExpressManager.ShowInformationMessage("출하지시량이 남은 수주량을 초과할 수 없습니다.\n출하가능량 : " + _pLeave_QTY);
                //    }
                //}
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
    }
}
