using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.UserForm;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.UI.QC.Business;
using CoFAS_MES.UI.QC.Entity;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Spreadsheet;
using Newtonsoft.Json;
using System.IO;
using static CoFAS_MES.CORE.BaseControls.ucSpreadSheetControl;
using DevExpress.XtraSpreadsheet;

namespace CoFAS_MES.UI.QC
{
    public partial class CheckDataView : frmBaseNone
    {
        public string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private System.Drawing.Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부

        private CheckDataViewEntity _pCheckDataViewEntity = null; // 엔티티 생성

        private System.Data.DataTable _dtList = null; //조회 데이터 리스트
        private System.Data.DataTable _dtList_Mst = null; // 마스터 데이터 리스트
        private System.Data.DataTable _dtList_Sub = null;

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

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

        private string _pUSER_GRANT = string.Empty;

        //알림창메시지 복사 끝

        string fileName = "";
        string fileFullName = "";
        string filePath = "";
        
        IWorkbook wb = null;
        IWorkbook basewb = null;
        Worksheet worksheet = null;
        string worksheetName = string.Empty;

        public CheckDataView()
        {
            InitializeComponent();

            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        #region ○ Form_Load
        private void Form_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            try
            {
                InitializeSetting();

                //버튼이벤트 생성
                SearchButtonClicked += new EventHandler(Form_SearchButtonClicked);
                SaveButtonClicked += new EventHandler(Form_SaveButtonClicked);
                ExportButtonClicked += new EventHandler(Form_ExortButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);

                CoFAS_ControlManager.SetFontInControls(this.Controls, _pFONT_SETTING);

                Form_SearchButtonClicked(null, null);

                //CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                //OpenFileDialog opd = new OpenFileDialog();
                //opd.FileName = "";
                //opd.Filter = "Excel Files(.xls)|*.xls|Excel Files(.xlsx) | *.xlsx |Excel Files(*.xlsm) | *.xlsm|Excel Files파일(*.xlsx)|*.xlsx";
                //opd.Title = "엑셀 저장";

                //if (opd.ShowDialog() == DialogResult.OK)
                //{
                //    fileName = opd.SafeFileName;
                //    fileFullName = opd.FileName;
                //    filePath = fileFullName.Replace(fileName, "");

                //    _sdMAIN.LoadDocument(fileFullName);

                //    wb = _sdMAIN.Document;
                //    basewb = _sdMAIN.Document;
                //    //    worksheetName = _sdMAIN.ActiveSheet.Name;
                //    //    worksheet = wb.Worksheets[worksheetName];
                //    //}
                //}
                //SheetFind_DisplayData();
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

        #region ○ Form_FormClosed
        private void Form_FormClosed(object sender, FormClosedEventArgs pFormClosedEventArgs)
        {
            //throw new NotImplementedException();
            try
            {
                //화면 레이아웃 저장 ?
                _gdMAIN_VIEW.RowCellClick -= _gdMAIN_VIEW_RowCellClick;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ Form_Closing
        private void Form_Closing(object sender, FormClosingEventArgs pFormClosingEventArgs)
        {
            //throw new NotImplementedException();
            try
            {
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ Form_Activated
        private void Form_Activated(object sender, EventArgs pEventArgs)
        {
            //throw new NotImplementedException();
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
                //_pnLeft.Size = new Size(552, 605);

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

                //메뉴 화면 엔티티 설정
                _pCheckDataViewEntity = new CheckDataViewEntity();
                _pCheckDataViewEntity.USER_CODE = _pUSER_CODE;
                _pCheckDataViewEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;


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

                _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;

                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pCheckDataViewEntity.CRUD = "";

                //MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                //SubFind_DisplayData();

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
                _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
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
                _luT_REG_DATE.FromDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  //조회 시작일, 매월 초 날짜로 설정
                _luT_REG_DATE.ToDateTime = DateTime.Today;  //조회 종료일, 당일 설정
                _luT_PART_NAME.Text = "";
                _luT_LOT_NO.Text = "";
                
                //_luT_BAD_GROUP_CODE.Text = "";
                //_luT_BAD_GROUP_NAME.Text = "";

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 

                //dxValidationProvider.SetValidationRule(_luGRID_NAME, NotEmptyValidationRule);
                //dxValidationProvider.SetValidationRule(_luGRIDVIEW_NAME, NotEmptyValidationRule);
                // 컨트롤러 유효성 검증 처리
                //메인 그리드
                //_gdMAIN.DataSource = null;

                //서브그리드 초기화
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

        // 메인 버튼 처리영역

        #region ○ 조회 버튼 클릭시 처리하기
        private void Form_SearchButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                MainFind_DisplayData();
                //SheetFind_DisplayData();
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
                {
                    return;
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
                Form_InitialButtonClicked(null, null);
                Form_SearchButtonClicked(null, null);
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

        #region ○ 내보내기 버튼 클릭시 처리하기
        private void Form_ExortButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                if (_gdMAIN.DataSource == null) return;
                _sdMAIN.SaveDocumentAs();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ 초기화 버튼 클릭시 처리하기
        private void Form_InitialButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                _luT_PART_NAME.Text = "";
                _luT_LOT_NO.Text = "";
                _gdMAIN.DataSource = null;
                Worksheet ws = _sdMAIN.Document.Worksheets[0];
                ws.Clear(ws.GetUsedRange());

                wb = _sdMAIN.Document;
                basewb = _sdMAIN.Document;

                InitializeSetting();

                //SheetFind_DisplayData();

                DisplayMessage(_pMSG_RESET_COMPLETE);
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

        // 추가 이벤트 영역

        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                Worksheet ws = _sdMAIN.Document.Worksheets[0];
                ws.Clear(ws.GetUsedRange());

                SheetFind_DisplayData();
                
                

                wb = _sdMAIN.Document;
                worksheet = wb.Worksheets[_sdMAIN.ActiveSheet.Name];

                GridView gv = sender as GridView;
                if (e.RowHandle < 0) return;
                if (gv.GetFocusedRowCellValue("SEQ") == null) return;
                string strPartName = gv.GetFocusedRowCellValue("PART_NAME").ToString();
                string strLotNo = gv.GetFocusedRowCellValue("LOT_NO").ToString();
                string strTrsNo = gv.GetFocusedRowCellValue("TRS_NO").ToString();
                string strFpsTrsNo = gv.GetFocusedRowCellValue("FPS_TRS_NO").ToString();

                #region 헤드 조정

                //worksheet.Range["A1"].ColumnWidth = 1;

                worksheet.Range["B2"].Value = strPartName + "_SQC Chart";
                //worksheet.Range["B2:P2"].Font.Bold = true;
                //worksheet.Range["B2:P2"].Font.Size = 36;
                //worksheet.MergeCells(worksheet.Range["B2:P2"]);
                //worksheet.Range["B2:P2"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                //worksheet.Range["B2:P2"].Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
                worksheet.Range["B2"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;

                //worksheet.Range["AB2"].Value = "목표"; worksheet.Range["AB2"].Fill.BackgroundColor = Color.LightGreen;
                //worksheet.Range["AC2"].Value = "주의"; worksheet.Range["AC2"].Fill.BackgroundColor = Color.LightYellow;
                //worksheet.Range["AD2"].Value = "개선"; worksheet.Range["AD2"].Fill.BackgroundColor = Color.LightPink;
                //worksheet.Range["AE2"].Value = "정지"; worksheet.Range["AE2"].Fill.BackgroundColor = Color.PaleVioletRed;

                //worksheet.Range["B4"].Value = "LOT No.";
                //worksheet.MergeCells(worksheet.Range["B4:B5"]);

                //worksheet.Range["C4"].Value = "QCC";

                //worksheet.Range["C5"].Value = "CHARAC.";

                //worksheet.Range["D4"].Value = "SPEC.";
                //worksheet.MergeCells(worksheet.Range["D4:E4"]);
                //worksheet.Range["D5"].Value = "상한";
                //worksheet.Range["E5"].Value = "하한";

                //worksheet.Range["F4"].Value = "측정값";
                //worksheet.MergeCells(worksheet.Range["F4:V4"]);
                //for (int i = 0; i < 17; i++)
                //    worksheet.Cells[4, i + 5].Value = i + 1;

                //worksheet.Range["W4"].Value = "SQC";
                //worksheet.MergeCells(worksheet.Range["W4:AD4"]);
                //worksheet.Range["W5"].Value = "Acc/Rej";
                //worksheet.Range["X5"].Value = "평균";
                //worksheet.Range["Y5"].Value = "표준편차";
                //worksheet.Range["Z5"].Value = "6시그마";
                //worksheet.Range["AA5"].Value = "공차영역";
                //worksheet.Range["AB5"].Value = "Cp";
                //worksheet.Range["AC5"].Value = "중심편차";
                //worksheet.Range["AD5"].Value = "Cpk";

                //worksheet.Range["B4:AD5"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                //worksheet.Range["B4:AD5"].Alignment.Vertical = SpreadsheetVerticalAlignment.Center;

                #endregion

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pCheckDataViewEntity.SEQ = gv.GetFocusedRowCellValue("SEQ").ToString();
                _dtList_Mst = new CheckDataViewBusiness().Excel_Json_Mst_Sub_Info(_pCheckDataViewEntity);

                if (_dtList_Mst == null) return;

                if (_dtList_Mst.Rows.Count > 0)
                {
                    int totalrow = 6;

                    for (int i = 0; i < _dtList_Mst.Rows.Count; i++)
                    {
                        //worksheet.Rows.Insert(totalrow);
                        //worksheet.Rows[totalrow].CopyFrom(worksheet.Rows[totalrow + 1], PasteSpecial.Borders | PasteSpecial.Formats | PasteSpecial.Formulas | PasteSpecial.NumberFormats);// Insert(totalrow+1);


                        worksheet.Cells[totalrow, 2].Value = _dtList_Mst.Rows[i]["charac3"].ToString();
                        _pCheckDataViewEntity.JSONCOL = _dtList_Mst.Rows[i]["charac2"].ToString();
                        _dtList_Sub = new CheckDataViewBusiness().Excel_Json_Sub_Info(_pCheckDataViewEntity);

                        int colcount = 1;
                        if (_dtList_Sub.Rows.Count == 0)
                        {
                            totalrow++;
                        }
                        else
                        {
                            double rowsum = 0;
                            List<double> arr_rownum = new List<double>();
                            for (int j = 0; j < _dtList_Sub.Rows.Count; j++)
                            {
                                if (colcount == 1)
                                {
                                    double numchk_min = 0.0;
                                    double numchk_max = 0.0;
                                    bool isNum_min = double.TryParse(_dtList_Mst.Rows[i]["min"].ToString(), out numchk_min);
                                    bool isNum_max = double.TryParse(_dtList_Mst.Rows[i]["max"].ToString(), out numchk_max);
                                    if (isNum_min)
                                    {
                                        worksheet.Cells[totalrow, 4].Value = Convert.ToDouble(_dtList_Mst.Rows[i]["min"].ToString());
                                    }
                                    else
                                    {
                                        worksheet.Cells[totalrow, 4].Value = _dtList_Mst.Rows[i]["min"].ToString();
                                    }

                                    if (isNum_max)
                                    {
                                        worksheet.Cells[totalrow, 3].Value = Convert.ToDouble(_dtList_Mst.Rows[i]["max"].ToString());
                                    }
                                    else
                                    {
                                        worksheet.Cells[totalrow, 3].Value = _dtList_Mst.Rows[i]["max"].ToString();
                                    }
                                }
                                worksheet.Cells[totalrow, colcount + 4].Value = Convert.ToDouble(_dtList_Sub.Rows[j]["jdata"].ToString());
                                if (colcount == 17)
                                {
                                    //worksheet.Cells[totalrow, 23].Value = "=AVERAGE(F" + totalrow + 1 + ":V" + totalrow + 1 + ")";
                                    totalrow++;
                                    colcount = 1;
                                }
                                else
                                    colcount++;


                                arr_rownum.Add(Convert.ToDouble(_dtList_Sub.Rows[j]["jdata"].ToString()));
                                rowsum = Json_DoubleSum(rowsum, Convert.ToDouble(_dtList_Sub.Rows[j]["jdata"].ToString()));

                                ////평균
                                //worksheet.Cells[totalrow, 23].Formula = @"=IF(G" + (totalrow + 1) + @"="""","""",+AVERAGE(F" + (totalrow + 1) + ": V" + (totalrow + 1) + "))"; ;
                                ////표준편차
                                //worksheet.Cells[totalrow, 24].Formula = @"=IF(G" + (totalrow + 1) + @"="""","""",+STDEVP(F" + (totalrow + 1) + ":V" + (totalrow + 1) + "))";
                                ////6시그마
                                //worksheet.Cells[totalrow, 25].Formula = @"=IF(Y" + (totalrow + 1) + @"= """","""",IF(Y" + (totalrow + 1) + @"= 0,"""",+Y" + (totalrow + 1) + "* 6))";
                                ////공차영역
                                //worksheet.Cells[totalrow, 26].Formula = @"=IF(F" + (totalrow + 1) + @"= """","""",+D" + (totalrow + 1) + "-E" + (totalrow + 1) + ")";
                                ////Cp
                                //worksheet.Cells[totalrow, 27].Formula = @"=IF(Z" + (totalrow + 1) + @"= """","""",AA" + (totalrow + 1) + "/Z" + (totalrow + 1) + ")";
                                ////중심편차
                                //worksheet.Cells[totalrow, 28].Formula = @"=IF(COUNT(D" + (totalrow + 1) + ":E" + (totalrow + 1) + @")= 0,"""",IF(X" + (totalrow + 1) + @"= """","""",X" + (totalrow + 1) + "- ((D" + (totalrow + 1) + "+ E" + (totalrow + 1) + ")/ 2)))";
                                ////Cpk
                                //worksheet.Cells[totalrow, 29].Formula = @"=IF(AB" + (totalrow + 1) + @"= """","""",(1-(SQRT(AC" + (totalrow + 1) + "^ 2)/((D" + (totalrow + 1) + "- E" + (totalrow + 1) + ")/ 2)))*AB" + (totalrow + 1) + ")";
                            }


                            //조건부서식
                            //--------------------------------------------------------------------------------------------------------------------------------
                            //string stemp = worksheet.Cells[totalrow,4].Value.ToString();
                            //string stemp2 = worksheet.Cells[totalrow,5].Value.ToString();

                            //RangeConditionalFormatting exRule2 = worksheet.ConditionalFormattings.AddRangeConditionalFormatting(worksheet.Range["F" + totalrow + ":V" + totalrow], ConditionalFormattingRangeCondition.Outside, stemp, stemp2);
                            //exRule2.Formatting.Fill.BackgroundColor = Color.Red;
                            //exRule2.StopIfTrue = true;

                            //double sDoubletemp = Convert.ToDouble(worksheet.Range["D" + totalrow]) - (Convert.ToDouble(worksheet.Range["AA" + totalrow]) / 3);
                            //double sDoubletemp2 = Convert.ToDouble(worksheet.Range["E" + totalrow]) + (Convert.ToDouble(worksheet.Range["AA" + totalrow]) / 3);

                            //RangeConditionalFormatting exRule4 = worksheet.ConditionalFormattings.AddRangeConditionalFormatting(worksheet.Range["F" + totalrow + ":V" + totalrow], ConditionalFormattingRangeCondition.Inside, sDoubletemp.ToString(), sDoubletemp2.ToString());
                            //exRule4.Formatting.Fill.BackgroundColor = Color.LightPink;
                            //exRule4.StopIfTrue = true;

                            //RangeConditionalFormatting exRule3 = worksheet.ConditionalFormattings.AddRangeConditionalFormatting(worksheet.Range["F" + totalrow + ":V" + totalrow], ConditionalFormattingRangeCondition.Inside, (("$D" + totalrow) + "-" + "($AA" + totalrow + "/6)"), (("$E" + totalrow) + "+" + "($AA" + totalrow + "/6)"));
                            //exRule3.Formatting.Fill.BackgroundColor = Color.Yellow;
                            //exRule3.StopIfTrue = true;

                            //RangeConditionalFormatting exRule5 = worksheet.ConditionalFormattings.AddRangeConditionalFormatting(worksheet.Range["F" + totalrow + ":V" + totalrow], ConditionalFormattingRangeCondition.Inside, "$D" + totalrow + "-" + "($AA" + totalrow + "/3)", "$E" + totalrow + "+" + "($AA" + totalrow + "/3)");
                            //exRule5.Formatting.Fill.BackgroundColor = Color.LightGreen;
                            //exRule5.StopIfTrue = true;

                            //ExpressionConditionalFormatting exRule1 = worksheet.ConditionalFormattings.AddExpressionConditionalFormatting(worksheet.Range["F" + totalrow + ":V" + totalrow], ConditionalFormattingExpressionCondition.EqualTo, "0");
                            //exRule1.Formatting.Fill.BackgroundColor = Color.White;
                            //exRule1.StopIfTrue = true;
                            //--------------------------------------------------------------------------------------------------------------------------------


                            //평균
                            double sheet23 = (double)rowsum / (double)(colcount - 1);
                            worksheet.Cells[totalrow, 23].Value = sheet23;
                            //표준편차
                            double sheet24 = GetStandardDeviation(arr_rownum);
                            worksheet.Cells[totalrow, 24].Value = sheet24;
                            //6시그마
                            double sheet25 = sheet24 * 6;
                            worksheet.Cells[totalrow, 25].Value = sheet25;
                            double numchk1 = 0.0;
                            double numchk2 = 0.0;
                            bool isNum1 = double.TryParse(worksheet.Cells[totalrow, 3].Value.ToString(), out numchk1);
                            bool isNum2 = double.TryParse(worksheet.Cells[totalrow, 4].Value.ToString(), out numchk2);
                            if (isNum1 && isNum2)
                            {
                                //공차영역
                                double sheet26 = Convert.ToDouble(worksheet.Cells[totalrow, 3].Value.ToString()) - Convert.ToDouble(worksheet.Cells[totalrow, 4].Value.ToString());
                                worksheet.Cells[totalrow, 26].Value = sheet26;
                                //Cp
                                double sheet27 = sheet26 / sheet25;
                                worksheet.Cells[totalrow, 27].Value = sheet27;
                                //중심편차
                                double sheet28 = sheet23 - ((Convert.ToDouble(worksheet.Cells[totalrow, 3].Value.ToString()) + Convert.ToDouble(worksheet.Cells[totalrow, 4].Value.ToString())) / 2);
                                worksheet.Cells[totalrow, 28].Value = sheet28;
                                //Cpk
                                double sheet29 = (1 - (Math.Sqrt((sheet28 * sheet28)) / (sheet26 / 2))) * sheet27;
                                worksheet.Cells[totalrow, 29].Value = sheet29;

                            }
                            else
                            {
                                worksheet.Cells[totalrow, 26].Value = "";
                                worksheet.Cells[totalrow, 27].Value = "";
                                worksheet.Cells[totalrow, 28].Value = "";
                                worksheet.Cells[totalrow, 29].Value = "";
                            }


                            colcount = 1;
                            totalrow++;
                            //Range tempRange = worksheet.Range["B" + totalrow+1 + ":AD" + totalrow+1];
                            //worksheet.Range["B" + (totalrow+2) + ":AD" + (totalrow+2)].CopyFrom(tempRange, PasteSpecial.Borders);
                            //worksheet.Rows[totalrow].CopyFrom(worksheet.Rows[totalrow+1]);
                        }
                    }

                    //worksheet.Range["X" + totalrow + ":AD" + totalrow].NumberFormat = "0.000";
                    

                }

                //#region 헤드 컬럼 조정

                //worksheet.Range["A4"].Value = "PART_NAME";
                //worksheet.Range["A4:B4"].Font.Bold = true; 
                //worksheet.MergeCells(worksheet.Range["A4:B4"]);
                //worksheet.Range["A4:B4"].Fill.BackgroundColor = Color.Yellow;

                //worksheet.Range["C4"].Value = strPartName;
                //worksheet.MergeCells(worksheet.Range["C4:F4"]);

                //worksheet.Range["G4"].Value = "LOT_NO";
                //worksheet.Range["G4:H4"].Font.Bold = true; 
                //worksheet.MergeCells(worksheet.Range["G4:H4"]);
                //worksheet.Range["G4:H4"].Fill.BackgroundColor = Color.Yellow;

                //worksheet.Range["I4"].Value = strPartName;
                //worksheet.MergeCells(worksheet.Range["I4:L4"]);

                //worksheet.Range["A4:L4"].Font.Size = 15;
                //worksheet.Range["A4:L4"].Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin);
                //worksheet.Range["A4:L4"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                //worksheet.Range["A4:L4"].Alignment.Vertical = SpreadsheetVerticalAlignment.Center;

                //worksheet.Range["A12"].Value = "CHARAC.";
                //worksheet.MergeCells(worksheet.Range["A12:A14"]);

                //worksheet.Range["A15"].Value = "SPEC.";
                //worksheet.MergeCells(worksheet.Range["A15:A16"]);

                //worksheet.Range["A17"].Value = "EQUIP.";

                //worksheet.Range["A18"].Value = "MIN";

                //worksheet.Range["A19"].Value = "MAX";

                //worksheet.Range["A12:A19"].Fill.BackgroundColor = Color.Yellow;
                //worksheet.Range["A12:A19"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                //worksheet.Range["A12:A19"].Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
                //worksheet.Range["A12:A19"].Font.Bold = true;

                //#endregion

                //CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                //_pCheckDataViewEntity.SEQ = gv.GetFocusedRowCellValue("SEQ").ToString();
                //_dtList_Mst = new CheckDataViewBusiness().Excel_Json_Mst_Sub_Info(_pCheckDataViewEntity);

                //if (_dtList_Mst == null) return;

                //if (_dtList_Mst.Rows.Count > 0)
                //{

                //    DataTable _dtList_Mst_Result = new DataTable();
                //    for (int i = 0; i < _dtList_Mst.Rows.Count; i++) { _dtList_Mst_Result.Columns.Add((i + 1).ToString(), typeof(string)); }

                //    for (int i = 4; i < _dtList_Mst.Columns.Count; i++)
                //    {
                //        DataRow drTemp = _dtList_Mst_Result.NewRow();
                //        for (int j = 0; j < _dtList_Mst.Rows.Count; j++)
                //        {
                //            drTemp[j] = _dtList_Mst.Rows[j][i].ToString();
                //        }

                //        _dtList_Mst_Result.Rows.Add(drTemp);
                //    }

                //    worksheet.Import(_dtList_Mst_Result, false, 11, 1);
                //    Range aRng = spreadsheetControl1.Document.Worksheets.ActiveWorksheet.Columns[_dtList_Mst.Rows.Count];
                //    string[] saRng = aRng.GetReferenceA1().Replace("$","").Split(':');
                //    worksheet.Range["A12:" + saRng[1].ToString() + "19"].Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin);
                //    worksheet.Range["A13:" + saRng[1].ToString() + "13"].Fill.BackgroundColor = Color.LightCoral;
                //}


                //// 서브조회 시작
                //_dtList_Sub = new CheckDataViewBusiness().Excel_Json_Sub_Info(_pCheckDataViewEntity);
                //DataTable dtJson = null;
                //DataTable dtResult = null;

                //if (_dtList_Sub == null) return;
                //if (_dtList_Sub.Rows.Count > 0)
                //{
                //    dtJson = (DataTable)JsonConvert.DeserializeObject("[" + _dtList_Sub.Rows[0][1].ToString().Replace("\\", "") + "]", (typeof(DataTable)));
                //    dtResult = dtJson.Clone();


                //    for (int i = 0; i < _dtList_Sub.Rows.Count; i++)
                //    {
                //        dtJson.Clear();

                //        dtJson = (DataTable)JsonConvert.DeserializeObject("[" + _dtList_Sub.Rows[i][1].ToString().Replace("\\", "") + "]", (typeof(DataTable)));

                //        dtResult.Merge(dtJson);
                //    }
                //}

                //worksheet.Import(dtResult,false, 19, 0);


                

                // AutoFit
                Range oRng = _sdMAIN.Document.Worksheets.ActiveWorksheet.Columns[_dtList_Mst.Rows.Count];
                string[] soRng = oRng.GetReferenceA1().Split(':');
                _sdMAIN.ActiveWorksheet["C:" + soRng[1].ToString()].AutoFitColumns();

                Range Rng = _sdMAIN.ActiveWorksheet.GetDataRange();
                string sRng = Rng.GetReferenceA1().Replace("$", "");
                worksheet.Range[sRng.ToString()].Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
                worksheet.Range[sRng.ToString()].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            } finally
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }
        #endregion

        //합계
        double  Json_DoubleSum(double rowsum, double rownum)
        {
            double row_num_sum = rowsum;
            row_num_sum += rownum;
            return row_num_sum;
        }

        // 표준편차
        public double GetStandardDeviation(List<double> valueArray)
        {
            double standardDeviation = 0;
            double M = 0.0;
            double S = 0.0;
            int k = 0;
            try
            {
                foreach (double value in valueArray)
                {
                    k++;
                    double tmpM = M;
                    M += (value - tmpM) / k;
                    S += (value - tmpM) * (value - M);
                }
                standardDeviation = Math.Sqrt(S / k);
            }
            catch (Exception)
            {
                throw;
            }
            return standardDeviation;
        }

        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()
        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                _pCheckDataViewEntity.DATE_FROM = Convert.ToString(_luT_REG_DATE.FromDateTime).Substring(0, 10).Replace("-", "");
                _pCheckDataViewEntity.DATE_TO = Convert.ToString(_luT_REG_DATE.ToDateTime).Substring(0, 10).Replace("-", "");
                _pCheckDataViewEntity.PART_NAME = _luT_PART_NAME.Text.ToString();
                _pCheckDataViewEntity.LOT_NO = _luT_LOT_NO.Text.ToString();
                _pCheckDataViewEntity.TRS_NO = _luT_TRS_NO.Text.ToString();
                _pCheckDataViewEntity.FPS_TRS_NO = _luT_FPS_TRS_NO.Text.ToString();

                _dtList = new CheckDataViewBusiness().Excel_Json_Mst_Info(_pCheckDataViewEntity);

                if (_dtList != null && _dtList.Rows.Count > 0 || _dtList != null)
                {
                    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩

                    if (_pLocation_Code != "" && _pLocation_YN)
                    {
                        int rowHandle = _gdMAIN_VIEW.LocateByValue("SEQ", _pLocation_Code);
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            _gdMAIN_VIEW.FocusedRowHandle = rowHandle;

                        //조회 후 초기화 
                        _pLocation_Code = "";
                    }
                }
                else
                {
                    _gdMAIN.DataSource = null;
                    InitializeControl();
                    //DisplayMessage("조회 내역이 없습니다.");
                    DisplayMessage(_pMSG_SEARCH_EMPT);
                    //CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                    CoFAS_DevExpressManager.ShowInformationMessage(_pMSG_SEARCH_EMPT);
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

        #region ○ 서브조회 - SubFind_DisplayData()

        private void SubFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                //_dtList = new BadCodeMstRegisterBusiness().BadCode_Info_Detail(_pBadCodeMstRegisterEntity);

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

        #region ○ 시트조회 - SheetFind_DisplayData()

        private void SheetFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                string strFTP_PATH = "";
                string strUSE_TYPE = "";
                string strFILE_NAME = "";
                _pCheckDataViewEntity.CRUD = "R";
                _pCheckDataViewEntity.WINDOW_NAME = _pWINDOW_NAME;
                _dtList = new CheckDataViewBusiness().Sheet_Info_Sheet(_pCheckDataViewEntity);   //엑셀 시트 조회하기

                strUSE_TYPE = _dtList.Rows[0]["USE_TYPE"].ToString();
                strFILE_NAME = _dtList.Rows[0]["FILE_NAME"].ToString();
                _pFTP_PATH = MainForm.UserEntity.FTP_IP_PORT;
                switch (strUSE_TYPE)
                {
                    case "PRINT":
                        strFTP_PATH = string.Format(@"{0}{1}/", _pFTP_PATH, "ORDER_FORM");
                        break;
                    case "VIEW":
                        strFTP_PATH = string.Format(@"{0}{1}/{2}/{3}/", _pFTP_PATH, "USER", "PROGRAM_VIEW", _pWINDOW_NAME);
                        break;
                }

                if (_dtList != null)
                {
                    using (Stream responseStream = CORE.Function.CoFAS_FTPManager.FTPFileBinding(strFTP_PATH, strFILE_NAME, _pFTP_ID, _pFTP_PW))
                    {
                        if (responseStream != null)
                        {
                            _sdMAIN.LoadDocument(responseStream, DocumentFormat.Xlsx);
                            //_sdMAIN.LoadDocument((byte[])_ojList, DocumentFormat.Xlsx);    // 일반 컨트롤 일때 : DocumentFormat.Xls   // UC일때,  enFileFormat.Xls
                        }
                        else
                        {
                            _sdMAIN.CloseCellEditor(CellEditorEnterValueMode.Default);
                            _sdMAIN.CreateNewDocument();
                        }
                    }
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                }






                //_ojList = new ProcessMaterialStockStatusBusiness().Sheet_Info_Sheet(_pProcessMaterialStockStatusEntity);

                //if (_ojList != null)
                //{
                //    _sdMAIN.LoadDocument((byte[])_ojList, DocumentFormat.Xlsx);    // 일반 컨트롤 일때 : DocumentFormat.Xls   // UC일때,  enFileFormat.Xls
                //}
                //else
                //{
                //    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                //}
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
    }
}