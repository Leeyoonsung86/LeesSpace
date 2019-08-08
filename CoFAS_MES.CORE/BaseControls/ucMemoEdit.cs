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

namespace CoFAS_MES.CORE.BaseControls
{
    public partial class ucMemoEdit : UserControl
    {
        public event OnKeyPressEventHandler _OnKeyPress;
        public delegate void OnKeyPressEventHandler(object sender, KeyPressEventArgs e);

        public event EventHandler _OnTextChanged;
        public delegate void TextChangedEventHandler(object pSender, EventArgs pEventArgs);

        public bool ReadOnly
        {
            get
            {
                return _pMemoEdit.Properties.ReadOnly;
            }
            set
            {
                _pMemoEdit.Properties.ReadOnly = value;
            }
        }

        public new string Text
        {
            get
            {
                return _pMemoEdit.Text;
            }
            set
            {
                _pMemoEdit.Text = value;
            }

        }


        public ucMemoEdit()
        {
            InitializeComponent();
            Initialize();

            _pMemoEdit.KeyPress += new KeyPressEventHandler(_pTextEdit_KeyPress);
            _pMemoEdit.TextChanged += new EventHandler(_pTextEdit_TextChanged);
        }

        private void _pTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_OnKeyPress != null)
                _OnKeyPress(this, e);
        }
        private void _pTextEdit_TextChanged(object pSender, EventArgs pEventArgs)
        {
            if (_OnTextChanged != null)
                _OnTextChanged(this, pEventArgs);
        }

        #region 초기화 하기 - Initialize()

        /// <summary>
        /// 초기화 하기
        /// </summary>
        protected virtual void Initialize()
        {
            try
            {

                _pMemoEdit.Properties.AutoHeight = false;
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
        #endregion

    }
}
