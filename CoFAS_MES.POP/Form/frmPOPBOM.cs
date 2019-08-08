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
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Entity;

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using CoFAS_MES.CORE.Business;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.UserForm;
using DevExpress.XtraTreeList;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList.Nodes;
using System.IO;

namespace CoFAS_MES.POP
{
    public partial class frmPOPBOM : frmBaseSingle
    {

        private string _pCORP_CODE = string.Empty;       // 회사코드       
        private string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private string _pUSER_NAME = string.Empty;       // 사용자이름
        private string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        private string _pPART_CODE = string.Empty;
        private string _pPART_NAME = string.Empty;
        private string _pFONT_TYPE = "굴림"; //string.Empty;       // 시스템 폰트 타입 설정
        private int _pFONT_SIZE = 15;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;              // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
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



        private POPProductBOMEntity _pPOPProductBOMEntity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        private DataTable _dtBOMCheckList = null;
        private int select_row_handle = 0;
 //       public System.Windows.Forms.TreeNode Parent { get; }

        private int active_row = 0;

        private string Image_nm = null;
        private string common = null;

        private DataTable dtTL = new DataTable("TreeListData"); //treelist 저장 처리 데이터 테이블
        private DataRow drTL = null; // treelist 저장 처리 데이터 로우
        public int iTreeNodeIndex = 0;


        public UserEntity _pUserEntity = null;

        private DataTable _dtreturn = new DataTable();

        /// <summary>
        /// 메인 폼
        /// </summary>
        public IMainForm MainForm
        {
            get
            {
                return MdiParent as IMainForm;
            }
        }



        public DataTable dtReturn
        {
            get
            {
                return _dtreturn;

            }
            set
            {
                _dtreturn = value;
            }

        }

        public frmPOPBOM(UserEntity pUserEntity, string code)
        {
            InitializeComponent();

            _pUserEntity = pUserEntity;
            _pPART_CODE = code;
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

                //if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                //{
                //    pFormClosingEventArgs.Cancel = true;
                //    return;
                //}

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
                //dxWaitViewManager.ShowWaitForm();
                InitializeSetting();
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

                

                //버튼이벤트 생성 (POP는 없으므로 사용하지 않음)

                //SearchButtonClicked += new EventHandler(Form_SearchButtonClicked);
                //SaveButtonClicked += new EventHandler(Form_SaveButtonClicked);
                //AddItemButtonClicked += new EventHandler(Form_AddItemButtonClicked);
                //DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
                //PrintButtonClicked += new EventHandler(Form_PrintButtonClicked);
                //ExportButtonClicked += new EventHandler(Form_ExportButtonClicked);
                //ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                //InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                //SettingButtonClicked += new EventHandler(Form_SettingButtonClicked);

                //FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);
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

                //메인 화면 전역 변수 처리
                _pCORP_CODE = _pUserEntity.CORP_CODE;
                _pUSER_CODE = _pUserEntity.USER_CODE;
                _pUSER_NAME = _pUserEntity.USER_NAME;
                _pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = _pUserEntity.FONT_TYPE;
                _pFONT_SIZE = _pUserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                _pFTP_ID= _pUserEntity.FTP_ID;
                _pFTP_PATH = _pUserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                _pFTP_PW = _pUserEntity.FTP_PW;



                _pWINDOW_NAME = this.Name;
                _pUSER_CODE = _pUserEntity.USER_CODE;
                _pUSER_NAME = _pUserEntity.USER_NAME;
                _pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = _pUserEntity.FONT_TYPE;
                _pFONT_SIZE = _pUserEntity.FONT_SIZE;
                //메뉴 화면 엔티티 설정
                _pPOPProductBOMEntity = new POPProductBOMEntity();
                _pPOPProductBOMEntity.CORP_CODE = _pUserEntity.CORP_CODE;
                _pPOPProductBOMEntity.USER_CODE = _pUserEntity.USER_CODE;
                _pPOPProductBOMEntity.LANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _pPOPProductBOMEntity.PART_CODE = _pPART_CODE;
                // _pPOPProductBOMEntity.RESOURCE_CODE = _pUserEntity.RESOURCE_CODE;

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

                ////여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                //_pSampleRegisterEntity.CRUD = "";
                //if (_pFirstYN)
                //{
                BOMFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                //    _pFirstYN = false;
                //}

                //SubFind_DisplayData("", ""); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                //_gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                //그리드 버튼추가 시 클릭 이벤트 처리 
                //CoFAS_DevExpressManager._OnButtonPressed += CoFAS_DevExpressManager__OnButtonPressed;
                //CoFAS_DevExpressManager._OnOpenButton += CoFAS_DevExpressManager__OnOpenButton;
                // CoFAS_DevExpressManager._OnOpenClick += CoFAS_DevExpressManager__OnOpenClick;
                //CoFAS_DevExpressManager._OnDownloadClick += CoFAS_DevExpressManager__OnDownloadClick;
                // CoFAS_DevExpressManager._OnDeleteClick += CoFAS_DevExpressManager__OnDeleteClick;


                //CoFAS_ControlManager.SetFontInControls(this.Controls, new Font("Arial", 8, FontStyle.Bold));





            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }



