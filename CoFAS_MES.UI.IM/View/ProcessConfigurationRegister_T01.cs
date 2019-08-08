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
using CoFAS_MES.CORE;

using CoFAS_MES.UI.IM.Business;
using CoFAS_MES.UI.IM.Entity;
using CoFAS_MES.UI.IM.UserForm;

using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList.Nodes;
using CoFAS_MES.CORE.UserForm;

using DevExpress.Utils.DragDrop;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;

using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;

namespace CoFAS_MES.UI.IM
{
    public partial class ProcessConfigurationRegister_T01 : frmBaseNone
    {
        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pMENU_NAME = string.Empty;       // 메뉴명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부

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

        //화면 추가 메시지 영역
        private string _pMSG_REVISION_INIT = string.Empty;   // 리비젼 정보가 초기화됩니다

        private ProcessConfigurationRegister_T01Entity _pProcessConfigurationRegister_T01Entity = null; // 엔티티 생성

        private CoFAS_DevGridManager _TempMainGridView;
        private CoFAS_DevGridManager _TempSubGridView;
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtMapping = null;

        private DataTable tmp_PROCESS = null;
      //  private DataTable tmp_EQUIPMENT = null;
      //  private DataTable tmp_TERMINAL = null;
        private DataTable tmp_RESOURCE = null;
      //  private DataTable tmp_TOOL = null;

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private DataTable dtMessage = null; // 화면별 메세지 관리 데이터 테이블

        private DataTable _dtRoutingCheckList = null; //선택된 BOM 리스트 체크용 백업 데이터테이블

        //18.06.08 트리리스트 관련
        private DataTable dtTL = new DataTable("TreeData"); //treelist 저장 처리 데이터 테이블
        private DataRow drTL = null; // treelist 저장 처리 데이터 로우
        public int iTreeNodeIndex = 0;


        public ProcessConfigurationRegister_T01()
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

                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;
                _gdROUTING_VIEW.InitNewRow -= _gdROUTING_VIEW_InitNewRow;
                _gdROUTING_VIEW.ShownEditor -= _gdROUTING_VIEW_ShownEditor;
                _TempSubGridView._OnButtonPressed -= _TempSubGridView__OnButtonPressed;
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
        #endregion

        // 초기화 처리 영역
        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
                _pnContent.Visible = true;
                _pnLeft.Visible = true;

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
                _pProcessConfigurationRegister_T01Entity = new ProcessConfigurationRegister_T01Entity();
                _pProcessConfigurationRegister_T01Entity.CORP_CODE = _pCORP_CODE;
                _pProcessConfigurationRegister_T01Entity.USER_CODE = _pUSER_CODE;
                _pProcessConfigurationRegister_T01Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

                //추가 메세지 정보 조회.
                dtMessage = new MessageBusiness().MessageValue_Mst_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                if (dtMessage != null && dtMessage.Rows[0][0].ToString() != "")
                {
                    _pMSG_REVISION_INIT = dtMessage.Rows[0]["MSG_REVISION_INIT"].ToString();

                }

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
                _pProcessConfigurationRegister_T01Entity.CRUD = "R";

                _pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE = _luT_CONFIGURATION_MST_CODE.Text.ToString();
                _pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_NAME = _luT_CONFIGURATION_MST_NAME.Text.ToString();
                _pProcessConfigurationRegister_T01Entity.USE_YN = _luT_USE_YN.GetValue();
                MainFind_DisplayData(); //10

                _pProcessConfigurationRegister_T01Entity.CRUD = "";

                RoutingProcessFind_DisplayData();


