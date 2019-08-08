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

using System.Threading;
using DevExpress.XtraBars.Docking2010.Customization;
using CoFAS_MES.CORE.UserForm;
using System.Globalization;

namespace CoFAS_MES
{
    public partial class frmLogin : Form
    {
        private LoginEntity pLoginEntity = null; // 로그인 용 엔티티
        private UserEntity pUserEntity = null; // 시스템 사용 사용자 엔티티

        private Font _font = null;

        private byte[] saltBytes = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };


        private string _msgNotice = "";
        private string _msgLoginMessage = "";


        public frmLogin()
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
                XtraMessageBox.Show(pException.ToString(), _msgNotice, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {

                Initialize();
                InitializeLanguage();
                InitializeCorporationCI();
                _txtAccount.Focus();

                if (_ckUserIDSave.Checked && _txtAccount.Text.Trim().Length > 1)
                    _txtPassword.Select();
                else
                    _txtAccount.Select();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), _msgNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string strConnection = "";

                //배포용
                //배포할때는 비밀번호 바꿀것
                //db id : dbmes
                string strTempPW = "0we11Passw0rd!@#dbmes"; //"dbmes1!"; //"komipo1234#%&";
                //string strTempPW = "dbmes1!"; //"dbmes1!"; //"komipo1234#%&";

                //오웰서버 테스트용
                //server ip : owell.coever.co.kr
                //dbmes id : dbmes
                //테스트할때는  db id도 변경해서 할 것!
                //string strTempPW = "dbmes1!"; //"dbmes1!"; //"0we11Passw0rd!@#dbmes";

                switch (Properties.Settings.Default.DB_TYPE.ToString())
                {
                    case "MySql":
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.MySQLServer;
                        strConnection = string.Format(
                                                         "Server={0};Database={1};UID={2};PWD={3};CharSet=utf8mb4",
                                                         Properties.Settings.Default.SERVER_IP.ToString(),
                                                         Properties.Settings.Default.DB_NAME.ToString(),
                                                         Properties.Settings.Default.DB_ID.ToString(),
                                                         strTempPW
                                                     );
                        break;
                    case "SQLServer":
                        DBManager.PrimaryDBManagerType = DBManagerType.SQLServer;//.SQLServer;
                        strConnection = string.Format(
                                                         "Server={0};Database={1};UID={2};PWD={3};CharSet=utf8mb4",
                                                         Properties.Settings.Default.SERVER_IP.ToString(),
                                                         Properties.Settings.Default.DB_NAME.ToString(),
                                                         Properties.Settings.Default.DB_ID.ToString(),
                                                         strTempPW
                                                     );
                        break;
                    case "ORACLE":
                        //(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=124.136.38.72)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=nNAMSUN)))
                        DBManager.PrimaryDBManagerType = DBManagerType.Oracle;//.ORACLE;
                        strConnection = string.Format(
                                                         "data Source={0};user id={1};password={2}",
                                                         string.Format("(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID={1})))",Properties.Settings.Default.SERVER_IP.ToString(), Properties.Settings.Default.DB_NAME.ToString()),
                                                         Properties.Settings.Default.DB_ID.ToString(),
                                                         strTempPW
                                                     );
                        break;
                    default:
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.MySQLServer;
                        strConnection = string.Format(
                                                         "Server={0};Database={1};UID={2};PWD={3};CharSet=utf8mb4",
                                                         Properties.Settings.Default.SERVER_IP.ToString(),
                                                         Properties.Settings.Default.DB_NAME.ToString(),
                                                         Properties.Settings.Default.DB_ID.ToString(),
                                                         strTempPW
                                                     );
                        break;
                }

                DBManager.PrimaryConnectionString = strConnection;
               //     string.Format
               //(
               //    "Server={0};Database={1};UID={2};PWD={3};CharSet=utf8mb4",
               //    Properties.Settings.Default.SERVER_IP.ToString(),
               //    Properties.Settings.Default.DB_NAME.ToString(),
               //    Properties.Settings.Default.DB_ID.ToString(),
               //     "dbmes1!" //"komipo1234#%&";
               //);

                DBManager.InitDatabaseServer = Properties.Settings.Default.SERVER_IP.ToString();
                DBManager.InitDatabaseName= Properties.Settings.Default.DB_NAME.ToString();
                DBManager.InitDatabaseID = Properties.Settings.Default.DB_ID.ToString();
                DBManager.InitDatabasePass = strTempPW; //"komipo1234#%&";


                


                _ckUserIDSave.EditValue = Properties.Settings.Default.USER_ID_SAVE.ToString();

                if(_ckUserIDSave.EditValue.ToString() == "Y")
                {
                    _txtAccount.Text = Properties.Settings.Default.USER_ID.ToString();
                }
                else
                {
                    _txtAccount.Text = "";
                }

                pUserEntity.LANGUAGE_TYPE = Properties.Settings.Default.MULTI_LANGUAGE.ToString();

                pUserEntity.CULTURE_INFO = Thread.CurrentThread.CurrentCulture.ToString();
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
            _lbLoginHeader.Text = Resources.Language._lbLoginHeader;
            _lciAccount.Text = Resources.Language._lciAccount;
            _lciPassword.Text = Resources.Language._lciPassword;

            _btLoginOk.Text = Resources.Language._btLoginOk;
            _btLoginCancel.Text = Resources.Language._btLoginCancel;

            _btLoginSetting.Text = Resources.Language._btLoginSetting;

            _ckUserIDSave.Text = Resources.Language._ckUserIDSave;



            _msgNotice = Resources.Language._msgNotice;
            _msgLoginMessage = Resources.Language._msgLoginMessage;

        }
        private void InitializeCorporationCI()
        {

            try
            {
                DataTable dtCI = new SystemSettingBusiness().CI_Download();
                if (dtCI != null && (dtCI.Rows[0]["LOGO_FIRST"]).ToString().Length > 0 && (((byte[])dtCI.Rows[0]["LOGO_FIRST"]).Length > 0 && dtCI.Rows.Count > 0))
                {
                    if (System.IO.File.Exists(Application.StartupPath + "\\" + "logo.png"))
                    {
                        _ucIMG_LOGIN_LOGO.Image.Dispose();
                        _ucIMG_LOGIN_LOGO.Image = null;
                        System.IO.File.Delete(Application.StartupPath + "\\" + "logo.png");
                    }

                    Image imgCI = CoFAS_ConvertManager.byteArrayToImage((byte[])dtCI.Rows[0]["LOGO_FIRST"]);
                    if (imgCI != null)
                    {
                        imgCI.Save(Application.StartupPath + "\\" + "logo.png");
                    }
                }

                if (System.IO.File.Exists(Application.StartupPath + "\\" + "logo.png"))
                {
                    _ucIMG_LOGIN_LOGO.Image = Image.FromFile(Application.StartupPath + "\\" + "logo.png");
                }
                else
                {
                    _ucIMG_LOGIN_LOGO.Image = Properties.Resources.None;
                }
            }
            catch(Exception ex)
            {

            }
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
            //pLoginEntity.CORP_CODE = Properties.Settings.Default.CORP_CODE.ToString();
            pLoginEntity.USER_CODE = _txtAccount.Text.ToString();
            pLoginEntity.USER_PASS = CoFAS_AES256Encrypt.EncryptToString(_txtPassword.Text.ToString(),"COEVER",saltBytes, false); // 암호화

            

            DataTable dtLoginInfo = new LoginBusiness().Login_Info(pLoginEntity.USER_CODE, pLoginEntity.USER_PASS);
            //DataTable dtLoginInfo = new LoginBusiness().Login_Info(pLoginEntity.CORP_CODE, pLoginEntity.USER_CODE, pLoginEntity.USER_PASS);
            if (dtLoginInfo == null || dtLoginInfo.Rows.Count == 0)
            {
                CoFAS_DevExpressManager.ShowInformationMessage(_msgLoginMessage);

                _txtPassword.Focus();
                _txtPassword.Select();
                return; 
            }
            else
            {
                //pUserEntity.CORP_CODE = dtLoginInfo.Rows[0]["CORP_CODE"].ToString();
                pUserEntity.CORP_NAME = dtLoginInfo.Rows[0]["CORP_NAME"].ToString();
                pUserEntity.USER_CODE = dtLoginInfo.Rows[0]["USER_ACCOUNT"].ToString();
                pUserEntity.USER_NAME = dtLoginInfo.Rows[0]["USER_NAME"].ToString();
                pUserEntity.USER_GRANT = dtLoginInfo.Rows[0]["USER_GRANT"].ToString();

                if (_ckUserIDSave.EditValue.ToString() == "Y")
                {
                    Properties.Settings.Default.USER_ID = pUserEntity.USER_CODE.ToString();
                    Properties.Settings.Default.USER_ID_SAVE = "Y";
                }
                else
                {
                    Properties.Settings.Default.USER_ID = "";
                    Properties.Settings.Default.USER_ID_SAVE = "N";
                }

                Properties.Settings.Default.Save();

                //frmMain pMain = new frmMain(pUserEntity);
                //듀얼모니터에서 실행위치 보내기
                frmMain pMain = new frmMain(pUserEntity, GetCurrnetMonitor());

                //pMain.Show();
                Hide();
                pMain.ShowDialog();
                _txtPassword.Text =  "";
                Show();
                _txtPassword.Focus();
            }
        }
        //듀얼모니터에서 실행위치에서 폼 띄우기
        private int GetCurrnetMonitor()
        {
            Screen[] screens = Screen.AllScreens;
            int tmp = 0;
            //모니터가 1대 이상일경우
            if(screens.Length>1)
            {
                if (screens[0].WorkingArea.Contains(this.Location))
                    tmp = 0;
                else
                    tmp = 1;
            }
            return tmp;
        }

