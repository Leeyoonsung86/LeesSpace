
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
using DevExpress.DashboardCommon;
using DevExpress.XtraEditors;
using CoFAS_MES.CORE.Function;
using DevExpress.DataAccess.ConnectionParameters;

namespace CoFAS_MES.CORE.UserForm
{
    public partial class frmViewDesign : frmBaseSingle
    {
        private string strCORP_CODE = "";
        private string strUSER_CODE = "";
        private string strPARENT_WINDOW_ID = "";
        private string strPARENT_WINDOW_NAME = "";
        private string strPARENT_LANGUAGE = "";

        private Font fntPARENT_FONT = null;

        //private string _pWINDOW_NAME = "";

        private bool isRESULT = false;

        //private bool _pFirstYN = true; // 최초실행여부 최초 설정 에서만 사용

        public string PASS_CORP_CODE
        {
            get { return this.strCORP_CODE; }
            set { this.strCORP_CODE = value; }
        }
        public string PASS_USER_CODE
        {
            get { return this.strUSER_CODE; }
            set { this.strUSER_CODE = value; }
        }
        public string PASS_PARENT_WINDOW_ID
        {
            get { return this.strPARENT_WINDOW_ID; }
            set { this.strPARENT_WINDOW_ID = value; }
        }
        public string PASS_PARENT_WINDOW_NAME
        {
            get { return this.strPARENT_WINDOW_NAME; }
            set { this.strPARENT_WINDOW_NAME = value; }
        }
        public string PASS_PARENT_LANGUAGE
        {
            get { return this.strPARENT_LANGUAGE; }
            set { this.strPARENT_LANGUAGE = value; }
        }
        public Font PASS_PARENT_FONT
        {
            get { return this.fntPARENT_FONT; }
            set { this.fntPARENT_FONT = value; }
        }
        public bool PASS_RESULT
        {
            get { return this.isRESULT; }
            set { this.isRESULT = value; }
        }


        bool saveDashboard;
        public Dashboard Dashboard { get { return dashboardDesigner.Dashboard; } }
        public bool SaveDashboard { get { return saveDashboard; } }

        public frmViewDesign(Dashboard dashboard)
        {
            InitializeComponent();
            if(dashboard != null) dashboardDesigner.Dashboard = dashboard;
        }

        private void frmViewDesign_Load(object sender, EventArgs e)
        {
            //fileRibbonPageGroup1.Enabled = false;
            //fileNewBarItem1.Enabled = false;
            //fileOpenBarItem1.Enabled = false;
            //ribbonControl1.Toolbar.ItemLinks.Remove(fileSaveBarItem1);
            //dashboardBackstageViewControl1.Enabled = false;
            WindowName = strPARENT_WINDOW_ID + "    " + strPARENT_WINDOW_NAME;

            this.WindowState = FormWindowState.Maximized;

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (dashboardDesigner.IsDashboardModified)
            {
                DialogResult result = XtraMessageBox.Show(this, "There is a work item. \tDo you want to close it ?", "Dashboard Designer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    e.Cancel = true;
                else
                    saveDashboard = result == DialogResult.Yes;
            }
        }

        private void dashboardDesigner_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e)
        {
                switch (DBManager.PrimaryDBManagerType)
                {
                    case DBManagerType.MySql:
                    e.ConnectionParameters = new MySqlConnectionParameters(DBManager.InitDatabaseServer, DBManager.InitDatabaseName, DBManager.InitDatabaseID, DBManager.InitDatabasePass, 3306);
                    break;
                    case DBManagerType.SQLServer:
                        e.ConnectionParameters = new MsSqlConnectionParameters();
                        break;
                }
        }
    }
}
