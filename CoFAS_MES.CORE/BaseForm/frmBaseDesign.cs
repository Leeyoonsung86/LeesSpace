using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.CORE.Entity;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.DashboardCommon;
using System.IO;
using DevExpress.DashboardWin;
using System.Reflection;
using DevExpress.DataAccess;

namespace CoFAS_MES.CORE.BaseForm
{
    public partial class frmBaseDesign : Form, IForm
    {
        public delegate void MessageEventHandler(string pMessage);
        public event MessageEventHandler MessageEvent;

        //public delegate void WaitingShowEventHandler();
        //public event WaitingShowEventHandler WaitingShowEvent;

        //public delegate void WaitingCloseEventHandler();
        //public event WaitingCloseEventHandler WaitingCloseEvent;



        /// <summary>
        /// 메뉴 정보
        /// </summary>
        protected MenuSettingEntity _pMenuSettingEntity = null;

        #region 메인 폼 - MainForm

        /// <summary>
        /// 메인 폼
        /// </summary>
        public IMainForm MainForm
        {
            get
            {
                return MdiParent as IMainForm;
            }
        }

        #endregion

        #region Event

        /// <summary>
        /// 닫기 버튼 클릭시 
        /// </summary>
        public event EventHandler FormCloseButtonClicked;

        /// <summary>
        /// 내보내기 버튼 클릭시
        /// </summary>
        public event EventHandler ExportButtonClicked;

        /// <summary>
        /// 가져오기 버튼 클릭시
        /// </summary>
        public event EventHandler ImportButtonClicked;

        /// <summary>
        /// 인쇄 버튼 클릭시
        /// </summary>
        public event EventHandler PrintButtonClicked;

        /// <summary>
        /// 저장 버튼 클릭시
        /// </summary>
        public event EventHandler SaveButtonClicked;

        /// <summary>
        /// 삭제 버튼 클릭시
        /// </summary>
        public event EventHandler DeleteButtonClicked;

        /// <summary>
        /// 조회 버튼 클릭시
        /// </summary>
        public event EventHandler SearchButtonClicked;

        /// <summary>
        /// 초기화 버튼 클릭시
        /// </summary>
        public event EventHandler InitialButtonClicked;

        /// <summary>
        /// 설정 버튼 클릭시
        /// </summary>
        public event EventHandler SettingButtonClicked;

        /// <summary>
        /// 신규추가 버튼 클릭시
        /// </summary>
        public event EventHandler AddItemButtonClicked;
        #endregion


        #region 윈도우명 - WindowName

        /// <summary>
        /// 윈도우명
        /// </summary>
        public string WindowName
        {
            get
            {
                return Text;
            }
            set
            {
                Text = value;
            }
        }

        #endregion

        #region 메뉴 설정 개체 - MenuSettingEntity

        /// <summary>
        /// 메뉴 설정 개체
        /// </summary>
        public MenuSettingEntity MenuSettingEntity
        {
            get
            {
                return _pMenuSettingEntity;
            }
            set
            {
                _pMenuSettingEntity = value;
            }
        }

        #endregion


        #region 화면 디자인 설정  - Dashboard Setting

        protected static Dashboard CreateCopy(Dashboard dashboard)
        {
            using (Stream stream = new MemoryStream())
            {
                dashboard.SaveToXml(stream);
                stream.Seek(0L, SeekOrigin.Begin);
                Dashboard copy = new Dashboard();
                copy.LoadFromXml(stream);
                for (int i = 0; i < dashboard.DataSources.Count; i++)
                {
                    IDashboardDataSource dataSource = dashboard.DataSources[i];
                    if (dataSource is DashboardObjectDataSource)
                        copy.DataSources[i].Data = dataSource.Data;
                    DashboardExtractDataSource extractDataSource = dataSource as DashboardExtractDataSource;
                    if (extractDataSource is DashboardExtractDataSource)
                        ((DashboardExtractDataSource)copy.DataSources[i]).FileName = extractDataSource.FileName;
                }
                return copy;
            }
        }

