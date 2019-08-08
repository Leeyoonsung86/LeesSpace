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
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Entity;

using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Widget;

namespace CoFAS_MES.CORE.UserControls
{
    public partial class DashboardHomeWidgets : UserControl
    {
        //Random random = new Random();

        private static DashboardHomeWidgets _instance;
        public static DashboardHomeWidgets Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DashboardHomeWidgets();
                }
                return _instance;
            }
        }

        public DashboardHomeWidgets()
        {
            InitializeComponent();

            widgetView1.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            widgetView1.QueryControl += OnQueryControl;
            SetWidgetsAppearances();
            foreach (Document item in widgetView1.Documents)
            {
                item.Width = (int)Math.Round(item.Width * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
                item.Height = (int)Math.Round(item.Height * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
            }
            ApplyLayoutMode(widgetView1.LayoutMode);

        }

        void OnQueryControl(object sender, QueryControlEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Document.ControlTypeName))
                e.Control = Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)) as Control;
            else
                e.Control = new Control();
        }
        void ApplyLayoutMode(LayoutMode layoutMode)
        {
            widgetView1.BeginUpdateAnimation();
            widgetView1.LayoutMode = layoutMode;

            widgetView1.EndUpdateAnimation();
        }

        //void StackLayoutMix()
        //{
        //    int randomIndex = 0;
        //    try
        //    {
        //        widgetView1.BeginUpdateAnimation();
        //        foreach (Document document in widgetView1.Documents)
        //        {
        //            StackGroup oldGroup = document.Parent;
        //            if (oldGroup != null)
        //                oldGroup.Items.Remove(document);
        //            randomIndex = random.Next(widgetView1.StackGroups.Count);
        //            widgetView1.StackGroups[randomIndex].Items.Add(document);
        //        }
        //    }
        //    finally
        //    {
        //        widgetView1.EndUpdateAnimation();
        //    }
        //}
        //void TableLayoutMix()
        //{
        //    try
        //    {
        //        widgetView1.BeginUpdateAnimation();
        //        List<Point> points = new List<Point>();
        //        for (int i = 0; i < 3; i++)
        //        {
        //            for (int j = 0; j < 3; j++)
        //            {
        //                points.Add(new Point(i, j));
        //            }
        //        }
        //        foreach (Document document in widgetView1.Documents)
        //        {
        //            Point newLocation = points[random.Next(points.Count)];
        //            document.RowIndex = newLocation.Y;
        //            document.ColumnIndex = newLocation.X;
        //            points.Remove(newLocation);
        //        }
        //    }
        //    finally
        //    {
        //        widgetView1.EndUpdateAnimation();
        //    }
        //}
        //void FlowLayoutMix()
        //{
        //    int index = 0;
        //    Document document = new Document();
        //    try
        //    {
        //        widgetView1.BeginUpdateAnimation();
        //        for (int i = 0; i < widgetView1.FlowLayoutProperties.FlowLayoutItems.Count; i++)
        //        {
        //            index = random.Next(widgetView1.Documents.Count);
        //            if (i == index) continue;
        //            document = widgetView1.FlowLayoutProperties.FlowLayoutItems[i];
        //            widgetView1.FlowLayoutProperties.FlowLayoutItems.Remove(document);
        //            widgetView1.FlowLayoutProperties.FlowLayoutItems.Insert(index, document);
        //        }
        //    }
        //    finally
        //    {
        //        widgetView1.EndUpdateAnimation();
        //    }
        //}

        void SetWidgetsAppearances()
        {
            List<BaseDocument> documents = new List<BaseDocument>();
            documents.AddRange(widgetView1.Documents.ToArray());
            documents.AddRange(widgetView1.FloatDocuments.ToArray());
            for (int i = 0; i < documents.Count; i++)
            {
                Document document = documents[i] as Document;
                document.AppearanceActiveCaption.BackColor = Color.Transparent;// WidgetColors[i % WidgetColors.Length];
                document.AppearanceCaption.BackColor = Color.Transparent;//WidgetColors[i % WidgetColors.Length];
            }
        }

    }
}
