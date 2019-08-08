using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using CoFAS_MES.CORE;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;

using DevExpress.XtraEditors;

namespace CoFAS_MES.POP
{
    public partial class frmPOPLogin :  Form
    {
        private LoginEntity pLoginEntity = null; // 로그인 용 엔티티
        private UserEntity pUserEntity = null; // 시스템 사용 사용자 엔티티

        private Font _font = null;

        private byte[] saltBytes = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        public frmPOPLogin()
        {
            try
            {
                InitializeComponent();

                pLoginEntity = new LoginEntity();
                pUserEntity = new UserEntity();

                layoutControl1.AllowCustomization = false; //레이아웃 컨트롤러 커스텀 메뉴 활성화 유무

            }
            catch (Exception pException)
            {
                XtraMessageBox.Show(pException.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPOPLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Initialize();
                InitializeLanguage();
                _txtAccount.Focus();

              


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                   Properties.Settings.Default.CORP_CODE.ToString(),
                   Properties.Settings.Default.SERVER_IP.ToString(),
                   Properties.Settings.Default.DB_NAME.ToString(),
                   "0we11Passw0rd!@#dbmes"
               );

                //_ckUserIDSave.EditValue = Properties.Settings.Default.USER_ID_SAVE.ToString();

                if (_ckUserIDSave.EditValue.ToString() == "Y")
                {
                  //  _txtAccount.Text = Properties.Settings.Default.USER_ID.ToString();
                }
                else
                {
                    _txtAccount.Text = "";
                }

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

        private void InitializeLanguage()
        {
            //_lbLoginHeader.Text = Resources.Language._lbLoginHeader;
            //_lciAccount.Text = Resources.Language._lciAccount;
            //_lciPassword.Text = Resources.Language._lciPassword;

            //_btLoginOk.Text = Resources.Language._btLoginOk;
            //_btLoginCancel.Text = Resources.Language._btLoginCancel;

            //_btLoginSetting.Text = Resources.Language._btLoginSetting;

            //_ckUserIDSave.Text = Resources.Language._ckUserIDSave;
        }

        //시스템 종료
        private void _btLoginClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _btLoginCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //시스템 로그인
        private void _btLoginOk_Click(object sender, EventArgs e)
        {
            ////pLoginEntity.CORP_CODE = Properties.Settings.Default.CORP_CODE.ToString();
            ////pLoginEntity.USER_CODE = _txtAccount.Text.ToString();
            ////pLoginEntity.USER_PASS = CoFAS_AES256Encrypt.EncryptToString(_txtPassword.Text.ToString(), "COEVER", saltBytes, false); // 암호화



            ////DataTable dtLoginInfo = new LoginBusiness().Login_Info(pLoginEntity.CORP_CODE, pLoginEntity.USER_CODE, pLoginEntity.USER_PASS);
            ////if (dtLoginInfo == null || dtLoginInfo.Rows.Count == 0)
            ////{
            ////    CoFAS_DevExpressManager.ShowInformationMessage("잘못된 계정 정보 입니다.");
            ////    _txtPassword.Focus();
            ////    return;
            ////}
            ////else
            ////{
            ////    pUserEntity.CORP_CODE = dtLoginInfo.Rows[0]["CORP_CODE"].ToString();
            ////    pUserEntity.CORP_NAME = dtLoginInfo.Rows[0]["CORP_NAME"].ToString();
            ////    pUserEntity.USER_CODE = dtLoginInfo.Rows[0]["USER_MAIL"].ToString();
            ////    pUserEntity.USER_NAME = dtLoginInfo.Rows[0]["USER_NAME"].ToString();






            ////    if (_ckUserIDSave.EditValue.ToString() == "Y")
            ////    {
            ////        //Properties.Settings.Default.USER_ID = pUserEntity.USER_CODE.ToString();
            ////        //Properties.Settings.Default.USER_ID_SAVE = "Y";
            ////    }
            ////    else
            ////    {
            ////        //Properties.Settings.Default.USER_ID = "";
            ////        //Properties.Settings.Default.USER_ID_SAVE = "N";
            ////    }

            ////    Properties.Settings.Default.Save();


                // 작업장 설정 별 , 화면 Show

                 DQGathering _DQGathering = new DQGathering();

                 _DQGathering.Show();

                // frmMain pMain = new frmMain(pUserEntity);
                // pMain.Show();
                Hide();
            ////}
        }

        private void _txtAccount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                    _txtPassword.Focus();
            }
            catch { }
        }

        private void _txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    _btLoginOk_Click(null, null);
            }
            catch { }
        }
        //시스템 설정
        private void _btLoginSetting_Click(object sender, EventArgs e)
        {
            frmPOPSetting pPOPSetting = new frmPOPSetting(_txtAccount.Text.ToString());
            pPOPSetting.ShowDialog();

        }

        #region 기능함수

        #region ○ 폼 이동

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


    }
}
