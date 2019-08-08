using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.POP.Business;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.POP.Entity;
using CoFAS_MES.CORE.Entity;
using DevExpress.XtraGrid.Views.Grid;

using CoFAS_MES.POP;

//엑셀관련
using DevExpress.Spreadsheet;
using System.IO;

namespace CoFAS_MES.UI.POP.UserControls
{
    public partial class ucTABRegister : UserControl
    {
        private string _pCORP_CODE = string.Empty;       // 회사코드       
        private string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private string _pUSER_NAME = string.Empty;       // 사용자이름
        private string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        private string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        private string _pFONT_TYPE = "Meiryo UI"; //string.Empty;       // 시스템 폰트 타입 설정
        private int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
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

        private ucTABRegisterEntity _pucTABRegisterEntity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtList_Comment = null; //코멘트 조회 데이터 리스트
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        private int select_row_handle = 0;

        private int active_row = 0;

        private string common = null;

        public UserEntity _pUserEntity = null;

        private DataTable _dtreturn = new DataTable();

        public frmTABMain _pfrmTABMain = null;

        string fileName = "";
        string fileFullName = "";
        string filePath = "";
        IWorkbook wb = null;
        Worksheet worksheet = null;
        string worksheetName = string.Empty;

        public string text = string.Empty; // 메시지 알림용

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

        public ucTABRegister(UserEntity pUserEntity, frmTABMain main)
        {
            InitializeComponent();

            this._pfrmTABMain = main;

            _pUserEntity = pUserEntity;

            this._pfrmTABMain._lmSAVE.Click += new EventHandler(Form_SaveButtonClicked);
            //this._pfrmTABMain._lmIMPORT.Click += new EventHandler(_ucbtEXCEL_IMPORT_Click);

            Load += new EventHandler(Form_Load);
        }

        #region ○ Form_Activated
        private void Form_Activated(object pSender, EventArgs pEventArgs)
        {
            //try
            //{
            //    InitializeButtons();
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            //}
        }
        #endregion

        #region ○ Form_Closing