        protected bool dashboardModified = false;
        Dashboard dashboard;

        protected Dashboard Dashboard
        {
            get { return dashboard; }
            set
            {
                if (value != dashboard)
                {
                    DisposeDashboard();
                    dashboard = value;
                    OnDashboardChanged();
                }
            }
        }
        protected DashboardViewer DashboardViewer { get { return dashboardViewer; } }
        protected bool DashboardModified { get { return dashboardModified; } }
        #endregion


        public frmBaseDesign()
        {
            InitializeComponent();
            Initialize(); //dashboard 용 초기화
        }

        void Initialize()
        {
            //panelFooter.Visible = ShowFooterPanel;
           // dashboardViewer.CalculateHiddenTotals = CalculateHiddenTotals;
            dashboardViewer.DataSourceOptions.ObjectDataSourceLoadingBehavior = DocumentLoadingBehavior.LoadAsIs;
            SubscribeDashboardEvents();
            //LoadDashboard();
        }

        protected virtual void EditDashboard()
        {
            using (Dashboard dashboard = CreateCopy(Dashboard))
            {
                using (CoFAS_MES.CORE.UserForm.frmViewDesign designerForm = new CoFAS_MES.CORE.UserForm.frmViewDesign(dashboard))
                {
                    //designerForm.AllowFormGlass = DevExpress.Skins.SkinManager.AllowFormSkins ? DefaultBoolean.False : DefaultBoolean.True;
                    designerForm.ShowDialog();
                    if (designerForm.SaveDashboard)
                    {
                        Dashboard = CreateCopy(designerForm.Dashboard);
                        dashboardModified = true;
                    }
                }
            }
        }

        protected virtual void SubscribeDashboardEvents() { }
        void OnDashboardChanged()
        {
            dashboardViewer.Dashboard = dashboard;
        }

        //void LoadDashboard()
        //{
        //    Assembly asm = Assembly.GetExecutingAssembly();
        //    Type dashboardType = asm.GetType(string.Format("DashboardMainDemo.Dashboards.{0}", GetType().Name));
        //    if (dashboardType != null)
        //        Dashboard = (Dashboard)Activator.CreateInstance(dashboardType);
        //    else
        //        Dashboard = null;
        //}

        void DisposeDashboard()
        {
            if (dashboard != null)
                dashboard.Dispose();
        }

        #region 닫기 버튼 클릭시 이벤트 발생시키기 - RaiseExitButtonClickedEvent()

        /// <summary>
        /// 닫기 버튼 클릭시 이벤트 발생시키기
        /// </summary>
        public void RaiseFormCloseButtonClickedEvent()
        {
            if (FormCloseButtonClicked != null)
            {
                FormCloseButtonClicked(this, EventArgs.Empty);
            }
        }

        #endregion

        #region 내보내기 버튼 클릭시 이벤트 발생시키기 - RaiseExportButtonClickedEvent()

        /// <summary>
        /// 내보내기 버튼 클릭시 이벤트 발생시키기
        /// </summary>
        public void RaiseExportButtonClickedEvent()
        {
            if (ExportButtonClicked != null)
            {
                ExportButtonClicked(this, EventArgs.Empty);
            }
        }

        #endregion

        #region 가져오기 버튼 클릭시 이벤트 발생시키기 - RaiseImportButtonClickedEvent()

        /// <summary>
        /// 가져오기 버튼 클릭시 이벤트 발생시키기
        /// </summary>
        public void RaiseImportButtonClickedEvent()
        {
            if (ImportButtonClicked != null)
            {
                ImportButtonClicked(this, EventArgs.Empty);
            }
        }

        #endregion

        #region 인쇄 버튼 클릭시 이벤트 발생시키기 - RaisePrintButtonClickedEvent()

        /// <summary>
        /// 인쇄 버튼 클릭시 이벤트 발생시키기
        /// </summary>
        public void RaisePrintButtonClickedEvent()
        {
            if (PrintButtonClicked != null)
            {
                PrintButtonClicked(this, EventArgs.Empty);
            }
        }

