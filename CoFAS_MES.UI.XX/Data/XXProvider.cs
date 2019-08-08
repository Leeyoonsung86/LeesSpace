using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

using CoFAS_MES.UI.XX.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;

namespace CoFAS_MES.UI.XX.Data
{
    public class SampleRegisterProvider : EntityManager<SampleRegisterEntity>
    {
        #region 생성자 - SampleRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SampleRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(SampleRegisterEntity pSampleRegisterEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1)

                        };
                        break;
                }

                pDataParameters[0].Value = pSampleRegisterEntity.CRUD;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SampleRegister_R10", pDataParameters);

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
                    "Sample_Info_Mst(SampleRegisterEntity pSampleRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(SampleRegisterEntity pSampleRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(SampleRegisterEntity pSampleRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            _pDBManager.BeginTransaction(); //Transaction 시작

            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParametersA = new IDataParameter[]
                        {
                                new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20)
                        };
                        break;
                }

                pDataParametersA[0].Value = pSampleRegisterEntity.CORP_CODE;
                pDataParametersA[1].Value = pSampleRegisterEntity.CRUD;
                pDataParametersA[2].Value = pSampleRegisterEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SampleRegister_I10", pDataParametersA);

                pSampleRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pSampleRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pSampleRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pSampleRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pSampleRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    if (dt != null)
                    {
                        pCount = dt.Rows.Count;

                        for (int a = 0; a < pCount; a++)
                        {
                            IDataParameter[] pDataParametersB = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                        new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = pSampleRegisterEntity.CORP_CODE;
                            pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[2].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pSampleRegisterEntity.USER_CODE);

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pSampleRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pSampleRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pSampleRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pSampleRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pSampleRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
                        }
                    }
                }
                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;

                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                pErrorYN = true;

                throw new ExceptionManager
                (
                    this,
                    "Sample_Info_Save(SampleRegisterEntity pSampleRegisterEntity, DataTable dt)",
                    pException
                );
            }
            finally
            {
                if (pErrorYN)
                    _pDBManager.RollbackTransaction();  // 저장 실패 Rollback Transaction 
                else
                    _pDBManager.CommitTransaction();  // 저장 성공  Commit Transaction
            }

            return pErrorYN;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override SampleRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SampleRegisterEntity pSampleRegisterEntity = new SampleRegisterEntity();

                pSampleRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pSampleRegisterEntity;
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

        #region 파일명 조회하기 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pSampleRegisterEntity.WINDOW_NAME;
                pDataParameters[1].Value = pSampleRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuRegister_R40", pDataParameters);

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
                    "Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)",
                    pException
                );
            }
        }

        #endregion


        #region XML파일 다운로드 - Templete_Download(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object Templete_Download(SampleRegisterEntity pSampleRegisterEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_menu_no", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_dsp_sort", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_menu_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_dsp_sort", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)

                        };
                        break;
                }

                pDataParameters[0].Value = pMENU_NO;
                pDataParameters[1].Value = pDSP_SORT;
                pDataParameters[2].Value = "Y";


                object pObject = _pDBManager.GetScalar(CommandType.StoredProcedure, "USP_MenuRegister_R30", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pObject;
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
                    "Templete_Download(SampleRegisterEntity pSampleRegisterEntity, string pMENU_NO, string pDSP_SORT, string pCUR_FILE)",
                    pException
                );
            }
        }

        #endregion
    }

    public class UsingExcelProvider : EntityManager<UsingExcelEntity>
    {
        #region 생성자 - UsingExcelProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public UsingExcelProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - UsingExcel_Mst(UsingExcelEntity pSampleRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pUsingExcelEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable UsingExcel_Mst(UsingExcelEntity pUsingExcelEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 10)
                        };
                        break;
                }

                pDataParameters[0].Value = pUsingExcelEntity.CRUD;
                pDataParameters[1].Value = pUsingExcelEntity.WINDOW_NAME;
                pDataParameters[2].Value = pUsingExcelEntity.DATE_FROM;
                pDataParameters[3].Value = pUsingExcelEntity.DATE_TO;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_UsingExcel_R10", pDataParameters);

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
                    "UsingExcel_Mst(pUsingExcelEntity pUsingExcelEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 마스터 조회하기 - ExcelForm_Mst(UsingExcelEntity pSampleRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pUsingExcelEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ExcelForm_Mst(UsingExcelEntity pUsingExcelEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pUsingExcelEntity.CRUD;
                pDataParameters[1].Value = pUsingExcelEntity.WINDOW_NAME;
                pDataParameters[2].Value = 'Y';

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SheetInfoRegister_R10", pDataParameters);

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
                    "ExcelForm_Mst(pUsingExcelEntity pUsingExcelEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 정보 저장하기 - UsingExcel_Save(UsingExcelEntity pUsingExcelEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pUsingExcelEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool UsingExcel_Save(UsingExcelEntity pUsingExcelEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParametersA = new IDataParameter[]
                        {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_dsp_seq", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_file_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_file_nickname", MySqlDbType.VarChar, 100)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_dsp_seq", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_file_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_file_nickname", SqlDbType.NVarChar, 100)
                        };
                        break;
                }

                pDataParametersA[0].Value = pUsingExcelEntity.CRUD;
                pDataParametersA[1].Value = pUsingExcelEntity.USER_CODE;
                pDataParametersA[2].Value = pUsingExcelEntity.DSP_SEQ;
                pDataParametersA[3].Value = pUsingExcelEntity.WINDOW_NAME;
                pDataParametersA[4].Value = pUsingExcelEntity.FILE_NAME;
                pDataParametersA[5].Value = pUsingExcelEntity.FILE_NICKNAME;


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_UsingExcel_I10", pDataParametersA);

                pUsingExcelEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pUsingExcelEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pUsingExcelEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pUsingExcelEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pUsingExcelEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;

                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                pErrorYN = true;

                throw new ExceptionManager
                (
                    this,
                    "UsingExcel_Save(UsingExcelEntity pUsingExcelEntity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override UsingExcelEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                UsingExcelEntity pUsingExcelEntity = new UsingExcelEntity();

                pUsingExcelEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pUsingExcelEntity;
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


    public class SampleExcelBindingProvider : EntityManager<SampleExcelBindingEntity>
    {
        #region 생성자 - SampleExcelBindingProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SampleExcelBindingProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(SampleExcelBindingEntity pSampleExcelBindingEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(SampleExcelBindingEntity pSampleExcelBindingEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pSampleExcelBindingEntity.CORP_CODE;
                pDataParameters[1].Value = pSampleExcelBindingEntity.CRUD;
                pDataParameters[2].Value = pSampleExcelBindingEntity.DATE_FROM;
                pDataParameters[3].Value = pSampleExcelBindingEntity.DATE_TO;
                pDataParameters[4].Value = pSampleExcelBindingEntity.PART_NAME;
                pDataParameters[5].Value = pSampleExcelBindingEntity.VEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SampleExcelBinding_R10", pDataParameters);

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
                    "Sample_Info_Mst(SampleExcelBindingEntity pSampleExcelBindingEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(SampleExcelBindingEntity pSampleExcelBindingEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(SampleExcelBindingEntity pSampleExcelBindingEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParametersA = new IDataParameter[]
                        {
                                new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20)
                        };
                        break;
                }

                pDataParametersA[0].Value = pSampleExcelBindingEntity.CORP_CODE;
                pDataParametersA[1].Value = pSampleExcelBindingEntity.CRUD;
                pDataParametersA[2].Value = pSampleExcelBindingEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SampleExcelBinding_I10", pDataParametersA);

                pSampleExcelBindingEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pSampleExcelBindingEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pSampleExcelBindingEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pSampleExcelBindingEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pSampleExcelBindingEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    //if (dt != null)
                    //{
                    //    pCount = dt.Rows.Count;

                    //    for (int a = 0; a < pCount; a++)
                    //    {
                    //        IDataParameter[] pDataParametersB = null;

                    //        switch (_pDBManager.DBManagerType.ToString())
                    //        {
                    //            case "MySql":
                    //                pDataParametersB = new IDataParameter[]
                    //                {
                    //                    new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                    //                    new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                    //                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20)
                    //                };
                    //                break;

                    //            case "SQLServer":
                    //                pDataParametersB = new IDataParameter[]
                    //                {
                    //                    new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                    //                    new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                    //                    new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20)
                    //                };
                    //                break;
                    //        }

                    //        pDataParametersB[0].Value = pSampleExcelBindingEntity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pSampleExcelBindingEntity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pSampleExcelBindingEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pSampleExcelBindingEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pSampleExcelBindingEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pSampleExcelBindingEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pSampleExcelBindingEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
                    //    }
                    //}
                }
                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;

                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                pErrorYN = true;

                throw new ExceptionManager
                (
                    this,
                    "Sample_Info_Save(SampleExcelBindingEntity pSampleExcelBindingEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override SampleExcelBindingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SampleExcelBindingEntity pSampleExcelBindingEntity = new SampleExcelBindingEntity();

                pSampleExcelBindingEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pSampleExcelBindingEntity;
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


        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(SampleExcelBindingEntity pSampleExcelBindingEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleExcelBindingEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(SampleExcelBindingEntity pSampleExcelBindingEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pSampleExcelBindingEntity.CRUD;
                pDataParameters[1].Value = pSampleExcelBindingEntity.WINDOW_NAME;


                DataTable pDatatable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SheetInfoRegister_R20", pDataParameters);


                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDatatable;
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
                    "Sheet_Info_sheet(SampleExcelBindingEntity pSampleExcelBindingEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 바인딩 데이터 테이블 불러오기 - Sheet_Info_Sheet_Data(ProcessMaterialStockStatusEntity pProcessMaterialStockStatusEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
      //  public DataTable Sheet_Info_Sheet_Data(SampleExcelBindingEntity pSampleExcelBindingEntity)
        public DataSet Sheet_Info_Sheet_Data(SampleExcelBindingEntity pSampleExcelBindingEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pSampleExcelBindingEntity.CRUD;
                pDataParameters[1].Value = pSampleExcelBindingEntity.DATE_FROM;
                pDataParameters[2].Value = pSampleExcelBindingEntity.DATE_TO;
                pDataParameters[3].Value = pSampleExcelBindingEntity.PART_CODE;
                pDataParameters[4].Value = pSampleExcelBindingEntity.PART_NAME;
                pDataParameters[5].Value = pSampleExcelBindingEntity.VEND_CODE;
                pDataParameters[6].Value = pSampleExcelBindingEntity.VEND_NAME;


                //DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SampleExcelBinding_R10", pDataParameters);
                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_SampleExcelBinding_R10", pDataParameters);


                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                // return pDataTable;
                return pDataSet;
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
                    "Sheet_Info_Sheet_Data(ProcessMaterialStockStatusEntity pProcessMaterialStockStatusEntity)",
                    pException
                );
            }
        }
        #endregion
    }

    public class WorkResultViewProvider : EntityManager<WorkResultViewEntity>
    {
        #region ○ 생성자

        public WorkResultViewProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override WorkResultViewEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultViewEntity pWorkResultViewEntity = new WorkResultViewEntity();

                pWorkResultViewEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultViewEntity;
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

        #region ○ 데이터 조회

        public DataTable WorkResultView_Info_Mst(WorkResultViewEntity ppWorkResultViewEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_contract_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = ppWorkResultViewEntity.CRUD;
                pDataParameters[1].Value = ppWorkResultViewEntity.DATE_FROM;
                pDataParameters[2].Value = ppWorkResultViewEntity.DATE_TO;
                pDataParameters[3].Value = ppWorkResultViewEntity.CONTRACT_ID;
                pDataParameters[4].Value = ppWorkResultViewEntity.PART_CODE;
                pDataParameters[5].Value = ppWorkResultViewEntity.PART_NAME;
                pDataParameters[6].Value = ppWorkResultViewEntity.VEND_CODE;
                pDataParameters[7].Value = ppWorkResultViewEntity.VEND_NAME;
                pDataParameters[8].Value = ppWorkResultViewEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultView_R10", pDataParameters);
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
                    "WorkResultView_Info_Mst(WorkResultViewEntity ppWorkResultViewEntity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장

        public bool WorkResultView_Save(WorkResultViewEntity pWorkResultViewEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction();

            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_contract_date", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_contract_qty", MySqlDbType.Decimal),
                            new MySqlParameter("@v_delivery_date", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_delivery_location", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_unitcost", MySqlDbType.Decimal),
                            new MySqlParameter("@v_cost", MySqlDbType.Decimal),
                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_contract_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_contract_date", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_contract_qty", SqlDbType.Decimal),
                            new SqlParameter("@v_delivery_date", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_delivery_location", SqlDbType.VarChar, 100),
                            new SqlParameter("@v_unitcost", SqlDbType.Decimal),
                            new SqlParameter("@v_cost", SqlDbType.Decimal),
                            new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultViewEntity.CRUD;
                pDataParameters[1].Value = pWorkResultViewEntity.USER_CODE;
                pDataParameters[2].Value = pWorkResultViewEntity.CONTRACT_ID;
                pDataParameters[3].Value = pWorkResultViewEntity.CONTRACT_DATE;
                pDataParameters[4].Value = pWorkResultViewEntity.PART_CODE;
                pDataParameters[5].Value = pWorkResultViewEntity.VEND_CODE;
                pDataParameters[6].Value = pWorkResultViewEntity.CONTRACT_QTY;
                pDataParameters[7].Value = pWorkResultViewEntity.DELIVERY_DATE;
                pDataParameters[8].Value = pWorkResultViewEntity.DELIVERY_LOCATION;
                pDataParameters[9].Value = pWorkResultViewEntity.UNITCOST;
                pDataParameters[10].Value = pWorkResultViewEntity.COST;
                pDataParameters[11].Value = pWorkResultViewEntity.REMARK;
                pDataParameters[12].Value = pWorkResultViewEntity.USE_YN;
                //pDataParameters[13].Value = pWorkResultViewEntity.UNIT_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultView_I10", pDataParameters);

                pWorkResultViewEntity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                pWorkResultViewEntity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                pWorkResultViewEntity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                pWorkResultViewEntity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                pWorkResultViewEntity.RTN_AQ = pDataTable.Rows[0]["rtn_aq"].ToString();
                pWorkResultViewEntity.RTN_SQ = pDataTable.Rows[0]["rtn_sq"].ToString();
                pWorkResultViewEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {

                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;

                throw pExceptionManager;
            }
            finally
            {
                if (pErrorYN)
                    _pDBManager.RollbackTransaction();  // 저장실패
                else
                    _pDBManager.CommitTransaction();
            }

            return pErrorYN;
        }

        #endregion
    }

    public class WorkResultView2Provider : EntityManager<WorkResultView2Entity>
    {
        #region ○ 생성자

        public WorkResultView2Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override WorkResultView2Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultView2Entity pWorkResultView2Entity = new WorkResultView2Entity();

                pWorkResultView2Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultView2Entity;
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

        #region ○ 데이터 조회

        public DataTable WorkResultView2_Info_Mst(WorkResultView2Entity ppWorkResultView2Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                        //    new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 50),
                        //    new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                        //    new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                        //    new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                        //    new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50),
                        //    new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                        //    new SqlParameter("@v_contract_id", SqlDbType.VarChar, 50),
                        //    new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                        //    new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                        //    new SqlParameter("@v_vend_code", SqlDbType.VarChar, 50),
                        //    new SqlParameter("@v_vend_name", SqlDbType.VarChar, 50),
                        //    new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = ppWorkResultView2Entity.CRUD;
                pDataParameters[1].Value = ppWorkResultView2Entity.DATE_FROM;
                pDataParameters[2].Value = ppWorkResultView2Entity.DATE_TO;
                //pDataParameters[3].Value = ppWorkResultView2Entity.CONTRACT_ID;
                //pDataParameters[4].Value = ppWorkResultView2Entity.PART_CODE;
                //pDataParameters[5].Value = ppWorkResultView2Entity.PART_NAME;
                //pDataParameters[6].Value = ppWorkResultView2Entity.VEND_CODE;
                //pDataParameters[7].Value = ppWorkResultView2Entity.VEND_NAME;
                //pDataParameters[8].Value = ppWorkResultView2Entity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultView2_R10", pDataParameters);
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
                    "WorkResultView2_Info_Mst(WorkResultView2Entity ppWorkResultView2Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장

        public bool WorkResultView2_Save(WorkResultView2Entity pWorkResultView2Entity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction();

            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_contract_date", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_contract_qty", MySqlDbType.Decimal),
                            new MySqlParameter("@v_delivery_date", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_delivery_location", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_unitcost", MySqlDbType.Decimal),
                            new MySqlParameter("@v_cost", MySqlDbType.Decimal),
                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_contract_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_contract_date", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_contract_qty", SqlDbType.Decimal),
                            new SqlParameter("@v_delivery_date", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_delivery_location", SqlDbType.VarChar, 100),
                            new SqlParameter("@v_unitcost", SqlDbType.Decimal),
                            new SqlParameter("@v_cost", SqlDbType.Decimal),
                            new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultView2Entity.CRUD;
                pDataParameters[1].Value = pWorkResultView2Entity.USER_CODE;
                pDataParameters[2].Value = pWorkResultView2Entity.CONTRACT_ID;
                pDataParameters[3].Value = pWorkResultView2Entity.CONTRACT_DATE;
                pDataParameters[4].Value = pWorkResultView2Entity.PART_CODE;
                pDataParameters[5].Value = pWorkResultView2Entity.VEND_CODE;
                pDataParameters[6].Value = pWorkResultView2Entity.CONTRACT_QTY;
                pDataParameters[7].Value = pWorkResultView2Entity.DELIVERY_DATE;
                pDataParameters[8].Value = pWorkResultView2Entity.DELIVERY_LOCATION;
                pDataParameters[9].Value = pWorkResultView2Entity.UNITCOST;
                pDataParameters[10].Value = pWorkResultView2Entity.COST;
                pDataParameters[11].Value = pWorkResultView2Entity.REMARK;
                pDataParameters[12].Value = pWorkResultView2Entity.USE_YN;
                //pDataParameters[13].Value = pWorkResultView2Entity.UNIT_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultView2_I10", pDataParameters);

                pWorkResultView2Entity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                pWorkResultView2Entity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                pWorkResultView2Entity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                pWorkResultView2Entity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                pWorkResultView2Entity.RTN_AQ = pDataTable.Rows[0]["rtn_aq"].ToString();
                pWorkResultView2Entity.RTN_SQ = pDataTable.Rows[0]["rtn_sq"].ToString();
                pWorkResultView2Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {

                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;

                throw pExceptionManager;
            }
            finally
            {
                if (pErrorYN)
                    _pDBManager.RollbackTransaction();  // 저장실패
                else
                    _pDBManager.CommitTransaction();
            }

            return pErrorYN;
        }

        #endregion
    }

    public class TestDataStatusProvider : EntityManager<TestDataStatusEntity>
    {
        #region 생성자 - TestDataStatusProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public TestDataStatusProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        
        #region 파일명 조회하기 - TestDataStatus_Info_Filename(TestDataStatusEntity pTestDataStatusEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pTestDataStatusEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable TestDataStatus_Info_Filename(TestDataStatusEntity pTestDataStatusEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pTestDataStatusEntity.WINDOW_NAME;
                pDataParameters[1].Value = pTestDataStatusEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuRegister_R40", pDataParameters);

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
                    "TestDataStatus_Info_Filename(TestDataStatusEntity pTestDataStatusEntity)",
                    pException
                );
            }
        }

        #endregion
        
        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override TestDataStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                TestDataStatusEntity pTestDataStatusEntity = new TestDataStatusEntity();

                pTestDataStatusEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pTestDataStatusEntity;
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
