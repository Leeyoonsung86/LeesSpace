using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

using CoFAS_MES.UI.PO.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;
using DevExpress.Spreadsheet;
using System.Threading;

namespace CoFAS_MES.UI.PO.Data
{
    public class Dyeing_RecipeInformationRegisterProvider : EntityManager<Dyeing_RecipeInformationRegisterEntity>
    {
        #region 생성자 - Dyeing_RecipeInformationRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public Dyeing_RecipeInformationRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)
        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pDyeing_RecipeInformationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pDyeing_RecipeInformationRegisterEntity.CORP_CODE;
                pDataParameters[1].Value = pDyeing_RecipeInformationRegisterEntity.CRUD;
                pDataParameters[2].Value = pDyeing_RecipeInformationRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Dyeing_RecipeInformationRegister_R10", pDataParameters);

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
                    "Sample_Info_Mst(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity, DataTable dt)
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

                pDataParametersA[0].Value = pDyeing_RecipeInformationRegisterEntity.CORP_CODE;
                pDataParametersA[1].Value = pDyeing_RecipeInformationRegisterEntity.CRUD;
                pDataParametersA[2].Value = pDyeing_RecipeInformationRegisterEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SampleRegister_I10", pDataParametersA);

                pDyeing_RecipeInformationRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pDyeing_RecipeInformationRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pDyeing_RecipeInformationRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pDyeing_RecipeInformationRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pDyeing_RecipeInformationRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                            pDataParametersB[0].Value = pDyeing_RecipeInformationRegisterEntity.CORP_CODE;
                            pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[2].Value = pDyeing_RecipeInformationRegisterEntity.USER_CODE;

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pDyeing_RecipeInformationRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pDyeing_RecipeInformationRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pDyeing_RecipeInformationRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pDyeing_RecipeInformationRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pDyeing_RecipeInformationRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity, DataTable dt)",
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
        public override Dyeing_RecipeInformationRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity = new Dyeing_RecipeInformationRegisterEntity();

                pDyeing_RecipeInformationRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pDyeing_RecipeInformationRegisterEntity;
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

    public class Dyeing_WorkOrdersRegisterProvider : EntityManager<Dyeing_WorkOrdersRegisterEntity>
    {
        #region 생성자 - Dyeing_WorkOrdersRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public Dyeing_WorkOrdersRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)
        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pDyeing_RecipeInformationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(Dyeing_WorkOrdersRegisterEntity pDyeing_WorkOrdersRegisterEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pDyeing_WorkOrdersRegisterEntity.CORP_CODE;
                pDataParameters[1].Value = pDyeing_WorkOrdersRegisterEntity.CRUD;
                pDataParameters[2].Value = pDyeing_WorkOrdersRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Dyeing_RecipeInformationRegister_R10", pDataParameters);

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
                    "Sample_Info_Mst(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(Dyeing_WorkOrdersRegisterEntity pDyeing_WorkOrdersRegisterEntity, DataTable dt)
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

                pDataParametersA[0].Value = pDyeing_WorkOrdersRegisterEntity.CORP_CODE;
                pDataParametersA[1].Value = pDyeing_WorkOrdersRegisterEntity.CRUD;
                pDataParametersA[2].Value = pDyeing_WorkOrdersRegisterEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SampleRegister_I10", pDataParametersA);

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pDyeing_WorkOrdersRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pDyeing_WorkOrdersRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pDyeing_WorkOrdersRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pDyeing_WorkOrdersRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pDyeing_WorkOrdersRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
                    "Sample_Info_Save(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity, DataTable dt)",
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
        public override Dyeing_WorkOrdersRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                Dyeing_WorkOrdersRegisterEntity pDyeing_WorkOrdersRegisterEntity = new Dyeing_WorkOrdersRegisterEntity();

                pDyeing_WorkOrdersRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pDyeing_WorkOrdersRegisterEntity;
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


    public class WorkOrdersRegisterProvider : EntityManager<WorkOrdersRegisterEntity>
    {
        #region 생성자 - WorkOrdersRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkOrdersRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_plan_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_workcenter_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[] 
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_plan_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_workcenter_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                //pDataParameters[0].Value = pWorkOrdersRegisterEntity.CORP_CODE;
                pDataParameters[0].Value = pWorkOrdersRegisterEntity.CRUD;
                pDataParameters[1].Value = pWorkOrdersRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pWorkOrdersRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pWorkOrdersRegisterEntity.ORDER_CODE;
                pDataParameters[4].Value = pWorkOrdersRegisterEntity.PART_CODE;
                pDataParameters[5].Value = pWorkOrdersRegisterEntity.PART_NAME;
                pDataParameters[6].Value = pWorkOrdersRegisterEntity.REFERENCE_ID;
                pDataParameters[7].Value = pWorkOrdersRegisterEntity.PROCESS_CODE;
                pDataParameters[8].Value = pWorkOrdersRegisterEntity.USE_YN;
                pDataParameters[9].Value = pWorkOrdersRegisterEntity.WORKCENTER_CODE;
                pDataParameters[10].Value = pWorkOrdersRegisterEntity.COMPLETE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WORKORDER_R10", pDataParameters);

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
                    "Sample_Info_Mst(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity)
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
                                new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_order_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_order_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                            
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_order_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_order_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_order_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                             
                        };
                        break;
                }

                pDataParametersA[0].Value = pWorkOrdersRegisterEntity.CRUD;
                pDataParametersA[1].Value = pWorkOrdersRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pWorkOrdersRegisterEntity.ORDER_CODE;
                pDataParametersA[3].Value = pWorkOrdersRegisterEntity.ORDER_DATE;
                pDataParametersA[4].Value = pWorkOrdersRegisterEntity.WORKCENTER_CODE;
                pDataParametersA[5].Value = pWorkOrdersRegisterEntity.ORDER_QTY;
                pDataParametersA[6].Value = pWorkOrdersRegisterEntity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrderRegister_I10", pDataParametersA);

                pWorkOrdersRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pWorkOrdersRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pWorkOrdersRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pWorkOrdersRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "ProductOutRegister_Info_Save(ProductOutRegisterEntity pProductOutRegisterEntity, DataTable dt)",
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
        public override WorkOrdersRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkOrdersRegisterEntity pWorkOrdersRegisterEntity = new WorkOrdersRegisterEntity();

                pWorkOrdersRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkOrdersRegisterEntity;
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

