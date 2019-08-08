using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoFAS_MES
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
                //string myCultureInfo = Thread.CurrentThread.CurrentCulture.ToString();

                string myCultureInfo = "";// 

                switch(Properties.Settings.Default.MULTI_LANGUAGE.ToString())
                {
                    case "한국어":
                        myCultureInfo = "ko-KR";
                        break;
                    case "English":
                        myCultureInfo = "en-US";
                        break;
                    case "日本":
                        myCultureInfo = "ja-JP";
                        break;
                    case "中国":
                        myCultureInfo = "zh-CN";
                        break;

                }


                Thread.CurrentThread.CurrentCulture = new CultureInfo(myCultureInfo);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(myCultureInfo);


                //switch (myCultureInfo)
                //{
                //    case "ko-KR":
                //        Properties.Settings.Default.MULTI_LANGUAGE = "한국어";
                //        break;
                //    case "en-US":
                //        Properties.Settings.Default.MULTI_LANGUAGE = "English";
                //        break;
                //    case "ja-JP":
                //        Properties.Settings.Default.MULTI_LANGUAGE = "日本";
                //        break;
                //    case "zh-CN":
                //        Properties.Settings.Default.MULTI_LANGUAGE = "中国";
                //        break;
                //}



                try
                {
                    Application.Run(new frmLogin());
                    appMeutex.ReleaseMutex();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }

            }
        }
    }
}
