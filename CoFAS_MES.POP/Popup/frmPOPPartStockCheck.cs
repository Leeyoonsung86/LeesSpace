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
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Entity;

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System.Threading;

namespace CoFAS_MES.POP
{
    public partial class frmPOPPartStockCheck : frmBaseSingle
    {
        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)      
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        
        private string _pFONT_TYPE = "굴림"; //string.Empty;       // 시스템 폰트 타입 설정
        private int _pFONT_SIZE = 21;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;              // 시스템 폰트 설정
        private string _pFTP_ID = string.Empty;          // FTP ID 정보
        private string _pFTP_IP_PORT = string.Empty;     // FTP SERVER IP 정보
        private string _pFTP_PW = string.Empty;          //FTP PW 정보

        private DataTable _dtList = null; //조회 데이터 리스트
        private DataTable _rt_dtList = null; //조회 데이터 리스트

        private System.Threading.Timer tmrDtNow;
        private int pCount = 0;

        public UserEntity _pUserEntity = null;
        private frmPOPPartStockCheckEntity _pfrmPOPPartStockCheckEntity = null; // 엔티티 생성
        public MessageEntity _pMessageEntity = null; //공통 메세지 엔티티

        private CoFAS_Serial _pBarcode_Serial = null;  // 바코드 시리얼 생성
        private string COM_PORT = string.Empty;
        private string COM_PORT2 = string.Empty; //저울 포트
        private string _pTERMINAL_CODE = string.Empty; //단말기코드 : TP010003(구)  / TP010006(신규)

        public bool Check = false;
        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용
        public string titleName = "";

        public string _pBARCODE_NO = "";

        public string ReturnValue1 { get; set; }    //작업보류
        public string ReturnValue2 { get; set; }    //선택취소

        string orderid;
        string orderseq;

        public static string LANGUAGE_TYPE
        {
            get { return _pLANGUAGE_TYPE; }
            set { _pLANGUAGE_TYPE = value; }
        }
        
