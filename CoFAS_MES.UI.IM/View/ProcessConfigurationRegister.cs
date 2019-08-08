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

//018.06.08트리리트관련
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Menu;
using DevExpress.XtraTreeList.Nodes;

using CoFAS_MES.CORE.UserForm;

namespace CoFAS_MES.UI.IM
{
    public partial class ProcessConfigurationRegister : frmBaseNone
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
        
        private string _pMSG_REVISION_CHECK = string.Empty;   // 리비젼 확인(변경) 후 작업
        private string _pMSG_BOM_COPY_CHECK = string.Empty;   // BOM 복사 시에만 가능
        private string _pMSG_BOM_DISABLE = string.Empty;   // 사용 중지된 BOM 입니다
        private string _pMSG_LEVEL_SAME_NOT = string.Empty;   // 코드를 같은 레벨 에 등록 할 수 없습니다
        private string _pMSG_PART_ALREADY_BOM = string.Empty;   // BOM 구성된 제품 입니다.
        private string _pMSG_PART_NOT_CHILD = string.Empty;   // 하위 품목 에 등록할 수 없습니다
        private string _pMSG_PART_NOT_OTHER = string.Empty;   // 제품코드 이 외에 등록 할 수 없습니다
        private string _pMSG_PART_NOT_SUB = string.Empty;   // 하위 품목 에 등록 할 수 없습니다
        private string _pMSG_PART_SAME_CODE = string.Empty;   // 상위코드와 같습니다
        private string _pMSG_PRODUCT_NOT_SUB = string.Empty;   // 제품코드 는 하위품목 으로 등록 할 수 없습니다
        private string _pMSG_REVISION_INIT = string.Empty;   // 리비젼 정보가 초기화됩니다
        private string _pMSG_SEMI_PART_NOT_REG = string.Empty;   // 반제품 품목 에 등록 할 수 없습니다
        private string _pMSG_SELECT_CONFIGURATION = string.Empty; //선택된 공정구성이 없습니다.


        //알림창메시지 복사 끝

        private ProcessConfigurationRegisterEntity _pProcessConfigurationRegisterEntity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        private DataTable dtMessage = null; // 화면별 메세지 관리 데이터 테이블

        private DataTable _dtRoutingCheckList = null; //선택된 BOM 리스트 체크용 백업 데이터테이블

        //18.06.08 트리리스트 관련
        private DataTable dtTL = new DataTable("TreeListData"); //treelist 저장 처리 데이터 테이블
        private DataRow drTL = null; // treelist 저장 처리 데이터 로우
        public int iTreeNodeIndex = 0;


        public ProcessConfigurationRegister()
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
                _gdSUB01_VIEW.RowCellClick -= _gdSUB01_VIEW_RowCellClick;
                _gdROUTING_VIEW.RowCellClick -= _gdROUTING_VIEW_RowCellClick;

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
                // DevExpress.Utils.AppearanceObject.DefaultFont = _pFONT_SETTING;//화면에 모든 항목 폰트 재설정
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

                //추가 메세지 정보 조회.
                dtMessage = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                if (dtMessage != null && dtMessage.Rows[0][0].ToString() != "")
                {
                    _pMSG_REVISION_CHECK = dtMessage.Rows[0]["MSG_REVISION_CHECK"].ToString();
                    _pMSG_REVISION_CHECK = dtMessage.Rows[0]["MSG_REVISION_CHECK"].ToString();
                    _pMSG_BOM_COPY_CHECK = dtMessage.Rows[0]["MSG_BOM_COPY_CHECK"].ToString();
                    _pMSG_BOM_DISABLE = dtMessage.Rows[0]["MSG_BOM_DISABLE"].ToString();
                    _pMSG_LEVEL_SAME_NOT = dtMessage.Rows[0]["MSG_LEVEL_SAME_NOT"].ToString();
                    _pMSG_PART_ALREADY_BOM = dtMessage.Rows[0]["MSG_PART_ALREADY_BOM"].ToString();
                    _pMSG_PART_NOT_CHILD = dtMessage.Rows[0]["MSG_PART_NOT_CHILD"].ToString();
                    _pMSG_PART_NOT_OTHER = dtMessage.Rows[0]["MSG_PART_NOT_OTHER"].ToString();
                    _pMSG_PART_NOT_SUB = dtMessage.Rows[0]["MSG_PART_NOT_SUB"].ToString();
                    _pMSG_PART_SAME_CODE = dtMessage.Rows[0]["MSG_PART_SAME_CODE"].ToString();
                    _pMSG_PRODUCT_NOT_SUB = dtMessage.Rows[0]["MSG_PRODUCT_NOT_SUB"].ToString();
                    _pMSG_REVISION_INIT = dtMessage.Rows[0]["MSG_REVISION_INIT"].ToString();
                    _pMSG_SEMI_PART_NOT_REG = dtMessage.Rows[0]["MSG_SEMI_PART_NOT_REG"].ToString();
                    _pMSG_SELECT_CONFIGURATION = dtMessage.Rows[0]["MSG_SELECT_CONFIGURATION"].ToString();

                }


                //메뉴 화면 엔티티 설정
                _pProcessConfigurationRegisterEntity = new ProcessConfigurationRegisterEntity();
                _pProcessConfigurationRegisterEntity.CORP_CODE = _pCORP_CODE;
                _pProcessConfigurationRegisterEntity.USER_CODE = _pUSER_CODE;
                _pProcessConfigurationRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

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
                _pProcessConfigurationRegisterEntity.CRUD = "";

