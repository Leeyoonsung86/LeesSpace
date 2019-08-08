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
using System.Diagnostics;
using DevExpress.Spreadsheet;
using DevExpress.Utils.Extensions;

namespace CoFAS_MES.UI.QC
{
    public partial class CheckDataRegister : frmBaseNone
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
        private string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보
        private string _pLocation_Code = string.Empty;  // 저장/수정 후 로케이션 위치 저장
        private bool _pLocation_YN = true;              // 저장위치 사용여부

        private CheckDataRegisterEntity _pCheckDataRegisterEntity = null; // 엔티티 생성

        private System.Data.DataTable _dtList = null; //조회 데이터 리스트

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

        System.Data.DataTable dt_MTemp = null;
        System.Data.DataTable dt_STemp = null;
        string fileName = "";
        string fileFullName = "";
        string filePath = "";
        IWorkbook wb = null;
        Worksheet worksheet = null;
        string worksheetName = string.Empty;

        public CheckDataRegister()
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
                SaveButtonClicked += new EventHandler(Form_SaveButtonClicked);
                ImportButtonClicked += new EventHandler(Form_ImportButtonClicked);
                InitialButtonClicked += new EventHandler(Form_InitialButtonClicked);
                FormCloseButtonClicked += new EventHandler(Form_FormCloseButtonClicked);

                CoFAS_ControlManager.SetFontInControls(this.Controls, _pFONT_SETTING);

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
                //화면 레이아웃 저장 
                //KillSpecificExcelFileProcess(fileFullName.Replace(filePath,""));
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

                //메인 화면 전역 변수 처리
                _pCORP_CODE = MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = MainForm.UserEntity.USER_NAME;
                _pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                _pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;
                _pFONT_SIZE = MainForm.UserEntity.FONT_SIZE;
                _pFONT_SETTING = new System.Drawing.Font(_pFONT_TYPE, _pFONT_SIZE);
                _pFTP_ID = MainForm.UserEntity.FTP_ID;
                _pFTP_IP_PORT = MainForm.UserEntity.FTP_IP_PORT;  //string.Format(@"{0}/{1}/", MainForm.UserEntity.FTP_IP_PORT, "test"); //화면 별 해당 위치 지정
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
                _pCheckDataRegisterEntity = new CheckDataRegisterEntity();
                _pCheckDataRegisterEntity.USER_CODE = _pUSER_CODE;
                _pCheckDataRegisterEntity.LANGUAGE_TYPE = _pLANGUAGE_TYPE;


                //화면 설정 언어 & 명칭 변경.
                System.Data.DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

                if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                {
                    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                }

                //그리드 설정
                //InitializeGrid();

                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 

                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                _pCheckDataRegisterEntity.CRUD = "";

                //MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.

                //SubFind_DisplayData();

