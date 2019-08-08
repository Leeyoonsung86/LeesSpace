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
using CoFAS_MES.CORE.BaseControls;
using CoFAS_MES.CORE.UserForm;
using CoFAS_MES.CORE.UserControls;
using CoFAS_MES.UI.MM.Business;
using CoFAS_MES.UI.MM.Data;
using CoFAS_MES.UI.MM.Entity;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Spreadsheet;
using System.IO;
using static CoFAS_MES.CORE.BaseControls.ucSpreadSheetControl;

namespace CoFAS_MES.UI.MM
{
    public partial class  testprint : frmBaseNone
    {
        #region ○ 변수선언

        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
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

        private MaterialOrderRegisterEntity _pMaterialOrderRegisterEntity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private Object _ojList = null;    //엑셀파일  //추가
        private DataSet _stList = null;   //DataSet  //추가

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        #endregion

        #region ○ 생성자

        public testprint()
        {
            InitializeComponent();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        #endregion

        #region ● 폼 이벤트 처리 영역

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

                throw pExceptionManager;

            }
        }
        #endregion

        #region ○ Form_Closing

        private void Form_Closing(object pSender, FormClosingEventArgs pFormClosingEventArgs)
        {
            try
            {
                //그리드 작업 정보 확인 하기
                if (_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n종료 하겠습니까?") == DialogResult.No)
                    {
                        pFormClosingEventArgs.Cancel = true;
                        return;
                    }
                }
                pFormClosingEventArgs.Cancel = false;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

                throw pExceptionManager;

            }
            catch (Exception pException)
            {
                //throw new ExceptionManager(this, "InputData_Save(DataTable dtSave)", pException);
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

                throw pExceptionManager;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InputData_Save(DataTable dtSave)", pException);
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
                DeleteButtonClicked += new EventHandler(Form_DeleteButtonClicked);
                PrintButtonClicked += new EventHandler(Form_PrintButtonClicked);
                ExportButtonClicked += new EventHandler(Form_ExportButtonClicked);
                ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                SettingButtonClicked += new EventHandler(Form_SettingButtonClicked);

                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);

                //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행
                _luORDER_QTY._OnKeyDown += new ucTextEdit.OnKeyDownEventHandler(_luORDER_QTY__OnKeyDown);
                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                _btPRINT.Click += _btPRINT_Click;  //추가

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

                throw pExceptionManager;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InputData_Save(DataTable dtSave)", pException);
            }

        }
        #endregion

        #endregion

        #region ● 초기화영역

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
                _pnContent.Width = 200;

                xtraTabPage2.PageVisible = false;

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
                _pWINDOW_NAME = this.Name;

                //메뉴 화면 엔티티 설정
                _pMaterialOrderRegisterEntity = new MaterialOrderRegisterEntity();
                //_pMaterialOrderRegisterEntity.CORP_CODE = _pCORP_CODE;
                _pMaterialOrderRegisterEntity.USER_CODE = _pUSER_CODE;
                _pMaterialOrderRegisterEntity.WINDOW_NAME = _pWINDOW_NAME;
                _pMaterialOrderRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;


                //화면 설정 언어 & 명칭 변경.
                DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //메인 화면 공용 버튼 설정
                //if (_pFirstYN)
                //{
                //    InitializeButtons();
                //}

                //그리드 설정
                InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl(true);

                //SpreadSheet 초기화 _sdMAIN  //추가
                _sdMAIN.ClearSheet();

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    MainFind_DisplayData("");
                    _pFirstYN = false;
                }

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
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl(bool FirstChk)
        {
            try
            {
                //조회조건 영역
                _luT_ORDER_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luT_ORDER_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                _luT_PART_CODE.CodeText = "";
                _luT_PART_CODE.NameText = "";
                _luT_VEND_CODE.CodeText = "";
                _luT_VEND_CODE.NameText = "";

                _luTORDER_ID.Text = "";
                _luTREFERENCE_ID.Text = "";

                _luTUSE_YN.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "common_code", "CD99", "", "").Tables[0], 0, 0, "");
                _luTUSE_YN.ItemIndex = 0;

                //데이터 영역


                _luORDER_DATE.DateTime = DateTime.Today;

                _luORDER_ID.Text = "";
                _luORDER_ID.ReadOnly = true;

                _luREFERENCE_ID.Text = "";   // 수주번호
                _luREFERENCE_ID.ReadOnly = true;

                _luUNIT_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R",_pLANGUAGE_TYPE, "COMMON_CODE", "CD04", "", "").Tables[0], 0, 0, "");
                _luUNIT_CODE.ReadOnly = true;

                _luPART.CodeText = "";
                _luPART.NameText = "";
                _luPART.CodeReadOnly = true;
                _luPART.NameReadOnly = true;

                _luVEND.CodeText = "";
                _luVEND.NameText = "";
                _luVEND.CodeReadOnly = true;
                _luVEND.NameReadOnly = true;



                _luORDER_QTY.Text = "0";
                _luORDER_QTY.ReadOnly = false;

                _luUNIT_COST.Text = "0";
                _luUNIT_COST.ReadOnly = false;

                _luCOST.Text = "0";
                _luCOST.ReadOnly = true;

                _luREQUEST_DATE.DateTime = DateTime.Today;


                _luREQUEST_LOCATION.Text = "";
                _luUNIT_COST.ReadOnly = false;

                _luREMARK.Text = "";
                _luREMARK.ReadOnly = false;

                _btPRINT.Text = "PRINT";

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

                dxValidationProvider.SetValidationRule(_luORDER_QTY, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _gdMAIN.DataSource = null;
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

        // 추가이벤트 설정
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                
                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                _pMaterialOrderRegisterEntity.VEND_CODE = gv.GetFocusedRowCellValue("VEND_CODE").ToString();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
        }

        private void _btPRINT_Click(object sender, EventArgs e)   //추가
        {
            _sdMAIN.ShowPrintPeview();
        }

        #region ○ simplebutton _ 엑셀 수정 이벤트   //추가
        private void _btSHEET_Click(object pSender, EventArgs pEventArgs)   //추가
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                CoFAS_MES.CORE.UserForm.frmSheetSetting xfrmSheetSetting = new CORE.UserForm.frmSheetSetting();
                //xfrmSheetSetting.PASS_CORP_CODE = _pMaterialOrderRegisterEntity.CORP_CODE;
                xfrmSheetSetting.PASS_PARENT_WINDOW_NAME = _pWINDOW_NAME;
                xfrmSheetSetting.PASS_USER_CODE = _pUSER_CODE;
                xfrmSheetSetting.PASS_PARENT_LANGUAGE = _pLANGUAGE_TYPE;
                xfrmSheetSetting.PASS_PARENT_FONT = _pFONT_SETTING;
                xfrmSheetSetting.PASS_PARENT_FTP_PATH = _pFTP_PATH;
                xfrmSheetSetting.PASS_PARENT_FTP_ID = _pFTP_ID;
                xfrmSheetSetting.PASS_PARENT_FTP_PW = _pFTP_PW;

                xfrmSheetSetting.ShowDialog();


                if (xfrmSheetSetting.PASS_RESULT)
                {
                    InitializeSetting();
                    xfrmSheetSetting.Dispose();
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        #endregion



        #region ● 메인 버튼 처리영역

        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("작업 중인 데이터가 있습니다.");
                }
                else
                {
                    MainFind_DisplayData("R");

                    //DisplayMessage("조회 되었습니다.");
                    DisplayMessage(_pMSG_SEARCH);
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

        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (!dxValidationProvider.Validate())
                {
                    MessageBox.Show("빈값이 있음");
                    return;
                }
                if (_luORDER_QTY.Text == "0" || _luORDER_QTY.Text == "")
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("수량을 입력해 주세요.");
                    return;
                }

                int intQty_chk = Convert.ToInt32(_luORDER_QTY.Text);

                if (intQty_chk < 0)
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("발주수량이 0보다 작을 수 없습니다.");
                    return;
                }

                 //확인
                if (_luORDER_ID.Text.ToString() != "")
                {
                    _pMaterialOrderRegisterEntity.CRUD = "U";
                }
                else
                {
                    _pMaterialOrderRegisterEntity.CRUD = "C";
                }


                _pMaterialOrderRegisterEntity.USER_CODE = _pUSER_CODE;
                _pMaterialOrderRegisterEntity.ORDER_ID = _luORDER_ID.Text;
                _pMaterialOrderRegisterEntity.ORDER_DATE = DateTime.Parse(_luORDER_DATE.DateTime.ToString()).ToString("yyyyMMdd");//_luORDER_DATE.DateTime.ToString().Substring(0,10).Replace("-", "").ToString();
                _pMaterialOrderRegisterEntity.ORDER_SEQ = "";
                _pMaterialOrderRegisterEntity.VEND_CODE = _luVEND.CodeText;
                _pMaterialOrderRegisterEntity.PART_CODE = _luPART.CodeText;
                _pMaterialOrderRegisterEntity.ORDER_QTY = _luORDER_QTY.Text;
                _pMaterialOrderRegisterEntity.REQUEST_DATE = DateTime.Parse(_luREQUEST_DATE.DateTime.ToString()).ToString("yyyyMMdd");  //_luREQUEST_DATE.DateTime.ToString().Substring(0, 10).Replace("-", "").ToString();
                _pMaterialOrderRegisterEntity.REQUEST_LOCATION = _luREQUEST_LOCATION.Text;
                _pMaterialOrderRegisterEntity.UNIT_CODE = _luUNIT_CODE.GetValue();
                _pMaterialOrderRegisterEntity.UNITCODT_CURRENCY_CODE = _luREQUEST_LOCATION.Text;
                _pMaterialOrderRegisterEntity.UNITCOST = _luUNIT_COST.Text;
                _pMaterialOrderRegisterEntity.COST = _luCOST.Text;
                _pMaterialOrderRegisterEntity.CONTRACT_ID = _luREFERENCE_ID.Text;
                _pMaterialOrderRegisterEntity.REMARK = _luREMARK.Text;
                _pMaterialOrderRegisterEntity.USE_YN = "Y";


                InputData_Save(_pMaterialOrderRegisterEntity);

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
                    MessageBox.Show("빈값이 있음");
                    return;
                }

                //확인
                if (_luORDER_ID.Text.ToString() != "")
                {
                    _pMaterialOrderRegisterEntity.CRUD = "D";
                }
                else
                {
                    MessageBox.Show("발주 정보를 선택하세요.");
                    return;
                }
                if (CoFAS_DevExpressManager.ShowQuestionMessage("발주 데이터를 삭제하시겠습니까? \n 발주번호 : " + _luORDER_ID.Text) == DialogResult.No)
                {
                    return;
                }



                _pMaterialOrderRegisterEntity.ORDER_ID = _luORDER_ID.Text.ToString();
                _pMaterialOrderRegisterEntity.ORDER_DATE = _luORDER_DATE.DateTime.ToString("yyyy-MM-dd");
                //_pMaterialOrderRegisterEntity.ORDER_SEQ = _luORDER_SEQ.Text.ToString().ToString() == "" ? "0" : _luORDER_SEQ.Text.ToString();

                //_pMaterialOrderRegisterEntity.VEND_CODE = _luVEND_CODE1.Text.ToString();
                //_pMaterialOrderRegisterEntity.PART_CODE = _luPART_CODE1.Text.ToString();
                _pMaterialOrderRegisterEntity.ORDER_QTY = _luORDER_QTY.Text.ToString();
                _pMaterialOrderRegisterEntity.REQUEST_DATE = _luREQUEST_DATE.DateTime.ToString("yyyy-MM-dd");
                _pMaterialOrderRegisterEntity.REQUEST_LOCATION = _luREQUEST_LOCATION.Text.ToString();
                _pMaterialOrderRegisterEntity.UNIT_CODE = _luUNIT_CODE.GetValue();
                _pMaterialOrderRegisterEntity.UNITCOST = _luUNIT_COST.Text.ToString() == "" ? "0" : _luUNIT_COST.Text.ToString().ToString();
                _pMaterialOrderRegisterEntity.COST = _luCOST.Text.ToString() == "" ? "0" : _luCOST.Text.ToString().ToString();
                _pMaterialOrderRegisterEntity.CONTRACT_ID = _luREFERENCE_ID.Text.ToString();
                _pMaterialOrderRegisterEntity.REMARK = _luREMARK.Text.ToString();
                _pMaterialOrderRegisterEntity.USE_YN = "Y";


                InputData_Save(_pMaterialOrderRegisterEntity);

                InitializeControl(false);
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

                if (_luORDER_ID.Text.ToString() != "")
                {
                    SheetFind_DisplayData();          //엑셀 파일 컨트롤에 불러오기  //추가
                    Sheet_Info_Sheet_Data();          //화면명과 선택한 발주번호에 맞는 정보 바인딩   //추가   

                    xtraTabPage2.PageVisible = true;
                    xtraTabPage2.Show();                  //추가

                    _btPRINT.PerformClick();          //simple 버튼 클릭 실행
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("인쇄할 발주건을 선택해주세요.");
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

                if (_gdMAIN_VIEW.GridControl != null && CoFAS_ConvertManager.DataTable_FindCount(_gdMAIN_VIEW.GridControl.DataSource as DataTable, "CRUD IN ('C','U','D')", ""))
                {
                    if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 자료가 있습니다.\n초기화 하겠습니까?") == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        InitializeSetting();

                        DisplayMessage("초기화했습니다.");
                    }
                }
                else
                {
                    InitializeSetting();

                    DisplayMessage("초기화했습니다.");
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
                //xfrmPageSetting.PASS_CORP_CODE = _pMaterialOrderRegisterEntity.CORP_CODE;
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

        #endregion

        #region ● DB 처리

        #region ○ 메인조회 - MainFind_DisplayData(string pCRUD)

        private void MainFind_DisplayData(string pCRUD)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pMaterialOrderRegisterEntity.CRUD = pCRUD;
                _pMaterialOrderRegisterEntity.DATE_FROM = DateTime.Parse(_luT_ORDER_DATE.FromDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luT_ORDER_DATE.FromDateTime).Substring(0, 10).Replace("-", "");
                _pMaterialOrderRegisterEntity.DATE_TO = DateTime.Parse(_luT_ORDER_DATE.ToDateTime.ToString()).ToString("yyyyMMdd");//Convert.ToString(_luT_ORDER_DATE.ToDateTime).Substring(0, 10).Replace("-", "");
                _pMaterialOrderRegisterEntity.ORDER_ID = _luTORDER_ID.Text;
                _pMaterialOrderRegisterEntity.REFERENCE_ID = _luTREFERENCE_ID.Text;
                _pMaterialOrderRegisterEntity.USE_YN = _luTUSE_YN.GetValue();
                _pMaterialOrderRegisterEntity.VEND_CODE = _luT_VEND_CODE.CodeText.ToString() ;
                _pMaterialOrderRegisterEntity.VEND_NAME = _luT_VEND_CODE.NameText.ToString();
                _pMaterialOrderRegisterEntity.PART_CODE = _luT_PART_CODE.CodeText.ToString();
                _pMaterialOrderRegisterEntity.PART_NAME = _luT_PART_CODE.NameText.ToString();



                using (DBManager pDBManager = new DBManager())
                {

                    _dtList = new MaterialOrderRegisterProvider(pDBManager).MaterialOrderRegister_R10(_pMaterialOrderRegisterEntity);

                    if (_dtList != null && _dtList.Rows.Count > 0)
                    {
                        CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                    }
                    else
                    {

                        CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
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

        #region ○ 서브조회 - SubFind_DisplayData(string pORDERID)   //사용X

        private void SubFind_DisplayData(string pORDERID)  //사용X
        {
            

        }
        #endregion

        #region ○ 시트조회 - SheetFind_DisplayData()   //추가

        private void SheetFind_DisplayData()   //추가
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new MaterialOrderRegisterBusiness().Sheet_Info_Sheet(_pMaterialOrderRegisterEntity);

                if (_dtList != null && _dtList.Rows.Count > 0)
                {
                    string strUSE_TYPE = _dtList.Rows[0][1].ToString();
                    string strFILE_NAME = _dtList.Rows[0][0].ToString();
                    string strFTP_PATH = "";

                    switch (strUSE_TYPE)
                    {
                        case "PRINT":
                            strFTP_PATH = string.Format(@"{0}{1}/{2}/", _pFTP_PATH, "ORDER_FORM", _pMaterialOrderRegisterEntity.WINDOW_NAME);
                            break;
                        case "VIEW":
                            strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH,"USER", "PROGRAM_VIEW", _pMaterialOrderRegisterEntity.WINDOW_NAME);
                            break;
                        case "REGIT":
                            strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pMaterialOrderRegisterEntity.WINDOW_NAME);
                            break;
                    }

                    using (Stream responseStream = CoFAS_FTPManager.FTPFileBinding(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW))
                    {
                        if (responseStream != null)
                        {
                            _sdMAIN.LoadDocument(responseStream, enFileFormat.Xlsx);
                        }
                        else
                        {
                            _sdMAIN.ClearSheet();
                        }
                    }
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("해당 거래처로 저장된 인쇄용 엑셀 파일이 없습니다.");
                    _sdMAIN.ClearSheet();
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager));
            }
            finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        #region ○ 화면명과 선택한 발주번호에 맞는 정보 바인딩 - Sheet_Info_Sheet_Data()  //추가

        private void Sheet_Info_Sheet_Data()   //추가
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _pMaterialOrderRegisterEntity.ORDER_ID = _luORDER_ID.Text.ToString();
                
                IWorkbook workbook = _sdMAIN.Document;

                using (DBManager pDBManager = new DBManager())
                {

                    _dtList = new MaterialOrderRegisterProvider(pDBManager).Sheet_Info_Sheet_Data(_pMaterialOrderRegisterEntity);

                    if (_dtList != null && _dtList.Rows.Count > 0)
                    {

                        Worksheet sheet_1 = workbook.Worksheets["data"];

                        ExternalDataSourceOptions dsOptions = new ExternalDataSourceOptions();
                        dsOptions.ImportHeaders = false;

                        /* 
                         * 발주서 양식에 데이터를 바인딩할 때, row와 column의 인덱스 또는 범위(range)를 직접 지정하여 바인딩해야 한다.
                         * 현재, 발주번호 1건에 1개의 품목이 정의된 상태에서는 'data' 시트에 '기본 정보'와 '품목 조회 부분'을 같이 불러왔다. 
                         * 그리고 엑셀의 참조 기능을 이용하여 발주서 양식을 완성했다. 
                         * 
                         * 하지만, 발주번호 1건에 여러 개의 품목이 정의된 상태는 바인딩 방법을 다르게 해야 한다.
                         * DataSet으로 '기본 정보'와 '품목 조회 부분'을 따로 불러와야 한다.
                         * '기본 정보'는 'data' 시트에 바인딩한 후, 엑셀의 참조 기능을 이용한다.
                         * 그리고, '품목 조회 부분'은 rows.count()를 이용해 row의 수를 파악하여 발주서 양식에 행을 추가한다.
                         * 그 후, 행을 추가한 부분에 '품목 조회 부분'의 위치를 직접 지정하여 바인딩해야 한다.
                         * 
                        */
                        sheet_1.DataBindings.BindToDataSource(_dtList, 1, 0, dsOptions);
                        
                    }
                    else
                    {

                        CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    }
                }

                workbook.Worksheets.ActiveWorksheet = workbook.Worksheets[0];

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

        private void InputData_Save(MaterialOrderRegisterEntity _pMaterialOrderRegisterEntity)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                using (DBManager pDBManager = new DBManager())
                {
                    isError = new MaterialOrderRegisterBusiness().MaterialOrderRegister_Info_Save(_pMaterialOrderRegisterEntity);

                    if (isError)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    }
                    else
                    {
                        //정상 처리
                        CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");

                        MainFind_DisplayData("R");
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

        #endregion

       


        private void _luUNIT_COST_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != 8)

            {
                e.Handled = true;
            }
            int orderqty;
            int unitcost;
            int cost;
            int summary;
            orderqty = Convert.ToInt32(_luORDER_QTY.Text);
            unitcost = Convert.ToInt32(_luUNIT_COST.Text);
            cost = Convert.ToInt32(_luCOST.Text);
            summary = (orderqty * unitcost);
            _luCOST.Text = Convert.ToString(summary);
        }

        private void _luORDER_QTY__OnKeyDown(object sender, KeyEventArgs e)
        {
            string test1 = "";
            string test2 = "";
            test1 = e.KeyValue.ToString();
            test2 = e.KeyData.ToString();
            if (e.KeyValue != '.' && e.KeyValue != 8)

            {
                e.Handled = true;
            }
            decimal orderqty;
            decimal unitcost;
            decimal cost;
            decimal summary;
            orderqty = Convert.ToDecimal(_luORDER_QTY.Text.Replace(",", ""));
            unitcost = Convert.ToDecimal(_luUNIT_COST.Text.Replace(",", ""));
            cost = Convert.ToDecimal(_luCOST.Text);
            summary = (orderqty * unitcost);
            _luCOST.Text = Convert.ToString(summary);
        }

        #region ○ 자재조회팝업호출 - _luT_PART_CODE__OnOpenClick()   //추가
     
        private void _luT_PART_CODE__OnOpenClick(object sender, EventArgs e)
        {
            //VendCostInfo
            frmCommonPopup.CRUD = "R";
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;
            
            

            // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            frmCommonPopup.ARRAY = new object[2] { "Material_Code", "" }; 

            //검색조건 전달 0 코드 1 명칭
            frmCommonPopup.ARRAY_CODE = new object[2] { _luT_PART_CODE.CodeText.ToString(), _luT_PART_CODE.NameText.ToString() };

            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luT_PART_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luT_PART_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

                //데이터 세팅
            }
           
            xfrmCommonPopup.Dispose();
        }

        #endregion

        #region ○ 거래처조회팝업호출 - _luT_VEND_CODE__OnOpenClick()  
        private void _luT_VEND_CODE__OnOpenClick(object sender, EventArgs e)
        {
            //VendCostInfo
            frmCommonPopup.CRUD = "R";
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;



            // 0 서비스네임 1 공통코드경우 CODE_TYPE 으로구분자 올린다.
            frmCommonPopup.ARRAY = new object[2] { "Vend_Code_I", "" };

            //검색조건 전달 0 코드 1 명칭
            frmCommonPopup.ARRAY_CODE = new object[2] { _luT_VEND_CODE.CodeText.ToString(), _luT_VEND_CODE.NameText.ToString() };

            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("CommonCode"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luT_VEND_CODE.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["CD"].ToString();
                _luT_VEND_CODE.NameText = xfrmCommonPopup.dtReturn.Rows[0]["CD_NM"].ToString();

                //데이터 세팅
            }

            xfrmCommonPopup.Dispose();
        }
        #endregion


        #region ○ 자재 거래처별 단가 조회팝업호출 - _btPART_Click()  
        private void _luPART_CODE__OnOpenClick(object sender, EventArgs e)
        {
            //VendCostInfo
            frmCommonPopup.USER_CODE = _pUSER_CODE;
            frmCommonPopup.LANGUAGE_TYPE = _pLANGUAGE_TYPE;
            frmCommonPopup.FONT_TYPE = _pFONT_SETTING;

            frmCommonPopup.ARRAY = new object[2] { "Material_Code", "" }; //넘기는 파라메터 에 따라 설정



            //ucVendCodeInfoPopup xucVendCodeInfoPopup = new CORE.UserControls.ucVendCodeInfoPopup("PartCodeInfo"); //유저컨트롤러 설정 부분
            frmCommonPopup xfrmCommonPopup = new CORE.UserForm.frmCommonPopup("VendCostInfo"); //유저컨트롤러 설정 부분
            xfrmCommonPopup.ShowDialog();

            if (xfrmCommonPopup.dtReturn != null && xfrmCommonPopup.dtReturn.Rows.Count > 0)
            {
                _luVEND.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_CODE"].ToString();
                _luVEND.NameText = xfrmCommonPopup.dtReturn.Rows[0]["VEND_NAME"].ToString();
                _luPART.CodeText = xfrmCommonPopup.dtReturn.Rows[0]["PART_CODE"].ToString();
                _luPART.NameText = xfrmCommonPopup.dtReturn.Rows[0]["PART_NAME"].ToString();
                _luUNIT_COST.Text = xfrmCommonPopup.dtReturn.Rows[0]["PART_UNITCOST"].ToString();
            }


            xfrmCommonPopup.Dispose();
        }

        #endregion


    }
}