        private void CoFAS_DevExpressManager__OnOpenButton(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Caption.ToString())
            {
                case "TESTBUTN": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.

                    switch (e.Button.Index)
                    {
                        case 0:
                            MessageBox.Show("TESTBUTN 오픈");


                            break;
                        case 1:
                            MessageBox.Show("TESTBUTN 다운로드");


                            break;
                        case 2:
                            MessageBox.Show("TESTBUTN 삭제");


                            break;
                    }
                    break;

            }
        }


        #endregion

        #region ○ 버튼 초기화 하기 - InitializeButtons()

        private void InitializeButtons()
        {
            try
            {
                //MainFormButtonSetting pButtonSetting = new MainFormButtonSetting();

                //pButtonSetting.UseYNSearchButton = _pMenuSettingEntity.MENU_SEARCH == "Y" ? true : false; // 조회
                //pButtonSetting.UseYNExportButton = _pMenuSettingEntity.MENU_EXPORT == "Y" ? true : false; // 내보내기
                //pButtonSetting.UseYNImportButton = _pMenuSettingEntity.MENU_IMPORT == "Y" ? true : false; // 가져오기
                //pButtonSetting.UseYNPrintButton = _pMenuSettingEntity.MENU_PRINT == "Y" ? true : false; // 프린터
                //pButtonSetting.UseYNSaveButton = _pMenuSettingEntity.MENU_SAVE == "Y" ? true : false; // 저장
                //pButtonSetting.UseYNAddItemButton = _pMenuSettingEntity.MENU_ADDITEM == "Y" ? true : false; // 신규
                //pButtonSetting.UseYNDeleteButton = _pMenuSettingEntity.MENU_DELETE == "Y" ? true : false; // 삭제

                //pButtonSetting.UseYNInitialButton = true; // 초기화
                //pButtonSetting.UseYNSettingButton = true; // 설정
                //pButtonSetting.UseYNFormCloseButton = true; // 폼닫기

                //MainForm.SetButtonSetting(pButtonSetting);

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
                    //_gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                }

                //_gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pWINDOW_NAME, _gdSUB.Name.ToString()));
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            SetUpTreeList();
            CreateDataTable();
        }


        #endregion

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl()
        {
            try
            {



                //조회조건 영역 
                //_luT_WINDOW_NAME.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "MENU_LIST", "", "", "").Tables[0], 0, 0, "");
                //_luT_USE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");

                //데이터 영역
                //_luWINDOW_NAME.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "MENU_LIST", "", "", "").Tables[0], 0, -1, "");
                //_luWINDOW_NAME.ReadOnly = false;

                //_luGRID_NAME.Text = "";
                //_luGRID_NAME.ReadOnly = false;

                //_luGRIDVIEW_NAME.Text = "";
                //_luGRIDVIEW_NAME.ReadOnly = false;

                //_luEDIT_ABLE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "COMMON_CODE", "CD99", "", "").Tables[0], 0, 0, "");
                //_luEDITOR_SHOWMODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return(_pCORP_CDDE, "R", "COMMON_CODE", "MM20", "", "").Tables[0], 0, 0, "");


                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                //dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                //dxValidationProvider.Validate();

                //dxValidationProvider.SetValidationRule(_luGRID_NAME, NotEmptyValidationRule);
                //dxValidationProvider.SetValidationRule(_luGRIDVIEW_NAME, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    //_gdMAIN.DataSource = null;
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


        private void gdMAIN_VIEW_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            //if (((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused) != 0) && ((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.GridFocused) != 0))
            //    e.Appearance.Assign(view.PaintAppearance.FocusedRow);
            if (view.FocusedRowHandle == e.RowHandle)
            {
                e.Appearance.BackColor = Color.Orange;
                e.Appearance.ParentAppearance.BackColor = Color.Orange;
            }
            
        }

        public void SetUpTreeList()
        {
            /// 트리 리스트 폰트 설정
            Font fntHeader = new Font(_pFONT_SETTING.FontFamily, _pFONT_SETTING.Size + 2, FontStyle.Bold);
            Font fntRow = _pFONT_SETTING;

            //_dragRowCursor = Cursors.Default;

            /// 트리 리스트 설정 영역
            treeList1.AllowDrop = true; // 트리 리스트 항상 Drop 기능 활성화 유무

            treeList1.Appearance.HeaderPanel.Font = fntHeader; // 트리 리스트 헤더 데이터 패널 폰트
            treeList1.Appearance.Row.Font = fntRow; // 트리 리스트 로우 데이터 폰트

            treeList1.Appearance.Row.FontSizeDelta = 10;

            treeList1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // 트리 리스트 헤더 데이터 정렬 가로
            treeList1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center; // 트리 리스트 헤더 데이터 정렬 가로

            treeList1.Appearance.OddRow.BackColor = Color.Empty;// Color.LightSteelBlue; // 트리 리스트 홀수 줄 색상
            treeList1.Appearance.FocusedRow.BackColor = Color.LightYellow; // 트리 리스트 선택 로우 색상
            

            treeList1.OptionsView.EnableAppearanceOddRow = true; // 트리 리스트 홀수 줄 색상 변경 유무
            //treeList1.OptionsView.AutoWidth = true; // 트리 리스트 컬럼 사이즈 조정 자동 유무
            treeList1.OptionsView.ShowIndentAsRowStyle = true;
            treeList1.OptionsView.ShowIndicator = true;
            
            treeList1.RowHeight = 20; // 트리 리스트 줄 높이 설정
            //treeList1.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Single;    



            switch (_pPOPProductBOMEntity.LANGUAGE_TYPE)
            {
                case "한국어":
                    treeList1.Columns[0].Caption = "품목코드";
                    treeList1.Columns[1].Caption = "파일명";
                    treeList1.Columns[2].Caption = "품목명";
                    treeList1.Columns[3].Caption = "수량";
                    treeList1.Columns[4].Caption = "단위";
                    treeList1.Columns[5].Caption = "파일이미지";
                    break;

                case "日本":
                    treeList1.Columns[0].Caption = "商品番号";
                    treeList1.Columns[1].Caption = "商品名";
                    treeList1.Columns[2].Caption = "パート数";
                    treeList1.Columns[3].Caption = "アイテム単位";
                    break;

            }

            ///// 트리 리스트 이벤트 영역
            //treeList1.DragOver += treeList_DragOver;
            //treeList1.DragDrop += treeList_DragDrop;
            //treeList1.MouseMove += treeList_MouseMove;
            //treeList1.MouseDown += treeList_MouseDown;
            //treeList1.MouseUp += treeList_MouseUp;
            //treeList1.GiveFeedback += treeList_GiveFeedback;
        }
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

            // dtTL.Columns.Add(new DataColumn("OLD_P_PART_CODE", typeof(string)));
            // dtTL.Columns.Add(new DataColumn("OLD_NODE_LEVEL", typeof(int)));
            // dtTL.Columns.Add(new DataColumn("OLD_NODE_ID", typeof(int)));

            dtTL.Columns.Add(new DataColumn("USE_YN", typeof(string)));
        }

        private void BOMFind_DisplayData()
        {
            try
            {
                Image image = null;
                
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new POPProductBOMCommonBusiness().POPProductBOM_Info(_pPOPProductBOMEntity);
                
                treeList1.ClearNodes();
                byte[] rawData;

                
                //(byte[])_dtList.Rows[i]["file_image"],
                if (_dtList != null && _dtList.Rows.Count > 0)
                {
                    _dtBOMCheckList = null;
                    _dtBOMCheckList = _dtList;

                    for (int i = 0; _dtList.Rows.Count > i; i++)
                    {
                        rawData = (byte[])_dtList.Rows[i]["file_image"];

                        if (rawData.Length > 0)
                        {
                            
                            MemoryStream ms = new MemoryStream(rawData);
                            image = Image.FromStream(ms, true);
                           
                        }
                        else
                        {
                            image = null;
                        }

                        if (treeList1.AllNodesCount == 0)
                        {
                            
                            treeList1.AppendNode(new object[] { _dtList.Rows[i]["ID"].ToString(), _dtList.Rows[i]["file_name"].ToString(), _dtList.Rows[i]["part_name"], _dtList.Rows[i]["part_qty"], _dtList.Rows[i]["part_unit_name"], image, "0", _dtList.Rows[i]["part_dsp_seq"], "", _dtList.Rows[i]["ParentID"], _dtList.Rows[i]["use_yn"], _dtList.Rows[i]["used_configuration"], _dtList.Rows[i]["part_code2"], _dtList.Rows[i]["p_part_code2"] }, null);

                        }
                        else
                        {
                            treeList1.AppendNode(new object[] { _dtList.Rows[i]["ID"].ToString(), _dtList.Rows[i]["file_name"].ToString(), _dtList.Rows[i]["part_name"], _dtList.Rows[i]["part_qty"], _dtList.Rows[i]["part_unit_name"], image, _dtList.Rows[i]["part_lvl"], _dtList.Rows[i]["part_dsp_seq"], _dtList.Rows[i]["cur_path"].ToString(), _dtList.Rows[i]["ParentID"].ToString(), _dtList.Rows[i]["use_yn"], _dtList.Rows[i]["used_configuration"], _dtList.Rows[i]["part_code2"], _dtList.Rows[i]["p_part_code2"] }, treeList1.FindNodeByFieldValue("part_code2", _dtList.Rows[i]["p_part_code2"]));

                        }
                        
                        
                    }
                
                    treeList1.ForceInitialize();
                    treeList1.ExpandAll();
                    treeList1.BestFitColumns();
                    treeList1.RowHeight = 100;

                    treeList1.Columns[0].Width = 320;
                    treeList1.Columns[1].Width = 300;
                    treeList1.Columns[2].Width = 400;
                    treeList1.Columns[3].Width = 100;
                    treeList1.Columns[4].Width = 80;
                    treeList1.Columns[5].Width = 350;

                    treeList1.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    treeList1.Columns[1].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;                   
                    treeList1.Columns[3].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    treeList1.Columns[4].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    treeList1.Columns[5].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                    treeList1.Parent.Tag = "OddRow";
                    //트리에서 컬럼 수정가능하게
                    treeList1.OptionsBehavior.Editable = false;
                    treeList1.Appearance.OddRow.BackColor = Color.White;
                    treeList1.BestFitColumns();
         
                }
              

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                //_gdMAIN_VIEW.BestFitColumns();

                _pPOPProductBOMEntity.CRUD = "U";
                _pPOPProductBOMEntity.PART_CODE = "";

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }

            
        }


        #region ○ 버튼 클릭시

        private void btnCmd_Click(object pSender, EventArgs pEventArgs)
        {
            TreeListMultiSelection selectedNodes = treeList1.Selection;
            SimpleButton pCmd = pSender as SimpleButton;
            int Acitve_Row = 0;

            

            string sCls = pCmd.Name.Substring(6, 2);

            switch (sCls)
            {
                case "10":

                    treeList1.MoveFirst();
                        break;
                    

                case "20":

                    treeList1.MovePrev();
                     break;


               
                    case "30":

                    _pPART_CODE = selectedNodes[0].GetValue(treeList1.Columns[0]).ToString();
                    _pPOPProductBOMEntity.PART_CODE = _pPART_CODE;
                    _pPART_NAME = selectedNodes[0].GetValue(treeList1.Columns[1]).ToString();
                    _pPOPProductBOMEntity.PART_NAME = _pPART_NAME;

                    try
                    {
                        CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                        _dtList = new POPProductBOMCommonBusiness().POPProductBOM_Image_Info(_pPOPProductBOMEntity);

                        if (_pPOPProductBOMEntity.CRUD == "") _dtList.Rows.Clear();

                        if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pPOPProductBOMEntity.CRUD == ""))
                        {
                            string Image_nm2 = _dtList.Rows[0]["file2"].ToString();
                            Image_nm = _dtList.Rows[0]["file1"].ToString();
                            string document_type = _dtList.Rows[0]["Document_type"].ToString();                           

                            if (Image_nm.Contains(".pdf"))
                            {
                                

                                if (Image_nm.IndexOf("*NoSave*") > -1 || Image_nm.Trim().Length < 4)
                                {
                                    //CoFAS_DevExpressManager.ShowInformationMessage("저장하지 않아서 볼 수 없습니다.");
                                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_DISPLAY_NOT_SAVE);
                                }
                                else
                                {
                                    MemoryStream STR = null;
                                    string strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "FILE_DATA", document_type);

                                    var stream = CoFAS_FTPManager.FTPImage(strFTP_PATH, Image_nm2, _pFTP_ID, _pFTP_PW);

                                    MemoryStream _ms = new MemoryStream();

                                    byte[] buffer = new byte[16 * 1024];
                                    int read;
                                    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                                    {
                                        _ms.Write(buffer, 0, read);
                                    }

                                    frmPdfView_bumah.CORP_CDDE = _pCORP_CODE;
                                    frmPdfView_bumah.USER_CODE = _pUSER_CODE;
                                    frmPdfView_bumah.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                                    frmPdfView_bumah.FONT_TYPE = _pFONT_SETTING;
                                    frmPdfView_bumah.MS = _ms;

                                    

                                    frmPdfView_bumah xfrmImageView = new frmPdfView_bumah(); //유저컨트롤러 설정 부분

                                    xfrmImageView.ShowDialog();

                                    xfrmImageView.Dispose();


                                    
                                }

                            }
                            else
                            {
                                if (Image_nm2.IndexOf(" * NoSave*") > -1 || Image_nm2.Trim().Length < 4)
                                {
                                    //CoFAS_DevExpressManager.ShowInformationMessage("저장하지 않아서 볼 수 없습니다.");
                                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_NOT_DISPLAY_NOT_SAVE);
                                }
                                else
                                {
                                    string strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "FILE_DATA", document_type);



                                    frmImageView_buma.CORP_CDDE = _pCORP_CODE;
                                    frmImageView_buma.USER_CODE = _pUSER_CODE;
                                    frmImageView_buma.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                                    frmImageView_buma.FONT_TYPE = _pFONT_SETTING;
                                    frmImageView_buma.IMAGE_DATA = Image.FromStream(CoFAS_FTPManager.FTPImage(strFTP_PATH, Image_nm2, _pFTP_ID, _pFTP_PW));

                                    frmImageView_buma xfrmImageView = new POP.frmImageView_buma(Image_nm2, _pPART_NAME); //유저컨트롤러 설정 부분

                                    xfrmImageView.ShowDialog();

                                    xfrmImageView.Dispose();
                                }
                            }
                        }
                    }
                    catch (ExceptionManager pExceptionManager)
                    {
                        CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
                    }

                    break;

                case "40":

                    treeList1.MoveNext();
           
                    break;

                case "50":

                    treeList1.MoveLast();
                    break;

                default: break;
            }


        }

        #endregion


    }
}

