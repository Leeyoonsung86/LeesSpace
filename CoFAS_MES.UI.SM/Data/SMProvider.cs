using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

using CoFAS_MES.UI.SM.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;

namespace CoFAS_MES.UI.SM.Data
{
    public class CommonCodeRegisterProvider : EntityManager<CommonCodeRegisterEntity>
    {
        #region 생성자 - CommonCodeRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public CommonCodeRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 대분류 조회하기 - CommonCode_Info_First(CommonCodeRegisterEntity pCommonCodeRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="CommonCodeRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable CommonCode_Info_First(CommonCodeRegisterEntity pCommonCodeRegisterEntity)
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

                pDataParameters[0].Value = pCommonCodeRegisterEntity.CRUD;
                pDataParameters[1].Value = pCommonCodeRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pCommonCodeRegisterEntity.CODE;
                pDataParameters[3].Value = pCommonCodeRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CommonCodeRegister_R10", pDataParameters);

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
                    "CommonCode_Info_First(CommonCodeRegisterEntity pCommonCodeRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 중분류 조회하기 - CommonCode_Info_Second(CommonCodeRegisterEntity pCommonCodeRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="CommonCodeRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable CommonCode_Info_Second(CommonCodeRegisterEntity pCommonCodeRegisterEntity)
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

                pDataParameters[0].Value = pCommonCodeRegisterEntity.CRUD;
                pDataParameters[1].Value = pCommonCodeRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pCommonCodeRegisterEntity.CODE_TYPE;
                pDataParameters[3].Value = pCommonCodeRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CommonCodeRegister_R20", pDataParameters);

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
                    "CommonCode_Info_Second(CommonCodeRegisterEntity pCommonCodeRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 소분류 조회하기 - CommonCode_Info_Third(CommonCodeRegisterEntity pCommonCodeRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="CommonCodeRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable CommonCode_Info_Third(CommonCodeRegisterEntity pCommonCodeRegisterEntity)
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

                pDataParameters[0].Value = pCommonCodeRegisterEntity.CRUD;
                pDataParameters[1].Value = pCommonCodeRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pCommonCodeRegisterEntity.CODE_TYPE;
                pDataParameters[3].Value = pCommonCodeRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CommonCodeRegister_R30", pDataParameters);

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
                    "CommonCode_Info_Third(CommonCodeRegisterEntity pCommonCodeRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - CommonCode_Info_Save(CommonCodeRegisterEntity pCommonCodeRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pLanguageInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool CommonCode_Info_Save(CommonCodeRegisterEntity pCommonCodeRegisterEntity, DataTable dt,string code)
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
                                new MySqlParameter("@v_comm_code", MySqlDbType.VarChar,50),
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
                                new SqlParameter("@v_comm_code", SqlDbType.NVarChar,50),
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
                        pDataParameters[1].Value = pCommonCodeRegisterEntity.USER_CODE;
                        pDataParameters[2].Value = pCommonCodeRegisterEntity.LANGUAGE_TYPE;
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

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CommonCodeRegister_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pCommonCodeRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pCommonCodeRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pCommonCodeRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pCommonCodeRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pCommonCodeRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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

        public bool CommonCode_Info_Save(CommonCodeRegisterEntity pCommonCodeRegisterEntity, DataTable dt)
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
                                new MySqlParameter("@v_comm_code", MySqlDbType.VarChar,50),
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
                                new SqlParameter("@v_comm_code", SqlDbType.NVarChar,50),
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
                        pDataParameters[1].Value = pCommonCodeRegisterEntity.USER_CODE;
                        pDataParameters[2].Value = pCommonCodeRegisterEntity.LANGUAGE_TYPE;
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

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CommonCodeRegister_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pCommonCodeRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pCommonCodeRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pCommonCodeRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pCommonCodeRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pCommonCodeRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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


        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override CommonCodeRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                CommonCodeRegisterEntity pCommonCodeRegisterEntity = new CommonCodeRegisterEntity();

                //pCommonCodeRegisterEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pCommonCodeRegisterEntity;
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