                if (_pFirstYN)
                {
                    tmp_PROCESS = new DataTable();
                    tmp_RESOURCE = new DataTable();

                    tmp_PROCESS = new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "ROUTING_P_CODE", "", "", "").Tables[0];
                    tmp_RESOURCE = new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "ROUTING_CODE", "", "", "").Tables[0];


                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    _gdROUTING_VIEW.InitNewRow += _gdROUTING_VIEW_InitNewRow;
                    _gdROUTING_VIEW.ShownEditor += _gdROUTING_VIEW_ShownEditor;
                    _pFirstYN = false;
                }
                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행

                //그리드 버튼추가 시 클릭 이벤트 처리 

                _TempSubGridView._OnButtonPressed += _TempSubGridView__OnButtonPressed;

                _pProcessConfigurationRegister_T01Entity.CRUD = "C";
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _gdROUTING_VIEW_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;

            view.SetRowCellValue(e.RowHandle, view.Columns["LVL"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["DSP_SORT"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["P_PROCESS_TYPE"], "PROCESS_CODE_MST");
            view.SetRowCellValue(e.RowHandle, view.Columns["P_PROCESS_CODE"], "");
            view.SetRowCellValue(e.RowHandle, view.Columns["REVISION_NO"], "");
            view.SetRowCellValue(e.RowHandle, view.Columns["PROCESS_TYPE"], "PROCESS_CODE_MST");
            view.SetRowCellValue(e.RowHandle, view.Columns["PROCESS_CODE"], "");
            view.SetRowCellValue(e.RowHandle, view.Columns["USE_YN"], "Y");
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
                    _TempMainGridView = new CoFAS_DevGridManager();

                    _gdMAIN_VIEW = _TempMainGridView.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));

                    _TempSubGridView = new CoFAS_DevGridManager();

                    _gdROUTING_VIEW = _TempSubGridView.Grid_Setting(_gdROUTING, _gdROUTING_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdROUTING.Name.ToString()));

                    _gdMAIN_VIEW.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(_gdMAIN_VIEW_RowChange);
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
                _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "", true);
                _luT_USE_YN.ItemIndex = 1;
                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "", false);

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                //dxValidationProvider.SetValidationRule(_luGRID_NAME, NotEmptyValidationRule);
                //dxValidationProvider.SetValidationRule(_luGRIDVIEW_NAME, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                }

                CreateDataTable(); //tree 저장 처리 데이터 테이블 만들기

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
        #region ○ 메인 그리드 로우 선택 이벤트 생성
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                if (e.RowHandle < 0) return;

                GridView gv = sender as GridView;

                _pProcessConfigurationRegister_T01Entity.CRUD = "R";
                _pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE = gv.GetFocusedRowCellValue("CONFIGURATION_MST_CODE").ToString();
                _pProcessConfigurationRegister_T01Entity.REVISION_NO = gv.GetFocusedRowCellValue("REVISION_NO").ToString();
                _pProcessConfigurationRegister_T01Entity.USE_YN = gv.GetFocusedRowCellValue("USE_YN").ToString();

                SubFind_DisplayData();

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }



        #endregion

        private void _gdROUTING_VIEW_ShownEditor(object sender, EventArgs e)
        {
            ColumnView view = (ColumnView)sender;
            int qRowIndex = view.FocusedRowHandle;

            if (view.ActiveEditor.GetType().Name != "LookUpEdit") return; 


            string strP_PROCESS_CODE_TYPE = view.GetRowCellValue(qRowIndex, "P_PROCESS_CODE_TYPE").ToString();
            string strPROCESS_CODE_TYPE = view.GetRowCellValue(qRowIndex, "PROCESS_CODE_TYPE").ToString();

            LookUpEdit edit = (LookUpEdit)view.ActiveEditor;

            DataTable empty_table = new DataTable();
            DataRow row = null;
            DataTable tmp = new DataTable();

            if (view.FocusedColumn.FieldName == "P_PROCESS_CODE_TYPE" && view.ActiveEditor is LookUpEdit && !view.GetFocusedRowCellValue("CRUD").ToString().Equals(""))
            {
                view.SetFocusedRowCellValue("P_PROCESS_CODE", "");
            }

            if (view.FocusedColumn.FieldName == "PROCESS_CODE_TYPE" && view.ActiveEditor is LookUpEdit && !view.GetFocusedRowCellValue("CRUD").ToString().Equals(""))
            {
                view.SetFocusedRowCellValue("PROCESS_CODE", "");
            }

            if (view.FocusedColumn.FieldName == "P_PROCESS_CODE" && view.ActiveEditor is LookUpEdit)
            {
                
                if (strP_PROCESS_CODE_TYPE == "")
                {
                    empty_table.Columns.Add(new DataColumn("CD", typeof(string)));
                    empty_table.Columns.Add(new DataColumn("CD_NM", typeof(string)));
                    empty_table.Columns.Add(new DataColumn("CD_TP", typeof(string)));

                    row = empty_table.NewRow();

                    row["CD"] = "";
                    row["CD_NM"] = "";
                    row["CD_TP"] = "";

                    empty_table.Rows.Add(row);
                    edit.Properties.DataSource = empty_table;
                    edit.Properties.DropDownRows = empty_table.Rows.Count;
                }
                else
                {
                    if (tmp_PROCESS.Select("CD_TP = '" + strP_PROCESS_CODE_TYPE + "'").Length == 0)
                    {
                        empty_table.Columns.Add(new DataColumn("CD", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_NM", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_TP", typeof(string)));

                        row = empty_table.NewRow();

                        row["CD"] = "";
                        row["CD_NM"] = "";
                        row["CD_TP"] = "";

                        empty_table.Rows.Add(row);
                        edit.Properties.DataSource = empty_table;
                        edit.Properties.DropDownRows = empty_table.Rows.Count;
                    }
                    else
                    {
                        tmp = tmp_PROCESS.Select("CD_TP = '" + strP_PROCESS_CODE_TYPE + "'").CopyToDataTable();
                        edit.Properties.DataSource = tmp;
                        edit.Properties.DropDownRows = tmp.Rows.Count;
                    }
                }
            }



            if (view.FocusedColumn.FieldName == "PROCESS_CODE" && view.ActiveEditor is LookUpEdit)
            {
                
                if (strPROCESS_CODE_TYPE == "")
                {
                    empty_table.Columns.Add(new DataColumn("CD", typeof(string)));
                    empty_table.Columns.Add(new DataColumn("CD_NM", typeof(string)));
                    empty_table.Columns.Add(new DataColumn("CD_TP", typeof(string)));

                    row = empty_table.NewRow();

                    row["CD"] = "";
                    row["CD_NM"] = "";
                    row["CD_TP"] = "";

                    empty_table.Rows.Add(row);
                    edit.Properties.DataSource = empty_table;
                    edit.Properties.DropDownRows = empty_table.Rows.Count;
                }
                else
                {
                    if (tmp_RESOURCE.Select("CD_TP = '" + strPROCESS_CODE_TYPE + "'").Length == 0)
                    {
                        empty_table.Columns.Add(new DataColumn("CD", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_NM", typeof(string)));
                        empty_table.Columns.Add(new DataColumn("CD_TP", typeof(string)));

                        row = empty_table.NewRow();

                        row["CD"] = "";
                        row["CD_NM"] = "";
                        row["CD_TP"] = "";

                        empty_table.Rows.Add(row);
                        edit.Properties.DataSource = empty_table;
                        edit.Properties.DropDownRows = empty_table.Rows.Count;
                    }
                    else
                    {
                        tmp = tmp_RESOURCE.Select("CD_TP = '" + strPROCESS_CODE_TYPE + "'").CopyToDataTable();
                        edit.Properties.DataSource = tmp;
                        edit.Properties.DropDownRows = tmp.Rows.Count;
                    }
                }
            }

            edit.Properties.ShowHeader = false;
            edit.Properties.ShowFooter = false;
            view.ShowEditor();
            view.GetFocusedDataRow().EndEdit();
        }

        #region ○ 메인 그리드 버튼 클릭 이벤트 생성 - _TempSubGridView__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)

        private void _TempSubGridView__OnButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = _gdROUTING_VIEW.GetFocusedDataRow();

            if (dr == null) return;

            switch (e.Button.Caption.ToString())
            {
                case "ROW_COPY_BTN": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.

                    _gdROUTING_VIEW.AddNewRow();

                    int rowHandle = _gdROUTING_VIEW.GetRowHandle(_gdROUTING_VIEW.DataRowCount);

                    if (_gdROUTING_VIEW.IsNewItemRow(rowHandle))
                    {
                        _gdROUTING_VIEW.SetRowCellValue(rowHandle, _gdROUTING_VIEW.Columns["CRUD"], dr["CRUD"].ToString());
                        _gdROUTING_VIEW.SetRowCellValue(rowHandle, _gdROUTING_VIEW.Columns["LVL"], dr["LVL"].ToString());
                        _gdROUTING_VIEW.SetRowCellValue(rowHandle, _gdROUTING_VIEW.Columns["DSP_SORT"], dr["DSP_SORT"].ToString());
                        _gdROUTING_VIEW.SetRowCellValue(rowHandle, _gdROUTING_VIEW.Columns["P_PROCESS_CODE_TYPE"], dr["P_PROCESS_CODE_TYPE"].ToString());
                        _gdROUTING_VIEW.SetRowCellValue(rowHandle, _gdROUTING_VIEW.Columns["P_PROCESS_CODE"], dr["P_PROCESS_CODE"].ToString());
                        _gdROUTING_VIEW.SetRowCellValue(rowHandle, _gdROUTING_VIEW.Columns["REVISION_NO"], dr["REVISION_NO"].ToString());
                        _gdROUTING_VIEW.SetRowCellValue(rowHandle, _gdROUTING_VIEW.Columns["PROCESS_CODE_TYPE"], dr["PROCESS_CODE_TYPE"].ToString());
                        _gdROUTING_VIEW.SetRowCellValue(rowHandle, _gdROUTING_VIEW.Columns["PROCESS_CODE"], dr["PROCESS_CODE"].ToString());
                        _gdROUTING_VIEW.SetRowCellValue(rowHandle, _gdROUTING_VIEW.Columns["USE_YN"], dr["USE_YN"].ToString());
                    }
                    break;

                case "BTN_PROROUTING_DOCUMENT": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.
                    if (dr["CONFIGURATION_MST_CODE"].ToString() == "") return;
                    if (dr["CONFIGURATION_SEQ"].ToString() == "") return;
                    if (dr["CONFIGURATION_CODE"].ToString() == "") return;
                    
                    UserForm.frmCommonPopup.CORP_CDDE = _pCORP_CODE;
                    UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                    UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
                    UserForm.frmCommonPopup.FTP_PATH = _pFTP_IP_PORT;
                    UserForm.frmCommonPopup.FTP_ID = _pFTP_ID;
                    UserForm.frmCommonPopup.FTP_PW = _pFTP_PW;

                    UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" }; //넘기는 파라메터 에 따라 설정
                    UserForm.frmCommonPopup.ARRAY_CODE = new object[3] { dr["CONFIGURATION_MST_CODE"].ToString(), dr["CONFIGURATION_SEQ"].ToString(), dr["CONFIGURATION_CODE"].ToString() };// dr["CONTRACT_ID"].ToString(), dr["CONTRACT_NUMBER"].ToString() }; //넘기는 파라메터 에 따라 설정

                    UserForm.frmCommonPopup xfrmcommonPopup = new UserForm.frmCommonPopup("ucProRoutingDocumentListPopup"); //유저컨트롤러 설정 부분

                    xfrmcommonPopup.ShowDialog();

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

                _pProcessConfigurationRegister_T01Entity.CRUD = "R";

                MainFind_DisplayData();

               
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

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                    return;

                if (CheckInputData())
                {
                    return;
                }

                if (PartMappingCheck())
                {
                    CoFAS_DevExpressManager.ShowErrorMessage("이미 구성되어있는 품목이 존재하여 수정 또는 삭제할 수 없습니다.");
                }
                else
                {
                    if (_luCONFIGURATION_MST_CODE.Text.ToString().Length > 0)
                    {
                        _pProcessConfigurationRegister_T01Entity.CRUD = "U";
                        //InputData_Save();
                    }
                    else
                    {
                        _pProcessConfigurationRegister_T01Entity.CRUD = "C";
                    }

                    DataTable tempDT = _gdROUTING_VIEW.GridControl.DataSource as DataTable;

                    InputData_Save(tempDT);
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

                _luCONFIGURATION_MST_CODE.Text = "";
                _luCONFIGURATION_MST_NAME.Text = "";
                _luCONFIGURATION_VEND_CODE.Text = "";
                _luUSE_YN.ItemIndex = 0;
                _luREVISION_NO.Text = "";
                _luREVISION_NO.ReadOnly = false;

                _dtRoutingCheckList = null;

                _ckCOPY.Checked = false;

                _pProcessConfigurationRegister_T01Entity.CRUD = "R";
                MainFind_DisplayData();

                SubFind_DisplayData();
                RoutingProcessFind_DisplayData();

                _pProcessConfigurationRegister_T01Entity.CRUD = "C";
                _pProcessConfigurationRegister_T01Entity.REVISION_NO = "";

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
                // xfrmPageSetting.PASS_CORP_CODE = _pCORP_CODE;
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

                _pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE = _luT_CONFIGURATION_MST_CODE.Text.ToString();
                _pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_NAME = _luT_CONFIGURATION_MST_NAME.Text.ToString();
                _pProcessConfigurationRegister_T01Entity.USE_YN = _luT_USE_YN.GetValue();

                _dtList = new ProcessConfigurationRegister_T01Business().ProcessConfigurationRegister_T01_Info_Main(_pProcessConfigurationRegister_T01Entity);


                if (_pProcessConfigurationRegister_T01Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegister_T01Entity.CRUD == ""))
                {
                    _TempMainGridView.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    DisplayMessage(_pMSG_SEARCH);

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("ROUTING_MST_CODE", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;


                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }
                }
                else
                {
                    _TempMainGridView.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                   
                    DisplayMessage(_pMSG_SEARCH_EMPT);

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

        #region ○ 서브조회 - SubFind_DisplayData()
        private void SubFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ProcessConfigurationRegister_T01Business().ProcessConfigurationRegister_T01_Info_Routing_MST(_pProcessConfigurationRegister_T01Entity);

                if (_pProcessConfigurationRegister_T01Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegister_T01Entity.CRUD == ""))
                {
                    CoFAS_ControlManager.Controls_Binding(_dtList, false, this);

                    if (_luREVISION_NO.Text.ToString().Length > 0) _luREVISION_NO.ReadOnly = true;

                    RoutingProcessFind_DisplayData();
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
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }


        #endregion

        #region ○ 라우팅 공정 조회 - RoutingProcessFind_DisplayData() 20
        private void RoutingProcessFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ProcessConfigurationRegister_T01Business().ProcessConfigurationRegister_T01_Info_Routing_DETAIL(_pProcessConfigurationRegister_T01Entity);

                if (_pProcessConfigurationRegister_T01Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegister_T01Entity.CRUD == ""))
                {
                    _TempSubGridView.BindGridControl(_gdROUTING, _gdROUTING_VIEW, _dtList);
                }
                else
                {
                    _TempSubGridView.BindGridControl(_gdROUTING, _gdROUTING_VIEW, _dtList);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdROUTING_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region 품목구성 체크
        private bool PartMappingCheck()
        {
            bool _result = false;
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtMapping = new ProcessConfigurationRegister_T01Business().ProcessConfigurationRegister_T01_Info_Main_MappingCheck(_pProcessConfigurationRegister_T01Entity);

                if ((_dtMapping != null && _dtMapping.Rows.Count > 0) || (_dtMapping != null && _pProcessConfigurationRegister_T01Entity.CRUD == ""))
                {
                    _result = true;
                }else
                {
                    _result = false;
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
            return _result;
        }
        #endregion

        //#region ○ 저장 - InputData_Save(DataTable dtSave)
        //private void InputData_Save()
        //{
        //    try
        //    {
        //        CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

        //        bool isError = false;

        //        _pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE = _luCONFIGURATION_MST_CODE.Text.ToString();
        //        _pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_NAME = _luCONFIGURATION_MST_NAME.Text.ToString();
        //        _pProcessConfigurationRegister_T01Entity.CONFIGURATION_VEND_CODE = _luCONFIGURATION_VEND_CODE.Text.ToString();
        //        _pProcessConfigurationRegister_T01Entity.REVISION_NO = _luREVISION_NO.Text.ToString();
        //        _pProcessConfigurationRegister_T01Entity.USE_YN = _luUSE_YN.GetValue();

        //        isError = new ProcessConfigurationRegister_T01Business().ProcessConfigurationRegister_T01_Info_MST_Save(_pProcessConfigurationRegister_T01Entity);

        //        if (isError)
        //        {
        //            //오류 발생.
        //            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
        //            //화면 표시.
        //        }
        //        else
        //        {
        //            //정상 처리
        //            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

        //            // 화면 갱신
        //            _pProcessConfigurationRegister_T01Entity.CRUD = "R";

        //            _pProcessConfigurationRegister_T01Entity.REVISION_NO = _luREVISION_NO.Text.ToString();
        //            _pProcessConfigurationRegister_T01Entity.USE_YN = _luUSE_YN.GetValue();
        //            SubFind_DisplayData();

        //            MainFind_DisplayData();


        //        }
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

        #region 저장

        private void InputData_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;
                dtTL.Clear();
                drTL = null;

                DataTable dtDetail = null;
                DataTable dtDetail2 = null;

                _pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE = _luCONFIGURATION_MST_CODE.Text.ToString();
                _pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_NAME = _luCONFIGURATION_MST_NAME.Text.ToString();
                _pProcessConfigurationRegister_T01Entity.CONFIGURATION_VEND_CODE = _luCONFIGURATION_VEND_CODE.Text.ToString();
                _pProcessConfigurationRegister_T01Entity.REVISION_NO = _luREVISION_NO.Text.ToString().Length > 0 ? _luREVISION_NO.Text.ToString() : "1.0";
                _pProcessConfigurationRegister_T01Entity.USE_YN = _luUSE_YN.GetValue();

                DataRowADD(dtSave);

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dtTL, "NODE_LEVEL = '0' AND CRUD NOT IN ('D')", "");
                //
                if (isChack)
                {
                    dtDetail = CoFAS_ConvertManager.DataTable_FindValue(dtTL, "NODE_LEVEL = '0' AND CRUD NOT IN ('D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                bool isChack2 = CoFAS_ConvertManager.DataTable_FindCount(dtTL, "CRUD NOT IN ('D')", "");

                if(isChack2)
                {
                    dtDetail2 = CoFAS_ConvertManager.DataTable_FindValue(dtTL, "CRUD NOT IN ('D')", "");
                }
                //if (_ckCOPY.Checked)
                //{
                //    _pProcessConfigurationRegister_T01Entity.CRUD = "C";
                //}
                //else
                //{
                //    _pProcessConfigurationRegister_T01Entity.CRUD = "U";
                //}

                bool isDeletecheck = CoFAS_ConvertManager.DataTable_FindCount(dtTL, "CRUD IN ('D','U')", "");
                isError = new ProcessConfigurationRegister_T01Business().ProcessConfigurationRegister_T01_Info_Save(_pProcessConfigurationRegister_T01Entity, dtDetail, dtDetail2, isDeletecheck);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.
                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

                    // 화면 갱신
                    _pProcessConfigurationRegister_T01Entity.CRUD = "R";

                    _pProcessConfigurationRegister_T01Entity.REVISION_NO = _luREVISION_NO.Text.ToString();
                    _pProcessConfigurationRegister_T01Entity.USE_YN = _luUSE_YN.GetValue();
                    //SubFind_DisplayData();
                    Form_InitialButtonClicked(null, null);
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

        #region ○ 필수값 데이터 확인 - CheckInputData()

        /// <summary>
        /// 필수값 데이터 확인
        /// </summary>
        /// <returns>입력 데이터 조사 결과 (정상:false 에러:true)</returns>
        private bool CheckInputData()
        {
            bool pErrorAllYN = false;
            string pCls = string.Empty;
            string pErrName = string.Empty;

            try
            {

                if (_luCONFIGURATION_MST_NAME.Text == "")
                    pErrName += _lciCONFIGURATION_MST_NAME.Text.ToString() + ". ";

                if (_luREVISION_NO.Text == "")
                    pErrName += _lciREVISION_NO.Text.ToString() + ". ";

                if (pErrName != "")
                {
                    pErrorAllYN = true;

                    CoFAS_DevExpressManager.ShowInformationMessage(pErrName + " " + _pMSG_CHECK_VALID_ITEM);

                    DisplayMessage(_pMSG_CHECK_VALID_ITEM);

                }
            }
            catch (Exception pException)
            {
                pErrorAllYN = true;
                CoFAS_DevExpressManager.ShowErrorMessage(pException);
            }
            return pErrorAllYN;
        }

        #endregion

        private void CreateDataTable()
        {
            dtTL.Columns.Add(new DataColumn("CRUD", typeof(string)));
            dtTL.Columns.Add(new DataColumn("ROUTING_MST_CODE", typeof(string)));
            dtTL.Columns.Add(new DataColumn("ROUTING_CODE", typeof(string)));
            dtTL.Columns.Add(new DataColumn("P_ROUTING_CODE", typeof(string)));
            dtTL.Columns.Add(new DataColumn("REVISION_NO", typeof(string)));
            dtTL.Columns.Add(new DataColumn("NODE_LEVEL", typeof(int)));
            dtTL.Columns.Add(new DataColumn("NODE_ID", typeof(int)));

            dtTL.Columns.Add(new DataColumn("USE_YN", typeof(string)));
        }

        private void DataRowADD(DataTable dt)
        {
            int iCnt = 0;
            
            foreach (DataRow dr in dt.Rows)
            {
                drTL = dtTL.NewRow();
                drTL["CRUD"] = dr["CRUD"].ToString();
                drTL["ROUTING_MST_CODE"] = dr["P_PROCESS_CODE"].ToString();
                drTL["ROUTING_CODE"] = dr["PROCESS_CODE"].ToString();
                drTL["P_ROUTING_CODE"] = dr["P_PROCESS_CODE"].ToString();
                drTL["REVISION_NO"] = dr["REVISION_NO"].ToString();
                drTL["NODE_LEVEL"] = dr["LVL"].ToString();
                drTL["NODE_ID"] = iCnt = iCnt + 1;
                drTL["USE_YN"] = dr["USE_YN"].ToString();

                dtTL.Rows.Add(drTL);
            }
        }

        private void _ucbtPART_MAPPING_Click(object sender, EventArgs e)
        {
            try
            {

                if (_luCONFIGURATION_MST_CODE.Text.ToString().Length > 0)
                {
                    UI.IM.UserForm.frmCommonPopup.CRUD = "R";
                    UI.IM.UserForm.frmCommonPopup.USER_CODE = _pUSER_CODE;
                    UI.IM.UserForm.frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    UI.IM.UserForm.frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    UI.IM.UserForm.frmCommonPopup.ARRAY = new object[2] { "", "" };
                    UI.IM.UserForm.frmCommonPopup.ARRAY_CODE = new object[3] { _luCONFIGURATION_MST_CODE.Text.ToString(), _luCONFIGURATION_MST_NAME.Text.ToString(), _luREVISION_NO.Text.ToString() };
                    UI.IM.UserForm.frmCommonPopup xfrmCommonPopup = new UI.IM.UserForm.frmCommonPopup("PartProcessMapping_T01");

                    xfrmCommonPopup.ShowDialog();

                    if (xfrmCommonPopup.dtReturn == null)
                    {
                        xfrmCommonPopup.Dispose();
                        return;
                    }

                    xfrmCommonPopup.Dispose();
                }
                else
                {
                   // CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SELECT_CONFIGURATION);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }


        }

        #region 키보드 이동
        private void _gdMAIN_VIEW_RowChange(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                if ((gv.DataSource as DataTable) == null) return;
                _pProcessConfigurationRegister_T01Entity.CRUD = "R";
                _pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE = gv.GetFocusedRowCellValue("CONFIGURATION_MST_CODE").ToString();
                _pProcessConfigurationRegister_T01Entity.REVISION_NO = gv.GetFocusedRowCellValue("REVISION_NO").ToString();
                _pProcessConfigurationRegister_T01Entity.USE_YN = gv.GetFocusedRowCellValue("USE_YN").ToString();

                SubFind_DisplayData();

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        private void _ckCOPY_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (_ckCOPY.Checked)
                {
                    if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_REVISION_INIT) == DialogResult.Yes)
                    {
                        _luREVISION_NO.Text = "";
                        _luREVISION_NO.ReadOnly = false;

                        _luCONFIGURATION_MST_CODE.Text = "";
                        _luCONFIGURATION_MST_NAME.Text = "";
                        _luCONFIGURATION_VEND_CODE.Text = "";
                        _dtRoutingCheckList = null;

                        _ckCOPY.Checked = false;

                        _pProcessConfigurationRegister_T01Entity.CRUD = "C";
                        _pProcessConfigurationRegister_T01Entity.REVISION_NO = "";
                        _pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE = "";
                        _pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_NAME = "";
                        DataTable dtCopyinit = _gdROUTING_VIEW.GridControl.DataSource as DataTable;
                        if (dtCopyinit == null) return;
                        if (dtCopyinit.Rows.Count > 0)
                        {
                            for (int i = 0; i < dtCopyinit.Rows.Count; i++)
                            {
                                dtCopyinit.Rows[i]["CRUD"] = "C";
                                dtCopyinit.Rows[i]["DSP_SORT"] = 0;
                                dtCopyinit.Rows[i]["REVISION_NO"] = "";

                                dtCopyinit.Rows[i]["CONFIGURATION_MST_CODE"] = "";
                                dtCopyinit.Rows[i]["CONFIGURATION_SEQ"] = 0;
                                dtCopyinit.Rows[i]["CONFIGURATION_CODE"] = "";
                            }
                        }
                    }
                    else
                    {
                        _ckCOPY.Checked = false;
                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
            finally
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }

        }
    }
}
