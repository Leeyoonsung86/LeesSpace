namespace CoFAS_MES.UI.SP
{
    partial class ShipmentPlanRegister
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
            this.ucFromToDateEdit1 = new CoFAS_MES.CORE.BaseControls.ucFromToDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).BeginInit();
            this._pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnHeader
            // 
            this._pnHeader.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnHeader.Appearance.Options.UseBackColor = true;
            this._pnHeader.Controls.Add(this.ucFromToDateEdit1);
            // 
            // _pnContent
            // 
            this._pnContent.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnContent.Appearance.Options.UseBackColor = true;
            this._pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnContent.Size = new System.Drawing.Size(1190, 634);
            // 
            // _pnLeft
            // 
            this._pnLeft.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnLeft.Appearance.Options.UseBackColor = true;
            // 
            // _pnRight
            // 
            this._pnRight.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnRight.Appearance.Options.UseBackColor = true;
            this._pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnRight.Location = new System.Drawing.Point(205, 86);
            this._pnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnRight.Size = new System.Drawing.Size(1195, 634);
            // 
            // ucFromToDateEdit1
            // 
            this.ucFromToDateEdit1.FromDateTime = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.ucFromToDateEdit1.Location = new System.Drawing.Point(154, 42);
            this.ucFromToDateEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.ucFromToDateEdit1.Name = "ucFromToDateEdit1";
            this.ucFromToDateEdit1.Size = new System.Drawing.Size(272, 19);
            this.ucFromToDateEdit1.TabIndex = 0;
            this.ucFromToDateEdit1.ToDateTime = new System.DateTime(2018, 6, 22, 8, 43, 47, 78);
            // 
            // ShipmentPlanRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 720);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShipmentPlanRegister";
            this.Text = "ShipmentPlanRegister";
            this.WindowName = "ShipmentPlanRegister";
            ((System.ComponentModel.ISupportInitialize)(this._pnHeader)).EndInit();
            this._pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pnContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pnRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CORE.BaseControls.ucFromToDateEdit ucFromToDateEdit1;
    }
}