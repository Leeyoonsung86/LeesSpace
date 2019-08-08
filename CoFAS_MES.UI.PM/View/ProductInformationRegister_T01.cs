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

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE;

using CoFAS_MES.UI.PM.Business;
using CoFAS_MES.UI.PM.Data;
using CoFAS_MES.UI.PM.Entity;
using CoFAS_MES.UI.PM.UserForm;
using DevExpress.XtraGrid.Views.Grid;


namespace CoFAS_MES.UI.PM
{
    public partial class ProductInformationRegister_T01 : frmBaseNone
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
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭
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

        //private bool _pImageDelete_YN = false;          //이미지가 휴지통으로 FTP에 삭제를 시키면 DB도 업뎃
        private string _pBefore_ImageName = string.Empty; // 이미지를 휴지통으로 삭제할 시 이전에 등록된게 있으면 ofd만 지우고, 데이터가 있었으면 FTP와 DB에서 삭제

        private ProductInformationRegister_T01Entity _pProductInformationRegister_T01Entity = null; // 엔티티 생성

        private CoFAS_DevGridManager _TempGridView;

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true;

        // 코에버 frp 관련 변수
        //private string _pFileName = "";                                 //local 파일이름   //ofd로 받아서 넣기 safe~
        //private string _pFullName = "";                                 //localfile 파일명 포함 전체 경로        
        //private string _pFTP_DOWNLOAD_PATH = ""; // ftp download에 사용
        //OpenFileDialog ofd;

        public ProductInformationRegister_T01()
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
                //    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
                //    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_EXIT_QUESTION) == DialogResult.No)
                //    {
                //        pFormClosingEventArgs.Cancel = true;
                //        return;
                //    }
                //}
                //else
                //{
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업 종료 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                    {
                        pFormClosingEventArgs.Cancel = true;
                        return;
                    }
                //}

                //pFormClosingEventArgs.Cancel = false;
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
                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;
                _gdMAIN_VIEW.InitNewRow -= _gdMAIN_VIEW_InitNewRow;
                _luT_PART._OnOpenClick -= _luT_PART_OnOpenClick;
                _luTCONTRACT._OnOpenClick -= _luTCONTRACT__OnOpenClick;
                _TempGridView._OnButtonPressed -= _TempGridView__OnButtonPressed;

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
                //dxWaitViewManager.ShowWaitForm();
                InitializeSetting();

