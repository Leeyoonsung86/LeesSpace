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
    public partial class ucDateEdit_Year : UserControl
    {
        public bool ReadOnly
        {
            get
            {
                return _pDateEdit.Properties.ReadOnly;
            }
            set
            {
                _pDateEdit.Properties.ReadOnly = value;
            }
        }
        public DateTime DateTime
        {
            get
            {
                return _pDateEdit.DateTime;
            }
            set
            {
                _pDateEdit.DateTime = value;
            }
        }

        public ucDateEdit_Year()
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
                _pDateEdit.Properties.AutoHeight = false;

                _pDateEdit.DateTime = DateTime.Now;
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
