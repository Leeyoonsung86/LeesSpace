using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.Utils;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;

using CoFAS_MES.CORE.UserForm;

using CoFAS_MES.UI.IM.Business;
using CoFAS_MES.UI.IM.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace CoFAS_MES.UI.IM.View
{
    public partial class RuleOptionSetting : frmBaseSingle
    {
        public static string com_code = null;

        private string _pUSER_GRANT = string.Empty; // 사용자 권한

        private RuleOptionSettingEntity _pRuleOptionSettingEntity; // 엔티티 생성

        private DataTable _dtList = null; //조회 데이터 리스트

        public RuleOptionSetting()
        {
            InitializeComponent();

            _pRuleOptionSettingEntity = new RuleOptionSettingEntity();

            CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

            _gdMAIN_VIEW.OptionsBehavior.Editable = false;
            _gdMAIN_VIEW.OptionsBehavior.EditorShowMode = EditorShowMode.Default;

            _gdMAIN_VIEW.OptionsBehavior.ReadOnly = true; // 강제 ReadOnly true

            _gdMAIN_VIEW.OptionsCustomization.AllowColumnMoving = false;
            _gdMAIN_VIEW.OptionsCustomization.AllowColumnResizing = false;
            _gdMAIN_VIEW.OptionsCustomization.AllowFilter = false;
            _gdMAIN_VIEW.OptionsCustomization.AllowSort = false;

            _gdMAIN_VIEW.OptionsMenu.EnableColumnMenu = false;

            _gdMAIN_VIEW.OptionsSelection.MultiSelect = false;

            _gdMAIN_VIEW.RowCellClick += _gdMAIN_VIEW_RowCellClick;
            
            MainFind_DisplayData();

            //DisplayMessage("조회 되었습니다.");
        }

        // 추가 이벤트 생성
        #region ○ 메인 그리드 로우 선택 이벤트 생성 - _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        private void _gdMAIN_VIEW_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;

                CoFAS_ControlManager.Controls_Binding(gv, false, this);

                string strRULE_OPTION = gv.GetFocusedRowCellValue("RULE_OPTION").ToString();
                string strRULE_VALUE = gv.GetFocusedRowCellValue("RULE_VALUE").ToString();

                RuleGenerator.ruleOption = strRULE_OPTION;
                RuleGenerator.ruleValue = strRULE_VALUE;
                
                Close();
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
        }

        #endregion

        // DB 처리
        #region ○ 메인조회 - MainFind_DisplayData()

        private void MainFind_DisplayData()
        {
            try
            {
                    CoFAS_DevExpressManager.SetCursor(this, Cursors.WaitCursor);

                    _pRuleOptionSettingEntity.COMPONENT = com_code;

                    _dtList = new RuleOptionSettingBusiness().RuleOptionSetting_Info(_pRuleOptionSettingEntity);

                    if (_dtList != null && _dtList.Rows.Count > 0)
                    {
                        CoFAS_DevExpressManager.BindGridControl(_gdMAIN, _gdMAIN_VIEW, _dtList); //데이터 필드에 맞춰 자동 바인딩
                    }
            }
            catch (ExceptionManager pExceptionManager)
            {
                CoFAS_DevExpressManager.ShowErrorMessage(string.Format("{0}\n{1}", pExceptionManager.Exception.Message.ToString(), pExceptionManager.TargetSite.ToString()));
            }
            finally
            {
                //_gdMAIN_VIEW.BestFitColumns();

                CoFAS_DevExpressManager.SetCursor(this, Cursors.Default);
            }
        }

        #endregion
    }
}