    public class CorporationInformationProvider : EntityManager<CorporationInformationEntity>
    {
        #region 생성자 - CorporationInformationProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public CorporationInformationProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Corporation_Info(CorporationInformationEntity pCorporationInformationEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCorporationInformationEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Corporation_Info(CorporationInformationEntity pCorporationInformationEntity)
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
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pCorporationInformationEntity.CRUD;
                pDataParameters[1].Value = pCorporationInformationEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CorporationInformation_R10", pDataParameters);

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
                    "Corporation_Info(CorporationInformationEntity pCorporationInformationEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 정보 저장하기 - Corporation_Info_Save(CorporationInformationEntity pCorporationInformationEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <returns></returns>
        public bool Corporation_Info_Save(CorporationInformationEntity pCorporationInformationEntity)
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
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_corp_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_corp_eng_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_corp_ein", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_corp_ssn", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_corp_ceo_name", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_corp_business_opendate", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_corp_tel", MySqlDbType.VarChar, 14),
                                new MySqlParameter("@v_corp_fax", MySqlDbType.VarChar, 14),
                                new MySqlParameter("@v_corp_mail", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_corp_address_1", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_corp_address_2", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_corp_business", MySqlDbType.VarChar, 500),
                                new MySqlParameter("@v_corp_business_type", MySqlDbType.VarChar, 500),
                                new MySqlParameter("@v_corp_server_id", MySqlDbType.VarChar, 25),

                                new MySqlParameter("@v_mail_server_ip", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_mail_server_port", MySqlDbType.Int32),
                                new MySqlParameter("@v_mail_server_id", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_mail_server_password", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_mail_server_ssl", MySqlDbType.VarChar, 1),


                                new MySqlParameter("@v_logo_first", MySqlDbType.LongBlob),
                                new MySqlParameter("@v_logo_first_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_logo_second", MySqlDbType.LongBlob),
                                new MySqlParameter("@v_logo_second_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_corp_registration", MySqlDbType.LongBlob),
                                new MySqlParameter("@v_corp_registration_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_corp_eng_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_corp_ein", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_corp_ssn", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_corp_ceo_name", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_corp_business_opendate", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_corp_tel", SqlDbType.NVarChar, 14),
                                new SqlParameter("@v_corp_fax", SqlDbType.NVarChar, 14),
                                new SqlParameter("@v_corp_mail", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_corp_address_1", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_corp_address_2", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_corp_business", SqlDbType.NVarChar, 500),
                                new SqlParameter("@v_corp_business_type", SqlDbType.NVarChar, 500),
                                new SqlParameter("@v_corp_server_id", SqlDbType.NVarChar, 25),

                                new SqlParameter("@v_mail_server_ip", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_mail_server_port", SqlDbType.Int),
                                new SqlParameter("@v_mail_server_id", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_mail_server_password", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_mail_server_ssl", SqlDbType.NVarChar, 1),

                                new SqlParameter("@v_logo_first", SqlDbType.Image),
                                new SqlParameter("@v_logo_first_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_logo_second", SqlDbType.Image),
                                new SqlParameter("@v_logo_second_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_corp_registration", SqlDbType.Image),
                                new SqlParameter("@v_corp_registration_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pCorporationInformationEntity.CRUD;
                pDataParameters[1].Value = pCorporationInformationEntity.USER_CODE;
                pDataParameters[2].Value = pCorporationInformationEntity.CORP_NAME;
                pDataParameters[3].Value = pCorporationInformationEntity.CORP_ENG_NAME;
                pDataParameters[4].Value = pCorporationInformationEntity.CORP_EIN;
                pDataParameters[5].Value = pCorporationInformationEntity.CORP_SSN;
                pDataParameters[6].Value = pCorporationInformationEntity.CORP_CEO_NAME;
                pDataParameters[7].Value = pCorporationInformationEntity.CORP_BUSINESS_OPENDATE;
                pDataParameters[8].Value = pCorporationInformationEntity.CORP_TEL;
                pDataParameters[9].Value =  pCorporationInformationEntity.CORP_FAX;
                pDataParameters[10].Value = pCorporationInformationEntity.CORP_MAIL;
                pDataParameters[11].Value = pCorporationInformationEntity.CORP_ADDRESS_1;
                pDataParameters[12].Value = pCorporationInformationEntity.CORP_ADDRESS_2;
                pDataParameters[13].Value = pCorporationInformationEntity.CORP_BUSINESS;
                pDataParameters[14].Value = pCorporationInformationEntity.CORP_BUSINESS_TYPE;
                pDataParameters[15].Value = pCorporationInformationEntity.CORP_SERVER_ID;

                pDataParameters[16].Value = pCorporationInformationEntity.MAIL_SERVER_IP;
                pDataParameters[17].Value = pCorporationInformationEntity.MAIL_SERVER_PORT;
                pDataParameters[18].Value = pCorporationInformationEntity.MAIL_SERVER_ID;
                pDataParameters[19].Value = pCorporationInformationEntity.MAIL_SERVER_PASSWORD;
                pDataParameters[20].Value = pCorporationInformationEntity.MAIL_SERVER_SSL;



                pDataParameters[21].Value = pCorporationInformationEntity.LOGO_FIRST;
                pDataParameters[22].Value = pCorporationInformationEntity.LOGO_FIRST_NAME;
                pDataParameters[23].Value = pCorporationInformationEntity.LOGO_SECOND;
                pDataParameters[24].Value = pCorporationInformationEntity.LOGO_SECOND_NAME;
                pDataParameters[25].Value = pCorporationInformationEntity.CORP_REGISTRATION;
                pDataParameters[26].Value = pCorporationInformationEntity.CORP_REGISTRATION_NAME;
                pDataParameters[27].Value = pCorporationInformationEntity.REMARK;
                pDataParameters[28].Value = pCorporationInformationEntity.USE_YN;


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CorporationInformation_I10", pDataParameters);

                pCorporationInformationEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pCorporationInformationEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pCorporationInformationEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pCorporationInformationEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pCorporationInformationEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Corporation_Info_Save(CorporationInformationEntity pCorporationInformationEntity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 로고 삭제하기 - Corporation_Logo_Delete(CorporationInformationEntity pCorporationInformationEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <returns></returns>
        public bool Corporation_Logo_Delete(CorporationInformationEntity pCorporationInformationEntity)
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
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_image_choice", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_image", MySqlDbType.LongBlob),
                                new MySqlParameter("@v_image_name", MySqlDbType.VarChar, 100),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_image_choice", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_image", SqlDbType.Image),
                                new SqlParameter("@v_image_name", SqlDbType.NVarChar, 100),
                        };
                        break;
                }

                pDataParameters[0].Value = pCorporationInformationEntity.CRUD;
                pDataParameters[1].Value = pCorporationInformationEntity.USER_CODE;
                pDataParameters[2].Value = pCorporationInformationEntity.IMAGE_CHOICE;
                if (pCorporationInformationEntity.IMAGE_CHOICE.ToString() == "1")
                {
                    pDataParameters[3].Value = pCorporationInformationEntity.LOGO_FIRST;
                    pDataParameters[4].Value = pCorporationInformationEntity.LOGO_FIRST_NAME;
                }
                else if (pCorporationInformationEntity.IMAGE_CHOICE.ToString() == "2")
                {
                    pDataParameters[3].Value = pCorporationInformationEntity.LOGO_SECOND;
                    pDataParameters[4].Value = pCorporationInformationEntity.LOGO_SECOND_NAME;
                }else
                {
                    pDataParameters[3].Value = pCorporationInformationEntity.CORP_REGISTRATION;
                    pDataParameters[4].Value = pCorporationInformationEntity.CORP_REGISTRATION_NAME;
                }


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CorporationInformation_I11", pDataParameters);

                pCorporationInformationEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pCorporationInformationEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pCorporationInformationEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pCorporationInformationEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pCorporationInformationEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
                    "Corporation_Logo_Delete(CorporationInformationEntity pCorporationInformationEntity)",
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
        public override CorporationInformationEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                CorporationInformationEntity pCorporationInformationEntity = new CorporationInformationEntity();

                //pCorporationInformationEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pCorporationInformationEntity;
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

    public class UserInformationProvider : EntityManager<UserInformationEntity>
    {
        #region 생성자 - UserInformationProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public UserInformationProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 정보 조회하기 - User_Info(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pUserInformationEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable User_Info(UserInformationEntity pUserInformationEntity)
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
                            new MySqlParameter("@v_user_account", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_user_name", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_user_name", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)



                };
                        break;
                }

                pDataParameters[0].Value = pUserInformationEntity.CRUD;
                pDataParameters[1].Value = pUserInformationEntity.USER_ACCOUNT;
                pDataParameters[2].Value = pUserInformationEntity.USER_NAME;
                pDataParameters[3].Value = pUserInformationEntity.USE_YN;
                pDataParameters[4].Value = pUserInformationEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_UserInformation_R10", pDataParameters);

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
                    "User_Info(UserInformationEntity pUserInformationEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 상세 조회하기 - User_Info_Sub(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable User_Info_Sub(UserInformationEntity pUserInformationEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_id", MySqlDbType.VarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        

                };
                        break;
                }

