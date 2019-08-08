using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

using CoFAS_MES.POP.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;
using DevExpress.Spreadsheet;
using DevExpress.XtraGrid.Views.Grid;

namespace CoFAS_MES.POP.Data
{
    public class POPProductionOrderProvider : EntityManager<POPProductionOrderEntity>
    {
        #region 생성자 - POPProductionOrderProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPProductionOrderProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - POPProductionOrder_Info_Mst(POPProductionOrderEntity pPOPProductionOrderEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductionOrder_Info_Mst(POPProductionOrderEntity pPOPProductionOrderEntity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrderEntity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrderEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pPOPProductionOrderEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPOPProductionOrderEntity.PROCESS_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrder_R10", pDataParameters);

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

        public DataSet POPProductionOrder_Info_Mst_3(POPProductionOrderEntity pPOPProductionOrderEntity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrderEntity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrderEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pPOPProductionOrderEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPOPProductionOrderEntity.PROCESS_CODE;

                // DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrder_R10", pDataParameters);
                   DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_frmPOPMain_PRODUCT_BIOCERRA_R10", pDataParameters);


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
                    "Sample_Info_Mst(SampleExcelBindingEntity pSampleExcelBindingEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 마스터 조회하기_다시조회 - POPProductionOrder_Info_Mst(POPProductionOrderEntity pPOPProductionOrderEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductionOrder_Info_Mst_2(POPProductionOrderEntity pPOPProductionOrderEntity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrderEntity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrderEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pPOPProductionOrderEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPOPProductionOrderEntity.PROCESS_CODE;
                pDataParameters[4].Value = pPOPProductionOrderEntity.PRODUCTION_ORDER_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrder_R20", pDataParameters);

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

        #region 정보 저장하기 - POPProductionOrder_Save(POPProductionOrderEntity pPOPProductionOrderEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPOPProductionOrderEntity"></param>
        /// <returns></returns>
        public bool POPProductionOrder_Save(POPProductionOrderEntity pPOPProductionOrderEntity)
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
                                    new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_collection_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_date", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_property_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_condition_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.VarChar,10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_collection_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_date", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_property_value", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_condition_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_value", SqlDbType.VarChar,10)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrderEntity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrderEntity.CRUD;
                pDataParameters[2].Value = pPOPProductionOrderEntity.USER_CODE;
                //pDataParameters[3].Value = pPOPProductionOrderEntity.COLLECTION_CODE;
                //pDataParameters[4].Value = pPOPProductionOrderEntity.COLLECTION_DATE;
                //pDataParameters[5].Value = pPOPProductionOrderEntity.PROPERTY_VALUE;
                //pDataParameters[6].Value = pPOPProductionOrderEntity.CONDITION_CODE;
                //pDataParameters[7].Value = pPOPProductionOrderEntity.COLLECTION_VALUE;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_DQGathering_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pPOPProductionOrderEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pPOPProductionOrderEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pPOPProductionOrderEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pPOPProductionOrderEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pPOPProductionOrderEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "POPProductionOrder_Save(POPProductionOrderEntity pPOPProductionOrderEntity)",
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
        public override POPProductionOrderEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPProductionOrderEntity pPOPProductionOrderEntity = new POPProductionOrderEntity();

                pPOPProductionOrderEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPProductionOrderEntity;
            }
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

    public class POPProductionOrder_T03Provider : EntityManager<POPProductionOrder_T03Entity>
    {
        #region 생성자 - POPProductionOrder_T03Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPProductionOrder_T03Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - POPProductionOrder_Info_Mst(POPProductionOrderEntity pPOPProductionOrderEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrder_T03Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductionOrder_Info_Mst(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrder_T03Entity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrder_T03Entity.RESOURCE_CODE;
                pDataParameters[2].Value = pPOPProductionOrder_T03Entity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPOPProductionOrder_T03Entity.PROCESS_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrder_T03_R10", pDataParameters);

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
                    "POPProductionOrder_Info_Mst(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 마스터 조회하기_다시조회 - POPProductionOrder_Info_Mst_2(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductionOrder_Info_Mst_2(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrder_T03Entity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrder_T03Entity.RESOURCE_CODE;
                pDataParameters[2].Value = pPOPProductionOrder_T03Entity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPOPProductionOrder_T03Entity.PROCESS_CODE;
                pDataParameters[4].Value = pPOPProductionOrder_T03Entity.PRODUCTION_ORDER_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrder_T03_R20", pDataParameters);

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
                    "POPProductionOrder_Info_Mst_2(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - POPProductionOrder_Save(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPOPProductionOrderEntity"></param>
        /// <returns></returns>
        public bool POPProductionOrder_Save(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)
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
                                    new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_collection_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_date", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_property_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_condition_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.VarChar,10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_collection_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_date", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_property_value", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_condition_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_value", SqlDbType.VarChar,10)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrder_T03Entity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrder_T03Entity.CRUD;
                pDataParameters[2].Value = pPOPProductionOrder_T03Entity.USER_CODE;
                //pDataParameters[3].Value = pPOPProductionOrderEntity.COLLECTION_CODE;
                //pDataParameters[4].Value = pPOPProductionOrderEntity.COLLECTION_DATE;
                //pDataParameters[5].Value = pPOPProductionOrderEntity.PROPERTY_VALUE;
                //pDataParameters[6].Value = pPOPProductionOrderEntity.CONDITION_CODE;
                //pDataParameters[7].Value = pPOPProductionOrderEntity.COLLECTION_VALUE;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_DQGathering_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pPOPProductionOrder_T03Entity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pPOPProductionOrder_T03Entity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pPOPProductionOrder_T03Entity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pPOPProductionOrder_T03Entity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pPOPProductionOrder_T03Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "POPProductionOrder_Save(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)",
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
        public override POPProductionOrder_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity = new POPProductionOrder_T03Entity();