        #endregion

        #region 삭제 버튼 클릭시 이벤트 발생시키기 - RaiseDeleteButtonClickedEvent()

        /// <summary>
        /// 삭제 버튼 클릭시 이벤트 발생시키기
        /// </summary>
        public void RaiseDeleteButtonClickedEvent()
        {
            if (DeleteButtonClicked != null)
            {
                DeleteButtonClicked(this, EventArgs.Empty);
            }
        }

        #endregion

        #region 저장 버튼 클릭시 이벤트 발생시키기 - RaiseSaveButtonClickedEvent()

        /// <summary>
        /// 저장 버튼 클릭시 이벤트 발생시키기
        /// </summary>
        public void RaiseSaveButtonClickedEvent()
        {
            if (SaveButtonClicked != null)
            {
                SaveButtonClicked(this, EventArgs.Empty);
            }
        }

        #endregion

        #region 조회 버튼 클릭시 이벤트 발생시키기 - RaiseFindButtonClickedEvent()

        /// <summary>
        /// 조회 버튼 클릭시 이벤트 발생시키기
        /// </summary>
        public void RaiseSearchButtonClickedEvent()
        {
            if (SearchButtonClicked != null)
            {
                SearchButtonClicked(this, EventArgs.Empty);
            }
        }

        #endregion

        #region 초기화 버튼 클릭시 이벤트 발생시키기 - RaiseInitialButtonClickedEvent()

        /// <summary>
        /// 초기화 버튼 클릭시 이벤트 발생시키기
        /// </summary>
        public void RaiseInitialButtonClickedEvent()
        {
            if (InitialButtonClicked != null)
            {
                InitialButtonClicked(this, EventArgs.Empty);
            }
        }

        #endregion

        #region 설정 버튼 클릭시 이벤트 발생시키기 - RaiseSettingButtonClickedEvent()

        /// <summary>
        /// 설정 버튼 클릭시 이벤트 발생시키기
        /// </summary>
        public void RaiseSettingButtonClickedEvent()
        {
            if (SettingButtonClicked != null)
            {
                SettingButtonClicked(this, EventArgs.Empty);
            }
        }

        #endregion

        #region 신규추가 버튼 클릭시 이벤트 발생시키기 - RaiseAddItemButtonClickedEvent()

        /// <summary>
        /// 신규추가 버튼 클릭시 이벤트 발생시키기
        /// </summary>
        public void RaiseAddItemButtonClickedEvent()
        {
            if (AddItemButtonClicked != null)
            {
                AddItemButtonClicked(this, EventArgs.Empty);
            }
        }

        #endregion

        /// <summary>
        /// dxValidationProvider 함수는 BaseControl 에서만 가능. 
        /// UserControl 은 별도 처리 해야됨.
        /// </summary>
        ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
        public ConditionValidationRule NotEmptyValidationRule
        {
            get
            {
                notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
                notEmptyValidationRule.ErrorText = "Please enter a value";
                return notEmptyValidationRule;
            }
        }

        public void Show_Waiting()
        {
            //splashScreenManager1.s
            //dxWaitingForm.ShowWaitForm();

            //if(WaitingShowEvent != null)
            //{
            //    WaitingShowEvent();
            //}
        }
        public void Stop_Waiting()
        {
            //dxWaitingForm.CloseWaitForm();
            //if(WaitingCloseEvent != null)
            //{
            //    WaitingCloseEvent();
            //}
        }

        #region 메시지 표시하기

        /// <summary>
        /// 메시지를 status에 표시한다
        /// </summary>
        /// <param name="pMessage"></param>
        protected void DisplayMessage(string pMessage)
        {
            DateTime dt = DateTime.Now;
            if (MessageEvent != null)
            {
                MessageEvent(string.Format("[{0}:{1}:{2}] {3}\r\n", dt.ToString("HH"), dt.ToString("mm"), dt.ToString("ss"), pMessage));
            }
        }

        #endregion


    }
}