        private void _txtAccount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    _txtPassword.Focus();
                    _txtPassword.Select();
                }
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
            //frmVerifyPermissions.USER_CODE = _pUSER_CODE;
            frmVerifyPermissions.LANGUAGE_TYPE = pUserEntity.LANGUAGE_TYPE;
            frmVerifyPermissions.FONT_TYPE = _font;
            frmVerifyPermissions xfrmVerifyPermissions = new CORE.UserForm.frmVerifyPermissions(); //유저컨트롤러 설정 부분

            xfrmVerifyPermissions.ShowDialog();

            if (xfrmVerifyPermissions.isReturnGrant)
            {
                frmSetting pSetting = new frmSetting(_txtAccount.Text.ToString());

                pSetting.ShowDialog();
            }

            xfrmVerifyPermissions.Dispose();

            //환경설정이 저장(변경)이 되었으면, 다시 로드
            if (frmSetting.SAVE_YN)
            {
                //

                string myCultureInfo = "";// 

                switch (Properties.Settings.Default.MULTI_LANGUAGE.ToString())
                {
                    case "한국어":
                        myCultureInfo = "ko-KR";
                        break;
                    case "English":
                        myCultureInfo = "en-US";
                        break;
                    case "日本":
                        myCultureInfo = "ja-JP";
                        break;
                    case "中国":
                        myCultureInfo = "zh-CN";
                        break;

                }


                Thread.CurrentThread.CurrentCulture = new CultureInfo(myCultureInfo);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(myCultureInfo);

                Initialize();
                InitializeLanguage();
                InitializeCorporationCI();
                _txtAccount.Focus();

                if (_ckUserIDSave.Checked && _txtAccount.Text.Trim().Length > 1)
                    _txtPassword.Select();
                else
                    _txtAccount.Select();
            }
            else
             _txtAccount.Focus();
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
