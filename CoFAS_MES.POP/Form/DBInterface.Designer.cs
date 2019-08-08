namespace CoFAS_MES.POP
{
    partial class DBInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBInterface));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._lvLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._luPROC_TIME = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._btSTOP = new DevExpress.XtraEditors.SimpleButton();
            this._btSTART = new DevExpress.XtraEditors.SimpleButton();
            this._luPROC_DATE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luWORK_DATE = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luJSNO = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this._pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnMain
            // 
            this._pnMain.Controls.Add(this.layoutControl1);
            this._pnMain.Size = new System.Drawing.Size(788, 337);
            // 
            // _pnRight
            // 
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnRight.Location = new System.Drawing.Point(0, 0);
            this._pnRight.Size = new System.Drawing.Size(788, 337);
            // 
            // _lbHeader
            // 
            this._lbHeader.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this._lbHeader.Appearance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbHeader.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("_lbHeader.Appearance.Image")));
            this._lbHeader.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lbHeader.Appearance.Options.UseBackColor = true;
            this._lbHeader.Appearance.Options.UseFont = true;
            this._lbHeader.Appearance.Options.UseImage = true;
            this._lbHeader.Appearance.Options.UseImageAlign = true;
            this._lbHeader.Size = new System.Drawing.Size(728, 20);
            this._lbHeader.Text = "데이터 수집 프로그램 v1.0";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._lvLog);
            this.layoutControl1.Controls.Add(this._luPROC_TIME);
            this.layoutControl1.Controls.Add(this._btSTOP);
            this.layoutControl1.Controls.Add(this._btSTART);
            this.layoutControl1.Controls.Add(this._luPROC_DATE);
            this.layoutControl1.Controls.Add(this._luWORK_DATE);
            this.layoutControl1.Controls.Add(this._luJSNO);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(788, 337);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _lvLog
            // 
            this._lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this._lvLog.Location = new System.Drawing.Point(12, 168);
            this._lvLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lvLog.Name = "_lvLog";
            this._lvLog.Size = new System.Drawing.Size(764, 157);
            this._lvLog.TabIndex = 11;
            this._lvLog.UseCompatibleStateImageBehavior = false;
            this._lvLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "수집 시간";
            this.columnHeader1.Width = 181;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "수집 데이터";
            this.columnHeader2.Width = 729;
            // 
            // _luPROC_TIME
            // 
            this._luPROC_TIME.CancelButton = null;
            this._luPROC_TIME.CommandButton = null;
            this._luPROC_TIME.EditMask = "";
            this._luPROC_TIME.Location = new System.Drawing.Point(463, 122);
            this._luPROC_TIME.Margin = new System.Windows.Forms.Padding(0);
            this._luPROC_TIME.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPROC_TIME.Name = "_luPROC_TIME";
            this._luPROC_TIME.PasswordChar = '\0';
            this._luPROC_TIME.ReadOnly = true;
            this._luPROC_TIME.Size = new System.Drawing.Size(301, 20);
            this._luPROC_TIME.TabIndex = 10;
            this._luPROC_TIME.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPROC_TIME.UseMaskAsDisplayFormat = false;
            // 
            // _btSTOP
            // 
            this._btSTOP.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this._btSTOP.Appearance.Options.UseFont = true;
            this._btSTOP.Location = new System.Drawing.Point(396, 12);
            this._btSTOP.Name = "_btSTOP";
            this._btSTOP.Size = new System.Drawing.Size(380, 24);
            this._btSTOP.StyleController = this.layoutControl1;
            this._btSTOP.TabIndex = 9;
            this._btSTOP.Text = "인터페이스 중지";
            this._btSTOP.Click += new System.EventHandler(this._btSTOP_Click);
            // 
            // _btSTART
            // 
            this._btSTART.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this._btSTART.Appearance.Options.UseFont = true;
            this._btSTART.Location = new System.Drawing.Point(12, 12);
            this._btSTART.Name = "_btSTART";
            this._btSTART.Size = new System.Drawing.Size(380, 24);
            this._btSTART.StyleController = this.layoutControl1;
            this._btSTART.TabIndex = 8;
            this._btSTART.Text = "인터페이스 시작";
            this._btSTART.Click += new System.EventHandler(this._btSTART_Click);
            // 
            // _luPROC_DATE
            // 
            this._luPROC_DATE.CancelButton = null;
            this._luPROC_DATE.CommandButton = null;
            this._luPROC_DATE.EditMask = "";
            this._luPROC_DATE.Location = new System.Drawing.Point(463, 98);
            this._luPROC_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luPROC_DATE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luPROC_DATE.Name = "_luPROC_DATE";
            this._luPROC_DATE.PasswordChar = '\0';
            this._luPROC_DATE.ReadOnly = true;
            this._luPROC_DATE.Size = new System.Drawing.Size(301, 20);
            this._luPROC_DATE.TabIndex = 7;
            this._luPROC_DATE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luPROC_DATE.UseMaskAsDisplayFormat = false;
            // 
            // _luWORK_DATE
            // 
            this._luWORK_DATE.CancelButton = null;
            this._luWORK_DATE.CommandButton = null;
            this._luWORK_DATE.EditMask = "";
            this._luWORK_DATE.Location = new System.Drawing.Point(463, 74);
            this._luWORK_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luWORK_DATE.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luWORK_DATE.Name = "_luWORK_DATE";
            this._luWORK_DATE.PasswordChar = '\0';
            this._luWORK_DATE.ReadOnly = true;
            this._luWORK_DATE.Size = new System.Drawing.Size(301, 20);
            this._luWORK_DATE.TabIndex = 6;
            this._luWORK_DATE.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luWORK_DATE.UseMaskAsDisplayFormat = false;
            // 
            // _luJSNO
            // 
            this._luJSNO.CancelButton = null;
            this._luJSNO.CommandButton = null;
            this._luJSNO.EditMask = "";
            this._luJSNO.Location = new System.Drawing.Point(79, 74);
            this._luJSNO.Margin = new System.Windows.Forms.Padding(0);
            this._luJSNO.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luJSNO.Name = "_luJSNO";
            this._luJSNO.PasswordChar = '\0';
            this._luJSNO.ReadOnly = true;
            this._luJSNO.Size = new System.Drawing.Size(301, 20);
            this._luJSNO.TabIndex = 4;
            this._luJSNO.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luJSNO.UseMaskAsDisplayFormat = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem7});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(788, 337);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem3,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(384, 128);
            this.layoutControlGroup2.Text = "작업오더정보 인터페이스";
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(360, 58);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this._luJSNO;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(213, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "접수번호";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 17);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem6});
            this.layoutControlGroup3.Location = new System.Drawing.Point(384, 28);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(384, 128);
            this.layoutControlGroup3.Text = "텐더 센서 수집데이터 인터페이스";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(360, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this._luPROC_DATE;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(213, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "수집일자";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this._luWORK_DATE;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(213, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "수집번호";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._luPROC_TIME;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem6.Text = "수집시간";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(52, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._btSTART;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(384, 28);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._btSTOP;
            this.layoutControlItem5.Location = new System.Drawing.Point(384, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(384, 28);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._lvLog;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 156);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(768, 161);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // DBInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 467);
            this.Name = "DBInterface";
            this.Text = "DBInterface";
            this._pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private CORE.BaseControls.ucTextEdit _luPROC_DATE;
        private CORE.BaseControls.ucTextEdit _luWORK_DATE;
        private CORE.BaseControls.ucTextEdit _luJSNO;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton _btSTOP;
        private DevExpress.XtraEditors.SimpleButton _btSTART;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private CORE.BaseControls.ucTextEdit _luPROC_TIME;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.ListView _lvLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}