                pPOPProductionOrder_T03Entity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPProductionOrder_T03Entity;
            }
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

    public class POPProductionOrder_T50Provider : EntityManager<POPProductionOrder_T50Entity>
    {
        #region 생성자 - POPProductionOrder_T50Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPProductionOrder_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - POPProductionOrder_Info_Mst(POPProductionOrderEntity pPOPProductionOrderEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrder_T50Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductionOrder_Info_Mst(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrder_T50Entity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrder_T50Entity.RESOURCE_CODE; //pop
                pDataParameters[2].Value = pPOPProductionOrder_T50Entity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPOPProductionOrder_T50Entity.PROCESS_CODE; //설비

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrder_T50_R11", pDataParameters);

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
                    "POPProductionOrder_Info_Mst(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)",
                    pException
                );
            }
        }

        #endregion


        public DataTable USP_production_order_detail_t50_check_R10(string order_id, string seq)
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
                            new MySqlParameter("@Param_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_seq", MySqlDbType.VarChar, 5)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = order_id;
                pDataParameters[1].Value = seq; //pop

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_production_order_detail_t50_check_R10", pDataParameters);

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
                    "POPProductionOrder_Info_Mst(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)",
                    pException
                );
            }
        }

        #region 마스터 조회하기_다시조회 - POPProductionOrder_Info_Mst_2(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductionOrder_Info_Mst_2(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrder_T50Entity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrder_T50Entity.RESOURCE_CODE;
                pDataParameters[2].Value = pPOPProductionOrder_T50Entity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPOPProductionOrder_T50Entity.PROCESS_CODE;
                pDataParameters[4].Value = pPOPProductionOrder_T50Entity.PRODUCTION_ORDER_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrder_T50_R20", pDataParameters);

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
                    "POPProductionOrder_Info_Mst_2(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - POPProductionOrder_Save(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPOPProductionOrderEntity"></param>
        /// <returns></returns>
        public bool POPProductionOrder_Save(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)
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
                                    new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_collection_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_date", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_property_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_condition_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.VarChar,10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_collection_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_date", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_property_value", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_condition_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_value", SqlDbType.VarChar,10)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrder_T50Entity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrder_T50Entity.CRUD;
                pDataParameters[2].Value = pPOPProductionOrder_T50Entity.USER_CODE;
                //pDataParameters[3].Value = pPOPProductionOrderEntity.COLLECTION_CODE;
                //pDataParameters[4].Value = pPOPProductionOrderEntity.COLLECTION_DATE;
                //pDataParameters[5].Value = pPOPProductionOrderEntity.PROPERTY_VALUE;
                //pDataParameters[6].Value = pPOPProductionOrderEntity.CONDITION_CODE;
                //pDataParameters[7].Value = pPOPProductionOrderEntity.COLLECTION_VALUE;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_DQGathering_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pPOPProductionOrder_T50Entity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pPOPProductionOrder_T50Entity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pPOPProductionOrder_T50Entity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pPOPProductionOrder_T50Entity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pPOPProductionOrder_T50Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "POPProductionOrder_Save(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 스캔 작지 조회하기 - POPProductionOrder_Info_Mst(POPProductionOrderEntity pPOPProductionOrderEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrder_T50Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable USP_PRODUCTION_ORDER_T50_R12(string id)
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
                            new MySqlParameter("@Param_production_order_id", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_production_order_id", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = id;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_PRODUCTION_ORDER_T50_R12", pDataParameters);

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
                    "POPProductionOrder_Info_Mst(POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 스캔 작지 조회하기 - POPProductionOrder_Info_Mst(POPProductionOrderEntity pPOPProductionOrderEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrder_T50Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable USP_production_order_detail_t50_U10(string id, string seq, string equipment)
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
                            new MySqlParameter("@Param_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_production_order_seq", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_equipment_code", MySqlDbType.VarChar, 50),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@Param_production_order_seq", SqlDbType.VarChar, 50),
                            new SqlParameter("@Param_equipment_code", SqlDbType.VarChar, 50),

                };
                        break;
                }

                pDataParameters[0].Value = id;
                pDataParameters[1].Value = seq;
                pDataParameters[2].Value = equipment;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_production_order_detail_t50_U10", pDataParameters);

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
                    "USP_production_order_detail_t50_U10(USP_production_order_detail_t50_U10 pPOPProductionOrder_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 작업자 조회하기 - POPProductionOrder_Info_Mst(POPProductionOrderEntity pPOPProductionOrderEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrder_T50Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable USP_user_mst_R10()
        {

            // 회사코드
            // 단말기번호(옵션)


            try
            {
                IDataParameter[] pDataParameters = null;

                //switch (_pDBManager.DBManagerType.ToString())
                //{
                //    case "MySql":
                //        pDataParameters = new IDataParameter[]
                //        {
                //            new MySqlParameter("@Param_production_order_id", MySqlDbType.VarChar, 50),
                //            new MySqlParameter("@Param_production_order_seq", MySqlDbType.VarChar, 50),
                //            new MySqlParameter("@Param_equipment_code", MySqlDbType.VarChar, 50),


                //};
                //        break;

                //    case "SQLServer":
                //        pDataParameters = new IDataParameter[]
                //        {
                //            new SqlParameter("@Param_production_order_id", SqlDbType.VarChar, 50),
                //            new SqlParameter("@Param_production_order_seq", SqlDbType.VarChar, 50),
                //            new SqlParameter("@Param_equipment_code", SqlDbType.VarChar, 50),

                //};
                //        break;
                //}
                

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_user_mst_R10", pDataParameters);

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
                    "USP_user_mst_R10(USP_user_mst_R10 pPOPProductionOrder_T50Entity)",
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
        public override POPProductionOrder_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPProductionOrder_T50Entity pPOPProductionOrder_T50Entity = new POPProductionOrder_T50Entity();

                pPOPProductionOrder_T50Entity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPProductionOrder_T50Entity;
            }
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

    public class POPLabelPrintProvider : EntityManager<POPLabelPrintEntity>
    {
        #region 생성자 - POPProductionOrder_T03Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPLabelPrintProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - POPProductionOrder_Info_Mst(POPProductionOrderEntity pPOPProductionOrderEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrder_T03Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProduction_Info_Mst(POPLabelPrintEntity pPOPLabelPrintEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),


                };
                        break;
                }

                pDataParameters[0].Value = pPOPLabelPrintEntity.CRUD;
                pDataParameters[1].Value = pPOPLabelPrintEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POPLabelPrint_R10", pDataParameters);

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
                    "POPProductionOrder_Info_Mst(POPProductionOrder_T03Entity pPOPProductionOrder_T03Entity)",
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
        public override POPLabelPrintEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPLabelPrintEntity pPOPLabelPrintEntity = new POPLabelPrintEntity();

                pPOPLabelPrintEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPLabelPrintEntity;
            }
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
    public class POPSelect_INSPECT_COSMETICSProvider : EntityManager<POPSelect_INSPECT_COSMETICSEntity>
    {
        #region 생성자 - POPSelect_INSPECT_COSMETICSProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPSelect_INSPECT_COSMETICSProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - POPSelect_INSPECT_COSMETICS_Info_Mst(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPSelect_INSPECT_COSMETICSEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPSelect_INSPECT_COSMETICS_Info_Mst(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
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
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_today", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_today", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_process_code_mst", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),


                };
                        break;
                }

                pDataParameters[0].Value = "R";// pPOPSelect_INSPECT_COSMETICSEntity.CRUD;
                pDataParameters[1].Value = pPOPSelect_INSPECT_COSMETICSEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pPOPSelect_INSPECT_COSMETICSEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPOPSelect_INSPECT_COSMETICSEntity.PROCESS_CODE;
                pDataParameters[4].Value = "";// pPOPSelect_INSPECT_COSMETICSEntity.TODAY;
                pDataParameters[5].Value = "";//pPOPSelect_INSPECT_COSMETICSEntity.PROCESS_CODE_MST;
                pDataParameters[6].Value = "";//pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_ORDER_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POPSelect_INSPECT_COSMETICS_R10", pDataParameters);

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


        #region 정보 저장하기 - POPSelect_INSPECT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPOPSelect_INSPECT_COSMETICSEntity"></param>
        /// <returns></returns>
        public bool POPSelect_INSPECT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
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
                                    new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_collection_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_date", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_property_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_condition_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.VarChar,10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_collection_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_date", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_property_value", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_condition_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_value", SqlDbType.VarChar,10)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPSelect_INSPECT_COSMETICSEntity.CORP_CODE;
                pDataParameters[1].Value = pPOPSelect_INSPECT_COSMETICSEntity.CRUD;
                pDataParameters[2].Value = pPOPSelect_INSPECT_COSMETICSEntity.USER_CODE;
                //pDataParameters[3].Value = pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_CODE;
                //pDataParameters[4].Value = pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_DATE;
                //pDataParameters[5].Value = pPOPSelect_INSPECT_COSMETICSEntity.PROPERTY_VALUE;
                //pDataParameters[6].Value = pPOPSelect_INSPECT_COSMETICSEntity.CONDITION_CODE;
                //pDataParameters[7].Value = pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_VALUE;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_DQGathering_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pPOPSelect_INSPECT_COSMETICSEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "POPSelect_INSPECT_COSMETICS_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)",
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
        public override POPSelect_INSPECT_COSMETICSEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity = new POPSelect_INSPECT_COSMETICSEntity();

                pPOPSelect_INSPECT_COSMETICSEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPSelect_INSPECT_COSMETICSEntity;
            }
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
    
    public class DQGatheringProvider : EntityManager<DQGatheringEntity>
    {
        #region 생성자 - DQGatheringProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public DQGatheringProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 정보 저장하기 - DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDQGatheringEntity"></param>
        /// <returns></returns>
        public bool DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)
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
                                    new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_collection_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_date", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_property_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_condition_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.VarChar,10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_collection_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_date", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_property_value", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_condition_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_value", SqlDbType.VarChar,10)
                        };
                        break;
                }

                pDataParameters[0].Value = pDQGatheringEntity.CORP_CODE;
                pDataParameters[1].Value = pDQGatheringEntity.CRUD;
                pDataParameters[2].Value = pDQGatheringEntity.USER_CODE;
                pDataParameters[3].Value = pDQGatheringEntity.COLLECTION_CODE;
                pDataParameters[4].Value = pDQGatheringEntity.COLLECTION_DATE;
                pDataParameters[5].Value = pDQGatheringEntity.PROPERTY_VALUE;
                pDataParameters[6].Value = pDQGatheringEntity.CONDITION_CODE;
                pDataParameters[7].Value = pDQGatheringEntity.COLLECTION_VALUE;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_DQGathering_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pDQGatheringEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pDQGatheringEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pDQGatheringEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pDQGatheringEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pDQGatheringEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)",
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
        public override DQGatheringEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                DQGatheringEntity pDQGatheringEntity = new DQGatheringEntity();

                pDQGatheringEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pDQGatheringEntity;
            }
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

    public class DBInterfaceProvider : EntityManager<DBInterfaceEntity>
    {
        #region 생성자 - DBInterfaceProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public DBInterfaceProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        public DataTable Interface_Data_Order()
        {
            try
            {
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.Text, "select top 1 jsno from tblerporder order by jsno desc");

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
                    "Interface_Data_Info_Order()",
                    pException
                );
            }

        }

        #region 마스터 조회하기 - Interface_Data_Order_Bokang()

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Interface_Data_Order_Bokang()
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DYETEC_Bokang_Search", pDataParameters);

                return pDataTable;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Interface_Data_Order_Bokang()",
                    pException
                );
            }
        }

        #endregion


        public DataTable Interface_Data_minwon(string strJSNO)
        {
            try
            {
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.Text, "select a.* FROM[DYETEC_DB].[dbo].[VW_OD_1000] as a with (nolock)   where a.jsno > '" + strJSNO + "' order by jsno");

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
                    "Interface_Data_minwon()",
                    pException
                );
            }

        }

        public DataTable Interface_Data_workorder(string PLAN_NUMB)
        {
            try
            {
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.Text, "	SELECT  a.* , b.COLR_NAME  FROM [DYETEC_DB].[dbo].[VW_BT_1000] as a with (nolock) inner join VW_OD_1100 as b with (nolock)   on a.work_date = b.work_date and a.HEAD_NUMB = b.HEAD_NUMB and a.sqen_numb = b.SQEN_NUMB where a.PROC_NUMB > '" + PLAN_NUMB + "'   order by a.PROC_NUMB  ");

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
                    "Interface_Data_workorder()",
                    pException
                );
            }

        }

        public DataTable Interface_Data_color(string strJSNO)
        {
            try
            {
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.Text, "select a.* FROM[DYETEC_DB].[dbo].[VW_OD_1100] as a with (nolock)   where a.jsno > '" + strJSNO + "' order by jsno");

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
                    "Interface_Data_color()",
                    pException
                );
            }

        }

        public DataTable Interface_Data_workplan(string strPlan)
        {
            try
            {
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.Text, "select a.* FROM[DYETEC_DB].[dbo].[vw_BT_2000] as a with (nolock)   where a.PLAN_NUMB > '" + strPlan + "' order by PLAN_NUMB");

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
                    "Interface_Data_color()",
                    pException
                );
            }

        }


        public DataTable Interface_Data_Sensor()
        {
            try
            {
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.Text, "select top 1 work_date, proc_date, proc_time from tblsensordata order by work_date desc, proc_date desc, proc_time desc");

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
                    "Interface_Data_Sensor()",
                    pException
                );
            }

        }

        public DataTable Interface_Data_Order_MST(string strJSNO)
        {
            try
            {
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.Text, "SELECT * FROM[INTER_DB].[dbo].vw_ord WITH(NOLOCK) WHERE cust_code = '0002' and  jsno > '" + strJSNO + "'");

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
                    "Interface_Data_Order_MST(string strJSNO)",
                    pException
                );
            }

        }

        public DataTable Interface_Data_Sensor_MST(string strWORK_DATE, string strPROC_DATE, string strPROC_TIME)
        {
            try
            {
                //DataTable pDataTable = _pDBManager.GetDataTable(CommandType.Text, "SELECT top 1000 * FROM[TEMPER_DB].[dbo].[TP_1000] WITH(NOLOCK) WHERE WORK_DATE >= '"+ strWORK_DATE + "'" +" AND PROC_DATE >= '" + strPROC_DATE + "'" + " AND PROC_TIME > '" + strPROC_TIME + "'" + " ORDER BY WORK_dATE ASC, PROC_DATE ASC, PROC_TIME ASC");
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.Text, "SELECT top 1000 * FROM[TEMPER_DB].[dbo].[TP_1000] WITH(NOLOCK) WHERE WORK_DATE >= '" + strWORK_DATE + "'" + " AND PROC_DATE+PROC_TIME > '" + strPROC_DATE + strPROC_TIME + "'" + " ORDER BY WORK_dATE ASC, PROC_DATE ASC, PROC_TIME ASC");

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
                    "Interface_Data_Sensor_MST(string strWORK_DATE, string strSQEN_NUMB)",
                    pException
                );
            }

        }

        public DataTable Interface_Data_Sensor_MST_sarim(string strWORK_DATE, string strPROC_DATE, string strPROC_TIME)
        {
            try
            {
                //DataTable pDataTable = _pDBManager.GetDataTable(CommandType.Text, "SELECT top 1000 * FROM[TEMPER_DB].[dbo].[TP_1000] WITH(NOLOCK) WHERE WORK_DATE >= '"+ strWORK_DATE + "'" +" AND PROC_DATE >= '" + strPROC_DATE + "'" + " AND PROC_TIME > '" + strPROC_TIME + "'" + " ORDER BY WORK_dATE ASC, PROC_DATE ASC, PROC_TIME ASC");
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.Text, "SELECT top 1000 * FROM[TEMPER].[dbo].[TP_1000] WITH(NOLOCK) WHERE WORK_DATE >= '" + strWORK_DATE + "'" + " AND PROC_DATE+PROC_TIME > '" + strPROC_DATE + strPROC_TIME + "'" + " ORDER BY WORK_dATE ASC, PROC_DATE ASC, PROC_TIME ASC");

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
                    "Interface_Data_Sensor_MST(string strWORK_DATE, string strSQEN_NUMB)",
                    pException
                );
            }

        }

        #region 정보 저장하기 - Interface_Data_Order_Save(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDQGatheringEntity"></param>
        /// <returns></returns>
        public bool Interface_Data_Order_Save(DBInterfaceEntity pDBInterfaceEntity,  DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
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
                                    //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                    //new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                    //new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_jsno", MySqlDbType.VarChar,9),
                                    new MySqlParameter("@v_ordno", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_jpsu_date", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_nabdat", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_cust_code", MySqlDbType.VarChar,4),
                                    new MySqlParameter("@v_short_name", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_item_code", MySqlDbType.VarChar,11),
                                    new MySqlParameter("@v_item_name", MySqlDbType.VarChar,30),
                                    new MySqlParameter("@v_kagu_code", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_kagu_name", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_pog1", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_scust_name", MySqlDbType.VarChar,30),
                                    new MySqlParameter("@v_colcnt", MySqlDbType.Int32),
                                    new MySqlParameter("@v_cqty", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_soyo_qty", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_dan", MySqlDbType.VarChar,1)
                            };
                            break;

                        case "SQLServer":
                            pDataParameters = new IDataParameter[]
                            {
                                    //new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                                    //new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    //new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_jsno", SqlDbType.NVarChar,9),
                                    new SqlParameter("@v_ordno", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_jpsu_date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_nabdat", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_cust_code", SqlDbType.NVarChar,4),
                                    new SqlParameter("@v_short_name", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_item_code", SqlDbType.NVarChar,11),
                                    new SqlParameter("@v_item_name", SqlDbType.NVarChar,30),
                                    new SqlParameter("@v_kagu_code", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_kagu_name", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_pog1", SqlDbType.Decimal),
                                    new SqlParameter("@v_scust_name", SqlDbType.NVarChar,30),
                                    new SqlParameter("@v_colcnt", SqlDbType.Int),
                                    new SqlParameter("@v_cqty", SqlDbType.Decimal),
                                    new SqlParameter("@v_soyo_qty", SqlDbType.Decimal),
                                    new SqlParameter("@v_dan", SqlDbType.NVarChar,1)
                            };
                            break;
                    }

                    pDataParameters[0].Value = dt.Rows[a]["jsno"].ToString();
                    pDataParameters[1].Value = dt.Rows[a]["ordno"].ToString();
                    pDataParameters[2].Value = dt.Rows[a]["jpsu_date"].ToString();
                    pDataParameters[3].Value = dt.Rows[a]["nabdat"].ToString();
                    pDataParameters[4].Value = dt.Rows[a]["cust_code"].ToString();
                    pDataParameters[5].Value = dt.Rows[a]["short_name"].ToString();
                    pDataParameters[6].Value = dt.Rows[a]["item_code"].ToString();
                    pDataParameters[7].Value = dt.Rows[a]["item_name"].ToString();

                    pDataParameters[8].Value = dt.Rows[a]["kagu_code"].ToString();
                    pDataParameters[9].Value = dt.Rows[a]["kagu_name"].ToString();
                    pDataParameters[10].Value = Convert.ToDecimal(dt.Rows[a]["pog1"].ToString());
                    pDataParameters[11].Value = dt.Rows[a]["scust_name"].ToString();
                    pDataParameters[12].Value = Convert.ToInt32(dt.Rows[a]["colcnt"].ToString());
                    pDataParameters[13].Value = Convert.ToDecimal(dt.Rows[a]["cqty"].ToString());
                    pDataParameters[14].Value = Convert.ToDecimal(dt.Rows[a]["soyo_qty"].ToString());
                    pDataParameters[15].Value = dt.Rows[a]["dan"].ToString();


                    DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DBInterface_I10", pDataParameters);

                    if (pDataTable.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }

                    pDBInterfaceEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                    pDBInterfaceEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                    pDBInterfaceEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                    pDBInterfaceEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                    pDBInterfaceEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                    //if (pDataTable != null)
                    //{
                    //    GetEntity(pDataTable.Rows[0]);
                    //}
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
                    "Interface_Data_Order_Save(DBInterfaceEntity pDBInterfaceEntity,  DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 정보 저장하기 - Interface_Data_Order_Save(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDQGatheringEntity"></param>
        /// <returns></returns>
        public bool Interface_Data_Sensor_Save(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
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
                                    //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                    //new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                    //new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_work_date", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_sqen_numb", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_proc_date", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_proc_time", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_jsno_numb", MySqlDbType.VarChar,9),
                                    new MySqlParameter("@v_jsno_sqen", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_bsno_numb", MySqlDbType.VarChar,9),
                                    new MySqlParameter("@v_dsgn_numb", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_colr_name", MySqlDbType.VarChar,30),
                                    new MySqlParameter("@v_roll_cont", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_totl_qnty", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_empl_cod1", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_empl_cod2", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_bsno_plus", MySqlDbType.VarChar,100),
                                    new MySqlParameter("@v_ds_data001", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data002", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data003", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data004", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data005", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data006", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data007", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data008", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data009", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data010", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data011", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data012", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data013", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data014", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data015", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data016", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data017", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data018", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data019", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data020", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data021", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data022", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data023", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data024", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data025", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data026", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data027", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data028", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data029", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data030", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data031", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data032", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data033", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data034", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data035", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data036", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data037", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data038", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data039", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data040", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data041", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data042", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data043", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data044", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data045", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data046", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data047", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data048", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data049", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data050", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data051", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data052", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data053", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data054", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data055", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data056", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data057", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data058", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data059", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data060", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data061", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data062", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data063", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data064", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data065", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data066", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data067", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data068", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data069", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data070", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data071", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data072", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data073", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data074", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data075", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data076", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data077", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data078", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data079", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data080", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data081", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data082", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data083", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data084", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data085", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data086", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data087", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data088", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data089", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data090", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data091", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data092", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data093", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data094", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data095", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data096", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data097", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data098", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data099", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data100", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data101", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data102", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data103", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data104", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data105", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data106", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data107", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data108", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data109", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data110", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data111", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data112", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data113", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data114", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data115", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data116", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data117", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data118", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data119", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data120", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data121", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data122", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data123", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data124", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data125", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data126", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data127", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data128", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data129", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data130", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data131", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data132", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data133", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data134", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data135", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data136", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data137", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data138", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data139", MySqlDbType.Decimal)
                            };
                            break;

                        case "SQLServer":
                            pDataParameters = new IDataParameter[]
                            {
                                    //new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                                    //new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    //new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_work_date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_sqen_numb", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_proc_date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_proc_time", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_jsno_numb", SqlDbType.NVarChar,9),
                                    new SqlParameter("@v_jsno_sqen", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_bsno_numb", SqlDbType.NVarChar,9),
                                    new SqlParameter("@v_dsgn_numb", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_colr_name", SqlDbType.NVarChar,30),
                                    new SqlParameter("@v_roll_cont", SqlDbType.Decimal,13),
                                    new SqlParameter("@v_totl_qnty", SqlDbType.Decimal,13),
                                    new SqlParameter("@v_empl_cod1", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_empl_cod2", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_bsno_plus", SqlDbType.NVarChar,100),
                                    new SqlParameter("@v_ds_data001", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data002", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data003", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data004", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data005", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data006", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data007", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data008", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data009", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data010", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data011", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data012", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data013", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data014", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data015", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data016", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data017", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data018", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data019", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data020", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data021", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data022", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data023", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data024", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data025", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data026", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data027", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data028", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data029", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data030", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data031", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data032", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data033", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data034", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data035", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data036", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data037", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data038", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data039", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data040", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data041", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data042", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data043", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data044", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data045", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data046", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data047", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data048", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data049", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data050", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data051", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data052", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data053", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data054", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data055", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data056", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data057", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data058", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data059", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data060", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data061", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data062", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data063", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data064", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data065", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data066", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data067", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data068", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data069", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data070", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data071", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data072", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data073", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data074", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data075", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data076", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data077", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data078", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data079", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data080", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data081", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data082", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data083", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data084", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data085", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data086", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data087", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data088", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data089", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data090", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data091", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data092", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data093", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data094", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data095", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data096", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data097", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data098", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data099", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data100", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data101", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data102", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data103", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data104", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data105", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data106", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data107", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data108", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data109", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data110", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data111", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data112", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data113", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data114", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data115", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data116", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data117", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data118", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data119", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data120", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data121", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data122", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data123", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data124", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data125", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data126", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data127", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data128", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data129", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data130", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data131", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data132", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data133", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data134", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data135", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data136", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data137", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data138", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data139", SqlDbType.Decimal)
                            };
                            break;
                    }

                    pDataParameters[0].Value = dt.Rows[a]["work_date"].ToString();
                    pDataParameters[1].Value = dt.Rows[a]["sqen_numb"].ToString();
                    pDataParameters[2].Value = dt.Rows[a]["proc_date"].ToString();
                    pDataParameters[3].Value = dt.Rows[a]["proc_time"].ToString();
                    pDataParameters[4].Value = dt.Rows[a]["jsno_numb"].ToString();
                    pDataParameters[5].Value = dt.Rows[a]["jsno_sqen"].ToString();
                    pDataParameters[6].Value = dt.Rows[a]["bsno_numb"].ToString();
                    pDataParameters[7].Value = dt.Rows[a]["dsgn_numb"].ToString();
                    pDataParameters[8].Value = dt.Rows[a]["colr_name"].ToString();
                    pDataParameters[9].Value = decimal.Parse(dt.Rows[a]["roll_cont"].ToString());
                    pDataParameters[10].Value = decimal.Parse(dt.Rows[a]["totl_qnty"].ToString());
                    pDataParameters[11].Value = dt.Rows[a]["empl_cod1"].ToString();
                    pDataParameters[12].Value = dt.Rows[a]["empl_cod2"].ToString();
                    pDataParameters[13].Value = dt.Rows[a]["bsno_plus"].ToString();
                    pDataParameters[14].Value = decimal.Parse(dt.Rows[a]["D012"].ToString());
                    pDataParameters[15].Value = decimal.Parse(dt.Rows[a]["D016"].ToString());
                    pDataParameters[16].Value = decimal.Parse(dt.Rows[a]["D022"].ToString());
                    pDataParameters[17].Value = decimal.Parse(dt.Rows[a]["D094"].ToString());
                    pDataParameters[18].Value = decimal.Parse(dt.Rows[a]["D100"].ToString());
                    pDataParameters[19].Value = decimal.Parse(dt.Rows[a]["D102"].ToString());
                    pDataParameters[20].Value = decimal.Parse(dt.Rows[a]["D104"].ToString());
                    pDataParameters[21].Value = decimal.Parse(dt.Rows[a]["D106"].ToString());
                    pDataParameters[22].Value = decimal.Parse(dt.Rows[a]["D108"].ToString());
                    pDataParameters[23].Value = decimal.Parse(dt.Rows[a]["D110"].ToString());
                    pDataParameters[24].Value = decimal.Parse(dt.Rows[a]["D112"].ToString());
                    pDataParameters[25].Value = decimal.Parse(dt.Rows[a]["D114"].ToString());
                    pDataParameters[26].Value = decimal.Parse(dt.Rows[a]["D255"].ToString());
                    pDataParameters[27].Value = decimal.Parse(dt.Rows[a]["D256"].ToString());
                    pDataParameters[28].Value = decimal.Parse(dt.Rows[a]["D261"].ToString());
                    pDataParameters[29].Value = decimal.Parse(dt.Rows[a]["D283"].ToString());
                    pDataParameters[30].Value = decimal.Parse(dt.Rows[a]["D300"].ToString());
                    pDataParameters[31].Value = decimal.Parse(dt.Rows[a]["D302"].ToString());
                    pDataParameters[32].Value = decimal.Parse(dt.Rows[a]["D304"].ToString());
                    pDataParameters[33].Value = decimal.Parse(dt.Rows[a]["D306"].ToString());
                    pDataParameters[34].Value = decimal.Parse(dt.Rows[a]["D312"].ToString());
                    pDataParameters[35].Value = decimal.Parse(dt.Rows[a]["D319"].ToString());
                    pDataParameters[36].Value = decimal.Parse(dt.Rows[a]["D332"].ToString());
                    pDataParameters[37].Value = decimal.Parse(dt.Rows[a]["D340"].ToString());
                    pDataParameters[38].Value = decimal.Parse(dt.Rows[a]["D342"].ToString());
                    pDataParameters[39].Value = decimal.Parse(dt.Rows[a]["D350"].ToString());
                    pDataParameters[40].Value = decimal.Parse(dt.Rows[a]["D351"].ToString());
                    pDataParameters[41].Value = decimal.Parse(dt.Rows[a]["D352"].ToString());
                    pDataParameters[42].Value = decimal.Parse(dt.Rows[a]["D353"].ToString());
                    pDataParameters[43].Value = decimal.Parse(dt.Rows[a]["D354"].ToString());
                    pDataParameters[44].Value = decimal.Parse(dt.Rows[a]["D355"].ToString());
                    pDataParameters[45].Value = decimal.Parse(dt.Rows[a]["D356"].ToString());
                    pDataParameters[46].Value = decimal.Parse(dt.Rows[a]["D357"].ToString());
                    pDataParameters[47].Value = decimal.Parse(dt.Rows[a]["D358"].ToString());
                    pDataParameters[48].Value = decimal.Parse(dt.Rows[a]["D382"].ToString());
                    pDataParameters[49].Value = decimal.Parse(dt.Rows[a]["D384"].ToString());
                    pDataParameters[50].Value = decimal.Parse(dt.Rows[a]["D394"].ToString());
                    pDataParameters[51].Value = decimal.Parse(dt.Rows[a]["D399"].ToString());
                    pDataParameters[52].Value = decimal.Parse(dt.Rows[a]["D401"].ToString());
                    pDataParameters[53].Value = decimal.Parse(dt.Rows[a]["D402"].ToString());
                    pDataParameters[54].Value = decimal.Parse(dt.Rows[a]["D411"].ToString());
                    pDataParameters[55].Value = decimal.Parse(dt.Rows[a]["D412"].ToString());
                    pDataParameters[56].Value = decimal.Parse(dt.Rows[a]["D413"].ToString());
                    pDataParameters[57].Value = decimal.Parse(dt.Rows[a]["D414"].ToString());
                    pDataParameters[58].Value = decimal.Parse(dt.Rows[a]["D415"].ToString());
                    pDataParameters[59].Value = decimal.Parse(dt.Rows[a]["D416"].ToString());
                    pDataParameters[60].Value = decimal.Parse(dt.Rows[a]["D417"].ToString());
                    pDataParameters[61].Value = decimal.Parse(dt.Rows[a]["D418"].ToString());
                    pDataParameters[62].Value = decimal.Parse(dt.Rows[a]["D425"].ToString());
                    pDataParameters[63].Value = decimal.Parse(dt.Rows[a]["D427"].ToString());
                    pDataParameters[64].Value = decimal.Parse(dt.Rows[a]["D429"].ToString());
                    pDataParameters[65].Value = decimal.Parse(dt.Rows[a]["D436"].ToString());
                    pDataParameters[66].Value = decimal.Parse(dt.Rows[a]["D437"].ToString());
                    pDataParameters[67].Value = decimal.Parse(dt.Rows[a]["D438"].ToString());
                    pDataParameters[68].Value = decimal.Parse(dt.Rows[a]["D470"].ToString());
                    pDataParameters[69].Value = decimal.Parse(dt.Rows[a]["D500"].ToString());
                    pDataParameters[70].Value = decimal.Parse(dt.Rows[a]["D502"].ToString());
                    pDataParameters[71].Value = decimal.Parse(dt.Rows[a]["D504"].ToString());
                    pDataParameters[72].Value = decimal.Parse(dt.Rows[a]["D610"].ToString());
                    pDataParameters[73].Value = decimal.Parse(dt.Rows[a]["D611"].ToString());
                    pDataParameters[74].Value = decimal.Parse(dt.Rows[a]["D612"].ToString());
                    pDataParameters[75].Value = decimal.Parse(dt.Rows[a]["D613"].ToString());
                    pDataParameters[76].Value = decimal.Parse(dt.Rows[a]["D614"].ToString());
                    pDataParameters[77].Value = decimal.Parse(dt.Rows[a]["D615"].ToString());
                    pDataParameters[78].Value = decimal.Parse(dt.Rows[a]["D616"].ToString());
                    pDataParameters[79].Value = decimal.Parse(dt.Rows[a]["D617"].ToString());
                    pDataParameters[80].Value = decimal.Parse(dt.Rows[a]["D618"].ToString());
                    pDataParameters[81].Value = decimal.Parse(dt.Rows[a]["D619"].ToString());
                    pDataParameters[82].Value = decimal.Parse(dt.Rows[a]["D620"].ToString());
                    pDataParameters[83].Value = decimal.Parse(dt.Rows[a]["D621"].ToString());
                    pDataParameters[84].Value = decimal.Parse(dt.Rows[a]["D622"].ToString());
                    pDataParameters[85].Value = decimal.Parse(dt.Rows[a]["D623"].ToString());
                    pDataParameters[86].Value = decimal.Parse(dt.Rows[a]["D624"].ToString());
                    pDataParameters[87].Value = decimal.Parse(dt.Rows[a]["D625"].ToString());
                    pDataParameters[88].Value = decimal.Parse(dt.Rows[a]["D626"].ToString());
                    pDataParameters[89].Value = decimal.Parse(dt.Rows[a]["D627"].ToString());
                    pDataParameters[90].Value = decimal.Parse(dt.Rows[a]["D628"].ToString());
                    pDataParameters[91].Value = decimal.Parse(dt.Rows[a]["D629"].ToString());
                    pDataParameters[92].Value = decimal.Parse(dt.Rows[a]["D630"].ToString());
                    pDataParameters[93].Value = decimal.Parse(dt.Rows[a]["D631"].ToString());
                    pDataParameters[94].Value = decimal.Parse(dt.Rows[a]["D632"].ToString());
                    pDataParameters[95].Value = decimal.Parse(dt.Rows[a]["D633"].ToString());
                    pDataParameters[96].Value = decimal.Parse(dt.Rows[a]["D634"].ToString());
                    pDataParameters[97].Value = decimal.Parse(dt.Rows[a]["D635"].ToString());
                    pDataParameters[98].Value = decimal.Parse(dt.Rows[a]["D636"].ToString());
                    pDataParameters[99].Value = decimal.Parse(dt.Rows[a]["D637"].ToString());
                    pDataParameters[100].Value = decimal.Parse(dt.Rows[a]["D638"].ToString());
                    pDataParameters[101].Value = decimal.Parse(dt.Rows[a]["D639"].ToString());
                    pDataParameters[102].Value = decimal.Parse(dt.Rows[a]["D640"].ToString());
                    pDataParameters[103].Value = decimal.Parse(dt.Rows[a]["D641"].ToString());
                    pDataParameters[104].Value = decimal.Parse(dt.Rows[a]["D642"].ToString());
                    pDataParameters[105].Value = decimal.Parse(dt.Rows[a]["D643"].ToString());
                    pDataParameters[106].Value = decimal.Parse(dt.Rows[a]["D644"].ToString());
                    pDataParameters[107].Value = decimal.Parse(dt.Rows[a]["D645"].ToString());
                    pDataParameters[108].Value = decimal.Parse(dt.Rows[a]["D646"].ToString());
                    pDataParameters[109].Value = decimal.Parse(dt.Rows[a]["D647"].ToString());
                    pDataParameters[110].Value = decimal.Parse(dt.Rows[a]["D648"].ToString());
                    pDataParameters[111].Value = decimal.Parse(dt.Rows[a]["D649"].ToString());
                    pDataParameters[112].Value = decimal.Parse(dt.Rows[a]["D650"].ToString());
                    pDataParameters[113].Value = decimal.Parse(dt.Rows[a]["D651"].ToString());
                    pDataParameters[114].Value = decimal.Parse(dt.Rows[a]["D652"].ToString());
                    pDataParameters[115].Value = decimal.Parse(dt.Rows[a]["D654"].ToString());
                    pDataParameters[116].Value = decimal.Parse(dt.Rows[a]["D655"].ToString());
                    pDataParameters[117].Value = decimal.Parse(dt.Rows[a]["D656"].ToString());
                    pDataParameters[118].Value = decimal.Parse(dt.Rows[a]["D657"].ToString());
                    pDataParameters[119].Value = decimal.Parse(dt.Rows[a]["D658"].ToString());
                    pDataParameters[120].Value = decimal.Parse(dt.Rows[a]["D659"].ToString());
                    pDataParameters[121].Value = decimal.Parse(dt.Rows[a]["D660"].ToString());
                    pDataParameters[122].Value = decimal.Parse(dt.Rows[a]["D661"].ToString());
                    pDataParameters[123].Value = decimal.Parse(dt.Rows[a]["D662"].ToString());
                    pDataParameters[124].Value = decimal.Parse(dt.Rows[a]["D663"].ToString());
                    pDataParameters[125].Value = decimal.Parse(dt.Rows[a]["D664"].ToString());
                    pDataParameters[126].Value = decimal.Parse(dt.Rows[a]["D665"].ToString());
                    pDataParameters[127].Value = decimal.Parse(dt.Rows[a]["D666"].ToString());
                    pDataParameters[128].Value = decimal.Parse(dt.Rows[a]["D667"].ToString());
                    pDataParameters[129].Value = decimal.Parse(dt.Rows[a]["D668"].ToString());
                    pDataParameters[130].Value = decimal.Parse(dt.Rows[a]["D669"].ToString());
                    pDataParameters[131].Value = decimal.Parse(dt.Rows[a]["D670"].ToString());
                    pDataParameters[132].Value = decimal.Parse(dt.Rows[a]["D671"].ToString());
                    pDataParameters[133].Value = decimal.Parse(dt.Rows[a]["D672"].ToString());
                    pDataParameters[134].Value = decimal.Parse(dt.Rows[a]["D673"].ToString());
                    pDataParameters[135].Value = decimal.Parse(dt.Rows[a]["D675"].ToString());
                    pDataParameters[136].Value = decimal.Parse(dt.Rows[a]["D680"].ToString());
                    pDataParameters[137].Value = decimal.Parse(dt.Rows[a]["D681"].ToString());
                    pDataParameters[138].Value = decimal.Parse(dt.Rows[a]["D690"].ToString());
                    pDataParameters[139].Value = decimal.Parse(dt.Rows[a]["D750"].ToString());
                    pDataParameters[140].Value = decimal.Parse(dt.Rows[a]["D770"].ToString());
                    pDataParameters[141].Value = decimal.Parse(dt.Rows[a]["M600"].ToString());
                    pDataParameters[142].Value = decimal.Parse(dt.Rows[a]["M606"].ToString());
                    pDataParameters[143].Value = decimal.Parse(dt.Rows[a]["M612"].ToString());
                    pDataParameters[144].Value = decimal.Parse(dt.Rows[a]["M618"].ToString());
                    pDataParameters[145].Value = decimal.Parse(dt.Rows[a]["M624"].ToString());
                    pDataParameters[146].Value = decimal.Parse(dt.Rows[a]["M630"].ToString());
                    pDataParameters[147].Value = decimal.Parse(dt.Rows[a]["M636"].ToString());
                    pDataParameters[148].Value = decimal.Parse(dt.Rows[a]["M642"].ToString());
                    pDataParameters[149].Value = decimal.Parse(dt.Rows[a]["M800"].ToString());
                    pDataParameters[150].Value = decimal.Parse(dt.Rows[a]["M806"].ToString());
                    pDataParameters[151].Value = decimal.Parse(dt.Rows[a]["M812"].ToString());
                    pDataParameters[152].Value = decimal.Parse(dt.Rows[a]["M818"].ToString());
                    /*
                    pDataParameters[14].Value = decimal.Parse(dt.Rows[a]["D332"].ToString());
                    pDataParameters[15].Value = decimal.Parse(dt.Rows[a]["D340"].ToString());
                    pDataParameters[16].Value = decimal.Parse(dt.Rows[a]["D100"].ToString());
                    pDataParameters[17].Value = decimal.Parse(dt.Rows[a]["D102"].ToString());
                    pDataParameters[18].Value = decimal.Parse(dt.Rows[a]["D104"].ToString());
                    pDataParameters[19].Value = decimal.Parse(dt.Rows[a]["D106"].ToString());
                    pDataParameters[20].Value = decimal.Parse(dt.Rows[a]["D108"].ToString());
                    pDataParameters[21].Value = decimal.Parse(dt.Rows[a]["D110"].ToString());
                    pDataParameters[22].Value = decimal.Parse(dt.Rows[a]["D112"].ToString());
                    pDataParameters[23].Value = decimal.Parse(dt.Rows[a]["D114"].ToString());
                    pDataParameters[24].Value = decimal.Parse(dt.Rows[a]["D411"].ToString());
                    pDataParameters[25].Value = decimal.Parse(dt.Rows[a]["D412"].ToString());
                    pDataParameters[26].Value = decimal.Parse(dt.Rows[a]["D413"].ToString());
                    pDataParameters[27].Value = decimal.Parse(dt.Rows[a]["D414"].ToString());
                    pDataParameters[28].Value = decimal.Parse(dt.Rows[a]["D415"].ToString());
                    pDataParameters[29].Value = decimal.Parse(dt.Rows[a]["D416"].ToString());
                    pDataParameters[30].Value = decimal.Parse(dt.Rows[a]["D417"].ToString());
                    pDataParameters[31].Value = decimal.Parse(dt.Rows[a]["D418"].ToString());
                    pDataParameters[32].Value = decimal.Parse(dt.Rows[a]["D660"].ToString());
                    pDataParameters[33].Value = decimal.Parse(dt.Rows[a]["D661"].ToString());
                    pDataParameters[34].Value = decimal.Parse(dt.Rows[a]["D662"].ToString());
                    pDataParameters[35].Value = decimal.Parse(dt.Rows[a]["D663"].ToString());
                    pDataParameters[36].Value = decimal.Parse(dt.Rows[a]["D664"].ToString());
                    pDataParameters[37].Value = decimal.Parse(dt.Rows[a]["D665"].ToString());
                    pDataParameters[38].Value = decimal.Parse(dt.Rows[a]["D666"].ToString());
                    pDataParameters[39].Value = decimal.Parse(dt.Rows[a]["D667"].ToString());
                    pDataParameters[40].Value = decimal.Parse(dt.Rows[a]["M600"].ToString());
                    pDataParameters[41].Value = decimal.Parse(dt.Rows[a]["M606"].ToString());
                    pDataParameters[42].Value = decimal.Parse(dt.Rows[a]["M612"].ToString());
                    pDataParameters[43].Value = decimal.Parse(dt.Rows[a]["M618"].ToString());
                    pDataParameters[44].Value = decimal.Parse(dt.Rows[a]["M624"].ToString());
                    pDataParameters[45].Value = decimal.Parse(dt.Rows[a]["M630"].ToString());
                    pDataParameters[46].Value = decimal.Parse(dt.Rows[a]["M636"].ToString());
                    pDataParameters[47].Value = decimal.Parse(dt.Rows[a]["M642"].ToString());
                    pDataParameters[48].Value = decimal.Parse(dt.Rows[a]["D680"].ToString());
                    pDataParameters[49].Value = decimal.Parse(dt.Rows[a]["D681"].ToString());
                    pDataParameters[49].Value = decimal.Parse(dt.Rows[a]["D681"].ToString());
                    */
                    
                    DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DBInterface_I20", pDataParameters);

                    if (pDataTable.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }

                    pDBInterfaceEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                    pDBInterfaceEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                    pDBInterfaceEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                    pDBInterfaceEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                    pDBInterfaceEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                    //if (pDataTable != null)
                    //{
                    //    GetEntity(pDataTable.Rows[0]);
                    //}
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
                    "Interface_Data_Sensor_Save(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        public bool Interface_Data_Sensor_Save_sarim(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
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
                                    //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                    //new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                    //new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_work_date", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_sqen_numb", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_proc_date", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_proc_time", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_jsno_numb", MySqlDbType.VarChar,9),
                                    new MySqlParameter("@v_jsno_sqen", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_bsno_numb", MySqlDbType.VarChar,9),
                                    new MySqlParameter("@v_dsgn_numb", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_colr_name", MySqlDbType.VarChar,30),
                                    new MySqlParameter("@v_roll_cont", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_totl_qnty", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_empl_cod1", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_empl_cod2", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_bsno_plus", MySqlDbType.VarChar,100),
                                    new MySqlParameter("@v_ds_data001", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data002", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data003", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data004", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data005", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data006", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data007", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data008", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data009", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data010", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data011", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data012", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data013", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data014", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data015", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data016", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data017", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data018", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data019", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data020", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data021", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data022", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data023", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data024", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data025", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data026", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data027", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data028", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data029", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data030", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data031", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data032", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data033", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data034", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data035", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data036", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data037", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data038", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data039", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data040", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data041", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data042", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data043", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data044", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data045", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data046", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data047", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data048", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data049", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data050", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data051", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data052", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data053", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data054", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data055", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data056", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data057", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data058", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data059", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data060", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data061", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data062", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data063", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data064", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data065", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data066", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data067", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data068", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data069", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data070", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data071", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data072", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data073", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data074", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data075", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data076", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data077", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data078", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data079", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data080", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data081", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data082", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data083", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data084", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data085", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data086", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data087", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data088", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data089", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data090", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data091", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data092", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data093", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data094", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data095", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data096", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data097", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data098", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data099", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data100", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data101", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data102", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data103", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data104", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data105", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data106", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data107", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data108", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data109", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data110", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data111", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data112", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data113", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data114", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data115", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data116", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data117", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data118", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data119", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data120", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data121", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data122", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data123", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data124", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data125", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data126", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data127", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data128", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data129", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data130", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data131", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data132", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data133", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data134", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data135", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data136", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data137", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data138", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ds_data139", MySqlDbType.Decimal)
                            };
                            break;

                        case "SQLServer":
                            pDataParameters = new IDataParameter[]
                            {
                                    //new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                                    //new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    //new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_work_date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_sqen_numb", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_proc_date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_proc_time", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_jsno_numb", SqlDbType.NVarChar,9),
                                    new SqlParameter("@v_jsno_sqen", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_bsno_numb", SqlDbType.NVarChar,9),
                                    new SqlParameter("@v_dsgn_numb", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_colr_name", SqlDbType.NVarChar,30),
                                    new SqlParameter("@v_roll_cont", SqlDbType.Decimal,13),
                                    new SqlParameter("@v_totl_qnty", SqlDbType.Decimal,13),
                                    new SqlParameter("@v_empl_cod1", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_empl_cod2", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_bsno_plus", SqlDbType.NVarChar,100),
                                    new SqlParameter("@v_ds_data001", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data002", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data003", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data004", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data005", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data006", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data007", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data008", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data009", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data010", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data011", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data012", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data013", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data014", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data015", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data016", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data017", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data018", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data019", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data020", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data021", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data022", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data023", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data024", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data025", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data026", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data027", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data028", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data029", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data030", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data031", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data032", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data033", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data034", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data035", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data036", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data037", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data038", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data039", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data040", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data041", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data042", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data043", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data044", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data045", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data046", SqlDbType.Decimal),
                                    new SqlParameter("@v_ds_data047", SqlDbType.Decimal),
                                   // new SqlParameter("@v_ds_data048", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data049", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data050", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data051", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data052", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data053", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data054", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data055", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data056", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data057", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data058", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data059", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data060", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data061", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data062", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data063", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data064", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data065", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data066", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data067", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data068", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data069", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data070", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data071", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data072", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data073", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data074", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data075", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data076", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data077", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data078", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data079", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data080", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data081", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data082", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data083", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data084", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data085", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data086", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data087", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data088", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data089", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data090", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data091", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data092", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data093", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data094", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data095", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data096", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data097", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data098", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data099", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data100", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data101", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data102", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data103", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data104", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data105", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data106", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data107", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data108", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data109", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data110", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data111", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data112", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data113", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data114", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data115", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data116", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data117", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data118", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data119", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data120", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data121", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data122", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data123", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data124", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data125", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data126", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data127", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data128", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data129", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data130", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data131", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data132", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data133", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data134", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data135", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data136", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data137", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data138", SqlDbType.Decimal),
                                    //new SqlParameter("@v_ds_data139", SqlDbType.Decimal)
                            };
                            break;
                    }

                    pDataParameters[0].Value = dt.Rows[a]["work_date"].ToString();
                    pDataParameters[1].Value = dt.Rows[a]["sqen_numb"].ToString();
                    pDataParameters[2].Value = dt.Rows[a]["proc_date"].ToString();
                    pDataParameters[3].Value = dt.Rows[a]["proc_time"].ToString();
                    pDataParameters[4].Value = dt.Rows[a]["jsno_numb"].ToString();
                    pDataParameters[5].Value = dt.Rows[a]["jsno_sqen"].ToString();
                    pDataParameters[6].Value = dt.Rows[a]["bsno_numb"].ToString();
                    pDataParameters[7].Value = dt.Rows[a]["dsgn_numb"].ToString();
                    pDataParameters[8].Value = dt.Rows[a]["colr_name"].ToString();
                    pDataParameters[9].Value = decimal.Parse(dt.Rows[a]["roll_cont"].ToString());
                    pDataParameters[10].Value = decimal.Parse(dt.Rows[a]["totl_qnty"].ToString());
                    pDataParameters[11].Value = dt.Rows[a]["empl_cod1"].ToString();
                    pDataParameters[12].Value = dt.Rows[a]["empl_cod2"].ToString();
                    pDataParameters[13].Value = dt.Rows[a]["bsno_plus"].ToString();
                    pDataParameters[14].Value = decimal.Parse(dt.Rows[a]["MW121"].ToString());
                    pDataParameters[15].Value = decimal.Parse(dt.Rows[a]["MW122"].ToString());
                    pDataParameters[16].Value = decimal.Parse(dt.Rows[a]["MW123"].ToString());
                    pDataParameters[17].Value = decimal.Parse(dt.Rows[a]["MW124"].ToString());
                    pDataParameters[18].Value = decimal.Parse(dt.Rows[a]["MW125"].ToString());
                    pDataParameters[19].Value = decimal.Parse(dt.Rows[a]["MW126"].ToString());
                    pDataParameters[20].Value = decimal.Parse(dt.Rows[a]["MW127"].ToString());
                    pDataParameters[21].Value = decimal.Parse(dt.Rows[a]["MW131"].ToString());
                    pDataParameters[22].Value = decimal.Parse(dt.Rows[a]["MW132"].ToString());
                    pDataParameters[23].Value = decimal.Parse(dt.Rows[a]["MW138"].ToString());
                    pDataParameters[24].Value = decimal.Parse(dt.Rows[a]["MW161"].ToString());
                    pDataParameters[25].Value = decimal.Parse(dt.Rows[a]["MW162"].ToString());
                    pDataParameters[26].Value = decimal.Parse(dt.Rows[a]["MW163"].ToString());
                    pDataParameters[27].Value = decimal.Parse(dt.Rows[a]["MW167"].ToString());
                    pDataParameters[28].Value = decimal.Parse(dt.Rows[a]["MW168"].ToString());
                    pDataParameters[29].Value = decimal.Parse(dt.Rows[a]["MW169"].ToString());
                    pDataParameters[30].Value = decimal.Parse(dt.Rows[a]["MW171"].ToString());
                    pDataParameters[31].Value = decimal.Parse(dt.Rows[a]["MW172"].ToString());
                    pDataParameters[32].Value = decimal.Parse(dt.Rows[a]["MW173"].ToString());
                    pDataParameters[33].Value = decimal.Parse(dt.Rows[a]["MW176"].ToString());
                    pDataParameters[34].Value = decimal.Parse(dt.Rows[a]["MW177"].ToString());
                    pDataParameters[35].Value = decimal.Parse(dt.Rows[a]["MW178"].ToString());
                    pDataParameters[36].Value = decimal.Parse(dt.Rows[a]["MW221"].ToString());
                    pDataParameters[37].Value = decimal.Parse(dt.Rows[a]["MW222"].ToString());
                    pDataParameters[38].Value = decimal.Parse(dt.Rows[a]["MW223"].ToString());
                    pDataParameters[39].Value = decimal.Parse(dt.Rows[a]["MW224"].ToString());
                    pDataParameters[40].Value = decimal.Parse(dt.Rows[a]["MW225"].ToString());
                    pDataParameters[41].Value = decimal.Parse(dt.Rows[a]["MW226"].ToString());
                    pDataParameters[42].Value = decimal.Parse(dt.Rows[a]["MW227"].ToString());
                    pDataParameters[43].Value = decimal.Parse(dt.Rows[a]["MW231"].ToString());
                    pDataParameters[44].Value = decimal.Parse(dt.Rows[a]["MW232"].ToString());
                    pDataParameters[45].Value = decimal.Parse(dt.Rows[a]["MW238"].ToString());
                    pDataParameters[46].Value = decimal.Parse(dt.Rows[a]["MW241"].ToString());
                    pDataParameters[47].Value = decimal.Parse(dt.Rows[a]["MW242"].ToString());
                    pDataParameters[48].Value = decimal.Parse(dt.Rows[a]["MW243"].ToString());
                    pDataParameters[49].Value = decimal.Parse(dt.Rows[a]["MW244"].ToString());
                    pDataParameters[50].Value = decimal.Parse(dt.Rows[a]["MW245"].ToString());
                    pDataParameters[51].Value = decimal.Parse(dt.Rows[a]["MW246"].ToString());
                    pDataParameters[52].Value = decimal.Parse(dt.Rows[a]["MW247"].ToString());
                    pDataParameters[53].Value = decimal.Parse(dt.Rows[a]["MW248"].ToString());
                    pDataParameters[54].Value = decimal.Parse(dt.Rows[a]["MW249"].ToString());
                    pDataParameters[55].Value = decimal.Parse(dt.Rows[a]["MW250"].ToString());
                    pDataParameters[56].Value = decimal.Parse(dt.Rows[a]["MW251"].ToString());
                    pDataParameters[57].Value = decimal.Parse(dt.Rows[a]["MW252"].ToString());
                    pDataParameters[58].Value = decimal.Parse(dt.Rows[a]["MW253"].ToString());
                    pDataParameters[59].Value = decimal.Parse(dt.Rows[a]["MW254"].ToString());
                    pDataParameters[60].Value = decimal.Parse(dt.Rows[a]["MW310"].ToString());
                  

                    DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DBInterface_I30", pDataParameters);

                    if (pDataTable.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }

                    pDBInterfaceEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                    pDBInterfaceEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                    pDBInterfaceEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                    pDBInterfaceEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                    pDBInterfaceEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                    //if (pDataTable != null)
                    //{
                    //    GetEntity(pDataTable.Rows[0]);
                    //}
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
                    "Interface_Data_Sensor_Save(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        public bool Interface_Data_Sensor_Save_Bokang_minwon(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
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
                                    new MySqlParameter("@v_work_date", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_sqen_numb", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_jsno",      MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_jpsu_date", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_stat_gubn", MySqlDbType.VarChar,2),
                                    new MySqlParameter("@v_stat_name", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_lact_gubn", MySqlDbType.VarChar,5),
                                    new MySqlParameter("@v_lact_name", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_cust_code", MySqlDbType.VarChar,4),
                                    new MySqlParameter("@v_cust_user", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_cust_name", MySqlDbType.VarChar,70),
                                    new MySqlParameter("@v_gust_mod1", MySqlDbType.VarChar,100),
                                    new MySqlParameter("@v_gust_amnt", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_meno_xxx2", MySqlDbType.VarChar,200),
                                    new MySqlParameter("@v_fabr_name", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_item_name", MySqlDbType.VarChar,100),
                                    new MySqlParameter("@v_cust_area", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_dyee_name", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_mjno_numb", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_bsno_numb", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_bill_date", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_colr_cont", MySqlDbType.Int32),
                                    new MySqlParameter("@v_totl_qnty", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_qnty_unit", MySqlDbType.VarChar,5),
                                    new MySqlParameter("@v_qnty_name", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_taxx_amnt", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_ipnn_amnt", MySqlDbType.Decimal),
                                
                            };
                            break;

                        case "SQLServer":
                            pDataParameters = new IDataParameter[]
                            {
                                    new SqlParameter("@v_work_date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_sqen_numb", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_jsno",      SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_jpsu_date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_stat_gubn", SqlDbType.NVarChar,2),
                                    new SqlParameter("@v_stat_name", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_lact_gubn", SqlDbType.NVarChar,5),
                                    new SqlParameter("@v_lact_name", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_cust_code", SqlDbType.NVarChar,4),
                                    new SqlParameter("@v_cust_user", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_cust_name", SqlDbType.NVarChar,70),
                                    new SqlParameter("@v_gust_mod1", SqlDbType.NVarChar,100),
                                    new SqlParameter("@v_gust_amnt", SqlDbType.Decimal),
                                    new SqlParameter("@v_memo_xxx2", SqlDbType.NVarChar,200),
                                    new SqlParameter("@v_fabr_name", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_item_name", SqlDbType.NVarChar,100),
                                    new SqlParameter("@v_cust_area", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_dyee_name", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_mjno_numb", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_bsno_numb", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_bill_date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_colr_cont", SqlDbType.Int),
                                    new SqlParameter("@v_totl_qnty", SqlDbType.Decimal),
                                    new SqlParameter("@v_qnty_unit", SqlDbType.NVarChar,5),
                                    new SqlParameter("@v_qnty_name", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_taxx_amnt", SqlDbType.Decimal),
                                    new SqlParameter("@v_ipnn_amnt", SqlDbType.Decimal),
                             
                            };
                            break;
                    }

                    pDataParameters[0].Value = dt.Rows[a]["work_date"].ToString();
                    pDataParameters[1].Value = dt.Rows[a]["sqen_numb"].ToString();
                    pDataParameters[2].Value = dt.Rows[a]["jsno"].ToString();
                    pDataParameters[3].Value = dt.Rows[a]["jpsu_date"].ToString();
                    pDataParameters[4].Value = dt.Rows[a]["stat_gubn"].ToString();
                    pDataParameters[5].Value = dt.Rows[a]["stat_name"].ToString();
                    pDataParameters[6].Value = dt.Rows[a]["lact_gubn"].ToString();
                    pDataParameters[7].Value = dt.Rows[a]["lact_name"].ToString();
                    pDataParameters[8].Value = dt.Rows[a]["cust_code"].ToString();
                    pDataParameters[9].Value = dt.Rows[a]["cust_user"].ToString();
                    pDataParameters[10].Value = dt.Rows[a]["cust_name"].ToString();
                    pDataParameters[11].Value = dt.Rows[a]["gust_mod1"].ToString();
                    pDataParameters[12].Value = decimal.Parse(dt.Rows[a]["gust_amnt"].ToString());
                    pDataParameters[13].Value = dt.Rows[a]["memo_xxx2"].ToString();
                    pDataParameters[14].Value = dt.Rows[a]["fabr_name"].ToString();
                    pDataParameters[15].Value = dt.Rows[a]["item_name"].ToString();
                    pDataParameters[16].Value = dt.Rows[a]["cust_area"].ToString();
                    pDataParameters[17].Value = dt.Rows[a]["dyee_name"].ToString();
                    pDataParameters[18].Value = dt.Rows[a]["mjno_numb"].ToString();
                    pDataParameters[19].Value = dt.Rows[a]["bsno_numb"].ToString();
                    pDataParameters[20].Value = dt.Rows[a]["bill_date"].ToString();
                    pDataParameters[21].Value = int.Parse(dt.Rows[a]["colr_cont"].ToString());
                    pDataParameters[22].Value = decimal.Parse(dt.Rows[a]["totl_qnty"].ToString());
                    pDataParameters[23].Value = dt.Rows[a]["qnty_unit"].ToString();
                    pDataParameters[24].Value = dt.Rows[a]["qnty_name"].ToString();
                    pDataParameters[25].Value = decimal.Parse(dt.Rows[a]["taxx_amnt"].ToString());
                    pDataParameters[26].Value = decimal.Parse(dt.Rows[a]["ipnn_amnt"].ToString());
              

                    DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DBInterface_I40", pDataParameters);

                    if (pDataTable.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }

                    pDBInterfaceEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                    pDBInterfaceEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                    pDBInterfaceEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                    pDBInterfaceEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                    pDBInterfaceEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Interface_Data_Sensor_Save(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        public bool Interface_Data_Sensor_Save_Bokang_workorder(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
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
                                    new MySqlParameter("@v_work_date", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_head_numb", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_sqen_numb", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_sqen_cont", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_proc_numb", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_plan_numb", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_btno_numb", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_jobb_date", MySqlDbType.DateTime),
                                    new MySqlParameter("@v_plan_date", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_unit_code", MySqlDbType.VarChar,2),
                                    new MySqlParameter("@v_unit_qnty", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_colr_temp", MySqlDbType.VarChar,30),
                                    new MySqlParameter("@v_colr_time", MySqlDbType.VarChar,30),
                                    new MySqlParameter("@v_colr_amnt", MySqlDbType.VarChar,30),
                                    new MySqlParameter("@v_work_user", MySqlDbType.VarChar,30),
                                    new MySqlParameter("@v_user_face", MySqlDbType.VarChar,30),
                                    new MySqlParameter("@v_frst_work", MySqlDbType.VarChar,200),
                                    new MySqlParameter("@v_memo_xxxx", MySqlDbType.VarChar,200),
                                    new MySqlParameter("@v_color_name", MySqlDbType.VarChar,50),
                            };
                            break;

                        case "SQLServer":
                            pDataParameters = new IDataParameter[]
                            {
                                    new SqlParameter("@v_work_date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_head_numb", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_sqen_numb", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_sqen_cont", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_proc_numb", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_plan_numb", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_btno_numb", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_jobb_date", SqlDbType.DateTime),
                                    new SqlParameter("@v_plan_date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_unit_code", SqlDbType.NVarChar,2),
                                    new SqlParameter("@v_unit_qnty", SqlDbType.Decimal),
                                    new SqlParameter("@v_colr_temp", SqlDbType.NVarChar,30),
                                    new SqlParameter("@v_colr_time", SqlDbType.NVarChar,30),
                                    new SqlParameter("@v_colr_amnt", SqlDbType.NVarChar,30),
                                    new SqlParameter("@v_work_user", SqlDbType.NVarChar,30),
                                    new SqlParameter("@v_user_face", SqlDbType.NVarChar,30),
                                    new SqlParameter("@v_frst_work", SqlDbType.NVarChar,200),
                                    new SqlParameter("@v_memo_xxxx", SqlDbType.NVarChar,200),
                                    new SqlParameter("@v_color_name", SqlDbType.NVarChar,50),
                            };
                            break;
                    }

                    pDataParameters[0].Value = dt.Rows[a]["work_date"].ToString();
                    pDataParameters[1].Value = dt.Rows[a]["head_numb"].ToString();
                    pDataParameters[2].Value = dt.Rows[a]["sqen_numb"].ToString();
                    pDataParameters[3].Value = dt.Rows[a]["sqen_cont"].ToString();
                    pDataParameters[4].Value = dt.Rows[a]["proc_numb"].ToString();
                    pDataParameters[5].Value = dt.Rows[a]["plan_numb"].ToString();
                    pDataParameters[6].Value = dt.Rows[a]["btno_numb"].ToString();
                    pDataParameters[7].Value = DateTime.Parse(dt.Rows[a]["jobb_date"].ToString());
                    pDataParameters[8].Value = dt.Rows[a]["plan_date"].ToString();
                    pDataParameters[9].Value = dt.Rows[a]["unit_code"].ToString();
                    pDataParameters[10].Value = decimal.Parse(dt.Rows[a]["unit_qnty"].ToString());
                    pDataParameters[11].Value = dt.Rows[a]["colr_temp"].ToString();
                    pDataParameters[12].Value = dt.Rows[a]["colr_time"].ToString();
                    pDataParameters[13].Value = dt.Rows[a]["colr_amnt"].ToString();
                    pDataParameters[14].Value = dt.Rows[a]["work_user"].ToString();
                    pDataParameters[15].Value = dt.Rows[a]["user_face"].ToString();
                    pDataParameters[16].Value = dt.Rows[a]["frst_work"].ToString();
                    pDataParameters[17].Value = dt.Rows[a]["memo_xxxx"].ToString();
                    pDataParameters[18].Value = dt.Rows[a]["colr_name"].ToString();

                    DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DBInterface_I41", pDataParameters);

                    if (pDataTable.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }

                    pDBInterfaceEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                    pDBInterfaceEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                    pDBInterfaceEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                    pDBInterfaceEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                    pDBInterfaceEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Interface_Data_Sensor_Save(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        public bool Interface_Data_Sensor_Save_Bokang_color(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
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
                                    new MySqlParameter("@v_work_date", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_head_numb", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_sqen_numb", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_jsno", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_colr_name", MySqlDbType.VarChar,30),
                                    new MySqlParameter("@v_colr_qnty", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_dyee_gubn", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_dyee_name", MySqlDbType.VarChar,50),
                            };
                            break;

                        case "SQLServer":
                            pDataParameters = new IDataParameter[]
                            {
                                    new SqlParameter("@v_work_date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_head_numb", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_sqen_numb", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_jsno", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_colr_name", SqlDbType.NVarChar,30),
                                    new SqlParameter("@v_colr_qnty", SqlDbType.Decimal),
                                    new SqlParameter("@v_dyee_gubn", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_dyee_name", SqlDbType.NVarChar,50),
                            };
                            break;
                    }

                    pDataParameters[0].Value = dt.Rows[a]["work_date"].ToString();
                    pDataParameters[1].Value = dt.Rows[a]["head_numb"].ToString();
                    pDataParameters[2].Value = dt.Rows[a]["sqen_numb"].ToString();
                    pDataParameters[3].Value = dt.Rows[a]["jsno"].ToString();
                    pDataParameters[4].Value = dt.Rows[a]["colr_name"].ToString();
                    pDataParameters[5].Value = decimal.Parse(dt.Rows[a]["colr_qnty"].ToString());
                    pDataParameters[6].Value = dt.Rows[a]["dyee_gubn"].ToString();
                    pDataParameters[7].Value = dt.Rows[a]["dyee_name"].ToString();
               

                    DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DBInterface_I42", pDataParameters);

                    if (pDataTable.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }

                    pDBInterfaceEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                    pDBInterfaceEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                    pDBInterfaceEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                    pDBInterfaceEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                    pDBInterfaceEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Interface_Data_Sensor_Save(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        public bool Interface_Data_Sensor_Save_Bokang_workplan(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
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
                                    new MySqlParameter("@v_work_date", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_head_numb", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_sqen_numb", MySqlDbType.VarChar,6),
                                    new MySqlParameter("@v_jsno", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_colr_name", MySqlDbType.VarChar,30),
                                    new MySqlParameter("@v_colr_qnty", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_dyee_gubn", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_dyee_name", MySqlDbType.VarChar,50),
                            };
                            break;

                        case "SQLServer":
                            pDataParameters = new IDataParameter[]
                            {
                                    new SqlParameter("@v_hogi_numb", SqlDbType.NVarChar,3),
                                    new SqlParameter("@v_work_Date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_sqen_numb", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_plan_Date", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_hogi_sqen", SqlDbType.NVarChar,6),
                                    new SqlParameter("@v_plan_numb", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_item_name", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_colr_name", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_plan_qnty", SqlDbType.Decimal),
                                    new SqlParameter("@v_work_memo", SqlDbType.NVarChar,1000),
                                    new SqlParameter("@v_memo_xxxx", SqlDbType.NVarChar,1000),
                                    new SqlParameter("@v_cust_name", SqlDbType.NVarChar,70),
                                    new SqlParameter("@v_qnty_unit", SqlDbType.NVarChar,5),
                                    new SqlParameter("@v_stat_gubn", SqlDbType.NVarChar,2),
                                    new SqlParameter("@v_stat_name", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_qnty_name", SqlDbType.NVarChar,2),
                            };
                            break;
                    }

                    pDataParameters[0].Value = dt.Rows[a]["hogi_numb"].ToString();
                    pDataParameters[1].Value = dt.Rows[a]["work_Date"].ToString();
                    pDataParameters[2].Value = dt.Rows[a]["sqen_numb"].ToString();
                    pDataParameters[3].Value = dt.Rows[a]["plan_Date"].ToString();
                    pDataParameters[4].Value = dt.Rows[a]["hogi_sqen"].ToString();
                    pDataParameters[5].Value = dt.Rows[a]["plan_numb"].ToString();
                    pDataParameters[6].Value = dt.Rows[a]["item_name"].ToString();
                    pDataParameters[7].Value = dt.Rows[a]["colr_name"].ToString();
                    pDataParameters[8].Value = decimal.Parse(dt.Rows[a]["plan_qnty"].ToString());
                    pDataParameters[9].Value = dt.Rows[a]["work_memo"].ToString();
                    pDataParameters[10].Value = dt.Rows[a]["memo_xxxx"].ToString();
                    pDataParameters[11].Value = dt.Rows[a]["cust_name"].ToString();
                    pDataParameters[12].Value = dt.Rows[a]["qnty_unit"].ToString();
                    pDataParameters[13].Value = dt.Rows[a]["stat_gubn"].ToString();
                    pDataParameters[14].Value = dt.Rows[a]["stat_name"].ToString();
                    pDataParameters[15].Value = dt.Rows[a]["qnty_name"].ToString();


                    DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DBInterface_I43", pDataParameters);

                    if (pDataTable.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }

                    pDBInterfaceEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                    pDBInterfaceEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                    pDBInterfaceEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                    pDBInterfaceEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                    pDBInterfaceEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Interface_Data_Sensor_Save(DBInterfaceEntity pDBInterfaceEntity, DataTable dt)",
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
        public override DBInterfaceEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                DBInterfaceEntity pDBInterfaceEntity = new DBInterfaceEntity();

                pDBInterfaceEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pDBInterfaceEntity;
            }
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

     public class GatheringMainProvider : EntityManager<GatheringMainEntity>
    {
        #region 생성자 - GatheringMainProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public GatheringMainProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - POPProductionOrder_Info_Mst(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Gathering_Search_Mst(GatheringMainEntity pGatheringMainEntity)
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
                            //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            //new MySqlParameter("@resource_code", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            //new SqlParameter("@resource_code", SqlDbType.NVarChar, 50),
                           // new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                //pDataParameters[0].Value = pGatheringMainEntity.CORP_CODE;
                //pDataParameters[1].Value = pGatheringMainEntity.COLLECTION_DATE;
                //pDataParameters[2].Value = pGatheringMainEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_XGathering_LoadingData_R10", pDataParameters);

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

        #region 디테일 조회하기 - Gathering_Search_Sub(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Gathering_Search_Sub(DataRow dr)
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
                            //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@rsc_mst_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@rsc_mst_code", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = dr["RESOURCE_CODE"].ToString();
                //pDataParameters[1].Value = pGatheringMainEntity.COLLECTION_DATE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_XGathering_LoadingData_R20", pDataParameters);

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

        #region MinMax센서 테이더 조회하기 - Alarm_MinMax_Mst(GatheringMainEntity pGatheringUcCtlEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Alarm_MinMax_Mst(GatheringMainEntity pGatheringUcCtlEntity)
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

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {

                        };
                        break;
                }

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_gathering_MinMax", pDataParameters);

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

        #region 정보 저장하기 - DQ_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDQGatheringEntity"></param>
        /// <returns></returns>
        public bool DQ_Data_Save(GatheringMainEntity pGatheringMainEntity)
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
                                    new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_collection_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_date", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_property_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_condition_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.VarChar,10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_collection_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_date", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_property_value", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_condition_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_value", SqlDbType.VarChar,10)
                        };
                        break;
                }

                pDataParameters[0].Value = pGatheringMainEntity.CORP_CODE;
                pDataParameters[1].Value = pGatheringMainEntity.CRUD;
                pDataParameters[2].Value = pGatheringMainEntity.USER_CODE;
                pDataParameters[3].Value = pGatheringMainEntity.COLLECTION_CODE;
                pDataParameters[4].Value = pGatheringMainEntity.COLLECTION_DATE;
                pDataParameters[5].Value = pGatheringMainEntity.PROPERTY_VALUE;
                pDataParameters[6].Value = pGatheringMainEntity.CONDITION_CODE;
                pDataParameters[7].Value = pGatheringMainEntity.COLLECTION_VALUE;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_DQGathering_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pGatheringMainEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pGatheringMainEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pGatheringMainEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pGatheringMainEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pGatheringMainEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)",
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
        public override GatheringMainEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                GatheringMainEntity pGatheringMainEntity = new GatheringMainEntity();

                pGatheringMainEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pGatheringMainEntity;
            }
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


    public class GatheringUcCtlProvider : EntityManager<GatheringUcCtlEntity>
    {
        #region 생성자 - GatheringMainProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public GatheringUcCtlProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - POPProductionOrder_Info_Mst(GatheringUcCtlEntity pGatheringUcCtlEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Gathering_Binding_Mst(GatheringUcCtlEntity pGatheringUcCtlEntity)
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
                            //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            //new MySqlParameter("@resource_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            //new SqlParameter("@resource_code", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                //pDataParameters[0].Value = pGatheringMainEntity.CORP_CODE;
                //pDataParameters[1].Value = pGatheringMainEntity.COLLECTION_DATE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_XGathering_LoadingData_R10", pDataParameters);

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

        #region 알람마스터 조회하기 - Gathering_Alarm_Mst(GatheringUcCtlEntity pGatheringUcCtlEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Gathering_Alarm_Mst(GatheringUcCtlEntity pGatheringUcCtlEntity)
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
                          
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                           
                        };
                        break;
                }

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_alarm_search_status", pDataParameters);

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

        #region MinMax센서 테이더 조회하기 - Alarm_MinMax_Mst(GatheringUcCtlEntity pGatheringUcCtlEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Alarm_MinMax_Mst(GatheringUcCtlEntity pGatheringUcCtlEntity)
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

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {

                        };
                        break;
                }

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_gathering_MinMax", pDataParameters);

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

        

        #region 정보 저장하기 - DQ_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDQGatheringEntity"></param>
        /// <returns></returns>
        public bool DQ_Data_Save(GatheringUcCtlEntity pGatheringUcCtlEntity)
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
                                    new MySqlParameter("@v_resource_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_property_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_condition_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_resource_mst", MySqlDbType.VarChar,50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_resource_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_property_value", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_condition_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                                    new SqlParameter("@v_resource_mst", SqlDbType.NVarChar,50)
                        };
                        break;
                }

                pDataParameters[0].Value = pGatheringUcCtlEntity.RESOURCE_SERVER;  // 채번된 리소스 센서코드
                pDataParameters[1].Value = pGatheringUcCtlEntity.ATTR1;
                pDataParameters[2].Value = pGatheringUcCtlEntity.ATTR2;
                pDataParameters[3].Value = pGatheringUcCtlEntity.VALUES;
                pDataParameters[4].Value = pGatheringUcCtlEntity.RESOURCE_CODE;  // ex ) RS0001

                //프로시저 생성

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SvrSensor_I40", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pGatheringUcCtlEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pGatheringUcCtlEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pGatheringUcCtlEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pGatheringUcCtlEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pGatheringUcCtlEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 정보 저장하기 - DQ_Data_Trash_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDQGatheringEntity"></param>
        /// <returns></returns>
        public bool DQ_Data_Trash_Save(GatheringUcCtlEntity pGatheringUcCtlEntity)  //41번으로 교체
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
                                    new MySqlParameter("@v_resource_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_property_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_condition_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.Decimal),
                                    new MySqlParameter("@v_resource_mst", MySqlDbType.VarChar,50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_resource_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_property_value", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_condition_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                                    new SqlParameter("@v_resource_mst", SqlDbType.NVarChar,50)
                        };
                        break;
                }

                pDataParameters[0].Value = pGatheringUcCtlEntity.RESOURCE_SERVER;  // 채번된 리소스 센서코드
                pDataParameters[1].Value = pGatheringUcCtlEntity.ATTR1;
                pDataParameters[2].Value = pGatheringUcCtlEntity.ATTR2;
                pDataParameters[3].Value = pGatheringUcCtlEntity.VALUES;
                pDataParameters[4].Value = pGatheringUcCtlEntity.RESOURCE_CODE;  // ex ) RS0001

                //프로시저 생성

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SvrSensor_I41", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pGatheringUcCtlEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pGatheringUcCtlEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pGatheringUcCtlEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pGatheringUcCtlEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pGatheringUcCtlEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region String 정보 저장하기 - DQ_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDQGatheringEntity"></param>
        /// <returns></returns>
        public bool DQ_Data_Save_Str(GatheringUcCtlEntity pGatheringUcCtlEntity)
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
                                    new MySqlParameter("@v_resource_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_property_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_condition_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_resource_mst", MySqlDbType.VarChar,50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_resource_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_property_value", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_condition_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_value", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_resource_mst", SqlDbType.NVarChar,50)
                        };
                        break;
                }

                pDataParameters[0].Value = pGatheringUcCtlEntity.RESOURCE_SERVER;  // 채번된 리소스 센서코드
                pDataParameters[1].Value = pGatheringUcCtlEntity.ATTR1;
                pDataParameters[2].Value = pGatheringUcCtlEntity.ATTR2;
                pDataParameters[3].Value = pGatheringUcCtlEntity.STRING_VALUES;
                pDataParameters[4].Value = pGatheringUcCtlEntity.RESOURCE_CODE;  // ex ) RS0001

                //프로시저 생성

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SvrSensor_I30", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pGatheringUcCtlEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pGatheringUcCtlEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pGatheringUcCtlEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pGatheringUcCtlEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pGatheringUcCtlEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region CoreChips Svr 저장하기 - CoreChips_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDQGatheringEntity"></param>
        /// <returns></returns>
        public bool CoreChips_Data_Save(GatheringUcCtlEntity pGatheringUcCtlEntity)
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
                                    new MySqlParameter("@v_CORP_CODE", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_EQUIPMENT_CODE", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_GROUP_CODE", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_STATUS_CODE", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_AVG_P_VOLTAGE", MySqlDbType.VarChar,50),  //5
                                    new MySqlParameter("@v_E_AVG_L_VOLTAGE", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_AVG_VOL_FACTOR", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_AVG_P_CURRENT", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_AVG_CUR_FACTOR", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_ACTIVE_POWER", MySqlDbType.VarChar,50), //10
                                    new MySqlParameter("@v_E_REACTIVE_POWER", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_POWER_FACTOR", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_AVG_FREQUENCY", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_AVG_VOLTAGE", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_AVG_CURRENT", MySqlDbType.VarChar,50), //15
                                    new MySqlParameter("@v_E_TEMP", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_AVG_VOL_HAMONIC", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_AVG_CURR_HAMONIC", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_POWER_CONSUMPTION", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_ELECTRIC_CHARGE", MySqlDbType.VarChar,50), //20
                                    new MySqlParameter("@v_E_RS_LINE_VOLTAGE", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_ST_LINE_VOLTAGE", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_TR_LINE_VOLTAGE", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_MONTH_POWER_CONSUMPTION", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_MONTH_ELECTRIC_CHARGE", MySqlDbType.VarChar,50), //25
                                    new MySqlParameter("@v_E_R_CURRENT", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_S_CURRENT", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_T_CURRENT", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_N_CURRENT", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_R_VOLTAGE", MySqlDbType.VarChar,50), //30
                                    new MySqlParameter("@v_E_S_VOLTAGE", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_E_T_VOLTAGE", MySqlDbType.VarChar,50), 
                                    new MySqlParameter("@v_E_N_VOLTAGE", MySqlDbType.VarChar,50) //33
                        };                                 
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@회사코드", SqlDbType.NVarChar,10),
                                    new SqlParameter("@설비번호", SqlDbType.NVarChar,8),
                                    new SqlParameter("@그룹번호", SqlDbType.NVarChar,50),
                                    new SqlParameter("@상태코드", SqlDbType.NVarChar,2),
                                    new SqlParameter("@평균상전압", SqlDbType.NVarChar,20), //5
                                    new SqlParameter("@평균선간전압", SqlDbType.NVarChar,20),
                                    new SqlParameter("@평균전압파고율", SqlDbType.NVarChar,20),
                                    new SqlParameter("@평균상전류", SqlDbType.NVarChar,20),
                                    new SqlParameter("@평균전류파고율", SqlDbType.NVarChar,20),
                                    new SqlParameter("@유효전력량", SqlDbType.NVarChar,20), //10
                                    new SqlParameter("@무효전력량", SqlDbType.NVarChar,20), 
                                    new SqlParameter("@역률", SqlDbType.NVarChar,20),
                                    new SqlParameter("@평균주파수", SqlDbType.NVarChar,20),
                                    new SqlParameter("@평균전압", SqlDbType.NVarChar,20),
                                    new SqlParameter("@평균전류", SqlDbType.NVarChar,20),  //15
                                    new SqlParameter("@평균온도", SqlDbType.NVarChar,20),  
                                    new SqlParameter("@평균전압고조파", SqlDbType.NVarChar,20),
                                    new SqlParameter("@평균전류고조파", SqlDbType.NVarChar,20),
                                    new SqlParameter("@누적전력량", SqlDbType.NVarChar,20),
                                    new SqlParameter("@누적요금", SqlDbType.NVarChar,20), //20
                                    new SqlParameter("@RS간선간전압", SqlDbType.NVarChar,20), 
                                    new SqlParameter("@ST간선간전압", SqlDbType.NVarChar,20),
                                    new SqlParameter("@TR간선간전압", SqlDbType.NVarChar,20),
                                    new SqlParameter("@당월누적전력량", SqlDbType.NVarChar,20),
                                    new SqlParameter("@당월누적요금", SqlDbType.NVarChar,20), //25
                                    new SqlParameter("@R상전류", SqlDbType.NVarChar,20), 
                                    new SqlParameter("@S상전류", SqlDbType.NVarChar,20),
                                    new SqlParameter("@T상전류", SqlDbType.NVarChar,20),
                                    new SqlParameter("@N상전류", SqlDbType.NVarChar,20),
                                    new SqlParameter("@R상전압", SqlDbType.NVarChar,20), //30
                                    new SqlParameter("@S상전압", SqlDbType.NVarChar,20), 
                                    new SqlParameter("@T상전압", SqlDbType.NVarChar,20),
                                    new SqlParameter("@N상전압", SqlDbType.NVarChar,20)  // 33
                                    
                        };
                        break;
                }

                pDataParameters[0].Value = pGatheringUcCtlEntity.CORP_CODE;
                pDataParameters[1].Value = pGatheringUcCtlEntity.E_EQUIPMENT_CODE;
                pDataParameters[2].Value = pGatheringUcCtlEntity.E_GROUP_CODE;
                pDataParameters[3].Value = pGatheringUcCtlEntity.E_STATUS_CODE;
                pDataParameters[4].Value = pGatheringUcCtlEntity.E_AVG_P_VOLTAGE;
                pDataParameters[5].Value = pGatheringUcCtlEntity.E_AVG_L_VOLTAGE;
                pDataParameters[6].Value = pGatheringUcCtlEntity.E_AVG_VOL_FACTOR;
                pDataParameters[7].Value = pGatheringUcCtlEntity.E_AVG_P_CURRENT;
                pDataParameters[8].Value = pGatheringUcCtlEntity.E_AVG_CUR_FACTOR;
                pDataParameters[9].Value = pGatheringUcCtlEntity.E_ACTIVE_POWER;
                pDataParameters[10].Value = pGatheringUcCtlEntity.E_REACTIVE_POWER;
                pDataParameters[11].Value = pGatheringUcCtlEntity.E_POWER_FACTOR;
                pDataParameters[12].Value = pGatheringUcCtlEntity.E_AVG_FREQUENCY;
                pDataParameters[13].Value = pGatheringUcCtlEntity.E_AVG_VOLTAGE;
                pDataParameters[14].Value = pGatheringUcCtlEntity.E_AVG_CURRENT;
                pDataParameters[15].Value = pGatheringUcCtlEntity.E_TEMP;
                pDataParameters[16].Value = pGatheringUcCtlEntity.E_AVG_VOL_HAMONIC;
                pDataParameters[17].Value = pGatheringUcCtlEntity.E_AVG_CURR_HAMONIC;
                pDataParameters[18].Value = pGatheringUcCtlEntity.E_POWER_CONSUMPTION;
                pDataParameters[19].Value = pGatheringUcCtlEntity.E_ELECTRIC_CHARGE;
                pDataParameters[20].Value = pGatheringUcCtlEntity.E_RS_LINE_VOLTAGE;
                pDataParameters[21].Value = pGatheringUcCtlEntity.E_ST_LINE_VOLTAGE;
                pDataParameters[22].Value = pGatheringUcCtlEntity.E_TR_LINE_VOLTAGE;
                pDataParameters[23].Value = pGatheringUcCtlEntity.E_MONTH_POWER_CONSUMPTION;
                pDataParameters[24].Value = pGatheringUcCtlEntity.E_MONTH_ELECTRIC_CHARGE;
                pDataParameters[25].Value = pGatheringUcCtlEntity.E_R_CURRENT;
                pDataParameters[26].Value = pGatheringUcCtlEntity.E_S_CURRENT;
                pDataParameters[27].Value = pGatheringUcCtlEntity.E_T_CURRENT;
                pDataParameters[28].Value = pGatheringUcCtlEntity.E_N_CURRENT;
                pDataParameters[29].Value = pGatheringUcCtlEntity.E_R_VOLTAGE;
                pDataParameters[30].Value = pGatheringUcCtlEntity.E_S_VOLTAGE;
                pDataParameters[31].Value = pGatheringUcCtlEntity.E_T_VOLTAGE;
                pDataParameters[32].Value = pGatheringUcCtlEntity.E_N_VOLTAGE;

                //프로시저 생성

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_XGathering_ElectricSave_I01", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pGatheringUcCtlEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pGatheringUcCtlEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pGatheringUcCtlEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pGatheringUcCtlEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_AQ"].ToString();
                pGatheringUcCtlEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "USP_XGathering_ElectricSave_I01(DQGatheringEntity pDQGatheringEntity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 정보 저장하기 - DQ_TOP_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDQGatheringEntity"></param>
        /// <returns></returns>
        public bool DQ_TOP_Data_Save(GatheringUcCtlEntity pGatheringUcCtlEntity)
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
                                    new MySqlParameter("@v_hw_gubn", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_hw_id", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_value", MySqlDbType.VarChar,50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_hw_gubn", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_hw_id", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_value", SqlDbType.NVarChar,50)
                        };
                        break;
                }

                pDataParameters[0].Value = pGatheringUcCtlEntity.E_GROUP_CODE;  // 채번된 리소스 센서코드
                pDataParameters[1].Value = pGatheringUcCtlEntity.E_EQUIPMENT_CODE;
                pDataParameters[2].Value = pGatheringUcCtlEntity.E_TEMP;

                //프로시저 생성

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SvrSensor_I50", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pGatheringUcCtlEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pGatheringUcCtlEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pGatheringUcCtlEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pGatheringUcCtlEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pGatheringUcCtlEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region TOP 전력 정보 저장하기 - DQ_TOP_Data_Save(GatheringMainEntity pGatheringMainEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDQGatheringEntity"></param>
        /// <returns></returns>
        public bool DQ_TOP_elec_Data_Save(GatheringUcCtlEntity pGatheringUcCtlEntity)
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
                                    new MySqlParameter("@v_hw_gubn", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_hw_id", MySqlDbType.VarChar,8),
                                    new MySqlParameter("@v_r_vol", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_s_vol", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_t_vol", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_r_curr", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_s_curr", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_t_curr", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_pow_fac", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_act_pow", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_pow_consum", MySqlDbType.VarChar,50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_hw_gubn", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_hw_id", SqlDbType.NVarChar,8),
                                    new SqlParameter("@v_r_vol", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_s_vol", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_t_vol", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_r_curr", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_s_curr", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_t_curr", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_pow_fac", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_act_pow", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_pow_consum", SqlDbType.NVarChar,50)
                        };
                        break;
                }

                pDataParameters[0].Value = pGatheringUcCtlEntity.E_STATUS_CODE;  // 채번된 리소스 센서코드
                pDataParameters[1].Value = pGatheringUcCtlEntity.E_HW_CODE.Trim();
                pDataParameters[2].Value = pGatheringUcCtlEntity.E_R_VOLTAGE;
                pDataParameters[3].Value = pGatheringUcCtlEntity.E_S_VOLTAGE;
                pDataParameters[4].Value = pGatheringUcCtlEntity.E_T_VOLTAGE;
                pDataParameters[5].Value = pGatheringUcCtlEntity.E_R_CURRENT;
                pDataParameters[6].Value = pGatheringUcCtlEntity.E_S_CURRENT;
                pDataParameters[7].Value = pGatheringUcCtlEntity.E_T_CURRENT;
                pDataParameters[8].Value = pGatheringUcCtlEntity.E_POWER_FACTOR;
                pDataParameters[9].Value = pGatheringUcCtlEntity.E_ACTIVE_POWER;
                pDataParameters[10].Value = pGatheringUcCtlEntity.E_POWER_CONSUMPTION;

                //프로시저 생성

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SvrSensor_I60", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pGatheringUcCtlEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pGatheringUcCtlEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pGatheringUcCtlEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pGatheringUcCtlEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pGatheringUcCtlEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "DQ_Data_Save(DQGatheringEntity pDQGatheringEntity)",
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
        public override GatheringUcCtlEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                GatheringUcCtlEntity pGatheringUcCtlEntity = new GatheringUcCtlEntity();

                pGatheringUcCtlEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pGatheringUcCtlEntity;
            }
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

    //포장
    public class frmPOPMain_PRODUCT_COSMETICSProvider : EntityManager<POPSelect_INSPECT_COSMETICSEntity>
    {
        #region ○ 개체구하기
        public override POPSelect_INSPECT_COSMETICSEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity = new POPSelect_INSPECT_COSMETICSEntity();
                pPOPSelect_INSPECT_COSMETICSEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pPOPSelect_INSPECT_COSMETICSEntity;
            }
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

        #region ○ 생성자 - POPProductionOrderProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPMain_PRODUCT_COSMETICSProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        public bool frmPOPMain_PRODUCT_COSMETICS_REQUEST_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
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
                                            new MySqlParameter("@v_production_order_id   ".Trim(), MySqlDbType.VarChar, 15)
                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_production_order_id   ".Trim(), SqlDbType.VarChar, 15)
                            };
                            break;
                    }
                    pDataParametersA[0].Value = pPOPSelect_INSPECT_COSMETICSEntity.CRUD;
                    pDataParametersA[1].Value = pPOPSelect_INSPECT_COSMETICSEntity.USER_CODE;
                    pDataParametersA[2].Value = pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_ORDER_ID;


                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T01_I30", pDataParametersA);

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    pPOPSelect_INSPECT_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                    pPOPSelect_INSPECT_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                    pPOPSelect_INSPECT_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                    pPOPSelect_INSPECT_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                    pPOPSelect_INSPECT_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
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

        #region 정보 저장하기 - WorkResultInfo_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)


        public bool WorkResultInfo_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
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

                pDataParametersA[0].Value = pPOPSelect_INSPECT_COSMETICSEntity.RESOURCE_CODE;
                pDataParametersA[1].Value = pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_DATE;
                pDataParametersA[2].Value = pPOPSelect_INSPECT_COSMETICSEntity.PROPERTY_VALUE;
                pDataParametersA[3].Value = pPOPSelect_INSPECT_COSMETICSEntity.CONDITION_CODE;
                pDataParametersA[4].Value = pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_VALUE;
                pDataParametersA[5].Value = pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE;

                //DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T01_I40", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pPOPSelect_INSPECT_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(POPProductionOrder_Entity pPOPSelect_INSPECT_COSMETICSEntity)",
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

        public bool WorkResultInfo_Save_01(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
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

                pDataParametersA[0].Value = pPOPSelect_INSPECT_COSMETICSEntity.CRUD;
                pDataParametersA[1].Value = pPOPSelect_INSPECT_COSMETICSEntity.USER_CODE;
                pDataParametersA[2].Value = pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pPOPSelect_INSPECT_COSMETICSEntity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pPOPSelect_INSPECT_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(POPProductionOrder_Entity pPOPProductionOrder_Entity)",
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

        //시험검사의뢰
        public bool WorkResultInfo_Save_02(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
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
                                            new MySqlParameter("@v_reference_id              ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_part_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_sampling_result             ".Trim(), MySqlDbType.Decimal),
                                            new MySqlParameter("@v_sampling_date             ".Trim(), MySqlDbType.VarChar, 8)
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
                                            new SqlParameter("@v_sampling_result             ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_sampling_date             ".Trim(), SqlDbType.VarChar, 8)
                                           // new SqlParameter("@v_remark             ".Trim(), SqlDbType.VarChar, 2000),

                                    };
                                    break;
                            }
                            pDataParametersA[0].Value = pPOPSelect_INSPECT_COSMETICSEntity.CRUD;
                            pDataParametersA[1].Value = pPOPSelect_INSPECT_COSMETICSEntity.USER_CODE;
                            pDataParametersA[2].Value = pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_ORDER_ID;// dt.Rows[a]["PRODUCTION_ORDER_ID"].ToString().ToUpper();
                            pDataParametersA[3].Value = pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE;//dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                            pDataParametersA[4].Value = pPOPSelect_INSPECT_COSMETICSEntity.SAMPLING_RESULT== "" ? "0" : pPOPSelect_INSPECT_COSMETICSEntity.SAMPLING_RESULT;  // 회사코드 pQTY; ;//dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                            pDataParametersA[5].Value = pPOPSelect_INSPECT_COSMETICSEntity.SAMPLING_DATE;
                                                                                                                                                                  //pDataParametersA[4].Value = dt.Rows[a]["REMARK"].ToString().ToUpper();


                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POPMain_PRODUCT_COSMETICS_I10", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            pPOPSelect_INSPECT_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                            pPOPSelect_INSPECT_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                            pPOPSelect_INSPECT_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                            pPOPSelect_INSPECT_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                            pPOPSelect_INSPECT_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
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

        public bool POPSelect_INSPECT_COSMETICS_Info_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
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

                pDataParametersA[0].Value = pPOPSelect_INSPECT_COSMETICSEntity.CRUD;
                pDataParametersA[1].Value = pPOPSelect_INSPECT_COSMETICSEntity.USER_CODE;
                pDataParametersA[2].Value = pPOPSelect_INSPECT_COSMETICSEntity.INOUT_TYPE;
                pDataParametersA[3].Value = pPOPSelect_INSPECT_COSMETICSEntity.INOUT_ID;
                pDataParametersA[4].Value = pPOPSelect_INSPECT_COSMETICSEntity.INOUT_DATE;
                pDataParametersA[5].Value = pPOPSelect_INSPECT_COSMETICSEntity.INOUT_SEQ;
                pDataParametersA[6].Value = pPOPSelect_INSPECT_COSMETICSEntity.INOUT_CODE;
                pDataParametersA[7].Value = pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE;
                pDataParametersA[8].Value = pPOPSelect_INSPECT_COSMETICSEntity.VEND_CODE;
                pDataParametersA[9].Value = Convert.ToDecimal(pPOPSelect_INSPECT_COSMETICSEntity.INOUT_QTY);
                pDataParametersA[10].Value = pPOPSelect_INSPECT_COSMETICSEntity.PART_UNIT;
                pDataParametersA[11].Value = Convert.ToDecimal(pPOPSelect_INSPECT_COSMETICSEntity.UNITCOST);
                pDataParametersA[12].Value = Convert.ToDecimal(pPOPSelect_INSPECT_COSMETICSEntity.COST);
                pDataParametersA[13].Value = pPOPSelect_INSPECT_COSMETICSEntity.REFERENCE_ID;
                pDataParametersA[14].Value = pPOPSelect_INSPECT_COSMETICSEntity.REMARK;
                pDataParametersA[15].Value = pPOPSelect_INSPECT_COSMETICSEntity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucWorkResultPopup_T01_I10", pDataParametersA);

                pPOPSelect_INSPECT_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.RTN_AQ = pDataTableA.Rows[0]["rtn_aq"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.RTN_SQ = pDataTableA.Rows[0]["rtn_sq"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();
                

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

    }



    //제조
    public class frmPOPMain_SEMIPRODUCT_COSMETICSProvider : EntityManager<POPSelect_INSPECT_COSMETICSEntity>
    {
        #region ○ 개체구하기
        public override POPSelect_INSPECT_COSMETICSEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity = new POPSelect_INSPECT_COSMETICSEntity();
                pPOPSelect_INSPECT_COSMETICSEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pPOPSelect_INSPECT_COSMETICSEntity;
            }
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

        #region ○ 생성자 - POPProductionOrderProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPMain_SEMIPRODUCT_COSMETICSProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 저장하기 - WorkResultInfo_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)


        public bool WorkResultInfo_Save(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
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

                pDataParametersA[0].Value = pPOPSelect_INSPECT_COSMETICSEntity.RESOURCE_CODE;
                pDataParametersA[1].Value = pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_DATE;
                pDataParametersA[2].Value = pPOPSelect_INSPECT_COSMETICSEntity.PROPERTY_VALUE;
                pDataParametersA[3].Value = pPOPSelect_INSPECT_COSMETICSEntity.CONDITION_CODE;
                pDataParametersA[4].Value = pPOPSelect_INSPECT_COSMETICSEntity.COLLECTION_VALUE;
                pDataParametersA[5].Value = pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pPOPSelect_INSPECT_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(POPProductionOrder_Entity pPOPSelect_INSPECT_COSMETICSEntity)",
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

        public bool WorkResultInfo_Save_01(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
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

                pDataParametersA[0].Value = pPOPSelect_INSPECT_COSMETICSEntity.CRUD;
                pDataParametersA[1].Value = pPOPSelect_INSPECT_COSMETICSEntity.USER_CODE;
                pDataParametersA[2].Value = pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pPOPSelect_INSPECT_COSMETICSEntity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pPOPSelect_INSPECT_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(POPProductionOrder_Entity pPOPProductionOrder_Entity)",
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

        //시험검사의뢰
        public bool WorkResultInfo_Save_02(POPSelect_INSPECT_COSMETICSEntity pPOPSelect_INSPECT_COSMETICSEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
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
                                            new MySqlParameter("@v_reference_id              ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_part_code             ".Trim(), MySqlDbType.VarChar, 50),
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
                                            new SqlParameter("@v_sampling_result             ".Trim(), SqlDbType.Decimal)
                            // new SqlParameter("@v_remark             ".Trim(), SqlDbType.VarChar, 2000),

                        };
                        break;
                }
                pDataParametersA[0].Value = pPOPSelect_INSPECT_COSMETICSEntity.CRUD;
                pDataParametersA[1].Value = pPOPSelect_INSPECT_COSMETICSEntity.USER_CODE;
                pDataParametersA[2].Value = pPOPSelect_INSPECT_COSMETICSEntity.PRODUCTION_ORDER_ID;// dt.Rows[a]["PRODUCTION_ORDER_ID"].ToString().ToUpper();
                pDataParametersA[3].Value = pPOPSelect_INSPECT_COSMETICSEntity.PART_CODE;//dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                                                                                         //pDataParametersA[4].Value = dt.Rows[a]["REMARK"].ToString().ToUpper();
                pDataParametersA[4].Value = pPOPSelect_INSPECT_COSMETICSEntity.SAMPLING_RESULT == "" ? "0" : pPOPSelect_INSPECT_COSMETICSEntity.SAMPLING_RESULT;  // 회사코드 pQTY; ;//dt.Rows[a]["PART_CODE"].ToString().ToUpper();

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POPMain_PRODUCT_COSMETICS_I10", pDataParametersA);

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                pPOPSelect_INSPECT_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                pPOPSelect_INSPECT_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
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

    //푸른들식품, 바이오믹스
    public class frmPOPMain_PRODUCT_MIXProvider : EntityManager<POPSelect_INSPECT_MIXEntity>
    {
        #region ○ 개체구하기
        public override POPSelect_INSPECT_MIXEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity = new POPSelect_INSPECT_MIXEntity();
                pPOPSelect_INSPECT_MIXEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pPOPSelect_INSPECT_MIXEntity;
            }
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

        #region ○ 생성자 - POPProductionOrderProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPMain_PRODUCT_MIXProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 터미널 상세 정보 조회하기 - frmPOPMain_PRODUCT_MIX_terminal_info(pPOPSelect_INSPECT_MIXEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_PRODUCT_MIX_terminal_info(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break; 

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPSelect_INSPECT_MIXEntity.TERMINAL_CODE;
                pDataParameters[1].Value = pPOPSelect_INSPECT_MIXEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R40", pDataParameters);


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
                    "frmPOPMain_PRODUCT_MIX_terminal_info(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 바코드 라벨 정보 조회하기 - frmPOPMain_PRODUCT_MIX_terminal_info(pPOPSelect_INSPECT_MIXEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_PRODUCT_MIX_barcode_Info(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_print_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_print_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPSelect_INSPECT_MIXEntity.PRINT_CODE;
                pDataParameters[1].Value = pPOPSelect_INSPECT_MIXEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R30", pDataParameters);


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
                    "frmPOPMain_PRODUCT_MIX_terminal_info(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 실적 정보 저장하기 

        public bool POP_ProductInRegister_Info_Save(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)
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
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
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
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
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
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                                new SqlParameter("@v_order_id", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pPOPSelect_INSPECT_MIXEntity.CRUD;
                pDataParametersA[1].Value = pPOPSelect_INSPECT_MIXEntity.USER_CODE;
                pDataParametersA[2].Value = pPOPSelect_INSPECT_MIXEntity.INOUT_TYPE;
                pDataParametersA[3].Value = "";
                pDataParametersA[4].Value = pPOPSelect_INSPECT_MIXEntity.INOUT_DATE;
                pDataParametersA[5].Value = pPOPSelect_INSPECT_MIXEntity.INOUT_SEQ;
                pDataParametersA[6].Value = pPOPSelect_INSPECT_MIXEntity.INOUT_CODE;
                pDataParametersA[7].Value = pPOPSelect_INSPECT_MIXEntity.PART_CODE;
                pDataParametersA[8].Value = pPOPSelect_INSPECT_MIXEntity.VEND_CODE;
                pDataParametersA[9].Value = Convert.ToDecimal(pPOPSelect_INSPECT_MIXEntity.INOUT_QTY);
                pDataParametersA[10].Value = pPOPSelect_INSPECT_MIXEntity.PART_UNIT;
                pDataParametersA[11].Value = "";
                pDataParametersA[12].Value = pPOPSelect_INSPECT_MIXEntity.USE_YN;
                pDataParametersA[13].Value = pPOPSelect_INSPECT_MIXEntity.PRODUCTION_ORDER_ID;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductInRegister_I20", pDataParametersA);

                pPOPSelect_INSPECT_MIXEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                pPOPSelect_INSPECT_MIXEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                pPOPSelect_INSPECT_MIXEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                pPOPSelect_INSPECT_MIXEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                pPOPSelect_INSPECT_MIXEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

        #endregion

        #region 업체 번호 조회하기 - frmPOPMain_PRODUCT_MIX_vendCode_info(string partCode)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_PRODUCT_MIX_vendCode_info(string printCode)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_print_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_print_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = printCode;
                pDataParameters[1].Value = "";

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R50", pDataParameters);


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
                    "frmPOPMain_PRODUCT_MIX_terminal_info(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - WorkResultInfo_Save(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)


        public bool WorkResultInfo_Save(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)
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

                pDataParametersA[0].Value = pPOPSelect_INSPECT_MIXEntity.RESOURCE_CODE;
                pDataParametersA[1].Value = pPOPSelect_INSPECT_MIXEntity.COLLECTION_DATE;
                pDataParametersA[2].Value = pPOPSelect_INSPECT_MIXEntity.PROPERTY_VALUE;
                pDataParametersA[3].Value = pPOPSelect_INSPECT_MIXEntity.CONDITION_CODE;
                pDataParametersA[4].Value = pPOPSelect_INSPECT_MIXEntity.OPTION_CODE;
                pDataParametersA[5].Value = pPOPSelect_INSPECT_MIXEntity.COLLECTION_VALUE;
                pDataParametersA[6].Value = "";
                pDataParametersA[7].Value = pPOPSelect_INSPECT_MIXEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);


                /*
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
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 20)
                        };
                        break;
                }

                pDataParametersA[0].Value = pPOPSelect_INSPECT_MIXEntity.RESOURCE_CODE;
                pDataParametersA[1].Value = pPOPSelect_INSPECT_MIXEntity.COLLECTION_DATE;
                pDataParametersA[2].Value = pPOPSelect_INSPECT_MIXEntity.PROPERTY_VALUE;
                pDataParametersA[3].Value = pPOPSelect_INSPECT_MIXEntity.CONDITION_CODE;
                pDataParametersA[4].Value = pPOPSelect_INSPECT_MIXEntity.COLLECTION_VALUE;
                pDataParametersA[5].Value = pPOPSelect_INSPECT_MIXEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I20", pDataParametersA);
                */

                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pPOPSelect_INSPECT_MIXEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(POPProductionOrder_Entity pPOPSelect_INSPECT_MIXEntity)",
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

        public bool WorkResultInfo_Save_01(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)
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

                pDataParametersA[0].Value = pPOPSelect_INSPECT_MIXEntity.CRUD;
                pDataParametersA[1].Value = pPOPSelect_INSPECT_MIXEntity.USER_CODE;
                pDataParametersA[2].Value = pPOPSelect_INSPECT_MIXEntity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pPOPSelect_INSPECT_MIXEntity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pPOPSelect_INSPECT_MIXEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(POPProductionOrder_Entity pPOPProductionOrder_Entity)",
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

    // 진영
    public class frmPOPMain_PRESS_LINEProvider : EntityManager<frmPOPMain_PRESS_LINEEntity>
    {
        #region ○ 생성자 - frmPOPMain_PRESS_LINEProvider(pDBManager)
        public frmPOPMain_PRESS_LINEProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region ○ MAIN REFRESH
        public DataTable frmPOPMain_PRESS_LINE_REFRESH(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity)
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
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_lot_id", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pfrmPOPMain_PRESS_LINEEntity.CRUD;
                pDataParameters[1].Value = pfrmPOPMain_PRESS_LINEEntity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pfrmPOPMain_PRESS_LINEEntity.LOT_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_PRESS_LINE_R10", pDataParameters);


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
                    "frmPOPMain_PRESS_LINE_REFRESH(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity)",
                    pException
                );
            }
        }
        #endregion

        #region LOT 불량내역조회
        public DataTable frmPOPMain_PRESS_LINE_NG_LIST(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity)
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
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_id", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_lot_id", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pfrmPOPMain_PRESS_LINEEntity.CRUD;
                pDataParameters[1].Value = pfrmPOPMain_PRESS_LINEEntity.PROCESS_CODE;
                pDataParameters[2].Value = pfrmPOPMain_PRESS_LINEEntity.PRODUCTION_ORDER_ID;
                pDataParameters[3].Value = pfrmPOPMain_PRESS_LINEEntity.LOT_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrder_T03_R15", pDataParameters);


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
                    "frmPOPMain_PRESS_LINE_NG_LIST(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ LOT 생성하기
        public bool PRESS_LINE_LOT_CRATE(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_value1", MySqlDbType.VarChar, 1),
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_value1", SqlDbType.VarChar, 1),
                        };
                        break;
                }

                pDataParametersA[0].Value = pfrmPOPMain_PRESS_LINEEntity.CRUD;
                pDataParametersA[1].Value = pfrmPOPMain_PRESS_LINEEntity.USER_CODE;
                pDataParametersA[2].Value = pfrmPOPMain_PRESS_LINEEntity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pfrmPOPMain_PRESS_LINEEntity.USA_LOT_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_PRESS_LINE_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pfrmPOPMain_PRESS_LINEEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                    pfrmPOPMain_PRESS_LINEEntity.NEW_LOT = pDataTableA.Rows[0]["NEW_LOT"].ToString();
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
                    "PRESS_LINE_LOT_CRATE(POPSelect_INSPECT_MIXEntity pPOPSelect_INSPECT_MIXEntity)",
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

        #region 생산실적 및 불량 결과저장
        public bool PRESS_LINE_LOT_RESULT(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity, DataTable dt)
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
                            pfrmPOPMain_PRESS_LINEEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "PRESS_LINE_LOT_RESULT(frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity, DataTable dt)",
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

        #region ○ 개체구하기
        public override frmPOPMain_PRESS_LINEEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                frmPOPMain_PRESS_LINEEntity pfrmPOPMain_PRESS_LINEEntity = new frmPOPMain_PRESS_LINEEntity();
                pfrmPOPMain_PRESS_LINEEntity.CORP_CODE = pDataRow["production_order_id"] is DBNull ? string.Empty : pDataRow["production_order_id"] as string;  // 회사코드
                return pfrmPOPMain_PRESS_LINEEntity;
            }
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

    //범아기전
    public class frmPOPMain_PRODUCT_Work_MIXProvider : EntityManager<POPWorkResult_MIXEntity>
    {
        #region ○ 개체구하기
        public override POPWorkResult_MIXEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity = new POPWorkResult_MIXEntity();
                pPOPWorkResult_MIXEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pPOPWorkResult_MIXEntity;
            }
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

        #region ○ 생성자 - POPProductionOrderProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPMain_PRODUCT_Work_MIXProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 터미널 상세 정보 조회하기 - frmPOPMain_PRODUCT_MIX_terminal_info(pPOPWorkResult_MIXEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_PRODUCT_Work_MIX_terminal_info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPWorkResult_MIXEntity.TERMINAL_CODE;
                pDataParameters[1].Value = pPOPWorkResult_MIXEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R40", pDataParameters);


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
                    "frmPOPMain_PRODUCT_MIX_terminal_info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 바코드 라벨 정보 조회하기 - frmPOPMain_PRODUCT_MIX_terminal_info(pPOPWorkResult_MIXEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_PRODUCT_MIX_barcode_Info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_print_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_print_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPWorkResult_MIXEntity.PRINT_CODE;
                pDataParameters[1].Value = pPOPWorkResult_MIXEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R30", pDataParameters);


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
                    "frmPOPMain_PRODUCT_MIX_terminal_info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)",
                    pException
                );
            }
        }

        #endregion
        #region 바코드 라벨 정보 조회하기 - frmPOPMain_PRODUCT_MIX_terminal_info(pPOPWorkResult_MIXEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_PRODUCT_MIX_barcode_save_Info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_barcode_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_print_date", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_barcode_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_print_date", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPWorkResult_MIXEntity.PRINT_CODE;
                pDataParameters[1].Value = pPOPWorkResult_MIXEntity.PART_CODE;
                pDataParameters[2].Value = pPOPWorkResult_MIXEntity.COLLECTION_DATE;
                pDataParameters[3].Value = "";
                pDataParameters[4].Value = pPOPWorkResult_MIXEntity.USER_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_LabelPrint_I10", pDataParameters);


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
                    "frmPOPMain_PRODUCT_MIX_terminal_info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 업체 번호 조회하기 - frmPOPMain_PRODUCT_MIX_vendCode_info(string partCode)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_PRODUCT_MIX_vendCode_info(string printCode)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_print_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_print_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = printCode;
                pDataParameters[1].Value = "";

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R50", pDataParameters);


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
                    "frmPOPMain_PRODUCT_MIX_terminal_info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - WorkResultInfo_Save(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)


        public bool WorkResultInfo_Save(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
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
                            new SqlParameter("@v_option_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_collection_value_str", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 20)
                        };
                        break;
                }

                pDataParametersA[0].Value = pPOPWorkResult_MIXEntity.RESOURCE_CODE;
                pDataParametersA[1].Value = pPOPWorkResult_MIXEntity.COLLECTION_DATE;
                pDataParametersA[2].Value = pPOPWorkResult_MIXEntity.PROPERTY_VALUE;
                pDataParametersA[3].Value = pPOPWorkResult_MIXEntity.CONDITION_CODE;
                pDataParametersA[4].Value = "";
                pDataParametersA[5].Value = pPOPWorkResult_MIXEntity.COLLECTION_VALUE;
                pDataParametersA[6].Value = "";
                pDataParametersA[7].Value = "";

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pPOPWorkResult_MIXEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(POPProductionOrder_Entity pPOPWorkResult_MIXEntity)",
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

        public bool WorkResultInfo_Save_01(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
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

                pDataParametersA[0].Value = pPOPWorkResult_MIXEntity.CRUD;
                pDataParametersA[1].Value = pPOPWorkResult_MIXEntity.USER_CODE;
                pDataParametersA[2].Value = pPOPWorkResult_MIXEntity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pPOPWorkResult_MIXEntity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pPOPWorkResult_MIXEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(POPProductionOrder_Entity pPOPProductionOrder_Entity)",
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

        #region 마스터 조회하기 - POPProductBOM_image_info(POPProductBOMEntity pPOPProductBOMEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderCommonEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductBOM_image_info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            //new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_document_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            //new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_document_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pPOPWorkResult_MIXEntity.CORP_CODE;
                //pDataParameters[1].Value = pPOPProductBOMEntity.RESOURCE_CODE;
                pDataParameters[1].Value = pPOPWorkResult_MIXEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pPOPWorkResult_MIXEntity.PART_CODE;
                pDataParameters[3].Value = pPOPWorkResult_MIXEntity.DOCUMENT_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_BOMDocument_R20", pDataParameters);

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

        #region 공지사항 가져오기 - POPProduct_notice_info(POPProductBOMEntity pPOPProductBOMEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderCommonEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProduct_notice_info(POPWorkResult_MIXEntity pPOPWorkResult_MIXEntity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            //new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            //new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            

                };
                        break;
                }

                pDataParameters[0].Value = pPOPWorkResult_MIXEntity.CORP_CODE;
                //pDataParameters[1].Value = pPOPProductBOMEntity.RESOURCE_CODE;
                pDataParameters[1].Value = pPOPWorkResult_MIXEntity.LANGUAGE_TYPE;
               

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_NOTICE_R10", pDataParameters);

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

    }

    public class frmPOPMain_PRODUCT_Work_T50Provider : EntityManager<POPWorkResult_T50Entity>
    {
        #region ○ 개체구하기
        public override POPWorkResult_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPWorkResult_T50Entity pPOPWorkResult_T50Entity = new POPWorkResult_T50Entity();
                pPOPWorkResult_T50Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pPOPWorkResult_T50Entity;
            }
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

        #region ○ 생성자 - POPProductionOrderProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPMain_PRODUCT_Work_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 터미널 상세 정보 조회하기 - frmPOPMain_PRODUCT_MIX_terminal_info(pPOPWorkResult_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_PRODUCT_Work_T50_terminal_info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPWorkResult_T50Entity.TERMINAL_CODE;
                pDataParameters[1].Value = pPOPWorkResult_T50Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R40", pDataParameters);


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
                    "frmPOPMain_PRODUCT_MIX_terminal_info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 바코드 라벨 정보 조회하기 - frmPOPMain_PRODUCT_MIX_terminal_info(pPOPWorkResult_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_PRODUCT_MIX_barcode_Info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_print_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_print_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPWorkResult_T50Entity.PRINT_CODE;
                pDataParameters[1].Value = pPOPWorkResult_T50Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R30", pDataParameters);


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
                    "frmPOPMain_PRODUCT_MIX_terminal_info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 업체 번호 조회하기 - frmPOPMain_PRODUCT_MIX_vendCode_info(string partCode)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_PRODUCT_MIX_vendCode_info(string printCode)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_print_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_print_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = printCode;
                pDataParameters[1].Value = "";

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R50", pDataParameters);


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
                    "frmPOPMain_PRODUCT_MIX_terminal_info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - WorkResultInfo_Save(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)


        public bool WorkResultInfo_Save(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
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
                            new SqlParameter("@v_option_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_collection_value_str", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 20)
                        };
                        break;
                }

                pDataParametersA[0].Value = pPOPWorkResult_T50Entity.RESOURCE_CODE;
                pDataParametersA[1].Value = pPOPWorkResult_T50Entity.COLLECTION_DATE;
                pDataParametersA[2].Value = pPOPWorkResult_T50Entity.PROPERTY_VALUE;
                pDataParametersA[3].Value = pPOPWorkResult_T50Entity.CONDITION_CODE;
                pDataParametersA[4].Value = pPOPWorkResult_T50Entity.OPTION_CODE;
                pDataParametersA[5].Value = pPOPWorkResult_T50Entity.COLLECTION_VALUE;
                pDataParametersA[6].Value = "";
                pDataParametersA[7].Value = pPOPWorkResult_T50Entity.USER_NAME;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pPOPWorkResult_T50Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(POPProductionOrder_Entity pPOPWorkResult_T50Entity)",
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

        public bool WorkResultInfo_Save_01(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
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
                            new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 6),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                            new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 6),
                            new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pPOPWorkResult_T50Entity.CRUD;
                pDataParametersA[1].Value = pPOPWorkResult_T50Entity.USER_CODE;
                pDataParametersA[2].Value = pPOPWorkResult_T50Entity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pPOPWorkResult_T50Entity.PRODUCTION_ORDER_SEQ;
                pDataParametersA[4].Value = pPOPWorkResult_T50Entity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T50_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pPOPWorkResult_T50Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(POPProductionOrder_Entity pPOPProductionOrder_Entity)",
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

        public bool WorkResultInfo_Save_02(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
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
                            new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 6),
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 15),
                            new MySqlParameter("@v_production_order_seq", MySqlDbType.VarChar, 6),
                        };
                        break;
                }

                pDataParametersA[0].Value = pPOPWorkResult_T50Entity.CRUD;
                pDataParametersA[1].Value = pPOPWorkResult_T50Entity.USER_CODE;
                pDataParametersA[2].Value = pPOPWorkResult_T50Entity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pPOPWorkResult_T50Entity.PRODUCTION_ORDER_SEQ;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_T50_U10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pPOPWorkResult_T50Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(POPProductionOrder_Entity pPOPProductionOrder_Entity)",
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

        #region 작업중인 작지정보 가져오기
        public DataTable USP_production_order_detail_t50_R10(string code)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_equipment_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_equipment_code", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = code;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_production_order_detail_t50_R10", pDataParameters);


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
                    "frmPOPMain_PRODUCT_MIX_terminal_info(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 설비상태 입력하기
        public DataTable USP_equipment_running_I10(POPWorkResult_T50Entity pPOPWorkResult_T50Entity, string remark)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_equipment_state", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_remark", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_user", MySqlDbType.VarChar, 50),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_equipment_code", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPWorkResult_T50Entity.TERMINAL_CODE; //설비코드
                pDataParameters[1].Value = pPOPWorkResult_T50Entity.PROCESS_CODE;
                pDataParameters[2].Value = pPOPWorkResult_T50Entity.PROPERTY_VALUE;
                pDataParameters[3].Value = remark;
                pDataParameters[4].Value = pPOPWorkResult_T50Entity.USER_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_equipment_running_I10", pDataParameters);


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
                    "USP_equipment_running_I10(USP_equipment_running_I10 pPOPWorkResult_T50Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 설비상태 조회하기
        public DataTable USP_equipment_running_R10(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_equipment_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_equipment_code", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPWorkResult_T50Entity.TERMINAL_CODE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_equipment_running_R10", pDataParameters);


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
                    "USP_equipment_running_I10(USP_equipment_running_I10 pPOPWorkResult_T50Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 설비상태 조회하기
        public DataTable USP_production_order_t50_R60(string orderid)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_production_order_id", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_production_order_id", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = orderid;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_production_order_t50_R60", pDataParameters);


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
                    "USP_equipment_running_I10(USP_equipment_running_I10 pPOPWorkResult_T50Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 설비상태 조회하기
        public DataTable USP_PRODUCTION_ORDER_T50_U10(string orderid, string seq, string badqty)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_seq", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_badqty", MySqlDbType.Int32)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_production_order_id", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = orderid;
                pDataParameters[1].Value = seq;
                pDataParameters[2].Value = badqty;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_PRODUCTION_ORDER_T50_U10", pDataParameters);


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
                    "USP_equipment_running_I10(USP_equipment_running_I10 pPOPWorkResult_T50Entity)",
                    pException
                );
            }
        }
        #endregion
    }



    public class frmPOPMain_WEIGHING_COSMETICSProvider : EntityManager<frmPOPMain_WEIGHING_COSMETICSEntity>
    {
        #region 생성자 - frmPOPMain_WEIGHING_COSMETICSProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPMain_WEIGHING_COSMETICSProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

         #region 마스터 조회하기 - Sample_Info_Mst(ucMaterialStockInfoPopupEntity pucMaterialStockInfoPopupEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet frmPOPMain_WEIGHING_COSMETICS_Sub_Return(string pCRUD, string pPART_CODE)
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

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPART_CODE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_frmPOPMain_WEIGHING_COSMETICS_R20", pDataParameters);


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
                    "Sample_Info_Mst(ucMaterialStockInfoPopupEntity pucMaterialStockInfoPopupEntity)",
                    pException
                );
            }
        }

        #endregion
        #region 마스터 조회하기 - Sample_Info_Mst(frmPOPMain_WEIGHING_COSMETICSEntity pfrmPOPMain_WEIGHING_COSMETICSEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_WEIGHING_COSMETICS_Main_Return(string pCRUD, string pPART_CODE, string pLANGUAGE_TYPE, string pQTY,string pPRODUCTION_ORDER_ID)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_qty", MySqlDbType.Decimal),
                            new MySqlParameter("@v_production_order_id",  MySqlDbType.VarChar,15)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_qty", SqlDbType.Decimal),
                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar,15)
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPART_CODE;
                pDataParameters[2].Value = pLANGUAGE_TYPE;
                pDataParameters[3].Value = pQTY =="" ? "0" : pQTY;  // 회사코드 pQTY;
                pDataParameters[4].Value = pPRODUCTION_ORDER_ID;  // 회사코드 pQTY;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_WEIGHING_COSMETICS_R10", pDataParameters);


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
                    "Sample_Info_Mst(frmPOPMain_WEIGHING_COSMETICSEntity pfrmPOPMain_WEIGHING_COSMETICSEntity)",
                    pException
                );
            }
        }

        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        #region 정보 저장하기 - MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool frmPOPMain_WEIGHING_COSMETICS_Save(frmPOPMain_WEIGHING_COSMETICSEntity pfrmPOPMain_WEIGHING_COSMETICSEntity, DataTable dt)
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
                        if (dt.Rows[a]["CRUD"].ToString() == "U")
                        {
                            if (Convert.ToDecimal(dt.Rows[a]["INPUT_QTY"].ToString()) > 0)
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
                                new MySqlParameter("@v_inout_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_inout_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_inout_code", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_process_seq", MySqlDbType.VarChar, 10)
                                        };
                                        break;

                                    case "SQLServer":
                                        pDataParametersA = new IDataParameter[]
                                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inout_id", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_inout_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_reference_id", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                                new SqlParameter("@v_inout_code", SqlDbType.VarChar, 10),
                                new SqlParameter("@v_process_seq", SqlDbType.VarChar, 10)

                                        };
                                        break;
                                }

                                pDataParametersA[0].Value = pfrmPOPMain_WEIGHING_COSMETICSEntity.CRUD;
                                pDataParametersA[1].Value = pfrmPOPMain_WEIGHING_COSMETICSEntity.USER_CODE;
                                pDataParametersA[2].Value = dt.Rows[a]["INOUT_ID"].ToString().ToUpper();
                                pDataParametersA[3].Value = dt.Rows[a]["INPUT_QTY"].ToString().ToUpper();
                                pDataParametersA[4].Value = pfrmPOPMain_WEIGHING_COSMETICSEntity.PRODUCTION_ORDER_ID; // "";
                                pDataParametersA[5].Value = "Y";
                                pDataParametersA[6].Value = pfrmPOPMain_WEIGHING_COSMETICSEntity.INOUT_CODE;
                                pDataParametersA[7].Value = dt.Rows[a]["PROCESS_SEQ"].ToString().ToUpper();

                                //pDataParametersA[0].Value = pfrmPOPMain_WEIGHING_COSMETICSEntity.CRUD;
                                //pDataParametersA[1].Value = pfrmPOPMain_WEIGHING_COSMETICSEntity.USER_CODE;
                                //pDataParametersA[2].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper();
                                //pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                                //pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");


                                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialOutRegister_T01_I10", pDataParametersA);

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
                                pfrmPOPMain_WEIGHING_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["p_err_no"].ToString();
                                pfrmPOPMain_WEIGHING_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["p_err_msg"].ToString();
                                pfrmPOPMain_WEIGHING_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["p_rtn_key"].ToString();
                                pfrmPOPMain_WEIGHING_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["p_rtn_seq"].ToString();
                                pfrmPOPMain_WEIGHING_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["p_rtn_others"].ToString();

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
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
                    "MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderRegisterEntity_Request, DataTable dt)",
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
        public override frmPOPMain_WEIGHING_COSMETICSEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                frmPOPMain_WEIGHING_COSMETICSEntity pfrmPOPMain_WEIGHING_COSMETICSEntity = new frmPOPMain_WEIGHING_COSMETICSEntity();

                pfrmPOPMain_WEIGHING_COSMETICSEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pfrmPOPMain_WEIGHING_COSMETICSEntity;
            }
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

    public class frmPOPSelect_WorkOrderDoc_COSMETICSProvider : EntityManager<frmPOPSelect_WorkOrderDoc_COSMETICSEntity>
    {
        #region 생성자 - frmPOPSelect_WorkOrderDoc_COSMETICSProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPSelect_WorkOrderDoc_COSMETICSProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(frmPOPSelect_WorkOrderDoc_COSMETICSEntity pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet frmPOPSelect_WorkOrderDoc_COSMETICS_Return(string pCRUD, string pLANGUAGE_TYPE, string pPRODUCTION_ORDER_ID, string pPART_NAME, string pPART_CODE, string pPROCESS_CODE_MST)
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


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_frmPOPSelect_WorkOrderDoc_COSMETICS_R10", pDataParameters);


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
                    "Sample_Info_Mst(frmPOPSelect_WorkOrderDoc_COSMETICSEntity pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(frmPOPSelect_WorkOrderDoc_COSMETICSEntity pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet frmPOPSelect_WorkOrderDoc_FINDPARTCODE_COSMETICS_Return(string pCRUD, string pPRODUCTION_ORDER_ID, string pBARCODE_ID, string pPROCESS_CODE_MST)
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
                            new MySqlParameter("@v_reference_id", MySqlDbType.VarChar,15),
                            new MySqlParameter("@v_barcode_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 10),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_reference_id", SqlDbType.NVarChar,15),
                            new SqlParameter("@v_barcode_id", SqlDbType.NVarChar,15),
                            new SqlParameter("@v_process_code_mst", SqlDbType.NVarChar, 10),
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pBARCODE_ID;
                pDataParameters[3].Value = pPROCESS_CODE_MST;
                

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_frmPOPSelect_WorkOrderDoc_COSMETICS_R20", pDataParameters);


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
                    "Sample_Info_Mst(frmPOPSelect_WorkOrderDoc_COSMETICSEntity pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity)",
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
        public bool frmPOPSelect_WorkOrderDoc_COSMETICS_Save(frmPOPSelect_WorkOrderDoc_COSMETICSEntity pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;
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
                                            new SqlParameter("@v_order_file             ".Trim(), SqlDbType.VarChar, 100),
                                            new SqlParameter("@v_process_code_mst       ".Trim(), SqlDbType.VarChar, 10),
                                            new SqlParameter("@v_make_no       ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_approver_sign_chk       ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_production_result_qty       ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_production_ng_result_qty       ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_semi_production_result_qty       ".Trim(), SqlDbType.Decimal)


                            };
                            break;
                    }
                    pDataParametersA[0].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.CRUD;
                    pDataParametersA[1].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.USER_CODE;
                    pDataParametersA[2].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PRODUCTION_ORDER_ID;
                    pDataParametersA[3].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.FILE_NAME;
                    pDataParametersA[4].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PROCESS_CODE_MST;
                    pDataParametersA[5].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.MAKE_NO;
                    pDataParametersA[6].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.APPROVER_SIGN_CHK;
                    pDataParametersA[7].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PRODUCTION_RESULT_QTY;
                    pDataParametersA[8].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PRODUCTION_NG_RESULT_QTY;
                    pDataParametersA[9].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.SEMI_PRODUCTION_RESULT_QTY == "" ? "0" : pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.SEMI_PRODUCTION_RESULT_QTY;
                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPSelect_WorkOrderDoc_COSMETICS_I10", pDataParametersA);

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["p_err_no"].ToString();
                    pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["p_err_msg"].ToString();
                    pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["p_rtn_key"].ToString();
                    pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["p_rtn_seq"].ToString();
                    pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["p_rtn_others"].ToString();

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    //     }
                    // }
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
                    "ucWorkRequestInfo_Info_Check_Save(frmPOPSelect_WorkOrderDoc_COSMETICSEntity pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity, DataTable dt)",
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
        #region   BOM으로 부자재 불량실적 등록
        public bool frmPOPSelect_WorkOrderDoc_COSMETICS_Save2(frmPOPSelect_WorkOrderDoc_COSMETICSEntity pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity, Worksheet pSheet)
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
                            //new MySqlParameter("@v_in_inout_id", MySqlDbType.VarChar, 15)
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
                            //new SqlParameter("@v_in_inout_id", SqlDbType.VarChar, 15)
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
                                pDataParametersA[0].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RESOURCE_CODE;
                                pDataParametersA[1].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.COLLECTION_DATE;
                                pDataParametersA[2].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PROPERTY_VALUE;
                                pDataParametersA[3].Value = "MR050020";//MR050020 : 생산출고
                                pDataParametersA[4].Value = Convert.ToDecimal(pSheet.GetCellValue(8, i + 11).ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                                pDataParametersA[5].Value = pSheet.GetCellValue(2, i + 11).ToString();  //업체품번 : 자재코드
                                pDataParametersA[6].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.USER_CODE;
                                pDataParametersA[8].Value = pSheet.GetCellValue(7, i + 11).ToString();  //제조번호
                                //v_in_inout_id
                                //pDataParametersA[7].Value = first_chk1;
                                // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPSelect_WorkOrderDoc_COSMETICS_I20", pDataParametersA);
                                if (pDataTableA.Rows[0]["P_ERR_NO"].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
                                else
                                {
                                    pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
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
                            pDataParametersA[0].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RESOURCE_CODE;
                            pDataParametersA[1].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.COLLECTION_DATE;
                            pDataParametersA[2].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PROPERTY_VALUE;
                            pDataParametersA[3].Value = "BC020001";//BC020001 : 작업불량
                            pDataParametersA[4].Value = Convert.ToDecimal(pSheet.GetCellValue(10, i + 11).ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                            pDataParametersA[5].Value = pSheet.GetCellValue(2, i + 11).ToString();  //업체품번 : 자재코드
                            pDataParametersA[6].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.USER_CODE;
                            pDataParametersA[7].Value = first_chk2;
                            // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPSelect_WorkOrderDoc_COSMETICS_I30", pDataParametersA);
                            if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            else
                            {
                                pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                                first_chk2 = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                            }
                        }
                    }
                    //업체불량
                    if (pSheet.GetCellValue(11, i + 11).ToString() != "")
                    {
                        if ((Convert.ToDecimal(pSheet.GetCellValue(11, i + 11).ToString()) != 0))
                        {
                            pDataParametersA[0].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RESOURCE_CODE;
                            pDataParametersA[1].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.COLLECTION_DATE;
                            pDataParametersA[2].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PROPERTY_VALUE;
                            pDataParametersA[3].Value = "BC020002";//BC020001 : 업체불량
                            pDataParametersA[4].Value = Convert.ToDecimal(pSheet.GetCellValue(11, i + 11).ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                            pDataParametersA[5].Value = pSheet.GetCellValue(2, i + 11).ToString();  //업체품번 : 자재코드
                            pDataParametersA[6].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.USER_CODE;
                            pDataParametersA[7].Value = first_chk3;
                            // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPSelect_WorkOrderDoc_COSMETICS_I30", pDataParametersA);
                            if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            else
                            {
                                pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                                first_chk3 = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                            }
                        }
                    }
                    //반입량
                    if (pSheet.GetCellValue(13, i + 11).ToString() != "")
                    {
                        if ((Convert.ToDecimal(pSheet.GetCellValue(13, i + 11).ToString()) != 0))
                        {
                            pDataParametersA[0].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RESOURCE_CODE;
                            pDataParametersA[1].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.COLLECTION_DATE;
                            pDataParametersA[2].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PROPERTY_VALUE;
                            pDataParametersA[3].Value = "MR040013";// : 반입량코드입력
                            pDataParametersA[4].Value = Convert.ToDecimal(pSheet.GetCellValue(13, i + 11).ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                            pDataParametersA[5].Value = pSheet.GetCellValue(2, i + 11).ToString();  //업체품번 : 자재코드
                            pDataParametersA[6].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.USER_CODE;
                            pDataParametersA[7].Value = first_chk3;
                            // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPSelect_WorkOrderDoc_COSMETICS_I50", pDataParametersA);
                            if (pDataTableA.Rows[0]["P_ERR_NO"].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            else

                            {
                                pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
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
                                pDataParametersA[0].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RESOURCE_CODE;
                                pDataParametersA[1].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.COLLECTION_DATE;
                                pDataParametersA[2].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.PROPERTY_VALUE;
                                pDataParametersA[3].Value = "PD040020";//MR050020 : 생산출고
                                pDataParametersA[4].Value = Convert.ToDecimal(pSheet.GetCellValue(9, i + 25).ToString());// pucWorkResultPopUp_T01_Entity.COLLECTION_VALUE;
                                pDataParametersA[5].Value = pSheet.GetCellValue(2, i + 25).ToString();  //업체품번 : 자재코드
                                pDataParametersA[6].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.USER_CODE;
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
                                    pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
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
        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override frmPOPSelect_WorkOrderDoc_COSMETICSEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                frmPOPSelect_WorkOrderDoc_COSMETICSEntity pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity = new frmPOPSelect_WorkOrderDoc_COSMETICSEntity();

                pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pfrmPOPSelect_WorkOrderDoc_COSMETICSEntity;
            }
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
        public DataTable Sheet_Info_sheet(frmPOPSelect_WorkOrderDoc_COSMETICSEntity pfrmPOPSelect_WorkOrderDoc_COSMETICSEntityEntity)
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

                pDataParameters[0].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntityEntity.CRUD;
                pDataParameters[1].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntityEntity.WINDOW_NAME;
                pDataParameters[2].Value = pfrmPOPSelect_WorkOrderDoc_COSMETICSEntityEntity.LANGUAGE_TYPE;

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


    public class frmPOPSelect_WorkRequestDoc_COSMETICSProvider : EntityManager<frmPOPSelect_WorkRequestDoc_COSMETICSEntity>
    {
        #region 생성자 - frmPOPSelect_WorkRequestDoc_COSMETICSProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPSelect_WorkRequestDoc_COSMETICSProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(frmPOPSelect_WorkRequestDoc_COSMETICSEntity pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet frmPOPSelect_WorkRequestDoc_COSMETICS_Return(string pCRUD, string pLANGUAGE_TYPE, string pPRODUCTION_ORDER_ID, string pPART_NAME, string pPART_CODE, string pPROCESS_CODE_MST)
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


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_frmPOPSelect_WorkRequestDoc_COSMETICS_R10", pDataParameters);


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
                    "Sample_Info_Mst(frmPOPSelect_WorkRequestDoc_COSMETICSEntity pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity)",
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
        public bool frmPOPSelect_WorkRequestDoc_COSMETICS_Save(frmPOPSelect_WorkRequestDoc_COSMETICSEntity pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;
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
                                            new MySqlParameter("@v_process_code_mst             ".Trim(), MySqlDbType.VarChar, 10)


                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_production_order_id     ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_order_file       ".Trim(), SqlDbType.VarChar, 100),
                                            new SqlParameter("@v_process_code_mst       ".Trim(), SqlDbType.VarChar, 10)


                            };
                            break;
                    }
                    pDataParametersA[0].Value = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.CRUD;
                    pDataParametersA[1].Value = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.USER_CODE;
                    pDataParametersA[2].Value = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PRODUCTION_ORDER_ID;
                    pDataParametersA[3].Value = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.FILE_NAME;
                    pDataParametersA[4].Value = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.PROCESS_CODE_MST;


                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPSelect_WorkRequestDoc_COSMETICS_I10", pDataParametersA);

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["p_err_no"].ToString();
                    pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["p_err_msg"].ToString();
                    pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["p_rtn_key"].ToString();
                    pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["p_rtn_seq"].ToString();
                    pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["p_rtn_others"].ToString();

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    //     }
                    // }
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
                    "ucWorkRequestInfo_Info_Check_Save(frmPOPSelect_WorkRequestDoc_COSMETICSEntity pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity, DataTable dt)",
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
        public override frmPOPSelect_WorkRequestDoc_COSMETICSEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                frmPOPSelect_WorkRequestDoc_COSMETICSEntity pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity = new frmPOPSelect_WorkRequestDoc_COSMETICSEntity();

                pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pfrmPOPSelect_WorkRequestDoc_COSMETICSEntity;
            }
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
        public DataTable Sheet_Info_sheet(frmPOPSelect_WorkRequestDoc_COSMETICSEntity pfrmPOPSelect_WorkRequestDoc_COSMETICSEntityEntity)
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

                pDataParameters[0].Value = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntityEntity.CRUD;
                pDataParameters[1].Value = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntityEntity.WINDOW_NAME;
                pDataParameters[2].Value = pfrmPOPSelect_WorkRequestDoc_COSMETICSEntityEntity.LANGUAGE_TYPE;

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


    public class POPProductImageCommonProvider : EntityManager<POPProductionOrder_T50Entity>
    {
        #region 생성자 - POPProductImageCommonProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPProductImageCommonProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - POPProductImage_Info_Mst(POPProductBOMEntity pPOPProductionOrder_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductImageCommonEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductImage_Info_Mst(POPWorkResult_T50Entity _pPOPWorkResult_T50Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                };
                        break;
                }

                pDataParameters[0].Value = _pPOPWorkResult_T50Entity.PART_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_Document_T50_R10", pDataParameters);

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
        public override POPProductionOrder_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPProductionOrder_T50Entity pPOPProductImageCommonEntity = new POPProductionOrder_T50Entity();

                pPOPProductImageCommonEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPProductImageCommonEntity;
            }
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
    public class frmPOPPartStockCheckProvider : EntityManager<frmPOPPartStockCheckEntity>
    {
        #region 생성자 - frmPOPPartStockCheckProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPPartStockCheckProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - POPProductImage_Info_Mst(frmPOPPartStockCheckEntity _pfrmPOPPartStockCheckEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pfrmPOPPartStockCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPPartStockCheck_Info_Mst(frmPOPPartStockCheckEntity _pfrmPOPPartStockCheckEntity)
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
                            new MySqlParameter("@v_barcode_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_barcode_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                };
                        break;
                }

                pDataParameters[0].Value = _pfrmPOPPartStockCheckEntity.CRUD;
                pDataParameters[1].Value = _pfrmPOPPartStockCheckEntity.BARCODE;
                pDataParameters[2].Value = _pfrmPOPPartStockCheckEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPPartStockCheck_R10", pDataParameters);

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
        public override frmPOPPartStockCheckEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                frmPOPPartStockCheckEntity pfrmPOPPartStockCheckEntity = new frmPOPPartStockCheckEntity();

                pfrmPOPPartStockCheckEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pfrmPOPPartStockCheckEntity;
            }
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
    public class POPProductionOrderCommonProvider : EntityManager<POPProductionOrderCommonEntity>
    {
        #region 생성자 - POPProductionOrderCommonProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPProductionOrderCommonProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - POPProductionOrderCommon_Info_Mst(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderCommonEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductionOrderCommon_Info_Mst(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrderCommonEntity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrderCommonEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pPOPProductionOrderCommonEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPOPProductionOrderCommonEntity.PROCESS_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R10", pDataParameters);

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

        #region 래시피 조회하기 - POPProductionOrderCommon_Recipe_Check(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderCommonEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductionOrderCommon_Recipe_Check(string ORDER_ID)
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

                pDataParameters[0].Value = "R";
                pDataParameters[1].Value = ORDER_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R80", pDataParameters);

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

        #region 배합량 BOM 조회하기 - POPProductionOrderMix_Info_Mst(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderCommonEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductionOrderMix_Info_Mst(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrderCommonEntity.CRUD;
                pDataParameters[1].Value = pPOPProductionOrderCommonEntity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pPOPProductionOrderCommonEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R70", pDataParameters);

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

        #region 마스터 조회하기 - POPProductionOrderCommon_Info_Mst2(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderCommonEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductionOrderCommon_Info_Mst2(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrderCommonEntity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrderCommonEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pPOPProductionOrderCommonEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPOPProductionOrderCommonEntity.PROCESS_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R60", pDataParameters);

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

        #region 마스터 조회하기 - POPProductBOM_Info_Mst(POPProductBOMEntity pPOPProductBOMEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderCommonEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductBOM_Info_Mst(POPProductBOMEntity pPOPProductBOMEntity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            //new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            //new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductBOMEntity.CORP_CODE;
                //pDataParameters[1].Value = pPOPProductBOMEntity.RESOURCE_CODE;
                pDataParameters[1].Value = pPOPProductBOMEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pPOPProductBOMEntity.PART_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductBOMRegister_R20", pDataParameters);

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

        #region 마스터 조회하기 - POPProductBOM_image_info(POPProductBOMEntity pPOPProductBOMEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderCommonEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductBOM_image_info(POPProductBOMEntity pPOPProductBOMEntity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            //new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            //new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductBOMEntity.CORP_CODE;
                //pDataParameters[1].Value = pPOPProductBOMEntity.RESOURCE_CODE;
                pDataParameters[1].Value = pPOPProductBOMEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pPOPProductBOMEntity.PART_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_BOMDocument_R10", pDataParameters);

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

        #region 정보 저장하기 - POPProductionOrderCommon_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPOPProductionOrderCommonEntity"></param>
        /// <returns></returns>
        public bool POPProductionOrderCommon_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
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
                                    new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_collection_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_date", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_property_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_condition_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.VarChar,10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_collection_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_date", SqlDbType.NVarChar,20),
                                    new SqlParameter("@v_property_value", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_condition_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_collection_value", SqlDbType.VarChar,10)
                        };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrderCommonEntity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrderCommonEntity.CRUD;
                pDataParameters[2].Value = pPOPProductionOrderCommonEntity.USER_CODE;
                //pDataParameters[3].Value = pPOPProductionOrderCommonEntity.COLLECTION_CODE;
                //pDataParameters[4].Value = pPOPProductionOrderCommonEntity.COLLECTION_DATE;
                //pDataParameters[5].Value = pPOPProductionOrderCommonEntity.PROPERTY_VALUE;
                //pDataParameters[6].Value = pPOPProductionOrderCommonEntity.CONDITION_CODE;
                //pDataParameters[7].Value = pPOPProductionOrderCommonEntity.COLLECTION_VALUE;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_DQGathering_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pPOPProductionOrderCommonEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pPOPProductionOrderCommonEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pPOPProductionOrderCommonEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pPOPProductionOrderCommonEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pPOPProductionOrderCommonEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "POPProductionOrderCommon_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 바코드 정보 저장하기 - POPProductionOrderCommon_Info_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPOPProductionOrderCommonEntity"></param>
        /// <returns></returns>
        public bool POPProductionOrderCommon_Info_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
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
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_part_barcode", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_print_date", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_print_seq", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_part_qty", MySqlDbType.VarChar,50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_part_barcode", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_print_date", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_print_seq", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_part_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_part_qty", SqlDbType.VarChar,50)
                        };
                        break;
                }

                pDataParameters[0].Value = "C";
                pDataParameters[1].Value = pPOPProductionOrderCommonEntity.USER_CODE;
                pDataParameters[2].Value = pPOPProductionOrderCommonEntity.PART_BARCODE;
                pDataParameters[3].Value = pPOPProductionOrderCommonEntity.PRINT_DATE;
                pDataParameters[4].Value = pPOPProductionOrderCommonEntity.PRINT_SEQ;
                pDataParameters[5].Value = pPOPProductionOrderCommonEntity.PART_CODE;
                pDataParameters[6].Value = pPOPProductionOrderCommonEntity.PART_QTY;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pPOPProductionOrderCommonEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pPOPProductionOrderCommonEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pPOPProductionOrderCommonEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pPOPProductionOrderCommonEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pPOPProductionOrderCommonEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "POPProductionOrderCommon_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 배합량 BOM 저장하기 - POPProductionOrderCommon_Recipe_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        public bool POPProductionOrderCommon_Recipe_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity, DataTable dt)
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

                            //마스터 저장
                            IDataParameter[] pDataParametersA = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new MySqlParameter("@v_crud                  ".Trim(), MySqlDbType.VarChar, 1),
                                            new MySqlParameter("@v_user_code                  ".Trim(), MySqlDbType.VarChar, 20),
                                            new MySqlParameter("@v_production_order_id             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_p_part_code              ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_part_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_default_qty             ".Trim(), MySqlDbType.Decimal),
                                            new MySqlParameter("@v_update_qty             ".Trim(), MySqlDbType.Decimal),
                                            new MySqlParameter("@v_input_qty             ".Trim(), MySqlDbType.Decimal),
                                            new MySqlParameter("@v_standard_qty             ".Trim(), MySqlDbType.Decimal),
                                            new MySqlParameter("@v_box_qty             ".Trim(), MySqlDbType.Decimal),
                                            new MySqlParameter("@v_meterage_qty             ".Trim(), MySqlDbType.Decimal),
                                            new MySqlParameter("@v_remark             ".Trim(), MySqlDbType.VarChar, 1000)

                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code                  ".Trim(), SqlDbType.VarChar, 20),
                                            new SqlParameter("@v_production_order_id             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_p_part_code              ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_part_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_default_qty           ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_update_qty           ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_input_qty           ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_standard_qty           ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_box_qty           ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_meterage_qty           ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_remark           ".Trim(), SqlDbType.VarChar, 1000)

                                    };
                                    break;
                            }
                            pDataParametersA[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersA[1].Value = pPOPProductionOrderCommonEntity.USER_CODE;
                            pDataParametersA[2].Value = dt.Rows[a]["PRODUCTION_ORDER_ID"].ToString().ToUpper();
                            pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                            pDataParametersA[4].Value = dt.Rows[a]["MATERIAL_CODE"].ToString().ToUpper();
                            pDataParametersA[5].Value = Convert.ToDecimal(dt.Rows[a]["DEFAULT_QTY"].ToString());

                            if (dt.Rows[a]["UPDATE_QTY"].ToString() == null || dt.Rows[a]["UPDATE_QTY"].ToString() == "")
                            {
                                pDataParametersA[6].Value = Convert.ToDecimal(dt.Rows[a]["DEFAULT_QTY"].ToString());
                            }
                            else
                            {
                                pDataParametersA[6].Value = Convert.ToDecimal(dt.Rows[a]["UPDATE_QTY"].ToString());
                            }

                            pDataParametersA[7].Value = Convert.ToDecimal(dt.Rows[a]["INPUT_QTY"].ToString());
                            pDataParametersA[8].Value = Convert.ToDecimal(dt.Rows[a]["STANDARD_QTY"].ToString());
                            pDataParametersA[9].Value = Convert.ToDecimal(dt.Rows[a]["BOX_QTY"].ToString());
                            pDataParametersA[10].Value = Convert.ToDecimal(dt.Rows[a]["METERAGE_QTY"].ToString());

                            pDataParametersA[11].Value = dt.Rows[a]["REMARK"].ToString();

                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_I20", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            pPOPProductionOrderCommonEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                            pPOPProductionOrderCommonEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                            pPOPProductionOrderCommonEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                            pPOPProductionOrderCommonEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

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
                    "MaterialInRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialInRegisterEntity_Request, DataTable dt)",
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
        public override POPProductionOrderCommonEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity = new POPProductionOrderCommonEntity();

                pPOPProductionOrderCommonEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPProductionOrderCommonEntity;
            }
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


    public class POPProductionOrderCommonProvider2 : EntityManager<POPProductionOrderCommonEntity>
    {
        #region 생성자 - POPProductionOrderCommonProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPProductionOrderCommonProvider2(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

 
        #region 마스터 조회하기 - POPProductionOrderCommon_Info_Mst2(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductionOrderCommonEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductionOrderCommon_Info_Mst2(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_terminal_code", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductionOrderCommonEntity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductionOrderCommonEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pPOPProductionOrderCommonEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPOPProductionOrderCommonEntity.PROCESS_CODE;
                pDataParameters[4].Value = pPOPProductionOrderCommonEntity.TERMINAL_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R60", pDataParameters);

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
        public override POPProductionOrderCommonEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity = new POPProductionOrderCommonEntity();

                pPOPProductionOrderCommonEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPProductionOrderCommonEntity;
            }
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

    public class POPProductMonitoringProvider : EntityManager<POPProductMonitoringEntity>
    {
        #region 생성자 - POPProductMonitoringProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPProductMonitoringProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion


        #region 마스터 조회하기 - POPProductMonitoring_Info_Mst2(POPProductMonitoringEntity pPOPProductMonitoringEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pPOPProductMonitoringEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPProductMonitoring_Info_Mst2(POPProductMonitoringEntity pPOPProductMonitoringEntity)
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
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_curd", SqlDbType.VarChar, 1),

                };
                        break;
                }

                pDataParameters[0].Value = pPOPProductMonitoringEntity.CORP_CODE;
                pDataParameters[1].Value = pPOPProductMonitoringEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pPOPProductMonitoringEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPOPProductMonitoringEntity.PROCESS_CODE;
                pDataParameters[4].Value = "R";

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductMonitoring_R10", pDataParameters);

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
        public override POPProductMonitoringEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPProductMonitoringEntity pPOPProductMonitoringEntity = new POPProductMonitoringEntity();

                pPOPProductMonitoringEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPProductMonitoringEntity;
            }
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


    public class frmPOPMain_RAWMATERIAL_COSMETICSProvider : EntityManager<frmPOPMain_RAWMATERIAL_COSMETICSEntity>
    {
        #region 생성자 - frmPOPMain_RAWMATERIAL_COSMETICSProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPMain_RAWMATERIAL_COSMETICSProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - frmPOPMain_RAWMATERIAL_COSMETICS_Info_Mst(frmPOPMain_RAWMATERIAL_COSMETICSEntity pfrmPOPMain_RAWMATERIAL_COSMETICSEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pfrmPOPMain_RAWMATERIAL_COSMETICSEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_RAWMATERIAL_COSMETICS_Info_Mst(frmPOPMain_RAWMATERIAL_COSMETICSEntity pfrmPOPMain_RAWMATERIAL_COSMETICSEntity)
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
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                           // new MySqlParameter("@v_order_date", MySqlDbType.VarChar,20),
                           // new MySqlParameter("@v_to_date", MySqlDbType.VarChar,20),
                           // new MySqlParameter("@v_part_name", MySqlDbType.VarChar,50),
                           // new MySqlParameter("@v_vend_name", MySqlDbType.VarChar,50),


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                           // new SqlParameter("@v_order_date", SqlDbType.NVarChar,20),
                           // new SqlParameter("@v_to_date", SqlDbType.NVarChar,20),
                           // new SqlParameter("@v_part_name", SqlDbType.NVarChar,50),
                           // new SqlParameter("@v_vend_name", SqlDbType.NVarChar,50)

                        };
                        break;
                }

                pDataParameters[0].Value = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.CRUD;
               //pDataParameters[1].Value = pFROM_DATE;
               //pDataParameters[2].Value = pTO_DATE;
               //pDataParameters[3].Value = pPART_NAME;
               //pDataParameters[4].Value = pVEND_NAME;
                

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_RAWMATERIAL_COSMETICS_R10", pDataParameters);

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

        #region 정보 저장하기 - MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool frmPOPMain_RAWMATERIAL_COSMETICS_Info_Save(frmPOPMain_RAWMATERIAL_COSMETICSEntity pfrmPOPMain_RAWMATERIAL_COSMETICSEntity, DataTable dt)
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
                        if (dt.Rows[a]["CRUD"].ToString() == "U")
                        {
                            if (Convert.ToDecimal(dt.Rows[a]["INPUT_QTY"].ToString()) > 0)
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
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_end_date", MySqlDbType.VarChar, 8)
                                        };
                                        break;

                                    case "SQLServer":
                                        pDataParametersA = new IDataParameter[]
                                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
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
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                                new SqlParameter("@v_end_date", SqlDbType.VarChar, 8)
                                        };
                                        break;
                                }

                                pDataParametersA[0].Value = "C";
                                pDataParametersA[1].Value = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.USER_CODE;
                                pDataParametersA[2].Value = "I";
                                pDataParametersA[3].Value = dt.Rows[a]["INOUT_ID"].ToString().ToUpper();
                                pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");// _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                                pDataParametersA[5].Value = "000000";
                                pDataParametersA[6].Value = "1001";// pMaterialInRegister_RequestEntity.INOUT_CODE;
                                pDataParametersA[7].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                                pDataParametersA[8].Value = dt.Rows[a]["VEND_CODE"].ToString().ToUpper();
                                pDataParametersA[9].Value = Convert.ToDecimal(dt.Rows[a]["INPUT_QTY"].ToString().ToUpper());
                                pDataParametersA[10].Value = dt.Rows[a]["PART_UNIT"].ToString().ToUpper();
                                pDataParametersA[11].Value = Convert.ToDecimal(dt.Rows[a]["UNITCOST"].ToString().ToUpper());
                                pDataParametersA[12].Value = Convert.ToDecimal(dt.Rows[a]["COST"].ToString().ToUpper());
                                pDataParametersA[13].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper(); ;// dt.Rows[a]["REFERENCE_ID"].ToString().ToUpper();
                                pDataParametersA[14].Value = "";// pMaterialInRegister_RequestEntity.REMARK;
                                pDataParametersA[15].Value = "Y";
                                pDataParametersA[16].Value = DateTime.Now.ToString("yyyyMMdd"); //pMaterialInRegister_RequestEntity.END_DATE;


                                //pDataParametersA[0].Value = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.CRUD;
                                //pDataParametersA[1].Value = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.USER_CODE;
                                //pDataParametersA[2].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper();
                                //pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                                //pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");


                                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_RAWMATERIAL_COSMETICS_I10", pDataParametersA);

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
                                pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                                pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                                pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                                pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                                pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
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
                    "MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderRegisterEntity_Request, DataTable dt)",
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
        public override frmPOPMain_RAWMATERIAL_COSMETICSEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                frmPOPMain_RAWMATERIAL_COSMETICSEntity pfrmPOPMain_RAWMATERIAL_COSMETICSEntity = new frmPOPMain_RAWMATERIAL_COSMETICSEntity();

                pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pfrmPOPMain_RAWMATERIAL_COSMETICSEntity;
            }
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
        public bool frmPOPMain_RAWMATERIAL_COSMETICS_INSPECT_Save(frmPOPMain_RAWMATERIAL_COSMETICSEntity pfrmPOPMain_RAWMATERIAL_COSMETICSEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    //for (int a = 0; a < pCount; a++)
                   // {
                        //체크된것만 저장
                      //  if (dt.Rows[a]["CRUD"].ToString() == "Y")
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
                                            new MySqlParameter("@v_inout_id              ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_part_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_sampling_result         ".Trim(), MySqlDbType.Decimal),
                                            new MySqlParameter("@v_sampling_date             ".Trim(), MySqlDbType.VarChar, 8)


                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_inout_id              ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_part_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_sampling_result             ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_sampling_date             ".Trim(), SqlDbType.VarChar, 8),

                                    };
                                    break;
                            }
                            pDataParametersA[0].Value = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.CRUD;
                            pDataParametersA[1].Value = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.USER_CODE;
                            pDataParametersA[2].Value = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.ORDER_ID;//t.Rows[a]["INOUT_ID"].ToString().ToUpper();
                            pDataParametersA[3].Value = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.PART_CODE;//dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                            pDataParametersA[4].Value = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.SAMPLING_RESULT == "" ? "0" : pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.SAMPLING_RESULT;  // 회사코드 pQTY; ;//dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                            pDataParametersA[5].Value = pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.SAMPLING_DATE;

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_RAWMATERIAL_COSMETICS_I20", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                           pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                           pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                           pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                           pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                            pfrmPOPMain_RAWMATERIAL_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                       // }
                   // }
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
                    "MaterialInRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialInRegisterEntity_Request, DataTable dt)",
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
    }


    public class frmPOPMain_MATERIAL_COSMETICSProvider : EntityManager<frmPOPMain_MATERIAL_COSMETICSEntity>
    {
        #region 생성자 - frmPOPMain_MATERIAL_COSMETICSProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPMain_MATERIAL_COSMETICSProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - frmPOPMain_MATERIAL_COSMETICS_Info_Mst(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pfrmPOPMain_MATERIAL_COSMETICSEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_MATERIAL_COSMETICS_Info_Mst(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity)
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
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                           // new MySqlParameter("@v_order_date", MySqlDbType.VarChar,20),
                           // new MySqlParameter("@v_to_date", MySqlDbType.VarChar,20),
                           // new MySqlParameter("@v_part_name", MySqlDbType.VarChar,50),
                           // new MySqlParameter("@v_vend_name", MySqlDbType.VarChar,50),


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                           // new SqlParameter("@v_order_date", SqlDbType.NVarChar,20),
                           // new SqlParameter("@v_to_date", SqlDbType.NVarChar,20),
                           // new SqlParameter("@v_part_name", SqlDbType.NVarChar,50),
                           // new SqlParameter("@v_vend_name", SqlDbType.NVarChar,50)

                        };
                        break;
                }

                pDataParameters[0].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD;
                //pDataParameters[1].Value = pFROM_DATE;
                //pDataParameters[2].Value = pTO_DATE;
                //pDataParameters[3].Value = pPART_NAME;
                //pDataParameters[4].Value = pVEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_MATERIAL_COSMETICS_R10", pDataParameters);

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

        #region 작업지시조회 - frmPOPMain_MATERIAL_COSMETICS_Info_Mst2(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pfrmPOPMain_MATERIAL_COSMETICSEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_MATERIAL_COSMETICS_Info_Mst2(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity)
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
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_qty", MySqlDbType.Decimal),
                            new MySqlParameter("@v_production_order_id",  MySqlDbType.VarChar,15)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_qty", SqlDbType.Decimal),
                            new SqlParameter("@v_production_order_id", SqlDbType.NVarChar,15)
                        };
                        break;
                }

                pDataParameters[0].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD;
                pDataParameters[1].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.PART_CODE;
                pDataParameters[2].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_QTY == "" ? "0" : pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_QTY;  // 회사코드 pQTY;
                pDataParameters[4].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID;  // 회사코드 pQTY;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_MATERIAL_COSMETICS_R20", pDataParameters);


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
                    "Sample_Info_Mst(frmPOPMain_WEIGHING_COSMETICSEntity pfrmPOPMain_WEIGHING_COSMETICSEntity)",
                    pException
                );
            }
        }

        #endregion
        #region 작업지시조회 - frmPOPMain_MATERIAL_COSMETICS_Info_Mst2(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pfrmPOPMain_MATERIAL_COSMETICSEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_MATERIAL_COSMETICS_Info_Mst3(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity)
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
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),

                        };
                        break;
                }

                pDataParameters[0].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD;
                pDataParameters[1].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_MATERIAL_COSMETICS_R30", pDataParameters);


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
                    "Sample_Info_Mst(frmPOPMain_WEIGHING_COSMETICSEntity pfrmPOPMain_WEIGHING_COSMETICSEntity)",
                    pException
                );
            }
        }

        #endregion
        #region 마스터 조회하기 - Sample_Info_Mst(ucMaterialStockInfoPopupEntity pucMaterialStockInfoPopupEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet frmPOPMain_MATERIAL_COSMETICS_Sub_Return(string pCRUD, string pPART_CODE)
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

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPART_CODE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_frmPOPMain_MATERIAL_COSMETICS_R40", pDataParameters);


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
                    "Sample_Info_Mst(ucMaterialStockInfoPopupEntity pucMaterialStockInfoPopupEntity)",
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
        public bool frmPOPMain_MATERIAL_COSMETICS_Info_Save(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity, DataTable dt)
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
                        if (dt.Rows[a]["CRUD"].ToString() == "U")
                        {
                            if (Convert.ToDecimal(dt.Rows[a]["INPUT_QTY"].ToString()) > 0)
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
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_end_date", MySqlDbType.VarChar, 8)
                                        };
                                        break;

                                    case "SQLServer":
                                        pDataParametersA = new IDataParameter[]
                                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
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
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                                new SqlParameter("@v_end_date", SqlDbType.VarChar, 8)
                                        };
                                        break;
                                }

                                pDataParametersA[0].Value = "C";
                                pDataParametersA[1].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE;
                                pDataParametersA[2].Value = "I";
                                pDataParametersA[3].Value = dt.Rows[a]["INOUT_ID"].ToString().ToUpper();
                                pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");// _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                                pDataParametersA[5].Value = "000000";
                                pDataParametersA[6].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.INOUT_CODE; //"1001";// pMaterialInRegister_RequestEntity.INOUT_CODE;
                                pDataParametersA[7].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                                pDataParametersA[8].Value = dt.Rows[a]["VEND_CODE"].ToString().ToUpper();
                                pDataParametersA[9].Value = Convert.ToDecimal(dt.Rows[a]["INPUT_QTY"].ToString().ToUpper());
                                pDataParametersA[10].Value = dt.Rows[a]["PART_UNIT"].ToString().ToUpper();
                                pDataParametersA[11].Value = Convert.ToDecimal(dt.Rows[a]["UNITCOST"].ToString().ToUpper());
                                pDataParametersA[12].Value = Convert.ToDecimal(dt.Rows[a]["COST"].ToString().ToUpper());
                                pDataParametersA[13].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper(); ;// dt.Rows[a]["REFERENCE_ID"].ToString().ToUpper();
                                pDataParametersA[14].Value = "";// pMaterialInRegister_RequestEntity.REMARK;
                                pDataParametersA[15].Value = "Y";
                                pDataParametersA[16].Value = DateTime.Now.ToString("yyyyMMdd"); //pMaterialInRegister_RequestEntity.END_DATE;


                                //pDataParametersA[0].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD;
                                //pDataParametersA[1].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE;
                                //pDataParametersA[2].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper();
                                //pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                                //pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");


                                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_MATERIAL_COSMETICS_I10", pDataParametersA);

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
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
                    "MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderRegisterEntity_Request, DataTable dt)",
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

        #region 정보 저장하기 - MaterialOrderRegister_Request_Info_Save2(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        /// //생산출고
        public bool frmPOPMain_MATERIAL_COSMETICS_Info_Save2(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity, DataTable dt)
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
                        if (dt.Rows[a]["CRUD"].ToString() == "U" && dt.Rows[a]["INPUT_QTY"].ToString() != "" && dt.Rows[a]["IN_INOUT_ID"].ToString() != "")
                        {
                            if (Convert.ToDecimal(dt.Rows[a]["INPUT_QTY"].ToString()) > 0)
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
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_end_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_in_inout_id", MySqlDbType.VarChar, 15)
                                        };
                                        break;

                                    case "SQLServer":
                                        pDataParametersA = new IDataParameter[]
                                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
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
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                                new SqlParameter("@v_end_date", SqlDbType.VarChar, 8),
                                new SqlParameter("@v_in_inout_id", SqlDbType.VarChar, 15)
                                        };
                                        break;
                                }

                                pDataParametersA[0].Value = "C";
                                pDataParametersA[1].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE;
                                pDataParametersA[2].Value = "O";
                                pDataParametersA[3].Value = "";// dt.Rows[a]["INOUT_ID"].ToString().ToUpper();
                                pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");// _luINOUT_DATE.DateTime.ToString("yyyyMMdd");
                                pDataParametersA[5].Value = "000000";
                                pDataParametersA[6].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.INOUT_CODE; //"1001";// pMaterialInRegister_RequestEntity.INOUT_CODE;
                                pDataParametersA[7].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                                pDataParametersA[8].Value = "V00000";// dt.Rows[a]["VEND_CODE"].ToString().ToUpper();
                                pDataParametersA[9].Value = Convert.ToDecimal(dt.Rows[a]["INPUT_QTY"].ToString().ToUpper());
                                pDataParametersA[10].Value = dt.Rows[a]["UNIT_CODE"].ToString().ToUpper();
                                pDataParametersA[11].Value = Convert.ToDecimal(dt.Rows[a]["UNITCOST"].ToString().ToUpper());
                                pDataParametersA[12].Value = 0;// Convert.ToDecimal(dt.Rows[a]["COST"].ToString().ToUpper());
                                pDataParametersA[13].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID;
                                pDataParametersA[14].Value = "";// pMaterialInRegister_RequestEntity.REMARK;
                                pDataParametersA[15].Value = "Y";
                                pDataParametersA[16].Value = DateTime.Now.ToString("yyyyMMdd"); //pMaterialInRegister_RequestEntity.END_DATE;
                                pDataParametersA[17].Value = dt.Rows[a]["IN_INOUT_ID"].ToString().ToUpper(); //pMaterialInRegister_RequestEntity.END_DATE;


                                //pDataParametersA[0].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD;
                                //pDataParametersA[1].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE;
                                //pDataParametersA[2].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper();
                                //pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                                //pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");


                                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_MATERIAL_COSMETICS_I30", pDataParametersA);

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
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
                    "MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderRegisterEntity_Request, DataTable dt)",
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
        #region 정보 저장하기 - MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool frmPOPMain_MATERIAL_COSMETICS_INSPECT_Save3(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity, DataTable dt)
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
                        if (dt.Rows[a]["CRUD"].ToString() == "U")
                        {
                            if (Convert.ToDecimal(dt.Rows[a]["INPUT_QTY"].ToString()) > 0)
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
                                new MySqlParameter("@v_inout_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_inout_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_inout_code", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_process_seq", MySqlDbType.VarChar, 10),
                                        };
                                        break;

                                    case "SQLServer":
                                        pDataParametersA = new IDataParameter[]
                                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inout_id", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_inout_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_reference_id", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                                new SqlParameter("@v_inout_code", SqlDbType.VarChar, 10),
                                new SqlParameter("@v_process_seq", SqlDbType.VarChar, 10),

                                        };
                                        break;
                                }

                                pDataParametersA[0].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD;
                                pDataParametersA[1].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE;
                                pDataParametersA[2].Value = dt.Rows[a]["INOUT_ID"].ToString().ToUpper();
                                pDataParametersA[3].Value = dt.Rows[a]["INPUT_QTY"].ToString().ToUpper();
                                pDataParametersA[4].Value = "";// pfrmPOPMain_MATERIAL_COSMETICSEntity.PRODUCTION_ORDER_ID; // "";
                                pDataParametersA[5].Value = "Y";
                                pDataParametersA[6].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.INOUT_CODE;
                                pDataParametersA[7].Value = "";

                                //pDataParametersA[0].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD;
                                //pDataParametersA[1].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE;
                                //pDataParametersA[2].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper();
                                //pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                                //pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");


                                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialOutRegister_T01_I10", pDataParametersA);

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["p_err_no"].ToString();
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["p_err_msg"].ToString();
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["p_rtn_key"].ToString();
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["p_rtn_seq"].ToString();
                                pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["p_rtn_others"].ToString();

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
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
                    "MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderRegisterEntity_Request, DataTable dt)",
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
        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override frmPOPMain_MATERIAL_COSMETICSEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity = new frmPOPMain_MATERIAL_COSMETICSEntity();

                pfrmPOPMain_MATERIAL_COSMETICSEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pfrmPOPMain_MATERIAL_COSMETICSEntity;
            }
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
        public bool frmPOPMain_MATERIAL_COSMETICS_INSPECT_Save(frmPOPMain_MATERIAL_COSMETICSEntity pfrmPOPMain_MATERIAL_COSMETICSEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    //for (int a = 0; a < pCount; a++)
                    // {
                    //체크된것만 저장
                    //  if (dt.Rows[a]["CRUD"].ToString() == "Y")
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
                                            new MySqlParameter("@v_inout_id              ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_part_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_sampling_result             ".Trim(), MySqlDbType.Decimal),
                                            new MySqlParameter("@v_sampling_date             ".Trim(), MySqlDbType.VarChar, 8)


                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_inout_id              ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_part_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_sampling_result             ".Trim(), SqlDbType.Decimal),
                                            new SqlParameter("@v_sampling_date             ".Trim(), SqlDbType.VarChar, 8)

                            };
                            break;
                    }
                    pDataParametersA[0].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.CRUD;
                    pDataParametersA[1].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.USER_CODE;
                    pDataParametersA[2].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.ORDER_ID;//t.Rows[a]["INOUT_ID"].ToString().ToUpper();
                    pDataParametersA[3].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.PART_CODE;//dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                    pDataParametersA[4].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.SAMPLING_RESULT == "" ? "0" : pfrmPOPMain_MATERIAL_COSMETICSEntity.SAMPLING_RESULT;  // 회사코드 pQTY; ;//dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                    pDataParametersA[5].Value = pfrmPOPMain_MATERIAL_COSMETICSEntity.SAMPLING_DATE;


                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_MATERIAL_COSMETICS_I20", pDataParametersA);

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    pfrmPOPMain_MATERIAL_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                    pfrmPOPMain_MATERIAL_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                    pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                    pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                    pfrmPOPMain_MATERIAL_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    // }
                    // }
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
                    "MaterialInRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialInRegisterEntity_Request, DataTable dt)",
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
    }


    public class frmPOPMain_OUT_COSMETICSProvider : EntityManager<frmPOPMain_OUT_COSMETICSEntity>
    {
        #region 생성자 - frmPOPMain_OUT_COSMETICSProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPMain_OUT_COSMETICSProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - frmPOPMain_OUT_COSMETICS_Info_Mst(frmPOPMain_OUT_COSMETICSEntity pfrmPOPMain_OUT_COSMETICSEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pfrmPOPMain_OUT_COSMETICSEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmPOPMain_OUT_COSMETICS_Info_Mst(frmPOPMain_OUT_COSMETICSEntity pfrmPOPMain_OUT_COSMETICSEntity)
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
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50)
                           // new MySqlParameter("@v_vend_name", MySqlDbType.VarChar,50),


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50)

                        };
                        break;
                }

                pDataParameters[0].Value = pfrmPOPMain_OUT_COSMETICSEntity.CRUD;
                pDataParameters[1].Value = pfrmPOPMain_OUT_COSMETICSEntity.DATE_FROM;
                pDataParameters[2].Value = pfrmPOPMain_OUT_COSMETICSEntity.DATE_TO;
                pDataParameters[3].Value = pfrmPOPMain_OUT_COSMETICSEntity.LANGUAGE_TYPE;
                //pDataParameters[4].Value = pVEND_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_OUT_COSMETICS_R10", pDataParameters);

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

        #region 정보 저장하기 - MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool frmPOPMain_OUT_COSMETICS_Info_Save(frmPOPMain_OUT_COSMETICSEntity pfrmPOPMain_OUT_COSMETICSEntity, DataTable dt)
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
                        if (dt.Rows[a]["CRUD"].ToString() == "U")
                        {
                            if (Convert.ToDecimal(dt.Rows[a]["INPUT_QTY"].ToString()) > 0)
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
                                new MySqlParameter("@v_inout_type", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_inout_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_inout_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_inout_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_inout_qty", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_unitcost", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_cost", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                        };
                                        break;

                                    case "SQLServer":
                                        pDataParametersA = new IDataParameter[]
                                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inout_type", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_inout_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_inout_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_inout_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_inout_qty", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_unitcost", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_cost", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_reference_id", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                        };
                                        break;
                                }
                                pDataParametersA[0].Value = pfrmPOPMain_OUT_COSMETICSEntity.CRUD;
                                pDataParametersA[1].Value = pfrmPOPMain_OUT_COSMETICSEntity.USER_CODE;
                                pDataParametersA[2].Value = "O";// pProductOutRegister_T01Entity.INOUT_TYPE;
                                pDataParametersA[3].Value = "";// pProductOutRegister_T01Entity.INOUT_ID;
                                pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd"); //pProductOutRegister_T01Entity.INOUT_DATE;
                                pDataParametersA[5].Value = pfrmPOPMain_OUT_COSMETICSEntity.INOUT_CODE; //"1001";//수주출고: pProductOutRegister_T01Entity.INOUT_CODE;
                                pDataParametersA[6].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper(); //pProductOutRegister_T01Entity.PART_CODE;
                                pDataParametersA[7].Value = dt.Rows[a]["VEND_CODE"].ToString().ToUpper();// pProductOutRegister_T01Entity.VEND_CODE;
                                pDataParametersA[8].Value = Convert.ToDecimal(dt.Rows[a]["INPUT_QTY"].ToString().ToUpper()); //pProductOutRegister_T01Entity.INOUT_QTY;
                                pDataParametersA[9].Value = Convert.ToDecimal(dt.Rows[a]["UNITCOST"].ToString().ToUpper()); //pProductOutRegister_T01Entity.UNITCOST;
                                pDataParametersA[10].Value = Convert.ToDecimal(dt.Rows[a]["INPUT_QTY"].ToString().ToUpper())* Convert.ToDecimal(dt.Rows[a]["UNITCOST"].ToString().ToUpper());// pProductOutRegister_T01Entity.COST;
                                pDataParametersA[11].Value = dt.Rows[a]["SHIPMENT_ID"].ToString().ToUpper(); // pProductOutRegister_T01Entity.REFERENCE_ID;
                                pDataParametersA[12].Value = "";// pProductOutRegister_T01Entity.REMARK;
                                pDataParametersA[13].Value = "Y";// pProductOutRegister_T01Entity.USE_YN;
                                

                                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_OUT_COSMETICS_I10", pDataParametersA);

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
                                pfrmPOPMain_OUT_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["p_err_no"].ToString();
                                pfrmPOPMain_OUT_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["p_err_msg"].ToString();
                                pfrmPOPMain_OUT_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["p_rtn_key"].ToString();
                                pfrmPOPMain_OUT_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["p_rtn_sq"].ToString();
                                pfrmPOPMain_OUT_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["p_rtn_others"].ToString();

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
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
                    "MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderRegisterEntity_Request, DataTable dt)",
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
        public override frmPOPMain_OUT_COSMETICSEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                frmPOPMain_OUT_COSMETICSEntity pfrmPOPMain_OUT_COSMETICSEntity = new frmPOPMain_OUT_COSMETICSEntity();

                pfrmPOPMain_OUT_COSMETICSEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pfrmPOPMain_OUT_COSMETICSEntity;
            }
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
        public bool frmPOPMain_OUT_COSMETICS_INSPECT_Save(frmPOPMain_OUT_COSMETICSEntity pfrmPOPMain_OUT_COSMETICSEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                    pCount = dt.Rows.Count;

                    //for (int a = 0; a < pCount; a++)
                    // {
                    //체크된것만 저장
                    //  if (dt.Rows[a]["CRUD"].ToString() == "Y")
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
                                            new MySqlParameter("@v_inout_id              ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_part_code             ".Trim(), MySqlDbType.VarChar, 50),


                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_inout_id              ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_part_code             ".Trim(), SqlDbType.VarChar, 50),

                            };
                            break;
                    }
                    pDataParametersA[0].Value = pfrmPOPMain_OUT_COSMETICSEntity.CRUD;
                    pDataParametersA[1].Value = pfrmPOPMain_OUT_COSMETICSEntity.USER_CODE;
                    pDataParametersA[2].Value = pfrmPOPMain_OUT_COSMETICSEntity.INOUT_ID;//t.Rows[a]["INOUT_ID"].ToString().ToUpper();
                    pDataParametersA[3].Value = pfrmPOPMain_OUT_COSMETICSEntity.PART_CODE;//dt.Rows[a]["PART_CODE"].ToString().ToUpper();


                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_OUT_COSMETICS_I20", pDataParametersA);

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    pfrmPOPMain_OUT_COSMETICSEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                    pfrmPOPMain_OUT_COSMETICSEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                    pfrmPOPMain_OUT_COSMETICSEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                    pfrmPOPMain_OUT_COSMETICSEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                    pfrmPOPMain_OUT_COSMETICSEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    // }
                    // }
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
                    "MaterialInRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialInRegisterEntity_Request, DataTable dt)",
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
    }
    public class BarcodeLabelPrinttProvider : EntityManager<frmPOPInfoEntity>
    {
        #region 생성자 - BarcodeLabelPrintProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public BarcodeLabelPrinttProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 터미널 정보 조회하기 -BarcodeLabelPrint_COM_Info(frmPOPInfoEntity pfrmPOPInfoEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pBarcodeLabelPrintEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BarcodeLabelPrint_COM_Info(string p_language_type, string p_terminal_code)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = p_language_type;
                pDataParameters[1].Value = p_terminal_code;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_BarcodeLabelPrint_R30", pDataParameters);

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
                    "BarcodeLabelPrint_COM_Info(frmPOPInfoEntity pfrmPOPInfoEntity)",
                    pException
                );
            }
        }

        #endregion
        #region 바코드 정보 조회하기 -BarcodeLabelPrint_COM_Info(frmPOPInfoEntity pfrmPOPInfoEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pBarcodeLabelPrintEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet BarcodeLabelPrint_Inspect_Info(string p_language_type, string p_Crud, string p_Barcode_no)
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
                            new MySqlParameter("@v_barcode_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_barcode_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = p_Crud;
                pDataParameters[1].Value = p_Barcode_no;
                pDataParameters[2].Value = p_language_type;

                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_BarcodeLabelInfo_R10", pDataParameters);

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
                    "BarcodeLabelPrint_COM_Info(frmPOPInfoEntity pfrmPOPInfoEntity)",
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
        public override frmPOPInfoEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                frmPOPInfoEntity pfrmPOPInfoEntity = new frmPOPInfoEntity();

                //pBarcodeLabelPrintEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pfrmPOPInfoEntity;
            }
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

    public class POPCheckProvider : EntityManager<POPCheckEntity>
    {
        #region 생성자 - POPProductionOrderCommonProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPCheckProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion


        #region 마스터 조회하기 - POPProductionOrderCommon_Info_Mst2(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="_pPOPPCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPCheck_Info_Mst(POPCheckEntity pPOPCheckEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_check_cycle", MySqlDbType.VarChar, 50)

                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_equipment_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_check_cycle", SqlDbType.VarChar, 50)

                         };
                        break;
                }

                pDataParameters[0].Value = pPOPCheckEntity.CRUD;
                pDataParameters[1].Value = pPOPCheckEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pPOPCheckEntity.EQUIPMENT_CODE;
                pDataParameters[3].Value = pPOPCheckEntity.CHECK_CYCLE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_EquipmentCheck_R10", pDataParameters);

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
                    "EquipmentCheck_T01_Info_Mst(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool POPCheck_Save(POPCheckEntity _pPOPCheckEntity, DataTable pDataTable)
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
                            new MySqlParameter("@v_check_date", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_check_cycle", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_check_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_check_result", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_result_data", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_check_item", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_check_cycle_detail", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_check_way", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_sort_num", MySqlDbType.VarChar, 3)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_check_date", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_equipment_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_check_cycle", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_check_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_check_result", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_result_data", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_check_item", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_check_cycle_detail", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_check_way", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_sort_num", SqlDbType.VarChar, 3)
                        };
                        break;
                }

                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {

                    pDataParametersA[0].Value = "";
                    pDataParametersA[1].Value = _pPOPCheckEntity.USER_CODE;
                    pDataParametersA[2].Value = pDataTable.Rows[i]["CHECK_DATE"].ToString();
                    pDataParametersA[3].Value = pDataTable.Rows[i]["equipment_code"].ToString();
                    pDataParametersA[4].Value = pDataTable.Rows[i]["check_cycle"].ToString();
                    pDataParametersA[5].Value = pDataTable.Rows[i]["check_code"].ToString();
                    pDataParametersA[6].Value = pDataTable.Rows[i]["check_result"].ToString();
                    pDataParametersA[7].Value = pDataTable.Rows[i]["result_data"].ToString();
                    pDataParametersA[8].Value = pDataTable.Rows[i]["check_item"].ToString();
                    pDataParametersA[9].Value = pDataTable.Rows[i]["check_cycle_detail"].ToString();
                    pDataParametersA[10].Value = pDataTable.Rows[i]["check_way"].ToString();
                    pDataParametersA[11].Value = pDataTable.Rows[i]["sort_num"].ToString();

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_EquipmentCheck_I10", pDataParametersA);
                    if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    else
                    {
                        _pPOPCheckEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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

      
        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override POPCheckEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPCheckEntity pPOPCheckEntity = new POPCheckEntity();

                pPOPCheckEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPCheckEntity;
            }
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

    public class POPFirstMiddleLastProvider : EntityManager<POPFirstMiddleLastEntity>
    {
        #region 생성자 - POPProductionOrderCommonProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPFirstMiddleLastProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion


        #region 마스터 조회하기 - POPProductionOrderCommon_Info_Mst2(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="_pPOPPCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPFirstMiddleLast_Info_Mst(POPFirstMiddleLastEntity pPOPFirstMiddleLastEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_firstmiddlelast_gubn", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_inspect_date", MySqlDbType.VarChar, 12)

                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_firstmiddlelast_gubn", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_inspect_date", SqlDbType.VarChar, 12)

                         };
                        break;
                }

                pDataParameters[0].Value = pPOPFirstMiddleLastEntity.CRUD;
                pDataParameters[1].Value = pPOPFirstMiddleLastEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pPOPFirstMiddleLastEntity.PRODUCTION_ORDER_ID;
                pDataParameters[3].Value = pPOPFirstMiddleLastEntity.CHECK_CYCLE;
                pDataParameters[4].Value = pPOPFirstMiddleLastEntity.PART_CODE;
                pDataParameters[5].Value = pPOPFirstMiddleLastEntity.COLLECTION_DATE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POPFirstMiddleLast_R10", pDataParameters);

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
                    "EquipmentCheck_T01_Info_Mst(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool POPFirstMiddleLast_Save(POPFirstMiddleLastEntity _pPOPFirstMiddleLastEntity, DataTable pDataTable)
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
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_inspect_item", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_inspect_standard", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_inspect_fixture", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_firstmiddlelast_gubn", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_check_result", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_inspect_date", MySqlDbType.VarChar, 12),
                            new MySqlParameter("@v_result", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_equipment_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_inspect_item", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_inspect_standard", SqlDbType.VarChar, 100),
                            new SqlParameter("@v_inspect_fixture", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_remark", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_firstmiddlelast_gubn", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_check_result", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_inspect_date", SqlDbType.VarChar, 12),
                            new SqlParameter("@v_result", SqlDbType.VarChar, 50)

                        };
                        break;
                }

                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {

                    pDataParametersA[0].Value = "";
                    pDataParametersA[1].Value = _pPOPFirstMiddleLastEntity.USER_CODE;
                    pDataParametersA[2].Value = _pPOPFirstMiddleLastEntity.EQUIPMENT_CODE;
                    pDataParametersA[3].Value = _pPOPFirstMiddleLastEntity.PART_CODE;
                    pDataParametersA[4].Value = pDataTable.Rows[i]["INSPECT_ITEM"].ToString();
                    pDataParametersA[5].Value = pDataTable.Rows[i]["INSPECT_STANDARD"].ToString();
                    pDataParametersA[6].Value = pDataTable.Rows[i]["INSPECT_FIXTURE"].ToString();
                    pDataParametersA[7].Value = pDataTable.Rows[i]["REMARK"].ToString();
                    pDataParametersA[8].Value = pDataTable.Rows[i]["PRODUCTION_ORDER_ID"].ToString();
                    pDataParametersA[9].Value= pDataTable.Rows[i]["FIRSTMIDDLELAST_GUBN"].ToString();
                    pDataParametersA[10].Value = pDataTable.Rows[i]["CHECK_RESULT"].ToString();
                    pDataParametersA[11].Value = _pPOPFirstMiddleLastEntity.COLLECTION_DATE;
                    pDataParametersA[12].Value = pDataTable.Rows[i]["REMARK"].ToString();

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POPFirstMiddleLast_I10", pDataParametersA);
                    if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    else
                    {
                        _pPOPFirstMiddleLastEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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


        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override POPFirstMiddleLastEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPFirstMiddleLastEntity pPOPFirstMiddleLastEntity = new POPFirstMiddleLastEntity();

                pPOPFirstMiddleLastEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPFirstMiddleLastEntity;
            }
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

    public class POPStop_T01Provider : EntityManager<POPCheckEntity>
    {
        #region 생성자 - POPProductionOrderCommonProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPStop_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion


        #region 마스터 조회하기 - POPProductionOrderCommon_Info_Mst2(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="_pPOPPCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POPStop_Info_Mst(POPCheckEntity pPOPCheckEntity)
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
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50)

                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_equipment_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50)

                         };
                        break;
                }

                pDataParameters[0].Value = pPOPCheckEntity.CRUD;
                pDataParameters[1].Value = pPOPCheckEntity.EQUIPMENT_CODE;
                pDataParameters[2].Value = pPOPCheckEntity.USER_CODE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POPStop_T01_R10", pDataParameters);

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
                    "EquipmentCheck_T01_Info_Mst(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)",
                    pException
                );
            }
        }

        #endregion

   

        #region 정보 저장하기 - POPStop_save(POPCheckEntity POPCheckEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPOPProductionOrderCommonEntity"></param>
        /// <returns></returns>
        public bool POPStop_save(POPCheckEntity _pPOPCheckEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
                                   //int pCount = 0;

            try
            {
                IDataParameter[] pDataParametersA = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParametersA = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_stop_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_stop_detail", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_stop_start_date", MySqlDbType.DateTime, 50),
                            new MySqlParameter("@v_stop_end_date", MySqlDbType.DateTime, 50),
                            new MySqlParameter("@v_stop_id", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_equipment_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_stop_mst", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_stop_detail", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_stop_start_date", SqlDbType.DateTime, 50),
                            new SqlParameter("@v_stop_end_date", SqlDbType.DateTime, 50),
                            new SqlParameter("@v_stop_id", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = _pPOPCheckEntity.CRUD;
                pDataParametersA[1].Value = _pPOPCheckEntity.USER_CODE;
                pDataParametersA[2].Value = _pPOPCheckEntity.EQUIPMENT_CODE;
                pDataParametersA[3].Value = _pPOPCheckEntity.STOP_GROUP;
                pDataParametersA[4].Value = _pPOPCheckEntity.STOP_DETAIL;
                pDataParametersA[5].Value = _pPOPCheckEntity.START_DATE;
                pDataParametersA[6].Value = _pPOPCheckEntity.END_DATE;
                pDataParametersA[7].Value = _pPOPCheckEntity.STOP_ID;



                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POPSTOP_T01_I10", pDataParametersA);

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
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
                    "POPProductionOrderCommon_Save(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)",
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
        public override POPCheckEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPCheckEntity pPOPCheckEntity = new POPCheckEntity();

                pPOPCheckEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPCheckEntity;
            }
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

    public class POPEquipmentCheckProvider : EntityManager<POPCheckEntity>
    {
        #region 생성자 - POPProductionOrderCommonProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPEquipmentCheckProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion


        #region 마스터 조회하기 - POPProductionOrderCommon_Info_Mst2(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="_pPOPPCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable USP_equipment_check_mst_R10(POPCheckEntity pPOPCheckEntity, string date)
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
                            new MySqlParameter("@Param_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_date", MySqlDbType.Date)

                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_equipment_code", SqlDbType.NVarChar, 50),

                         };
                        break;
                }

                pDataParameters[0].Value = pPOPCheckEntity.PROCESS_CODE;
                pDataParameters[1].Value = date;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_equipment_check_mst_R10", pDataParameters);

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
                    "EquipmentCheck_T01_Info_Mst(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 마스터 조회하기 - USP_equipment_check_result_I10(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="_pPOPPCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable USP_equipment_check_result_I10(object[] item, string user, string date)
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
                            new MySqlParameter("@Param_date", MySqlDbType.Date),
                            new MySqlParameter("@Param_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_check_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_result", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_remark", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_user", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_seq", MySqlDbType.VarChar, 50)
                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_equipment_code", SqlDbType.NVarChar, 50),

                         };
                        break;
                }

                pDataParameters[0].Value = date;
                pDataParameters[1].Value = item[8];
                pDataParameters[2].Value = item[7];
                pDataParameters[3].Value = item[6];
                pDataParameters[4].Value = item[10];
                pDataParameters[5].Value = user;
                pDataParameters[6].Value = item[9];

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_equipment_check_result_I10", pDataParameters);

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
                    "USP_equipment_check_result_I10(USP_equipment_check_result_I10 USP_equipment_check_result_I10)",
                    pException
                );
            }
        }
        #endregion

        #region 마스터 조회하기 - POPProductionOrderCommon_Info_Mst2(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="_pPOPPCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable USP_equipment_check_mst_R20()
        {

            // 회사코드
            // 단말기번호(옵션)
            try
            {
                IDataParameter[] pDataParameters = null;
                
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_equipment_check_mst_R20", pDataParameters);

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
                    "USP_equipment_check_mst_R20(USP_equipment_check_mst_R20 pEquipmentCheck_T01Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 마스터 조회하기 - POPProductionOrderCommon_Info_Mst2(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="_pPOPPCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable USP_equipment_check_mst_R30()
        {

            // 회사코드
            // 단말기번호(옵션)
            try
            {
                IDataParameter[] pDataParameters = null;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_equipment_check_mst_R30", pDataParameters);

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
                    "USP_equipment_check_mst_R30(USP_equipment_check_mst_R30 pEquipmentCheck_T01Entity)",
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
        public override POPCheckEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPCheckEntity pPOPCheckEntity = new POPCheckEntity();

                pPOPCheckEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOPCheckEntity;
            }
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
    public class POPMAIN_HWTProvider: EntityManager<POP_MAIN_HWTEntity>
    {
        #region 생성자 - POPProductionOrderCommonProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POPMAIN_HWTProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion


        #region 마스터 조회하기 - POPProductionOrderCommon_Info_Mst2(POPProductionOrderCommonEntity pPOPProductionOrderCommonEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="_pPOPPCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable USP_process_mst_hwt_R10(string process, string order_id)
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
                            new MySqlParameter("@Param_process", MySqlDbType.VarChar, 2),
                            new MySqlParameter("@Param_order_id", MySqlDbType.VarChar, 50)

                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_equipment_code", SqlDbType.NVarChar, 50),

                         };
                        break;
                }

                pDataParameters[0].Value = process;
                pDataParameters[1].Value = order_id;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_process_mst_hwt_R10", pDataParameters);

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
                    "EquipmentCheck_T01_Info_Mst(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)",
                    pException
                );
            }
        }
        #endregion
        public DataTable USP_work_state_I10(object[] item, string orderid, string process)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_classification_std", MySqlDbType.VarChar, 5),
                            new MySqlParameter("@Param_classification", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_seq", MySqlDbType.Int32),
                            new MySqlParameter("@Param_work_time", MySqlDbType.Int32),
                            new MySqlParameter("@Param_completeYN", MySqlDbType.VarChar, 2),

                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@Param_equipment_code", SqlDbType.NVarChar, 50),

                         };
                        break;
                }

                pDataParameters[0].Value = orderid; //order id         
                pDataParameters[1].Value = process; //ABB
                pDataParameters[2].Value = item[1].ToString(); //[3]
                pDataParameters[3].Value = item[2].ToString(); //[2]
                pDataParameters[4].Value = item[4].ToString(); //[4] 뒤에 한글자 잘라야함.
                pDataParameters[5].Value = item[5].ToString(); //[5]


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_work_state_I10", pDataParameters);

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
                    "EquipmentCheck_T01_Info_Mst(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)",
                    pException
                );
            }
        }
        public DataTable USP_production_order_R10()
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_classification_std", MySqlDbType.VarChar, 5),
                            new MySqlParameter("@Param_classification", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_seq", MySqlDbType.Int32),
                            new MySqlParameter("@Param_work_time", MySqlDbType.Int32),
                            new MySqlParameter("@Param_completeYN", MySqlDbType.VarChar, 2),

                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_equipment_code", SqlDbType.NVarChar, 50),

                         };
                        break;
                }

                //pDataParameters[0].Value = "orderid"; //order id         
                //pDataParameters[1].Value = "A"; //ABB
                //pDataParameters[2].Value = item[1].ToString(); //[3]
                //pDataParameters[3].Value = item[2].ToString(); //[2]
                //pDataParameters[4].Value = item[4].ToString().Replace("분", ""); //[4] 뒤에 한글자 잘라야함.
                //pDataParameters[5].Value = item[5].ToString(); //[5]


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_production_order_R10", pDataParameters);

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
                    "EquipmentCheck_T01_Info_Mst(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)",
                    pException
                );
            }
        }

        public DataTable USP_production_order_I20(POPWorkResult_T50Entity pPOPWorkResult_T50Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_process", MySqlDbType.VarChar, 2),                        
                            new MySqlParameter("@Param_complete_yn", MySqlDbType.VarChar, 2),

                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_equipment_code", SqlDbType.NVarChar, 50),

                         };
                        break;
                }

                pDataParameters[0].Value = pPOPWorkResult_T50Entity.PRODUCTION_ORDER_ID; //order id         
                pDataParameters[1].Value = pPOPWorkResult_T50Entity.PRODUCTION_ORDER_SEQ; //ABB
                pDataParameters[2].Value = pPOPWorkResult_T50Entity.COMPLETE_YN; //[3]



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_production_order_I20", pDataParameters);

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
                    "EquipmentCheck_T01_Info_Mst(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)",
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
        public override POP_MAIN_HWTEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POP_MAIN_HWTEntity pPOP_MAIN_HWTEntity = new POP_MAIN_HWTEntity();

                pPOP_MAIN_HWTEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pPOP_MAIN_HWTEntity;
            }
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


    public class CreaPOPProvider : EntityManager<CreaPOPEntity>
    {
        #region 생성자 - POPProductionOrderCommonProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public CreaPOPProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion


        #region 작업지시Left 조회하기 - MainPrinterLeft_Search(CreaPOPEntity pCreaPOPEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="_pPOPPCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MainPrinterLeft_Search(CreaPOPEntity pCreaPOPEntity)
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
                            new MySqlParameter("@r_corp_cd", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@r_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@r_emp_no", MySqlDbType.VarChar, 20),
                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@r_corp_cd", SqlDbType.NVarChar, 10),
                            new SqlParameter("@r_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@r_emp_no", SqlDbType.NVarChar, 20),

                         };
                        break;
                }

                pDataParameters[0].Value = pCreaPOPEntity.CORP_CODE;
                pDataParameters[1].Value = pCreaPOPEntity.CRUD;
                pDataParameters[2].Value = pCreaPOPEntity.USER_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmMainPrinter_S01", pDataParameters);

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
                    "EquipmentCheck_T01_Info_Mst(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 작업지시Main 조회하기 - MainPrinterLeft_Search(CreaPOPEntity pCreaPOPEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="_pPOPPCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MainPrinterMain_Search(CreaPOPEntity pCreaPOPEntity)
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
                            new MySqlParameter("@r_corp_cd", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@r_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@r_emp_no", MySqlDbType.VarChar, 20),
                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@r_corp_cd", SqlDbType.NVarChar, 10),
                            new SqlParameter("@r_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@r_emp_no", SqlDbType.NVarChar, 20),

                         };
                        break;
                }

                pDataParameters[0].Value = pCreaPOPEntity.CORP_CODE;
                pDataParameters[1].Value = pCreaPOPEntity.CRUD;
                pDataParameters[2].Value = pCreaPOPEntity.USER_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmMainPrinter_S02", pDataParameters);

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
                    "MainPrinterMain_Search(CreaPOPEntity pCreaPOPEntity)",
                    pException
                );
            }
        }
        #endregion

        #region 작업지시 업데이트 - MainPrinterUpdate(CreaPOPEntity pCreaPOPEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pCreaPOPEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MainPrinterUpdate(CreaPOPEntity pCreaPOPEntity)
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
                            new MySqlParameter("@v_eventdate", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_eventseq", MySqlDbType.VarChar, 4),
                            new MySqlParameter("@v_pono", MySqlDbType.VarChar, 10),
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_eventdate", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_eventseq", SqlDbType.VarChar, 4),
                            new SqlParameter("@v_pono", SqlDbType.VarChar, 10),
                        };
                        break;
                }

                    pDataParametersA[0].Value = pCreaPOPEntity.EVENTDATE;
                    pDataParametersA[1].Value = pCreaPOPEntity.EVENTSEQ;
                    pDataParametersA[2].Value = pCreaPOPEntity.PONO;


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmMainPrinter_U01", pDataParametersA);
                    if (pDataTableA.Rows[0]["err_no"].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    else
                    {
                        pCreaPOPEntity.RTN_KEY = pDataTableA.Rows[0]["err_msg"].ToString();
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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override CreaPOPEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                CreaPOPEntity pCreaPOPEntity = new CreaPOPEntity();

             //   pCreaPOPEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pCreaPOPEntity;
            }
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


    public class frmPOPMain_PRODUCT_BIOCERRAProvider : EntityManager<POPProductionOrderEntity>
    {
        #region ○ 생성자 - frmPOPMain_PRODUCT_BIOCERRAProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmPOPMain_PRODUCT_BIOCERRAProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }


        #endregion

        #region ○ 개체구하기 - GetEntity(pDataRow)

        public override POPProductionOrderEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POPProductionOrderEntity pPOPProductionOrderEntity = new POPProductionOrderEntity();

                pPOPProductionOrderEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pPOPProductionOrderEntity;
            }
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



        #region ○ 데이터 저장 frmPOPMain_PRODUCT_BIOCERRA_Save(POPProductionOrderEntity pPOPProductionOrderEntity)

        public bool frmPOPMain_PRODUCT_BIOCERRA_Save(POPProductionOrderEntity pPOPProductionOrderEntity)
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

                    pDataParameters[0].Value = pPOPProductionOrderEntity.CRUD;
                    pDataParameters[1].Value = pPOPProductionOrderEntity.USER_CODE;
                    pDataParameters[2].Value = pPOPProductionOrderEntity.PRODUCTION_ORDER_ID;
                    pDataParameters[3].Value = pPOPProductionOrderEntity.COMPLETE_YN; 


                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_PRODUCT_BIOCERRA_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pPOPProductionOrderEntity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                        pPOPProductionOrderEntity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                        pPOPProductionOrderEntity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                        pPOPProductionOrderEntity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                        pPOPProductionOrderEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
                    
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;

                throw pExceptionManager;
            }
            finally
            {
                pPOPProductionOrderEntity.PART_CODE = "";
                pPOPProductionOrderEntity.PART_NAME = "";
                pPOPProductionOrderEntity.PROCESS_CODE_MST = "";
                pPOPProductionOrderEntity.PROCESS_CODE = "";
                pPOPProductionOrderEntity.PRODUCTION_ORDER_ID = "";

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
        public bool frmPOPMain_PRODUCT_BIOCERRA_Result_Sub1(POPProductionOrderEntity pPOPProductionOrderEntity)
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
               
                        pDataParametersA[0].Value = pPOPProductionOrderEntity.CRUD;
                        pDataParametersA[1].Value = pPOPProductionOrderEntity.PROCESS_CODE;
                        pDataParametersA[2].Value = pPOPProductionOrderEntity.USER_CODE;
                        pDataParametersA[3].Value = pPOPProductionOrderEntity.COLLECTION_DATE;
                        pDataParametersA[4].Value = pPOPProductionOrderEntity.PRODUCTION_ORDER_ID +"-"+ pPOPProductionOrderEntity.PRODUCTION_SEQ;
                        pDataParametersA[5].Value = pPOPProductionOrderEntity.PRODUCTION_OK_QTY;
                        pDataParametersA[6].Value = pPOPProductionOrderEntity.PART_CODE;
                        pDataParametersA[7].Value = "";
                        // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_PRODUCT_BIOCERRA_I20", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pPOPProductionOrderEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
        public bool frmPOPMain_PRODUCT_BIOCERRA_Result_Sub2(POPProductionOrderEntity pPOPProductionOrderEntity)
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

                        pDataParametersA[0].Value = pPOPProductionOrderEntity.CRUD;  
                        pDataParametersA[1].Value = pPOPProductionOrderEntity.PROCESS_CODE;  
                        pDataParametersA[2].Value = pPOPProductionOrderEntity.USER_CODE; 
                        pDataParametersA[3].Value = pPOPProductionOrderEntity.COLLECTION_DATE; 
                        pDataParametersA[4].Value = pPOPProductionOrderEntity.PRODUCTION_ORDER_ID+"-" + pPOPProductionOrderEntity.PRODUCTION_SEQ; //pPOPProductionOrderEntity.PRODUCTION_ORDER_ID;  
                        pDataParametersA[5].Value = pPOPProductionOrderEntity.BAD_CODE; 
                        pDataParametersA[6].Value = pPOPProductionOrderEntity.PRODUCTION_NG_QTY;  
                        pDataParametersA[7].Value = pPOPProductionOrderEntity.PART_CODE; 
                        pDataParametersA[8].Value = "";
                        // DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                         DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmPOPMain_PRODUCT_BIOCERRA_I30", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pPOPProductionOrderEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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

    public class ucTABSearchProvider : EntityManager<ucTABSearchEntity>
    {
        #region 생성자 - ucTABSearchProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucTABSearchProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 조회하기 ucTABSearch_Info_Return(ucTABSearchEntity pucTABSearchEntity)

        public DataTable ucTABSearch_Info_Return(ucTABSearchEntity pucTABSearchEntity)
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
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar, 8)
                        };
                        break;
                }

                pDataParameters[0].Value = pucTABSearchEntity.CRUD;
                pDataParameters[1].Value = pucTABSearchEntity.DATE_FROM;
                pDataParameters[2].Value = pucTABSearchEntity.DATE_TO;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTABSearch_R10", pDataParameters);

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
                    "ucTABSearch_Info_Return(ucTABSearchEntity pucTABSearchEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucTABSearchEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucTABSearchEntity pucTABSearchEntity = new ucTABSearchEntity();
                pucTABSearchEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucTABSearchEntity;
            }
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

    public class ucTABRegisterProvider : EntityManager<ucTABRegisterEntity>
    {
        #region 생성자 - ucTABRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucTABRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 조회하기 ucTABRegister_Info_Return(ucTABRegisterEntity pucTABRegisterEntity)

        public DataTable ucTABRegister_Info_Return(ucTABRegisterEntity pucTABRegisterEntity)
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
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucTABRegisterEntity.CRUD;
                pDataParameters[1].Value = pucTABRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTABComment_R10", pDataParameters);

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
                    "ucTABRegister_Info_Return(ucTABRegisterEntity pucTABRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 코멘트 갯수 조회하기 ucTABRegister_Comment_Info_Return(ucTABRegisterEntity pucTABRegisterEntity)

        public DataTable ucTABRegister_Comment_Info_Return(ucTABRegisterEntity pucTABRegisterEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucTABRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[1].Value = pucTABRegisterEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pucTABRegisterEntity.DATE_FROM;
                pDataParameters[3].Value = pucTABRegisterEntity.DATE_TO;
                
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTABRegisger_R20", pDataParameters);

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
                    "ucTABRegister_Info_Return(ucTABRegisterEntity pucTABRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ucTABRegister_Info_One_Save(ucTABRegisterEntity pucTABRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ucTABRegister_Info_One_Save(ucTABRegisterEntity pucTABRegisterEntity)
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
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_date_time", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_value", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_comment1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_comment2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_comment3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_date_time", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_value", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_comment1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_comment2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_comment3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_date_from", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_date_to", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucTABRegisterEntity.CRUD;
                pDataParametersA[1].Value = "tablet";
                pDataParametersA[2].Value = pucTABRegisterEntity.RESOURCE_CODE;
                pDataParametersA[3].Value = pucTABRegisterEntity.DATE_TIME;

                if (pucTABRegisterEntity.VALUE == "" || pucTABRegisterEntity.VALUE == null)
                {
                    pDataParametersA[4].Value = "";
                }
                else
                {
                    pDataParametersA[4].Value = pucTABRegisterEntity.VALUE;
                }

                pDataParametersA[5].Value = pucTABRegisterEntity.LANGUAGE_TYPE;

                if (pucTABRegisterEntity.COMMENT1 == "" || pucTABRegisterEntity.COMMENT1 == null)
                {
                    pDataParametersA[6].Value = "";
                }
                else
                {
                    pDataParametersA[6].Value = pucTABRegisterEntity.COMMENT1;
                }

                if (pucTABRegisterEntity.COMMENT2 == "" || pucTABRegisterEntity.COMMENT2 == null)
                {
                    pDataParametersA[7].Value = "";
                }
                else
                {
                    pDataParametersA[7].Value = pucTABRegisterEntity.COMMENT2;
                }

                if (pucTABRegisterEntity.COMMENT3 == "" || pucTABRegisterEntity.COMMENT3 == null)
                {
                    pDataParametersA[8].Value = "";
                }
                else
                {
                    pDataParametersA[8].Value = pucTABRegisterEntity.COMMENT3;
                }

                pDataParametersA[9].Value = pucTABRegisterEntity.DATE_FROM;
                pDataParametersA[10].Value = pucTABRegisterEntity.DATE_TO;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_TabletBasedSensorInfoRegister_I20", pDataParametersA);

                pucTABRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pucTABRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pucTABRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pucTABRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["P_RTN_SEQ"].ToString();
                pucTABRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();

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
                    "ucTABRegister_Info_One_Save(ucTABRegisterEntity pucTABRegisterEntity, DataTable dt)",
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

        #region 엑셀 저장하기 - InputData_Excel_Save(ucTABRegisterEntity _pucTABRegisterEntity, Worksheet sheet_0)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool InputData_Excel_Save(ucTABRegisterEntity _pucTABRegisterEntity, Worksheet sheet_0)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                int num = 0;

                //마스터 저장
                IDataParameter[] pDataParametersA = null;

                Range usedRange = sheet_0.GetUsedRange();

                for (int i = 0; i < usedRange.RowCount; i++)
                {
                    if (sheet_0.GetCellValue(1, i + 1).ToString() != null && sheet_0.GetCellValue(1, i + 1).ToString() != "")
                    {

                        string chk = sheet_0.GetCellValue(3, i + 1).ToString();
                        //num -> 엑셀 시트에 저장된 입력값

                        int chknum = 0;
                        // chknum -> int형 숫자

                        bool isnum = int.TryParse(chk, out chknum);

                        if (isnum)
                        {

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersA = new IDataParameter[]
                                    {
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                    new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_user1", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_user2", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_reg_date_keyin", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000)

                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                    new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_collection_value", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_collection_date", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_user1", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_user2", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_reg_date_keyin", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000)

                                    };
                                    break;
                            }

                            pDataParametersA[0].Value = _pucTABRegisterEntity.USER_CODE;
                            pDataParametersA[1].Value = sheet_0.GetCellValue(1, i + 1).ToString(); // 리소스코드
                            pDataParametersA[2].Value = sheet_0.GetCellValue(3, i + 1).ToString(); // 값
                            pDataParametersA[3].Value = _pucTABRegisterEntity.COLLECTION_DATE;
                            pDataParametersA[4].Value = sheet_0.GetCellValue(4, i + 1).ToString(); // 수기자1
                            pDataParametersA[5].Value = sheet_0.GetCellValue(5, i + 1).ToString(); // 수기자2
                            pDataParametersA[6].Value = sheet_0.GetCellValue(6, i + 1).ToString(); // 수기일
                            pDataParametersA[7].Value = sheet_0.GetCellValue(7, i + 1).ToString(); // 비고

                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTabletBasedSensorInfoPopup_T02_I10", pDataParametersA);

                            _pucTABRegisterEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                            _pucTABRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                            _pucTABRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                            _pucTABRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                            _pucTABRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            num++;
                        }
                    }
                    else
                    {
                        break;
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
                    "InputData_Excel_Save(ucTABRegisterEntity pucTABRegisterEntity)",
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

        public override ucTABRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucTABRegisterEntity pucTABRegisterEntity = new ucTABRegisterEntity();
                pucTABRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucTABRegisterEntity;
            }
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

    public class ucTABExcelProvider : EntityManager<ucTABExcelEntity>
    {
        #region 생성자 - ucTABExcelProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucTABExcelProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(ucTABExcelEntity pucTABExcelEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(ucTABExcelEntity pucTABExcelEntity)
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

                pDataParameters[0].Value = pucTABExcelEntity.CRUD;
                pDataParameters[1].Value = pucTABExcelEntity.WINDOW_NAME;
                pDataParameters[2].Value = pucTABExcelEntity.LANGUAGE_TYPE;

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

        #region 엑셀 시트 저장하기 - ucTABExcel_Save(ucTABExcelEntity _pucTABExcelEntity, Worksheet sheet_0)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ucTABExcel_Save(ucTABExcelEntity _pucTABExcelEntity, Worksheet sheet_0)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                int num = 0;

                //마스터 저장
                IDataParameter[] pDataParametersA = null;

                Range usedRange = sheet_0.GetUsedRange();

                for (int i = 0; i < usedRange.RowCount; i++)
                {
                    if (sheet_0.GetCellValue(1, i + 1).ToString() != null && sheet_0.GetCellValue(1, i + 1).ToString() != "")
                    {

                        string chk = sheet_0.GetCellValue(3, i + 1).ToString();
                        //num -> 엑셀 시트에 저장된 입력값

                        int chknum = 0;
                        // chknum -> int형 숫자

                        bool isnum = int.TryParse(chk, out chknum);

                        if (isnum)
                        {

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersA = new IDataParameter[]
                                    {
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                    new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_user1", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_user2", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_reg_date_keyin", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000)

                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                    new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_collection_value", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_collection_date", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_user1", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_user2", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_reg_date_keyin", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000)

                                    };
                                    break;
                            }

                            pDataParametersA[0].Value = _pucTABExcelEntity.USER_CODE;
                            pDataParametersA[1].Value = sheet_0.GetCellValue(1, i + 1).ToString(); // 리소스코드
                            pDataParametersA[2].Value = sheet_0.GetCellValue(3, i + 1).ToString(); // 값
                            pDataParametersA[3].Value = _pucTABExcelEntity.COLLECTION_DATE;
                            pDataParametersA[4].Value = sheet_0.GetCellValue(4, i + 1).ToString(); // 수기자1
                            pDataParametersA[5].Value = sheet_0.GetCellValue(5, i + 1).ToString(); // 수기자2
                            pDataParametersA[6].Value = sheet_0.GetCellValue(6, i + 1).ToString(); // 수기일
                            pDataParametersA[7].Value = sheet_0.GetCellValue(7, i + 1).ToString(); // 비고

                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTabletBasedSensorInfoPopup_T02_I10", pDataParametersA);

                            _pucTABExcelEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                            _pucTABExcelEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                            _pucTABExcelEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                            _pucTABExcelEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                            _pucTABExcelEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            num++;
                        }
                    }
                    else
                    {
                        break;
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
                    "ucTABExcel_Save(ucTABExcelEntity pucTABExcelEntity, ucTABExcelEntity)",
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
        public override ucTABExcelEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucTABExcelEntity pucTABExcelEntity = new ucTABExcelEntity();

                pucTABExcelEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucTABExcelEntity;
            }
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

    public class ucTABCommentProvider : EntityManager<ucTABCommentEntity>
    {
        #region 생성자 - ucTABCommentProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucTABCommentProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 조회하기 ucTABComment_Info_Return(ucTABCommentEntity pucTABCommentEntity)

        public DataTable ucTABComment_Info_Return(ucTABCommentEntity pucTABCommentEntity)
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
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucTABCommentEntity.CRUD;
                pDataParameters[1].Value = pucTABCommentEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTABComment_R10", pDataParameters);
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
                    "ucTABComment_Info_Return(ucTABCommentEntity pucTABCommentEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ucTABComment_Info_Save(ucTABCommentEntity pucTABCommentEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ucTABComment_Info_Save(ucTABCommentEntity pucTABCommentEntity)
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
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_com_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_com_data", MySqlDbType.VarChar, 1000),
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_com_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_com_data", SqlDbType.VarChar, 1000),
                        };
                        break;
                }

                pDataParametersA[0].Value = pucTABCommentEntity.CRUD;
                pDataParametersA[1].Value = pucTABCommentEntity.LANGUAGE_TYPE;
                pDataParametersA[2].Value = pucTABCommentEntity.COOMMENT_ID;
                pDataParametersA[3].Value = pucTABCommentEntity.COOMMENT_DATA;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTABComment_I10", pDataParametersA);

                pucTABCommentEntity.ERR_NO = pDataTableA.Rows[0]["p_err_no"].ToString();
                pucTABCommentEntity.ERR_MSG = pDataTableA.Rows[0]["p_err_msg"].ToString();
                pucTABCommentEntity.RTN_KEY = pDataTableA.Rows[0]["p_rtn_key"].ToString();
                pucTABCommentEntity.RTN_SEQ = pDataTableA.Rows[0]["p_rtn_seq"].ToString();
                pucTABCommentEntity.RTN_AQ = pDataTableA.Rows[0]["p_rtn_aq"].ToString();
                pucTABCommentEntity.RTN_SQ = pDataTableA.Rows[0]["p_rtn_sq"].ToString();
                pucTABCommentEntity.RTN_OTHERS = pDataTableA.Rows[0]["p_rtn_others"].ToString();

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

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucTABCommentEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucTABCommentEntity pucTABCommentEntity = new ucTABCommentEntity();
                pucTABCommentEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucTABCommentEntity;
            }
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

    public class ucTABLobbyProvider : EntityManager<ucTABLobbyEntity>
    {
        #region 생성자 - ucTABLobbyProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucTABLobbyProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 조회하기 ucTABLobby_Info_Return(ucTABLobbyEntity pucTABLobbyEntity)

        public DataTable ucTABLobby_Info_Return(ucTABLobbyEntity pucTABLobbyEntity)
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
                            new MySqlParameter("@v_contract_number", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_contract_date_from", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_contract_date_to", MySqlDbType.VarChar, 8)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_contract_number", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_contract_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_contract_date_to", SqlDbType.NVarChar, 8)
                        };
                        break;
                }

                pDataParameters[0].Value = pucTABLobbyEntity.CRUD;
                pDataParameters[1].Value = pucTABLobbyEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pucTABLobbyEntity.CONTRACT_NUMBER;
                pDataParameters[3].Value = pucTABLobbyEntity.CONTRACT_DATE_FROM;
                pDataParameters[4].Value = pucTABLobbyEntity.CONTRACT_DATE_TO;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTABLobby_R10", pDataParameters);
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
                    "ucTABLobby_Info_Return(ucTABLobbyEntity pucTABLobbyEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucTABLobbyEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucTABLobbyEntity pucTABLobbyEntity = new ucTABLobbyEntity();
                pucTABLobbyEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucTABLobbyEntity;
            }
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

    public class ucTABEquipmentProvider : EntityManager<ucTABEquipmentEntity>
    {
        #region 생성자 - ucTABEquipmentProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucTABEquipmentProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 조회하기 ucTABEquipment_Info_Return(ucTABEquipmentEntity pucTABEquipmentEntity)

        public DataTable ucTABEquipment_Info_Return(ucTABEquipmentEntity pucTABEquipmentEntity)
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
                            new MySqlParameter("@v_day", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_equipment_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_day", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucTABEquipmentEntity.EQUIPMENT_CODE;
                pDataParameters[1].Value = pucTABEquipmentEntity.DAY;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTABEquipment_R10", pDataParameters);

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
                    "ucTABEquipment_Info_Return(ucTABEquipmentEntity pucTABEquipmentEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 코멘트 갯수 조회하기 ucTABEquipment_Comment_Info_Return(ucTABEquipmentEntity pucTABEquipmentEntity)

        public DataTable ucTABEquipment_Comment_Info_Return(ucTABEquipmentEntity pucTABEquipmentEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucTABEquipmentEntity.LANGUAGE_TYPE;
                pDataParameters[1].Value = pucTABEquipmentEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pucTABEquipmentEntity.DATE_FROM;
                pDataParameters[3].Value = pucTABEquipmentEntity.DATE_TO;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTABRegisger_R20", pDataParameters);

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
                    "ucTABEquipment_Info_Return(ucTABEquipmentEntity pucTABEquipmentEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ucTABEquipment_Info_Inspect_Save(ucTABEquipmentEntity pucTABEquipmentEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ucTABEquipment_Info_Inspect_Save(ucTABEquipmentEntity pucTABEquipmentEntity)
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
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_equipment", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_attribute", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_day", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_value", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_equipment", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_attribute", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_day", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_value", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucTABEquipmentEntity.CRUD;
                pDataParametersA[1].Value = "tablet";
                pDataParametersA[2].Value = pucTABEquipmentEntity.INSPECT_ID;
                pDataParametersA[3].Value = pucTABEquipmentEntity.EQUIPMENT_CODE;
                pDataParametersA[4].Value = pucTABEquipmentEntity.ATTRIBUTE;
                pDataParametersA[5].Value = pucTABEquipmentEntity.DAY;
                pDataParametersA[6].Value = pucTABEquipmentEntity.VALUE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTABEquipment_I10", pDataParametersA);

                pucTABEquipmentEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pucTABEquipmentEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pucTABEquipmentEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pucTABEquipmentEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pucTABEquipmentEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
                    "ucTABEquipment_Info_Inspect_Save(ucTABEquipmentEntity pucTABEquipmentEntity, DataTable dt)",
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

        #region 엑셀 저장하기 - InputData_Excel_Save(ucTABEquipmentEntity _pucTABEquipmentEntity, Worksheet sheet_0)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool InputData_Excel_Save(ucTABEquipmentEntity _pucTABEquipmentEntity, Worksheet sheet_0)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                int num = 0;

                //마스터 저장
                IDataParameter[] pDataParametersA = null;

                Range usedRange = sheet_0.GetUsedRange();

                for (int i = 0; i < usedRange.RowCount; i++)
                {
                    if (sheet_0.GetCellValue(1, i + 1).ToString() != null && sheet_0.GetCellValue(1, i + 1).ToString() != "")
                    {

                        string chk = sheet_0.GetCellValue(3, i + 1).ToString();
                        //num -> 엑셀 시트에 저장된 입력값

                        int chknum = 0;
                        // chknum -> int형 숫자

                        bool isnum = int.TryParse(chk, out chknum);

                        if (isnum)
                        {

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersA = new IDataParameter[]
                                    {
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                    new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_collection_value", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_collection_date", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_user1", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_user2", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_reg_date_keyin", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000)

                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                    new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_collection_value", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_collection_date", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_user1", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_user2", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_reg_date_keyin", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000)

                                    };
                                    break;
                            }

                            pDataParametersA[0].Value = _pucTABEquipmentEntity.USER_CODE;
                            pDataParametersA[1].Value = sheet_0.GetCellValue(1, i + 1).ToString(); // 리소스코드
                            pDataParametersA[2].Value = sheet_0.GetCellValue(3, i + 1).ToString(); // 값
                            pDataParametersA[3].Value = _pucTABEquipmentEntity.COLLECTION_DATE;
                            pDataParametersA[4].Value = sheet_0.GetCellValue(4, i + 1).ToString(); // 수기자1
                            pDataParametersA[5].Value = sheet_0.GetCellValue(5, i + 1).ToString(); // 수기자2
                            pDataParametersA[6].Value = sheet_0.GetCellValue(6, i + 1).ToString(); // 수기일
                            pDataParametersA[7].Value = sheet_0.GetCellValue(7, i + 1).ToString(); // 비고

                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTabletBasedSensorInfoPopup_T02_I10", pDataParametersA);

                            _pucTABEquipmentEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                            _pucTABEquipmentEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                            _pucTABEquipmentEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                            _pucTABEquipmentEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                            _pucTABEquipmentEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            num++;
                        }
                    }
                    else
                    {
                        break;
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
                    "InputData_Excel_Save(ucTABEquipmentEntity pucTABEquipmentEntity)",
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

        public override ucTABEquipmentEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucTABEquipmentEntity pucTABEquipmentEntity = new ucTABEquipmentEntity();
                pucTABEquipmentEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucTABEquipmentEntity;
            }
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