                pDataParameters[0].Value = pUserInformationEntity.CRUD;
                pDataParameters[1].Value = pUserInformationEntity.USER_ACCOUNT;
                pDataParameters[2].Value = pUserInformationEntity.USER_ID;
                pDataParameters[3].Value = pUserInformationEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_UserInformation_R11", pDataParameters);

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
                    "User_Info_Sub(UserInformationEntity pUserInformationEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - User_Info_Save(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pUserInformationEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool User_Info_Save(UserInformationEntity pUserInformationEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            //int pCount = 0;

            try
            {

                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_code_user", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_user_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_password", MySqlDbType.VarChar, 1000),
                            new MySqlParameter("@v_user_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_mail", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_mail_receive_check", MySqlDbType.VarChar,1),
                            new MySqlParameter("@v_user_grant", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_image_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_user_image", MySqlDbType.MediumBlob),
                            new MySqlParameter("@v_user_emp_number", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_user_department", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_job_title", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_tel", MySqlDbType.VarChar, 14),
                            new MySqlParameter("@v_user_tel_number", MySqlDbType.VarChar, 14),
                            new MySqlParameter("@v_user_fax", MySqlDbType.VarChar, 14),
                            new MySqlParameter("@v_user_entry_date", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_user_leaving_date", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_code_user", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_user_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_password", SqlDbType.NVarChar, 1000),
                            new SqlParameter("@v_user_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_mail", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_mail_receive_check", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_user_grant", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_image_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_user_image", SqlDbType.Binary),
                            new SqlParameter("@v_user_emp_number", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_user_department", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_job_title", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_tel", SqlDbType.NVarChar, 14),
                            new SqlParameter("@v_user_tel_number", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_user_fax", SqlDbType.NVarChar, 14),
                            new SqlParameter("@v_user_entry_date", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_user_leaving_date", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pUserInformationEntity.CRUD;
                pDataParameters[1].Value = pUserInformationEntity.USER_CODE;
                pDataParameters[2].Value = pUserInformationEntity.USER_ID;
                pDataParameters[3].Value = pUserInformationEntity.USER_ACCOUNT;
                pDataParameters[4].Value = pUserInformationEntity.USER_PASSWORD;
                pDataParameters[5].Value = pUserInformationEntity.USER_NAME;
                pDataParameters[6].Value = pUserInformationEntity.USER_MAIL;
                pDataParameters[7].Value = pUserInformationEntity.MAIL_RECEIVE_CHECK;
                pDataParameters[8].Value = pUserInformationEntity.USER_GRANT;

                pDataParameters[9].Value = pUserInformationEntity.USER_IMAGE_NAME;
                pDataParameters[10].Value = pUserInformationEntity.USER_IMAGE;

                pDataParameters[11].Value = pUserInformationEntity.USER_EMP_NUMBER;
                pDataParameters[12].Value = pUserInformationEntity.USER_DEPARTMENT;
                pDataParameters[13].Value = pUserInformationEntity.USER_JOB_TITLE;
                pDataParameters[14].Value = pUserInformationEntity.USER_TEL;
                pDataParameters[15].Value =  pUserInformationEntity.USER_TEL_NUMBER;
                pDataParameters[16].Value = pUserInformationEntity.USER_FAX;
                pDataParameters[17].Value = pUserInformationEntity.USER_ENTRY_DATE;
                pDataParameters[18].Value = pUserInformationEntity.USER_LEAVING_DATE;
                pDataParameters[19].Value = pUserInformationEntity.REMARK;
                pDataParameters[20].Value = pUserInformationEntity.USE_YN;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_UserInformation_I10", pDataParameters);

                //if (pDataTable.Rows[0][0].ToString() != "00")
                //{
                //    pErrorYN = true;
                //}

                pUserInformationEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pUserInformationEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pUserInformationEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pUserInformationEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pUserInformationEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
            catch (Exception pException)
            {
                pErrorYN = true;

                throw new ExceptionManager
                (
                    this,
                    "User_Info_Save(UserInformationEntity pUserInformationEntity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion
        //

        #region 정보 저장하기 - User_Image_Delete(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pUserInformationEntity"></param>
        /// <returns></returns>
        public bool User_Image_Delete(UserInformationEntity pUserInformationEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            //int pCount = 0;

            try
            {

                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_code_user", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_user_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_image_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_user_image", MySqlDbType.MediumBlob)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_code_user", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_user_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_image_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_user_image", SqlDbType.Binary)
                        };
                        break;
                }

                pDataParameters[0].Value = pUserInformationEntity.CRUD;
                pDataParameters[1].Value = pUserInformationEntity.USER_CODE;
                pDataParameters[2].Value = pUserInformationEntity.USER_ID;
                pDataParameters[3].Value = pUserInformationEntity.USER_ACCOUNT;

                pDataParameters[4].Value = pUserInformationEntity.USER_IMAGE_NAME;
                pDataParameters[5].Value = pUserInformationEntity.USER_IMAGE;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_UserInformation_I15", pDataParameters);

                //if (pDataTable.Rows[0][0].ToString() != "00")
                //{
                //    pErrorYN = true;
                //}

                pUserInformationEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pUserInformationEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pUserInformationEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pUserInformationEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pUserInformationEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
            catch (Exception pException)
            {
                pErrorYN = true;

                throw new ExceptionManager
                (
                    this,
                    "User_Info_Save(UserInformationEntity pUserInformationEntity)",
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
        public override UserInformationEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                UserInformationEntity pUserInformationEntity = new UserInformationEntity();

                //pUserInformationEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pUserInformationEntity;
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


    public class SheetInfoRegisterProvider : EntityManager<SheetInfoRegisterEntity>
    {

        #region 생성자 - VendorInformationProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SheetInfoRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sheet_Info_Mst(SheetInfoRegisterEntity pSheetInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pVendorInformationEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_Mst(SheetInfoRegisterEntity pSheetInfoRegisterEntity)
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
                            new MySqlParameter("@v_use_type", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_file_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_type", SqlDbType.NVarChar, 50),
                            //new SqlParameter("@v_file_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;

                }

                pDataParameters[0].Value = pSheetInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pSheetInfoRegisterEntity.WINDOW_NAME;
                pDataParameters[2].Value = pSheetInfoRegisterEntity.USE_TYPE;
                pDataParameters[3].Value = pSheetInfoRegisterEntity.USE_YN;
                pDataParameters[4].Value = pSheetInfoRegisterEntity.LANGUAGE_TYPE;

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
                    "Sheet_Info_Mst(SheetInfoRegisterEntity pSheetInfoRegisterEntity)",
                    pException
                );
            }
        }
        #endregion

        #region 정보 저장하기 - Sheet_Info_Save(SheetInfoRegisterEntity pSheetInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sheet_Info_Save(SheetInfoRegisterEntity pSheetInfoRegisterEntity)
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
                                new MySqlParameter("@v_sheetinfo_id", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_file_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_file_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_use_vend_code", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_use_type", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_sheetinfo_id", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_file_type", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_file_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_use_vend_code", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_use_type", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 100)

                        };
                        break;

                }

                pDataParametersA[0].Value = pSheetInfoRegisterEntity.CRUD;
                pDataParametersA[1].Value = pSheetInfoRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pSheetInfoRegisterEntity.SHEETINFO_ID;
                pDataParametersA[3].Value = pSheetInfoRegisterEntity.WINDOW_NAME;
                pDataParametersA[4].Value = pSheetInfoRegisterEntity.PROCESS_CODE;
                pDataParametersA[5].Value = pSheetInfoRegisterEntity.FILE_TYPE;
                pDataParametersA[6].Value = pSheetInfoRegisterEntity.FILE_NAME;
                pDataParametersA[7].Value = pSheetInfoRegisterEntity.USE_VEND_CODE;
                pDataParametersA[8].Value = pSheetInfoRegisterEntity.USE_TYPE;
                pDataParametersA[9].Value = pSheetInfoRegisterEntity.USE_YN;
                pDataParametersA[10].Value = pSheetInfoRegisterEntity.REMARK;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SheetInfoRegister_I10", pDataParametersA);

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                pSheetInfoRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pSheetInfoRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pSheetInfoRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pSheetInfoRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pSheetInfoRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
                    "Sheet_Info_Save(SheetInfoRegisterEntity pSheetInfoRegisterEntity)",
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
        public override SheetInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SheetInfoRegisterEntity pSheetInfoRegisterEntity = new SheetInfoRegisterEntity();

                //pSheetInfoRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pSheetInfoRegisterEntity;
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

    public class MenuAuthorityProvider : EntityManager<MenuAuthorityEntity>
    {
        #region 생성자 - MenuAuthorityProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MenuAuthorityProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 정보 조회하기 - MenuAuthority_R10(MenuAuthorityEntity pMenuAuthorityEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="MenuAuthorityEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MenuAuthority_R10(MenuAuthorityEntity pMenuAuthorityEntity)
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
                            new MySqlParameter("@v_user_name", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_name", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pMenuAuthorityEntity.CRUD;
                pDataParameters[1].Value = pMenuAuthorityEntity.USER_CODE;
                pDataParameters[2].Value = pMenuAuthorityEntity.USER_ACCOUNT;
                pDataParameters[3].Value = pMenuAuthorityEntity.USER_NAME;
                pDataParameters[4].Value = pMenuAuthorityEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_R10", pDataParameters);

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
                    "MenuAuthority_R10(MenuAuthorityEntity pMenuAuthorityEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 조회하기 - MenuAuthority_R20(MenuAuthorityEntity pMenuAuthorityEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="MenuAuthorityEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MenuAuthority_R20(MenuAuthorityEntity pMenuAuthorityEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pMenuAuthorityEntity.CRUD;
                pDataParameters[1].Value = pMenuAuthorityEntity.USER_ACCOUNT;
                pDataParameters[2].Value = pMenuAuthorityEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_R20", pDataParameters);

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
                    "MenuAuthority_R20(MenuAuthorityEntity pMenuAuthorityEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - MenuAuthority_I10(MenuAuthorityEntity pMenuAuthorityEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pMenuAuthorityEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MenuAuthority_I10(MenuAuthorityEntity pMenuAuthorityEntity, DataTable dt)
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
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_menu_no", MySqlDbType.Int32),
                                new MySqlParameter("@v_menu_useyn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_init", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_search", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_save", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_additem", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_delete", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_print", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_import", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_export", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_menu_no", SqlDbType.Int),
                                new SqlParameter("@v_menu_useyn", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_init", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_search", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_save", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_additem", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_delete", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_print", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_import", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_export", SqlDbType.NVarChar, 1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pMenuAuthorityEntity.USER_CODE;
                        pDataParameters[2].Value = dt.Rows[a]["USER_ACCOUNT"].ToString().ToUpper();
                        pDataParameters[3].Value = int.Parse(dt.Rows[a]["MENU_NO"].ToString().ToUpper());
                        pDataParameters[4].Value = dt.Rows[a]["MENU_USEYN"].ToString();
                        pDataParameters[5].Value = dt.Rows[a]["MENU_INIT"].ToString();
                        pDataParameters[6].Value = dt.Rows[a]["MENU_SEARCH"].ToString();
                        pDataParameters[7].Value = dt.Rows[a]["MENU_SAVE"].ToString();
                        pDataParameters[8].Value = dt.Rows[a]["MENU_ADDITEM"].ToString();
                        pDataParameters[9].Value =  dt.Rows[a]["MENU_DELETE"].ToString();
                        pDataParameters[10].Value = dt.Rows[a]["MENU_PRINT"].ToString();
                        pDataParameters[11].Value = dt.Rows[a]["MENU_IMPORT"].ToString().ToUpper();
                        pDataParameters[12].Value = dt.Rows[a]["MENU_EXPORT"].ToString().ToUpper();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pMenuAuthorityEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pMenuAuthorityEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pMenuAuthorityEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pMenuAuthorityEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pMenuAuthorityEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "MenuAuthority_I10(MenuAuthorityEntity pMenuAuthorityEntity, DataTable dt)",
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
        public override MenuAuthorityEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MenuAuthorityEntity pMenuAuthorityEntity = new MenuAuthorityEntity();

                //pMenuAuthorityEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pMenuAuthorityEntity;
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

    public class MenuAuthority_T01Provider : EntityManager<MenuAuthority_T01Entity>
    {
        #region 생성자 - MenuAuthority_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MenuAuthority_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 정보 조회하기 - MenuAuthority_T01_R10(MenuAuthority_T01Entity pMenuAuthority_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="MenuAuthority_T01Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MenuAuthority_T01_R10(MenuAuthority_T01Entity pMenuAuthority_T01Entity)
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
                            new MySqlParameter("@v_user_name", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_name", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pMenuAuthority_T01Entity.CRUD;
                pDataParameters[1].Value = pMenuAuthority_T01Entity.USER_CODE;
                pDataParameters[2].Value = pMenuAuthority_T01Entity.USER_ACCOUNT;
                pDataParameters[3].Value = pMenuAuthority_T01Entity.USER_NAME;
                pDataParameters[4].Value = pMenuAuthority_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_T01_R10", pDataParameters);

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
                    "MenuAuthority_T01_R10(MenuAuthority_T01Entity pMenuAuthority_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 조회하기 - MenuAuthority_T01_R20(MenuAuthority_T01Entity pMenuAuthority_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="MenuAuthority_T01Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MenuAuthority_T01_R20(MenuAuthority_T01Entity pMenuAuthority_T01Entity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pMenuAuthority_T01Entity.CRUD;
                pDataParameters[1].Value = pMenuAuthority_T01Entity.USER_ACCOUNT;
                pDataParameters[2].Value = pMenuAuthority_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_T01_R20", pDataParameters);

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
                    "MenuAuthority_T01_R20(MenuAuthority_T01Entity pMenuAuthority_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - MenuAuthority_T01_I10(MenuAuthority_T01Entity pMenuAuthority_T01Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pMenuAuthority_T01Entity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MenuAuthority_T01_I10(MenuAuthority_T01Entity pMenuAuthority_T01Entity, DataTable dt)
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
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_menu_no", MySqlDbType.Int32),
                                new MySqlParameter("@v_menu_useyn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_init", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_search", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_save", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_additem", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_delete", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_print", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_import", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_export", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_menu_no", SqlDbType.Int),
                                new SqlParameter("@v_menu_useyn", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_init", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_search", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_save", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_additem", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_delete", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_print", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_import", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_export", SqlDbType.NVarChar, 1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pMenuAuthority_T01Entity.USER_CODE;
                        pDataParameters[2].Value = dt.Rows[a]["USER_ACCOUNT"].ToString().ToUpper();
                        pDataParameters[3].Value = int.Parse(dt.Rows[a]["MENU_NO"].ToString().ToUpper());
                        pDataParameters[4].Value = dt.Rows[a]["MENU_USEYN"].ToString();
                        pDataParameters[5].Value = dt.Rows[a]["MENU_INIT"].ToString();
                        pDataParameters[6].Value = dt.Rows[a]["MENU_SEARCH"].ToString();
                        pDataParameters[7].Value = dt.Rows[a]["MENU_SAVE"].ToString();
                        pDataParameters[8].Value = dt.Rows[a]["MENU_ADDITEM"].ToString();
                        pDataParameters[9].Value = dt.Rows[a]["MENU_DELETE"].ToString();
                        pDataParameters[10].Value = dt.Rows[a]["MENU_PRINT"].ToString();
                        pDataParameters[11].Value = dt.Rows[a]["MENU_IMPORT"].ToString().ToUpper();
                        pDataParameters[12].Value = dt.Rows[a]["MENU_EXPORT"].ToString().ToUpper();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_T01_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pMenuAuthority_T01Entity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pMenuAuthority_T01Entity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pMenuAuthority_T01Entity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pMenuAuthority_T01Entity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pMenuAuthority_T01Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "MenuAuthority_T01_I10(MenuAuthority_T01Entity pMenuAuthority_T01Entity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pMenuAuthority_T01Entity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MenuAuthority_T01_I20(MenuAuthority_T01Entity pMenuAuthority_T01Entity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            //int pCount = 0;

            try
            {
                //if (dt != null)
                //{
                    //pCount = dt.Rows.Count;

                    //for (int a = 0; a < pCount; a++)
                    //{

                        IDataParameter[] pDataParameters = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters = new IDataParameter[]
                                {
                                //new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                //new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 50),
                                //new MySqlParameter("@v_menu_no", MySqlDbType.Int32),
                                //new MySqlParameter("@v_menu_useyn", MySqlDbType.VarChar, 1),
                                //new MySqlParameter("@v_menu_init", MySqlDbType.VarChar, 1),
                                //new MySqlParameter("@v_menu_search", MySqlDbType.VarChar, 1),
                                //new MySqlParameter("@v_menu_save", MySqlDbType.VarChar, 1),
                                //new MySqlParameter("@v_menu_additem", MySqlDbType.VarChar, 1),
                                //new MySqlParameter("@v_menu_delete", MySqlDbType.VarChar, 1),
                                //new MySqlParameter("@v_menu_print", MySqlDbType.VarChar, 1),
                                //new MySqlParameter("@v_menu_import", MySqlDbType.VarChar, 1),
                                //new MySqlParameter("@v_menu_export", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                //new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                //new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                                //new SqlParameter("@v_menu_no", SqlDbType.Int),
                                //new SqlParameter("@v_menu_useyn", SqlDbType.NVarChar, 1),
                                //new SqlParameter("@v_menu_init", SqlDbType.NVarChar, 1),
                                //new SqlParameter("@v_menu_search", SqlDbType.NVarChar, 1),
                                //new SqlParameter("@v_menu_save", SqlDbType.NVarChar, 1),
                                //new SqlParameter("@v_menu_additem", SqlDbType.NVarChar, 1),
                                //new SqlParameter("@v_menu_delete", SqlDbType.NVarChar, 1),
                                //new SqlParameter("@v_menu_print", SqlDbType.NVarChar, 1),
                                //new SqlParameter("@v_menu_import", SqlDbType.NVarChar, 1),
                                //new SqlParameter("@v_menu_export", SqlDbType.NVarChar, 1)
                                };
                                break;
                        }

                        //pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        //pDataParameters[1].Value = pMenuAuthority_T01Entity.USER_CODE;
                        string a = pMenuAuthority_T01Entity.USER_ACCOUNT;
                        pDataParameters[0].Value = pMenuAuthority_T01Entity.USER_ACCOUNT; //dt.Rows[a]["USER_ACCOUNT"].ToString().ToUpper();

                        //pDataParameters[3].Value = int.Parse(dt.Rows[a]["MENU_NO"].ToString().ToUpper());
                        //pDataParameters[4].Value = dt.Rows[a]["MENU_USEYN"].ToString();
                        //pDataParameters[5].Value = dt.Rows[a]["MENU_INIT"].ToString();
                        //pDataParameters[6].Value = dt.Rows[a]["MENU_SEARCH"].ToString();
                        //pDataParameters[7].Value = dt.Rows[a]["MENU_SAVE"].ToString();
                        //pDataParameters[8].Value = dt.Rows[a]["MENU_ADDITEM"].ToString();
                        //pDataParameters[9].Value = dt.Rows[a]["MENU_DELETE"].ToString();
                        //pDataParameters[10].Value = dt.Rows[a]["MENU_PRINT"].ToString();
                        //pDataParameters[11].Value = dt.Rows[a]["MENU_IMPORT"].ToString().ToUpper();
                        //pDataParameters[12].Value = dt.Rows[a]["MENU_EXPORT"].ToString().ToUpper();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_T01_I20", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pMenuAuthority_T01Entity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pMenuAuthority_T01Entity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pMenuAuthority_T01Entity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pMenuAuthority_T01Entity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pMenuAuthority_T01Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                    //}



                //}

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
                    "MenuAuthority_T01_I20(MenuAuthority_T01Entity pMenuAuthority_T01Entity, DataTable dt)",
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
        public override MenuAuthority_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MenuAuthority_T01Entity pMenuAuthority_T01Entity = new MenuAuthority_T01Entity();

                //pMenuAuthority_T01Entity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pMenuAuthority_T01Entity;
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


    public class MenuAuthority_T02Provider : EntityManager<MenuAuthority_T02Entity>
    {
        #region 생성자 - MenuAuthority_T02Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MenuAuthority_T02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 정보 조회하기 - MenuAuthority_T02_R10(MenuAuthority_T02Entity pMenuAuthority_T02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="MenuAuthority_T02Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MenuAuthority_T02_R10(MenuAuthority_T02Entity pMenuAuthority_T02Entity)
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
                            new MySqlParameter("@v_user_name", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_name", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pMenuAuthority_T02Entity.CRUD;
                pDataParameters[1].Value = pMenuAuthority_T02Entity.USER_CODE;
                pDataParameters[2].Value = pMenuAuthority_T02Entity.USER_ACCOUNT;
                pDataParameters[3].Value = pMenuAuthority_T02Entity.USER_NAME;
                pDataParameters[4].Value = pMenuAuthority_T02Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_T02_R10", pDataParameters);

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
                    "MenuAuthority_T02_R10(MenuAuthority_T02Entity pMenuAuthority_T02Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 조회하기 - MenuAuthority_T02_R20(MenuAuthority_T02Entity pMenuAuthority_T02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="MenuAuthority_T02Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MenuAuthority_T02_R20(MenuAuthority_T02Entity pMenuAuthority_T02Entity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pMenuAuthority_T02Entity.CRUD;
                pDataParameters[1].Value = pMenuAuthority_T02Entity.USER_ACCOUNT;
                pDataParameters[2].Value = pMenuAuthority_T02Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_T02_R20", pDataParameters);

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
                    "MenuAuthority_T02_R20(MenuAuthority_T02Entity pMenuAuthority_T02Entity)",
                    pException
                );
            }
        }

        #endregion
        public DataTable MenuAuthority_T02_R30(MenuAuthority_T02Entity pMenuAuthority_T02Entity)
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
                            new MySqlParameter("@v_user_account", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_user_name", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_user_name", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)



                };
                        break;
                }

                pDataParameters[0].Value = pMenuAuthority_T02Entity.CRUD;
                pDataParameters[1].Value = pMenuAuthority_T02Entity.USER_ACCOUNT;
                pDataParameters[2].Value = pMenuAuthority_T02Entity.USER_NAME;
                pDataParameters[3].Value = pMenuAuthority_T02Entity.USE_YN;
                pDataParameters[4].Value = pMenuAuthority_T02Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_T02_R30", pDataParameters);

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
                    "User_Info(UserInformationEntity pUserInformationEntity)",
                    pException
                );
            }
        }
        public DataTable MenuAuthority_T02_R40(MenuAuthority_T02Entity pMenuAuthority_T02Entity)
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
                            new MySqlParameter("@v_user_account", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_user_name", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_user_name", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)



                };
                        break;
                }

                pDataParameters[0].Value = pMenuAuthority_T02Entity.CRUD;
                pDataParameters[1].Value = pMenuAuthority_T02Entity.USER_ACCOUNT;
                pDataParameters[2].Value = pMenuAuthority_T02Entity.USER_NAME;
                pDataParameters[3].Value = pMenuAuthority_T02Entity.USE_YN;
                pDataParameters[4].Value = pMenuAuthority_T02Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_T02_R40", pDataParameters);

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
                    "User_Info(UserInformationEntity pUserInformationEntity)",
                    pException
                );
            }
        }
        #region 정보 저장하기 - MenuAuthority_T02_I10(MenuAuthority_T02Entity pMenuAuthority_T02Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pMenuAuthority_T02Entity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MenuAuthority_T02_I10(MenuAuthority_T02Entity pMenuAuthority_T02Entity, DataTable dt)
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
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_menu_no", MySqlDbType.Int32),
                                new MySqlParameter("@v_menu_useyn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_init", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_search", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_save", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_additem", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_delete", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_print", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_import", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_menu_export", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_menu_no", SqlDbType.Int),
                                new SqlParameter("@v_menu_useyn", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_init", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_search", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_save", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_additem", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_delete", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_print", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_import", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_menu_export", SqlDbType.NVarChar, 1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pMenuAuthority_T02Entity.USER_CODE;
                        pDataParameters[2].Value = dt.Rows[a]["USER_ACCOUNT"].ToString().ToUpper();
                        pDataParameters[3].Value = int.Parse(dt.Rows[a]["MENU_NO"].ToString().ToUpper());
                        pDataParameters[4].Value = dt.Rows[a]["MENU_USEYN"].ToString();
                        pDataParameters[5].Value = dt.Rows[a]["MENU_INIT"].ToString();
                        pDataParameters[6].Value = dt.Rows[a]["MENU_SEARCH"].ToString();
                        pDataParameters[7].Value = dt.Rows[a]["MENU_SAVE"].ToString();
                        pDataParameters[8].Value = dt.Rows[a]["MENU_ADDITEM"].ToString();
                        pDataParameters[9].Value = dt.Rows[a]["MENU_DELETE"].ToString();
                        pDataParameters[10].Value = dt.Rows[a]["MENU_PRINT"].ToString();
                        pDataParameters[11].Value = dt.Rows[a]["MENU_IMPORT"].ToString().ToUpper();
                        pDataParameters[12].Value = dt.Rows[a]["MENU_EXPORT"].ToString().ToUpper();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_T02_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pMenuAuthority_T02Entity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pMenuAuthority_T02Entity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pMenuAuthority_T02Entity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pMenuAuthority_T02Entity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pMenuAuthority_T02Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "MenuAuthority_T02_I10(MenuAuthority_T02Entity pMenuAuthority_T02Entity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 정보 저장하기 - MenuAuthority_T02_I10(MenuAuthority_T02Entity pMenuAuthority_T02Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pMenuAuthority_T02Entity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MenuAuthority_T02_I20(MenuAuthority_T02Entity pMenuAuthority_T02Entity, DataTable dt)
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
                        if(dt.Rows[a]["CRUD"].ToString()=="Y")
                            { 
                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters = new IDataParameter[]
                                {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_user_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_copy_user_id", MySqlDbType.VarChar, 15)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_user_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_copy_user_id", SqlDbType.NVarChar, 15)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pMenuAuthority_T02Entity.USER_CODE;
                        pDataParameters[2].Value = dt.Rows[a]["USER_ACCOUNT"].ToString().ToUpper();
                        pDataParameters[3].Value = dt.Rows[a]["USER_ID"].ToString();
                        pDataParameters[4].Value = pMenuAuthority_T02Entity.COPY_USER_ID;

                            DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MenuAuthority_T02_I20", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pMenuAuthority_T02Entity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pMenuAuthority_T02Entity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pMenuAuthority_T02Entity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pMenuAuthority_T02Entity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pMenuAuthority_T02Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "MenuAuthority_T02_I10(MenuAuthority_T02Entity pMenuAuthority_T02Entity, DataTable dt)",
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
        public override MenuAuthority_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MenuAuthority_T02Entity pMenuAuthority_T02Entity = new MenuAuthority_T02Entity();

                //pMenuAuthority_T02Entity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pMenuAuthority_T02Entity;
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
    public class GroupMenuAuthorityProvider : EntityManager<GroupMenuAuthorityEntity>
    {
        #region 생성자 - GroupMenuAuthorityProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public GroupMenuAuthorityProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 정보 조회하기 - GroupMenuAuthority_R10(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="GroupMenuAuthorityEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable GroupMenuAuthority_R10(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity)
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
                            new MySqlParameter("@v_group_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_group_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pGroupMenuAuthorityEntity.CRUD;
                pDataParameters[1].Value = pGroupMenuAuthorityEntity.GROUP_NAME;
                pDataParameters[2].Value = pGroupMenuAuthorityEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GroupMenuAuthority_R10", pDataParameters);

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
                    "GroupMenuAuthority_R10(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 조회하기 - GroupMenuAuthority_R20(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="GroupMenuAuthorityEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable GroupMenuAuthority_R20(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity)
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
                            new MySqlParameter("@v_group_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_group_account", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_group_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_group_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pGroupMenuAuthorityEntity.CRUD;
                pDataParameters[1].Value = pGroupMenuAuthorityEntity.GROUP_CODE;
                pDataParameters[2].Value = pGroupMenuAuthorityEntity.GROUP_ACCOUNT;
                pDataParameters[3].Value = pGroupMenuAuthorityEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GroupMenuAuthority_R20", pDataParameters);

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
                    "GroupMenuAuthority_R20(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - GroupMenuAuthority_I20(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGroupMenuAuthorityEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool GroupMenuAuthority_I10(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity, DataTable dt)
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
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_group_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_Menu_no", MySqlDbType.Int32),
                                new MySqlParameter("@v_Menu_useyn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_Menu_init", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_Menu_search", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_Menu_save", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_Menu_additem", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_Menu_delete", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_Menu_print", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_Menu_import", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_Menu_export", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_group_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_Menu_no", SqlDbType.Int),
                                new SqlParameter("@v_Menu_useyn", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_Menu_init", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_Menu_search", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_Menu_save", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_Menu_additem", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_Menu_delete", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_Menu_print", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_Menu_import", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_Menu_export", SqlDbType.NVarChar, 1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pGroupMenuAuthorityEntity.USER_CODE;
                        pDataParameters[2].Value = dt.Rows[a]["GROUP_CODE"].ToString().ToUpper();
                        pDataParameters[3].Value = int.Parse(dt.Rows[a]["MENU_NO"].ToString().ToUpper());
                        pDataParameters[4].Value = dt.Rows[a]["MENU_USEYN"].ToString();
                        pDataParameters[5].Value = dt.Rows[a]["MENU_INIT"].ToString();
                        pDataParameters[6].Value = dt.Rows[a]["MENU_SEARCH"].ToString();
                        pDataParameters[7].Value = dt.Rows[a]["MENU_SAVE"].ToString();
                        pDataParameters[8].Value = dt.Rows[a]["MENU_ADDITEM"].ToString();
                        pDataParameters[9].Value = dt.Rows[a]["MENU_DELETE"].ToString();
                        pDataParameters[10].Value = dt.Rows[a]["MENU_PRINT"].ToString();
                        pDataParameters[11].Value = dt.Rows[a]["MENU_IMPORT"].ToString().ToUpper();
                        pDataParameters[12].Value = dt.Rows[a]["MENU_EXPORT"].ToString().ToUpper();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GroupMenuAuthority_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pGroupMenuAuthorityEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pGroupMenuAuthorityEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pGroupMenuAuthorityEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pGroupMenuAuthorityEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pGroupMenuAuthorityEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "GroupMenuAuthority_I10(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity, DataTable dt)",
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
        public override GroupMenuAuthorityEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                GroupMenuAuthorityEntity pGroupMenuAuthorityEntity = new GroupMenuAuthorityEntity();

                //pGroupMenuAuthorityEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pGroupMenuAuthorityEntity;
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

    public class Teamviewer_Info_T01Provider : EntityManager<Teamviewer_Info_T01Entity>
    {
        #region 생성자 - Teamviewer_Info_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public Teamviewer_Info_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Teamviewer_Info_T01_Info_Mst(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pTeamviewer_Info_T01Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Teamviewer_Info_T01_Info_Mst(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)
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
                            new MySqlParameter("@v_teamviewer_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_teamviewer_pw", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_teamviewer_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_teamviewer_vend", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_teamviewer_admin", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_remark",MySqlDbType.VarChar, 1000),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_teamviewer_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_teamviewer_pw", SqlDbType.VarChar, 10),
                            new SqlParameter("@v_teamviewer_name", SqlDbType.VarChar, 100),
                            new SqlParameter("@v_teamviewer_vend", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_teamviewer_admin", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_remark",SqlDbType.VarChar, 1000),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),

                };
                        break;
                }

                pDataParameters[0].Value = pTeamviewer_Info_T01Entity.CRUD;
                pDataParameters[1].Value = pTeamviewer_Info_T01Entity.TEAMVIEWER_ID;
                pDataParameters[2].Value = pTeamviewer_Info_T01Entity.TEAMVIEWER_PW;
                pDataParameters[3].Value = pTeamviewer_Info_T01Entity.TEAMVIEWER_NAME;
                pDataParameters[4].Value = pTeamviewer_Info_T01Entity.TEAMVIEWER_VEND;
                pDataParameters[5].Value = pTeamviewer_Info_T01Entity.TEAMVIEWER_ADMIN;
                pDataParameters[6].Value = pTeamviewer_Info_T01Entity.REMARK;
                pDataParameters[7].Value = pTeamviewer_Info_T01Entity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_teamviewer_info_T01_R10", pDataParameters);

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
                    "Teamviewer_Info_T01_Info_Mst(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 상세 조회하기 - Teamviewer_Info_T01_Info_Sub(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Teamviewer_Info_T01_Info_Sub(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_revision_no", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_revision_no", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pTeamviewer_Info_T01Entity.CRUD;
                pDataParameters[1].Value = pTeamviewer_Info_T01Entity.PART_CODE;
                pDataParameters[2].Value = pTeamviewer_Info_T01Entity.PART_REVISION_NO;
                pDataParameters[3].Value = pTeamviewer_Info_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_teamviewer_info_T01_R20", pDataParameters);

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
                    "Teamviewer_Info_T01_Info_Sub(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Teamviewer_Info_T01_Info_Save(Teamviewer_Info_T01Entity pTeamviewer_Info_T01, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Teamviewer_Info_T01_Info_Save(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)
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
                                new MySqlParameter("@v_teamviewer_id", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_teamviewer_pw", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_teamviewer_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_teamviewer_vend", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_teamviewer_admin", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.VarChar, 20),
                                new SqlParameter("@v_teamviewer_id", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_teamviewer_pw", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_teamviewer_name", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_teamviewer_vend", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_teamviewer_admin",SqlDbType.VarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                        };
                        break;
                }

                pDataParametersA[0].Value = pTeamviewer_Info_T01Entity.CRUD;
                pDataParametersA[1].Value = pTeamviewer_Info_T01Entity.USER_CODE;
                pDataParametersA[2].Value = pTeamviewer_Info_T01Entity.TEAMVIEWER_ID;
                pDataParametersA[3].Value = pTeamviewer_Info_T01Entity.TEAMVIEWER_PW;
                pDataParametersA[4].Value = pTeamviewer_Info_T01Entity.TEAMVIEWER_NAME;
                pDataParametersA[5].Value = pTeamviewer_Info_T01Entity.TEAMVIEWER_VEND;
                pDataParametersA[6].Value = pTeamviewer_Info_T01Entity.TEAMVIEWER_ADMIN;
                pDataParametersA[7].Value = pTeamviewer_Info_T01Entity.REMARK;
                pDataParametersA[8].Value = pTeamviewer_Info_T01Entity.USE_YN;


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Teamviewer_Info_T01_I10", pDataParametersA);

                pTeamviewer_Info_T01Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pTeamviewer_Info_T01Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pTeamviewer_Info_T01Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pTeamviewer_Info_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();

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
                    "Teamviewer_Info_T01Entity_Info_Save(Teamviewer_Info_T01EntityEntity pTeamviewer_Info_T01EntityEntity, DataTable dt)",
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
        public override Teamviewer_Info_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity = new Teamviewer_Info_T01Entity();

                //pMaterialInformationRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pTeamviewer_Info_T01Entity;
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

    public class GroupUserMailingProvider : EntityManager<GroupUserMailingEntity>
    {
        #region 생성자 - GroupUserMailingProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public GroupUserMailingProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 룰 정보 조회하기 - GroupRule_info(GroupUserMailingEntity pGroupUserMailingEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGroupUserMailingEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable GroupRule_info(GroupUserMailingEntity pGroupUserMailingEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_resource_name", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_resource_name", SqlDbType.NVarChar,50)
                        };
                        break;
                }

                pDataParameters[0].Value = pGroupUserMailingEntity.RESOURCE_NAME;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GroupUserMailing_R10", pDataParameters);

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
                    "GroupRule_info(GroupUserMailingEntity pGroupUserMailingEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 룰 그룹 별 사용자 조회하기 - GroupUserMailing_Rule_info(GroupUserMailingEntity pGroupUserMailingEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGroupUserMailingEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable GroupUserMailing_Rule_info(GroupUserMailingEntity pGroupUserMailingEntity)
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
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar,20)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar,20)
                        };
                        break;
                }

                pDataParameters[0].Value = pGroupUserMailingEntity.CRUD;
                pDataParameters[1].Value = pGroupUserMailingEntity.RESOURCE_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GroupUserMailing_R20", pDataParameters);

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
                    "GroupUserMailing_Rule_info(GroupUserMailingEntity pGroupUserMailingEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - GroupUserMailing_Info_Save(GroupUserMailingEntity pGroupUserMailingEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pLanguageInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool GroupUserMailing_Info_Save(GroupUserMailingEntity pGroupUserMailingEntity, DataTable dt)
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
                                new MySqlParameter("@v_resource_code", MySqlDbType.VarChar,20),
                                new MySqlParameter("@v_user_id", MySqlDbType.VarChar,20),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                new SqlParameter("@v_resource_code", SqlDbType.NVarChar,20),
                                new SqlParameter("@v_user_id", SqlDbType.NVarChar,20),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                };
                                break;
                        }

                        if(dt.Rows[a]["ID"].ToString().ToUpper() == "")
                        {
                            pDataParameters[0].Value = "C";
                        }else
                        {
                            if(dt.Rows[a]["CHECKED"].ToString().ToUpper() == "N")
                            {
                                pDataParameters[0].Value = "D";
                            }else
                            {
                                pDataParameters[0].Value = "U";
                            }
                        }

                        pDataParameters[1].Value = dt.Rows[a]["ID"].ToString().ToUpper() == "" ? pGroupUserMailingEntity.RESOURCE_CODE : dt.Rows[a]["ID"].ToString().ToUpper();
                        pDataParameters[2].Value = dt.Rows[a]["USER_ID"].ToString().ToUpper();
                        pDataParameters[3].Value = pGroupUserMailingEntity.USER_CODE;

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GroupUserMailing_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pGroupUserMailingEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pGroupUserMailingEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pGroupUserMailingEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pGroupUserMailingEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pGroupUserMailingEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "GroupUserMailing_Info_Save(GroupUserMailingEntity pGroupUserMailingEntity, DataTable dt)",
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
        public override GroupUserMailingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                GroupUserMailingEntity pGroupUserMailingEntity = new GroupUserMailingEntity();

                //pCommonCodeRegisterEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pGroupUserMailingEntity;
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