    public class WorkOrdersRegister_T07Provider : EntityManager<WorkOrdersRegister_T07Entity>
    {
        #region 생성자 - WorkOrdersRegister_T07Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkOrdersRegister_T07Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_plan_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_workcenter_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_plan_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_workcenter_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                //pDataParameters[0].Value = pWorkOrdersRegister_T07Entity.CORP_CODE;
                pDataParameters[0].Value = pWorkOrdersRegister_T07Entity.CRUD;
                pDataParameters[1].Value = pWorkOrdersRegister_T07Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkOrdersRegister_T07Entity.DATE_TO;
                pDataParameters[3].Value = pWorkOrdersRegister_T07Entity.ORDER_CODE;
                pDataParameters[4].Value = pWorkOrdersRegister_T07Entity.PART_CODE;
                pDataParameters[5].Value = pWorkOrdersRegister_T07Entity.PART_NAME;
                pDataParameters[6].Value = pWorkOrdersRegister_T07Entity.REFERENCE_ID;
                pDataParameters[7].Value = pWorkOrdersRegister_T07Entity.PROCESS_CODE;
                pDataParameters[8].Value = pWorkOrdersRegister_T07Entity.USE_YN;
                pDataParameters[9].Value = pWorkOrdersRegister_T07Entity.WORKCENTER_CODE;
                pDataParameters[10].Value = pWorkOrdersRegister_T07Entity.COMPLETE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T07_R10", pDataParameters);

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
                    "Sample_Info_Mst(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity)
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
                                new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_order_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_order_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_order_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_order_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_order_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)

                        };
                        break;
                }

                pDataParametersA[0].Value = pWorkOrdersRegister_T07Entity.CRUD;
                pDataParametersA[1].Value = pWorkOrdersRegister_T07Entity.USER_CODE;
                pDataParametersA[2].Value = pWorkOrdersRegister_T07Entity.ORDER_CODE;
                pDataParametersA[3].Value = pWorkOrdersRegister_T07Entity.ORDER_DATE;
                pDataParametersA[4].Value = pWorkOrdersRegister_T07Entity.WORKCENTER_CODE;
                pDataParametersA[5].Value = pWorkOrdersRegister_T07Entity.ORDER_QTY;
                pDataParametersA[6].Value = pWorkOrdersRegister_T07Entity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrderRegister_I10", pDataParametersA);

                pWorkOrdersRegister_T07Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pWorkOrdersRegister_T07Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pWorkOrdersRegister_T07Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pWorkOrdersRegister_T07Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "ProductOutRegister_Info_Save(ProductOutRegisterEntity pProductOutRegisterEntity, DataTable dt)",
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
        public override WorkOrdersRegister_T07Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity = new WorkOrdersRegister_T07Entity();

                pWorkOrdersRegister_T07Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkOrdersRegister_T07Entity;
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
    public class WorkOrdersRegister_T50Provider : EntityManager<WorkOrdersRegister_T50Entity>
    {
        #region 생성자 - WorkOrdersRegister_T50Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkOrdersRegister_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(SampleExcelBindingEntity pRawMaterialInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pRawMaterialInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;

                }

                pDataParameters[0].Value = pWorkOrdersRegister_T50Entity.CRUD;
                pDataParameters[1].Value = pWorkOrdersRegister_T50Entity.WINDOW_NAME;
                pDataParameters[2].Value = pWorkOrdersRegister_T50Entity.LANGUAGE_TYPE;

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

        public DataSet WorkOrderRegister_info_ExcelBinding(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkOrdersRegister_T50Entity.PRODUCTION_ORDER_ID;
                pDataParameters[1].Value = pWorkOrdersRegister_T50Entity.PART_CODE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T50_R20", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "Sample_Info_Mst(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)",
                    pException
                );
            }

        }

        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_plan_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_workcenter_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_plan_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_workcenter_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                //pDataParameters[0].Value = pWorkOrdersRegister_T50Entity.CORP_CODE;
                pDataParameters[0].Value = pWorkOrdersRegister_T50Entity.CRUD;
                pDataParameters[1].Value = pWorkOrdersRegister_T50Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkOrdersRegister_T50Entity.DATE_TO;
                pDataParameters[3].Value = pWorkOrdersRegister_T50Entity.ORDER_CODE;
                pDataParameters[4].Value = pWorkOrdersRegister_T50Entity.PART_CODE;
                pDataParameters[5].Value = pWorkOrdersRegister_T50Entity.PART_NAME;
                pDataParameters[6].Value = pWorkOrdersRegister_T50Entity.REFERENCE_ID;
                pDataParameters[7].Value = pWorkOrdersRegister_T50Entity.PROCESS_CODE;
                pDataParameters[8].Value = pWorkOrdersRegister_T50Entity.USE_YN;
                pDataParameters[9].Value = pWorkOrdersRegister_T50Entity.WORKCENTER_CODE;
                pDataParameters[10].Value = pWorkOrdersRegister_T50Entity.COMPLETE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T50_R10", pDataParameters);

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
                    "Sample_Info_Mst(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)
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
                                new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_order_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_order_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_carve", MySqlDbType.VarChar, 500),
                                new MySqlParameter("@v_message", MySqlDbType.VarChar, 500)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_order_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_order_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_order_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)

                        };
                        break;
                }

                pDataParametersA[0].Value = pWorkOrdersRegister_T50Entity.CRUD;
                pDataParametersA[1].Value = pWorkOrdersRegister_T50Entity.USER_CODE;
                pDataParametersA[2].Value = pWorkOrdersRegister_T50Entity.ORDER_CODE;
                pDataParametersA[3].Value = pWorkOrdersRegister_T50Entity.ORDER_DATE;
                pDataParametersA[4].Value = pWorkOrdersRegister_T50Entity.WORKCENTER_CODE;
                pDataParametersA[5].Value = pWorkOrdersRegister_T50Entity.ORDER_QTY;
                pDataParametersA[6].Value = pWorkOrdersRegister_T50Entity.USE_YN;
                pDataParametersA[7].Value = pWorkOrdersRegister_T50Entity.CARVE;
                pDataParametersA[8].Value = pWorkOrdersRegister_T50Entity.MESSAGE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrderRegister_T50_I10", pDataParametersA);

                pWorkOrdersRegister_T50Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pWorkOrdersRegister_T50Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pWorkOrdersRegister_T50Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pWorkOrdersRegister_T50Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "ProductOutRegister_Info_Save(ProductOutRegisterEntity pProductOutRegisterEntity, DataTable dt)",
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
        public override WorkOrdersRegister_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity = new WorkOrdersRegister_T50Entity();

                pWorkOrdersRegister_T50Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkOrdersRegister_T50Entity;
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

    public class LotManagementSatusProvider : EntityManager<LotManagementSatusEntity>
    {
        #region 생성자 - LotManagementSatusProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public LotManagementSatusProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(LotManagementSatusEntity pLotManagementSatusEntity)
        public DataTable Sample_Info_Mst(LotManagementSatusEntity pLotManagementSatusEntity)
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

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8)
                        };
                        break;
                }

                pDataParameters[0].Value = pLotManagementSatusEntity.CRUD;
                pDataParameters[1].Value = pLotManagementSatusEntity.DATE_FROM;
                pDataParameters[2].Value = pLotManagementSatusEntity.DATE_TO;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "", pDataParameters);
                
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
                    "Sample_Info_Mst(LotManagementSatusEntity pLotManagementSatusEntity)",
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
        public override LotManagementSatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                LotManagementSatusEntity pLotManagementSatusEntity = new LotManagementSatusEntity();

                pLotManagementSatusEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pLotManagementSatusEntity;
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

    public class WorkOrdersRegister_T01Provider : EntityManager<WorkOrdersRegister_T01Entity>
    {
        #region 생성자 - WorkOrdersRegister_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkOrdersRegister_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_workcenter_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_reference_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_workcenter_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_complete_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                //pDataParameters[0].Value = pWorkOrdersRegister_T01Entity.CORP_CODE;
                pDataParameters[0].Value = pWorkOrdersRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pWorkOrdersRegister_T01Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkOrdersRegister_T01Entity.DATE_TO;
                pDataParameters[3].Value = pWorkOrdersRegister_T01Entity.ORDER_CODE;
                pDataParameters[4].Value = pWorkOrdersRegister_T01Entity.PART_CODE;
                pDataParameters[5].Value = pWorkOrdersRegister_T01Entity.PART_NAME;
                pDataParameters[6].Value = pWorkOrdersRegister_T01Entity.REFERENCE_ID;
                pDataParameters[7].Value = pWorkOrdersRegister_T01Entity.PROCESS_CODE;
                pDataParameters[8].Value = pWorkOrdersRegister_T01Entity.USE_YN;
                pDataParameters[9].Value = pWorkOrdersRegister_T01Entity.WORKCENTER_CODE;
                pDataParameters[10].Value = pWorkOrdersRegister_T01Entity.LANGUAGE_TYPE;
                pDataParameters[11].Value = pWorkOrdersRegister_T01Entity.COMPLETE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T01_R10", pDataParameters);

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
                    "Sample_Info_Mst(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity)
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
                                new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_order_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_order_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_order_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_order_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_order_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)

                        };
                        break;
                }

                pDataParametersA[0].Value = pWorkOrdersRegister_T01Entity.CRUD;
                pDataParametersA[1].Value = pWorkOrdersRegister_T01Entity.USER_CODE;
                pDataParametersA[2].Value = pWorkOrdersRegister_T01Entity.ORDER_CODE;
                pDataParametersA[3].Value = pWorkOrdersRegister_T01Entity.ORDER_DATE;
                pDataParametersA[4].Value = pWorkOrdersRegister_T01Entity.WORKCENTER_CODE;
                pDataParametersA[5].Value = pWorkOrdersRegister_T01Entity.ORDER_QTY;
                pDataParametersA[6].Value = pWorkOrdersRegister_T01Entity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T01_I10", pDataParametersA);

                pWorkOrdersRegister_T01Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pWorkOrdersRegister_T01Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pWorkOrdersRegister_T01Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pWorkOrdersRegister_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "ProductOutRegister_Info_Save(ProductOutRegisterEntity pProductOutRegisterEntity, DataTable dt)",
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
        public override WorkOrdersRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity = new WorkOrdersRegister_T01Entity();

                pWorkOrdersRegister_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkOrdersRegister_T01Entity;
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

    public class WorkOrdersRegister_T02Provider : EntityManager<WorkOrdersRegister_T02Entity>
    {
        #region 생성자 - WorkOrdersRegister_T02Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkOrdersRegister_T02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pWorkOrdersRegister_T02Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)
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
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_order_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_order_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_order_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_reference_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkOrdersRegister_T02Entity.CRUD;
                pDataParameters[1].Value = pWorkOrdersRegister_T02Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkOrdersRegister_T02Entity.DATE_TO;
                pDataParameters[3].Value = pWorkOrdersRegister_T02Entity.ORDER_NUMBER;
                pDataParameters[4].Value = pWorkOrdersRegister_T02Entity.ORDER_NAME;
                pDataParameters[5].Value = pWorkOrdersRegister_T02Entity.REFERENCE_ID;
                pDataParameters[6].Value = pWorkOrdersRegister_T02Entity.USE_YN;
                pDataParameters[7].Value = pWorkOrdersRegister_T02Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T02_R10", pDataParameters);
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
                    "Sample_Info_Mst(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 - Sample_Info_Sub(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pWorkOrdersRegister_T02Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Sub(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_production_plan_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_order_number", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_complete_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),

                        };
                        break;
                }

                //pDataParameters[0].Value = pWorkOrdersRegisterEntity.CORP_CODE;
                pDataParameters[0].Value = pWorkOrdersRegister_T02Entity.CRUD;
                pDataParameters[1].Value = pWorkOrdersRegister_T02Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkOrdersRegister_T02Entity.DATE_TO;
                pDataParameters[3].Value = pWorkOrdersRegister_T02Entity.PRODUCTION_PLAN_ID;
                pDataParameters[4].Value = pWorkOrdersRegister_T02Entity.ORDER_NUMBER;
                pDataParameters[5].Value = pWorkOrdersRegister_T02Entity.COMPLETE_YN;
                pDataParameters[6].Value = pWorkOrdersRegister_T02Entity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T02_R11", pDataParameters);

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
                    "Sample_Info_Sub(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pWorkOrdersRegister_T02Entity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity, DataTable pDataTable)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction();
            try
            {
                if (pDataTable != null)
                {
                    pCount = pDataTable.Rows.Count;
                    for (int i = 0; i < pCount; i++)
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
                                    new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_production_order_date", MySqlDbType.VarChar, 8),
                                    new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 6),
                                    new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_production_order_qty", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1),
                                    new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParametersA = new IDataParameter[]
                                {
                                    new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                                    new SqlParameter("@v_production_order_date", SqlDbType.VarChar, 8),
                                    new SqlParameter("@v_production_order_seq", SqlDbType.VarChar, 6),
                                    new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_production_order_qty", SqlDbType.Decimal),
                                    new SqlParameter("@v_reference_id", SqlDbType.VarChar, 15),
                                    new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                                };
                                break;
                        }
                        if (pDataTable.Rows[i]["REG_PRODUCTION"].ToString().Equals("Y"))
                        {
                            pDataParametersA[0].Value = "U";
                            pDataParametersA[1].Value = pWorkOrdersRegister_T02Entity.USER_CODE;
                            pDataParametersA[2].Value = pDataTable.Rows[i]["PRODUCTION_ORDER_ID"].ToString();
                            if (pDataTable.Rows[i]["PRODUCTION_ORDER_DATE"].ToString().Length > 8)
                            {
                                pDataParametersA[3].Value = pDataTable.Rows[i]["PRODUCTION_ORDER_DATE"].ToString().Substring(0, 10).Replace("-", "").ToString();
                            }
                            else
                            {
                                pDataParametersA[3].Value = pDataTable.Rows[i]["PRODUCTION_ORDER_DATE"].ToString();
                            }
                            pDataParametersA[4].Value = pDataTable.Rows[i]["PRODUCTION_ORDER_SEQ"].ToString();
                        }
                        else
                        {
                            pDataParametersA[0].Value = "C";
                            pDataParametersA[1].Value = pWorkOrdersRegister_T02Entity.USER_CODE;
                            pDataParametersA[2].Value = ""; // ID
                            if (pDataTable.Rows[i]["PRODUCTION_ORDER_DATE"].ToString().Length > 8)
                            {
                                pDataParametersA[3].Value = pDataTable.Rows[i]["PRODUCTION_ORDER_DATE"].ToString().Substring(0, 10).Replace("-", "").ToString();
                            }
                            else
                            {
                                pDataParametersA[3].Value = pDataTable.Rows[i]["PRODUCTION_ORDER_DATE"].ToString();
                            }
                            pDataParametersA[4].Value = ""; // SEQ
                        }
                        pDataParametersA[5].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                        pDataParametersA[6].Value = pDataTable.Rows[i]["PRODUCTION_ORDER_QTY"].ToString();
                        pDataParametersA[7].Value = pDataTable.Rows[i]["REFERENCE_ID"].ToString();
                        pDataParametersA[8].Value = pDataTable.Rows[i]["COMPLETE_YN"].ToString();
                        pDataParametersA[9].Value = pDataTable.Rows[i]["USE_YN"].ToString();

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T02_I10", pDataParametersA);

                        pWorkOrdersRegister_T02Entity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                        pWorkOrdersRegister_T02Entity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                        pWorkOrdersRegister_T02Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                        pWorkOrdersRegister_T02Entity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

                        if (pDataTableA.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                    }
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
                    "Sample_Info_Save(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity, DataTable pDataTable)",
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
        public override WorkOrdersRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity = new WorkOrdersRegister_T02Entity();

                pWorkOrdersRegister_T02Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkOrdersRegister_T02Entity;
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

    public class ucWorkOrderInfoPopup_T01Provider : EntityManager<ucWorkOrderInfoPopup_T01Entity>
    {
        #region 생성자 - ucWorkOrderInfoPopup_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucWorkOrderInfoPopup_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucWorkOrderInfoPopup_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucWorkOrderInfoPopup_T01Entity pucWorkOrderInfoPopup_T01Entity = new ucWorkOrderInfoPopup_T01Entity();
                pucWorkOrderInfoPopup_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucWorkOrderInfoPopup_T01Entity;
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

        #region 코드정보 조회하기 WorkOrderInfo_Return(string pCRUD, string pPLANORDER)

        public DataSet WorkOrderInfo_Return(string pCRUD, string pPLANORDER, string pPARTCODE)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPLANORDER;
                pDataParameters[2].Value = pPARTCODE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucWorkOrderInfoPopup_T01_R10", pDataParameters);
                return pDataTableSet;
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
                    "WorkOrderInfo_Return(string pCRUD, string pPARTCODE, string pPARTNAME, string PARTTYPE)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - WorkOrderInfo_Save(ucWorkOrderInfoPopup_T01Entity pucWorkOrderInfoPopup_T01Entity, DataTable pDataTable)


        //public bool WorkOrderInfo_Save(ucWorkOrderInfoPopup_T01Entity pucWorkOrderInfoPopup_T01Entity, DataTable pDataTable)
        public DataSet WorkOrderInfo_Save(ucWorkOrderInfoPopup_T01Entity pucWorkOrderInfoPopup_T01Entity, DataTable pDataTable)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
           // DataTable tmp_DataTable = null;
            DataSet tmp_DataSet = null;
            _pDBManager.BeginTransaction();

            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                string v_create_seq = "";     
                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParametersA = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_production_order_date", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 3),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_qty", MySqlDbType.Decimal),
                            new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_production_request_file", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_create_seq", MySqlDbType.VarChar,50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_production_order_date", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_production_order_seq", SqlDbType.VarChar, 3),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_qty", SqlDbType.Decimal),
                            new SqlParameter("@v_reference_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_production_request_file", SqlDbType.VarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_create_seq", SqlDbType.VarChar,50)
                        };
                        break;
                }

                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(pDataTable.Rows[i]["IN_QTY"].ToString()) > 0)
                    {
                        pDataParametersA[0].Value = pucWorkOrderInfoPopup_T01Entity.CRUD;
                        pDataParametersA[1].Value = pucWorkOrderInfoPopup_T01Entity.USER_CODE;
                        //if (i == 0)
                        pDataParametersA[2].Value = "";
                        //else
                        //    pDataParametersA[2].Value = pucWorkOrderInfoPopup_T01Entity.RTN_KEY;

                        pDataParametersA[3].Value = pDataTable.Rows[i]["PRODUCT_ORDER_DATE"].ToString().Substring(0, 10).Replace("-", "");
                        pDataParametersA[4].Value = "";
                        pDataParametersA[5].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                        pDataParametersA[6].Value = pDataTable.Rows[i]["PROCESS_CODE"].ToString();//
                        pDataParametersA[7].Value = Convert.ToDecimal(pDataTable.Rows[i]["IN_QTY"].ToString());
                        pDataParametersA[8].Value = pucWorkOrderInfoPopup_T01Entity.REFERENCE_ID;
                        pDataParametersA[9].Value = "N";
                        pDataParametersA[10].Value = "";// pDataTable.Rows[i]["WORKCENTER_CODE"].ToString();
                        pDataParametersA[11].Value = pucWorkOrderInfoPopup_T01Entity.FILE_NAME;
                        pDataParametersA[12].Value = "Y";
                        pDataParametersA[13].Value = v_create_seq =="" ? "" : v_create_seq;

                        DataTable pDataTableA = null;
                        tmp_DataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucWorkOrderInfoPopup_T01_I10", pDataParametersA);

                        pDataTableA = tmp_DataSet.Tables[0];
                        
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                            
                        }
                        else
                        {
                            pucWorkOrderInfoPopup_T01Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                            v_create_seq = pDataTableA.Rows[0]["rtn_create_seq"].ToString();

                            //tmp_DataTable = tmp_DataSet
                        }
                    }
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
                    "RuleGenerator_Info_Save(RuleGeneratorEntity pRuleGeneratorEntity, DataTable dt)",
                    pException
                );
            }
            finally
            {
                if (pErrorYN)
                    _pDBManager.RollbackTransaction();  // 저장실패
                else
                    _pDBManager.CommitTransaction();
            }

            //return pErrorYN;
            return tmp_DataSet;
        }

        #endregion

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(SheetInfoRegisterEntity pSheetInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(ucWorkOrderInfoPopup_T01Entity pucWorkOrderInfoPopup_T01Entity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                };
                        break;

                }

                pDataParameters[0].Value = pucWorkOrderInfoPopup_T01Entity.CRUD;
                pDataParameters[1].Value = pucWorkOrderInfoPopup_T01Entity.WINDOW_NAME;
                pDataParameters[2].Value = pucWorkOrderInfoPopup_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SheetInfoRegister_R20", pDataParameters);


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
                    "Sheet_Info_sheet(SheetInfoRegisterEntity pSheetInfoRegisterEntity)",
                    pException
                );
            }
        }

        #endregion
    }

    public class ucWorkOrderInfoPopup_T03Provider : EntityManager<ucWorkOrderInfoPopup_T03Entity>
    {
        #region 생성자 - ucWorkOrderInfoPopup_T03Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucWorkOrderInfoPopup_T03Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucWorkOrderInfoPopup_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucWorkOrderInfoPopup_T03Entity pucWorkOrderInfoPopup_T03Entity = new ucWorkOrderInfoPopup_T03Entity();
                pucWorkOrderInfoPopup_T03Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucWorkOrderInfoPopup_T03Entity;
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

        #region 코드정보 조회하기 WorkOrderInfo_Return(string pCRUD, string pPLANORDER)

        public DataSet WorkOrderInfo_Return(ucWorkOrderInfoPopup_T03Entity _pWorkOrderInfoPopup_T03Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_order_number", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = _pWorkOrderInfoPopup_T03Entity.CRUD;
                pDataParameters[1].Value = _pWorkOrderInfoPopup_T03Entity.ORDER_NUMBER;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucWorkOrderInfoPopup_T03_R10", pDataParameters);
                return pDataTableSet;
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
                    "WorkOrderInfo_Return(string pCRUD, string pPARTCODE, string pPARTNAME, string PARTTYPE)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - WorkOrderInfo_Save(ucWorkOrderInfoPopup_T03Entity pucWorkOrderInfoPopup_T03Entity, DataTable pDataTable)


        public bool WorkOrderInfo_Save(ucWorkOrderInfoPopup_T03Entity pucWorkOrderInfoPopup_T03Entity, DataTable pDataTable)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction();
            
            try
            {
                if(pDataTable != null)
                {
                    pCount = pDataTable.Rows.Count;

                    for (int i = 0; i < pCount; i++)
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
                                    new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_production_order_date", MySqlDbType.VarChar, 8),
                                    new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 6),
                                    new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_production_order_qty", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1),
                                    new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParametersA = new IDataParameter[]
                                {
                                    new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                                    new SqlParameter("@v_production_order_date", SqlDbType.VarChar, 8),
                                    new SqlParameter("@v_production_order_seq", SqlDbType.VarChar, 6),
                                    new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_production_order_qty", SqlDbType.Decimal),
                                    new SqlParameter("@v_reference_id", SqlDbType.VarChar, 15),
                                    new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                                };
                                break;
                        }

                        pDataParametersA[0].Value = pucWorkOrderInfoPopup_T03Entity.CRUD;
                        pDataParametersA[1].Value = pucWorkOrderInfoPopup_T03Entity.USER_CODE;
                        pDataParametersA[2].Value = "";
                        pDataParametersA[3].Value = DateTime.Now.ToString("yyyyMMdd");
                        pDataParametersA[4].Value = "";
                        pDataParametersA[5].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                        pDataParametersA[6].Value = Convert.ToDecimal(pDataTable.Rows[i]["PRODUCTION_ORDER_QTY"].ToString());
                        pDataParametersA[7].Value = pucWorkOrderInfoPopup_T03Entity.REFERENCE_ID;
                        pDataParametersA[8].Value = "N";
                        pDataParametersA[9].Value = "Y";

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucWorkOrderinfoPopup_T03_I10", pDataParametersA);

                        pucWorkOrderInfoPopup_T03Entity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                        pucWorkOrderInfoPopup_T03Entity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                        pucWorkOrderInfoPopup_T03Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                        pucWorkOrderInfoPopup_T03Entity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                        pucWorkOrderInfoPopup_T03Entity.RTN_DATE = pDataTableA.Rows[0]["RTN_DATE"].ToString();
                        pucWorkOrderInfoPopup_T03Entity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

                        if (pDataTableA.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                    }
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
                    "WorkOrderInfo_Save(ucWorkOrderInfoPopup_T03Entity pucWorkOrderInfoPopup_T03Entity, DataTable pDataTable)",
                    pException
                );
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

    public class ResultStatusDataProvider : EntityManager<ResultStatusDataEntity>
    {
        #region 생성자 - ResultStatusDataProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ResultStatusDataProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ResultStatusDataEntity pResultStatusDataEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(ResultStatusDataEntity pResultStatusDataEntity)
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

                pDataParameters[0].Value = pResultStatusDataEntity.CRUD;
                pDataParameters[1].Value = pResultStatusDataEntity.DATE_FROM;
                pDataParameters[2].Value = pResultStatusDataEntity.DATE_TO;
                pDataParameters[3].Value = pResultStatusDataEntity.PART_NAME;
                pDataParameters[4].Value = pResultStatusDataEntity.VEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResultStatusData_R10", pDataParameters);

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
                    "Sample_Info_Mst(ResultStatusDataEntity pResultStatusDataEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)
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

                pDataParametersA[0].Value = pResultStatusDataEntity.CORP_CODE;
                pDataParametersA[1].Value = pResultStatusDataEntity.CRUD;
                pDataParametersA[2].Value = pResultStatusDataEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResultStatusData_I10", pDataParametersA);

                pResultStatusDataEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pResultStatusDataEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pResultStatusDataEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pResultStatusDataEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pResultStatusDataEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                    //        pDataParametersB[0].Value = pResultStatusDataEntity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pResultStatusDataEntity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pResultStatusDataEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pResultStatusDataEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pResultStatusDataEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pResultStatusDataEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pResultStatusDataEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 파일명 조회하기 - ResultStatusData_Info_Filename(ResultStatusDataEntity pResultStatusDataEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pResultStatusDataEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ResultStatusData_Info_Filename(ResultStatusDataEntity pResultStatusDataEntity)
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

                pDataParameters[0].Value = pResultStatusDataEntity.WINDOW_NAME;
                pDataParameters[1].Value = pResultStatusDataEntity.LANGUAGE_TYPE;

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
                    "ResultStatusData_Info_Filename(ResultStatusDataEntity pResultStatusDataEntity)",
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
        public object Templete_Download(ResultStatusDataEntity pResultStatusDataEntity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pResultStatusDataEntity.LANGUAGE_TYPE;

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
        public override ResultStatusDataEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ResultStatusDataEntity pResultStatusDataEntity = new ResultStatusDataEntity();

                pResultStatusDataEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pResultStatusDataEntity;
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
    public class ucProductionOrderInfoPopup_T04Provider : EntityManager<ucProductionOrderInfoPopup_T04_Entity>
    {
        #region 생성자 - ucProductionOrderInfoPopup_T04Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucProductionOrderInfoPopup_T04Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기

        public override ucProductionOrderInfoPopup_T04_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucProductionOrderInfoPopup_T04_Entity pucProductionOrderInfoPopup_T04_Entity = new ucProductionOrderInfoPopup_T04_Entity();
                pucProductionOrderInfoPopup_T04_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucProductionOrderInfoPopup_T04_Entity;
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

        #region ○ 수주정보 조회하기

        public DataSet pucProductionOrderInfoPopup_T04_Return(ucProductionOrderInfoPopup_T04_Entity pucProductionOrderInfoPopup_T04_Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucProductionOrderInfoPopup_T04_Entity.CRUD;
                pDataParameters[1].Value = pucProductionOrderInfoPopup_T04_Entity.DATE_FROM;
                pDataParameters[2].Value = pucProductionOrderInfoPopup_T04_Entity.DATE_TO;
                pDataParameters[3].Value = pucProductionOrderInfoPopup_T04_Entity.PART_CODE;
                pDataParameters[4].Value = pucProductionOrderInfoPopup_T04_Entity.PART_NAME;
                pDataParameters[5].Value = pucProductionOrderInfoPopup_T04_Entity.VEND_CODE;
                pDataParameters[6].Value = pucProductionOrderInfoPopup_T04_Entity.VEND_NAME;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucProductionOrderInfoPopup_T04_R10", pDataParameters);
                return pDataTableSet;
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
                    "ProductPlanInfo_Return(string pCRUD, string pPARTCODE, string pPARTNAME, string PARTTYPE)",
                    pException
                );
            }
        }

        #endregion
    }

    public class ucProductionOrderInfoPopup_T07Provider : EntityManager<ucProductionOrderInfoPopup_T07_Entity>
    {
        #region 생성자 - ucProductionOrderInfoPopup_T07Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucProductionOrderInfoPopup_T07Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기

        public override ucProductionOrderInfoPopup_T07_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucProductionOrderInfoPopup_T07_Entity pucProductionOrderInfoPopup_T07_Entity = new ucProductionOrderInfoPopup_T07_Entity();
                pucProductionOrderInfoPopup_T07_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucProductionOrderInfoPopup_T07_Entity;
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

        #region ○ 수주정보 조회하기

        public DataSet pucProductionOrderInfoPopup_T07_Return(ucProductionOrderInfoPopup_T07_Entity pucProductionOrderInfoPopup_T07_Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_contract_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_contract_number", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_order_number", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucProductionOrderInfoPopup_T07_Entity.CRUD;
                pDataParameters[1].Value = pucProductionOrderInfoPopup_T07_Entity.DATE_FROM;
                pDataParameters[2].Value = pucProductionOrderInfoPopup_T07_Entity.DATE_TO;
                pDataParameters[3].Value = pucProductionOrderInfoPopup_T07_Entity.CONTRACT_NUMBER;
                pDataParameters[4].Value = pucProductionOrderInfoPopup_T07_Entity.ORDER_NUMBER;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucProductionOrderInfoPopup_T07_R10", pDataParameters);
                return pDataTableSet;
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
                    "pucProductionOrderInfoPopup_T07_Return(ucProductionOrderInfoPopup_T07_Entity pucProductionOrderInfoPopup_T07_Entity)",
                    pException
                );
            }
        }

        #endregion
    }


    public class ResultStatusPlanResultProvider : EntityManager<ResultStatusPlanResultEntity>
    {
        #region 생성자 - ResultStatusPlanResultProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ResultStatusPlanResultProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)
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

                pDataParameters[0].Value = pResultStatusPlanResultEntity.CRUD;
                pDataParameters[1].Value = pResultStatusPlanResultEntity.DATE_FROM;
                pDataParameters[2].Value = pResultStatusPlanResultEntity.DATE_TO;
                pDataParameters[3].Value = pResultStatusPlanResultEntity.PART_NAME;
                pDataParameters[4].Value = pResultStatusPlanResultEntity.VEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResultStatusPlanResult_R10", pDataParameters);

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
                    "Sample_Info_Mst(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, DataTable dt)
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

                pDataParametersA[0].Value = pResultStatusPlanResultEntity.CORP_CODE;
                pDataParametersA[1].Value = pResultStatusPlanResultEntity.CRUD;
                pDataParametersA[2].Value = pResultStatusPlanResultEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResultStatusPlanResult_I10", pDataParametersA);

                pResultStatusPlanResultEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pResultStatusPlanResultEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pResultStatusPlanResultEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pResultStatusPlanResultEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pResultStatusPlanResultEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                    //        pDataParametersB[0].Value = pResultStatusPlanResultEntity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pResultStatusPlanResultEntity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pResultStatusPlanResultEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pResultStatusPlanResultEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pResultStatusPlanResultEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pResultStatusPlanResultEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pResultStatusPlanResultEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 파일명 조회하기 - ResultStatusPlanResult_Info_Filename(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pResultStatusPlanResultEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ResultStatusPlanResult_Info_Filename(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)
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

                pDataParameters[0].Value = pResultStatusPlanResultEntity.WINDOW_NAME;
                pDataParameters[1].Value = pResultStatusPlanResultEntity.LANGUAGE_TYPE;

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
                    "ResultStatusPlanResult_Info_Filename(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)",
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
        public object Templete_Download(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pResultStatusPlanResultEntity.LANGUAGE_TYPE;

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
        public override ResultStatusPlanResultEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ResultStatusPlanResultEntity pResultStatusPlanResultEntity = new ResultStatusPlanResultEntity();

                pResultStatusPlanResultEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pResultStatusPlanResultEntity;
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

    public class ProductPlanMonthStatusProvider : EntityManager<ProductPlanMonthStatusEntity>
    {
        #region 생성자 - ProductPlanMonthStatusProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductPlanMonthStatusProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(ProductPlanMonthStatusEntity pProductPlanMonthStatusEntity)
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

                pDataParameters[0].Value = pProductPlanMonthStatusEntity.CRUD;
                pDataParameters[1].Value = pProductPlanMonthStatusEntity.DATE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResultStatusPlanResult_R10", pDataParameters);

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
                    "Sample_Info_Mst(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)",
                    pException
                );
            }
        }

        #endregion

      
        #region 파일명 조회하기 - ResultStatusPlanResult_Info_Filename(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pResultStatusPlanResultEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductPlanMonthStatus_Info_Filename(ProductPlanMonthStatusEntity pProductPlanMonthStatusEntity)
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

                pDataParameters[0].Value = pProductPlanMonthStatusEntity.WINDOW_NAME;
                pDataParameters[1].Value = pProductPlanMonthStatusEntity.LANGUAGE_TYPE;

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
                    "ResultStatusPlanResult_Info_Filename(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)",
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
        public object Templete_Download(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pResultStatusPlanResultEntity.LANGUAGE_TYPE;

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
        public override ProductPlanMonthStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductPlanMonthStatusEntity pResultStatusPlanResultEntity = new ProductPlanMonthStatusEntity();

                pResultStatusPlanResultEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pResultStatusPlanResultEntity;
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


    public class ProductTimeMonthLiveProvider : EntityManager<ProductTimeMonthLiveEntity>
    {
        #region 생성자 - ProductTimeMonthLiveProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductTimeMonthLiveProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity)
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

                pDataParameters[0].Value = pProductTimeMonthLiveEntity.CRUD;
                pDataParameters[1].Value = pProductTimeMonthLiveEntity.DATE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResultStatusPlanResult_R10", pDataParameters);

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
                    "Sample_Info_Mst(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 파일명 조회하기 - ProductTimeMonthLive_Info_Filename(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pResultStatusPlanResultEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductTimeMonthLive_Info_Filename(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity)
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

                pDataParameters[0].Value = pProductTimeMonthLiveEntity.WINDOW_NAME;
                pDataParameters[1].Value = pProductTimeMonthLiveEntity.LANGUAGE_TYPE;

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
                    "ResultStatusPlanResult_Info_Filename(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)",
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
        public object Templete_Download(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pProductTimeMonthLiveEntity.LANGUAGE_TYPE;

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
        public override ProductTimeMonthLiveEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity = new ProductTimeMonthLiveEntity();

                pProductTimeMonthLiveEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProductTimeMonthLiveEntity;
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

    public class ProductResultPlanStatusProvider : EntityManager<ProductResultPlanStatusEntity>
    {
        #region 생성자 - ProductResultPlanStatusProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductResultPlanStatusProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ProductResultPlanStatusEntity pProductResultPlanStatusEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(ProductResultPlanStatusEntity pProductResultPlanStatusEntity)
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

                pDataParameters[0].Value = pProductResultPlanStatusEntity.CRUD;
                pDataParameters[1].Value = pProductResultPlanStatusEntity.DATE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResultStatusPlanResult_R10", pDataParameters);

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
                    "Sample_Info_Mst(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 파일명 조회하기 - ProductResultPlanStatus_Info_Filename(ProductResultPlanStatusEntity pProductResultPlanStatusEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pResultStatusPlanResultEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductResultPlanStatus_Info_Filename(ProductResultPlanStatusEntity pProductResultPlanStatusEntity)
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

                pDataParameters[0].Value = pProductResultPlanStatusEntity.WINDOW_NAME;
                pDataParameters[1].Value = pProductResultPlanStatusEntity.LANGUAGE_TYPE;

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
                    "ResultStatusPlanResult_Info_Filename(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)",
                    pException
                );
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ProductResultPlanStatusEntity pProductResultPlanStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object Templete_Download(ProductResultPlanStatusEntity pProductResultPlanStatusEntity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pProductResultPlanStatusEntity.LANGUAGE_TYPE;

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
        public override ProductResultPlanStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductResultPlanStatusEntity pProductResultPlanStatusEntity = new ProductResultPlanStatusEntity();

                pProductResultPlanStatusEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProductResultPlanStatusEntity;
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


    public class ResultStatusProductProvider : EntityManager<ResultStatusProductEntity>
    {
        #region 생성자 - ResultStatusProductProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ResultStatusProductProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ResultStatusProductEntity pResultStatusProductEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(ResultStatusProductEntity pResultStatusProductEntity)
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

                pDataParameters[0].Value = pResultStatusProductEntity.CRUD;
                pDataParameters[1].Value = pResultStatusProductEntity.DATE_FROM;
                pDataParameters[2].Value = pResultStatusProductEntity.DATE_TO;
                pDataParameters[3].Value = pResultStatusProductEntity.PART_NAME;
                pDataParameters[4].Value = pResultStatusProductEntity.VEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResultStatusProduct_R10", pDataParameters);

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
                    "Sample_Info_Mst(ResultStatusProductEntity pResultStatusProductEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(ResultStatusProductEntity pResultStatusProductEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(ResultStatusProductEntity pResultStatusProductEntity, DataTable dt)
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

                pDataParametersA[0].Value = pResultStatusProductEntity.CORP_CODE;
                pDataParametersA[1].Value = pResultStatusProductEntity.CRUD;
                pDataParametersA[2].Value = pResultStatusProductEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResultStatusProduct_I10", pDataParametersA);

                pResultStatusProductEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pResultStatusProductEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pResultStatusProductEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pResultStatusProductEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pResultStatusProductEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                    //        pDataParametersB[0].Value = pResultStatusProductEntity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pResultStatusProductEntity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pResultStatusProductEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pResultStatusProductEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pResultStatusProductEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pResultStatusProductEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pResultStatusProductEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(ResultStatusProductEntity pResultStatusProductEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 파일명 조회하기 - ResultStatusProduct_Info_Filename(ResultStatusProductEntity pResultStatusProductEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pResultStatusProductEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ResultStatusProduct_Info_Filename(ResultStatusProductEntity pResultStatusProductEntity)
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

                pDataParameters[0].Value = pResultStatusProductEntity.WINDOW_NAME;
                pDataParameters[1].Value = pResultStatusProductEntity.LANGUAGE_TYPE;

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
                    "ResultStatusProduct_Info_Filename(ResultStatusProductEntity pResultStatusProductEntity)",
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
        public object Templete_Download(ResultStatusProductEntity pResultStatusProductEntity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pResultStatusProductEntity.LANGUAGE_TYPE;

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
        public override ResultStatusProductEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ResultStatusProductEntity pResultStatusProductEntity = new ResultStatusProductEntity();

                pResultStatusProductEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pResultStatusProductEntity;
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

    public class ContractMstRegisterProvider : EntityManager<ContractMstRegisterEntity>
    {
        #region ○ 생성자

        public ContractMstRegisterProvider(DBManager pDBManager)
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
        public override ContractMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ContractMstRegisterEntity pContractMstRegisterEntity = new ContractMstRegisterEntity();

                pContractMstRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pContractMstRegisterEntity;
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

        public DataTable ContractMstRegister_Info_Mst(ContractMstRegisterEntity ppContractMstRegisterEntity)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


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
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = ppContractMstRegisterEntity.CRUD;
                pDataParameters[1].Value = ppContractMstRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = ppContractMstRegisterEntity.DATE_TO;
                pDataParameters[3].Value = ppContractMstRegisterEntity.CONTRACT_ID;
                pDataParameters[4].Value = ppContractMstRegisterEntity.PART_CODE;
                pDataParameters[5].Value = ppContractMstRegisterEntity.PART_NAME;
                pDataParameters[6].Value = ppContractMstRegisterEntity.VEND_CODE;
                pDataParameters[7].Value = ppContractMstRegisterEntity.VEND_NAME;
                pDataParameters[8].Value = ppContractMstRegisterEntity.USE_YN;
                pDataParameters[9].Value = ppContractMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ContractMstRegister_R10", pDataParameters);
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
                    "ContractMstRegister_Info_Mst(ContractMstRegisterEntity ppContractMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장

        public bool ContractMstRegister_Save(ContractMstRegisterEntity pContractMstRegisterEntity)
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
                
                pDataParameters[0].Value = pContractMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pContractMstRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pContractMstRegisterEntity.CONTRACT_ID;
                pDataParameters[3].Value = pContractMstRegisterEntity.CONTRACT_DATE;
                pDataParameters[4].Value = pContractMstRegisterEntity.PART_CODE;
                pDataParameters[5].Value = pContractMstRegisterEntity.VEND_CODE;
                pDataParameters[6].Value = pContractMstRegisterEntity.CONTRACT_QTY;
                pDataParameters[7].Value = pContractMstRegisterEntity.DELIVERY_DATE;
                pDataParameters[8].Value = pContractMstRegisterEntity.DELIVERY_LOCATION;
                pDataParameters[9].Value = pContractMstRegisterEntity.UNITCOST;
                pDataParameters[10].Value = pContractMstRegisterEntity.COST;
                pDataParameters[11].Value = pContractMstRegisterEntity.REMARK;
                pDataParameters[12].Value = pContractMstRegisterEntity.USE_YN;
                //pDataParameters[13].Value = pContractMstRegisterEntity.UNIT_CODE;
                
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ContractMstRegister_I10", pDataParameters);

                pContractMstRegisterEntity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                pContractMstRegisterEntity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                pContractMstRegisterEntity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                pContractMstRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                pContractMstRegisterEntity.RTN_AQ = pDataTable.Rows[0]["rtn_aq"].ToString();
                pContractMstRegisterEntity.RTN_SQ = pDataTable.Rows[0]["rtn_sq"].ToString();
                pContractMstRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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

        #region ○ 수주 수정 시, 해당 수주번호로 내려진 생산계획이 있는지 조회 - Sample_Check_Next_Process(ContractMstRegisterEntity pContractMstRegisterEntity)

        public DataTable Sample_Check_Next_Process(ContractMstRegisterEntity pContractMstRegisterEntity)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


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
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pContractMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pContractMstRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pContractMstRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pContractMstRegisterEntity.CONTRACT_ID;
                pDataParameters[4].Value = pContractMstRegisterEntity.PART_CODE;
                pDataParameters[5].Value = pContractMstRegisterEntity.PART_NAME;
                pDataParameters[6].Value = pContractMstRegisterEntity.USE_YN;
                pDataParameters[7].Value = pContractMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_R10", pDataParameters);
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
                    "Sample_Check_Next_Process(ContractMstRegisterEntity pContractMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

    }

    public class ContractMstRegister_T01Provider : EntityManager<ContractMstRegister_T01Entity>
    {
        #region ○ 생성자

        public ContractMstRegister_T01Provider(DBManager pDBManager)
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
        public override ContractMstRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ContractMstRegister_T01Entity pContractMstRegister_T01Entity = new ContractMstRegister_T01Entity();

                pContractMstRegister_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pContractMstRegister_T01Entity;
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

        #region ○ 데이터 조회_SUB

        public DataTable ContractMstRegister_Info_Sub(ContractMstRegister_T01Entity ppContractMstRegister_T01Entity)
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
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_contract_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_order_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = ppContractMstRegister_T01Entity.CRUD;
                pDataParameters[1].Value = ppContractMstRegister_T01Entity.DATE_FROM;
                pDataParameters[2].Value = ppContractMstRegister_T01Entity.DATE_TO;
                pDataParameters[3].Value = ppContractMstRegister_T01Entity.CONTRACT_ID;
                pDataParameters[4].Value = ppContractMstRegister_T01Entity.CONTRACT_NUMBER;
                pDataParameters[5].Value = ppContractMstRegister_T01Entity.USE_YN;
                pDataParameters[6].Value = ppContractMstRegister_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ContractMstRegister_T01_R11", pDataParameters);
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
                    "ContractMstRegister_Info_detail(ContractMstRegister_T01Entity ppContractMstRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 조회_MAIN

        public DataTable ContractMstRegister_Info_Mst(ContractMstRegister_T01Entity ppContractMstRegister_T01Entity)
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
                            new MySqlParameter("@v_contract_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_contract_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_contract_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = ppContractMstRegister_T01Entity.CRUD;
                pDataParameters[1].Value = ppContractMstRegister_T01Entity.DATE_FROM;
                pDataParameters[2].Value = ppContractMstRegister_T01Entity.DATE_TO;
                pDataParameters[3].Value = ppContractMstRegister_T01Entity.CONTRACT_ID;
                pDataParameters[4].Value = ppContractMstRegister_T01Entity.CONTRACT_NUMBER;
                pDataParameters[5].Value = ppContractMstRegister_T01Entity.VEND_CODE;
                pDataParameters[6].Value = ppContractMstRegister_T01Entity.USE_YN;
                pDataParameters[7].Value = ppContractMstRegister_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ContractMstRegister_T01_R10", pDataParameters);
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
                    "ContractMstRegister_Info_Mst(ContractMstRegister_T01Entity ppContractMstRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장

        public bool ContractMstRegister_Save(ContractMstRegister_T01Entity pContractMstRegister_T01Entity,DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction();
            try
            {
                if (dt != null)
                {

                    pCount = dt.Rows.Count;

                    for (int i = 0; i < pCount; i++)
                    {
                        IDataParameter[] pDataParameters = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters = new IDataParameter[]
                                {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_contract_id", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_contract_number", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_contract_revision", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_contract_name", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_contract_date", MySqlDbType.VarChar,8),
                                new MySqlParameter("@v_contract_seq", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_vend_code", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_delivery_date", MySqlDbType.VarChar,8),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_contract_id", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_contract_number", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_contract_revision", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_contract_name", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_contract_date", SqlDbType.NVarChar,8),
                                new SqlParameter("@v_contract_seq", SqlDbType.NVarChar,8),
                                new SqlParameter("@v_vend_code", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_delivery_date", SqlDbType.NVarChar,8),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar,8),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[i]["CRUD"].ToString();
                        pDataParameters[1].Value = pContractMstRegister_T01Entity.USER_CODE;
                        pDataParameters[2].Value = dt.Rows[i]["CONTRACT_ID"].ToString();
                        pDataParameters[3].Value = dt.Rows[i]["CONTRACT_NUMBER"].ToString();
                        pDataParameters[4].Value = dt.Rows[i]["CONTRACT_REVISION"].ToString();
                        pDataParameters[5].Value = dt.Rows[i]["CONTRACT_NAME"].ToString();
                        //pDataParameters[5].Value = pContractMstRegister_T01Entity.CONTRACT_DATE;
                        if (dt.Rows[i]["CONTRACT_DATE"].ToString().Length > 8)
                        {
                            pDataParameters[6].Value = dt.Rows[i]["CONTRACT_DATE"].ToString().Substring(0, 10).Replace("-", "").ToString();
                        }
                        else
                        {
                            pDataParameters[6].Value = dt.Rows[i]["CONTRACT_DATE"].ToString();
                        }
                        pDataParameters[7].Value = "" ;
                        pDataParameters[8].Value = dt.Rows[i]["VEND_CODE"].ToString();
                        //pDataParameters[8].Value = pContractMstRegister_T01Entity.DELIVERY_DATE;
                        if (dt.Rows[i]["DELIVERY_DATE"].ToString().Length > 8)
                        {
                            pDataParameters[9].Value = dt.Rows[i]["DELIVERY_DATE"].ToString().Substring(0, 10).Replace("-", "").ToString();
                        }
                        else
                        {
                            pDataParameters[9].Value = dt.Rows[i]["DELIVERY_DATE"].ToString();
                        }

                        pDataParameters[10].Value = dt.Rows[i]["REMARK"].ToString();
                        pDataParameters[11].Value = dt.Rows[i]["USE_YN"].ToString();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ContractMstRegister_T01_I10", pDataParameters);

                        pContractMstRegister_T01Entity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                        pContractMstRegister_T01Entity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                        pContractMstRegister_T01Entity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                        pContractMstRegister_T01Entity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                        pContractMstRegister_T01Entity.RTN_AQ = pDataTable.Rows[0]["rtn_aq"].ToString();
                        pContractMstRegister_T01Entity.RTN_SQ = pDataTable.Rows[0]["rtn_sq"].ToString();

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                    }
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

    public class ucContractDocumentListPopupProvider : EntityManager<ucContractDocumentListPopupEntity>
    {
        #region 생성자 - ucContractDocumentListPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucContractDocumentListPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 메인 조회하기 ucContractDocumentListPopup_Info_Main(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)
        public DataTable ucContractDocumentListPopup_Info_Main(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)
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
                            new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_contract_revision", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_contract_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_contract_revision", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)


                };
                        break;
                }

                pDataParameters[0].Value = pucContractDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucContractDocumentListPopupEntity.CONTRACT_ID;
                pDataParameters[2].Value = pucContractDocumentListPopupEntity.CONTRACT_REVISION;
                pDataParameters[3].Value = pucContractDocumentListPopupEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucContractDocumentListPopup_R10", pDataParameters);
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
                    "ucContractDocumentListPopup_Info_Main(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 uContractDocumentListPopup_Info_Sub(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)

        public DataTable uContractDocumentListPopup_Info_Sub(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)
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
                            new MySqlParameter("@v_document_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_document_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_document_ver", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_contract_number", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_contract_revision", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_document_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_document_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_document_ver", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_contract_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_contract_number", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_contract_revision", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pucContractDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucContractDocumentListPopupEntity.DOCUMENT_TYPE;
                pDataParameters[2].Value = pucContractDocumentListPopupEntity.DOCUMENT_NAME;
                pDataParameters[3].Value = pucContractDocumentListPopupEntity.DOCUMENT_VER;

                pDataParameters[4].Value = pucContractDocumentListPopupEntity.CONTRACT_ID;
                pDataParameters[5].Value = pucContractDocumentListPopupEntity.CONTRACT_NUMBER;
                pDataParameters[6].Value = pucContractDocumentListPopupEntity.CONTRACT_REVISION;
                pDataParameters[7].Value = pucContractDocumentListPopupEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucContractDocumentListPopup_R20", pDataParameters);
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
                    "uContractDocumentListPopup_Info_Sub(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ucContractDocumentListPopup_Info_Save(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity, DataTable pDataTable)
        public bool ucContractDocumentListPopup_Info_Save(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity, DataTable pDataTable)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction();

            try
            {
                if (pDataTable != null)
                {
                    pCount = pDataTable.Rows.Count;

                    for (int a = 0; a < pCount; a++)
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
                                        new MySqlParameter("@v_contract_number", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_contract_revision", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_document_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_document_type", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_contract_id", SqlDbType.NVarChar, 15),
                                        new SqlParameter("@v_contract_number", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_contract_revision", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_document_id", SqlDbType.NVarChar, 15),
                                        new SqlParameter("@v_document_type", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                };
                                break;

                        }

                        pDataParameters[0].Value = pDataTable.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pucContractDocumentListPopupEntity.USER_CODE;

                        pDataParameters[2].Value = pucContractDocumentListPopupEntity.CONTRACT_ID;
                        pDataParameters[3].Value = pucContractDocumentListPopupEntity.CONTRACT_NUMBER;
                        pDataParameters[4].Value = pucContractDocumentListPopupEntity.CONTRACT_REVISION;
                        pDataParameters[5].Value = pDataTable.Rows[a]["DOCUMENT_ID"].ToString();
                        pDataParameters[6].Value = pDataTable.Rows[a]["DOCUMENT_TYPE"].ToString();
                        pDataParameters[7].Value = pDataTable.Rows[a]["REMARK"].ToString();
                        pDataParameters[8].Value = pDataTable.Rows[a]["USE_YN"].ToString().ToUpper() == "" ? "Y" : pDataTable.Rows[a]["USE_YN"].ToString().ToUpper();

                        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucContractDocumentListPopup_I10", pDataParameters);

                        if (pDataTableB.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pucContractDocumentListPopupEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                        pucContractDocumentListPopupEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();

                    }
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
                    "ucContractDocumentListPopup_Info_Save(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity, DataTable pDataTable)",
                    pException
                );
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

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucContractDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity = new ucContractDocumentListPopupEntity();
                pucContractDocumentListPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucContractDocumentListPopupEntity;
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

    public class ucOrderNumberInfoPopup_Provider : EntityManager<ucOrderNumberInfoPopup_Entity>
    {
        #region ○ 생성자

        public ucOrderNumberInfoPopup_Provider(DBManager pDBManager)
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
        public override ucOrderNumberInfoPopup_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucOrderNumberInfoPopup_Entity pOrderNumberInfoPopup_Entity = new ucOrderNumberInfoPopup_Entity();

                pOrderNumberInfoPopup_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pOrderNumberInfoPopup_Entity;
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

        #region ○ 데이터 조회_MAIN

        public DataTable ContractMstRegister_Info_Mst(ucOrderNumberInfoPopup_Entity pOrderNumberInfoPopup_Entity)
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
                            new MySqlParameter("@v_contract_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_contract_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_code", SqlDbType.VarChar,50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),

                        };
                        break;
                }

                pDataParameters[0].Value = pOrderNumberInfoPopup_Entity.CRUD;
                pDataParameters[1].Value = pOrderNumberInfoPopup_Entity.CONTRACT_NUMBER;
                pDataParameters[2].Value = pOrderNumberInfoPopup_Entity.VEND_CODE;
                pDataParameters[3].Value = pOrderNumberInfoPopup_Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucOrderNumberInfoPopup_R10", pDataParameters);
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
                    "ContractMstRegister_Info_Mst(ucOrderNumberInfoPopup_Entity pOrderNumberInfoPopup_Entity)",
                    pException
                );
            }
        }

        #endregion

        public bool ContractMstRegister_Save(ucOrderNumberInfoPopup_Entity pOrderNumberInfoPopup_Entity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction();
            try
            {
                IDataParameter[] pDataParameters = null;

                if (dt != null)
                {

                    pCount = dt.Rows.Count;

                    for (int i = 0; i < pCount; i++)
                    {
                        IDataParameter[] pDataParameters2 = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters2 = new IDataParameter[]
                                {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_order_number",MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_contract_date", MySqlDbType.VarChar, 8),
                                        new MySqlParameter("@v_contract_seq", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_contract_qty", MySqlDbType.Decimal),
                                        new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_delivery_date", MySqlDbType.VarChar, 8),
                                        new MySqlParameter("@v_unitcost", MySqlDbType.Decimal),
                                        new MySqlParameter("@v_cost", MySqlDbType.Decimal),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                                };
                                break;

                            case "SQLServer":
                                pDataParameters2 = new IDataParameter[]
                                {
                                        new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_order_number", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_contract_id", SqlDbType.VarChar, 15),
                                        new SqlParameter("@v_contract_date", SqlDbType.VarChar, 8),
                                        new SqlParameter("@v_contract_seq", SqlDbType.VarChar, 15),
                                        new SqlParameter("@v_contract_qty", SqlDbType.Decimal),
                                        new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_delivery_date", SqlDbType.VarChar, 8),
                                        new SqlParameter("@v_unitcost", SqlDbType.Decimal),
                                        new SqlParameter("@v_cost", SqlDbType.Decimal),
                                        new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                                };
                                break;
                        }

                        pDataParameters2[0].Value = "C";
                        pDataParameters2[1].Value = pOrderNumberInfoPopup_Entity.USER_CODE;
                        pDataParameters2[2].Value = pOrderNumberInfoPopup_Entity.CONTRACT_NUMBER;
                        pDataParameters2[3].Value = dt.Rows[i]["CONTRACT_ID"].ToString();
                        if (dt.Rows[i]["CONTRACT_DATE"].ToString().Length > 8)
                        {
                            pDataParameters2[4].Value = dt.Rows[i]["CONTRACT_DATE"].ToString().Substring(0, 10).Replace("-", "").ToString();
                        }
                        else
                        {
                            pDataParameters2[4].Value = dt.Rows[i]["CONTRACT_DATE"].ToString();
                        }
                        if (dt.Rows[i]["CONTRACT_SEQ"].ToString().Equals(""))
                        {
                            pDataParameters2[5].Value = "";
                        }
                        else
                        {
                            pDataParameters2[5].Value = dt.Rows[i]["CONTRACT_SEQ"].ToString();
                        }
                        pDataParameters2[6].Value = Convert.ToDecimal(dt.Rows[i]["CONTRACT_QTY"].ToString());
                        pDataParameters2[7].Value = dt.Rows[i]["PART_CODE"].ToString();
                        if (dt.Rows[i]["DELIVERY_DATE"].ToString().Length > 8)
                        {
                            pDataParameters2[8].Value = dt.Rows[i]["DELIVERY_DATE"].ToString().Substring(0, 10).Replace("-", "").ToString();
                        }
                        else
                        {
                            pDataParameters2[8].Value = dt.Rows[i]["DELIVERY_DATE"].ToString();
                        }
                        pDataParameters2[9].Value = Convert.ToDecimal(dt.Rows[i]["UNITCOST"].ToString());
                        pDataParameters2[10].Value = Convert.ToDecimal(dt.Rows[i]["COST"].ToString());

                        pDataParameters2[11].Value = dt.Rows[i]["REMARK"].ToString();
                        pDataParameters2[12].Value = dt.Rows[i]["USE_YN"].ToString();

                        DataTable pDataTable2 = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ContractMstRegister_T01_I11", pDataParameters2);

                        pOrderNumberInfoPopup_Entity.ERR_NO = pDataTable2.Rows[0]["err_no"].ToString();
                        pOrderNumberInfoPopup_Entity.ERR_MSG = pDataTable2.Rows[0]["err_msg"].ToString();
                        pOrderNumberInfoPopup_Entity.RTN_KEY = pDataTable2.Rows[0]["rtn_key"].ToString();
                        pOrderNumberInfoPopup_Entity.RTN_SEQ = pDataTable2.Rows[0]["rtn_seq"].ToString();
                        pOrderNumberInfoPopup_Entity.RTN_AQ = pDataTable2.Rows[0]["rtn_aq"].ToString();
                        pOrderNumberInfoPopup_Entity.RTN_SQ = pDataTable2.Rows[0]["rtn_sq"].ToString();

                        if (pDataTable2.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {

                        }
                    }
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
    }

    public class ProductPlanRegisterProvider : EntityManager<ProductPlanRegisterEntity>
    {
        public ProductPlanRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #region ○ 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ProductPlanRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductPlanRegisterEntity pContractMstRegisterEntity = new ProductPlanRegisterEntity();

                pContractMstRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pContractMstRegisterEntity;
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

        public DataTable ProductPlanRegister_Info_Mst(ProductPlanRegisterEntity pProductPlanRegisterEntity)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


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
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductPlanRegisterEntity.CRUD;
                pDataParameters[1].Value = pProductPlanRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pProductPlanRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pProductPlanRegisterEntity.CONTRACT_ID;
                pDataParameters[4].Value = pProductPlanRegisterEntity.PART_CODE;
                pDataParameters[5].Value = pProductPlanRegisterEntity.PART_NAME;
                pDataParameters[6].Value = pProductPlanRegisterEntity.USE_YN;
                pDataParameters[7].Value = pProductPlanRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_R10", pDataParameters);
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
                    "ProductPlanRegister_Info_Mst(ProductPlanRegisterEntity pProductPlanRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장



        #endregion

        #region ○ 데이터 삭제

        public DataTable ProductPlanRegister_del(ProductPlanRegisterEntity pProductPlanRegisterEntity)
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
                            new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_production_plan_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),

                        };
                        break;
                }

                pDataParameters[0].Value = pProductPlanRegisterEntity.CRUD;
                pDataParameters[1].Value = pProductPlanRegisterEntity.production_plan_id;
                pDataParameters[2].Value = pProductPlanRegisterEntity.USE_YN;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_I01", pDataParameters);
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
                    "ProductPlanRegister_Info_Mst(ProductPlanRegisterEntity pProductPlanRegisterEntity)",
                    pException
                );
            }
        }

        #endregion
    }

    public class ProductPlanRegister_T01Provider : EntityManager<ProductPlanRegister_T01Entity>
    {
        public ProductPlanRegister_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #region ○ 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ProductPlanRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductPlanRegister_T01Entity pContractMstRegisterEntity = new ProductPlanRegister_T01Entity();

                pContractMstRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pContractMstRegisterEntity;
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

        public DataTable ProductPlanRegister_T01_Info_Mst(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                           , new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar, 50)

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
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                           , new SqlParameter("@v_production_plan_id", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductPlanRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pProductPlanRegister_T01Entity.DATE_FROM;
                pDataParameters[2].Value = pProductPlanRegister_T01Entity.DATE_TO;
                pDataParameters[3].Value = pProductPlanRegister_T01Entity.CONTRACT_ID;
                pDataParameters[4].Value = pProductPlanRegister_T01Entity.PART_CODE;
                pDataParameters[5].Value = pProductPlanRegister_T01Entity.PART_NAME;
                pDataParameters[6].Value = pProductPlanRegister_T01Entity.USE_YN;
                pDataParameters[7].Value = pProductPlanRegister_T01Entity.LANGUAGE_TYPE;

                pDataParameters[8].Value = pProductPlanRegister_T01Entity.production_plan_id;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_T01_R10", pDataParameters);
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
                    "ProductPlanRegister_T01_Info_Mst(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장



        #endregion

        #region ○ 데이터 삭제

        public DataTable ProductPlanRegister_T01_del(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)
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
                            new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_production_plan_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),

                        };
                        break;
                }

                pDataParameters[0].Value = pProductPlanRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pProductPlanRegister_T01Entity.production_plan_id;
                pDataParameters[2].Value = pProductPlanRegister_T01Entity.USE_YN;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_T01_I01", pDataParameters);
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
                    "ProductPlanRegister_T01_Info_Mst(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 작업지시 조회  - Sample_Check_Next_Process(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)
        /// <summary>
        /// 생산계획 수정 시, 해당 생산계획 번호로 이미 등록된 작업지시가 있는지 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>     

        public DataTable Sample_Check_Next_Process(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_plan_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_workcenter_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_plan_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_workcenter_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                //pDataParameters[0].Value = pProductPlanRegister_T01Entity.CORP_CODE;
                pDataParameters[0].Value = pProductPlanRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pProductPlanRegister_T01Entity.DATE_FROM;
                pDataParameters[2].Value = pProductPlanRegister_T01Entity.DATE_TO;
                pDataParameters[3].Value = pProductPlanRegister_T01Entity.ORDER_CODE;
                pDataParameters[4].Value = pProductPlanRegister_T01Entity.PART_CODE;
                pDataParameters[5].Value = pProductPlanRegister_T01Entity.PART_NAME;
                pDataParameters[6].Value = pProductPlanRegister_T01Entity.REFERENCE_ID;
                pDataParameters[7].Value = pProductPlanRegister_T01Entity.PROCESS_CODE;
                pDataParameters[8].Value = pProductPlanRegister_T01Entity.USE_YN;
                pDataParameters[9].Value = pProductPlanRegister_T01Entity.WORKCENTER_CODE;
                pDataParameters[10].Value = pProductPlanRegister_T01Entity.COMPLETE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T03_R10", pDataParameters);

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
                    "Sample_Check_Next_Process(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion        



        
    }

    public class ProductPlanRegister_T02Provider : EntityManager<ProductPlanRegister_T02Entity>
    {
        public ProductPlanRegister_T02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #region ○ 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ProductPlanRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductPlanRegister_T02Entity pContractMstRegister_T02Entity = new ProductPlanRegister_T02Entity();

                pContractMstRegister_T02Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pContractMstRegister_T02Entity;
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

        public DataTable ProductPlanRegister_Info_Mst(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)
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
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_order_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_order_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_order_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_reference_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductPlanRegister_T02Entity.CRUD;
                pDataParameters[1].Value = pProductPlanRegister_T02Entity.DATE_FROM;
                pDataParameters[2].Value = pProductPlanRegister_T02Entity.DATE_TO;
                pDataParameters[3].Value = pProductPlanRegister_T02Entity.ORDER_NUMBER;
                pDataParameters[4].Value = pProductPlanRegister_T02Entity.ORDER_NAME;
                pDataParameters[5].Value = pProductPlanRegister_T02Entity.CONTRACT_NUMBER;
                pDataParameters[6].Value = pProductPlanRegister_T02Entity.USE_YN;
                pDataParameters[7].Value = pProductPlanRegister_T02Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_T02_R10", pDataParameters);
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
                    "ProductPlanRegister_Info_Mst(ProductPlanRegisterEntity pProductPlanRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 서브 데이터 조회

        public DataTable ProductPlanRegister_Info_Sub(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)
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
                            new MySqlParameter("@v_contract_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_contract_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_order_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductPlanRegister_T02Entity.CRUD;
                pDataParameters[1].Value = pProductPlanRegister_T02Entity.CONTRACT_NUMBER;
                pDataParameters[2].Value = pProductPlanRegister_T02Entity.ORDER_NUMBER;
                pDataParameters[3].Value = pProductPlanRegister_T02Entity.USE_YN;
                pDataParameters[4].Value = pProductPlanRegister_T02Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_T02_R11", pDataParameters);
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
                    "DataTable ProductPlanRegister_Info_Sub(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 품목데이터 조회
        public DataTable ProductPlanRegister_Info_detail(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)
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
                            new MySqlParameter("@v_contract_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)                                
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_contract_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_order_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductPlanRegister_T02Entity.CRUD;
                pDataParameters[1].Value = pProductPlanRegister_T02Entity.CONTRACT_NUMBER;
                pDataParameters[2].Value = pProductPlanRegister_T02Entity.ORDER_NUMBER;
                pDataParameters[3].Value = pProductPlanRegister_T02Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucOrderNumberInfoPopup_R10", pDataParameters);
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
                    "ProductPlanRegister_Info_detail(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)",
                    pException
                );
            }
        }
        #endregion

        #region ○ 데이터 저장

        public bool ProductPlanRegister_Save_Mst(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity, DataTable dt)
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

                                new MySqlParameter("@v_crud                  ".Trim(), MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code             ".Trim(), MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_production_plan_id    ".Trim(), MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_production_plan_date  ".Trim(), MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_order_number          ".Trim(), MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_order_name            ".Trim(), MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_order_option           ".Trim(), MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_order_revision        ".Trim(), MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_reference_id          ".Trim(), MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark                ".Trim(), MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn                ".Trim(), MySqlDbType.VarChar, 1),

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {

                                new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                new SqlParameter("@v_production_plan_id    ".Trim(), SqlDbType.VarChar, 50),
                                new SqlParameter("@v_production_plan_date  ".Trim(), SqlDbType.VarChar, 8),
                                new SqlParameter("@v_order_number          ".Trim(), SqlDbType.VarChar, 50),
                                new SqlParameter("@v_order_name            ".Trim(), SqlDbType.VarChar, 50),
                                new SqlParameter("@v_order_option           ".Trim(), SqlDbType.VarChar, 50),
                                new SqlParameter("@v_order_revision        ".Trim(), SqlDbType.VarChar, 50),
                                new SqlParameter("@v_reference_id          ".Trim(), SqlDbType.VarChar, 50),
                                new SqlParameter("@v_remark                ".Trim(), SqlDbType.VarChar, 1000),
                                new SqlParameter("@v_use_yn                ".Trim(), SqlDbType.VarChar, 1),

                        };
                        break;
                }
                pDataParametersA[0].Value = pProductPlanRegister_T02Entity.CRUD;
                pDataParametersA[1].Value = pProductPlanRegister_T02Entity.USER_CODE;
                pDataParametersA[2].Value = pProductPlanRegister_T02Entity.PRODUCTION_PLAN_ID;
                pDataParametersA[3].Value = pProductPlanRegister_T02Entity.PRODUCTION_PLAN_DATE;
                pDataParametersA[4].Value = pProductPlanRegister_T02Entity.ORDER_NUMBER;
                pDataParametersA[5].Value = pProductPlanRegister_T02Entity.ORDER_NAME;
                pDataParametersA[6].Value = pProductPlanRegister_T02Entity.ORDER_OPTION;
                pDataParametersA[7].Value = pProductPlanRegister_T02Entity.ORDER_REVISION;
                pDataParametersA[8].Value = pProductPlanRegister_T02Entity.REFERENCE_ID;
                pDataParametersA[9].Value = pProductPlanRegister_T02Entity.REMARK;
                pDataParametersA[10].Value = pProductPlanRegister_T02Entity.USE_YN;
                
                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_T02_I10", pDataParametersA);
                
                pProductPlanRegister_T02Entity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                pProductPlanRegister_T02Entity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                pProductPlanRegister_T02Entity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                pProductPlanRegister_T02Entity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                pProductPlanRegister_T02Entity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }else
                {
                    if (dt != null)
                    {

                        pCount = dt.Rows.Count;

                        for (int i = 0; i < pCount; i++)
                        {
                            IDataParameter[] pDataParameters = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParameters = new IDataParameter[]
                                    {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar,15),
                                new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_production_plan_date", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_production_plan_seq", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_order_number", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_order_seq", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_order_date", MySqlDbType.VarChar,8),
                                new MySqlParameter("@v_order_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_unitcost", MySqlDbType.Decimal),
                                new MySqlParameter("@v_cost", MySqlDbType.Decimal),
                                new MySqlParameter("@v_delivery_date", MySqlDbType.VarChar,8),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParameters = new IDataParameter[]
                                    {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar,15),
                                new SqlParameter("@v_production_plan_id", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_production_plan_date", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_production_plan_seq", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_order_number", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_order_seq", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_order_date", SqlDbType.VarChar, 8),
                                new SqlParameter("@v_order_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_part_code", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_unitcost", SqlDbType.Decimal),
                                new SqlParameter("@v_cost", SqlDbType.Decimal),
                                new SqlParameter("@v_delivery_date", SqlDbType.VarChar, 8),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar,8),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                                    };
                                    break;
                            }
                            if(dt.Rows[i]["REG_PRODUCTION"].ToString().Equals("Y"))
                            {
                                pDataParameters[0].Value = "U";
                                pDataParameters[1].Value = pProductPlanRegister_T02Entity.USER_CODE;
                                pDataParameters[2].Value = pProductPlanRegister_T02Entity.PRODUCTION_PLAN_ID;
                                pDataParameters[3].Value = pProductPlanRegister_T02Entity.PRODUCTION_PLAN_DATE;
                                pDataParameters[4].Value = pProductPlanRegister_T02Entity.PRODUCTION_PLAN_SEQ;
                            }
                            else
                            {
                                pDataParameters[0].Value = "C";
                                pDataParameters[1].Value = pProductPlanRegister_T02Entity.USER_CODE;
                                pDataParameters[2].Value = pProductPlanRegister_T02Entity.RTN_KEY;
                                pDataParameters[3].Value = pProductPlanRegister_T02Entity.PRODUCTION_PLAN_DATE;
                                pDataParameters[4].Value = pProductPlanRegister_T02Entity.RTN_SEQ;
                            }

                            pDataParameters[5].Value = pProductPlanRegister_T02Entity.ORDER_NUMBER;
                            pDataParameters[6].Value = dt.Rows[i]["ORDER_SEQ"].ToString();
                            pDataParameters[7].Value = pProductPlanRegister_T02Entity.PRODUCTION_PLAN_DATE;
                            pDataParameters[8].Value = dt.Rows[i]["ORDER_QTY"].ToString();
                            pDataParameters[9].Value = dt.Rows[i]["PART_CODE"].ToString();
                            pDataParameters[10].Value = dt.Rows[i]["UNITCOST"].ToString();
                            pDataParameters[11].Value = dt.Rows[i]["COST"].ToString();
                            if (dt.Rows[i]["DELIVERY_DATE"].ToString().Length > 8)
                            {
                                pDataParameters[12].Value = dt.Rows[i]["DELIVERY_DATE"].ToString().Substring(0, 10).Replace("-", "").ToString();
                            }
                            else
                            {
                                pDataParameters[12].Value = dt.Rows[i]["DELIVERY_DATE"].ToString();
                            }
                            pDataParameters[13].Value = dt.Rows[i]["REMARK"].ToString();
                            pDataParameters[14].Value = "Y";


                            DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_T02_I20", pDataParameters);

                            pProductPlanRegister_T02Entity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                            pProductPlanRegister_T02Entity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                            pProductPlanRegister_T02Entity.RTN_AQ = pDataTable.Rows[0]["rtn_aq"].ToString();
                            pProductPlanRegister_T02Entity.RTN_SQ = pDataTable.Rows[0]["rtn_sq"].ToString();

                            if (pDataTable.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                        }
                    }
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
                    "ProductPlanRegister_Save_Mst(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)",
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

        #region 서브데이터 저장
        public bool ProductPlanRegister_Save_Sub(ucOrderNumberInfoPopup_Entity pucOrderNumberInfoPopup_Entity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction();
            try
            {
                if (dt != null)
                {

                    pCount = dt.Rows.Count;

                    for (int i = 0; i < pCount; i++)
                    {
                        IDataParameter[] pDataParameters = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters = new IDataParameter[]
                                {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar,15),
                                new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_production_plan_date", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_production_plan_seq", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_order_number", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_order_seq", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_order_date", MySqlDbType.VarChar,8),
                                new MySqlParameter("@v_order_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_unitcost", MySqlDbType.Decimal),
                                new MySqlParameter("@v_cost", MySqlDbType.Decimal),
                                new MySqlParameter("@v_delivery_date", MySqlDbType.VarChar,8),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar,15),
                                new SqlParameter("@v_production_plan_id", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_production_plan_date", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_production_plan_seq", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_order_number", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_order_seq", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_order_date", SqlDbType.VarChar, 8),
                                new SqlParameter("@v_order_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_part_code", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_unitcost", SqlDbType.Decimal),
                                new SqlParameter("@v_cost", SqlDbType.Decimal),
                                new SqlParameter("@v_delivery_date", SqlDbType.VarChar, 8),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar,8),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[i]["CRUD"].ToString();
                        pDataParameters[1].Value = pucOrderNumberInfoPopup_Entity.USER_CODE;
                        pDataParameters[2].Value = pucOrderNumberInfoPopup_Entity.PRODUCTION_PLAN_ID;
                        pDataParameters[3].Value = pucOrderNumberInfoPopup_Entity.PRODUCTION_PLAN_DATE;
                        pDataParameters[4].Value = pucOrderNumberInfoPopup_Entity.PRODUCTION_PLAN_SEQ;
                        pDataParameters[5].Value = pucOrderNumberInfoPopup_Entity.ORDER_NUMBER;
                        pDataParameters[6].Value = pucOrderNumberInfoPopup_Entity.ORDER_SEQ;
                        if (dt.Rows[i]["ORDER_DATE"].ToString().Length > 8)
                        {
                            pDataParameters[7].Value = dt.Rows[i]["ORDER_DATE"].ToString().Substring(0, 10).Replace("-", "").ToString();
                        }
                        else
                        {
                            pDataParameters[7].Value = dt.Rows[i]["ORDER_DATE"].ToString();
                        }
                        pDataParameters[8].Value = dt.Rows[i]["ORDER_QTY"].ToString();
                        pDataParameters[9].Value = dt.Rows[i]["PART_CODE"].ToString();
                        pDataParameters[10].Value = dt.Rows[i]["UNITCOST"].ToString();
                        pDataParameters[11].Value = dt.Rows[i]["COST"].ToString();
                        if (dt.Rows[i]["DELIVERY_DATE"].ToString().Length > 8)
                        {
                            pDataParameters[12].Value = dt.Rows[i]["DELIVERY_DATE"].ToString().Substring(0, 10).Replace("-", "").ToString();
                        }
                        else
                        {
                            pDataParameters[12].Value = dt.Rows[i]["DELIVERY_DATE"].ToString();
                        }
                        pDataParameters[13].Value = dt.Rows[i]["REMARK"].ToString();
                        pDataParameters[14].Value = dt.Rows[i]["USE_YN"].ToString();


                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_T02_I20", pDataParameters);

                        pucOrderNumberInfoPopup_Entity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                        pucOrderNumberInfoPopup_Entity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                        pucOrderNumberInfoPopup_Entity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                        pucOrderNumberInfoPopup_Entity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                        pucOrderNumberInfoPopup_Entity.RTN_AQ = pDataTable.Rows[0]["rtn_aq"].ToString();
                        pucOrderNumberInfoPopup_Entity.RTN_SQ = pDataTable.Rows[0]["rtn_sq"].ToString();

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                    }
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

        #region ○ 데이터 삭제

        public DataTable ProductPlanRegister_del(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)
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
                            new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_production_plan_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),

                        };
                        break;
                }

                pDataParameters[0].Value = pProductPlanRegister_T02Entity.CRUD;
                pDataParameters[1].Value = pProductPlanRegister_T02Entity.PRODUCTION_PLAN_ID;
                pDataParameters[2].Value = pProductPlanRegister_T02Entity.USE_YN;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_T02_I01", pDataParameters);
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
                    "ProductPlanRegister_Info_Mst(ProductPlanRegisterEntity pProductPlanRegisterEntity)",
                    pException
                );
            }
        }

        #endregion
    }

    public class ProductPlanRegister_T50Provider : EntityManager<ProductPlanRegister_T50Entity>
    {
        public ProductPlanRegister_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #region ○ 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ProductPlanRegister_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductPlanRegister_T50Entity pContractMstRegisterEntity = new ProductPlanRegister_T50Entity();

                pContractMstRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pContractMstRegisterEntity;
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

        public DataTable ProductPlanRegister_T50_Info_Mst(ProductPlanRegister_T50Entity pProductPlanRegister_T50Entity)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


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
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductPlanRegister_T50Entity.CRUD;
                pDataParameters[1].Value = pProductPlanRegister_T50Entity.DATE_FROM;
                pDataParameters[2].Value = pProductPlanRegister_T50Entity.DATE_TO;
                pDataParameters[3].Value = pProductPlanRegister_T50Entity.CONTRACT_ID;
                pDataParameters[4].Value = pProductPlanRegister_T50Entity.PART_CODE;
                pDataParameters[5].Value = pProductPlanRegister_T50Entity.PART_NAME;
                pDataParameters[6].Value = pProductPlanRegister_T50Entity.USE_YN;
                pDataParameters[7].Value = pProductPlanRegister_T50Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_T50_R10", pDataParameters);
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
                    "ProductPlanRegister_T50_Info_Mst(ProductPlanRegister_T50Entity pProductPlanRegister_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장



        #endregion

        #region ○ 데이터 삭제

        public DataTable ProductPlanRegister_T50_del(ProductPlanRegister_T50Entity pProductPlanRegister_T50Entity)
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
                            new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_production_plan_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),

                        };
                        break;
                }

                pDataParameters[0].Value = pProductPlanRegister_T50Entity.CRUD;
                pDataParameters[1].Value = pProductPlanRegister_T50Entity.production_plan_id;
                pDataParameters[2].Value = pProductPlanRegister_T50Entity.USE_YN;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_T50_I10", pDataParameters);
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
                    "ProductPlanRegister_T50_Info_Mst(ProductPlanRegister_T50Entity pProductPlanRegister_T50Entity)",
                    pException
                );
            }
        }

        #endregion
    }

    public class ucProductPlanDocumentListPopupProvider : EntityManager<ucProductPlanDocumentListPopupEntity>
    {
        #region 생성자 - ucProductPlanDocumentListPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucProductPlanDocumentListPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 메인 조회하기 ucProductPlanDocumentListPopup_Info_Main(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity)
        public DataTable ucProductPlanDocumentListPopup_Info_Main(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity)
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
                            new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_plan_seq", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_plan_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_production_plan_seq", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)


                };
                        break;
                }

                pDataParameters[0].Value = pucProductPlanDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucProductPlanDocumentListPopupEntity.PRODUCTION_PLAN_ID;
                pDataParameters[2].Value = pucProductPlanDocumentListPopupEntity.PRODUCTION_PLAN_SEQ;
                pDataParameters[3].Value = pucProductPlanDocumentListPopupEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProductPlanDocumentListPopup_R10", pDataParameters);
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
                    "ucProductPlanDocumentListPopup_Info_Main(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 ucProductPlanDocumentListPopup_Info_Sub(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity)

        public DataTable ucProductPlanDocumentListPopup_Info_Sub(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity)
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
                            new MySqlParameter("@v_document_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_document_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_document_ver", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_contract_number", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_contract_revision", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_document_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_document_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_document_ver", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_contract_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_contract_number", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_contract_revision", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pucProductPlanDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucProductPlanDocumentListPopupEntity.DOCUMENT_TYPE;
                pDataParameters[2].Value = pucProductPlanDocumentListPopupEntity.DOCUMENT_NAME;
                pDataParameters[3].Value = pucProductPlanDocumentListPopupEntity.DOCUMENT_VER;

                pDataParameters[4].Value = pucProductPlanDocumentListPopupEntity.CONTRACT_ID;
                pDataParameters[5].Value = pucProductPlanDocumentListPopupEntity.CONTRACT_NUMBER;
                pDataParameters[6].Value = pucProductPlanDocumentListPopupEntity.CONTRACT_REVISION;
                pDataParameters[7].Value = pucProductPlanDocumentListPopupEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProductPlanDocumentListPopup_R20", pDataParameters);
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
                    "ucProductPlanDocumentListPopup_Info_Sub(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ucProductPlanDocumentListPopup_Info_Save(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity, DataTable pDataTable)
        public bool ucProductPlanDocumentListPopup_Info_Save(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity, DataTable pDataTable)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction();

            try
            {
                if (pDataTable != null)
                {
                    pCount = pDataTable.Rows.Count;

                    for (int a = 0; a < pCount; a++)
                    {
                        IDataParameter[] pDataParameters = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters = new IDataParameter[]
                                {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_production_plan_seq", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_document_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_document_type", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_production_plan_id", SqlDbType.NVarChar, 15),
                                        new SqlParameter("@v_production_plan_seq", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_document_id", SqlDbType.NVarChar, 15),
                                        new SqlParameter("@v_document_type", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                };
                                break;

                        }

                        pDataParameters[0].Value = pDataTable.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pucProductPlanDocumentListPopupEntity.USER_CODE;

                        pDataParameters[2].Value = pucProductPlanDocumentListPopupEntity.PRODUCTION_PLAN_ID;
                        pDataParameters[3].Value = pucProductPlanDocumentListPopupEntity.PRODUCTION_PLAN_SEQ;
                        pDataParameters[4].Value = pDataTable.Rows[a]["DOCUMENT_ID"].ToString();
                        pDataParameters[5].Value = pDataTable.Rows[a]["DOCUMENT_TYPE"].ToString();
                        pDataParameters[6].Value = pDataTable.Rows[a]["REMARK"].ToString();
                        pDataParameters[7].Value = pDataTable.Rows[a]["USE_YN"].ToString().ToUpper() == "" ? "Y" : pDataTable.Rows[a]["USE_YN"].ToString().ToUpper();

                        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProductPlanDocumentListPopup_I10", pDataParameters);

                        if (pDataTableB.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pucProductPlanDocumentListPopupEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                        pucProductPlanDocumentListPopupEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();

                    }
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
                    "ucProductPlanDocumentListPopup_Info_Save(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity, DataTable pDataTable)",
                    pException
                );
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

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucProductPlanDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity = new ucProductPlanDocumentListPopupEntity();
                pucProductPlanDocumentListPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucProductPlanDocumentListPopupEntity;
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

    public class JobResultRegisterProvider : EntityManager<JobResultRegisterEntity>
    {
        #region 생성자 - JobResultRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public JobResultRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(JobResultRegisterEntity pJobResultRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(JobResultRegisterEntity pJobResultRegisterEntity)
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

                pDataParameters[0].Value = pJobResultRegisterEntity.CRUD;
                pDataParameters[1].Value = pJobResultRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pJobResultRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pJobResultRegisterEntity.PART_NAME;
                pDataParameters[4].Value = pJobResultRegisterEntity.VEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_JobResultRegister_R10", pDataParameters);

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
                    "Sample_Info_Mst(JobResultRegisterEntity pJobResultRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(JobResultRegisterEntity pJobResultRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(JobResultRegisterEntity pJobResultRegisterEntity, DataTable dt)
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

                pDataParametersA[0].Value = pJobResultRegisterEntity.CORP_CODE;
                pDataParametersA[1].Value = pJobResultRegisterEntity.CRUD;
                pDataParametersA[2].Value = pJobResultRegisterEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_JobResultRegister_I10", pDataParametersA);

                pJobResultRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pJobResultRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pJobResultRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pJobResultRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pJobResultRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                    //        pDataParametersB[0].Value = pJobResultRegisterEntity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pJobResultRegisterEntity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pJobResultRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pJobResultRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pJobResultRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pJobResultRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pJobResultRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(JobResultRegisterEntity pJobResultRegisterEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 파일명 조회하기 - JobResultRegister_Info_Filename(JobResultRegisterEntity pJobResultRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pJobResultRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable JobResultRegister_Info_Filename(JobResultRegisterEntity pJobResultRegisterEntity)
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

                pDataParameters[0].Value = pJobResultRegisterEntity.WINDOW_NAME;
                pDataParameters[1].Value = pJobResultRegisterEntity.LANGUAGE_TYPE;

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
                    "JobResultRegister_Info_Filename(JobResultRegisterEntity pJobResultRegisterEntity)",
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
        public object Templete_Download(JobResultRegisterEntity pJobResultRegisterEntity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pJobResultRegisterEntity.LANGUAGE_TYPE;

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
        public override JobResultRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                JobResultRegisterEntity pJobResultRegisterEntity = new JobResultRegisterEntity();

                pJobResultRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pJobResultRegisterEntity;
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

    public class Facility_Utilization_StatusProvider : EntityManager<Facility_Utilization_StatusEntity>
    {
        #region 생성자 - Facility_Utilization_StatusProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public Facility_Utilization_StatusProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_date_year", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_date_month", MySqlDbType.VarChar, 10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_date_year", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_date_month", SqlDbType.NVarChar, 10)
                        };
                        break;
                }

                pDataParameters[0].Value = pFacility_Utilization_StatusEntity.DATE_YEAR;
                pDataParameters[1].Value = pFacility_Utilization_StatusEntity.DATE_MONTH;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "", pDataParameters);

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
                    "Sample_Info_Mst(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 파일명 조회하기 - Facility_Utilization_Status_Info_Filename(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pFacility_Utilization_StatusEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Facility_Utilization_Status_Info_Filename(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)
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

                pDataParameters[0].Value = pFacility_Utilization_StatusEntity.WINDOW_NAME;
                pDataParameters[1].Value = pFacility_Utilization_StatusEntity.LANGUAGE_TYPE;

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
                    "Facility_Utilization_Status_Info_Filename(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)",
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
        public override Facility_Utilization_StatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity = new Facility_Utilization_StatusEntity();

                pFacility_Utilization_StatusEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pFacility_Utilization_StatusEntity;
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

    public class JobResultStatus_NGProvider : EntityManager<JobResultStatus_NGEntity>
    {
        #region 생성자 - JobResultStatus_NGProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public JobResultStatus_NGProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(JobResultStatus_NGEntity pJobResultStatus_NGEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(JobResultStatus_NGEntity pJobResultStatus_NGEntity)
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

                pDataParameters[0].Value = pJobResultStatus_NGEntity.CRUD;
                pDataParameters[1].Value = pJobResultStatus_NGEntity.DATE_FROM;
                pDataParameters[2].Value = pJobResultStatus_NGEntity.DATE_TO;
                pDataParameters[3].Value = pJobResultStatus_NGEntity.PART_NAME;
                pDataParameters[4].Value = pJobResultStatus_NGEntity.VEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_JobResultStatus_NG_R10", pDataParameters);

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
                    "Sample_Info_Mst(JobResultStatus_NGEntity pJobResultStatus_NGEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(JobResultStatus_NGEntity pJobResultStatus_NGEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(JobResultStatus_NGEntity pJobResultStatus_NGEntity, DataTable dt)
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

                pDataParametersA[0].Value = pJobResultStatus_NGEntity.CORP_CODE;
                pDataParametersA[1].Value = pJobResultStatus_NGEntity.CRUD;
                pDataParametersA[2].Value = pJobResultStatus_NGEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_JobResultStatus_NG_I10", pDataParametersA);

                pJobResultStatus_NGEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pJobResultStatus_NGEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pJobResultStatus_NGEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pJobResultStatus_NGEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pJobResultStatus_NGEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                    //        pDataParametersB[0].Value = pJobResultStatus_NGEntity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pJobResultStatus_NGEntity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pJobResultStatus_NGEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pJobResultStatus_NGEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pJobResultStatus_NGEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pJobResultStatus_NGEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pJobResultStatus_NGEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(JobResultStatus_NGEntity pJobResultStatus_NGEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 파일명 조회하기 - JobResultStatus_NG_Info_Filename(JobResultStatus_NGEntity pJobResultStatus_NGEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pJobResultStatus_NGEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable JobResultStatus_NG_Info_Filename(JobResultStatus_NGEntity pJobResultStatus_NGEntity)
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

                pDataParameters[0].Value = pJobResultStatus_NGEntity.WINDOW_NAME;
                pDataParameters[1].Value = pJobResultStatus_NGEntity.LANGUAGE_TYPE;

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
                    "JobResultStatus_NG_Info_Filename(JobResultStatus_NGEntity pJobResultStatus_NGEntity)",
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
        public object Templete_Download(JobResultStatus_NGEntity pJobResultStatus_NGEntity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pJobResultStatus_NGEntity.LANGUAGE_TYPE;

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
        public override JobResultStatus_NGEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                JobResultStatus_NGEntity pJobResultStatus_NGEntity = new JobResultStatus_NGEntity();

                pJobResultStatus_NGEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pJobResultStatus_NGEntity;
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
    public class ProductMonitoringProvider : EntityManager<ProductMonitoringEntity>
    {
        #region 생성자 - ProductMonitoringProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductMonitoringProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 파일명 조회하기 - ProductMonitoring_Info_Filename(ProductMonitoringEntity pProductMonitoringEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductMonitoringEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductMonitoring_Info_Filename(ProductMonitoringEntity pProductMonitoringEntity)
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

                pDataParameters[0].Value = pProductMonitoringEntity.WINDOW_NAME;
                pDataParameters[1].Value = pProductMonitoringEntity.LANGUAGE_TYPE;

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
                    "ProductMonitoring_Info_Filename(ProductMonitoringEntity pProductMonitoringEntity)",
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
        public override ProductMonitoringEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductMonitoringEntity pProductMonitoringEntity = new ProductMonitoringEntity();

                pProductMonitoringEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProductMonitoringEntity;
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

    public class ProductMonitoring_T01Provider : EntityManager<ProductMonitoring_T01Entity>
    {
        #region 생성자 - ProductMonitoring_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductMonitoring_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 파일명 조회하기 - ProductMonitoring_T01_Info_Filename(ProductMonitoring_T01Entity pProductMonitoring_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductMonitoring_T01Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductMonitoring_T01_Info(ProductMonitoring_T01Entity pProductMonitoring_T01Entity)
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
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_vend_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductMonitoring_T01Entity.CRUD;
                pDataParameters[1].Value = pProductMonitoring_T01Entity.VEND_NAME;
                pDataParameters[2].Value = pProductMonitoring_T01Entity.DATE_FROM;
                pDataParameters[3].Value = pProductMonitoring_T01Entity.DATE_TO;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductMonitoring_T01_R10", pDataParameters);

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
                    "ProductMonitoring_T01_Info_Filename(ProductMonitoring_T01Entity pProductMonitoring_T01Entity)",
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
        public override ProductMonitoring_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductMonitoring_T01Entity pProductMonitoring_T01Entity = new ProductMonitoring_T01Entity();

                pProductMonitoring_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProductMonitoring_T01Entity;
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

    public class ProductMonitoring_T02Provider : EntityManager<ProductMonitoring_T02Entity>
    {
        #region 생성자 - ProductMonitoring_T02Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductMonitoring_T02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion


        #region 마스터 조회하기 - ProductMonitoring_T02_Info_Mst2(ProductMonitoring_T02Entity pProductMonitoring_T02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductMonitoringEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductMonitoring_T02_Info_Mst2(ProductMonitoring_T02Entity pProductMonitoring_T02Entity)
        {

            // 회사코드
            // 단말기번호(옵션)


            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_vend_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductMonitoring_T02Entity.CRUD;
                pDataParameters[1].Value = pProductMonitoring_T02Entity.VEND_NAME;
                pDataParameters[2].Value = pProductMonitoring_T02Entity.DATE_FROM;
                pDataParameters[3].Value = pProductMonitoring_T02Entity.DATE_TO;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductMonitoring_T02_R10", pDataParameters);

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


        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ProductMonitoring_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductMonitoring_T02Entity pProductMonitoring_T02Entity = new ProductMonitoring_T02Entity();

                pProductMonitoring_T02Entity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pProductMonitoring_T02Entity;
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

    public class ProductMonitoring_T03Provider : EntityManager<ProductMonitoring_T03Entity>
    {
        #region 생성자 - ProductMonitoring_T03Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductMonitoring_T03Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion


        #region 마스터 조회하기 - ProductMonitoring_T03_Info_Mst2(ProductMonitoring_T03Entity pProductMonitoring_T03Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductMonitoringEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductMonitoring_T03_Info_Mst2(ProductMonitoring_T03Entity pProductMonitoring_T03Entity)
        {

            // 회사코드
            // 단말기번호(옵션)


            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_vend_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductMonitoring_T03Entity.CRUD;
                pDataParameters[1].Value = pProductMonitoring_T03Entity.VEND_NAME;
                pDataParameters[2].Value = pProductMonitoring_T03Entity.DATE_FROM;
                pDataParameters[3].Value = pProductMonitoring_T03Entity.DATE_TO;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductMonitoring_T03_R10", pDataParameters);

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


        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ProductMonitoring_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductMonitoring_T03Entity pProductMonitoring_T03Entity = new ProductMonitoring_T03Entity();

                pProductMonitoring_T03Entity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pProductMonitoring_T03Entity;
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
    public class NgResultRegisterProvider : EntityManager<NgResultRegisterEntity>
    {
        #region 생성자 - NgResultRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public NgResultRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(NgResultRegisterEntity pNgResultRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(NgResultRegisterEntity pNgResultRegisterEntity)
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

                pDataParameters[0].Value = pNgResultRegisterEntity.CRUD;
                pDataParameters[1].Value = pNgResultRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pNgResultRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pNgResultRegisterEntity.PART_NAME;
                pDataParameters[4].Value = pNgResultRegisterEntity.VEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_NgResultRegister_R10", pDataParameters);

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
                    "Sample_Info_Mst(NgResultRegisterEntity pNgResultRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(NgResultRegisterEntity pNgResultRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(NgResultRegisterEntity pNgResultRegisterEntity, DataTable dt)
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

                pDataParametersA[0].Value = pNgResultRegisterEntity.CORP_CODE;
                pDataParametersA[1].Value = pNgResultRegisterEntity.CRUD;
                pDataParametersA[2].Value = pNgResultRegisterEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_NgResultRegister_I10", pDataParametersA);

                pNgResultRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pNgResultRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pNgResultRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pNgResultRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pNgResultRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                    //        pDataParametersB[0].Value = pNgResultRegisterEntity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pNgResultRegisterEntity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pNgResultRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pNgResultRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pNgResultRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pNgResultRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pNgResultRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(NgResultRegisterEntity pNgResultRegisterEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 파일명 조회하기 - NgResultRegister_Info_Filename(NgResultRegisterEntity pNgResultRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pNgResultRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable NgResultRegister_Info_Filename(NgResultRegisterEntity pNgResultRegisterEntity)
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

                pDataParameters[0].Value = pNgResultRegisterEntity.WINDOW_NAME;
                pDataParameters[1].Value = pNgResultRegisterEntity.LANGUAGE_TYPE;

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
                    "NgResultRegister_Info_Filename(NgResultRegisterEntity pNgResultRegisterEntity)",
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
        public object Templete_Download(NgResultRegisterEntity pNgResultRegisterEntity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pNgResultRegisterEntity.LANGUAGE_TYPE;


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
        public override NgResultRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                NgResultRegisterEntity pNgResultRegisterEntity = new NgResultRegisterEntity();

                pNgResultRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pNgResultRegisterEntity;
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


    public class PlanResult_JobResultProvider : EntityManager<PlanResult_JobResultEntity>
    {
        #region 생성자 - PlanResult_JobResultProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public PlanResult_JobResultProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(PlanResult_JobResultEntity pPlanResult_JobResultEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(PlanResult_JobResultEntity pPlanResult_JobResultEntity)
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

                pDataParameters[0].Value = pPlanResult_JobResultEntity.CRUD;
                pDataParameters[1].Value = pPlanResult_JobResultEntity.DATE_FROM;
                pDataParameters[2].Value = pPlanResult_JobResultEntity.DATE_TO;
                pDataParameters[3].Value = pPlanResult_JobResultEntity.PART_NAME;
                pDataParameters[4].Value = pPlanResult_JobResultEntity.VEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_PlanResult_JobResult_R10", pDataParameters);

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
                    "Sample_Info_Mst(PlanResult_JobResultEntity pPlanResult_JobResultEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(PlanResult_JobResultEntity pPlanResult_JobResultEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(PlanResult_JobResultEntity pPlanResult_JobResultEntity, DataTable dt)
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

                pDataParametersA[0].Value = pPlanResult_JobResultEntity.CORP_CODE;
                pDataParametersA[1].Value = pPlanResult_JobResultEntity.CRUD;
                pDataParametersA[2].Value = pPlanResult_JobResultEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_PlanResult_JobResult_I10", pDataParametersA);

                pPlanResult_JobResultEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pPlanResult_JobResultEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pPlanResult_JobResultEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pPlanResult_JobResultEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pPlanResult_JobResultEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                    //        pDataParametersB[0].Value = pPlanResult_JobResultEntity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pPlanResult_JobResultEntity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pPlanResult_JobResultEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pPlanResult_JobResultEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pPlanResult_JobResultEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pPlanResult_JobResultEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pPlanResult_JobResultEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(PlanResult_JobResultEntity pPlanResult_JobResultEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 파일명 조회하기 - PlanResult_JobResult_Info_Filename(PlanResult_JobResultEntity pPlanResult_JobResultEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPlanResult_JobResultEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable PlanResult_JobResult_Info_Filename(PlanResult_JobResultEntity pPlanResult_JobResultEntity)
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

                pDataParameters[0].Value = pPlanResult_JobResultEntity.WINDOW_NAME;
                pDataParameters[1].Value = pPlanResult_JobResultEntity.LANGUAGE_TYPE;

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
                    "PlanResult_JobResult_Info_Filename(PlanResult_JobResultEntity pPlanResult_JobResultEntity)",
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
        public object Templete_Download(PlanResult_JobResultEntity pPlanResult_JobResultEntity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pPlanResult_JobResultEntity.LANGUAGE_TYPE;

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
        public override PlanResult_JobResultEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                PlanResult_JobResultEntity pPlanResult_JobResultEntity = new PlanResult_JobResultEntity();

                pPlanResult_JobResultEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pPlanResult_JobResultEntity;
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

    public class WorkResultRegisterProvider : EntityManager<WorkResultRegisterEntity>
    {
        #region ○ 생성자 - WorkResultRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkResultRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }


        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override WorkResultRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultRegisterEntity pWorkResultRegisterEntity = new WorkResultRegisterEntity();

                pWorkResultRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultRegisterEntity;
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

        #region ○ 마스터 조회하기 - WorkResultRegister_Info_Mst(WorkResultRegisterEntity pWorkResultRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_Info_Mst(WorkResultRegisterEntity pWorkResultRegisterEntity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegisterEntity.CRUD;
                pDataParameters[1].Value = pWorkResultRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pWorkResultRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pWorkResultRegisterEntity.PART_CODE;
                pDataParameters[4].Value = pWorkResultRegisterEntity.PART_NAME;
                pDataParameters[5].Value = pWorkResultRegisterEntity.PROCESS_CODE_MST;
                pDataParameters[6].Value = pWorkResultRegisterEntity.PROCESS_CODE;
                pDataParameters[7].Value = pWorkResultRegisterEntity.PRODUCTION_ORDER_ID;
                pDataParameters[8].Value = pWorkResultRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_R10", pDataParameters);
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
                    "WorkResultRegister_Info_Mst(WorkResultRegisterEntity pWorkResultRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 서브1 조회하기 - WorkResultRegister_Info_Sub1(WorkResultRegisterEntity pWorkResultRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_Info_Sub1(WorkResultRegisterEntity pWorkResultRegisterEntity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_code_gubn", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_code_gubn", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegisterEntity.CRUD;
                pDataParameters[1].Value = pWorkResultRegisterEntity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegisterEntity.CODE_GUBN;
                pDataParameters[3].Value = pWorkResultRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_R20", pDataParameters);
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
                    "WorkResultRegister_Info_Mst(WorkResultRegisterEntity pWorkResultRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장 WorkResultRegister_Save(WorkResultRegisterEntity pWorkResultRegisterEntity, DataTable dt)

        public bool WorkResultRegister_Save(WorkResultRegisterEntity pWorkResultRegisterEntity, DataTable dt)
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
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                    new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                                    new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper(); //pWorkResultRegisterEntity.CRUD;
                        pDataParameters[1].Value = pWorkResultRegisterEntity.USER_CODE;
                        pDataParameters[2].Value = dt.Rows[a]["PRODUCTION_ORDER_ID"].ToString();
                        pDataParameters[3].Value = dt.Rows[a]["COMPLETE_YN"].ToString(); 


                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pWorkResultRegisterEntity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                        pWorkResultRegisterEntity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                        pWorkResultRegisterEntity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                        pWorkResultRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                        pWorkResultRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();


                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;

                throw pExceptionManager;
            }
            finally
            {
                pWorkResultRegisterEntity.PART_CODE = "" ;
                pWorkResultRegisterEntity.PART_NAME = "";
                pWorkResultRegisterEntity.PROCESS_CODE_MST = ""; 
                pWorkResultRegisterEntity.PROCESS_CODE = ""; 
                pWorkResultRegisterEntity.PRODUCTION_ORDER_ID = ""; 

                if (pErrorYN)
                    _pDBManager.RollbackTransaction();  // 저장실패
                else
                    _pDBManager.CommitTransaction();
            }

                    return pErrorYN;
                }

        #endregion

    }

    public class WorkResultRegister_T09Provider : EntityManager<WorkResultRegister_T09Entity>
    {
        #region ○ 생성자 - WorkResultRegister_T09Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkResultRegister_T09Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }


        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override WorkResultRegister_T09Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultRegister_T09Entity pWorkResultRegister_T09Entity = new WorkResultRegister_T09Entity();

                pWorkResultRegister_T09Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultRegister_T09Entity;
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

        #region ○ 마스터 조회하기 - WorkResultRegister_T09_Info_Mst(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_T09_Info_Mst(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T09Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T09Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkResultRegister_T09Entity.DATE_TO;
                pDataParameters[3].Value = pWorkResultRegister_T09Entity.PART_CODE;
                pDataParameters[4].Value = pWorkResultRegister_T09Entity.PART_NAME;
                pDataParameters[5].Value = pWorkResultRegister_T09Entity.PROCESS_CODE_MST;
                pDataParameters[6].Value = pWorkResultRegister_T09Entity.PROCESS_CODE;
                pDataParameters[7].Value = pWorkResultRegister_T09Entity.PRODUCTION_ORDER_ID;
                pDataParameters[8].Value = pWorkResultRegister_T09Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T09_R10", pDataParameters);
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
                    "WorkResultRegister_T09_Info_Mst(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 서브1 조회하기 - WorkResultRegister_T09_Info_Sub1(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_T09_Info_Sub1(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_code_gubn", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_code_gubn", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T09Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T09Entity.PRODUCTION_ORDER_ID + "-"+pWorkResultRegister_T09Entity.PRODUCTION_SEQ;// pWorkResultRegister_T09Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T09Entity.CODE_GUBN;
                pDataParameters[3].Value = pWorkResultRegister_T09Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T09_R20", pDataParameters);
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
                    "WorkResultRegister_T09_Info_Mst(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장 WorkResultRegister_T09_Save(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity, DataTable dt)

        public bool WorkResultRegister_T09_Save(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity, DataTable dt)
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
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1),
                                    new MySqlParameter("@v_production_seq", MySqlDbType.Int32, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                    new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                                    new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_production_seq", SqlDbType.Int, 1),
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper(); //pWorkResultRegister_T09Entity.CRUD;
                        pDataParameters[1].Value = pWorkResultRegister_T09Entity.USER_CODE;
                        pDataParameters[2].Value = dt.Rows[a]["PRODUCTION_ORDER_ID"].ToString();
                        pDataParameters[3].Value = dt.Rows[a]["COMPLETE_YN"].ToString();
                        pDataParameters[4].Value = Convert.ToInt32(dt.Rows[a]["PRODUCTION_SEQ"].ToString());


                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T09_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pWorkResultRegister_T09Entity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                        pWorkResultRegister_T09Entity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                        pWorkResultRegister_T09Entity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                        pWorkResultRegister_T09Entity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                        pWorkResultRegister_T09Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();


                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;

                throw pExceptionManager;
            }
            finally
            {
                pWorkResultRegister_T09Entity.PART_CODE = "";
                pWorkResultRegister_T09Entity.PART_NAME = "";
                pWorkResultRegister_T09Entity.PROCESS_CODE_MST = "";
                pWorkResultRegister_T09Entity.PROCESS_CODE = "";
                pWorkResultRegister_T09Entity.PRODUCTION_ORDER_ID = "";

                if (pErrorYN)
                    _pDBManager.RollbackTransaction();  // 저장실패
                else
                    _pDBManager.CommitTransaction();
            }

            return pErrorYN;
        }

        #endregion

        #region 양품 정보 저장하기 - Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool WorkResultRegister_T09_Result_Sub1(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity, DataTable pDataTable)
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
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_ok_result", MySqlDbType.Decimal),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_ok_seq", MySqlDbType.VarChar, 10)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_ok_result", SqlDbType.Decimal),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_ok_seq", SqlDbType.VarChar, 10)
                        };
                        break;
                }
                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(pDataTable.Rows[i]["PRODUCTION_RESULT"].ToString()) > 0)
                    {
                        pDataParametersA[0].Value = pDataTable.Rows[i]["CRUD"].ToString();
                        pDataParametersA[1].Value = pDataTable.Rows[i]["PROCESS_CODE"].ToString();
                        pDataParametersA[2].Value = pWorkResultRegister_T09Entity.USER_CODE;
                        pDataParametersA[3].Value = pDataTable.Rows[i]["COLLECTION_DATE"].ToString();
                        //pDataParametersA[4].Value = pWorkResultRegister_T09Entity.PRODUCTION_ORDER_ID;
                        pDataParametersA[4].Value = pWorkResultRegister_T09Entity.PRODUCTION_ORDER_ID + "-" + pWorkResultRegister_T09Entity.PRODUCTION_SEQ;// pWorkResultRegister_T09Entity.PRODUCTION_ORDER_ID
                        pDataParametersA[5].Value = Convert.ToDecimal(pDataTable.Rows[i]["PRODUCTION_RESULT"].ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                        pDataParametersA[6].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                        pDataParametersA[7].Value = pDataTable.Rows[i]["OK_SEQ"].ToString();
                        // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T09_I20", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pWorkResultRegister_T09Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                        }
                    }
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
                    "Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 불량 정보 저장하기 - Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool WorkResultRegister_T09_Result_Sub2(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity, DataTable pDataTable)
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
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_bad_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_ng_result", MySqlDbType.Decimal),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 10)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_bad_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_ng_result", SqlDbType.Decimal),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_seq", SqlDbType.VarChar, 10),
                        };
                        break;
                }
                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(pDataTable.Rows[i]["PRODUCTION_NG_RESULT"].ToString()) > 0)
                    {
                        pDataParametersA[0].Value = pDataTable.Rows[i]["CRUD"].ToString();
                        pDataParametersA[1].Value = pDataTable.Rows[i]["PROCESS_CODE"].ToString(); 
                        pDataParametersA[2].Value = pWorkResultRegister_T09Entity.USER_CODE;
                        pDataParametersA[3].Value = pDataTable.Rows[i]["COLLECTION_DATE"].ToString();
                        pDataParametersA[4].Value = pWorkResultRegister_T09Entity.PRODUCTION_ORDER_ID+"-" +pWorkResultRegister_T09Entity.PRODUCTION_SEQ;// pWorkResultRegister_T09Entity.PRODUCTION_ORDER_ID;
                        pDataParametersA[5].Value = pDataTable.Rows[i]["BAD_CODE"].ToString();//pucWorkResultPopUp_T01_Entity.CONDITION_CODE;
                        pDataParametersA[6].Value = Convert.ToDecimal(pDataTable.Rows[i]["PRODUCTION_NG_RESULT"].ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                        pDataParametersA[7].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                        pDataParametersA[8].Value = pDataTable.Rows[i]["PRODUCTION_ORDER_SEQ"].ToString();
                        // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                          DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T09_I30", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pWorkResultRegister_T09Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                        }
                    }
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
                    "Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

    }

    public class WorkResultRegister_T01Provider : EntityManager<WorkResultRegister_T01Entity>
    {
        #region ○ 생성자 - WorkResultRegister_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkResultRegister_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }


        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override WorkResultRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultRegister_T01Entity pWorkResultRegister_T01Entity = new WorkResultRegister_T01Entity();

                pWorkResultRegister_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultRegister_T01Entity;
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

        #region ○ 마스터 조회하기 - WorkResultRegister_T01_Info_Mst(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_T01_Info_Mst(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T01Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkResultRegister_T01Entity.DATE_TO;
                pDataParameters[3].Value = pWorkResultRegister_T01Entity.PART_CODE;
                pDataParameters[4].Value = pWorkResultRegister_T01Entity.PART_NAME;
                pDataParameters[5].Value = pWorkResultRegister_T01Entity.PROCESS_CODE_MST;
                pDataParameters[6].Value = pWorkResultRegister_T01Entity.PROCESS_CODE;
                pDataParameters[7].Value = pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID;
                pDataParameters[8].Value = pWorkResultRegister_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T01_R10", pDataParameters);
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
                    "WorkResultRegister_T01_Info_Mst(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 서브1 조회하기 - WorkResultRegister_T01_Info_Sub1(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_T01_Info_Sub1(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_code_gubn", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_code_gubn", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T01Entity.CODE_GUBN;
                pDataParameters[3].Value = pWorkResultRegister_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T01_R20", pDataParameters);
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
                    "WorkResultRegister_T01_Info_Mst(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - WorkResultRegister_T01_Info_Check_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity_Request, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool WorkResultRegister_T01_Info_Check_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    for (int a = 0; a < pCount; a++)
                    {
                        //체크된것만 저장
                        if (dt.Rows[a]["CRUD"].ToString() == "Y")
                        {
                            //마스터 저장
                            IDataParameter[] pDataParametersA = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new MySqlParameter("@v_crud                  ".Trim(), MySqlDbType.VarChar, 1),
                                            new MySqlParameter("@v_user_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_reference_id              ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_part_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_sampling_date             ".Trim(), MySqlDbType.VarChar, 8),
                                            new MySqlParameter("@v_sampling_result             ".Trim(), MySqlDbType.Decimal)
                                          //  new MySqlParameter("@v_remark             ".Trim(), MySqlDbType.VarChar, 2000),


                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_reference_id              ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_part_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_sampling_date             ".Trim(), SqlDbType.VarChar, 8),
                                            new SqlParameter("@v_sampling_result           ".Trim(), SqlDbType.Decimal)
                                           // new SqlParameter("@v_remark             ".Trim(), SqlDbType.VarChar, 2000),

                                    };
                                    break;
                            }
                            pDataParametersA[0].Value = pWorkResultRegister_T01Entity.CRUD;
                            pDataParametersA[1].Value = pWorkResultRegister_T01Entity.USER_CODE;
                            pDataParametersA[2].Value = dt.Rows[a]["PRODUCTION_ORDER_ID"].ToString().ToUpper();
                            pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                            pDataParametersA[4].Value = String.Format("{0:yyyyMMdd}", Convert.ToDateTime(dt.Rows[a]["SAMPLING_DATE"].ToString()));// dt.Rows[a]["SAMPLING_DATE"].ToString().ToUpper();
                            pDataParametersA[5].Value = dt.Rows[a]["INPUT"].ToString().ToUpper();
                            //pDataParametersA[4].Value = dt.Rows[a]["REMARK"].ToString().ToUpper();


                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T01_I20", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            pWorkResultRegister_T01Entity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                            pWorkResultRegister_T01Entity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                            pWorkResultRegister_T01Entity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                            pWorkResultRegister_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                            pWorkResultRegister_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                        }
                    }
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
                    "WorkResultRegister_T01_Info_Save(MaterialOrderStatusEntity pMaterialOrderRegisterEntity_Request, DataTable dt)",
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
        #region 작업요청 정보 저장하기 - WorkResultRegister_T01_Info_Check_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity_Request, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool WorkResultRegister_T01_Info_REQUEST_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                   // pCount = dt.Rows.Count;

                    //for (int a = 0; a < pCount; a++)
                  //  {
                        //체크된것만 저장
                       // if (dt.Rows[a]["CRUD"].ToString() == "Y")
                       // {
                            //마스터 저장
                            IDataParameter[] pDataParametersA = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new MySqlParameter("@v_crud                  ".Trim(), MySqlDbType.VarChar, 1),
                                            new MySqlParameter("@v_user_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_production_order_id   ".Trim(), MySqlDbType.VarChar, 15)
                                         //   new MySqlParameter("@v_part_code             ".Trim(), MySqlDbType.VarChar, 50)
                                          //  new MySqlParameter("@v_remark             ".Trim(), MySqlDbType.VarChar, 2000),


                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_production_order_id   ".Trim(), SqlDbType.VarChar, 15)
                                          //  new SqlParameter("@v_part_code             ".Trim(), SqlDbType.VarChar, 50)
                                           // new SqlParameter("@v_remark             ".Trim(), SqlDbType.VarChar, 2000),

                                    };
                                    break;
                            }
                            pDataParametersA[0].Value = pWorkResultRegister_T01Entity.CRUD;
                            pDataParametersA[1].Value = pWorkResultRegister_T01Entity.USER_CODE;
                            pDataParametersA[2].Value = pWorkResultRegister_T01Entity.PRODUCTION_ORDER_ID;
                            //pDataParametersA[3].Value = pWorkResultRegister_T01Entity.PART_CODE;
                            //pDataParametersA[4].Value = dt.Rows[a]["REMARK"].ToString().ToUpper();


                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T01_I30", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            pWorkResultRegister_T01Entity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                            pWorkResultRegister_T01Entity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                            pWorkResultRegister_T01Entity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                            pWorkResultRegister_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                            pWorkResultRegister_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                        //}
                  //  }
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
                    "WorkResultRegister_T01_Info_Save(MaterialOrderStatusEntity pMaterialOrderRegisterEntity_Request, DataTable dt)",
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
    }

    public class WorkResultRegister_T02Provider : EntityManager<WorkResultRegister_T02Entity>
    {
        #region ○ 생성자 - WorkResultRegister_T02Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkResultRegister_T02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }


        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override WorkResultRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultRegister_T02Entity pWorkResultRegister_T02Entity = new WorkResultRegister_T02Entity();

                pWorkResultRegister_T02Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultRegister_T02Entity;
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

        #region ○ 마스터 조회하기 - WorkResultRegister_T02_Info_Mst(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_T02_Info_Mst(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T02Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T02Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkResultRegister_T02Entity.DATE_TO;
                pDataParameters[3].Value = pWorkResultRegister_T02Entity.PART_CODE;
                pDataParameters[4].Value = pWorkResultRegister_T02Entity.PART_NAME;
                pDataParameters[5].Value = pWorkResultRegister_T02Entity.PROCESS_CODE_MST;
                pDataParameters[6].Value = pWorkResultRegister_T02Entity.PROCESS_CODE;
                pDataParameters[7].Value = pWorkResultRegister_T02Entity.PRODUCTION_ORDER_ID;
                pDataParameters[8].Value = pWorkResultRegister_T02Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T02_R10", pDataParameters);
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
                    "WorkResultRegister_T02_Info_Mst(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 서브1 조회하기 - WorkResultRegister_T02_Info_Sub1(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_T02_Info_Sub1(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_code_gubn", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_code_gubn", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T02Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T02Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T02Entity.CODE_GUBN;
                pDataParameters[3].Value = pWorkResultRegister_T02Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T02_R20", pDataParameters);
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
                    "WorkResultRegister_T02_Info_Mst(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장 WorkResultRegister_T02_Save(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity, DataTable dt)

        public bool WorkResultRegister_T02_Save(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity, DataTable dt)
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
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                    new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                                    new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper(); //pWorkResultRegisterEntity.CRUD;
                        pDataParameters[1].Value = pWorkResultRegister_T02Entity.USER_CODE;
                        pDataParameters[2].Value = dt.Rows[a]["PRODUCTION_ORDER_ID"].ToString();
                        pDataParameters[3].Value = dt.Rows[a]["COMPLETE_YN"].ToString();


                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pWorkResultRegister_T02Entity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                        pWorkResultRegister_T02Entity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                        pWorkResultRegister_T02Entity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                        pWorkResultRegister_T02Entity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                        pWorkResultRegister_T02Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();


                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;

                throw pExceptionManager;
            }
            finally
            {
                pWorkResultRegister_T02Entity.PART_CODE = "";
                pWorkResultRegister_T02Entity.PART_NAME = "";
                pWorkResultRegister_T02Entity.PROCESS_CODE_MST = "";
                pWorkResultRegister_T02Entity.PROCESS_CODE = "";
                pWorkResultRegister_T02Entity.PRODUCTION_ORDER_ID = "";

                if (pErrorYN)
                    _pDBManager.RollbackTransaction();  // 저장실패
                else
                    _pDBManager.CommitTransaction();
            }

            return pErrorYN;
        }

        #endregion
    }


    public class WorkResultRegister_T03Provider : EntityManager<WorkResultRegister_T03Entity>
    {
        #region ○ 생성자 - WorkResultRegister_T03Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkResultRegister_T03Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }


        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override WorkResultRegister_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultRegister_T03Entity pWorkResultRegister_T03Entity = new WorkResultRegister_T03Entity();

                pWorkResultRegister_T03Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultRegister_T03Entity;
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

        #region ○ 마스터 조회하기 - WorkResultRegister_Info_Mst(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_Info_Mst(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_part_code", SqlDbType.VarChar, 50),

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T03Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T03Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkResultRegister_T03Entity.DATE_TO;
                pDataParameters[3].Value = pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID;
                pDataParameters[4].Value = pWorkResultRegister_T03Entity.PART_CODE;
                pDataParameters[5].Value = pWorkResultRegister_T03Entity.VEND_PART_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T03_R10", pDataParameters);
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
                    "WorkResultRegister_Info_Mst(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 메인(LOT) 조회하기 - WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50)

                             
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T03Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T03_R20", pDataParameters);
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
                    "WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브1 조회하기
        public DataTable WorkResultRegister_Info_Sub_Detail1(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T03Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T03Entity.LOT_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T03_R21", pDataParameters);
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
                    "WorkResultRegister_Info_Sub_Detail1(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 서브2 조회하기
        public DataTable WorkResultRegister_Info_Sub_Detail2(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T03Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T03Entity.LOT_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T03_R22", pDataParameters);
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
                    "WorkResultRegister_Info_Sub_Detail2(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 서브3 조회하기
        public DataTable WorkResultRegister_Info_Sub_Detail3(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T03Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T03Entity.LOT_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T03_R23", pDataParameters);
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
                    "WorkResultRegister_Info_Sub_Detail3(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)",
                    pException
                );
            }
        }
        #endregion

        #region LOT 생성
        public bool WorkResultRegister_Lot_Save(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
        {
            bool pErrorYN = false;
            _pDBManager.BeginTransaction();
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_value1", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_value1", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T03Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T03Entity.USER_CODE;
                pDataParameters[2].Value = pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID;
                pDataParameters[3].Value = pWorkResultRegister_T03Entity.USA_LOT_CHECK;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T03_I10", pDataParameters);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pWorkResultRegister_T03Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResult_Lot_Save(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)",
                    pException
                );
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

        #region 저장

        #region 데이터삽입

        public bool WorkResultRegister_Save(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    for (int i = 0; i < pCount; i++)
                    {
                        //마스터 저장
                        IDataParameter[] pDataParametersA = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParametersA = new IDataParameter[]
                                {
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_property_value", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_condition_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_value", MySqlDbType.Decimal)
                                };
                                break;

                            case "SQLServer":
                                pDataParametersA = new IDataParameter[]
                                {
                            new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_property_value", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_condition_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal)
                                };
                                break;
                        }

                        pDataParametersA[0].Value = dt.Rows[i]["RESOURCE_CODE"].ToString();
                        pDataParametersA[1].Value = dt.Rows[i]["COLLECTION_DATE"].ToString();
                        pDataParametersA[2].Value = dt.Rows[i]["PROPERTY_VALUE"].ToString();
                        pDataParametersA[3].Value = dt.Rows[i]["CONDITION_CODE"].ToString();
                        pDataParametersA[4].Value = dt.Rows[i]["COLLECTION_VALUE"].ToString();

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pWorkResultRegister_T03Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                        }
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
                    "WorkResultInfo_Save(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)",
                    pException
                );
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

        #region 완료처리

        public bool WorkResultRegister_Save_01(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity, DataTable dt)
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pWorkResultRegister_T03Entity.CRUD;
                pDataParametersA[1].Value = pWorkResultRegister_T03Entity.USER_CODE;
                pDataParametersA[2].Value = pWorkResultRegister_T03Entity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pWorkResultRegister_T03Entity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T03_I20", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pWorkResultRegister_T03Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save_01(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)",
                    pException
                );
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

        #endregion
    }

    public class WorkResultRegister_T04Provider : EntityManager<WorkResultRegister_T04Entity>
    {
        #region ○ 생성자 - WorkResultRegister_T04Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkResultRegister_T04Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }


        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override WorkResultRegister_T04Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultRegister_T04Entity pWorkResultRegister_T04Entity = new WorkResultRegister_T04Entity();

                pWorkResultRegister_T04Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultRegister_T04Entity;
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

        #region ○ 마스터 조회하기 - WorkResultRegister_Info_Mst(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_Info_Mst(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_high", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_middle", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_low", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_high", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_middle", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_low", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_order_number", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T04Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T04Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkResultRegister_T04Entity.DATE_TO;
                pDataParameters[3].Value = pWorkResultRegister_T04Entity.PRODUCTION_ORDER_ID;
                pDataParameters[4].Value = pWorkResultRegister_T04Entity.PART_CODE;
                pDataParameters[5].Value = pWorkResultRegister_T04Entity.VEND_PART_CODE;
                pDataParameters[6].Value = pWorkResultRegister_T04Entity.PART_HIGH;
                pDataParameters[7].Value = pWorkResultRegister_T04Entity.PART_MIDDLE;
                pDataParameters[8].Value = pWorkResultRegister_T04Entity.PART_LOW;
                pDataParameters[9].Value = pWorkResultRegister_T04Entity.ORDER_NUMBER;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T04_R10", pDataParameters);
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
                    "WorkResultRegister_Info_Mst(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 마스터 조회하기(Equipment) - WorkResultRegister_Info_Equip(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        public DataTable WorkResultRegister_Info_Equip(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T04Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T04Entity.PRODUCTION_ORDER_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T04_R15", pDataParameters);
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
                    "WorkResultRegister_Info_Equip(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)",
                    pException
                );
            }
        }
        #endregion

        #region ○ 마스터 바인딩 조회하기 - WorkResultRegister_Info_Mst_Binding(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        public DataTable WorkResultRegister_Info_Mst_Binding(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T04Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T04Entity.PRODUCTION_ORDER_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T04_R12", pDataParameters);
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
                    "WorkResultRegister_Info_Mst_Binding(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)",
                    pException
                );
            }
        }
        #endregion

        #region ○ 메인서브 조회하기 - WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T04Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T04Entity.PRODUCTION_ORDER_ID;
                

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T04_R11", pDataParameters);
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
                    "WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)",
                    pException
                );
            }
        }

        #endregion
        
        #region PACKING 조회하기
        public DataTable WorkResultRegister_Info_Sub_Packing(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T04Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T04Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T04Entity.LOT_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T04_R16", pDataParameters);
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
                    "WorkResultRegister_Info_Sub_Packing(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 서브1 조회하기
        public DataTable WorkResultRegister_Info_Sub_Bad(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T04Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T04Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T04Entity.LOT_ID;
                pDataParameters[3].Value = pWorkResultRegister_T04Entity.PROCESS_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T04_R13", pDataParameters);
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
                    "WorkResultRegister_Info_Sub_Bad(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 서브2 조회하기
        public DataTable WorkResultRegister_Info_Sub_Status(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T04Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T04Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T04Entity.LOT_ID;
                pDataParameters[3].Value = pWorkResultRegister_T04Entity.PROCESS_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T04_R14", pDataParameters);
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
                    "WorkResultRegister_Info_Sub_Status(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)",
                    pException
                );
            }
        }
        #endregion

        #region LOT 생성
        public bool WorkResultRegister_Lot_Save(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        {
            bool pErrorYN = false;
            _pDBManager.BeginTransaction();
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_value1", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_value1", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T04Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T04Entity.USER_CODE;
                pDataParameters[2].Value = pWorkResultRegister_T04Entity.PRODUCTION_ORDER_ID;
                pDataParameters[3].Value = pWorkResultRegister_T04Entity.USA_LOT_CHECK;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T04_I10", pDataParameters);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pWorkResultRegister_T04Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                    pWorkResultRegister_T04Entity.RTN_LOT_NO = pDataTableA.Rows[0]["NEWLOT"].ToString();
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
                    "WorkResult_Lot_Save(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)",
                    pException
                );
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

        #region 저장

        #region 데이터삽입

        public bool WorkResultRegister_Save(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity, DataTable dt, DataTable dtPacking, DataTable dtsub_Temp)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    for (int i = 0; i < pCount; i++)
                    {
                        //마스터 저장
                        IDataParameter[] pDataParametersA = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParametersA = new IDataParameter[]
                                {
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_property_value", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_condition_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_option_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_value", MySqlDbType.Decimal),
                            new MySqlParameter("@v_collection_value_str", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20)
                                };
                                break;

                            case "SQLServer":
                                pDataParametersA = new IDataParameter[]
                                {
                            new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_property_value", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_condition_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_option_code", SqlDbType.VarChar,50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_collection_value_str", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 20)
                                };
                                break;
                        }

                        pDataParametersA[0].Value = dt.Rows[i]["RESOURCE_CODE"].ToString();
                        pDataParametersA[1].Value = dt.Rows[i]["COLLECTION_DATE"].ToString();
                        pDataParametersA[2].Value = dt.Rows[i]["PROPERTY_VALUE"].ToString();
                        pDataParametersA[3].Value = dt.Rows[i]["CONDITION_CODE"].ToString();
                        pDataParametersA[4].Value = dt.Rows[i]["OPTION_CODE"].ToString();
                        pDataParametersA[5].Value = dt.Rows[i]["COLLECTION_VALUE"].ToString();
                        pDataParametersA[6].Value = dt.Rows[i]["COLLECTION_VALUE_STR"].ToString();
                        pDataParametersA[7].Value = dt.Rows[i]["USER_CODE"].ToString();

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pWorkResultRegister_T04Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                        }
                    }
                }
                if(pErrorYN == false)
                {
                    //마스터 저장
                    IDataParameter[] pDataParametersB = null;

                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersB = new IDataParameter[]
                            {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_move_document_id", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_mat_document_id", MySqlDbType.VarChar, 50)
                            };
                            break;

                        case "SQLServer":
                            pDataParametersB = new IDataParameter[]
                            {
                                        new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_move_document_id", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_mat_document_id", SqlDbType.VarChar, 50)
                            };
                            break;
                    }

                    pDataParametersB[0].Value = "U";
                    pDataParametersB[1].Value = pWorkResultRegister_T04Entity.USER_CODE;
                    pDataParametersB[2].Value = pWorkResultRegister_T04Entity.LOT_ID;
                    pDataParametersB[3].Value = pWorkResultRegister_T04Entity.MTC_NO;
                    pDataParametersB[4].Value = pWorkResultRegister_T04Entity.MATERAL_TRS_NO;



                    DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T04_I11", pDataParametersB);

                    if (pDataTableB.Rows[0]["ERR_NO"].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    else
                    {
                        pWorkResultRegister_T04Entity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    }
                }

                if(pErrorYN == false)
                {
                    int pSubCount = 0;
                    if(dtsub_Temp != null)
                    {

                        pSubCount = dtsub_Temp.Rows.Count;
                        for (int i = 0; i < pSubCount; i++)
                        {
                            //마스터 저장
                            IDataParameter[] pDataParametersD = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersD = new IDataParameter[]
                                    {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_configuration_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_configuration_seq", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_document_revision", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_production_user", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_production_date", MySqlDbType.VarChar, 50)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersD = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                                        new SqlParameter("@v_lot_id", SqlDbType.VarChar, 15),
                                        new SqlParameter("@v_configuration_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_configuration_seq", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_document_revision", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                        new SqlParameter("@v_production_user", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_production_date", SqlDbType.VarChar, 50)
                                    };
                                    break;
                            }

                            pDataParametersD[0].Value = "C";
                            pDataParametersD[1].Value = pWorkResultRegister_T04Entity.USER_CODE;
                            pDataParametersD[2].Value = dtsub_Temp.Rows[i]["PRODUCTION_ORDER_ID"].ToString();
                            pDataParametersD[3].Value = dtsub_Temp.Rows[i]["LOT_ID"].ToString();
                            pDataParametersD[4].Value = dtsub_Temp.Rows[i]["CONFIGURATION_CODE"].ToString();
                            pDataParametersD[5].Value = dtsub_Temp.Rows[i]["CONFIGURATION_SEQ"].ToString();
                            pDataParametersD[6].Value = dtsub_Temp.Rows[i]["DOCUMENT_REVISION"].ToString();
                            pDataParametersD[7].Value = dtsub_Temp.Rows[i]["REMARK"].ToString();
                            pDataParametersD[8].Value = pWorkResultRegister_T04Entity.USER_CODE;
                            pDataParametersD[9].Value = DateTime.Parse(dtsub_Temp.Rows[i]["PRODUCTION_DATE"].ToString()).ToString("yyyy-MM-dd");


                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T04_I13", pDataParametersD);

                            if (pDataTableB.Rows[0]["ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                        }
                        
                    }
                }

                if (pErrorYN == false)
                {
                    int pPackingCount = 0;
                    if (dtPacking != null)
                    {
                        pPackingCount = dtPacking.Rows.Count;
                        for (int i = 0; i < pPackingCount; i++)
                        {
                            //마스터 저장
                            IDataParameter[] pDataParametersC = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersC = new IDataParameter[]
                                    {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_packing_id", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_packing_date", MySqlDbType.VarChar, 8),
                                        new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_packing_qty", MySqlDbType.Decimal),
                                        new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 5)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersC = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_packing_id", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_packing_date", SqlDbType.VarChar, 8),
                                        new SqlParameter("@v_lot_id", SqlDbType.VarChar, 15),
                                        new SqlParameter("@v_packing_qty", SqlDbType.Decimal),
                                        new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_use_yn", SqlDbType.VarChar, 5)
                                    };
                                    break;
                            }

                            pDataParametersC[0].Value = dtPacking.Rows[i]["CRUD"].ToString();
                            pDataParametersC[1].Value = pWorkResultRegister_T04Entity.USER_CODE;
                            pDataParametersC[2].Value = dtPacking.Rows[i]["PACKING_ID"].ToString();
                            pDataParametersC[3].Value = dtPacking.Rows[i]["PACKING_DATE"].ToString();
                            pDataParametersC[4].Value = dtPacking.Rows[i]["LOT_ID"].ToString();
                            pDataParametersC[5].Value = Convert.ToDecimal(dtPacking.Rows[i]["PACKING_QTY"].ToString());
                            pDataParametersC[6].Value = dtPacking.Rows[i]["PART_CODE"].ToString();
                            pDataParametersC[7].Value = dtPacking.Rows[i]["USE_YN"].ToString();

                            DataTable pDataTableC = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T04_I12", pDataParametersC);

                            if (pDataTableC.Rows[0]["ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            else
                            {
                                pWorkResultRegister_T04Entity.RTN_KEY = pDataTableC.Rows[0]["RTN_KEY"].ToString();
                            }
                        }
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
                    "WorkResultInfo_Save(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)",
                    pException
                );
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

        #region Header 등록
        public bool WorkResultRegister_Header_Save(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction(); //Transaction 시작

            try
            {

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
                    "WorkResultInfo_Save(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)",
                    pException
                );
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

        #region 완료처리

        public bool WorkResultRegister_Save_01(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity, DataTable dt)
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pWorkResultRegister_T04Entity.CRUD;
                pDataParametersA[1].Value = pWorkResultRegister_T04Entity.USER_CODE;
                pDataParametersA[2].Value = pWorkResultRegister_T04Entity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pWorkResultRegister_T04Entity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T04_I20", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pWorkResultRegister_T04Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save_01(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)",
                    pException
                );
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

        #endregion
    }

    public class WorkResultRegister_T05Provider : EntityManager<WorkResultRegister_T05Entity>
    {
        #region ○ 생성자 - WorkResultRegister_T05Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkResultRegister_T05Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }


        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override WorkResultRegister_T05Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultRegister_T05Entity pWorkResultRegister_T05Entity = new WorkResultRegister_T05Entity();

                pWorkResultRegister_T05Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultRegister_T05Entity;
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

        #region ○ 마스터 조회하기 - WorkResultRegister_Info_Mst(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_Info_Mst(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
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
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_high", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_middle", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_low", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_high", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_middle", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_low", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_order_number", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T05Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T05Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkResultRegister_T05Entity.DATE_TO;
                pDataParameters[3].Value = pWorkResultRegister_T05Entity.LOT_ID;
                pDataParameters[4].Value = pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID;
                pDataParameters[5].Value = pWorkResultRegister_T05Entity.PART_CODE;
                pDataParameters[6].Value = pWorkResultRegister_T05Entity.VEND_PART_CODE;
                pDataParameters[7].Value = pWorkResultRegister_T05Entity.PART_HIGH;
                pDataParameters[8].Value = pWorkResultRegister_T05Entity.PART_MIDDLE;
                pDataParameters[9].Value = pWorkResultRegister_T05Entity.PART_LOW;
                pDataParameters[10].Value = pWorkResultRegister_T05Entity.ORDER_NUMBER;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T05_R10", pDataParameters);
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
                    "WorkResultRegister_Info_Mst(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 마스터 조회하기(Equipment) - WorkResultRegister_Info_Equip(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
        public DataTable WorkResultRegister_Info_Equip(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T05Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T05_R15", pDataParameters);
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
                    "WorkResultRegister_Info_Equip(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)",
                    pException
                );
            }
        }
        #endregion

        #region ○ 마스터 바인딩 조회하기 - WorkResultRegister_Info_Mst_Binding(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
        public DataTable WorkResultRegister_Info_Mst_Binding(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T05Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T05_R12", pDataParameters);
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
                    "WorkResultRegister_Info_Mst_Binding(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)",
                    pException
                );
            }
        }
        #endregion

        #region ○ 메인서브 조회하기 - WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
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
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T05Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T05Entity.LOT_ID;
                pDataParameters[2].Value = pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T05_R11", pDataParameters);
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
                    "WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)",
                    pException
                );
            }
        }

        #endregion

        #region PACKING 조회하기
        public DataTable WorkResultRegister_Info_Sub_Packing(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T05Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T05Entity.LOT_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T05_R16", pDataParameters);
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
                    "WorkResultRegister_Info_Sub_Packing(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 서브1 조회하기
        public DataTable WorkResultRegister_Info_Sub_Bad(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T05Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T05Entity.LOT_ID;
                pDataParameters[3].Value = pWorkResultRegister_T05Entity.PROCESS_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T05_R13", pDataParameters);
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
                    "WorkResultRegister_Info_Sub_Bad(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 서브2 조회하기
        public DataTable WorkResultRegister_Info_Sub_Status(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T05Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T05Entity.LOT_ID;
                pDataParameters[3].Value = pWorkResultRegister_T05Entity.PROCESS_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T05_R14", pDataParameters);
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
                    "WorkResultRegister_Info_Sub_Status(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 저장

        #region 데이터삽입

        public bool WorkResultRegister_Save(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity, DataTable dt, DataTable dtPacking, DataTable dtsub_Temp)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    for (int i = 0; i < pCount; i++)
                    {
                        //마스터 저장
                        IDataParameter[] pDataParametersA = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParametersA = new IDataParameter[]
                                {
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_property_value", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_condition_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_option_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_value", MySqlDbType.Decimal),
                            new MySqlParameter("@v_collection_value_str", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50)
                                };
                                break;

                            case "SQLServer":
                                pDataParametersA = new IDataParameter[]
                                {
                            new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_property_value", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_condition_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_option_code", SqlDbType.VarChar,50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_collection_value_str", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50)
                                };
                                break;
                        }

                        pDataParametersA[0].Value = dt.Rows[i]["RESOURCE_CODE"].ToString();
                        pDataParametersA[1].Value = dt.Rows[i]["COLLECTION_DATE"].ToString();
                        pDataParametersA[2].Value = dt.Rows[i]["PROPERTY_VALUE"].ToString();
                        pDataParametersA[3].Value = dt.Rows[i]["CONDITION_CODE"].ToString();
                        pDataParametersA[4].Value = dt.Rows[i]["OPTION_CODE"].ToString();
                        pDataParametersA[5].Value = dt.Rows[i]["COLLECTION_VALUE"].ToString();
                        pDataParametersA[6].Value = dt.Rows[i]["COLLECTION_VALUE_STR"].ToString();
                        pDataParametersA[7].Value = dt.Rows[i]["USER_CODE"].ToString();

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pWorkResultRegister_T05Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                        }
                    }
                }
                if (pErrorYN == false)
                {
                    //마스터 저장
                    IDataParameter[] pDataParametersB = null;

                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersB = new IDataParameter[]
                            {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_move_document_id", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_mat_document_id", MySqlDbType.VarChar, 50)
                            };
                            break;

                        case "SQLServer":
                            pDataParametersB = new IDataParameter[]
                            {
                                        new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_move_document_id", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_mat_document_id", SqlDbType.VarChar, 50)
                            };
                            break;
                    }

                    pDataParametersB[0].Value = "U";
                    pDataParametersB[1].Value = pWorkResultRegister_T05Entity.USER_CODE;
                    pDataParametersB[2].Value = pWorkResultRegister_T05Entity.LOT_ID;
                    pDataParametersB[3].Value = pWorkResultRegister_T05Entity.MTC_NO;
                    pDataParametersB[4].Value = pWorkResultRegister_T05Entity.MATERAL_TRS_NO;



                    DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T05_I11", pDataParametersB);

                    if (pDataTableB.Rows[0]["ERR_NO"].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    else
                    {
                        pWorkResultRegister_T05Entity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    }
                }

                if (pErrorYN == false)
                {
                    int pSubCount = 0;
                    if (dtsub_Temp != null)
                    {

                        pSubCount = dtsub_Temp.Rows.Count;
                        for (int i = 0; i < pSubCount; i++)
                        {
                            //마스터 저장
                            IDataParameter[] pDataParametersD = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersD = new IDataParameter[]
                                    {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_configuration_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_configuration_seq", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_document_revision", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_production_user", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_production_date", MySqlDbType.VarChar, 50)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersD = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                                        new SqlParameter("@v_lot_id", SqlDbType.VarChar, 15),
                                        new SqlParameter("@v_configuration_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_configuration_seq", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_document_revision", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                        new SqlParameter("@v_production_user", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_production_date", SqlDbType.VarChar, 50)
                                    };
                                    break;
                            }

                            pDataParametersD[0].Value = "C";
                            pDataParametersD[1].Value = pWorkResultRegister_T05Entity.USER_CODE;
                            pDataParametersD[2].Value = dtsub_Temp.Rows[i]["PRODUCTION_ORDER_ID"].ToString();
                            pDataParametersD[3].Value = dtsub_Temp.Rows[i]["LOT_ID"].ToString();
                            pDataParametersD[4].Value = dtsub_Temp.Rows[i]["CONFIGURATION_CODE"].ToString();
                            pDataParametersD[5].Value = dtsub_Temp.Rows[i]["CONFIGURATION_SEQ"].ToString();
                            pDataParametersD[6].Value = dtsub_Temp.Rows[i]["DOCUMENT_REVISION"].ToString();
                            pDataParametersD[7].Value = dtsub_Temp.Rows[i]["REMARK"].ToString();
                            pDataParametersD[8].Value = pWorkResultRegister_T05Entity.USER_CODE;
                            pDataParametersD[9].Value = DateTime.Parse(dtsub_Temp.Rows[i]["PRODUCTION_DATE"].ToString()).ToString("yyyy-MM-dd");


                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T05_I13", pDataParametersD);

                            if (pDataTableB.Rows[0]["ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                        }

                    }
                }

                if (pErrorYN == false)
                {
                    int pPackingCount = 0;
                    if (dtPacking != null)
                    {
                        pPackingCount = dtPacking.Rows.Count;
                        for (int i = 0; i < pPackingCount; i++)
                        {
                            //마스터 저장
                            IDataParameter[] pDataParametersC = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersC = new IDataParameter[]
                                    {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_packing_id", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_packing_date", MySqlDbType.VarChar, 8),
                                        new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_packing_qty", MySqlDbType.Decimal),
                                        new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 5)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersC = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_packing_id", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_packing_date", SqlDbType.VarChar, 8),
                                        new SqlParameter("@v_lot_id", SqlDbType.VarChar, 15),
                                        new SqlParameter("@v_packing_qty", SqlDbType.Decimal),
                                        new SqlParameter("@v_part_code", SqlDbType.VarChar,50),
                                        new SqlParameter("@v_use_yn", SqlDbType.VarChar, 5)
                                    };
                                    break;
                            }

                            pDataParametersC[0].Value = dtPacking.Rows[i]["CRUD"].ToString();
                            pDataParametersC[1].Value = pWorkResultRegister_T05Entity.USER_CODE;
                            pDataParametersC[2].Value = dtPacking.Rows[i]["PACKING_ID"].ToString();
                            pDataParametersC[3].Value = dtPacking.Rows[i]["PACKING_DATE"].ToString();
                            pDataParametersC[4].Value = dtPacking.Rows[i]["LOT_ID"].ToString();
                            pDataParametersC[5].Value = Convert.ToDecimal(dtPacking.Rows[i]["PACKING_QTY"].ToString());
                            pDataParametersC[6].Value = dtPacking.Rows[i]["PART_CODE"].ToString();
                            pDataParametersC[7].Value = dtPacking.Rows[i]["USE_YN"].ToString();

                            DataTable pDataTableC = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T05_I12", pDataParametersC);

                            if (pDataTableC.Rows[0]["ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            else
                            {
                                pWorkResultRegister_T05Entity.RTN_KEY = pDataTableC.Rows[0]["RTN_KEY"].ToString();
                            }
                        }
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
                    "WorkResultRegister_Save(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity, DataTable dt, DataTable dtPacking)",
                    pException
                );
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

        #region 완료처리

        public bool WorkResultRegister_Save_01(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity, DataTable dt)
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pWorkResultRegister_T05Entity.CRUD;
                pDataParametersA[1].Value = pWorkResultRegister_T05Entity.USER_CODE;
                pDataParametersA[2].Value = pWorkResultRegister_T05Entity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pWorkResultRegister_T05Entity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T05_I20", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pWorkResultRegister_T05Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultRegister_Save_01(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity, DataTable dt)",
                    pException
                );
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

        #endregion
    }

    public class WorkResultRegister_T06Provider : EntityManager<WorkResultRegister_T06Entity>
    {
        #region ○ 생성자 - WorkResultRegister_T06Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkResultRegister_T06Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }


        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override WorkResultRegister_T06Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultRegister_T06Entity pWorkResultRegister_T06Entity = new WorkResultRegister_T06Entity();

                pWorkResultRegister_T06Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultRegister_T06Entity;
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

        #region ○ 마스터 조회하기 - WorkResultRegister_Info_Mst(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_Info_Mst(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity)
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
                            new MySqlParameter("@v_shipment_status", MySqlDbType.VarChar,1),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                            //new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_part_high", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_part_middle", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_part_low", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_shipment_status", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                            //new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_vend_part_code", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_part_high", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_part_middle", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_part_low", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_order_number", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T06Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T06Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkResultRegister_T06Entity.DATE_TO;
                pDataParameters[3].Value = pWorkResultRegister_T06Entity.SHIPMENT_STATUS;
                pDataParameters[4].Value = pWorkResultRegister_T06Entity.USE_YN;
                //pDataParameters[3].Value = pWorkResultRegister_T06Entity.LOT_ID;
                //pDataParameters[4].Value = pWorkResultRegister_T06Entity.PRODUCTION_ORDER_ID;
                //pDataParameters[5].Value = pWorkResultRegister_T06Entity.PART_CODE;
                //pDataParameters[6].Value = pWorkResultRegister_T06Entity.VEND_PART_CODE;
                //pDataParameters[7].Value = pWorkResultRegister_T06Entity.PART_HIGH;
                //pDataParameters[8].Value = pWorkResultRegister_T06Entity.PART_MIDDLE;
                //pDataParameters[9].Value = pWorkResultRegister_T06Entity.PART_LOW;
                //pDataParameters[10].Value = pWorkResultRegister_T06Entity.ORDER_NUMBER;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T06_R10", pDataParameters);
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
                    "WorkResultRegister_Info_Mst(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기
        public DataTable WorkResultRegister_Info_Sub(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity)
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
                            new MySqlParameter("@v_shipment_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_shipment_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T06Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T06Entity.SHIPMENT_ID;
                pDataParameters[2].Value = pWorkResultRegister_T06Entity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T06_R20", pDataParameters);
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
                    "WorkResultRegister_Info_Sub(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 저장

        #region 데이터 삽입
        public bool WorkResultRegister_Save(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작

            try
            {
                IDataParameter[] pDataParameters = null;
                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                        new MySqlParameter("@v_shipment_id", MySqlDbType.VarChar,15),
                        new MySqlParameter("@v_shipment_date", MySqlDbType.VarChar,8),
                        new MySqlParameter("@v_shipment_status", MySqlDbType.VarChar,1),
                        new MySqlParameter("@v_shipment_standard", MySqlDbType.VarChar,50),
                        new MySqlParameter("@v_reference_id", MySqlDbType.VarChar,15),
                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000),
                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                        new SqlParameter("@v_shipment_id", SqlDbType.NVarChar,15),
                        new SqlParameter("@v_shipment_date", SqlDbType.NVarChar,8),
                        new SqlParameter("@v_shipment_status", SqlDbType.NVarChar,1),
                        new SqlParameter("@v_shipment_standard", SqlDbType.NVarChar,50),
                        new SqlParameter("@v_reference_id", SqlDbType.NVarChar,15),
                        new SqlParameter("@v_remark", SqlDbType.NVarChar,1000),
                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T06Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T06Entity.USER_CODE;
                pDataParameters[2].Value = pWorkResultRegister_T06Entity.SHIPMENT_ID;
                pDataParameters[3].Value = pWorkResultRegister_T06Entity.SHIPMENT_DATE;
                pDataParameters[4].Value = pWorkResultRegister_T06Entity.SHIPMENT_STATUS;
                pDataParameters[5].Value = pWorkResultRegister_T06Entity.SHIPMENT_STANDARD;
                pDataParameters[6].Value = pWorkResultRegister_T06Entity.REFERENCE_ID;
                pDataParameters[7].Value = pWorkResultRegister_T06Entity.REMARK;
                pDataParameters[8].Value = pWorkResultRegister_T06Entity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T06_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }else
                {
                    pWorkResultRegister_T06Entity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();

                    if (dt != null)
                    {
                        pCount = dt.Rows.Count;
                        for (int i = 0; i < pCount; i++)
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
                                        new MySqlParameter("@v_shipment_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_shipment_seq", MySqlDbType.VarChar, 10),
                                        new MySqlParameter("@v_shipment_item", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_shipment_item_qty", MySqlDbType.Decimal),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_shipment_id", SqlDbType.VarChar, 15),
                                        new SqlParameter("@v_shipment_seq", SqlDbType.VarChar, 10),
                                        new SqlParameter("@v_shipment_item", SqlDbType.VarChar, 15),
                                        new SqlParameter("@v_shipment_item_qty", SqlDbType.Decimal),
                                        new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                                    };
                                    break;
                            }

                            pDataParametersA[0].Value = dt.Rows[i]["CRUD"].ToString();
                            pDataParametersA[1].Value = pWorkResultRegister_T06Entity.USER_CODE;
                            pDataParametersA[2].Value = pWorkResultRegister_T06Entity.RTN_KEY == "" ? pWorkResultRegister_T06Entity.SHIPMENT_ID : pWorkResultRegister_T06Entity.RTN_KEY;
                            pDataParametersA[3].Value = dt.Rows[i]["SHIPMENT_SEQ"].ToString();
                            pDataParametersA[4].Value = dt.Rows[i]["SHIPMENT_ITEM"].ToString();
                            pDataParametersA[5].Value = dt.Rows[i]["SHIPMENT_ITEM_QTY"].ToString();
                            pDataParametersA[6].Value = dt.Rows[i]["REMARK"].ToString();
                            pDataParametersA[7].Value = dt.Rows[i]["USE_YN"].ToString();

                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T06_I20", pDataParametersA);
                            if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            else
                            {
                                pWorkResultRegister_T06Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                            }

                            //마스터 저장
                            IDataParameter[] pDataParametersB = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                        new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                                        new MySqlParameter("@v_property_value", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_condition_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_option_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_collection_value", MySqlDbType.Decimal),
                                        new MySqlParameter("@v_collection_value_str", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                                        new SqlParameter("@v_property_value", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_condition_code", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_option_code", SqlDbType.VarChar,50),
                                        new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                                        new SqlParameter("@v_collection_value_str", SqlDbType.VarChar, 50),
                                        new SqlParameter("@v_user_code", SqlDbType.VarChar, 50)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = "";
                            pDataParametersB[1].Value = DateTime.Now.ToString("yyyyMMddHHmmss");
                            pDataParametersB[2].Value = dt.Rows[i]["LOT_ID"].ToString();
                            pDataParametersB[3].Value = "CD501002";
                            pDataParametersB[4].Value = "PC190005";
                            pDataParametersB[5].Value = dt.Rows[i]["PACKING_QTY"].ToString();
                            pDataParametersB[6].Value = "";
                            pDataParametersB[7].Value = pWorkResultRegister_T06Entity.USER_CODE;

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersB);
                            if (pDataTableB.Rows[0]["ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                        }
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
                    "WorkResultRegister_Save(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity, DataTable dt)",
                    pException
                );
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

        #endregion
    }

    public class WorkResultRegister_T07Provider : EntityManager<WorkResultRegister_T07Entity>
    {
        #region ○ 생성자 - WorkResultRegister_T07Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkResultRegister_T07Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }


        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override WorkResultRegister_T07Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultRegister_T07Entity pWorkResultRegister_T07Entity = new WorkResultRegister_T07Entity();

                pWorkResultRegister_T07Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultRegister_T07Entity;
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

        #region ○ 마스터 조회하기 - WorkResultRegister_T07_Info_Mst(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_T07_Info_Mst(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T07Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T07Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkResultRegister_T07Entity.DATE_TO;
                pDataParameters[3].Value = pWorkResultRegister_T07Entity.PART_CODE;
                pDataParameters[4].Value = pWorkResultRegister_T07Entity.PART_NAME;
                pDataParameters[5].Value = pWorkResultRegister_T07Entity.PROCESS_CODE_MST;
                pDataParameters[6].Value = pWorkResultRegister_T07Entity.PROCESS_CODE;
                pDataParameters[7].Value = pWorkResultRegister_T07Entity.PRODUCTION_ORDER_ID;
                pDataParameters[8].Value = pWorkResultRegister_T07Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T07_R10", pDataParameters);
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
                    "WorkResultRegister_T07_Info_Mst(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 서브1 조회하기 - WorkResultRegister_T07_Info_Sub1(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_T07_Info_Sub1(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_code_gubn", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_code_gubn", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T07Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T07Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T07Entity.CODE_GUBN;
                pDataParameters[3].Value = pWorkResultRegister_T07Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T07_R20", pDataParameters);
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
                    "WorkResultRegister_T07_Info_Mst(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장 WorkResultRegister_T07_Save(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity, DataTable dt)

        public bool WorkResultRegister_T07_Save(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity, DataTable dt)
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
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                    new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                                    new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper(); //pWorkResultRegisterEntity.CRUD;
                        pDataParameters[1].Value = pWorkResultRegister_T07Entity.USER_CODE;
                        pDataParameters[2].Value = dt.Rows[a]["PRODUCTION_ORDER_ID"].ToString();
                        pDataParameters[3].Value = dt.Rows[a]["COMPLETE_YN"].ToString();


                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pWorkResultRegister_T07Entity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                        pWorkResultRegister_T07Entity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                        pWorkResultRegister_T07Entity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                        pWorkResultRegister_T07Entity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                        pWorkResultRegister_T07Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();


                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;

                throw pExceptionManager;
            }
            finally
            {
                pWorkResultRegister_T07Entity.PART_CODE = "";
                pWorkResultRegister_T07Entity.PART_NAME = "";
                pWorkResultRegister_T07Entity.PROCESS_CODE_MST = "";
                pWorkResultRegister_T07Entity.PROCESS_CODE = "";
                pWorkResultRegister_T07Entity.PRODUCTION_ORDER_ID = "";

                if (pErrorYN)
                    _pDBManager.RollbackTransaction();  // 저장실패
                else
                    _pDBManager.CommitTransaction();
            }

            return pErrorYN;
        }

        #endregion
    }


    public class WorkResultRegister_T50Provider : EntityManager<WorkResultRegister_T50Entity>
    {
        #region ○ 생성자 - WorkResultRegister_T50Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkResultRegister_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }


        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override WorkResultRegister_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultRegister_T50Entity pWorkResultRegister_T50Entity = new WorkResultRegister_T50Entity();

                pWorkResultRegister_T50Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultRegister_T50Entity;
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

        #region ○ 마스터 조회하기 - WorkResultRegister_T50_Info_Mst(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_T50_Info_Mst(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T50Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T50Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkResultRegister_T50Entity.DATE_TO;
                pDataParameters[3].Value = pWorkResultRegister_T50Entity.PART_CODE;
                pDataParameters[4].Value = pWorkResultRegister_T50Entity.PART_NAME;
                pDataParameters[5].Value = pWorkResultRegister_T50Entity.PROCESS_CODE_MST;
                pDataParameters[6].Value = pWorkResultRegister_T50Entity.PROCESS_CODE;
                pDataParameters[7].Value = pWorkResultRegister_T50Entity.PRODUCTION_ORDER_ID;
                pDataParameters[8].Value = pWorkResultRegister_T50Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T50_R10", pDataParameters);
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
                    "WorkResultRegister_T50_Info_Mst(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 서브1 조회하기 - WorkResultRegister_T50_Info_Sub1(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultRegister_T50_Info_Sub1(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 6),
                            new MySqlParameter("@v_code_gubn", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_seq", SqlDbType.VarChar, 6),
                            new SqlParameter("@v_code_gubn", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T50Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T50Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pWorkResultRegister_T50Entity.PRODUCTION_ORDER_SEQ;
                pDataParameters[3].Value = pWorkResultRegister_T50Entity.CODE_GUBN;
                pDataParameters[4].Value = pWorkResultRegister_T50Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T50_R20", pDataParameters);
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
                    "WorkResultRegister_T50_Info_Mst(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장 WorkResultRegister_T50_Save(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity, DataTable dt)

        public bool WorkResultRegister_T50_Save(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity, DataTable dt)
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
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 6),
                                    new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                    new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                                    new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper(); //pWorkResultRegisterEntity.CRUD;
                        pDataParameters[1].Value = pWorkResultRegister_T50Entity.USER_CODE;
                        pDataParameters[2].Value = dt.Rows[a]["PRODUCTION_ORDER_ID"].ToString();
                        pDataParameters[3].Value = dt.Rows[a]["PRODUCTION_ORDER_SEQ"].ToString();
                        pDataParameters[4].Value = dt.Rows[a]["COMPLETE_YN"].ToString();


                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T50_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pWorkResultRegister_T50Entity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                        pWorkResultRegister_T50Entity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                        pWorkResultRegister_T50Entity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                        pWorkResultRegister_T50Entity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                        pWorkResultRegister_T50Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();


                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;

                throw pExceptionManager;
            }
            finally
            {
                pWorkResultRegister_T50Entity.PART_CODE = "";
                pWorkResultRegister_T50Entity.PART_NAME = "";
                pWorkResultRegister_T50Entity.PROCESS_CODE_MST = "";
                pWorkResultRegister_T50Entity.PROCESS_CODE = "";
                pWorkResultRegister_T50Entity.PRODUCTION_ORDER_ID = "";

                if (pErrorYN)
                    _pDBManager.RollbackTransaction();  // 저장실패
                else
                    _pDBManager.CommitTransaction();
            }

            return pErrorYN;
        }

        #endregion
    }

    public class OutsourcingInfoRegister_Provider : EntityManager<OutsourcingInfoRegisterEntity>
    {
        #region ○ 생성자 - OutsourcingInfoRegister_Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public OutsourcingInfoRegister_Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override OutsourcingInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity = new OutsourcingInfoRegisterEntity();

                pOutsourcingInfoRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pOutsourcingInfoRegisterEntity;
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

        #region ○ 마스터 조회하기 - OutsourcingInfoRegister_Info_Mst(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)
        public DataTable OutsourcingInfoRegister_Info_Mst(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)
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
                            //new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_part_high", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_part_middle", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_part_low", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_outsourcing_status", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            //new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_vend_part_code", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_part_high", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_part_middle", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_part_low", SqlDbType.VarChar, 50),
                            //new SqlParameter("@v_order_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_outsourcing_status", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)

                        };
                        break;
                }

                pDataParameters[0].Value = pOutsourcingInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pOutsourcingInfoRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pOutsourcingInfoRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pOutsourcingInfoRegisterEntity.OUTSOURCING_STATUS;
                pDataParameters[4].Value = pOutsourcingInfoRegisterEntity.USE_YN;
                //pDataParameters[3].Value = pOutsourcingInfoRegisterEntity.LOT_ID;
                //pDataParameters[4].Value = pOutsourcingInfoRegisterEntity.PRODUCTION_ORDER_ID;
                //pDataParameters[5].Value = pOutsourcingInfoRegisterEntity.PART_CODE;
                //pDataParameters[6].Value = pOutsourcingInfoRegisterEntity.VEND_PART_CODE;
                //pDataParameters[7].Value = pOutsourcingInfoRegisterEntity.PART_HIGH;
                //pDataParameters[8].Value = pOutsourcingInfoRegisterEntity.PART_MIDDLE;
                //pDataParameters[9].Value = pOutsourcingInfoRegisterEntity.PART_LOW;
                //pDataParameters[10].Value = pOutsourcingInfoRegisterEntity.ORDER_NUMBER;
                //pDataParameters[11].Value = pOutsourcingInfoRegisterEntity.OUTSOURCING_STATUS;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_OutsourcingInfoRegister_R10", pDataParameters);
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
                    "OutsourcingInfoRegister_Info_Mst(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)",
                    pException
                );
            }
        }
        #endregion

        #region ○ 서브 조회하기 - OutsourcingInfoRegister_Info_Mst(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)
        public DataTable OutsourcingInfoRegister_Info_Sub(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_outsourcing_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_outsourcing_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)

                        };
                        break;
                }

                pDataParameters[0].Value = pOutsourcingInfoRegisterEntity.OUTSOURCING_ID;
                pDataParameters[1].Value = pOutsourcingInfoRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_OutsourcingInfoRegister_R20", pDataParameters);
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
                    "OutsourcingInfoRegister_Info_Sub(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)",
                    pException
                );
            }
        }
        #endregion

        #region ○ 저장 - OutsourcingInfoRegister_Info_Mst(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)
        public bool OutsourcingInfoRegister_Save(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작

            try
            {
                IDataParameter[] pDataParameters = null;
                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                        new MySqlParameter("@v_outsourcing_id", MySqlDbType.VarChar,15),
                        new MySqlParameter("@v_outsourcing_date", MySqlDbType.VarChar,8),
                        new MySqlParameter("@v_vend_code", MySqlDbType.VarChar,10),
                        new MySqlParameter("@v_outsourcing_user", MySqlDbType.VarChar,20),
                        new MySqlParameter("@v_outsourcing_number", MySqlDbType.VarChar,20),
                        new MySqlParameter("@v_outsourcing_status", MySqlDbType.VarChar,1),
                        new MySqlParameter("@v_reference_id", MySqlDbType.VarChar,20),
                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000),
                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                        new SqlParameter("@v_outsourcing_id", SqlDbType.NVarChar,15),
                        new SqlParameter("@v_outsourcing_date", SqlDbType.NVarChar,8),
                        new SqlParameter("@v_vend_code", SqlDbType.NVarChar,10),
                        new SqlParameter("@v_outsourcing_user", SqlDbType.NVarChar,20),
                        new SqlParameter("@v_outsourcing_number", SqlDbType.NVarChar,20),
                        new SqlParameter("@v_outsourcing_status", SqlDbType.NVarChar,8),
                        new SqlParameter("@v_reference_id", SqlDbType.NVarChar,8),
                        new SqlParameter("@v_remark", SqlDbType.NVarChar,1000),
                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParameters[0].Value = pOutsourcingInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pOutsourcingInfoRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pOutsourcingInfoRegisterEntity.OUTSOURCING_ID;
                pDataParameters[3].Value = pOutsourcingInfoRegisterEntity.OUTSOURCING_DATE;
                pDataParameters[4].Value = pOutsourcingInfoRegisterEntity.VEND_CODE;
                pDataParameters[5].Value = pOutsourcingInfoRegisterEntity.OUTSOURCING_USER;
                pDataParameters[6].Value = pOutsourcingInfoRegisterEntity.OUTSOURCING_NUMBER;
                pDataParameters[7].Value = pOutsourcingInfoRegisterEntity.OUTSOURCING_STATUS;
                pDataParameters[8].Value = pOutsourcingInfoRegisterEntity.REFERENCE_ID;
                pDataParameters[9].Value = pOutsourcingInfoRegisterEntity.REMARK;
                pDataParameters[10].Value = pOutsourcingInfoRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_OutsourcingInfoRegister_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }else
                {
                    pOutsourcingInfoRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();

                    if (dt != null)
                    {
                        pCount = dt.Rows.Count;

                        for (int i = 0; i < pCount; i++)
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
                                    new MySqlParameter("@v_outsourcing_id", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_outsourcing_seq", MySqlDbType.VarChar, 6),
                                    new MySqlParameter("@v_outsourcing_item", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_outsourcing_item_qty", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_outsourcing_memo", MySqlDbType.VarChar, 1000),
                                    new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                    new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {
                                    new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_outsourcing_id", SqlDbType.VarChar, 15),
                                    new SqlParameter("@v_outsourcing_seq", SqlDbType.VarChar,6),
                                    new SqlParameter("@v_outsourcing_item", SqlDbType.VarChar, 15),
                                    new SqlParameter("@v_outsourcing_item_qty", SqlDbType.Decimal),
                                    new SqlParameter("@v_outsourcing_memo", SqlDbType.VarChar, 1000),
                                    new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                    new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                                    };
                                    break;
                            }

                            pDataParametersA[0].Value = dt.Rows[i]["CRUD"].ToString();
                            pDataParametersA[1].Value = pOutsourcingInfoRegisterEntity.USER_CODE;
                            pDataParametersA[2].Value = pOutsourcingInfoRegisterEntity.OUTSOURCING_ID == "" ? pOutsourcingInfoRegisterEntity.RTN_KEY : pOutsourcingInfoRegisterEntity.OUTSOURCING_ID;
                            pDataParametersA[3].Value = dt.Rows[i]["OUTSOURCING_SEQ"].ToString();
                            pDataParametersA[4].Value = dt.Rows[i]["LOT_ID"].ToString();
                            pDataParametersA[5].Value = dt.Rows[i]["OUTSOURCING_ITEM_QTY"].ToString();
                            pDataParametersA[6].Value = dt.Rows[i]["OUTSOURCING_MEMO"].ToString();
                            pDataParametersA[7].Value = dt.Rows[i]["REMARK"].ToString();
                            pDataParametersA[8].Value = "Y";

                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_OutsourcingInfoRegister_I20", pDataParametersA);
                            if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            else
                            {
                                //pOutsourcingInfoRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                            }
                        }
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
                    "OutsourcingInfoRegister_Save(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity, DataTable dt)",
                    pException
                );
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



    public class ucOutsourcingInfoPopupProvider : EntityManager<ucOutsourcingInfoPopupEntity>
    {
        #region ○ 생성자 - ucOutsourcingInfoPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucOutsourcingInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override ucOutsourcingInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucOutsourcingInfoPopupEntity pucOutsourcingInfoPopupEntity = new ucOutsourcingInfoPopupEntity();

                pucOutsourcingInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucOutsourcingInfoPopupEntity;
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

        #region 마스터 조회하기
        public DataTable ucOutsourcingInfoPopup_Mst(ucOutsourcingInfoPopupEntity pucOutsourcingInfoPopupEntity)
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
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_high", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_middle", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_low", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_lot_no", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_order_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_high", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_middle", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_low", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pucOutsourcingInfoPopupEntity.CRUD;
                pDataParameters[1].Value = pucOutsourcingInfoPopupEntity.LOT_ID;
                pDataParameters[2].Value = pucOutsourcingInfoPopupEntity.LOT_NO;
                pDataParameters[3].Value = pucOutsourcingInfoPopupEntity.ORDER_NUMBER;
                pDataParameters[4].Value = pucOutsourcingInfoPopupEntity.PART_CODE;
                pDataParameters[5].Value = pucOutsourcingInfoPopupEntity.VEND_PART_CODE;
                pDataParameters[6].Value = pucOutsourcingInfoPopupEntity.PART_HIGH;
                pDataParameters[7].Value = pucOutsourcingInfoPopupEntity.PART_MIDDLE;
                pDataParameters[8].Value = pucOutsourcingInfoPopupEntity.PART_LOW;
                

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucOutsourcingInfoPopup_R10", pDataParameters);
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
                    "ucOutsourcingInfoPopup_Mst(ucOutsourcingInfoPopupEntity pucOutsourcingInfoPopupEntity)",
                    pException
                );
            }
        }
        #endregion
    }

    public class ucShipmentInfoPopupProvider : EntityManager<ucShipmentInfoPopupEntity>
    {
        #region ○ 생성자 - ucShipmentInfoPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucShipmentInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override ucShipmentInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucShipmentInfoPopupEntity pucShipmentInfoPopupEntity = new ucShipmentInfoPopupEntity();

                pucShipmentInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucShipmentInfoPopupEntity;
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

        #region 마스터 조회하기
        public DataTable ucShipmentInfoPopup_Mst(ucShipmentInfoPopupEntity pucShipmentInfoPopupEntity)
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
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_high", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_middle", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_low", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_lot_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_lot_no", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_order_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_high", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_middle", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_low", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pucShipmentInfoPopupEntity.CRUD;
                pDataParameters[1].Value = pucShipmentInfoPopupEntity.LOT_ID;
                pDataParameters[2].Value = pucShipmentInfoPopupEntity.LOT_NO;
                pDataParameters[3].Value = pucShipmentInfoPopupEntity.ORDER_NUMBER;
                pDataParameters[4].Value = pucShipmentInfoPopupEntity.PART_CODE;
                pDataParameters[5].Value = pucShipmentInfoPopupEntity.VEND_PART_CODE;
                pDataParameters[6].Value = pucShipmentInfoPopupEntity.PART_HIGH;
                pDataParameters[7].Value = pucShipmentInfoPopupEntity.PART_MIDDLE;
                pDataParameters[8].Value = pucShipmentInfoPopupEntity.PART_LOW;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucShipmentInfoPopup_R10", pDataParameters);
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
                    "ucShipmentInfoPopup_Mst(ucShipmentInfoPopupEntity pucShipmentInfoPopupEntity)",
                    pException
                );
            }
        }
        #endregion
    }

    public class ucProductionPartListPopup_T01Provider : EntityManager<ucProductionPartListPopup_T01Entity>
    {
        #region 생성자 - ucProductionPartListPopup_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucProductionPartListPopup_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 조회하기 ucProductionPartListPopup_Info_Return(ucProductionPartListPopup_T01Entity pucProductionPartListPopup_T01Entity)

        public DataTable ucProductionPartListPopup_Info_Return(ucProductionPartListPopup_T01Entity pucProductionPartListPopup_T01Entity)
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
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_part_revision_no", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_part_high", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_middle", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_low", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_vend_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_part_revision_no", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_part_high", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_middle", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_low", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucProductionPartListPopup_T01Entity.CRUD;
                pDataParameters[1].Value = pucProductionPartListPopup_T01Entity.VEND_PART_CODE;
                pDataParameters[2].Value = pucProductionPartListPopup_T01Entity.PART_NAME;
                pDataParameters[3].Value = pucProductionPartListPopup_T01Entity.PART_REVISION_NO;
                pDataParameters[4].Value = pucProductionPartListPopup_T01Entity.PART_HIGH;
                pDataParameters[5].Value = pucProductionPartListPopup_T01Entity.PART_MIDDLE;
                pDataParameters[6].Value = pucProductionPartListPopup_T01Entity.PART_LOW;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProductionPartListPopup_R10", pDataParameters);
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
                    "ucProductionPartListPopup_Info_Return(ucProductionPartListPopup_T01Entity pucProductionPartListPopup_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucProductionPartListPopup_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucProductionPartListPopup_T01Entity pucProductionPartListPopup_T01Entity = new ucProductionPartListPopup_T01Entity();
                return pucProductionPartListPopup_T01Entity;
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

    public class ucMaterialUsagePartListPopupProvider : EntityManager<ucMaterialUsagePartListPopupEntity>
    {
        #region 생성자 - ucMaterialUsagePartListPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucMaterialUsagePartListPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 조회하기 ucMaterialUsagePartListPopup_Info_Return(ucMaterialUsagePartListPopupEntity pucMaterialUsagePartListPopupEntity)

        public DataTable ucMaterialUsagePartListPopup_Info_Return(ucMaterialUsagePartListPopupEntity pucMaterialUsagePartListPopupEntity)
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
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_part_revision_no", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_part_high", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_middle", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_low", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_vend_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_part_revision_no", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_part_high", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_middle", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_low", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucMaterialUsagePartListPopupEntity.CRUD;
                pDataParameters[1].Value = pucMaterialUsagePartListPopupEntity.VEND_PART_CODE;
                pDataParameters[2].Value = pucMaterialUsagePartListPopupEntity.PART_NAME;
                pDataParameters[3].Value = pucMaterialUsagePartListPopupEntity.PART_REVISION_NO;
                pDataParameters[4].Value = pucMaterialUsagePartListPopupEntity.PART_HIGH;
                pDataParameters[5].Value = pucMaterialUsagePartListPopupEntity.PART_MIDDLE;
                pDataParameters[6].Value = pucMaterialUsagePartListPopupEntity.PART_LOW;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMaterialUsagePartListPopup_R10", pDataParameters);
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
                    "ucMaterialUsagePartListPopup_Info_Return(ucMaterialUsagePartListPopupEntity pucMaterialUsagePartListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucMaterialUsagePartListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucMaterialUsagePartListPopupEntity pucMaterialUsagePartListPopupEntity = new ucMaterialUsagePartListPopupEntity();
                return pucMaterialUsagePartListPopupEntity;
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

    public class ucMeterialUsagePopupProvider : EntityManager<ucMeterialUsagePopupEntity>
    {
        #region 생성자 - ucMeterialUsagePopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucMeterialUsagePopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 조회하기 ucMeterialUsagePopup_Info_Return(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)

        public DataTable ucMeterialUsagePopup_Info_Return(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucMeterialUsagePopupEntity.CRUD;
                pDataParameters[1].Value = pucMeterialUsagePopupEntity.PART_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMeterialUsagePopup_R10", pDataParameters);
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
                    "ucMeterialUsagePopup_Info_Return(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 정보 조회하기 ucMeterialUsagePopup_Sub_Return(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)

        public DataTable ucMeterialUsagePopup_Sub_Return(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_lot_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucMeterialUsagePopupEntity.CRUD;
                pDataParameters[1].Value = pucMeterialUsagePopupEntity.PRODUCTINO_ORDER_ID;
                pDataParameters[2].Value = pucMeterialUsagePopupEntity.LOT_ID;
                pDataParameters[3].Value = pucMeterialUsagePopupEntity.PROCESS_CODE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMeterialUsagePopup_R20", pDataParameters);
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
                    "ucMeterialUsagePopup_Sub_Return(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 조회하기 ucMeterialUsagePopup_Info_Save(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity, DataTable dt)
        public bool ucMeterialUsagePopup_Info_Save(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction(); //Transaction 시작

            try
            {
                int pCount = 0;

                if (dt != null)
                {
                    pCount = dt.Rows.Count;
                    for (int i = 0; i < pCount; i++)
                    {
                        //마스터 저장
                        IDataParameter[] pDataParametersB = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParametersB = new IDataParameter[]
                                {
                                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                            new MySqlParameter("@v_matstock_id", MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_matstock_detail_seq", MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_usage_date", MySqlDbType.VarChar, 8),
                                            new MySqlParameter("@v_usage_qty", MySqlDbType.Decimal)
                                };
                                break;
                            case "SQLServer":
                                pDataParametersB = new IDataParameter[]
                                {
                                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                            new SqlParameter("@v_matstock_id", SqlDbType.NVarChar, 15),
                                            new SqlParameter("@v_matstock_detail_seq", SqlDbType.NVarChar, 15),
                                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar, 15),
                                            new SqlParameter("@v_lot_id", SqlDbType.NVarChar, 15),
                                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 15),
                                            new SqlParameter("@v_usage_date", SqlDbType.VarChar, 8),
                                            new SqlParameter("@v_usage_qty", SqlDbType.Decimal)
                                };
                                break;
                        }

                        pDataParametersB[0].Value = dt.Rows[i]["CRUD"].ToString();
                        pDataParametersB[1].Value = pucMeterialUsagePopupEntity.USER_CODE;
                        pDataParametersB[2].Value = dt.Rows[i]["MATSTOCK_ID"].ToString();
                        pDataParametersB[3].Value = dt.Rows[i]["MATSTOCK_DETAIL_SEQ"].ToString();
                        pDataParametersB[4].Value = dt.Rows[i]["PRODUCTION_ORDER_ID"].ToString();
                        pDataParametersB[5].Value = dt.Rows[i]["LOT_ID"].ToString();
                        pDataParametersB[6].Value = dt.Rows[i]["PROCESS_CODE"].ToString();
                        pDataParametersB[7].Value = dt.Rows[i]["USAGE_DATE"].ToString();
                        pDataParametersB[8].Value = Convert.ToDecimal(dt.Rows[i]["USAGE_QTY"].ToString());

                        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMeterialUsagePopup_I10", pDataParametersB);

                        if (pDataTableB.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                    }
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
                    _pDBManager.RollbackTransaction();  // 저장 실패 Rollback Transaction 
                else
                    _pDBManager.CommitTransaction();  // 저장 성공  Commit Transaction
            }
            return pErrorYN;
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucMeterialUsagePopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity = new ucMeterialUsagePopupEntity();
                return pucMeterialUsagePopupEntity;
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

    public class ucOrderNumberInfoListPopupProvider : EntityManager<ucOrderNumberInfoListPopupEntity>
    {
        public ucOrderNumberInfoListPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #region ○ 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ucOrderNumberInfoListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucOrderNumberInfoListPopupEntity pucOrderNumberInfoListPopupEntity = new ucOrderNumberInfoListPopupEntity();

                pucOrderNumberInfoListPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucOrderNumberInfoListPopupEntity;
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

        public DataTable OrderNumber_Info_Mst(ucOrderNumberInfoListPopupEntity pucOrderNumberInfoListPopupEntity)
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
                            new MySqlParameter("@v_order_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_order_name", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_order_number", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_order_name", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pucOrderNumberInfoListPopupEntity.CRUD;
                pDataParameters[1].Value = pucOrderNumberInfoListPopupEntity.DATE_FROM;
                pDataParameters[2].Value = pucOrderNumberInfoListPopupEntity.DATE_TO;
                pDataParameters[3].Value = pucOrderNumberInfoListPopupEntity.ORDER_NUMBER;
                pDataParameters[4].Value = pucOrderNumberInfoListPopupEntity.ORDER_NAME;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucOrderNumberInfoListPopup_R10", pDataParameters);
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
                    "OrderNumber_Info_Mst(ucOrderNumberInfoListPopupEntity pucOrderNumberInfoListPopupEntity)",
                    pException
                );
            }
        }

        #endregion
        
    }

    public class ProductResultHistoryProvider : EntityManager<ProductResultHistoryEntity>
    {
        #region 생성자 - ProductResultHistoryProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductResultHistoryProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - ProductResultHistory_Info_Mst(ProductResultHistoryEntity pProductResultHistoryEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductResultHistoryEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductResultHistory_Info_Mst(ProductResultHistoryEntity pProductResultHistoryEntity)
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
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                            
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_lot_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductResultHistoryEntity.CRUD;
                pDataParameters[1].Value = pProductResultHistoryEntity.DATE_FROM;
                pDataParameters[2].Value = pProductResultHistoryEntity.DATE_TO;
                pDataParameters[3].Value = pProductResultHistoryEntity.PART_CODE;
                pDataParameters[4].Value = pProductResultHistoryEntity.PART_NAME;
                pDataParameters[5].Value = pProductResultHistoryEntity.PROCESS_CODE;
                pDataParameters[6].Value = pProductResultHistoryEntity.PROCESS_NAME;
                pDataParameters[7].Value = pProductResultHistoryEntity.ORDER_ID;
                pDataParameters[8].Value = pProductResultHistoryEntity.LOT_NO;
                pDataParameters[9].Value = pProductResultHistoryEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductResultHistory_R10", pDataParameters);

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
                    "ProductResultHistory_Info_Mst(ProductResultHistoryEntity pProductResultHistoryEntity)",
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
        public override ProductResultHistoryEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductResultHistoryEntity pProductResultHistoryEntity = new ProductResultHistoryEntity();

                //pProductResultHistoryEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProductResultHistoryEntity;
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

    public class ProductGoalMonthProvider : EntityManager<ProductGoalMonthEntity>
    {
        #region 생성자 - ProductGoalMonthProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductGoalMonthProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - ProductGoalMonth_Info_Mst(ProductGoalMonthEntity pProductGoalMonthEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductGoalMonthEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductGoalMonth_Info_Mst(ProductGoalMonthEntity pProductGoalMonthEntity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 6),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_goal_type", MySqlDbType.VarChar, 10),

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_lot_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductGoalMonthEntity.CRUD;
                pDataParameters[1].Value = pProductGoalMonthEntity.DATE_FROM;
                pDataParameters[2].Value = pProductGoalMonthEntity.USER_CODE;
                pDataParameters[3].Value = pProductGoalMonthEntity.GOAL_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductGoalMonth_R10", pDataParameters);

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
                    "ProductGoalMonth_Info_Mst(ProductGoalMonthEntity pProductGoalMonthEntity)",
                    pException
                );
            }
        }

        #endregion

        #region FPD 마스터 조회하기 - ProductGoalMonth_Info_Mst(ProductGoalMonthEntity pProductGoalMonthEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductGoalMonthEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductGoalMonth_Info_Mst2(ProductGoalMonthEntity pProductGoalMonthEntity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 6),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_goal_type", MySqlDbType.VarChar, 10),

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_lot_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductGoalMonthEntity.CRUD;
                pDataParameters[1].Value = pProductGoalMonthEntity.DATE_FROM;
                pDataParameters[2].Value = pProductGoalMonthEntity.USER_CODE;
                pDataParameters[3].Value = pProductGoalMonthEntity.GOAL_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductGoalMonth_R20", pDataParameters);

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
                    "ProductGoalMonth_Info_Mst(ProductGoalMonthEntity pProductGoalMonthEntity)",
                    pException
                );
            }
        }

        #endregion

        #region FPD 마스터 조회하기 - ProductGoalMonth_Info_Mst(ProductGoalMonthEntity pProductGoalMonthEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductGoalMonthEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductGoalMonth_Info_Mst3(ProductGoalMonthEntity pProductGoalMonthEntity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 6),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_goal_type", MySqlDbType.VarChar, 10),

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_lot_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductGoalMonthEntity.CRUD;
                pDataParameters[1].Value = pProductGoalMonthEntity.DATE_FROM;
                pDataParameters[2].Value = pProductGoalMonthEntity.USER_CODE;
                pDataParameters[3].Value = pProductGoalMonthEntity.GOAL_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductGoalMonth_R30", pDataParameters);

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
                    "ProductGoalMonth_Info_Mst(ProductGoalMonthEntity pProductGoalMonthEntity)",
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
        public override ProductGoalMonthEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductGoalMonthEntity pProductGoalMonthEntity = new ProductGoalMonthEntity();

                //pProductGoalMonthEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProductGoalMonthEntity;
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

        #region ○ 데이터 저장 ProductGoalMonth_Save(ProductGoalMonthEntity pProductGoalMonthEntity, DataTable dt)

        public bool ProductGoalMonth_Save(ProductGoalMonthEntity pProductGoalMonthEntity, DataTable dt)
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
                        if (dt.Rows[a]["CRUD"].ToString() == "U")
                        {
                            IDataParameter[] pDataParameters = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParameters = new IDataParameter[]
                                    {
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                    new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 6),
                                    new MySqlParameter("@v_goal_type", MySqlDbType.VarChar, 10),
                                    new MySqlParameter("@v_goal_cost", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParameters = new IDataParameter[]
                                    {
                                    new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                                    new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                                    };
                                    break;
                            }

                            pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper(); //pWorkResultRegisterEntity.CRUD;
                            pDataParameters[1].Value = dt.Rows[a]["GOAL_MONTH"].ToString();
                            pDataParameters[2].Value = dt.Rows[a]["GOAL_TYPE"].ToString(); // GOAL_TYPE : 미사용(추후 제품구분 시 사용예정)
                            pDataParameters[3].Value = dt.Rows[a]["GOAL_COST"].ToString();
                            pDataParameters[4].Value = dt.Rows[a]["REMARK"].ToString();
                            pDataParameters[5].Value = pProductGoalMonthEntity.USER_CODE;


                            DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductGoalMonth_I10", pDataParameters);

                            if (pDataTable.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                        }
                    }
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

    public class ucWorkResultPopUp_T01Provider : EntityManager<ucWorkResultPopUp_T01_Entity>
    {
        #region ○ 개체구하기
        public override ucWorkResultPopUp_T01_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity = new ucWorkResultPopUp_T01_Entity();
                pucWorkResultPopUp_T01_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucWorkResultPopUp_T01_Entity;
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

        #region ○ 생성자 - ucWorkResultPopUp_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucWorkResultPopUp_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 저장하기 - WorkResultInfo_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)


        public bool WorkResultInfo_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)
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
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_property_value", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_condition_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_value", MySqlDbType.Decimal),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_property_value", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_condition_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucWorkResultPopUp_T01_Entity.RESOURCE_CODE;
                pDataParametersA[1].Value = pucWorkResultPopUp_T01_Entity.COLLECTION_DATE;
                pDataParametersA[2].Value = pucWorkResultPopUp_T01_Entity.PROPERTY_VALUE;
                pDataParametersA[3].Value = pucWorkResultPopUp_T01_Entity.CONDITION_CODE;
                pDataParametersA[4].Value = pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                pDataParametersA[5].Value = pucWorkResultPopUp_T01_Entity.PART_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pucWorkResultPopUp_T01_Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)",
                    pException
                );
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


        public bool WorkResultInfo_Save_01(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucWorkResultPopUp_T01_Entity.CRUD;
                pDataParametersA[1].Value = pucWorkResultPopUp_T01_Entity.USER_CODE;
                pDataParametersA[2].Value = pucWorkResultPopUp_T01_Entity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pucWorkResultPopUp_T01_Entity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pucWorkResultPopUp_T01_Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)",
                    pException
                );
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

        public bool WorkResultInfo_Save_02(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucWorkResultPopUp_T01_Entity.CRUD;
                pDataParametersA[1].Value = pucWorkResultPopUp_T01_Entity.USER_CODE;
                pDataParametersA[2].Value = pucWorkResultPopUp_T01_Entity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pucWorkResultPopUp_T01_Entity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T01_I70", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pucWorkResultPopUp_T01_Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)",
                    pException
                );
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

        //18.09.20
        //에이치피앤씨 -> 포장일경우에는 BOM조회 - > 부자재 불량등록
        public bool WorkResultInfo_Save_02(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity,DataTable pDataTable)
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
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_property_value", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_condition_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_value", MySqlDbType.Decimal),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_property_value", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_condition_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50)
                        };
                        break;
                }
                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(pDataTable.Rows[i]["PRODUCTION_NG_RESULT"].ToString()) > 0)
                    {
                        pDataParametersA[0].Value = pucWorkResultPopUp_T01_Entity.RESOURCE_CODE;
                        pDataParametersA[1].Value = pucWorkResultPopUp_T01_Entity.COLLECTION_DATE;
                        pDataParametersA[2].Value = pucWorkResultPopUp_T01_Entity.PROPERTY_VALUE;
                        pDataParametersA[3].Value = pDataTable.Rows[i]["BAD_CODE"].ToString();//pucWorkResultPopUp_T01_Entity.CONDITION_CODE;
                        pDataParametersA[4].Value = Convert.ToDecimal(pDataTable.Rows[i]["PRODUCTION_NG_RESULT"].ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                        pDataParametersA[5].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                        // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T01_I40", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pucWorkResultPopUp_T01_Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                        }
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
                    "WorkResultInfo_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)",
                    pException
                );
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
        public bool ucWorkResultPopup_T01_Info_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopup_T01Entity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
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
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_inout_type", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_inout_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_inout_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_inout_seq", MySqlDbType.VarChar, 6),
                                new MySqlParameter("@v_inout_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_inout_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_part_unit", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_unitcost", MySqlDbType.Decimal),
                                new MySqlParameter("@v_cost", MySqlDbType.Decimal),
                                new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inout_type", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_inout_id", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_inout_date", SqlDbType.VarChar, 8),
                                new SqlParameter("@v_inout_seq", SqlDbType.VarChar, 6),
                                new SqlParameter("@v_inout_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_vend_code", SqlDbType.VarChar, 10),
                                new SqlParameter("@v_inout_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_part_unit", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_unitcost", SqlDbType.Decimal),
                                new SqlParameter("@v_cost", SqlDbType.Decimal),
                                new SqlParameter("@v_reference_id", SqlDbType.VarChar, 20),
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucWorkResultPopup_T01Entity.CRUD;
                pDataParametersA[1].Value = pucWorkResultPopup_T01Entity.USER_CODE;
                pDataParametersA[2].Value = pucWorkResultPopup_T01Entity.INOUT_TYPE;
                pDataParametersA[3].Value = pucWorkResultPopup_T01Entity.INOUT_ID;
                pDataParametersA[4].Value = pucWorkResultPopup_T01Entity.INOUT_DATE;
                pDataParametersA[5].Value = pucWorkResultPopup_T01Entity.INOUT_SEQ;
                pDataParametersA[6].Value = pucWorkResultPopup_T01Entity.INOUT_CODE;
                pDataParametersA[7].Value = pucWorkResultPopup_T01Entity.PART_CODE;
                pDataParametersA[8].Value = pucWorkResultPopup_T01Entity.VEND_CODE;
                pDataParametersA[9].Value = Convert.ToDecimal(pucWorkResultPopup_T01Entity.INOUT_QTY);
                pDataParametersA[10].Value = pucWorkResultPopup_T01Entity.PART_UNIT;
                pDataParametersA[11].Value = Convert.ToDecimal(pucWorkResultPopup_T01Entity.UNITCOST);
                pDataParametersA[12].Value = Convert.ToDecimal(pucWorkResultPopup_T01Entity.COST);
                pDataParametersA[13].Value = pucWorkResultPopup_T01Entity.REFERENCE_ID;
                pDataParametersA[14].Value = pucWorkResultPopup_T01Entity.REMARK;
                pDataParametersA[15].Value = pucWorkResultPopup_T01Entity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucWorkResultPopup_T01_I10", pDataParametersA);

                pucWorkResultPopup_T01Entity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                pucWorkResultPopup_T01Entity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                pucWorkResultPopup_T01Entity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                pucWorkResultPopup_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                pucWorkResultPopup_T01Entity.RTN_AQ = pDataTableA.Rows[0]["rtn_aq"].ToString();
                pucWorkResultPopup_T01Entity.RTN_SQ = pDataTableA.Rows[0]["rtn_sq"].ToString();
                pucWorkResultPopup_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTableA.Rows[0][0].ToString() != "00")
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
                    _pDBManager.RollbackTransaction();  // 저장 실패 Rollback Transaction 
                else
                    _pDBManager.CommitTransaction();  // 저장 성공  Commit Transaction
            }

            return pErrorYN;
        }
        #region ○ 제품 -> BOM 조회 - WorkResultRegister_T01_Info_Mst(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultInfo_Save_T01_Info(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pucWorkResultPopUp_T01_Entity.CRUD;
                pDataParameters[1].Value = pucWorkResultPopUp_T01_Entity.PART_CODE;
                pDataParameters[2].Value = pucWorkResultPopUp_T01_Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucWorkResultPopUp_T01_R10", pDataParameters);
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
                    "WorkResultRegister_T01_Info_Mst(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion
    }

    public class WorkRequestRegisterProvider : EntityManager<WorkRequestRegisterEntity>
    {
        #region 생성자 - WorkRequestRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkRequestRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(WorkRequestRegisterEntity pWorkRequestRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pWorkRequestRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(WorkRequestRegisterEntity pWorkRequestRegisterEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                };
                        break;

                }

                pDataParameters[0].Value = pWorkRequestRegisterEntity.CRUD;
                pDataParameters[1].Value = pWorkRequestRegisterEntity.WINDOW_NAME;
                pDataParameters[2].Value = pWorkRequestRegisterEntity.LANGUAGE_TYPE;

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

        #region 마스터 조회하기 - Sample_Info_Mst(WorkRequestRegisterEntity pWorkRequestRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(WorkRequestRegisterEntity pWorkRequestRegisterEntity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_work_status", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_work_status", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkRequestRegisterEntity.CRUD;
                pDataParameters[1].Value = pWorkRequestRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pWorkRequestRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pWorkRequestRegisterEntity.PART_CODE;
                pDataParameters[4].Value = pWorkRequestRegisterEntity.PART_NAME;
                pDataParameters[5].Value = pWorkRequestRegisterEntity.WORK_STATUS;
                pDataParameters[6].Value = pWorkRequestRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkRequestRegister_R10", pDataParameters);

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
                    "Sample_Info_Mst(WorkRequestRegisterEntity pWorkRequestRegisterEntity)",
                    pException
                );
            }

        }
        
      public DataTable Sub_BOM_Info(WorkRequestRegisterEntity pWorkRequestRegisterEntity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar,15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar,15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pWorkRequestRegisterEntity.CRUD;
                pDataParameters[1].Value = pWorkRequestRegisterEntity.PART_CODE;
                pDataParameters[2].Value = pWorkRequestRegisterEntity.PRODUCTION_ORDER_ID;
                pDataParameters[3].Value = pWorkRequestRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkRequestRegister_R20", pDataParameters);

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
                    "Sample_Info_Mst(WorkRequestRegisterEntity pWorkRequestRegisterEntity)",
                    pException
                );
            }

        }
        public DataSet WorkRequestRegister_info_ExcelBinding(WorkRequestRegisterEntity pWorkRequestRegisterEntity)
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
                            new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pWorkRequestRegisterEntity.INSPECT_ID;
                pDataParameters[1].Value = pWorkRequestRegisterEntity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_WorkRequestRegister_R20", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "Sample_Info_Mst(WorkRequestRegisterEntity pWorkRequestRegisterEntity)",
                    pException
                );
            }

        }
        #endregion

        #region 정보 저장하기 - Sample_Info_Save(WorkRequestRegisterEntity pWorkRequestRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool WorkRequestRegister_Info_Mst_Save(WorkRequestRegisterEntity pWorkRequestRegisterEntity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_production_file", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_accept_chk", MySqlDbType.VarChar, 1)
                                



                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_production_order_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_contract_id", SqlDbType.NVarChar,15),
                                new SqlParameter("@v_production_file", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_process_code_mst", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_accept_chk", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pWorkRequestRegisterEntity.CRUD;
                pDataParametersA[1].Value = pWorkRequestRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pWorkRequestRegisterEntity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pWorkRequestRegisterEntity.REFERENCE_ID;
                pDataParametersA[4].Value = pWorkRequestRegisterEntity.PRODUCTION_FILE;
                pDataParametersA[5].Value = pWorkRequestRegisterEntity.PROCESS_CODE_MST;
                pDataParametersA[6].Value = pWorkRequestRegisterEntity.ACCEPT_CHK;


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkRequestRegister_I10", pDataParametersA);

                pWorkRequestRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pWorkRequestRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pWorkRequestRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pWorkRequestRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "ProductOutRegister_Info_Save(ProductOutRegisterEntity pProductOutRegisterEntity, DataTable dt)",
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

        #region 정보 저장하기 - Sample_Info_Save(WorkRequestRegisterEntity pWorkRequestRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool WorkRequestRegister_Info_Detail_Save(WorkRequestRegisterEntity pWorkRequestRegisterEntity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                int rowcnt = pWorkRequestRegisterEntity.dtListCnt;
                for (int i = 0; i < rowcnt; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_inspect_code", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_inspect_result", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_inspect_date", MySqlDbType.VarChar,8),
                                new MySqlParameter("@v_inspect_user", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_decision", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000),

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_inspect_code", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_inspect_result", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_inspect_date", SqlDbType.NVarChar,8),
                                new SqlParameter("@v_inspect_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_decision", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pWorkRequestRegisterEntity.CRUD;
                    pDataParametersA[1].Value = pWorkRequestRegisterEntity.USER_CODE;
                    pDataParametersA[2].Value = pWorkRequestRegisterEntity.INSPECT_ID;
                    pDataParametersA[3].Value = sheet_1.GetCellValue(0, i + 1).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(3, i + 1).ToString();
                    pDataParametersA[5].Value = sheet_1.GetCellValue(5, i + 1).ToString();
                    pDataParametersA[6].Value = sheet_1.GetCellValue(6, i + 1).ToString();
                    pDataParametersA[7].Value = sheet_1.GetCellValue(4, i + 1).ToString();//v_inspect_user
                    pDataParametersA[8].Value = sheet_1.GetCellValue(7, i + 1).ToString();//v_inspect_user

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkRequestRegister_I20", pDataParametersA);

                    pWorkRequestRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pWorkRequestRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pWorkRequestRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pWorkRequestRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "ProductOutRegister_Info_Save(ProductOutRegisterEntity pProductOutRegisterEntity, DataTable dt)",
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

        #region 사용자 이미지 조회 - Sample_Info(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable GetUserImage(string CRUD, string USER_CODE)
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
                          new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = CRUD;
                pDataParameters[1].Value = USER_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GetUserImage_R10", pDataParameters);

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
                    "Sample_Info_Mst(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)",
                    pException
                );
            }

        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(WorkRequestRegisterEntity pWorkRequestRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool WorkRequestRegister_Info_MAKE_NO_SAVE(WorkRequestRegisterEntity pWorkRequestRegisterEntity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_make_no", MySqlDbType.VarChar, 50),
                                
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_reference_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_make_no", SqlDbType.NVarChar,50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pWorkRequestRegisterEntity.CRUD;
                pDataParametersA[1].Value = pWorkRequestRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pWorkRequestRegisterEntity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pWorkRequestRegisterEntity.MAKE_NO;


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkRequestRegister_I20", pDataParametersA);

                pWorkRequestRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pWorkRequestRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pWorkRequestRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pWorkRequestRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "ProductOutRegister_Info_Save(ProductOutRegisterEntity pProductOutRegisterEntity, DataTable dt)",
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
        public override WorkRequestRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkRequestRegisterEntity pWorkRequestRegisterEntity = new WorkRequestRegisterEntity();

                pWorkRequestRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkRequestRegisterEntity;
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

    public class ucWorkRequestInfoPopupProvider : EntityManager<ucWorkRequestInfoPopupEntity>
    {
        #region 생성자 - ucWorkRequestInfoPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucWorkRequestInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ucWorkRequestInfoPopupEntity pucWorkRequestInfoPopupEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet ucWorkRequestInfoPopup_Return(string pCRUD, string pFROM_DATE, string pTO_DATE,string pPRODUCTION_ORDER_ID, string pPART_NAME,string pPART_CODE, string pPROCESS_CODE_MST)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar,15),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar,15),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.NVarChar, 10),
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pFROM_DATE;
                pDataParameters[2].Value = pTO_DATE;
                pDataParameters[3].Value = pPRODUCTION_ORDER_ID;
                pDataParameters[4].Value = pPART_NAME;
                pDataParameters[5].Value = pPART_CODE;
                pDataParameters[6].Value = pPROCESS_CODE_MST;


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucWorkRequestInfoPopup_R10", pDataParameters);


                return pDataTableSet;
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
                    "Sample_Info_Mst(ucWorkRequestInfoPopupEntity pucWorkRequestInfoPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ucWorkRequestInfo_Info_Check_Save(ucWorkRequestInfoPopupEntity pucWorkRequestInfoPopupEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    for (int a = 0; a < pCount; a++)
                    {
                        //체크된것만 저장
                        if (dt.Rows[a]["CRUD"].ToString() == "Y")
                        {
                            //마스터 저장
                            IDataParameter[] pDataParametersA = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new MySqlParameter("@v_crud                  ".Trim(), MySqlDbType.VarChar, 1),
                                            new MySqlParameter("@v_user_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_production_order_id    ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_process_code_mst      ".Trim(), MySqlDbType.VarChar, 50),


                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_production_order_id     ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_process_code_mst       ".Trim(), SqlDbType.VarChar, 50),


                                    };
                                    break;
                            }
                            pDataParametersA[0].Value = pucWorkRequestInfoPopupEntity.CRUD;
                            pDataParametersA[1].Value = pucWorkRequestInfoPopupEntity.USER_CODE;
                            pDataParametersA[2].Value = dt.Rows[a]["PRODUCTION_ORDER_ID"].ToString().ToUpper();
                            pDataParametersA[3].Value = dt.Rows[a]["PROCESS_CODE_MST"].ToString().ToUpper();


                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucWorkRequestInfoPopup_I10", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            pucWorkRequestInfoPopupEntity.ERR_NO = pDataTableA.Rows[0]["p_err_no"].ToString();
                            pucWorkRequestInfoPopupEntity.ERR_MSG = pDataTableA.Rows[0]["p_err_msg"].ToString();
                            pucWorkRequestInfoPopupEntity.RTN_KEY = pDataTableA.Rows[0]["p_rtn_key"].ToString();
                            pucWorkRequestInfoPopupEntity.RTN_SEQ = pDataTableA.Rows[0]["p_rtn_seq"].ToString();
                            pucWorkRequestInfoPopupEntity.RTN_OTHERS = pDataTableA.Rows[0]["p_rtn_others"].ToString();

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                        }
                    }
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
                    "ucWorkRequestInfo_Info_Check_Save(ucWorkRequestInfoPopupEntity pucWorkRequestInfoPopupEntity, DataTable dt)",
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
        public override ucWorkRequestInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucWorkRequestInfoPopupEntity pucWorkRequestInfoPopupEntity = new ucWorkRequestInfoPopupEntity();

                pucWorkRequestInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucWorkRequestInfoPopupEntity;
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


    public class ucMakeNoMappingPopupProvider : EntityManager<ucMakeNoMappingPopupEntity>
    {
        #region 생성자 - ucMakeNoMappingPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucMakeNoMappingPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ucMakeNoMappingPopupEntity pucMakeNoMappingPopupEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet ucMakeNoMappingPopup_Return(string pCRUD, string pFROM_DATE, string pTO_DATE, string pPRODUCTION_ORDER_ID, string pPART_NAME, string pPART_CODE, string pPROCESS_CODE_MST)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPART_NAME;
                pDataParameters[2].Value = pPART_CODE;


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucMakeNoMappingPopup_R10", pDataParameters);


                return pDataTableSet;
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
                    "Sample_Info_Mst(ucMakeNoMappingPopupEntity pucMakeNoMappingPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ucWorkRequestInfo_Info_Check_Save(ucMakeNoMappingPopupEntity pucMakeNoMappingPopupEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    for (int a = 0; a < pCount; a++)
                    {
                        //체크된것만 저장
                        if (dt.Rows[a]["CRUD"].ToString() == "Y")
                        {
                            //마스터 저장
                            IDataParameter[] pDataParametersA = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new MySqlParameter("@v_crud                  ".Trim(), MySqlDbType.VarChar, 1),
                                            new MySqlParameter("@v_user_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_production_order_id    ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_process_code_mst      ".Trim(), MySqlDbType.VarChar, 50),


                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_production_order_id     ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_process_code_mst       ".Trim(), SqlDbType.VarChar, 50),


                                    };
                                    break;
                            }
                            pDataParametersA[0].Value = pucMakeNoMappingPopupEntity.CRUD;
                            pDataParametersA[1].Value = pucMakeNoMappingPopupEntity.USER_CODE;
                            pDataParametersA[2].Value = dt.Rows[a]["PRODUCTION_ORDER_ID"].ToString().ToUpper();
                            pDataParametersA[3].Value = dt.Rows[a]["PROCESS_CODE_MST"].ToString().ToUpper();


                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMakeNoMappingPopup_I10", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            pucMakeNoMappingPopupEntity.ERR_NO = pDataTableA.Rows[0]["p_err_no"].ToString();
                            pucMakeNoMappingPopupEntity.ERR_MSG = pDataTableA.Rows[0]["p_err_msg"].ToString();
                            pucMakeNoMappingPopupEntity.RTN_KEY = pDataTableA.Rows[0]["p_rtn_key"].ToString();
                            pucMakeNoMappingPopupEntity.RTN_SEQ = pDataTableA.Rows[0]["p_rtn_seq"].ToString();
                            pucMakeNoMappingPopupEntity.RTN_OTHERS = pDataTableA.Rows[0]["p_rtn_others"].ToString();

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                        }
                    }
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
                    "ucWorkRequestInfo_Info_Check_Save(ucMakeNoMappingPopupEntity pucMakeNoMappingPopupEntity, DataTable dt)",
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
        public override ucMakeNoMappingPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucMakeNoMappingPopupEntity pucMakeNoMappingPopupEntity = new ucMakeNoMappingPopupEntity();

                pucMakeNoMappingPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucMakeNoMappingPopupEntity;
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


    public class ucWorkOrderDocRegPopupProvider : EntityManager<ucWorkOrderDocRegPopupEntity>
    {
        #region 생성자 - ucWorkOrderDocRegPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucWorkOrderDocRegPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet ucWorkOrderDocRegPopup_Return(string pCRUD, string pLANGUAGE_TYPE,string pPRODUCTION_ORDER_ID, string pPART_NAME, string pPART_CODE, string pPROCESS_CODE_MST )
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar,15),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar,15),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pPART_NAME;
                pDataParameters[3].Value = pPART_CODE;
                pDataParameters[4].Value = pPROCESS_CODE_MST;
                pDataParameters[5].Value = pLANGUAGE_TYPE;


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucWorkOrderDocRegPopup_R10", pDataParameters);


                return pDataTableSet;
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
                    "Sample_Info_Mst(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ucWorkOrderDocRegPopup_Save(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
              //  if (dt != null)
              //  {
                 //   pCount = dt.Rows.Count;
                   //
                   // for (int a = 0; a < pCount; a++)
                   // {
                   //     //체크된것만 저장
                   //     if (dt.Rows[a]["CRUD"].ToString() == "Y")
                   //     {
                            //마스터 저장
                            IDataParameter[] pDataParametersA = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new MySqlParameter("@v_crud                  ".Trim(), MySqlDbType.VarChar, 1),
                                            new MySqlParameter("@v_user_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_production_order_id    ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_order_file             ".Trim(), MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_process_code_mst             ".Trim(), MySqlDbType.VarChar, 10),
                                            new MySqlParameter("@v_make_no             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_approver_sign_chk             ".Trim(), MySqlDbType.VarChar, 1),
                                            new MySqlParameter("@v_production_result_qty             ".Trim(), MySqlDbType.Decimal),
                                            new MySqlParameter("@v_production_ng_result_qty             ".Trim(), MySqlDbType.Decimal),
                                            new MySqlParameter("@v_semi_production_result_qty             ".Trim(), MySqlDbType.Decimal)


                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_production_order_id     ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_order_file       ".Trim(), SqlDbType.VarChar, 100),
                                            new SqlParameter("@v_process_code_mst       ".Trim(), SqlDbType.VarChar, 10),
                                            new SqlParameter("@v_make_no       ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_approver_sign_chk       ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_production_result_qty       ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_production_ng_result_qty       ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_semi_production_result_qty       ".Trim(), SqlDbType.Decimal)


                                    };
                                    break;
                            }
                            pDataParametersA[0].Value = pucWorkOrderDocRegPopupEntity.CRUD;
                            pDataParametersA[1].Value = pucWorkOrderDocRegPopupEntity.USER_CODE;
                            pDataParametersA[2].Value = pucWorkOrderDocRegPopupEntity.PRODUCTION_ORDER_ID;
                            pDataParametersA[3].Value = pucWorkOrderDocRegPopupEntity.FILE_NAME;
                            pDataParametersA[4].Value = pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST;
                            pDataParametersA[5].Value = pucWorkOrderDocRegPopupEntity.MAKE_NO;
                            pDataParametersA[6].Value = pucWorkOrderDocRegPopupEntity.APPROVER_SIGN_CHK;
                            pDataParametersA[7].Value = pucWorkOrderDocRegPopupEntity.PRODUCTION_RESULT_QTY;
                            pDataParametersA[8].Value = pucWorkOrderDocRegPopupEntity.PRODUCTION_NG_RESULT_QTY;
                            pDataParametersA[9].Value = pucWorkOrderDocRegPopupEntity.SEMI_PRODUCTION_RESULT_QTY;


                  DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucWorkOrderDocRegPopup_I10", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            pucWorkOrderDocRegPopupEntity.ERR_NO = pDataTableA.Rows[0]["p_err_no"].ToString();
                            pucWorkOrderDocRegPopupEntity.ERR_MSG = pDataTableA.Rows[0]["p_err_msg"].ToString();
                            pucWorkOrderDocRegPopupEntity.RTN_KEY = pDataTableA.Rows[0]["p_rtn_key"].ToString();
                            pucWorkOrderDocRegPopupEntity.RTN_SEQ = pDataTableA.Rows[0]["p_rtn_seq"].ToString();
                            pucWorkOrderDocRegPopupEntity.RTN_OTHERS = pDataTableA.Rows[0]["p_rtn_others"].ToString();

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                  //     }
                  // }
               // }
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
                    "ucWorkRequestInfo_Info_Check_Save(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity, DataTable dt)",
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

        #region 제조/작업지시서 실적등록
        public bool WorkResultInfo_Save(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity,Worksheet pSheet)
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
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_property_value", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_condition_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_value", MySqlDbType.Decimal),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_property_value", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_condition_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucWorkOrderDocRegPopupEntity.RESOURCE_CODE;
                pDataParametersA[1].Value = pucWorkOrderDocRegPopupEntity.COLLECTION_DATE;
                pDataParametersA[2].Value = pucWorkOrderDocRegPopupEntity.PROPERTY_VALUE;
                pDataParametersA[3].Value = pucWorkOrderDocRegPopupEntity.CONDITION_CODE;
                pDataParametersA[4].Value = pucWorkOrderDocRegPopupEntity.COLLECTION_VALUE;
                pDataParametersA[5].Value = pucWorkOrderDocRegPopupEntity.PART_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pucWorkOrderDocRegPopupEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)",
                    pException
                );
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
        #region   BOM으로 부자재 불량실적 등록
        public bool WorkResultInfo_Save_02(ucWorkOrderDocRegPopupEntity ucWorkOrderDocRegPopupEntity, Worksheet pSheet)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();

            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                string first_chk1 = "";
                string first_chk2 = "";
                string first_chk3 = "";
                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParametersA = new IDataParameter[]
                        {
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_property_value", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_condition_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_value", MySqlDbType.Decimal),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_first_chk", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_make_no", MySqlDbType.VarChar, 15)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_property_value", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_condition_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_first_chk", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_make_no", SqlDbType.VarChar, 15)
                        };
                        break;
                }
             
                for (int i = 0; i < 13; i++)
                {
                    //정상사용 -> 생산출고
                    if (pSheet.GetCellValue(9, i + 11).ToString() != "")
                    {
                        if (pSheet.GetCellValue(2, i + 11).ToString() != "")
                        {
                            if (Convert.ToDecimal(pSheet.GetCellValue(9, i + 11).ToString()) != 0)
                            {
                                pDataParametersA[0].Value = ucWorkOrderDocRegPopupEntity.RESOURCE_CODE;
                                pDataParametersA[1].Value = ucWorkOrderDocRegPopupEntity.COLLECTION_DATE;
                                pDataParametersA[2].Value = ucWorkOrderDocRegPopupEntity.PROPERTY_VALUE;
                                pDataParametersA[3].Value = "MR050020";//MR050020 : 생산출고
                                pDataParametersA[4].Value = Convert.ToDecimal(pSheet.GetCellValue(9, i + 11).ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                                pDataParametersA[5].Value = pSheet.GetCellValue(2, i + 11).ToString();  //업체품번 : 자재코드
                                pDataParametersA[6].Value = ucWorkOrderDocRegPopupEntity.USER_CODE;
                                pDataParametersA[8].Value = pSheet.GetCellValue(7, i + 11).ToString();  //제조번호
                                //pDataParametersA[7].Value = first_chk1;
                                // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T01_I50", pDataParametersA);
                                if (pDataTableA.Rows[0]["P_ERR_NO"].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
                                else
                                {
                                    ucWorkOrderDocRegPopupEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                                    first_chk1 = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                                }
                            }
                        }
                    }
                    //작업불량
                    if (pSheet.GetCellValue(10, i + 11).ToString() != "")
                    {
                        if (Convert.ToDecimal(pSheet.GetCellValue(10, i + 11).ToString()) != 0)
                        {
                            pDataParametersA[0].Value = ucWorkOrderDocRegPopupEntity.RESOURCE_CODE;
                            pDataParametersA[1].Value = ucWorkOrderDocRegPopupEntity.COLLECTION_DATE;
                            pDataParametersA[2].Value = ucWorkOrderDocRegPopupEntity.PROPERTY_VALUE;
                            pDataParametersA[3].Value = "BC020001";//BC020001 : 작업불량
                            pDataParametersA[4].Value = Convert.ToDecimal(pSheet.GetCellValue(10, i + 11).ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                            pDataParametersA[5].Value = pSheet.GetCellValue(2, i + 11).ToString();  //업체품번 : 자재코드
                            pDataParametersA[6].Value = ucWorkOrderDocRegPopupEntity.USER_CODE;
                            pDataParametersA[7].Value = first_chk2;
                            // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T01_I60", pDataParametersA);
                            if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            else
                            {
                                ucWorkOrderDocRegPopupEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                                first_chk2 = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                            }
                        }
                    }
                    //업체불량
                    if(pSheet.GetCellValue(11, i + 11).ToString() != "")
                    {
                        if ((Convert.ToDecimal(pSheet.GetCellValue(11, i + 11).ToString()) != 0))
                        {
                            pDataParametersA[0].Value = ucWorkOrderDocRegPopupEntity.RESOURCE_CODE;
                            pDataParametersA[1].Value = ucWorkOrderDocRegPopupEntity.COLLECTION_DATE;
                            pDataParametersA[2].Value = ucWorkOrderDocRegPopupEntity.PROPERTY_VALUE;
                            pDataParametersA[3].Value = "BC020002";//BC020001 : 업체불량
                            pDataParametersA[4].Value = Convert.ToDecimal(pSheet.GetCellValue(11, i + 11).ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                            pDataParametersA[5].Value = pSheet.GetCellValue(2, i + 11).ToString();  //업체품번 : 자재코드
                            pDataParametersA[6].Value = ucWorkOrderDocRegPopupEntity.USER_CODE;
                            pDataParametersA[7].Value = first_chk3;
                            // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T01_I60", pDataParametersA);
                            if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            else
                            {
                                ucWorkOrderDocRegPopupEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                                first_chk3 = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                            }
                        }
                    }

                    //반입량
                    if (pSheet.GetCellValue(13, i + 11).ToString() != "")
                    {
                        if ((Convert.ToDecimal(pSheet.GetCellValue(13, i + 11).ToString()) != 0))
                        {
                            pDataParametersA[0].Value = ucWorkOrderDocRegPopupEntity.RESOURCE_CODE;
                            pDataParametersA[1].Value = ucWorkOrderDocRegPopupEntity.COLLECTION_DATE;
                            pDataParametersA[2].Value = ucWorkOrderDocRegPopupEntity.PROPERTY_VALUE;
                            pDataParametersA[3].Value = "MR040013";// : 반입량코드입력
                            pDataParametersA[4].Value = Convert.ToDecimal(pSheet.GetCellValue(13, i + 11).ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                            pDataParametersA[5].Value = pSheet.GetCellValue(2, i + 11).ToString();  //업체품번 : 자재코드
                            pDataParametersA[6].Value = ucWorkOrderDocRegPopupEntity.USER_CODE;
                            pDataParametersA[7].Value = first_chk3;
                            // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T01_I80", pDataParametersA);
                            if (pDataTableA.Rows[0]["P_ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            else
                            {
                                ucWorkOrderDocRegPopupEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                                first_chk3 = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                            }
                        }
                    }
                }
                //포장 -> 반제품 저장
                for (int i = 0; i < 2; i++)
                {
                    //정상사용 -> 생산출고
                    if (pSheet.GetCellValue(9, i + 25).ToString() != "")
                    {
                        if (pSheet.GetCellValue(2, i + 25).ToString() != "")
                        {
                            if (Convert.ToDecimal(pSheet.GetCellValue(9, i + 25).ToString()) != 0)
                            {
                                pDataParametersA[0].Value = ucWorkOrderDocRegPopupEntity.RESOURCE_CODE;
                                pDataParametersA[1].Value = ucWorkOrderDocRegPopupEntity.COLLECTION_DATE;
                                pDataParametersA[2].Value = ucWorkOrderDocRegPopupEntity.PROPERTY_VALUE;
                                pDataParametersA[3].Value = "PD040020";//MR050020 : 생산출고
                                pDataParametersA[4].Value = Convert.ToDecimal(pSheet.GetCellValue(9, i + 25).ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                                pDataParametersA[5].Value = pSheet.GetCellValue(2, i + 25).ToString();  //업체품번 : 자재코드
                                pDataParametersA[6].Value = ucWorkOrderDocRegPopupEntity.USER_CODE;
                                pDataParametersA[8].Value = pSheet.GetCellValue(7, i + 25).ToString();  //제조번호
                                                                                                        //v_in_inout_id
                                                                                                        //pDataParametersA[7].Value = first_chk1;
                                                                                                        // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPSelect_WorkOrderDoc_COSMETICS_I40", pDataParametersA);
                                if (pDataTableA.Rows[0]["P_ERR_NO"].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
                                else
                                {
                                    ucWorkOrderDocRegPopupEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                                    first_chk1 = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                                }
                            }
                        }
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
                    "WorkResultInfo_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)",
                    pException
                );
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


        #region 정보 저장하기 - MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ucWorkOrderDocRegPopup_Data_Save(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity, Worksheet pSheet)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                //  if (dt != null)
                //  {
                //   pCount = dt.Rows.Count;
                //
                // for (int a = 0; a < pCount; a++)
                // {
                //     //체크된것만 저장
                //     if (dt.Rows[a]["CRUD"].ToString() == "Y")
                //     {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParametersA = new IDataParameter[]
                        {

                                            new MySqlParameter("@v_crud                  ".Trim(), MySqlDbType.VarChar, 1),
                                            new MySqlParameter("@v_user_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_production_order_id    ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_order_file             ".Trim(), MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_process_code_mst             ".Trim(), MySqlDbType.VarChar, 10),
                                            new MySqlParameter("@v_make_no             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_approver_sign_chk             ".Trim(), MySqlDbType.VarChar, 1),
                                            new MySqlParameter("@v_production_result_qty             ".Trim(), MySqlDbType.Decimal)


                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_production_order_id     ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_order_file       ".Trim(), SqlDbType.VarChar, 100),
                                            new SqlParameter("@v_process_code_mst       ".Trim(), SqlDbType.VarChar, 10),
                                            new SqlParameter("@v_make_no       ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_approver_sign_chk       ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_production_result_qty       ".Trim(), SqlDbType.Decimal)


                        };
                        break;
                }
                pDataParametersA[0].Value = pucWorkOrderDocRegPopupEntity.CRUD;
                pDataParametersA[1].Value = pucWorkOrderDocRegPopupEntity.USER_CODE;
                pDataParametersA[2].Value = pucWorkOrderDocRegPopupEntity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pucWorkOrderDocRegPopupEntity.FILE_NAME;
                pDataParametersA[4].Value = pucWorkOrderDocRegPopupEntity.PROCESS_CODE_MST;
                pDataParametersA[5].Value = pucWorkOrderDocRegPopupEntity.MAKE_NO;
                pDataParametersA[6].Value = pucWorkOrderDocRegPopupEntity.APPROVER_SIGN_CHK;
                pDataParametersA[7].Value = pucWorkOrderDocRegPopupEntity.PRODUCTION_RESULT_QTY;


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucWorkOrderDocRegPopup_I20", pDataParametersA);

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                pucWorkOrderDocRegPopupEntity.ERR_NO = pDataTableA.Rows[0]["p_err_no"].ToString();
                pucWorkOrderDocRegPopupEntity.ERR_MSG = pDataTableA.Rows[0]["p_err_msg"].ToString();
                pucWorkOrderDocRegPopupEntity.RTN_KEY = pDataTableA.Rows[0]["p_rtn_key"].ToString();
                pucWorkOrderDocRegPopupEntity.RTN_SEQ = pDataTableA.Rows[0]["p_rtn_seq"].ToString();
                pucWorkOrderDocRegPopupEntity.RTN_OTHERS = pDataTableA.Rows[0]["p_rtn_others"].ToString();

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                //     }
                // }
                // }
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
                    "ucWorkRequestInfo_Info_Check_Save(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity, DataTable dt)",
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
        public override ucWorkOrderDocRegPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity = new ucWorkOrderDocRegPopupEntity();

                pucWorkOrderDocRegPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucWorkOrderDocRegPopupEntity;
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

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(SheetInfoRegisterEntity pSheetInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntityEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                };
                        break;

                }

                pDataParameters[0].Value = pucWorkOrderDocRegPopupEntityEntity.CRUD;
                pDataParameters[1].Value = pucWorkOrderDocRegPopupEntityEntity.WINDOW_NAME;
                pDataParameters[2].Value = pucWorkOrderDocRegPopupEntityEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SheetInfoRegister_R20", pDataParameters);


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
                    "Sheet_Info_sheet(SheetInfoRegisterEntity pSheetInfoRegisterEntity)",
                    pException
                );
            }
        }

        #endregion
        public DataTable GetUserImage(string CRUD, string USER_CODE)
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
                          new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = CRUD;
                pDataParameters[1].Value = USER_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GetUserImage_R10", pDataParameters);

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
                    "Sample_Info_Mst(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)",
                    pException
                );
            }

        }

    }


    public class ProductPlanInfoPopup_T01Provider : EntityManager<ProductPlanInfoPopup_T01Entity>
    {
        #region 생성자 - ProductPlanInfoPopup_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductPlanInfoPopup_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ProductPlanInfoPopup_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductPlanInfoPopup_T01Entity pProductPlanInfoPopup_T01Entity = new ProductPlanInfoPopup_T01Entity();
                pProductPlanInfoPopup_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pProductPlanInfoPopup_T01Entity;
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

        #region 코드정보 조회하기 ProductPlanInfo_Return(string pCRUD, string pPARTCODE, string pPARTNAME, string PARTTYPE)

        public DataSet ProductPlanInfo_Return(string pCRUD, string pPARTCODE)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 100)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 100)

                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPARTCODE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucProductPlanInfoPopup_T01_R10", pDataParameters);
                return pDataTableSet;
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
                    "ProductPlanInfo_Return(string pCRUD, string pPARTCODE, string pPARTNAME, string PARTTYPE)",
                    pException
                );
            }





        }

        #endregion

        #region 정보 저장하기 - ProductPlanInfo_Save(ProductPlanInfoPopup_T01Entity pProductPlanInfoPopup_T01Entity, DataTable pDataTable)


        public DataTable ProductPlanInfo_Save(ProductPlanInfoPopup_T01Entity pProductPlanInfoPopup_T01Entity, DataTable pDataTable)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            DataTable pDataTableA = null;
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_production_plan_date", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_production_plan_seq", MySqlDbType.VarChar, 3),
                            new MySqlParameter("@v_part_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_plan_qty", MySqlDbType.Decimal),
                            new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_plan_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_production_plan_date", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_production_plan_seq", SqlDbType.VarChar, 3),
                            new SqlParameter("@v_part_code_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_plan_qty", SqlDbType.Decimal),
                            new SqlParameter("@v_reference_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(pDataTable.Rows[i]["PLAN_QTY"].ToString()) > 0)
                    {
                        pDataParametersA[0].Value = pProductPlanInfoPopup_T01Entity.CRUD;
                        pDataParametersA[1].Value = pProductPlanInfoPopup_T01Entity.USER_CODE;
                        if (i == 0 || pProductPlanInfoPopup_T01Entity.RTN_KEY == null)
                            pDataParametersA[2].Value = "";
                        else
                            pDataParametersA[2].Value = pProductPlanInfoPopup_T01Entity.RTN_KEY;

                        pDataParametersA[3].Value = pDataTable.Rows[i]["TODAY"].ToString();
                        pDataParametersA[4].Value = "";
                        pDataParametersA[5].Value = pProductPlanInfoPopup_T01Entity.PART_CODE_MST;
                        pDataParametersA[6].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                        pDataParametersA[7].Value = pDataTable.Rows[i]["PLAN_QTY"].ToString();
                        pDataParametersA[8].Value = pProductPlanInfoPopup_T01Entity.CONTRACT_ID;
                        pDataParametersA[9].Value = pDataTable.Rows[i]["REMARK"].ToString();
                        pDataParametersA[10].Value = "Y";

                        pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProductPlanInfoPopup_T01_I10", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pProductPlanInfoPopup_T01Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                        }
                    }
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
                    "RuleGenerator_Info_Save(RuleGeneratorEntity pRuleGeneratorEntity, DataTable dt)",
                    pException
                );
            }
            finally
            {
                if (pErrorYN)
                    _pDBManager.RollbackTransaction();  // 저장실패
                else
                    _pDBManager.CommitTransaction();
            }

            return pDataTableA;
        }

        #endregion
    }

    public class ucProductionOrderInfoPopup_T06Provider : EntityManager<ucProductionOrderInfoPopup_T06_Entity>
    {
        #region 생성자 - ucProductionOrderInfoPopup_T06Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucProductionOrderInfoPopup_T06Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기

        public override ucProductionOrderInfoPopup_T06_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucProductionOrderInfoPopup_T06_Entity pucProductionOrderInfoPopup_T06_Entity = new ucProductionOrderInfoPopup_T06_Entity();
                pucProductionOrderInfoPopup_T06_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucProductionOrderInfoPopup_T06_Entity;
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

        #region ○ 수주정보 조회하기

        public DataSet ucProductonOrderInfoPopup_T06_Return(ucProductionOrderInfoPopup_T06_Entity pucProductionOrderInfoPopup_T06_Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucProductionOrderInfoPopup_T06_Entity.CRUD;
                pDataParameters[1].Value = pucProductionOrderInfoPopup_T06_Entity.DATE_FROM;
                pDataParameters[2].Value = pucProductionOrderInfoPopup_T06_Entity.DATE_TO;
                pDataParameters[3].Value = pucProductionOrderInfoPopup_T06_Entity.PART_CODE;
                pDataParameters[4].Value = pucProductionOrderInfoPopup_T06_Entity.PART_NAME;
                pDataParameters[5].Value = pucProductionOrderInfoPopup_T06_Entity.VEND_CODE;
                pDataParameters[6].Value = pucProductionOrderInfoPopup_T06_Entity.VEND_NAME;
                pDataParameters[7].Value = pucProductionOrderInfoPopup_T06_Entity.LANGUAGE_TYPE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "ucProductonOrderInfoPopup_T06_R10", pDataParameters);
                return pDataTableSet;
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
                    "ProductPlanInfo_Return(string pCRUD, string pPARTCODE, string pPARTNAME, string PARTTYPE)",
                    pException
                );
            }
        }

        #endregion
    }

    public class WorkOrdersRegister_T03Provider : EntityManager<WorkOrdersRegister_T03Entity>
    {
        #region 생성자 - WorkOrdersRegister_T03Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkOrdersRegister_T03Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_plan_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_workcenter_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_plan_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_workcenter_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                //pDataParameters[0].Value = pWorkOrdersRegister_T03Entity.CORP_CODE;
                pDataParameters[0].Value = pWorkOrdersRegister_T03Entity.CRUD;
                pDataParameters[1].Value = pWorkOrdersRegister_T03Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkOrdersRegister_T03Entity.DATE_TO;
                pDataParameters[3].Value = pWorkOrdersRegister_T03Entity.ORDER_CODE;
                pDataParameters[4].Value = pWorkOrdersRegister_T03Entity.PART_CODE;
                pDataParameters[5].Value = pWorkOrdersRegister_T03Entity.PART_NAME;
                pDataParameters[6].Value = pWorkOrdersRegister_T03Entity.REFERENCE_ID;
                pDataParameters[7].Value = pWorkOrdersRegister_T03Entity.PROCESS_CODE;
                pDataParameters[8].Value = pWorkOrdersRegister_T03Entity.USE_YN;
                pDataParameters[9].Value = pWorkOrdersRegister_T03Entity.WORKCENTER_CODE;
                pDataParameters[10].Value = pWorkOrdersRegister_T03Entity.COMPLETE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T03_R10", pDataParameters);

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
                    "Sample_Info_Mst(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)",
                    pException
                );
            }
        }

        #endregion        

        #region 정보 저장하기 - Sample_Info_Save(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)
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
                                new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_order_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_order_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_order_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_order_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_order_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)

                        };
                        break;
                }

                pDataParametersA[0].Value = pWorkOrdersRegister_T03Entity.CRUD;
                pDataParametersA[1].Value = pWorkOrdersRegister_T03Entity.USER_CODE;
                pDataParametersA[2].Value = pWorkOrdersRegister_T03Entity.ORDER_CODE;
                pDataParametersA[3].Value = pWorkOrdersRegister_T03Entity.ORDER_DATE;
                pDataParametersA[4].Value = pWorkOrdersRegister_T03Entity.WORKCENTER_CODE;
                pDataParametersA[5].Value = pWorkOrdersRegister_T03Entity.ORDER_QTY;
                pDataParametersA[6].Value = pWorkOrdersRegister_T03Entity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrderRegister_T03_I10", pDataParametersA);

                pWorkOrdersRegister_T03Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pWorkOrdersRegister_T03Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pWorkOrdersRegister_T03Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pWorkOrdersRegister_T03Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "ProductOutRegister_Info_Save(ProductOutRegisterEntity pProductOutRegisterEntity, DataTable dt)",
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
        public override WorkOrdersRegister_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity = new WorkOrdersRegister_T03Entity();

                pWorkOrdersRegister_T03Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkOrdersRegister_T03Entity;
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

        #region 작업일보 조회하기 - Sample_Check_Next_Process (WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)
        /// <summary>
        /// 작업지시 수정 시, 해당 작업지시 번호로 이미 등록된 작업일보가 있는지 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        
        public DataTable Sample_Check_Next_Process(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                };
                        break;
                }

                pDataParameters[0].Value = pWorkOrdersRegister_T03Entity.CRUD;
                pDataParameters[1].Value = pWorkOrdersRegister_T03Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkOrdersRegister_T03Entity.DATE_TO;
                pDataParameters[3].Value = pWorkOrdersRegister_T03Entity.PART_CODE;
                pDataParameters[4].Value = pWorkOrdersRegister_T03Entity.PART_NAME;
                pDataParameters[5].Value = pWorkOrdersRegister_T03Entity.PROCESS_CODE_MST;
                pDataParameters[6].Value = pWorkOrdersRegister_T03Entity.PROCESS_CODE;
                pDataParameters[7].Value = pWorkOrdersRegister_T03Entity.PRODUCTION_ORDER_ID;
                pDataParameters[8].Value = pWorkOrdersRegister_T03Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T02_R10", pDataParameters);
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
                    "WorkResultRegister_T02_Info_Mst(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)",
                    pException
                );
            }
        }        
        #endregion
    }

    public class WorkOrdersRegister_T06Provider : EntityManager<WorkOrdersRegister_T06Entity>
    {
        #region 생성자 - WorkOrdersRegister_T06Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkOrdersRegister_T06Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_plan_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_workcenter_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_plan_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_workcenter_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                //pDataParameters[0].Value = pWorkOrdersRegister_T06Entity.CORP_CODE;
                pDataParameters[0].Value = pWorkOrdersRegister_T06Entity.CRUD;
                pDataParameters[1].Value = pWorkOrdersRegister_T06Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkOrdersRegister_T06Entity.DATE_TO;
                pDataParameters[3].Value = pWorkOrdersRegister_T06Entity.ORDER_CODE;
                pDataParameters[4].Value = pWorkOrdersRegister_T06Entity.PART_CODE;
                pDataParameters[5].Value = pWorkOrdersRegister_T06Entity.PART_NAME;
                pDataParameters[6].Value = pWorkOrdersRegister_T06Entity.REFERENCE_ID;
                pDataParameters[7].Value = pWorkOrdersRegister_T06Entity.PROCESS_CODE;
                pDataParameters[8].Value = pWorkOrdersRegister_T06Entity.USE_YN;
                pDataParameters[9].Value = pWorkOrdersRegister_T06Entity.WORKCENTER_CODE;
                pDataParameters[10].Value = pWorkOrdersRegister_T06Entity.COMPLETE_YN;
                pDataParameters[11].Value = pWorkOrdersRegister_T06Entity.TERMINAL_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T06_R10", pDataParameters);

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
                    "Sample_Info_Mst(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)",
                    pException
                );
            }
        }

        #endregion        
        
        #region 마스터 조회하기 - Sample_Info_Mst(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst2(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_plan_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_workcenter_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_day_and_night", MySqlDbType.VarChar, 10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_plan_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_workcenter_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_day_and_night", SqlDbType.NVarChar, 10)
                        };
                        break;
                }

                //pDataParameters[0].Value = pWorkOrdersRegister_T06Entity.CORP_CODE;
                pDataParameters[0].Value = pWorkOrdersRegister_T06Entity.CRUD;
                pDataParameters[1].Value = pWorkOrdersRegister_T06Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkOrdersRegister_T06Entity.DATE_TO;
                pDataParameters[3].Value = pWorkOrdersRegister_T06Entity.ORDER_CODE;
                pDataParameters[4].Value = pWorkOrdersRegister_T06Entity.PART_CODE;
                pDataParameters[5].Value = pWorkOrdersRegister_T06Entity.PART_NAME;
                pDataParameters[6].Value = pWorkOrdersRegister_T06Entity.REFERENCE_ID;
                pDataParameters[7].Value = pWorkOrdersRegister_T06Entity.PROCESS_CODE;
                pDataParameters[8].Value = pWorkOrdersRegister_T06Entity.USE_YN;
                pDataParameters[9].Value = pWorkOrdersRegister_T06Entity.WORKCENTER_CODE;
                pDataParameters[10].Value = pWorkOrdersRegister_T06Entity.COMPLETE_YN;
                pDataParameters[11].Value = pWorkOrdersRegister_T06Entity.TERMINAL_CODE;
                pDataParameters[12].Value = pWorkOrdersRegister_T06Entity.DAY_AND_NIGHT;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T08_R10", pDataParameters);

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
                    "Sample_Info_Mst(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)",
                    pException
                );
            }
        }

        #endregion        
        #region 정보 저장하기 - Sample_Info_Save(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)
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
                                new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_order_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_order_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_order_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_order_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_order_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pWorkOrdersRegister_T06Entity.CRUD;
                pDataParametersA[1].Value = pWorkOrdersRegister_T06Entity.USER_CODE;
                pDataParametersA[2].Value = pWorkOrdersRegister_T06Entity.ORDER_CODE;
                pDataParametersA[3].Value = pWorkOrdersRegister_T06Entity.ORDER_DATE;
                pDataParametersA[4].Value = pWorkOrdersRegister_T06Entity.WORKCENTER_CODE;
                pDataParametersA[5].Value = pWorkOrdersRegister_T06Entity.ORDER_QTY;
                pDataParametersA[6].Value = pWorkOrdersRegister_T06Entity.USE_YN;
                pDataParametersA[7].Value = pWorkOrdersRegister_T06Entity.PART_CODE;
                pDataParametersA[8].Value = pWorkOrdersRegister_T06Entity.TERMINAL_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T06_I10", pDataParametersA);

                pWorkOrdersRegister_T06Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pWorkOrdersRegister_T06Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pWorkOrdersRegister_T06Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pWorkOrdersRegister_T06Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "ProductOutRegister_Info_Save(ProductOutRegisterEntity pProductOutRegisterEntity, DataTable dt)",
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

        #region 정보 저장하기 - Sample_Info_Save(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save2(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity, DataTable dt)
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
                        //마스터 저장
                        IDataParameter[] pDataParametersA = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParametersA = new IDataParameter[]
                                {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_order_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_order_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_day_and_night", MySqlDbType.VarChar, 50)


                                };
                                break;

                            case "SQLServer":
                                pDataParametersA = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_order_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_order_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_order_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_day_and_night", SqlDbType.NVarChar, 50)
                                };
                                break;
                        }

                        pDataParametersA[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParametersA[1].Value = pWorkOrdersRegister_T06Entity.USER_CODE;
                        pDataParametersA[2].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper();
                        if (pDataParametersA[0].Value.Equals("C"))
                        {
                            string b = dt.Rows[a]["ORDER_DATE"].ToString();
                            string c = b.Substring(0, 10);
                            string d = c.Replace("-", "");
                            pDataParametersA[3].Value = d;
                        }
                        else
                        {
                            pDataParametersA[3].Value = dt.Rows[a]["ORDER_DATE"].ToString();
                        }
                        
                        pDataParametersA[4].Value = dt.Rows[a]["PROCESS_CODE"].ToString();
                        pDataParametersA[5].Value = dt.Rows[a]["PRODUCTION_ORDER_QTY"].ToString();
                        pDataParametersA[6].Value = dt.Rows[a]["USE_YN"].ToString();
                        pDataParametersA[7].Value = dt.Rows[a]["PART_CODE"].ToString();
                        pDataParametersA[8].Value = dt.Rows[a]["terminal_code"].ToString();
                        pDataParametersA[9].Value = dt.Rows[a]["DAYANDNIGHT"].ToString();
                        
                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkOrdersRegister_T08_I10", pDataParametersA);

                        if (pDataTableA.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pWorkOrdersRegister_T06Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                        pWorkOrdersRegister_T06Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                        pWorkOrdersRegister_T06Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                        pWorkOrdersRegister_T06Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
                    }
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
                    "ProductOutRegister_Info_Save(ProductOutRegisterEntity pProductOutRegisterEntity, DataTable dt)",
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
        public override WorkOrdersRegister_T06Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity = new WorkOrdersRegister_T06Entity();

                pWorkOrdersRegister_T06Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkOrdersRegister_T06Entity;
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

        #region 작업일보 조회하기 - Sample_Check_Next_Process (WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)
        /// <summary>
        /// 작업지시 수정 시, 해당 작업지시 번호로 이미 등록된 작업일보가 있는지 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>

        public DataTable Sample_Check_Next_Process(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                };
                        break;
                }

                pDataParameters[0].Value = pWorkOrdersRegister_T06Entity.CRUD;
                pDataParameters[1].Value = pWorkOrdersRegister_T06Entity.DATE_FROM;
                pDataParameters[2].Value = pWorkOrdersRegister_T06Entity.DATE_TO;
                pDataParameters[3].Value = pWorkOrdersRegister_T06Entity.PART_CODE;
                pDataParameters[4].Value = pWorkOrdersRegister_T06Entity.PART_NAME;
                pDataParameters[5].Value = pWorkOrdersRegister_T06Entity.PROCESS_CODE_MST;
                pDataParameters[6].Value = pWorkOrdersRegister_T06Entity.PROCESS_CODE;
                pDataParameters[7].Value = pWorkOrdersRegister_T06Entity.PRODUCTION_ORDER_ID;
                pDataParameters[8].Value = pWorkOrdersRegister_T06Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T02_R10", pDataParameters);
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
                    "WorkResultRegister_T02_Info_Mst(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)",
                    pException
                );
            }
        }
        #endregion
    }


    public class WorkOrderInfoPopup_T02Provider : EntityManager<WorkOrderInfoPopup_T02Entity>
    {
        #region 생성자 - WorkOrderInfoPopup_T02Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkOrderInfoPopup_T02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override WorkOrderInfoPopup_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkOrderInfoPopup_T02Entity pWorkOrderInfoPopup_T02Entity = new WorkOrderInfoPopup_T02Entity();
                pWorkOrderInfoPopup_T02Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pWorkOrderInfoPopup_T02Entity;
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

        #region 코드정보 조회하기 WorkOrderInfo_Return(string pCRUD, string pPLANORDER)

        public DataSet WorkOrderInfo_Return(string pCRUD, string pPLANORDER, string pPARTCODE, WorkOrderInfoPopup_T02Entity pWorkOrderInfoPopup_T02Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_production_plan_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPLANORDER;
                pDataParameters[2].Value = pPARTCODE;
                pDataParameters[3].Value = pWorkOrderInfoPopup_T02Entity.LANGUAGE_TYPE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_WorkOrderInfoPopup_T02_R11", pDataParameters);
                return pDataTableSet;
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
                    "WorkOrderInfo_Return(string pCRUD, string pPARTCODE, string pPARTNAME, string PARTTYPE)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - WorkOrderInfo_Save(WorkOrderInfoPopup_T02Entity pWorkOrderInfoPopup_T02Entity, DataTable pDataTable)


        public bool WorkOrderInfo_Save(WorkOrderInfoPopup_T02Entity pWorkOrderInfoPopup_T02Entity, DataTable pDataTable)
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_production_order_date", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 3),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_qty", MySqlDbType.Decimal),
                            new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_production_order_date", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_production_order_seq", SqlDbType.VarChar, 3),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_qty", SqlDbType.Decimal),
                            new SqlParameter("@v_reference_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(pDataTable.Rows[i]["IN_QTY"].ToString()) > 0)
                    {
                        pDataParametersA[0].Value = pWorkOrderInfoPopup_T02Entity.CRUD;
                        pDataParametersA[1].Value = pWorkOrderInfoPopup_T02Entity.USER_CODE;
                        //if (i == 0)
                        pDataParametersA[2].Value = "";
                        //else
                        //    pDataParametersA[2].Value = pWorkOrderInfoPopup_T02Entity.RTN_KEY;

                        pDataParametersA[3].Value = pDataTable.Rows[i]["PRODUCT_ORDER_DATE"].ToString().Substring(0, 10).Replace("/", "").Replace("-","");
                        pDataParametersA[4].Value = "";
                        pDataParametersA[5].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                        pDataParametersA[6].Value = pDataTable.Rows[i]["PROCESS_CODE"].ToString();
                        pDataParametersA[7].Value = Convert.ToDecimal(pDataTable.Rows[i]["IN_QTY"].ToString());
                        pDataParametersA[8].Value = pWorkOrderInfoPopup_T02Entity.REFERENCE_ID;
                        pDataParametersA[9].Value = "N";
                        pDataParametersA[10].Value = pDataTable.Rows[i]["WORKCENTER_CODE"].ToString();
                        pDataParametersA[11].Value = "Y";

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucWorkOrderInfoPopup_T02_I10", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pWorkOrderInfoPopup_T02Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                        }
                    }
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
                    "RuleGenerator_Info_Save(RuleGeneratorEntity pRuleGeneratorEntity, DataTable dt)",
                    pException
                );
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

    public class ucPlanOrderinfoPopup_T01Provider : EntityManager<ucPlanOrderinfoPopup_T01_Entity>
    {
        #region 생성자 - ucPlanOrderinfoPopup_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucPlanOrderinfoPopup_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기

        public override ucPlanOrderinfoPopup_T01_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucPlanOrderinfoPopup_T01_Entity pucPlanOrderinfoPopup_T01_Entity = new ucPlanOrderinfoPopup_T01_Entity();
                pucPlanOrderinfoPopup_T01_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucPlanOrderinfoPopup_T01_Entity;
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

        #region ○ 수주정보 조회하기

        public DataSet pucPlanOrderinfoPopup_T01_Return(ucPlanOrderinfoPopup_T01_Entity pucPlanOrderinfoPopup_T01_Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_plan_order", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_plan_order", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucPlanOrderinfoPopup_T01_Entity.CRUD;
                pDataParameters[1].Value = pucPlanOrderinfoPopup_T01_Entity.DATE_FROM;
                pDataParameters[2].Value = pucPlanOrderinfoPopup_T01_Entity.DATE_TO;
                pDataParameters[3].Value = pucPlanOrderinfoPopup_T01_Entity.PART_CODE;
                pDataParameters[4].Value = pucPlanOrderinfoPopup_T01_Entity.PART_NAME;
                pDataParameters[5].Value = pucPlanOrderinfoPopup_T01_Entity.PLAN_ORDER_ID;
                pDataParameters[6].Value = pucPlanOrderinfoPopup_T01_Entity.LANGUAGE_TYPE;


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, " USP_ucPlanOrderInfoPopup_T01_R11", pDataParameters);
                return pDataTableSet;
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
                    "ProductPlanInfo_Return(string pCRUD, string pPARTCODE, string pPARTNAME, string PARTTYPE)",
                    pException
                );
            }
        }

        #endregion
    }

    public class ucWorkResultPopUp_T02Provider : EntityManager<ucWorkResultPopUp_T02_Entity>
    {
        #region ○ 개체구하기
        public override ucWorkResultPopUp_T02_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucWorkResultPopUp_T02_Entity pucWorkResultPopUp_T02_Entity = new ucWorkResultPopUp_T02_Entity();
                pucWorkResultPopUp_T02_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucWorkResultPopUp_T02_Entity;
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

        #region ○ 생성자 - ucWorkResultPopUp_T02Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucWorkResultPopUp_T02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 저장하기 - WorkResultInfo_Save(ucWorkResultPopUp_T02_Entity pucWorkResultPopUp_T02_Entity)


        public bool WorkResultInfo_Save(ucWorkResultPopUp_T02_Entity pucWorkResultPopUp_T02_Entity)
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
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_property_value", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_condition_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_option_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_value", MySqlDbType.Decimal),
                            new MySqlParameter("@v_collection_value_str", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_property_value", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_condition_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_option_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_collection_value_str", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 20)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucWorkResultPopUp_T02_Entity.RESOURCE_CODE;
                pDataParametersA[1].Value = pucWorkResultPopUp_T02_Entity.COLLECTION_DATE;
                pDataParametersA[2].Value = pucWorkResultPopUp_T02_Entity.PROPERTY_VALUE;
                pDataParametersA[3].Value = pucWorkResultPopUp_T02_Entity.CONDITION_CODE;
                pDataParametersA[4].Value = "";
                pDataParametersA[5].Value = pucWorkResultPopUp_T02_Entity.COLLECTION_VALUE;
                pDataParametersA[6].Value = "";
                pDataParametersA[7].Value = "";

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pucWorkResultPopUp_T02_Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(ucWorkResultPopUp_T02_Entity pucWorkResultPopUp_T02_Entity)",
                    pException
                );
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

        public bool WorkResultInfo_Save_01(ucWorkResultPopUp_T02_Entity pucWorkResultPopUp_T02_Entity)
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucWorkResultPopUp_T02_Entity.CRUD;
                pDataParametersA[1].Value = pucWorkResultPopUp_T02_Entity.USER_CODE;
                pDataParametersA[2].Value = pucWorkResultPopUp_T02_Entity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pucWorkResultPopUp_T02_Entity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pucWorkResultPopUp_T02_Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(ucWorkResultPopUp_T02_Entity pucWorkResultPopUp_T02_Entity)",
                    pException
                );
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

    public class ucWorkResultPopUp_T03Provider : EntityManager<ucWorkResultPopUp_T03_Entity>
    {
        #region ○ 개체구하기
        public override ucWorkResultPopUp_T03_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucWorkResultPopUp_T03_Entity pucWorkResultPopUp_T03_Entity = new ucWorkResultPopUp_T03_Entity();
                pucWorkResultPopUp_T03_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucWorkResultPopUp_T03_Entity;
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

        #region ○ 생성자 - ucWorkResultPopUp_T03Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucWorkResultPopUp_T03Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 저장하기 - WorkResultInfo_Save(ucWorkResultPopUp_T03_Entity pucWorkResultPopUp_T03_Entity)


        public bool WorkResultInfo_Save(ucWorkResultPopUp_T03_Entity pucWorkResultPopUp_T03_Entity)
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
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_property_value", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_condition_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_option_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_value", MySqlDbType.Decimal),
                            new MySqlParameter("@v_collection_value_str", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_property_value", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_condition_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_option_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_collection_value_str", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 20)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucWorkResultPopUp_T03_Entity.RESOURCE_CODE;
                pDataParametersA[1].Value = pucWorkResultPopUp_T03_Entity.COLLECTION_DATE;
                pDataParametersA[2].Value = pucWorkResultPopUp_T03_Entity.PROPERTY_VALUE;
                pDataParametersA[3].Value = pucWorkResultPopUp_T03_Entity.CONDITION_CODE;
                pDataParametersA[4].Value = "";
                pDataParametersA[5].Value = pucWorkResultPopUp_T03_Entity.COLLECTION_VALUE;
                pDataParametersA[6].Value = "";
                pDataParametersA[7].Value = "";

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pucWorkResultPopUp_T03_Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(ucWorkResultPopUp_T03_Entity pucWorkResultPopUp_T03_Entity)",
                    pException
                );
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

        public bool WorkResultInfo_Save_01(ucWorkResultPopUp_T03_Entity pucWorkResultPopUp_T03_Entity)
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucWorkResultPopUp_T03_Entity.CRUD;
                pDataParametersA[1].Value = pucWorkResultPopUp_T03_Entity.USER_CODE;
                pDataParametersA[2].Value = pucWorkResultPopUp_T03_Entity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pucWorkResultPopUp_T03_Entity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pucWorkResultPopUp_T03_Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(ucWorkResultPopUp_T03_Entity pucWorkResultPopUp_T03_Entity)",
                    pException
                );
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
        
    public class Scheduling_T50Provider : EntityManager<Scheduling_T50Entity>
    {
        #region 생성자 - Scheduling_T50Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public Scheduling_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 파일명 조회하기 - Scheduling_T50_Info_Filename(Scheduling_T50Entity pScheduling_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pScheduling_T50Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Scheduling_T50_Info(Scheduling_T50Entity pScheduling_T50Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_order_date", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_all_view", MySqlDbType.VarChar, 10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_order_date", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_all_view", SqlDbType.NVarChar, 10)
                        };
                        break;
                }

                pDataParameters[0].Value = pScheduling_T50Entity.order_date;
                pDataParameters[1].Value = pScheduling_T50Entity.VEND_NAME;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Scheduling_T50_R14", pDataParameters);

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
                    "Scheduling_T50_Info_Filename(Scheduling_T50Entity pScheduling_T50Entity)",
                    pException
                );
            }
        }

        public DataTable Scheduling_T50_R13(Scheduling_T50Entity pScheduling_T50Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_all_view", MySqlDbType.VarChar, 10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_all_view", SqlDbType.NVarChar, 10)
                        };
                        break;
                }

                pDataParameters[0].Value = pScheduling_T50Entity.ORDER_ID;
                pDataParameters[1].Value = pScheduling_T50Entity.VEND_NAME;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Scheduling_T50_R13", pDataParameters);

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
                    "Scheduling_T50_R13(Scheduling_T50Entity pScheduling_T50Entity)",
                    pException
                );
            }
        }

        

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pScheduling_T50Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Scheduling_T50_EquiList(Scheduling_T50Entity pScheduling_T50Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_EQUIPMENT_MST_CODE", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_EQUIPMENT_MST_CODE", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pScheduling_T50Entity.EQUIPMENT_MST_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Scheduling_T50_R12", pDataParameters);

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
                    "Scheduling_T50_EquiList(Scheduling_T50Entity pScheduling_T50Entity)",
                    pException
                );
            }
        }



        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="ucScheduling_T50_OrderList">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ucScheduling_T50_OrderList(Scheduling_T50Entity pScheduling_T50Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_date", MySqlDbType.VarChar, 8)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_equipment_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_production_order_date", SqlDbType.NVarChar, 8)
                        };
                        break;
                }

                pDataParameters[0].Value = pScheduling_T50Entity.equipment_code;
                pDataParameters[1].Value = pScheduling_T50Entity.order_date ;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucScheduling_T50_R10", pDataParameters);

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
                    "ucScheduling_T50_OrderList(Scheduling_T50Entity pScheduling_T50Entity)",
                    pException
                );
            }
        }


        /// <summary>
        /// 설비배정하기
        /// </summary>
        /// <param name="ucScheduling_T50_U10">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ucScheduling_T50_U10(Scheduling_T50Entity pScheduling_T50Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@V_PRODUCTION_ORDER_ID", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@V_PRODUCTION_ORDER_SEQ", MySqlDbType.VarChar, 6),
                            new MySqlParameter("@V_PRODUCTION_ORDER_DATE", MySqlDbType.VarChar, 8)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_equipment_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@V_PRODUCTION_ORDER_ID", SqlDbType.NVarChar, 15),
                            new SqlParameter("@V_PRODUCTION_ORDER_SEQ", SqlDbType.NVarChar, 6),
                            new SqlParameter("@V_PRODUCTION_ORDER_DATE", SqlDbType.NVarChar, 8)
                        };
                        break;
                }

                pDataParameters[0].Value = pScheduling_T50Entity.equipment_code;
                pDataParameters[1].Value = pScheduling_T50Entity.USER_CODE;
                pDataParameters[2].Value = pScheduling_T50Entity.ORDER_ID;
                pDataParameters[3].Value = pScheduling_T50Entity.ORDER_SEQ;
                pDataParameters[4].Value = pScheduling_T50Entity.order_date;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucScheduling_T50_U10", pDataParameters);

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
                    "ucScheduling_T50_U10(Scheduling_T50Entity pScheduling_T50Entity)",
                    pException
                );
            }
        }

        /// <summary>
        /// 설비별 작업지시 순서 변경하기
        /// </summary>
        /// <param name="ucScheduling_T50_U11">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ucScheduling_T50_U11(Scheduling_T50Entity pScheduling_T50Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@V_EQUIPMENT_CODE", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@V_PRODUCTION_ORDER_DATE", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@V_PRODUCTION_ORDER_ID", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@V_PRODUCTION_ORDER_SEQ", MySqlDbType.VarChar, 6),
                            new MySqlParameter("@V_STATUS", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@V_ORDER_SEQ", MySqlDbType.Int32),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_equipment_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@V_PRODUCTION_ORDER_DATE", SqlDbType.NVarChar, 8),
                            new SqlParameter("@V_PRODUCTION_ORDER_ID", SqlDbType.NVarChar, 15),
                            new SqlParameter("@V_PRODUCTION_ORDER_SEQ", SqlDbType.NVarChar, 6),
                            new SqlParameter("@V_STATUS", SqlDbType.NVarChar, 10),
                            new SqlParameter("@V_ORDER_SEQ", SqlDbType.Int),
                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                        };
                        break;
                }

                pDataParameters[0].Value = pScheduling_T50Entity.equipment_code;
                pDataParameters[1].Value = pScheduling_T50Entity.order_date;
                pDataParameters[2].Value = pScheduling_T50Entity.ORDER_ID;
                pDataParameters[3].Value = pScheduling_T50Entity.ORDER_SEQ;
                pDataParameters[4].Value = pScheduling_T50Entity.CRUD;
                pDataParameters[5].Value = pScheduling_T50Entity.USER_SEQ;
                pDataParameters[6].Value = pScheduling_T50Entity.USER_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucScheduling_T50_U11", pDataParameters);

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
                    "ucScheduling_T50_U10(Scheduling_T50Entity pScheduling_T50Entity)",
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
        public override Scheduling_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                Scheduling_T50Entity pScheduling_T50Entity = new Scheduling_T50Entity();

                pScheduling_T50Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pScheduling_T50Entity;
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

    public class ucWorkResultPopUp_T50Provider : EntityManager<ucWorkResultPopUp_T50_Entity>
    {
        #region ○ 개체구하기
        public override ucWorkResultPopUp_T50_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucWorkResultPopUp_T50_Entity pucWorkResultPopUp_T50_Entity = new ucWorkResultPopUp_T50_Entity();
                pucWorkResultPopUp_T50_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucWorkResultPopUp_T50_Entity;
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

        #region ○ 생성자 - ucWorkResultPopUp_T50Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucWorkResultPopUp_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 저장하기 - WorkResultInfo_Save(ucWorkResultPopUp_T50_Entity pucWorkResultPopUp_T50_Entity)


        public bool WorkResultInfo_Save(ucWorkResultPopUp_T50_Entity pucWorkResultPopUp_T50_Entity)
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
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_property_value", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_condition_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_option_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_collection_value", MySqlDbType.Decimal),
                            new MySqlParameter("@v_collection_value_str", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_date", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_property_value", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_condition_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_option_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_collection_value_str", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 20)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucWorkResultPopUp_T50_Entity.RESOURCE_CODE;
                pDataParametersA[1].Value = pucWorkResultPopUp_T50_Entity.COLLECTION_DATE;
                pDataParametersA[2].Value = pucWorkResultPopUp_T50_Entity.PROPERTY_VALUE;
                pDataParametersA[3].Value = pucWorkResultPopUp_T50_Entity.CONDITION_CODE;
                pDataParametersA[4].Value = pucWorkResultPopUp_T50_Entity.OPTION_CODE;        //"";
                pDataParametersA[5].Value = pucWorkResultPopUp_T50_Entity.COLLECTION_VALUE;
                pDataParametersA[6].Value = "";
                pDataParametersA[7].Value = "";

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pucWorkResultPopUp_T50_Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(ucWorkResultPopUp_T50_Entity pucWorkResultPopUp_T50_Entity)",
                    pException
                );
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

        public bool WorkResultInfo_Save_01(ucWorkResultPopUp_T50_Entity pucWorkResultPopUp_T50_Entity)
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
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucWorkResultPopUp_T50_Entity.CRUD;
                pDataParametersA[1].Value = pucWorkResultPopUp_T50_Entity.USER_CODE;
                pDataParametersA[2].Value = pucWorkResultPopUp_T50_Entity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pucWorkResultPopUp_T50_Entity.PRODUCTION_ORDER_SEQ;
                pDataParametersA[4].Value = pucWorkResultPopUp_T50_Entity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T50_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pucWorkResultPopUp_T50_Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(ucWorkResultPopUp_T50_Entity pucWorkResultPopUp_T50_Entity)",
                    pException
                );
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



    public class WorkReadingStatusProvider : EntityManager<WorkReadingStatusEntity>
    {

        #region ○ 개체구하기
        public override WorkReadingStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkReadingStatusEntity pucWorkReadingStatusEntity = new WorkReadingStatusEntity();
                pucWorkReadingStatusEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucWorkReadingStatusEntity;
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


        #region 생성자 - WorkReadingStatusProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkReadingStatusProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(WorkReadingStatusEntity pWorkReadingStatusEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(WorkReadingStatusEntity pWorkReadingStatusEntity)
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
                            new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_reading_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 50)



                        //new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                        //new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                        //new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                        //new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_account", SqlDbType.VarChar, 100),
                            new SqlParameter("@v_reading_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar, 50)

                        //new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                        //new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                        //new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                        //new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 50)
                };
                        break;
                }

                pDataParameters[0].Value = pWorkReadingStatusEntity.CRUD;
                pDataParameters[1].Value = pWorkReadingStatusEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pWorkReadingStatusEntity.USER_ACCOUNT;
                pDataParameters[3].Value = pWorkReadingStatusEntity.READING_TYPE;
                pDataParameters[4].Value = pWorkReadingStatusEntity.DATE_FROM;
                pDataParameters[5].Value = pWorkReadingStatusEntity.DATE_TO;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkReadingStatus_R10", pDataParameters);

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
                    "WorkReadingStatus_Info_Mst(WorkReadingStatusEntity pWorkReadingStatusEntity)",
                    pException
                );
            }
        }

        #endregion

    }

    public class WorkResultStatus_T01Provider : EntityManager<WorkResultStatus_T01Entity>
    {

        #region 생성자 - ProductMonitoringProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkResultStatus_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 파일명 조회하기 - WorkResultStatus_T01_Info_Filename(WorkResultStatus_T01Entity pWorkResultStatus_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pWorkResultStatus_T01Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable WorkResultStatus_T01_Info_Filename(WorkResultStatus_T01Entity pWorkResultStatus_T01Entity)
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

                pDataParameters[0].Value = pWorkResultStatus_T01Entity.WINDOW_NAME;
                pDataParameters[1].Value = pWorkResultStatus_T01Entity.LANGUAGE_TYPE;

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
                    "WorkResultStatus_T01_Info_Filename(WorkResultStatus_T01Entity pWorkResultStatus_T01Entity)",
                    pException
                );
            }
        }

        #endregion
        #region XML파일 다운로드 - Templete_Download(WorkResultStatus_T01Entity pWorkResultStatus_T01Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object Templete_Download(WorkResultStatus_T01Entity pWorkResultStatus_T01Entity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pWorkResultStatus_T01Entity.LANGUAGE_TYPE;

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
        public override WorkResultStatus_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultStatus_T01Entity pWorkResultStatus_T01Entity = new WorkResultStatus_T01Entity();

                pWorkResultStatus_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultStatus_T01Entity;
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

    public class WorkResultRegister_T08Provider : EntityManager<WorkResultRegister_T08Entity>
    {
        #region 생성자 - WorkResultRegister_T08Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkResultRegister_T08Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Material_In_Mst(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)
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
                            new MySqlParameter("@v_work_seq", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_di_tolerance", MySqlDbType.VarChar, 50)                           
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T08Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T08Entity.WORK_SEQ;
                pDataParameters[2].Value = pWorkResultRegister_T08Entity.DATE_FROM;
                pDataParameters[3].Value = pWorkResultRegister_T08Entity.DATE_TO;
                pDataParameters[4].Value = pWorkResultRegister_T08Entity.PART_CODE;
                pDataParameters[5].Value = pWorkResultRegister_T08Entity.PART_NAME;
                pDataParameters[6].Value = pWorkResultRegister_T08Entity.VEND_CODE;
                pDataParameters[7].Value = pWorkResultRegister_T08Entity.VEND_NAME;
                pDataParameters[8].Value = pWorkResultRegister_T08Entity.LANGUAGE_TYPE;
                pDataParameters[9].Value = pWorkResultRegister_T08Entity.REMARK;
                pDataParameters[10].Value = pWorkResultRegister_T08Entity.DI_TOLERRANCE;             


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T08_R10", pDataParameters);

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
                    "Sample_Info_Mst(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - WorkResultRegister_T08_Info_Save(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool WorkResultRegister_T08_Info_Save(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)
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
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_work_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_work_qty", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_work_seq", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_di_tolerance", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_work_date", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_part_code", SqlDbType.VarChar, 20),
                                new SqlParameter("@v_vend_code", SqlDbType.VarChar, 20),
                                new SqlParameter("@v_work_qty", SqlDbType.VarChar, 1000),
                                new SqlParameter("@v_user_code", SqlDbType.VarChar, 20),
                                new SqlParameter("@v_work_seq", SqlDbType.VarChar, 50),
                        };
                        break;
                }

                pDataParametersA[0].Value = pWorkResultRegister_T08Entity.CRUD;
                pDataParametersA[1].Value = pWorkResultRegister_T08Entity.WORK_DATE;
                pDataParametersA[2].Value = pWorkResultRegister_T08Entity.PART_CODE;
                pDataParametersA[3].Value = pWorkResultRegister_T08Entity.VEND_CODE;
                pDataParametersA[4].Value = pWorkResultRegister_T08Entity.WORK_QTY;
                pDataParametersA[5].Value = pWorkResultRegister_T08Entity.USER_CODE;
                pDataParametersA[6].Value = pWorkResultRegister_T08Entity.WORK_SEQ;
                pDataParametersA[7].Value = pWorkResultRegister_T08Entity.LANGUAGE_TYPE;
                pDataParametersA[8].Value = pWorkResultRegister_T08Entity.REMARK;
                pDataParametersA[9].Value = pWorkResultRegister_T08Entity.DI_TOLERRANCE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T08_I10", pDataParametersA);

                pWorkResultRegister_T08Entity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                pWorkResultRegister_T08Entity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                pWorkResultRegister_T08Entity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                pWorkResultRegister_T08Entity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                pWorkResultRegister_T08Entity.RTN_AQ = pDataTableA.Rows[0]["rtn_aq"].ToString();
                pWorkResultRegister_T08Entity.RTN_SQ = pDataTableA.Rows[0]["rtn_sq"].ToString();
                pWorkResultRegister_T08Entity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTableA.Rows[0][0].ToString() != "00")
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
                    _pDBManager.RollbackTransaction();  // 저장 실패 Rollback Transaction 
                else
                    _pDBManager.CommitTransaction();  // 저장 성공  Commit Transaction
            }
            return pErrorYN;
        }





        #endregion 인쇄하기 - WorkReadingStatus(WorkREsultRegister_T08Entity pWorkResultRegister_T08Entity,DataTable dt)

        #region 인쇄하기 - WorkResultExcel(WorkResultRegister_T08Entity pWorkREsultRegister_T08Entity, DataTable dt)

        public DataTable WorkResultExcel(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "Mysql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud".Trim(),MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_work_seq".Trim(),MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from".Trim(),MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to".Trim(),MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_part_code".Trim(),MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name".Trim(),MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_code".Trim(),MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_name".Trim(),MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_remark".Trim(),MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_di_tolerance".Trim(),MySqlDbType.VarChar,50),
                        };
                        break;
                }

                pDataParameters[0].Value = pWorkResultRegister_T08Entity.CRUD;
                pDataParameters[1].Value = pWorkResultRegister_T08Entity.WORK_SEQ;
                pDataParameters[2].Value = pWorkResultRegister_T08Entity.DATE_FROM;
                pDataParameters[3].Value = pWorkResultRegister_T08Entity.DATE_TO;
                pDataParameters[4].Value = pWorkResultRegister_T08Entity.PART_CODE;
                pDataParameters[5].Value = pWorkResultRegister_T08Entity.PART_NAME;
                pDataParameters[6].Value = pWorkResultRegister_T08Entity.VEND_CODE;
                pDataParameters[7].Value = pWorkResultRegister_T08Entity.VEND_NAME;
                pDataParameters[8].Value = pWorkResultRegister_T08Entity.REMARK;
                pDataParameters[9].Value = pWorkResultRegister_T08Entity.DI_TOLERRANCE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultExcel_R10", pDataParameters);

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
                    "WorkResultExcel(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)",
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
        public override WorkResultRegister_T08Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkResultRegister_T08Entity pWorkResultRegister_T08Entity = new WorkResultRegister_T08Entity();

                pWorkResultRegister_T08Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWorkResultRegister_T08Entity;
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

    public class ucWorkOrderInfoPopup_T04Provider : EntityManager<ucWorkOrderInfoPopup_T04Entity>
    {
        #region 생성자 - ucWorkOrderInfoPopup_T04Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucWorkOrderInfoPopup_T04Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucWorkOrderInfoPopup_T04Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucWorkOrderInfoPopup_T04Entity pucWorkOrderInfoPopup_T04Entity = new ucWorkOrderInfoPopup_T04Entity();
                pucWorkOrderInfoPopup_T04Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucWorkOrderInfoPopup_T04Entity;
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

        #region 코드정보 조회하기 WorkOrderInfo_Return(string pCRUD, string pPLANORDER)

        public DataSet WorkOrderInfo_Return(string pCRUD, string pPLANORDER, string pPARTCODE, ucWorkOrderInfoPopup_T04Entity pucWorkOrderInfoPopup_T04Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_plan_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_leave_qty", MySqlDbType.Decimal)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_production_plan_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_leave_qty",    SqlDbType.Decimal)

                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPLANORDER;
                pDataParameters[2].Value = pPARTCODE;
                pDataParameters[3].Value = pucWorkOrderInfoPopup_T04Entity.LANGUAGE_TYPE;
                pDataParameters[4].Value = Convert.ToDecimal(pucWorkOrderInfoPopup_T04Entity.LEAVE_QTY) ;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucWorkOrderInfoPopup_T04_R10", pDataParameters);
                return pDataTableSet;
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
                    "WorkOrderInfo_Return(string pCRUD, string pPARTCODE, string pPARTNAME, string PARTTYPE)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - WorkOrderInfo_Save(ucWorkOrderInfoPopup_T04Entity pucWorkOrderInfoPopup_T04Entity, DataTable pDataTable)


        public bool WorkOrderInfo_Save(ucWorkOrderInfoPopup_T04Entity pucWorkOrderInfoPopup_T04Entity, DataTable pDataTable)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();

            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                pucWorkOrderInfoPopup_T04Entity.RTN_KEY = "";
                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParametersA = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_production_order_date", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 3),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_qty", MySqlDbType.Decimal),
                            new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_production_order_date", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_production_order_seq", SqlDbType.VarChar, 3),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_qty", SqlDbType.Decimal),
                            new SqlParameter("@v_reference_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(pDataTable.Rows[i]["IN_QTY"].ToString()) > 0)
                    {
                        pDataParametersA[0].Value = pucWorkOrderInfoPopup_T04Entity.CRUD;
                        pDataParametersA[1].Value = pucWorkOrderInfoPopup_T04Entity.USER_CODE;
                        //if (i == 0)
                        //pDataParametersA[2].Value = "";
                        //else
                        pDataParametersA[2].Value = pucWorkOrderInfoPopup_T04Entity.RTN_KEY;
                        if (pDataTable.Rows[i]["PRODUCT_ORDER_DATE"].ToString().Substring(0, 10).Substring(0, 10).Replace("-", "").Length > 8)
                        {
                            pDataParametersA[3].Value = pDataTable.Rows[i]["PRODUCT_ORDER_DATE"].ToString().Substring(0, 10).Replace("/", "");
                        }
                        else
                        {
                            pDataParametersA[3].Value = pDataTable.Rows[i]["PRODUCT_ORDER_DATE"].ToString().Substring(0, 10).Replace("-", "");
                        }
                        pDataParametersA[4].Value = "";
                        pDataParametersA[5].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                        pDataParametersA[6].Value = pDataTable.Rows[i]["PROCESS_CODE"].ToString();
                        pDataParametersA[7].Value = Convert.ToDecimal(pDataTable.Rows[i]["IN_QTY"].ToString());
                        pDataParametersA[8].Value = pucWorkOrderInfoPopup_T04Entity.REFERENCE_ID;
                        pDataParametersA[9].Value = "N";
                        pDataParametersA[10].Value = pDataTable.Rows[i]["WORKCENTER_CODE"].ToString();
                        pDataParametersA[11].Value = "Y";

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucucWorkOrderInfoPopup_T04_I10", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pucWorkOrderInfoPopup_T04Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                        }
                    }
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
                    "RuleGenerator_Info_Save(RuleGeneratorEntity pRuleGeneratorEntity, DataTable dt)",
                    pException
                );
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

    public class ProductionResultState_T50Provider : EntityManager<ProductionResultState_T50Entity>
    {
        #region 생성자 - WorkOrdersRegister_T50Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductionResultState_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(SampleExcelBindingEntity pRawMaterialInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pRawMaterialInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(ProductionResultState_T50Entity pProductionResultState_T50Entity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;

                }

                pDataParameters[0].Value = pProductionResultState_T50Entity.CRUD;
                pDataParameters[1].Value = pProductionResultState_T50Entity.WINDOW_NAME;
                pDataParameters[2].Value = pProductionResultState_T50Entity.LANGUAGE_TYPE;

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

        #region 목표실적 테이블 피봇 조회

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pRawMaterialInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable SSP_PIVOT_RETURN_R10(string condition)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("tbl_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("base_group_col", MySqlDbType.VarChar, 100),
                            new MySqlParameter("pivot_col", MySqlDbType.VarChar, 100),
                            new MySqlParameter("value_col", MySqlDbType.VarChar, 100),
                            new MySqlParameter("condition_string", MySqlDbType.VarChar, 1000),
                            new MySqlParameter("order_by", MySqlDbType.VarChar, 1000)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                        };
                        break;

                }

                pDataParameters[0].Value = "production_goal_month";
                pDataParameters[1].Value = "goal_type";
                pDataParameters[2].Value = "goal_month";
                pDataParameters[3].Value = "goal_cost";
                pDataParameters[4].Value = condition;
                pDataParameters[5].Value = "";

                DataTable pDatatable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_PIVOT_RETURN_R10", pDataParameters);


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

        #region 생산실적 테이블 조회
        public DataTable USP_product_inout_R10(string condition)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {

                            new MySqlParameter("Param_condition", MySqlDbType.VarChar, 2)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {

                        };
                        break;

                }

                pDataParameters[0].Value = condition;

                DataTable pDatatable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_product_inout_R10", pDataParameters);


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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ProductionResultState_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductionResultState_T50Entity pProductionResultState_T50Entity = new ProductionResultState_T50Entity();

                pProductionResultState_T50Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProductionResultState_T50Entity;
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

    public class ProductionStatusProvider : EntityManager<ProductionStatusEntity>
    {
        #region 생성자 - WorkOrdersRegister_T50Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductionStatusProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(SampleExcelBindingEntity pRawMaterialInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pRawMaterialInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductionStatus_Info_Filename(ProductionStatusEntity pProductionStatusEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;

                }

                pDataParameters[0].Value = pProductionStatusEntity.CRUD;
                pDataParameters[1].Value = pProductionStatusEntity.WINDOW_NAME;
                pDataParameters[2].Value = pProductionStatusEntity.LANGUAGE_TYPE;

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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ProductionStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductionStatusEntity pProductionStatusEntity = new ProductionStatusEntity();

                pProductionStatusEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProductionStatusEntity;
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
