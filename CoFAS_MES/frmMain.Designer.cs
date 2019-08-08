namespace CoFAS_MES
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager dxWaitingScreen = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CoFAS_MES.frmWaitingScreen), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this._pnTop = new DevExpress.XtraEditors.PanelControl();
            this._lbMAIN_HEADER = new DevExpress.XtraEditors.LabelControl();
            this._btSystem_Setting = new DevExpress.XtraEditors.SimpleButton();
            this._btLogout = new DevExpress.XtraEditors.SimpleButton();
            this._btMin = new DevExpress.XtraEditors.SimpleButton();
            this._btMax = new DevExpress.XtraEditors.SimpleButton();
            this._btClose = new DevExpress.XtraEditors.SimpleButton();
            this._btSETTING = new DevExpress.XtraEditors.SimpleButton();
            this._pnButton = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._pnButtonGroup = new DevExpress.XtraEditors.PanelControl();
            this._btADDITEM = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._pnUser_Info = new DevExpress.XtraEditors.PanelControl();
            this._ptUser = new DevExpress.XtraEditors.PictureEdit();
            this._btUSER_SETTING = new DevExpress.XtraEditors.SimpleButton();
            this._btEXIT = new DevExpress.XtraEditors.SimpleButton();
            this._btSliding = new DevExpress.XtraEditors.SimpleButton();
            this._btFORMCLOSE = new DevExpress.XtraEditors.SimpleButton();
            this._btINITIAL = new DevExpress.XtraEditors.SimpleButton();
            this._btEXPORT = new DevExpress.XtraEditors.SimpleButton();
            this._btIMPORT = new DevExpress.XtraEditors.SimpleButton();
            this._btSAVE = new DevExpress.XtraEditors.SimpleButton();
            this._btDELETE = new DevExpress.XtraEditors.SimpleButton();
            this._btPRINT = new DevExpress.XtraEditors.SimpleButton();
            this._btSEARCH = new DevExpress.XtraEditors.SimpleButton();
            this._btHOME = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this._ptCI = new DevExpress.XtraEditors.PictureEdit();
            this._lbUserName = new DevExpress.XtraEditors.LabelControl();
            this._acdMenuControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.xtraTabMdiControl = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this._pnMain = new DevExpress.XtraEditors.PanelControl();
            this._btSet = new DevExpress.XtraEditors.PanelControl();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this._btHomeRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this._btHomeMaxSize = new DevExpress.XtraEditors.SimpleButton();
            this._lbMessage = new DevExpress.XtraEditors.LabelControl();
            this._pnBottom = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._lbScreenID = new DevExpress.XtraEditors.LabelControl();
            this._lbScreenName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this._pnTop)).BeginInit();
            this._pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnButton)).BeginInit();
            this._pnButton.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnButtonGroup)).BeginInit();
            this._pnButtonGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnUser_Info)).BeginInit();
            this._pnUser_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ptUser.Properties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ptCI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._acdMenuControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabMdiControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnMain)).BeginInit();
            this._pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._btSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnBottom)).BeginInit();
            this._pnBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dxWaitingScreen
            // 
            dxWaitingScreen.ClosingDelay = 500;
            // 
            // _pnTop
            // 
            this._pnTop.Appearance.BackColor = System.Drawing.Color.DarkTurquoise;
            this._pnTop.Appearance.Options.UseBackColor = true;
            this._pnTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnTop.Controls.Add(this._lbMAIN_HEADER);
            this._pnTop.Controls.Add(this._btSystem_Setting);
            this._pnTop.Controls.Add(this._btLogout);
            this._pnTop.Controls.Add(this._btMin);
            this._pnTop.Controls.Add(this._btMax);
            this._pnTop.Controls.Add(this._btClose);
            this._pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnTop.Location = new System.Drawing.Point(0, 0);
            this._pnTop.Margin = new System.Windows.Forms.Padding(0);
            this._pnTop.Name = "_pnTop";
            this._pnTop.Size = new System.Drawing.Size(1400, 23);
            this._pnTop.TabIndex = 0;
            // 
            // _lbMAIN_HEADER
            // 
            this._lbMAIN_HEADER.Appearance.BackColor = System.Drawing.Color.DarkTurquoise;
            this._lbMAIN_HEADER.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._lbMAIN_HEADER.Appearance.ForeColor = System.Drawing.Color.Black;
            this._lbMAIN_HEADER.Appearance.Image = global::CoFAS_MES.Properties.Resources.folderpanel_16x16;
            this._lbMAIN_HEADER.Appearance.Options.UseBackColor = true;
            this._lbMAIN_HEADER.Appearance.Options.UseFont = true;
            this._lbMAIN_HEADER.Appearance.Options.UseForeColor = true;
            this._lbMAIN_HEADER.Appearance.Options.UseImage = true;
            this._lbMAIN_HEADER.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbMAIN_HEADER.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbMAIN_HEADER.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._lbMAIN_HEADER.Location = new System.Drawing.Point(0, 0);
            this._lbMAIN_HEADER.Margin = new System.Windows.Forms.Padding(0);
            this._lbMAIN_HEADER.Name = "_lbMAIN_HEADER";
            this._lbMAIN_HEADER.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this._lbMAIN_HEADER.Size = new System.Drawing.Size(1295, 23);
            this._lbMAIN_HEADER.TabIndex = 3;
            this._lbMAIN_HEADER.Text = "System Name_ver";
            this._lbMAIN_HEADER.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form_SizeChange);
            this._lbMAIN_HEADER.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Moving);
            // 
            // _btSystem_Setting
            // 
            this._btSystem_Setting.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btSystem_Setting.Appearance.Options.UseBackColor = true;
            this._btSystem_Setting.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btSystem_Setting.Dock = System.Windows.Forms.DockStyle.Right;
            this._btSystem_Setting.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.customizegrid_16x16;
            this._btSystem_Setting.Location = new System.Drawing.Point(1295, 0);
            this._btSystem_Setting.Name = "_btSystem_Setting";
            this._btSystem_Setting.Size = new System.Drawing.Size(20, 23);
            this._btSystem_Setting.TabIndex = 15;
            this._btSystem_Setting.ToolTip = "설정";
            this._btSystem_Setting.Visible = false;
            this._btSystem_Setting.Click += new System.EventHandler(this._btSystem_Setting_Click);
            // 
            // _btLogout
            // 
            this._btLogout.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btLogout.Appearance.Options.UseBackColor = true;
            this._btLogout.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this._btLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btLogout.ImageOptions.Image")));
            this._btLogout.Location = new System.Drawing.Point(1315, 0);
            this._btLogout.Name = "_btLogout";
            this._btLogout.Size = new System.Drawing.Size(25, 23);
            this._btLogout.TabIndex = 16;
            this._btLogout.ToolTip = "로그아웃";
            this._btLogout.Click += new System.EventHandler(this._btLogout_Click);
            // 
            // _btMin
            // 
            this._btMin.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this._btMin.Appearance.Options.UseFont = true;
            this._btMin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btMin.Dock = System.Windows.Forms.DockStyle.Right;
            this._btMin.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.alignhorizontalbottom_16x161;
            this._btMin.Location = new System.Drawing.Point(1340, 0);
            this._btMin.Margin = new System.Windows.Forms.Padding(0);
            this._btMin.Name = "_btMin";
            this._btMin.Size = new System.Drawing.Size(20, 23);
            this._btMin.TabIndex = 2;
            this._btMin.ToolTip = "최소화";
            this._btMin.Click += new System.EventHandler(this._btMin_Click);
            // 
            // _btMax
            // 
            this._btMax.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this._btMax.Appearance.Options.UseFont = true;
            this._btMax.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btMax.Dock = System.Windows.Forms.DockStyle.Right;
            this._btMax.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.alignhorizontaltop_16x162;
            this._btMax.Location = new System.Drawing.Point(1360, 0);
            this._btMax.Margin = new System.Windows.Forms.Padding(0);
            this._btMax.Name = "_btMax";
            this._btMax.Size = new System.Drawing.Size(20, 23);
            this._btMax.TabIndex = 0;
            this._btMax.ToolTip = "최대화";
            this._btMax.Click += new System.EventHandler(this._btMax_Click);
            // 
            // _btClose
            // 
            this._btClose.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this._btClose.Appearance.Options.UseFont = true;
            this._btClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this._btClose.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.close_16x162;
            this._btClose.Location = new System.Drawing.Point(1380, 0);
            this._btClose.Margin = new System.Windows.Forms.Padding(0);
            this._btClose.Name = "_btClose";
            this._btClose.Size = new System.Drawing.Size(20, 23);
            this._btClose.TabIndex = 1;
            this._btClose.ToolTip = "닫기";
            this._btClose.Click += new System.EventHandler(this._btClose_Click);
            // 
            // _btSETTING
            // 
            this._btSETTING.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._btSETTING.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._btSETTING.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._btSETTING.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this._btSETTING.Appearance.Options.UseBackColor = true;
            this._btSETTING.Appearance.Options.UseBorderColor = true;
            this._btSETTING.Appearance.Options.UseFont = true;
            this._btSETTING.Appearance.Options.UseTextOptions = true;
            this._btSETTING.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this._btSETTING.AppearanceHovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this._btSETTING.AppearanceHovered.Options.UseBackColor = true;
            this._btSETTING.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btSETTING.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btSETTING.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.technology_32x32;
            this._btSETTING.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._btSETTING.Location = new System.Drawing.Point(411, 0);
            this._btSETTING.Margin = new System.Windows.Forms.Padding(0);
            this._btSETTING.Name = "_btSETTING";
            this._btSETTING.Size = new System.Drawing.Size(41, 47);
            this._btSETTING.TabIndex = 8;
            this._btSETTING.Text = "설정";
            this._btSETTING.Visible = false;
            this._btSETTING.Click += new System.EventHandler(this._btSETTING_Click);
            // 
            // _pnButton
            // 
            this._pnButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this._pnButton.Appearance.BackColor2 = System.Drawing.Color.White;
            this._pnButton.Appearance.BorderColor = System.Drawing.Color.White;
            this._pnButton.Appearance.Options.UseBackColor = true;
            this._pnButton.Appearance.Options.UseBorderColor = true;
            this._pnButton.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnButton.Controls.Add(this.tableLayoutPanel3);
            this._pnButton.Controls.Add(this.tableLayoutPanel4);
            this._pnButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnButton.Location = new System.Drawing.Point(0, 23);
            this._pnButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnButton.Name = "_pnButton";
            this._pnButton.Size = new System.Drawing.Size(1400, 70);
            this._pnButton.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this._pnButtonGroup, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this._btHOME, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1200, 70);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // _pnButtonGroup
            // 
            this._pnButtonGroup.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnButtonGroup.Appearance.Options.UseBackColor = true;
            this._pnButtonGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnButtonGroup.Controls.Add(this._btADDITEM);
            this._pnButtonGroup.Controls.Add(this.panelControl4);
            this._pnButtonGroup.Controls.Add(this._btFORMCLOSE);
            this._pnButtonGroup.Controls.Add(this._btINITIAL);
            this._pnButtonGroup.Controls.Add(this._btEXPORT);
            this._pnButtonGroup.Controls.Add(this._btIMPORT);
            this._pnButtonGroup.Controls.Add(this._btSAVE);
            this._pnButtonGroup.Controls.Add(this._btDELETE);
            this._pnButtonGroup.Controls.Add(this._btPRINT);
            this._pnButtonGroup.Controls.Add(this._btSEARCH);
            this._pnButtonGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnButtonGroup.Location = new System.Drawing.Point(130, 0);
            this._pnButtonGroup.Margin = new System.Windows.Forms.Padding(0);
            this._pnButtonGroup.Name = "_pnButtonGroup";
            this._pnButtonGroup.Size = new System.Drawing.Size(1070, 70);
            this._pnButtonGroup.TabIndex = 15;
            // 
            // _btADDITEM
            // 
            this._btADDITEM.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btADDITEM.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._btADDITEM.Appearance.ForeColor = System.Drawing.Color.White;
            this._btADDITEM.Appearance.Options.UseBackColor = true;
            this._btADDITEM.Appearance.Options.UseFont = true;
            this._btADDITEM.Appearance.Options.UseForeColor = true;
            this._btADDITEM.Appearance.Options.UseTextOptions = true;
            this._btADDITEM.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._btADDITEM.AppearanceHovered.BackColor = System.Drawing.Color.LightSkyBlue;
            this._btADDITEM.AppearanceHovered.Options.UseBackColor = true;
            this._btADDITEM.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btADDITEM.Dock = System.Windows.Forms.DockStyle.Left;
            this._btADDITEM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btADDITEM.ImageOptions.Image")));
            this._btADDITEM.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btADDITEM.Location = new System.Drawing.Point(735, 0);
            this._btADDITEM.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._btADDITEM.Name = "_btADDITEM";
            this._btADDITEM.Size = new System.Drawing.Size(105, 70);
            this._btADDITEM.TabIndex = 14;
            this._btADDITEM.Text = "신규추가";
            this._btADDITEM.Click += new System.EventHandler(this._btADDITEM_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.tableLayoutPanel2);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(930, 0);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(35, 70);
            this.panelControl4.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this._pnUser_Info, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Visible = false;
            // 
            // _pnUser_Info
            // 
            this._pnUser_Info.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnUser_Info.Appearance.Image = global::CoFAS_MES.Properties.Resources.None;
            this._pnUser_Info.Appearance.Options.UseBackColor = true;
            this._pnUser_Info.Appearance.Options.UseImage = true;
            this._pnUser_Info.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnUser_Info.Controls.Add(this._ptUser);
            this._pnUser_Info.Controls.Add(this._btUSER_SETTING);
            this._pnUser_Info.Controls.Add(this._btEXIT);
            this._pnUser_Info.Controls.Add(this._btSliding);
            this._pnUser_Info.Location = new System.Drawing.Point(0, 0);
            this._pnUser_Info.Margin = new System.Windows.Forms.Padding(0);
            this._pnUser_Info.Name = "_pnUser_Info";
            this._pnUser_Info.Size = new System.Drawing.Size(140, 47);
            this._pnUser_Info.TabIndex = 3;
            this._pnUser_Info.Visible = false;
            // 
            // _ptUser
            // 
            this._ptUser.Cursor = System.Windows.Forms.Cursors.Default;
            this._ptUser.EditValue = global::CoFAS_MES.Properties.Resources.mapit_32x32;
            this._ptUser.Location = new System.Drawing.Point(0, 14);
            this._ptUser.Margin = new System.Windows.Forms.Padding(0);
            this._ptUser.Name = "_ptUser";
            this._ptUser.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._ptUser.Properties.Appearance.Options.UseBackColor = true;
            this._ptUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._ptUser.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            this._ptUser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this._ptUser.Properties.ShowMenu = false;
            this._ptUser.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this._ptUser.Size = new System.Drawing.Size(20, 20);
            this._ptUser.TabIndex = 0;
            // 
            // _btUSER_SETTING
            // 
            this._btUSER_SETTING.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btUSER_SETTING.Appearance.Options.UseBackColor = true;
            this._btUSER_SETTING.Appearance.Options.UseTextOptions = true;
            this._btUSER_SETTING.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this._btUSER_SETTING.AppearanceHovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this._btUSER_SETTING.AppearanceHovered.Options.UseBackColor = true;
            this._btUSER_SETTING.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btUSER_SETTING.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btUSER_SETTING.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.editcontact_32x32;
            this._btUSER_SETTING.Location = new System.Drawing.Point(60, 0);
            this._btUSER_SETTING.Margin = new System.Windows.Forms.Padding(0);
            this._btUSER_SETTING.Name = "_btUSER_SETTING";
            this._btUSER_SETTING.Size = new System.Drawing.Size(41, 47);
            this._btUSER_SETTING.TabIndex = 1;
            this._btUSER_SETTING.Visible = false;
            this._btUSER_SETTING.Click += new System.EventHandler(this._btUSER_SETTING_Click);
            // 
            // _btEXIT
            // 
            this._btEXIT.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btEXIT.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this._btEXIT.Appearance.ForeColor = System.Drawing.Color.White;
            this._btEXIT.Appearance.Options.UseBackColor = true;
            this._btEXIT.Appearance.Options.UseFont = true;
            this._btEXIT.Appearance.Options.UseForeColor = true;
            this._btEXIT.Appearance.Options.UseTextOptions = true;
            this._btEXIT.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this._btEXIT.AppearanceHovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this._btEXIT.AppearanceHovered.Options.UseBackColor = true;
            this._btEXIT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btEXIT.Dock = System.Windows.Forms.DockStyle.Right;
            this._btEXIT.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.cancel_32x32;
            this._btEXIT.Location = new System.Drawing.Point(101, 0);
            this._btEXIT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btEXIT.Name = "_btEXIT";
            this._btEXIT.Size = new System.Drawing.Size(39, 47);
            this._btEXIT.TabIndex = 0;
            this._btEXIT.Visible = false;
            this._btEXIT.Click += new System.EventHandler(this._btEXIT_Click);
            // 
            // _btSliding
            // 
            this._btSliding.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btSliding.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this._btSliding.Appearance.Options.UseBackColor = true;
            this._btSliding.Appearance.Options.UseFont = true;
            this._btSliding.AppearanceHovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this._btSliding.AppearanceHovered.Options.UseBackColor = true;
            this._btSliding.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btSliding.Dock = System.Windows.Forms.DockStyle.Left;
            this._btSliding.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.contentarrangeinrows_32x32;
            this._btSliding.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._btSliding.Location = new System.Drawing.Point(0, 0);
            this._btSliding.Margin = new System.Windows.Forms.Padding(0);
            this._btSliding.Name = "_btSliding";
            this._btSliding.Size = new System.Drawing.Size(60, 47);
            this._btSliding.TabIndex = 0;
            this._btSliding.Visible = false;
            this._btSliding.Click += new System.EventHandler(this._btSliding_Click);
            // 
            // _btFORMCLOSE
            // 
            this._btFORMCLOSE.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btFORMCLOSE.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._btFORMCLOSE.Appearance.ForeColor = System.Drawing.Color.White;
            this._btFORMCLOSE.Appearance.Options.UseBackColor = true;
            this._btFORMCLOSE.Appearance.Options.UseFont = true;
            this._btFORMCLOSE.Appearance.Options.UseForeColor = true;
            this._btFORMCLOSE.Appearance.Options.UseTextOptions = true;
            this._btFORMCLOSE.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._btFORMCLOSE.AppearanceHovered.BackColor = System.Drawing.Color.LightSkyBlue;
            this._btFORMCLOSE.AppearanceHovered.Options.UseBackColor = true;
            this._btFORMCLOSE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btFORMCLOSE.Dock = System.Windows.Forms.DockStyle.Right;
            this._btFORMCLOSE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btFORMCLOSE.ImageOptions.Image")));
            this._btFORMCLOSE.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btFORMCLOSE.Location = new System.Drawing.Point(965, 0);
            this._btFORMCLOSE.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this._btFORMCLOSE.Name = "_btFORMCLOSE";
            this._btFORMCLOSE.Size = new System.Drawing.Size(105, 70);
            this._btFORMCLOSE.TabIndex = 13;
            this._btFORMCLOSE.Text = "닫기";
            this._btFORMCLOSE.Click += new System.EventHandler(this._btFORMCLOSE_Click);
            // 
            // _btINITIAL
            // 
            this._btINITIAL.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btINITIAL.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._btINITIAL.Appearance.ForeColor = System.Drawing.Color.White;
            this._btINITIAL.Appearance.Options.UseBackColor = true;
            this._btINITIAL.Appearance.Options.UseFont = true;
            this._btINITIAL.Appearance.Options.UseForeColor = true;
            this._btINITIAL.Appearance.Options.UseTextOptions = true;
            this._btINITIAL.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._btINITIAL.AppearanceHovered.BackColor = System.Drawing.Color.LightSkyBlue;
            this._btINITIAL.AppearanceHovered.Options.UseBackColor = true;
            this._btINITIAL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btINITIAL.Dock = System.Windows.Forms.DockStyle.Left;
            this._btINITIAL.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.refresh_32x32;
            this._btINITIAL.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btINITIAL.Location = new System.Drawing.Point(630, 0);
            this._btINITIAL.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._btINITIAL.Name = "_btINITIAL";
            this._btINITIAL.Size = new System.Drawing.Size(105, 70);
            this._btINITIAL.TabIndex = 12;
            this._btINITIAL.Text = "초기화";
            this._btINITIAL.Click += new System.EventHandler(this._btINITIAL_Click);
            // 
            // _btEXPORT
            // 
            this._btEXPORT.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btEXPORT.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._btEXPORT.Appearance.ForeColor = System.Drawing.Color.White;
            this._btEXPORT.Appearance.Options.UseBackColor = true;
            this._btEXPORT.Appearance.Options.UseFont = true;
            this._btEXPORT.Appearance.Options.UseForeColor = true;
            this._btEXPORT.Appearance.Options.UseTextOptions = true;
            this._btEXPORT.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._btEXPORT.AppearanceHovered.BackColor = System.Drawing.Color.LightSkyBlue;
            this._btEXPORT.AppearanceHovered.Options.UseBackColor = true;
            this._btEXPORT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btEXPORT.Dock = System.Windows.Forms.DockStyle.Left;
            this._btEXPORT.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.exportfile_32x32;
            this._btEXPORT.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btEXPORT.Location = new System.Drawing.Point(525, 0);
            this._btEXPORT.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._btEXPORT.Name = "_btEXPORT";
            this._btEXPORT.Size = new System.Drawing.Size(105, 70);
            this._btEXPORT.TabIndex = 9;
            this._btEXPORT.Text = "내보내기";
            this._btEXPORT.Click += new System.EventHandler(this._btEXPORT_Click);
            // 
            // _btIMPORT
            // 
            this._btIMPORT.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btIMPORT.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._btIMPORT.Appearance.ForeColor = System.Drawing.Color.White;
            this._btIMPORT.Appearance.Options.UseBackColor = true;
            this._btIMPORT.Appearance.Options.UseFont = true;
            this._btIMPORT.Appearance.Options.UseForeColor = true;
            this._btIMPORT.Appearance.Options.UseTextOptions = true;
            this._btIMPORT.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._btIMPORT.AppearanceHovered.BackColor = System.Drawing.Color.LightSkyBlue;
            this._btIMPORT.AppearanceHovered.Options.UseBackColor = true;
            this._btIMPORT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btIMPORT.Dock = System.Windows.Forms.DockStyle.Left;
            this._btIMPORT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btIMPORT.ImageOptions.Image")));
            this._btIMPORT.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btIMPORT.Location = new System.Drawing.Point(420, 0);
            this._btIMPORT.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._btIMPORT.Name = "_btIMPORT";
            this._btIMPORT.Size = new System.Drawing.Size(105, 70);
            this._btIMPORT.TabIndex = 10;
            this._btIMPORT.Text = "가져오기";
            this._btIMPORT.Click += new System.EventHandler(this._btIMPORT_Click);
            // 
            // _btSAVE
            // 
            this._btSAVE.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btSAVE.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._btSAVE.Appearance.ForeColor = System.Drawing.Color.White;
            this._btSAVE.Appearance.Options.UseBackColor = true;
            this._btSAVE.Appearance.Options.UseFont = true;
            this._btSAVE.Appearance.Options.UseForeColor = true;
            this._btSAVE.Appearance.Options.UseTextOptions = true;
            this._btSAVE.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._btSAVE.AppearanceHovered.BackColor = System.Drawing.Color.LightSkyBlue;
            this._btSAVE.AppearanceHovered.Options.UseBackColor = true;
            this._btSAVE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btSAVE.Dock = System.Windows.Forms.DockStyle.Left;
            this._btSAVE.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.save_32x322;
            this._btSAVE.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btSAVE.Location = new System.Drawing.Point(315, 0);
            this._btSAVE.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._btSAVE.Name = "_btSAVE";
            this._btSAVE.Size = new System.Drawing.Size(105, 70);
            this._btSAVE.TabIndex = 5;
            this._btSAVE.Text = "저장";
            this._btSAVE.Click += new System.EventHandler(this._btSAVE_Click);
            // 
            // _btDELETE
            // 
            this._btDELETE.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btDELETE.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._btDELETE.Appearance.ForeColor = System.Drawing.Color.White;
            this._btDELETE.Appearance.Options.UseBackColor = true;
            this._btDELETE.Appearance.Options.UseFont = true;
            this._btDELETE.Appearance.Options.UseForeColor = true;
            this._btDELETE.Appearance.Options.UseTextOptions = true;
            this._btDELETE.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._btDELETE.AppearanceHovered.BackColor = System.Drawing.Color.LightSkyBlue;
            this._btDELETE.AppearanceHovered.Options.UseBackColor = true;
            this._btDELETE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btDELETE.Dock = System.Windows.Forms.DockStyle.Left;
            this._btDELETE.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.deletelist2_32x32;
            this._btDELETE.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btDELETE.Location = new System.Drawing.Point(210, 0);
            this._btDELETE.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._btDELETE.Name = "_btDELETE";
            this._btDELETE.Size = new System.Drawing.Size(105, 70);
            this._btDELETE.TabIndex = 6;
            this._btDELETE.Text = "삭제";
            this._btDELETE.Click += new System.EventHandler(this._btDELETE_Click);
            // 
            // _btPRINT
            // 
            this._btPRINT.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btPRINT.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._btPRINT.Appearance.ForeColor = System.Drawing.Color.White;
            this._btPRINT.Appearance.Options.UseBackColor = true;
            this._btPRINT.Appearance.Options.UseFont = true;
            this._btPRINT.Appearance.Options.UseForeColor = true;
            this._btPRINT.Appearance.Options.UseTextOptions = true;
            this._btPRINT.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._btPRINT.AppearanceHovered.BackColor = System.Drawing.Color.LightSkyBlue;
            this._btPRINT.AppearanceHovered.Options.UseBackColor = true;
            this._btPRINT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btPRINT.Dock = System.Windows.Forms.DockStyle.Left;
            this._btPRINT.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.print_32x32;
            this._btPRINT.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btPRINT.Location = new System.Drawing.Point(105, 0);
            this._btPRINT.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._btPRINT.Name = "_btPRINT";
            this._btPRINT.Size = new System.Drawing.Size(105, 70);
            this._btPRINT.TabIndex = 11;
            this._btPRINT.Text = "인쇄";
            this._btPRINT.Click += new System.EventHandler(this._btPRINT_Click);
            // 
            // _btSEARCH
            // 
            this._btSEARCH.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btSEARCH.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._btSEARCH.Appearance.ForeColor = System.Drawing.Color.White;
            this._btSEARCH.Appearance.Options.UseBackColor = true;
            this._btSEARCH.Appearance.Options.UseFont = true;
            this._btSEARCH.Appearance.Options.UseForeColor = true;
            this._btSEARCH.Appearance.Options.UseTextOptions = true;
            this._btSEARCH.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._btSEARCH.AppearanceHovered.BackColor = System.Drawing.Color.LightSkyBlue;
            this._btSEARCH.AppearanceHovered.Options.UseBackColor = true;
            this._btSEARCH.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btSEARCH.Dock = System.Windows.Forms.DockStyle.Left;
            this._btSEARCH.ImageOptions.Image = global::CoFAS_MES.Properties.Resources._35x_1403084972_search;
            this._btSEARCH.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btSEARCH.Location = new System.Drawing.Point(0, 0);
            this._btSEARCH.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._btSEARCH.Name = "_btSEARCH";
            this._btSEARCH.Size = new System.Drawing.Size(105, 70);
            this._btSEARCH.TabIndex = 4;
            this._btSEARCH.Text = "조회";
            this._btSEARCH.Click += new System.EventHandler(this._btSEARCH_Click);
            // 
            // _btHOME
            // 
            this._btHOME.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btHOME.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._btHOME.Appearance.ForeColor = System.Drawing.Color.White;
            this._btHOME.Appearance.Options.UseBackColor = true;
            this._btHOME.Appearance.Options.UseFont = true;
            this._btHOME.Appearance.Options.UseForeColor = true;
            this._btHOME.Appearance.Options.UseTextOptions = true;
            this._btHOME.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._btHOME.AppearanceHovered.BackColor = System.Drawing.Color.LightSkyBlue;
            this._btHOME.AppearanceHovered.Options.UseBackColor = true;
            this._btHOME.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btHOME.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btHOME.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btHOME.ImageOptions.Image")));
            this._btHOME.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this._btHOME.Location = new System.Drawing.Point(10, 0);
            this._btHOME.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._btHOME.Name = "_btHOME";
            this._btHOME.Size = new System.Drawing.Size(110, 70);
            this._btHOME.TabIndex = 1;
            this._btHOME.Text = "Home";
            this._btHOME.Click += new System.EventHandler(this._btHOME_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel4.Controls.Add(this._ptCI, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 70);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // _ptCI
            // 
            this._ptCI.Cursor = System.Windows.Forms.Cursors.Default;
            this._ptCI.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ptCI.EditValue = global::CoFAS_MES.Properties.Resources.Coever;
            this._ptCI.Location = new System.Drawing.Point(0, 0);
            this._ptCI.Margin = new System.Windows.Forms.Padding(0);
            this._ptCI.Name = "_ptCI";
            this._ptCI.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._ptCI.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this._ptCI.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this._ptCI.Properties.Appearance.Options.UseBackColor = true;
            this._ptCI.Properties.Appearance.Options.UseBorderColor = true;
            this._ptCI.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._ptCI.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this._ptCI.Properties.ReadOnly = true;
            this._ptCI.Properties.ShowMenu = false;
            this._ptCI.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this._ptCI.Size = new System.Drawing.Size(200, 70);
            this._ptCI.TabIndex = 0;
            // 
            // _lbUserName
            // 
            this._lbUserName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._lbUserName.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._lbUserName.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._lbUserName.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._lbUserName.Appearance.ForeColor = System.Drawing.Color.White;
            this._lbUserName.Appearance.Image = global::CoFAS_MES.Properties.Resources.mapit_32x32;
            this._lbUserName.Appearance.Options.UseBackColor = true;
            this._lbUserName.Appearance.Options.UseBorderColor = true;
            this._lbUserName.Appearance.Options.UseFont = true;
            this._lbUserName.Appearance.Options.UseForeColor = true;
            this._lbUserName.Appearance.Options.UseImage = true;
            this._lbUserName.Appearance.Options.UseTextOptions = true;
            this._lbUserName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this._lbUserName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbUserName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._lbUserName.Location = new System.Drawing.Point(201, 0);
            this._lbUserName.Margin = new System.Windows.Forms.Padding(0);
            this._lbUserName.Name = "_lbUserName";
            this._lbUserName.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this._lbUserName.Size = new System.Drawing.Size(210, 47);
            this._lbUserName.TabIndex = 1;
            this._lbUserName.Text = "User Name";
            // 
            // _acdMenuControl
            // 
            this._acdMenuControl.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Simple;
            this._acdMenuControl.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._acdMenuControl.Appearance.AccordionControl.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._acdMenuControl.Appearance.AccordionControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._acdMenuControl.Appearance.AccordionControl.Options.UseBackColor = true;
            this._acdMenuControl.Appearance.AccordionControl.Options.UseBorderColor = true;
            this._acdMenuControl.Dock = System.Windows.Forms.DockStyle.Left;
            this._acdMenuControl.Location = new System.Drawing.Point(0, 93);
            this._acdMenuControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._acdMenuControl.Name = "_acdMenuControl";
            this._acdMenuControl.OptionsMinimizing.AllowMinimizing = true;
            this._acdMenuControl.OptionsMinimizing.NormalWidth = 200;
            this._acdMenuControl.ScaleImages = DevExpress.Utils.DefaultBoolean.False;
            this._acdMenuControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this._acdMenuControl.ShowGroupExpandButtons = false;
            this._acdMenuControl.ShowItemExpandButtons = false;
            this._acdMenuControl.Size = new System.Drawing.Size(200, 763);
            this._acdMenuControl.TabIndex = 2;
            this._acdMenuControl.Text = "accordionControl1";
            this._acdMenuControl.SizeChanged += new System.EventHandler(this._acdMenuControl_SizeChanged);
            // 
            // xtraTabMdiControl
            // 
            this.xtraTabMdiControl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.xtraTabMdiControl.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.xtraTabMdiControl.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.xtraTabMdiControl.Appearance.Options.UseBackColor = true;
            this.xtraTabMdiControl.Appearance.Options.UseBorderColor = true;
            this.xtraTabMdiControl.AppearancePage.PageClient.BackColor = System.Drawing.Color.White;
            this.xtraTabMdiControl.AppearancePage.PageClient.Options.UseBackColor = true;
            this.xtraTabMdiControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabMdiControl.MdiParent = this;
            this.xtraTabMdiControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.xtraTabMdiControl_MouseUp);
            this.xtraTabMdiControl.PageAdded += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabMdiControl_PageAdded);
            this.xtraTabMdiControl.PageRemoved += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabMdiControl_PageRemoved);
            // 
            // _pnMain
            // 
            this._pnMain.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._pnMain.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._pnMain.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._pnMain.Appearance.Options.UseBackColor = true;
            this._pnMain.Appearance.Options.UseBorderColor = true;
            this._pnMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnMain.Controls.Add(this._btSet);
            this._pnMain.Controls.Add(this.panelControl10);
            this._pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnMain.Location = new System.Drawing.Point(200, 93);
            this._pnMain.Margin = new System.Windows.Forms.Padding(0);
            this._pnMain.Name = "_pnMain";
            this._pnMain.Size = new System.Drawing.Size(1200, 716);
            this._pnMain.TabIndex = 4;
            // 
            // _btSet
            // 
            this._btSet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._btSet.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._btSet.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._btSet.Appearance.Options.UseBackColor = true;
            this._btSet.Appearance.Options.UseBorderColor = true;
            this._btSet.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btSet.Location = new System.Drawing.Point(0, 20);
            this._btSet.Margin = new System.Windows.Forms.Padding(0);
            this._btSet.Name = "_btSet";
            this._btSet.Size = new System.Drawing.Size(1200, 696);
            this._btSet.TabIndex = 1;
            // 
            // panelControl10
            // 
            this.panelControl10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.panelControl10.Appearance.Options.UseBackColor = true;
            this.panelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl10.Controls.Add(this._btHomeRefresh);
            this.panelControl10.Controls.Add(this.labelControl1);
            this.panelControl10.Controls.Add(this._btHomeMaxSize);
            this.panelControl10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl10.Location = new System.Drawing.Point(0, 0);
            this.panelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(1200, 20);
            this.panelControl10.TabIndex = 0;
            // 
            // _btHomeRefresh
            // 
            this._btHomeRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btHomeRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this._btHomeRefresh.ImageOptions.Image = global::CoFAS_MES.Properties.Resources.refresh_16x16;
            this._btHomeRefresh.Location = new System.Drawing.Point(1160, 0);
            this._btHomeRefresh.Name = "_btHomeRefresh";
            this._btHomeRefresh.Size = new System.Drawing.Size(20, 20);
            this._btHomeRefresh.TabIndex = 2;
            this._btHomeRefresh.Visible = false;
            this._btHomeRefresh.Click += new System.EventHandler(this._btHomeRefresh_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1180, 20);
            this.labelControl1.TabIndex = 0;
            // 
            // _btHomeMaxSize
            // 
            this._btHomeMaxSize.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._btHomeMaxSize.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._btHomeMaxSize.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this._btHomeMaxSize.Appearance.Options.UseBackColor = true;
            this._btHomeMaxSize.Appearance.Options.UseForeColor = true;
            this._btHomeMaxSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._btHomeMaxSize.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btHomeMaxSize.Dock = System.Windows.Forms.DockStyle.Right;
            this._btHomeMaxSize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btHomeMaxSize.ImageOptions.Image")));
            this._btHomeMaxSize.Location = new System.Drawing.Point(1180, 0);
            this._btHomeMaxSize.Margin = new System.Windows.Forms.Padding(0);
            this._btHomeMaxSize.Name = "_btHomeMaxSize";
            this._btHomeMaxSize.Size = new System.Drawing.Size(20, 20);
            this._btHomeMaxSize.TabIndex = 1;
            this._btHomeMaxSize.Click += new System.EventHandler(this._btHomeMaxSize_Click);
            // 
            // _lbMessage
            // 
            this._lbMessage.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._lbMessage.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._lbMessage.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._lbMessage.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._lbMessage.Appearance.ForeColor = System.Drawing.Color.White;
            this._lbMessage.Appearance.Image = global::CoFAS_MES.Properties.Resources.pielabelstooltips_16x16;
            this._lbMessage.Appearance.Options.UseBackColor = true;
            this._lbMessage.Appearance.Options.UseBorderColor = true;
            this._lbMessage.Appearance.Options.UseFont = true;
            this._lbMessage.Appearance.Options.UseForeColor = true;
            this._lbMessage.Appearance.Options.UseImage = true;
            this._lbMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbMessage.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbMessage.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._lbMessage.Location = new System.Drawing.Point(0, 0);
            this._lbMessage.Margin = new System.Windows.Forms.Padding(0);
            this._lbMessage.Name = "_lbMessage";
            this._lbMessage.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this._lbMessage.Size = new System.Drawing.Size(748, 47);
            this._lbMessage.TabIndex = 0;
            this._lbMessage.Text = "Message";
            // 
            // _pnBottom
            // 
            this._pnBottom.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._pnBottom.Appearance.Options.UseBackColor = true;
            this._pnBottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnBottom.Controls.Add(this._lbMessage);
            this._pnBottom.Controls.Add(this.tableLayoutPanel1);
            this._pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._pnBottom.Location = new System.Drawing.Point(200, 809);
            this._pnBottom.Margin = new System.Windows.Forms.Padding(0);
            this._pnBottom.Name = "_pnBottom";
            this._pnBottom.Size = new System.Drawing.Size(1200, 47);
            this._pnBottom.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Controls.Add(this._lbUserName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._btSETTING, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this._lbScreenID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._lbScreenName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(748, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 47);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // _lbScreenID
            // 
            this._lbScreenID.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this._lbScreenID.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this._lbScreenID.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this._lbScreenID.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._lbScreenID.Appearance.ForeColor = System.Drawing.Color.Black;
            this._lbScreenID.Appearance.Image = global::CoFAS_MES.Properties.Resources.suggestion_16x161;
            this._lbScreenID.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lbScreenID.Appearance.Options.UseBackColor = true;
            this._lbScreenID.Appearance.Options.UseBorderColor = true;
            this._lbScreenID.Appearance.Options.UseFont = true;
            this._lbScreenID.Appearance.Options.UseForeColor = true;
            this._lbScreenID.Appearance.Options.UseImage = true;
            this._lbScreenID.Appearance.Options.UseImageAlign = true;
            this._lbScreenID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbScreenID.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbScreenID.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._lbScreenID.Location = new System.Drawing.Point(0, 0);
            this._lbScreenID.Margin = new System.Windows.Forms.Padding(0);
            this._lbScreenID.Name = "_lbScreenID";
            this._lbScreenID.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this._lbScreenID.Size = new System.Drawing.Size(1, 47);
            this._lbScreenID.TabIndex = 0;
            this._lbScreenID.Text = "화면 아이디";
            // 
            // _lbScreenName
            // 
            this._lbScreenName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._lbScreenName.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._lbScreenName.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this._lbScreenName.Appearance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this._lbScreenName.Appearance.ForeColor = System.Drawing.Color.White;
            this._lbScreenName.Appearance.Image = global::CoFAS_MES.Properties.Resources.example_16x161;
            this._lbScreenName.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lbScreenName.Appearance.Options.UseBackColor = true;
            this._lbScreenName.Appearance.Options.UseBorderColor = true;
            this._lbScreenName.Appearance.Options.UseFont = true;
            this._lbScreenName.Appearance.Options.UseForeColor = true;
            this._lbScreenName.Appearance.Options.UseImage = true;
            this._lbScreenName.Appearance.Options.UseImageAlign = true;
            this._lbScreenName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbScreenName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbScreenName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._lbScreenName.Location = new System.Drawing.Point(1, 0);
            this._lbScreenName.Margin = new System.Windows.Forms.Padding(0);
            this._lbScreenName.Name = "_lbScreenName";
            this._lbScreenName.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this._lbScreenName.Size = new System.Drawing.Size(200, 47);
            this._lbScreenName.TabIndex = 1;
            this._lbScreenName.Text = "화면 명칭";
            this._lbScreenName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this._lbScreenName.ToolTipTitle = "view";
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 856);
            this.Controls.Add(this._pnMain);
            this.Controls.Add(this._pnBottom);
            this.Controls.Add(this._acdMenuControl);
            this.Controls.Add(this._pnButton);
            this.Controls.Add(this._pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "System Name";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this._pnTop)).EndInit();
            this._pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnButton)).EndInit();
            this._pnButton.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnButtonGroup)).EndInit();
            this._pnButtonGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnUser_Info)).EndInit();
            this._pnUser_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ptUser.Properties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ptCI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._acdMenuControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabMdiControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnMain)).EndInit();
            this._pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._btSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnBottom)).EndInit();
            this._pnBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl _pnTop;
        private DevExpress.XtraEditors.PanelControl _pnButton;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabMdiControl;
        private DevExpress.XtraEditors.PanelControl _pnMain;
        private DevExpress.XtraEditors.SimpleButton _btMin;
        private DevExpress.XtraEditors.SimpleButton _btMax;
        private DevExpress.XtraEditors.SimpleButton _btClose;
        private DevExpress.XtraEditors.LabelControl _lbMAIN_HEADER;
        private DevExpress.XtraEditors.SimpleButton _btSliding;
        private DevExpress.XtraEditors.SimpleButton _btHOME;
        private DevExpress.XtraEditors.SimpleButton _btSETTING;
        private DevExpress.XtraEditors.SimpleButton _btFORMCLOSE;
        private DevExpress.XtraEditors.PictureEdit _ptCI;
        private DevExpress.XtraEditors.PanelControl _pnBottom;
        private DevExpress.XtraEditors.LabelControl _lbMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl _lbScreenID;
        private DevExpress.XtraEditors.LabelControl _lbScreenName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.PictureEdit _ptUser;
        private DevExpress.XtraEditors.LabelControl _lbUserName;
        private DevExpress.XtraBars.Navigation.AccordionControl _acdMenuControl;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton _btHomeMaxSize;
        private DevExpress.XtraEditors.SimpleButton _btSEARCH;
        private DevExpress.XtraEditors.SimpleButton _btSAVE;
        private DevExpress.XtraEditors.SimpleButton _btDELETE;
        private DevExpress.XtraEditors.SimpleButton _btEXPORT;
        private DevExpress.XtraEditors.SimpleButton _btIMPORT;
        private DevExpress.XtraEditors.SimpleButton _btPRINT;
        private DevExpress.XtraEditors.SimpleButton _btINITIAL;
        private DevExpress.XtraEditors.PanelControl _pnUser_Info;
        private DevExpress.XtraEditors.SimpleButton _btEXIT;
        private DevExpress.XtraEditors.SimpleButton _btUSER_SETTING;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl _btSet;
        private DevExpress.XtraEditors.PanelControl _pnButtonGroup;
        private DevExpress.XtraEditors.SimpleButton _btADDITEM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton _btHomeRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.SimpleButton _btSystem_Setting;
        private DevExpress.XtraEditors.SimpleButton _btLogout;
    }
}

