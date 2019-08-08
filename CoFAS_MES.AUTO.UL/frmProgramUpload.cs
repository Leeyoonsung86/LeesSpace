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
using System.Runtime.InteropServices;
using CoFAS_MES.CORE.Function;
using DevExpress.XtraEditors;
using CoFAS_MES.CORE.Business;

namespace CoFAS_MES.AUTO.UL
{
    public partial class frmProgramUpload : Form
    {

        public string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어
        public string _pWINDOW_NAME = string.Empty;     // 화면 명칭
        public string _pFONT_TYPE = string.Empty;       // 시스템 폰트 타입 설정
        public int _pFONT_SIZE = 9;                     // 시스템 폰트 사이즈 설정 기본 9
        private Font _pFONT_SETTING = null;             // 시스템 폰트 설정

        private bool _pFirstYN = true;                  // 최초실행여부 최초 설정 에서만 사용

        private CoFAS_DevGridManager _tempGrid = null;

        public frmProgramUpload()
        {
            InitializeComponent();
        }

        #region 기능함수

        #region ○ 메인 폼 이동

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Form_Moving(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }


        #endregion

        #endregion

        private void _btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void _btMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        private void _btClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("프로그램을 종료하시겠습니까?", "메시지", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
            }
            catch (Exception pException)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(pException);
            }
        }

        private void frmProgramUpload_Load(object sender, EventArgs e)
        {

            _pLANGUAGE_TYPE ="한국어";
            _pFONT_TYPE = "맑은고딕";
            _pFONT_SIZE = 9;
            _pFONT_SETTING = new Font(_pFONT_TYPE, _pFONT_SIZE);

            _pWINDOW_NAME = this.Name;

            Initialize();

            InitializeSetting();
            
        }

        private void Initialize()
        {
            try
            {
                switch (Properties.Settings.Default.DB_TYPE.ToString())
                {
                    case "MySql":
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;
                        break;
                    case "SQLServer":
                        DBManager.PrimaryDBManagerType = DBManagerType.SQLServer;
                        break;
                    default:
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;
                        break;
                }

                DBManager.InitDatabaseServer = Properties.Settings.Default.SERVER_IP.ToString();
                DBManager.InitDatabaseName = Properties.Settings.Default.DB_NAME.ToString();
                DBManager.InitDatabaseID = Properties.Settings.Default.DB_ID.ToString();
                DBManager.InitDatabasePass = "coever119!#%";

                DBManager.PrimaryConnectionString = string.Format
               (
                   "Server={0};Database={1};UID={2};PWD={3}",
                   DBManager.InitDatabaseServer,//Properties.Settings.Default.SERVER_IP.ToString(),
                   DBManager.InitDatabaseName,  //Properties.Settings.Default.DB_NAME.ToString(),
                   DBManager.InitDatabaseID,    //Properties.Settings.Default.DB_ID.ToString(),
                   DBManager.InitDatabasePass   //"coever119!#%"
               );
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
                //_luCORP_CODE.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", "COMMON_CODE", "MM11", "", "").Tables[0], 0, 0, "");

                if (_pFirstYN)
                {
                    _luFILE_TYPE.ItemAdd("All");

                    _luFILE_TYPE.ItemAdd("POP");
                    _luFILE_TYPE.ItemAdd("MES");
                    _luFILE_TYPE.ItemAdd("Monitoring");

                    _luFILE_TYPE.SelectedIndex = 0;

                    _tempGrid = new CoFAS_DevGridManager();

                    _gdMAIN_VIEW = _tempGrid.Grid_Setting(_gdMAIN, _gdMAIN_VIEW, _pFONT_SETTING, _pLANGUAGE_TYPE, new DevGridSettingBusiness().DevGrid_Info(_pLANGUAGE_TYPE, _pWINDOW_NAME, _gdMAIN.Name.ToString()));

                    _pFirstYN = false;
                }

                MainFind_DisplayData(); //Dev Grid 데이터소스 로 바인딩 작업 처리 할 경우에는 최초 빈 데이터 테이블을 바인딩 해야 됨.
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

                //_pLanguageInfoRegisterEntity.LANGUAGE_TYPE = _luLANGUAGE_TYPE.GetValue();
                //_pLanguageInfoRegisterEntity.WINDOW_NAME = _luWINDOW_NAME.GetValue();
                //_pLanguageInfoRegisterEntity.USE_YN = _luUSE_YN.GetValue();

                //_dtList = new LanguageInfoRegisterBusiness().Language_Info(_pLanguageInfoRegisterEntity);

                //if (_pLanguageInfoRegisterEntity.CRUD == "") _dtList.Rows.Clear();

                //if ((_dtList != null && _dtList.Rows.Count > 0) || (_dtList != null && _pLanguageInfoRegisterEntity.CRUD == ""))
                //{
                //    CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList);
                //}
                //else
                //{
                //    CoFAS_DevExpressManager.ShowInformationMessage("조회 내역이 없습니다.");
                //}
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                _gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion

        private void _btSEARCH_Click(object sender, EventArgs e)
        {

        }

        private void _btREFRESH_Click(object sender, EventArgs e)
        {

        }

        private void _btUPLOAD_Click(object sender, EventArgs e)
        {

        }

        private void _btNEWFILE_Click(object sender, EventArgs e)
        {
            InitializeSetting();
        }
    }
}
