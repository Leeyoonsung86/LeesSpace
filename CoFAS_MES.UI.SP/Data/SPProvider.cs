using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

using CoFAS_MES.UI.SP.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;

namespace CoFAS_MES.UI.SP.Data
{
    public class ShipmentPlanRegisterProvider : EntityManager<ShipmentPlanRegisterEntity>
    {
        #region 생성자 - ShipmentPlanRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ShipmentPlanRegisterProvider(DBManager pDBManager)
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
        public DataTable Sample_Info_Mst(ShipmentPlanRegisterEntity pShipmentPlanRegisterEntity)
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

                pDataParameters[0].Value = pShipmentPlanRegisterEntity.CRUD;



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
        public bool Sample_Info_Save(ShipmentPlanRegisterEntity pShipmentPlanRegisterEntity, DataTable dt)
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

                pDataParametersA[0].Value = pShipmentPlanRegisterEntity.CORP_CODE;
                pDataParametersA[1].Value = pShipmentPlanRegisterEntity.CRUD;
                pDataParametersA[2].Value = pShipmentPlanRegisterEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SampleRegister_I10", pDataParametersA);

                pShipmentPlanRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pShipmentPlanRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pShipmentPlanRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pShipmentPlanRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pShipmentPlanRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                            pDataParametersB[0].Value = pShipmentPlanRegisterEntity.CORP_CODE;
                            pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[2].Value = pShipmentPlanRegisterEntity.USER_CODE;

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pShipmentPlanRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pShipmentPlanRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pShipmentPlanRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pShipmentPlanRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pShipmentPlanRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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

            return pErrorYN;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ShipmentPlanRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ShipmentPlanRegisterEntity pShipmentPlanRegisterEntity = new ShipmentPlanRegisterEntity();

                pShipmentPlanRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pShipmentPlanRegisterEntity;
            }
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

    public class ShipmentRegisterProvider : EntityManager<ShipmentRegisterEntity>
    {
        #region ○ 생성자

        public ShipmentRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        public override ShipmentRegisterEntity GetEntity(DataRow pDataRow)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ○ 출하지시정보 조회

