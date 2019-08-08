namespace CoFAS_MES.POP
{
    partial class frmPOPComplete
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCmd10 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this._luT_PrintCode = new CoFAS_MES.CORE.BaseControls.ucLookUpEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._luT_PrintSEQ = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this._luT_PrintQTY = new CoFAS_MES.CORE.BaseControls.ucTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            this._pnSINGLE_MAIN.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnSINGLE_MAIN
            // 
            this._pnSINGLE_MAIN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnSINGLE_MAIN.Appearance.BorderColor = System.Drawing.Color.Silver;
            this._pnSINGLE_MAIN.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_MAIN.Appearance.Options.UseBorderColor = true;
            this._pnSINGLE_MAIN.Controls.Add(this.tableLayoutPanel1);
            this._pnSINGLE_MAIN.Size = new System.Drawing.Size(600, 360);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCmd10, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.layoutControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.layoutControl1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCmd10
            // 
            this.btnCmd10.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmd10.Appearance.Options.UseFont = true;
            this.btnCmd10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd10.Location = new System.Drawing.Point(150, 260);
            this.btnCmd10.Margin = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.btnCmd10.Name = "btnCmd10";
            this.btnCmd10.Size = new System.Drawing.Size(300, 100);
            this.btnCmd10.TabIndex = 4;
            this.btnCmd10.Text = "발행";
            this.btnCmd10.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this._luT_PrintCode);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(53, 3);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(494, 94);
            this.layoutControl2.TabIndex = 6;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // _luT_PrintCode
            // 
            this._luT_PrintCode.ItemIndex = -1;
            this._luT_PrintCode.Location = new System.Drawing.Point(87, 12);
            this._luT_PrintCode.Margin = new System.Windows.Forms.Padding(0);
            this._luT_PrintCode.Name = "_luT_PrintCode";
            this._luT_PrintCode.ReadOnly = false;
            this._luT_PrintCode.Size = new System.Drawing.Size(395, 70);
            this._luT_PrintCode.TabIndex = 4;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(494, 94);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this._luT_PrintCode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(474, 74);
            this.layoutControlItem2.Text = "완제품";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 39);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._luT_PrintSEQ);
            this.layoutControl1.Controls.Add(this._luT_PrintQTY);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(53, 103);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(494, 94);
            this.layoutControl1.TabIndex = 5;
            // 
            // _luT_PrintSEQ
            // 
            this._luT_PrintSEQ.CancelButton = null;
            this._luT_PrintSEQ.CommandButton = null;
            this._luT_PrintSEQ.EditMask = "";
            this._luT_PrintSEQ.Location = new System.Drawing.Point(111, 12);
            this._luT_PrintSEQ.Margin = new System.Windows.Forms.Padding(0);
            this._luT_PrintSEQ.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luT_PrintSEQ.Name = "_luT_PrintSEQ";
            this._luT_PrintSEQ.PasswordChar = '\0';
            this._luT_PrintSEQ.ReadOnly = false;
            this._luT_PrintSEQ.Size = new System.Drawing.Size(138, 70);
            this._luT_PrintSEQ.TabIndex = 8;
            this._luT_PrintSEQ.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luT_PrintSEQ.UseMaskAsDisplayFormat = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(494, 94);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 24F);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this._luT_PrintSEQ;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(241, 74);
            this.layoutControlItem4.Text = "출력갯수";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(96, 39);
            // 
            // _luT_PrintQTY
            // 
            this._luT_PrintQTY.CancelButton = null;
            this._luT_PrintQTY.CommandButton = null;
            this._luT_PrintQTY.EditMask = "";
            this._luT_PrintQTY.Location = new System.Drawing.Point(352, 12);
            this._luT_PrintQTY.Margin = new System.Windows.Forms.Padding(0);
            this._luT_PrintQTY.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this._luT_PrintQTY.Name = "_luT_PrintQTY";
            this._luT_PrintQTY.PasswordChar = '\0';
            this._luT_PrintQTY.ReadOnly = false;
            this._luT_PrintQTY.Size = new System.Drawing.Size(130, 70);
            this._luT_PrintQTY.TabIndex = 8;
            this._luT_PrintQTY.TextAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._luT_PrintQTY.UseMaskAsDisplayFormat = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 24F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this._luT_PrintQTY;
            this.layoutControlItem1.CustomizationFormText = "완료수량";
            this.layoutControlItem1.Location = new System.Drawing.Point(241, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(233, 74);
            this.layoutControlItem1.Text = "등록갯수";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 14);
            // 
            // frmPOPComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Name = "frmPOPComplete";
            this.Text = "frmPOPComplete";
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnCmd10;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private CORE.BaseControls.ucLookUpEdit _luT_PrintCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private CORE.BaseControls.ucTextEdit _luT_PrintSEQ;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private CORE.BaseControls.ucTextEdit _luT_PrintQTY;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}