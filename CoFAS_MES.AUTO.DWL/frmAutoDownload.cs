using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.AUTO.DWL.Business;
using CoFAS_MES.AUTO.DWL.Entity;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Function;
using System.Threading;

namespace CoFAS_MES.AUTO.DWL
{
    public partial class frmAutoDownload : frmBaseSingleNone
    {
        private AutoDownloadEntity pAutoDownloadEntity = null;

        //파일 다운로드 스레드
        Thread thStartAutoDownload;

        //다운로드 대상 폴더(업데이트한 파일을 이동할 폴더)
        private string strTargetPath = Application.StartupPath;

        //다운로드 임시 폴더
        private string strPathUpdate = Application.StartupPath + "\\"+ "FileTemporary";

        private string strFileType = "MES";

        //다운로드 완료 후 실행 파일
        private static string strStartFile = "CoFAS_MES.EXE";

        public frmAutoDownload()
        {
            InitializeComponent();
        }

        private void frmAutoDownload_Load(object sender, EventArgs e)
        {
            //디비 설정 및 프로그램 설정
            Initialize();

            //다운로드 스레드 처리
            thStartAutoDownload = new Thread(new ThreadStart(AutoDownload_Start));
            thStartAutoDownload.IsBackground = true;
            thStartAutoDownload.Start();
        }

        private void Initialize()
        {
            try
            {
                switch (Properties.Settings.Default.DB_TYPE.ToString())
                {
                    case "MySql":
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;
                        break;
                    case "SQLServer":
                        DBManager.PrimaryDBManagerType = DBManagerType.SQLServer;
                        break;
                    default:
                        DBManager.PrimaryDBManagerType = DBManagerType.MySql;
                        break;
                }

                DBManager.InitDatabaseServer = Properties.Settings.Default.SERVER_IP.ToString();
                DBManager.InitDatabaseName = Properties.Settings.Default.DB_NAME.ToString();
                DBManager.InitDatabaseID = Properties.Settings.Default.DB_ID.ToString();
                DBManager.InitDatabasePass = "coever119!#%";

                DBManager.PrimaryConnectionString = string.Format
               (
                   "Server={0};Database={1};UID={2};PWD={3}",
                   DBManager.InitDatabaseServer,//Properties.Settings.Default.SERVER_IP.ToString(),
                   DBManager.InitDatabaseName,  //Properties.Settings.Default.DB_NAME.ToString(),
                   DBManager.InitDatabaseID,    //Properties.Settings.Default.DB_ID.ToString(),
                   DBManager.InitDatabasePass   //"coever119!#%"
               );

                

                if (!CoFAS_FileManager.FolderExists(strPathUpdate))
                {
                    CoFAS_FileManager.FolderCreate(strPathUpdate);
                }

                pAutoDownloadEntity = new AutoDownloadEntity();

                pAutoDownloadEntity.CORP_CODE = Properties.Settings.Default.CORP_CODE.ToString();

                //clsLog.WLog("업데이트 프로그램을 실행합니다.\tv" + Application.ProductVersion);

            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Initialize()", pException);
            }
        }

        private void AutoDownload_Start()
        {
            try
            {

                DoEvent(true,string.Format("{0:D0}%", "0"));

                DoEvent(false, "File Download Start . . .");

                for (int i = 1; i < 11; i++)
                {
                    double dbl = i * 0.1;

                    CoFAS_ControlManager.InvokeIfNeeded(this, () => this.Opacity = dbl);

                    Thread.Sleep(150);
                    Application.DoEvents();
                }

                //FileTemporary 파일 삭제.
                CoFAS_FileManager.FolderFileDelete(strPathUpdate);

                //File 다운로드
                FileDownload();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                DoEvent(false, "File Download Complete . . .");
                //clsLog.WLog("업데이트 프로그램을 종료합니다.");
                try
                {
                    //파일 무브
                    FileMove();

                }
                catch(Exception ex)
                { }

                CoFAS_ControlManager.InvokeIfNeeded(this, () => this.Close());

            }
        }

        /// <summary>
        /// 파일 다운로드 처리 메세지 표시
        /// </summary>
        /// <param name="isTotalCount"></param>
        /// <param name="strMsg"></param>
        private void DoEvent(bool isTotalCount, string strMsg)
        {
            if(isTotalCount)
            {
                CoFAS_ControlManager.InvokeIfNeeded(_lbFileCount, () => _lbFileCount.Text = strMsg);
            }
            else
            {
                CoFAS_ControlManager.InvokeIfNeeded(_lbAutodownload, () => _lbAutodownload.Text = strMsg);
            }

            Application.DoEvents();
            Thread.Sleep(150);

        }

