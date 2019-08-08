using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.CORE.Function;


namespace CoFAS_MES.CORE.BaseForm
{
    public partial class frmBasePOP : Form
    {
        private System.Threading.Timer tmrTime; //시간 타이머 스레드

        //public delegate void MessageEventHandler(string pMessage);
        //public event MessageEventHandler MessageEvent;

        private CoFAS_Log _pCoFASLog = new CoFAS_Log(Application.StartupPath + "\\LOG", "", 30, true);

        private string _pMessage = string.Empty; //메세지 처리

        private string _pttitle = string.Empty; //화면 타이틀 처리

        private string _pTimeSt = string.Empty; //화면 시작시간 처리
        private string _pTimeEt = string.Empty; //화면 시작시간 처리

        public Image _ptci = null;

        public Image _ptCI
        {
            get
            {
                if (_ptci == null)
                {
                    //_ptci.PropertyIdList = .PropertyItems;
                }
                return _ptci;
            }
            set
            {
                _ptci = value;
                CoFAS_ControlManager.InvokeIfNeeded(_peCI,() => _peCI.Image = _ptci);
            }


        }


        protected string _ptTitle
        {

            get
            {
                if (_pttitle == null)
                {
                    _pttitle = "Title Name";
                }
                return _pttitle;
            }
            set
            {
                _pttitle = value;
                CoFAS_ControlManager.InvokeIfNeeded(_lbTitle, () => _lbTitle.Text = _pttitle);
            }
        }

        protected string _ptimeSt
        {
            get
            {
                if (_pTimeSt == null)
                {
                    _pTimeSt = "開始時間 :";
                }
                return _pTimeSt;
            }
            set
            {
                _pTimeSt = value;
                CoFAS_ControlManager.InvokeIfNeeded(_lbStartName, () => _lbStartName.Text = _pTimeSt);
            }
        }

        protected string _ptimeEt
        {
            get
            {
                if (_pTimeEt == null)
                {
                    _pTimeEt = "現在の時刻 :";
                }
                return _pTimeSt;
            }
            set
            {
                _pTimeEt = value;
                CoFAS_ControlManager.InvokeIfNeeded(_lbCurrentName, () => _lbCurrentName.Text = _pTimeEt);
            }
        }



        public frmBasePOP()
        {
            InitializeComponent();
            if (System.IO.File.Exists(Application.StartupPath + "\\" + "logo.png"))
            {
                _peCI.Image = Image.FromFile(Application.StartupPath + "\\" + "logo.png");
            }
            else
            {
                _peCI.Image = Properties.Resources.None;
            }
            CoFAS_ControlManager.InvokeIfNeeded(_lbStartTime, () => _lbStartTime.Text = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTime));

            tmrTime = new System.Threading.Timer(new TimerCallback(Up_Date_Time), null, 0, 1000);
        }

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

        private void frm_Base_None_Load(object sender, EventArgs e)
        {


        }

        #region ○ Up_Date_Time : 현제 시간 업데이트
        private void Up_Date_Time(object obj)
        {
            CoFAS_ControlManager.InvokeIfNeeded(_lbCurrentTime, () => _lbCurrentTime.Text = CoFAS_ConvertManager.Date2String(DateTime.Now, CoFAS_ConvertManager.enDateType.DateTime));
        }
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
            this.Close();
            Application.Exit();
        }


        #region 메시지 표시하기
        /// <summary>
        /// 메시지를 표시한다
        /// </summary>
        /// <param name="pMessage"></param>
        protected void DisplayMessage(string pMessage)
        {
            DateTime dt = DateTime.Now;

            _pMessage = string.Format("[{0}:{1}:{2}] {3}\r\n", dt.ToString("HH"), dt.ToString("mm"), dt.ToString("ss"), pMessage);

            CoFAS_ControlManager.InvokeIfNeeded(_lbMessage, () => _lbMessage.Text = _pMessage);
        }
        #endregion


        // ■ 메세지 처리
        #region ○ 메세지 처리
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strMessage">메세지 표시</param>
        /// <param name="isLog">로그 저장 유무</param>
        /// <param name="isView">화면 표시 유무</param>
        private void Message_Log(string strMessage, bool isLog, bool isView)
        {
            DateTime dt = DateTime.Now;

            _pMessage = string.Format("[{0}:{1}:{2}] {3}\r\n", dt.ToString("HH"), dt.ToString("mm"), dt.ToString("ss"), strMessage);

            if (isView)
            {
                CoFAS_ControlManager.InvokeIfNeeded(_lbMessage, () => _lbMessage.Text = _pMessage);
            }

            if (isLog)
            {
                _pCoFASLog.WLog(_pMessage);
            }
        }
        #endregion

        private void _peCI_Click(object sender, EventArgs e)
        {

        }
    }
}
