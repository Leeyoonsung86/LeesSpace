using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoFAS_MES.AUTO.DWL.Data;
using CoFAS_MES.AUTO.DWL.Entity;
using CoFAS_MES.CORE.Function;
using System.IO;

using MySql.Data.Types;

namespace CoFAS_MES.AUTO.DWL.Business
{
    public class AutoDownloadBusiness
    {
        #region 파일정보 조회하기 - FileInfo_GetList(AutoDownloadEntity pAutoDownloadEntity)

        /// <summary>
        /// 파일정보 조회하기
        /// </summary>
        public DataTable FileInfo_GetList(AutoDownloadEntity pAutoDownloadEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new AutoDownloadProvider(pDBManager).FileInfo_GetList(pAutoDownloadEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FileInfo_GetList(string pFILE_TYPE)", pException);
            }
        }

        #endregion

        #region 파일조회 - FileInfo_GetFileData(AutoDownloadEntity pAutoDownloadEntity)

        /// <summary>
        /// 파일조회
        /// </summary>
        public string FileInfo_GetFileData(AutoDownloadEntity pAutoDownloadEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new AutoDownloadProvider(pDBManager).FileInfo_GetFileData(pAutoDownloadEntity);

                    byte[] bLob = (byte[])pDataTable.Rows[0]["FILE_DATA"];
                    
                    using (FileStream fs = new FileStream(pAutoDownloadEntity.FILE_PATH + pAutoDownloadEntity.FILENAME, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                    {
                        fs.Write(bLob, 0, bLob.Length);

                        fs.Flush();
                        fs.Close();
                        fs.Dispose();
                    }
                }
                FileInfo fi = new FileInfo(pAutoDownloadEntity.FILE_PATH + pAutoDownloadEntity.FILENAME);

                return CoFAS_FileManager.Get_Crc32(fi);
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FileInfo_GetFileData(AutoDownloadEntity pAutoDownloadEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public AutoDownloadEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                AutoDownloadEntity pAutoDownloadEntity = new AutoDownloadProvider(null).GetEntity(pDataRow);
                return pAutoDownloadEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion
    }
}
