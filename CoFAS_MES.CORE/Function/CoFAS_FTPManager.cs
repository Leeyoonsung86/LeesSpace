using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.CORE.Function
{
    public static class CoFAS_FTPManager
    {
        #region ○ FTP 삭제
        public static bool FTPDelete(string qFilename, string qPath, string qFTP_ID, string qFTP_PW)
        {
            try
            {
                FtpWebRequest requestFileDelete = (FtpWebRequest)WebRequest.Create("ftp://" + qPath + qFilename);
                requestFileDelete.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                requestFileDelete.Method = WebRequestMethods.Ftp.DeleteFile;

                FtpWebResponse responseFileDelete = (FtpWebResponse)requestFileDelete.GetResponse();
                responseFileDelete.Close();
                return true;
            }
            catch(WebException pException)
            {
                return false;
            }

            
        }
        #endregion

        #region ○ FTP 이미지
        public static Stream FTPImage(string qFTPPath, string qFileName, string qFTP_ID, string qFTP_PW)
        {
            Stream responseStream;
            try
            {

                FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create("ftp://" + qFTPPath + qFileName);
                requestFileDownload.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;

                FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();

                responseStream = responseFileDownload.GetResponseStream();

            }
            catch (Exception pException)
            {
                responseStream = null;
            }
            //FileStream writeStream = new FileStream(qFTPLocalPath, FileMode.Create);

            //int pLength = 102400;
            //Byte[] buffer = new Byte[pLength];
            //int bytesRead = responseStream.Read(buffer, 0, pLength);

            //while (bytesRead > 0)
            //{
            //    writeStream.Write(buffer, 0, bytesRead);
            //    bytesRead = responseStream.Read(buffer, 0, pLength);
            //}

           
            //writeStream.Close();

            //MemoryStream ms = new MemoryStream();

            //int read;
            //while ((read = responseStream.Read(buffer, 0, buffer.Length)) > 0)
            //{
            //    ms.Write(buffer, 0, read);
            //}

            //responseStream.Close();


            return responseStream; //ms.ToArray();
        }
        #endregion

        #region ○ FTP 다운로드
        //저장하고 열기
        public static void FTPDownLoad(string qFTPPath, string qFileName, string qFTP_ID, string qFTP_PW, string qFTPLocalPath)
        {
            FileInfo f = new FileInfo(qFTPLocalPath + qFileName);
            if (f.Exists)
            {
                f.Delete();
            }

            FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create("ftp://" + qFTPPath + qFileName);
            requestFileDownload.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
            requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;

            FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();

            Stream responseStream = responseFileDownload.GetResponseStream();
            FileStream writeStream = new FileStream(qFTPLocalPath, FileMode.Create);

            int pLength = 102400;
            Byte[] buffer = new Byte[pLength];
            int bytesRead = responseStream.Read(buffer, 0, pLength);

            while (bytesRead > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
                bytesRead = responseStream.Read(buffer, 0, pLength);
            }

            responseStream.Close();
            writeStream.Close();

            Process.Start(qFTPLocalPath);   //다운로드된 폴더 열기
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="qFTPPath 저장할 경로+화일명+확장자"></param>
        /// <param name="qFileName 서버에서 읽어올 화일명"></param>
        /// <param name="qFTP_ID"></param>
        /// <param name="qFTP_PW"></param>
        /// <param name="qFTPLocalPath"></param>
        /// <param name="qOpenYN"></param>
        public static void FTPDownLoad(string qFTPPath, string qFileName, string qFTP_ID, string qFTP_PW, string qFTPLocalPath,bool qOpenYN)
        {
            FileInfo f = new FileInfo(qFTPLocalPath + qFileName);
            if (f.Exists)
            {
                f.Delete();
            }

            FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create("ftp://" + qFTPPath + qFileName);
            requestFileDownload.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
            requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;

            FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();

            Stream responseStream = responseFileDownload.GetResponseStream();
            FileStream writeStream = new FileStream(qFTPLocalPath, FileMode.Create);

            int pLength = 102400;
            Byte[] buffer = new Byte[pLength];
            int bytesRead = responseStream.Read(buffer, 0, pLength);

            while (bytesRead > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
                bytesRead = responseStream.Read(buffer, 0, pLength);
            }

            responseStream.Close();
            writeStream.Close();

            if(qOpenYN)
                Process.Start(qFTPLocalPath);   //다운로드된 폴더 열기
        }

        public static void FTPDownLoad2(string qFTPPath, string qFileName, string qFTP_ID, string qFTP_PW, string qFTPLocalPath, bool qOpenYN)
        {
            FileInfo f = new FileInfo(qFTPLocalPath);
            if (f.Exists)
            {
                f.Delete();
            }

            FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create("ftp://" + qFTPPath + qFileName);
            requestFileDownload.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
            requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;

            FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();

            Stream responseStream = responseFileDownload.GetResponseStream();
            FileStream writeStream = new FileStream(qFTPLocalPath, FileMode.Create);

            int pLength = 102400;
            Byte[] buffer = new Byte[pLength];
            int bytesRead = responseStream.Read(buffer, 0, pLength);

            while (bytesRead > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
                bytesRead = responseStream.Read(buffer, 0, pLength);
            }

            responseStream.Close();
            writeStream.Close();

            if (qOpenYN)
                Process.Start(qFTPLocalPath);   //다운로드된 폴더 열기
        }

        #endregion


        public static void FTPFileView(string qFTPPath, string qFileName, string qFTP_ID, string qFTP_PW, string qFTPLocalPath)
        {
            FileInfo f = new FileInfo(qFTPLocalPath);
            if (f.Exists)
            {
                f.Delete();
            }

            FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create("ftp://" + qFTPPath + qFileName);
            requestFileDownload.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
            requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;

            if (requestFileDownload == null)
            {
                CoFAS_DevExpressManager.ShowInformationMessage("File Not Found!");
                return;
            }

            FtpWebResponse responseFileDownload;

            try {
                responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();
            }
            catch(Exception ex)
            {
                CoFAS_DevExpressManager.ShowErrorMessage("File Not Found!");
                return;
            }

            

            Stream responseStream = responseFileDownload.GetResponseStream();

            FileStream writeStream = new FileStream(qFTPLocalPath, FileMode.Create);         

            int pLength = 102400;
            Byte[] buffer = new Byte[pLength];
            int bytesRead = responseStream.Read(buffer, 0, pLength);

            while (bytesRead > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
                bytesRead = responseStream.Read(buffer, 0, pLength);
            }
            responseStream.Close();
            writeStream.Close();

            Process.Start(qFTPLocalPath);   //다운로드된 폴더 열기
        }

        #region ○ FTP 업로드
        //public static void FTPUpload(string pFileName, string qPath, string qFullName, string qFTP_ID, string qFTP_PW, string qFTP_Path)
        public static void FTPUpload(string pFileName, string qFullName, string qFTP_ID, string qFTP_PW, string qFTP_Path)
        {
            try
            {
                // 파일존재확인
                CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(qFTP_Path, qFTP_ID, qFTP_PW);
                if (qFTPUtil.IsFTPFileExsit(qFTP_Path + pFileName))
                {
                    // 파일삭제하기
                    FtpWebRequest requestFileDelete = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + pFileName);
                    requestFileDelete.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                    requestFileDelete.Method = WebRequestMethods.Ftp.DeleteFile;

                    FtpWebResponse responseFileDelete = (FtpWebResponse)requestFileDelete.GetResponse();
                }

                FtpWebRequest requestFTPUploader = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + pFileName);
                requestFTPUploader.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                requestFTPUploader.Method = WebRequestMethods.Ftp.UploadFile;

                FileInfo fileInfo = new FileInfo(qFullName);
                FileStream fileStream = fileInfo.OpenRead();

                int bufferLength = 102400;
                byte[] buffer = new byte[bufferLength];

                Stream uploadStream = requestFTPUploader.GetRequestStream();
                int contentLength = fileStream.Read(buffer, 0, bufferLength);

                while (contentLength != 0)
                {
                    uploadStream.Write(buffer, 0, contentLength);
                    contentLength = fileStream.Read(buffer, 0, bufferLength);
                }

                uploadStream.Close();
                fileStream.Close();

                requestFTPUploader = null;
            }
            catch (Exception pException)
            {
                return;
            }
        }
        public static bool FTPUpload_CheckDirectory(string pFileName, string qFullName, string qFTP_ID, string qFTP_PW, string qFTP_Path, string qDirectory)
        {
            bool IsUpload;

            try
            {
                // 파일존재확인
                CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(qFTP_Path, qFTP_ID, qFTP_PW);
                if (!qFTPUtil.FtpDirectoryExists(qFTP_Path, qDirectory))    // qFTP_Path 디렉토리 체크해서     >> 여기서 해당 window_name의 폴더가 없다는 false를 내보냄.....
                {
                    //없으면 directory(qFTP_Path) 생성 단계 거쳐서 저장단계로 넘기기
                    qFTPUtil.MakeDirectory_AfterChecking(qFTP_Path + "/%2F/" + qDirectory);                            //  >> 그래서 여기서 해당 폴더를 만들려다가 에러를 내보내서, 폴더는 안 만들고
                }


                if (qFTPUtil.IsFTPFileExsit(qFTP_Path + "/%2F/" + qDirectory + "/%2F/" + pFileName))
                {
                    // 파일삭제하기
                    FtpWebRequest requestFileDelete = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + "/%2F/" + qDirectory + "/" + pFileName);
                    requestFileDelete.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                    requestFileDelete.Method = WebRequestMethods.Ftp.DeleteFile;

                    FtpWebResponse responseFileDelete = (FtpWebResponse)requestFileDelete.GetResponse();
                }

                FtpWebRequest requestFTPUploader = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + "/%2F/" + qDirectory + "/" + pFileName);
                requestFTPUploader.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                requestFTPUploader.Method = WebRequestMethods.Ftp.UploadFile;

                FileInfo fileInfo = new FileInfo(qFullName);
                FileStream fileStream = fileInfo.OpenRead();

                int bufferLength = 102400;
                byte[] buffer = new byte[bufferLength];

                Stream uploadStream = requestFTPUploader.GetRequestStream();
                int contentLength = fileStream.Read(buffer, 0, bufferLength);

                while (contentLength != 0)
                {
                    uploadStream.Write(buffer, 0, contentLength);
                    contentLength = fileStream.Read(buffer, 0, bufferLength);
                }

                uploadStream.Close();
                fileStream.Close();

                requestFTPUploader = null;

                IsUpload = true;
            }
            catch (Exception pException)
            {
                IsUpload = false;
            }
            return IsUpload;
        }

        public static void FTPUpload_CheckDFile(string pFileName, string qFTP_ID, string qFTP_PW, string qFTP_Path, byte[] qFileData)
        {                                             
            try
            {
                CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(qFTP_Path, qFTP_ID, qFTP_PW);
                if (qFTPUtil.IsFTPFileExsit(qFTP_Path + pFileName))
                {
                    // 파일삭제하기
                    FtpWebRequest requestFileDelete = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + pFileName);
                    requestFileDelete.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                    requestFileDelete.Method = WebRequestMethods.Ftp.DeleteFile;

                    FtpWebResponse responseFileDelete = (FtpWebResponse)requestFileDelete.GetResponse();
                }
                FtpWebRequest requestFTPUploader = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + "/%2F/" + pFileName);
                requestFTPUploader.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                requestFTPUploader.Method = WebRequestMethods.Ftp.UploadFile;

                byte[] data = qFileData;

                requestFTPUploader.ContentLength = data.Length;
                using (Stream reqStream = requestFTPUploader.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                }

                using (FtpWebResponse resp = (FtpWebResponse)requestFTPUploader.GetResponse())
                {
                    Console.WriteLine("Upload: {0}", resp.StatusDescription);
                }

            }
            catch (Exception pException)
            {
                return;
            }
        }

        //Directory 있는지 체크하는 부분 추가
        public static bool FTPUpload_DataofByte_CheckDirectory(string pFileName, string qFTP_ID, string qFTP_PW, string qFTP_Path, string qDirectory, byte[] qFileData)
        {
            bool IsUpload;
            Stream reqStream;

            try
            {
                CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(qFTP_Path, qFTP_ID, qFTP_PW);
                if (!qFTPUtil.FtpDirectoryExists(qFTP_Path, qDirectory))    // qFTP_Path 디렉토리 체크해서     >> 여기서 해당 window_name의 폴더가 없다는 false를 내보냄.....
                {
                    //없으면 directory(qFTP_Path) 생성 단계 거쳐서 저장단계로 넘기기
                    qFTPUtil.MakeDirectory_AfterChecking(qFTP_Path+ "/%2F/" + qDirectory);
                }

                //해당 파일이 있는지 없는지 확인하는 부분
                // >> 있으면 삭제, 없으면 업로드

                FtpWebRequest requestFTPUploader = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + "/%2F/" + qDirectory+ "/" + pFileName);
                requestFTPUploader.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                requestFTPUploader.Method = WebRequestMethods.Ftp.UploadFile;

                byte[] data = qFileData;

                requestFTPUploader.ContentLength = data.Length;

                using (reqStream = requestFTPUploader.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                }
                if (reqStream != null) reqStream.Close();

                IsUpload = true;

            }
            catch (Exception pException)
            {
                IsUpload =  false;
            }

            return IsUpload;
        }
        public static bool FTPUpload_DataofStream_CheckDirectory(string pFileName, string qFTP_ID, string qFTP_PW, string qFTP_Path, string qDirectory, byte[] qFileData, string qLOCAL_PATH)
        {
            bool IsUpload;
            Stream reqStream;

            //읽을 화일 경로 및 이름 설정
            FileInfo fileinf = new FileInfo(qLOCAL_PATH);
            //파일 오픈 파일 스트림 상태로 읽어들임
            FileStream fs = fileinf.OpenRead();

            try
            {
                //FTP 오픈
                CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(qFTP_Path, qFTP_ID, qFTP_PW);
                //ftp 폴더에 디렉토리가 없으면 생성
                if (!qFTPUtil.FtpDirectoryExists(qFTP_Path, qDirectory))    // qFTP_Path 디렉토리 체크해서     >> 여기서 해당 window_name의 폴더가 없다는 false를 내보냄.....
                {
                    //없으면 directory(qFTP_Path) 생성 단계 거쳐서 저장단계로 넘기기
                    qFTPUtil.MakeDirectory_AfterChecking(qFTP_Path + "/%2F/" + qDirectory);
                }

                //해당 파일이 있는지 없는지 확인하는 부분
                // >> 있으면 삭제, 없으면 업로드

                FtpWebRequest requestFTPUploader = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + "/%2F/" + qDirectory + "/" + pFileName);
                requestFTPUploader.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                requestFTPUploader.Method = WebRequestMethods.Ftp.UploadFile;

                byte[] data = qFileData;

                requestFTPUploader.ContentLength = data.Length;

                int contentLen;

                using (reqStream = requestFTPUploader.GetRequestStream())
                {

                    contentLen = fs.Read(data, 0, data.Length);

                    while (contentLen != 0)
                    {

                        reqStream.Write(data, 0, contentLen);
                        contentLen = fs.Read(data, 0, data.Length);
                    }

                    //reqStream.Write(data, 0, data.Length);
                }
                if (reqStream != null)
                {
                    reqStream.Close();
                    fs.Close();
                }

                IsUpload = true;

            }
            catch (Exception pException)
            {
                IsUpload = false;
            }

            return IsUpload;
        }

        public static bool FTPUpload_DataofByte_CheckDirectory_Encoding(string pFileName, string qFTP_ID, string qFTP_PW, string qFTP_Path, string qDirectory, byte[] qFileData, string qLOCAL_PATH)
        {
            bool IsUpload;
            Stream reqStream;

            try
            {
                CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(qFTP_Path, qFTP_ID, qFTP_PW);
                if (!qFTPUtil.FtpDirectoryExists(qFTP_Path, qDirectory))    // qFTP_Path 디렉토리 체크해서     >> 여기서 해당 window_name의 폴더가 없다는 false를 내보냄.....
                {
                    //없으면 directory(qFTP_Path) 생성 단계 거쳐서 저장단계로 넘기기
                    qFTPUtil.MakeDirectory_AfterChecking(qFTP_Path + "/%2F/" + qDirectory);
                }

                //해당 파일이 있는지 없는지 확인하는 부분
                // >> 있으면 삭제, 없으면 업로드

                FtpWebRequest requestFTPUploader = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + "/%2F/" + qDirectory + "/" + pFileName);
                requestFTPUploader.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                requestFTPUploader.Method = WebRequestMethods.Ftp.UploadFile;

                byte[] data = new byte[qFileData.Length]; // qFileData;

                requestFTPUploader.ContentLength = data.Length;

                using (StreamReader sourceStream = new StreamReader(qLOCAL_PATH))
                {
                    data = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                }

                using (reqStream = requestFTPUploader.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                }
                if (reqStream != null) reqStream.Close();

                IsUpload = true;

            }
            catch (Exception pException)
            {
                IsUpload = false;
            }

            return IsUpload;
        }

        public static bool FTPUpload_DataofStream_CheckDirectory_Encoding(string pFileName, string qFTP_ID, string qFTP_PW, string qFTP_Path, string qDirectory, byte[] qFileData, string qLOCAL_PATH)
        {
            bool IsUpload;
            Stream reqStream;

            FileInfo fileinf = new FileInfo(qLOCAL_PATH);

            FileStream fs = fileinf.OpenRead();

            try
            {
                CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(qFTP_Path, qFTP_ID, qFTP_PW);
                if (!qFTPUtil.FtpDirectoryExists(qFTP_Path, qDirectory))    // qFTP_Path 디렉토리 체크해서     >> 여기서 해당 window_name의 폴더가 없다는 false를 내보냄.....
                {
                    //없으면 directory(qFTP_Path) 생성 단계 거쳐서 저장단계로 넘기기
                    qFTPUtil.MakeDirectory_AfterChecking(qFTP_Path + "/%2F/" + qDirectory);
                }

                //해당 파일이 있는지 없는지 확인하는 부분
                // >> 있으면 삭제, 없으면 업로드

                FtpWebRequest requestFTPUploader = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + "/%2F/" + qDirectory + "/" + pFileName);
                requestFTPUploader.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                requestFTPUploader.Method = WebRequestMethods.Ftp.UploadFile;

                byte[] data = new byte[qFileData.Length]; // qFileData;

                requestFTPUploader.ContentLength = data.Length;

                int contentLen;

                //using (StreamReader sourceStream = new StreamReader(qLOCAL_PATH))
                //{
                //    data = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                //}

                using (reqStream = requestFTPUploader.GetRequestStream())
                {

                    contentLen = fs.Read(data, 0, data.Length);

                    while(contentLen != 0)
                    {

                        reqStream.Write(data, 0, contentLen);
                        contentLen = fs.Read(data, 0, data.Length);
                    }

                    //reqStream.Write(data, 0, data.Length);
                }
                if (reqStream != null)
                {
                    reqStream.Close();
                    fs.Close();
                }

                IsUpload = true;

            }
            catch (Exception pException)
            {
                IsUpload = false;
            }

            return IsUpload;
        }


        #endregion

        #region ○ FTP에 저장된 파일 control에 바인딩시키기 위해 Stream 생성
        public static Stream FTPFileBinding(string qFTP_Path, string qFileName, string qFTP_ID, string qFTP_PW)  //추가
        {
            try
            {
                Stream responseStream = null;

                CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(qFTP_Path, qFTP_ID, qFTP_PW);
                if (qFTPUtil.IsFTPFileExsit(qFTP_Path + qFileName))
                {

                    FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create("ftp://" + qFTP_Path + qFileName);
                    requestFileDownload.Credentials = new NetworkCredential(qFTP_ID, qFTP_PW);
                    requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;

                    FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();

                    return responseStream = responseFileDownload.GetResponseStream();
                }
                else
                {
                    //CoFAS_DevExpressManager.ShowErrorMessage("FTP서버에 저장되지 않은 파일입니다. 저장을 먼저 해주세요.");
                    return null;
                }
            }
            catch (Exception pException)
            {
                return null;
            }
        }
        #endregion

    




    }

    public class CoFAS_FTPUtilManager
    {
        #region 멤버 변수 & 프로퍼티

        /// <summary>
        ///
        /// </summary>
        private string host;

        /// <summary>
        /// FTP 서버 호스트명(IP)를 가져옵니다.
        /// </summary>
        public string Host
        {
            get { return host; }
            private set { host = value; }
        }

        private string userName;

        /// <summary>
        /// 사용자 명을 가져옵니다.
        /// </summary>
        public string UserName
        {
            get { return userName; }
            private set { userName = value; }
        }

        private string password;

        /// <summary>
        /// 비밀번호를 가져옵니다.
        /// </summary>
        public string Password
        {
            get { return password; }
            private set { password = value; }
        }

        #endregion

        #region 생성자

        /// <summary>
        /// FXFtpUtil의 새 인스턴스를 생성합니다.
        /// </summary>
        /// <param name="host">FTP 서버 주소 입니다.</param>
        /// <param name="userName">FTP 사용자 아이디 입니다.</param>
        /// <param name="password">FTP 비밀번호 입니다.</param>
        public CoFAS_FTPUtilManager(string host, string userName, string password)
        {
            this.Host = host;
            this.UserName = userName;
            this.Password = password;
        }

        #endregion

        #region 메서드

        /// <summary>
        /// 파일을 FTP 서버에 업로드 합니다.
        /// </summary>
        /// <param name="localFileFullPath">로컬 파일의 전체 경로 입니다.</param>
        /// <param name="ftpFilePath"><para>파일을 업로드 할 FTP 전체 경로 입니다.</para><para>하위 디렉터리에 넣는 경우 /디렉터리명/파일명.확장자 형태 입니다.</para></param>
        /// <exception cref="FileNotFoundException">지정한 로컬 파일(localFileFullPath)이 없을 때 발생합니다.</exception>
        /// <returns>업로드 성공 여부입니다.</returns>
        public bool Upload(string localFileFullPath, string ftpFilePath)
        {
            LocalFileValidationCheck(localFileFullPath);

            FTPDirectioryCheck(GetDirectoryPath(ftpFilePath));
            if (IsFTPFileExsit(ftpFilePath))
            {
                //throw new ApplicationException(string.Format("{0}은 이미 존재하는 파일 입니다.", ftpFilePath));
            }
            string ftpFileFullPath = string.Format("ftp://{0}/{1}", this.Host, ftpFilePath);
            FtpWebRequest ftpWebRequest = WebRequest.Create(new Uri(ftpFileFullPath)) as FtpWebRequest;
            ftpWebRequest.Credentials = GetCredentials();
            ftpWebRequest.UseBinary = true;
            ftpWebRequest.UsePassive = true;
            ftpWebRequest.Timeout = 10000;
            ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;

            FileInfo fileInfo = new FileInfo(localFileFullPath);
            FileStream fileStream = fileInfo.OpenRead();
            Stream stream = null;
            byte[] buf = new byte[2048];
            int currentOffset = 0;
            try
            {
                stream = ftpWebRequest.GetRequestStream();
                currentOffset = fileStream.Read(buf, 0, 2048);
                while (currentOffset != 0)
                {
                    stream.Write(buf, 0, currentOffset);
                    currentOffset = fileStream.Read(buf, 0, 2048);
                }

            }
            finally
            {
                fileStream.Dispose();
                if (stream != null)
                    stream.Dispose();
            }

            return true;
        }

        /// <summary>
        /// 해당 경로에 파일이 존재하는지 여부를 가져옵니다.
        /// </summary>
        /// <param name="ftpFilePath">파일 경로</param>
        /// <returns>존재시 참 </returns>
        public bool IsFTPFileExsit(string ftpFilePath)
        {
            string fileName = GetFileName(ftpFilePath);
            string ftpFileFullPath = string.Format("ftp:/{0}/%2F/{1}", GetDirectoryPath(ftpFilePath), fileName);
            FtpWebRequest ftpWebRequest = WebRequest.Create(new Uri(ftpFileFullPath)) as FtpWebRequest;
            ftpWebRequest.Credentials = new NetworkCredential(this.UserName, this.Password);
            ftpWebRequest.UseBinary = true;
            ftpWebRequest.UsePassive = true;
            ftpWebRequest.Timeout = 10000;
            ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = null;
            string data = string.Empty;
            try
            {
                response = ftpWebRequest.GetResponse() as FtpWebResponse;
                if (response != null)
                {
                    StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.Default);
                    data = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex) { }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }

            string[] directorys = data.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            if (directorys.Length > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// FTP 풀 경로에서 Directory 경로만 가져옵니다.
        /// </summary>
        /// <param name="ftpFilePath">FTP 풀 경로</param>
        /// <returns>디렉터리 경로입니다.</returns>
        private string GetDirectoryPath(string ftpFilePath)
        {
            string[] datas = ftpFilePath.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            string directoryPath = string.Empty;

            for (int i = 0; i < datas.Length - 1; i++)
            {
                directoryPath += string.Format("/{0}", datas[i]);
            }
            return directoryPath;
        }

        /// <summary>
        /// FTP 풀 경로에서 파일이름만 가져옵니다.
        /// </summary>
        /// <param name="ftpFilePath">FTP 풀 경로</param>
        /// <returns>파일명입니다.</returns>
        private string GetFileName(string ftpFilePath)
        {
            string[] datas = ftpFilePath.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            return datas[datas.Length - 1];
        }

        /// <summary>
        /// FTP 경로의 디렉토리를 점검하고 없으면 생성
        /// </summary>
        /// <param name="directoryPath">디렉터리 경로 입니다.</param>
        public void FTPDirectioryCheck(string directoryPath)
        {
            string[] directoryPaths = directoryPath.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);

            string currentDirectory = string.Empty;
            foreach (string directory in directoryPaths)
            {
                currentDirectory += string.Format("/{0}", directory);
                if (!IsExtistDirectory(currentDirectory))
                {
                    MakeDirectory(currentDirectory);
                }
            }
        }

        /// <summary>
        /// FTP에 해당 디렉터리가 있는지 알아온다.
        /// </summary>
        /// <param name="currentDirectory">디렉터리 명</param>
        /// <returns>있으면 참</returns>
        private bool IsExtistDirectory(string currentDirectory)
        {
            string ftpFileFullPath = string.Format("ftp://{0}{1}", this.Host, GetParentDirectory(currentDirectory));
            FtpWebRequest ftpWebRequest = WebRequest.Create(new Uri(ftpFileFullPath)) as FtpWebRequest;
            ftpWebRequest.Credentials = new NetworkCredential(this.UserName, this.Password);
            ftpWebRequest.UseBinary = true;
            ftpWebRequest.UsePassive = true;
            ftpWebRequest.Timeout = 10000;
            ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = null;
            string data = string.Empty;
            try
            {
                response = ftpWebRequest.GetResponse() as FtpWebResponse;
                if (response != null)
                {
                    StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.Default);

                    data = streamReader.ReadToEnd();
                }
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }

            string[] directorys = data.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return (from directory in directorys
                    select directory.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    into directoryInfos
                    where directoryInfos[0][0] == 'd'
                    select directoryInfos[8]).Any(
                        name => name == (currentDirectory.Split('/')[currentDirectory.Split('/').Length - 1]).ToString());
        }

        /// <summary>
        /// FTP에 해당 디렉터리가 있는지 알아온다.
        /// </summary>
        /// <param name="currentDirectory">디렉터리 명</param>
        /// <param name="checkDirectory">확인 할 디렉터리 명</param>
        /// <returns>있으면 참</returns>
        public bool FtpDirectoryExists(string currentDirectory, string checkDirectory)
        {
            string ftpFileFullPath = string.Format("ftp://{0}", currentDirectory);
            //string ftpFileFullPath = string.Format("ftp://{0}", currentDirectory + "/%2F/" + checkDirectory); 
            FtpWebRequest ftpWebRequest = WebRequest.Create(new Uri(ftpFileFullPath)) as FtpWebRequest;
            ftpWebRequest.Credentials = new NetworkCredential(this.UserName, this.Password);
            ftpWebRequest.UseBinary = true;
            ftpWebRequest.UsePassive = true;
            ftpWebRequest.Timeout = 10000;
            ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = null;

            bool isCheckDirectory = true;
            try
            {
                response = ftpWebRequest.GetResponse() as FtpWebResponse;
                if (response != null)
                {
                    StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.Default);

                    string directoryList = streamReader.ReadToEnd();

                    string[] directoryLists = directoryList.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    if(directoryLists == null || directoryLists.Length == 0)
                    {
                        isCheckDirectory = false;
                    }
                    else
                    {
                        for (int i = 0; i < directoryLists.Length; i++)
                        {
                            string name_Directory = directoryLists[i];
                            if (checkDirectory.Equals(name_Directory))
                            {
                                isCheckDirectory = true;
                                return isCheckDirectory;
                            }
                            else
                            {
                                isCheckDirectory = false;
                            }
                        }
                    }
                }
            }
            catch (Exception pException)
            {
                return false;
            }
            return isCheckDirectory;
        }

        /// <summary>
        /// 상위 디렉터리를 알아옵니다.
        /// </summary>
        /// <param name="currentDirectory"></param>
        /// <returns></returns>
        private string GetParentDirectory(string currentDirectory)
        {
            string[] directorys = currentDirectory.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            string parentDirectory = string.Empty;
            for (int i = 0; i < directorys.Length - 1; i++)
            {
                parentDirectory += "/" + directorys[i];
            }

            return parentDirectory;
        }

        /// <summary>
        /// 인증을 가져옵니다.
        /// </summary>
        /// <returns>인증</returns>
        private ICredentials GetCredentials()
        {
            return new NetworkCredential(this.UserName, this.Password);
        }

        private string GetStringResponse(FtpWebRequest ftp)
        {
            string result = "";
            using (FtpWebResponse response = (FtpWebResponse)ftp.GetResponse())
            {
                long size = response.ContentLength;
                using (Stream datastream = response.GetResponseStream())
                {
                    if (datastream != null)
                    {
                        using (StreamReader sr = new StreamReader(datastream))
                        {
                            result = sr.ReadToEnd();
                            sr.Close();
                        }

                        datastream.Close();
                    }
                }

                response.Close();
            }

            return result;
        }

        private FtpWebRequest GetRequest(string URI)
        {
            FtpWebRequest result = (FtpWebRequest)WebRequest.Create(URI);
            result.Credentials = GetCredentials();
            result.KeepAlive = false;
            return result;
        }

        /// <summary>
        /// FTP에 해당 디렉터리를 만든다.
        /// </summary>
        /// <param name="dirpath"></param>
        public bool MakeDirectory(string dirpath)
        {
            string URI = string.Format("ftp://{0}/{1}", this.Host, dirpath);
            System.Net.FtpWebRequest ftp = GetRequest(URI);
            ftp.Method = System.Net.WebRequestMethods.Ftp.MakeDirectory;

            try
            {
                string str = GetStringResponse(ftp);
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// FTP에 해당 디렉터리를 만든다.
        /// </summary>
        /// <param name="dirpath"></param>
        public void MakeDirectory_AfterChecking(string dirpath)
        {
            string URI = string.Format("ftp://{0}", dirpath);
            System.Net.FtpWebRequest ftp = GetRequest(URI);
            ftp.Method = System.Net.WebRequestMethods.Ftp.MakeDirectory;

            try
            {
                string str = GetStringResponse(ftp);
            }
            catch (Exception pException)
            {
            }
        }

        /// <summary>
        /// 지정한 로컬 파일이 실제 존재하는지 확인합니다.
        /// </summary>
        /// <param name="localFileFullPath">로컬 파일의 전체 경로입니다.</param>
        private void LocalFileValidationCheck(string localFileFullPath)
        {
            if (!File.Exists(localFileFullPath))
            {
                throw new FileNotFoundException(string.Format("The specified file does not exist.\nLocalPath : {0}", localFileFullPath));
            }
        }
        #endregion
    }
}
