using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.UserForm;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.UI.PO.Business;
using CoFAS_MES.UI.PO.Entity;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;

namespace CoFAS_MES.UI.PO
{
    public partial class WorkOrdersRegister_T02 : frmBaseNone
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
        private string _pUSER_GRANT = string.Empty;     // 사용자 권한

        private WorkOrdersRegister_T02Entity _pWorkOrdersRegister_T02Entity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtSList = null; // 선택 데이터 모음
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

        //알림창메시지 복사 끝

        public WorkOrdersRegister_T02()
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
                CoFAS_DevExpressManager._OnButtonPressed -= CoFAS_DevExpressManager_OnButtonPressed;
                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;
                _gdSUB_VIEW.CellValueChanged -= _gdSUB_VIEW_CellValueChanged;
                _gdMAIN_VIEW.FocusedRowChanged -= new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(_gdMAIN_VIEW_RowChange);
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

        // 초기화 처리 영역
        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
                _pnHeader.Visible = true;
                _pnContent.Visible = true;
                _pnLeft.Width = 650;

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
                _pWorkOrdersRegister_T02Entity = new WorkOrdersRegister_T02Entity();
                _pWorkOrdersRegister_T02Entity.CORP_CODE = _pCORP_CODE;
                _pWorkOrdersRegister_T02Entity.USER_CODE = _pUSER_CODE;
                _pWorkOrdersRegister_T02Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

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
                _gdSUB.DataSource = null;
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pWorkOrdersRegister_T02Entity.CRUD = "";
                if (_pFirstYN)
                {
                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    _gdMAIN_VIEW.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(_gdMAIN_VIEW_RowChange);
                    _pFirstYN = false;
                }

                //  SubFind_DisplayData("", ""); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                
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
                    _gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
                    CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager_OnButtonPressed;
                    _gdSUB_VIEW.CellValueChanged += _gdSUB_VIEW_CellValueChanged;