        #region Label 내 AutoFontSize
        public void FontResize(LabelControl lbl)
        {

            Font ft = lbl.Font;

            try
            {
                if (lbl.Height > 4)
                {
                    string[] str = lbl.Text.Split('\n');

                    string maxText = string.Empty;
                    int maxlength = 0;

                    if (str.Length > 0)
                    {
                        maxText = str[0].Replace("\n", string.Empty);
                        maxlength = str[0].Replace("\n", string.Empty).Length + 1;
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (str[i].Replace("\n", string.Empty).Length > maxlength)
                            {
                                maxlength = str[i].Replace("\n", string.Empty).Length;
                                maxText = str[i].Replace("\n", string.Empty);
                            }
                        }

                        if (maxText == "") return;

                        int textWidth = System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Width;

                        //if ((textWidth > 0 && (fnt.Size * lbl.Width / 72 / 2) - 2 < lbl.Height) && lbl.Width > textWidth)

                        int textHeight = System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Height * str.Length;
                        if (textHeight < lbl.Height && lbl.Width > textWidth)
                        {
                            bool result = false;

                            //크게 해준다.
                            while (lbl.Width > System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Width && lbl.Height > (ft.Height * str.Length) && lbl.Height > System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Height * str.Length)
                            {
                                result = true;
                                ft = new Font(ft.FontFamily, ft.Size + 0.5f, ft.Style);
                                //lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size + 0.5f, lbl.Font.Style);
                            }
                            if (result)
                            {
                                ft = new Font(ft.FontFamily, ft.Size - 0.5f, ft.Style);
                                //lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size - 0.5f, lbl.Font.Style);
                            }
                        }
                        else
                        {
                            //작게 해준다
                            while (lbl.Width < System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Width || lbl.Height < System.Windows.Forms.TextRenderer.MeasureText(maxText, new Font(ft.FontFamily, ft.Size, ft.Style)).Height * str.Length)
                            {
                                if (ft.Size >= 0.6)
                                {
                                    ft = new Font(ft.FontFamily, ft.Size - 0.5f, ft.Style);
                                    //lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size - 0.5f, lbl.Font.Style);
                                }
                                else
                                    break;
                            }
                        }
                    }
                }
                else
                    return;

                lbl.Font = ft;
            }
            catch (Exception ex)
            {
                //LogManager.Error(this.GetType(), ex.ToString(), ex);
            }
        }
        #endregion
        public frmPOPPartStockCheck(UserEntity pUserEntity)
        {
            InitializeComponent();

            _pUserEntity = pUserEntity;
            _pMessageEntity = new MessageEntity();

            _pFONT_SETTING = new Font(_pUserEntity.FONT_TYPE, _pUserEntity.FONT_SIZE);

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
                this.Size = new Size(640, 480);
                this.StartPosition = FormStartPosition.Manual;
                this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
                this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;


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
                _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);

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
                _pfrmPOPPartStockCheckEntity = new frmPOPPartStockCheckEntity();
                FontResize(_lciTPART_STOCK); 
                FontResize(_luPART_STOCK);

                FontResize(_lciTPART_NAME);
                FontResize(_luPART_NAME);

                FontResize(_lciTVEND_PART_CODE);
                FontResize(_luVEND_PART_CODE);

                FontResize(_lciTPART_CODE);
                FontResize(_luPART_CODE);
                // _luT_BadCode.Font = new Font("굴림", 20);
                // _luT_BadSubCode.Font = new Font("굴림", 20);

                // _luT_BadCode.ValueChanged += new EventHandler(_luT_BadCode_ValueChanged);
                // _luT_BadCode.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("", _pLANGUAGE_TYPE, "POP_BAD1_CODE", "", "", "").Tables[0], 0, 0, "", false);

                // 컨트롤러 유효성 검증 처리

                //그리드 초기화 
                //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화
                if (_pFirstYN)
                {
                    MainFind_DisplayData();
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
        private void _luT_BadCode_ValueChanged(object sender, EventArgs e)
        {
            //  _luT_BadSubCode.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("", _pLANGUAGE_TYPE, "POP_BAD2_CODE", _luT_BadCode.GetValue(), "", "").Tables[0], 0, 0, "", false);

            //throw new NotImplementedException();
        }
        #endregion

        private void MainFind_DisplayData()
        {
            try
            {
                CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);
                
                _pfrmPOPPartStockCheckEntity.CRUD = "R";
                _pfrmPOPPartStockCheckEntity.LANGUAGE_TYPE = _pUserEntity.LANGUAGE_TYPE;
                //_pfrmPOPPartStockCheckEntity.PROCESS_CODE = _pUserEntity.PROCESS_CODE;
                //_pfrmPOPPartStockCheckEntity.RESOURCE_CODE = _pUserEntity.RESOURCE_CODE;
                _pfrmPOPPartStockCheckEntity.BARCODE = _pBARCODE_NO;

                 _dtList = new frmPOPPartStockCheckBusiness().frmPOPPartStockCheck_Info(_pfrmPOPPartStockCheckEntity);

                if (_pfrmPOPPartStockCheckEntity.CRUD == "") _dtList.Rows.Clear();


                if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pfrmPOPPartStockCheckEntity.CRUD == ""))
                {
                    _luPART_NAME.Text = _dtList.Rows[0]["PART_NAME"].ToString();
                    _luPART_UNIT.Text = _dtList.Rows[0]["PART_UNIT"].ToString();
                    _luPART_CODE.Text = _dtList.Rows[0]["PART_CODE"].ToString();
                    _luVEND_PART_CODE.Text = _dtList.Rows[0]["VEND_PART_CODE"].ToString();
                    _luPART_STOCK.Text = _dtList.Rows[0]["PART_STOCK"].ToString();
                    

                }
                else
                {
                    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                }
                tmrDtNow = new System.Threading.Timer(new TimerCallback(UpdateDtNow), null, 0, 5000);
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
        public void UpdateDtNow(object obj)
        {
            pCount++;


            if (pCount == 3)
            {
                CoFAS_ControlManager.InvokeIfNeeded(this, () =>Close());
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}

