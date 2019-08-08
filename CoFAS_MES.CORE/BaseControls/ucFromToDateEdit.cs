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
    public partial class ucFromToDateEdit : UserControl
    {
        public DateTime FromDateTime
        {
            get
            {
                return _pFromDateEdit.DateTime;
            }
            set
            {
                _pFromDateEdit.DateTime = value;
            }
        }

        public DateTime ToDateTime
        {
            get
            {
                return _pToDateEdit.DateTime;
            }
            set
            {
                _pToDateEdit.DateTime = new DateTime(value.Year, value.Month, value.Day, 23, 59, 59); // value;
            }
        }

        public ucFromToDateEdit()
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
                DateTime dCalcDate = DateTime.Now;

                _pFromDateEdit.Properties.AutoHeight = false;
                _pToDateEdit.Properties.AutoHeight = false;

                _pFromDateEdit.DateTime = new DateTime(dCalcDate.Year, dCalcDate.Month, 1);
                _pToDateEdit.DateTime = new DateTime(dCalcDate.Year, dCalcDate.Month, dCalcDate.Day, 23, 59, 59);
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

        public void FromDateTimeSetting(int iDay)
        {
            _pFromDateEdit.DateTime = DateTime.Now.AddDays(iDay);
        }
    }
}