                    _gdSUB_VIEW.Columns["VEND_PART_CODE"].Summary.Add(DevExpress.Data.SummaryItemType.Count, string.Empty,string.Empty);
                    _gdSUB_VIEW.Columns["ORDER_QTY"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, string.Empty, "{0:N0}");
                    _gdSUB_VIEW.Columns["PRODUCTION_ORDER_QTY"].Summary.Add(DevExpress.Data.SummaryItemType.Sum,string.Empty,"{0:N0}");
                }
                //_gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pCORP_CDDE, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pCORP_CDDE, _pWINDOW_NAME, _gdSUB.Name.ToString()));
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


                if (_pFirstYN)
                {
                    //조회조건 영역 
                    _luTUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "",true);
                    _luTUSE_YN.ItemIndex = 1;
                    _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                    //_luTWC_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "WORKCENTER", "", "", "").Tables[0], 0, 0, "", true);
                    //_luTPC_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PROCESSCODE_MAIN", "", "", "").Tables[0], 0, 0, "", true);
                    //_luTCOMPLETE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD51", "", "").Tables[0], 0, 0, "", true);
                    _luTORDER_DATE.FromDateTime = Convert.ToDateTime("2000-01-01");  //조회 시작일, 매월 초 날짜로 설정
                    _luTORDER_DATE.ToDateTime = DateTime.Today.AddDays(1);  //조회 종료일, 당일 설정
                    _pWorkOrdersRegister_T02Entity.REFERENCE_ID = "";
                    //_luTPART_ALL.CodeText = "";
                    //_luTPART_ALL.NameText = "";
                    _luTORDER_NUMBER.CodeText = "";
                    _luTORDER_NUMBER.NameText = "";
                    //_luTPRODUCTION_ORDER_ID.Text = "";

                    //   GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                    //  CoFAS_ControlManager.Controls_Binding(gv, true, this);

                    //DisplayMessage("초기화했습니다.");
                    _luORDER_NUMBER.Text = "";
                    _luORDER_NAME.Text = "";
                    _luORDER_REVISION.Text = "";
                    _luORDER_DATE.Text = "";
                    _luREMARK.Text = "";
                    _luCONTRACT.CodeText = "";
                    _luCONTRACT.NameText = "";
                }

                //데이터 영역

                //_luORDER_ID.Text = "";
                //_luORDER_ID.ReadOnly = true;
                //_luORDER_DATE.DateTime = DateTime.Today;
                //_luPRODUCTION_ORDER_QTY.Text = "0.00";
                //_luREFERENCE_ID.Text = "";
                //_luREFERENCE_ID.ReadOnly = true;
                //_luPART_NAME.Text = "";
                //_luPART_NAME.ReadOnly = true;
                //_luPROCESS_CODE_MST.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "PROCESSCODE_MAIN", "", "", "").Tables[0], 0, 0, "");
                //_luPROCESS_CODE_MST.ReadOnly = true;
                //_luPROCESS_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "WORKCENTER", "", "", "").Tables[0], 0, 0, "");
                //_luPROCESS_CODE.ReadOnly = true;
                //_luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                //_luCOMPLETE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD51", "", "").Tables[0], 0, 0, "");
                //_luCOMPLETE_YN.ReadOnly = true;
                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                { 
                    _gdMAIN.DataSource = null;
                    _gdSUB.DataSource = null;
                    _luORDER_NUMBER.ReadOnly = true;
                    _luORDER_NAME.ReadOnly = true;
                    _luORDER_REVISION.ReadOnly = true;
                    _luORDER_DATE.ReadOnly = true;
                    _luREMARK.ReadOnly = true;
                    _luCONTRACT.CodeReadOnly = true;
                    _luCONTRACT.NameReadOnly = true;
                    _luUSE_YN.ReadOnly = true;
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

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this); //

                _gdSUB.DataSource = null;

                _dtSList = null;
                _dtSList = ((DataView)_gdMAIN_VIEW.DataSource).ToTable().Clone();
                _dtSList.ImportRow(gv.GetDataRow(gv.FocusedRowHandle));

                _pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_ID = gv.GetFocusedRowCellValue("PRODUCTION_PLAN_ID").ToString(); ;
                _pWorkOrdersRegister_T02Entity.USE_YN = gv.GetFocusedRowCellValue("USE_YN").ToString();
                _luCONTRACT.CodeText = gv.GetFocusedRowCellValue("CONTRACT_NUMBER").ToString();
                _luCONTRACT.NameText = gv.GetFocusedRowCellValue("CONTRACT_NAME").ToString();
                _luORDER_DATE.DateTime = Convert.ToDateTime(gv.GetFocusedRowCellValue("PRODUCTION_PLAN_DATE").ToString().Substring(0, 4) + "-" + gv.GetFocusedRowCellValue("PRODUCTION_PLAN_DATE").ToString().Substring(4, 2) + "-" + gv.GetFocusedRowCellValue("PRODUCTION_PLAN_DATE").ToString().Substring(6, 2));

                _pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_DATE = _dtSList.Rows[0]["PRODUCTION_PLAN_DATE"].ToString();
                _pWorkOrdersRegister_T02Entity.ORDER_NUMBER = _dtSList.Rows[0]["ORDER_NUMBER"].ToString();
                _pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_SEQ = _dtSList.Rows[0]["PRODUCTION_PLAN_SEQ"].ToString();
                _pWorkOrdersRegister_T02Entity.CONTRACT_NUMBER = _dtSList.Rows[0]["CONTRACT_NUMBER"].ToString();
                _pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_ID = _dtSList.Rows[0]["PRODUCTION_PLAN_ID"].ToString();



                SubFind_DisplayData(_pWorkOrdersRegister_T02Entity, _dtSList);


                _pWorkOrdersRegister_T02Entity.CRUD = "R";
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

                _pWorkOrdersRegister_T02Entity.DATE_FROM = DateTime.Parse(_luTORDER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");
                _pWorkOrdersRegister_T02Entity.DATE_TO = DateTime.Parse(_luTORDER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");
                //_pWorkOrdersRegister_T02Entity.PRODUCTION_ORDER_ID = _luTPRODUCTION_ORDER_ID.Text;
                _pWorkOrdersRegister_T02Entity.ORDER_NUMBER = _luTORDER_NUMBER.CodeText.ToString();
                _pWorkOrdersRegister_T02Entity.ORDER_NAME = _luTORDER_NUMBER.NameText.ToString();
                //_pWorkOrdersRegister_T02Entity.VEND_PART_CODE = _luTPART_ALL.CodeText;
                //_pWorkOrdersRegister_T02Entity.WORKCENTER_CODE = _luTWC_CODE.GetValue();
                //_pWorkOrdersRegister_T02Entity.PROCESS_CODE = _luTPC_CODE.GetValue();
                _pWorkOrdersRegister_T02Entity.USE_YN = _luTUSE_YN.GetValue();
                //_pWorkOrdersRegister_T02Entity.COMPLETE_YN = _luTCOMPLETE_YN.GetValue();


                _pWorkOrdersRegister_T02Entity.CRUD = "R";
                MainFind_DisplayData();

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

        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);


                //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업지시번호 "+_luORDER_ID.Text +"를 \n 저장 하겠습니까?") == DialogResult.No)
                //if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                //{
                //    return;
                //}
                //else
                //{
                    if (!dxValidationProvider.Validate())
                    {
                        return;
                    }
                    //확인
                    _pWorkOrdersRegister_T02Entity.CRUD = "U";
                    //_pWorkOrdersRegisterEntity.ORDER_CODE = _luORDER_ID.Text;
                    //_pWorkOrdersRegisterEntity.ORDER_DATE = _luORDER_DATE.DateTime.ToString("yyyyMMdd");
                    //_pWorkOrdersRegisterEntity.ORDER_QTY = _luPRODUCTION_ORDER_QTY.Text;
                    //_pWorkOrdersRegisterEntity.WORKCENTER_CODE = _luPROCESS_CODE.GetValue();
                    //_pWorkOrdersRegisterEntity.USE_YN = _luUSE_YN.GetValue();
                    //_pWorkOrdersRegisterEntity.COMPLETE_YN = _luTCOMPLETE_YN.GetValue();
                    InputData_Save(_pWorkOrdersRegister_T02Entity);
                //}
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
            //try
            //{
            //    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

            //    UI.PO.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
            //    UI.PO.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            //    UI.PO.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            //    UI.PO.UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
            //    UI.PO.UserForm.frmCommonPopup xfrmCommonPopup = new UI.PO.UserForm.frmCommonPopup("WorkOrderInfo_T03"); //유저컨트롤러 설정 부분


            //    xfrmCommonPopup.ShowDialog();

            //    if (xfrmCommonPopup.dtReturn == null)
            //    {
            //        xfrmCommonPopup.Dispose();
            //        return;
            //    }

            //    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            //    {
            //        _pLocation_Code = xfrmCommonPopup.dtReturn.Rows[0]["PRODUCTION_PLAN_ID"].ToString();
            //    }

            //    xfrmCommonPopup.Dispose();


            //    if (xfrmCommonPopup.dtReturn.Rows.Count != 0)

            //    {
            //        Form_SearchButtonClicked(null, null);
            //    }

            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
            //finally
            //{
            //    CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            //}
        }
        #endregion

        #region ○ 삭제 버튼 클릭시 처리하기
        private void Form_DeleteButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                //확인
                //if (_gdSUB_VIEW.GetFocusedRowCellValue(_gdSUB_VIEW.Columns["CRUD"]).ToString() == "C")
                //{
                //    // 신규 데이터는 로우 삭제
                //    _gdSUB_VIEW.DeleteRow(_gdSUB_VIEW.FocusedRowHandle);
                //}
                //else
                //{
                //    // 수정 데이터는 "CRUD" 처리
                //    _gdSUB_VIEW.SetRowCellValue(_gdSUB_VIEW.FocusedRowHandle, _gdSUB_VIEW.Columns["CRUD"], "D");
                //}

                // 수정 후 포커스 이동 안되면 데이터 반영 안됨. 
                // 삭제 버튼 클릭시에는 GetFocusedDataRow().EndEdit() 처리 해야됨.
                // 마우스 팝업 메뉴에서 처리는 자동으로 처리됨.
                //_gdSUB_VIEW.GetFocusedDataRow().EndEdit();

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
                InitializeSetting();
                //조회조건 영역 
                _luTUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "",true);
                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                //_luTWC_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "WORKCENTER", "", "", "").Tables[0], 0, 0, "", true);
                //_luTPC_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PROCESSCODE_MAIN", "", "", "").Tables[0], 0, 0, "", true);
                //_luTCOMPLETE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "common_code", "CD51", "", "").Tables[0], 0, 0, "", true);
                _luTORDER_DATE.FromDateTime = Convert.ToDateTime("2000-01-01");  //조회 시작일, 매월 초 날짜로 설정
                _luTORDER_DATE.ToDateTime = DateTime.Today.AddDays(1);  //조회 종료일, 당일 설정
                _pWorkOrdersRegister_T02Entity.REFERENCE_ID = "";
                //_luTPART_ALL.CodeText = "";
                //_luTPART_ALL.NameText = "";
                _luTORDER_NUMBER.CodeText = "";
                _luTORDER_NUMBER.NameText = "";
                _luALL_PERCENT.Text = "0";
                //_luTPRODUCTION_ORDER_ID.Text = "";

                //   GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                //  CoFAS_ControlManager.Controls_Binding(gv, true, this);

                //DisplayMessage("초기화했습니다.");
                _luORDER_NUMBER.Text = "";
                _luORDER_NAME.Text = "";
                _luORDER_REVISION.Text = "";
                _luORDER_DATE.Text = "";
                _luREMARK.Text = "";
                _luCONTRACT.CodeText = "";
                _luCONTRACT.NameText = "";

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
                
                _dtList = new WorkOrdersRegister_T02Business().Sample_Info(_pWorkOrdersRegister_T02Entity);

                if (_pWorkOrdersRegister_T02Entity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pWorkOrdersRegister_T02Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "")
                    {
                        int rowHandle = _gdSUB_VIEW.LocateByValue("ORDER_ID", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        {
                            _gdSUB_VIEW.FocusedRowHandle = rowHandle;
                            //_luORDER_ID.Text = _pLocation_Code;
                        }
                        //조회 후 초기화 
                        _pLocation_Code = "";
                        //_luTPART_ALL.CodeText = "";
                        //_luTPART_ALL.NameText = "";
                    }


                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    //_dtList.Rows.Clear();
                    //CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                //_gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 서브조회 - SubFind_DisplayData() 

        private void SubFind_DisplayData(WorkOrdersRegister_T02Entity _pWorkOrdersRegister_T02Entity, DataTable selectdt)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pWorkOrdersRegister_T02Entity.CRUD = "R";
                _pWorkOrdersRegister_T02Entity.DATE_FROM = DateTime.Parse(_luTORDER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");
                _pWorkOrdersRegister_T02Entity.DATE_TO = DateTime.Parse(_luTORDER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");
                _pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_ID = selectdt.Rows[0]["PRODUCTION_PLAN_ID"].ToString();
                _pWorkOrdersRegister_T02Entity.COMPLETE_YN = "";
                _pWorkOrdersRegister_T02Entity.USE_YN = selectdt.Rows[0]["USE_YN"].ToString();
                _pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_DATE = selectdt.Rows[0]["PRODUCTION_PLAN_DATE"].ToString();
                _pWorkOrdersRegister_T02Entity.ORDER_NUMBER = selectdt.Rows[0]["ORDER_NUMBER"].ToString();
                _pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_SEQ = selectdt.Rows[0]["PRODUCTION_PLAN_SEQ"].ToString();
                _pWorkOrdersRegister_T02Entity.CONTRACT_NUMBER = selectdt.Rows[0]["CONTRACT_NUMBER"].ToString();
                _pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_ID = selectdt.Rows[0]["PRODUCTION_PLAN_ID"].ToString();

                _dtList = new WorkOrdersRegister_T02Business().Sample_Info_Sub(_pWorkOrdersRegister_T02Entity);

                if (_pWorkOrdersRegister_T02Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pWorkOrdersRegister_T02Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
                }
                else
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB, _gdSUB_VIEW, _dtList);
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
                // _gdSUB_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 저장 - InputData_Save(ProductOutRegisterEntity _pProductOutRegisterEntity) 

        private void InputData_Save(WorkOrdersRegister_T02Entity _pWorkOrdersRegister_T02Entity)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;
                DataTable dt;
                DataTable dtTemp;
                int rowhandle = 0;

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                {
                    rowhandle = _gdMAIN_VIEW.GetFocusedDataSourceRowIndex();
                    dt = _gdSUB.DataSource as DataTable;
                    if (CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", ""))
                    {
                        dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", "");

                        isError = new WorkOrdersRegister_T02Business().Sample_Info_Save(_pWorkOrdersRegister_T02Entity, dtTemp);

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
                            //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

                            _pLocation_Code = _pWorkOrdersRegister_T02Entity.RTN_KEY;  //저장 위치 
                            SubFind_DisplayData(_pWorkOrdersRegister_T02Entity, _dtSList);
                            Form_SearchButtonClicked(null, null);
                            if (rowhandle == 0)
                                rowhandle = _gdMAIN_VIEW.RowCount;
                            _gdMAIN_VIEW.SelectRow(rowhandle);

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

        #region 현재버전에서 사용안함. 삭제하지말것

        private void _luTPART_ALL_OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //try
            //{
            //    //_pPART_CODE = _pARRAY_CODE[0].ToString();
            //    //_pVEND_PART_CODE = _pARRAY_CODE[1].ToString();
            //    //_pPART_NAME = _pARRAY_CODE[2].ToString();
            //    //_pPART_TYPE = _pARRAY_CODE[3].ToString();
            //    //_pSERVICE_NAME = _pARRAY_CODE[4].ToString();
            //    frmCommonPopup.USER_CODE = _pUSER_CODE;
            //    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            //    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            //    frmCommonPopup.ARRAY = new object[5] { "", "","","","" }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
            //    frmCommonPopup.ARRAY_CODE = new object[5] { "", "","","","VEND_PART_PDT" };
            //    frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("VENDPARTCODE_POPUP"); //유저컨트롤러 설정 부분

            //    xfrmCommonPopup.ShowDialog();

            //    if (xfrmCommonPopup.dtReturn == null)
            //    {
            //        xfrmCommonPopup.Dispose();
            //        return;
            //    }

            //    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            //    {
            //        //_luTPART_ALL.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_PART_CODE"].ToString();
            //        //_luTPART_ALL.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
            //    }

            //    xfrmCommonPopup.Dispose();
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
        }

        private void _luTPLAN_ORDER__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //try
            //{
            //    frmCommonPopup.USER_CODE = _pUSER_CODE;
            //    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            //    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            //    frmCommonPopup.ARRAY = new object[2] { "PlanOrderInfo_Popup", "" }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
            //    frmCommonPopup.ARRAY_CODE = new object[2] { _luTORDER_NUMBER.Text, "" };
            //    frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("PlanOrderInfo_Popup"); //유저컨트롤러 설정 부분

            //    xfrmCommonPopup.ShowDialog();

            //    if (xfrmCommonPopup.dtReturn == null)
            //    {
            //        xfrmCommonPopup.Dispose();
            //        return;
            //    }

            //    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            //    {
            //        _luTORDER_NUMBER.Text = xfrmCommonPopup.dtReturn.Rows[0]["PLAN_ORDER"].ToString();
            //    }

            //    xfrmCommonPopup.Dispose();
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
        }

        private void _gdROUTING_VIEW_ShownEditor(object sender, EventArgs e)
        {
            //ColumnView view = (ColumnView)sender;
            //int qRowIndex = view.FocusedRowHandle;

            //if (view.ActiveEditor.GetType().Name != "LookUpEdit") return;


            //string strPROCESS_MST_CODE = view.GetRowCellValue(qRowIndex, "PROCESS_MST_CODE").ToString();
            //string strEQUIPMENT_MST_CODE = view.GetRowCellValue(qRowIndex, "EQUIPMENT_MST_CODE").ToString();
            //string strTERMINAL_MST_CODE = view.GetRowCellValue(qRowIndex, "TERMINAL_MST_CODE").ToString();
            //string strRESOURCE_MST_CODE = view.GetRowCellValue(qRowIndex, "RESOURCE_MST_CODE").ToString();
            //string strTOOL_MST_CODE = view.GetRowCellValue(qRowIndex, "TOOL_MST_CODE").ToString();

            //LookUpEdit edit = (LookUpEdit)view.ActiveEditor;

            //DataTable empty_table = new DataTable();
            //DataRow row = null;
            //DataTable tmp = new DataTable();

            //if (view.FocusedColumn.FieldName == "PROCESS_CODE" && view.ActiveEditor is LookUpEdit)
            //{
            //    if (strPROCESS_MST_CODE == "")
            //    {
            //        empty_table.Columns.Add(new DataColumn("CD", typeof(string)));
            //        empty_table.Columns.Add(new DataColumn("CD_NM", typeof(string)));

            //        row = empty_table.NewRow();

            //        row["CD"] = "";
            //        row["CD_NM"] = "";

            //        empty_table.Rows.Add(row);
            //        edit.Properties.DataSource = empty_table;
            //        edit.Properties.DropDownRows = empty_table.Rows.Count;
            //    }
            //    else
            //    {
            //        //if (tmp_PROCESS.Select("CD like'" + strPROCESS_MST_CODE + "%'").Length == 0)
            //        //{
            //        //    empty_table.Columns.Add(new DataColumn("CD", typeof(string)));
            //        //    empty_table.Columns.Add(new DataColumn("CD_NM", typeof(string)));

            //        //    row = empty_table.NewRow();

            //        //    row["CD"] = "";
            //        //    row["CD_NM"] = "";

            //        //    empty_table.Rows.Add(row);
            //        //    edit.Properties.DataSource = empty_table;
            //        //    edit.Properties.DropDownRows = empty_table.Rows.Count;
            //        //}
            //        //else
            //        //{
            //        //    tmp = tmp_PROCESS.Select("CD like'" + strPROCESS_MST_CODE + "%'").CopyToDataTable();
            //        //    edit.Properties.DataSource = tmp;
            //        //    edit.Properties.DropDownRows = tmp.Rows.Count;
            //        //}
            //    }
            //}
        }

        private void _ucbtAPPLY_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                UI.PO.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                UI.PO.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                UI.PO.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                UI.PO.UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                UI.PO.UserForm.frmCommonPopup xfrmCommonPopup = new UI.PO.UserForm.frmCommonPopup("WorkOrderInfo_T03"); //유저컨트롤러 설정 부분


                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _pLocation_Code = xfrmCommonPopup.dtReturn.Rows[0]["PRODUCTION_PLAN_ID"].ToString();
                }

                xfrmCommonPopup.Dispose();


                if (xfrmCommonPopup.dtReturn.Rows.Count != 0)

                {
                    Form_SearchButtonClicked(null, null);
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

        #region ○ 그리드 버튼추가 시 클릭 이벤트 생성 - CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        private void CoFAS_DevExpressManager_OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CoFAS_DevExpressManager._OnButtonPressed -= CoFAS_DevExpressManager_OnButtonPressed;
            btnEvent(sender, e);
            CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager_OnButtonPressed;
        }

        private void btnEvent(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btnedit = sender as ButtonEdit;
            GridView g = null;
            string _sFCode = string.Empty;
            string _sFName = string.Empty;


            string _sResultCode = string.Empty;
            string _sResultName = string.Empty;

            if (btnedit != null)
            {
                var gridControl = btnedit.Parent as DevExpress.XtraGrid.GridControl;
                if (gridControl == null)
                    return;

                var gridView = gridControl.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
                g = gridView;
                if (gridView == null)
                    return;

                var dataRow = gridView.GetFocusedDataRow();
                if (dataRow == null)
                    return;
            }


            //switch (e.Button.Caption.ToString())
            switch (g.FocusedColumn.FieldName)
            {
                case "BTN_WOPDT": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.
                    _sFCode = g.GetFocusedRowCellValue("PART_CODE").ToString();
                    _sFName = g.GetFocusedRowCellValue("PART_NAME").ToString();

                    frmCommonPopup.CRUD = "R";
                    frmCommonPopup.USER_CODE = _pUSER_CODE;
                    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    frmCommonPopup.ARRAY = new object[2] { "Product_Code_R", "" };
                    frmCommonPopup.ARRAY_CODE = new object[2] { _sFCode, _sFName };
                    frmCommonPopup xfrmCommonPopup1 = new frmCommonPopup("CommonCode");

                    xfrmCommonPopup1.ShowDialog();

                    if (xfrmCommonPopup1.dtReturn == null)
                    {
                        xfrmCommonPopup1.Dispose();
                        return;
                    }

                    if (xfrmCommonPopup1.dtReturn.Rows.Count > 0)
                    {
                        _sResultCode = xfrmCommonPopup1.dtReturn.Rows[0]["CD"].ToString();
                        _sResultName = xfrmCommonPopup1.dtReturn.Rows[0]["CD_NM"].ToString();
                    }

                    xfrmCommonPopup1.Dispose();

                    if (!_sResultCode.Equals("") && !_sResultName.Equals(""))
                    {
                        g.SetFocusedRowCellValue("PART_CODE", _sResultCode);
                        g.SetFocusedRowCellValue("PART_NAME", _sResultName);
                    }

                    break;
                case "BTN_WOPROCESS":
                    //_sFCode = g.GetFocusedRowCellValue("VEND_CODE").ToString();
                    //_sFName = g.GetFocusedRowCellValue("VEND_NAME").ToString();

                    //frmCommonPopup.CRUD = "R";
                    //frmCommonPopup.USER_CODE = _pUSER_CODE;
                    //frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    //frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    //frmCommonPopup.ARRAY = new object[2] { "vend_code", "" };
                    //frmCommonPopup.ARRAY_CODE = new object[2] { _sFCode, _sFName };
                    //frmCommonPopup xfrmCommonPopup2 = new frmCommonPopup("CommonCode");

                    //xfrmCommonPopup2.ShowDialog();

                    //if (xfrmCommonPopup2.dtReturn == null)
                    //{
                    //    xfrmCommonPopup2.Dispose();
                    //    return;
                    //}
                    //if (xfrmCommonPopup2.dtReturn.Rows.Count > 0)
                    //{
                    //    _sResultCode = xfrmCommonPopup2.dtReturn.Rows[0]["CD"].ToString();
                    //    _sResultName = xfrmCommonPopup2.dtReturn.Rows[0]["CD_NM"].ToString();
                    //}

                    //xfrmCommonPopup2.Dispose();

                    //if (!_sResultCode.Equals("") && !_sResultName.Equals(""))
                    //{
                    //    g.SetFocusedRowCellValue("VEND_CODE", _sResultCode);
                    //    g.SetFocusedRowCellValue("VEND_NAME", _sResultName);
                    //}
                    break;
            }
        }
        #endregion




        #region 자동계산
        private void _gdSUB_VIEW_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            _gdSUB_VIEW.CellValueChanged -= _gdSUB_VIEW_CellValueChanged;
            ChangeValues(sender, e);
            _gdSUB_VIEW.CellValueChanged += _gdSUB_VIEW_CellValueChanged;
        }

        private void ChangeValues(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView g = sender as GridView;

            int selectedRowNum = g.FocusedRowHandle;
            int selectedCellNum = g.FocusedColumn.VisibleIndex;
            decimal order_qty = 0;
            decimal unit_cost = 0;
            decimal cost = 0;

            if (g.GetRowCellDisplayText(selectedRowNum, "ORDER_QTY").Equals("")) return;
            if (g.GetRowCellDisplayText(selectedRowNum, "ORDER_INCREASE").Equals("")) return;
            

            if(g.FocusedColumn.FieldName == "PRODUCTION_ORDER_QTY")
            {
                order_qty = Convert.ToDecimal(g.GetRowCellValue(selectedRowNum, "ORDER_QTY").ToString() == "" ? "0" : g.GetRowCellValue(selectedRowNum, "ORDER_QTY"));
                unit_cost = Convert.ToDecimal(g.GetRowCellValue(selectedRowNum, "PRODUCTION_ORDER_QTY").ToString() == "" ? "0" : g.GetRowCellValue(selectedRowNum, "PRODUCTION_ORDER_QTY"));
                cost = Math.Truncate(Math.Round((unit_cost / order_qty),3)*100);

                g.SetFocusedRowCellValue("ORDER_INCREASE", cost);
            }
            else
            {
                order_qty = Convert.ToDecimal(g.GetRowCellValue(selectedRowNum, "ORDER_QTY").ToString() == "" ? "0" : g.GetRowCellValue(selectedRowNum, "ORDER_QTY"));
                unit_cost = Convert.ToDecimal(g.GetRowCellValue(selectedRowNum, "ORDER_INCREASE").ToString() == "" ? "0" : g.GetRowCellValue(selectedRowNum, "ORDER_INCREASE"));
                cost = Math.Ceiling(order_qty * (unit_cost / 100));

                g.SetFocusedRowCellValue("PRODUCTION_ORDER_QTY", cost);
            }

            
            
        }
        #endregion

        #region 조회 - 주문번호 검색 ORDER NUMBER EVENT
        private void _luTORDER_NUMBER__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                PO.UserForm.frmCommonPopup.CRUD = "R";
                PO.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                PO.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                PO.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                PO.UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" };
                PO.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] { _luTORDER_NUMBER.CodeText.ToString(), _luTORDER_NUMBER.NameText.ToString() };
                PO.UserForm.frmCommonPopup xfrmCommonPopup = new PO.UserForm.frmCommonPopup("ucOrderNumberInfoListPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luTORDER_NUMBER.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["ORDER_NUMBER"].ToString();
                    _luTORDER_NUMBER.NameText = xfrmCommonPopup.dtReturn.Rows[0]["ORDER_NAME"].ToString();
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion


        #region 전체 퍼센트 변경
        private void _luALL_PERCENT__OnTextChanged(object sender, EventArgs e)
        {
            decimal order_qty = 0;
            decimal order_increase = 0;
            decimal production_order_qty = 0;

            DataTable _dtTemp = _gdSUB.DataSource as DataTable;
            if (_dtTemp == null) return;
            if(_dtTemp.Rows.Count > 0)
            {
                for(int i = 0;i<_dtTemp.Rows.Count;i++)
                {
                    if (_luALL_PERCENT.Text.ToString() == "") break;

                    if (_dtTemp.Rows[i]["CRUD"].ToString().Equals("")) break;

                    _dtTemp.Rows[i]["ORDER_INCREASE"] = Convert.ToDecimal(_luALL_PERCENT.Text.ToString());

                    if (_dtTemp.Rows[i]["ORDER_QTY"].ToString().Equals("")) return;
                    if (_dtTemp.Rows[i]["ORDER_INCREASE"].ToString().Equals("")) return;


                    order_qty = Convert.ToDecimal(_dtTemp.Rows[i]["ORDER_QTY"].ToString() == "" ? "0" : _dtTemp.Rows[i]["ORDER_QTY"]);
                    order_increase = Convert.ToDecimal(_dtTemp.Rows[i]["ORDER_INCREASE"].ToString() == "" ? "0" : _dtTemp.Rows[i]["ORDER_INCREASE"]);
                    _dtTemp.Rows[i]["PRODUCTION_ORDER_QTY"] = Math.Ceiling(order_qty * (order_increase / 100));

                }
            }
        }
        #endregion

        #region 키보드 이동
        private void _gdMAIN_VIEW_RowChange(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                if ((gv.DataSource as DataTable) == null) return;
                CoFAS_ControlManager.Controls_Binding(gv, false, this); //

                _gdSUB.DataSource = null;

                _dtSList = null;
                _dtSList = ((DataView)_gdMAIN_VIEW.DataSource).ToTable().Clone();
                _dtSList.ImportRow(gv.GetDataRow(gv.FocusedRowHandle));

                _pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_ID = gv.GetFocusedRowCellValue("PRODUCTION_PLAN_ID").ToString(); ;
                _pWorkOrdersRegister_T02Entity.USE_YN = gv.GetFocusedRowCellValue("USE_YN").ToString();
                _luCONTRACT.CodeText = gv.GetFocusedRowCellValue("CONTRACT_NUMBER").ToString();
                _luCONTRACT.NameText = gv.GetFocusedRowCellValue("CONTRACT_NAME").ToString();
                _luORDER_DATE.DateTime = Convert.ToDateTime(gv.GetFocusedRowCellValue("PRODUCTION_PLAN_DATE").ToString().Substring(0, 4) + "-" + gv.GetFocusedRowCellValue("PRODUCTION_PLAN_DATE").ToString().Substring(4, 2) + "-" + gv.GetFocusedRowCellValue("PRODUCTION_PLAN_DATE").ToString().Substring(6, 2));

                _pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_DATE = _dtSList.Rows[0]["PRODUCTION_PLAN_DATE"].ToString();
                _pWorkOrdersRegister_T02Entity.ORDER_NUMBER = _dtSList.Rows[0]["ORDER_NUMBER"].ToString();
                _pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_SEQ = _dtSList.Rows[0]["PRODUCTION_PLAN_SEQ"].ToString();
                _pWorkOrdersRegister_T02Entity.CONTRACT_NUMBER = _dtSList.Rows[0]["CONTRACT_NUMBER"].ToString();
                _pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_ID = _dtSList.Rows[0]["PRODUCTION_PLAN_ID"].ToString();



                SubFind_DisplayData(_pWorkOrdersRegister_T02Entity, _dtSList);


                _pWorkOrdersRegister_T02Entity.CRUD = "R";
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion
    }
}