        public DataTable ShipmentRegister_Info_Mst(ShipmentRegisterEntity pShipmentRegisterEntity)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pShipmentRegisterEntity.CRUD;
                pDataParameters[1].Value = pShipmentRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pShipmentRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pShipmentRegisterEntity.PART_CODE;
                pDataParameters[4].Value = pShipmentRegisterEntity.PART_NAME;
                pDataParameters[5].Value = pShipmentRegisterEntity.VEND_CODE;
                pDataParameters[6].Value = pShipmentRegisterEntity.VEND_NAME;
                pDataParameters[7].Value = pShipmentRegisterEntity.USE_YN;
                pDataParameters[8].Value = pShipmentRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ShipmentRegister_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ShipmentRegister_Info_Mst(ShipmentRegisterEntity pShipmentRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 출하지시정보 저장

        public bool ShipmentRegister_Info_Save(ShipmentRegisterEntity pShipmentRegisterEntity)
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
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_shipment_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_shipment_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_shipment_seq", MySqlDbType.Int32),
                                new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_shipment_order_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_shipment_state", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 2000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_shipment_id", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_shipment_date", SqlDbType.VarChar, 8),
                                new SqlParameter("@v_shipment_seq", SqlDbType.Int),
                                new SqlParameter("@v_vend_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_shipment_order_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_shipment_state", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_reference_id", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 2000),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pShipmentRegisterEntity.CRUD;
                pDataParametersA[1].Value = pShipmentRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pShipmentRegisterEntity.SHIPMENT_ID;
                pDataParametersA[3].Value = pShipmentRegisterEntity.SHIPMENT_DATE;
                pDataParametersA[4].Value = pShipmentRegisterEntity.SHIPMENT_SEQ;
                pDataParametersA[5].Value = pShipmentRegisterEntity.VEND_CODE;
                pDataParametersA[6].Value = pShipmentRegisterEntity.PART_CODE;
                pDataParametersA[7].Value = pShipmentRegisterEntity.SHIPMENT_ORDER_QTY;
                pDataParametersA[8].Value = pShipmentRegisterEntity.SHIPMENT_STATE;
                pDataParametersA[9].Value = pShipmentRegisterEntity.REFERENCE_ID;
                pDataParametersA[10].Value = pShipmentRegisterEntity.REMARK;
                pDataParametersA[11].Value = pShipmentRegisterEntity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ShipmentRegister_I10", pDataParametersA);

                pShipmentRegisterEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                pShipmentRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                pShipmentRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                pShipmentRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                pShipmentRegisterEntity.RTN_AQ = pDataTableA.Rows[0]["rtn_aq"].ToString();
                pShipmentRegisterEntity.RTN_SQ = pDataTableA.Rows[0]["rtn_sq"].ToString();
                pShipmentRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

    public class ShipmentBaseRegister_T50Provider : EntityManager<ShipmentBaseRegister_T50Entity>
    {
        #region ○ 생성자

        public ShipmentBaseRegister_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        public override ShipmentBaseRegister_T50Entity GetEntity(DataRow pDataRow)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ○ 출하지시정보 조회

        public DataTable ShipmentBaseRegister_T50_Info_Mst(ShipmentBaseRegister_T50Entity pShipmentBaseRegister_T50Entity)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_tracking_no", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pShipmentBaseRegister_T50Entity.CRUD;
                pDataParameters[1].Value = pShipmentBaseRegister_T50Entity.DATE_FROM;
                pDataParameters[2].Value = pShipmentBaseRegister_T50Entity.DATE_TO;
                pDataParameters[3].Value = pShipmentBaseRegister_T50Entity.PART_CODE;
                pDataParameters[4].Value = pShipmentBaseRegister_T50Entity.PART_NAME;
                pDataParameters[5].Value = pShipmentBaseRegister_T50Entity.VEND_NAME;
                pDataParameters[6].Value = pShipmentBaseRegister_T50Entity.TRACKING_NO;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ShipmentBaseRegister_T50_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ShipmentBaseRegister_T50_Info_Mst(ShipmentBaseRegister_T50Entity pShipmentBaseRegister_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 출하지시정보 저장

        public bool ShipmentBaseRegister_T50_Info_Save(ShipmentBaseRegister_T50Entity pShipmentBaseRegister_T50Entity)
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
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_shipment_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_shipment_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_shipment_seq", MySqlDbType.Int32),
                                new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_shipment_order_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_shipment_state", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 2000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_shipment_id", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_shipment_date", SqlDbType.VarChar, 8),
                                new SqlParameter("@v_shipment_seq", SqlDbType.Int),
                                new SqlParameter("@v_vend_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_shipment_order_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_shipment_state", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_reference_id", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 2000),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pShipmentBaseRegister_T50Entity.CRUD;
                pDataParametersA[1].Value = pShipmentBaseRegister_T50Entity.USER_CODE;
                pDataParametersA[2].Value = pShipmentBaseRegister_T50Entity.SHIPMENT_ID;
                pDataParametersA[3].Value = pShipmentBaseRegister_T50Entity.SHIPMENT_DATE;
                pDataParametersA[4].Value = pShipmentBaseRegister_T50Entity.SHIPMENT_SEQ;
                pDataParametersA[5].Value = pShipmentBaseRegister_T50Entity.VEND_CODE;
                pDataParametersA[6].Value = pShipmentBaseRegister_T50Entity.PART_CODE;
                pDataParametersA[7].Value = pShipmentBaseRegister_T50Entity.SHIPMENT_ORDER_QTY;
                pDataParametersA[8].Value = pShipmentBaseRegister_T50Entity.SHIPMENT_STATE;
                pDataParametersA[9].Value = pShipmentBaseRegister_T50Entity.REFERENCE_ID;
                pDataParametersA[10].Value = pShipmentBaseRegister_T50Entity.REMARK;
                pDataParametersA[11].Value = pShipmentBaseRegister_T50Entity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ShipmentBaseRegister_T50_I10", pDataParametersA);

                pShipmentBaseRegister_T50Entity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                pShipmentBaseRegister_T50Entity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                pShipmentBaseRegister_T50Entity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                pShipmentBaseRegister_T50Entity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                pShipmentBaseRegister_T50Entity.RTN_AQ = pDataTableA.Rows[0]["rtn_aq"].ToString();
                pShipmentBaseRegister_T50Entity.RTN_SQ = pDataTableA.Rows[0]["rtn_sq"].ToString();
                pShipmentBaseRegister_T50Entity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

    public class ShipmentRegister_T01Provider : EntityManager<ShipmentRegister_T01Entity>
    {
        #region ○ 생성자

        public ShipmentRegister_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        public override ShipmentRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ○ 출하지시정보 조회

        public DataTable ShipmentRegister_T01_Info_Mst(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)
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
                            new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 8), //PONO
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 100),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pShipmentRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pShipmentRegister_T01Entity.CONTRACT_ID;
                pDataParameters[2].Value = pShipmentRegister_T01Entity.PART_CODE;
                pDataParameters[3].Value = pShipmentRegister_T01Entity.PART_NAME;
                pDataParameters[4].Value = pShipmentRegister_T01Entity.VEND_NAME;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ShipmentRegister_T01_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ShipmentRegister_T01_Info_Mst(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 출하재고정보 조회

        public DataTable ShipmentRegister_T01_Info_Sub(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 100),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pShipmentRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pShipmentRegister_T01Entity.PART_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ShipmentRegister_T01_R11", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ShipmentRegister_T01_Info_Mst(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 출하재고정보 조회

        public DataTable ShipmentRegister_T01_Info_Bot(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)
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
                            new MySqlParameter("@v_pono", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 100)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pShipmentRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pShipmentRegister_T01Entity.CONTRACT_ID;
                pDataParameters[2].Value = pShipmentRegister_T01Entity.PART_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ShipmentRegister_T01_R12", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ShipmentRegister_T01_Info_Mst(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 출하지시정보 저장

        public bool ShipmentRegister_T01_Info_Save(ShipmentRegister_T01Entity pShipmentRegister_T01Entity, DataTable dt)
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
                            if (Convert.ToDecimal(dt.Rows[a]["OUT_QTY"].ToString()) > 0)
                            {
                                //마스터 저장
                                IDataParameter[] pDataParametersA = null;

                                switch (_pDBManager.DBManagerType.ToString())
                                {
                                    case "MySql":
                                        pDataParametersA = new IDataParameter[]
                                        {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_pono", MySqlDbType.VarChar, 20),
                                        new MySqlParameter("@v_lot_no", MySqlDbType.VarChar, 20),
                                        new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 100),
                                        new MySqlParameter("@v_out_qty", MySqlDbType.Decimal),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_invst_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_indate", MySqlDbType.VarChar, 50)

                                        };
                                        break;

                                    case "SQLServer":
                                        pDataParametersA = new IDataParameter[]
                                        {
                                         new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                         new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                         new SqlParameter("@v_shipment_id", SqlDbType.VarChar, 15),
                                        };
                                        break;
                                }

                                pDataParametersA[0].Value = pShipmentRegister_T01Entity.CRUD;
                                pDataParametersA[1].Value = pShipmentRegister_T01Entity.CONTRACT_ID;
                                pDataParametersA[2].Value = dt.Rows[a]["LOT_NO"].ToString(); //pShipmentRegister_T01Entity.LOT_NO;
                                pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString();//pShipmentRegister_T01Entity.PART_CODE;
                                pDataParametersA[4].Value = dt.Rows[a]["OUT_QTY"].ToString();
                                pDataParametersA[5].Value = pShipmentRegister_T01Entity.USER_CODE;
                                pDataParametersA[6].Value = pShipmentRegister_T01Entity.INVSTCD;
                                pDataParametersA[7].Value = pShipmentRegister_T01Entity.VEND_NAME;
                                pDataParametersA[8].Value = pShipmentRegister_T01Entity.INDATE;

                                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ShipmentRegister_T01_I10", pDataParametersA);



                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }

                                pShipmentRegister_T01Entity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                                pShipmentRegister_T01Entity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                                pShipmentRegister_T01Entity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                                pShipmentRegister_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                                pShipmentRegister_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

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
                    _pDBManager.RollbackTransaction();  // 저장 실패 Rollback Transaction 
                else
                    _pDBManager.CommitTransaction();  // 저장 성공  Commit Transaction
            }
            return pErrorYN;
        }

        #endregion
    }

    public class ucShipmentRegisterInfoPopupProvider : EntityManager<ucShipmentRegisterInfoPopupEntity>
    {
        #region ○ 생성자

        public ucShipmentRegisterInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        public override ucShipmentRegisterInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ○ 수주정보조회

        public DataTable ucShipmentRegisterInfoPopup_Info_Mst(ucShipmentRegisterInfoPopupEntity pucShipmentRegisterInfoPopupEntity)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100)
                        };
                        break;
                }

