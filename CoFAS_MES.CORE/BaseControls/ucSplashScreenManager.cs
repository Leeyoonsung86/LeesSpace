using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace CoFAS_MES.CORE.BaseControls
{
    public partial class ucSplashScreenManager : UserControl
    {

        SplashScreenManager dxSplashScreen = new SplashScreenManager();

        public ucSplashScreenManager()
        {
            InitializeComponent();
        }
    }
}
