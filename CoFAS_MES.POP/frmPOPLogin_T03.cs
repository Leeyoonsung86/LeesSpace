﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


using CoFAS_MES.CORE;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;

using DevExpress.XtraEditors;
using System.Globalization;

namespace CoFAS_MES.POP
{
    public partial class frmPOPLogin_T03 : Form
    { 
        private LoginEntity pLoginEntity = null; // 로그인 용 엔티티
        private UserEntity pUserEntity = null; // 시스템 사용 사용자 엔티티

        private Font _font = null;

        private byte[] saltBytes = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };


        private string _msgNotice = "";
        private string _msgLoginMessage = "";


        public frmPOPLogin_T03()
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

        private void frmPOPLogin_T03_Load(object sender, EventArgs e)
        {
            try
            {

                Initialize();
                InitializeLanguage();
                InitializeCorporationCI();
                _txtAccount.Focus();
                //화면 컨트롤러 설정
                InitializeControl();
                

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
                switch (Properties.Settings.Default.DB_TYPE.ToString())
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

                Properties.Settings.Default.DB_NAME = "coever_mes_owell_v10_real";

                DBManager.PrimaryConnectionString = string.Format
               (
                   "Server={0};Database={1};UID={2};PWD={3}",
                   Properties.Settings.Default.SERVER_IP.ToString(),
                   Properties.Settings.Default.DB_NAME.ToString(),
                   Properties.Settings.Default.DB_ID.ToString(),
                   "0we11Passw0rd!@#dbmes"
                   //"0we11Passw0rd!@#dbmes"
               );

                DBManager.InitDatabaseServer = Properties.Settings.Default.SERVER_IP.ToString();
                DBManager.InitDatabaseName = Properties.Settings.Default.DB_NAME.ToString();
                DBManager.InitDatabaseID = Properties.Settings.Default.DB_ID.ToString();
                DBManager.InitDatabasePass = "0we11Passw0rd!@#dbmes";
                //DBManager.InitDatabasePass = "0we11Passw0rd!@#dbmes";


                _ckUserIDSave.EditValue = Properties.Settings.Default.USER_ID_SAVE.ToString();
                

                if (_ckUserIDSave.EditValue.ToString() == "Y")
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

        #region ○ 컨트롤 초기화 - InitializeControl()
        private void InitializeControl()
        {
            try
            {
                _luT_PROCESS_LIST.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", pUserEntity.LANGUAGE_TYPE, "POP_PROCESS_DSELECT", "PT13", "", "").Tables[0], 0, 0, "");
                _luT_PROCESS_LIST.ItemIndex = Properties.Settings.Default.PROCESS_POP;
                _luT_PROCESS_LIST.ReadOnly = false;
                _txtPassword.Text = "";
               

                //_luT_TERMINAL_LIST.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", pUserEntity.LANGUAGE_TYPE, "POP_TERMINALE_DETAIL", "", "", "").Tables[0], 0, 0, "");
                //_luT_TERMINAL_LIST.ItemIndex = Properties.Settings.Default.PROCESS_POP;
                //_luT_TERMINAL_LIST.ReadOnly = false;
            }
            catch(Exception ex)
            {
            }
        }
        #endregion
    
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

        // 로고 불러오기
        private void InitializeCorporationCI()
        {
            //DataTable dtCI = new SystemSettingBusiness().CI_Download();
            //if (dtCI != null && (dtCI.Rows[0]["LOGO_FIRST"]).ToString().Length > 0 && (((byte[])dtCI.Rows[0]["LOGO_FIRST"]).Length > 0 && dtCI.Rows.Count > 0))
            //{
            //    if (System.IO.File.Exists(Application.StartupPath + "\\" + "logo.png"))
            //    {
            //        _ucIMG_LOGIN_LOGO.Image.Dispose();
            //        _ucIMG_LOGIN_LOGO.Image = null;
            //        System.IO.File.Delete(Application.StartupPath + "\\" + "logo.png");
            //    }

            //    Image imgCI = CoFAS_ConvertManager.byteArrayToImage((byte[])dtCI.Rows[0]["LOGO_FIRST"]);
            //    if (imgCI != null)
            //    {
            //        imgCI.Save(Application.StartupPath + "\\" + "logo.png");
            //    }
            //}

            if (System.IO.File.Exists(Application.StartupPath + "\\" + "logo.png"))
            {
                _ucIMG_LOGIN_LOGO.Image = Image.FromFile(Application.StartupPath + "\\" + "logo.png");
            }
            else
            {
                _ucIMG_LOGIN_LOGO.Image = Properties.Resources.None;
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
            pLoginEntity.USER_PASS = CoFAS_AES256Encrypt.EncryptToString(_txtPassword.Text.ToString(), "COEVER", saltBytes, false); // 암호화



            DataTable dtLoginInfo = new LoginBusiness().Login_Info(pLoginEntity.USER_CODE, pLoginEntity.USER_PASS);
            //DataTable dtLoginInfo = new LoginBusiness().Login_Info(pLoginEntity.CORP_CODE, pLoginEntity.USER_CODE, pLoginEntity.USER_PASS);
            if (dtLoginInfo == null || dtLoginInfo.Rows.Count == 0)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("誤ったアカウント情報です。");// _msgLoginMessage);

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
                pUserEntity.POP_TITLE = _luT_PROCESS_LIST.GetDisplayName();


                string terminal_code = _luT_PROCESS_LIST.GetValue().ToString();//_luT_TERMINAL_LIST.GetValue().ToString();


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

                //공정저장
                Properties.Settings.Default.PROCESS_POP = _luT_PROCESS_LIST.ItemIndex;
                  
                Properties.Settings.Default.Save();

                pUserEntity.RESOURCE_CODE = Properties.Settings.Default.RESOURCE_CODE;
                pUserEntity.PROCESS_CODE = _luT_PROCESS_LIST.GetValue();
                string _SELECT_PROCESS_POP = _luT_PROCESS_LIST.GetValue();

                //switch (_SELECT_PROCESS_POP)
                //{
                //    //case "frmPOPMain_MATERIAL_COSMETICS":       //부자재실
                //    //    frmPOPMain_MATERIAL_COSMETICS pMain1 = new frmPOPMain_MATERIAL_COSMETICS(pUserEntity);
                //    //    pMain1.Show();
                //    //    break;
                //    case "PT130001":    //반죽
                //        //frmPOPMain_PRODUCTION pMain3 = new frmPOPMain_PRODUCTION(pUserEntity, terminal_code);
                //        //pMain3.Show();
                //        frmPOPProductMonitoring pMain3 = new frmPOPProductMonitoring(pUserEntity);
                   //     pMain3.Show();
                    //    break;
                    //case "PT130003":    //포장
                        frmPOPMain_PRODUCT pMain2 = new frmPOPMain_PRODUCT(pUserEntity, terminal_code, "");
                        pMain2.Show();
                        ////frmPOPProductMonitoring pMain2 = new frmPOPProductMonitoring(pUserEntity);
                        //// pMain2.Show();
                        //break;
                //}

               
                Hide();
            }
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
            /*
            //frmVerifyPermissions.USER_CODE = _pUSER_CODE;
            frmVerifyPermissions.LANGUAGE_TYPE = pUserEntity.LANGUAGE_TYPE;
            frmVerifyPermissions.FONT_TYPE = _font;
            frmVerifyPermissions xfrmVerifyPermissions = new CORE.UserForm.frmVerifyPermissions(); //유저컨트롤러 설정 부분

            xfrmVerifyPermissions.ShowDialog();

            if (xfrmVerifyPermissions.isReturnGrant)
            {
                frmPOPSetting pSetting = new frmPOPSetting(_txtAccount.Text.ToString());

                pSetting.ShowDialog();
            }

            xfrmVerifyPermissions.Dispose();
            */

            //위에 환경설정 관리자부분 추가가 될경우 하단 showdialog 지우기
            frmPOPSetting pSetting = new frmPOPSetting(_txtAccount.Text.ToString());
            pSetting.ShowDialog();

            //환경설정이 저장(변경)이 되었으면, 다시 로드
            if (frmPOPSetting.SAVE_YN)
            {
                //

                string myCultureInfo = "";// 

                //switch (Properties.Settings.Default.MULTI_LANGUAGE.ToString())
                //{
                    //case "한국어":
                    //    myCultureInfo = "ko-KR";
                    //    break;
                    //case "English":
                    //    myCultureInfo = "en-US";
                    //    break;
                    //case "日本":
                        myCultureInfo = "ja-JP";
                    //    break;
                    //case "中国":
                    //    myCultureInfo = "zh-CN";
                    //    break;

                //}


                Thread.CurrentThread.CurrentCulture = new CultureInfo(myCultureInfo);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(myCultureInfo);

                Initialize();
                InitializeLanguage();
                InitializeCorporationCI();
                _txtAccount.Focus();
                InitializeControl();

                if (_ckUserIDSave.Checked && _txtAccount.Text.Trim().Length > 1)
                    _txtPassword.Select();
                else
                    _txtAccount.Select();
            }
            else
                _txtAccount.Focus();
        }

        #region ○ 단말기 구분 콤보박스 변경 - _luT_PROCESS_LIST_TabIndexChanged(object sender, EventArgs e)
        //private void _luT_PROCESS_LIST_TabIndexChanged(object sender, EventArgs e)
        //{
        //    String ProcessCode = _luT_PROCESS_LIST.GetValue();

        //    //_luT_TERMINAL_LIST.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", pUserEntity.LANGUAGE_TYPE, "POP_TERMINALE_DETAIL2", ProcessCode, "", "").Tables[0], 0, 0, "");
        //    //_luT_TERMINAL_LIST.ItemIndex = Properties.Settings.Default.PROCESS_POP;
        //    //_luT_TERMINAL_LIST.ReadOnly = false;
        //    switch (ProcessCode)
        //    {
        //        case "PT130003": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.

        //            _luT_TERMINAL_LIST.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", pUserEntity.LANGUAGE_TYPE, "POP_TERMINALE_DETAIL3", ProcessCode, "", "").Tables[0], 0, 0, "");
        //            _luT_TERMINAL_LIST.ItemIndex = Properties.Settings.Default.PROCESS_POP;
        //            _luT_TERMINAL_LIST.ReadOnly = false;

        //            break;

        //        case "PT130001": //해당 그리드에 필드명 // 2개 이상 그리드의 버튼 항목들은 버튼 타입에 필드 명칭이 모두 다르게 설정 되어야됨.

        //            _luT_TERMINAL_LIST.AddValue(new CommonCodeReturnBusiness().CommonCode_Return("R", pUserEntity.LANGUAGE_TYPE, "POP_TERMINALE_DETAIL3", ProcessCode, "", "").Tables[0], 0, 0, "");
        //            _luT_TERMINAL_LIST.ItemIndex = Properties.Settings.Default.PROCESS_POP;
        //            _luT_TERMINAL_LIST.ReadOnly = false;

        //            break;
                    
                    
        //    }
        //}
        #endregion

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

        private void _luT_PROCESS_LIST_TabIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
