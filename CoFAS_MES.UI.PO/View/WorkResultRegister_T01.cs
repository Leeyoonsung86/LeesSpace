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

using CoFAS_MES.UI.PO.Business;
using CoFAS_MES.UI.PO.Entity;
using CoFAS_MES;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Business;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.UserForm;
using DevExpress.XtraPrinting;

namespace CoFAS_MES.UI.PO
{
    public partial class WorkResultRegister_T01 : frmBaseNone
    {
        #region ○ 기본 전역변수

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
        private string _pAPPROVAL = string.Empty;              // 승인여부
        private string _pJOB_STATUS = string.Empty;     // 작업요청
        private string _pJOB_STATUS_NAME = string.Empty;     // 작업요청명
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭

        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pUSER_GRANT = string.Empty;      // 사용자 권한

        private WorkResultRegister_T01Entity _pWorkResultRegister_T01Entity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtSub = null;
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private int _gdMAIN_index = -1;

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
        private string _pMSG_PROCESS_CODE = string.Empty;   // 작업장선택이 안되어 실적등록을 할 수 없습니다.
        private string _pMSG_STATUS_OK = string.Empty;      // 작업이 완료되어 실적등록을 할 수 없습니다.

        //알림창메시지 복사 끝

        #endregion

        #region ○ 생성자

