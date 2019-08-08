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

using System.Threading;
using DevExpress.XtraEditors;
using DevExpress.Spreadsheet;
using System.Drawing.Printing;
using System.IO;

namespace CoFAS_MES.POP
{
    public partial class frmMainPrinter : frmBasePOP
    {
        private string _pCORP_CODE = string.Empty;       // 회사코드       
        public string _pCORP_CDDE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        public string _pUSER_NAME = string.Empty;       // 사용자이름
        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        public UserEntity _pUserEntity = null;
        public CreaPOPEntity _PCreaPOPEntity = null;
        private System.Threading.Timer tmrWorkOrder; // 작업 지시서 조회

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _dtListMain = null; //조회 데이터 리스트
        private string _pMessage = string.Empty; //메세지 처리
        private CoFAS_Log _pCoFASLog = new CoFAS_Log(Application.StartupPath + "\\LOG", "", 30, true);
        IWorkbook wb = null;
        private static string _strFTP_PATH = string.Empty;
        private static object[] _pARRAY = null;
        private static object[] _pARRAY_CODE = null;
        private static string _strFILE_NAME = string.Empty;
        private string _pFile_Attr = string.Empty;
        private static string _pFTP_ID = string.Empty;          // FTP ID 정보
        private static string _pFTP_IP_PORT = string.Empty;        // FTP SERVER IP 정보
        private static string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private static string _pFTP_PW = string.Empty;          //FTP PW 정보
        private bool fristPrint = false;
        private string falg_print = "0";
         
        public static object[] ARRAY_CODE
        {
            get { return _pARRAY_CODE; }
            set { _pARRAY_CODE = value; }
        }
        public static string strFTP_PATH
        {
            get { return _strFTP_PATH; }
            set { _strFTP_PATH = value; }
        }
        public static string strFILE_NAME
        {
            get { return _strFILE_NAME; }
            set { _strFILE_NAME = value; }
        }
        public static string USER_CODE
        {
            get { return _pUSER_CODE; }
            set { _pUSER_CODE = value; }
        }
        public static string FTP_ID
        {
            get { return _pFTP_ID; }
            set { _pFTP_ID = value; }
        }

        public static string FTP_IP_PORT
        {
            get { return _pFTP_IP_PORT; }
            set { _pFTP_IP_PORT = value; }
        }

        public static string FTP_PATH
        {
            get { return _pFTP_PATH; }
            set { _pFTP_PATH = value; }
        }

        public static string FTP_PW
        {
            get { return _pFTP_PW; }
            set { _pFTP_PW = value; }
        }
        public frmMainPrinter()
        {
            InitializeComponent();

            //_pCORP_CODE = _pUserEntity.USER_CODE;
            //_pUSER_CODE = _pUserEntity.USER_NAME;
            //_pLANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;

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
                InitializeSetting();
                WorkOrder_Data(); //미출력 작업지시서
                MainFind_DisplayData(); //재발행 내역
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
                        DBManager.PrimaryDBManagerType = DBManagerType.SQLServer;//.SQLServer;
                        break;
                }

                DBManager.PrimaryConnectionString = string.Format
               (
                   //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                   "Server={0};Database={1};UID={2};PWD={3}",
                   Properties.Settings.Default.SERVER_IP.ToString(),
                   Properties.Settings.Default.DB_NAME.ToString(),
                   Properties.Settings.Default.DB_ID.ToString(),
                   "Codb89897788!#%"
               );

