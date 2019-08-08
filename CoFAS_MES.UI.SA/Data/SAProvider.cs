using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

using CoFAS_MES.UI.SA.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;


namespace CoFAS_MES.UI.SA.Data
{
    public class LanguageInfoRegisterProvider : EntityManager<LanguageInfoRegisterEntity>
    {
        #region 생성자 - LanguageInfoRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public LanguageInfoRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 정보 조회하기 - Language_Info(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pLanguageInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Language_Info(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pLanguageInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pLanguageInfoRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pLanguageInfoRegisterEntity.WINDOW_NAME;
                pDataParameters[3].Value = pLanguageInfoRegisterEntity.USE_YN;
                

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_LanguageInfoRegister_R10", pDataParameters);

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
                    "Language_Info(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Language_Info_Save(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pLanguageInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Language_Info_Save(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction();

            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    for (int a = 0; a < pCount; a++)
                    {
                        IDataParameter[] pDataParameters = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters = new IDataParameter[]
                                {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_code_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_field_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_field_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_field_name2", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_field_desc", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_field_key", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_value", MySqlDbType.VarChar, 100),
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_code_type", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_field_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_field_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_field_name2", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_field_desc", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_field_key", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                                     new SqlParameter("@v_value", SqlDbType.NVarChar, 100),
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pLanguageInfoRegisterEntity.USER_CODE;
                        pDataParameters[2].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["CODE_TYPE"].ToString().ToUpper());
                        pDataParameters[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["LANGUAGE_TYPE"].ToString().ToUpper());
                        pDataParameters[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["WINDOW_NAME"].ToString());

