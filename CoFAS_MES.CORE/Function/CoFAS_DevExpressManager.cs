using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using DevExpress.LookAndFeel;
using DevExpress.Utils;

using DevExpress.XtraBars.Navigation;

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

using DevExpress.XtraTab;
using DevExpress.XtraTabbedMdi;


using CoFAS_MES.CORE.Business;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Drawing;
using System.Runtime.InteropServices;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Tile;

namespace CoFAS_MES.CORE.Function
{
    public class CoFAS_DevExpressManager
    {

        #region Delegate

        /// <summary>
        /// 컨트롤 포커스 설정하기 델리게이트
        /// </summary>
        /// <param name="pControl">컨트롤</param>
        private delegate void FocusControlDelegate(System.Windows.Forms.Control pControl);

        /// <summary>
        /// 컨트롤 활성화 하기 델리게이트
        /// </summary>
        /// <param name="pForm">폼</param>
        /// <param name="bEnabled">활성화 여부</param>
        /// <param name="pControls">컨트롤 목록</param>
        private delegate void EnableControlDelegate(Form pForm, bool bEnabled, params System.Windows.Forms.Control[] pControls);

        /// <summary>
        /// 컨트롤 추가하기
        /// </summary>
        /// <param name="pParentControl">부모 컨트롤</param>
        /// <param name="pChildControl">자식 컨트롤</param>
        private delegate void AddControlDelegate(System.Windows.Forms.Control pParentControl, System.Windows.Forms.Control pChildControl);

        /// <summary>
        /// 커서 설정하기 델리게이트
        /// </summary>
        /// <param name="pControl">컨트롤</param>
        /// <param name="pCursor">커서</param>
        protected delegate void SetCursorDelegate(System.Windows.Forms.Control pControl, Cursor pCursor);

        /// <summary>
        /// 뷰 영역으로 컨트롤 스크롤 하기
        /// </summary>
        /// <param name="pFlowLayoutPanel">FlowLayoutPanel</param>
        /// <param name="pControl">Control</param>
        protected delegate void ScrollControlIntoViewDeletage(FlowLayoutPanel pFlowLayoutPanel, System.Windows.Forms.Control pControl);



        /// <summary>
        /// 탭 제목 설정하기 델리게이트
        /// </summary>
        /// <param name="pXtraTabControl">엑스트라 탭 컨트롤</param>
        /// <param name="nTabPageIndex">탭 페이지 인덱스</param>
        /// <param name="strCaption">제목</param>
        private delegate void SetTabCaptionDelegate(XtraTabControl pXtraTabControl, int nTabPageIndex, string strCaption);

        /// <summary>
        /// 탭 제목 설정하기 델리게이트 2
        /// </summary>
        /// <param name="pXtraTabControl">엑스트라 탭 컨트롤</param>
        /// <param name="nTabPageIndex">탭 페이지 인덱스</param>
        /// <param name="strDefaultTitle">디폴트 제목</param>
        /// <param name="nCount">건수</param>
        private delegate void SetTabCaptionDelegate2(XtraTabControl pXtraTabControl, int nTabPageIndex, string strDefaultTitle, int nCount);

        /// <summary>
        /// 텍스트 설정하기 델리게이트 1
        /// </summary>
        /// <param name="pControl">컨트롤</param>
        /// <param name="strText">텍스트</param>
        private delegate void SetTextDelegate1(System.Windows.Forms.Control pControl, string strText);

        /// <summary>
        /// 텍스트 설정하기 델리게이트 2
        /// </summary>
        /// <param name="pControl">컨트롤</param>
        /// <param name="strDefaultText">디폴트 텍스트</param>
        /// <param name="nCount">건수</param>
        private delegate void SetTextDelegate2(System.Windows.Forms.Control pControl, string strDefaultText, int nCount);

        /// <summary>
        /// 그리드 컨트롤 바인드 하기 델리게이트
        /// </summary>
        /// <param name="pGridControl">그리드 컨트롤</param>
        /// <param name="pGridView">그리드 뷰</param>
        /// <param name="pDataSource">데이타 소스</param>
        private delegate void BindGridControlDelegate(GridControl pGridControl, GridView pGridView, object pDataSource);

        #endregion

        private static string _pCORP_CODE;
        public static string pCORP_CODE
        {
            set
            {
                _pCORP_CODE = value;
            }
        }

        #region 생성자 - CoFAS_DevExpressManager()

        /// <summary>
        /// 생성자
        /// </summary>
        private CoFAS_DevExpressManager()
        {
        }

        #endregion


        #region 컨트롤 포커스 설정하기 - FocusControl(pControl)

        /// <summary>
        /// 컨트롤 포커스 설정하기
        /// </summary>
        /// <param name="pControl">컨트롤</param>
        public static void FocusControl(System.Windows.Forms.Control pControl)
        {
            try
            {
                if (pControl.InvokeRequired)
                {
                    FocusControlDelegate pFocusControlDelegate = new FocusControlDelegate(FocusControl);

                    pControl.Invoke(pFocusControlDelegate, pControl);
                }
                else
                {
                    pControl.Focus();
                }
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "FocusControl(pControl)",
                    pException
                );
            }
        }

        #endregion

        #region 컨트롤 활성화 하기 - EnableControl(pForm, bEnabled, pControls)

        /// <summary>
        /// 컨트롤 활성화 하기
        /// </summary>
        /// <param name="pForm">폼</param>
        /// <param name="bEnabled">활성화 여부</param>
        /// <param name="pControls">컨트롤 목록</param>
        public static void EnableControl(Form pForm, bool bEnabled, params System.Windows.Forms.Control[] pControls)
        {
            if (pForm.InvokeRequired)
            {
                EnableControlDelegate pEnableControlDelegate = new EnableControlDelegate(EnableControl);

                pForm.Invoke(pEnableControlDelegate, pForm, bEnabled, pControls);
            }
            else
            {
                foreach (System.Windows.Forms.Control pControl in pControls)
                {
                    pControl.Enabled = bEnabled;
                }
            }
        }

        #endregion

        #region 컨트롤 추가하기 - AddControl(pParentControl, pChildControl)

