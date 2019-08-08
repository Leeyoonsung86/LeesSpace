using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

using CoFAS_MES.UI.MO.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;

namespace CoFAS_MES.UI.MO.Data
{
    public class SensorDataSearchProvider : EntityManager<SensorDataSearchEntity>
    {
        #region 생성자 - SensorDataSearchProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SensorDataSearchProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(SensorDataSearchEntity pSensorDataSearchEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(SensorDataSearchEntity pSensorDataSearchEntity)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                //pDataParameters[0].Value = pSensorDataSearchEntity.CRUD;
                //pDataParameters[1].Value = pSensorDataSearchEntity.DATE_FROM;
                //pDataParameters[2].Value = pSensorDataSearchEntity.DATE_TO;
                //pDataParameters[3].Value = pSensorDataSearchEntity.PART_NAME;
                //pDataParameters[4].Value = pSensorDataSearchEntity.VEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SensorDataSearch_R10", pDataParameters);

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
                    "Sample_Info_Mst(SensorDataSearchEntity pSensorDataSearchEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(SensorDataSearchEntity pSensorDataSearchEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(SensorDataSearchEntity pSensorDataSearchEntity, DataTable dt)
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

                pDataParametersA[0].Value = pSensorDataSearchEntity.CORP_CODE;
                pDataParametersA[1].Value = pSensorDataSearchEntity.CRUD;
                pDataParametersA[2].Value = pSensorDataSearchEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SensorDataSearch_I10", pDataParametersA);

                pSensorDataSearchEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pSensorDataSearchEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pSensorDataSearchEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pSensorDataSearchEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pSensorDataSearchEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                    //        pDataParametersB[0].Value = pSensorDataSearchEntity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pSensorDataSearchEntity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pSensorDataSearchEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pSensorDataSearchEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pSensorDataSearchEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pSensorDataSearchEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pSensorDataSearchEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(SensorDataSearchEntity pSensorDataSearchEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 파일명 조회하기 - SensorDataSearch_Info_Filename(SensorDataSearchEntity pSensorDataSearchEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSensorDataSearchEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable SensorDataSearch_Info_Filename(SensorDataSearchEntity pSensorDataSearchEntity)
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
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }
                pDataParameters[0].Value = pSensorDataSearchEntity.WINDOW_NAME;
                pDataParameters[1].Value = pSensorDataSearchEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuRegister_R40", pDataParameters);

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
                    "SensorDataSearch_Info_Filename(SensorDataSearchEntity pSensorDataSearchEntity)",
                    pException
                );
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialInStatusEntity pMaterialInStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object Templete_Download(SensorDataSearchEntity pSensorDataSearchEntity, string pMENU_NO, string pDSP_SORT)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_menu_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_dsp_sort", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)


                };
                        break;
                }

                pDataParameters[0].Value = pMENU_NO;
                pDataParameters[1].Value = pDSP_SORT;
                pDataParameters[2].Value = "Y";
                pDataParameters[3].Value = pSensorDataSearchEntity.LANGUAGE_TYPE;

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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override SensorDataSearchEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SensorDataSearchEntity pSensorDataSearchEntity = new SensorDataSearchEntity();

                pSensorDataSearchEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pSensorDataSearchEntity;
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

    public class SensorStatusSeacrhProvider : EntityManager<SensorStatusSeacrhEntity>
    {
        #region 생성자 - SensorStatusSeacrhProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SensorStatusSeacrhProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                //pDataParameters[0].Value = pSensorStatusSeacrhEntity.CRUD;
                //pDataParameters[1].Value = pSensorStatusSeacrhEntity.DATE_FROM;
                //pDataParameters[2].Value = pSensorStatusSeacrhEntity.DATE_TO;
                //pDataParameters[3].Value = pSensorStatusSeacrhEntity.PART_NAME;
                //pDataParameters[4].Value = pSensorStatusSeacrhEntity.VEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SensorStatusSeacrh_R10", pDataParameters);

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
                    "Sample_Info_Mst(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity, DataTable dt)
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

                pDataParametersA[0].Value = pSensorStatusSeacrhEntity.CORP_CODE;
                pDataParametersA[1].Value = pSensorStatusSeacrhEntity.CRUD;
                pDataParametersA[2].Value = pSensorStatusSeacrhEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SensorStatusSeacrh_I10", pDataParametersA);

                pSensorStatusSeacrhEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pSensorStatusSeacrhEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pSensorStatusSeacrhEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pSensorStatusSeacrhEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pSensorStatusSeacrhEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                    //        pDataParametersB[0].Value = pSensorStatusSeacrhEntity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pSensorStatusSeacrhEntity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pSensorStatusSeacrhEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pSensorStatusSeacrhEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pSensorStatusSeacrhEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pSensorStatusSeacrhEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pSensorStatusSeacrhEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 파일명 조회하기 - SensorStatusSeacrh_Info_Filename(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSensorStatusSeacrhEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable SensorStatusSeacrh_Info_Filename(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)
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
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }
                pDataParameters[0].Value = pSensorStatusSeacrhEntity.WINDOW_NAME;
                pDataParameters[1].Value = pSensorStatusSeacrhEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuRegister_R40", pDataParameters);

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
                    "SensorStatusSeacrh_Info_Filename(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)",
                    pException
                );
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialInStatusEntity pMaterialInStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object Templete_Download(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity, string pMENU_NO, string pDSP_SORT)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_menu_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_dsp_sort", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)


                };
                        break;
                }

                pDataParameters[0].Value = pMENU_NO;
                pDataParameters[1].Value = pDSP_SORT;
                pDataParameters[2].Value = "Y";
                pDataParameters[3].Value = pSensorStatusSeacrhEntity.LANGUAGE_TYPE;

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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override SensorStatusSeacrhEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SensorStatusSeacrhEntity pSensorStatusSeacrhEntity = new SensorStatusSeacrhEntity();

                pSensorStatusSeacrhEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pSensorStatusSeacrhEntity;
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

    public class SensorStatusSeacrh_T01Provider : EntityManager<SensorStatusSeacrh_T01Entity>
    {
        #region 생성자 - SensorStatusSeacrh_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SensorStatusSeacrh_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                //pDataParameters[0].Value = pSensorStatusSeacrh_T01Entity.CRUD;
                //pDataParameters[1].Value = pSensorStatusSeacrh_T01Entity.DATE_FROM;
                //pDataParameters[2].Value = pSensorStatusSeacrh_T01Entity.DATE_TO;
                //pDataParameters[3].Value = pSensorStatusSeacrh_T01Entity.PART_NAME;
                //pDataParameters[4].Value = pSensorStatusSeacrh_T01Entity.VEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SensorStatusSeacrh_T01_R10", pDataParameters);

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
                    "Sample_Info_Mst(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity, DataTable dt)
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

                pDataParametersA[0].Value = pSensorStatusSeacrh_T01Entity.CORP_CODE;
                pDataParametersA[1].Value = pSensorStatusSeacrh_T01Entity.CRUD;
                pDataParametersA[2].Value = pSensorStatusSeacrh_T01Entity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SensorStatusSeacrh_T01_I10", pDataParametersA);

                pSensorStatusSeacrh_T01Entity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pSensorStatusSeacrh_T01Entity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pSensorStatusSeacrh_T01Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pSensorStatusSeacrh_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pSensorStatusSeacrh_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                    //        pDataParametersB[0].Value = pSensorStatusSeacrh_T01Entity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pSensorStatusSeacrh_T01Entity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pSensorStatusSeacrh_T01Entity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pSensorStatusSeacrh_T01Entity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pSensorStatusSeacrh_T01Entity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pSensorStatusSeacrh_T01Entity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pSensorStatusSeacrh_T01Entity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 파일명 조회하기 - SensorStatusSeacrh_T01_Info_Filename(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSensorStatusSeacrh_T01Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable SensorStatusSeacrh_T01_Info_Filename(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)
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
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }
                pDataParameters[0].Value = pSensorStatusSeacrh_T01Entity.WINDOW_NAME;
                pDataParameters[1].Value = pSensorStatusSeacrh_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuRegister_R40", pDataParameters);

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
                    "SensorStatusSeacrh_T01_Info_Filename(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialInStatusEntity pMaterialInStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object Templete_Download(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity, string pMENU_NO, string pDSP_SORT)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_menu_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_dsp_sort", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)


                };
                        break;
                }

                pDataParameters[0].Value = pMENU_NO;
                pDataParameters[1].Value = pDSP_SORT;
                pDataParameters[2].Value = "Y";
                pDataParameters[3].Value = pSensorStatusSeacrh_T01Entity.LANGUAGE_TYPE;

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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override SensorStatusSeacrh_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity = new SensorStatusSeacrh_T01Entity();

                pSensorStatusSeacrh_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pSensorStatusSeacrh_T01Entity;
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

    public class SensorViewProvider : EntityManager<SensorViewEntity>
    {
        #region 생성자 - SensorDataSearchProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SensorViewProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 파일명 조회하기 - SensorView_Info_Filename(SensorViewEntity pSensorViewEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSensorDataSearchEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable SensorView_Info_Filename(SensorViewEntity pSensorViewEntity)
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
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }
                pDataParameters[0].Value = pSensorViewEntity.WINDOW_NAME;
                pDataParameters[1].Value = pSensorViewEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuRegister_R40", pDataParameters);

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
                    "SensorDataSearch_Info_Filename(SensorViewEntity pSensorViewEntity)",
                    pException
                );
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialInStatusEntity pMaterialInStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object Templete_Download(SensorDataSearchEntity pSensorDataSearchEntity, string pMENU_NO, string pDSP_SORT)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_menu_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_dsp_sort", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)


                };
                        break;
                }

                pDataParameters[0].Value = pMENU_NO;
                pDataParameters[1].Value = pDSP_SORT;
                pDataParameters[2].Value = "Y";
                pDataParameters[3].Value = pSensorDataSearchEntity.LANGUAGE_TYPE;

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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override SensorViewEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SensorViewEntity pSensorViewEntity = new SensorViewEntity();

                pSensorViewEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pSensorViewEntity;
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

    public class DoorOpeningClosingStatusProvider : EntityManager<DoorOpeningClosingStatusEntity>
    {
        #region 생성자 - DoorOpeningClosingStatusProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public DoorOpeningClosingStatusProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_start_time", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_end_time", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_summary_term", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_start_time", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_end_time", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_summary_term", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pDoorOpeningClosingStatusEntity.RESOURCE_CODE;
                if (pDoorOpeningClosingStatusEntity.FROM_DATE == null)
                {
                    pDataParameters[1].Value = "2000-01-01 00:00:00";
                    pDataParameters[2].Value = "2000-01-10 00:00:00";
                    pDataParameters[3].Value = "DAY";
                }
                else
                {
                    pDataParameters[1].Value = pDoorOpeningClosingStatusEntity.FROM_DATE;
                    pDataParameters[2].Value = pDoorOpeningClosingStatusEntity.TO_DATE;
                    pDataParameters[3].Value = pDoorOpeningClosingStatusEntity.INTERVAL;
                }
                


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GetCategorySummariesWithZero", pDataParameters);

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
                    "Sample_Info_Mst(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity, DataTable dt)
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

                pDataParametersA[0].Value = pDoorOpeningClosingStatusEntity.CORP_CODE;
                pDataParametersA[1].Value = pDoorOpeningClosingStatusEntity.CRUD;
                pDataParametersA[2].Value = pDoorOpeningClosingStatusEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DoorOpeningClosingStatus_I10", pDataParametersA);

                pDoorOpeningClosingStatusEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pDoorOpeningClosingStatusEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pDoorOpeningClosingStatusEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pDoorOpeningClosingStatusEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pDoorOpeningClosingStatusEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                    //        pDataParametersB[0].Value = pDoorOpeningClosingStatusEntity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pDoorOpeningClosingStatusEntity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pDoorOpeningClosingStatusEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pDoorOpeningClosingStatusEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pDoorOpeningClosingStatusEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pDoorOpeningClosingStatusEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pDoorOpeningClosingStatusEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 파일명 조회하기 - DoorOpeningClosingStatus_Info_Filename(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pDoorOpeningClosingStatusEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable DoorOpeningClosingStatus_Info_Filename(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)
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
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }
                pDataParameters[0].Value = pDoorOpeningClosingStatusEntity.WINDOW_NAME;
                pDataParameters[1].Value = pDoorOpeningClosingStatusEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuRegister_R40", pDataParameters);

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
                    "DoorOpeningClosingStatus_Info_Filename(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)",
                    pException
                );
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialInStatusEntity pMaterialInStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object Templete_Download(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity, string pMENU_NO, string pDSP_SORT)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_menu_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_dsp_sort", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)


                };
                        break;
                }

                pDataParameters[0].Value = pMENU_NO;
                pDataParameters[1].Value = pDSP_SORT;
                pDataParameters[2].Value = "Y";
                pDataParameters[3].Value = pDoorOpeningClosingStatusEntity.LANGUAGE_TYPE;

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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override DoorOpeningClosingStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity = new DoorOpeningClosingStatusEntity();

                pDoorOpeningClosingStatusEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pDoorOpeningClosingStatusEntity;
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

    public class Gathering_InfoProvider : EntityManager<Gathering_InfoEntity>
    {
        #region 생성자 - Gathering_InfoProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public Gathering_InfoProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(Gathering_InfoEntity pGathering_InfoEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(Gathering_InfoEntity pGathering_InfoEntity)
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
                            new MySqlParameter("@v_resource_code",MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_resource_name",MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_resource_min_1",MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_resource_max_1",MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_resource_min_2",MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_resource_max_2",MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_resource_min_3",MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_resource_max_3",MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_resource_min_4",MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_resource_max_4",MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_resource_min_5",MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_resource_max_5",MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_remark",MySqlDbType.VarChar,1000),
                            new MySqlParameter("@v_use_yn",MySqlDbType.VarChar,1),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_resource_code",SqlDbType.VarChar, 50),
                            new SqlParameter("@v_resource_name",SqlDbType.VarChar, 50),
                            new SqlParameter("@v_resource_min_1",SqlDbType.VarChar,50),
                            new SqlParameter("@v_resource_max_1",SqlDbType.VarChar,50),
                            new SqlParameter("@v_resource_min_2",SqlDbType.VarChar,50),
                            new SqlParameter("@v_resource_max_2",SqlDbType.VarChar,50),
                            new SqlParameter("@v_resource_min_3",SqlDbType.VarChar,50),
                            new SqlParameter("@v_resource_max_3",SqlDbType.VarChar,50),
                            new SqlParameter("@v_resource_min_4",SqlDbType.VarChar,50),
                            new SqlParameter("@v_resource_max_4",SqlDbType.VarChar,50),
                            new SqlParameter("@v_resource_min_5",SqlDbType.VarChar,50),
                            new SqlParameter("@v_resource_max_5",SqlDbType.VarChar,50),
                            new SqlParameter("@v_remark",SqlDbType.VarChar,1000),
                            new SqlParameter("@v_use_yn",SqlDbType.VarChar,1),
                        };
                        break;
                }

                pDataParameters[0].Value = pGathering_InfoEntity.CRUD;
                pDataParameters[1].Value = pGathering_InfoEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pGathering_InfoEntity.RESOURCE_NAME;
                pDataParameters[3].Value = pGathering_InfoEntity.RESOURCE_MIN_1;
                pDataParameters[4].Value = pGathering_InfoEntity.RESOURCE_MAX_1;
                pDataParameters[5].Value = pGathering_InfoEntity.RESOURCE_MIN_2;
                pDataParameters[6].Value = pGathering_InfoEntity.RESOURCE_MAX_2;
                pDataParameters[7].Value = pGathering_InfoEntity.RESOURCE_MIN_3;
                pDataParameters[8].Value = pGathering_InfoEntity.RESOURCE_MAX_3;
                pDataParameters[9].Value = pGathering_InfoEntity.RESOURCE_MIN_4;
                pDataParameters[10].Value = pGathering_InfoEntity.RESOURCE_MAX_4;
                pDataParameters[11].Value = pGathering_InfoEntity.RESOURCE_MIN_5;
                pDataParameters[12].Value = pGathering_InfoEntity.RESOURCE_MAX_5;
                pDataParameters[13].Value = pGathering_InfoEntity.REMARK;
                pDataParameters[14].Value = pGathering_InfoEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Gathering_Info_R10", pDataParameters);

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
                    "Sample_Info_Mst(Gathering_InfoEntity pGathering_InfoEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Gathering_Info_Info_Save(Gathering_InfoEntity pGathering_InfoEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Gathering_Info_Info_Save(Gathering_InfoEntity pGathering_InfoEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
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
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_min_1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_max_1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_min_2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_max_2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_min_3",MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_resource_max_3",MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_resource_min_4",MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_resource_max_4",MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_resource_min_5",MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_resource_max_5",MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.VarChar, 20),
                                new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_resource_min_1", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_resource_max_1", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_resource_min_2", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_resource_max_2", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_resource_min_3",SqlDbType.VarChar,50),
                                new SqlParameter("@v_resource_max_3",SqlDbType.VarChar,50),
                                new SqlParameter("@v_resource_min_4",SqlDbType.VarChar,50),
                                new SqlParameter("@v_resource_max_4",SqlDbType.VarChar,50),
                                new SqlParameter("@v_resource_min_5",SqlDbType.VarChar,50),
                                new SqlParameter("@v_resource_max_5",SqlDbType.VarChar,50),
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pGathering_InfoEntity.CRUD;
                pDataParametersA[1].Value = pGathering_InfoEntity.USER_CODE;
                pDataParametersA[2].Value = pGathering_InfoEntity.RESOURCE_CODE;
                pDataParametersA[3].Value = pGathering_InfoEntity.RESOURCE_MIN_1;
                pDataParametersA[4].Value = pGathering_InfoEntity.RESOURCE_MAX_1;
                pDataParametersA[5].Value = pGathering_InfoEntity.RESOURCE_MIN_2;
                pDataParametersA[6].Value = pGathering_InfoEntity.RESOURCE_MAX_2;
                pDataParametersA[7].Value = pGathering_InfoEntity.RESOURCE_MIN_3;
                pDataParametersA[8].Value = pGathering_InfoEntity.RESOURCE_MAX_3;
                pDataParametersA[9].Value = pGathering_InfoEntity.RESOURCE_MIN_4;
                pDataParametersA[10].Value = pGathering_InfoEntity.RESOURCE_MAX_4;
                pDataParametersA[11].Value = pGathering_InfoEntity.RESOURCE_MIN_5;
                pDataParametersA[12].Value = pGathering_InfoEntity.RESOURCE_MAX_5;
                pDataParametersA[13].Value = pGathering_InfoEntity.REMARK;
                pDataParametersA[14].Value = pGathering_InfoEntity.USE_YN;


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Gathering_Info_I10", pDataParametersA);

                pGathering_InfoEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pGathering_InfoEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pGathering_InfoEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pGathering_InfoEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
                //pGathering_InfoEntity.SensorCnt = pDataTableA.Rows[0]["SENSORCNT"].ToString();

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
                    "Gathering_Info_Info_Save(Gathering_InfoEntity pGathering_InfoEntity, DataTable dt)",
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
        public override Gathering_InfoEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                Gathering_InfoEntity pGathering_InfoEntity = new Gathering_InfoEntity();

                pGathering_InfoEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pGathering_InfoEntity;
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

    } // 게더링 수식등록

    public class DPSSetting_mstProvider : EntityManager<DPSSetting_mstEntity>
    {
        #region 생성자 - DPSSetting_mstProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public DPSSetting_mstProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(DPSSetting_mstEntity pDPSSetting_mstEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(DPSSetting_mstEntity pDPSSetting_mstEntity)
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
                            new MySqlParameter("@v_gathering_gubn",MySqlDbType.VarChar,50),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_mode",SqlDbType.NVarChar,50),
                        };
                        break;
                }

                pDataParameters[0].Value = pDPSSetting_mstEntity.CRUD;
                pDataParameters[1].Value = pDPSSetting_mstEntity.GATHERING_GUBN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DPSSetting_mst_R10", pDataParameters);

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
                    "Sample_Info_Mst(DPSSetting_mstEntity pDPSSetting_mstEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Gathering_Info_Info_Save(DPSSetting_mstEntity pDPSSetting_mstEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDPSSetting_mstEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Gathering_Info_Info_Save(DPSSetting_mstEntity pDPSSetting_mstEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
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
                                new MySqlParameter("@v_gathering_id",MySqlDbType.Int64),
                                new MySqlParameter("@v_gathering_gubn",MySqlDbType.VarChar,10),
                                new MySqlParameter("@v_gathering_code",MySqlDbType.VarChar,10),
                                new MySqlParameter("@v_gathering_name",MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_gathering_ip",MySqlDbType.VarChar,10),
                                new MySqlParameter("@v_gathering_port",MySqlDbType.VarChar,10),
                                new MySqlParameter("@v_gathering_interval",MySqlDbType.VarChar,10),
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_gathering_id",SqlDbType.BigInt),
                                new SqlParameter("@v_gathering_gubn",SqlDbType.NVarChar,10),
                                new SqlParameter("@v_gathering_code",SqlDbType.NVarChar,10),
                                new SqlParameter("@v_gathering_name",SqlDbType.NVarChar,100),
                                new SqlParameter("@v_gathering_ip",SqlDbType.NVarChar,10),
                                new SqlParameter("@v_gathering_port",SqlDbType.NVarChar,10),
                                new SqlParameter("@v_gathering_interval",SqlDbType.NVarChar,10),
                        };
                        break;
                }

                pDataParametersA[0].Value = pDPSSetting_mstEntity.CRUD;
                pDataParametersA[1].Value = pDPSSetting_mstEntity.GATHERING_ID;
                pDataParametersA[2].Value = pDPSSetting_mstEntity.GATHERING_GUBN;
                pDataParametersA[3].Value = pDPSSetting_mstEntity.GATHERING_CODE;
                pDataParametersA[4].Value = pDPSSetting_mstEntity.GATHERING_NAME;
                pDataParametersA[5].Value = pDPSSetting_mstEntity.GATHERING_IP;
                pDataParametersA[6].Value = pDPSSetting_mstEntity.GATHERING_PORT;
                pDataParametersA[7].Value = pDPSSetting_mstEntity.GATHERING_INTERVAL;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DPSSetting_mst_I10", pDataParametersA);

                pDPSSetting_mstEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pDPSSetting_mstEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pDPSSetting_mstEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pDPSSetting_mstEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
                //pGathering_InfoEntity.SensorCnt = pDataTableA.Rows[0]["SENSORCNT"].ToString();

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
                    "Gathering_Info_Info_Save(DPSSetting_mstEntity pDPSSetting_mstEntity, DataTable dt)",
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
        public override DPSSetting_mstEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                DPSSetting_mstEntity pDPSSetting_mstEntity = new DPSSetting_mstEntity();

                pDPSSetting_mstEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pDPSSetting_mstEntity;
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