                        if (dt.Rows[a]["CRUD"].ToString().ToUpper().Equals("C"))
                        {
                            pDataParameters[5].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["FIELD_CODE"].ToString().ToUpper());
                        }
                        else
                        {
                            pDataParameters[5].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["OLD_FIELD_CODE"].ToString().ToUpper());
                        }
                        pDataParameters[6].Value = dt.Rows[a]["FIELD_NAME"].ToString();
                        pDataParameters[7].Value = dt.Rows[a]["FIELD_NAME2"].ToString();
                        pDataParameters[8].Value = dt.Rows[a]["FIELD_DESC"].ToString();
                        pDataParameters[9].Value = dt.Rows[a]["FIELD_KEY"].ToString();

                        pDataParameters[10].Value = dt.Rows[a]["REMARK"].ToString();
                        pDataParameters[11].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();
                        pDataParameters[12].Value = dt.Rows[a]["FIELD_CODE"].ToString().ToUpper();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_LanguageInfoRegister_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pLanguageInfoRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pLanguageInfoRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pLanguageInfoRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pLanguageInfoRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pLanguageInfoRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Language_Info(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity)",
                    pException
                );
            }
            finally
            {
                if (pErrorYN == true)
                    _pDBManager.RollbackTransaction();
                else
                    _pDBManager.CommitTransaction();

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
        public override LanguageInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                LanguageInfoRegisterEntity pLanguageInfoRegisterEntity = new LanguageInfoRegisterEntity();

                //pLanguageInfoRegisterEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pLanguageInfoRegisterEntity;
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

    public class MessageInfoRegisterProvider : EntityManager<MessageInfoRegisterEntity>
    {
        #region 생성자 - MessageInfoRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MessageInfoRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 정보 조회하기 - Message_Info(MessageInfoRegisterEntity pMessageInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMessageInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Message_Info(MessageInfoRegisterEntity pMessageInfoRegisterEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_message_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_message_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_window_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_message_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_message_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pMessageInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pMessageInfoRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pMessageInfoRegisterEntity.WINDOW_NAME;
                pDataParameters[3].Value = pMessageInfoRegisterEntity.MESSAGE_TYPE;
                pDataParameters[4].Value = pMessageInfoRegisterEntity.MESSAGE_CODE;
                pDataParameters[5].Value = pMessageInfoRegisterEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MessageInfoRegister_R10", pDataParameters);

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
                    "Message_Info(MessageInfoRegisterEntity pMessageInfoRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Message_Info_Save(MessageInfoRegisterEntity pMessageInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pMessageInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Message_Info_Save(MessageInfoRegisterEntity pMessageInfoRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction();

            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    for (int a = 0; a < pCount; a++)
                    {
                        IDataParameter[] pDataParameters = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters = new IDataParameter[]
                                {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_message_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_message_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_message_value", MySqlDbType.VarChar, 500),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_window_name", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_message_type", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_message_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_message_value", SqlDbType.NVarChar, 500),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pMessageInfoRegisterEntity.USER_CODE;
                        pDataParameters[2].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["LANGUAGE_TYPE"].ToString().ToUpper());
                        pDataParameters[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["WINDOW_NAME"].ToString());
                        pDataParameters[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["MESSAGE_TYPE"].ToString().ToUpper());
                        pDataParameters[5].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["MESSAGE_CODE"].ToString().ToUpper());
                        pDataParameters[6].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["MESSAGE_VALUE"].ToString());
                        pDataParameters[7].Value = dt.Rows[a]["REMARK"].ToString();
                        pDataParameters[8].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MessageInfoRegister_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pMessageInfoRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pMessageInfoRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pMessageInfoRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pMessageInfoRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pMessageInfoRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
                    }



                }

                if (pMessageInfoRegisterEntity.CRUD == "D")
                {
                    IDataParameter[] pDataParametersD = null;

                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersD = new IDataParameter[]
                            {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_message_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_message_value", MySqlDbType.VarChar, 500),
                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                            };
                            break;

                        case "SQLServer":
                            pDataParametersD = new IDataParameter[]
                            {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_message_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_message_value", SqlDbType.NVarChar, 500),
                            new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                            };
                            break;
                    }

                    pDataParametersD[0].Value = pMessageInfoRegisterEntity.CRUD;
                    pDataParametersD[1].Value = pMessageInfoRegisterEntity.USER_CODE;
                    pDataParametersD[2].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pMessageInfoRegisterEntity.LANGUAGE_TYPE);
                    pDataParametersD[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pMessageInfoRegisterEntity.MESSAGE_CODE);
                    pDataParametersD[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pMessageInfoRegisterEntity.MESSAGE_VALUE);
                    pDataParametersD[5].Value = "";
                    pDataParametersD[6].Value = "";

                    DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MessageInfoRegister_I10", pDataParametersD);

                    if (pDataTable.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }

                    pMessageInfoRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                    pMessageInfoRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                    pMessageInfoRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                    pMessageInfoRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                    pMessageInfoRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Message_Info_Save(MessageInfoRegisterEntity pMessageInfoRegisterEntity, DataTable dt)",
                    pException
                );
            }
            finally
            {
                if (pErrorYN == true)
                    _pDBManager.RollbackTransaction();
                else
                    _pDBManager.CommitTransaction();

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
        public override MessageInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MessageInfoRegisterEntity pMessageInfoRegisterEntity = new MessageInfoRegisterEntity();

                //pLanguageInfoRegisterEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pMessageInfoRegisterEntity;
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

    public class GridInfoRegisterProvider : EntityManager<GridInfoRegisterEntity>
    {
        #region 생성자 - GridInfoRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public GridInfoRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Grid_Info_Mst(GridInfoRegisterEntity pGridInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Grid_Info_Mst(GridInfoRegisterEntity pGridInfoRegisterEntity)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pGridInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pGridInfoRegisterEntity.WINDOW_NAME;
                pDataParameters[2].Value = pGridInfoRegisterEntity.USE_YN;
                pDataParameters[3].Value = pGridInfoRegisterEntity.LANGUAGE_TYPE;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_R10", pDataParameters);

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
                    "Grid_Info(GridInfoRegisterEntity pGridInfoRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 상세 조회하기 - Grid_Info_Sub(GridInfoRegisterEntity pGridInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Grid_Info_Sub(GridInfoRegisterEntity pGridInfoRegisterEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_grid_name", MySqlDbType.VarChar, 50)
                            
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_grid_name", SqlDbType.NVarChar, 50)
                            
                        };
                        break;
                }

                pDataParameters[0].Value = pGridInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pGridInfoRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pGridInfoRegisterEntity.WINDOW_NAME;
                pDataParameters[3].Value = pGridInfoRegisterEntity.GRID_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_R20", pDataParameters);

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
                    "Grid_Info(GridInfoRegisterEntity pGridInfoRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)
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
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),

                                new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_grid_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_gridview_name", MySqlDbType.VarChar, 50),

                                new MySqlParameter("@v_edit_able", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_editor_showmode", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_read_only", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_allow_column_moving", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_allow_column_resizing", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_allow_filter", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_allow_sort", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_enable_column_menu", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_multi_select", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_gridmulti_selectmode", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_showcheckboxselector_incolumnheader", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_column_autowidth", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_enable_appearance_evenrow", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_enable_appearance_oddrow", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_grouppanel", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_indicator", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_autofilterrow", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_footer", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_newitemrowposition", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_newitemrowname", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_allow_drop", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 100)
                                
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),

                                new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_grid_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_gridview_name", SqlDbType.NVarChar, 50),

                                new SqlParameter("@v_edit_able", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_editor_showmode", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_read_only", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_allow_column_moving", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_allow_column_resizing", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_allow_filter", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_allow_sort", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_enable_column_menu", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_multi_select", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_gridmulti_selectmode", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_showcheckboxselector_incolumnheader", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_column_autowidth", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_enable_appearance_evenrow", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_enable_appearance_oddrow", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_grouppanel", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_indicator", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_autofilterrow", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_footer", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_newitemrowposition", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_newitemrowname", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_allow_drop", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 100)

                        };
                        break;
                }

                pDataParametersA[0].Value =  pGridInfoRegisterEntity.CRUD;
                pDataParametersA[1].Value =  pGridInfoRegisterEntity.USER_CODE;
                pDataParametersA[2].Value =  pGridInfoRegisterEntity.WINDOW_NAME;
                pDataParametersA[3].Value =  pGridInfoRegisterEntity.GRID_NAME;
                pDataParametersA[4].Value =  pGridInfoRegisterEntity.GRIDVIEW_NAME;
                pDataParametersA[5].Value =  pGridInfoRegisterEntity.EDIT_ABLE;
                pDataParametersA[6].Value =  pGridInfoRegisterEntity.EDITOR_SHOWMODE;
                pDataParametersA[7].Value =  pGridInfoRegisterEntity.READ_ONLY;
                pDataParametersA[8].Value =  pGridInfoRegisterEntity.ALLOW_COLUMN_MOVING;
                pDataParametersA[9].Value =  pGridInfoRegisterEntity.ALLOW_COLUMN_RESIZING;
                pDataParametersA[10].Value = pGridInfoRegisterEntity.ALLOW_FILTER;
                pDataParametersA[11].Value = pGridInfoRegisterEntity.ALLOW_SORT;
                pDataParametersA[12].Value = pGridInfoRegisterEntity.ENABLE_COLUMN_MENU;
                pDataParametersA[13].Value = pGridInfoRegisterEntity.MULTI_SELECT;
                pDataParametersA[14].Value = pGridInfoRegisterEntity.GRIDMULTI_SELECTMODE;
                pDataParametersA[15].Value = pGridInfoRegisterEntity.SHOWCHECKBOXSELECTOR_INCOLUMNHEADER;
                pDataParametersA[16].Value = pGridInfoRegisterEntity.COLUMN_AUTOWIDTH;
                pDataParametersA[17].Value = pGridInfoRegisterEntity.ENABLE_APPEARANCE_EVENROW;
                pDataParametersA[18].Value = pGridInfoRegisterEntity.ENABLE_APPEARANCE_ODDROW;
                pDataParametersA[19].Value = pGridInfoRegisterEntity.SHOW_GROUPPANEL;
                pDataParametersA[20].Value = pGridInfoRegisterEntity.SHOW_INDICATOR;
                pDataParametersA[21].Value = pGridInfoRegisterEntity.SHOW_AUTOFILTERROW;
                pDataParametersA[22].Value = pGridInfoRegisterEntity.SHOW_FOOTER;
                pDataParametersA[23].Value = pGridInfoRegisterEntity.GRID_NEWITEMROWPOSITION;
                pDataParametersA[24].Value = pGridInfoRegisterEntity.GRID_NEWITEMROWNAME;
                pDataParametersA[25].Value = pGridInfoRegisterEntity.ALLOW_DROP;
                pDataParametersA[26].Value = pGridInfoRegisterEntity.USE_YN;
                pDataParametersA[27].Value = pGridInfoRegisterEntity.REMARK;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I10", pDataParametersA);

                pGridInfoRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pGridInfoRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pGridInfoRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pGridInfoRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pGridInfoRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),

                                        new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_grid_name", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_gridview_name", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_column_name", MySqlDbType.VarChar, 100),
                                        new MySqlParameter("@v_column_seq", MySqlDbType.Int32),
                                        new MySqlParameter("@v_column_caption", MySqlDbType.VarChar, 100),
                                        new MySqlParameter("@v_column_caption_color", MySqlDbType.VarChar, 1),

                                        new MySqlParameter("@v_column_field_name", MySqlDbType.VarChar, 100),
                                        new MySqlParameter("@v_column_size", MySqlDbType.Int32),
                                        new MySqlParameter("@v_column_type", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_text_size", MySqlDbType.Int32),
                                        new MySqlParameter("@v_parameter_data", MySqlDbType.VarChar, 100),
                                        new MySqlParameter("@v_unbound_columntype", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_horz_alignment", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_allow_edit", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_allow_focus", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_allow_merge", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_format_type", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_format_string", MySqlDbType.VarChar, 100),
                                        new MySqlParameter("@v_showunbound_expressionmenu", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_visible_index", MySqlDbType.Int32),
                                        new MySqlParameter("@v_visible", MySqlDbType.VarChar, 1),

                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 100),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),

                                        new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_grid_name", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_gridview_name", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_column_name", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@v_column_seq", SqlDbType.Int),
                                        new SqlParameter("@v_column_caption", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@v_column_caption_color", SqlDbType.NVarChar, 1),

                                        new SqlParameter("@v_column_field_name", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@v_column_size", SqlDbType.Int),
                                        new SqlParameter("@v_column_type", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_text_size", SqlDbType.Int),
                                        new SqlParameter("@v_parameter_data", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@v_unbound_columntype", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_horz_alignment", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_allow_edit", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_allow_focus", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_allow_merge", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_format_type", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_format_string", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@v_showunbound_expressionmenu", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_visible_index", SqlDbType.Int),
                                        new SqlParameter("@v_visible", SqlDbType.NVarChar, 1),

                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value  = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[1].Value  = pGridInfoRegisterEntity.USER_CODE;


                            pDataParametersB[2].Value = dt.Rows[a]["LANGUAGE_TYPE"].ToString().ToUpper();
                            pDataParametersB[3].Value  = pGridInfoRegisterEntity.WINDOW_NAME;
                            pDataParametersB[4].Value  = pGridInfoRegisterEntity.GRID_NAME;
                            pDataParametersB[5].Value  = pGridInfoRegisterEntity.GRIDVIEW_NAME;
                            pDataParametersB[6].Value  = dt.Rows[a]["COLUMN_NAME"].ToString().ToUpper();
                            pDataParametersB[7].Value  = Convert.ToInt32(dt.Rows[a]["COLUMN_SEQ"].ToString() == "" ? "0" : dt.Rows[a]["COLUMN_SEQ"].ToString());
                            pDataParametersB[8].Value  = dt.Rows[a]["COLUMN_CAPTION"].ToString();
                            pDataParametersB[9].Value  = dt.Rows[a]["COLUMN_CAPTION_COLOR"].ToString().ToUpper();
                            pDataParametersB[10].Value  = dt.Rows[a]["COLUMN_FIELD_NAME"].ToString().ToUpper();
                            pDataParametersB[11].Value = Convert.ToInt32(dt.Rows[a]["COLUMN_SIZE"].ToString() == "" ? "0" : dt.Rows[a]["COLUMN_SIZE"].ToString());
                            pDataParametersB[12].Value = dt.Rows[a]["COLUMN_TYPE"].ToString().ToUpper();
                            pDataParametersB[13].Value = Convert.ToInt32(dt.Rows[a]["TEXT_SIZE"].ToString() == "" ? "0" : dt.Rows[a]["TEXT_SIZE"].ToString());

                            pDataParametersB[14].Value = dt.Rows[a]["PARAMETER_DATA"].ToString().ToUpper();
                            pDataParametersB[15].Value = dt.Rows[a]["UNBOUND_COLUMNTYPE"].ToString().ToUpper();
                            pDataParametersB[16].Value = dt.Rows[a]["HORZ_ALIGNMENT"].ToString().ToUpper();
                            pDataParametersB[17].Value = dt.Rows[a]["ALLOW_EDIT"].ToString().ToUpper();
                            pDataParametersB[18].Value = dt.Rows[a]["ALLOW_FOCUS"].ToString().ToUpper();
                            pDataParametersB[19].Value = dt.Rows[a]["ALLOW_MERGE"].ToString().ToUpper();
                            pDataParametersB[20].Value = dt.Rows[a]["FORMAT_TYPE"].ToString().ToUpper();
                            pDataParametersB[21].Value = dt.Rows[a]["FORMAT_STRING"].ToString().ToUpper();
                            pDataParametersB[22].Value = dt.Rows[a]["SHOWUNBOUND_EXPRESSIONMENU"].ToString().ToUpper();
                            pDataParametersB[23].Value = Convert.ToInt32(dt.Rows[a]["VISIBLE_INDEX"].ToString() == "" ? "0" : dt.Rows[a]["VISIBLE_INDEX"].ToString());
                            pDataParametersB[24].Value = dt.Rows[a]["VISIBLE"].ToString().ToUpper();
                            pDataParametersB[25].Value = dt.Rows[a]["REMARK"].ToString();
                            pDataParametersB[26].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pGridInfoRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pGridInfoRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pGridInfoRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pGridInfoRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pGridInfoRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)",
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
        public override GridInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                GridInfoRegisterEntity pGridInfoRegisterEntity = new GridInfoRegisterEntity();

                //pGridInfoRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pGridInfoRegisterEntity;
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

    public class DynamicColumnInfoRegisterProvider : EntityManager<DynamicColumnInfoRegisterEntity>
    {
        #region 생성자 - DynamicColumnInfoRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public DynamicColumnInfoRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 정보 조회하기 - DynamicColumn_Info(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pDynamicColumnInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable DynamicColumn_Info(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity)
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
                            new MySqlParameter("@v_dynamic_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                            
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_dynamic_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                            
                        };
                        break;
                }

                pDataParameters[0].Value = pDynamicColumnInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pDynamicColumnInfoRegisterEntity.DYNAMIC_TYPE;
                pDataParameters[2].Value = pDynamicColumnInfoRegisterEntity.USE_YN;
               

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DynamicColumnInfoRegister_R10", pDataParameters);

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
                    "DynamicColumn_Info(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - DynamicColumn_Info_Save(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDynamicColumnInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool DynamicColumn_Info_Save(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    for (int a = 0; a < pCount; a++)
                    {
                        IDataParameter[] pDataParameters = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters = new IDataParameter[]
                                {
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_dynamic_type", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_dynamic_seq", MySqlDbType.Int32),
                                    new MySqlParameter("@v_dynamic_column", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_dynamic_column_name", MySqlDbType.VarChar,100),
                                    new MySqlParameter("@v_dynamic_column_type", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),
                                    new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_dynamic_type", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_dynamic_seq", SqlDbType.Int),
                                    new SqlParameter("@v_dynamic_column", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_dynamic_column_name", SqlDbType.NVarChar,100),
                                    new SqlParameter("@v_dynamic_column_type", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1),
                                    new SqlParameter("@v_remark", SqlDbType.NVarChar,1000)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pDynamicColumnInfoRegisterEntity.USER_CODE;
                        pDataParameters[2].Value = dt.Rows[a]["DYNAMIC_TYPE"].ToString().ToUpper();
                        pDataParameters[3].Value = Convert.ToInt32(dt.Rows[a]["DYNAMIC_SEQ"].ToString() == "" ? "0" : dt.Rows[a]["DYNAMIC_SEQ"].ToString());
                        pDataParameters[4].Value = dt.Rows[a]["DYNAMIC_COLUMN"].ToString().ToUpper();
                        pDataParameters[5].Value = dt.Rows[a]["DYNAMIC_COLUMN_NAME"].ToString().ToUpper();
                        pDataParameters[6].Value = dt.Rows[a]["DYNAMIC_COLUMN_TYPE"].ToString().ToUpper();
                        pDataParameters[7].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();
                        pDataParameters[8].Value = dt.Rows[a]["REMARK"].ToString();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DynamicColumnInfoRegister_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pDynamicColumnInfoRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pDynamicColumnInfoRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pDynamicColumnInfoRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pDynamicColumnInfoRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pDynamicColumnInfoRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "DynamicColumn_Info_Save(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity, DataTable dt)",
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
        public override DynamicColumnInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity = new DynamicColumnInfoRegisterEntity();

                //pDynamicColumnInfoRegisterEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pDynamicColumnInfoRegisterEntity;
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


    public class MenuRegisterProvider : EntityManager<MenuRegisterEntity>
    {
        #region 생성자 - MenuRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MenuRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - MenuRegister_Info_Mst(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MenuRegister_Info_Mst(MenuRegisterEntity pMenuRegisterEntity)
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
                            new MySqlParameter("@v_menu_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_module", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud",             SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_menu_name",        SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_window_name",      SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_module",           SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_use_yn",           SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pMenuRegisterEntity.CRUD;
                pDataParameters[1].Value = pMenuRegisterEntity.MENU_NAME;
                pDataParameters[2].Value = pMenuRegisterEntity.WINDOW_NAME;
                pDataParameters[3].Value = pMenuRegisterEntity.MODULE;
                pDataParameters[4].Value = pMenuRegisterEntity.USE_YN;
                pDataParameters[5].Value = pMenuRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuRegister_R11", pDataParameters);

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
                    "MenuRegister_Info_Mst(MenuRegisterEntity pMenuRegisterEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 상세 조회하기 - MenuRegister_Info_Sub(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MenuRegister_Info_Sub(MenuRegisterEntity pMenuRegisterEntity)
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
                            new MySqlParameter("@v_menu_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_menu_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pMenuRegisterEntity.CRUD;
                pDataParameters[1].Value = pMenuRegisterEntity.MENU_NO;
                pDataParameters[2].Value = pMenuRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuRegister_R20", pDataParameters);

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
                    "MenuRegister_Info_Sub(MenuRegisterEntity pMenuRegisterEntity)",
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
        public bool MenuRegister_Info_Save(MenuRegisterEntity pMenuRegisterEntity, DataTable dt)
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
                                new MySqlParameter("@v_crud"            , MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code"       , MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_menu_no"         , MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_menu_name"       , MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_p_menu_no"       , MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_window_name"     , MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_module"          , MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_iconcss"         , MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_dsp_sort"        , MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_remark"          , MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_use_yn"          , MySqlDbType.VarChar, 1)


                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud"              , SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code"         , SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_menu_no"           , SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_menu_name"         , SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_p_menu_no"         , SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_window_name"       , SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_module"            , SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_iconcss"           , SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_dsp_sort"          , SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_remark"            , SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_use_yn"            , SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pMenuRegisterEntity.CRUD;
                pDataParametersA[1].Value = pMenuRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pMenuRegisterEntity.MENU_NO;
                pDataParametersA[3].Value = pMenuRegisterEntity.MENU_NAME;
                pDataParametersA[4].Value = pMenuRegisterEntity.P_MENU_NO;
                pDataParametersA[5].Value = pMenuRegisterEntity.WINDOW_NAME;
                pDataParametersA[6].Value = pMenuRegisterEntity.MODULE;
                pDataParametersA[7].Value = pMenuRegisterEntity.ICONCSS;
                pDataParametersA[8].Value = pMenuRegisterEntity.DSP_SORT;
                pDataParametersA[9].Value =  pMenuRegisterEntity.REMARK;
                pDataParametersA[10].Value = pMenuRegisterEntity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuRegister_I11", pDataParametersA);

                pMenuRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pMenuRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pMenuRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pMenuRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pMenuRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_menu_no"         , MySqlDbType.VarChar, 10),
                                        new MySqlParameter("@v_dsp_sort"         , MySqlDbType.VarChar, 10),
                                        new MySqlParameter("@v_templete_name"         , MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_xml_file"       , MySqlDbType.Blob),
                                        new MySqlParameter("@v_xml_file_name"       , MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_remark"          , MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_use_yn"          , MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_language_type"          , MySqlDbType.VarChar, 50)

                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_menu_no"         , SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_dsp_sort"         , SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_templete_name"         , SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_xml_file"       , SqlDbType.VarBinary),
                                        new SqlParameter("@v_xml_file_name"       , SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_remark"          , SqlDbType.NVarChar, 1000),
                                        new SqlParameter("@v_use_yn"          , SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_language_type"          , SqlDbType.NVarChar, 50)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[1].Value = pMenuRegisterEntity.USER_CODE;
                            pDataParametersB[2].Value = pMenuRegisterEntity.MENU_NO;
                            pDataParametersB[3].Value = dt.Rows[a]["DSP_SORT"].ToString();
                            pDataParametersB[4].Value = dt.Rows[a]["TEMPLETE_NAME"].ToString();
                            pDataParametersB[5].Value = null;
                            pDataParametersB[6].Value = dt.Rows[a]["XML_FILE_NAME"].ToString();
                            pDataParametersB[7].Value = dt.Rows[a]["REMARK"].ToString();
                            //if (dt.Rows[a]["CRUD"].ToString().ToUpper().Equals("D"))
                            //{
                            //    pDataParametersB[8].Value = "N";
                            //}
                            //else
                            //{
                                pDataParametersB[8].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();
                            pDataParametersB[9].Value = pMenuRegisterEntity.LANGUAGE_TYPE;
                            //}
                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuRegister_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pMenuRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pMenuRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pMenuRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pMenuRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pMenuRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "MenuRegister_Info_Save(MenuRegisterEntity pMenuRegisterEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion







        #region OPENBUTTON으로 XML파일 다운로드 - MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)
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
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pMenuRegisterEntity.MENU_NO;
                pDataParameters[1].Value = pMenuRegisterEntity.DSP_SORT;
                pDataParameters[2].Value = pMenuRegisterEntity.USE_YN;
                pDataParameters[3].Value = pMenuRegisterEntity.LANGUAGE_TYPE;


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
                    "MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)",
                    pException
                );
            }
        }

        #endregion


        #region OPENBUTTON으로 XML파일,파일명 삭제 - MenuRegister_Templete_Delete(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MenuRegister_Templete_Delete(MenuRegisterEntity pMenuRegisterEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

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

                        pDataParameters[0].Value = pMenuRegisterEntity.MENU_NO;
                        pDataParameters[1].Value = pMenuRegisterEntity.DSP_SORT;
                        pDataParameters[2].Value = pMenuRegisterEntity.USE_YN;

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuRegister_I30", pDataParameters);

                        pMenuRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                        pMenuRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                        pMenuRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                        pMenuRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                        pMenuRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
                    "MenuRegister_Templete_Delete(MenuRegisterEntity pMenuRegisterEntity, DataTable dt)",
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
        public override MenuRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MenuRegisterEntity pMenuRegisterEntity = new MenuRegisterEntity();

                //pMenuRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pMenuRegisterEntity;
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

    public class MenuInfoRegisterProvider : EntityManager<MenuInfoRegisterEntity>
    {
        #region 생성자 - MenuInfoRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MenuInfoRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - MenuInfoRegister_Info_left(MenuInfoRegisterEntity pMenuInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MenuInfoRegister_Info_left(MenuInfoRegisterEntity pMenuInfoRegisterEntity)
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
                            new MySqlParameter("@v_module", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud",             SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_module",           SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn",           SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pMenuInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pMenuInfoRegisterEntity.MODULE;
                pDataParameters[2].Value = pMenuInfoRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pMenuInfoRegisterEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuInfoRegister_R10", pDataParameters);

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
                    "MenuInfoRegister_Info_Mst(MenuInfoRegisterEntity pMenuInfoRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 상세 조회하기 - MenuInfoRegister_Info_Mst(MenuInfoRegisterEntity pMenuInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MenuInfoRegister_Info_Mst(MenuInfoRegisterEntity pMenuInfoRegisterEntity)
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
                            new MySqlParameter("@v_menu_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_module", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_menu_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_module",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pMenuInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pMenuInfoRegisterEntity.MENU_CODE;
                pDataParameters[2].Value = pMenuInfoRegisterEntity.MODULE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuInfoRegister_R20", pDataParameters);

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
                    "MenuInfoRegister_Info_Mst(MenuInfoRegisterEntity pMenuInfoRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 템플렛 조회하기 - MenuInfoRegister_Info_Sub(MenuInfoRegisterEntity pMenuInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MenuInfoRegister_Info_Sub(MenuInfoRegisterEntity pMenuInfoRegisterEntity)
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
                            new MySqlParameter("@v_menu_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_Language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_menu_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_Language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pMenuInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pMenuInfoRegisterEntity.MENU_CODE;
                pDataParameters[2].Value = pMenuInfoRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuInfoRegister_R21", pDataParameters);

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
                    "MenuInfoRegister_Info_Sub(MenuInfoRegisterEntity pMenuInfoRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - MenuInfoRegister_Info_Save(MenuInfoRegisterEntity pMenuInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pMenuInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MenuInfoRegister_Info_Save(MenuInfoRegisterEntity pMenuInfoRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {
                //마스터 저장
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                                new MySqlParameter("@v_crud"            , MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code"       , MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_menu_code"       , MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_menu_name"       , MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_p_menu_code"       , MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_window_name"     , MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_module"          , MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_iconcss"         , MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_dsp_sort"        , MySqlDbType.Int32),
                                new MySqlParameter("@v_remark"          , MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn"          , MySqlDbType.VarChar, 1)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud"              , SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code"         , SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_menu_code"           , SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_menu_name"         , SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_p_menu_code"         , SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_window_name"       , SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_module"            , SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_iconcss"           , SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_dsp_sort"          , SqlDbType.Int),
                                new SqlParameter("@v_remark"            , SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_use_yn"            , SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pMenuInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pMenuInfoRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pMenuInfoRegisterEntity.MENU_CODE;
                pDataParameters[3].Value = pMenuInfoRegisterEntity.MENU_NAME;
                pDataParameters[4].Value = pMenuInfoRegisterEntity.P_MENU_CODE;
                pDataParameters[5].Value = pMenuInfoRegisterEntity.WINDOW_NAME;
                pDataParameters[6].Value = pMenuInfoRegisterEntity.MODULE;
                pDataParameters[7].Value = pMenuInfoRegisterEntity.ICONCSS;
                pDataParameters[8].Value = pMenuInfoRegisterEntity.DSP_SORT;
                pDataParameters[9].Value = pMenuInfoRegisterEntity.REMARK;
                pDataParameters[10].Value = pMenuInfoRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuInfoRegister_I10", pDataParameters);

                pMenuInfoRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pMenuInfoRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pMenuInfoRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pMenuInfoRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pMenuInfoRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pMenuInfoRegisterEntity.MENU_CODE = pMenuInfoRegisterEntity.RTN_KEY;


                    if (dt != null)
                    {
                        pCount = dt.Rows.Count;

                        for (int a = 0; a < pCount; a++)
                        {
                            IDataParameter[] pDataParametersA = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersA = new IDataParameter[]
                                    {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                        new MySqlParameter("@v_menu_code"         , MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_templete_seq"         , MySqlDbType.VarChar, 6),
                                        new MySqlParameter("@v_templete_name"         , MySqlDbType.VarChar, 100),
                                        new MySqlParameter("@v_templete_file_name"       , MySqlDbType.VarChar, 100),
                                        new MySqlParameter("@v_remark"          , MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_use_yn"          , MySqlDbType.VarChar, 1)

                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                        new SqlParameter("@v_menu_code"         , SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_templete_seq"         , SqlDbType.NVarChar, 6),
                                        new SqlParameter("@v_templete_name"         , SqlDbType.NVarChar, 100),
                                        new SqlParameter("@v_templete_file_name"       , SqlDbType.NVarChar, 100),
                                        new SqlParameter("@v_remark"          , SqlDbType.NVarChar, 1000),
                                        new SqlParameter("@v_use_yn"          , SqlDbType.NVarChar, 1)
                                        
                                    };
                                    break;
                            }

                            pDataParametersA[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersA[1].Value = pMenuInfoRegisterEntity.USER_CODE;
                            pDataParametersA[2].Value = pMenuInfoRegisterEntity.MENU_CODE;
                            pDataParametersA[3].Value = "";
                            pDataParametersA[4].Value = dt.Rows[a]["TEMPLETE_NAME"].ToString();
                            pDataParametersA[5].Value = dt.Rows[a]["TEMPLETE_FILE_NAME"].ToString();
                            pDataParametersA[6].Value = dt.Rows[a]["REMARK"].ToString();
                         
                            pDataParametersA[7].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();

                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuInfoRegister_I20", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            else
                            {
                                pMenuInfoRegisterEntity.CRUD = dt.Rows[a]["CRUD"].ToString().ToUpper();

                                pMenuInfoRegisterEntity.TEMPLETE_BEFROE_FILE_NAME = dt.Rows[a]["TEMPLETE_BEFROE_FILE_NAME"].ToString();
                                pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME = dt.Rows[a]["TEMPLETE_FILE_NAME"].ToString();
                                pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME_FULL = dt.Rows[a]["TEMPLETE_FILE_NAME_FULL"].ToString();

                                pErrorYN = File_Save(pMenuInfoRegisterEntity) == 0 ? false : true;
                            }

                            pMenuInfoRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                            pMenuInfoRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                            pMenuInfoRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                            pMenuInfoRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                            pMenuInfoRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();
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
                    "MenuInfoRegister_Info_Save(MenuInfoRegisterEntity pMenuInfoRegisterEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region ○ 파일 저장 - File_Save(MenuInfoRegisterEntity pMenuInfoRegisterEntity)
        private int File_Save(MenuInfoRegisterEntity pMenuInfoRegisterEntity)
        {
            try
            {
                // return 값
                // 1 : FileName == ""
                // 2 : FTP 연결 확인
                // 0 : 정상

                string strFTP_PATH = "";

                if (pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME_FULL == "") return 1;

                byte[] data = CoFAS_ConvertManager.GetFileData(pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME_FULL);

                strFTP_PATH = string.Format(@"{0}{1}/", pMenuInfoRegisterEntity.FTP_IP_PORT, "PROGRAM_VIEW");

                if (pMenuInfoRegisterEntity.CRUD == "C" && pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME_FULL != null) // 저장, 추가 생성
                {
                    if (CoFAS_FTPManager.FTPUpload_DataofStream_CheckDirectory(pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME, pMenuInfoRegisterEntity.FTP_ID, pMenuInfoRegisterEntity.FTP_PW, strFTP_PATH, pMenuInfoRegisterEntity.WINDOW_NAME, data, pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME_FULL)) 
                    {
                    }
                    else
                    {
                        return 2;
                    }
                }
                else if (pMenuInfoRegisterEntity.CRUD == "U" || pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME_FULL == null) // 업데이트
                {
                    CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(strFTP_PATH + pMenuInfoRegisterEntity.WINDOW_NAME + "/", pMenuInfoRegisterEntity.FTP_ID, pMenuInfoRegisterEntity.FTP_PW);

                    if (CoFAS_FTPManager.FTPDelete(pMenuInfoRegisterEntity.TEMPLETE_BEFROE_FILE_NAME, strFTP_PATH + pMenuInfoRegisterEntity.WINDOW_NAME + "/", pMenuInfoRegisterEntity.FTP_ID, pMenuInfoRegisterEntity.FTP_PW))
                    {
                        if (CoFAS_FTPManager.FTPUpload_DataofStream_CheckDirectory_Encoding(pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME, pMenuInfoRegisterEntity.FTP_ID, pMenuInfoRegisterEntity.FTP_PW, strFTP_PATH, pMenuInfoRegisterEntity.WINDOW_NAME, data, pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME_FULL))
                        {
                        }
                        else
                        {
                            return 2;
                        }
                    }
                    //파일이 없는지 체크
                    else if (!qFTPUtil.IsFTPFileExsit(strFTP_PATH + pMenuInfoRegisterEntity.WINDOW_NAME + "/" + pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME))
                    {
                        //정상 처리
                        if (CoFAS_FTPManager.FTPUpload_DataofStream_CheckDirectory_Encoding(pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME, pMenuInfoRegisterEntity.FTP_ID, pMenuInfoRegisterEntity.FTP_PW, strFTP_PATH, pMenuInfoRegisterEntity.WINDOW_NAME, data, pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME_FULL))
                        {
                        }
                        else
                        {
                            return 2;
                        }
                    }
                    else
                    {
                        return 2;
                    }

                }

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
                    "File_Save(MenuInfoRegisterEntity pMenuInfoRegisterEntity)",
                    pException
                );
            }
            finally
            {
            }

            return 0;
        }
        #endregion

        #region 파일 삭제 - File_Delete(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool File_Delete(MenuInfoRegisterEntity pMenuInfoRegisterEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_menu_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_templete_seq", MySqlDbType.VarChar, 6),
                                new MySqlParameter("@v_templete_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_templete_file_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {

                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_menu_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_templete_seq", SqlDbType.NVarChar, 6),
                                new SqlParameter("@v_templete_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_templete_file_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pMenuInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pMenuInfoRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pMenuInfoRegisterEntity.MENU_CODE;
                pDataParameters[3].Value = pMenuInfoRegisterEntity.TEMPLETE_SEQ;
                pDataParameters[4].Value = pMenuInfoRegisterEntity.TEMPLETE_NAME;
                pDataParameters[5].Value = pMenuInfoRegisterEntity.TEMPLETE_FILE_NAME;
                pDataParameters[6].Value = pMenuInfoRegisterEntity.REMARK;
                pDataParameters[7].Value = pMenuInfoRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuInfoRegister_I20", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pMenuInfoRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pMenuInfoRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pMenuInfoRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pMenuInfoRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pMenuInfoRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "File_Delete(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)",
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
        public override MenuInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MenuInfoRegisterEntity pMenuInfoRegisterEntity = new MenuInfoRegisterEntity();

                //pMenuRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pMenuInfoRegisterEntity;
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

    public class MonitoringDesignerProvider : EntityManager<MonitoringDesignerEntity>
    {
        #region 생성자 - MonitoringDesignerProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MonitoringDesignerProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - MonitoringDesigner_Info_Mst(MonitoringDesignerEntity pMonitoringDesignerEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMonitoringDesignerEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MonitoringDesigner_Info_Mst(MonitoringDesignerEntity pMonitoringDesignerEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pMonitoringDesignerEntity.CRUD;
                pDataParameters[1].Value = pMonitoringDesignerEntity.LANGUAGE_TYPE;



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
                    "MonitoringDesigner_Info_Mst(MonitoringDesignerEntity pMonitoringDesignerEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - MonitoringDesigner_Info_Save(MonitoringDesignerEntity pMonitoringDesignerEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pMonitoringDesignerEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MonitoringDesigner_Info_Save(MonitoringDesignerEntity pMonitoringDesignerEntity, DataTable dt)
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

                pDataParametersA[0].Value = pMonitoringDesignerEntity.CORP_CODE;
                pDataParametersA[1].Value = pMonitoringDesignerEntity.CRUD;
                pDataParametersA[2].Value = pMonitoringDesignerEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SampleRegister_I10", pDataParametersA);

                pMonitoringDesignerEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pMonitoringDesignerEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pMonitoringDesignerEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pMonitoringDesignerEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pMonitoringDesignerEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                            pDataParametersB[0].Value = pMonitoringDesignerEntity.CORP_CODE;
                            pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[2].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pMonitoringDesignerEntity.USER_CODE);

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pMonitoringDesignerEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pMonitoringDesignerEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pMonitoringDesignerEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pMonitoringDesignerEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pMonitoringDesignerEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "MonitoringDesigner_Info_Save(MonitoringDesignerEntity pMonitoringDesignerEntity, DataTable dt)",
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
        public override MonitoringDesignerEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MonitoringDesignerEntity pMonitoringDesignerEntity = new MonitoringDesignerEntity();

                pMonitoringDesignerEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pMonitoringDesignerEntity;
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

        #region 파일명 조회하기 - MonitoringDesigner_Info_Filename(MonitoringDesignerEntity pMonitoringDesignerEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMonitoringDesignerEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MonitoringDesigner_Info_Filename(MonitoringDesignerEntity pMonitoringDesignerEntity)
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

                pDataParameters[0].Value = pMonitoringDesignerEntity.WINDOW_NAME;

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
                    "MonitoringDesignerEntity_Info_Filename(MonitoringDesignerEntity pMonitoringDesignerEntity)",
                    pException
                );
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MonitoringDesignerEntity pMonitoringDesignerEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMonitoringDesignerEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object Templete_Download(MonitoringDesignerEntity pMonitoringDesignerEntity, string pMENU_NO, string pDSP_SORT)
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
                    "Templete_Download(MonitoringDesignerEntity pMonitoringDesignerEntity, string pMENU_NO, string pDSP_SORT)",
                    pException
                );
            }
        }

        #endregion
    }

    public class SystemCodeRegisterProvider : EntityManager<SystemCodeRegisterEntity>
    {
        #region 생성자 - CommonCodeRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SystemCodeRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 대분류 조회하기 - SystemCode_Info_First(SystemCodeRegisterEntity pSystemCodeRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="SystemCodeRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable SystemCode_Info_First(SystemCodeRegisterEntity pSystemCodeRegisterEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParameters[0].Value = pSystemCodeRegisterEntity.CRUD;
                pDataParameters[1].Value = pSystemCodeRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pSystemCodeRegisterEntity.CODE;
                pDataParameters[3].Value = pSystemCodeRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SystemCodeRegister_R10", pDataParameters);

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
                    "SystemCode_Info_First(SystemCodeRegisterEntity pSystemCodeRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 중분류 조회하기 - SystemCode_Info_Second(SystemCodeRegisterEntity pSystemCodeRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="SystemCodeRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable SystemCode_Info_Second(SystemCodeRegisterEntity pSystemCodeRegisterEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_code_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                           // ,.CODE_M
                           //  .USE_YN
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_code_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParameters[0].Value = pSystemCodeRegisterEntity.CRUD;
                pDataParameters[1].Value = pSystemCodeRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pSystemCodeRegisterEntity.CODE_TYPE;
                pDataParameters[3].Value = pSystemCodeRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SystemCodeRegister_R20", pDataParameters);

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
                    "SystemCode_Info_Second(SystemCodeRegisterEntity pSystemCodeRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 소분류 조회하기 - SystemCode_Info_Third(SystemCodeRegisterEntity pSystemCodeRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="SystemCodeRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable SystemCode_Info_Third(SystemCodeRegisterEntity pSystemCodeRegisterEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_code_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_code_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParameters[0].Value = pSystemCodeRegisterEntity.CRUD;
                pDataParameters[1].Value = pSystemCodeRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pSystemCodeRegisterEntity.CODE_TYPE;
                pDataParameters[3].Value = pSystemCodeRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SystemCodeRegister_R30", pDataParameters);

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
                    "SystemCode_Info_Third(SystemCodeRegisterEntity pSystemCodeRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - SystemCode_Info_Save(SystemCodeRegisterEntity pSystemCodeRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSystemCodeRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool SystemCode_Info_Save(SystemCodeRegisterEntity pSystemCodeRegisterEntity, DataTable dt, string code)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            _pDBManager.BeginTransaction();

            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    for (int a = 0; a < pCount; a++)
                    {
                        IDataParameter[] pDataParameters = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters = new IDataParameter[]
                                {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_code_type", MySqlDbType.VarChar,20),
                                new MySqlParameter("@v_system_code", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_code_name", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_code_desc", MySqlDbType.VarChar,500),
                                new MySqlParameter("@v_code_val1", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_code_val2", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_code_val3", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_dsp_seq", MySqlDbType.Int32),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar,100)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_code_type", SqlDbType.NVarChar,20),
                                new SqlParameter("@v_system_code", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_code_name", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_code_desc", SqlDbType.NVarChar,500),
                                new SqlParameter("@v_code_val1", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_code_val2", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_code_val3", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_dsp_seq", SqlDbType.Int),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar,100)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pSystemCodeRegisterEntity.USER_CODE;
                        pDataParameters[2].Value = pSystemCodeRegisterEntity.LANGUAGE_TYPE;
                        //pDataParameters[2].Value = pCommonCodeRegisterEntity.CODE_TYPE;
                        pDataParameters[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["CODE_TYPE"].ToString().ToUpper()); //code;
                        pDataParameters[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["CODE"].ToString().ToUpper());
                        pDataParameters[5].Value = dt.Rows[a]["CODE_NAME"].ToString();
                        pDataParameters[6].Value = dt.Rows[a]["CODE_DESCRIPTION"].ToString();
                        pDataParameters[7].Value = dt.Rows[a]["CODE_VALUE1"].ToString();
                        pDataParameters[8].Value = dt.Rows[a]["CODE_VALUE2"].ToString();
                        pDataParameters[9].Value = dt.Rows[a]["CODE_VALUE3"].ToString();
                        pDataParameters[10].Value = dt.Rows[a]["DSP_SEQ"].ToString() == "" ? 0 : Convert.ToInt32(dt.Rows[a]["DSP_SEQ"].ToString());
                        pDataParameters[11].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();
                        pDataParameters[12].Value = dt.Rows[a]["REMARK"].ToString();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SystemCodeRegister_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pSystemCodeRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pSystemCodeRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pSystemCodeRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pSystemCodeRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pSystemCodeRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "CommonCode_Info_Save(CommonCodeRegisterEntity pCommonCodeRegisterEntity, DataTable dt)",
                    pException
                );
            }
            finally
            {
                if (pErrorYN)
                    _pDBManager.RollbackTransaction();
                else
                    _pDBManager.CommitTransaction();
            }

            return pErrorYN;
        }

        public bool SystemCode_Info_Save(SystemCodeRegisterEntity pSystemCodeRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            _pDBManager.BeginTransaction();

            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    for (int a = 0; a < pCount; a++)
                    {
                        IDataParameter[] pDataParameters = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters = new IDataParameter[]
                                {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_code_type", MySqlDbType.VarChar,20),
                                new MySqlParameter("@v_system_code", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_code_name", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_code_desc", MySqlDbType.VarChar,500),
                                new MySqlParameter("@v_code_val1", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_code_val2", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_code_val3", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_dsp_seq", MySqlDbType.Int32),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar,100)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_code_type", SqlDbType.NVarChar,20),
                                new SqlParameter("@v_system_code", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_code_name", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_code_desc", SqlDbType.NVarChar,500),
                                new SqlParameter("@v_code_val1", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_code_val2", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_code_val3", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_dsp_seq", SqlDbType.Int),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar,100)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pSystemCodeRegisterEntity.USER_CODE;
                        pDataParameters[2].Value = pSystemCodeRegisterEntity.LANGUAGE_TYPE;
                        pDataParameters[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["CODE_TYPE"].ToString().ToUpper());
                        pDataParameters[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["CODE"].ToString().ToUpper());
                        pDataParameters[5].Value = dt.Rows[a]["CODE_NAME"].ToString();
                        pDataParameters[6].Value = dt.Rows[a]["CODE_DESCRIPTION"].ToString();
                        pDataParameters[7].Value = dt.Rows[a]["CODE_VALUE1"].ToString();
                        pDataParameters[8].Value = dt.Rows[a]["CODE_VALUE2"].ToString();
                        pDataParameters[9].Value = dt.Rows[a]["CODE_VALUE3"].ToString();
                        pDataParameters[10].Value = dt.Rows[a]["DSP_SEQ"].ToString() == "" ? 0 : Convert.ToInt32(dt.Rows[a]["DSP_SEQ"].ToString());
                        pDataParameters[11].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();
                        pDataParameters[12].Value = dt.Rows[a]["REMARK"].ToString();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SystemCodeRegister_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pSystemCodeRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pSystemCodeRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pSystemCodeRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pSystemCodeRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pSystemCodeRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "SystemCode_Info_Save(SystemCodeRegisterEntity pSystemCodeRegisterEntity, DataTable dt)",
                    pException
                );
            }
            finally
            {
                if (pErrorYN)
                    _pDBManager.RollbackTransaction();
                else
                    _pDBManager.CommitTransaction();
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
        public override SystemCodeRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SystemCodeRegisterEntity pSystemCodeRegisterEntity = new SystemCodeRegisterEntity();

                //pCommonCodeRegisterEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pSystemCodeRegisterEntity;
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

    public class SystemLogInfoStatusProvider : EntityManager<SystemLogInfoStatusEntity>
    {
        #region 생성자 - SystemLogInfoStatusProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SystemLogInfoStatusProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 정보 조회하기 - SystemLogInfoStatus_R10(SystemLogInfoStatusEntity pSystemLogInfoStatusEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSystemLogInfoStatusEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable SystemLogInfoStatus_R10(SystemLogInfoStatusEntity pSystemLogInfoStatusEntity)
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_name", MySqlDbType.VarChar, 100)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_name", SqlDbType.NVarChar, 100)

                };
                        break;
                }

                pDataParameters[0].Value = pSystemLogInfoStatusEntity.CRUD;
                pDataParameters[1].Value = pSystemLogInfoStatusEntity.USER_CODE;
                pDataParameters[2].Value = pSystemLogInfoStatusEntity.USER_ACCOUNT;
                pDataParameters[3].Value = pSystemLogInfoStatusEntity.USER_NAME;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SystemLogInfoStatus_R10", pDataParameters);

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
                    "SystemLogInfoStatus_R10(SystemLogInfoStatusEntity pSystemLogInfoStatusEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 조회하기 - SystemLoginfoStatus_R20(SystemLogInfoStatusEntity pSystemLogInfoStatusEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSystemLogInfoStatusEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable SystemLoginfoStatus_R20(SystemLogInfoStatusEntity pSystemLogInfoStatusEntity)
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
                            new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_logdate_from", MySqlDbType.VarChar, 18),
                            new MySqlParameter("@v_logdate_to", MySqlDbType.VarChar, 18),
                            new MySqlParameter("@v_log_mst", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_logdate_from", SqlDbType.NVarChar, 18),
                            new SqlParameter("@v_logdate_to", SqlDbType.NVarChar, 18),
                            new SqlParameter("@v_log_mst", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pSystemLogInfoStatusEntity.CRUD;
                pDataParameters[1].Value = pSystemLogInfoStatusEntity.USER_ACCOUNT;
                pDataParameters[2].Value = pSystemLogInfoStatusEntity.LOGDATE_FROM;
                pDataParameters[3].Value = pSystemLogInfoStatusEntity.LOGDATE_TO;
                pDataParameters[4].Value = pSystemLogInfoStatusEntity.LOG_MST;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SystemLoginfoStatus_R20", pDataParameters);

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
                    "SystemLoginfoStatus_R20(SystemLogInfoStatusEntity pSystemLogInfoStatusEntity)",
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
        public override SystemLogInfoStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SystemLogInfoStatusEntity pSystemLogInfoStatusEntity = new SystemLogInfoStatusEntity();

                //pMenuAuthorityEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pSystemLogInfoStatusEntity;
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