        /// <summary>
        /// 컨트롤 추가하기
        /// </summary>
        /// <param name="pParentControl">부모 컨트롤</param>
        /// <param name="pChildControl">자식 컨트롤</param>
        public static void AddControl(System.Windows.Forms.Control pParentControl, System.Windows.Forms.Control pChildControl)
        {
            try
            {
                if (pParentControl.InvokeRequired)
                {
                    AddControlDelegate pAddControlDelegate = new AddControlDelegate(AddControl);

                    pParentControl.Invoke(pAddControlDelegate, pParentControl, pChildControl);
                }
                else
                {
                    pParentControl.Controls.Add(pChildControl);
                }
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "FocusControl(pControl)",
                    pException
                );
            }
        }

        #endregion

        #region 커서 설정하기 - SetCursor(pControl, pCursor)

        /// <summary>
        /// 커서 설정하기
        /// </summary>
        public static void SetCursor(System.Windows.Forms.Control pControl, Cursor pCursor)
        {
            try
            {
                if (pControl.InvokeRequired)
                {
                    SetCursorDelegate pSetCursorDelegate = new SetCursorDelegate(SetCursor);

                    pControl.Invoke(pSetCursorDelegate, pControl, pCursor);
                }
                else
                {
                     pControl.Cursor = pCursor;
                }
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "SetCursor(pControl, pCursor)",
                    pException
                );
            }
        }

        #endregion

        //////////////////////////////////////////////////////////// Skin

        #region 디폴트 룩앤필 구하기 - GetDefaultLookAndFeel(pContainer, strSkinName)

        /// <summary>
        /// 디폴트 룩앤필 구하기
        /// </summary>
        /// <param name="pContainer">컨테이너</param>
        /// <param name="strSkinName">스킨명</param>
        /// <returns>디폴트 룩앤필</returns>
        public static DefaultLookAndFeel GetDefaultLookAndFeel(IContainer pContainer, string strSkinName)
        {
            DefaultLookAndFeel pDefaultLookAndFeel = null;

            try
            {
                pDefaultLookAndFeel = new DefaultLookAndFeel(pContainer);

                pDefaultLookAndFeel.LookAndFeel.SkinName = strSkinName;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GetDefaultLookAndFeel(pContainer, strSkinName)",
                    pException
                );
            }

            return pDefaultLookAndFeel;
        }

        #endregion

        //////////////////////////////////////////////////////////// Menu Strip


        #region 도구 스트립 메뉴 항목 구하기 - GetToolStripMenuItem(strName, strText)

        /// <summary>
        /// 도구 스트립 메뉴 항목 구하기
        /// </summary>
        /// <param name="strName">명칭</param>
        /// <param name="strText">텍스트</param>
        /// <returns>도구 스트립 메뉴 항목</returns>
        public static ToolStripMenuItem GetToolStripMenuItem(string strName, string strText)
        {
            ToolStripMenuItem pToolStripMenuItem = null;

            try
            {
                pToolStripMenuItem = new ToolStripMenuItem();

                pToolStripMenuItem.Name = strName;
                pToolStripMenuItem.Text = strText;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GetToolStripMenuItem(strName, strText)",
                    pException
                );
            }

            return pToolStripMenuItem;
        }

        #endregion

        //////////////////////////////////////////////////////////// XtraTabControl

        #region 탭 제목 설정하기 - SetTabCaption(pXtraTabControl, nTabPageIndex, strCaption)

        /// <summary>
        /// 탭 제목 설정하기
        /// </summary>
        /// <param name="pXtraTabControl">엑스트라 탭 컨트롤</param>
        /// <param name="nTabPageIndex">탭 페이지 인덱스</param>
        /// <param name="strCaption">제목</param>
        public static void SetTabCaption(XtraTabControl pXtraTabControl, int nTabPageIndex, string strCaption)
        {
            try
            {
                if (pXtraTabControl.InvokeRequired)
                {
                    SetTabCaptionDelegate pSetTabCaptionDelegate = new SetTabCaptionDelegate(SetTabCaption);

                    pXtraTabControl.Invoke(pSetTabCaptionDelegate, pXtraTabControl, nTabPageIndex, strCaption);
                }
                else
                {
                    pXtraTabControl.TabPages[nTabPageIndex].Text = strCaption;
                }
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "SetTabCaption(pXtraTabControl, nTabPageIndex, strCaption)",
                    pException
                );
            }
        }

        #endregion

        #region 탭 제목 설정하기 - SetTabCaption(pXtraTabControl, nTabPageIndex, strDefaultTitle, nCount)

        /// <summary>
        /// 탭 제목 설정하기
        /// </summary>
        /// <param name="pXtraTabControl">엑스트라 탭 컨트롤</param>
        /// <param name="nTabPageIndex">탭 페이지 인덱스</param>
        /// <param name="strDefaultTitle">디폴트 제목</param>
        /// <param name="nCount">건수</param>
        public static void SetTabCaption(XtraTabControl pXtraTabControl, int nTabPageIndex, string strDefaultTitle, int nCount)
        {
            try
            {
                if (pXtraTabControl.InvokeRequired)
                {
                    SetTabCaptionDelegate2 pShowListCountDelegate = new SetTabCaptionDelegate2(SetTabCaption);

                    pXtraTabControl.Invoke(pShowListCountDelegate, pXtraTabControl, nTabPageIndex, strDefaultTitle, nCount);
                }
                else
                {
                    if (nCount > 0)
                    {
                        pXtraTabControl.TabPages[nTabPageIndex].Text = string.Format
                        (
                            "{0} ({1}건)",
                            strDefaultTitle,
                            nCount.ToString("#,##0")
                        );
                    }
                    else
                    {
                        pXtraTabControl.TabPages[nTabPageIndex].Text = strDefaultTitle;
                    }
                }
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "SetTabCaption(pXtraTabControl, nTabPageIndex, strDefaultTitle, nCount)",
                    pException
                );
            }
        }

        #endregion

        //////////////////////////////////////////////////////////// Navigation Control

        #region 초기화 시작하기 - BeginInitialize(AccordionControl pAccordionControl)

        /// <summary>
        /// 초기화 시작하기
        /// </summary>
        /// <param name="pAccordionControl">네비게이션 아카디언 컨트롤</param>
        public static void BeginInitialize(AccordionControl pAccordionControl)
        {
            try
            {
                ((ISupportInitialize)pAccordionControl).BeginInit();
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "BeginInitialize(AccordionControl pAccordionControl)",
                    pException
                );
            }
        }

        #endregion

        #region 초기화 종료하기 - EndInitialize(AccordionControl pAccordionControl)

        /// <summary>
        /// 초기화 종료하기
        /// </summary>
        /// <param name="pAccordionControl">네비게이션 아카디언 컨트롤</param>
        public static void EndInitialize(AccordionControl pAccordionControl)
        {
            try
            {
                ((ISupportInitialize)pAccordionControl).EndInit();
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "EndInitialize(AccordionControl pAccordionControl)",
                    pException
                );
            }
        }

        #endregion

        #region 데이타 지우기 - ClearData(AccordionControl pAccordionControl)

        /// <summary>
        /// 데이타 지우기
        /// </summary>
        /// <param name="pAccordionControl">네비게이션 아카디언 컨트롤</param>
        public static void ClearData(AccordionControl pAccordionControl)
        {
            try
            {
                AccordionControlElementCollection pAccordionControlElementCollection = pAccordionControl.Elements;


                for(int i = 0; i < pAccordionControlElementCollection.Count; i++)
                {
                    pAccordionControlElementCollection[i].Elements.Clear();
                }

                pAccordionControlElementCollection.Clear();

                pAccordionControl.Elements.Clear();


                //NavGroupCollection pNavGroupCollection = pNavBarControl.Groups;

                //for (int i = 0; i < pNavGroupCollection.Count; i++)
                //{
                //    pNavGroupCollection[i].ItemLinks.Clear();
                //}

                //pNavGroupCollection.Clear();

                //pNavBarControl.Items.Clear();
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "ClearData(AccordionControl pAccordionControl)",
                    pException
                );
            }
        }

        #endregion

        #region 네비게이션 아카디언 그룹 추가하기 - AddAccordionGroup(AccordionControl pAccordionControl, string strName, string strCaption)
        public static AccordionControlElement AddAccordionGroup(AccordionControl pAccordionControl, string strName, string strCaption)
        {
            try
            {
                AccordionControlElement pAccordionControlElementGroup = new AccordionControlElement();

                pAccordionControlElementGroup.Name = strName;
                pAccordionControlElementGroup.Text = strCaption;
                pAccordionControlElementGroup.Style = ElementStyle.Group;

                pAccordionControl.Elements.Add(pAccordionControlElementGroup);

                return pAccordionControlElementGroup;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "AccordionControlElement AddAccordionItem(AccordionControl pAccordionControl, string strName, string strCaption)",
                    pException
                );
            }
        }
        #endregion

        public static AccordionControlElement AddAccordionChildGroup(AccordionControlElement pAccordionControlElement, string strName, string strCaption)
        {
            try
            {
                AccordionControlElement pAccordionControlElementChildGroup = new AccordionControlElement();

                pAccordionControlElementChildGroup.Name = strName;
                pAccordionControlElementChildGroup.Text = strCaption;
                pAccordionControlElementChildGroup.Style = ElementStyle.Group;

                pAccordionControlElement.Elements.Add(pAccordionControlElementChildGroup);

                return pAccordionControlElementChildGroup;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "AccordionControlElement AddAccordionChildGroup(AccordionControlElement pAccordionControlElement, string strName, string strCaption)",
                    pException
                );
            }
        }

        #region 네비게이션 아카디언 아이템 추가하기 - AddAccordionItem(AccordionControlElement pAccordionControlElementGroup, string strName, string strCaption)
        public static AccordionControlElement AddAccordionItem(AccordionControlElement pAccordionControlElementGroup, string strName, string strCaption)
        {
            try
            {
                AccordionControlElement pAccordionControlElementItem = new AccordionControlElement();

                pAccordionControlElementItem.Name = strName;
                pAccordionControlElementItem.Text = strCaption;
                pAccordionControlElementItem.Style = ElementStyle.Item;

                pAccordionControlElementGroup.Elements.Add(pAccordionControlElementItem);

                return pAccordionControlElementItem;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "AccordionControlElement AddAccordionItem(AccordionControl pAccordionControl, string strName, string strCaption)",
                    pException
                );
            }
        }
        #endregion

        #region 네비게이션 바 그룹 추가하기 - AddNavigationBarGroup(pNavBarControl, strName, strCaption, bExpanded)

        /// <summary>
        /// 네비게이션 바 그룹 추가하기
        /// </summary>
        /// <param name="pNavBarControl">네비게이션 바 컨트롤</param>
        /// <param name="strName">명칭</param>
        /// <param name="strCaption">제목</param>
        /// <param name="bExpanded">확장 여부</param>
        /// <returns>네비게이션 바 그룹</returns>
        //public static NavBarGroup AddNavigationBarGroup(NavBarControl pNavBarControl, string strName, string strCaption, bool bExpanded)
        //{
        //    try
        //    {
        //        NavBarGroup pNavBarGroup = new NavBarGroup();

        //        pNavBarGroup.Name = strName;
        //        pNavBarGroup.Caption = strCaption;
        //        pNavBarGroup.Expanded = bExpanded;

        //        pNavBarControl.Groups.Add(pNavBarGroup);

        //        return pNavBarGroup;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager
        //        (
        //            typeof(DevExpressManager),
        //            "AddNavigationBarGroup(pNavBarControl, strName, strCaption, bExpanded)",
        //            pException
        //        );
        //    }
        //}

        #endregion

        #region 네비게이션 바 아이템 추가하기 - AddNaviationBarItem(pNavBarControl, pNavBarGroup, strName, strCaption)

        /// <summary>
        /// 네비게이션 바 아이템 추가하기
        /// </summary>
        /// <param name="pNavBarControl">네비게이션 바 컨트롤</param>
        /// <param name="pNavBarGroup">네비게이션 바 그룹</param>
        /// <param name="strName">명칭</param>
        /// <param name="strCaption">제목</param>
        /// <returns>네비게이션 바 아이템</returns>
        //public static NavBarItem AddNaviationBarItem(NavBarControl pNavBarControl, NavBarGroup pNavBarGroup, string strName, string strCaption)
        //{
        //    try
        //    {
        //        NavBarItem pNavBarItem = new NavBarItem();

        //        pNavBarItem.Name = strName;
        //        pNavBarItem.Caption = strCaption;

        //        pNavBarControl.Items.Add(pNavBarItem);

        //        pNavBarGroup.ItemLinks.Add(pNavBarItem);

        //        return pNavBarItem;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager
        //        (
        //            typeof(DevExpressManager),
        //            "AddNaviationBarItem(pNavBarControl, pNavBarGroup, strName, strCaption)",
        //            pException
        //        );
        //    }
        //}

        #endregion


        //////////////////////////////////////////////////////////// GridControl & GridView Setting 영역
        public static event OnButtonPressedEventHandler _OnButtonPressed;
        public delegate void OnButtonPressedEventHandler(object sender, ButtonPressedEventArgs e);

        #region 컬럼 타입 설정 리스트
        public static void GridColumnAddButton(GridColumn pGridColumn, string strFieldCode)
        {
            try
            {
                RepositoryItemButtonEdit pColumnType = new RepositoryItemButtonEdit();
                //옵션
                pColumnType.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

                pColumnType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;

                pColumnType.Buttons[0].Kind = ButtonPredefines.Glyph;
                pColumnType.Buttons[0].ImageOptions.Image = Properties.Resources.zoom_16x16;

                pColumnType.Buttons[0].Caption = strFieldCode;

                pColumnType.ButtonPressed += new ButtonPressedEventHandler(pColumnType_ButtonPressed);

                pGridColumn.ColumnEdit = pColumnType;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GridColumnAddButton(GridControl pGridControl, GridView pGridView, GridColumn pGridColumn)",
                    pException
                );
            }

        }

        private static void pColumnType_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (_OnButtonPressed != null)
                _OnButtonPressed(sender, e);
        }

        public static void GridColumnAddLookUpEdit(GridColumn pGridColumn, string pParameterData, string strLanguage)
        {
            try
            {
                RepositoryItemLookUpEdit pColumnType = new RepositoryItemLookUpEdit();

             

                string[] strParameterData = new string[pParameterData.Count(f => f == ';')];

                if (pParameterData.IndexOf(';') != -1)
                {
                    strParameterData = pParameterData.Split(';');

                    DataTable dtComboBox = new CommonCodeReturnBusiness().CommonCode_Return("R", strLanguage, strParameterData[0].ToString(), strParameterData[1].ToString(), strParameterData[2].ToString(), strParameterData[3].ToString()).Tables[0];

                    if (dtComboBox != null)
                    {
                        pColumnType.DataSource = dtComboBox;
                        pColumnType.ValueMember = "CD";
                        pColumnType.DisplayMember = "CD_NM";

                        pColumnType.PopulateColumns();
                        //pColumnType.Columns["CD"].Visible = false;

                        //pColumnType.Columns.Count();

                        for(int a = 0; a < pColumnType.Columns.Count(); a++ )
                        {
                            if(pColumnType.Columns[a].FieldName != "CD_NM")
                            {
                                pColumnType.Columns[a].Visible = false;
                            }
                        }

                        /*

                        if (pColumnType.Columns["CD_TP"] != null)
                        {
                            pColumnType.Columns["CD_TP"].Visible = false;

                        }
                        if (pColumnType.Columns["CD_VALUE1"] != null)
                        {
                            pColumnType.Columns["CD_VALUE1"].Visible = false;

                        }
                        if (pColumnType.Columns["CD_VALUE2"] != null)
                        {
                            pColumnType.Columns["CD_VALUE2"].Visible = false;

                        }
                        if (pColumnType.Columns["CD_VALUE3"] != null)
                        {
                            pColumnType.Columns["CD_VALUE3"].Visible = false;

                        }
                        */

                        pColumnType.BestFitMode = BestFitMode.BestFitResizePopup;
                        pColumnType.ShowHeader = false;
                        //pColumnType.SearchMode = SearchMode.AutoFilter;
                        pColumnType.ShowFooter = false;
                        if (strParameterData[2].ToString() != "")
                        {
                            pColumnType.DropDownRows = Convert.ToInt32(strParameterData[2].ToString());
                        }
                        else
                        {
                            pColumnType.DropDownRows = dtComboBox.Rows.Count;
                        }
                    }

                }

                pColumnType.NullText = "";
                //pColumnType.AllowNullInput = DefaultBoolean.True;
                pGridColumn.ColumnEdit = pColumnType;
                //if(pGridColumn.View.Columns.Count != 0)
                //pGridColumn.View.Columns[0].Visible = false;
                
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GridColumnAddLookUpEdit(GridColumn pGridColumn, string pParameterData)",
                    pException
                );
            }

        }

        public static void GridColumnAddCheckEdit(GridColumn pGridColumn)
        {
            try
            {
                RepositoryItemCheckEdit pColumnType = new RepositoryItemCheckEdit();

                pColumnType.NullStyle = StyleIndeterminate.Unchecked;
                pColumnType.ValueChecked = "Y";
                pColumnType.ValueUnchecked = "N";
                pColumnType.ValueGrayed = "";
                pGridColumn.ColumnEdit = pColumnType;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GridColumnAddCheckEdit(GridColumn pGridColumn)",
                    pException
                );
            }

        }

        public static void GridColumnAddTextEdit(GridColumn pGridColumn, int iMaxLength)
        {
            try
            {
                RepositoryItemTextEdit pColumnType = new RepositoryItemTextEdit();
                //옵션

                pColumnType.MaxLength = iMaxLength;

                pColumnType.KeyDown += TextEdit_KeyDown;

                pGridColumn.ColumnEdit = pColumnType;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GridColumnAddTextEdit(GridColumn pGridColumn)",
                    pException
                );
            }

        }

        public static void GridColumnAddOpenButtonEdit(GridColumn pGridColumn, string strFieldCode)
        {
            try
            {
                RepositoryItemButtonEdit pColumnType = new RepositoryItemButtonEdit();

                DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();

                //옵션
                pColumnType.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

                pColumnType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});


                pColumnType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

                pColumnType.Buttons[0].Kind = ButtonPredefines.Glyph;
                pColumnType.Buttons[0].ImageOptions.Image = Properties.Resources.article_16x161;

                pColumnType.Buttons[0].Caption = strFieldCode;

                pColumnType.Buttons[1].Kind = ButtonPredefines.Glyph;
                pColumnType.Buttons[1].ImageOptions.Image = Properties.Resources.saveto_16x16;

                pColumnType.Buttons[1].Caption = strFieldCode;

                pColumnType.Buttons[2].Kind = ButtonPredefines.Glyph;
                pColumnType.Buttons[2].ImageOptions.Image = Properties.Resources.trash_16x16;

                pColumnType.Buttons[2].Caption = strFieldCode;


                //pColumnType.ButtonPressed += new ButtonPressedEventHandler(pColumnType_ButtonPressed);


                pColumnType.ButtonPressed += new ButtonPressedEventHandler(ucGOpenButton_Click);


                pGridColumn.ColumnEdit = pColumnType;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GridColumnAddOpenButtonEdit(GridColumn pGridColumn)",
                    pException
                );
            }
        }

        public static event OnOpenButtonEventHandler _OnOpenButton;
        public delegate void OnOpenButtonEventHandler(object sender, ButtonPressedEventArgs e);
        //ButtonPressedEventArgs
        private static void ucGOpenButton_Click(object sender, ButtonPressedEventArgs e)
        {
            if (_OnOpenButton != null)
                _OnOpenButton(sender, e);
        }

        public static void GridColumnAddImageOpenButtonEdit(GridColumn pGridColumn, string strFieldCode)
        {
            try
            {
                RepositoryItemButtonEdit pColumnType = new RepositoryItemButtonEdit();

                DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();

                //옵션
                pColumnType.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

                pColumnType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
                
                //pColumnType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles


                pColumnType.Buttons[0].Kind = ButtonPredefines.Glyph;
                pColumnType.Buttons[0].ImageOptions.Image = Properties.Resources.article_16x161;

                pColumnType.Buttons[0].Caption = strFieldCode;

                pColumnType.Buttons[1].Kind = ButtonPredefines.Glyph;
                pColumnType.Buttons[1].ImageOptions.Image = Properties.Resources.saveto_16x16;

                pColumnType.Buttons[1].Caption = strFieldCode;

                pColumnType.Buttons[2].Kind = ButtonPredefines.Glyph;
                pColumnType.Buttons[2].ImageOptions.Image = Properties.Resources.image_16x16;

                pColumnType.Buttons[2].Caption = strFieldCode;

                pColumnType.Buttons[3].Kind = ButtonPredefines.Glyph;
                pColumnType.Buttons[3].ImageOptions.Image = Properties.Resources.trash_16x16;

                pColumnType.Buttons[3].Caption = strFieldCode;

               

                pColumnType.ButtonPressed += new ButtonPressedEventHandler(ucGImageOpenButton_Click);
                
                pGridColumn.ColumnEdit = pColumnType;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GridColumnAddOpenButtonEdit(GridColumn pGridColumn)",
                    pException
                );
            }
        }

        private static void ucGImageOpenButton_Click(object sender, ButtonPressedEventArgs e)
        {
            if (_OnOpenButton != null)
                _OnOpenButton(sender, e);
        }

        private static void TextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            //TextEdit txEdit = sender as TextEdit;

            //if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.LButton || e.KeyCode == Keys.RButton)
            //{
                //txEdit.Text = txEdit.Text.ToUpper();
            //}
        }

        public static void GridColumnAddDateEdit(GridColumn pGridColumn)
        {
            try
            {
                RepositoryItemDateEdit pColumnType = new RepositoryItemDateEdit();
                //옵션

                // pColumnType.AutoHeight = false;
                // pColumnType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                // pColumnType.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                // pColumnType.Name = "repositoryItemDateEdit";

                //pColumnType.CalendarTimeEditing = DefaultBoolean.False;

                //pColumnType.EditFormat.FormatType = FormatType.DateTime;
                //pColumnType.EditFormat.FormatString = "yyyy-MM-dd";

                //pColumnType.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                //pColumnType.Mask.EditMask = "yyyy-MM-dd";
                //pColumnType.Mask.UseMaskAsDisplayFormat = true;


                //pColumnType.CalendarDateTimeFormatInfo.ShortDatePattern = CoFAS_ConvertManager.enDateType.Date.ToString();
                //pColumnType.ParseEditValue += edit_ParseEditValue;
                //pColumnType.Mask.EditMask = "d";
                //pColumnType.Mask.UseMaskAsDisplayFormat = true;
                //pColumnType.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;

                //pColumnType.DisplayFormat.FormatType = FormatType.DateTime;
                //pColumnType.DisplayFormat.FormatString = "yyyy-MM-dd";
                pColumnType.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                pColumnType.Mask.EditMask = "\\d\\d\\d\\d-\\d\\d-\\d\\d";
                pColumnType.Mask.UseMaskAsDisplayFormat = true;


                //pColumnType.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                //pColumnType.DisplayFormat.FormatString = "yyyy-MM-dd";
                //pColumnType.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                //pColumnType.Mask.EditMask = "yyyy-MM-dd";
                //pColumnType.Mask.UseMaskAsDisplayFormat = true;

                // pColumnType.ReadOnly = false;

                pGridColumn.ColumnEdit = pColumnType;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GridColumnAddDateEdit(GridColumn pGridColumn)",
                    pException
                );
            }
        }
        
        public static void GridColumnAddSpinEdit(GridColumn pGridColumn) // , int iMinValue, int iMaxValue)
        {
            try
            {
              //   RepositoryItemDateEdit

                RepositoryItemSpinEdit pColumnType = new RepositoryItemSpinEdit();

                pColumnType.MinValue = 0;
                

                pGridColumn.ColumnEdit = pColumnType;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GridColumnAddSpinEdit(GridColumn pGridColumn)",
                    pException
                );
            }

        }

        private static void edit_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
    {
        if (sender is DateEdit)
        {
            e.Value = CoFAS_ConvertManager.String2Date(sender.ToString(), CoFAS_ConvertManager.enDateType.Date);//Convert.ToDateTime(ConvertToDateTimeType((string)gridView1.GetFocusedRowCellValue("B")));
            e.Handled = true;
        }
    }

    //string ConvertToDateTimeType(string value)
    //{
    //    string year = value.Substring(0, 4);
    //    string month = value.Substring(4, 2);
    //    string day = value.Substring(6, 2);
    //    return year + '-' + month + '-' + day;
    //}


    #endregion

    public static GridView GetGridSetting(DataSet dsGridSetting, Font hFONT, Font rFONT, string strLANGUAGE)
        {
            try
            {
                //GridControl _targetGrid = new GridControl();
                GridView _targetGridView = new GridView();

                //그리드 및 뷰 속성 설정
                if (dsGridSetting != null && dsGridSetting.Tables.Count == 2 && dsGridSetting.Tables[0].Rows.Count > 0 && dsGridSetting.Tables[1].Rows.Count > 0)
                {
                    CoFAS_DevExpressManager.SetGridView(_targetGridView, dsGridSetting.Tables[0].Rows[0]["GRIDVIEW_NAME"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["EDIT_ABLE"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["EDITOR_SHOWMODE"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["READ_ONLY"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["ALLOW_COLUMN_MOVING"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["ALLOW_COLUMN_RESIZING"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["ALLOW_FILTER"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["ALLOW_SORT"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["ENABLE_COLUMN_MENU"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["MULTI_SELECT"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["GRIDMULTI_SELECTMODE"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["SHOWCHECKBOXSELECTOR_INCOLUMNHEADER"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["COLUMN_AUTOWIDTH"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["ENABLE_APPEARANCE_EVENROW"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["ENABLE_APPEARANCE_ODDROW"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["SHOW_GROUPPANEL"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["SHOW_INDICATOR"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["SHOW_AUTOFILTERROW"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["SHOW_FOOTER"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["GRID_NEWITEMROWPOSITION"].ToString(),
                                                                         dsGridSetting.Tables[0].Rows[0]["GRID_NEWITEMROWNAME"].ToString(),
                                                                         hFONT,
                                                                         rFONT
                                                          );
                    //그리드 컬럼 네임 값 , 화면 표시 명칭 , DB 연결 필드 값 , 필드 타입 , 필드 사이즈 , 필드 정렬 , 필드 수정 유무 , 필드 포커스 유무, 필드 포멧 타입, 포멧 형식, 확장메뉴 사용 유무, 보여주기 수량, 필드 숨김 유무
                    //데이터 만큼 반복
                    foreach (DataRow drColumn in dsGridSetting.Tables[1].Rows)
                    {
                        CoFAS_DevExpressManager.AddGridColumn(_targetGridView, CoFAS_DevExpressManager.GetGridColumn(drColumn["COLUMN_NAME"].ToString(),
                                                                                                                     //strLANGUAGE == "한국어" ? drColumn["COLUMN_CAPTION"].ToString() : drColumn["COLUMN_CAPTION2"].ToString(), 
                                                                                                                     drColumn["COLUMN_CAPTION"].ToString(),
                                                                                                                     drColumn["COLUMN_CAPTION_COLOR"].ToString(),
                                                                                                                     drColumn["COLUMN_FIELD_NAME"].ToString(), 
                                                                                                                     Convert.ToInt32(drColumn["COLUMN_SIZE"].ToString()),
                                                                                                                     drColumn["COLUMN_TYPE"].ToString(),
                                                                                                                     Convert.ToInt32(drColumn["TEXT_SIZE"].ToString()),
                                                                                                                     drColumn["PARAMETER_DATA"].ToString(),
                                                                                                                     drColumn["UNBOUND_COLUMNTYPE"].ToString(), 
                                                                                                                     drColumn["HORZ_ALIGNMENT"].ToString(), 
                                                                                                                     drColumn["ALLOW_EDIT"].ToString(), 
                                                                                                                     drColumn["ALLOW_FOCUS"].ToString(),
                                                                                                                     drColumn["ALLOW_MERGE"].ToString(),
                                                                                                                     drColumn["FORMAT_TYPE"].ToString(), 
                                                                                                                     drColumn["FORMAT_STRING"].ToString(), 
                                                                                                                     drColumn["SHOWUNBOUND_EXPRESSIONMENU"].ToString(),
                                                                                                                     Convert.ToInt32(drColumn["VISIBLE_INDEX"].ToString()), 
                                                                                                                     drColumn["VISIBLE"].ToString(),
                                                                                                                     strLANGUAGE)
                                                                                                                     );
                    }
                }

                return _targetGridView;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GetGridSetting(DataSet dsGridSetting)",
                    pException
                );
            }
        }

        //////////////////////////////////////////////////////////// GridControl

        #region 그리드 컨트롤 설정하기 - SetGridControl(GridControl pGridControl, string strName, bool bAllowDrop)

        /// <summary>
        /// 그리드 컨트롤 설정하기
        /// </summary>
        /// <param name="pGridControl">GridControl</param>
        /// <param name="strName">명칭</param>
        /// <param name="bAllowDrop">Drag & Drop 기능 유무</param>
        /// <returns>그리드 컨트롤</returns>
        public static void SetGridControl(GridControl pGridControl, string strName, bool bAllowDrop)
        {
            try
            {
                //pGridControl.Name = strName;
                //pGridControl.UseEmbeddedNavigator = true;
                pGridControl.AllowDrop = bAllowDrop; // 그리드 컨트롤러 항상 Drag & Drop 기능 활성화 유무

            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "SetGridControl(GridControl pGridControl, string strName, bool bAllowDrop)",
                    pException
                );
            }
        }

        #endregion

        #region 그리드 컨트롤 구하기 - GetGridControl(strName)

        /// <summary>
        /// 그리드 컨트롤 구하기
        /// </summary>
        /// <param name="strName">명칭</param>
        /// <param name="bAllowDrop">Drop 기능 유무</param>
        /// <returns>그리드 컨트롤</returns>
        public static GridControl GetGridControl(string strName, bool bAllowDrop)
        {
            try
            {
                GridControl pGridControl = new GridControl();

                pGridControl.Name = strName;
                pGridControl.AllowDrop = bAllowDrop; // 그리드 컨트롤러 항상 DROP 기능 활성화 유무

                return pGridControl;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GetGridControl(strName)",
                    pException
                );
            }
        }

        #endregion

        #region 초기화 시작하기 - BeginInitialize_Grid(pGridControl)

        /// <summary>
        /// 초기화 시작하기
        /// </summary>
        /// <param name="pGridControl">그리드 컨트롤</param>
        public static void BeginInitialize_Grid(GridControl pGridControl)
        {
            try
            {
                ((ISupportInitialize)pGridControl).BeginInit();
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "BeginInitialize_Grid(pGridControl)",
                    pException
                );
            }
        }

        #endregion

        #region 초기화 종료하기 - EndInitialize(pGridControl)

        /// <summary>
        /// 초기화 종료하기
        /// </summary>
        /// <param name="pGridControl">그리드 컨트롤</param>
        public static void EndInitialize_Grid(GridControl pGridControl)
        {
            try
            {
                ((ISupportInitialize)pGridControl).EndInit();
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "EndInitialize_Grid(pGridControl)",
                    pException
                );
            }
        }

        #endregion

        #region 뷰 추가하기 - AddView(pGridControl, pBaseView, bMainView) --컨트롤 동적 생성시 사용???

        /// <summary>
        /// 뷰 추가하기 //컨트롤 동적 생성시 사용?
        /// </summary>
        /// <param name="pGridControl">그리드 컨트롤</param>
        /// <param name="pBaseView">기본 뷰</param>
        /// <param name="bMainView">메인 뷰 여부</param>
        public static void AddView(GridControl pGridControl, BaseView pBaseView, bool bMainView)
        {
            try
            {
                pGridControl.ViewCollection.Add(pBaseView);

                if (bMainView)
                {
                    pGridControl.MainView = pBaseView;
                }

                pBaseView.GridControl = pGridControl;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "AddView(pGridControl, pBaseView, bMainView)",
                    pException
                );
            }
        }

        #endregion

        #region 그리드 컨트롤 바인드 하기 - BindGridControl(pGridControl, pGridView, pDataSource)

        /// <summary>
        /// 그리드 컨트롤 바인드 하기
        /// </summary>
        /// <param name="pGridControl">그리드 컨트롤</param>
        /// <param name="pGridView">그리드 뷰</param>
        /// <param name="pDataSource">데이타 소스</param>
        public static void BindGridControl(GridControl pGridControl, GridView pGridView, object pDataSource)
        {
            try
            {
                if (pGridControl.InvokeRequired)
                {
                    BindGridControlDelegate pBindGridControlDelegate = new BindGridControlDelegate(BindGridControl);

                    pGridControl.Invoke(pBindGridControlDelegate, pGridControl, pGridView, pDataSource);
                }
                else
                {
                    pGridControl.DataSource = pDataSource;

                    try
                    {
                        pGridView.FocusedRowHandle = 0;
                    }
                    catch
                    {
                    }
                }
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "BindGridControl(GridControl pGridControl, GridView pGridView, object pDataSource)",
                    pException
                );
            }
        }

        public static void BindGridControl(GridControl pGridControl, TileView pTileView, object pDataSource)
        {
            try
            {
                if (pGridControl.InvokeRequired)
                {
                    BindGridControlDelegate pBindGridControlDelegate = new BindGridControlDelegate(BindGridControl);

                    pGridControl.Invoke(pBindGridControlDelegate, pGridControl, pTileView, pDataSource);
                }
                else
                {
                    pGridControl.DataSource = pDataSource;

                    try
                    {
                        pTileView.FocusedRowHandle = 0;
                    }
                    catch
                    {
                    }
                }
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "BindGridControl(GridControl pGridControl, GridView pGridView, object pDataSource)",
                    pException
                );
            }
        }

        #endregion

        //////////////////////////////////////////////////////////// GridView

        #region 그리드 뷰 설정하기 - SetGridView(pGridView, string strName, bool bEditable, bool bReadOnly, bool bAllowColumnMoving, bool bAllowColumnResizing, bool bAllowFilter, bool bAllowSort, bool bEnableColumnMenu,  bool bMultiSelect, GridMultiSelectMode pGridMultiSelectMode, bool bColumnAutoWidth, bool bEnableAppearanceEvenRow, bool bEnableAppearanceOddRow, bool bShowGroupPanel, bool bShowIndicator, bool bShowAutoFilterRow,  NewItemRowPosition pGridNewItemRowPosition)

        /// <summary>
        /// 그리드 뷰 설정하기
        /// </summary>
        /// <param name="pGridView">GridView</param>
        /// <param name="strName">명칭</param>
        /// <param name="strEditable">편집 가능 여부</param>
        /// <param name="strEditorShowMode">편집 선택 모드</param>
        /// <param name="strReadOnly">읽기 전용 여부</param>
        /// <param name="strAllowColumnMoving"></param>
        /// <param name="strAllowColumnResizing"></param>
        /// <param name="strAllowFilter"></param>
        /// <param name="strAllowSort"></param>
        /// <param name="strEnableColumnMenu"></param>
        /// <param name="strMultiSelect">복수 선택 여부</param>
        /// <param name="strGridMultiSelectMode">그리드 복수 선택 모드</param>
        /// <param name="strShowCheckBoxSelectorInColumnHeader">해더 체크박스 표시 유무</param>
        /// <param name="strColumnAutoWidth"></param>
        /// <param name="strEnableAppearanceEvenRow"></param>
        /// <param name="strEnableAppearanceOddRow"></param>
        /// <param name="strShowGroupPanel">그룹 패널 표시 여부</param>
        /// <param name="strShowIndicator">지시자 표시 여부</param>
        /// <param name="strShowAutoFilterRow"></param>
        /// <param name="strShowFooter">푸터 정보 표시</param>
        /// <param name="strGridNewItemRowPosition"></param>
        /// <param name="strGridNewItemRowName"></param>
        public static void SetGridView
        (
         GridView pGridView,
         string strName,
         string strEditable,
         string strEditorShowMode, //EditorShowMode pEditorShowMode
         string strReadOnly,
         string strAllowColumnMoving,
         string strAllowColumnResizing,
         string strAllowFilter,
         string strAllowSort,
         string strEnableColumnMenu,
         string strMultiSelect,
         string strGridMultiSelectMode, //GridMultiSelectMode pGridMultiSelectMode,
         string strShowCheckBoxSelectorInColumnHeader,
         string strColumnAutoWidth,
         string strEnableAppearanceEvenRow,
         string strEnableAppearanceOddRow,
         string strShowGroupPanel,
         string strShowIndicator,
         string strShowAutoFilterRow,
         string strShowFooter,
         string strGridNewItemRowPosition, // NewItemRowPosition pGridNewItemRowPosition,
         string strGridNewItemRowName,
         Font hFont, Font rFont
        )
        {
            try
            {
                //pGridView.Name = strName;
                //pGridView.OptionsView.EnableAppearanceEvenRow = strEnableAppearanceEvenRow == "Y" ? true : false; // 그리드 뷰 짝수 줄 색상 변경 유무
                pGridView.OptionsView.EnableAppearanceOddRow = true;// strEnableAppearanceOddRow == "Y" ? true : false; // 그리드 뷰 홀수 줄 색상 변경 유무

                pGridView.Appearance.OddRow.BackColor = Color.LightSteelBlue; // 그리드 뷰 홀수 줄 색상
                //pGridView.Appearance.EvenRow.BackColor = Color.BlueViolet; // 그리드 뷰 짝수 줄 색상

                pGridView.OptionsSelection.EnableAppearanceFocusedCell = true;
                pGridView.OptionsSelection.EnableAppearanceFocusedRow = true;

                // pGridView.Appearance.SelectedRow.BackColor = Color.YellowGreen; // 그리드 뷰 선택 로우 색상

          

                pGridView.Appearance.FocusedRow.BackColor = Color.YellowGreen;
              //  pGridView.Appearance.HideSelectionRow.BackColor = Color.YellowGreen;

              //  pGridView.Appearance.SelectedRow.Options.UseBackColor = true; // 그리드 뷰 선택 로우 색상 유무


                pGridView.Appearance.HeaderPanel.Font = hFont; // 그리드 뷰 헤더 데이터 패널 폰트
                pGridView.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap;

                pGridView.Appearance.Row.Font = rFont; // 그리드 뷰 로우 데이터 폰트
                pGridView.Appearance.SelectedRow.Font = rFont;

                pGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple; // 그리드 뷰 보더스타일 변경

                pGridView.OptionsBehavior.Editable = strEditable == "Y" ? true : false; // 그리드 뷰 셀 데이터 수정 가능 유무


                switch (strEditorShowMode) // 그리드 뷰 입력 모드
                {
                    case "1":
                        pGridView.OptionsBehavior.EditorShowMode = EditorShowMode.Default;
                        break;
                    case "2":
                        pGridView.OptionsBehavior.EditorShowMode = EditorShowMode.Click;
                        break;
                    case "3":
                        pGridView.OptionsBehavior.EditorShowMode = EditorShowMode.MouseDown;
                        break;
                    case "4":
                        pGridView.OptionsBehavior.EditorShowMode = EditorShowMode.MouseDownFocused;
                        break;
                    case "5":
                        pGridView.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
                        break;
                    default:
                        pGridView.OptionsBehavior.EditorShowMode = EditorShowMode.Default;
                        break;


                }


                pGridView.OptionsBehavior.ReadOnly = strReadOnly == "Y" ? true : false; // 그리드 뷰 데이터 읽기 전용 유무


                pGridView.OptionsCustomization.AllowColumnMoving = strAllowColumnMoving == "Y" ? true : false;
                pGridView.OptionsCustomization.AllowColumnResizing = strAllowColumnResizing == "Y" ? true : false;
                pGridView.OptionsCustomization.AllowFilter = strAllowFilter == "Y" ? true : false;
                pGridView.OptionsCustomization.AllowSort = strAllowSort == "Y" ? true : false;

                pGridView.OptionsMenu.EnableColumnMenu = strEnableColumnMenu == "Y" ? true : false;

                pGridView.OptionsSelection.MultiSelect = strMultiSelect == "Y" ? true : false; // 그리드 뷰 다중 선택 유무

                

                switch (strGridMultiSelectMode) // pGridMultiSelectMode // 그리드 뷰 다중 선택 방식 선택
                {
                    case "1":
                        pGridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;  
                        break;
                    case "2":
                        pGridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
                        pGridView.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
                        pGridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = strShowCheckBoxSelectorInColumnHeader == "Y" ? DefaultBoolean.True : DefaultBoolean.False;
                        break;
                    case "3":
                        pGridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
                        break;
                    default:
                        pGridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
                        break;
                }

                pGridView.OptionsView.ColumnAutoWidth = strColumnAutoWidth == "Y" ? true : false; // 그리드 뷰 컬럼 사이즈 조정 자동 유무

               // pGridView.OptionsView.ColumnHeaderAutoHeight = DefaultBoolean.True;

                //pGridView.OptionsView.EnableAppearanceEvenRow = strEnableAppearanceEvenRow == "Y" ? true : false; // 그리드 뷰 짝수 줄 색상 변경 유무
                //pGridView.OptionsView.EnableAppearanceOddRow = strEnableAppearanceOddRow == "Y" ? true : false; // 그리드 뷰 홀수 줄 색상 변경 유무
                pGridView.OptionsView.ShowGroupPanel = strShowGroupPanel == "Y" ? true : false; // 그리드 뷰 그룹패널 표시 유무
                pGridView.OptionsView.ShowIndicator = strShowIndicator == "Y" ? true : false; // 지시자 표시 여부
                pGridView.OptionsView.ShowAutoFilterRow = strShowAutoFilterRow == "Y" ? true : false; // 그리드 뷰 TOP 검색 기능 표시 유무
                pGridView.OptionsView.ShowFooter = strShowFooter == "Y" ? true : false; // 그리드 뷰 푸터 정보 표시 유무

                pGridView.OptionsView.AllowCellMerge = true; // 셀 머지 기능 기본은 전체 셀머지 컬럼별 셀머지를 위해서는 컬럼 옵션에서 개별 설정 해줌. 

               
                

                pGridView.OptionsView.RowAutoHeight = false;

                switch(strGridNewItemRowPosition) // 그리드 뷰 TOP 신규추가 로우 표시 위치
                {
                    case "1":
                        pGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                        break;
                    case "2":
                        pGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                        break;
                    case "3":
                        pGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                        break;
                    default:
                        pGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                        break;
                }


                pGridView.NewItemRowText = strGridNewItemRowName;

                pGridView.OptionsNavigation.EnterMoveNextColumn = true;

            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "SetGridView(pGridView, string strName, bool bEditable, bool bReadOnly, bool bAllowColumnMoving, bool bAllowColumnResizing, bool bAllowFilter, bool bAllowSort, bool bEnableColumnMenu,  bool bMultiSelect, GridMultiSelectMode pGridMultiSelectMode, bool bColumnAutoWidth, bool bEnableAppearanceEvenRow, bool bEnableAppearanceOddRow, bool bShowGroupPanel, bool bShowIndicator, bool bShowAutoFilterRow, NewItemRowPosition pGridNewItemRowPosition)",
                    pException
                );
            }
        }

        #endregion

        #region 그리드 뷰 구하기 - GetGridView(string strName, bool bEditable, bool bReadOnly, bool bAllowColumnMoving, bool bAllowColumnResizing, bool bAllowFilter, bool bAllowSort, bool bEnableColumnMenu,  bool bMultiSelect, GridMultiSelectMode pGridMultiSelectMode, bool bColumnAutoWidth, bool bEnableAppearanceEvenRow, bool bEnableAppearanceOddRow, bool bShowGroupPanel, bool bShowIndicator, bool bShowAutoFilterRow, NewItemRowPosition pGridNewItemRowPosition)

        /// <summary>
        /// 그리드 뷰 구하기
        /// </summary>
        /// <param name="strName">명칭</param>
        /// <param name="bEditable">편집 가능 여부</param>
        /// <param name="bReadOnly">읽기 전용 여부</param>
        /// <param name="bAllowColumnMoving"></param>
        /// <param name="bAllowColumnResizing"></param>
        /// <param name="bAllowFilter"></param>
        /// <param name="bAllowSort"></param>
        /// <param name="bEnableColumnMenu"></param>
        /// <param name="bMultiSelect">복수 선택 여부</param>
        /// <param name="pGridMultiSelectMode">그리드 복수 선택 모드</param>
        /// <param name="bColumnAutoWidth"></param>
        /// <param name="bEnableAppearanceEvenRow"></param>
        /// <param name="bEnableAppearanceOddRow"></param>
        /// <param name="bShowGroupPanel">그룹 패널 표시 여부</param>
        /// <param name="bShowIndicator">지시자 표시 여부</param>
        /// <param name="bShowAutoFilterRow">컬럼별 검색 기능 표시 유무</param>
        /// <param name="pGridNewItemRowPosition"></param>
        /// <returns>그리드 뷰</returns>
        public static GridView GetGridView
        (
         string strName,
         bool bEditable,
         bool bReadOnly,
         bool bAllowColumnMoving,
         bool bAllowColumnResizing,
         bool bAllowFilter,
         bool bAllowSort,
         bool bEnableColumnMenu,
         bool bMultiSelect,
         GridMultiSelectMode pGridMultiSelectMode,
         bool bColumnAutoWidth,
         bool bEnableAppearanceEvenRow,
         bool bEnableAppearanceOddRow,
         bool bShowGroupPanel,
         bool bShowIndicator,
         bool bShowAutoFilterRow,
         NewItemRowPosition pGridNewItemRowPosition
        )
        {
            try
            {
                /// 그리드 컨트롤 & 뷰 폰트 설정
                float fontSize = 9;
                string fontType = "굴림";

                Font fntHeader = new Font(fontType, fontSize, FontStyle.Bold);
                Font fntRow = new Font(fontType, fontSize);

                GridView pGridView = new GridView();

                pGridView.Name = strName;

                pGridView.Appearance.OddRow.BackColor = Color.LightSteelBlue; // 그리드 뷰 홀수 줄 색상
                pGridView.Appearance.HeaderPanel.Font = fntHeader; // 그리드 뷰 헤더 데이터 패널 폰트
                pGridView.Appearance.Row.Font = fntRow; // 그리드 뷰 로우 데이터 폰트
                pGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // 그리드 뷰 헤더 데이터 정렬 가로
                pGridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center; // 그리드 뷰 헤더  데이터 정렬 세로

                pGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple; // 그리드 뷰 보더스타일 변경

                pGridView.OptionsBehavior.Editable = bEditable; // 그리드 뷰 셀 데이터 수정 가능 유무
                pGridView.OptionsBehavior.EditorShowMode = EditorShowMode.Default; // 그리드 뷰 입력 모드
                pGridView.OptionsBehavior.ReadOnly = bReadOnly; // 그리드 뷰 데이터 읽기 전용 유무

                pGridView.OptionsCustomization.AllowColumnMoving = bAllowColumnMoving;
                pGridView.OptionsCustomization.AllowColumnResizing = bAllowColumnResizing;
                pGridView.OptionsCustomization.AllowFilter = bAllowFilter;
                pGridView.OptionsCustomization.AllowSort = bAllowSort;

                pGridView.OptionsMenu.EnableColumnMenu = bEnableColumnMenu;

                pGridView.OptionsSelection.MultiSelect = bMultiSelect; // 그리드 뷰 다중 선택 유무
                pGridView.OptionsSelection.MultiSelectMode = pGridMultiSelectMode; // 그리드 뷰 다중 선택 방식 선택

                pGridView.OptionsView.ColumnAutoWidth = bColumnAutoWidth; // 그리드 뷰 컬럼 사이즈 조정 자동 유무
                pGridView.OptionsView.EnableAppearanceEvenRow = bEnableAppearanceEvenRow; // 그리드 뷰 짝수 줄 색상 변경 유무
                pGridView.OptionsView.EnableAppearanceOddRow = bEnableAppearanceOddRow; // 그리드 뷰 홀수 줄 색상 변경 유무
                pGridView.OptionsView.ShowGroupPanel = bShowGroupPanel; // 그리드 뷰 그룹패널 표시 유무
                pGridView.OptionsView.ShowIndicator = bShowIndicator;
                pGridView.OptionsView.ShowAutoFilterRow = bShowAutoFilterRow; // 그리드 뷰 TOP 검색 기능 표시 유무

                pGridView.OptionsView.NewItemRowPosition = pGridNewItemRowPosition;

                return pGridView;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GetGridView(string strName, bool bEditable, bool bReadOnly, bool bAllowColumnMoving, bool bAllowColumnResizing, bool bAllowFilter, bool bAllowSort, bool bEnableColumnMenu,  bool bMultiSelect, GridMultiSelectMode pGridMultiSelectMode, bool bColumnAutoWidth, bool bEnableAppearanceEvenRow, bool bEnableAppearanceOddRow, bool bShowGroupPanel, bool bShowIndicator, bool bShowAutoFilterRow, NewItemRowPosition pGridNewItemRowPosition)",
                    pException
                );
            }
        }

        #endregion

        #region 초기화 시작하기 - BeginInitialize(pGridView)

        /// <summary>
        /// 초기화 시작하기
        /// </summary>
        /// <param name="pGridView">그리드 뷰</param>
        public static void BeginInitialize_Gridview(GridView pGridView)
        {
            try
            {
                ((ISupportInitialize)pGridView).BeginInit();
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "BeginInitialize_Gridview(pGridView)",
                    pException
                );
            }
        }

        #endregion

        #region 초기화 종료하기 - EndInitialize_Gridview(pGridView)

        /// <summary>
        /// 초기화 종료하기
        /// </summary>
        /// <param name="pGridView">그리드 뷰</param>
        public static void EndInitialize_Gridview(GridView pGridView)
        {
            try
            {
                ((ISupportInitialize)pGridView).EndInit();
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "EndInitialize_Gridview(pGridView)",
                    pException
                );
            }
        }

        #endregion

        #region 그리드 컬럼 추가하기 - AddGridColumn(GridView pGridView, GridColumn pGridColumn)

        /// <summary>
        /// 그리드 컬럼 추가하기
        /// </summary>
        /// <param name="pGridView">그리드 뷰</param>
        /// <param name="pGridColumn">그리드 컬럼</param>
        public static void AddGridColumn(GridView pGridView, GridColumn pGridColumn)
        {
            try
            {
                pGridView.Columns.Add(pGridColumn);
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "AddGridColumn(GridView pGridView, GridColumn pGridColumn)",
                    pException
                );
            }
        }

        #endregion

        //////////////////////////////////////////////////////////// GridColumn
        #region 그리드 컬럼 구하기 - GetGridColumn(string strName, string strCaption, string strFieldName, DevExpress.Data.UnboundColumnType pUnboundColumnType, int nWidth, DevExpress.Utils.HorzAlignment pHorzAlignment, bool bAllowEdit, bool bAllowFocus, DevExpress.Utils.FormatType pFormatType, string pFormatString, bool bShowUnboundExpressionMenu, int nVisibleIndex, bool bVisible)

        /// <summary>
        /// 그리드 컬럼 구하기
        /// </summary>
        /// <param name="strName">명칭</param>
        /// <param name="strCaption">제목</param>
        /// <param name="strFieldName">필드명</param>
        /// <param name="nWidth">너비</param>
        /// <param name="strColumnType">필드 타입</param>
        /// <param name="strParameterData">파라메터 데이터</param>
        /// <param name="strUnboundColumnType">언바운드 컬럼 종류</param>
        /// <param name="strHorzAlignment">수평 정렬</param>
        /// <param name="strAllowEdit">편집 허용 여부</param>
        /// <param name="strAllowFocus">포커스 허용 여부</param>
        /// <param name="strAllowMerge">셀 머지 허용 여부</param>
        /// <param name="strFormatType">형식 종류</param>
        /// <param name="strFormatString">형식 문자열</param>
        /// <param name="strShowUnboundExpressionMenu"> Expression Editor 메뉴 표시 유무 (마우스 오른쪽 버튼 클릭시)</param>
        /// <param name="nVisibleIndex">표시 인덱스</param>
        /// <param name="strVisible">표시 여부</param>
        /// <returns>그리드 컬럼</returns>
        public static DevExpress.XtraGrid.Columns.GridColumn GetGridColumn
        (
         string strName,
         string strCaption,
         string strCaptionColor,
         string strFieldName,
         int nWidth,
         string strColumnType,
         int nTextSize,
         string strParameterData,
         string strUnboundColumnType, //DevExpress.Data.UnboundColumnType pUnboundColumnType,
         string strHorzAlignment, //DevExpress.Utils.HorzAlignment pHorzAlignment,
         string strAllowEdit,
         string strAllowFocus,
         string strAllowMerge,
         string strFormatType, //DevExpress.Utils.FormatType pFormatType,
         string strFormatString,
         string strShowUnboundExpressionMenu,
         int nVisibleIndex,
         string strVisible,
         string strLanguage
        )
        {
            try
            {
                DevExpress.XtraGrid.Columns.GridColumn pGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();

                pGridColumn.Name = strName; // 컬럼 헤더 명칭               
                pGridColumn.Caption = strCaption; //컬럼 해더 제목
                pGridColumn.FieldName = strFieldName; // 컬럼 필드명
                

                switch (strUnboundColumnType)
                {
                    case "1":
                        pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                        break;
                    case "2":
                        pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
                        break;
                    case "3":
                        pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
                        break;
                    case "4":
                        pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                        break;
                    case "5":
                        pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
                        break;
                    case "6":
                        pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
                        break;
                    case "7":
                        pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
                        break;
                    default:
                        pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                        break;
                }
                //pGridColumn.UnboundType = pUnboundColumnType; //언바운드 컬럼 종류

                pGridColumn.Width = nWidth; //컬럼 사이즈
               
                pGridColumn.VisibleIndex = nVisibleIndex; //표시인덱스
                pGridColumn.Visible = strVisible == "Y" ? true : false;// 표시여부

                pGridColumn.AppearanceHeader.Options.UseTextOptions = true;
                pGridColumn.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center; // 그리드 뷰 컬럼 헤더 데이터 정렬 (가로)
                pGridColumn.AppearanceHeader.Options.UseForeColor = true;

                if (strCaptionColor == "Y")
                {
                    pGridColumn.AppearanceHeader.ForeColor = Color.Red;
                }

                pGridColumn.AppearanceCell.Options.UseTextOptions = true;

                switch(strHorzAlignment)
                {
                    case "1":
                        pGridColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default;
                        break;
                    case "2":
                        pGridColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near;
                        break;
                    case "3":
                        pGridColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                        break;
                    case "4":
                        pGridColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
                        break;
                    default:
                        pGridColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default;
                        break;
                }

                // AllowEdit & AllowFocus 모두 True 일경우 쓰기 모드 가능
                pGridColumn.OptionsColumn.AllowEdit = strAllowEdit == "Y" ? true : false;
                pGridColumn.OptionsColumn.AllowFocus = strAllowFocus == "Y" ? true : false;
                pGridColumn.OptionsColumn.AllowMerge = strAllowMerge == "Y" ? DefaultBoolean.True : DefaultBoolean.False;

                pGridColumn.OptionsColumn.ReadOnly = false;


                switch (strFormatType)
                {
                    case "1":
                        pGridColumn.DisplayFormat.FormatType = FormatType.None;
                        pGridColumn.DisplayFormat.FormatString = strFormatString;
                        break;
                    case "2":
                        pGridColumn.DisplayFormat.FormatType = FormatType.Custom;
                        pGridColumn.DisplayFormat.FormatString = strFormatString;
                        break;
                    case "3":
                        pGridColumn.DisplayFormat.FormatType = FormatType.DateTime;
                        pGridColumn.DisplayFormat.FormatString = "yyyy-MM-dd";
                        break;
                    case "4":
                        pGridColumn.DisplayFormat.FormatType = FormatType.Numeric;
                        pGridColumn.DisplayFormat.FormatString = strFormatString;
                        break;
                    default:
                        pGridColumn.DisplayFormat.FormatType = FormatType.None;
                        pGridColumn.DisplayFormat.FormatString = strFormatString;
                        break;
                }

                pGridColumn.ShowUnboundExpressionMenu = strShowUnboundExpressionMenu == "Y" ? true : false; //마우스 우측 버튼 메뉴 Expression Editor 메뉴 표시 유무

                switch (strColumnType)
                {
                    case "1":
                        GridColumnAddTextEdit(pGridColumn, nTextSize);
                        break;
                    case "2":
                        GridColumnAddLookUpEdit(pGridColumn, strParameterData, strLanguage);
                        break;
                    case "3":
                        GridColumnAddButton(pGridColumn, strFieldName);
                        break;
                    case "4":
                        GridColumnAddCheckEdit(pGridColumn);
                        break;
                    case "5":
                        GridColumnAddOpenButtonEdit(pGridColumn, strFieldName);
                        break;
                    case "6":
                        GridColumnAddDateEdit(pGridColumn);
                        break;
                    case "7":
                        GridColumnAddImageOpenButtonEdit(pGridColumn, strFieldName);
                        break;
                    case "8":
                        GridColumnAddSpinEdit(pGridColumn);
                        break;
                    default:
                        GridColumnAddTextEdit(pGridColumn, nTextSize);
                        break;


                }

                //pGridColumn.ColumnEdit





                return pGridColumn;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GetGridColumn(string strName, string strCaption, string strFieldName, DevExpress.Data.UnboundColumnType pUnboundColumnType, int nWidth, DevExpress.Utils.HorzAlignment pHorzAlignment, bool bAllowEdit, bool bAllowFocus, DevExpress.Utils.FormatType pFormatType, string pFormatString, bool bShowUnboundExpressionMenu, int nVisibleIndex, bool bVisible)",
                    pException
                );
            }
        }

        #endregion

        //////////////////////////////////////////////////////////// GridSetting
        #region 그리드 설정 하기 - Grid_Setting(GridControl _gd, GridView _gv, string strGD_NAME)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_gd"> 그리드 컨트롤러 </param>
        /// <param name="_gv"> 그리드 뷰 </param>
        /// <param name="_corp_code"> 회사코드 </param>
        /// <param name="_ft"> 그리드 폰트 설정 </param>
        /// <param name="_lt"> 그리드 언어 설정 </param> 
        /// <param name="_ds"> 그리드 설정 데이터 </param>
        /// <returns></returns>
        public static GridView Grid_Setting(GridControl _gd, GridView _gv, Font _ft, string _lt, DataSet _ds)  
        {
            // 메인 그리드 설정
            DataSet dsGridSetting = null;
            Font fntHeader = new Font(_ft.FontFamily, _ft.Size+2, FontStyle.Bold); 
            Font fntRow = _ft; //new Font(_ft, 10);
            // pCORP_CODE = _corp_code;
            GridControl _Grid_Control = _gd;
            GridView _Grid_View = _gv;

            dsGridSetting = _ds; //그리드 설정 데이터

            _Grid_Control.ForceInitialize();

            if (dsGridSetting != null && dsGridSetting.Tables.Count > 0 && dsGridSetting.Tables[0].Rows.Count > 0)
            {
                SetGridControl(_Grid_Control, dsGridSetting.Tables[0].Rows[0]["GRID_NAME"].ToString(), dsGridSetting.Tables[0].Rows[0]["ALLOW_DROP"].ToString() == "Y" ? true : false); //조회 데이터 기준 그리드 컨트롤러 설정

                _Grid_View = GetGridSetting(dsGridSetting, fntHeader, fntRow, _lt); // 그리드 뷰 and 컬럼 설정

                AddView(_Grid_Control, _Grid_View, true); // 그리드 컨트롤러 에 메인 뷰 설정

                _Grid_View.BestFitColumns();
            }

            new CoFAS_DevGridEventManager(_Grid_Control, "");

            return _Grid_View;
        }



        //public static GridView Grid_Setting(GridControl _gd, GridView _gv, string _corp_code, Font _ft, string _lt, DataSet _ds)   // 
        //{
        //    // 메인 그리드 설정
        //    DataSet dsGridSetting = null;
        //    Font fntHeader = new Font(_ft.FontFamily, _ft.Size + 2, FontStyle.Bold);
        //    Font fntRow = _ft; //new Font(_ft, 10);
        //    pCORP_CODE = _corp_code;
        //    GridControl _Grid_Control = _gd;
        //    GridView _Grid_View = _gv;

        //    dsGridSetting = _ds; //그리드 설정 데이터

        //    _Grid_Control.ForceInitialize();

        //    if (dsGridSetting != null && dsGridSetting.Tables.Count > 0 && dsGridSetting.Tables[0].Rows.Count > 0)
        //    {
        //        SetGridControl(_Grid_Control, dsGridSetting.Tables[0].Rows[0]["GRID_NAME"].ToString(), true); //조회 데이터 기준 그리드 컨트롤러 설정

        //        _Grid_View = GetGridSetting(dsGridSetting, fntHeader, fntRow, _lt); // 그리드 뷰 and 컬럼 설정

        //        AddView(_Grid_Control, _Grid_View, true); // 그리드 컨트롤러 에 메인 뷰 설정

        //        _Grid_View.BestFitColumns();
        //    }

        //    new CoFAS_DevGridEventManager(_Grid_Control, "");

        //    return _Grid_View;
        //}
        #endregion

        //////////////////////////////////////////////////////////// MessageBox

        #region 에러 메시지 보여주기 - ShowErrorMessage(pException)

        /// <summary>
        /// 에러 메시지 보여주기
        /// </summary>
        /// <param name="pException">예외</param>
        public static void ShowErrorMessage(Exception pException)
        {
            try
            {

                XtraMessageBox.Show(
                    "담당자에게 문의해 주시기 바랍니다.\r\n" + pException.Message + "\r\n" + pException.StackTrace,
                    "Error",
                    MessageBoxButtons.OK
                );

            }
            catch
            {
            }
        }

        #endregion

        #region 에러 메시지 보여주기 - ShowErrorMessage(strMessage)

        /// <summary>
        /// 에러 메시지 보여주기
        /// </summary>
        /// <param name="strMessage">메시지</param>
        public static void ShowErrorMessage(string strMessage)
        {
            try
            {
                XtraMessageBox.Show
                (
                    strMessage,
                    "Error",
                    MessageBoxButtons.OK
                );
            }
            catch
            {
            }
        }

        #endregion

        #region 정보 메시지 보여주기 - ShowInformationMessage(strMessage)

        /// <summary>
        /// 정보 메시지 보여주기
        /// </summary>
        /// <param name="strMessage">메시지</param>
        public static void ShowInformationMessage(string strMessage)
        {
            try
            {
                XtraMessageBox.Show
                (
                    strMessage,
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch
            {
            }
        }

        #endregion

        #region 질문 메시지 보여주기 - ShowQuestionMessage(strMessage)

        /// <summary>
        /// 질문 메시지 보여주기
        /// </summary>
        /// <param name="strMessage">메시지</param>
        public static System.Windows.Forms.DialogResult ShowQuestionMessage(string strMessage)
        {
            try
            {
                return XtraMessageBox.Show
                (
                    strMessage,
                    "Question",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            }
            catch
            {
                return DialogResult.No;
            }
        }

        #endregion

        //////////////////////////////////////////////////////////// Others

        #region 뷰 영역으로 컨트롤 스크롤 하기 - ScrollControlIntoView(pFlowLayoutPanel, pControl)

        /// <summary>
        /// 뷰 영역으로 컨트롤 스크롤 하기
        /// </summary>
        /// <param name="pFlowLayoutPanel">FlowLayoutPanel</param>
        /// <param name="pControl">Control</param>
        public static void ScrollControlIntoView(FlowLayoutPanel pFlowLayoutPanel, System.Windows.Forms.Control pControl)
        {
            if (pFlowLayoutPanel.InvokeRequired)
            {
                ScrollControlIntoViewDeletage pScrollControlIntoViewDeletage = new ScrollControlIntoViewDeletage(ScrollControlIntoView);

                pFlowLayoutPanel.Invoke(pScrollControlIntoViewDeletage, pFlowLayoutPanel, pControl);
            }
            else
            {
                pFlowLayoutPanel.ScrollControlIntoView(pControl);
            }
        }

        #endregion


        #region 텍스트 설정하기 - SetText(pControl, strText)

        /// <summary>
        /// 텍스트 설정하기
        /// </summary>
        /// <param name="pControl">컨트롤</param>
        /// <param name="strText">텍스트</param>
        public static void SetText(System.Windows.Forms.Control pControl, string strText)
        {
            if (pControl.InvokeRequired)
            {
                SetTextDelegate1 pSetTextDelegate1 = new SetTextDelegate1(SetText);

                pControl.Invoke(pSetTextDelegate1, pControl, strText);
            }
            else
            {
                pControl.Text = strText;
            }
        }

        #endregion

        #region 텍스트 설정하기 - SetText(pControl, strDefaultText, nCount)

        /// <summary>
        /// 텍스트 설정하기
        /// </summary>
        /// <param name="pControl">컨트롤</param>
        /// <param name="strDefaultText">디폴트 텍스트</param>
        /// <param name="nCount">건수</param>
        public static void SetText(System.Windows.Forms.Control pControl, string strDefaultText, int nCount)
        {
            if (pControl.InvokeRequired)
            {
                SetTextDelegate2 pSetTextDelegate2 = new SetTextDelegate2(SetText);

                pControl.Invoke(pSetTextDelegate2, pControl, strDefaultText, nCount);
            }
            else
            {
                if (nCount > 0)
                {
                    pControl.Text = string.Format("{0} : {1}건", strDefaultText, nCount);
                }
                else
                {
                    pControl.Text = strDefaultText;
                }
            }
        }

        #endregion
    }

    public class CoFAS_DevGridEventManager
    {
        private string strMenuCode = "";

        GridControl _gridControl;
        GridHitInfo _dragStartHitInfo;
        Cursor _dragRowCursor;

        bool isGD_DoubleClick = false; 

        readonly CoFAS_DragGridImageHelper _imageHelper;

        int dropTargetRowHandle = -1;


        public static event OnViewDoubleClickEventHandler OnViewDoubleClick;
        public delegate void OnViewDoubleClickEventHandler(object sender, EventArgs e);
        //ButtonPressedEventArgs
        //private static void ucGOpenButton_Click(object sender, ButtonPressedEventArgs e)
        //{
        //    if (_OnOpenButton != null)
        //        _OnOpenButton(sender, e);
        //}


       

        //Dictionary<DataRow, Color> colors = new Dictionary<DataRow, Color>();

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="grid">GridControl</param>
        /// <param name="strCode">그리드 명칭 코드</param>
        public CoFAS_DevGridEventManager(GridControl grid, string strCode)
        {
            strMenuCode = strCode;
            _gridControl = grid;// as roGridControl;
            SetUpGrid(_gridControl);
            _imageHelper = new CoFAS_DragGridImageHelper(grid.FocusedView as GridView);
        }

        /// <summary>
        /// GridControl 이벤트 설정
        /// </summary>
        /// <param name="grid"></param>
        //public void SetUpGrid(GridControl grid)
        public void SetUpGrid(GridControl grid)
        {
            /// 그리드 컨트롤러 이벤트 영역
            //grid.AllowDrop = true; //추가
            grid.DragOver += grid_DragOver;
            grid.DragDrop += grid_DragDrop;
            grid.DragLeave += grid_DragLeave;
            grid.Paint += grid_Paint;
            grid.GiveFeedback += grid_GiveFeedback;

            grid.MouseDoubleClick += grid_MouseDoubleClick;

            grid.EditorKeyDown += grid_EditorKeyDown;

            grid.ProcessGridKey += grid_ProcessGridKey;

            GridView view = grid.MainView as GridView;



            /// 그리드 뷰 이벤트 영역
            /// 
            //view.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp; //그리드 수정시 더블 클릭으로 변경 

            //view.ShowingEditor += view_ShowingEditor; //그리드 수정시 더블 클릭으로 변경 
            view.ShownEditor += view_shownEditor;

            view.DoubleClick += View_DoubleClick;

            view.MouseMove += view_MouseMove;
            view.MouseDown += view_MouseDown;

            view.KeyDown += View_KeyDown;
            view.InitNewRow += view_InitNewRow;
            view.ValidateRow += view_ValidateRow;
            view.CellValueChanged += view_CellValueChanged;
            //view.FocusedColumnChanged += View_FocusedColumnChanged;
            view.PopupMenuShowing += view_PopupMenuShowing;

            view.RowStyle += view_RowStyle;
            //view.RowCellStyle += view_RowCellStyle;
        }

        private void grid_ProcessGridKey(object sender, KeyEventArgs e)
        {
            //GridView gridView = (GridView)((GridControl)sender).MainView;
            //if (gridView.FocusedColumn == gridView.VisibleColumns.Last(col => !col.ReadOnly) && (e.KeyCode == System.Windows.Forms.Keys.Enter || e.KeyCode == System.Windows.Forms.Keys.Tab))
            //{
            //    gridView.FocusedRowHandle = GridControl.NewItemRowHandle;

            //    // Met le focus sur la dernière colonne avant de le mettre sur la première parce que la première cellule mise en focus est vidée
            //    gridView.FocusedColumn = gridView.VisibleColumns[gridView.VisibleColumns.Count - 1];

            //    // Crée la nouvelle ligne immédiatement sur le focus et non seulement à l'édition
            //    // gridView.ShowEditor();
            //    //  gridView.ActiveEditor.IsModified = true;
            //    // gridView.FocusedColumn = gridView.VisibleColumns[0];
            //}

            ////throw new NotImplementedException();
                }
       
        private void grid_EditorKeyDown(object sender, KeyEventArgs e)
        {
            //GridControl grid = sender as GridControl;
            //GridView view = grid.FocusedView as GridView;
            //if (e.KeyData == Keys.Enter && view.IsNewItemRow(view.FocusedRowHandle))
            //{

            //    view.FocusedRowHandle = 0;
                
            //    //if (view.ActiveEditor != null)
            //    //    view.ActiveEditor.IsModified = true;
            //}

            //throw new NotImplementedException();
        }

        private void view_RowStyle(object sender, RowStyleEventArgs e)
        {
            //GridView view = sender as GridView;

            //if (!view.IsDataRow(e.RowHandle)) return;

            //DataRow dr = view.GetDataRow(e.RowHandle);

            GridView view = sender as GridView;
            if (((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused) != 0) && ((e.State & DevExpress.XtraGrid.Views.Base.GridRowCellState.GridFocused) != 0))
                e.Appearance.Assign(view.PaintAppearance.FocusedRow);

            if (e.RowHandle >= 0)
            {
                if (view.GetRowCellValue(e.RowHandle, view.Columns["USE_YN"]) != null)
                {
                    string strUSE_YN = view.GetRowCellValue(e.RowHandle, view.Columns["USE_YN"]).ToString();
                    if (strUSE_YN == "N")
                    {
                        e.Appearance.BackColor = Color.FromArgb(150, Color.LightCoral);
                        e.Appearance.BackColor2 = Color.White;
                    }
                }

                if (view.GetRowCellValue(e.RowHandle, view.Columns["USED_CONFIGURATION"]) != null)
                {
                    string strCONFIGURATION_USED = view.GetRowCellValue(e.RowHandle, view.Columns["USED_CONFIGURATION"]).ToString();
                    if (strCONFIGURATION_USED == "Y")
                    {
                        e.Appearance.BackColor = Color.FromArgb(150, Color.LightBlue);
                        e.Appearance.BackColor2 = Color.White;
                    }
                }

                if (view.GetRowCellValue(e.RowHandle, view.Columns["COMPLETE_YN"]) != null)
                {
                    string strCOMPLETE_YN = view.GetRowCellValue(e.RowHandle, view.Columns["COMPLETE_YN"]).ToString();
                    if (strCOMPLETE_YN == "Y")
                    {
                        e.Appearance.BackColor = Color.FromArgb(150, Color.LightBlue);
                        e.Appearance.BackColor2 = Color.White;
                    }
                }
            }


            //if (e.Appearance.BackColor != Color.YellowGreen)
            //{
            //    e.Appearance.BackColor = Color.YellowGreen;
            //}
            //else
            //{
            //    e.Appearance.BackColor = Color.White;
            //}

        }

        //private void view_RowCellStyle(object sender, RowCellStyleEventArgs e)
        //{
        //    GridView View = sender as GridView;
        //    if (e.Column.FieldName == "USE_YN")
        //    {
        //        string status = View.GetRowCellValue(e.RowHandle, View.Columns["USE_YN"]).ToString();
        //        if (status == "N")
        //        {
        //            e.Appearance.BackColor = Color.FromArgb(150, Color.Salmon);
        //            e.Appearance.BackColor2 = Color.FromArgb(150, Color.Salmon);
        //        }
        //    }
        //}

        private void View_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsNewItemRowFocused(sender) && (e.KeyData == Keys.Up || e.KeyData == Keys.Down))
                e.Handled = true;
        }

        private void View_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
           // GridView view = sender as GridView;

           // if(view.FocusedRowHandle == GridControl.NewItemRowHandle) view.SetRowCellValue(GridControl.NewItemRowHandle, view.Columns["CRUD"], "C");
        }

        //////////////////////////////////////////////////////////// GridControl & GridView Event 영역
        //bool doubleClick = false;
        private void view_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (!isGD_DoubleClick)
                e.Cancel = true;
            else
                isGD_DoubleClick = false;
        }

        private void view_shownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            view.ActiveEditor.BackColor = Color.Yellow; // Color.DodgerBlue;
            view.ActiveEditor.ForeColor = Color.Black;
            if (view.IsNewItemRow(view.FocusedRowHandle)) //신규 입력 후 
            {
                view.ActiveEditor.IsModified = true;

                //view.FocusedRowHandle = 0;
            }
        }

        private void grid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GridControl gridControl = sender as GridControl;
            ColumnView view = gridControl.FocusedView as ColumnView; //.FocusedView as ColumnView;
            GridHitInfo hi = view.CalcHitInfo(e.Location) as GridHitInfo;
            if (hi.HitTest == GridHitTest.RowCell)
            {
                isGD_DoubleClick = true;
            }
        }

        //private void View_DoubleClick(object sender, EventArgs e)
        //{
        //    GridView view = sender as GridView;
        //    Point pt = view.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition);

        //    GridHitInfo info = view.CalcHitInfo(pt);
        //    if (info.InRow || info.InRowCell)
        //    {
        //        //string colCaption = info.Column == null ? "N/A" : info.Column.FieldName;
        //        //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));

        //    }

        //}

        public static void View_DoubleClick(object sender, EventArgs e)
        {

            if (OnViewDoubleClick != null)
                OnViewDoubleClick(sender, e);
            //    GridView view = sender as GridView;
            //Point pt = view.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition);

            //GridHitInfo info = view.CalcHitInfo(pt);
            //if (info.InRow || info.InRowCell)
            //{
            //    //string colCaption = info.Column == null ? "N/A" : info.Column.FieldName;
            //    //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));

            //}

        }


        private void view_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;

            _dragStartHitInfo = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));

            if (!IsNewItemRowClicked(sender, e) && IsNewItemRowFocused(sender) && !IsNewItemRowEmpty(sender))
                (e as DXMouseEventArgs).Handled = true;
            //gv.GetFocusedRowCellValue(strName).ToString();
            //if (IsNewItemRowClicked(sender, e))
            //{
            //foreach (GridColumn column in (view as GridView).Columns)
            //{
            //    switch (column.ColumnEdit.EditorTypeName)
            //    {
            //        case "LookUpEdit":
            //            column.View.Columns[0].Visible = false;
            //            //view.SetFocusedRowCellValue(column.Name, GetDefault(column.ColumnType));
            //            break;
            //    }
            //}
            //}

            if (System.Windows.Forms.Control.ModifierKeys != Keys.None)
                return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
                _dragStartHitInfo = hitInfo;
        }

        private object GetDefault(Type type)
        {
            if (type.IsValueType)
            {
                return Activator.CreateInstance(type);
            }
            return null;
        }

        private void view_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && _dragStartHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(_dragStartHitInfo.HitPoint.X - dragSize.Width / 2, _dragStartHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    _dragRowCursor = _imageHelper.GetDragCursor(_dragStartHitInfo.RowHandle, e.Location);
                    DataRow row = view.GetDataRow(_dragStartHitInfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    _dragStartHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void view_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
             GridView view = sender as GridView;

            //if(e.RowHandle == GridControl.NewItemRowHandle) 
            //{
            //    view.SetRowCellValue(e.RowHandle, "CRUD", "C");
            //}
            //else
            //{
            if (view.RowCount == 0) return;

            if (e.Column.ColumnEdit is RepositoryItemDateEdit)
            {
                e.Column.DisplayFormat.FormatType = FormatType.DateTime;
                e.Column.DisplayFormat.FormatString = "yyyy-MM-dd";
            }


            if (e.Column.Name == "CRUD" || e.RowHandle < 0 || view.GetRowCellValue(e.RowHandle, "CRUD").ToString() == "C") return;

            if (e.Column.Name.Length > 0)
            {
                view.SetRowCellValue(e.RowHandle, "CRUD", "U");
            }
               // if (e.Column.ColumnType is RepositoryItemDateEdit)

            //}
            view.GetFocusedDataRow().EndEdit();
        }

        private void view_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {

            GridView view = sender as GridView;
            // Check whether a row is right-clicked.

            if (!view.OptionsBehavior.ReadOnly) //뷰 속성이 ReadOnly fals 이면 팝업 메뉴 표시
            {
                if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row || e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Column)
                {
                    int rowHandle = e.HitInfo.RowHandle;
                    // Delete existing menu items, if any.
                    e.Menu.Items.Clear();
                    // Add a submenu with a single menu item.

                    DXMenuItem itemDeleteRow = CreateDeleteRowMenu(view, rowHandle);
                    e.Menu.Items.Add(itemDeleteRow);

                    DXMenuItem itemReplicationRow = CreateReplicationRowMenu(view, rowHandle);
                    itemReplicationRow.BeginGroup = true;
                    e.Menu.Items.Add(itemReplicationRow);
                }
            }
        }

        private void view_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //GridView view = sender as GridView;

            //if (view.FocusedRowHandle == GridControl.NewItemRowHandle)
            //{
            //    gridControl1.BeginInvoke(new MethodInvoker(() => {
            //        view.ShowEditor();
            //    }));
            //}
        }


        private void view_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;

            view.SetRowCellValue(e.RowHandle, view.Columns["CRUD"], "C");
            //foreach (GridColumn column in (view as GridView).Columns)
            //{
            //    switch (column.ColumnEdit.EditorTypeName)
            //    {
            //        case "LookUpEdit":

            //            //GetDefault(column.ColumnType) GetDefault(view.Columns[column.Name].GetType())
            //            view.SetRowCellValue(e.RowHandle, view.Columns[column.Name], GetDefault(view.Columns[column.Name].ColumnType));
            //            break;
            //    }
            //}
            view.GetFocusedDataRow().EndEdit();
        }

        private bool IsNewItemRowFocused(object sender)
        {
            GridView view = sender as GridView;
            return view.IsNewItemRow(view.FocusedRowHandle);
        }

        private bool IsNewItemRowClicked(object sender,MouseEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            return view.IsNewItemRow(hitInfo.RowHandle);
        }

        private bool IsNewItemRowEmpty(object sender)
        {
            GridView view = sender as GridView;
            return view.GetRow(view.FocusedRowHandle) == null;
        }

        /// <summary>
        /// 그리드 로우 메뉴 삭제
        /// </summary>
        /// <param name="view"></param>
        /// <param name="rowHandle"></param>
        /// <returns></returns>
        DXMenuItem CreateDeleteRowMenu(GridView view, int rowHandle)
        {
            DXMenuItem menuItemDeleteRow = new DXMenuItem("&" + Resources.Language._msgCreateDelete, new EventHandler(OnDeleteRowClick));
            menuItemDeleteRow.Tag = new RowInfo(view, rowHandle);

            return menuItemDeleteRow;
        }
        private void OnDeleteRowClick(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            RowInfo info = item.Tag as RowInfo;

            if (info.RowHandle < 0) return;

            if (info.View.GetRowCellValue(info.RowHandle, "CRUD").ToString() == "C")
            {
                info.View.DeleteRow(info.RowHandle);
            }
            else
            {
                info.View.SetRowCellValue(info.RowHandle, "CRUD", "D");
            }

            if (info.View.GetFocusedDataRow() == null) return;

            info.View.GetFocusedDataRow().EndEdit();
        }

        /// <summary>
        /// 그리드 로우 메뉴 행 복제
        /// </summary>
        /// <param name="view"></param>
        /// <param name="rowHandle"></param>
        /// <returns></returns>
        DXMenuItem CreateReplicationRowMenu(GridView view, int rowHandle)
        {
            
            DXMenuItem menuItemReplicationRow = new DXMenuItem("&" + Resources.Language._msgCreateReplication, new EventHandler(OnCopyRowClick));
            menuItemReplicationRow.Tag = new RowInfo(view, rowHandle);

            return menuItemReplicationRow;
        }

        private void OnCopyRowClick(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            RowInfo info = item.Tag as RowInfo;

            if (info.RowHandle < 0) return;
    
            DataRowView copyRow = (DataRowView)info.View.GetRow(info.RowHandle);

            info.View.AddNewRow();

            int newRowHandle = info.View.FocusedRowHandle;

            DataRowView newRow = (DataRowView)info.View.GetRow(newRowHandle);
            for (int i = 0; i< info.View.Columns.Count; i++)
            {
                info.View.SetRowCellValue(newRowHandle, info.View.Columns[i], info.View.GetRowCellValue(info.RowHandle, info.View.Columns[i]));
            }

            info.View.SetRowCellValue(newRowHandle, "CRUD", "C");

            info.View.GetFocusedDataRow().EndEdit();
        }

        int DropTargetRowHandle
        {
            get
            {
                return dropTargetRowHandle;
            }
            set
            {
                dropTargetRowHandle = value;
                _gridControl.Invalidate();
            }
        }

        private void grid_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            DataTable table = grid.DataSource as DataTable;
            DataRow row = null;
            //화면에 따라서 Grid - Drag & Drop 기능 추가 //기본은 Grid 에 Drag & Drop 기능 안씀.
            switch (strMenuCode)
            {
                case "화면에 따라서 그리드 DragDrop 기능 추가":
                    TreeListNode node = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;
                    if (node.RootNode == node)
                        return;
                    if (node != null && table != null)
                    {
                        List<object> itemArray = new List<object>();
                        foreach (DataColumn column in table.Columns)
                        {
                            itemArray.Add(node.GetValue(column));
                        }
                        object[] tmp = new object[itemArray.Count];
                        itemArray.CopyTo(tmp);
                        row = table.NewRow();
                        row.ItemArray = tmp;
                        table.Rows.InsertAt(row, DropTargetRowHandle);
                        TreeList treeList = node.TreeList;
                        treeList.DeleteNode(node);
                    }
                    break;
                default:
                    row = e.Data.GetData(typeof(DataRow)) as DataRow;

                    Point pt = new Point(e.X, e.Y);
                    pt = grid.PointToClient(pt);

                    GridView view = grid.GetViewAt(pt) as GridView;
                    DataRow dr = null;

                    if (view == null) return;

                    GridHitInfo hitInfo = view.CalcHitInfo(pt);

                    int sourceRow = view.FocusedRowHandle;
                    int targetRow = hitInfo.RowHandle;
                    int targetCnt = hitInfo.View.DataRowCount;

                    if (row != null && table != null && row.Table != table)
                    {
                        dr = table.NewRow();

                        if (dr.ItemArray.Length != row.ItemArray.Length) return;

                        dr.ItemArray = row.ItemArray;

                        if (dr["CRUD"].ToString() == "")
                        {
                            dr["CRUD"] = "C";
                        }

                        if(targetRow < 0)
                        {
                            table.Rows.InsertAt(dr, targetCnt+1);
                        }
                        else
                        {
                            table.Rows.InsertAt(dr, targetRow);
                        }

                        table.AcceptChanges();
                    }
                    else
                    {
                        if (sourceRow == targetRow)
                        {
                            return;
                        }
                        else
                        {
                            dr = table.NewRow();
                            dr.ItemArray = row.ItemArray;

                            view.DeleteRow(sourceRow);
                            if (targetRow < 0)
                            {
                                table.Rows.InsertAt(dr, targetCnt + 1);
                            }
                            else
                            {
                                table.Rows.InsertAt(dr, targetRow);
                            }
                            table.AcceptChanges();
                        }
                    }

                    break;

            }

            DropTargetRowHandle = -1;
        }

        private void grid_DragOver(object sender, DragEventArgs e)
        {


            GridControl grid = (GridControl)sender;
            Point pt = new Point(e.X, e.Y);
            pt = grid.PointToClient(pt);
            GridView view = grid.GetViewAt(pt) as GridView;
            if (view == null)
                return;
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if (hitInfo.RowHandle == GridControl.InvalidRowHandle)
                DropTargetRowHandle = view.DataRowCount;
            else
                DropTargetRowHandle = hitInfo.RowHandle;

            if (e.Data.GetDataPresent(typeof(DataRow)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;

        }

        private void grid_DragLeave(object sender, EventArgs e)
        {
            DropTargetRowHandle = -1;
        }

        private void grid_Paint(object sender, PaintEventArgs e)
        {
            if (DropTargetRowHandle < 0)
                return;
            GridControl grid = (GridControl)sender;
            GridView view = (GridView)grid.MainView;
            bool isBottomLine = DropTargetRowHandle == view.DataRowCount;
            GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;
            GridRowInfo rowInfo = viewInfo.GetGridRowInfo(isBottomLine ? DropTargetRowHandle - 1 : DropTargetRowHandle);
            if (rowInfo == null)
                return;
            Point p1, p2;
            if (isBottomLine)
            {
                p1 = new Point(rowInfo.Bounds.Left, rowInfo.Bounds.Bottom - 1);
                p2 = new Point(rowInfo.Bounds.Right, rowInfo.Bounds.Bottom - 1);
            }
            else
            {
                p1 = new Point(rowInfo.Bounds.Left, rowInfo.Bounds.Top - 1);
                p2 = new Point(rowInfo.Bounds.Right, rowInfo.Bounds.Top - 1);
            }
            e.Graphics.DrawLine(Pens.Blue, p1, p2);
        }

        void grid_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (_dragStartHitInfo != null)
            {
                e.UseDefaultCursors = false;
                Cursor.Current = _dragRowCursor;
            }
        }

    }

    //class GridControl :GridControl
    //{
    //    protected override void OnValidating(CancelEventArgs e)
    //    {
    //        if ((MainView as GridView).FocusedRowHandle == NewItemRowHandle)
    //            return;
    //        base.OnValidating(e);
    //    }
    //}

    class RowInfo
    {
        public RowInfo(GridView view, int rowHandle)
        {
            this.RowHandle = rowHandle;
            this.View = view;
        }
        public GridView View;
        public int RowHandle;
    }

    class CursorCreator
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }

        public static Cursor CreateCursor(Bitmap bmp, Point hotspot)
        {
            if (bmp == null)
                return Cursors.Default;
            IntPtr ptr = bmp.GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.fIcon = false;
            tmp.xHotspot = hotspot.X;
            tmp.yHotspot = hotspot.Y;
            ptr = CreateIconIndirect(ref tmp);
            return new Cursor(ptr);

        }
    }

    public class CoFAS_DragGridImageHelper : GridPainter
    {
        //private readonly DevExpress.XtraGrid.Views.Grid.GridView _view;
        private readonly DevExpress.XtraGrid.Views.Grid.GridView _view = new DevExpress.XtraGrid.Views.Grid.GridView();
        public CoFAS_DragGridImageHelper(DevExpress.XtraGrid.Views.Grid.GridView view)
            : base(view)
        {
            _view = view;
        }

        public Cursor GetDragCursor(int rowHandle, Point e)
        {
            GridViewInfo info = _view.GetViewInfo() as GridViewInfo;
            GridRowInfo rowInfo = info.GetGridRowInfo(rowHandle);
            Bitmap result = GetRowDragBitmap(rowHandle);
            Point offset = new Point(rowInfo.Bounds.X, e.Y - rowInfo.Bounds.Y);
            return CursorCreator.CreateCursor(result, offset);
        }

        public Bitmap GetRowDragBitmap(int rowHandle)
        {
            Bitmap bmpView = null;
            Bitmap bmpRow = null;
            GridViewInfo info = _view.GetViewInfo() as GridViewInfo;
            Rectangle totalBounds = info.Bounds;
            GridRowInfo ri = info.GetGridRowInfo(rowHandle);
            Rectangle imageBounds = new Rectangle(new Point(0, 0), ri.Bounds.Size);
            try
            {
                bmpView = new Bitmap(totalBounds.Width, totalBounds.Height);
                using (Graphics gView = Graphics.FromImage(bmpView))
                {
                    using (XtraBufferedGraphics grView = XtraBufferedGraphicsManager.Current.Allocate(gView, new Rectangle(Point.Empty, bmpView.Size)))
                    {
                        Color color = ri.Appearance.BackColor == Color.Transparent ? Color.White : ri.Appearance.BackColor;
                        grView.Graphics.Clear(color);
                        GridViewDrawArgs args = new GridViewDrawArgs(new GraphicsCache(grView.Graphics), info, totalBounds);
                        DrawRow(args, ri);
                        grView.Graphics.FillRectangle(args.Cache.GetSolidBrush(Color.Transparent), ri.Bounds);
                        grView.Render();
                        bmpRow = new Bitmap(ri.Bounds.Width, ri.Bounds.Height);
                        using (Graphics gRow = Graphics.FromImage(bmpRow))
                        {
                            using (XtraBufferedGraphics grRow = XtraBufferedGraphicsManager.Current.Allocate(gRow, new Rectangle(Point.Empty, bmpRow.Size)))
                            {
                                grRow.Graphics.Clear(color);
                                grRow.Graphics.DrawImage(bmpView, imageBounds, ri.Bounds, GraphicsUnit.Pixel);
                                grRow.Render();
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            return bmpRow;
        }



    }

}
