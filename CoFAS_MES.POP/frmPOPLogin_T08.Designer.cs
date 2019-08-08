namespace CoFAS_MES.POP
{
    partial class frmPOPLogin_T08
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this._lbLoginHeader = new DevExpress.XtraEditors.LabelControl();
            this._btLoginClose = new DevExpress.XtraEditors.SimpleButton();
            this._btLoginSetting = new DevExpress.XtraEditors.SimpleButton();
            this._btLoginOk = new DevExpress.XtraEditors.SimpleButton();
            this._btLoginCancel = new DevExpress.XtraEditors.SimpleButton();
            this._pnLoginMain = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._ckUserIDSave = new DevExpress.XtraEditors.CheckEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCmd30 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd01 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd02 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd03 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd04 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd05 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd06 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd07 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd08 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd09 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd60 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd00 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd70 = new DevExpress.XtraEditors.SimpleButton();
            this._luT_DISPLAY_LIST = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._ucIMG_LOGIN_LOGO = new CoFAS_MES.CORE.BaseControls.ucPictureEdit();
            this._luT_TERMINAL_LIST = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._txtPassword = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luT_PROCESS_LIST = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._txtAccount = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLoginMain)).BeginInit();
            this._pnLoginMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ckUserIDSave.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this._lbLoginHeader);
            this.panelControl1.Controls.Add(this._btLoginClose);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(635, 20);
            this.panelControl1.TabIndex = 0;
            // 
            // _lbLoginHeader
            // 
            this._lbLoginHeader.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._lbLoginHeader.Appearance.ForeColor = System.Drawing.Color.White;
            this._lbLoginHeader.Appearance.Image = global::CoFAS_MES.POP.Properties.Resources.folderpanel_16x16;
            this._lbLoginHeader.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lbLoginHeader.Appearance.Options.UseFont = true;
            this._lbLoginHeader.Appearance.Options.UseForeColor = true;
            this._lbLoginHeader.Appearance.Options.UseImage = true;
            this._lbLoginHeader.Appearance.Options.UseImageAlign = true;
            this._lbLoginHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this._lbLoginHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbLoginHeader.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._lbLoginHeader.Location = new System.Drawing.Point(0, 0);
            this._lbLoginHeader.Margin = new System.Windows.Forms.Padding(0);
            this._lbLoginHeader.Name = "_lbLoginHeader";
            this._lbLoginHeader.Padding = new System.Windows.Forms.Padding(10);
            this._lbLoginHeader.Size = new System.Drawing.Size(615, 20);
            this._lbLoginHeader.TabIndex = 1;
            this._lbLoginHeader.Text = "System Login";
            this._lbLoginHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Moving);
            // 
            // _btLoginClose
            // 
            this._btLoginClose.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._btLoginClose.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this._btLoginClose.Appearance.ForeColor = System.Drawing.Color.White;
            this._btLoginClose.Appearance.Options.UseBackColor = true;
            this._btLoginClose.Appearance.Options.UseFont = true;
            this._btLoginClose.Appearance.Options.UseForeColor = true;
            this._btLoginClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btLoginClose.Dock = System.Windows.Forms.DockStyle.Right;
            this._btLoginClose.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.close_16x162;
            this._btLoginClose.Location = new System.Drawing.Point(615, 0);
            this._btLoginClose.Margin = new System.Windows.Forms.Padding(0);
            this._btLoginClose.Name = "_btLoginClose";
            this._btLoginClose.Size = new System.Drawing.Size(20, 20);
            this._btLoginClose.TabIndex = 0;
            this._btLoginClose.Click += new System.EventHandler(this._btLoginClose_Click);
            // 
            // _btLoginSetting
            // 
            this._btLoginSetting.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btLoginSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btLoginSetting.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.technology_32x321;
            this._btLoginSetting.Location = new System.Drawing.Point(321, 350);
            this._btLoginSetting.Name = "_btLoginSetting";
            this._btLoginSetting.Size = new System.Drawing.Size(99, 53);
            this._btLoginSetting.TabIndex = 9;
            this._btLoginSetting.Click += new System.EventHandler(this._btLoginSetting_Click);
            // 
            // _btLoginOk
            // 
            this._btLoginOk.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._btLoginOk.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btLoginOk.Appearance.Options.UseFont = true;
            this._btLoginOk.Appearance.Options.UseForeColor = true;
            this._btLoginOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btLoginOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btLoginOk.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.apply_32x321;
            this._btLoginOk.Location = new System.Drawing.Point(426, 350);
            this._btLoginOk.Name = "_btLoginOk";
            this._btLoginOk.Size = new System.Drawing.Size(99, 53);
            this._btLoginOk.TabIndex = 2;
            this._btLoginOk.Text = "로그인";
            this._btLoginOk.Click += new System.EventHandler(this._btLoginOk_Click);
            // 
            // _btLoginCancel
            // 
            this._btLoginCancel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._btLoginCancel.Appearance.ForeColor = System.Drawing.Color.Black;
            this._btLoginCancel.Appearance.Options.UseFont = true;
            this._btLoginCancel.Appearance.Options.UseForeColor = true;
            this._btLoginCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._btLoginCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btLoginCancel.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.close_32x321;
            this._btLoginCancel.Location = new System.Drawing.Point(531, 350);
            this._btLoginCancel.Name = "_btLoginCancel";
            this._btLoginCancel.Size = new System.Drawing.Size(101, 53);
            this._btLoginCancel.TabIndex = 1;
            this._btLoginCancel.Text = "닫기";
            this._btLoginCancel.Click += new System.EventHandler(this._btLoginCancel_Click);
            // 
            // _pnLoginMain
            // 
            this._pnLoginMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pnLoginMain.Controls.Add(this.layoutControl1);
            this._pnLoginMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnLoginMain.Location = new System.Drawing.Point(0, 20);
            this._pnLoginMain.Margin = new System.Windows.Forms.Padding(0);
            this._pnLoginMain.Name = "_pnLoginMain";
            this._pnLoginMain.Size = new System.Drawing.Size(635, 406);
            this._pnLoginMain.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.White;
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1062, 512, 812, 500);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(635, 406);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.BackgroundImageOptions.Visible = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(635, 406);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // _ckUserIDSave
            // 
            this._ckUserIDSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ckUserIDSave.EditValue = "Y";
            this._ckUserIDSave.Location = new System.Drawing.Point(528, 0);
            this._ckUserIDSave.Margin = new System.Windows.Forms.Padding(0);
            this._ckUserIDSave.Name = "_ckUserIDSave";
            this._ckUserIDSave.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this._ckUserIDSave.Properties.Appearance.Options.UseFont = true;
            this._ckUserIDSave.Properties.Caption = "아이디 저장";
            this._ckUserIDSave.Properties.ValueChecked = "Y";
            this._ckUserIDSave.Properties.ValueUnchecked = "N";
            this._ckUserIDSave.Size = new System.Drawing.Size(107, 57);
            this._ckUserIDSave.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.12563F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.12563F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58291F));
            this.tableLayoutPanel1.Controls.Add(this._luT_DISPLAY_LIST, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this._ucIMG_LOGIN_LOGO, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._luT_TERMINAL_LIST, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._txtPassword, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this._luT_PROCESS_LIST, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._txtAccount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._ckUserIDSave, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd30, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd01, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd02, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd03, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd04, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd05, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd06, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd07, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd08, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd09, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd60, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd00, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd70, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this._btLoginOk, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this._btLoginCancel, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this._btLoginSetting, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 406);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnCmd30
            // 
            this.btnCmd30.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd30.Appearance.Options.UseFont = true;
            this.btnCmd30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd30.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources._48x_back;
            this.btnCmd30.Location = new System.Drawing.Point(531, 60);
            this.btnCmd30.Name = "btnCmd30";
            this.btnCmd30.Size = new System.Drawing.Size(101, 52);
            this.btnCmd30.TabIndex = 8;
            this.btnCmd30.Text = "BS";
            this.btnCmd30.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd01
            // 
            this.btnCmd01.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd01.Appearance.Options.UseFont = true;
            this.btnCmd01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd01.Location = new System.Drawing.Point(321, 118);
            this.btnCmd01.Name = "btnCmd01";
            this.btnCmd01.Size = new System.Drawing.Size(99, 52);
            this.btnCmd01.TabIndex = 9;
            this.btnCmd01.Text = "1";
            this.btnCmd01.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd02
            // 
            this.btnCmd02.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd02.Appearance.Options.UseFont = true;
            this.btnCmd02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd02.Location = new System.Drawing.Point(426, 118);
            this.btnCmd02.Name = "btnCmd02";
            this.btnCmd02.Size = new System.Drawing.Size(99, 52);
            this.btnCmd02.TabIndex = 10;
            this.btnCmd02.Text = "2";
            this.btnCmd02.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd03
            // 
            this.btnCmd03.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd03.Appearance.Options.UseFont = true;
            this.btnCmd03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd03.Location = new System.Drawing.Point(531, 118);
            this.btnCmd03.Name = "btnCmd03";
            this.btnCmd03.Size = new System.Drawing.Size(101, 52);
            this.btnCmd03.TabIndex = 11;
            this.btnCmd03.Text = "3";
            this.btnCmd03.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd04
            // 
            this.btnCmd04.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd04.Appearance.Options.UseFont = true;
            this.btnCmd04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd04.Location = new System.Drawing.Point(321, 176);
            this.btnCmd04.Name = "btnCmd04";
            this.btnCmd04.Size = new System.Drawing.Size(99, 52);
            this.btnCmd04.TabIndex = 12;
            this.btnCmd04.Text = "4";
            this.btnCmd04.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd05
            // 
            this.btnCmd05.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd05.Appearance.Options.UseFont = true;
            this.btnCmd05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd05.Location = new System.Drawing.Point(426, 176);
            this.btnCmd05.Name = "btnCmd05";
            this.btnCmd05.Size = new System.Drawing.Size(99, 52);
            this.btnCmd05.TabIndex = 13;
            this.btnCmd05.Text = "5";
            this.btnCmd05.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd06
            // 
            this.btnCmd06.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd06.Appearance.Options.UseFont = true;
            this.btnCmd06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd06.Location = new System.Drawing.Point(531, 176);
            this.btnCmd06.Name = "btnCmd06";
            this.btnCmd06.Size = new System.Drawing.Size(101, 52);
            this.btnCmd06.TabIndex = 14;
            this.btnCmd06.Text = "6";
            this.btnCmd06.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd07
            // 
            this.btnCmd07.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd07.Appearance.Options.UseFont = true;
            this.btnCmd07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd07.Location = new System.Drawing.Point(321, 234);
            this.btnCmd07.Name = "btnCmd07";
            this.btnCmd07.Size = new System.Drawing.Size(99, 52);
            this.btnCmd07.TabIndex = 15;
            this.btnCmd07.Text = "7";
            this.btnCmd07.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd08
            // 
            this.btnCmd08.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd08.Appearance.Options.UseFont = true;
            this.btnCmd08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd08.Location = new System.Drawing.Point(426, 234);
            this.btnCmd08.Name = "btnCmd08";
            this.btnCmd08.Size = new System.Drawing.Size(99, 52);
            this.btnCmd08.TabIndex = 16;
            this.btnCmd08.Text = "8";
            this.btnCmd08.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd09
            // 
            this.btnCmd09.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd09.Appearance.Options.UseFont = true;
            this.btnCmd09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd09.Location = new System.Drawing.Point(531, 234);
            this.btnCmd09.Name = "btnCmd09";
            this.btnCmd09.Size = new System.Drawing.Size(101, 52);
            this.btnCmd09.TabIndex = 17;
            this.btnCmd09.Text = "9";
            this.btnCmd09.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd60
            // 
            this.btnCmd60.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd60.Appearance.Options.UseFont = true;
            this.btnCmd60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd60.Location = new System.Drawing.Point(321, 292);
            this.btnCmd60.Name = "btnCmd60";
            this.btnCmd60.Size = new System.Drawing.Size(99, 52);
            this.btnCmd60.TabIndex = 18;
            this.btnCmd60.Text = "-";
            this.btnCmd60.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd00
            // 
            this.btnCmd00.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd00.Appearance.Options.UseFont = true;
            this.btnCmd00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd00.Location = new System.Drawing.Point(426, 292);
            this.btnCmd00.Name = "btnCmd00";
            this.btnCmd00.Size = new System.Drawing.Size(99, 52);
            this.btnCmd00.TabIndex = 19;
            this.btnCmd00.Text = "0";
            this.btnCmd00.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd70
            // 
            this.btnCmd70.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnCmd70.Appearance.Options.UseFont = true;
            this.btnCmd70.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd70.Location = new System.Drawing.Point(531, 292);
            this.btnCmd70.Name = "btnCmd70";
            this.btnCmd70.Size = new System.Drawing.Size(101, 52);
            this.btnCmd70.TabIndex = 20;
            this.btnCmd70.Text = "+";
            this.btnCmd70.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // _luT_DISPLAY_LIST
            // 
            this._luT_DISPLAY_LIST.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this._luT_DISPLAY_LIST, 2);
            this._luT_DISPLAY_LIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luT_DISPLAY_LIST.ItemIndex = -1;
            this._luT_DISPLAY_LIST.Location = new System.Drawing.Point(0, 231);
            this._luT_DISPLAY_LIST.Margin = new System.Windows.Forms.Padding(0);
            this._luT_DISPLAY_LIST.Name = "_luT_DISPLAY_LIST";
            this._luT_DISPLAY_LIST.ReadOnly = false;
            this._luT_DISPLAY_LIST.Size = new System.Drawing.Size(318, 58);
            this._luT_DISPLAY_LIST.TabIndex = 12;
            // 
            // _ucIMG_LOGIN_LOGO
            // 
            this._ucIMG_LOGIN_LOGO.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this._ucIMG_LOGIN_LOGO, 2);
            this._ucIMG_LOGIN_LOGO.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucIMG_LOGIN_LOGO.Image = global::CoFAS_MES.POP.Properties.Resources.Coever;
            this._ucIMG_LOGIN_LOGO.Location = new System.Drawing.Point(0, 0);
            this._ucIMG_LOGIN_LOGO.Margin = new System.Windows.Forms.Padding(0);
            this._ucIMG_LOGIN_LOGO.Name = "_ucIMG_LOGIN_LOGO";
            this.tableLayoutPanel1.SetRowSpan(this._ucIMG_LOGIN_LOGO, 2);
            this._ucIMG_LOGIN_LOGO.Size = new System.Drawing.Size(318, 115);
            this._ucIMG_LOGIN_LOGO.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this._ucIMG_LOGIN_LOGO.TabIndex = 7;
            // 
            // _luT_TERMINAL_LIST
            // 
            this._luT_TERMINAL_LIST.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this._luT_TERMINAL_LIST, 2);
            this._luT_TERMINAL_LIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luT_TERMINAL_LIST.ItemIndex = -1;
            this._luT_TERMINAL_LIST.Location = new System.Drawing.Point(0, 173);
            this._luT_TERMINAL_LIST.Margin = new System.Windows.Forms.Padding(0);
            this._luT_TERMINAL_LIST.Name = "_luT_TERMINAL_LIST";
            this._luT_TERMINAL_LIST.ReadOnly = false;
            this._luT_TERMINAL_LIST.Size = new System.Drawing.Size(318, 58);
            this._luT_TERMINAL_LIST.TabIndex = 11;
            this._luT_TERMINAL_LIST.ValueChanged += new System.EventHandler(this._luT_Terminal_LIST_TabIndexChanged);
            // 
            // _txtPassword
            // 
            this._txtPassword.AutoSize = true;
            this._txtPassword.CancelButton = null;
            this.tableLayoutPanel1.SetColumnSpan(this._txtPassword, 2);
            this._txtPassword.CommandButton = null;
            this._txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtPassword.EditMask = "";
            this._txtPassword.Location = new System.Drawing.Point(318, 57);
            this._txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this._txtPassword.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.NumText = "";
            this._txtPassword.PasswordChar = '*';
            this._txtPassword.ReadOnly = false;
            this._txtPassword.Size = new System.Drawing.Size(210, 58);
            this._txtPassword.TabIndex = 6;
            this._txtPassword.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._txtPassword.UseMaskAsDisplayFormat = false;
            this._txtPassword._OnKeyDown += new CoFAS_MES.CORE.BaseControls.ucTextEdit.OnKeyDownEventHandler(this._txtPassword_KeyDown);
            // 
            // _luT_PROCESS_LIST
            // 
            this._luT_PROCESS_LIST.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this._luT_PROCESS_LIST, 2);
            this._luT_PROCESS_LIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luT_PROCESS_LIST.ItemIndex = -1;
            this._luT_PROCESS_LIST.Location = new System.Drawing.Point(0, 115);
            this._luT_PROCESS_LIST.Margin = new System.Windows.Forms.Padding(0);
            this._luT_PROCESS_LIST.Name = "_luT_PROCESS_LIST";
            this._luT_PROCESS_LIST.ReadOnly = false;
            this._luT_PROCESS_LIST.Size = new System.Drawing.Size(318, 58);
            this._luT_PROCESS_LIST.TabIndex = 10;
            this._luT_PROCESS_LIST.ValueChanged += new System.EventHandler(this._luT_PROCESS_LIST_TabIndexChanged);
            // 
            // _txtAccount
            // 
            this._txtAccount.AutoSize = true;
            this._txtAccount.CancelButton = null;
            this.tableLayoutPanel1.SetColumnSpan(this._txtAccount, 2);
            this._txtAccount.CommandButton = null;
            this._txtAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtAccount.EditMask = "";
            this._txtAccount.Location = new System.Drawing.Point(318, 0);
            this._txtAccount.Margin = new System.Windows.Forms.Padding(0);
            this._txtAccount.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._txtAccount.Name = "_txtAccount";
            this._txtAccount.NumText = "";
            this._txtAccount.PasswordChar = '\0';
            this._txtAccount.ReadOnly = false;
            this._txtAccount.Size = new System.Drawing.Size(210, 57);
            this._txtAccount.TabIndex = 5;
            this._txtAccount.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._txtAccount.UseMaskAsDisplayFormat = false;
            this._txtAccount._OnKeyDown += new CoFAS_MES.CORE.BaseControls.ucTextEdit.OnKeyDownEventHandler(this._txtAccount_KeyDown);
            // 
            // frmPOPLogin_T08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 426);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._pnLoginMain);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOPLogin_T08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Login";
            this.Load += new System.EventHandler(this.frmPOPLogin_T08_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLoginMain)).EndInit();
            this._pnLoginMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ckUserIDSave.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl _pnLoginMain;
        private DevExpress.XtraEditors.LabelControl _lbLoginHeader;
        private DevExpress.XtraEditors.SimpleButton _btLoginClose;
        private DevExpress.XtraEditors.SimpleButton _btLoginOk;
        private DevExpress.XtraEditors.SimpleButton _btLoginCancel;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.CheckEdit _ckUserIDSave;
        private CORE.BaseControls.ucTextEdit _txtPassword;
        private CORE.BaseControls.ucTextEdit _txtAccount;
        private CORE.BaseControls.ucPictureEdit _ucIMG_LOGIN_LOGO;
        private DevExpress.XtraEditors.SimpleButton _btLoginSetting;
        private CORE.BaseControls.ucLookUpEdit _luT_PROCESS_LIST;
        private CORE.BaseControls.ucLookUpEdit _luT_TERMINAL_LIST;
        private CORE.BaseControls.ucLookUpEdit _luT_DISPLAY_LIST;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnCmd30;
        private DevExpress.XtraEditors.SimpleButton btnCmd01;
        private DevExpress.XtraEditors.SimpleButton btnCmd02;
        private DevExpress.XtraEditors.SimpleButton btnCmd03;
        private DevExpress.XtraEditors.SimpleButton btnCmd04;
        private DevExpress.XtraEditors.SimpleButton btnCmd05;
        private DevExpress.XtraEditors.SimpleButton btnCmd06;
        private DevExpress.XtraEditors.SimpleButton btnCmd07;
        private DevExpress.XtraEditors.SimpleButton btnCmd08;
        private DevExpress.XtraEditors.SimpleButton btnCmd09;
        private DevExpress.XtraEditors.SimpleButton btnCmd60;
        private DevExpress.XtraEditors.SimpleButton btnCmd00;
        private DevExpress.XtraEditors.SimpleButton btnCmd70;
    }
}