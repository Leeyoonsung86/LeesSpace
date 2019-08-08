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

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraEditors;

namespace CoFAS_MES.POP
{
    public partial class frmPopupKeypad_T04 : frmBaseSingle
    {
        public string titleName = "";
        public string ReturnValue1 { get; set; }
        public frmPopupKeypad_T04()
        {
            InitializeComponent();
            Activated += new EventHandler(Form_Activated);
            FormClosing += new FormClosingEventHandler(Form_Closing);
            FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Load += new EventHandler(Form_Load);
        }

        //폼 이벤트 처리 영역
        #region ○ Form_Activated
        private void Form_Activated(object pSender, EventArgs pEventArgs)
        {
            try
            {

            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        #region ○ Form_Closing

        private void Form_Closing(object pSender, FormClosingEventArgs pFormClosingEventArgs)
        {
            try
            {
                //pFormClosingEventArgs.Cancel = false;
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));

            }
        }

        #endregion

        #region ○ Form_FormClosed

        private void Form_FormClosed(object pSender, FormClosedEventArgs pFormClosedEventArgs)
        {
            try
            {
                //화면 레이아웃 저장 ?
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        #region ○ Form_Load
        private void Form_Load(object pSender, EventArgs pEventArgs)
        {
            try
            {
                Initialize();
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Size = new Size(320, 480);
                this.StartPosition = FormStartPosition.Manual;
                this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
                this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;


            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }
        #endregion

        // 초기화 처리 영역
        private void Initialize()
        {
            try
            {
                switch (Properties.Settings.Default.DB_ID.ToString())
                {
                    case "MySql":
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.SQLServer;
                        break;
                    case "SQLServer":
                        DBManager.PrimaryDBManagerType = DBManagerType.SQLServer;//.SQLServer;
                        break;
                    default:
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;//.SQLServer;
                        break;
                }

                DBManager.PrimaryConnectionString = string.Format
               (
                   //"location = {0}; user id = {1}; password = {2}; data source = {3}",
                   "Server={0};Database={1};UID={2};PWD={3}",
                   Properties.Settings.Default.SERVER_IP.ToString(),
                   Properties.Settings.Default.DB_NAME.ToString(),
                   Properties.Settings.Default.DB_ID.ToString(),
                   "0we11Passw0rd!@#dbmes"
               //"0we11Passw0rd!@#dbmes"
               );
                WindowName = titleName;

                ucTextKeypad.Font = new Font("굴림", 30, FontStyle.Bold);
                ucTextKeypad.TextAlignment = DevExpress.Utils.HorzAlignment.Far;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Initialize()", pException);
            }
        }




        #region ○ 버튼 클릭시

        private void btnCmd_Click(object pSender, EventArgs pEventArgs)
        {
            SimpleButton pCmd = pSender as SimpleButton;

            string sCls = pCmd.Name.Substring(6, 2);
            switch (sCls)
            {
                case "00":
                    ucTextKeypad.Text += "0";

                    if (ucTextKeypad.Text.Length < 4)
                    {
                        if (ucTextKeypad.Text == "-00" || ucTextKeypad.Text == "00")
                        {
                            ucTextKeypad.Text = ucTextKeypad.Text.Substring(0, ucTextKeypad.Text.Length - 1);
                        }
                    }

                    break;

                case "01":
                    ucTextKeypad.Text += "1";
                    break;

                case "02":
                    ucTextKeypad.Text += "2";
                    break;

                case "03":
                    ucTextKeypad.Text += "3";
                    break;

                case "04":
                    ucTextKeypad.Text += "4";
                    break;

                case "05":
                    ucTextKeypad.Text += "5";
                    break;

                case "06":
                    ucTextKeypad.Text += "6";
                    break;

                case "07":
                    ucTextKeypad.Text += "7";
                    break;

                case "08":
                    ucTextKeypad.Text += "8";
                    break;

                case "09":
                    ucTextKeypad.Text += "9";
                    break;

                case "10":
                    ucTextKeypad.Text += "0";
                    break;

                case "20":
                    // 저장

                    //검사등록

                    decimal temp = 0;

                    if (decimal.TryParse(ucTextKeypad.Text, out temp))
                    {
                        ucTextKeypad.Text = decimal.Parse(ucTextKeypad.Text).ToString();


                        this.DialogResult = DialogResult.OK;

                        ReturnValue1 = ucTextKeypad.Text;
                        this.Close();
                    }
                    else
                    {
                        if (ucTextKeypad.Text == "0" || ucTextKeypad.Text.Trim() == "")
                        {
                            return;
                        }
                    }

                    break;

                case "30":
                    // BS
                    if (ucTextKeypad.Text.Length > 0)
                    {
                        ucTextKeypad.Text = ucTextKeypad.Text.Substring(0, ucTextKeypad.Text.Length - 1);

                    }
                    break;

                case "40":
                    //취소
                    this.DialogResult = DialogResult.No;
                    this.Close();
                    break;

                case "50":
                    //. 소수점
                    if (ucTextKeypad.Text.Length > 0 && ucTextKeypad.Text.IndexOf('.') == -1)
                    {
                        ucTextKeypad.Text += ".";
                    }
                    break;

                case "60":
                    //- 마이너스
                    if (ucTextKeypad.Text.IndexOf('-') < 0)
                    {
                        ucTextKeypad.Text = ucTextKeypad.Text.Insert(0, "-");
                    }
                    break;

                case "70":
                    //+ 플러스
                    if (ucTextKeypad.Text.IndexOf('-') > -1)
                    {
                        ucTextKeypad.Text = ucTextKeypad.Text.Replace("-", string.Empty);
                    }
                    break;


                default: break;
            }
            ucTextKeypad.Focus();

        }

        #endregion

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
