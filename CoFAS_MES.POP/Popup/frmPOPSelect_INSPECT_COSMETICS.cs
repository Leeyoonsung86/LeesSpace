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
using DevExpress.XtraEditors.Repository;

namespace CoFAS_MES.POP
{
    public partial class frmPOPSelect_INSPECT_COSMETICS : frmBaseSingle
    {

        private string _pCORP_CODE = string.Empty;       // 회사코드       
        private string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private string _pUSER_NAME = string.Empty;       // 사용자이름
        private string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        private string _pFONT_TYPE = "굴림"; //string.Empty;       // 시스템 폰트 타입 설정
        private int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;              // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pPRODUCTION_ORDER_ID = string.Empty;       // 사용자 ID (이메일)      

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


        private POPSelect_INSPECT_COSMETICSEntity _pPOPSelect_INSPECT_COSMETICSEntity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

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

        public frmPOPSelect_INSPECT_COSMETICS(UserEntity _pUserEntity)
        {
            InitializeComponent();

            _pCORP_CODE = _pUserEntity.USER_CODE;
            _pUSER_CODE = _pUserEntity.USER_NAME;
            _pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
            _pPRODUCTION_ORDER_ID=_pUserEntity.PRODUCTION_ORDER_ID;
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
                //종료 하겠습니까?
                //if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                // if (CoFAS_DevExpressManager.ShowQuestionMessage("종료 하겠습니까?") == DialogResult.No)
                // {
                //     pFormClosingEventArgs.Cancel = true;
                //     return;
                // }
                pFormClosingEventArgs.Cancel = false;
               // return;


               // pFormClosingEventArgs.Cancel = false;
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



                _pWINDOW_NAME = this.Name;

                //메뉴 화면 엔티티 설정
                _pPOPSelect_INSPECT_COSMETICSEntity = new POPSelect_INSPECT_COSMETICSEntity();
                _pPOPSelect_INSPECT_COSMETICSEntity.CORP_CODE = _pCORP_CODE;
                _pPOPSelect_INSPECT_COSMETICSEntity.USER_CODE = _pUSER_CODE;
                _pPOPSelect_INSPECT_COSMETICSEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
                _pPOPSelect_INSPECT_COSMETICSEntity.PROCESS_CODE   ="";
                _pPOPSelect_INSPECT_COSMETICSEntity.RESOURCE_CODE = "";

                

                _luTPART_NAME.Text ="";
                _luTPART_CODE.Text = "";
                _luTINSPECT_STATUS.Text = "";
                _luTAPPROVAL_YN.Text = "";
                _luTPRODUCTION_ORDER_ID.Text = "";
                _luTPART_NAME.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;

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

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

                //그리드 초기화 

                ////여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
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

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this); //

                //string strWINDOW_NAME = gv.GetFocusedRowCellValue("WINDOW_NAME").ToString();
                //string strGRID_NAME = gv.GetFocusedRowCellValue("GRID_NAME").ToString();
                //
                //_pProductInRegisterEntity.CRUD = "R";
                // SubFind_DisplayData(strWINDOW_NAME, strGRID_NAME);
                _luTPART_NAME.Text = gv.GetFocusedRowCellValue("PART_NAME").ToString();
                //_luTPART_CODE.Text = gv.GetFocusedRowCellValue("PART_CODE").ToString();
                _luTPART_CODE.Text = gv.GetFocusedRowCellValue("VEND_PART_CODE").ToString();
                _luTINSPECT_STATUS.Text = gv.GetFocusedRowCellDisplayText("INSPECT_STATUS").ToString();
                _luTAPPROVAL_YN.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("INSPECT_APPROVAL").ToString() == "" ? _gdMAIN_VIEW.GetFocusedRowCellValue("INSPECT_APPROVAL").ToString() : _gdMAIN_VIEW.GetFocusedRowCellDisplayText("INSPECT_APPROVAL").ToString(); ;// gv.GetFocusedRowCellDisplayText("APPROVAL").ToString();
                _luTPRODUCTION_ORDER_ID.Text = gv.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString();


            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

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


        private void gdMAIN_VIEW_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            // if (((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused) != 0) && ((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.GridFocused) != 0))
            //     e.Appearance.Assign(view.PaintAppearance.FocusedRow);
            if (view.FocusedRowHandle == e.RowHandle)
            {
                e.Appearance.BackColor = Color.Orange;
                e.Appearance.Font = new Font("굴림", 18, FontStyle.Bold);
            }
        }

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new POPSelect_INSPECT_COSMETICSBusiness().POPSelect_INSPECT_COSMETICS_Info(_pPOPSelect_INSPECT_COSMETICSEntity);

