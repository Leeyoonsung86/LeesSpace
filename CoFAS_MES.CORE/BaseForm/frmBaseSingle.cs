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

using DevExpress.XtraEditors;

namespace CoFAS_MES.CORE.BaseForm
{
    public partial class frmBaseSingle : Form, IPopUpForm
    {
        public string WindowName
        {
            get
            {
                return _lbSINGLE_HEADER.Text.ToString();
            }
            set
            {
                _lbSINGLE_HEADER.Text = value;
            }
        }

        private string strChild_Window_Name;
        public string Child_WindowName
        {
            get
            {
                return strChild_Window_Name;
            }
            set
            {
                strChild_Window_Name = value;
            }
        }

        private string strChild_User_Code;
        public string Child_User_Code
        {
            get
            {
                return strChild_User_Code;
            }
            set
            {
                strChild_User_Code = value;
            }
        }

        private string strChild_Language_Type;
        public string Child_Language_Type
        {
            get
            {
                return strChild_Language_Type;
            }
            set
            {
                strChild_Language_Type = value;
            }
        }

        private Font strChild_Font_Setting;
        public Font Child_Font_Setting
        {
            get
            {
                return strChild_Font_Setting;
            }
            set
            {
                strChild_Font_Setting = value;
            }
        }

        private bool isPage_Setting;
        public bool Child_Page_Setting
        {
            get
            {
                return isPage_Setting;
            }
            set
            {
                isPage_Setting = value;
            }
        }

        public bool Child_Page_Setting_Visible
        {
            get
            {
                return _btPageSetting.Visible;
            }
            set
            {
                _btPageSetting.Visible = value;
            }
        }

        #region Interface

        private string strPageSetting_WINDOW_NAME = "";
        public string PageSetting_WINDOW_NAME
        {
            get
            {
                return strPageSetting_WINDOW_NAME;
            }
            set
            {
                strPageSetting_WINDOW_NAME = value;
            }
        }

        private string strPageSetting_USER_CODE = "";
        public string PageSetting_USER_CODE
        {
            get
            {
                return strPageSetting_USER_CODE;
            }
            set
            {
                strPageSetting_USER_CODE = value;
            }
        }

        private string strPageSetting_LANGUAGE = "";
        public string PageSetting_LANGUAGE
        {
            get
            {
                return strPageSetting_LANGUAGE;
            }
            set
            {
                strPageSetting_LANGUAGE = value;
            }
        }

        private Font fntPageSetting_FONT = null;
        public Font PageSetting_FONT
        {
            get
            {
                return fntPageSetting_FONT;
            }
            set
            {
                fntPageSetting_FONT = value;
            }
        }
        #endregion

        public frmBaseSingle()
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

        private void frmBaseSingle_Load(object sender, EventArgs e)
        {

        }

        private void _btSingleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _btSingleMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void _btSingleNomal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void _btPageSetting_Click(object sender, EventArgs e)
        {
            CoFAS_MES.CORE.UserForm.frmPageSetting xfrmPageSetting = new CORE.UserForm.frmPageSetting();

            xfrmPageSetting.PASS_PARENT_WINDOW_NAME = strPageSetting_WINDOW_NAME;
            xfrmPageSetting.PASS_USER_CODE = strPageSetting_USER_CODE;
            xfrmPageSetting.PASS_PARENT_LANGUAGE = strPageSetting_LANGUAGE;
            xfrmPageSetting.PASS_PARENT_FONT = fntPageSetting_FONT;

            xfrmPageSetting.ShowDialog();

            if (xfrmPageSetting.PASS_RESULT)
            {
                xfrmPageSetting.Dispose();
            }
        }

        public void ProcessCommand(Enum cmd, object arg)
        {
            throw new NotImplementedException();
        }
    }
}
