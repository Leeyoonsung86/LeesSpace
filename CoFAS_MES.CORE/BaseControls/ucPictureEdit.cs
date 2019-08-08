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
    public partial class ucPictureEdit : UserControl
    {

        public Image Image
        {
            get
            {
                return _pPictureEdit.Image;
            }
            set
            {
                if (value == null)
                {
                    _pPictureEdit.Image = Properties.Resources.None;
                }
                else
                {
                    _pPictureEdit.Image = value;
                }
            }
        }

        public PictureSizeMode SizeMode
        {
            get
            {
                return _pPictureEdit.Properties.SizeMode;
            }
            set
            {
                _pPictureEdit.Properties.SizeMode = value;
            }
        }

        public new int Width
        {
            get
            {
                return _pPictureEdit.Width;
            }
            set
            {
                _pPictureEdit.Width = value;
            }
        }

        public new int Height
        {
            get
            {
                return _pPictureEdit.Height;
            }
            set
            {
                _pPictureEdit.Height = value;
            }
        }

        public ucPictureEdit()
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
                _pPictureEdit.Properties.AutoHeight = false;

                _pPictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
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

        public void initImage()
        {
            _pPictureEdit.Image = Properties.Resources.None;
        }
    }
}