        private void Form_Closing(object pSender, FormClosingEventArgs pFormClosingEventArgs)
        {
            try
            {

                ////if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_EXIT_QUESTION) == DialogResult.No)
                ////{
                ////    pFormClosingEventArgs.Cancel = true;
                ////    return;
                ////}

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
                this._pfrmTABMain._lmSAVE.Click -= new EventHandler(Form_SaveButtonClicked);
                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;
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

        #region ○ 메뉴 초기화 하기 - InitializeSetting()
        private void InitializeSetting()
        {
            try
            {

                //메인 화면 전역 변수 처리
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);

                _pWINDOW_NAME = this.Name;
                _pUSER_CODE = _pUserEntity.USER_CODE;
                _pUSER_NAME = _pUserEntity.USER_NAME;
                _pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = _pUserEntity.FONT_TYPE;
                _pFONT_SIZE = _pUserEntity.FONT_SIZE;
                //메뉴 화면 엔티티 설정
                _pucTABRegisterEntity = new ucTABRegisterEntity();
                _pucTABRegisterEntity.CORP_CODE = _pUserEntity.CORP_CODE;
                _pucTABRegisterEntity.USER_CODE = _pUserEntity.USER_CODE;
                _pucTABRegisterEntity.LANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;

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

                if (_pFirstYN)
                {
                    MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

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
                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _luSENSOR_LIST.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", _pLANGUAGE_TYPE, "SENSOR_DATA_HISTORY", "", "", "").Tables[0], 0, 0, "", false);

                _luSENSOR_LIST.Font = new Font("Meiryo UI", 16);
                _luSENSOR_LIST.Font = new Font("Meiryo UI", 16);

                _luCOMMENT_DATE.FromDateTime = DateTime.Today;  //조회 시작일, 당일 설정
                _luCOMMENT_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정

                _luDATA.Text = "";
                
                _luCOMMENT_DATE.FromDateTime = DateTime.Today;  //조회 시작일, 당일 설정
                _luCOMMENT_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                
                if (_pFirstYN)
                {
                    _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
                    //_gdMAIN.DataSource = null;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                //GridView gv = sender as GridView;
                //CoFAS_ControlManager.Controls_Binding(gv, false, this); //그리드 정보 디테일 표기

                //if (gv.FocusedRowHandle == e.RowHandle)
                //    e.Appearance.BackColor = Color.Orange;

                ////_pucTABRegisterEntity.CRUD = "R";
                ////_pucTABRegisterEntity.NOTICE_ID = gv.GetFocusedRowCellValue("NOTICE_ID").ToString();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        private void gdMAIN_VIEW_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            //if (((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused) != 0) && ((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.GridFocused) != 0))
            //    e.Appearance.Assign(view.PaintAppearance.FocusedRow);
            if (view.FocusedRowHandle == e.RowHandle)
                e.Appearance.BackColor = Color.Orange;
        }

        #endregion

        // 상단 메인 버튼 처리영역
        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

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

                if (_luSENSOR_LIST.GetValue().ToString() == "" || _luSENSOR_LIST.GetValue().ToString() == null)
                {
                    return;
                }

                DataTable tDataTable = _gdMAIN_VIEW.GridControl.DataSource as DataTable;

                if (tDataTable != null)
                {
                    int pCount = 0;
                    string sList = string.Empty;

                    int chk = 0;

                    pCount = tDataTable.Rows.Count;

                    _pucTABRegisterEntity.COMMENT1 = string.Empty;
                    _pucTABRegisterEntity.COMMENT2 = string.Empty;
                    _pucTABRegisterEntity.COMMENT3 = string.Empty;

                    for (int a = 0; a < pCount; a++)
                    {
                        //체크된것만 저장
                        if (tDataTable.Rows[a]["CRUD"].ToString() == "Y" && chk < 10)
                        {
                            if (chk == 0)
                            {
                                _pucTABRegisterEntity.COMMENT1 = tDataTable.Rows[a]["COM_CODE"].ToString();

                            }
                            else if (chk == 1)
                            {
                                _pucTABRegisterEntity.COMMENT2 = tDataTable.Rows[a]["COM_CODE"].ToString();

                            }
                            else if (chk == 2)
                            {
                                _pucTABRegisterEntity.COMMENT3 = tDataTable.Rows[a]["COM_CODE"].ToString();

                            }

                            chk++;
                        }

                        if (chk >= 4)
                        {
                            // 코멘트 등록은 최대 3개입니다.
                            text = "コメントの登録は最大3つです。";
                            Message_Click(null, null);
                            
                            return;
                        }
                    }
                }

                _pucTABRegisterEntity.CRUD = "C";
                _pucTABRegisterEntity.DATE_TIME = DateTime.Now.ToString("yyyyMMddHHmmss");
                _pucTABRegisterEntity.RESOURCE_CODE = _luSENSOR_LIST.GetValue().ToString();
                _pucTABRegisterEntity.RESOURCE_NAME = _luSENSOR_LIST.Text.ToString();
                _pucTABRegisterEntity.VALUE = _luDATA.Text;

                _pucTABRegisterEntity.DATE_FROM = DateTime.Parse(_luCOMMENT_DATE.FromDateTime.ToString()).ToString("yyyyMMdd"); // Convert.ToString(_luTINOUT_DATE.FromDateTime).Replace("-", "").Substring(0, 8);
                _pucTABRegisterEntity.DATE_TO = DateTime.Parse(_luCOMMENT_DATE.ToDateTime.ToString()).ToString("yyyyMMdd"); // Convert.ToString(_luTINOUT_DATE.FromDateTime).Replace("-", "").Substring(0, 8);

                MainFind_CommentCheck();

                string cum = _dtList_Comment.Rows[0]["COUNT"].ToString();

                if (cum == "3")
                {
                    // 이미 코멘트가 전부 등록된 기간입니다.
                    text = "既にコメントがすべて登録されている期間です。";
                    Message_Click(null, null);
                }
                else if (cum == "2")
                {
                    // 기간 내 이미 등록된 코멘트 2개가 있습니다. 1 코멘트가 저장됩니다.
                    text = "期間内にすでに登録されているコメント2つがあります。 \n1つのコメントが保存されます。";
                    Message_Click(null, null);

                    _pucTABRegisterEntity.COMMENT3 = _pucTABRegisterEntity.COMMENT1;

                    _pucTABRegisterEntity.COMMENT1 = "";
                    _pucTABRegisterEntity.COMMENT2 = "";

                    InputData_One_Save();
                }
                else if (cum == "1")
                {
                    // 이미 코멘트가 등록된 기간입니다.
                    text = "期間内にすでに登録されているコメント1つがあります。 \n2つのコメントが保存されます。";
                    Message_Click(null, null);

                    _pucTABRegisterEntity.COMMENT3 = _pucTABRegisterEntity.COMMENT2;
                    _pucTABRegisterEntity.COMMENT2 = _pucTABRegisterEntity.COMMENT1;

                    _pucTABRegisterEntity.COMMENT1 = "";

                    InputData_One_Save();
                }
                else
                {
                    InputData_One_Save();
                };
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

        #region ○ 엑셀 버튼 데이터 밀어넣기
        private void _ucbtEXCEL_IMPORT_Click(object sender, EventArgs e)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                OpenFileDialog opd = new OpenFileDialog();
                opd.FileName = "";
                opd.Filter = "xlsFile(*.xls)|*.xls|xlsxFile(*.xlsx)|*.xlsx";
                opd.Title = "Excel Upload";

                if (opd.ShowDialog() == DialogResult.OK)
                {
                    fileName = opd.SafeFileName;
                    fileFullName = opd.FileName;
                    filePath = fileFullName.Replace(fileName, "");

                    // 선택한 엑셀 파일 spread control에 바인딩
                    using (FileStream stream = new FileStream(opd.FileName.ToString(), FileMode.Open, FileAccess.Read))
                    {
                        spreadsheetControl1.LoadDocument(stream);

                        if (spreadsheetControl1.Document != null)
                        {
                            InputData_Excel_Save();
                        }
                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

            }
        }
        #endregion

        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new ucTABRegisterBusiness().ucTABRegister_Info_Return(_pucTABRegisterEntity);

                if (_pucTABRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pucTABRegisterEntity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    _gdMAIN_VIEW.RowHeight = 80;
                    _gdMAIN_VIEW.Appearance.Row.Font = new Font("Meiryo UI", 18);

                    _gdMAIN_VIEW.Appearance.FocusedRow.Font = new Font("Meiryo UI", 18);
                }
                else
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    //  InitializeControl();
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

        #region ○ 기존 코멘트 확인 - MainFind_CommentCheck()

        private void MainFind_CommentCheck()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList_Comment = new ucTABRegisterBusiness().ucTABRegister_Comment_Info_Return(_pucTABRegisterEntity);
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

        #region ○ 단일 저장 - InputData_One_Save(DataTable dtSave)

        private void InputData_One_Save()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                isError = new ucTABRegisterBusiness().ucTABRegister_Info_One_Save(_pucTABRegisterEntity);

                if (isError)
                {
                    //오류 발생.
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                    //화면 표시.

                }
                else
                {
                    InitializeControl();

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

        #region ○ 엑셀 저장 - InputData_Excel_Save()

        private void InputData_Excel_Save()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                bool isError = false;

                //실제데이터
                IWorkbook workbook = spreadsheetControl1.Document;
                Worksheet sheet_0 = workbook.Worksheets[0];

                _pucTABRegisterEntity.COLLECTION_DATE = DateTime.Now.ToString("yyyyMMddHHmmss");

                isError = new ucTABRegisterBusiness().InputData_Excel_Save(_pucTABRegisterEntity, sheet_0);

                if (isError)
                {
                    //오류 발생.
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 오류 발생! 데이터를 확인 하세요.");
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE_ERROR);
                }
                else
                {
                    //InitializeControl();
                    //MainFind_DisplayData();

                    //정상 처리
                    //CoFAS_DevExpressManager.ShowInformationMessage("저장 처리 되었습니다.");
                    //CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SAVE);

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

        #region ○ 키패드 팝업
        private void _lmKEY_PAD_Click(object sender, EventArgs e)
        {
            frmPopupKeypad_T04 frmkey = new frmPopupKeypad_T04();

            if (frmkey.ShowDialog() == DialogResult.OK)
            {
                string PopupValue = frmkey.ReturnValue1;
                _luDATA.Text = PopupValue;
            }
        }
        #endregion

        #region ○ 버튼 클릭시 (사용 x)
        //닫기버튼
        public static event OnClickEventHandler _Close_Click;
        public delegate void OnClickEventHandler(object sender, EventArgs e);
        private void _btCancle_Click(object sender, EventArgs e)
        {
            if (_Close_Click != null)
                _Close_Click(sender, e);
        }

        private void _ClickEvent(object sender, EventArgs e)
        {
            var sn = (dynamic)sender;
            string nm = sn.Name;
            string name = nm.Substring(3, nm.Length - 3);

            string windowName = null;

            switch (name)
            {
                case "SEARCH":

                    windowName = "TABSearch";

                    break;

                case "REGISTER":

                    windowName = "TABRegister";

                    break;

                case "COMMENT":

                    windowName = "TABComment";

                    break;

                case "EXCEL":

                    windowName = "TABExcel";

                    break;
            }

            _pfrmTABMain.USER_CONTROL_CHANGE = windowName;
        }

        #endregion

        #region ○ 알림 메시지

        private void MessageBoxFormClosing(Form fm)
        {

            if (fm.InvokeRequired)
            {
                Action<Form> closeform = new Action<Form>(MessageBoxFormClosing);
                this.Invoke(closeform, fm);
            }
            else
            {
                if (fm != null) fm.Close();
            }
        }

        private void Message_Click(object sender, EventArgs e)
        {
            Form msgfm = new Form();
            msgfm.BackColor = Color.LightSkyBlue;
            msgfm.ForeColor = Color.White;
            msgfm.FormBorderStyle = FormBorderStyle.None;

            Action clse = new Action(() =>
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(2000);
                    break;
                }
                MessageBoxFormClosing(msgfm);
            });
            clse.BeginInvoke(ir => clse.EndInvoke(ir), null);
            MessageBox.Show(msgfm, text);
        }

        #endregion

    }
}