                this._lbTitle.Text = "작업지시 발행";

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Initialize()", pException);
            }
        }

        #region ○ 메뉴 초기화 하기 - InitializeSetting()

        private void InitializeSetting()
        {
            try
            {
                //상속 화면 패널 사용 유무
                _pnRight.Visible = false;

                //메인 화면 전역 변수 처리
                _pCORP_CDDE = "9999999999";//MainForm.UserEntity.CORP_CODE;
                _pUSER_CODE = "admin@coever.co.kr";// MainForm.UserEntity.USER_CODE;
                _pUSER_NAME = "";//MainForm.UserEntity.USER_NAME;
                //_pLANGUAGE_TYPE = MainForm.UserEntity.LANGUAGE_TYPE;
                //_pFONT_TYPE = MainForm.UserEntity.FONT_TYPE;

                _pWINDOW_NAME = this.Name;

                _lbHeader.Text = "";
                DisplayMessage("");

                //메뉴 화면 엔티티 설정
                _PCreaPOPEntity = new CreaPOPEntity();
                _PCreaPOPEntity.CORP_CODE = _pCORP_CDDE;
                _PCreaPOPEntity.USER_CODE = _pUSER_CODE;


              

                //화면 설정 언어 & 명칭 변경. ==고정==
                //DataTable dtLanguage = new LanguageBusiness().Language_Info(_pCORP_CDDE, _pWINDOW_NAME, _pLANGUAGE_TYPE);

                //if (dtLanguage != null && dtLanguage.Rows.Count > 0)
                //{
                //    CoFAS_ControlManager.Language_Info(dtLanguage, this);
                //}
                //화면 설정 언어 & 명칭 변경. ==고정==

                //화면 컨트롤러 설정
                InitializeControl();

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    _pFirstYN = false;
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
                if (_pFirstYN)
                {

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
        private void btnCmd_Click(object pSender, EventArgs e)
        {
            SimpleButton pCmd = pSender as SimpleButton;
            string sCls = pCmd.Name.Substring(6, 2);
            switch (sCls)
            {
                case "01": // 재발행
                    this.Invoke(new MethodInvoker(delegate
                    {
                        falg_print = "1";
                        PrintOutput_Data();
                    }));
                    break;
                case "02": // 발행시작
                    if (btnCmd02.Text == "발행시작")
                    {
                        tmrWorkOrder = new System.Threading.Timer(new TimerCallback(UpdateWork), null, 0, 10000); //10초 간격으로 서열데이터 조회 //30초에서 수정
                    }
                    else
                    {
                        tmrWorkOrder.Dispose();
                    }

                    switch (btnCmd02.Text)
                    {
                        case "발행시작":
                            btnCmd02.Text = "중지";
                            fristPrint = true;
                            break;
                        case "중지":
                            btnCmd02.Text = "발행시작";
                            fristPrint = false;
                            break;
                        default: break;
                    }
                    break;
                case "03": // 종료
                    Application.Exit();
                    break;
                default: break;
            }
        }


        // ■ 작업 지시서 타이머 조회
        #region ○ UpdateWork : 작업 지시서 자동 조회.
        private void UpdateWork(object obj)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                WorkOrder_Data(); // 미출력 조회
            }));


            // 발행 기능 추가

             
                //Message_Log("작업지시 발행", false, true);
                //if (fpLeft.Sheets[0].Rows.Count > 0)
                //{
                //    rptView1.InvokeIfNeeded(LeftFind_DisplayData); // ??? 확인



                //    //if (crDocRpt.PrintOptions.PrinterName == "") //if (crDocRpt.PrintOptions.PrinterName == "Canon LBP6250K PCL5e") //기본프린트 미설정시 리턴
                //    //{
                //    //    fpLeft.InvokeIfNeeded(WorkOrder_Status);
                //    //    //DevExpressManager.ShowInformationMessage("기본 프린터 설정을 확인해주세요. \r 프린터명 : Canon LBP6250K PCL5e");
                //    //}
                //    //else
                //    //{
                //    //    //fpLeft.InvokeIfNeeded(WorkOrder_Status); //출력시 업데이트
                //    //    return;
                //    //}
                //}
            }
        #endregion

        #region ○ 좌측 조회
        private void WorkOrder_Data() //작지 미출력 조회
        {
            try
            {
                _PCreaPOPEntity.CORP_CODE = "1000";
                _PCreaPOPEntity.CRUD = "";

                _dtList = new CreaPopBusiness().MainPrinterLeft_Search(_PCreaPOPEntity);

                _gdLEFT.DataSource = _dtList;
                if (fristPrint)
                {
                    if (_dtList.Rows.Count > 0)
                    {
                        tmrWorkOrder.Change(Timeout.Infinite, Timeout.Infinite);
                        this.Invoke(new MethodInvoker(delegate
                        {
                            falg_print = "0";
                            PrintOutput_Data();  //발행기능 추가
                             tabControl1.SelectedIndex = 0;
                            WorkOrder_Status();  // 작업지시 업데이트
                         }));
                    }
                }
            }
            catch (Exception ex)
            {
                Message_Log("[WorkOrder_Data] :" + ex.ToString(), false, false);
            }
            finally
            {

            }
        }
        #endregion

        #region ○ 메인조회

        private void MainFind_DisplayData()
        {
            try
            {
                _PCreaPOPEntity.CORP_CODE = "1000";
                _PCreaPOPEntity.CRUD = "";

                _dtListMain = new CreaPopBusiness().MainPrinterMain_Search(_PCreaPOPEntity);

                _gdMAIN.DataSource = _dtListMain;
            }
            catch (Exception pException)
            {
                _pCoFASLog.WLog_Exception("MainFind_DisplayData()", pException);
            }
            finally
            {
            }

        }

        #endregion

        // ■ 메세지 처리
        #region ○ 메세지 처리
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strMessage">메세지 표시</param>
        /// <param name="isLog">로그 저장 유무</param>
        /// <param name="isView">화면 표시 유무</param>
        private void Message_Log(string strMessage, bool isLog, bool isView)
        {
            DateTime dt = DateTime.Now;

            _pMessage = string.Format("[{0}:{1}:{2}] {3}\r\n", dt.ToString("HH"), dt.ToString("mm"), dt.ToString("ss"), strMessage);

            if (isView)
            {
            }

            if (isLog)
            {
                _pCoFASLog.WLog(_pMessage);
            }
        }
        #endregion


        #region ○ 프린터발행 
        private void PrintOutput_Data()
        {
            try
            {
                Stream responseStream = null;

                responseStream = CORE.Function.CoFAS_FTPManager.FTPFileBinding("db2.coever.co.kr:8500/USER/PROGRAM_VIEW/frmMainPrinter/", "frmMainPrinterReport.xlsx", "ftpadmin", "Ftp89897788!#%");

                spreadsheetControl1.LoadDocument(responseStream);
                wb = spreadsheetControl1.Document;

                if (wb.MailMergeDataSource == null) return;

                Object dsTemp = wb.MailMergeDataSource;
                ParametersCollection para = wb.MailMergeParameters;

                para["v_option1"].Value = ""; // KEY값
                para["v_option2"].Value = ""; // 사용여부
                para["v_option3"].Value = ""; // 사용자
                para["v_option4"].Value = textBox1.Text == "" ?  gridView1.GetRowCellValue(0, "PONO").ToString() : textBox1.Text;  //첫 데이터 발행
                para["v_option5"].Value = falg_print;

                IList<IWorkbook> result = wb.GenerateMailMergeDocuments();
                using (MemoryStream resultStream = new MemoryStream())
                {
                    result[0].SaveDocument(resultStream, DocumentFormat.OpenXml);
                    wb.LoadDocument(resultStream);
                    wb.Worksheets[0].ActiveView.Zoom = 20;   // 엑셀 시트 Size 조정

                    // Create an object containing printer settings.
                    PrinterSettings printerSettings = new PrinterSettings();

                    // Define the printer to use.
                    printerSettings.PrinterName = "frmMainPrinterReport";
                    printerSettings.PrintToFile = true;
                    printerSettings.PrintFileName = "frmMainPrinterReport.xlsx";

                    // Specify that the first three pages should be printed.
                    printerSettings.PrintRange = PrintRange.SomePages;
                    printerSettings.FromPage = 1;
                    printerSettings.ToPage = 3;

                    // Set the number of copies to print.
                    printerSettings.Copies = 1;

                    // Print the document using the specified printer settings.
                    spreadsheetControl1.Print();// .Print(printerSettings);

                    Message_Log("발행", true, true);
                }
            }
            catch(Exception ex)
            {
                Message_Log("[PrintOutput_Data] :" + ex.ToString(), true, true);
              //  tmrWorkOrder.Change(10000, 10000);
            }
        }
        #endregion

        #region ○ WorkOrder_Status : 작업 지시서 업데이트.
        /// <summary>
        /// 출력된 작업지시서 업데이트
        /// </summary>
        private void WorkOrder_Status() //업데이트
        {
            try
            {
                _PCreaPOPEntity.CORP_CODE = "";
                _PCreaPOPEntity.EVENTDATE = gridView1.GetRowCellValue(0, "생산일자").ToString();
                _PCreaPOPEntity.EVENTSEQ = gridView1.GetRowCellValue(0, "SEQ").ToString();
                _PCreaPOPEntity.PONO = gridView1.GetRowCellValue(0, "PONO").ToString();

                if (_dtList.Rows.Count > 0)
                {

                    bool isError = false;
                    isError = new CreaPopBusiness().MainPrinterUpdate(_PCreaPOPEntity);

                    if(isError)
                    {
                        Message_Log("업데이트 오류", true, true);
                    }
                }
              
                WorkOrder_Data();
                Thread.Sleep(2000);
                MainFind_DisplayData(); //재발행 내역

                tmrWorkOrder.Change(10000, 10000);
            }
            catch (Exception pException)
            {
                _pCoFASLog.WLog_Exception("Pop_WorkOrder_Save", pException);
            }
            finally
            {
              //  fpMain.InvokeIfNeeded(MainFind_DisplayData);
            }
        }
        #endregion

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    textBox1.Text = gridView2.GetRowCellValue(e.RowHandle, "PONO").ToString();
                }));
            }
            catch(Exception ex)
            {
                Message_Log(ex.ToString(), true, true);
            }
        }
    }
}
