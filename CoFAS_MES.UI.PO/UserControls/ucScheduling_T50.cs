using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoFAS_MES.UI.PO.Business;
using CoFAS_MES.UI.PO.Entity;
using CoFAS_MES.CORE.Function;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using System.Runtime.InteropServices;
using DevExpress.Utils.Drawing;

namespace CoFAS_MES.UI.PO.UserControls
{
    public partial class ucScheduling_T50 : UserControl
    {

        private Scheduling_T50Entity _pScheduling_T50Entity = null;
        private GridHitInfo _dragStartHitInfo;
        private Cursor _dragRowCursor;
        readonly CoFAS_DragGridImageHelper _imageHelper;

        public event OnPopupEventHandler OnPopup;
        public delegate void OnPopupEventHandler(object sender, EventArgs e);

        //GridControl _gridControl;
        int dropTargetRowHandle = -1;

        int DropTargetRowHandle
        {
            get
            {
                return dropTargetRowHandle;
            }
            set
            {
                dropTargetRowHandle = value;
                _gdMAIN.Invalidate();
            }
        }

        public ucScheduling_T50(DataRow dr, string _pUSER_CODE, string _Order_date)
        {
            InitializeComponent();
            _pScheduling_T50Entity = new Scheduling_T50Entity();
            _pScheduling_T50Entity.USER_CODE = _pUSER_CODE;
            _pScheduling_T50Entity.order_date = _Order_date;
            _pScheduling_T50Entity.equipment_code = dr["equipment_code"].ToString();
            this.lblequi.Text = dr["equipment_name"].ToString();

            

            //_imageHelper = new CoFAS_DragGridImageHelper(_gdMAIN.FocusedView as GridView);

            //_imageHelper = new CoFAS_DragGridImageHelperUC(_gdMAIN_VIEW);
            
        }

        public GridView SetGrid(GridControl _grid)
        {

            GridView _view = _grid.MainView as GridView;

            _grid.AllowDrop = this.Tag.ToString() == "True" ? false : true;

            _view.OptionsSelection.MultiSelect = false;
            _view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

            _view.OptionsBehavior.Editable = false;
            _view.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            _view.OptionsSelection.EnableAppearanceFocusedCell = false;
            _view.OptionsSelection.EnableAppearanceFocusedRow = true;
            _view.OptionsBehavior.ReadOnly = true;
            _view.OptionsView.ShowGroupPanel = false;
            _view.OptionsView.ShowIndicator = false;
            _view.FocusRectStyle = DrawFocusRectStyle.None;

            _view.OptionsBehavior.Editable = false;
            // view.MouseMove += new System.Windows.Forms.MouseEventHandler(tileView_MouseMove);
            //_gdMAIN_VIEW.MouseDown += new System.Windows.Forms.MouseEventHandler(tileView_MouseDown);
            _view.OptionsNavigation.EnterMoveNextColumn = true;


            _grid.PaintEx += grid_Paint;
            _grid.DragOver += new System.Windows.Forms.DragEventHandler(grid_DragOver);
            _grid.DragDrop += new System.Windows.Forms.DragEventHandler(grid_DragDrop);

            _view.MouseMove += view_MouseMove;
            _view.MouseDown += view_MouseDown;

            

            DevExpress.XtraGrid.Columns.GridColumn pGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            pGridColumn.Name = "production_order_id"; // 컬럼 헤더 명칭               
            pGridColumn.Caption = "지시번호"; //컬럼 해더 제목
            pGridColumn.FieldName = "production_order_id"; // 컬럼 필드명
            pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            pGridColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default;
            pGridColumn.ShowUnboundExpressionMenu = false;
            pGridColumn.Visible = true;
            _view.Columns.Add(pGridColumn);

            pGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            pGridColumn.Name = "production_order_date"; // 컬럼 헤더 명칭               
            pGridColumn.Caption = "지시일자"; //컬럼 해더 제목
            pGridColumn.FieldName = "production_order_date"; // 컬럼 필드명
            pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            pGridColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default;
            pGridColumn.ShowUnboundExpressionMenu = false;
            pGridColumn.Visible = false;
            _view.Columns.Add(pGridColumn);

            pGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            pGridColumn.Name = "production_order_seq"; // 컬럼 헤더 명칭               
            pGridColumn.Caption = "지시순번"; //컬럼 해더 제목
            pGridColumn.FieldName = "production_order_seq"; // 컬럼 필드명
            pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            pGridColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default;
            pGridColumn.ShowUnboundExpressionMenu = false;
            pGridColumn.Visible = false;
            _view.Columns.Add(pGridColumn);

            pGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            pGridColumn.Name = "part_code"; // 컬럼 헤더 명칭               
            pGridColumn.Caption = "제품코드"; //컬럼 해더 제목
            pGridColumn.FieldName = "part_code"; // 컬럼 필드명
            pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            pGridColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default;
            pGridColumn.ShowUnboundExpressionMenu = false;
            pGridColumn.Visible = false;
            _view.Columns.Add(pGridColumn);

            pGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            pGridColumn.Name = "PART_NAME"; // 컬럼 헤더 명칭               
            pGridColumn.Caption = "제품명"; //컬럼 해더 제목
            pGridColumn.FieldName = "PART_NAME"; // 컬럼 필드명
            pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            pGridColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default;
            pGridColumn.ShowUnboundExpressionMenu = false;
            pGridColumn.Visible = true;
            _view.Columns.Add(pGridColumn);

            pGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            pGridColumn.Name = "production_order_qty"; // 컬럼 헤더 명칭               
            pGridColumn.Caption = "작업수량"; //컬럼 해더 제목
            pGridColumn.FieldName = "production_order_qty"; // 컬럼 필드명
            pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            pGridColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default;
            pGridColumn.ShowUnboundExpressionMenu = false;
            pGridColumn.Visible = true;
            _view.Columns.Add(pGridColumn);

            pGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            pGridColumn.Name = "routing_revision_no"; // 컬럼 헤더 명칭               
            pGridColumn.Caption = "리비전번호"; //컬럼 해더 제목
            pGridColumn.FieldName = "routing_revision_no"; // 컬럼 필드명
            pGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            pGridColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default;
            pGridColumn.ShowUnboundExpressionMenu = false;
            pGridColumn.Visible = false;
            _view.Columns.Add(pGridColumn);

            return _view;


            
        }

