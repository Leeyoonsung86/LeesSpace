using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Business;
using CoFAS_MES.CORE.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraPdfViewer.Commands;
using DevExpress.XtraPdfViewer.Controls;
using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Entity;
using System.Net;
using CoFAS_MES.POP;
using CoFAS_MES.POP.Function;

namespace CoFAS_MES.CORE.UserForm
{
    public partial class frmPdfView_T50 : frmBaseSingle
    {
        private static string _pCORP_CODE = string.Empty;       // 회사코드       
        private static string _pUSER_CODE = string.Empty;       // 사용자 ID (이메일)     
        private static string _pWINDOW_NAME = string.Empty;     // 화면명칭 
        private static string _pLANGUAGE_TYPE = string.Empty;   // 시스템 언어

        private static Font fntPARENT_FONT = null;

        private string _pFindControl = "";

        private static FileStream _pStream = null;
        private static MemoryStream _pStream2 = null;
        private static string _part_code = string.Empty;
        private static string _pFTP_ID = string.Empty;          // FTP ID 정보
        private static string _pFTP_PATH = string.Empty;     // FTP SERVER IP 정보
        private static string _pFTP_PW = string.Empty;          //FTP PW 정보

        PdfViewerCommand zoomIn;
        PdfViewerCommand zoomOut;
        PdfHandToolCommand handtool;

        private DataTable _dtList = null; //조회 데이터 리스트
        private POPWorkResult_T50Entity _pPOPWorkResult_T50Entity = null;
        private string Image_nm = null;


        public static string CORP_CDDE
        {
            get { return _pCORP_CODE; }
            set { _pCORP_CODE = value; }
        }
        public static string USER_CODE
        {
            get { return _pUSER_CODE; }
            set { _pUSER_CODE = value; }
        }
        public static string LANGUAGE_TYPE
        {
            get { return _pLANGUAGE_TYPE; }
            set { _pLANGUAGE_TYPE = value; }
        }
        public static Font FONT_TYPE
        {
            get { return fntPARENT_FONT; }
            set { fntPARENT_FONT = value; }
        }

        public static FileStream FILE_STREAM
        {
            get { return _pStream; }
            set { _pStream = value; }
        }

        public static MemoryStream MS
        {
            get { return _pStream2; }
            set { _pStream2 = value; }
        }

        public static string PART_CODE
        {
            get { return _part_code; }
            set { _part_code = value; }
        }

        public static string FTP_ID
        {
            get { return _pFTP_ID; }
            set { _pFTP_ID = value; }
        }
        public static string FTP_PATH
        {
            get { return _pFTP_PATH; }
            set { _pFTP_PATH = value; }
        }
        public static string FTP_PW
        {
            get { return _pFTP_PW; }
            set { _pFTP_PW = value; }
        }


        public frmPdfView_T50()
        {
            InitializeComponent();

            _pWINDOW_NAME = this.Name.ToString();
                        
            InitializeSetting();
            _pdfViewer.ZoomFactor = 40;
            zoomIn = new PdfZoomInCommand(_pdfViewer);
            zoomOut = new PdfZoomOutCommand(_pdfViewer);
            //handtool = new PdfHandToolCommand(_pdfViewer);

            _pdfViewer.CursorMode = PdfCursorMode.HandTool;

            //20181213 메모리스트림 처리 추가
            if (_pStream != null)
            {
                _pdfViewer.LoadDocument(_pStream);
            }
            else
            {
                _pdfViewer.LoadDocument(_pStream2);
            }
        }

        private void InitializeSetting()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            

            //화면 설정 언어 & 명칭 변경. ==고정==
            DataTable dtLanguage = new LanguageBusiness().Language_Info(_pWINDOW_NAME, _pLANGUAGE_TYPE);

