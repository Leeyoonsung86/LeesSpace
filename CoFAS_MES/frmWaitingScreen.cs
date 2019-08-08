using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.Utils.Drawing;
using DevExpress.Skins;

namespace CoFAS_MES
{
    public partial class frmWaitingScreen : SplashScreen
    {
        public frmWaitingScreen()
        {
            InitializeComponent();
        }
        protected override void DrawTopElement(GraphicsCache graphicsCache, Skin skin)
        {
            if (!UseCustomBackColor)
            {
                base.DrawTopElement(graphicsCache, skin);
                return;
            }
            DrawCustomBackground(graphicsCache);
        }
        protected override void DrawContent(GraphicsCache graphicsCache, Skin skin)
        {
            if (!UseCustomBackColor)
            {
                base.DrawContent(graphicsCache, skin);
                return;
            }
            DrawCustomBackground(graphicsCache);
        }
        protected void DrawCustomBackground(GraphicsCache graphicsCache)
        {
            graphicsCache.FillRectangle(Color.FromArgb(60, 70, 90), ClientRectangle);
        }
        protected virtual bool UseCustomBackColor { get { return true; } }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}