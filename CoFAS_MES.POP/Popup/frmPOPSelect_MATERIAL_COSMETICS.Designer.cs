﻿namespace CoFAS_MES.POP
{
    partial class frmPOPSelect_MATERIAL_COSMETICS
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
            this.btnCmd20 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd30 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd40 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCmd50 = new DevExpress.XtraEditors.SimpleButton();
            this._gdMAIN = new DevExpress.XtraGrid.GridControl();
            this._gdMAIN_VIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            this._pnSINGLE_MAIN.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this._pnSINGLE_MAIN.Controls.Add(this.tableLayoutPanel1);
            this._pnSINGLE_MAIN.Size = new System.Drawing.Size(800, 560);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.btnCmd10, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd20, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd30, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd40, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCmd50, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this._gdMAIN, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCmd10
            // 
            this.btnCmd10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd10.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.AUp_64x;
            this.btnCmd10.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd10.Location = new System.Drawing.Point(683, 3);
            this.btnCmd10.Name = "btnCmd10";
            this.btnCmd10.Size = new System.Drawing.Size(114, 106);
            this.btnCmd10.TabIndex = 0;
            this.btnCmd10.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd20
            // 
            this.btnCmd20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd20.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Up_64x;
            this.btnCmd20.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd20.Location = new System.Drawing.Point(683, 115);
            this.btnCmd20.Name = "btnCmd20";
            this.btnCmd20.Size = new System.Drawing.Size(114, 106);
            this.btnCmd20.TabIndex = 1;
            this.btnCmd20.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd30
            // 
            this.btnCmd30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd30.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Select_64x;
            this.btnCmd30.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCmd30.Location = new System.Drawing.Point(683, 227);
            this.btnCmd30.Name = "btnCmd30";
            this.btnCmd30.Size = new System.Drawing.Size(114, 106);
            this.btnCmd30.TabIndex = 2;
            this.btnCmd30.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd40
            // 
            this.btnCmd40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd40.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.Down_64x;
            this.btnCmd40.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnCmd40.Location = new System.Drawing.Point(683, 339);
            this.btnCmd40.Name = "btnCmd40";
            this.btnCmd40.Size = new System.Drawing.Size(114, 106);
            this.btnCmd40.TabIndex = 3;
            this.btnCmd40.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCmd50
            // 
            this.btnCmd50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCmd50.ImageOptions.Image = global::CoFAS_MES.POP.Properties.Resources.ADown_64x;
            this.btnCmd50.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnCmd50.Location = new System.Drawing.Point(683, 451);
            this.btnCmd50.Name = "btnCmd50";
            this.btnCmd50.Size = new System.Drawing.Size(114, 106);
            this.btnCmd50.TabIndex = 4;
            this.btnCmd50.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // _gdMAIN
            // 
            this._gdMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gdMAIN.Location = new System.Drawing.Point(0, 0);
            this._gdMAIN.MainView = this._gdMAIN_VIEW;
            this._gdMAIN.Margin = new System.Windows.Forms.Padding(0);
            this._gdMAIN.Name = "_gdMAIN";
            this.tableLayoutPanel1.SetRowSpan(this._gdMAIN, 5);
            this._gdMAIN.Size = new System.Drawing.Size(680, 560);
            this._gdMAIN.TabIndex = 5;
            this._gdMAIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gdMAIN_VIEW});
            // 
            // _gdMAIN_VIEW
            // 
            this._gdMAIN_VIEW.GridControl = this._gdMAIN;
            this._gdMAIN_VIEW.Name = "_gdMAIN_VIEW";
            this._gdMAIN_VIEW.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            // 
            // frmPOPSelect_MATERIAL_COSMETICS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "frmPOPSelect_MATERIAL_COSMETICS";
            this.Text = "frmPOPSelect_MATERIAL_COSMETICS";
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gdMAIN_VIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnCmd10;
        private DevExpress.XtraEditors.SimpleButton btnCmd20;
        private DevExpress.XtraEditors.SimpleButton btnCmd30;
        private DevExpress.XtraEditors.SimpleButton btnCmd40;
        private DevExpress.XtraEditors.SimpleButton btnCmd50;
        private DevExpress.XtraGrid.GridControl _gdMAIN;
        private DevExpress.XtraGrid.Views.Grid.GridView _gdMAIN_VIEW;
    }
}