            if (dtLanguage != null && dtLanguage.Rows.Count > 0)
            {
                CoFAS_ControlManager.Language_Info(dtLanguage, this);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (zoomIn.CanExecute())
                zoomIn.Execute();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (zoomOut.CanExecute())
                zoomOut.Execute();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //도면
        private void labelControl1_Click(object sender, EventArgs e)
        {
            if(_dtList != null)
                _dtList.Rows.Clear();   

            _pPOPWorkResult_T50Entity = new POPWorkResult_T50Entity();
            _pPOPWorkResult_T50Entity.PART_CODE = _part_code;
            DataTable dt = MS_DBClass.USP_POP_FILE(_part_code);

            MemoryStream _ms = new MemoryStream();
            if (dt != null && dt.Rows.Count > 0)
            {
                
                if (dt.Rows[0][5] != null)
                {
                    _ms = new MemoryStream((byte[])dt.Rows[0][5]);
                    _pdfViewer.LoadDocument(_ms);
                }
                else
                {
                    //No Image
                    string strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/{3}/", _pFTP_PATH, "ITEM", "ITEM_IMAGE", "ProductInformationRegister");

                    var stream = CoFAS_FTPManager.FTPImage(strFTP_PATH, "Noimage.pdf", _pFTP_ID, _pFTP_PW);

                    _ms = new MemoryStream();
                    byte[] buffer = new byte[16 * 1024];
                    int read;
                    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        _ms.Write(buffer, 0, read);
                    }
                    _pdfViewer.LoadDocument(_ms);
                }               
            }
            else
            {
                //No Image
                string strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/{3}/", _pFTP_PATH, "ITEM", "ITEM_IMAGE", "ProductInformationRegister");

                var stream = CoFAS_FTPManager.FTPImage(strFTP_PATH, "Noimage.pdf", _pFTP_ID, _pFTP_PW);

                _ms = new MemoryStream();
                byte[] buffer = new byte[16 * 1024];
                int read;
                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    _ms.Write(buffer, 0, read);
                }
                _pdfViewer.LoadDocument(_ms);
            }


            //getImage(Image_nm);
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            ///ftp서버에 있는 작업표준서 리스트를 보여준고
            ///선택한 작업표준서를 띄워준다.
            ///파일은 pdf 형식으로 제한한다.

            DataTable dt = new DataTable();
            dt.Columns.Add("FILENAME");

            

            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _pFTP_PATH + "FILE_DATA/%2F/CD050005/");
            ftpRequest.Credentials = new NetworkCredential(_pFTP_ID, _pFTP_PW);
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());

            List<string> directories = new List<string>();

            string line = streamReader.ReadLine();
            int i = 0;
            while (!string.IsNullOrEmpty(line))
            {
                if (line.Contains(".pdf"))
                {
                    if (!line.Contains("Noimage"))
                    {
                        DataRow dtrow = dt.NewRow();
                        dtrow["FILENAME"] = line;
                        dt.Rows.Add(dtrow);
                        directories.Add(line);

                        i++;
                    }
                }
                line = streamReader.ReadLine();
            }

            frmPOPWorkpage_T50.dtIn = dt;
            frmPOPWorkpage_T50 xfrmPOPWorkpage_T50 = new frmPOPWorkpage_T50();
            xfrmPOPWorkpage_T50.ShowDialog();

            
            if (xfrmPOPWorkpage_T50.dtReturn == null || xfrmPOPWorkpage_T50.dtReturn.Rows.Count == 0)
            {
                xfrmPOPWorkpage_T50.Dispose();
                return;
            }
            getImage(xfrmPOPWorkpage_T50.dtReturn.Rows[0]["FILENAME"].ToString());

            streamReader.Close();
        }

        private void getImage(string filename)
        {                                                  
            if (filename == "")
            {
               
                string strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/{3}/", _pFTP_PATH, "ITEM", "ITEM_IMAGE", "ProductInformationRegister");
                var stream = CoFAS_FTPManager.FTPImage(strFTP_PATH, "Noimage.pdf", _pFTP_ID, _pFTP_PW);

                MemoryStream _ms = new MemoryStream();

                byte[] buffer = new byte[16 * 1024];
                int read;
                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    _ms.Write(buffer, 0, read);
                }
                _pdfViewer.LoadDocument(_ms);
            }
            else
            {
                //pdf 일경우 
                if (filename.Contains(".pdf"))
                {
                    if (filename.IndexOf("*NoSave*") > -1 || filename.Trim().Length < 4)
                    {
                        CoFAS_DevExpressManager.ShowInformationMessage("저장하지 않아서 볼 수 없습니다.");
                    }
                    else
                    {
                        string strFTP_PATH = string.Format(@"{0}{1}/%2F/{2}/", _pFTP_PATH, "FILE_DATA", "CD050005");
                        var stream = CoFAS_FTPManager.FTPImage(strFTP_PATH, filename, _pFTP_ID, _pFTP_PW);

                        //해당 이미지가 ftp서버에 없을때.
                        if(stream == null)
                            stream = CoFAS_FTPManager.FTPImage(strFTP_PATH, "Noimage.pdf", _pFTP_ID, _pFTP_PW);

                        MemoryStream _ms = new MemoryStream();

                        byte[] buffer = new byte[16 * 1024];
                        int read;
                        while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            _ms.Write(buffer, 0, read);
                        }
                        _pdfViewer.LoadDocument(_ms);
                    }
                }
            }            
        }





    }
}
