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

namespace CoFAS_MES.CORE.UserControls
{
    public partial class Clock : UserControl
    {
        Timer timer = new Timer();

        public Clock()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += OnTick;
            timer.Start();
            OnTick(null, null);

        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                DisableTimer();
            }
            base.Dispose(disposing);
        }

        void DisableTimer()
        {
            timer.Stop();
            timer = null;
        }

        void OnTick(object sender, EventArgs e)
        {
            if (IsDisposed)
            {
                DisableTimer();
                return;
            }
            System.DateTime currentDate = System.DateTime.Now;


            CoFAS_ControlManager.InvokeIfNeeded(labelControl1, () => labelControl1.Text = string.Format("{0:T}\r\n{1}", currentDate, currentDate.ToString("D")));
        }
    }
}
