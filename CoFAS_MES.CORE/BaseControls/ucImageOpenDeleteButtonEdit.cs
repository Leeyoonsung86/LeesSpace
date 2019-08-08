using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using CoFAS_MES.CORE.Function;

namespace CoFAS_MES.CORE.BaseControls
{
    public partial class ucImageOpenDeleteButtonEdit : UserControl
    {
        public event OnOpenClickEventHandler _OnOpenClick;
        public delegate void OnOpenClickEventHandler(object sender, EventArgs e);

        public event OnDownloadClickEventHandler _OnDownloadClick;
        public delegate void OnDownloadClickEventHandler(object sender, EventArgs e);

        public event OnViewClickEventHandler _OnViewClick;
        public delegate void OnViewClickEventHandler(object sender, EventArgs e);

        public event OnDeleteClickEventHandler _OnDeleteClick;
        public delegate void OnDeleteClickEventHandler(object sender, EventArgs e);
        public TextEditStyles TextEditStyles
        {
            get
            {
                return _pImageOpenButtonEdit.Properties.TextEditStyle;
            }
            set
            {
                _pImageOpenButtonEdit.Properties.TextEditStyle = value;
            }
        }

        public bool ReadOnly
        {
            get
            {
                return _pImageOpenButtonEdit.Properties.ReadOnly;
            }
            set
            {
                _pImageOpenButtonEdit.Properties.ReadOnly = value;
            }
        }

        public bool DeleteVisible
        {
            get
            {
                return _pImageOpenButtonEdit.Properties.Buttons[3].Visible;
            }
            set
            {
                _pImageOpenButtonEdit.Properties.Buttons[3].Visible = value;
            }
        }

        public new string Text
        {
            get
            {
                return _pImageOpenButtonEdit.Text;
            }
            set
            {
                _pImageOpenButtonEdit.Text = value;
            }
        }

        public ucImageOpenDeleteButtonEdit()
        {
            InitializeComponent();
            Initialize();
        }

        #region 초기화 하기 - Initialize()

        /// <summary>
        /// 초기화 하기
        /// </summary>
        protected virtual void Initialize()
        {
            try
            {
                _pImageOpenButtonEdit.Properties.AutoHeight = false;

                _pImageOpenButtonEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                _pImageOpenButtonEdit.Properties.Buttons[0].Click += ucOpen_Click;
                _pImageOpenButtonEdit.Properties.Buttons[1].Click += ucDownload_Click;
                _pImageOpenButtonEdit.Properties.Buttons[2].Click += ucView_Click;
                _pImageOpenButtonEdit.Properties.Buttons[3].Click += ucDelete_Click;
                _pImageOpenButtonEdit.Properties.Buttons[3].Visible = false;
                //_pOpenButtonEdit.ButtonPressed           
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Initialize()",
                    pException
                );
            }
        }

        private void ucOpen_Click(object sender, EventArgs e)
        {
            if (_OnOpenClick != null)
                _OnOpenClick(this, e);
        }

        private void ucDownload_Click(object sender, EventArgs e)
        {
            if (_OnDownloadClick != null)
                _OnDownloadClick(this, e);
        }

        private void ucView_Click(object sender, EventArgs e)
        {
            if (_OnViewClick != null)
                _OnViewClick(this, e);
        }

        private void ucDelete_Click(object sender, EventArgs e)
        {
            if (_OnDeleteClick != null)
                _OnDeleteClick(this, e);
        }
        #endregion
    }
}
