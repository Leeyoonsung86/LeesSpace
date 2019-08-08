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
    public partial class ucDateEdit_Year_Month : UserControl
    {
        public event EventHandler ValueChanged;
        
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

        public new Font Font
        {
            get
            {
                return _pDateEdit.Properties.Appearance.Font;
            }
            set
            {
                _pDateEdit.Properties.Appearance.Font = value;
                _pDateEdit.Properties.AppearanceDropDown.Font = value;

            }
        }

        public ucDateEdit_Year_Month()
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
                _pDateEdit.EditValueChanged += new EventHandler(_pLookUpEdit_EditValueChanged);
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

        #region LookUpEdit 선택 Value 변경시 처리하기 - _pLookUpEdit_EditValueChanged(object pSender, EventArgs pEventArgs)

        /// <summary>
        /// LookUpEdit 선택 Value 변경시 처리하기
        /// </summary>
        /// <param name="pSender">이벤트 발생자</param>
        /// <param name="pEventArgs">이벤트 인자</param>
        private void _pLookUpEdit_EditValueChanged(object pSender, EventArgs pEventArgs)
        {
            try
            {
                if (ValueChanged != null)
                {
                    ValueChanged(this, EventArgs.Empty);
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "_pLookUpEdit_EditValueChanged(object pSender, EventArgs pEventArgs)",
                    pException
                );
            }
        }

        #endregion
    }
}