                if (_pFirstYN)
                {
                    //컨트롤러 별 추가 이벤트 생성은 화면 설정 마지막에 진행


                    //그리드 버튼추가 시 클릭 이벤트 처리 
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

        #region ○ 컨트롤 초기화 - InitializeControl()

        private void InitializeControl()
        {
            try
            {
                //조회조건 영역 

                // 컨트롤러 유효성 검증 처리 기본 컨트롤러 에서만 사용 
                dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
                dxValidationProvider.Validate();

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

        // 메인 버튼 영역
        #region ○ 저장 버튼 클릭시 처리하기
        private void Form_SaveButtonClicked(object pSender, EventArgs pEventArgs)
        {
            try
            {
                worksheetName = spreadsheetControl1.ActiveSheet.Name;
                if (!worksheetName.Contains("(통합)"))
                {
                    CoFAS_DevExpressManager.ShowErrorMessage("저장 가능한 양식이 아닙니다");
                    worksheetName = string.Empty;
                    return;
                }

                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                if (CoFAS_DevExpressManager.ShowQuestionMessage(_pMSG_SAVE_QUESTION) == DialogResult.No)
                {
                    return;
                }


                wb = spreadsheetControl1.Document;
                worksheet = wb.Worksheets[worksheetName];
                Range part_name = worksheet.Range["C4"];   //마스터정보 PART NAME
                Range lot_no = worksheet.Range["I4"];      // 마스터정보 LOT NO
                Range trs_no = worksheet.Range["C5"];
                Range fps_trs_no = worksheet.Range["I5"];
                Range lot_size = worksheet.Range["M4"];
                Range inspect_qty = worksheet.Range["Q4"];
                Range numVar1 = worksheet.Range["S4"];
                Range numVar2 = worksheet.Range["T4"];

                //int lastRowIgnoreFormulas = worksheet.Cells.Find(
                //                "*",
                //                System.Reflection.Missing.Value,
                //                xlValues,
                //                lWhole,
                //                xlByRows,
                //                xlPrevious,
                //                false,
                //                System.Reflection.Missing.Value,
                //                System.Reflection.Missing.Value).Row;

                //int lastColIgnoreFormulas = worksheet.Cells.Find(
                //                "*",
                //                System.Reflection.Missing.Value,
                //                System.Reflection.Missing.Value,
                //                System.Reflection.Missing.Value,
                //                xlByColumns,
                //                xlPrevious,
                //                false,
                //                System.Reflection.Missing.Value,
                //                System.Reflection.Missing.Value).Column;

                Range usedRange = spreadsheetControl1.Document.Worksheets[worksheetName].GetUsedRange();
                int lastRowIgnoreFormulas = GetEmptyCellRowIndex();
                int lastColIgnoreFormulas = GetEmptyCellColumnIndex(); 
                int row = lastRowIgnoreFormulas;
                int col = lastColIgnoreFormulas;
                System.Data.DataTable dtJson = new System.Data.DataTable();   // JSon DataTable Create
                dtJson.Columns.Add("sub_no", typeof(string));

                int currentSeq = 1;
                string sCurrentSeq = DateTime.Now.ToString("yyyyMMdd") + currentSeq.ToString().PadLeft(4, '0');
                string jsonColName = string.Empty;
                

                // Master Table    // dt_MTemp
                for (int i = 1; i < col; i++)
                {
                    DataRow dr_Mtemp = dt_MTemp.NewRow();

                    // Seq => 현재날짜 + 4자리숫자의 seq번호
                    dr_Mtemp["seq"] = sCurrentSeq;
                    dr_Mtemp["check_no"] = i;
                    dr_Mtemp["part_name"] = part_name.Value;
                    dr_Mtemp["lot_no"] = lot_no.Value;
                    dr_Mtemp["trs_no"] = trs_no.Value;
                    dr_Mtemp["fps_trs_no"] = fps_trs_no.Value;

                    dr_Mtemp["lot_size"] = lot_size.Value;
                    dr_Mtemp["inspect_qty"] = inspect_qty.Value;
                    dr_Mtemp["numVar1"] = numVar1.Value;
                    dr_Mtemp["numVar2"] = numVar2.Value;

                    if (worksheet.Cells[11, i].IsMerged)
                    {
                        IList<Range> ILRange = worksheet.Cells[11, i].GetMergedRanges();
                        Range rILRange = worksheet.Range.FromLTRB(ILRange[0].LeftColumnIndex, ILRange[0].TopRowIndex, ILRange[0].RightColumnIndex, ILRange[0].BottomRowIndex);
                        dr_Mtemp["charac1"] = rILRange[0][0].Value;
                    }
                    else
                    {
                        dr_Mtemp["charac1"] = ((Range)worksheet.Cells[11, i]).Value;
                    }


                    if (worksheet.Cells[12, i].IsMerged)
                    {
                        IList<Range> ILRange = worksheet.Cells[12, i].GetMergedRanges();
                        Range rILRange = worksheet.Range.FromLTRB(ILRange[0].LeftColumnIndex, ILRange[0].TopRowIndex, ILRange[0].RightColumnIndex, ILRange[0].BottomRowIndex);
                        dr_Mtemp["charac2"] = rILRange[0][0].Value;
                        jsonColName = rILRange[0][0].Value.ToString();
                    }
                    else
                    {
                        dr_Mtemp["charac2"] = ((Range)worksheet.Cells[12, i]).Value;
                        jsonColName = ((Range)worksheet.Cells[12, i]).Value.ToString();
                    }


                    if (worksheet.Cells[13, i].IsMerged)
                    {
                        IList<Range> ILRange = worksheet.Cells[13, i].GetMergedRanges();
                        Range rILRange = worksheet.Range.FromLTRB(ILRange[0].LeftColumnIndex, ILRange[0].TopRowIndex, ILRange[0].RightColumnIndex, ILRange[0].BottomRowIndex);
                        dr_Mtemp["charac3"] = rILRange[0][0].Value;
                    }
                    else
                    {
                        dr_Mtemp["charac3"] = ((Range)worksheet.Cells[13, i]).Value;
                    }

                    dr_Mtemp["spec1"] = ((Range)worksheet.Cells[14, i]).Value;
                    dr_Mtemp["spec2"] = ((Range)worksheet.Cells[15, i]).Value;
                    dr_Mtemp["equip"] = ((Range)worksheet.Cells[16, i]).Value;
                    dr_Mtemp["min"] = ((Range)worksheet.Cells[17, i]).Value;
                    dr_Mtemp["max"] = ((Range)worksheet.Cells[18, i]).Value;
                    colUpJsonDataTable(dtJson, jsonColName);   // JSON 데이터용 컬럼 미리 만들기
                    

                    dt_MTemp.Rows.Add(dr_Mtemp);
                }

                // Detail Table    // dt_STemp
                for (int i = 19; i < row; i++)
                {
                    DataRow dr_Stemp = dt_STemp.NewRow();

                    dr_Stemp["seq"] = sCurrentSeq;
                    dr_Stemp["sub_no"] = (i - 18);

                    // Dtail Json Data CREATE
                    DataRow dr_jsonTemp = dtJson.NewRow();
                    for (int j = 0; j < col; j++)
                    {

                        //string colName = ((Range)worksheet.Cells[13, j]).Value.ToString();
                        if (((Range)worksheet.Cells[i, j]).Value == null)
                        {
                            dr_jsonTemp[j] = "";
                        }
                        else
                        {
                            dr_jsonTemp[j] = ((Range)worksheet.Cells[i, j]).Value;
                        }
                    }
                    dtJson.Rows.Add(dr_jsonTemp);

                    dr_Stemp["jsondata"] = commonExtensions.ToJson(dtJson).ToString();  // Json Data Insert
                    dtJson.Clear();  // Json DataTable Clear
                    dt_STemp.Rows.Add(dr_Stemp);
                }

                bool isReturn = false;
                using (DBManager pDBManager = new DBManager())
                {
                    _pCheckDataRegisterEntity.CRUD = "C";
                    isReturn = new CheckDataRegisterBusiness().Excel_Info_Mst_Save(_pCheckDataRegisterEntity, dt_MTemp, dt_STemp);
                }

                if (!isReturn)
                    CoFAS_DevExpressManager.ShowInformationMessage("저장 완료");
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
                _pCheckDataRegisterEntity.CRUD = "R";
                dt_MTemp.Clear();
                dt_STemp.Clear();
                _pCheckDataRegisterEntity.RTN_KEY = "";
                _pCheckDataRegisterEntity.RTN_SEQ = "";
                Form_InitialButtonClicked(null, null);
                
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
                OpenFileDialog opd = new OpenFileDialog();
                opd.FileName = "";
                opd.Filter = "xls파일(*.xls)|*.xls|xlsx파일(*.xlsx)|*.xlsx";
                opd.Title = "엑셀 저장";

                if (opd.ShowDialog() == DialogResult.OK)
                {
                    fileName = opd.SafeFileName;
                    fileFullName = opd.FileName;
                    filePath = fileFullName.Replace(fileName, "");


                    dt_MTemp = new System.Data.DataTable();
                    dt_MTemp = init_M_DataTable(dt_MTemp);

                    dt_STemp = new System.Data.DataTable();
                    dt_STemp = init_S_DataTable(dt_STemp);

                    spreadsheetControl1.LoadDocument(fileFullName);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            catch(Exception ex)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", ex.Message.ToString(), ex.TargetSite.ToString()));
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

                InitializeSetting();

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

        #region DataTable etc..

        #region  Master - init_M_DataTable
        public System.Data.DataTable init_M_DataTable(System.Data.DataTable dtTemp)
        {
            System.Data.DataTable reDataTable = dtTemp;

            reDataTable.Columns.Add("seq", typeof(string));
            reDataTable.Columns.Add("check_no", typeof(int));
            reDataTable.Columns.Add("part_name", typeof(string));
            reDataTable.Columns.Add("lot_no", typeof(string));
            reDataTable.Columns.Add("trs_no", typeof(string));
            reDataTable.Columns.Add("fps_trs_no", typeof(string));

            reDataTable.Columns.Add("lot_size", typeof(string));
            reDataTable.Columns.Add("inspect_qty", typeof(string));
            reDataTable.Columns.Add("numVar1", typeof(string));
            reDataTable.Columns.Add("numVar2", typeof(string));

            reDataTable.Columns.Add("charac1", typeof(string));
            reDataTable.Columns.Add("charac2", typeof(string));
            reDataTable.Columns.Add("charac3", typeof(string));
            reDataTable.Columns.Add("spec1", typeof(string));
            reDataTable.Columns.Add("spec2", typeof(string));
            reDataTable.Columns.Add("equip", typeof(string));
            reDataTable.Columns.Add("min", typeof(string));
            reDataTable.Columns.Add("max", typeof(string));

            return reDataTable;
        }

        #endregion

        #region Sub - init_S_DataTable

        public System.Data.DataTable init_S_DataTable(System.Data.DataTable dtTemp)
        {
            // 기본 col 세팅

            System.Data.DataTable reDataTable = dtTemp;
            reDataTable.Columns.Add("seq", typeof(string));
            reDataTable.Columns.Add("sub_no", typeof(int));
            reDataTable.Columns.Add("jsondata", typeof(string));
            return reDataTable;
        }

        #endregion

        #region Add Columnm DataTable

        public System.Data.DataTable colUpJsonDataTable(System.Data.DataTable dtzson, string colName)
        {
            System.Data.DataTable reDataTable = dtzson;
            reDataTable.Columns.Add(colName, typeof(string));
            return reDataTable;
        }

        #endregion

        #endregion

        #region Excel Process Kill
        private void KillSpecificExcelFileProcess(string excelFileName)
        {
            var processes = from p in Process.GetProcessesByName("EXCEL")
                            select p;

            foreach (var process in processes)
            {
                if (process.MainWindowTitle == "Microsoft Excel - " + excelFileName)
                    process.Kill();
            }
        }

        #endregion

        private int GetEmptyCellRowIndex()
        {
            int emptyRowIndex = 19;
            while (true)
            {
                Range workRow = worksheet.Cells[emptyRowIndex, 0];
                //Cell c = spreadsheetControl1.ActiveWorksheet.Rows[emptyRowIndex][0];
                //if (c.Value.IsEmpty || c.Value.NumericValue == 0)
                if(workRow.Value.IsEmpty || workRow.Value.NumericValue == 0)
                    return emptyRowIndex;
                emptyRowIndex++;
            }
        }

        private int GetEmptyCellColumnIndex()
        {
            int emptyColIndex = 1;
            while (true)
            {
                Range workCol = worksheet.Cells[13, emptyColIndex];
                //Cell c = spreadsheetControl1.ActiveWorksheet.Columns[emptyColIndex][15];
                //if (c.Value.IsEmpty)
                if(workCol.Value.IsEmpty && !workCol.IsMerged)
                    return emptyColIndex;
                emptyColIndex++;
            }
        }
    }

    #region DataTable to Json
    public static class commonExtensions
    {
        public static string ToJson(this System.Data.DataTable value)
        {
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            serializer.MaxJsonLength = 2147483647;

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

            Dictionary<string, object> row;

            foreach (DataRow dr in value.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in value.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }
    }
    #endregion
}