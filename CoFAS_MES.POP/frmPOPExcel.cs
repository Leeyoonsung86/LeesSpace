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

//엑셀관련
using DevExpress.Spreadsheet;
using System.IO;
using DevExpress.Spreadsheet.Export;

namespace CoFAS_MES.POP
{
    public partial class frmPOPExcel : frmBaseSingle
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
        private DataTable _dtList_terminal = null; //터미널 상세정보 리스트

        private CoFAS_Serial _pCoFAS_Serial = null;  // 시리얼 생성

        delegate void CrossThreadSafetySetText(Control ctl, String text);
        delegate void CrossThreadSafetySetColor(Control ctl, Color text);

        private delegate void showMsg();

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

        private DataTable _dtList = null; //조회 데이터 리스트
        private bool _pFirstYN = true;    //최초실행여부 최초 설정 에서만 사용

        private int select_row_handle = 0;

        private int active_row = 0;

        string fileName = "";
        string fileFullName = "";
        string filePath = "";
        string worksheetName = string.Empty;

        public frmPOPExcel()
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
                SetHardware();
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
                using (FileStream stream = new FileStream("Documents\\COCKPIT_SHEET.xlsx", FileMode.Open))
                {
                    spreadsheetControl1.LoadDocument(stream, DocumentFormat.Xlsx);
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
                ////그리드 초기화 
                ////여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                //if (_pFirstYN)
                //{
                //    _gdMAIN_VIEW = CoFAS_DevExpressManager.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));
                //   // _gdMAIN_VIEW.OptionsView.RowAutoHeight = true;
                //}

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

        #region ○ H/W 세팅시
        private void SetHardware()
        {
            //try
            //{
            //    string partName = "COM8";
            //    int baudRate = 9600;
            //    string parity = "NONE";
            //    int dataBits = 8;
            //    string stopBits = "ONE";

            //    _pCoFAS_Serial = new CoFAS_Serial(partName, baudRate, parity, dataBits, stopBits);
            //    _pCoFAS_Serial.evtReceived += new CoFAS_Serial.delReceive(Serial_Data);
            //    _pCoFAS_Serial.Open();

            //    // 연결할 H/W 연결상태 표시. (연동시 변경)
            //    lc_0.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.plug_Green;

            //    //CoFAS_DevExpressManager.ShowInformationMessage("POP Start Complete");

            //}
            //catch (Exception ex)
            //{
            //    CoFAS_DevExpressManager.ShowInformationMessage("바코드 스캐너 연결상태를 확인해주시기 바랍니다.");
            //}
        }

        #endregion


        #region ○ 버튼 클릭시

        private void btnCmd_Click(object pSender, EventArgs pEventArgs)
        {
            SimpleButton pCmd = pSender as SimpleButton;

            string sCls = pCmd.Name.Substring(6, 2);

            switch (sCls)
            {
                case "10":

                    try
                    {
                        CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                        OpenFileDialog opd = new OpenFileDialog();
                        opd.InitialDirectory = "C\\";
                        opd.FileName = "";
                        opd.Filter = "xlsxFile(*.xlsx)|*.xlsx|xlsFile(*.xls)|*.xls";
                        opd.Title = "Excel Export";

                        if (opd.ShowDialog() == DialogResult.OK)
                        {
                            fileName = opd.SafeFileName;
                            fileFullName = opd.FileName;
                            filePath = fileFullName.Replace(fileName, "");

                            // 선택한 엑셀 파일 spread control에 바인딩
                            using (FileStream stream = new FileStream(opd.FileName.ToString(), FileMode.Open, FileAccess.Read))
                            {
                                spreadsheetControl2.LoadDocument(stream);

                                IWorkbook workbook = spreadsheetControl2.Document;
                                Worksheet sheet_0 = workbook.Worksheets["COCKPIT"];

                                IWorkbook workbook2 = spreadsheetControl1.Document;
                                Worksheet sheet2_0 = workbook2.Worksheets[0];

                                Range usedRange = sheet_0.GetUsedRange();

                                if (sheet2_0.Cells[2, 5].Value.ToString() != null && sheet2_0.Cells[2, 5].Value.ToString() != "")
                                {
                                    if (CoFAS_DevExpressManager.ShowQuestionMessage("작업중인 데이터가 있습니다. 계속 진행하시겠습니까?") == DialogResult.No)
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        using (FileStream st = new FileStream("Documents\\COCKPIT_SHEET.xlsx", FileMode.Open))
                                        {
                                            spreadsheetControl1.LoadDocument(st, DocumentFormat.Xlsx);

                                        }
                                    }
                                }

                                ExternalDataSourceOptions dsOptions = new ExternalDataSourceOptions();
                                dsOptions.ImportHeaders = true;

                                DataTable dt = new DataTable();

                                for (int i = 0; i < usedRange.RowCount; i++)
                                {
                                    sheet2_0.Cells[i + 1, 0].Value = sheet_0.Cells[12 + i, 0].Value.ToString();
                                    sheet2_0.Cells[i + 1, 1].Value = sheet_0.Cells[12 + i, 2].Value.ToString();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("엑셀 파일을 확인해주세요.");
                    }
                    finally
                    {
                        CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
                    }


                    break;

                case "20":

                    IWorkbook workbook3 = spreadsheetControl1.Document;
                    Worksheet sheet_3 = workbook3.Worksheets[0];

                    if (sheet_3.Cells[2, 5].Value.ToString() != null && sheet_3.Cells[2, 5].Value.ToString() != "")
                    {
                        // Save the modified document to a stream. 
                        using (FileStream stream = new FileStream("Documents\\SaveDocuments\\" + sheet_3.Cells[2, 5].Value.ToString() + "_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx",
                            FileMode.Create, FileAccess.ReadWrite))
                        {
                            workbook3.SaveDocument(stream, DocumentFormat.Xlsx);

                            CoFAS_DevExpressManager.ShowInformationMessage("저장 되었습니다.");
                        }
                    }
                    else
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("PO 넘버를 입력해주세요.");
                    }
                    
                    break;

                case "30":

                    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                    OpenFileDialog opd2 = new OpenFileDialog();
                    opd2.FileName = "";
                    opd2.InitialDirectory = Application.StartupPath+"\\Documents\\SaveDocuments";
                    opd2.Filter = "xlsxFile(*.xlsx)|*.xlsx|xlsFile(*.xls)|*.xls";
                    opd2.Title = "Excel Import";

                    if (opd2.ShowDialog() == DialogResult.OK)
                    {
                        fileName = opd2.SafeFileName;
                        fileFullName = opd2.FileName;
                        filePath = fileFullName.Replace(fileName, "");

                        // 선택한 엑셀 파일 spread control에 바인딩
                        using (FileStream stream = new FileStream(opd2.FileName.ToString(), FileMode.Open, FileAccess.Read))
                        {
                            spreadsheetControl1.LoadDocument(stream);
                        }
                    }

                    CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);

                    break;

                default: break;
            }


        }
        #endregion

        private void Serial_Data(byte[] data)
        {
            try
            {
                IWorkbook workbook2 = spreadsheetControl1.Document;
                Worksheet sheet2_0 = workbook2.Worksheets[0];
                
                if (sheet2_0.Cells[2, 0].Value.ToString() == null || sheet2_0.Cells[2, 0].Value.ToString() == "")
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("엑셀 시트를 불러와주시기 바랍니다.");
                    return;
                }

                int click_col = 0;
                int click_row = 0;

                click_col = spreadsheetControl1.ActiveWorksheet[spreadsheetControl1.ActiveCell.GetReferenceA1()].RightColumnIndex;
                click_row = spreadsheetControl1.ActiveWorksheet[spreadsheetControl1.ActiveCell.GetReferenceA1()].TopRowIndex;
                
                if (click_col == 2 && click_row < 178)
                {
                    lock (this)
                    {
                        showMsg method = delegate
                        {
                            string str = Encoding.Default.GetString(data);

                            sheet2_0.Cells[click_row, click_col].SetValue(str);
                            // sheet2_0.

                            bool check;

                            check = str.Contains(sheet2_0.Cells[click_row, 0].Value.ToString());

                            if (check)
                            {
                                sheet2_0.Cells[click_row, click_col + 1].SetValue("Y");
                                sheet2_0.Cells[click_row, click_col + 1].Font.Color = Color.White;
                                sheet2_0.Cells[click_row, click_col + 1].Fill.BackgroundColor = Color.Green;
                            }
                            else
                            {
                                sheet2_0.Cells[click_row, click_col + 1].SetValue("N");
                                sheet2_0.Cells[click_row, click_col + 1].Font.Color = Color.White;
                                sheet2_0.Cells[click_row, click_col + 1].Fill.BackgroundColor = Color.Red;
                            }

                            sheet2_0.SelectedCell = sheet2_0.Cells[click_row + 1, click_col];
                       };
                        this.BeginInvoke(method);
                    }
                  
                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("해당하는 Barcode에 마우스를 클릭해주시기 바랍니다.");
                    return;
                }
            }
            catch (Exception ex)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("연결상태를 확인해주시기 바랍니다.");
            }
        }

        private void spreadsheetControl1_KeyDown(object sender, KeyEventArgs e)
        {
            //IWorkbook workbook2 = spreadsheetControl1.Document;
            //Worksheet sheet2_0 = workbook2.Worksheets[0];

            //if (sheet2_0.Cells[2, 0].Value.ToString() == null || sheet2_0.Cells[2, 0].Value.ToString() == "")
            //{
            //    CoFAS_DevExpressManager.ShowInformationMessage("엑셀 시트를 불러와주시기 바랍니다.");
            //    return;
            //}

            //int click_col = 0;
            //int click_row = 0;

            //click_col = spreadsheetControl1.ActiveWorksheet[spreadsheetControl1.ActiveCell.GetReferenceA1()].RightColumnIndex;
            //click_row = spreadsheetControl1.ActiveWorksheet[spreadsheetControl1.ActiveCell.GetReferenceA1()].TopRowIndex;

            //if (click_col == 2 && click_row < 178)
            //{
            //    lock (this)
            //    {
            //        showMsg method = delegate
            //        {
            //            string str = sheet2_0.Cells[click_row, click_col].Value.ToString();

            //            sheet2_0.Cells[click_row, click_col].SetValue(str);
            //            // sheet2_0.

            //            string str1 = sheet2_0.Cells[click_row - 1, click_col].Value.ToString();

            //            bool check;

            //            check = str1.Contains(sheet2_0.Cells[click_row, 0].Value.ToString());
                        
            //            if (check)
            //            {
            //                sheet2_0.Cells[click_row, click_col + 1].SetValue("Y");
            //                sheet2_0.Cells[click_row, click_col + 1].Font.Color = Color.White;
            //                sheet2_0.Cells[click_row, click_col + 1].Fill.BackgroundColor = Color.Green;
            //            }
            //            else
            //            {
            //                sheet2_0.Cells[click_row, click_col + 1].SetValue("N");
            //                sheet2_0.Cells[click_row, click_col + 1].Font.Color = Color.White;
            //                sheet2_0.Cells[click_row, click_col + 1].Fill.BackgroundColor = Color.Red;
            //            }

            //            //sheet2_0.SelectedCell = sheet2_0.Cells[click_row + 1, click_col];
            //        };
            //        this.BeginInvoke(method);
            //    }

            //}
            //else
            //{
            //    CoFAS_DevExpressManager.ShowInformationMessage("해당하는 Barcode에 마우스를 클릭해주시기 바랍니다.");
            //    return;
            //}
        }
        
        private void SpreadsheetControl1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void spreadsheetControl1_CellValueChanged(object sender, DevExpress.XtraSpreadsheet.SpreadsheetCellEventArgs e)
        {
            IWorkbook workbook2 = spreadsheetControl1.Document;
            Worksheet sheet2_0 = workbook2.Worksheets[0];

            if (sheet2_0.Cells[2, 0].Value.ToString() == null || sheet2_0.Cells[2, 0].Value.ToString() == "")
            {
                CoFAS_DevExpressManager.ShowInformationMessage("엑셀 시트를 불러와주시기 바랍니다.");
                return;
            }

            int click_col = 0;
            int click_row = 0;

            click_col = spreadsheetControl1.ActiveWorksheet[spreadsheetControl1.ActiveCell.GetReferenceA1()].RightColumnIndex;
            click_row = spreadsheetControl1.ActiveWorksheet[spreadsheetControl1.ActiveCell.GetReferenceA1()].TopRowIndex;

            if (click_col == 2 && click_row < 178)
            {
                lock (this)
                {
                    showMsg method = delegate
                    {
                        string str = sheet2_0.Cells[click_row, click_col].Value.ToString();

                        sheet2_0.Cells[click_row, click_col].SetValue(str);
                        // sheet2_0.

                        bool check;

                        check = str.Contains(sheet2_0.Cells[click_row, 0].Value.ToString());

                        if (check)
                        {
                            sheet2_0.Cells[click_row, click_col + 1].SetValue("Y");
                            sheet2_0.Cells[click_row, click_col + 1].Font.Color = Color.White;
                            sheet2_0.Cells[click_row, click_col + 1].Fill.BackgroundColor = Color.Green;
                        }
                        else
                        {
                            sheet2_0.Cells[click_row, click_col + 1].SetValue("N");
                            sheet2_0.Cells[click_row, click_col + 1].Font.Color = Color.White;
                            sheet2_0.Cells[click_row, click_col + 1].Fill.BackgroundColor = Color.Red;
                        }

                        //sheet2_0.SelectedCell = sheet2_0.Cells[click_row + 1, click_col];
                    };
                    this.BeginInvoke(method);
                }

            }
            else
            {
                CoFAS_DevExpressManager.ShowInformationMessage("해당하는 Barcode에 마우스를 클릭해주시기 바랍니다.");
                return;
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
