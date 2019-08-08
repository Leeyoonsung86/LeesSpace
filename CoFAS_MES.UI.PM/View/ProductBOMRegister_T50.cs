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

using CoFAS_MES.UI.PM.Business;
using CoFAS_MES.UI.PM.Data;
using CoFAS_MES.UI.PM.Entity;
using DevExpress.XtraGrid.Views.Grid;

//018.06.08트리리트관련
using DevExpress.XtraTreeList;
//using DevExpress.XtraTreeList.Columns;
//using DevExpress.XtraTreeList.Handler;
using DevExpress.XtraTreeList.Menu;
using DevExpress.XtraTreeList.Nodes;
//using DevExpress.XtraTreeList.Painter;
//using DevExpress.XtraTreeList.ViewInfo;

using CoFAS_MES.CORE.UserForm;
//using DevExpress.Utils;

namespace CoFAS_MES.UI.PM
{
    public partial class ProductBOMRegister_T50 : frmBaseNone
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
        private string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pUSER_GRANT = string.Empty; // 사용자 권한

        //공통 메시지 영역 
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
        private string _pMSG_RESET_COMPLETE = string.Empty;     //초기화 하였습니다.
        private string _pMSG_CHECK_VALID_ITEM = string.Empty;    //필수항목을 확인해주시기 바랍니다. 
        
        //화면 추가 메시지 영역
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


        private ProductBOMRegister_T50Entity _pProductBOMRegister_T50Entity = null; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        private DataTable _dtBOMCheckList = null; //선택된 BOM 리스트 체크용 백업 데이터테이블

        private DataTable dtMessage = null; // 화면별 메세지 관리 데이터 테이블

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        //18.06.08 트리리스트 관련
        private DataTable dtTL = new DataTable("TreeListData"); //treelist 저장 처리 데이터 테이블
        private DataRow drTL = null; // treelist 저장 처리 데이터 로우
        public int iTreeNodeIndex = 0;

        public ProductBOMRegister_T50()
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

                treeList1.DragOver -= treeList_DragOver;
                treeList1.DragDrop -= treeList_DragDrop;
                treeList1.MouseMove -= treeList_MouseMove;
                treeList1.MouseDown -= treeList_MouseDown;
                treeList1.GiveFeedback -= treeList_GiveFeedback;

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
                _gdSUB05.Visible = false;
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
                _pMSG_RESET_COMPLETE = MainForm.MessageEntity.MSG_RESET_COMPLETE;
                _pMSG_CHECK_VALID_ITEM = MainForm.MessageEntity.MSG_CHECK_VALID_ITEM;

                _pWINDOW_NAME = this.Name;

                //메뉴 화면 엔티티 설정
                _pProductBOMRegister_T50Entity = new ProductBOMRegister_T50Entity();
                _pProductBOMRegister_T50Entity.CORP_CODE = _pCORP_CODE;
                _pProductBOMRegister_T50Entity.USER_CODE = _pUSER_CODE;
                _pProductBOMRegister_T50Entity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;

