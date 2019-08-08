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
    public partial class frmGatherSetting : System.Windows.Forms.Form
    {
        private string _strUserID = "";
        private Font _font = null;
        private static bool _SAVE_YN = false;

        public static bool SAVE_YN
        {
            get { return _SAVE_YN; }
            set { _SAVE_YN = value; }
        }

        public frmGatherSetting(string strUserID)
        {
            InitializeComponent();

            _strUserID = strUserID;

            layoutControl1.AllowCustomization = false; //레이아웃 컨트롤러 커스텀 메뉴 활성화 유무

        }

        private void frmGatherSetting_Load(object sender, EventArgs e)
        {
            try
            {
              
                _seSettingFont_Size.Value = Properties.Settings.Default.FONT_SIZE;

                if (_strUserID == "")
                {
                   // _txtSettingUserID.Text = Properties.Settings.Default.USER_ID.ToString();
                }
                else
                {
                   // _txtSettingUserID.Text = _strUserID;
                }

                // _ckSettingUserIDSave.EditValue = Properties.Settings.Default.USER_ID_SAVE.ToString();



                _txtSettingFTPSERVERIP.Text = "1";
           


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
            _lbSettingHeader.Text = Resources.Language._lbSettingHeader;
         

            _btSettingSave.Text = Resources.Language._btSettingSave;
            _btSettingExit.Text = Resources.Language._btSettingExit;
     
            _lciSettingFTPSERVERIP.Text = "Average Setting";
        }

        private void _btSettingSave_Click(object sender, EventArgs e)
        {
          
            Properties.Settings.Default.FONT_SIZE = Convert.ToInt32(_seSettingFont_Size.Value);
            Properties.Settings.Default.FTP_SERVER_IP = "Average Setting";
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

        private Point mousePoint;

        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }
        // 마우스 클릭시 먼저 선언된 mousePoint변수에 현재 마우스 위치값이 들어갑니다.

        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
        // 클릭상태로 마우스를 이동시 이동한 만큼에서 윈도우 위치값을 빼게됩니다.

        private void form_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState ==  FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void _btSettingSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
