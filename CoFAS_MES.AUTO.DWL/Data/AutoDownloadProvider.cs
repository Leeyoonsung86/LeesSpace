using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using System.Data.SqlClient;

using MySql.Data.MySqlClient;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using CoFAS_MES.AUTO.DWL.Entity;


namespace CoFAS_MES.AUTO.DWL.Data
{
    public class AutoDownloadProvider : EntityManager<AutoDownloadEntity>
    {
        #region 생성자 - AutoDownloadProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public AutoDownloadProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 파일정보 조회하기 - FileInfo_GetList(string pFILE_TYPE)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pFILE_TYPE"></param>
        /// <returns></returns>
        public DataTable FileInfo_GetList(AutoDownloadEntity pAutoDownloadEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@V_CORP_CODE", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@V_FILE_TYPE", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@V_CORP_CODE", SqlDbType.NVarChar, 10),
                            new SqlParameter("@V_FILE_TYPE", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pAutoDownloadEntity.CORP_CODE;
                pDataParameters[1].Value = pAutoDownloadEntity.FILE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_FileInfo_GetList", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "FileInfo_GetList(string pFILE_TYPE)",
                    pException
                );
            }
        }

        #endregion

        public DataTable FileInfo_GetFileData(AutoDownloadEntity pAutoDownloadEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@V_CORP_CODE", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@V_FILE_TYPE", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@V_FILENAME", MySqlDbType.VarChar, 100)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@V_CORP_CODE", SqlDbType.NVarChar, 10),
                            new SqlParameter("@V_FILE_TYPE", SqlDbType.NVarChar, 50),
                            new SqlParameter("@V_FILENAME", SqlDbType.NVarChar, 100)
                        };
                        break;
                }

                pDataParameters[0].Value = pAutoDownloadEntity.CORP_CODE;
                pDataParameters[1].Value = pAutoDownloadEntity.FILE_TYPE;
                pDataParameters[2].Value = pAutoDownloadEntity.FILENAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_FileInfo_GetFileData", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "FileInfo_GetFileData(AutoDownloadEntity pAutoDownloadEntity)",
                    pException
                );
            }
        }





        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override AutoDownloadEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                AutoDownloadEntity pAutoDownloadEntity = new AutoDownloadEntity();

                pAutoDownloadEntity.FILE_TYPE = pDataRow["FILE_TYPE"] is DBNull ? string.Empty : pDataRow["FILE_TYPE"] as string;

                return pAutoDownloadEntity;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
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