                //추가 메세지 정보 조회.
                dtMessage = new MessageBusiness().MessageValue_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME);

                if(dtMessage != null && dtMessage.Rows[0][0].ToString() != "")
                {
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
                //_pProductBOMRegister_T50Entity.CRUD = "";
                //MainFind_DisplayData();


                _pProductBOMRegister_T50Entity.CRUD = "R";
                SubFind_DisplayData();

                //if (_pFirstYN)
                //{
                //    LeftFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
                //    _pFirstYN = false;
                //}


                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                
                //그리드 버튼추가 시 클릭 이벤트 처리 


                //설정 완료 후 신규 CRUD 코드  C 로변경;
                _pProductBOMRegister_T50Entity.CRUD = "C";


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
                   _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE,_pWINDOW_NAME, _gdMAIN.Name.ToString()));
                   _gdSUB01_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB01, _gdSUB01_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB01.Name.ToString()));
                  // _gdSUB02_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB02, _gdSUB02_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB02.Name.ToString()));
                   _gdSUB03_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB03, _gdSUB03_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB03.Name.ToString()));
                  // _gdSUB04_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB04, _gdSUB04_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB04.Name.ToString()));
                   _gdSUB05_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB05, _gdSUB05_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdSUB05.Name.ToString()));

                }
                //new CoFAS_TreeListManager(treeList1, this.Name); // Drag&Drop 함수

                //new TreeListManager(treeList1, this.Name); // Drag&Drop 함수

                SetUpTreeList(); //트리 리스트 설정 및  Drag&Drop 함수
                                          //
                CreateDataTable(); //treelist 저장 처리 데이터 테이블 만들기

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
                //_luSUB_PART_TYPE
                _luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "USE_YN", "", "", "").Tables[0], 0, 0, "",false);



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

        #endregion

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                // CoFAS_ControlManager.Controls_Binding(gv, false, this);
                //if (gv.GetFocusedRowCellValue("USE_YN").ToString() == "Y")
                //{
                    _pProductBOMRegister_T50Entity.CRUD = "R";
                    _pProductBOMRegister_T50Entity.PART_CODE = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                    _pProductBOMRegister_T50Entity.REVISION_NO = gv.GetFocusedRowCellValue("REVISION_NO").ToString();
                    _pProductBOMRegister_T50Entity.USE_YN = gv.GetFocusedRowCellValue("USE_YN").ToString();
                    CodeText.Text = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                    NameText.Text = gv.GetFocusedRowCellValue("PART_NAME").ToString();
                _luPART_CODE.Text = "";
                _luPART_NAME.Text = "";
                    BOM_MST_Find_DisplayData();
                    BOMFind_DisplayData();

                    _pProductBOMRegister_T50Entity.CRUD = "U";
                //}
                //else
                //{
                //    _pProductBOMRegister_T50Entity.CRUD = "R";

                //    treeList1.ClearNodes();

                //    _luREVISION_NO.Text = "";
                //    _luPART_MST.CodeText = "";
                //    _luPART_MST.NameText = "";

                //    _ckCOPY.Checked = false;

                //    SubFind_DisplayData();
                //}

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 그리드 버튼추가 시 클릭 이벤트 생성

        #endregion


        // 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pProductBOMRegister_T50Entity.CRUD = "R";

                _pProductBOMRegister_T50Entity.PART_CODE = _luPART_CODE.Text;
                _pProductBOMRegister_T50Entity.PART_NAME = _luPART_NAME.Text;

                _pProductBOMRegister_T50Entity.USE_YN = _luT_USE_YN.GetValue();

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

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                    return;

                if (CheckInputData())
                {
                    DisplayMessage(_pMSG_CHECK_VALID_ITEM);
                    return;
                }

                if (_luUSE_YN.GetValue() == "N")
                {
                    //if (_luPART_MST.CodeText.ToString().Length > 0 )
                    //    if (CodeText.Text.ToString().Length > 0)
                        if (CodeText.Text.Length > 0)
                        {
                        _pProductBOMRegister_T50Entity.CRUD = "E";
                        _pProductBOMRegister_T50Entity.PART_CODE_MST = CodeText.Text; //_luPART_MST.CodeText.ToString();
                        //_pProductBOMRegister_T50Entity.REVISION_NO = _luREVISION_NO.Text.ToString();
                        _pProductBOMRegister_T50Entity.REVISION_NO = ""; //리비전사용안함

                        BOMData_Delete_Save();
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

                //if (_luPART_MST.CodeText.ToString().Length > 0)
                    if (CodeText.Text.Length > 0)
                    {
                    _pProductBOMRegister_T50Entity.CRUD = "E";
                    _pProductBOMRegister_T50Entity.PART_CODE_MST = CodeText.Text;//_luPART_MST.CodeText.ToString();
                    _pProductBOMRegister_T50Entity.REVISION_NO = _luREVISION_NO.Text.ToString();

                    BOMData_Delete_Save();
                }
                else
                {
                    DisplayMessage(_pMSG_CHECK_VALID_ITEM);
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
               // _luMAIN_PART.CodeText = "";
               // _luMAIN_PART.NameText = "";
                _luT_USE_YN.ItemIndex = 0;
                _luREVISION_NO.Text = "";
                //_luPART_MST.CodeText = "";
                CodeText.Text = "";
                NameText.Text = "";
                //_luPART_MST.NameText = "";
                _luUSE_YN.ItemIndex = 0;
                _luPART_CODE.Text = "";
                _luPART_NAME.Text = "";
               // _ckCOPY.Checked = false;

                treeList1.ClearNodes();
                _dtBOMCheckList = null;
               
                _pProductBOMRegister_T50Entity.CRUD = "C";
                _pProductBOMRegister_T50Entity.REVISION_NO = "";
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

        private void MainFind_DisplayData() //int iRowIndex
        {
            try
            {
                
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
          
                _dtList = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_Left(_pProductBOMRegister_T50Entity);

                if (_pProductBOMRegister_T50Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductBOMRegister_T50Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                }
                else
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);

                    DisplayMessage(_pMSG_SEARCH_EMPT);
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

                _dtList = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_SUB01(_pProductBOMRegister_T50Entity);

                if (_pProductBOMRegister_T50Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductBOMRegister_T50Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB01, _gdSUB01_VIEW, _dtList);
                }

                _dtList = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_SUB02(_pProductBOMRegister_T50Entity);

                if (_pProductBOMRegister_T50Entity.CRUD == "") _dtList.Rows.Clear();

                //if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductBOMRegister_T50Entity.CRUD == ""))
                //{
                //    CoFAS_DevExpressManager.BindGridControl(_gdSUB02, _gdSUB02_VIEW, _dtList);
                //}

                _dtList = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_SUB03(_pProductBOMRegister_T50Entity);

                if (_pProductBOMRegister_T50Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductBOMRegister_T50Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB03, _gdSUB03_VIEW, _dtList);
                }

                _dtList = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_SUB04(_pProductBOMRegister_T50Entity);

                if (_pProductBOMRegister_T50Entity.CRUD == "") _dtList.Rows.Clear();

                //if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductBOMRegister_T50Entity.CRUD == ""))
                //{
                //    CoFAS_DevExpressManager.BindGridControl(_gdSUB04, _gdSUB04_VIEW, _dtList);
                //}

                _dtList = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_SUB05(_pProductBOMRegister_T50Entity);

                if (_pProductBOMRegister_T50Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductBOMRegister_T50Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdSUB05, _gdSUB05_VIEW, _dtList);
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

        #region ○ BOM조회 - BOMFind_DisplayData()

        private void BOM_MST_Find_DisplayData()
        {
            try
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_Main(_pProductBOMRegister_T50Entity);

                _pProductBOMRegister_T50Entity.REVISION_NO = _dtList.Rows[0]["REVISION_NO"].ToString();

                if (_pProductBOMRegister_T50Entity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pProductBOMRegister_T50Entity.CRUD == ""))
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

        private void BOMFind_DisplayData()
        {
            try
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_BOM(_pProductBOMRegister_T50Entity);
                
                treeList1.ClearNodes();

                if (_dtList != null && _dtList.Rows.Count > 0)
                {
                    _dtBOMCheckList = null;
                    _dtBOMCheckList = _dtList;

                    for (int i = 0; _dtList.Rows.Count > i; i++)
                    {
                        if (treeList1.AllNodesCount == 0)
                        {
                            treeList1.AppendNode(new object[] { _dtList.Rows[i]["ID"].ToString(), _dtList.Rows[i]["part_name"], _dtList.Rows[i]["part_qty"], _dtList.Rows[i]["part_unit_name"], "0", _dtList.Rows[i]["part_dsp_seq"], "", _dtList.Rows[i]["ParentID"], _dtList.Rows[i]["use_yn"], _dtList.Rows[i]["used_configuration"], _dtList.Rows[i]["part_code2"], _dtList.Rows[i]["p_part_code2"], _dtList.Rows[i]["part_type"] }, null);
                        }
                        else
                        {
                            treeList1.AppendNode(new object[] { _dtList.Rows[i]["ID"].ToString(), _dtList.Rows[i]["part_name"], _dtList.Rows[i]["part_qty"], _dtList.Rows[i]["part_unit_name"], _dtList.Rows[i]["part_lvl"], _dtList.Rows[i]["part_dsp_seq"], _dtList.Rows[i]["cur_path"].ToString(), _dtList.Rows[i]["ParentID"].ToString(), _dtList.Rows[i]["use_yn"], _dtList.Rows[i]["used_configuration"], _dtList.Rows[i]["part_code2"], _dtList.Rows[i]["p_part_code2"], _dtList.Rows[i]["part_type"] }, treeList1.FindNodeByFieldValue("part_code2", _dtList.Rows[i]["p_part_code2"]));
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
                //else
                //{

                //    _dtList = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_Main_Sub(_pProductBOMRegister_T50Entity);

                //    if(_dtList != null && _dtList.Rows.Count > 0)
                //    {
                //        if (treeList1.AllNodesCount == 0)
                //        {
                //            treeList1.AppendNode(new object[] { _dtList.Rows[0]["ID"].ToString(), _dtList.Rows[0]["part_name"], _dtList.Rows[0]["part_qty"], _dtList.Rows[0]["part_unit_name"], "0", _dtList.Rows[0]["part_dsp_seq"], "0", _dtList.Rows[0]["ParentID"], "", _dtList.Rows[0]["use_yn"], _dtList.Rows[0]["used_configuration"] }, null);
                //        }
                //        treeList1.ForceInitialize();
                //        treeList1.ExpandAll();
                //        treeList1.BestFitColumns();
                //        treeList1.RowHeight = 25;
                //        //트리에서 컬럼 수정가능하게
                //        treeList1.OptionsBehavior.Editable = true;
                //        treeList1.Appearance.OddRow.BackColor = Color.White;

                //    }
                //    else
                //    {
                //        //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                //        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
                //        treeList1.ClearNodes();
                //    }
                //}
                

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                //_gdMAIN_VIEW.BestFitColumns();

                _pProductBOMRegister_T50Entity.CRUD = "U";
                _pProductBOMRegister_T50Entity.PART_CODE = "";
                _luPART_CODE.Text = "";
                _luPART_NAME.Text = "";
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        private DataTable BOM_Configuration_FindData()
        {
            try
            {

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                DataTable rtDT = null;

                _dtList = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Configuration_Info(_pProductBOMRegister_T50Entity);

              
                if (_dtList != null && _dtList.Rows.Count > 0)
                {
                    rtDT = _dtList;
                }

                return rtDT;
            }
            catch (ExceptionManager pExceptionManager)
            {
                return null;

                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
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

                //임시
                string strMST = CodeText.Text.ToString().Length > 0 ? CodeText.Text.ToString() : treeList1.Nodes[0][0].ToString();
                //string strMST = _luPART_MST.CodeText.ToString().Length > 0 ? _luPART_MST.CodeText.ToString() : treeList1.Nodes[0][0].ToString();
                string strRev = _luREVISION_NO.Text.ToString().Length > 0 ? _luREVISION_NO.Text.ToString() : "1.0";

                //

                //트리를 저장할려면 수정모드를 종료후 저장
                if (treeList1.AllNodesCount > 0)
                {
                    treeList1.CloseEditor();

                    DataRowADD(treeList1.Nodes[0], strMST, strRev);
                    SelectChildNodes(treeList1.Nodes[0], strMST, strRev);

                        if (_dtBOMCheckList == null)
                        {
                            _pProductBOMRegister_T50Entity.CRUD = "C";
                        }
                        else
                        {
                            if (!CoFAS_ConvertManager.DataTables_isEquals(_dtBOMCheckList, dtTL))
                            {
                                if (_dtBOMCheckList.Rows.Count != dtTL.Rows.Count)
                                {
                                    _pProductBOMRegister_T50Entity.CRUD = "C";
                                    //기존 리비젼 정보와 같으면 안됨.
                                    if (_pProductBOMRegister_T50Entity.REVISION_NO == strRev)
                                    {
                                        //CoFAS_DevExpressManager.ShowInformationMessage("리비젼 변경 후 작업");
                                        //CoFAS_DevExpressManager.ShowInformationMessage("Revision変更後のタスク");
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_REVISION_CHECK);
                                        return;
                                    }
                                }
                                else
                                {
                                    _pProductBOMRegister_T50Entity.CRUD = "U";
                                }
                            }
                        }
                    

                    // DataTable dt = dtTL;
                    //_pProductBOMRegister_T50Entity.CRUD = "C";
                    _pProductBOMRegister_T50Entity.USE_YN = _luUSE_YN.GetValue();
                    //isError = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_Save(_pProductBOMRegister_T50Entity, dtSave);

                    //20180118
                    //Revision 중복 검사
                    /*
                    DataTable temp_T = new DataTable();
                    temp_T = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_Duplicate_chk(_pProductBOMRegister_T50Entity, dtTL);
                    {
                        if(temp_T.Rows.Count>0)
                        {
                            //CoFAS_DevExpressManager.ShowInformationMessage("리비젼 변경 후 작업");
                            //CoFAS_DevExpressManager.ShowInformationMessage("Revision変更後のタスク");
                            CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_REVISION_CHECK);
                            return;
                        }
                    }
                    */


                    isError = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_Save(_pProductBOMRegister_T50Entity, dtTL);

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
                        _pProductBOMRegister_T50Entity.CRUD = "R";

                        _pProductBOMRegister_T50Entity.PART_CODE = _luPART_CODE.Text;
                        _pProductBOMRegister_T50Entity.PART_NAME = _luPART_NAME.Text;

                        _pProductBOMRegister_T50Entity.USE_YN = _luT_USE_YN.GetValue();

                        MainFind_DisplayData();

                        treeList1.ClearNodes();

                        _luREVISION_NO.Text = "";
                        //_luPART_MST.CodeText = "";
                        CodeText.Text = "";
                        NameText.Text = "";
                        //_luPART_MST.NameText = "";
                        _luUSE_YN.ItemIndex = 0;

                       // _ckCOPY.Checked = false;

                        SubFind_DisplayData();

                    }
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowInformationMessage("BOM데이터를 입력해주세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage("BOM"+_pMSG_INPUT_DATA);
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

        private void BOMData_Delete_Save()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                isError = new ProductBOMRegister_T50Business().ProductBOMRegister_T50_Info_Enable(_pProductBOMRegister_T50Entity);

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
                    _pProductBOMRegister_T50Entity.CRUD = "R";

                    _pProductBOMRegister_T50Entity.PART_CODE = _luPART_CODE.Text; // 
                    _pProductBOMRegister_T50Entity.PART_NAME = _luPART_NAME.Text; 

                    _pProductBOMRegister_T50Entity.USE_YN = _luT_USE_YN.GetValue();

                    MainFind_DisplayData();

                    treeList1.ClearNodes();

                    _luREVISION_NO.Text = "";
                    //_luPART_MST.CodeText = "";
                    //_luPART_MST.NameText = "";
                    _luUSE_YN.ItemIndex = 0;

                    //_ckCOPY.Checked = false;

                    SubFind_DisplayData();

                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                
                _pProductBOMRegister_T50Entity.PART_CODE_MST = "";
                _pProductBOMRegister_T50Entity.REVISION_NO = "";
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
            bool pErrorYN = false;
            string pErrName = string.Empty;

            try
            {
                //if (_luREVISION_NO.Text == "")
                //    pErrName += _lciREVISION_NO.Text.ToString() + ". ";
             
                if (pErrName != "")
                {
                    pErrorYN = true;
                    //DisplayMessage(pErrName);

                    CoFAS_DevExpressManager.ShowInformationMessage(pErrName + " " + _pMSG_CHECK_VALID_ITEM);

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


        //자재조회
        private void _ucbtSUB_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pProductBOMRegister_T50Entity.CRUD = "R";
                SubFind_DisplayData();

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

        #region 18.06.08 트리리스트 관련 
        private void CreateDataTable()
        {
            dtTL.Columns.Add(new DataColumn("PART_CODE_MST", typeof(string)));
            dtTL.Columns.Add(new DataColumn("REVISION_NO", typeof(string)));

            dtTL.Columns.Add(new DataColumn("PART_CODE", typeof(string)));
            dtTL.Columns.Add(new DataColumn("PART_NAME", typeof(string)));
            dtTL.Columns.Add(new DataColumn("P_PART_CODE", typeof(string)));
            dtTL.Columns.Add(new DataColumn("PART_QTY", typeof(decimal)));
            dtTL.Columns.Add(new DataColumn("NODE_LEVEL", typeof(int)));
            dtTL.Columns.Add(new DataColumn("NODE_ID", typeof(int)));

            //부모 , 현재기, 자식 노드ID
            dtTL.Columns.Add(new DataColumn("ParentNode_ID", typeof(string)));
            dtTL.Columns.Add(new DataColumn("NOWNode_ID", typeof(string)));
            dtTL.Columns.Add(new DataColumn("CHILDNODE_ID", typeof(string)));


            //트리구조
            dtTL.Columns.Add(new DataColumn("PART_CODE2", typeof(string)));
            dtTL.Columns.Add(new DataColumn("P_PART_CODE2", typeof(string)));

            // dtTL.Columns.Add(new DataColumn("OLD_P_PART_CODE", typeof(string)));
            //dtTL.Columns.Add(new DataColumn("OLD_NODE_LEVEL", typeof(int)));
            //dtTL.Columns.Add(new DataColumn("OLD_NODE_ID", typeof(int)));

            dtTL.Columns.Add(new DataColumn("USE_YN", typeof(string)));

            dtTL.Columns.Add(new DataColumn("PART_TYPE", typeof(string)));
        }

        private void DataRowADD(TreeListNode node, string strPART_CODE_MST, string strREVISION_NO)
        {
            drTL = dtTL.NewRow();

            drTL["PART_CODE_MST"] = strPART_CODE_MST;
            drTL["REVISION_NO"] = strREVISION_NO;

            drTL["PART_CODE"] = node.GetDisplayText(part_code);
            drTL["PART_NAME"] = node.GetDisplayText(part_name);
            drTL["P_PART_CODE"] = node.ParentNode == null ? node.GetDisplayText(part_code) : node.ParentNode.GetDisplayText(part_code);
            drTL["PART_QTY"] = node.GetValue(part_qty);
            drTL["NODE_LEVEL"] = node.Level;
            drTL["NODE_ID"] = iTreeNodeIndex; // node.Id;

            drTL["ParentNode_ID"] = node.ParentNode == null ? "0" : node.ParentNode.Id.ToString();
            drTL["NOWNode_ID"] = node.Id.ToString();
            drTL["CHILDNODE_ID"] = node.NextNode == null ? "0" : node.NextNode.Id.ToString();


            drTL["PART_CODE2"] = string.Format("{0}{1}",(node.Level.ToString()), iTreeNodeIndex.ToString());
            
            drTL["P_PART_CODE2"] = node.ParentNode == null ? drTL["PART_CODE2"].ToString() : node.ParentNode.Id.ToString();

            // drTL["OLD_P_PART_CODE"] = node.GetDisplayText(p_part_code);
            //drTL["OLD_NODE_LEVEL"] = node.GetValue(part_lvl) == null ? "" : node.GetValue(part_lvl);
            //drTL["OLD_NODE_ID"] = node.GetValue(part_dsp_seq) == null ? "" : node.GetValue(part_dsp_seq);

            drTL["USE_YN"] = node.GetValue(use_yn);
            drTL["PART_TYPE"] = node.GetValue(part_type);
            dtTL.Rows.Add(drTL);
        }

        private void SelectChildNodes(TreeListNode node, string strPART_CODE_MST, string strREVISION_NO)
        {
            string p_part_code = strPART_CODE_MST;
            string p_part_code2 = dtTL.Rows[0]["PART_CODE2"].ToString();

            foreach (TreeListNode childNode in node.Nodes)
            {
                iTreeNodeIndex += 1;
              
                DataRowADD(childNode, strPART_CODE_MST, strREVISION_NO);
                if (childNode.HasChildren)
                    SelectChildNodes(childNode, strPART_CODE_MST, strREVISION_NO);
            }
        }

        #endregion

        private void _ucbtPART_SEARCH_Click(object sender, EventArgs e)
        {
            _pProductBOMRegister_T50Entity.CRUD = "R";

            SubFind_DisplayData();
        }

        private void _luPART_MST__OnOpenClick(object sender, EventArgs e)
        {
            try
            {
                /*
                if (_ckCOPY.Checked)
                {

                    frmCommonPopup.CRUD = "R";
                    frmCommonPopup.USER_CODE = _pUSER_CODE;
                    frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                    frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

                    // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
                    frmCommonPopup.ARRAY = new object[2] { "Product_Code_R", "" };
                    frmCommonPopup.ARRAY_CODE = new object[2] { _luPART_MST.CodeText.ToString(), _luPART_MST.NameText.ToString() };
                    frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분

                    xfrmCommonPopup.ShowDialog();

                    if (xfrmCommonPopup.dtReturn == null)
                    {
                        xfrmCommonPopup.Dispose();
                        return;
                    }

                    if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
                    {
                        _luPART_MST.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                        _luPART_MST.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();
                        
                      //  treeList1.Nodes[0].SetValue(0, _luPART_MST.CodeText.ToString());
                      //  treeList1.Nodes[0].SetValue(1, _luPART_MST.NameText.ToString());
                    }

                    xfrmCommonPopup.Dispose();
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_BOM_COPY_CHECK);
                }
                */
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void _ckCOPY_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if(_ckCOPY.Checked)
            {
              if( CoFAS_DevExpressManager.ShowQuestionMessage (_pMSG_REVISION_INIT) == DialogResult.Yes )
                {
                    _luREVISION_NO.Text = "";
                }
              else
                {
                    _ckCOPY.Checked = false;
                }
            }
            */
        }



        #region Tree Event Manager
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



            switch (_pProductBOMRegister_T50Entity.LANGUAGE_TYPE)
            {
                case "한국어" :
                    treeList1.Columns[0].Caption = "품목코드";
                    treeList1.Columns[1].Caption = "품목명";
                    treeList1.Columns[2].Caption = "파트 수량";
                    treeList1.Columns[3].Caption = "품목 단위";
                    break;

                case "日本":
                    treeList1.Columns[0].Caption = "製品番号"; //기존 商品番号
                    treeList1.Columns[1].Caption = "製品名"; //기존 商品名
                    treeList1.Columns[2].Caption = "部品数"; //기존  パート数
                    treeList1.Columns[3].Caption = "アイテム単位";
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
                //'노드삭제'메뉴 생성
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
                if (Convert.ToInt32(dragNode.GetValue("part_type")) > Convert.ToInt32(targetNode.GetValue("part_type")))
                {
                    e.Effect = DragDropEffects.Move;
                    
                }
                else
                {
                    _dragRowCursor = Cursors.No;
                    DisplayMessage(_pMSG_PART_NOT_SUB);
                    //DisplayMessage("下に登録することはできません。");

                }

                
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

                    if (row["part_type"].ToString() != "1001")
                    {
                        MessageBox.Show(_pMSG_PART_NOT_OTHER);
                        //MessageBox.Show("製品のみ登録");
                        return;
                    }

                    if (row["used_configuration"].ToString() == "Y")
                    {
                        //  MessageBox.Show(_pMSG_PART_ALREADY_BOM);
                        MessageBox.Show("이미 구성된 제품 입니다.");
                        //MessageBox.Show("構成された製品");
                        return;
                    }

                    //if (row["use_yn"].ToString() == "N")
                    //{
                    //    MessageBox.Show("사용 중지된 제품 입니다.");
                    //    return;
                    //}

                    //if (row["checkd_dnd"].ToString() == "Y")
                    //{
                    //    return;
                    //}

                    //                                 품목코드(part_code)          품목명(part_name)           수량  단위 lvl seq  path 부모yn              
                    treeList.AppendNode(new object[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), "0", "", "0", "0", "", "", "Y", row.ItemArray[3].ToString(), null, null, row["part_type"].ToString() }, null);
                    
                }
                else
                {
                    if (hitInfo.HitInfoType != HitInfoType.Cell)
                    {
                        return;
                    }

                    if (targetNode.GetDisplayText("part_code") == row.ItemArray[0].ToString())
                    {
                        MessageBox.Show(_pMSG_PART_SAME_CODE); //登録することができません
                        //MessageBox.Show("登録することができません"); //
                        return;
                    }

                    if (row["part_type"].ToString() == "1001")
                    {
                        MessageBox.Show(_pMSG_PRODUCT_NOT_SUB);
                        //MessageBox.Show("下に登録することはできません。");
                        return;
                    }

                    // if (Convert.ToInt32(targetNode.GetDisplayText("part_code").Substring(0, 1)) > Convert.ToInt32(row.ItemArray[0].ToString().Substring(0, 1)))
                    if (Convert.ToInt32(targetNode.GetValue(part_type)) > Convert.ToInt32(row["part_type"].ToString()))
                    {
                        MessageBox.Show(_pMSG_PART_NOT_SUB);
                        //MessageBox.Show("下に登録することはできません。");
                        return;
                    }


                    //if ((Convert.ToInt32(targetNode.GetDisplayText("part_code").Substring(0, 1)) >= 3) && (Convert.ToInt32(row.ItemArray[0].ToString().Substring(0, 1)) >= 3))
                    if ((Convert.ToInt32(targetNode.GetValue(part_type)) >= 1004) && (Convert.ToInt32(row["part_type"].ToString()) >= 1004))
                    {
                        MessageBox.Show(_pMSG_PART_NOT_SUB);
                        //MessageBox.Show("下に登録することはできません。");
                        return;
                    }

                    //if ( targetNode.GetDisplayText("part_code").Substring(0, 1) == "2" && targetNode.GetDisplayText("used_configuration") == "Y")
                    if (targetNode.GetValue(part_type).ToString() == "1003" && targetNode.GetDisplayText("used_configuration") == "Y")
                    {
                        MessageBox.Show(_pMSG_SEMI_PART_NOT_REG);
                        //MessageBox.Show("下に登録することはできません。");
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
                            if (targetNode.Nodes[a].GetDisplayText("part_code") == row.ItemArray[0].ToString())
                            {
                                MessageBox.Show(row.ItemArray[0].ToString() +" " + _pMSG_LEVEL_SAME_NOT);
                                //MessageBox.Show(row.ItemArray[0].ToString() + " 登録することができません");
                                return;
                            }
                        }
                    }
                   


                    //하위 품목 있는지 확인 필요.
                    _pProductBOMRegister_T50Entity.PART_CODE = row.ItemArray[0].ToString();
                    DataTable dtCheck = BOM_Configuration_FindData();
                    string str_P_NODE = "";
                    if (dtCheck != null && dtCheck.Rows.Count > 0)
                    {
                        treeList.AppendNode(new object[] { dtCheck.Rows[0]["part_code"].ToString(), dtCheck.Rows[0]["part_name"].ToString(), dtCheck.Rows[0]["part_qty"].ToString(), "", (targetNode.Level + 1).ToString(), (targetNode.Id + 1).ToString(), "", "", "Y", "", "", dtCheck.Rows[0]["used_configuration"].ToString(), dtCheck.Rows[0]["part_type"].ToString() }, targetNode);

                        //20181204 하위 차일드 안가져오게 수정 나중에 가져오는 방식으로 수정 예정
                        //for(int a = 0; a < dtCheck.Rows.Count; a++)
                        //{
                        //    if (a > 0)
                        //    {
                        //        TreeListNode myNode = treeList.FindNode((node) => { return node["part_code"].ToString() == dtCheck.Rows[a]["p_part_code"].ToString(); });

                        //        //TreeListNode myNode = treeList.FindNode((node) => { return node.Id.ToString() == node.ParentNode.Id.ToString(); });

                        //        treeList.AppendNode(new object[] { dtCheck.Rows[a]["part_code"].ToString(), dtCheck.Rows[a]["part_name"].ToString(), dtCheck.Rows[a]["part_qty"].ToString(), "", (myNode.Level + 1).ToString(), (myNode.Id + 1).ToString(), "", "", "Y", dtCheck.Rows[a]["used_configuration"].ToString() }, myNode);
                        //    }
                        //    else
                        //    {
                        //        treeList.AppendNode(new object[] { dtCheck.Rows[a]["part_code"].ToString(), dtCheck.Rows[a]["part_name"].ToString(), dtCheck.Rows[a]["part_qty"].ToString(), "", (targetNode.Level + 1).ToString(), (targetNode.Id + 1).ToString(), "", "", "Y","","", dtCheck.Rows[a]["used_configuration"].ToString() }, targetNode);


                        //    }

                        //}
                    }
                    else
                    {
                        treeList.AppendNode(new object[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), "0", "", (targetNode.Level + 1).ToString(), (targetNode.Id + 1).ToString(), "", "", "Y", row.ItemArray[3].ToString() , null, null, row["part_type"].ToString() }, targetNode);
                    }
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

                //if (Convert.ToInt32(dragNode.GetDisplayText("part_code").Substring(0, 1)) > Convert.ToInt32(targetNode.GetDisplayText("part_code").Substring(0, 1)))
                if (Convert.ToInt32(dragNode.GetValue("part_type")) > Convert.ToInt32(targetNode.GetValue("part_type")))
                {
                    treeList.MoveNode(dragNode, targetNode, true);
                    treeList.SetNodeIndex(dragNode, index);
                    e.Effect = DragDropEffects.None;
                }
                else
                {
                    _dragRowCursor = Cursors.No;
                    DisplayMessage(_pMSG_PART_NOT_SUB); 

                    //DisplayMessage("下に登録することはできません。"); 
                }
            }


        }
        #endregion
    }
}