        private void GetGrid()
        {
            DataTable dt = new Scheduling_T50Business().ucScheduling_T50_OrderList(_pScheduling_T50Entity);
            //if(dt.Rows.Count > 0)
            //{
            _gdMAIN.DataSource = dt;
            _gdMAIN_VIEW.BestFitColumns();

            //_gdMAIN_VIEW.Columns["production_order_id"].Caption = "작지번호";
            //}
        }

        private void grid_Paint(object sender, PaintExEventArgs e) // PaintEventArgs
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

            e.Cache.DrawLine(Pens.Blue, p1, p2);
            //e.Graphics.DrawLine(Pens.Blue, p1, p2);
        }

        private void tileView_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //TileView view = sender as TileView;
            //if (view == null) return;
            //tileDownHitInfo = null;
            //TileViewHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            //if (Control.ModifierKeys != Keys.None) return;
            //if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            //    tileDownHitInfo = hitInfo;
        }
        private void grid_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void grid_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            DevExpress.XtraGrid.GridControl grid = sender as DevExpress.XtraGrid.GridControl;
            //if (grid.Name == "_gdMAIN")
            //    return;
            DataTable table = grid.DataSource as DataTable;
            DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;
            if (row != null && table != null && row.Table != table)
            {
                if (row.ItemArray.Length < 7)
                    return;
                //bool isChack = CoFAS_ConvertManager.DataTable_FindCount(table, String.Format("CONFIGURATION_CODE = '{0}'", row["CONFIGURATION_CODE"].ToString()), "");
                //if (!isChack)
                //{
                //table.ImportRow(row);

                _pScheduling_T50Entity.ORDER_ID = row["PRODUCTION_ORDER_ID"].ToString();
                _pScheduling_T50Entity.ORDER_SEQ = row["PRODUCTION_ORDER_SEQ"].ToString();
                _pScheduling_T50Entity.order_date = row["PRODUCTION_ORDER_DATE"].ToString();

                DataTable dt = new Scheduling_T50Business().ucScheduling_T50_U10(_pScheduling_T50Entity);

                GetGrid();

                OnPopup(this, new EventArgs());

                //}
            }
        }

        private void view_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
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
            catch(Exception ex)
            {

            }
        }

        private void view_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

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
            catch(Exception ex)
            {

            }
        }

        private bool IsNewItemRowFocused(object sender)
        {
            GridView view = sender as GridView;
            return view.IsNewItemRow(view.FocusedRowHandle);
        }

        private bool IsNewItemRowClicked(object sender, MouseEventArgs e)
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

        private void ucScheduling_T50_Load(object sender, EventArgs e)
        {
            _gdMAIN_VIEW = SetGrid(_gdMAIN);
            GetGrid();
        }

        private void picUp_Click(object sender, EventArgs e)
        {
            OrderUpdate("UP");
        }

        private void picDown_Click(object sender, EventArgs e)
        {
            OrderUpdate("DOWN");
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            OrderUpdate("DELETE");
            OnPopup(this, new EventArgs());
        }

        private void OrderUpdate(string status)
        {
            DataRow dr = _gdMAIN_VIEW.GetFocusedDataRow();

            if (dr == null)
                return;

            _pScheduling_T50Entity.ORDER_ID = dr["PRODUCTION_ORDER_ID"].ToString();
            _pScheduling_T50Entity.ORDER_SEQ = dr["PRODUCTION_ORDER_SEQ"].ToString();
            _pScheduling_T50Entity.order_date = dr["PRODUCTION_ORDER_DATE"].ToString();

            _pScheduling_T50Entity.USER_SEQ = int.Parse(dr["ORDER_SEQ"].ToString());
            _pScheduling_T50Entity.CRUD = status;

            DataTable dt = new Scheduling_T50Business().ucScheduling_T50_U11(_pScheduling_T50Entity);
            int [] rowf = _gdMAIN_VIEW.GetSelectedRows();
            GetGrid();

            if (rowf.Length > 0)
            {
                int nowrowseq = rowf[0];
                switch (status)
                {
                    case "UP":
                        if (nowrowseq >= 1)
                            nowrowseq--;
                        break;

                    case "DOWN":
                        if (nowrowseq < _gdMAIN_VIEW.RowCount-1)
                            nowrowseq++;
                        break;

                    case "DELETE":

                        break;
                }
                _gdMAIN_VIEW.FocusedRowHandle = nowrowseq;
                //_gdMAIN_VIEW.SelectRow(nowrowseq);
            }
            
        }

    }

    //class ucCursorCreator
    //{
    //    [DllImport("user32.dll")]
    //    [return: MarshalAs(UnmanagedType.Bool)]
    //    public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

    //    [DllImport("user32.dll")]
    //    public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

    //    public struct IconInfo
    //    {
    //        public bool fIcon;
    //        public int xHotspot;
    //        public int yHotspot;
    //        public IntPtr hbmMask;
    //        public IntPtr hbmColor;
    //    }

    //    public static Cursor CreateCursor(Bitmap bmp, Point hotspot)
    //    {
    //        if (bmp == null)
    //            return Cursors.Default;
    //        IntPtr ptr = bmp.GetHicon();
    //        IconInfo tmp = new IconInfo();
    //        GetIconInfo(ptr, ref tmp);
    //        tmp.fIcon = false;
    //        tmp.xHotspot = hotspot.X;
    //        tmp.yHotspot = hotspot.Y;
    //        ptr = CreateIconIndirect(ref tmp);
    //        return new Cursor(ptr);

    //    }
    //}

    //public class CoFAS_DragGridImageHelperUC : GridPainter
    //{
    //    private DevExpress.XtraGrid.Views.Grid.GridView _view;
    //    //private readonly DevExpress.XtraGrid.Views.Grid.GridView _view = new DevExpress.XtraGrid.Views.Grid.GridView();
    //    public CoFAS_DragGridImageHelperUC(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
    //    {
    //        _view = view;
    //    }

    //    public Cursor GetDragCursor(int rowHandle, Point e)
    //    {
    //        GridViewInfo info = _view.GetViewInfo() as GridViewInfo;
    //        GridRowInfo rowInfo = info.GetGridRowInfo(rowHandle);
    //        Bitmap result = GetRowDragBitmap(rowHandle);
    //        Point offset = new Point(rowInfo.Bounds.X, e.Y - rowInfo.Bounds.Y);
    //        return ucCursorCreator.CreateCursor(result, offset);
    //    }

    //    public Bitmap GetRowDragBitmap(int rowHandle)
    //    {
    //        Bitmap bmpView = null;
    //        Bitmap bmpRow = null;
    //        GridViewInfo info = _view.GetViewInfo() as GridViewInfo;
    //        Rectangle totalBounds = info.Bounds;
    //        GridRowInfo ri = info.GetGridRowInfo(rowHandle);
    //        Rectangle imageBounds = new Rectangle(new Point(0, 0), ri.Bounds.Size);
    //        try
    //        {
    //            bmpView = new Bitmap(totalBounds.Width, totalBounds.Height);
    //            using (Graphics gView = Graphics.FromImage(bmpView))
    //            {
    //                using (XtraBufferedGraphics grView = XtraBufferedGraphicsManager.Current.Allocate(gView, new Rectangle(Point.Empty, bmpView.Size)))
    //                {
    //                    Color color = ri.Appearance.BackColor == Color.Transparent ? Color.White : ri.Appearance.BackColor;
    //                    grView.Graphics.Clear(color);
    //                    GridViewDrawArgs args = new GridViewDrawArgs(new GraphicsCache(grView.Graphics), info, totalBounds);
    //                    DrawRow(args, ri);
    //                    grView.Graphics.FillRectangle(args.Cache.GetSolidBrush(Color.Transparent), ri.Bounds);
    //                    grView.Render();
    //                    bmpRow = new Bitmap(ri.Bounds.Width, ri.Bounds.Height);
    //                    using (Graphics gRow = Graphics.FromImage(bmpRow))
    //                    {
    //                        using (XtraBufferedGraphics grRow = XtraBufferedGraphicsManager.Current.Allocate(gRow, new Rectangle(Point.Empty, bmpRow.Size)))
    //                        {
    //                            grRow.Graphics.Clear(color);
    //                            grRow.Graphics.DrawImage(bmpView, imageBounds, ri.Bounds, GraphicsUnit.Pixel);
    //                            grRow.Render();
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //        catch
    //        {
    //        }
    //        return bmpRow;
    //    }



    //}
}
