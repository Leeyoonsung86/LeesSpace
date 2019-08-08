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
    public partial class ucSpinEdit : UserControl
    {
        /// <summary>
        /// 값 변경시 이벤트
        /// </summary>
        public event EventHandler ValueChanged;

        public bool ReadOnly
        {
            get
            {
                return _pSpinEdit.Properties.ReadOnly;
            }
            set
            {
                _pSpinEdit.Properties.ReadOnly = value;
            }
        }
        public DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit Properties
        {
            get
            {
                return _pSpinEdit.Properties;
            }
        }

        public new Font Font
        {
            get
            {
                return _pSpinEdit.Properties.Appearance.Font;
            }
            set
            {
                _pSpinEdit.Properties.Appearance.Font = value;
                _pSpinEdit.Properties.AppearanceDropDown.Font = value;

            }
        }

        public new Color ForeColor
        {
            get
            {
                return _pSpinEdit.Properties.Appearance.ForeColor;
            }
            set
            {
                _pSpinEdit.Properties.Appearance.ForeColor = value;

            }
        }

        public decimal Value
        {
            get
            {
                return _pSpinEdit.Value;
            }
            set
            {
                _pSpinEdit.Value = value;
            }
        }


        public ucSpinEdit()
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
                _pSpinEdit.Properties.AutoHeight = false;

                _pSpinEdit.Properties.NullText = ""; // 널 값 캡션 표시

                _pSpinEdit.Value = 0;
                
                _pSpinEdit.EditValueChanged += new EventHandler(_pSpinEdit_EditValueChanged);
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

        #region Value 변경시 처리하기 - _pSpinEdit_EditValueChanged(object pSender, EventArgs pEventArgs)

        /// <summary>
        /// LookUpEdit 선택 Value 변경시 처리하기
        /// </summary>
        /// <param name="pSender">이벤트 발생자</param>
        /// <param name="pEventArgs">이벤트 인자</param>
        private void _pSpinEdit_EditValueChanged(object pSender, EventArgs pEventArgs)
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
                    "_pSpinEdit_EditValueChanged(object pSender, EventArgs pEventArgs)",
                    pException
                );
            }
        }

        #endregion
    }
}
