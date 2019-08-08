using DevExpress.Utils;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Handler;
using DevExpress.XtraTreeList.Menu;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Painter;
using DevExpress.XtraTreeList.ViewInfo;

using DevExpress.XtraTreeList.Handler;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoFAS_MES.CORE.Function
{
    public class CoFAS_TreeListManager
    {
        private string strMenuCode = "";

        Cursor _dragRowCursor;

        TreeListHitInfo _dragStartHitInfo;
        readonly DragTreeListImageHelper _imageHelper;

        public CoFAS_TreeListManager(TreeList treeList, string strCode)
        {
            strMenuCode = strCode;
            SetUpTreeList(treeList);
            _imageHelper = new DragTreeListImageHelper(treeList);
        }

        public void SetUpTreeList(TreeList treeList)
        {
            /// 트리 리스트 폰트 설정
            float fontHeaderSize = 12;
            float fontRowSize = 12;
            string fontType = "굴림";

            Font fntHeader = new Font(fontType, fontHeaderSize, FontStyle.Bold);
            Font fntRow = new Font(fontType, fontRowSize);

            /// 트리 리스트 설정 영역
            treeList.AllowDrop = true; // 트리 리스트 항상 Drop 기능 활성화 유무

            treeList.Appearance.HeaderPanel.Font = fntHeader; // 트리 리스트 헤더 데이터 패널 폰트
            treeList.Appearance.Row.Font = fntRow; // 트리 리스트 로우 데이터 폰트

            treeList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // 트리 리스트 헤더 데이터 정렬 가로
            treeList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center; // 트리 리스트 헤더 데이터 정렬 가로

            treeList.Appearance.OddRow.BackColor = Color.Empty;// Color.LightSteelBlue; // 트리 리스트 홀수 줄 색상
            treeList.Appearance.FocusedRow.BackColor = Color.LightYellow; // 트리 리스트 선택 로우 색상

            treeList.OptionsView.EnableAppearanceOddRow = true; // 트리 리스트 홀수 줄 색상 변경 유무
            treeList.OptionsView.AutoWidth = true; // 트리 리스트 컬럼 사이즈 조정 자동 유무
            treeList.OptionsView.ShowIndentAsRowStyle = true;
            treeList.OptionsView.ShowIndicator = true;


            //Skin skin = GridSkins.GetSkin(treeList.LookAndFeel);
            //skin.Properties[GridSkins.OptShowTreeLine] = true;
            //treeList.LookAndFeel.SetStyle.UpdateStyleSettings();


            treeList.RowHeight = 20; // 트리 리스트 줄 높이 설정
            treeList.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Single;
            //Dev 최신 버전에서 사용하지 않아 주석처리
            //treeList.OptionsBehavior.DragNodes = true; // 트리 리스트 Drag 기능 활성화 유무
                                                       //treeList.OptionsBehavior.Editable = false;







            /// 트리 리스트 이벤트 영역
            treeList.DragOver += treeList_DragOver;
            treeList.DragDrop += treeList_DragDrop;
            treeList.MouseMove += treeList_MouseMove;
            treeList.MouseDown += treeList_MouseDown;
            treeList.GiveFeedback += treeList_GiveFeedback;

            //18.06.15 트리리스트로 만듬x
           // treeList.PopupMenuShowing += treeList_PopupMenuShowing;




            //treeList.NodeCellStyle += treeList_NodeCellStyle;

            //treeList.CustomDrawNodeCell += treeList_CustomDrawNodeCell;

            //treeList.AfterCheckNode += treeList_AfterCheckNode;
        }

        //안씀
        private TreeList tlTemp = null;
        private void treeList_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            tlTemp = sender as TreeList;

            if (e.Menu is TreeListNodeMenu)
            {
                tlTemp.FocusedNode = ((TreeListNodeMenu)e.Menu).Node;
                //e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Edit", bbEdit_ItemClick));
                //e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Add child", bbAddChild_ItemClick));
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Delete", bbDelete_ItemClick));
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Cancle", bbCancle_ItemClick));
            }
        }

        private void bbDelete_ItemClick(object sender, EventArgs e)
        {
            tlTemp.FocusedNode.SetValue("use_yn", "N");
            //tlTemp.Appearance.SelectedRow.BackColor = Color.Red;
            // tlTemp.DeleteNode(tlTemp.FocusedNode);
            //tlTemp.BeginUpdate();
            //tlTemp.ForceInitialize();
        }
        private void bbCancle_ItemClick(object sender, EventArgs e)
        {
            tlTemp.FocusedNode.SetValue("use_yn", "Y");
            //tlTemp.FOC.SelectedRow.BackColor = Color.LightYellow;
            // tlTemp.DeleteNode(tlTemp.FocusedNode);
            //tlTemp.BeginUpdate();
            //tlTemp.ForceInitialize();
        }

        //private void treeList_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        //{
        //    // Create brushes for cells.
        //    Brush backBrush, foreBrush;
        //    if (e.Node != (sender as TreeList).FocusedNode)
        //    {
        //        backBrush = new LinearGradientBrush(e.Bounds, Color.PapayaWhip, Color.PeachPuff, LinearGradientMode.ForwardDiagonal);
        //        foreBrush = Brushes.Black;
        //    }
        //    else
        //    {
        //        backBrush = Brushes.DarkBlue;
        //        foreBrush = new SolidBrush(Color.PeachPuff);
        //    }
        //    // Fill the background.
        //    e.Graphics.FillRectangle(backBrush, e.Bounds);
        //    // Paint the node value.
        //    e.Graphics.DrawString(e.CellText, e.Appearance.Font, foreBrush, e.Bounds,
        //      e.Appearance.GetStringFormat());

        //    // Prohibit default painting.
        //    e.Handled = true;
        //}

        private void treeList_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            // Modify the appearance settings used to paint the "Budget" column's cells
            // whose values are greater than 500,000.

            if (e.Node != (sender as TreeList).FocusedNode)
            {

                if (e.Column.FieldName != "USE_YN") return;

                if (e.Node.GetValue(e.Column.AbsoluteIndex).ToString() == "N")
                {
                    //e.Appearance.BackColor = Color.FromArgb(80, 255, 0, 255);
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
                else
                {
                    //e.Appearance.BackColor = Color.FromArgb(80, 255, 0, 255);
                    e.Appearance.ForeColor = Color.Empty;
                    e.Appearance.Font = new Font(e.Appearance.Font, 0);
                }
            }

        }


        private void treeList_AfterCheckNode(object sender, NodeEventArgs e)
        {

            ParentNodeChecked(e.Node);

            throw new NotImplementedException();
        }

        private void ParentNodeChecked(TreeListNode selectNode)
        {
            TreeListNode t = selectNode.ParentNode;
            if (t != null)
            {
                t.Checked = ChildNodeChecked(t);
            }
        }

        // 재귀로 자식노드 체크 상태 확인
        private bool ChildNodeChecked(TreeListNode StartNode)
        {
            foreach (TreeListNode tn in StartNode.Nodes)
            {
                if (ChildNodeChecked(tn) & tn.Checked == false) return false;
            }
            return true;
        }

        private void treeList_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (_dragStartHitInfo != null)
            {
                e.UseDefaultCursors = false;
                Cursor.Current = _dragRowCursor;
            }
        }

        private void treeList_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _dragStartHitInfo != null && _dragStartHitInfo.HitInfoType == HitInfoType.Cell)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(_dragStartHitInfo.MousePoint.X - dragSize.Width / 2, _dragStartHitInfo.MousePoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    //_dragRowCursor = _imageHelper.GetDragCursor(_dragStartHitInfo, e.Location);
                    TreeListNode dragObject = _dragStartHitInfo.Node;
                    (sender as TreeList).DoDragDrop(dragObject, DragDropEffects.Move);
                    _dragStartHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        //우클릭시 삭제x
        private void treeList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && System.Windows.Forms.Control.ModifierKeys == Keys.None)
                _dragStartHitInfo = (sender as TreeList).CalcHitInfo(new Point(e.X, e.Y));
            else
                _dragStartHitInfo = null;


           if (e.Button == MouseButtons.Right && System.Windows.Forms.Control.ModifierKeys == Keys.None)
           {
               _dragStartHitInfo = (sender as TreeList).CalcHitInfo(new Point(e.X, e.Y));
               TreeListNode node = null;
               //아래에 트리명칭참조
               //https://documentation.devexpress.com/WindowsForms/DevExpress.XtraTreeList.HitInfoType.enum
               //Cell : 셀클릭시
               if (_dragStartHitInfo.HitInfoType == HitInfoType.Cell)
               {
                   node = _dragStartHitInfo.Node;
               }
               if (node == null) return;
               //'품목삭제'메뉴 생성
               TreeListMenu menu = new TreeListMenu(sender as TreeList);
               DevExpress.Utils.Menu.DXMenuItem menuItem = new DevExpress.Utils.Menu.DXMenuItem("&" + "Delete Row", new EventHandler(deleteNodeMenuItemClick));
               menuItem.Tag = node;
               menu.Items.Add(menuItem);
               // Show the menu.
               menu.Show(e.Location);
           }
           else
               _dragStartHitInfo = null;
        }

        // 노드삭제 인보크
        private void deleteNodeMenuItemClick(object sender, EventArgs e)
        {
            DevExpress.Utils.Menu.DXMenuItem item = sender as DevExpress.Utils.Menu.DXMenuItem;
            if (item == null) return;
            TreeListNode node = item.Tag as TreeListNode;
            if (node == null) return;
            node.TreeList.DeleteNode(node);
        }


        private void treeList_DragOver(object sender, DragEventArgs e)
        {
            TreeListNode dragNode = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;

            TreeListNode targetNode;

            TreeList treeList = sender as TreeList;

            Point p = treeList.PointToClient(System.Windows.Forms.Control.MousePosition);

            targetNode = treeList.CalcHitInfo(p).Node;

            if (dragNode != null && targetNode != null && dragNode.Level != 0)
                e.Effect = DragDropEffects.Move;
            else
            {
                if (e.Data.GetDataPresent(typeof(DataRow)))
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void treeList_DragDrop(object sender, DragEventArgs e)
        {

            TreeListNode dragNode, targetNode;

            TreeList treeList = sender as TreeList;

            Point p = treeList.PointToClient(new Point(e.X, e.Y));

            targetNode = treeList.CalcHitInfo(p).Node;

            DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;

            if (row != null)
            {
                TreeListHitInfo hitInfo = treeList.CalcHitInfo(treeList.PointToClient(new Point(e.X, e.Y)));

                //트리리스가 등록되지 않은 초기상태
                if (treeList.AllNodesCount == 0)
                {
                    //화면에 따라서 TreeList - Drag & Drop 기능 추가
                    switch (strMenuCode)
                    {
                        case "ProductBOMRegister":

                            if (row["part_type"].ToString() != "1001")
                            {
                                MessageBox.Show("제품코드 이 외에 등록 할 수 없습니다.");
                                return;
                            }
                            treeList.AppendNode(new object[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), "0", "", "0", "0", "", "", "Y" }, null);
                            break;
                        case "ProcessConfigurationRegister":

                            if(row.ItemArray[2].ToString() == "Y")
                            {
                                MessageBox.Show("It's a configured process."); //구성된 공정 입니다.
                                return;
                            }
                            treeList.AppendNode(new object[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), "0", "0", "", "" ,"Y"}, null);
                            break;
                        case "ProcessResourceMapping":
                            treeList.AppendNode(new object[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), "Y", "0", "0", "" }, null);
                            break;
                        default:
                            treeList.AppendNode(new object[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), "0", "Y", "0", "0", "" }, null);
                            break;
                    }
                }
                else
                {
                    if (hitInfo.HitInfoType != HitInfoType.Cell)
                        return;

                    switch (strMenuCode)
                    {
                        case "ProductBOMRegister":

                            if (targetNode.GetDisplayText("part_code") == row.ItemArray[0].ToString())
                            {
                                MessageBox.Show("상위코드와 같습니다.");
                                return;
                            }

                            if (row["part_type"].ToString() == "1001")
                            {
                                MessageBox.Show("제품코드 는 하위코드로 등록 할 수 없습니다.");
                                return;
                            }

                            if (Convert.ToInt32(targetNode.GetDisplayText("part_code").Substring(0, 1)) > Convert.ToInt32(row.ItemArray[0].ToString().Substring(0, 1)))
                            {
                                MessageBox.Show("하위 코드에 등록 할 수 없습니다.");
                                return;
                            }

                            if (targetNode.Nodes.Count != 0)
                            {
                                for (int a = 0; a < targetNode.Nodes.Count; a++)
                                {
                                    if (targetNode.Nodes[a].GetDisplayText("part_code") == row.ItemArray[0].ToString())
                                    {
                                        MessageBox.Show(row.ItemArray[0].ToString() + " 코드를 같은 레벨 에 등록 할 수 없습니다.");
                                        return;
                                    }
                                }
                            }

                            treeList.AppendNode(new object[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), "0", "", (targetNode.Level + 1).ToString(), (targetNode.Id + 1).ToString(), "", "Y" }, targetNode);
                            break;
                        case "ProcessConfigurationRegister":


                            treeList.AppendNode(new object[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), (targetNode.Level + 1).ToString(), (targetNode.Id + 1).ToString(), "", "","Y" }, targetNode);
                            break;
                        case "ProcessResourceMapping":
                            if (targetNode.GetDisplayText("mapping_code") == row.ItemArray[0].ToString())
                            {
                                MessageBox.Show("상위코드와 같습니다.");
                                return;
                            }


                            if (targetNode.Nodes.Count != 0)
                            {
                                for (int a = 0; a < targetNode.Nodes.Count; a++)
                                {
                                    if (targetNode.Nodes[a].GetDisplayText("mapping_code") == row.ItemArray[0].ToString())
                                    {
                                        MessageBox.Show(row.ItemArray[0].ToString() + " 코드를 같은 레벨 에 등록 할 수 없습니다.");
                                        return;
                                    }
                                }
                            }

                            treeList.AppendNode(new object[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), "Y", (targetNode.Level + 1).ToString(), (targetNode.Id + 1).ToString(), "" }, targetNode);
                            break;
                        default:
                            treeList.AppendNode(new object[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), "0", "Y", (targetNode.Level + 1).ToString(), (targetNode.Id + 1).ToString(), "" }, targetNode);
                            break;
                    }
                }

                treeList.ForceInitialize();
                treeList.ExpandAll();
                treeList.BestFitColumns();

                e.Effect = DragDropEffects.None;

            }
            else
            {
                int index = -1;
                dragNode = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;

                if (targetNode.ParentNode != null) index = targetNode.ParentNode.Nodes.IndexOf(targetNode);

                treeList.MoveNode(dragNode, targetNode, true);
                treeList.SetNodeIndex(dragNode, index);
                e.Effect = DragDropEffects.None;

            }


        }



        //////////////////////////////////////////////////////////// TreeList

        #region 트리 목록 설정하기 - SetTreeList(strName, bShowColumns, bEnableColumnMenu, bAutoWidth, bShowIndicator, bShowHorzLines, bShowVertLines, bShowFocusedFrame, bEnableAppearanceFocusedCell, bInvertSelection, bEditable)

        /// <summary>
        /// 트리 목록 설정하기
        /// </summary>
        /// <param name="strName">명칭</param>
        /// <param name="bShowColumns">컬럼 표시 여부</param>
        /// <param name="bEnableColumnMenu">컬럼 메뉴 활성화 여부</param>
        /// <param name="bAutoWidth">자동 너비 여부</param>
        /// <param name="bShowIndicator">지시가 표시 여부</param>
        /// <param name="bShowHorzLines">수평선 표시 여부</param>
        /// <param name="bShowVertLines">수직선 표시 여부</param>
        /// <param name="bShowFocusedFrame">포커스 프레임 표시 여부</param>
        /// <param name="bEnableAppearanceFocusedCell">포커스 셀 모양 활성화 여부</param>
        /// <param name="bInvertSelection">선택 반전 여부</param>
        public static void SetTreeList(TreeList pTreeList, string strName, bool bShowColumns, bool bEnableColumnMenu, bool bAutoWidth, bool bShowIndicator, bool bShowHorzLines, bool bShowVertLines, bool bShowFocusedFrame, bool bEnableAppearanceFocusedCell, bool bInvertSelection, bool bEditable)
        {
            try
            {
                pTreeList.Name = strName;
                pTreeList.OptionsView.ShowColumns = bShowColumns;
                pTreeList.OptionsMenu.EnableColumnMenu = bEnableColumnMenu;
                pTreeList.OptionsView.AutoWidth = bAutoWidth;
                pTreeList.OptionsView.ShowIndicator = bShowIndicator;
                pTreeList.OptionsView.ShowHorzLines = bShowHorzLines;
                pTreeList.OptionsView.ShowVertLines = bShowVertLines;
                pTreeList.OptionsView.ShowFocusedFrame = bShowFocusedFrame;
                pTreeList.OptionsSelection.EnableAppearanceFocusedCell = bEnableAppearanceFocusedCell;
                pTreeList.OptionsSelection.InvertSelection = bInvertSelection;
                pTreeList.OptionsBehavior.Editable = bEditable;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "SetTreeList(strName, bShowColumns, bEnableColumnMenu, bAutoWidth, bShowIndicator, bShowHorzLines, bShowVertLines, bShowFocusedFrame, bEnableAppearanceFocusedCell, bInvertSelection, bEditable)",
                    pException
                );
            }
        }

        #endregion

        #region 트리 목록 설정하기 - SetTreeList(pTreeList, strName)

        /// <summary>
        /// 트리 목록 설정하기
        /// </summary>
        /// <param name="pTreeList">트리 목록</param>
        /// <param name="strName">명칭</param>
        public static void GetTreeList(TreeList pTreeList, string strName)
        {
            try
            {
                SetTreeList(pTreeList, strName, false, false, false, false, false, false, false, false, true, false);
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
                    "GetTreeList(pTreeList, strName)",
                    pException
                );
            }
        }

        #endregion


        #region 초기화 시작하기 - BeginInitialize(pTreeList)

        /// <summary>
        /// 초기화 시작하기
        /// </summary>
        /// <param name="pTreeList">트리 목록</param>
        public static void BeginInitialize(TreeList pTreeList)
        {
            try
            {
                ((ISupportInitialize)pTreeList).BeginInit();
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "BeginInitialize(pTreeList)",
                    pException
                );
            }
        }

        #endregion

        #region 초기화 종료하기 - EndInitialize(pTreeList)

        /// <summary>
        /// 초기화 종료하기
        /// </summary>
        /// <param name="pTreeList">트리 목록</param>
        public static void EndInitialize(TreeList pTreeList)
        {
            try
            {
                ((ISupportInitialize)pTreeList).EndInit();
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "EndInitialize(pTreeList)",
                    pException
                );
            }
        }

        #endregion


        #region 트리 목록 컬럼 추가하기 - AddTreeListColumn(pTreeList, pTreeListColumns)

        /// <summary>
        /// 트리 목록 컬럼 추가하기
        /// </summary>
        /// <param name="pTreeList">트리 목록</param>
        /// <param name="pTreeListColumns">트리 목록 컬럼</param>
        public static void AddTreeListColumn(TreeList pTreeList, TreeListColumn[] pTreeListColumns)
        {
            try
            {
                pTreeList.Columns.AddRange(pTreeListColumns);
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "AddTreeListColumn(pTreeList, pTreeListColumns)",
                    pException
                );
            }
        }

        #endregion

        #region 트리 목록 컬럼 추가하기 - AddTreeListColumn(pTreeList, pTreeListColumn)

        /// <summary>
        /// 트리 목록 컬럼 추가하기
        /// </summary>
        /// <param name="pTreeList">트리 목록</param>
        /// <param name="pTreeListColumn">트리 목록 컬럼</param>
        public static void AddTreeListColumn(TreeList pTreeList, TreeListColumn pTreeListColumn)
        {
            try
            {
                AddTreeListColumn(pTreeList, new TreeListColumn[] { pTreeListColumn });
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
                    "AddTreeListColumn(pTreeList, pTreeListColumn)",
                    pException
                );
            }
        }

        #endregion


        #region 트리 목록 노드 추가하기 - AddTreeListNode(pTreeList, pParentTreeListNode, pCheckState, pValue, pTag)

        /// <summary>
        /// 트리 목록 노드 추가하기
        /// </summary>
        /// <param name="pTreeList">트리 목록</param>
        /// <param name="pParentTreeListNode">부모 트리 목록 노드</param>
        /// <param name="pCheckState">체크 상태</param>
        /// <param name="pValue">값</param>
        /// <param name="pTag">태그</param>
        /// <returns>트리 목록 노드</returns>
        public static TreeListNode AddTreeListNode(TreeList pTreeList, TreeListNode pParentTreeListNode, CheckState pCheckState, object pValue, object pTag)
        {
            try
            {
                TreeListNode pTreeListNode = pTreeList.AppendNode(pValue, pParentTreeListNode, pCheckState);

                pTreeListNode.Tag = pTag;

                return pTreeListNode;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "AddTreeListNode(pTreeList, pParentTreeListNode, pCheckState, pValue, pTag)",
                    pException
                );
            }
        }

        #endregion

        #region 트리 목록 노드 추가하기 - AddTreeListNode(pTreeList, pParentTreeListNode, pCheckState, pValue)

        /// <summary>
        /// 트리 목록 노드 추가하기
        /// </summary>
        /// <param name="pTreeList">트리 목록</param>
        /// <param name="pParentTreeListNode">부모 트리 목록 노드</param>
        /// <param name="pCheckState">체크 상태</param>
        /// <param name="pValue">값</param>
        /// <returns>트리 목록 노드</returns>
        public static TreeListNode AddTreeListNode(TreeList pTreeList, TreeListNode pParentTreeListNode, CheckState pCheckState, object pValue)
        {
            try
            {
                return AddTreeListNode(pTreeList, pParentTreeListNode, CheckState.Unchecked, pValue, null);
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
                    "AddTreeListNode(pTreeList, pParentTreeListNode, pCheckState, pValue)",
                    pException
                );
            }
        }

        #endregion

        #region 트리 목록 노드 추가하기 - AddTreeListNode(pTreeList, pParentTreeListNode, pValue)

        /// <summary>
        /// 트리 목록 노드 추가하기
        /// </summary>
        /// <param name="pTreeList">트리 목록</param>
        /// <param name="pParentTreeListNode">부모 트리 목록 노드</param>
        /// <param name="pValue">값</param>
        /// <returns>트리 목록 노드</returns>
        public static TreeListNode AddTreeListNode(TreeList pTreeList, TreeListNode pParentTreeListNode, object pValue)
        {
            try
            {
                return AddTreeListNode(pTreeList, pParentTreeListNode, CheckState.Unchecked, pValue, null);
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
                    "AddTreeListNode(pTreeList, pParentTreeListNode, pValue)",
                    pException
                );
            }
        }

        #endregion

        //////////////////////////////////////////////////////////// TreeListColumn

        #region 트리 목록 컬럼 구하기 - GetTreeListColumn(strName, strCaption, strFieldName, pUnboundColumnType, nWidth, pHorzAlignment, bAllowEdit, pFormatType, strFormatString, nVisibleIndex, bVisible)

        /// <summary>
        /// 트리 목록 컬럼 구하기
        /// </summary>
        /// <param name="strName">명칭</param>
        /// <param name="strCaption">제목</param>
        /// <param name="strFieldName">필드명</param>
        /// <param name="pUnboundColumnType">언바운드 컬럼 종류</param>
        /// <param name="nWidth">너비</param>
        /// <param name="pHorzAlignment">수평 정렬</param>
        /// <param name="bAllowEdit">편집 허용 여부</param>
        /// <param name="pFormatType">형식 종류</param>
        /// <param name="strFormatString">형식 문자열</param>
        /// <param name="nVisibleIndex">표시 인덱스</param>
        /// <param name="bVisible">표시 여부</param>
        /// <returns>트리 목록 컬럼 구하기</returns>
        public static TreeListColumn GetTreeListColumn(string strName, string strCaption, string strFieldName, DevExpress.XtraTreeList.Data.UnboundColumnType pUnboundColumnType, int nWidth, HorzAlignment pHorzAlignment, bool bAllowEdit, FormatType pFormatType, string strFormatString, int nVisibleIndex, bool bVisible)
        {
            try
            {
                TreeListColumn pTreeListColumn = new TreeListColumn();

                pTreeListColumn.Name = strName;
                pTreeListColumn.Caption = strCaption;
                pTreeListColumn.FieldName = strFieldName;
                pTreeListColumn.UnboundType = pUnboundColumnType;
                pTreeListColumn.Width = nWidth;
                pTreeListColumn.AppearanceHeader.Options.UseTextOptions = true;
                pTreeListColumn.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                pTreeListColumn.AppearanceCell.Options.UseTextOptions = true;
                pTreeListColumn.AppearanceCell.TextOptions.HAlignment = pHorzAlignment;
                pTreeListColumn.OptionsColumn.AllowEdit = bAllowEdit;
                pTreeListColumn.Format.FormatType = pFormatType;
                pTreeListColumn.Format.FormatString = strFormatString;
                pTreeListColumn.VisibleIndex = nVisibleIndex;
                pTreeListColumn.Visible = bVisible;

                return pTreeListColumn;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    typeof(CoFAS_DevExpressManager),
                    "GetTreeListColumn(strName, strCaption, strFieldName, pUnboundColumnType, nWidth, pHorzAlignment, bAllowEdit, pFormatType, strFormatString, nVisibleIndex, bVisible)",
                    pException
                );
            }
        }

        #endregion

        #region 트리 목록 컬럼 구하기 - GetTreeListColumn(strName, strCaption, strFieldName, nWidth, nVisibleIndex)

        /// <summary>
        /// 트리 목록 컬럼 구하기
        /// </summary>
        /// <param name="strName">명칭</param>
        /// <param name="strCaption">제목</param>
        /// <param name="strFieldName">필드명</param>
        /// <param name="nWidth">너비</param>
        /// <param name="nVisibleIndex">표시 인덱스</param>
        /// <returns>트리 목록 컬럼 구하기</returns>
        public static TreeListColumn GetTreeListColumn(string strName, string strCaption, string strFieldName, int nWidth, int nVisibleIndex)
        {
            try
            {
                return GetTreeListColumn(strName, strCaption, strFieldName, DevExpress.XtraTreeList.Data.UnboundColumnType.String, nWidth, HorzAlignment.Near, false, FormatType.None, null, nVisibleIndex, true);
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
                    "GetTreeListColumn(strName, strCaption, strFieldName, nWidth, nVisibleIndex)",
                    pException
                );
            }
        }

        #endregion
    }

    public class DragTreeListImageHelper : TreeListPainter
    {
        private readonly TreeList _treeList;
        public DragTreeListImageHelper(TreeList treeList)
        {
            _treeList = treeList;
        }
        //public Cursor GetDragCursor(TreeListHitInfo hitInfo, Point e)
        //{
            //PropertyInfo Handler = _treeList.GetType().GetProperty("Handler", BindingFlags.Instance | BindingFlags.NonPublic);
            //TreeListHandler handler = (TreeListHandler)Handler.GetValue(_treeList, null);
            //FieldInfo fStateData = handler.GetType().GetField("fStateData", BindingFlags.Instance | BindingFlags.NonPublic);
            //StateData data = (StateData)fStateData.GetValue(handler);
            //TreeListViewInfo info = _treeList.ViewInfo;
            //RowInfo rowInfo = info.GetRowInfoByPoint(hitInfo.MousePoint);
            //Bitmap result = data.GetNodeDragBitmap(rowInfo.Node, rowInfo.VisibleIndex, rowInfo.IndentInfo.Bounds.Width);
            //Point offset = new Point(rowInfo.Bounds.X, e.Y - rowInfo.Bounds.Y);
            //return CursorCreator.CreateCursor(result, offset);
        //}
    }
}
