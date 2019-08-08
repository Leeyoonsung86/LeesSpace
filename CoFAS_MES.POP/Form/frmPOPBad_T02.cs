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

namespace CoFAS_MES.POP
{
    public partial class frmPOPBad_T02 : frmBaseSingle
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


        private POPProductionOrder_T03Entity _pPOPProductionOrder_T03Entity = null; // 엔티티 생성
        private DataTable _dtList = null; //조회 데이터 리스트
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        public UserEntity _pUserEntity = null;

        public string titleName = "";
        public string ReturnValue1 { get; set; }    //수량
        public string ReturnValue2 { get; set; }    //불량코드

        public frmPOPBad_T02()
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
                Initialize();
                InitializeControl();
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Size = new Size(1280, 960);
                this.StartPosition = FormStartPosition.Manual;
                this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
                this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        // 초기화 처리 영역
        private void Initialize()
        {
            try
            {
                switch (Properties.Settings.Default.DB_ID.ToString())
                {
                    case "MySql":
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.SQLServer;
                        break;
                    case "SQLServer":
                        DBManager.PrimaryDBManagerType = DBManagerType.SQLServer;//.SQLServer;
                        break;
                    default:
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.SQLServer;
                        break;
                }

                DBManager.PrimaryConnectionString = string.Format
               (
                   //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                   "Server={0};Database={1};UID={2};PWD={3}",
                   Properties.Settings.Default.SERVER_IP.ToString(),
                   Properties.Settings.Default.DB_NAME.ToString(),
                   Properties.Settings.Default.DB_ID.ToString(),
                   "0we11Passw0rd!@#dbmes"
               );
                WindowName = titleName;

                ucTextKeypad.Font = new Font("굴림", 25, FontStyle.Bold);
                ucTextKeypad.TextAlignment = DevExpress.Utils.HorzAlignment.Far;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Initialize()", pException);
            }
        }

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl()
        {
            try
            {
                _luT_BadCode.Font = new Font("굴림", 20);
                _luT_BadSubCode.Font = new Font("굴림", 20);

                _luT_BadCode.ValueChanged += new EventHandler(_luT_BadCode_ValueChanged);
                _luT_BadCode.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("", _pLANGUAGE_TYPE, "POP_BAD1_CODE", "", "", "").Tables[0], 0, 0, "", false);
                
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
                _pUSER_CODE = _pUserEntity.USER_CODE;
                _pUSER_NAME = _pUserEntity.USER_NAME;
                _pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = _pUserEntity.FONT_TYPE;
                _pFONT_SIZE = _pUserEntity.FONT_SIZE;
                //메뉴 화면 엔티티 설정
                _pPOPProductionOrder_T03Entity = new POPProductionOrder_T03Entity();
                _pPOPProductionOrder_T03Entity.CORP_CODE = _pUserEntity.CORP_CODE;
                _pPOPProductionOrder_T03Entity.USER_CODE = _pUserEntity.USER_CODE;
                _pPOPProductionOrder_T03Entity.LANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                _pPOPProductionOrder_T03Entity.PROCESS_CODE = _pUserEntity.PROCESS_CODE;
                _pPOPProductionOrder_T03Entity.RESOURCE_CODE = _pUserEntity.RESOURCE_CODE;

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
                    // _gdMAIN_VIEW.OptionsView.RowAutoHeight = true;
                }

                //_gdSUB_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdSUB, _gdSUB_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pWINDOW_NAME, _gdSUB.Name.ToString()));
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

        private void _luT_BadCode_ValueChanged(object sender, EventArgs e)
        {
            _luT_BadSubCode.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("", _pLANGUAGE_TYPE, "POP_BAD2_CODE", _luT_BadCode.GetValue(), "", "").Tables[0], 0, 0, "", false);
            
            //throw new NotImplementedException();
        }

        #endregion


        #region ○ 버튼 클릭시

        private void btnCmd_Click(object pSender, EventArgs pEventArgs)
        {
            SimpleButton pCmd = pSender as SimpleButton;

            string sCls = pCmd.Name.Substring(6, 2);
            switch (sCls)
            {
                case "00":
                    ucTextKeypad.Text += "0";

                    if (ucTextKeypad.Text.Length < 4)
                    {
                        if (ucTextKeypad.Text == "-00" || ucTextKeypad.Text == "00")
                        {
                            ucTextKeypad.Text = ucTextKeypad.Text.Substring(0, ucTextKeypad.Text.Length - 1);
                        }
                    }

                    break;

                case "01":
                    ucTextKeypad.Text += "1";
                    break;

                case "02":
                    ucTextKeypad.Text += "2";
                    break;

                case "03":
                    ucTextKeypad.Text += "3";
                    break;

                case "04":
                    ucTextKeypad.Text += "4";
                    break;

                case "05":
                    ucTextKeypad.Text += "5";
                    break;

                case "06":
                    ucTextKeypad.Text += "6";
                    break;

                case "07":
                    ucTextKeypad.Text += "7";
                    break;

                case "08":
                    ucTextKeypad.Text += "8";
                    break;

                case "09":
                    ucTextKeypad.Text += "9";
                    break;

                case "10":
                    ucTextKeypad.Text += "0";
                    break;

                case "20":
                    // 저장
                    //검사등록
                    if (CoFAS_DevExpressManager.ShowQuestionMessage("불량실적을 등록 하시겠습니까?") == DialogResult.Yes)
                    {

                        decimal temp = 0;

                        if (decimal.TryParse(ucTextKeypad.Text, out temp))
                        {
                            ucTextKeypad.Text = decimal.Parse(ucTextKeypad.Text).ToString();


                            this.DialogResult = DialogResult.OK;
                            ReturnValue1 = ucTextKeypad.Text;
                            ReturnValue2 = _luT_BadSubCode.GetValue();
                            this.Close();
                        }
                        else
                        {
                            if (ucTextKeypad.Text == "0" || ucTextKeypad.Text.Trim() == "")
                            {
                                return;
                            }
                        }
                    }
                    break;

                case "30":
                    // BS
                    if (ucTextKeypad.Text.Length > 0)
                    {
                        ucTextKeypad.Text = ucTextKeypad.Text.Substring(0, ucTextKeypad.Text.Length - 1);

                    }
                    break;

                case "40":
                    //취소
                    this.DialogResult = DialogResult.No;
                    this.Close();
                    break;

                case "50":
                    //. 소수점
                    if (ucTextKeypad.Text.Length > 0 && ucTextKeypad.Text.IndexOf('.') == -1)
                    {
                        ucTextKeypad.Text += ".";
                    }
                    break;

                case "60":
                    //- 마이너스
                    if (ucTextKeypad.Text.IndexOf('-') < 0)
                    {
                        ucTextKeypad.Text = ucTextKeypad.Text.Insert(0, "-");
                    }
                    break;

                case "70":
                    //+ 플러스
                    if (ucTextKeypad.Text.IndexOf('-') > -1)
                    {
                        ucTextKeypad.Text = ucTextKeypad.Text.Replace("-", string.Empty);
                    }
                    break;


                default: break;
            }
            ucTextKeypad.Focus();

        }

        #endregion

        #region ○ 메인조회 - MainFind_DisplayData()
        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _dtList = new POPProductionOrder_T03Business().POPProductionOrder_Info(_pPOPProductionOrder_T03Entity);

                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pPOPProductionOrder_T03Entity.CRUD == ""))
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
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