                if (_pPOPSelect_INSPECT_COSMETICSEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pPOPSelect_INSPECT_COSMETICSEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    _gdMAIN_VIEW.RowHeight = 80;
                    _gdMAIN_VIEW.Appearance.Row.Font = new Font("굴림", 18);
                    _gdMAIN_VIEW.RowStyle += new RowStyleEventHandler(gdMAIN_VIEW_RowStyle);
                    
                    RepositoryItemMemoEdit noteMemo = new RepositoryItemMemoEdit();
                    noteMemo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                    // noteMemo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    //  noteMemo.apprea
                    _gdMAIN_VIEW.Columns["PART_NAME"].ColumnEdit = noteMemo;
                    this._gdMAIN_VIEW.OptionsView.RowAutoHeight = true;

                    //_gdMAIN_VIEW.Appearance.SelectedRow.Options.UseBackColor = true;
                    //_gdMAIN_VIEW.OptionsSelection.EnableAppearanceFocusedRow = true;
                    //_gdMAIN_VIEW.OptionsView.EnableAppearanceEvenRow = true;
                    //_gdMAIN_VIEW.Appearance.EvenRow.BackColor = Color.Red;

                    //_gdMAIN_VIEW.OptionsSelection.MultiSelect = true;
                    //_gdMAIN_VIEW.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;

                    // _gdMAIN_VIEW.Appearance.FocusedRow.BackColor = Color.Red;



                    if (_pPRODUCTION_ORDER_ID != "")
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("PRODUCTION_ORDER_ID", _pPRODUCTION_ORDER_ID);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        {
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;
                            _luTPART_NAME.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_NAME").ToString();
                            _luTPART_CODE.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_CODE").ToString();
                            _luTINSPECT_STATUS.Text = _gdMAIN_VIEW.GetFocusedRowCellDisplayText("INSPECT_STATUS").ToString();
                            _luTAPPROVAL_YN.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("INSPECT_APPROVAL").ToString() =="" ? _gdMAIN_VIEW.GetFocusedRowCellValue("INSPECT_APPROVAL").ToString() : _gdMAIN_VIEW.GetFocusedRowCellDisplayText("INSPECT_APPROVAL").ToString();
                            _luTPRODUCTION_ORDER_ID.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString();
                        }
                        //_gdMAIN_VIEW.FocusedRowHandle = -1;
                        //조회 후 초기화 
                        _pPRODUCTION_ORDER_ID = "";
                    }

                    //_gdMAIN_VIEW.Appearance.SelectedRow.Options.UseBackColor = true;
                    //_gdMAIN_VIEW.Appearance.SelectedRow.BackColor = Color.LightSeaGreen;

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


        #region ○ 버튼 클릭시