        public WorkResultRegister_T01()
        {
            InitializeComponent();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        #endregion

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

              //  Form_SearchButtonClicked(null, null);

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
                _pnRight.Width = 620;

                //버튼 폰트색상 및 배경색상
                _ucbtINSPECT_REQUEST.BackColor = Color.LightBlue;
                _ucbtJOB_ORDER.BackColor = Color.LightBlue;
                _ucbtJOB_REQUEST.BackColor = Color.LightBlue;

                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                _pUSER_GRANT = MainForm.UserEntity.USER_GRANT;

                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_IP_PORT = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PW = MainForm.UserEntity.FTP_PW;
                _pFTP_PATH = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
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
                _pMSG_PROCESS_CODE = MainForm.MessageEntity.MSG_PROCESS_CODE;
                _pMSG_STATUS_OK = MainForm.MessageEntity.MSG_STATUS_OK;

                _pWINDOW_NAME = this.Name;
                _pMENU_NAME = this.Text;

                //메뉴 화면 엔티티 설정
                _pWorkResultRegister_T01Entity = new WorkResultRegister_T01Entity();
                _pWorkResultRegister_T01Entity.USER_CODE = _pUSER_CODE;
                _pWorkResultRegister_T01Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

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

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pWorkResultRegister_T01Entity.CRUD = "";
                if (_pFirstYN)
                {
                    xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
                    _pFirstYN = false;

                    if (DBManager.InitDatabaseName == "coever_mes_glenzen")
                    {
                            layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                            layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    }
                    _gdMAIN_VIEW.PrintInitialize += _gdMAIN_VIEW_PrintInitialize;

                }

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
                    _gdSUB1_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB1, _gdSUB1_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB1.Name.ToString()));
                    _gdSUB2_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB2, _gdSUB2_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB2.Name.ToString()));
                    _gdSUB3_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB3, _gdSUB3_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB3.Name.ToString()));
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

                //조회조건 영역
                _luTORDER_DATE.FromDateTime = DateTime.Today;   //조회 시작일, 매월 초 날짜로 설정
                _luTORDER_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                _luTWORK_ORDER.Text = "";
                _luTPART.NameText = "";
                _luTPART.CodeText = "";

                //_luTWC_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "WORKCENTER", "", "", "").Tables[0], 0, 0, "", true);
                //_luTPC_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "PROCESSCODE_MAIN", "", "", "").Tables[0], 0, 0, "", true);
                _luTPC_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PROCESS_MST_CODE_COSMETICS_Lookup", "", "", "").Tables[0], 0, 0, "");

                
                //데이터 영역

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _gdMAIN.DataSource = null;
                _gdSUB1.DataSource = null;
                _gdSUB2.DataSource = null;
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

                int qRowIndex = gv.FocusedRowHandle;
                string qColumnHeader = e.Column.Caption;
                string qWorkOrderID = gv.GetRowCellValue(qRowIndex, "PRODUCTION_ORDER_ID").ToString();

                _gdMAIN_index = qRowIndex;
                _pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID = gv.GetRowCellValue(qRowIndex, "PRODUCTION_ORDER_ID").ToString();
                _pWorkResultRegister_T01Entity.ORDER_FILE = gv.GetRowCellValue(qRowIndex, "ORDER_FILE").ToString();
                _pWorkResultRegister_T01Entity.PART_CODE = gv.GetRowCellValue(qRowIndex, "PART_CODE").ToString();
                _pWorkResultRegister_T01Entity.PART_NAME = gv.GetRowCellValue(qRowIndex, "PART_NAME").ToString(); ;
                _pWorkResultRegister_T01Entity.PROCESS_CODE = gv.GetRowCellValue(qRowIndex, "PROCESS_CODE").ToString();
                _pWorkResultRegister_T01Entity.USE_YN = gv.GetRowCellValue(qRowIndex, "PRODUCTION_STATUS").ToString();
                _pWorkResultRegister_T01Entity.PRODUCTION_ORDER_QTY = gv.GetRowCellValue(qRowIndex, "PRODUCTION_ORDER_QTY").ToString();
                _pWorkResultRegister_T01Entity.PRODUCTION_RESULT_QTY = gv.GetRowCellValue(qRowIndex, "PRODUCTION_RESULT_QTY").ToString();
                
                _pAPPROVAL = gv.GetRowCellValue(qRowIndex, "APPROVAL").ToString();
                _pJOB_STATUS = gv.GetRowCellValue(qRowIndex, "JOB_STATUS").ToString();
                _pJOB_STATUS_NAME = gv.GetRowCellDisplayText(qRowIndex, "JOB_STATUS").ToString();

                _pWorkResultRegister_T01Entity.PROCESS_CODE_MST = gv.GetRowCellValue(qRowIndex, "PROCESS_CODE_MST").ToString();

                if (DBManager.InitDatabaseName == "coever_mes_glenzen")
                {

                    if (gv.GetRowCellDisplayText(qRowIndex, "PROCESS_CODE_MST").ToString() == "제조")
                        //layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    else
                        //layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
                else
                { 
               // //제조는 작업요청안함
               // if (gv.GetRowCellDisplayText(qRowIndex, "PROCESS_CODE_MST").ToString() == "제조")
               //     //layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
               //     layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
               // else
               //     //layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
               //     layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                }
                switch (qColumnHeader)
                {
                    case "양품":
                    case "불량":
                    case "상태":
                        SubFind_DisplayData(qWorkOrderID, qColumnHeader);
                        break;
                    default:
                        break;
                }
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

                _pWorkResultRegister_T01Entity.CRUD = "R";
                _pWorkResultRegister_T01Entity.DATE_FROM = DateTime.Parse(_luTORDER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");
                _pWorkResultRegister_T01Entity.DATE_TO = DateTime.Parse(_luTORDER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");
                _pWorkResultRegister_T01Entity.PART_CODE = _luTPART.CodeText;
                _pWorkResultRegister_T01Entity.PART_NAME = _luTPART.NameText;
                _pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID = _luTWORK_ORDER.Text;
                _pWorkResultRegister_T01Entity.PROCESS_CODE_MST = _luTPC_CODE.GetValue();
                _pWorkResultRegister_T01Entity.PROCESS_CODE = _luTWC_CODE.GetValue();
                //제조는 작업요청안함
                if (_luTPC_CODE.GetDisplayName() == "제조")
                //layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                {
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    _ucbtJOB_ORDER.Text = "1)제조지시서";
                    
                    _ucbtINSPECT_REQUEST.Text = "2)시험의뢰";

                }
                else
                {
                    //layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    _ucbtJOB_ORDER.Text = "2)포장지시서";
                    _ucbtJOB_REQUEST.Text = "1)작업요청의뢰";
                    _ucbtINSPECT_REQUEST.Text = "3)시험의뢰";
                }

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

                if (!dxValidationProvider.Validate())
                {
                    return;
                }

                //InputData_Save(_pContractMstRegisterEntity);
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

                if(_gdMAIN_index > -1)
                {
                    // 작업장 필수항목 체크 - 팝업 불필요
                    //if(_pWorkResultRegister_T01Entity.PROCESS_CODE == "")
                    //{
                    //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PROCESS_CODE);
                    //    return;
                    //}
                    //PC01 / PT040001 : 제조
                    //PC03 / PT040002 : 포장
                    if(_gdMAIN_VIEW.GetFocusedRowCellValue("COMPLETE_YN").ToString()=="Y")
                    {
                            CoFAS_DevExpressManager.ShowInformationMessage("생산완료가 되었습니다.");
                            return;
                    }
                    if ((_pWorkResultRegister_T01Entity.PROCESS_CODE_MST == "PC03") || _pWorkResultRegister_T01Entity.PROCESS_CODE_MST == "PT040002")
                    {
                        if (_pJOB_STATUS != "QC010004")
                        {
                            if (DBManager.InitDatabaseName == "coever_mes_glenzen")
                            {
                                // CoFAS_DevExpressManager.ShowInformationMessage("시험검사가 승인이 완료된 것만 등록가능합니다.");
                                // return;
                            }
                            else
                            {
                                //20181207
                                //중간에 그만할수도있으니
                               // CoFAS_DevExpressManager.ShowInformationMessage("작업요청을 먼저 완료하시기 바랍니다.\n[ 현재상태 : " + _pJOB_STATUS_NAME + " ]");
                               // return;
                            }


                        }
                    }
                   // if(_gdMAIN_VIEW.GetFocusedRowCellValue( "PROCESS_CODE_MST").ToString())
                    // 작업상태 완료시 체크 - 수정불가
                    if (_pAPPROVAL != "QC020001")
                    {
                        if (DBManager.InitDatabaseName == "coever_mes_glenzen")
                        {

                            if (_luTPC_CODE.GetDisplayName() == "포장")
                            {
                                CoFAS_DevExpressManager.ShowInformationMessage("시험검사가 승인이 완료된 것만 등록가능합니다.");
                                return;
                            }

                        }
                        else
                        {
                            //중간에 그만할수도있으니
                            //CoFAS_DevExpressManager.ShowInformationMessage("시험검사가 승인이 완료된 것만 등록가능합니다.");
                            //return;
                        }


                    }

                    // 팝업에 파라미터 전송
                    CoFAS_MES.UI.PO.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                    CoFAS_MES.UI.PO.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    CoFAS_MES.UI.PO.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
                    // _pWorkResultRegister_T01Entity.PROCESS_CODE_MST
                    CoFAS_MES.UI.PO.UserForm.frmCommonPopup.PROCESS_NAME = _pWorkResultRegister_T01Entity.PROCESS_CODE_MST;// _luTPC_CODE.GetValue();// GetDisplayName();// _luTPC_CODE.GetDisplayName();



                    _pLocation_Code = _pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID;
                    CoFAS_MES.UI.PO.UserForm.frmCommonPopup.ARRAY_CODE = new object[4] { _pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID, _pWorkResultRegister_T01Entity.PART_CODE, _pWorkResultRegister_T01Entity.PART_NAME , _pWorkResultRegister_T01Entity.PROCESS_CODE };
                    CoFAS_MES.UI.PO.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.PO.UserForm.frmCommonPopup("WorkResult"); //유저컨트롤러 설정 부분

                    xfrmCommonPopup.ShowDialog();
                    xfrmCommonPopup.Dispose();

                    _gdMAIN_index = -1;

                    Form_SearchButtonClicked(null, null);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 선택하여주시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SELECT);
                    return;
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

                //InputData_Save(_pContractMstRegisterEntity);
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
                //_gdMAIN_VIEW.OptionsPrint.AllowMultilineHeaders = false;
                _gdMAIN_VIEW.ShowPrintPreview();
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

        private void _gdMAIN_VIEW_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            PrintingSystemBase pb = e.PrintingSystem as PrintingSystemBase;
            //가로 회전
            pb.PageSettings.Landscape = true;

            //여백
            pb.PageMargins.Left = 10;
            pb.PageMargins.Right = 10;
            pb.PageMargins.Top = 10;
            pb.PageMargins.Bottom = 10;

        }
        #endregion 


        #region ○ 내보내기 버튼 클릭시 처리하기
        private void Form_ExportButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;
                if (_gdMAIN_VIEW.RowCount > 0)
                {

                    SaveFileDialog mDlg = new SaveFileDialog();
                    mDlg.InitialDirectory = Application.StartupPath;
                    //mDlg.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
                    mDlg.Filter = "Excel files (*.xls)|*.xls|Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    mDlg.FilterIndex = 1;
                    if (mDlg.ShowDialog() == DialogResult.OK)
                    {
                        _gdMAIN_VIEW.ExportToXlsx(mDlg.FileName);
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
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_RESET_QUESTION) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    InitializeSetting();
                    //GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
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

        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new WorkResultRegister_T01Business().WorkResultRegister_T01_Info_Mst(_pWorkResultRegister_T01Entity);
                
                if (_pWorkResultRegister_T01Entity.CRUD == "")
                    _dtList.Rows.Clear();

                if((_dtList != null && _dtList.Rows.Count > 0) || (_dtList !=null && _pWorkResultRegister_T01Entity.CRUD == ""))
                {
                    //데이터 필드에 맞춰 자동 바인딩
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                    _gdMAIN_index = -1;
                    _gdMAIN_VIEW.Columns["CRUD"].AppearanceCell.BackColor = Color.Red;
                   // _gdMAIN_VIEW.Columns["PRODUCT_ORDER_DATE"].AppearanceCell.ForeColor = Color.Yellow;

                    //글랜젠은 컬럼 비활성
                    if (DBManager.InitDatabaseName == "coever_mes_glenzen")
                    {
                        _gdMAIN_VIEW.Columns["JOB_STATUS"].Visible = false;
                    }
                    else
                    {
                        if (_luTPC_CODE.GetDisplayName() == "제조")
                        //layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        {
                            _gdMAIN_VIEW.Columns["JOB_STATUS"].Visible = false;
                        }
                        else
                        {
                            _gdMAIN_VIEW.Columns["JOB_STATUS"].Visible = true;
                        }
                    }
                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("PRODUCTION_ORDER_ID", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;


                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }

                    xtraTabControl1.SelectedTabPageIndex = 0;
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB1, _gdSUB1_VIEW, null);
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB2, _gdSUB2_VIEW, null);
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB3, _gdSUB3_VIEW, null);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtList.Rows.Clear();
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB1, _gdSUB1_VIEW, _dtList);
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB2, _gdSUB2_VIEW, _dtList);
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

        #region ○ 서브조회 - SubFind_DisplayData()

        private void SubFind_DisplayData(string qWorkOrder, string qColumnHeader)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID = qWorkOrder;
                _pWorkResultRegister_T01Entity.CODE_GUBN = qColumnHeader;
                _dtSub = new WorkResultRegister_T01Business().WorkResultRegister_T01_Info_Sub1(_pWorkResultRegister_T01Entity);

                if (_pWorkResultRegister_T01Entity.CRUD == "")
                    _dtSub.Rows.Clear();

                if (_dtSub != null && _dtSub.Rows.Count > 0)
                {
                    switch (qColumnHeader)
                    {
                        case "양품":
                            xtraTabControl1.SelectedTabPageIndex = 0;
                            CoFAS_DevExpressManager.BindGridControl(_gdSUB1, _gdSUB1_VIEW, _dtSub);
                            break;
                        case "불량":
                            xtraTabControl1.SelectedTabPageIndex = 1;
                            CoFAS_DevExpressManager.BindGridControl(_gdSUB2, _gdSUB2_VIEW, _dtSub);  
                            break;
                        case "상태":
                            xtraTabControl1.SelectedTabPageIndex = 2;
                            CoFAS_DevExpressManager.BindGridControl(_gdSUB3, _gdSUB3_VIEW, _dtSub);
                            break;
                    }
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    _dtSub.Rows.Clear();
                    switch (qColumnHeader)
                    {
                        case "양품":
                            xtraTabControl1.SelectedTabPageIndex = 0;
                            CoFAS_DevExpressManager.BindGridControl(_gdSUB1, _gdSUB1_VIEW, _dtSub); //데이터 필드에 맞춰 자동 바인딩
                            break;
                        case "불량":
                            xtraTabControl1.SelectedTabPageIndex = 1;
                            CoFAS_DevExpressManager.BindGridControl(_gdSUB2, _gdSUB2_VIEW, _dtSub); //데이터 필드에 맞춰 자동 바인딩
                            break;
                        case "상태":
                            xtraTabControl1.SelectedTabPageIndex = 2;
                            CoFAS_DevExpressManager.BindGridControl(_gdSUB3, _gdSUB3_VIEW, _dtSub); //데이터 필드에 맞춰 자동 바인딩
                            break;
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

        #region ○ 저장 - InputData_Save(DataTable dtSave)  

        private void InputData_Save(ContractMstRegisterEntity _pContractMstRegisterEntity)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;
                isError = new ContractMstRegisterBusiness().ContractMst_Save(_pContractMstRegisterEntity);
                if (!isError)
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    _pLocation_Code = _pContractMstRegisterEntity.RTN_KEY;  //저장 위치
                    InitializeControl();
                    Form_SearchButtonClicked(null, null);
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
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

        #region ○ 팝업 이벤트

        #region ● 품목찾기 팝업
        private void _luTPART__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                frmCommonPopup.ARRAY = new object[2] { "Product_Code", _luTPART.NameText }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                frmCommonPopup.ARRAY_CODE = new object[2] { _luTPART.CodeText, _luTPART.NameText };
                frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("PartCodeInfo"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luTPART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                    _luTPART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #endregion

        private void _ucbtINSPECT_REQUEST_Click(object sender, EventArgs e)
        {
         //  DialogResult res = InputBox.ShowDialog("Select some item from ComboBox below:",
         //      Combo InputBox",   //Text message (mandatory), Title (optional)
         //      InputBox.Icon.Question, //Set icon type (default info)
         //      InputBox.Buttons.OkCancel, //Set buttons (default ok)
         //      InputBox.Type.TextBox, //Set type (default nothing)
         //      new string[] { "Item1", "Item2", "Item3" }, //String field as ComboBox items (default null)
         //      true, //Set visible in taskbar (default false)
         //      new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold)); //Set font 
         //
            int cnt = 0;
            DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;
            //CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD ='Y'", "");
            for (int i = 0; i < tDataTable.Rows.Count; i++)
            {
                if (tDataTable.Rows[i]["CRUD"].ToString() == "Y")
                {
                    if (tDataTable.Rows[i]["INSPECT_STATUS"].ToString() != "QC010001")
                    {
                        if(tDataTable.Rows[i]["INSPECT_STATUS"].ToString() != "")
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage("이미 시험의뢰를 맡긴 작업지시가 있습니다.");
                            return;
                        }
                        
                    }
                    if (Convert.ToDecimal(tDataTable.Rows[i]["PRODUCTION_OK_QTY"].ToString())<=0)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("생산실적이 있어야합니다.");
                        return;
                    }
                    if (DBManager.InitDatabaseName == "coever_mes_glenzen")
                    {

                        if (tDataTable.Rows[i]["PROCESS_CODE_MST"].ToString() == "PC01")
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage("제조는 시험의뢰를 맡길 수가 없습니다.");
                            return;
                        }
                    }


                    cnt++;
                }
            }

            // MessageBox.Show(cnt.ToString());
            if (cnt == 0)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("하나 이상의 작업지시를 선택하세요");
                return;
            }

            DataTable tTempData = new DataTable();

            //테이블 스키마 복사
            //체크한거만 시험의뢰
            // tTempData = tDataTable.Clone();
            tTempData = CoFAS_ConvertManager.DataTable_FindValue(tDataTable, "CRUD ='Y'", "");
            
            //수량입력하는 화면 
            //VendCostInfo
            CoFAS_MES.UI.PO.UserForm.frmCommonPopup.CRUD = "R";
            CoFAS_MES.UI.PO.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
            CoFAS_MES.UI.PO.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            CoFAS_MES.UI.PO.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
            CoFAS_MES.UI.PO.UserForm.frmCommonPopup._DataTable = tTempData;


            
            // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            CoFAS_MES.UI.PO.UserForm.frmCommonPopup.ARRAY = new object[2] { "InputSamplingReseult", "" };

            //검색조건 전달 0 코드 1 명칭
            CoFAS_MES.UI.PO.UserForm.frmCommonPopup.ARRAY_CODE = new object[2] {"", "" };

            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            CoFAS_MES.UI.PO.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.PO.UserForm.frmCommonPopup("InputSamplingReseult"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();
            DataTable reutrn_dtable = new DataTable();
            reutrn_dtable = null;

            if (xfrmCommonPopup.dtReturn == null || xfrmCommonPopup.dtReturn.Rows.Count==0)
            {
                xfrmCommonPopup.Dispose();
                return;
            }

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                reutrn_dtable = xfrmCommonPopup.dtReturn;
            }

            xfrmCommonPopup.Dispose();


            if (CoFAS_DevExpressManager.ShowQuestionMessage(reutrn_dtable.Rows.Count.ToString() + "건의 시험의뢰를 하시겠습니까?") == DialogResult.Yes)
            {
                _pWorkResultRegister_T01Entity.CRUD = "C";
                bool isError;
                isError = new WorkResultRegister_T01Business().WorkResultRegister_T01_Info_Check_Save(_pWorkResultRegister_T01Entity, reutrn_dtable); // tDataTable);

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
                    _pLocation_Code = _pWorkResultRegister_T01Entity.RTN_KEY;  //저장 위치 
                    _pWorkResultRegister_T01Entity.CRUD = "R";
                    _pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID = "";
                    _pWorkResultRegister_T01Entity.PART_CODE = "";
                    _pWorkResultRegister_T01Entity.PART_NAME = "";
                    MainFind_DisplayData();
                }
            }

        }

        private void _luTPC_CODE_ValueChanged(object sender, EventArgs e)
        {
          // if (DBManager.InitDatabaseName == "coever_mes_glenzen")
          // {
          //     
          //     if (_luTPC_CODE.GetDisplayName() == "제조")
          //         //layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
          //         layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
          //     else
          //         //layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
          //         layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
          // }
        }

        #region 작업요청
        private void _ucbtJOB_REQUEST_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;
            //CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD ='Y'", "");
            //여러건일경우

            if (_gdMAIN_index > -1)
            {
                if (_gdMAIN_VIEW.GetFocusedRowCellValue("JOB_STATUS").ToString() != "QC010001")   //QC010001 = 없음
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("이미 작업요청을 하였습니다.");

                    return;
                }
                /*
                for (int i = 0; i < tDataTable.Rows.Count; i++)
                {
                    if (tDataTable.Rows[i]["CRUD"].ToString() == "Y")
                    {
                        if (tDataTable.Rows[i]["INSPECT_STATUS"].ToString() != "QC010001")
                        {
                            if (tDataTable.Rows[i]["INSPECT_STATUS"].ToString() != "")
                            {
                                CoFAS_DevExpressManager.ShowInformationMessage("이미 작업요청을 하였습니다.");
                                return;
                            }

                        }
                        cnt++;
                    }
                }
                */
                // MessageBox.Show(cnt.ToString());

                if (CoFAS_DevExpressManager.ShowQuestionMessage("작업요청 하시겠습니까?") == DialogResult.Yes)
                {
                    _pWorkResultRegister_T01Entity.CRUD = "U";
                    _pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID = _gdMAIN_VIEW.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString();
                    _pWorkResultRegister_T01Entity.PART_CODE = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_CODE").ToString();
                    bool isError;
                    isError = new WorkResultRegister_T01Business().WorkResultRegister_T01_Info_REQUEST_Save(_pWorkResultRegister_T01Entity, tDataTable);

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
                        _pLocation_Code = _pWorkResultRegister_T01Entity.RTN_KEY;  //저장 위치 
                        _pWorkResultRegister_T01Entity.CRUD = "R";
                        _pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID = "";
                        _pWorkResultRegister_T01Entity.PART_CODE = "";
                        _pWorkResultRegister_T01Entity.PART_NAME = "";
                        MainFind_DisplayData();
                    }
                }
            }
            else
            {
                CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SELECT);
                return;
            }

            _gdMAIN_index = -1;

        }
        #endregion

        private void _ucbtWORK_ORDER_Click(object sender, EventArgs e)
        {
            try
            {
                if (_pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID !="" && _pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID != null)
                {
              
            string part_type = "1005";
                CoFAS_MES.UI.PO.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                CoFAS_MES.UI.PO.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                CoFAS_MES.UI.PO.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;


                CoFAS_MES.UI.PO.UserForm.frmCommonPopup.FTP_ID = _pFTP_ID;
                CoFAS_MES.UI.PO.UserForm.frmCommonPopup.FTP_IP_PORT = _pFTP_IP_PORT;
                CoFAS_MES.UI.PO.UserForm.frmCommonPopup.FTP_PATH = _pFTP_PATH;
                CoFAS_MES.UI.PO.UserForm.frmCommonPopup.FTP_PW = _pFTP_PW;

                CoFAS_MES.UI.PO.UserForm.frmCommonPopup.WorkResultRegister_T01Entity = _pWorkResultRegister_T01Entity;
                CoFAS_MES.UI.PO.UserForm.frmCommonPopup.ARRAY = new object[5] {
                                                                                "ucWorkOrderDocRegPopup",
                                                                                _pWorkResultRegister_T01Entity.PROCESS_CODE_MST,
                                                                                _pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID,
                                                                                _pWorkResultRegister_T01Entity.ORDER_FILE,
                                                                                _pWorkResultRegister_T01Entity.PROCESS_CODE_MST
                                                                            }; //넘기는 파라메터 에 따라 설정, 제품/조회할때 품목명을 던지기
                CoFAS_MES.UI.PO.UserForm.frmCommonPopup.ARRAY_CODE = new object[3] { "", "", part_type };
                CoFAS_MES.UI.PO.UserForm.frmCommonPopup xfrmCommonPopup = new CoFAS_MES.UI.PO.UserForm.frmCommonPopup("ucWorkOrderDocRegPopup"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    MainFind_DisplayData();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                   //_luT_PART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["ORDER_ID"].ToString();
                   //_luT_PART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                }

                xfrmCommonPopup.Dispose();
                _pWorkResultRegister_T01Entity.CRUD = "R";
                _pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID = "";
                _pWorkResultRegister_T01Entity.PART_CODE = "";
                _pWorkResultRegister_T01Entity.PART_NAME = "";
                MainFind_DisplayData();
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("작업지시를 선택하여주시기 바랍니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SELECT);
                    return;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _ckALLCHECK_CheckedChanged(object sender, EventArgs e)
        {
            DataTable _dtTemp = _gdMAIN.DataSource as DataTable;
            if (_dtTemp == null) return;
            if (_dtTemp.Rows.Count <= 0) return;
            for (int i = 0; i < _dtTemp.Rows.Count; i++)
            {
                _dtTemp.Rows[i]["CRUD"] = _ckALLCHECK.Checked == true ? "Y" : "N";
            }
        }

    }
}
