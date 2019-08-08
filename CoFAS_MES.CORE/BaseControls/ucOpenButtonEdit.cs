using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoFAS_MES.CORE.Function;

using DevExpress.XtraEditors.Controls;

namespace CoFAS_MES.CORE.BaseControls
{
    public partial class ucOpenButtonEdit : UserControl
    {
        public event OnOpenClickEventHandler _OnOpenClick;
        public delegate void OnOpenClickEventHandler(object sender, EventArgs e);

        public event OnDownloadClickEventHandler _OnDownloadClick;
        public delegate void OnDownloadClickEventHandler(object sender, EventArgs e);

        public event OnDeleteClickEventHandler _OnDeleteClick;
        public delegate void OnDeleteClickEventHandler(object sender, EventArgs e);

        public TextEditStyles TextEditStyles
        {
            get
            {
                return _pOpenButtonEdit.Properties.TextEditStyle;
            }
            set
            {
                _pOpenButtonEdit.Properties.TextEditStyle = value;
            }
        }

        public bool ReadOnly
        {
            get
            {
                return _pOpenButtonEdit.Properties.ReadOnly;
            }
            set
            {
                _pOpenButtonEdit.Properties.ReadOnly = value;
            }
        }

        public new string Text
        {
            get
            {
                return _pOpenButtonEdit.Text;
            }
            set
            {
                _pOpenButtonEdit.Text = value;
            }
        }

        public ucOpenButtonEdit()
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
                _pOpenButtonEdit.Properties.AutoHeight = false;

                _pOpenButtonEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                _pOpenButtonEdit.Properties.Buttons[0].Click += ucOpen_Click;
                _pOpenButtonEdit.Properties.Buttons[1].Click += ucDownload_Click;
                _pOpenButtonEdit.Properties.Buttons[2].Click += ucDelete_Click;
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

        private void ucDelete_Click(object sender, EventArgs e)
        {
            if (_OnDeleteClick != null)
                _OnDeleteClick(this, e);
        }
        #endregion
    }
}
