
namespace CoFAS_MES.POP
{
    partial class frmImageView_buma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageView_buma));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._PictureEdit = new CoFAS_MES.CORE.BaseControls.ucPictureEdit();
            this.Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.pictureName = new System.Windows.Forms.Label();
            this.Part_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this._pnSINGLE_MAIN.Size = new System.Drawing.Size(800, 560);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.42105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.42105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel1.Controls.Add(this._PictureEdit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cancel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Part_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _PictureEdit
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._PictureEdit, 3);
            this._PictureEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._PictureEdit.Image = ((System.Drawing.Image)(resources.GetObject("_PictureEdit.Image")));
            this._PictureEdit.Location = new System.Drawing.Point(0, 39);
            this._PictureEdit.Margin = new System.Windows.Forms.Padding(0);
            this._PictureEdit.Name = "_PictureEdit";
            this._PictureEdit.Size = new System.Drawing.Size(800, 476);
            this._PictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this._PictureEdit.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Appearance.Options.UseFont = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Cancel, 3);
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel.Location = new System.Drawing.Point(3, 518);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(794, 39);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "닫기";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // pictureName
            // 
            this.pictureName.AutoSize = true;
            this.pictureName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureName.Font = new System.Drawing.Font("Tahoma", 8F);
            this.pictureName.Location = new System.Drawing.Point(697, 0);
            this.pictureName.Name = "pictureName";
            this.pictureName.Size = new System.Drawing.Size(100, 39);
            this.pictureName.TabIndex = 2;
            this.pictureName.Text = "image_name";
            this.pictureName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Part_name
            // 
            this.Part_name.AutoSize = true;
            this.Part_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Part_name.Font = new System.Drawing.Font("Tahoma", 35F);
            this.Part_name.Location = new System.Drawing.Point(350, 0);
            this.Part_name.Name = "Part_name";
            this.Part_name.Size = new System.Drawing.Size(341, 39);
            this.Part_name.TabIndex = 3;
            this.Part_name.Text = "part_name";
            this.Part_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 35F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "품목명 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmImageView_buma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "frmImageView_buma";
            this.Text = "frmImageView";
            ((System.ComponentModel.ISupportInitialize)(this._pnSINGLE_MAIN)).EndInit();
            this._pnSINGLE_MAIN.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CORE.BaseControls.ucPictureEdit _PictureEdit;
        private DevExpress.XtraEditors.SimpleButton Cancel;
        private System.Windows.Forms.Label pictureName;
        private System.Windows.Forms.Label Part_name;
        private System.Windows.Forms.Label label1;
    }
}