        /// <summary>
        /// 파일 다운로드
        /// </summary>
        private void FileDownload()
        {
            try
            {
                DoEvent(false, "Chack Download File...");

                pAutoDownloadEntity.FILE_TYPE = strFileType;

                using (DataTable dt = new AutoDownloadBusiness().FileInfo_GetList(pAutoDownloadEntity))
                {
                    int intUpdateTotalCount = dt.Rows.Count;
                    int intUpdateCount = 0;

                    DoEvent(false, string.Format("Update File List {0} Files - Start File Download...",intUpdateTotalCount.ToString()));

                    foreach(DataRow dr in dt.Rows)
                    {
                        intUpdateCount++;

                        CoFAS_ControlManager.InvokeIfNeeded(_lbFileCount, () => _lbFileCount.Text = string.Format("{0:D0}%  {1:D2}/{2:D2}", 100 * intUpdateCount / intUpdateTotalCount, intUpdateCount, intUpdateTotalCount));

                        CoFAS_ControlManager.InvokeIfNeeded(_pgrAutodownloadAll, () => {
                            _pgrAutodownloadAll.Properties.Maximum = intUpdateTotalCount;
                            _pgrAutodownloadAll.Properties.Minimum = 0;
                            _pgrAutodownloadAll.PerformStep();
                            _pgrAutodownloadAll.Update();
                        });

                        string strFileName = strTargetPath + @"\" + CoFAS_ConvertManager.obj2String(dr["FILENAME"]);
                        string strTempFileName = strPathUpdate + CoFAS_ConvertManager.obj2String(dr["FILENAME"]);
                        string strVersion = CoFAS_ConvertManager.obj2String(dr["VERSION"]);
                        DateTime dtFileDate = (DateTime)dr["FILE_DATE"];
                        string strCrc = CoFAS_ConvertManager.obj2String(dr["CRC"]);
                        int intFileSize = Convert.ToInt32(dr["FILE_SIZE"]);
                        bool isUpdate = false;

                        string strFileVersion = string.Empty;
                        DateTime dtFileFileDate = DateTime.Now;

                        isUpdate = false;

                        DoEvent(false, string.Format("Check the file '{0}'", dr["FILENAME"]));

                        if (CoFAS_FileManager.FileExists(strFileName))
                        {
                            System.IO.FileInfo fi = new System.IO.FileInfo(strFileName);

                            strFileVersion = CoFAS_ConvertManager.obj2String(CoFAS_FileManager.FileGetVersion(fi.FullName));
                            dtFileFileDate = fi.LastWriteTime;

                            if (strFileVersion != strVersion || CoFAS_ConvertManager.obj2String(dtFileFileDate) != CoFAS_ConvertManager.obj2String(dtFileDate))
                            {
                                isUpdate = true;
                            }

                        }
                        else
                        {
                            isUpdate = true;
                        }

                        int intErrCnt = 0;
                        while (isUpdate)
                        {

                            pAutoDownloadEntity.FILE_TYPE = "MES";
                            pAutoDownloadEntity.FILENAME = CoFAS_ConvertManager.obj2String(dr["FILENAME"]);
                            pAutoDownloadEntity.FILE_PATH = strPathUpdate;

                            string strFileCrc = new AutoDownloadBusiness().FileInfo_GetFileData(pAutoDownloadEntity);

                            GC.Collect();
                            Application.DoEvents();
                            GC.WaitForPendingFinalizers();

                            //crc검사
                            if (strCrc != strFileCrc)
                            {
                                intErrCnt++;

                                CoFAS_FileManager.FileDelete(strPathUpdate + CoFAS_ConvertManager.obj2String(dr["FILENAME"]));

                                //3회까지 시도한다.
                                if (intErrCnt > 2)
                                    isUpdate = false;
                                else
                                {
                                    isUpdate = true;
                                }
                            }
                            else
                            {
                                isUpdate = false;
                                System.IO.FileInfo fi = new System.IO.FileInfo(strTempFileName);
                                fi.LastWriteTime = dtFileDate;

                            }
                        }
                    }
                }

                DoEvent(false, string.Format("Completed downloading files from server"));

            }
            catch
            {
                throw;
            }
            finally
            {

            }

        }

        /// <summary>
        /// 다운로드 파일 상태 표시
        /// </summary>
        /// <param name="strFileName"></param>
        /// <param name="intTotalSize"></param>
        /// <param name="intRecevedFileSize"></param>
        private void FileDownloading(string strFileName, int intTotalSize, int intRecevedFileSize)
        {
            CoFAS_ControlManager.InvokeIfNeeded(_lbAutodownload, () => _lbAutodownload.Text = string.Format("{0} {1}/{2}kb", strFileName, intRecevedFileSize, intTotalSize));

            CoFAS_ControlManager.InvokeIfNeeded(_pgrAutodownloadFile, () => {
                _pgrAutodownloadFile.Properties.Maximum = intTotalSize;
                _pgrAutodownloadFile.Properties.Minimum = 0;
                _pgrAutodownloadFile.PerformStep();
                _pgrAutodownloadFile.Update();

            });

            //CoFAS_ControlManager.InvokeIfNeeded(_lbFileCount, () => _lbFileCount.Text = string.Format("{0:D0}%", 100 * intRecevedFileSize / intTotalSize));
        }

        /// <summary>
        /// 다운로드 파일 이동
        /// </summary>
        private void FileMove()
        {
            try
            {
                Thread.Sleep(500);

                //원본폴더 확인
                if (!CoFAS_FileManager.FolderExists(strPathUpdate)) return;

                CoFAS_FileManager.FolderFileMove(strPathUpdate, strTargetPath);
            }
            catch
            {
            }
            finally
            {
                if(CoFAS_FileManager.FileExists(strStartFile))
                {
                    try
                    {
                        System.Diagnostics.Process pro = new System.Diagnostics.Process();
                        pro.StartInfo.FileName = strStartFile;
                        pro.Start();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }

        }



        private void _btEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