                //버튼이벤트 생성
                SearchButtonClicked += new EventHandler(Form_SearchButtonClicked);
                SaveButtonClicked += new EventHandler(Form_SaveButtonClicked);
                DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
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
                //dxWaitViewManager.CloseWaitForm();
            }
        }

        //private void Viewer_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e)
        //{
        //    if (e.ConnectionName == "m.coever.co.kr_coever_mes_Connection")
        //    {
        //        e.ConnectionParameters = new MySqlConnectionParameters();
        //        SqlDashboardHelper.SetupSqlParameters((MySqlConnectionParameters)e.ConnectionParameters);
        //    }

        //}
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
                _pnLeft.Width = 800;

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
                _pMENU_NAME = this.Text;

                //메뉴 화면 엔티티 설정
                _pProductInformationRegister_T01Entity = new ProductInformationRegister_T01Entity();
                _pProductInformationRegister_T01Entity.CORP_CODE = _pCORP_CODE;
                _pProductInformationRegister_T01Entity.USER_CODE = _pUSER_CODE;
                _pProductInformationRegister_T01Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

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
                _pProductInformationRegister_T01Entity.CRUD = "R";
                if (_pFirstYN)
                {
                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.



                    _pFirstYN = false;
                }

                //SubFind_DisplayData("", ""); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                _gdMAIN_VIEW.InitNewRow += _gdMAIN_VIEW_InitNewRow;
                _gdMAIN_VIEW.CellValueChanged += _gdMAIN_VIEW_CellValueChanged;

                //_luT_PART._OnOpenClick += _luT_PART_OnOpenClick;
                //_luTCONTRACT._OnOpenClick += _luTCONTRACT_OnOpenClick;

                //그리드 버튼추가 시 클릭 이벤트 처리 
                _TempGridView._OnButtonPressed += _TempGridView__OnButtonPressed;

                //CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;


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
                pButtonSetting.UseYNSaveButton = _pMenuSettingEntity.MENU_SAVE == "Y" ? true : false; // 저장
                pButtonSetting.UseYNDeleteButton = false; //_pMenuSettingEntity.MENU_DELETE == "Y" ? true : false; // 삭제

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
                    _TempGridView = new CoFAS_DevGridManager();

                    _gdMAIN_VIEW = _TempGridView.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));

                   // _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
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
                //_luT_PART_TYPE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "PRODUCT_TYPE", "", "", "").Tables[0], 0, 0, "",false); //PART_TYPE_PRODUCT
                
                _luT_PART.CodeText = "";
                _luT_PART.NameText = "";
                
                //_luVEND_PART_CODE.Text = "";

                _luPART_REVISION_NO.Text = "";

                _luPART_HIGH.Text = "";

                _luPART_MIDDLE.Text = "";

                _luPART_LOW.Text = "";

                _luTCONTRACT.CodeText = "";
                _luTCONTRACT.NameText = "";

                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "",true);
                _luUSE_YN.ItemIndex = 1;
                if (_pFirstYN)
                {
                    _luPART_DATE.FromDateTime = Convert.ToDateTime("1900-01-01");
                    _luPART_DATE.ToDateTime = Convert.ToDateTime("9999-12-31");
                }
                
                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                _gdMAIN.DataSource = null;

                //데이터 영역
                //ofd = null;
                //_pImageDelete_YN = false;

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

        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {

                if (e.RowHandle < 0) return;

                //GridView gv = sender as GridView;

                //CoFAS_ControlManager.Controls_Binding(gv, false, this);

                //단가정보 확인
                //string strPART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                //string strPART_REVISION_NO = gv.GetFocusedRowCellValue("PART_REVISION_NO").ToString();
                //_pProductInformationRegister_T01Entity.CRUD = "R";

                //SubFind_DisplayData(strPART_CODE, strPART_REVISION_NO);

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion
        #region ○ 메인 그리드 셀 벨류 체인지 이벤트 생성 - _gdMAIN_VIEW_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        private void _gdMAIN_VIEW_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gv = sender as GridView;

            if (e.Column.FieldName == "")
            {
                // 찾기 후 입력

            }


        }
        #endregion

        #region ○ 메인 그리드 신규로우 생성시 이벤트 생성 - _gdMAIN_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        private void _gdMAIN_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["CONTRACT_NUMBER_QTY"], "0.00");
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_REVISION_NO"], "1.0");
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_TYPE"], "1001");
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_UNIT"], "1001");
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_COST"], "1.00");
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_SAFE_STOCK"], "0.00");
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_START_DATE"], DateTime.Now.ToString("yyyy-MM-dd"));
            view.SetRowCellValue(e.RowHandle, view.Columns["PART_END_DATE"], "9999-12-31");
            view.SetRowCellValue(e.RowHandle, view.Columns["SALE_YN"], "Y");
            view.SetRowCellValue(e.RowHandle, view.Columns["PURC_YN"], "N");
            view.SetRowCellValue(e.RowHandle, view.Columns["OUTT_YN"], "N");
            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
        }
        #endregion

        #region ○ 메인 그리드 버튼 클릭 이벤트 생성 - CoFAS_DevExpressManager__OnOpenButton(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //private void CoFAS_DevExpressManager__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    DataRow dr =  _gdMAIN_VIEW.GetFocusedDataRow();

        //   // if (dr["PART_CODE"].ToString() == "") return;

        //    switch (e.Button.Caption.ToString())
        //    {
        //        case "CONTRACT_BTN":
        //            UserForm.frmCommonPopup.CORP_CDDE = _pCORP_CODE;
        //            UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
        //            UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
        //            UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

        //            UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정
        //            UserForm.frmCommonPopup.ARRAY_CODE = new object[4] { "", "", "", "" }; //넘기는 파라메터 에 따라 설정

        //            UserForm.frmCommonPopup xfrmcommonPopup = new UserForm.frmCommonPopup("ucContractInfoPopup"); //유저컨트롤러 설정 부분

        //            xfrmcommonPopup.ShowDialog();

        //            if (xfrmcommonPopup.dtReturn == null || xfrmcommonPopup.dtReturn.Rows.Count == 0) return;
        //            xfrmcommonPopup.dtReturn.Rows[0][0].ToString();
        //            // 리턴 받는 데이터의 값은 해당 그리드 뷰 필드에 설정.
        //            _gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["CONTRACT_ID"], xfrmcommonPopup.dtReturn.Rows[0]["CONTRACT_ID"].ToString());
        //            _gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["CONTRACT_NUMBER"], xfrmcommonPopup.dtReturn.Rows[0]["CONTRACT_NUMBER"].ToString());
        //           // _gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["CONTRACT_QTY"], xfrmcommonPopup.dtReturn.Rows[0]["CONTRACT_QTY"].ToString());

        //            xfrmcommonPopup.Dispose();
        //            break;


        //        case "PART_COST_BTN": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.
        //            if (dr["PART_CODE"].ToString() == "") return;
        //            UserForm.frmCommonPopup.CORP_CDDE = _pCORP_CODE;
        //            UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
        //            UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
        //            UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

        //            UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정
        //            UserForm.frmCommonPopup.ARRAY_CODE = new object[4] { dr["PART_CODE"].ToString(), dr["PART_NAME"].ToString(), dr["PART_REVISION_NO"].ToString(), dr["VEND_PART_CODE"].ToString() }; //넘기는 파라메터 에 따라 설정

        //            UserForm.frmCommonPopup xfrmcommonPopup1 = new UserForm.frmCommonPopup("ucVendCostInfoPopup"); //유저컨트롤러 설정 부분

        //            xfrmcommonPopup1.ShowDialog();

        //            xfrmcommonPopup1.Dispose();

        //            break;
        //        case "PART_DOCUMENT_BTN": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.
        //            if (dr["PART_CODE"].ToString() == "") return;

        //            UserForm.frmCommonPopup.CORP_CDDE = _pCORP_CODE;
        //            UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
        //            UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
        //            UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
        //            UserForm.frmCommonPopup.FTP_PATH = _pFTP_PATH;
        //            UserForm.frmCommonPopup.FTP_ID = _pFTP_ID;
        //            UserForm.frmCommonPopup.FTP_PW = _pFTP_PW;

        //            UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정
        //            UserForm.frmCommonPopup.ARRAY_CODE = new object[6] { dr["PART_CODE"].ToString(), dr["PART_NAME"].ToString(), dr["PART_REVISION_NO"].ToString(), dr["VEND_PART_CODE"].ToString(), "", "" };// dr["CONTRACT_ID"].ToString(), dr["CONTRACT_NUMBER"].ToString() }; //넘기는 파라메터 에 따라 설정

        //            UserForm.frmCommonPopup xfrmcommonPopup2 = new UserForm.frmCommonPopup("ucPartDocumentListPopup"); //유저컨트롤러 설정 부분

        //            xfrmcommonPopup2.ShowDialog();

        //            xfrmcommonPopup2.Dispose();


        //            break;

        //    }
        //}

        private void _TempGridView__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = _gdMAIN_VIEW.GetFocusedDataRow();

            // if (dr["PART_CODE"].ToString() == "") return;

            switch (e.Button.Caption.ToString())
            {
                case "CONTRACT_BTN":
                    UserForm.frmCommonPopup.CORP_CDDE = _pCORP_CODE;
                    UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                    UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정
                    UserForm.frmCommonPopup.ARRAY_CODE = new object[4] { "", "", "", "" }; //넘기는 파라메터 에 따라 설정

                    UserForm.frmCommonPopup xfrmcommonPopup = new UserForm.frmCommonPopup("ucContractInfoPopup"); //유저컨트롤러 설정 부분

                    xfrmcommonPopup.ShowDialog();

                    if (xfrmcommonPopup.dtReturn == null || xfrmcommonPopup.dtReturn.Rows.Count == 0) return;
                    xfrmcommonPopup.dtReturn.Rows[0][0].ToString();
                    // 리턴 받는 데이터의 값은 해당 그리드 뷰 필드에 설정.
                    _gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["CONTRACT_ID"], xfrmcommonPopup.dtReturn.Rows[0]["CONTRACT_ID"].ToString());
                    _gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["CONTRACT_NUMBER"], xfrmcommonPopup.dtReturn.Rows[0]["CONTRACT_NUMBER"].ToString());
                    // _gdMAIN_VIEW.SetRowCellValue(_gdMAIN_VIEW.FocusedRowHandle, _gdMAIN_VIEW.Columns["CONTRACT_QTY"], xfrmcommonPopup.dtReturn.Rows[0]["CONTRACT_QTY"].ToString());

                    xfrmcommonPopup.Dispose();
                    break;


                case "PART_COST_BTN": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.
                    if (dr["PART_CODE"].ToString() == "") return;
                    frmCommonPopup.CORP_CDDE = _pCORP_CODE;
                    frmCommonPopup.USER_CODE = _pUSER_CODE;
                    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정
                    frmCommonPopup.ARRAY_CODE = new object[4] { dr["PART_CODE"].ToString(), dr["PART_NAME"].ToString(), dr["PART_REVISION_NO"].ToString(), dr["VEND_PART_CODE"].ToString() }; //넘기는 파라메터 에 따라 설정

                    frmCommonPopup xfrmcommonPopup1 = new frmCommonPopup("ucVendCostInfoPopup"); //유저컨트롤러 설정 부분

                    xfrmcommonPopup1.ShowDialog();

                    xfrmcommonPopup1.Dispose();

                    break;
                case "PART_DOCUMENT_BTN": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.
                    if (dr["PART_CODE"].ToString() == "") return;

                    frmCommonPopup.CORP_CDDE = _pCORP_CODE;
                    frmCommonPopup.USER_CODE = _pUSER_CODE;
                    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
                    frmCommonPopup.FTP_PATH = _pFTP_PATH;
                    frmCommonPopup.FTP_ID = _pFTP_ID;
                    frmCommonPopup.FTP_PW = _pFTP_PW;

                    frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정
                    frmCommonPopup.ARRAY_CODE = new object[6] { dr["PART_CODE"].ToString(), dr["PART_NAME"].ToString(), dr["PART_REVISION_NO"].ToString(), dr["VEND_PART_CODE"].ToString(), "", "" };// dr["CONTRACT_ID"].ToString(), dr["CONTRACT_NUMBER"].ToString() }; //넘기는 파라메터 에 따라 설정

                    frmCommonPopup xfrmcommonPopup2 = new frmCommonPopup("ucPartDocumentListPopup"); //유저컨트롤러 설정 부분

                    xfrmcommonPopup2.ShowDialog();

                    xfrmcommonPopup2.Dispose();


                    break;

            }
        }

        #endregion

        #region ○ 조회 서치박스 - _luT_PART_OnOpenClick(object sender, EventArgs e)
        private void _luT_PART_OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                //if (_ckCOPY.Checked)
                //{

                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "", "" };
                frmCommonPopup.ARRAY_CODE = new object[2] { _luT_PART.CodeText.ToString(), _luT_PART.NameText.ToString() };
                frmCommonPopup xfrmCommonPopup = new frmCommonPopup("ucProductionPartListPopup");  // new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

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

                    _luPART_CODE.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                }

                xfrmCommonPopup.Dispose();
                //}
                //else
                //{
                //    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_BOM_COPY_CHECK);
                //}
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }

            //try
            //{
            //    frmCommonPopup.CRUD = "R";
            //    frmCommonPopup.USER_CODE = _pUSER_CODE;
            //    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            //    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            //    // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            //    frmCommonPopup.ARRAY = new object[2] { "Product_Code_R2", "" };
            //    frmCommonPopup.ARRAY_CODE = new object[2] { _luT_PART.CodeText.ToString(), _luT_PART.NameText.ToString() };
            //    frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

            //    xfrmCommonPopup.ShowDialog();

            //    if (xfrmCommonPopup.dtReturn == null)
            //    {
            //        xfrmCommonPopup.Dispose();
            //        return;
            //    }

            //    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            //    {
            //        _luT_PART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
            //        _luT_PART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
            //    }

            //    xfrmCommonPopup.Dispose();
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
        }
        #endregion

        #region 조회 서치박스 -

        private void _luTCONTRACT__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                frmCommonPopup.CRUD = "R";
                frmCommonPopup.USER_CODE = _pUSER_CODE;
                frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                frmCommonPopup.ARRAY = new object[2] { "", "" };
                frmCommonPopup.ARRAY_CODE = new object[2] { _luTCONTRACT.CodeText.ToString(), _luTCONTRACT.NameText.ToString() };
                frmCommonPopup xfrmCommonPopup = new frmCommonPopup("ucContractInfoPopup"); //유저컨트롤러 설정 부분

                xfrmCommonPopup.ShowDialog();

                if (xfrmCommonPopup.dtReturn == null)
                {
                    xfrmCommonPopup.Dispose();
                    return;
                }

                if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                {
                    _luTCONTRACT.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CONTRACT_NUMBER"].ToString();
                    _luTCONTRACT.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CONTRACT_NAME"].ToString();

                    _luCONTRACT_ID.Text = xfrmCommonPopup.dtReturn.Rows[0]["CONTRACT_ID"].ToString();


                }

                xfrmCommonPopup.Dispose();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        //private void _luTCONTRACT_OnOpenClick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        frmCommonPopup.CRUD = "R";
        //        frmCommonPopup.USER_CODE = _pUSER_CODE;
        //        frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
        //        frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

        //        // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
        //        frmCommonPopup.ARRAY = new object[2] { "contract_number_R", "" };
        //        frmCommonPopup.ARRAY_CODE = new object[2] { _luTCONTRACT.CodeText.ToString(), _luTCONTRACT.NameText.ToString() };
        //        frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

        //        xfrmCommonPopup.ShowDialog();

        //        if (xfrmCommonPopup.dtReturn == null)
        //        {
        //            xfrmCommonPopup.Dispose();
        //            return;
        //        }

        //        if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
        //        {
        //            _luTCONTRACT.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
        //            _luTCONTRACT.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
        //        }

        //        xfrmCommonPopup.Dispose();
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
        //    }
        //}
        #endregion

        // 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //_pProductInformationRegister_T01Entity.CRUD = "R";
                MainFind_DisplayData();

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

                DataTable dtCheck = _gdMAIN.DataSource as DataTable;
                DataTable dtCheck_Temp = null;
                DataTable dtCheck_C = null;
                DataTable dtCheck_UD = null;

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.Yes)
                { 

                    #region Validation

                    if (!dxValidationProvider.Validate())
                    {
                        return;
                    }

                    if ((CoFAS_ConvertManager.DataTable_FindCount(dtCheck, "CRUD IN ('C','U','D')", "")))
                    {
                        dtCheck_Temp = CoFAS_ConvertManager.DataTable_FindValue(dtCheck, "CRUD IN ('C','U','D')", "");

                        // 제품등록코드 생성간 'C'와 'U','D'의 구분체크를 위함
                        if ((CoFAS_ConvertManager.DataTable_FindCount(dtCheck, "CRUD IN ('C')", "")))
                            dtCheck_C = CoFAS_ConvertManager.DataTable_FindValue(dtCheck, "CRUD IN ('C')", "");
                        if ((CoFAS_ConvertManager.DataTable_FindCount(dtCheck, "CRUD IN ('U','D')", "")))
                            dtCheck_UD = CoFAS_ConvertManager.DataTable_FindValue(dtCheck, "CRUD IN ('U','D')", "");
                    }
                    else
                    {
                        // 수정 또는 추가된 내용이 없습니다
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_REG_DATA);
                        return;
                    }

                    if (CoFAS_ConvertManager.DataTable_FindCount(dtCheck_Temp, "Convert([PART_START_DATE], 'System.DateTime') > Convert([PART_END_DATE], 'System.DateTime')", ""))
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("제품시작일자가 제품종료일자보다 클 수 없습니다.");
                        return;
                    }

                    if (CoFAS_ConvertManager.DataTable_FindCount(dtCheck_Temp, "[CONTRACT_NUMBER] is null OR [CONTRACT_NUMBER] = ''", ""))
                    {
                        //CONTRACT_NUMBER
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_VALID_ITEM);
                        return;
                    }

                    if (dtCheck_C != null)
                    {
                        if (CoFAS_ConvertManager.DataTable_FindCount(dtCheck_C, "[PART_NAME] is null OR [PART_NAME] = ''", ""))
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_VALID_ITEM);
                            return;
                        }
                    }

                    if(dtCheck_UD != null)
                    {
                        if (CoFAS_ConvertManager.DataTable_FindCount(dtCheck_UD, "[PART_CODE] is null OR [PART_CODE] = ''", ""))
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_CHECK_VALID_ITEM);
                            return;
                        }
                    }
                    
                    #endregion

                    InputDataMain_Save(_gdMAIN_VIEW.GridControl.DataSource as DataTable);
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
               
                // 수정 후 포커스 이동 안되면 데이터 반영 안됨. 
                // 삭제 버튼 클릭시에는 GetFocusedDataRow().EndEdit() 처리 해야됨.
                // 마우스 팝업 메뉴에서 처리는 자동으로 처리됨.

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
                if (_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    //if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n초기화 하겠습니까?") == DialogResult.No)
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_WORKING + "\n" + _pMSG_RESET_QUESTION) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        InitializeControl();

                        //InitializeSetting();
                        //GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                        //CoFAS_ControlManager.Controls_Binding(gv, true, this);
                        Form_SearchButtonClicked(null, null);
                        DisplayMessage(_pMSG_RESET_COMPLETE);
                    }
                }
                else
                {
                    InitializeControl();

                    //InitializeSetting();
                    //GridView gv = _gdMAIN_VIEW; //바인딩 되는 데이터 마스터 그리드 설정
                    //CoFAS_ControlManager.Controls_Binding(gv, true, this);
                    Form_SearchButtonClicked(null, null);
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

        // 추가 이벤트

        // DB 처리

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pProductInformationRegister_T01Entity.CRUD = "R";
                _pProductInformationRegister_T01Entity.PART_CODE = _luPART_CODE.Text.ToString();
                _pProductInformationRegister_T01Entity.PART_NAME = _luT_PART.NameText.ToString();
                _pProductInformationRegister_T01Entity.PART_REVISION_NO = _luPART_REVISION_NO.Text.ToString();
                _pProductInformationRegister_T01Entity.VEND_PART_CODE = _luT_PART.CodeText.ToString();
                _pProductInformationRegister_T01Entity.PART_HIGH = _luPART_HIGH.Text.ToString();
                _pProductInformationRegister_T01Entity.PART_MIDDLE = _luPART_MIDDLE.Text.ToString();
                _pProductInformationRegister_T01Entity.PART_LOW = _luPART_LOW.Text.ToString();
                _pProductInformationRegister_T01Entity.PART_START_DATE = _luPART_DATE.FromDateTime.ToString("yyyyMMdd");
                _pProductInformationRegister_T01Entity.PART_END_DATE = _luPART_DATE.ToDateTime.ToString("yyyyMMdd");
                _pProductInformationRegister_T01Entity.CONTRACT_NUMBER = _luTCONTRACT.CodeText.ToString();
                _pProductInformationRegister_T01Entity.USE_YN = _luUSE_YN.GetValue();

                _dtList = new ProductInformationRegister_T01Business().ProductInformationRegister_T01_Info(_pProductInformationRegister_T01Entity);

                if (_pProductInformationRegister_T01Entity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductInformationRegister_T01Entity.CRUD == ""))
                {

                    _TempGridView.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                    //CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("PART_CODE", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;

                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }

                }
                else
                {

                    _TempGridView.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                    DisplayMessage(_pMSG_SEARCH_EMPT);

                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                    
                    //CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                    //InitializeControl();
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

        #region ○ 저장 - InputDataMain_Save(DataTable dtSave)

        private void InputDataMain_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                isError = new ProductInformationRegister_T01Business().ProductInformationRegister_T01_Info_Save(_pProductInformationRegister_T01Entity, dtSave);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.

                }
                else
                {
                    _pProductInformationRegister_T01Entity.CRUD = "R";

                    _pLocation_Code = _pProductInformationRegister_T01Entity.RTN_KEY;  //저장 위치 
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                    MainFind_DisplayData();
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

