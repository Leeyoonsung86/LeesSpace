namespace CoFAS_MES.POP
{
    partial class frmPOPDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOPDocument));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCmd10 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd20 = new DevExpress.XtraEditors.SimpleButton();
            this.ucPictureEdit1 = new CoFAS_MES.CORE.BaseControls.ucPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            this._pnSINGLE_MAIN.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnSINGLE_MAIN
            // 
            this._pnSINGLE_MAIN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnSINGLE_MAIN.Appearance.BorderColor = System.Drawing.Color.Silver;
            this._pnSINGLE_MAIN.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_MAIN.Appearance.Options.UseBorderColor = true;
            this._pnSINGLE_MAIN.Controls.Add(this.tableLayoutPanel1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd10, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd20, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucPictureEdit1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(700, 100);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 360);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Tag = "";
            this.labelControl1.Text = "1/3";
            // 
            // btnCmd10
            // 
            this.btnCmd10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd10.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Up_64x;
            this.btnCmd10.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd10.Location = new System.Drawing.Point(703, 3);
            this.btnCmd10.Name = "btnCmd10";
            this.btnCmd10.Size = new System.Drawing.Size(94, 94);
            this.btnCmd10.TabIndex = 1;
            // 
            // btnCmd20
            // 
            this.btnCmd20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd20.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Down_64x;
            this.btnCmd20.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnCmd20.Location = new System.Drawing.Point(703, 463);
            this.btnCmd20.Name = "btnCmd20";
            this.btnCmd20.Size = new System.Drawing.Size(94, 94);
            this.btnCmd20.TabIndex = 2;
            // 
            // ucPictureEdit1
            // 
            this.ucPictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPictureEdit1.Image = ((System.Drawing.Image)(resources.GetObject("ucPictureEdit1.Image")));
            this.ucPictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.ucPictureEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.ucPictureEdit1.Name = "ucPictureEdit1";
            this.tableLayoutPanel1.SetRowSpan(this.ucPictureEdit1, 3);
            this.ucPictureEdit1.Size = new System.Drawing.Size(700, 560);
            this.ucPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip;
            this.ucPictureEdit1.TabIndex = 3;
            // 
            // frmPOPDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "frmPOPDocument";
            this.Text = "frmPOPDocument";
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCmd10;
        private DevExpress.XtraEditors.SimpleButton btnCmd20;
        private CORE.BaseControls.ucPictureEdit ucPictureEdit1;
    }
}