                pDataParameters[0].Value = pucShipmentRegisterInfoPopupEntity.CRUD;
                pDataParameters[1].Value = pucShipmentRegisterInfoPopupEntity.DATE_FROM;
                pDataParameters[2].Value = pucShipmentRegisterInfoPopupEntity.DATE_TO;
                pDataParameters[3].Value = pucShipmentRegisterInfoPopupEntity.PART_NAME;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucShipmentRegisterInfoPopup_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucShipmentRegisterInfoPopup_Info_Mst(ucShipmentRegisterInfoPopupEntity pucShipmentRegisterInfoPopupEntity)",
                    pException
                );
            }
        }

        #endregion
    }

    public class ucShipmentRegisterInfoPopup_T01Provider : EntityManager<ucShipmentRegisterInfoPopup_T01Entity>
    {
        #region ○ 생성자

        public ucShipmentRegisterInfoPopup_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        public override ucShipmentRegisterInfoPopup_T01Entity GetEntity(DataRow pDataRow)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ○ 수주정보조회

        public DataTable ucShipmentRegisterInfoPopup_T01_Info_Mst(ucShipmentRegisterInfoPopup_T01Entity pucShipmentRegisterInfoPopup_T01Entity)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100)
                        };
                        break;
                }

                pDataParameters[0].Value = pucShipmentRegisterInfoPopup_T01Entity.CRUD;
                pDataParameters[1].Value = pucShipmentRegisterInfoPopup_T01Entity.DATE_FROM;
                pDataParameters[2].Value = pucShipmentRegisterInfoPopup_T01Entity.DATE_TO;
                pDataParameters[3].Value = pucShipmentRegisterInfoPopup_T01Entity.PART_NAME;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucShipmentRegisterInfoPopup_T01_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucShipmentRegisterInfoPopup_T01_Info_Mst(ucShipmentRegisterInfoPopup_T01Entity pucShipmentRegisterInfoPopup_T01Entity)",
                    pException
                );
            }
        }

        #endregion
    }

    public class ProductOutRegister_T01Provider : EntityManager<ProductOutRegister_T01Entity>
    {
        #region 생성자 - ProductOutRegister_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductOutRegister_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 바인딩 데이터 테이블 불러오기 - Sheet_Info_Sheet_Data(SheetInfoRegisterEntity pSheetInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet Sheet_Info_Sheet_Data(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_inout_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_user_name", MySqlDbType.VarChar, 50),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_inout_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_user_name", SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pProductOutRegister_T01Entity.VEND_CODE;
                pDataParameters[1].Value = pProductOutRegister_T01Entity.INOUT_ID;
                pDataParameters[2].Value = pProductOutRegister_T01Entity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pProductOutRegister_T01Entity.USER_NAME;


                DataSet pDataTable = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_SheetInfoRegister_R50", pDataParameters);

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
                    "Sheet_Info_Sheet_Data(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_Request)",
                    pException
                );
            }
        }
        #endregion
        //#region 마스터 조회하기 - Sample_Info_Mst(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)

        ///// <summary>
        ///// 조회하기
        ///// </summary>
        ///// <param name="pProductOutRegister_T01Entity">엔티티 정보</param>
        ///// <returns>조회 목록</returns>
        //public DataTable Sample_Info_Mst(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
        //{
        //    try
        //    {
        //        IDataParameter[] pDataParameters = null;

        //        switch (_pDBManager.DBManagerType.ToString())
        //        {
        //            case "MySql":
        //                pDataParameters = new IDataParameter[]
        //                {
        //                    new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
        //                    new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
        //                    new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
        //                    new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
        //                    new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
        //                    new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50)
        //                };
        //                break;

        //            case "SQLServer":
        //                pDataParameters = new IDataParameter[]
        //                {
        //                    new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
        //                    new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
        //                    new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
        //                    new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
        //                    new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
        //                    new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 50)
        //                };
        //                break;
        //        }

        //        pDataParameters[0].Value = pProductOutRegister_T01Entity.CRUD;
        //        pDataParameters[1].Value = pProductOutRegister_T01Entity.DATE_FROM;
        //        pDataParameters[2].Value = pProductOutRegister_T01Entity.DATE_TO;
        //        pDataParameters[3].Value = pProductOutRegister_T01Entity.PART_CODE;
        //        pDataParameters[4].Value = pProductOutRegister_T01Entity.PART_NAME;
        //        pDataParameters[5].Value = pProductOutRegister_T01Entity.VEND_NAME;


        //        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductOutRegister_T01_R10", pDataParameters);

        //        //if (pDataTable != null)
        //        //{
        //        //    GetEntity(pDataTable.Rows[0]);
        //        //}

        //        return pDataTable;
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager
        //        (
        //            this,
        //            "Sample_Info_Mst(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)",
        //            pException
        //        );
        //    }
        //}

        //#endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(SheetInfoRegisterEntity pSheetInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
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

                pDataParameters[0].Value = pProductOutRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pProductOutRegister_T01Entity.WINDOW_NAME;
                pDataParameters[2].Value = pProductOutRegister_T01Entity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - ProductOutRegister_T01_Info_Mst(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductOutRegister_T01Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProductOutRegister_T01_Info_Mst(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
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
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_inout_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_inout_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



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
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_reference_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_inout_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_inout_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductOutRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pProductOutRegister_T01Entity.DATE_FROM;
                pDataParameters[2].Value = pProductOutRegister_T01Entity.DATE_TO;
                pDataParameters[3].Value = pProductOutRegister_T01Entity.PART_CODE;
                pDataParameters[4].Value = pProductOutRegister_T01Entity.PART_NAME;
                pDataParameters[5].Value = pProductOutRegister_T01Entity.VEND_NAME;
                pDataParameters[6].Value = pProductOutRegister_T01Entity.REFERENCE_ID;
                pDataParameters[7].Value = pProductOutRegister_T01Entity.INOUT_ID;
                pDataParameters[8].Value = pProductOutRegister_T01Entity.INOUT_CODE;
                pDataParameters[9].Value = pProductOutRegister_T01Entity.USE_YN;
                pDataParameters[10].Value = pProductOutRegister_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductOutRegister_T01_R10", pDataParameters);

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
                    "MaterialOutRegister_Info_Mst(MaterialOutRegisterEntity pMaterialOutRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ProductOutRegister_T01_Info_Save(ProductOutRegister_T01Entity pMaterialOrderStatusEntity, DataTable dt)       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ProductOutRegister_T01_Info_Save(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
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

                pDataParametersA[0].Value = pProductOutRegister_T01Entity.CRUD;
                pDataParametersA[1].Value = pProductOutRegister_T01Entity.USER_CODE;
                pDataParametersA[2].Value = pProductOutRegister_T01Entity.INOUT_TYPE;
                pDataParametersA[3].Value = pProductOutRegister_T01Entity.INOUT_ID;
                pDataParametersA[4].Value = pProductOutRegister_T01Entity.INOUT_DATE;
                pDataParametersA[5].Value = pProductOutRegister_T01Entity.INOUT_CODE;
                pDataParametersA[6].Value = pProductOutRegister_T01Entity.PART_CODE;
                pDataParametersA[7].Value = pProductOutRegister_T01Entity.VEND_CODE;
                pDataParametersA[8].Value = pProductOutRegister_T01Entity.INOUT_QTY;
                pDataParametersA[9].Value = pProductOutRegister_T01Entity.UNITCOST;
                pDataParametersA[10].Value = pProductOutRegister_T01Entity.COST;
                pDataParametersA[11].Value = pProductOutRegister_T01Entity.REFERENCE_ID;
                pDataParametersA[12].Value = pProductOutRegister_T01Entity.REMARK;
                pDataParametersA[13].Value = pProductOutRegister_T01Entity.USE_YN;

                 DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductOutRegister_T01_I10", pDataParametersA);

                pProductOutRegister_T01Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pProductOutRegister_T01Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pProductOutRegister_T01Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pProductOutRegister_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "ProductOutRegister_T01_Info_Save(ProductOutRegister_T01Entity pProductOutRegister_T01Entity, DataTable dt)",
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

        //#region 정보 저장하기 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="pGridInfoRegisterEntity"></param>
        ///// <param name="dt"></param>
        ///// <returns></returns>
        //public DataTable ProductOutRegister_T01_Info_Save(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
        //{
        //    bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
        //    int pCount = 0;
        //    DataTable pDataTableA;
        //    try
        //    {
        //        //마스터 저장
        //        IDataParameter[] pDataParametersA = null;

        //        switch (_pDBManager.DBManagerType.ToString())
        //        {
        //            case "MySql":
        //                pDataParametersA = new IDataParameter[]
        //                {
        //                        new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
        //                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
        //                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
        //                        new MySqlParameter("@v_inout_type", MySqlDbType.VarChar, 1),
        //                        new MySqlParameter("@v_inout_id", MySqlDbType.VarChar, 15),
        //                        new MySqlParameter("@v_inout_date", MySqlDbType.VarChar, 8),
        //                        new MySqlParameter("@v_inout_seq", MySqlDbType.Int32),
        //                        new MySqlParameter("@v_inout_code", MySqlDbType.VarChar, 50),
        //                        new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
        //                        new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 20),
        //                        new MySqlParameter("@v_inout_qty", MySqlDbType.Decimal),
        //                        new MySqlParameter("@v_unitcost", MySqlDbType.Decimal),
        //                        new MySqlParameter("@v_cost", MySqlDbType.Decimal),
        //                        new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 20),
        //                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
        //                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),

        //                };
        //                break;

        //            case "SQLServer":
        //                pDataParametersA = new IDataParameter[]
        //                {
        //                        new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
        //                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
        //                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
        //                        new SqlParameter("@v_inout_type", SqlDbType.NVarChar, 1),
        //                        new SqlParameter("@v_inout_id", SqlDbType.NVarChar, 15),
        //                        new SqlParameter("@v_inout_date", SqlDbType.NVarChar, 8),
        //                        new SqlParameter("@v_inout_seq", SqlDbType.Int),
        //                        new SqlParameter("@v_inout_code", SqlDbType.NVarChar, 50),
        //                        new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
        //                        new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 20),
        //                        new SqlParameter("@v_inout_qty", SqlDbType.Decimal),
        //                        new SqlParameter("@v_unitcost", SqlDbType.Decimal),
        //                        new SqlParameter("@v_cost", SqlDbType.Decimal),
        //                        new SqlParameter("@v_reference_id", SqlDbType.NVarChar, 20),
        //                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
        //                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
        //                };
        //                break;
        //        }

        //        pDataParametersA[0].Value = "";//pProductOutRegister_T01Entity.CORP_CODE;
        //        pDataParametersA[1].Value = pProductOutRegister_T01Entity.CRUD;
        //        pDataParametersA[2].Value = pProductOutRegister_T01Entity.USER_CODE;

        //        pDataParametersA[3].Value = pProductOutRegister_T01Entity.INOUT_TYPE;
        //        pDataParametersA[4].Value = pProductOutRegister_T01Entity.INOUT_ID;
        //        pDataParametersA[5].Value = pProductOutRegister_T01Entity.INOUT_DATE;
        //        pDataParametersA[6].Value = pProductOutRegister_T01Entity.INOUT_SEQ=="" ? "0" : pProductOutRegister_T01Entity.INOUT_SEQ;
        //        pDataParametersA[7].Value = pProductOutRegister_T01Entity.INOUT_CODE;
        //        pDataParametersA[8].Value = pProductOutRegister_T01Entity.PART_CODE;
        //        pDataParametersA[9].Value =  pProductOutRegister_T01Entity.VEND_CODE;
        //        pDataParametersA[10].Value = pProductOutRegister_T01Entity.INOUT_QTY;
        //        pDataParametersA[11].Value = pProductOutRegister_T01Entity.UNITCOST;
        //        pDataParametersA[12].Value = pProductOutRegister_T01Entity.COST;
        //        pDataParametersA[13].Value = pProductOutRegister_T01Entity.REFERENCE_ID;
        //        pDataParametersA[14].Value = pProductOutRegister_T01Entity.REMARK;
        //        pDataParametersA[15].Value = "Y";// pProductOutRegister_T01Entity.USE_YN;

        //        pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductOutRegister_T01_I10", pDataParametersA);

        //        pProductOutRegister_T01Entity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
        //        pProductOutRegister_T01Entity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
        //        pProductOutRegister_T01Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
        //        pProductOutRegister_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
        //        pProductOutRegister_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

        //        if (pDataTableA.Rows[0][0].ToString() != "00")
        //        {
        //            pErrorYN = true;
        //        }
        //        else
        //        {
        //           // if (dt != null)
        //           // {
        //           //     pCount = dt.Rows.Count;
        //           //
        //           //     for (int a = 0; a < pCount; a++)
        //           //     {
        //           //         IDataParameter[] pDataParametersB = null;
        //           //
        //           //         switch (_pDBManager.DBManagerType.ToString())
        //           //         {
        //           //             case "MySql":
        //           //                 pDataParametersB = new IDataParameter[]
        //           //                 {
        //           //                     new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
        //           //                     new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
        //           //                     new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20)
        //           //                 };
        //           //                 break;
        //           //
        //           //             case "SQLServer":
        //           //                 pDataParametersB = new IDataParameter[]
        //           //                 {
        //           //                     new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
        //           //                     new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
        //           //                     new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20)
        //           //                 };
        //           //                 break;
        //           //         }
        //           //
        //           //         pDataParametersB[0].Value = pProductOutRegister_T01Entity.CORP_CODE;
        //           //         pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
        //           //         pDataParametersB[2].Value = pProductOutRegister_T01Entity.USER_CODE;
        //           //
        //           //         DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);
        //           //
        //           //         if (pDataTableB.Rows[0][0].ToString() != "00")
        //           //         {
        //           //             pErrorYN = true;
        //           //         }
        //           //
        //           //         pProductOutRegister_T01Entity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
        //           //         pProductOutRegister_T01Entity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
        //           //         pProductOutRegister_T01Entity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
        //           //         pProductOutRegister_T01Entity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
        //           //         pProductOutRegister_T01Entity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
        //           //     }
        //           // }
        //        }
        //        //if (pDataTable != null)
        //        //{
        //        //    GetEntity(pDataTable.Rows[0]);
        //        //}
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        pErrorYN = true;

        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        pErrorYN = true;

        //        throw new ExceptionManager
        //        (
        //            this,
        //            "Sample_Info_Save(ProductOutRegister_T01Entity pProductOutRegister_T01Entity, DataTable dt)",
        //            pException
        //        );
        //    }

        //    //return pErrorYN;
        //    return pDataTableA;
        //}

        //#endregion

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ProductOutRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductOutRegister_T01Entity pProductOutRegister_T01Entity = new ProductOutRegister_T01Entity();

                //pProductOutRegister_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProductOutRegister_T01Entity;
            }
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
    public class ucSemiProductStockInfoPopupProvider : EntityManager<ucSemiProductStockInfoMaterialPopupEntity>
    {
        #region 생성자 - ucSemiProductStockInfoPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucSemiProductStockInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ucSemiProductStockInfoPopupEntity pucSemiProductStockInfoPopupEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet ucInspectRequestInfo_Return(string pCRUD, string pPART_CODE, string pPART_NAME)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPART_CODE;
                pDataParameters[2].Value = pPART_NAME;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucSemiProductStockInfoPopup_R10", pDataParameters);


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
                    "Sample_Info_Mst(ucSemiProductStockInfoPopupEntity pucSemiProductStockInfoPopupEntity)",
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
        public bool ucSemiProductStockInfoPopup_Save(ucSemiProductStockInfoMaterialPopupEntity pucSemiProductStockInfoMaterialPopupEntity, DataTable dt)
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
                                new MySqlParameter("@v_inout_code", MySqlDbType.VarChar, 10)
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
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_inout_code", SqlDbType.VarChar, 10),

                                        };
                                        break;
                                }

                                pDataParametersA[0].Value = pucSemiProductStockInfoMaterialPopupEntity.CRUD;
                                pDataParametersA[1].Value = pucSemiProductStockInfoMaterialPopupEntity.USER_CODE;
                                pDataParametersA[2].Value = dt.Rows[a]["INOUT_ID"].ToString().ToUpper();
                                pDataParametersA[3].Value = dt.Rows[a]["INPUT_QTY"].ToString().ToUpper();
                                pDataParametersA[4].Value = "";
                                pDataParametersA[5].Value = "Y";
                                pDataParametersA[6].Value = pucSemiProductStockInfoMaterialPopupEntity.INOUT_CODE;

                                //pDataParametersA[0].Value = pucSemiProductStockInfoPopupEntity.CRUD;
                                //pDataParametersA[1].Value = pucSemiProductStockInfoPopupEntity.USER_CODE;
                                //pDataParametersA[2].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper();
                                //pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                                //pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");


                                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductOutRegister_T01_I30", pDataParametersA);

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
                                pucSemiProductStockInfoMaterialPopupEntity.ERR_NO = pDataTableA.Rows[0]["p_err_no"].ToString();
                                pucSemiProductStockInfoMaterialPopupEntity.ERR_MSG = pDataTableA.Rows[0]["p_err_msg"].ToString();
                                pucSemiProductStockInfoMaterialPopupEntity.RTN_KEY = pDataTableA.Rows[0]["p_rtn_key"].ToString();
                                pucSemiProductStockInfoMaterialPopupEntity.RTN_SEQ = pDataTableA.Rows[0]["p_rtn_sq"].ToString();
                                pucSemiProductStockInfoMaterialPopupEntity.RTN_OTHERS = pDataTableA.Rows[0]["p_rtn_others"].ToString();

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
        public override ucSemiProductStockInfoMaterialPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucSemiProductStockInfoMaterialPopupEntity pucSemiProductStockInfoPopupEntity = new ucSemiProductStockInfoMaterialPopupEntity();

                pucSemiProductStockInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucSemiProductStockInfoPopupEntity;
            }
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
    public class ucProductionOrderInfoPopup_T05Provider : EntityManager<ucProductionOrderInfoPopup_T05_Entity>
    {
        #region 생성자 - ucProductionOrderInfoPopup_T05Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucProductionOrderInfoPopup_T05Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기

        public override ucProductionOrderInfoPopup_T05_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucProductionOrderInfoPopup_T05_Entity pucProductionOrderInfoPopup_T05_Entity = new ucProductionOrderInfoPopup_T05_Entity();
                pucProductionOrderInfoPopup_T05_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucProductionOrderInfoPopup_T05_Entity;
            }
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

        public DataSet ucProductionOrderInfoPopup_T05_Return(ucProductionOrderInfoPopup_T05_Entity pucProductionOrderInfoPopup_T05_Entity)
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

                pDataParameters[0].Value = pucProductionOrderInfoPopup_T05_Entity.CRUD;
                pDataParameters[1].Value = pucProductionOrderInfoPopup_T05_Entity.DATE_FROM;
                pDataParameters[2].Value = pucProductionOrderInfoPopup_T05_Entity.DATE_TO;
                pDataParameters[3].Value = pucProductionOrderInfoPopup_T05_Entity.PART_CODE;
                pDataParameters[4].Value = pucProductionOrderInfoPopup_T05_Entity.PART_NAME;
                pDataParameters[5].Value = pucProductionOrderInfoPopup_T05_Entity.VEND_CODE;
                pDataParameters[6].Value = pucProductionOrderInfoPopup_T05_Entity.VEND_NAME;
                pDataParameters[7].Value = pucProductionOrderInfoPopup_T05_Entity.LANGUAGE_TYPE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucProductionOrderInfoPopup_T05_R10", pDataParameters);
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

    public class ucProductStockInfoPopupProvider : EntityManager<ucProductStockInfoPopupEntity>
    {
        #region 생성자 - ucProductStockInfoPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucProductStockInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ucProductStockInfoPopupEntity pucProductStockInfoPopupEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet ucInspectRequestInfo_Return(string pCRUD, string pPART_CODE, string pPART_NAME)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPART_CODE;
                pDataParameters[2].Value = pPART_NAME;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucProductStockInfoPopup_R10", pDataParameters);


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
                    "Sample_Info_Mst(ucProductStockInfoPopupEntity pucProductStockInfoPopupEntity)",
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
        public bool ucProductStockInfoPopup_Save(ucProductStockInfoPopupEntity pucProductStockInfoPopupEntity, DataTable dt)
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
                                new MySqlParameter("@v_inout_code", MySqlDbType.VarChar, 10)
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
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_inout_code", SqlDbType.VarChar, 10),

                                        };
                                        break;
                                }

                                pDataParametersA[0].Value = pucProductStockInfoPopupEntity.CRUD;
                                pDataParametersA[1].Value = pucProductStockInfoPopupEntity.USER_CODE;
                                pDataParametersA[2].Value = dt.Rows[a]["INOUT_ID"].ToString().ToUpper();
                                pDataParametersA[3].Value = dt.Rows[a]["INPUT_QTY"].ToString().ToUpper();
                                pDataParametersA[4].Value = "";
                                pDataParametersA[5].Value = "Y";
                                pDataParametersA[6].Value = pucProductStockInfoPopupEntity.INOUT_CODE;

                                //pDataParametersA[0].Value = pucProductStockInfoPopupEntity.CRUD;
                                //pDataParametersA[1].Value = pucProductStockInfoPopupEntity.USER_CODE;
                                //pDataParametersA[2].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper();
                                //pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                                //pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");


                                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialOutRegister_T01_I10", pDataParametersA);

                                if (pDataTableA.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }
                                pucProductStockInfoPopupEntity.ERR_NO = pDataTableA.Rows[0]["p_err_no"].ToString();
                                pucProductStockInfoPopupEntity.ERR_MSG = pDataTableA.Rows[0]["p_err_msg"].ToString();
                                pucProductStockInfoPopupEntity.RTN_KEY = pDataTableA.Rows[0]["p_rtn_key"].ToString();
                                pucProductStockInfoPopupEntity.RTN_SEQ = pDataTableA.Rows[0]["p_rtn_seq"].ToString();
                                pucProductStockInfoPopupEntity.RTN_OTHERS = pDataTableA.Rows[0]["p_rtn_others"].ToString();

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
        public override ucProductStockInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucProductStockInfoPopupEntity pucProductStockInfoPopupEntity = new ucProductStockInfoPopupEntity();

                pucProductStockInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucProductStockInfoPopupEntity;
            }
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
