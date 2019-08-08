using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoFAS_MES.CORE.Function;

namespace CoFAS_MES.POP
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
                string myCultureInfo = Thread.CurrentThread.CurrentCulture.ToString();
                myCultureInfo = "ja-JP";
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
                Properties.Settings.Default.MULTI_LANGUAGE = "日本";
                //        break;
                //    case "zh-CN":
                //        Properties.Settings.Default.MULTI_LANGUAGE = "中国";
                //        break;
                //}

                string strCorpCode = Properties.Settings.Default.CORP_CODE.ToString();
                //if (strCorpCode == "0313533074")
                //{
                Application.Run(new CoFAS_MES.POP.frmPOPLogin_T03());

                //}
                //else if(strCorpCode == "0319965552")
                //{
                //    Application.Run(new CoFAS_MES.POP.frmPOPLogin_T08());
                //}
                //else if (strCorpCode == "0313660093")  // 진영
                //{
                //    Application.Run(new CoFAS_MES.POP.frmPOPLogin_T05());
                //}
                //else if (strCorpCode == "0313526585")  // 대성
                //{
                //    Application.Run(new CoFAS_MES.POP.frmPOPLogin_T06());
                //}
                //else if (strCorpCode == "0325205959")  // 크레아
                //{
                //      Application.Run(new frmPOPLogin_T04()); //게더링
                //    Application.Run(new CoFAS_MES.POP.frmMainPrinter());  // 작업지시

                //}
                //else if (strCorpCode == "9999999995")
                //{
                //    Application.Run(new CoFAS_MES.POP.frmPOPExcel());

                //}
                //else if (Properties.Settings.Default.DB_NAME == "coever_mes_ds")
                //{
                //    Application.Run(new CoFAS_MES.POP.frmPOPLogin_T06());
                //}
                //else if (Properties.Settings.Default.DB_NAME == "coever_mes_hwt")
                //{
                //    Application.Run(new CoFAS_MES.POP.frmPOPLogin_T51());
                //    Application.Run(new frmPOPLogin_T04()); //게더링
                //}
                //else if (Properties.Settings.Default.DB_NAME == "coever_mes_hpnc")
                //{
                //    Application.Run(new CoFAS_MES.POP.frmPOPLogin_T01());
                //}
                //else if (Properties.Settings.Default.DB_NAME == "coever_mes_viomix")
                //{
                //    Application.Run(new CoFAS_MES.POP.frmPOPLogin_T07());
                //}
                //else if (Properties.Settings.Default.DB_NAME == "coever_mes_biocerra")
                //{
                //    Application.Run(new CoFAS_MES.POP.frmPOPLogin_T09());
                //    Application.Run(new frmPOPLogin_T04()); //게더링
                //}
                //else if (Properties.Settings.Default.SERVER_IP.ToString() == "210.222.217.50")
                //{
                //    Application.Run(new frmPOPLogin_T02()); // 푸른들 POP
                //}
                //else if (strCorpCode == "0319965552")  // YB
                //{
                //    Application.Run(new CoFAS_MES.POP.frmPOPLogin_T08());
                //}
                //else
                //{

                //    Application.Run(new CoFAS_MES.POP.frmPOPMain());

                //    화장품(HPNC)
                //     Application.Run(new CoFAS_MES.POP.frmPOPMain_MATERIAL_COSMETICS());     //부자재실
                //    Application.Run(new CoFAS_MES.POP.frmPOPMain_RAWMATERIAL_COSMETICS());  //원재료실
                //     Application.Run(new CoFAS_MES.POP.frmPOPMain_PRODUCT_COSMETICS());      //제조,포장
                //     Application.Run(new CoFAS_MES.POP.frmPOPMain_OUT_COSMETICS());          //출고




                //    Application.Run(new frmPOPLogin_T04()); //게더링


                //      Application.Run(new frmPOPLogin_T01());


                //     Application.Run(new CoFAS_MES.POP.frmGatheringMain());

                //    Application.Run(new CoFAS_MES.POP.DBInterface());
                //    Application.Run(new CoFAS_MES.POP.DQGathering());
                //    Application.Run(new CoFAS_MES.POP.frmPOPLogin_T51());
                //    Application.Run(new frmPOPLogin_T04()); //게더링
                //}

                appMeutex.ReleaseMutex();
            }
        }
    }
}
