using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoFAS_MES.AUTO.UL
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool AlreadyRun;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Mutex appMeutex = new Mutex(true, Application.ProductName, out AlreadyRun);

            if (AlreadyRun)
            {
                Application.Run(new frmProgramUpload());
                appMeutex.ReleaseMutex();
            }
        }
    }
}
