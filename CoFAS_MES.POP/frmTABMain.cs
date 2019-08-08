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

using CoFAS_MES.UI.POP.UserControls;

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
    public partial class frmTABMain : frmBaseSingle
    {

        private LoginEntity pLoginEntity = null; // 로그인 용 엔티티
        private static UserEntity pUserEntity = null; // 시스템 사용 사용자 엔티티

        private bool _pFirstYN = true;
        private static string _pFindControl = string.Empty;
        private static UserControl _uc = null;
        private static string ucn = string.Empty;

        private Font _font = null;

        private byte[] saltBytes = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        public frmTABMain()
        {
            try
            {
                InitializeComponent();

                pUserEntity = new UserEntity();
            }
            catch (Exception pException)
            {
                XtraMessageBox.Show(pException.ToString(), "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //폼 이벤트 처리 영역
        #region ○ frmTABMain_Load
        private void frmTABMain_Load(object pSender, EventArgs pEventArgs)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;

                timer1.Start();

                Initialize();
                InitializeControl();

                Child_Page_Setting_Visible = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = _font;//화면에 모든 항목 폰트 재설정
            }
        }

        private void Initialize()
        {
            try
            {
                switch (Properties.Settings.Default.DB_ID.ToString())
                {
                    case "MySql":
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.MySQLServer;
                        break;
                    case "SQLServer":
                        DBManager.PrimaryDBManagerType = DBManagerType.SQLServer;//.SQLServer;
                        break;
                    default:
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.MySQLServer;
                        break;
                }

                DBManager.PrimaryConnectionString = string.Format
               (
                   "Server={0};Database={1};UID={2};PWD={3}",
                   Properties.Settings.Default.SERVER_IP.ToString(),
                   Properties.Settings.Default.DB_NAME.ToString(),
                   Properties.Settings.Default.DB_ID.ToString(),
                   "0we11Passw0rd!@#dbmes"
               //"0we11Passw0rd!@#dbmes"
               );

                pUserEntity.LANGUAGE_TYPE = Properties.Settings.Default.MULTI_LANGUAGE.ToString();
                pUserEntity.FONT_TYPE = Properties.Settings.Default.FONT_TYPE.ToString();
                pUserEntity.FONT_SIZE = Properties.Settings.Default.FONT_SIZE;

                pUserEntity.FTP_ID = Properties.Settings.Default.FTP_ID;
                pUserEntity.FTP_IP_PORT = string.Format("{0}:{1}/", Properties.Settings.Default.FTP_SERVER_IP, Properties.Settings.Default.FTP_SERVER_PORT);
                pUserEntity.FTP_PW = "Ftp89897788!#%";


                _font = new Font(pUserEntity.FONT_TYPE, pUserEntity.FONT_SIZE);

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Initialize()", pException);
            }
        }
        #endregion

        #region ○ 버튼 초기화 하기 - InitializeButtons()

        private void InitializeButtons()
        {
            try
            {
                Child_Page_Setting_Visible = true;
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
                if (_pFirstYN)
                {
                    // 기본 로비 화면
                    _pFindControl = "TABLobby";

                    _pFirstYN = false;
                }

                mainPageControl(_pFindControl);
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ 메인 페이지 컨트롤 - mainPageControl(string strFindControl)
        public void mainPageControl(string strFindControl)
        {
            _pFindControl = strFindControl;

            switch (_pFindControl)
            {

                case "TABLobby":

                    if (_pnSINGLE_SUB != null)
                    {
                        _pnSINGLE_SUB.Controls.Clear();
                    }

                    _lmREFRESH.Visible = false;
                    _lmSELECT.Visible = false;
                    _lmSAVE.Visible = false;
                    _lmIMPORT.Visible = false;
                    _lmEXPORT.Visible = false;

                    _uc = new ucTABLobby(pUserEntity, this);

                    break;

                case "TABSearch":

                    if (_pnSINGLE_SUB != null)
                    {
                        _pnSINGLE_SUB.Controls.Clear();
                    }

                    _lmREFRESH.Visible = true;
                    _lmSELECT.Visible = true;

                    _uc = new ucTABSearch(pUserEntity, this);

                    break;

                case "TABExcel":

                    if (_pnSINGLE_SUB != null)
                    {
                        _pnSINGLE_SUB.Controls.Clear();
                    }

                    _lmREFRESH.Visible = true;
                    _lmIMPORT.Visible = true;
                    _lmEXPORT.Visible = true;

                    _uc = new ucTABExcel(pUserEntity, this);

                    break;

                case "TABRegister":

                    if (_pnSINGLE_SUB != null)
                    {
                        _pnSINGLE_SUB.Controls.Clear();
                    }

                    _lmREFRESH.Visible = true;
                    _lmIMPORT.Visible = true;
                    _lmSAVE.Visible = true;

                    _uc = new ucTABRegister(pUserEntity, this);

                    break;

                case "TABComment":

                    if (_pnSINGLE_SUB != null)
                    {
                        _pnSINGLE_SUB.Controls.Clear();
                    }

                    _lmREFRESH.Visible = true;
                    _lmSELECT.Visible = true;
                    _lmSAVE.Visible = true;

                    _uc = new ucTABComment(pUserEntity, this);

                    break;

                case "TABEquipment":

                    if (_pnSINGLE_SUB != null)
                    {
                        _pnSINGLE_SUB.Controls.Clear();
                    }

                    _lmREFRESH.Visible = true;
                    _lmSELECT.Visible = true;

                    _uc = new ucTABEquipment(pUserEntity, this);

                    break;

            }

            _uc.CreateControl();

            _pnSINGLE_SUB.Controls.Add(_uc);
            _uc.Dock = DockStyle.Fill;

            _pFindControl = null;
        }
        #endregion

        #region ○ 상단 페이지 컨트롤 - _lmFORM_Click(object sender, EventArgs e)
        private void _lmFORM_Click(object sender, EventArgs e)
        {
            var sn = (dynamic)sender;
            string nm = sn.Name;
            string name = nm.Substring(3, nm.Length - 3);

            switch (name)
            {
                case "REFRESH":

                    mainPageControl("TABLobby");

                    break;
            }
        }
        #endregion

        #region ○ 컨트롤 변경시 - USER_CONTROL_CHANGE()
        public string USER_CONTROL_CHANGE
        {
            get { return ucn; }
            set
            {
                ucn = value;

                if (ucn != null)
                {
                    mainPageControl(ucn);
                }

            }
        }
        #endregion

        #region ○ 시스템 설정 - _btLoginSetting_Click(object sender, EventArgs e)
        private void _btLoginSetting_Click(object sender, EventArgs e)
        {
            frmPOPSetting pPOPSetting = new frmPOPSetting("admin");
            pPOPSetting.ShowDialog();

        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