        private void btnCmd_Click(object pSender, EventArgs pEventArgs)
        {
            SimpleButton pCmd = pSender as SimpleButton;
            int Acitve_Row = 0;

            string sCls = pCmd.Name.Substring(6, 2);
            switch (sCls)
            {
                case "10":
                    // 최상위
                    if (_gdMAIN_VIEW.FocusedRowHandle <= _gdMAIN_VIEW.RowCount - 1)
                    {
                        _gdMAIN_VIEW.FocusedRowHandle = 0;
                        Acitve_Row = _gdMAIN_VIEW.FocusedRowHandle;
                        _gdMAIN_VIEW.SelectRow(Acitve_Row);
                    }
                    break;

                case "20":
                    // 위로
                    if (_gdMAIN_VIEW.FocusedRowHandle <= _gdMAIN_VIEW.RowCount - 1)
                    {
                        _gdMAIN_VIEW.FocusedRowHandle--;
                        Acitve_Row = _gdMAIN_VIEW.FocusedRowHandle;
                        _gdMAIN_VIEW.SelectRow(Acitve_Row);

                        _luTPART_NAME.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_NAME").ToString();
                        _luTPART_CODE.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_CODE").ToString();
                        _luTINSPECT_STATUS.Text = _gdMAIN_VIEW.GetFocusedRowCellDisplayText("INSPECT_STATUS").ToString();
                        _luTAPPROVAL_YN.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("INSPECT_APPROVAL").ToString() == "" ? _gdMAIN_VIEW.GetFocusedRowCellValue("INSPECT_APPROVAL").ToString() : _gdMAIN_VIEW.GetFocusedRowCellDisplayText("INSPECT_APPROVAL").ToString();
                        _luTPRODUCTION_ORDER_ID.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString();
                    }
                    break;


                case "30":

                    if (_gdMAIN_VIEW.RowCount <= 0)
                    {

                        CoFAS_DevExpressManager.ShowInformationMessage("선택된 품목이 없습니다.");
                        return;
                    }

                    if (_gdMAIN_VIEW.GetFocusedRowCellValue("INSPECT_APPROVAL").ToString() != "QC020001")
                    {
                        if (DBManager.InitDatabaseName == "coever_mes_glenzen")
                        {

                            if (_gdMAIN_VIEW.GetFocusedRowCellDisplayText("PROCESS_CODE_MST").ToString() == "포장")
                            {
                                CoFAS_DevExpressManager.ShowInformationMessage("시험검사가 승인이 완료된 것만 등록가능합니다.");
                                return;
                            }

                        }
                        else
                        {
                            CoFAS_DevExpressManager.ShowInformationMessage("시험검사가 승인이 완료된 것만 등록가능합니다.");
                            return;
                        }


                    }
                    else
                    {

                    }
                    if(_luTPART_NAME.Text=="")
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("시험검사를 선택해주세요.");
                        return;
                    }
                    // 실적등록
                    // 검사의뢰  선택 -> 실적입력 -> 리턴
                    // 실적등록
                    frmPopupKeypad frmkey = new frmPopupKeypad();
                    frmkey.titleName = pCmd.Text;

                    //실적등록에서 OK누를경우 리턴값
                    string PopupValue = string.Empty;
                    if (frmkey.ShowDialog() == DialogResult.OK)
                    {
                      
                            PopupValue = frmkey.ReturnValue1;
                            //리턴값이 빈값이 아니고 0도 아닐경우 실적등록
                            if (PopupValue != "0" && PopupValue != "")
                            {
                                _pPOPSelect_INSPECT_COSMETICSEntity.RESOURCE_CODE = "";// _luPROCESS_CODE.GetValue();
                                _pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_DATE = DateTime.Now.ToString("yyyyMMddHHmmss");
                                _pPOPSelect_INSPECT_COSMETICSEntity.PROPERTY_VALUE = _gdMAIN_VIEW.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString();
                                //CD501001 : 양품
                                //CD501002 : 불량
                                _pPOPSelect_INSPECT_COSMETICSEntity.CONDITION_CODE = "CD501001";
                                _pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_VALUE = PopupValue.Replace(",", "");

                                _pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_CODE").ToString();

                            //양품등록
                                bool isError = false;
                                isError = new frmPOPMain_PRODUCT_COSMETICSBusiness().frmPOPMain_PRODUCT_COSMETICS_Save(_pPOPSelect_INSPECT_COSMETICSEntity);
                            if (!isError)
                            {
                                //포장
                                if ((_gdMAIN_VIEW.GetFocusedRowCellValue("PROCESS_CODE_MST").ToString() == "PC010002") || (_gdMAIN_VIEW.GetFocusedRowCellValue("PROCESS_CODE_MST").ToString() == "PT040002"))
                                {
                                    //포장일경우 저장 프로시져
                                    //semi_mate_out_p_in : 반제품출고, 부자재출고,제품입고
                                    _pPOPSelect_INSPECT_COSMETICSEntity.CRUD = "semi_mate_out_p_in";

                                    _pPOPSelect_INSPECT_COSMETICSEntity.INOUT_TYPE = "O";
                                    _pPOPSelect_INSPECT_COSMETICSEntity.INOUT_ID = "";
                                    _pPOPSelect_INSPECT_COSMETICSEntity.INOUT_DATE = DateTime.Now.ToString("yyyyMMdd");// _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                                    _pPOPSelect_INSPECT_COSMETICSEntity.INOUT_SEQ = "000000";
                                    _pPOPSelect_INSPECT_COSMETICSEntity.INOUT_CODE = "PD040020"; //  PD040020 = 생산출고 INOUT_CODE -> TYPE
                                    _pPOPSelect_INSPECT_COSMETICSEntity.VEND_CODE = "V00000";
                                    _pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_CODE").ToString();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.INOUT_QTY = PopupValue.Replace(",", "").ToString() == "" ? "0" : PopupValue.Replace(",", "").ToString();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.PART_UNIT = "";// _luUNIT_CODE.GetValue();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.UNITCOST = "0";// _luUNITCOST.Text.ToString() == "" ? "0" : _luUNITCOST.Text.ToString().ToString();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.COST = "0";// _luCOST.Text.ToString() == "" ? "0" : _luCOST.Text.ToString().ToString();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.REFERENCE_ID = _gdMAIN_VIEW.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString(); // _luWORKORDERID.Text.ToString();   //포장지시번호로 BOM에서 떨구기
                                    _pPOPSelect_INSPECT_COSMETICSEntity.REMARK = "";// _luREMARK.Text.ToString();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.USE_YN = "Y";// _luUSE_YN.GetValue();

                                    isError = new frmPOPMain_PRODUCT_COSMETICSBusiness().ucWorkResultPopup_T01_Info_Save(_pPOPSelect_INSPECT_COSMETICSEntity);
                                    if (!isError)
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                    else
                                        CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                                }
                                else
                                {
                                    //semi_in : 반제품입고
                                    _pPOPSelect_INSPECT_COSMETICSEntity.CRUD = "semi_in";

                                    _pPOPSelect_INSPECT_COSMETICSEntity.INOUT_TYPE = "I";
                                    _pPOPSelect_INSPECT_COSMETICSEntity.INOUT_ID = "";
                                    _pPOPSelect_INSPECT_COSMETICSEntity.INOUT_DATE = DateTime.Now.ToString("yyyyMMdd");// _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                                    _pPOPSelect_INSPECT_COSMETICSEntity.INOUT_SEQ = "000000";
                                    _pPOPSelect_INSPECT_COSMETICSEntity.INOUT_CODE = "PD031014"; //  PD031014 = 생산입고 INOUT_CODE -> TYPE
                                    _pPOPSelect_INSPECT_COSMETICSEntity.VEND_CODE = "V00000";
                                    _pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_CODE").ToString();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.INOUT_QTY = PopupValue.Replace(",", "").ToString() == "" ? "0" : PopupValue.Replace(",", "").ToString();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.PART_UNIT = "";// _luUNIT_CODE.GetValue();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.UNITCOST = "0";// _luUNITCOST.Text.ToString() == "" ? "0" : _luUNITCOST.Text.ToString().ToString();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.COST = "0";// _luCOST.Text.ToString() == "" ? "0" : _luCOST.Text.ToString().ToString();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.REFERENCE_ID = _gdMAIN_VIEW.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.REMARK = "";// _luREMARK.Text.ToString();
                                    _pPOPSelect_INSPECT_COSMETICSEntity.USE_YN = "Y";// _luUSE_YN.GetValue();

                                    isError = new frmPOPMain_PRODUCT_COSMETICSBusiness().ucWorkResultPopup_T01_Info_Save(_pPOPSelect_INSPECT_COSMETICSEntity);
                                    if (!isError)
                                        //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);
                                        CoFAS_DevExpressManager.ShowInformationMessage("실적등록이 되었습니다.");
                                    else
                                        //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                                        CoFAS_DevExpressManager.ShowInformationMessage("저장오류 발생");
                                }

                                    if (!isError)
                                    this.DialogResult = DialogResult.OK;
                            }
                            
                                //작업지시상태 업데이트
                                
                        }
                    }

                   

                    Close();
                    break;

                case "40":
                    //아래로
                    if (_gdMAIN_VIEW.FocusedRowHandle <= _gdMAIN_VIEW.RowCount - 1)
                    {
                        _gdMAIN_VIEW.FocusedRowHandle++;
                        Acitve_Row = _gdMAIN_VIEW.FocusedRowHandle;
                        _gdMAIN_VIEW.SelectRow(Acitve_Row);
                        _luTPART_NAME.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_NAME").ToString();
                        _luTPART_CODE.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("PART_CODE").ToString();
                        _luTINSPECT_STATUS.Text = _gdMAIN_VIEW.GetFocusedRowCellDisplayText("INSPECT_STATUS").ToString();
                        _luTAPPROVAL_YN.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("INSPECT_APPROVAL").ToString() == "" ? _gdMAIN_VIEW.GetFocusedRowCellValue("INSPECT_APPROVAL").ToString() : _gdMAIN_VIEW.GetFocusedRowCellDisplayText("INSPECT_APPROVAL").ToString();
                        _luTPRODUCTION_ORDER_ID.Text = _gdMAIN_VIEW.GetFocusedRowCellValue("PRODUCTION_ORDER_ID").ToString();
                    }
                    break;


                case "50":
                    //최하단
                    if (_gdMAIN_VIEW.FocusedRowHandle <= _gdMAIN_VIEW.RowCount - 1)
                    {
                        _gdMAIN_VIEW.FocusedRowHandle = _gdMAIN_VIEW.RowCount - 1;
                        Acitve_Row = _gdMAIN_VIEW.FocusedRowHandle;
                        _gdMAIN_VIEW.SelectRow(Acitve_Row);
                    }
                    break;

                default: break;
            }

        }

        #endregion
    }
}
