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
    public partial class ucLookUpEdit : UserControl
    {
        #region Event

        /// <summary>
        /// 값 변경시 이벤트
        /// </summary>
        public event EventHandler ValueChanged;
        public event EventHandler ValueChanging;

        #endregion


        public bool ReadOnly
        {
            get
            {
                return _pLookUpEdit.Properties.ReadOnly;
            }
            set
            {
                _pLookUpEdit.Properties.ReadOnly = value;
            }
        }

        public int ItemIndex
        {
            get
            {
                return _pLookUpEdit.ItemIndex;
            }
            set
            {
                _pLookUpEdit.ItemIndex = value;
            }
        }

        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Properties
        {
            get
            {
                return _pLookUpEdit.Properties;
            }
        }

        public new Font Font
        {
            get
            {
                return _pLookUpEdit.Properties.Appearance.Font;
            }
            set
            {
                _pLookUpEdit.Properties.Appearance.Font = value;
                _pLookUpEdit.Properties.AppearanceDropDown.Font = value;

            }
        }

        //public  Font DropDownFont
        //{
        //    get
        //    {
        //        return _pLookUpEdit.Properties.AppearanceDropDown.Font;
        //    }
        //    set
        //    {
        //        _pLookUpEdit.Properties.AppearanceDropDown.Font = value;

        //    }
        //}

        public new Color ForeColor
        {
            get
            {
                return _pLookUpEdit.Properties.Appearance.ForeColor;
            }
            set
            {
                _pLookUpEdit.Properties.Appearance.ForeColor = value;

            }
        }

        #region 생성자 - ucLookUpEdit()

        /// <summary>
        /// 생성자
        /// </summary>
        public ucLookUpEdit()
        {
            InitializeComponent();
            Initialize();

           // this.Size = new Size(150, 20);
        }
        #endregion
        //bool resizing;

        //protected override void OnResize(EventArgs e)
        //{
        //    if (!resizing)
        //    {
        //        resizing = true;
        //        try
        //        {
        //            this.Size = new Size(150, 20);
        //        }
        //        finally
        //        {
        //            resizing = false;
        //        }
        //    }
        //    else
        //        base.OnResize(e);
        //}


        #region 초기화 하기 - Initialize()

        /// <summary>
        /// 초기화 하기
        /// </summary>
        protected virtual void Initialize()
        {
            try
            {
                _pLookUpEdit.Properties.AutoHeight = false;

                _pLookUpEdit.Properties.BestFitMode = BestFitMode.BestFitResizePopup; //드롭다운리스트 넓이 설정
                _pLookUpEdit.Properties.ShowHeader = false; // 헤더 표시 유무
                _pLookUpEdit.Properties.ShowFooter = false; // 푸터 표시 유무
                _pLookUpEdit.Properties.NullText = ""; // 널 값 캡션 표시

                         //_pComboBoxEdit.SelectedIndexChanged += new EventHandler(_pComboBoxEdit_SelectedIndexChanged);
                _pLookUpEdit.EditValueChanged += new EventHandler(_pLookUpEdit_EditValueChanged);
                _pLookUpEdit.EditValueChanging += new ChangingEventHandler(_pLookUpEdit_EditValueChanging);
       

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

        #region LookUpEdit 선택 Value 변경시 처리하깅ing -
        /// <summary>
        /// LookUpEdit 선택 Value 변경시 처리하깅ing
        /// </summary>
        /// <param name="pSender"></param>
        /// <param name="pEventArgs"></param>
        private void _pLookUpEdit_EditValueChanging(object pSender, EventArgs pEventArgs)
        {
            try
            {
                if (ValueChanging != null)
                {
                    ValueChanging(this, EventArgs.Empty);
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
                    "_pLookUpEdit_EditValueChanging(object pSender, EventArgs pEventArgs)",
                    pException
                );
            }
        }
        #endregion

        #region 값 추가하기 - AddValue(DataTable dt, int iRowCount, int iItemIndex, string strInitCaption)

        /// <summary>
        /// 값 추가하기
        /// </summary>
        /// <param name="dtList">데이터 리스트</param>
        /// <param name="iRowCount">표시 줄수</param>
        public void AddValue(DataTable dtList, int iRowCount, int iItemIndex, string strInitCaption)
        {
            try
            {
                if (dtList != null)
                {
                   
                    _pLookUpEdit.Properties.DataSource = dtList;
                    _pLookUpEdit.Properties.ValueMember = "CD";
                    _pLookUpEdit.Properties.DisplayMember = "CD_NM";
                    _pLookUpEdit.Properties.PopulateColumns();
                    _pLookUpEdit.Properties.ForceInitialize();
                    if(_pLookUpEdit.Properties.Columns.Count != 0)
                        _pLookUpEdit.Properties.Columns[0].Visible = false;
                    _pLookUpEdit.Properties.DropDownRows = iRowCount == 0 ? dtList.Rows.Count : iRowCount;

                    //if (iItemIndex > -1)
                    //{
                        if (_pLookUpEdit.Properties.ReadOnly)
                        {
                            _pLookUpEdit.Properties.ReadOnly = false;

                            _pLookUpEdit.ItemIndex = iItemIndex;

                            _pLookUpEdit.Properties.ReadOnly = true;
                        }
                        else
                        {
                            _pLookUpEdit.ItemIndex = iItemIndex;
                        }
                         //_pLookUpEdit.Properties.GetDataSourceRowIndex("CD", null);
                    //}
                }

                _pLookUpEdit.Properties.NullText = strInitCaption;
               

            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "AddValue(DataTable dt, int iRowCount, int iItemIndex, string strInitCaption)",
                    pException
                );
            }
        }

        public void AddValue(DataTable dtList, int iRowCount, int iItemIndex, string strInitCaption, bool isALL)
        {
            try
            {
                if (dtList != null)
                {
                    _pLookUpEdit.Properties.ForceInitialize();

                    if (isALL)
                    {
                        DataRow row;

                        row = dtList.NewRow();
                        row["CD"] = "";
                        row["CD_NM"] = "ALL";
                        dtList.Rows.InsertAt(row, 0);
                    }
                   // dtList.DefaultView.Sort = "CD ASC";
                  

                    _pLookUpEdit.Properties.DataSource = dtList;
                    _pLookUpEdit.Properties.ValueMember = "CD";
                    _pLookUpEdit.Properties.DisplayMember = "CD_NM";
                    _pLookUpEdit.Properties.PopulateColumns();
                    _pLookUpEdit.Properties.Columns[0].Visible = false;

                    _pLookUpEdit.Properties.DropDownRows = iRowCount == 0 ? dtList.Rows.Count : iRowCount;

                    if (_pLookUpEdit.Properties.ReadOnly)
                    {
                        _pLookUpEdit.Properties.ReadOnly = false;

                        _pLookUpEdit.ItemIndex = iItemIndex;

                        _pLookUpEdit.Properties.ReadOnly = true;
                    }
                    else
                    {
                        _pLookUpEdit.ItemIndex = iItemIndex;
                    }

                    //if (iItemIndex > -1)
                    //{
                    //    _pLookUpEdit.ItemIndex = iItemIndex; //_pLookUpEdit.Properties.GetDataSourceRowIndex("CD", null);
                    //}
                }

                _pLookUpEdit.Properties.NullText = strInitCaption;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "AddValue(DataTable dt, int iRowCount, int iItemIndex, string strInitCaption)",
                    pException
                );
            }
        }
        #endregion

        #region 값 구하기 - GetValue()

        /// <summary>
        /// 값 구하기
        /// </summary>
        /// <returns>값</returns>
        public string GetValue()
        {
            try
            {
                if (_pLookUpEdit.EditValue == null)
                {
                    return string.Empty;
                }
                else
                {
                    return _pLookUpEdit.EditValue.ToString();
                }
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetValue()",
                    pException
                );
            }
        }

        public string GetDisplayName()
        {
           // string displayText = lookUpEdit1.Properties.GetDisplayText(lookUpEdit1.EditValue)

            try
            {
                if (_pLookUpEdit.EditValue == null)
                {
                    return string.Empty;
                }
                else
                {
                    //return _pLookUpEdit.Properties.GetDisplayText(strEditValue);
                    return _pLookUpEdit.Properties.GetDisplayText(_pLookUpEdit.EditValue);
                }
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetDisplayName()",
                    pException
                );
            }

        }

        //displayName으로 Value 구하기
        public void SetValueByDisplayName(string strValue)
        {
            try
            {
                if (strValue == "")
                {
                    _pLookUpEdit.EditValue = null;

                }
                else
                {
                    object key= _pLookUpEdit.Properties.GetKeyValueByDisplayText(strValue);
                    _pLookUpEdit.EditValue = key;
                    //_pLookUpEdit.EditValue = strValue; // _pLookUpEdit.Properties.GetKeyValueByDisplayText(strValue);
                }
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "SetValue()",
                    pException
                );
            }
        }
        #endregion    

        public void SetValue(string strValue)
        {
            try
            {
                if (strValue == "")
                {
                    _pLookUpEdit.EditValue = null;
                    
                }
                else
                {
                    _pLookUpEdit.EditValue = strValue; // _pLookUpEdit.Properties.GetKeyValueByDisplayText(strValue);
                }
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "SetValue()",
                    pException
                );
            }
        }

        public new string Text
        {
            get
            {
                return _pLookUpEdit.Text.ToString();
            }
            set
            {
                _pLookUpEdit.Text = value;
            }
        }
    }
}
