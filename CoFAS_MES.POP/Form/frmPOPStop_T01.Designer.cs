namespace CoFAS_MES.POP
{
    partial class frmPOPStop_T01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOPStop_T01));
            this._lciTEnd = new System.Windows.Forms.TableLayoutPanel();
            this._luTSTOP_LIST = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this._ucbtCANCEL = new DevExpress.XtraEditors.SimpleButton();
            this._ucbtSAVE = new DevExpress.XtraEditors.SimpleButton();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._luTSTOP_DETAIL = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this._luTEND = new CoFAS_MES.CORE.BaseControls.ucDateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this._luTStart_Hour = new DevExpress.XtraEditors.LabelControl();
            this._luTStart_Minute = new DevExpress.XtraEditors.LabelControl();
            this._luTEnd_Hour = new DevExpress.XtraEditors.LabelControl();
            this._luTEnd_Minute = new DevExpress.XtraEditors.LabelControl();
            this._luTDATE = new CoFAS_MES.CORE.BaseControls.ucDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            this._pnSINGLE_MAIN.SuspendLayout();
            this._lciTEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnSINGLE_MAIN
            // 
            this._pnSINGLE_MAIN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnSINGLE_MAIN.Appearance.BorderColor = System.Drawing.Color.Silver;
            this._pnSINGLE_MAIN.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_MAIN.Appearance.Options.UseBorderColor = true;
            this._pnSINGLE_MAIN.Controls.Add(this._lciTEnd);
            this._pnSINGLE_MAIN.Size = new System.Drawing.Size(1280, 984);
            // 
            // _btPageSetting
            // 
            this._btPageSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btPageSetting.ImageOptions.Image")));
            this._btPageSetting.Location = new System.Drawing.Point(1200, 0);
            // 
            // _lciTEnd
            // 
            this._lciTEnd.ColumnCount = 7;
            this._lciTEnd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.81188F));
            this._lciTEnd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.87129F));
            this._lciTEnd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.485149F));
            this._lciTEnd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.930693F));
            this._lciTEnd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.485149F));
            this._lciTEnd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.930693F));
            this._lciTEnd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.48515F));
            this._lciTEnd.Controls.Add(this._luTSTOP_LIST, 1, 0);
            this._lciTEnd.Controls.Add(this._ucbtCANCEL, 6, 9);
            this._lciTEnd.Controls.Add(this._ucbtSAVE, 0, 9);
            this._lciTEnd.Controls.Add(this._gdMAIN, 0, 4);
            this._lciTEnd.Controls.Add(this._luTSTOP_DETAIL, 1, 1);
            this._lciTEnd.Controls.Add(this.labelControl1, 0, 0);
            this._lciTEnd.Controls.Add(this.labelControl3, 0, 1);
            this._lciTEnd.Controls.Add(this.labelControl2, 0, 2);
            this._lciTEnd.Controls.Add(this.labelControl4, 2, 2);
            this._lciTEnd.Controls.Add(this.labelControl5, 4, 2);
            this._lciTEnd.Controls.Add(this.labelControl6, 0, 3);
            this._lciTEnd.Controls.Add(this._luTEND, 1, 3);
            this._lciTEnd.Controls.Add(this.labelControl7, 2, 3);
            this._lciTEnd.Controls.Add(this.labelControl8, 4, 3);
            this._lciTEnd.Controls.Add(this._luTStart_Hour, 3, 2);
            this._lciTEnd.Controls.Add(this._luTStart_Minute, 5, 2);
            this._lciTEnd.Controls.Add(this._luTEnd_Hour, 3, 3);
            this._lciTEnd.Controls.Add(this._luTEnd_Minute, 5, 3);
            this._lciTEnd.Controls.Add(this._luTDATE, 1, 2);
            this._lciTEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lciTEnd.Location = new System.Drawing.Point(0, 0);
            this._lciTEnd.Margin = new System.Windows.Forms.Padding(0);
            this._lciTEnd.Name = "_lciTEnd";
            this._lciTEnd.RowCount = 10;
            this._lciTEnd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this._lciTEnd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this._lciTEnd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this._lciTEnd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this._lciTEnd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this._lciTEnd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this._lciTEnd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._lciTEnd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._lciTEnd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this._lciTEnd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this._lciTEnd.Size = new System.Drawing.Size(1280, 984);
            this._lciTEnd.TabIndex = 0;
            // 
            // _luTSTOP_LIST
            // 
            this._luTSTOP_LIST.AutoSize = true;
            this._lciTEnd.SetColumnSpan(this._luTSTOP_LIST, 6);
            this._luTSTOP_LIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luTSTOP_LIST.ItemIndex = -1;
            this._luTSTOP_LIST.Location = new System.Drawing.Point(240, 0);
            this._luTSTOP_LIST.Margin = new System.Windows.Forms.Padding(0);
            this._luTSTOP_LIST.Name = "_luTSTOP_LIST";
            this._luTSTOP_LIST.ReadOnly = false;
            this._luTSTOP_LIST.Size = new System.Drawing.Size(1040, 78);
            this._luTSTOP_LIST.TabIndex = 8;
            this._luTSTOP_LIST.ValueChanged += new System.EventHandler(this._luTSTOP_LIST_ValueChanged);
            // 
            // _ucbtCANCEL
            // 
            this._ucbtCANCEL.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ucbtCANCEL.Appearance.Options.UseFont = true;
            this._ucbtCANCEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtCANCEL.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources._1403074860_onebit_33;
            this._ucbtCANCEL.Location = new System.Drawing.Point(621, 902);
            this._ucbtCANCEL.Name = "_ucbtCANCEL";
            this._ucbtCANCEL.Size = new System.Drawing.Size(656, 79);
            this._ucbtCANCEL.TabIndex = 7;
            this._ucbtCANCEL.Text = "閉じる";
            this._ucbtCANCEL.Click += new System.EventHandler(this._ucbtCANCEL_Click);
            // 
            // _ucbtSAVE
            // 
            this._ucbtSAVE.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold);
            this._ucbtSAVE.Appearance.Options.UseFont = true;
            this._lciTEnd.SetColumnSpan(this._ucbtSAVE, 6);
            this._ucbtSAVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucbtSAVE.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Down_64x;
            this._ucbtSAVE.Location = new System.Drawing.Point(3, 902);
            this._ucbtSAVE.Name = "_ucbtSAVE";
            this._ucbtSAVE.Size = new System.Drawing.Size(612, 79);
            this._ucbtSAVE.TabIndex = 6;
            this._ucbtSAVE.Text = "保存";
            this._ucbtSAVE.Click += new System.EventHandler(this._ucbtSAVE_Click);
            // 
            // _gdMAIN
            // 
            this._lciTEnd.SetColumnSpan(this._gdMAIN, 7);
            this._gdMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gdMAIN.Location = new System.Drawing.Point(3, 315);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Name = "_gdMAIN";
            this._lciTEnd.SetRowSpan(this._gdMAIN, 5);
            this._gdMAIN.Size = new System.Drawing.Size(1274, 581);
            this._gdMAIN.TabIndex = 11;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            // 
            // _luTSTOP_DETAIL
            // 
            this._luTSTOP_DETAIL.AutoSize = true;
            this._lciTEnd.SetColumnSpan(this._luTSTOP_DETAIL, 6);
            this._luTSTOP_DETAIL.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luTSTOP_DETAIL.ItemIndex = -1;
            this._luTSTOP_DETAIL.Location = new System.Drawing.Point(240, 78);
            this._luTSTOP_DETAIL.Margin = new System.Windows.Forms.Padding(0);
            this._luTSTOP_DETAIL.Name = "_luTSTOP_DETAIL";
            this._luTSTOP_DETAIL.ReadOnly = false;
            this._luTSTOP_DETAIL.Size = new System.Drawing.Size(1040, 78);
            this._luTSTOP_DETAIL.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Meiryo UI", 30F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(234, 72);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "雨同タイプ :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Meiryo UI", 30F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(3, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(234, 72);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "雨同理由 :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Meiryo UI", 30F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 159);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(234, 72);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "開始時間 :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(407, 159);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(14, 48);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = ":";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(514, 159);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(14, 48);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = ":";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Meiryo UI", 30F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(3, 237);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(234, 72);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "終了時間 :";
            // 
            // _luTEND
            // 
            this._luTEND.DateTime = new System.DateTime(2019, 2, 18, 0, 0, 0, 0);
            this._luTEND.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luTEND.Location = new System.Drawing.Point(240, 234);
            this._luTEND.Margin = new System.Windows.Forms.Padding(0);
            this._luTEND.Name = "_luTEND";
            this._luTEND.ReadOnly = false;
            this._luTEND.Size = new System.Drawing.Size(164, 78);
            this._luTEND.TabIndex = 37;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(407, 237);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(14, 48);
            this.labelControl7.TabIndex = 38;
            this.labelControl7.Text = ":";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(514, 237);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(14, 48);
            this.labelControl8.TabIndex = 39;
            this.labelControl8.Text = ":";
            // 
            // _luTStart_Hour
            // 
            this._luTStart_Hour.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._luTStart_Hour.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this._luTStart_Hour.Appearance.Options.UseBackColor = true;
            this._luTStart_Hour.Appearance.Options.UseFont = true;
            this._luTStart_Hour.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luTStart_Hour.Location = new System.Drawing.Point(426, 159);
            this._luTStart_Hour.Name = "_luTStart_Hour";
            this._luTStart_Hour.Size = new System.Drawing.Size(82, 72);
            this._luTStart_Hour.TabIndex = 42;
            this._luTStart_Hour.Text = "0";
            this._luTStart_Hour.Click += new System.EventHandler(this._luTStart_Hour_Click_1);
            // 
            // _luTStart_Minute
            // 
            this._luTStart_Minute.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._luTStart_Minute.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this._luTStart_Minute.Appearance.Options.UseBackColor = true;
            this._luTStart_Minute.Appearance.Options.UseFont = true;
            this._luTStart_Minute.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luTStart_Minute.Location = new System.Drawing.Point(533, 159);
            this._luTStart_Minute.Name = "_luTStart_Minute";
            this._luTStart_Minute.Size = new System.Drawing.Size(82, 72);
            this._luTStart_Minute.TabIndex = 43;
            this._luTStart_Minute.Text = "0";
            this._luTStart_Minute.Click += new System.EventHandler(this._luTStart_Minute_Click);
            // 
            // _luTEnd_Hour
            // 
            this._luTEnd_Hour.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._luTEnd_Hour.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this._luTEnd_Hour.Appearance.Options.UseBackColor = true;
            this._luTEnd_Hour.Appearance.Options.UseFont = true;
            this._luTEnd_Hour.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luTEnd_Hour.Location = new System.Drawing.Point(426, 237);
            this._luTEnd_Hour.Name = "_luTEnd_Hour";
            this._luTEnd_Hour.Size = new System.Drawing.Size(82, 72);
            this._luTEnd_Hour.TabIndex = 44;
            this._luTEnd_Hour.Text = "0";
            this._luTEnd_Hour.Click += new System.EventHandler(this._luTEnd_Hour_Click);
            // 
            // _luTEnd_Minute
            // 
            this._luTEnd_Minute.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._luTEnd_Minute.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this._luTEnd_Minute.Appearance.Options.UseBackColor = true;
            this._luTEnd_Minute.Appearance.Options.UseFont = true;
            this._luTEnd_Minute.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luTEnd_Minute.Location = new System.Drawing.Point(533, 237);
            this._luTEnd_Minute.Name = "_luTEnd_Minute";
            this._luTEnd_Minute.Size = new System.Drawing.Size(82, 72);
            this._luTEnd_Minute.TabIndex = 45;
            this._luTEnd_Minute.Text = "0";
            this._luTEnd_Minute.Click += new System.EventHandler(this._luTEnd_Minute_Click);
            // 
            // _luTDATE
            // 
            this._luTDATE.DateTime = new System.DateTime(2019, 2, 19, 14, 36, 20, 923);
            this._luTDATE.Dock = System.Windows.Forms.DockStyle.Fill;
            this._luTDATE.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._luTDATE.Location = new System.Drawing.Point(240, 156);
            this._luTDATE.Margin = new System.Windows.Forms.Padding(0);
            this._luTDATE.Name = "_luTDATE";
            this._luTDATE.ReadOnly = false;
            this._luTDATE.Size = new System.Drawing.Size(164, 78);
            this._luTDATE.TabIndex = 46;
            // 
            // frmPOPStop_T01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Child_Page_Setting_Visible = true;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Name = "frmPOPStop_T01";
            this.Text = "frmPOPOrder_T01";
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this._lciTEnd.ResumeLayout(false);
            this._lciTEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _lciTEnd;
        private DevExpress.XtraEditors.SimpleButton _ucbtSAVE;
        private DevExpress.XtraEditors.SimpleButton _ucbtCANCEL;
        private CORE.BaseControls.ucLookUpEdit _luTSTOP_LIST;
        private CORE.BaseControls.ucLookUpEdit _luTSTOP_DETAIL;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private CORE.BaseControls.ucDateEdit _luTEND;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl _luTStart_Hour;
        private DevExpress.XtraEditors.LabelControl _luTStart_Minute;
        private DevExpress.XtraEditors.LabelControl _luTEnd_Hour;
        private DevExpress.XtraEditors.LabelControl _luTEnd_Minute;
        private CORE.BaseControls.ucDateEdit _luTDATE;
    }
}