                MainFind_DisplayData(); //10

               


                Routing_Configuration_Find_DisplayData(); //41

                _pProcessConfigurationRegisterEntity.CRUD = "R";

                RoutingProcessFind_DisplayData(); //30

                SubFind_DisplayData(); //21 ~ 26

                if (_pFirstYN)
                {
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    _gdSUB01_VIEW.RowCellClick += _gdSUB01_VIEW_RowCellClick;
                    _gdROUTING_VIEW.RowCellClick += _gdROUTING_VIEW_RowCellClick;
                    _pFirstYN = false;
                }
                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행

                //그리드 버튼추가 시 클릭 이벤트 처리 
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

                    _gdSUB01_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB01, _gdSUB01_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB01.Name.ToString()));

                    _gdSUB02_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB02, _gdSUB02_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB02.Name.ToString()));

                    _gdSUB03_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB03, _gdSUB03_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB03.Name.ToString()));

                    _gdSUB04_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB04, _gdSUB04_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB04.Name.ToString()));

                    _gdSUB05_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB05, _gdSUB05_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB05.Name.ToString()));

                    _gdSUB06_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB06, _gdSUB06_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB06.Name.ToString()));

                    _gdROUTING_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdROUTING, _gdROUTING_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdROUTING.Name.ToString()));

                    //_gdROUTING_MST_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdROUTING_MST, _gdROUTING_MST_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdROUTING_MST.Name.ToString()));
                    SetUpTileGrid(_gdROUTING_MST);

                }


                SetUpTreeList(); //트리 리스트 설정 및  Drag&Drop 함수                                      //
                CreateDataTable(); //treelist 저장 처리 데이터 테이블 만들기

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        public void SetUpTileGrid(GridControl grid)
        {
            grid.AllowDrop = true;
            grid.DragOver += new System.Windows.Forms.DragEventHandler(grid_DragOver);
            grid.DragDrop += new System.Windows.Forms.DragEventHandler(grid_DragDrop);
            TileView view = grid.MainView as TileView;
            view.OptionsBehavior.Editable = false;
            // view.MouseMove += new System.Windows.Forms.MouseEventHandler(tileView_MouseMove);
            view.MouseDown += new System.Windows.Forms.MouseEventHandler(tileView_MouseDown);
        }

        TileViewHitInfo tileDownHitInfo = null;

        private void tileView_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            TileView view = sender as TileView;
            if (view == null) return;
            tileDownHitInfo = null;
            TileViewHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
                tileDownHitInfo = hitInfo;
        }
        private void grid_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void grid_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            DataTable table = grid.DataSource as DataTable;
            DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;
            if (row != null && table != null && row.Table != table)
            {
                //bool isChack = CoFAS_ConvertManager.DataTable_FindCount(table, String.Format("CONFIGURATION_CODE = '{0}'", row["CONFIGURATION_CODE"].ToString()), "");
                //if (!isChack)
                //{
                    table.ImportRow(row);
                //}
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
                _luR_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "", false);
                _luUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "",false);

                _luT_USE_YN.ItemIndex = 1;

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
                    // _gdMAIN.DataSource = null;
                }

                //_gdSUB.DataSource = null;



            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {

            }
        }

        //private void _luPROCESS_TYPE_ValueChanged(object sender, EventArgs e)
        //{
        //    _ucbtSUB_SEARCH_Click(null, null);
        //}

        #endregion

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                if (e.RowHandle < 0) return;

                GridView gv = sender as GridView;

                _pProcessConfigurationRegisterEntity.CRUD = "R";
                _pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE = gv.GetFocusedRowCellValue("CONFIGURATION_MST_CODE").ToString();
                _pProcessConfigurationRegisterEntity.REVISION_NO = gv.GetFocusedRowCellValue("REVISION_NO").ToString();
                _pProcessConfigurationRegisterEntity.USE_YN = gv.GetFocusedRowCellValue("USE_YN").ToString();

                Routing_MST_Find_DisplayData();

                Routing_Configuration_Find_DisplayData();
                //_gdROUTING_MST.DataSource = null;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }



        #endregion

        #region ○ 서브01 그리드 로우 선택 이벤트 생성
        private void _gdSUB01_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                if (e.RowHandle < 0) return;

                _pProcessConfigurationRegisterEntity.CRUD = "R";
                _pProcessConfigurationRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pProcessConfigurationRegisterEntity.PROCESS_MST_CODE = gv.GetFocusedRowCellValue("PROCESS_MST_CODE").ToString();

                SubFind_WorkCenter_DisplayData();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }



        #endregion

        #region ○ 라우팅 그리드 로우 선택 이벤트 생성
        private void _gdROUTING_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                if (e.RowHandle < 0) return;
                _pProcessConfigurationRegisterEntity.CRUD = "R";
                _pProcessConfigurationRegisterEntity.ROUTING_MST_CODE = gv.GetFocusedRowCellValue("CONFIGURATION_CODE").ToString();
                _pProcessConfigurationRegisterEntity.ROUTING_REVISION_NO = gv.GetFocusedRowCellValue("ROUTING_REVISION_NO").ToString();
                _pProcessConfigurationRegisterEntity.USE_YN = gv.GetFocusedRowCellValue("USE_YN").ToString();

                RoutingProcessMST_DisplayData();
                RoutingTreeFind_DisplayData();

                _pProcessConfigurationRegisterEntity.CRUD = "U";

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

                _pProcessConfigurationRegisterEntity.CRUD = "R";
                _pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE = _luT_CONFIGURATION_MST_CODE.Text.ToString();
                _pProcessConfigurationRegisterEntity.CONFIGURATION_MST_NAME = _luT_CONFIGURATION_MST_NAME.Text.ToString();
                _pProcessConfigurationRegisterEntity.USE_YN = _luT_USE_YN.GetValue();
                
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

                //if (CoFAS_DevExpressManager.ShowQuestionMessage("저장 하시겠습니까?") == DialogResult.No)
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                    return;

                //if (CheckInputData())
                //{
                //    //DisplayMessage("입력항목을 확인하세요");
                //    DisplayMessage(_pMSG_CHECK_VALID_ITEM);
                //    return;
                //}

                //InputData_Save(dtTL);

                // if (!dxValidationProvider.Validate())
                // {
                //     return;
                // }

                //확인
                //if (_luGRID_NAME.ReadOnly)
                //{
                //    _pProductBOMRegisterEntity.CRUD = "U";
                //}
                //else
                //{
                //    _pProductBOMRegisterEntity.CRUD = "C";
                //}

                //InputData_Save(_gdSUB_VIEW.GridControl.DataSource as DataTable);
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

                _luT_USE_YN.ItemIndex = 1;

                _luPROCESS_MST_CODE.Text = "";
                _luPROCESS_MST_NAME.Text = "";
                _luR_REVISION_NO.Text = "";
                _luR_USE_YN.ItemIndex = 0;
                _ckCOPY.Checked = false;

                _luCONFIGURATION_MST_CODE.Text = "";
                _luCONFIGURATION_MST_NAME.Text = "";
                _luUSE_YN.ItemIndex = 0;
                _luREVISION_NO.Text = "";

                treeList1.ClearNodes();

                _dtRoutingCheckList = null;

                _pProcessConfigurationRegisterEntity.CRUD = "";
                Routing_Configuration_Find_DisplayData(); //41

                _pProcessConfigurationRegisterEntity.CRUD = "R";
                SubFind_DisplayData();
                RoutingProcessFind_DisplayData();

                _pProcessConfigurationRegisterEntity.CRUD = "C";
                _pProcessConfigurationRegisterEntity.REVISION_NO = "";

               // _gdROUTING_MST.DataSource = null;

                //_ucbtCONFIGURATION_SEARCH_Click(null, null);
                //_ucbtROUTING_SEARCH_Click(null, null);

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

        private void MainFind_DisplayData() //int iRowIndex
        {
            try
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
               


                _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_Main(_pProcessConfigurationRegisterEntity);


                if (_pProcessConfigurationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

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
                    _luT_CONFIGURATION_MST_CODE.Text = "";
                    _luT_CONFIGURATION_MST_NAME.Text = "";
                    _luT_USE_YN.ItemIndex = 0;

                    _pProcessConfigurationRegisterEntity.CRUD = "";
                    MainFind_DisplayData();

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
                //_gdMAIN_VIEW.BestFitColumns();

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

               _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_SUB01(_pProcessConfigurationRegisterEntity);

                if (_pProcessConfigurationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB01, _gdSUB01_VIEW, _dtList);
                }

                _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_SUB02(_pProcessConfigurationRegisterEntity);

                if (_pProcessConfigurationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB02, _gdSUB02_VIEW, _dtList);
                }

                _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_SUB03(_pProcessConfigurationRegisterEntity);

                if (_pProcessConfigurationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB03, _gdSUB03_VIEW, _dtList);
                }

                _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_SUB04(_pProcessConfigurationRegisterEntity);

                if (_pProcessConfigurationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB04, _gdSUB04_VIEW, _dtList);
                }

                _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_SUB05(_pProcessConfigurationRegisterEntity);

                if (_pProcessConfigurationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB05, _gdSUB05_VIEW, _dtList);
                }

                _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_SUB06(_pProcessConfigurationRegisterEntity);

                if (_pProcessConfigurationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB06, _gdSUB06_VIEW, _dtList);
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


        private void SubFind_WorkCenter_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

               
                _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_WorkCenter_SUB02(_pProcessConfigurationRegisterEntity);

                if (_pProcessConfigurationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB02, _gdSUB02_VIEW, _dtList);
                }
                else
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB02, _gdSUB02_VIEW, _dtList);
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

        #region ○ 라우팅 공정 조회 - RoutingProcessFind_DisplayData() 30
        private void RoutingProcessFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_Process(_pProcessConfigurationRegisterEntity);

                if (_pProcessConfigurationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdROUTING, _gdROUTING_VIEW, _dtList);
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

        private void RoutingProcessMST_DisplayData()
        {
            try
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Routing_Mst(_pProcessConfigurationRegisterEntity);

                _pProcessConfigurationRegisterEntity.ROUTING_REVISION_NO = _dtList.Rows[0]["R_REVISION_NO"].ToString();

                if (_pProcessConfigurationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegisterEntity.CRUD == ""))
                {
                    CoFAS_ControlManager.Controls_Binding(_dtList, false, this);
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

        private void RoutingTreeFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Routing_Tree(_pProcessConfigurationRegisterEntity);

                treeList1.ClearNodes();

                if (_dtList != null && _dtList.Rows.Count > 0)
                {

                    _dtRoutingCheckList = null;
                    _dtRoutingCheckList = _dtList;

                    for (int i = 0; _dtList.Rows.Count > i; i++)
                    {
                        if (treeList1.AllNodesCount == 0)
                        {
                            treeList1.AppendNode(new object[] { _dtList.Rows[i]["ID"].ToString(), _dtList.Rows[i]["configuration_name"],"0", _dtList.Rows[i]["routing_dsp_seq"], "", _dtList.Rows[i]["ParentID"], _dtList.Rows[i]["use_yn"], _dtList.Rows[i]["used_configuration"], _dtList.Rows[i]["ranking_code"] }, null); 
                        }
                        else
                        {
                            treeList1.AppendNode(new object[] { _dtList.Rows[i]["ID"].ToString(), _dtList.Rows[i]["configuration_name"],_dtList.Rows[i]["routing_lvl"], _dtList.Rows[i]["routing_dsp_seq"], _dtList.Rows[i]["cur_path"].ToString(), _dtList.Rows[i]["ParentID"].ToString(), _dtList.Rows[i]["use_yn"], _dtList.Rows[i]["used_configuration"], _dtList.Rows[i]["ranking_code"] }, treeList1.FindNodeByFieldValue("routing_code", _dtList.Rows[i]["ParentID"]));
                        }
                    }
                    treeList1.ForceInitialize();
                    treeList1.ExpandAll();
                    treeList1.BestFitColumns();
                    treeList1.RowHeight = 25;
                    //트리에서 컬럼 수정가능하게
                    treeList1.OptionsBehavior.Editable = true;
                    treeList1.Appearance.OddRow.BackColor = Color.White;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                // _gdSUB_VIEW.BestFitColumns();
                _pProcessConfigurationRegisterEntity.CRUD = "U";
                _pProcessConfigurationRegisterEntity.ROUTING_MST_CODE = "";


                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        #region ○ 라우팅 공정 순서 조회 - RoutingMSTFind_DisplayData() 40

        private void Routing_MST_Find_DisplayData() // 40
        {
            try
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_Routing_MST(_pProcessConfigurationRegisterEntity);

               

                if (_pProcessConfigurationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegisterEntity.CRUD == ""))
                {
                    CoFAS_ControlManager.Controls_Binding(_dtList, false, this);


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

        private void Routing_Configuration_Find_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_Routing_DETAIL(_pProcessConfigurationRegisterEntity);

                if (_pProcessConfigurationRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProcessConfigurationRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdROUTING_MST, tileView1, _dtList);
                }
                else
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdROUTING_MST, tileView1, _dtList);
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

        #region ○ 저장 - InputData_Save(DataTable dtSave)

        private void InputData_Save(DataTable dtSave)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;
                dtTL.Clear();
                drTL = null;
                iTreeNodeIndex = 0;


                string strMST = treeList1.Nodes[0][0].ToString();
                string strRev = _luR_REVISION_NO.Text.ToString().Length > 0 ? _luR_REVISION_NO.Text.ToString() : "1.0";

                //트리를 저장할려면 수정모드를 종료후 저장
                if (treeList1.AllNodesCount > 0)
                {
                    treeList1.CloseEditor();

                    DataRowADD(treeList1.Nodes[0], strMST, strRev);
                    SelectChildNodes(treeList1.Nodes[0], strMST, strRev);

                    if (_ckCOPY.Checked)
                    {
                        _pProcessConfigurationRegisterEntity.CRUD = "C";
                    }
                    else
                    {
                        if (_dtRoutingCheckList == null)
                        {
                            _pProcessConfigurationRegisterEntity.CRUD = "C";
                        }
                        else
                        {
                            if (!CoFAS_ConvertManager.DataTables_isEquals(_dtRoutingCheckList, dtTL))
                            {
                                if (_dtRoutingCheckList.Rows.Count != dtTL.Rows.Count)
                                {
                                     _pProcessConfigurationRegisterEntity.CRUD = "C";
                                    //기존 리비젼 정보와 같으면 안됨.
                                    if (_pProcessConfigurationRegisterEntity.ROUTING_REVISION_NO == strRev)
                                    {
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_REVISION_CHECK);
                                        return;
                                    }
                                }
                                else
                                {
                                    _pProcessConfigurationRegisterEntity.CRUD = "U";
                                }
                            }
                        }
                    }

                    // DataTable dt = dtTL;
                    //_pProductBOMRegisterEntity.CRUD = "C";

                    //isError = new ProductBOMRegisterBusiness().ProductBOMRegister_Info_Save(_pProductBOMRegisterEntity, dtSave);
                    _pProcessConfigurationRegisterEntity.USE_YN = _luR_USE_YN.GetValue();
                    isError = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_Save(_pProcessConfigurationRegisterEntity, dtTL);

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

                        // 화면 갱신
                        _pProcessConfigurationRegisterEntity.CRUD = "R";

                        _pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE = _luT_CONFIGURATION_MST_CODE.Text;
                        _pProcessConfigurationRegisterEntity.CONFIGURATION_MST_NAME = _luT_CONFIGURATION_MST_NAME.Text;

                        _pProcessConfigurationRegisterEntity.USE_YN = _luT_USE_YN.GetValue();

                        //MainFind_DisplayData();

                        treeList1.ClearNodes();

                        _luPROCESS_MST_CODE.Text = "";
                        _luPROCESS_MST_NAME.Text = "";
                        _luR_REVISION_NO.Text = "";
                        _luR_USE_YN.ItemIndex = 0;
                        _ckCOPY.Checked = false;

                        _luREVISION_NO.Text = "";
                        _luCONFIGURATION_MST_CODE.Text = "";
                        _luCONFIGURATION_MST_NAME.Text = "";
                        _luUSE_YN.ItemIndex = 0;

                        SubFind_DisplayData();

                        RoutingProcessFind_DisplayData();

                        //_ucbtROUTING_SEARCH_Click(null, null);

                    }
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("BOM데이터를 입력해주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_INPUT_DATA);
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

        #region ○ 저장 - RoutingData_Delete_Save()
        private void RoutingData_Delete_Save()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                isError = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Info_Enable(_pProcessConfigurationRegisterEntity);

                if (isError)
                {
                    //오류 발생.
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE_ERROR);

                }
                else
                {
                    //정상 처리
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_DELETE);

                    // 화면 갱신
                    // 화면 갱신
                    _pProcessConfigurationRegisterEntity.CRUD = "R";

                    _pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE = _luT_CONFIGURATION_MST_CODE.Text;
                    _pProcessConfigurationRegisterEntity.CONFIGURATION_MST_NAME = _luT_CONFIGURATION_MST_NAME.Text;

                    _pProcessConfigurationRegisterEntity.USE_YN = _luT_USE_YN.GetValue();

                    //MainFind_DisplayData();

                    treeList1.ClearNodes();

                    _luPROCESS_MST_CODE.Text = "";
                    _luPROCESS_MST_NAME.Text = "";
                    _luR_REVISION_NO.Text = "";
                    _luR_USE_YN.ItemIndex = 0;
                    _ckCOPY.Checked = false;

                    _luREVISION_NO.Text = "";
                    _luCONFIGURATION_MST_CODE.Text = "";
                    _luCONFIGURATION_MST_NAME.Text = "";
                    _luUSE_YN.ItemIndex = 0;

                    SubFind_DisplayData();

                    RoutingProcessFind_DisplayData();

                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {

                _pProcessConfigurationRegisterEntity.ROUTING_MST_CODE = "";
                _pProcessConfigurationRegisterEntity.REVISION_NO = "";
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        #region ○ 저장 - Configuration_Sort_Save(DataTable dtConfiguration)

        private void Configuration_Sort_Save(DataTable dtConfiguration)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = new ProcessConfigurationRegisterBusiness().ProcessConfigurationRegister_Configuration_Save(_pProcessConfigurationRegisterEntity, dtConfiguration);

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

                    // 화면 갱신

                    _pProcessConfigurationRegisterEntity.CRUD = "";
                    Routing_Configuration_Find_DisplayData(); //41

                    _pProcessConfigurationRegisterEntity.CRUD = "R";

                    _pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE = "";
                    _pProcessConfigurationRegisterEntity.CONFIGURATION_MST_NAME = "";

                    _pProcessConfigurationRegisterEntity.USE_YN = _luT_USE_YN.GetValue();

                    MainFind_DisplayData();

                    treeList1.ClearNodes();

                    _luR_REVISION_NO.Text = "";
                    _luPROCESS_MST_CODE.Text = "";
                    _luPROCESS_MST_NAME.Text = "";
                    _luR_USE_YN.ItemIndex = 0;
                    _ckCOPY.Checked = false;

                    _luREVISION_NO.Text = "";
                    _luCONFIGURATION_MST_CODE.Text = "";
                    _luCONFIGURATION_MST_NAME.Text = "";
                    _luUSE_YN.ItemIndex = 0;

                    _pProcessConfigurationRegisterEntity.CRUD = "R";

                    SubFind_DisplayData();
                    RoutingProcessFind_DisplayData();
                    //_ucbtROUTING_SEARCH_Click(null, null);

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
                    //DisplayMessage(pErrName);

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

        private void _ucbtPROCESS_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                    return;

                //if (CheckInputData())
                //{
                //    DisplayMessage(_pMSG_CHECK_VALID_ITEM);
                //    return;
                //}

                if (_luR_REVISION_NO.Text == "")
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_lciREVISION_NO.Text.ToString() + ". " + _pMSG_CHECK_VALID_ITEM);
                    return;
                }

                if (_luR_USE_YN.GetValue() == "N")
                {
                    if (_luPROCESS_MST_CODE.Text.ToString().Length > 0 && _luR_REVISION_NO.Text.ToString().Length > 0)
                    {
                        _pProcessConfigurationRegisterEntity.CRUD = "E";
                        _pProcessConfigurationRegisterEntity.ROUTING_MST_CODE = _luPROCESS_MST_CODE.Text.ToString();
                        _pProcessConfigurationRegisterEntity.ROUTING_REVISION_NO = _luR_REVISION_NO.Text.ToString();
                        _pProcessConfigurationRegisterEntity.USE_YN = _luR_USE_YN.GetValue();

                        RoutingData_Delete_Save();
                    }
                    else
                    {
                        DisplayMessage(_pMSG_CHECK_VALID_ITEM);
                    }
                }
                else
                {

                    InputData_Save(dtTL);
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

        private void _ucbtROUTING_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                    return;

                if (CheckInputData())
                {
                    DisplayMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }

                DataTable dtRouting_MST = tileView1.GridControl.DataSource as DataTable;

                if (dtRouting_MST != null && dtRouting_MST.Rows.Count > 0)
                {
                    //확인
                    if (_luCONFIGURATION_MST_CODE.Text.Length > 0)
                    {
                        _pProcessConfigurationRegisterEntity.CRUD = "U";

                    }
                    else
                    {
                        _pProcessConfigurationRegisterEntity.CRUD = "C";
                    }

                    _pProcessConfigurationRegisterEntity.RTN_KEY = "";

                    _pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE = _luCONFIGURATION_MST_CODE.Text.ToString();
                    _pProcessConfigurationRegisterEntity.CONFIGURATION_MST_NAME = _luCONFIGURATION_MST_NAME.Text.ToString();
                    _pProcessConfigurationRegisterEntity.CONFIGURATION_VEND_CODE = _luCONFIGURATION_VEND_CODE.Text.ToString();
                    _pProcessConfigurationRegisterEntity.REVISION_NO = _luREVISION_NO.Text.ToString();
                    _pProcessConfigurationRegisterEntity.USE_YN = _luUSE_YN.GetValue();

                    Configuration_Sort_Save(dtRouting_MST);
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

        #region Tree Event Manager
        #region 18.06.08 트리리스트 관련 
        private void CreateDataTable()
        {
            dtTL.Columns.Add(new DataColumn("ROUTING_MST_CODE", typeof(string)));
            dtTL.Columns.Add(new DataColumn("ROUTING_REVISION_NO", typeof(string)));

            dtTL.Columns.Add(new DataColumn("ROUTING_CODE", typeof(string)));
            dtTL.Columns.Add(new DataColumn("ROUTING_NAME", typeof(string)));
            dtTL.Columns.Add(new DataColumn("P_ROUTING_CODE", typeof(string)));
            dtTL.Columns.Add(new DataColumn("NODE_LEVEL", typeof(int)));
            dtTL.Columns.Add(new DataColumn("NODE_ID", typeof(int)));

            //dtTL.Columns.Add(new DataColumn("OLD_P_ROUTING_CODE", typeof(string)));
            //dtTL.Columns.Add(new DataColumn("OLD_NODE_LEVEL", typeof(int)));
            //dtTL.Columns.Add(new DataColumn("OLD_NODE_ID", typeof(int)));

            dtTL.Columns.Add(new DataColumn("USE_YN", typeof(string)));
        }

        private void DataRowADD(TreeListNode node, string strROUTING_MST_CODE, string strREVISION_NO)
        {
            drTL = dtTL.NewRow();

            drTL["ROUTING_MST_CODE"] = strROUTING_MST_CODE;
            drTL["ROUTING_REVISION_NO"] = strREVISION_NO;


            drTL["ROUTING_CODE"] = node.GetDisplayText(routing_code);
            drTL["ROUTING_NAME"] = node.GetDisplayText(routing_name);
            drTL["P_ROUTING_CODE"] = node.ParentNode == null ? node.GetDisplayText(routing_code) : node.ParentNode.GetDisplayText(routing_code);
            drTL["NODE_LEVEL"] = node.Level;
            drTL["NODE_ID"] = iTreeNodeIndex; // node.Id;

            drTL["USE_YN"] = node.GetValue(use_yn);

            ////drTL["OLD_P_PROCESS_CODE"] = node.GetDisplayText(p_process_code);
            ////drTL["OLD_NODE_LEVEL"] = node.GetValue(process_lvl) == null ? "" : node.GetValue(process_lvl);
            ////drTL["OLD_NODE_ID"] = node.GetValue(process_dsp_seq) == null ? "" : node.GetValue(process_dsp_seq);

            dtTL.Rows.Add(drTL);
        }

        private void SelectChildNodes(TreeListNode node, string strROUTING_MST_CODE, string strREVISION_NO)
        {
            foreach (TreeListNode childNode in node.Nodes)
            {
                iTreeNodeIndex += 1;
                DataRowADD(childNode, strROUTING_MST_CODE, strREVISION_NO);
                if (childNode.HasChildren)
                    SelectChildNodes(childNode, strROUTING_MST_CODE, strREVISION_NO);
            }
        }

        #endregion

        Cursor _dragRowCursor;

        TreeListHitInfo _dragStartHitInfo;

        public void SetUpTreeList()
        {
            /// 트리 리스트 폰트 설정
            Font fntHeader = new Font(_pFONT_SETTING.FontFamily, _pFONT_SETTING.Size + 2, FontStyle.Bold);
            Font fntRow = _pFONT_SETTING;

            _dragRowCursor = Cursors.Default;

            /// 트리 리스트 설정 영역
            treeList1.AllowDrop = true; // 트리 리스트 항상 Drop 기능 활성화 유무

            treeList1.Appearance.HeaderPanel.Font = fntHeader; // 트리 리스트 헤더 데이터 패널 폰트
            treeList1.Appearance.Row.Font = fntRow; // 트리 리스트 로우 데이터 폰트

            treeList1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // 트리 리스트 헤더 데이터 정렬 가로
            treeList1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center; // 트리 리스트 헤더 데이터 정렬 가로

            treeList1.Appearance.OddRow.BackColor = Color.Empty;// Color.LightSteelBlue; // 트리 리스트 홀수 줄 색상
            treeList1.Appearance.FocusedRow.BackColor = Color.LightYellow; // 트리 리스트 선택 로우 색상

            treeList1.OptionsView.EnableAppearanceOddRow = true; // 트리 리스트 홀수 줄 색상 변경 유무
            treeList1.OptionsView.AutoWidth = true; // 트리 리스트 컬럼 사이즈 조정 자동 유무
            treeList1.OptionsView.ShowIndentAsRowStyle = true;
            treeList1.OptionsView.ShowIndicator = true;

            treeList1.RowHeight = 20; // 트리 리스트 줄 높이 설정
            treeList1.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Single;


            switch (_pProcessConfigurationRegisterEntity.LANGUAGE_TYPE)
            {
                case "한국어":
                    treeList1.Columns[0].Caption = "공정 코드";
                    treeList1.Columns[1].Caption = "공정 이름";
                    treeList1.Columns[6].Caption = "사용 여부";
                    break;

                case "日本":
                    treeList1.Columns[0].Caption = "プロセスコード";
                    treeList1.Columns[1].Caption = "プロセス名";
                    treeList1.Columns[6].Caption = "使用分類";
                    break;

            }



            /// 트리 리스트 이벤트 영역
            treeList1.DragOver += treeList_DragOver;
            treeList1.DragDrop += treeList_DragDrop;
            treeList1.MouseMove += treeList_MouseMove;
            treeList1.MouseDown += treeList_MouseDown;
            treeList1.MouseUp += treeList_MouseUp;
            treeList1.GiveFeedback += treeList_GiveFeedback;
        }

        // 재귀로 자식노드 체크 상태 확인
        private bool ChildNodeChecked(TreeListNode StartNode)
        {
            foreach (TreeListNode tn in StartNode.Nodes)
            {
                if (ChildNodeChecked(tn) & tn.Checked == false) return false;
            }
            return true;
        }

        private void treeList_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (_dragStartHitInfo != null)
            {
                e.UseDefaultCursors = false;
                Cursor.Current = _dragRowCursor;
            }
        }

        private void treeList_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _dragStartHitInfo != null && _dragStartHitInfo.HitInfoType == HitInfoType.Cell)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(_dragStartHitInfo.MousePoint.X - dragSize.Width / 2, _dragStartHitInfo.MousePoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    //_dragRowCursor = _imageHelper.GetDragCursor(_dragStartHitInfo, e.Location);
                    TreeListNode dragObject = _dragStartHitInfo.Node;
                    (sender as TreeList).DoDragDrop(dragObject, DragDropEffects.Move);
                    _dragStartHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void treeList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && System.Windows.Forms.Control.ModifierKeys == Keys.None)
                _dragStartHitInfo = (sender as TreeList).CalcHitInfo(new Point(e.X, e.Y));
            else
                _dragStartHitInfo = null;


            if (e.Button == MouseButtons.Right && System.Windows.Forms.Control.ModifierKeys == Keys.None)
            {
                _dragStartHitInfo = (sender as TreeList).CalcHitInfo(new Point(e.X, e.Y));
                TreeListNode node = null;
                //아래에 트리명칭참조
                //https://documentation.devexpress.com/WindowsForms/DevExpress.XtraTreeList.HitInfoType.enum
                //Cell : 셀클릭시
                if (_dragStartHitInfo.HitInfoType == HitInfoType.Cell)
                {
                    node = _dragStartHitInfo.Node;
                }
                if (node == null) return;
                //'노드 삭제'메뉴 생성
                TreeListMenu menu = new TreeListMenu(sender as TreeList);
                DevExpress.Utils.Menu.DXMenuItem menuItem = new DevExpress.Utils.Menu.DXMenuItem("&" + "Delete Row", new EventHandler(deleteNodeMenuItemClick));
                menuItem.Tag = node;
                menu.Items.Add(menuItem);
                // Show the menu.
                menu.Show(e.Location);
            }
            else
                _dragStartHitInfo = null;
        }

        private void treeList_MouseUp(object sender, MouseEventArgs e)
        {
            //TreeListNode dragNode = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;

            //TreeListNode targetNode;

            //TreeList treeList = sender as TreeList;

            //Point p = treeList.PointToClient(System.Windows.Forms.Control.MousePosition);

            //targetNode = treeList.CalcHitInfo(p).Node;

        }

        // 노드삭제 인보크
        private void deleteNodeMenuItemClick(object sender, EventArgs e)
        {
            DevExpress.Utils.Menu.DXMenuItem item = sender as DevExpress.Utils.Menu.DXMenuItem;
            if (item == null) return;
            TreeListNode node = item.Tag as TreeListNode;
            if (node == null) return;
            node.TreeList.DeleteNode(node);
        }

        private void treeList_DragOver(object sender, DragEventArgs e)
        {
            TreeListNode dragNode = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;

            TreeListNode targetNode;

            TreeList treeList = sender as TreeList;

            Point p = treeList.PointToClient(System.Windows.Forms.Control.MousePosition);

            targetNode = treeList.CalcHitInfo(p).Node;

            if (dragNode != null && targetNode != null && dragNode.Level != 0)
            {

                //if (Convert.ToInt32(dragNode.GetDisplayText("part_code").Substring(0, 1)) > Convert.ToInt32(targetNode.GetDisplayText("part_code").Substring(0, 1)))
                //{
                    e.Effect = DragDropEffects.Move;

                //}
                //else
                //{
                //    _dragRowCursor = Cursors.No;
                //    DisplayMessage("하위 품목 에 등록 할 수 없습니다.");
                //}
            }
            else
            {
                if (e.Data.GetDataPresent(typeof(DataRow)))
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void treeList_DragDrop(object sender, DragEventArgs e)
        {

            TreeListNode dragNode, targetNode;

            TreeList treeList = sender as TreeList;

            Point p = treeList.PointToClient(new Point(e.X, e.Y));

            targetNode = treeList.CalcHitInfo(p).Node;

            DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;

            if (row != null)
            {
                TreeListHitInfo hitInfo = treeList.CalcHitInfo(treeList.PointToClient(new Point(e.X, e.Y)));

                //트리리스가 등록되지 않은 초기상태
                if (treeList.AllNodesCount == 0)
                {
                    // TreeList - Drag & Drop 기능 추가

                    //if (row["used_configuration"].ToString() == "Y")
                    //{
                    //    CoFAS_DevExpressManager.ShowInformationMessage("구성된 정보 입니다.");
                    //    //CoFAS_DevExpressManager.ShowInformationMessage("構成された情報");
                    //    return;
                    //}

                    treeList.AppendNode(new object[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), "0",  "0", "", "", "Y", row.ItemArray[2].ToString(), row.ItemArray[3].ToString() }, null);

                }
                else
                {
                    if (hitInfo.HitInfoType != HitInfoType.Cell)
                    {
                        return;
                    }

                    //if (row["used_configuration"].ToString() == "Y")
                    //{
                    //    CoFAS_DevExpressManager.ShowInformationMessage("구성된 정보 입니다.");
                    //    //CoFAS_DevExpressManager.ShowInformationMessage("構成された情報");
                    //    return;
                    //}

                    if (targetNode.GetDisplayText("routing_code") == row.ItemArray[0].ToString())
                    {

                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PART_SAME_CODE); 
                        //CoFAS_DevExpressManager.ShowInformationMessage("登録することができません"); 
                        return;
                    }

                    if (Convert.ToInt32(targetNode.GetDisplayText("ranking_code").Substring(0, 1)) > CoFAS_ConvertManager.obj2int(row.ItemArray[3]))
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_PART_NOT_CHILD);
                        //CoFAS_DevExpressManager.ShowInformationMessage("下に登録することはできません。");
                        return;
                    }

                    if (targetNode.GetDisplayText("use_yn").ToString() == "N")
                    {
                        MessageBox.Show(_pMSG_BOM_DISABLE);
                        //MessageBox.Show("停止製品");
                        return;
                    }

                    if (targetNode.Nodes.Count != 0)
                    {
                        for (int a = 0; a < targetNode.Nodes.Count; a++)
                        {
                            if (targetNode.Nodes[a].GetDisplayText("routing_code") == row.ItemArray[0].ToString())
                            {
                                CoFAS_DevExpressManager.ShowInformationMessage(row.ItemArray[0].ToString() + " " + _pMSG_LEVEL_SAME_NOT);

                                //CoFAS_DevExpressManager.ShowInformationMessage(row.ItemArray[0].ToString() + " 登録することができません");
                                return;
                            }
                        }
                    }

                    treeList.AppendNode(new object[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), (targetNode.Level + 1).ToString(), (targetNode.Id + 1).ToString(), "", "", "Y", row.ItemArray[2].ToString(), row.ItemArray[3].ToString() }, targetNode);
                }

                treeList.ForceInitialize();
                treeList.ExpandAll();
                treeList.BestFitColumns();

                e.Effect = DragDropEffects.None;

            }
            else
            {
                int index = -1;
                dragNode = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;

                if (targetNode.ParentNode != null) index = targetNode.ParentNode.Nodes.IndexOf(targetNode);

                if (Convert.ToInt32(dragNode.GetDisplayText("ranking_code").Substring(0, 1)) > Convert.ToInt32(targetNode.GetDisplayText("ranking_code").Substring(0, 1)))
                {
                    treeList.MoveNode(dragNode, targetNode, true);
                    treeList.SetNodeIndex(dragNode, index);
                    e.Effect = DragDropEffects.None;
                }
                else
                {
                    _dragRowCursor = Cursors.No;
                    DisplayMessage(_pMSG_PART_NOT_CHILD);
                    //DisplayMessage("下に登録することはできません。");
                }
            }


        }


        #endregion

        /// <summary>
        /// 품목 라우팅 구성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    UI.IM.UserForm.frmCommonPopup xfrmCommonPopup = new UI.IM.UserForm.frmCommonPopup("PartProcessMapping");

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
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SELECT_CONFIGURATION);
                    //CoFAS_DevExpressManager.ShowInformationMessage("構成情報を選択した後の作業");
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }


        }

        private void _ckCOPY_CheckedChanged(object sender, EventArgs e)
        {
            if (_ckCOPY.Checked)
            {
                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_REVISION_INIT) == DialogResult.Yes)
                {
                    _luR_REVISION_NO.Text = "";
                    _luR_USE_YN.ItemIndex = 0;
                }
                else
                {
                    _ckCOPY.Checked = false;
                }
            }
        }
    }
}
