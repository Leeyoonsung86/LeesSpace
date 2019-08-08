namespace CoFAS_MES.UI.PM
{
    partial class ProductNotOutStatus
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._luTCONTRACT_ID = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this._luTPART = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luTVEND = new CoFAS_MES.CORE.BaseControls.ucSearchEdit();
            this._luTCONTRACT_DATE = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this._lciCONTRACT_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this._lciVEND = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciPART = new DevExpress.XtraLayout.LayoutControlItem();
            this._lciCONTRACT_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.dashboardViewer = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            this._pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            this._pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.Controls.Add(this.layoutControl1);
            this._pnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnHeader.Size = new System.Drawing.Size(1200, 95);
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.Controls.Add(this.layoutControl2);
            this._pnContent.Location = new System.Drawing.Point(24, 95);
            this._pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnContent.Size = new System.Drawing.Size(1171, 605);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            this._pnLeft.Location = new System.Drawing.Point(0, 95);
            this._pnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnLeft.Size = new System.Drawing.Size(19, 605);
            this._pnLeft.Visible = false;
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnRight.Location = new System.Drawing.Point(24, 95);
            this._pnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnRight.Size = new System.Drawing.Size(1176, 605);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luTCONTRACT_ID);
            this.layoutControl1.Controls.Add(this._luTPART);
            this.layoutControl1.Controls.Add(this._luTVEND);
            this.layoutControl1.Controls.Add(this._luTCONTRACT_DATE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1200, 95);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _luTCONTRACT_ID
            // 
            this._luTCONTRACT_ID.CancelButton = null;
            this._luTCONTRACT_ID.CommandButton = null;
            this._luTCONTRACT_ID.EditMask = "";
            this._luTCONTRACT_ID.Location = new System.Drawing.Point(150, 50);
            this._luTCONTRACT_ID.Margin = new System.Windows.Forms.Padding(0);
            this._luTCONTRACT_ID.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luTCONTRACT_ID.Name = "_luTCONTRACT_ID";
            this._luTCONTRACT_ID.NumText = "";
            this._luTCONTRACT_ID.PasswordChar = '\0';
            this._luTCONTRACT_ID.ReadOnly = false;
            this._luTCONTRACT_ID.Size = new System.Drawing.Size(280, 21);
            this._luTCONTRACT_ID.TabIndex = 8;
            this._luTCONTRACT_ID.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luTCONTRACT_ID.UseMaskAsDisplayFormat = false;
            // 
            // _luTPART
            // 
            this._luTPART.BackColor = System.Drawing.Color.White;
            this._luTPART.CodeReadOnly = false;
            this._luTPART.CodeText = "";
            this._luTPART.CodeTextName = "_pCodeTextEdit";
            this._luTPART.Location = new System.Drawing.Point(555, 50);
            this._luTPART.Name = "_luTPART";
            this._luTPART.NameEnabled = true;
            this._luTPART.NameReadOnly = false;
            this._luTPART.NameText = "";
            this._luTPART.NameTextName = "_pNameButtonEdit";
            this._luTPART.Size = new System.Drawing.Size(269, 21);
            this._luTPART.TabIndex = 4;
            this._luTPART._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luTPART__OnOpenClick);
            // 
            // _luTVEND
            // 
            this._luTVEND.BackColor = System.Drawing.Color.White;
            this._luTVEND.CodeReadOnly = false;
            this._luTVEND.CodeText = "";
            this._luTVEND.CodeTextName = "_pCodeTextEdit";
            this._luTVEND.Location = new System.Drawing.Point(555, 24);
            this._luTVEND.Name = "_luTVEND";
            this._luTVEND.NameEnabled = true;
            this._luTVEND.NameReadOnly = false;
            this._luTVEND.NameText = "";
            this._luTVEND.NameTextName = "_pNameButtonEdit";
            this._luTVEND.Size = new System.Drawing.Size(269, 22);
            this._luTVEND.TabIndex = 5;
            this._luTVEND._OnOpenClick += new CoFAS_MES.CORE.BaseControls.ucSearchEdit.OnOpenClickEventHandler(this._luTVEND__OnOpenClick);
            // 
            // _luTCONTRACT_DATE
            // 
            this._luTCONTRACT_DATE.FromDateTime = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this._luTCONTRACT_DATE.Location = new System.Drawing.Point(150, 24);
            this._luTCONTRACT_DATE.Margin = new System.Windows.Forms.Padding(0);
            this._luTCONTRACT_DATE.Name = "_luTCONTRACT_DATE";
            this._luTCONTRACT_DATE.Size = new System.Drawing.Size(280, 22);
            this._luTCONTRACT_DATE.TabIndex = 4;
            this._luTCONTRACT_DATE.ToDateTime = new System.DateTime(2018, 4, 25, 23, 59, 59, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 15, 10, 10);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1200, 95);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._lciCONTRACT_DATE,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this._lciVEND,
            this._lciPART,
            this._lciCONTRACT_ID});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(1170, 75);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // _lciCONTRACT_DATE
            // 
            this._lciCONTRACT_DATE.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCONTRACT_DATE.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCONTRACT_DATE.Control = this._luTCONTRACT_DATE;
            this._lciCONTRACT_DATE.Location = new System.Drawing.Point(0, 0);
            this._lciCONTRACT_DATE.MaxSize = new System.Drawing.Size(405, 26);
            this._lciCONTRACT_DATE.MinSize = new System.Drawing.Size(405, 26);
            this._lciCONTRACT_DATE.Name = "_lciCONTRACT_DATE";
            this._lciCONTRACT_DATE.Size = new System.Drawing.Size(405, 26);
            this._lciCONTRACT_DATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCONTRACT_DATE.TextSize = new System.Drawing.Size(117, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(799, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(330, 26);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(330, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(347, 26);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem2.Location = new System.Drawing.Point(799, 26);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(330, 25);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(330, 25);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(347, 25);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.Text = "emptySpaceItem1";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // _lciVEND
            // 
            this._lciVEND.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciVEND.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciVEND.Control = this._luTVEND;
            this._lciVEND.Location = new System.Drawing.Point(405, 0);
            this._lciVEND.MaxSize = new System.Drawing.Size(394, 26);
            this._lciVEND.MinSize = new System.Drawing.Size(394, 26);
            this._lciVEND.Name = "_lciVEND";
            this._lciVEND.Size = new System.Drawing.Size(394, 26);
            this._lciVEND.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciVEND.TextSize = new System.Drawing.Size(117, 14);
            // 
            // _lciPART
            // 
            this._lciPART.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciPART.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciPART.Control = this._luTPART;
            this._lciPART.Location = new System.Drawing.Point(405, 26);
            this._lciPART.MaxSize = new System.Drawing.Size(394, 25);
            this._lciPART.MinSize = new System.Drawing.Size(394, 25);
            this._lciPART.Name = "_lciPART";
            this._lciPART.Size = new System.Drawing.Size(394, 25);
            this._lciPART.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciPART.TextSize = new System.Drawing.Size(117, 14);
            // 
            // _lciCONTRACT_ID
            // 
            this._lciCONTRACT_ID.AppearanceItemCaption.Options.UseTextOptions = true;
            this._lciCONTRACT_ID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._lciCONTRACT_ID.Control = this._luTCONTRACT_ID;
            this._lciCONTRACT_ID.Location = new System.Drawing.Point(0, 26);
            this._lciCONTRACT_ID.MaxSize = new System.Drawing.Size(405, 25);
            this._lciCONTRACT_ID.MinSize = new System.Drawing.Size(405, 25);
            this._lciCONTRACT_ID.Name = "_lciCONTRACT_ID";
            this._lciCONTRACT_ID.Size = new System.Drawing.Size(405, 25);
            this._lciCONTRACT_ID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this._lciCONTRACT_ID.TextSize = new System.Drawing.Size(117, 14);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.dashboardViewer);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1171, 605);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dashboardViewer.Appearance.Options.UseBackColor = true;
            this.dashboardViewer.Location = new System.Drawing.Point(12, 12);
            this.dashboardViewer.Name = "dashboardViewer";
            this.dashboardViewer.Size = new System.Drawing.Size(1147, 581);
            this.dashboardViewer.TabIndex = 4;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1171, 605);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dashboardViewer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1151, 585);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ProductNotOutStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductNotOutStatus";
            this.Text = "MaterialOrderStatus";
            this.WindowName = "MaterialOrderStatus";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            this._pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            this._pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciVEND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciPART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lciCONTRACT_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private DevExpress.XtraLayout.LayoutControl layoutControl1;
            private CORE.BaseControls.ucFromToDateEdit _luTCONTRACT_DATE;
            private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
            private DevExpress.XtraLayout.LayoutControlItem _lciCONTRACT_DATE;
            private DevExpress.XtraLayout.LayoutControl layoutControl2;
            private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
            private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
            private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
            private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
            private CORE.BaseControls.ucSearchEdit _luTPART;
            private CORE.BaseControls.ucSearchEdit _luTVEND;
            private DevExpress.XtraLayout.LayoutControlItem _lciVEND;
            private DevExpress.XtraLayout.LayoutControlItem _lciPART;
            private DevExpress.DashboardWin.DashboardViewer dashboardViewer;
            private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CORE.BaseControls.ucTextEdit _luTCONTRACT_ID;
        private DevExpress.XtraLayout.LayoutControlItem _lciCONTRACT_ID;
    }
    }