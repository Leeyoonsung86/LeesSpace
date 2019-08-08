using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CoFAS_MES.POP
{
    public partial class frmPOPSetting : Form
    {
        private string _strUserID = "";
        private Font _font = null;
        private static bool _SAVE_YN = false;

        public static bool SAVE_YN
        {
            get { return _SAVE_YN; }
            set { _SAVE_YN = value; }
        }

        public frmPOPSetting(string strUserID)
        {
            InitializeComponent();

            _strUserID = strUserID;

            layoutControl1.AllowCustomization = false; //레이아웃 컨트롤러 커스텀 메뉴 활성화 유무

        }

        private void frmPOPSetting_Load(object sender, EventArgs e)
        {
            try
            {
                _txtSettingCorpCode.Text = Properties.Settings.Default.CORP_CODE.ToString();
                _cbSettingMultiLanguage.EditValue = Properties.Settings.Default.MULTI_LANGUAGE.ToString();
                _ftSettingFont_Type.EditValue = Properties.Settings.Default.FONT_TYPE.ToString();
                _seSettingFont_Size.Value = Properties.Settings.Default.FONT_SIZE;

                _cbSettingMultiLanguage.ReadOnly = false;
                if (_strUserID == "")
                {
                   // _txtSettingUserID.Text = Properties.Settings.Default.USER_ID.ToString();
                }
                else
                {
                   // _txtSettingUserID.Text = _strUserID;
                }

               // _ckSettingUserIDSave.EditValue = Properties.Settings.Default.USER_ID_SAVE.ToString();
                _txtSettingServerIP.Text = Properties.Settings.Default.SERVER_IP.ToString();
                _txtSettingDBName.Text = Properties.Settings.Default.DB_NAME.ToString();
                _txtSettingDBID.Text = Properties.Settings.Default.DB_ID.ToString();
                _ckSettingDBType.EditValue = Properties.Settings.Default.DB_TYPE.ToString();

                _font = new Font(_ftSettingFont_Type.EditValue.ToString(), Convert.ToInt32(_seSettingFont_Size.Value));


                _txtSettingFTPID.Text = Properties.Settings.Default.FTP_ID.ToString();
                _txtSettingFTPSERVERIP.Text = Properties.Settings.Default.FTP_SERVER_IP.ToString();
                _txtSettingFTPSERVERPORT.Text = Properties.Settings.Default.FTP_SERVER_PORT.ToString();


                InitializeLanguage();
            }
            catch (Exception pException)
            {
                XtraMessageBox.Show(pException.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = _font;//화면에 모든 항목 폰트 재설정
            }
        }

        private void InitializeLanguage()
        {
            //_lbSettingHeader.Text = Resources.Language._lbSettingHeader;
            //_lciSettingCorpCode.Text = Resources.Language._lciSettingCorpCode;
            //_lciSettingLanguage.Text = Resources.Language._lciSettingLanguage;
            //_lciSettingUserID.Text = Resources.Language._lciSettingUserID;
            //_lciSettingUserIDSave.Text = Resources.Language._lciSettingUserIDSave;
            //_ckSettingUserIDSave.Text = Resources.Language._ckSettingUserIDSave;

            //_lciSettingServerIP.Text = Resources.Language._lciSettingServerIP;
            //_lciSettingDBName.Text = Resources.Language._lciSettingDBName;
            //_lciSettingDBID.Text = Resources.Language._lciSettingDBID;
            //_lciSettingFont.Text = Resources.Language._lciSettingFont;
            //_lciSettingDBType.Text = Resources.Language._lciSettingDBType;

            //_btSettingSave.Text = Resources.Language._btSettingSave;
            //_btSettingExit.Text = Resources.Language._btSettingExit;

            //_lciSettingFTPID.Text = Resources.Language._lciSettingFTPID;
            //_lciSettingFTPSERVERIP.Text = Resources.Language._lciSettingFTPSERVERIP;
        }

        private void _btSettingSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CORP_CODE = _txtSettingCorpCode.Text.ToString();
            Properties.Settings.Default.MULTI_LANGUAGE = _cbSettingMultiLanguage.EditValue.ToString();
            Properties.Settings.Default.FONT_TYPE = _ftSettingFont_Type.EditValue.ToString();
            Properties.Settings.Default.FONT_SIZE = Convert.ToInt32(_seSettingFont_Size.Value);


          
            Properties.Settings.Default.SERVER_IP = _txtSettingServerIP.Text.ToString();
            Properties.Settings.Default.DB_NAME = _txtSettingDBName.Text.ToString();
            Properties.Settings.Default.DB_ID = _txtSettingDBID.Text.ToString();
            Properties.Settings.Default.DB_TYPE = _ckSettingDBType.EditValue.ToString();

            Properties.Settings.Default.FTP_ID = _txtSettingFTPID.Text.ToString();
            Properties.Settings.Default.FTP_SERVER_IP = _txtSettingFTPSERVERIP.Text.ToString();
            Properties.Settings.Default.FTP_SERVER_PORT = _txtSettingFTPSERVERPORT.Text.ToString();
            

            Properties.Settings.Default.Save();

            //저장되면 로그인할때 확경설정값 다시 불러오기
            _SAVE_YN = true;

            this.Close();
        }

        private void _btSettingExit_Click(object sender, EventArgs e)
        {
                _SAVE_YN = false;
                this.Close();
        }

        private void _cbSettingMultiLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
