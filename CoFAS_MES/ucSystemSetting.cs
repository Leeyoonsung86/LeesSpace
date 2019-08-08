using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CoFAS_MES
{
    public partial class ucSystemSetting : UserControl
    {
        private Font _font = null;

        private string _msgBookMark = "";
        private string _msgBookMarkAdd = "";
        private string _msgBookMarkAddMessage = "";
        private string _msgBookMarkDelete = "";
        private string _msgBookMarkDeleteMessage = "";
        private string _msgBookMarkMessage = "";
        private string _msgLoginMessage = "";
        private string _msgMessage = "";
        private string _msgNotice = "";
        private string _msgSystemClose = "";

        public ucSystemSetting()
        {
            InitializeComponent();

            layoutControl1.AllowCustomization = false; //레이아웃 컨트롤러 커스텀 메뉴 활성화 유무
        }

        private void ucSystemSetting_Load(object sender, EventArgs e)
        {
            try
            {
                _cbSettingMultiLanguage.EditValue = Properties.Settings.Default.MULTI_LANGUAGE.ToString();
                _ftSettingFont_Type.EditValue = Properties.Settings.Default.FONT_TYPE.ToString();
                _seSettingFont_Size.Value = Properties.Settings.Default.FONT_SIZE;

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
                XtraMessageBox.Show(pException.ToString(), _msgNotice, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DevExpress.Utils.AppearanceObject.DefaultFont = _font;//화면에 모든 항목 폰트 재설정
            }

        }

        private void InitializeLanguage()
        {
            _lciSettingLanguage.Text = Resources.Language._lciSettingLanguage;

            _lciSettingServerIP.Text = Resources.Language._lciSettingServerIP;
            _lciSettingDBName.Text = Resources.Language._lciSettingDBName;
            _lciSettingDBID.Text = Resources.Language._lciSettingDBID;
            _lciSettingFont.Text = Resources.Language._lciSettingFont;
            _lciSettingDBType.Text = Resources.Language._lciSettingDBType;

            _btSettingSave.Text = Resources.Language._btSettingSave;

            _lciSettingFTPID.Text = Resources.Language._lciSettingFTPID;
            _lciSettingFTPSERVERIP.Text = Resources.Language._lciSettingFTPSERVERIP;


            _msgNotice = Resources.Language._msgNotice;
            _msgLoginMessage = Resources.Language._msgLoginMessage;

            _msgBookMark = Resources.Language._msgBookMark;
            _msgBookMarkAdd = Resources.Language._msgBookMarkAdd;
            _msgBookMarkAddMessage = Resources.Language._msgBookMarkAddMessage;
            _msgBookMarkDelete = Resources.Language._msgBookMarkDelete;
            _msgBookMarkDeleteMessage = Resources.Language._msgBookMarkDeleteMessage;
            _msgBookMarkMessage = Resources.Language._msgBookMarkMessage;
            _msgLoginMessage = Resources.Language._msgLoginMessage;
            _msgMessage = Resources.Language._msgMessage;
            _msgNotice = Resources.Language._msgNotice;
            _msgSystemClose = Resources.Language._msgSystemClose;
        }

        private void _btSettingSave_Click(object sender, EventArgs e)
        {
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

        }
    }
}
