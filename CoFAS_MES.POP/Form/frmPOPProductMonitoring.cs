﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Entity;

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace CoFAS_MES.POP
{
    public partial class frmPOPProductMonitoring : frmBaseSingle
    {
        private System.Threading.Timer tmrTime; //시간 타이머 스레드
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); //시간 타이머 스레드

        private string _pCORP_CODE = string.Empty;       // 회사코드       
        private string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private string _pUSER_NAME = string.Empty;       // 사용자이름
        private string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        private string _pFONT_TYPE = "굴림"; //string.Empty;       // 시스템 폰트 타입 설정
        private int _pFONT_SIZE = 20;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;              // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보
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

        private UserEntity _pUserEntity = null; // 시스템 사용 사용자 엔티티
        private POPProductMonitoringEntity _pPOPProductMonitoringEntity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private bool _pFirstYN = true;    // 최초실행여부 최초 설정 에서만 사용

        private int select_row_handle = 0;

        private int active_row = 0;

        private string common = null;

        public UserEntity UserEntity
        {
            get
            {
                return _pUserEntity;
            }
            set
            {
                _pUserEntity = value;
            }
        }



        private DataTable _dtreturn = new DataTable();

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

        public frmPOPProductMonitoring(UserEntity pUserEntity)
        {
            InitializeComponent();

            _pUserEntity = pUserEntity;

            // 접속 시간 업데이트
            CoFAS_ControlManager.InvokeIfNeeded(_lbStartTime, () => _lbStartTime.Text = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTime));
            tmrTime = new System.Threading.Timer(new TimerCallback(Up_Date_Time), null, 0, 1000);

            // timer : 1분
            timer.Enabled = true;
            timer.Interval = 60000;
            timer.Tick += new EventHandler(time_tick);
            timer.Start();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        #region ○ Up_Date_Time, time_tick : 현재시간 업데이트, 메인조회
        private void time_tick(object sender, EventArgs e)
        {
            MainFind_DisplayData();
        }
      
       
        private void Up_Date_Time(object obj)
        {
            CoFAS_ControlManager.InvokeIfNeeded(_lbCurrentTime, () => _lbCurrentTime.Text = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTime));
        }
        #endregion

        //폼 이벤트 처리 영역
        #region ○ Form_Activated
        private void Form_Activated(object pSender, EventArgs pEventArgs)
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

        #region ○ Form_Closing

        private void Form_Closing(object pSender, FormClosingEventArgs pFormClosingEventArgs)
        {
            try
            {


                pFormClosingEventArgs.Cancel = false;
                Application.Exit();
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
                
                Application.Exit();
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
                InitializeCorporationCI();
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
                //_pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                //_pUSER_CODE = MainForm.UserEntity.USER_CODE;
                //_pUSER_NAME = MainForm.UserEntity.USER_NAME;
                //_pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                //_pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                //_pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);
                //_pFTP_ID = MainForm.UserEntity.FTP_ID;
                //_pFTP_IP_PORT = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
                //_pFTP_PW = MainForm.UserEntity.FTP_PW;
                
                //_pUserEntity.LANGUAGE_TYPE = Properties.Settings.Default.MULTI_LANGUAGE.ToString();
                _pWINDOW_NAME = this.Name;
                //_pUSER_CODE = _pUserEntity.USER_CODE;
                //_pUSER_NAME = _pUserEntity.USER_NAME;
                _pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                //_pFONT_TYPE = _pUserEntity.FONT_TYPE;
                //_pFONT_SIZE = _pUserEntity.FONT_SIZE;

                //메뉴 화면 엔티티 설정
                _pPOPProductMonitoringEntity = new POPProductMonitoringEntity();
                _pPOPProductMonitoringEntity.CORP_CODE = _pUserEntity.CORP_CODE;
                _pPOPProductMonitoringEntity.USER_CODE = _pUserEntity.USER_CODE;
                _pPOPProductMonitoringEntity.LANGUAGE_TYPE = "한국어";
                _pPOPProductMonitoringEntity.PROCESS_CODE = _pUserEntity.PROCESS_CODE;
                _pPOPProductMonitoringEntity.RESOURCE_CODE = _pUserEntity.RESOURCE_CODE;

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

                //라벨컨트롤 가운데 정렬
                _lbStartTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                _lbCurrentTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                _lbContract.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                _lbContract_Qty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                _lbProductPlan.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                _lbPlan_QTY.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                _lbProductResult.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                _lbResult_Qty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                //_pSampleRegisterEntity.CRUD = "";
                //if (_pFirstYN)
                //{
                MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

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

                //_gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pWINDOW_NAME, _gdSUB.Name.ToString()));
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

        #region 로고변경하기
        private void InitializeCorporationCI()
        {
            DataTable dtCI = new SystemSettingBusiness().CI_Download();
            if (dtCI != null && (dtCI.Rows[0]["LOGO_FIRST"]).ToString().Length > 0 && (((byte[])dtCI.Rows[0]["LOGO_FIRST"]).Length > 0 && dtCI.Rows.Count > 0))
            {
                if (System.IO.File.Exists(Application.StartupPath + "\\" + "범아기전_CI_531x130.png"))
                {
                    _peCI.Image.Dispose();
                    _peCI.Image = null;
                    System.IO.File.Delete(Application.StartupPath + "\\" + "범아기전_CI_531x130.png");
                }

                Image imgCI = CoFAS_ConvertManager.byteArrayToImage((byte[])dtCI.Rows[0]["LOGO_FIRST"]);
                if (imgCI != null)
                {
                    imgCI.Save(Application.StartupPath + "\\" + "범아기전_CI_531x130.png");
                }
            }

            if (System.IO.File.Exists(Application.StartupPath + "\\" + "범아기전_CI_531x130.png"))
            {
                _peCI.Image = Image.FromFile(Application.StartupPath + "\\" + "범아기전_CI_531x130.png");
            }
            else
            {
                _peCI.Image = Properties.Resources.None;
            }
        }
        #endregion

        private void gdMAIN_VIEW_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused) != 0) && ((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.GridFocused) != 0))
                e.Appearance.Assign(view.PaintAppearance.FocusedRow);
            if (view.FocusedRowHandle == e.RowHandle)
                e.Appearance.BackColor = Color.Orange;
        }

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new POPProductMonitoringBusiness().POPProductMonitoring_Info(_pPOPProductMonitoringEntity);

                if (_pPOPProductMonitoringEntity.CRUD == "") _dtList.Rows.Clear();
                
                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pPOPProductMonitoringEntity.CRUD == ""))
                {
                    
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    
                    _gdMAIN_VIEW.RowHeight = 70;
                    _gdMAIN_VIEW.Appearance.Row.Font = new Font("굴림", 20);
                    _gdMAIN_VIEW.RowStyle += new RowStyleEventHandler(gdMAIN_VIEW_RowStyle);

                    
                    _gdMAIN_VIEW.Columns[2].Visible = false;
                    _gdMAIN_VIEW.Columns[4].Visible = false;
                    _gdMAIN_VIEW.Columns[17].Visible = false;
                    _gdMAIN_VIEW.Columns[18].Visible = false;
                    _gdMAIN_VIEW.Columns[8].Visible = false;
                    _gdMAIN_VIEW.Columns[9].Visible = false;
                    _gdMAIN_VIEW.Columns[10].Visible = false;
                    _gdMAIN_VIEW.Columns[11].Visible = false;
                    _gdMAIN_VIEW.Columns[12].Visible = false;
                    _gdMAIN_VIEW.Columns[13].Visible = false;
                    _gdMAIN_VIEW.Columns[14].Visible = false;

                    _gdMAIN_VIEW.Columns[0].Width = 160;
                    _gdMAIN_VIEW.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    _gdMAIN_VIEW.Columns[1].Width = 250;
                    _gdMAIN_VIEW.Columns[1].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    _gdMAIN_VIEW.Columns[3].Width = 200;
                    _gdMAIN_VIEW.Columns[3].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    _gdMAIN_VIEW.Columns[5].Width = 400;
                    _gdMAIN_VIEW.Columns[6].Width = 150;
                    _gdMAIN_VIEW.Columns[7].Width = 150;
                    _gdMAIN_VIEW.Columns[7].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    _gdMAIN_VIEW.Columns[15].Width = 100;
                    _gdMAIN_VIEW.Columns[16].Width = 100;

                    






                    //for (int i = 0; i < 17; i++)
                    //{
                    //    _gdMAIN_VIEW.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    //};

                    //// 수주(건)
                    //_lbContract_Qty.Text = _dtList.Rows.Count.ToString();

                    //// 생산계획량 합계
                    //double sum = 0;
                    //for(int i = 0; i < _dtList.Rows.Count; i++)
                    //{
                    //    sum = sum + Convert.ToDouble(_dtList.Rows[i][10].ToString());
                    //}

                    //_lbPlan_QTY.Text = sum.ToString();
                    _lbContract_Qty.Text = string.Format("{0:#,###}", Convert.ToInt32(_dtList.Rows[0]["COUNTCONTRACT"].ToString()));



                    _lbPlan_QTY.Text = string.Format("{0:#,###}", Convert.ToInt32(_dtList.Rows[0]["COUNTQTY"].ToString()));

                    // 생산실적량 합계
                    double sum2 = 0;
                    for(int i = 0; i < _dtList.Rows.Count; i++)
                    {
                        sum2 = sum2 + Convert.ToDouble(_dtList.Rows[i][15].ToString());
                    }

                    _lbResult_Qty.Text = sum2.ToString();


                    _gdMAIN_VIEW.Appearance.FocusedRow.BackColor = Color.LightYellow;


                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
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



   
    }
}
