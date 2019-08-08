namespace CoFAS_MES.POP
{
    partial class frmPOPResult
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Good = new System.Windows.Forms.Label();
            this.Bad = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Bad_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).BeginInit();
            this._pnSINGLE_MAIN.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnSINGLE_MAIN
            // 
            this._pnSINGLE_MAIN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pnSINGLE_MAIN.Appearance.BorderColor = System.Drawing.Color.Silver;
            this._pnSINGLE_MAIN.Appearance.Options.UseBackColor = true;
            this._pnSINGLE_MAIN.Appearance.Options.UseBorderColor = true;
            this._pnSINGLE_MAIN.Controls.Add(this.tableLayoutPanel4);
            this._pnSINGLE_MAIN.Size = new System.Drawing.Size(650, 410);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.Good, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.Bad, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.simpleButton1, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.simpleButton2, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.Bad_name, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(650, 410);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.tableLayoutPanel4.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "製品名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel4.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 80);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 120F);
            this.label3.Location = new System.Drawing.Point(3, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 113);
            this.label3.TabIndex = 2;
            this.label3.Text = "良品";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Good
            // 
            this.Good.AutoSize = true;
            this.Good.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Good.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Good.Font = new System.Drawing.Font("Tahoma", 120F);
            this.Good.ForeColor = System.Drawing.Color.Lime;
            this.Good.Location = new System.Drawing.Point(328, 145);
            this.Good.Name = "Good";
            this.Good.Size = new System.Drawing.Size(319, 113);
            this.Good.TabIndex = 4;
            this.Good.Text = "0";
            this.Good.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Good.Click += new System.EventHandler(this.Good_Click);
            // 
            // Bad
            // 
            this.Bad.AutoSize = true;
            this.Bad.BackColor = System.Drawing.Color.DarkRed;
            this.Bad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bad.Font = new System.Drawing.Font("Tahoma", 120F);
            this.Bad.ForeColor = System.Drawing.Color.Red;
            this.Bad.Location = new System.Drawing.Point(328, 258);
            this.Bad.Name = "Bad";
            this.Bad.Size = new System.Drawing.Size(319, 113);
            this.Bad.TabIndex = 5;
            this.Bad.Text = "0";
            this.Bad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bad.Click += new System.EventHandler(this.Bad_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Meiryo UI", 35F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(328, 374);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(319, 33);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "保存";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Meiryo UI", 35F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton2.Location = new System.Drawing.Point(3, 374);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(319, 33);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "キャンセル";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Bad_name
            // 
            this.Bad_name.AutoSize = true;
            this.Bad_name.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Bad_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bad_name.Font = new System.Drawing.Font("Meiryo UI", 120F);
            this.Bad_name.Location = new System.Drawing.Point(3, 258);
            this.Bad_name.Name = "Bad_name";
            this.Bad_name.Size = new System.Drawing.Size(319, 113);
            this.Bad_name.TabIndex = 8;
            this.Bad_name.Text = "不良";
            this.Bad_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPOPResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Child_Page_Setting_Visible = true;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Name = "frmPOPResult";
            this.Text = "frmPOPResult";
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Good;
        private System.Windows.Forms.Label Bad;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label Bad_name;
    }
}