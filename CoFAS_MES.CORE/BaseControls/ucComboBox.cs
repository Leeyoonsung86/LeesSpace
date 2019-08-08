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
    public partial class ucComboBox : UserControl
    {
        public bool ReadOnly
        {
            get
            {
                return _pComboBoxEdit.Properties.ReadOnly;
            }
            set
            {
                _pComboBoxEdit.Properties.ReadOnly = value;
            }
        }

        /* 
         * 작성자 : 김형석
         * 날짜 : 2018-10-19
         * "콤보박스 내용 수정 불가 및 선택은 가능" 목적으로 추가하였습니다.
        */ 
        public void DisableTextEditor()
        {
            _pComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        public int SelectedIndex
        {
            get
            {
                return _pComboBoxEdit.SelectedIndex;
            }
            set
            {
                _pComboBoxEdit.SelectedIndex = value;
            }
        }

        public object SelectedItem
        {
            get
            {
                return _pComboBoxEdit.SelectedItem;
            }
            set
            {
                _pComboBoxEdit.SelectedItem = value;
            }
        }

        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Properties
        {
            get
            {
                return _pComboBoxEdit.Properties;
            }
        }

        public new Font Font
        {
            get
            {
                return _pComboBoxEdit.Properties.Appearance.Font;
            }
            set
            {
                _pComboBoxEdit.Properties.Appearance.Font = value;

            }
        }

        public new Color ForeColor
        {
            get
            {
                return _pComboBoxEdit.Properties.Appearance.ForeColor;
            }
            set
            {
                _pComboBoxEdit.Properties.Appearance.ForeColor = value;

            }
        }

        //public List<T> Items
        //{
        //    get
        //    {
        //        return _pComboBoxEdit.Properties.Items;
        //    }
        //    set
        //    {
        //        _pComboBoxEdit.Properties.Items = value;
        //    }
        //}




        public ucComboBox()
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
                _pComboBoxEdit.Properties.AutoHeight = false;
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

        public void ItemAdd(string strAddItem)
        {
            _pComboBoxEdit.Properties.Items.Add(strAddItem);
        }

        public void ItemClear()
        {
            _pComboBoxEdit.Properties.Items.Clear();
        }

        #endregion
    }
}
