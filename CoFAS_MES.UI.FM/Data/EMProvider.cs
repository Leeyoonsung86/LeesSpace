using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

using CoFAS_MES.UI.EM.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;

namespace CoFAS_MES.UI.EM.Data
{
    public class EquipmentCodeMstRegisterProvider : EntityManager<EquipmentCodeMstRegisterEntity>
    {
        #region 생성자 - EquipmentCodeMstRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public EquipmentCodeMstRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Equipment_Info_Mst(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="EquipmentCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Equipment_Info_Mst(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)
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
                            new MySqlParameter("@v_equipment_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_equipment_mst_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_equipment_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_equipment_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_equipment_mst_name", SqlDbType.VarChar, 100),
                            new SqlParameter("@v_equipment_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
 
                };
                        break;
                }

                pDataParameters[0].Value = pEquipmentCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE;
                pDataParameters[2].Value = pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_NAME;
                pDataParameters[3].Value = pEquipmentCodeMstRegisterEntity.EQUIPMENT_TYPE;
                pDataParameters[4].Value = pEquipmentCodeMstRegisterEntity.USE_YN;
                pDataParameters[5].Value = pEquipmentCodeMstRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCodeMstRegister_R10", pDataParameters);

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
                    "Equipment_Info_Mst(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 마스터 바인딩 조회하기 - Equipment_Info_Mst_Binding(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="EquipmentCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Equipment_Info_Mst_Binding(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_equipment_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_equipment_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
 
                };
                        break;
                }

                pDataParameters[0].Value = pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE;
                pDataParameters[1].Value = pEquipmentCodeMstRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCodeMstRegister_R11", pDataParameters);

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
                    "Equipment_Info_Mst_Binding(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion



        #region 상세 조회하기 - Equipment_Info_Detail(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="EquipmentCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Equipment_Info_Detail(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)
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
                            new MySqlParameter("@v_equipment_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_equipment_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pEquipmentCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE;
                pDataParameters[2].Value = pEquipmentCodeMstRegisterEntity.USE_YN;
                pDataParameters[3].Value = pEquipmentCodeMstRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCodeMstRegister_R20", pDataParameters);

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
                    "Equipment_Info_Detail(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Equipment_Info_Save(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="EquipmentCodeMstRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Equipment_Info_Save(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity, DataTable dt)
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
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_equipment_mst_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_equipment_mst_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_equipment_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_equipment_mst_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_equipment_mst_name", SqlDbType.VarChar, 100),
                                new SqlParameter("@v_equipment_type", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pEquipmentCodeMstRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pEquipmentCodeMstRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE;
                pDataParameters[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_NAME);
                pDataParameters[5].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pEquipmentCodeMstRegisterEntity.EQUIPMENT_TYPE);
                pDataParameters[6].Value = pEquipmentCodeMstRegisterEntity.REMARK;
                pDataParameters[7].Value = pEquipmentCodeMstRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCodeMstRegister_I10", pDataParameters);

                pEquipmentCodeMstRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pEquipmentCodeMstRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pEquipmentCodeMstRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pEquipmentCodeMstRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pEquipmentCodeMstRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE = pEquipmentCodeMstRegisterEntity.RTN_KEY;

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
                                            new MySqlParameter("@v_equipment_mst_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_equipment_name", MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_equipment_image", MySqlDbType.LongBlob),
                                            new MySqlParameter("@v_equipment_serial_number", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_produce_country", MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_produce_company", MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_purchase_company", MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_purchase_price", MySqlDbType.Decimal),
                                            new MySqlParameter("@v_purchase_date", MySqlDbType.VarChar, 8),
                                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_equipment_mst_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_equipment_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_equipment_name", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_equipment_image", SqlDbType.Image),
                                            new SqlParameter("@v_equipment_serial_number", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_produce_country", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_produce_company", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_purchase_company", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_purchase_price", SqlDbType.Decimal),
                                            new SqlParameter("@v_purchase_date", SqlDbType.NVarChar, 8),
                                            new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[1].Value = pEquipmentCodeMstRegisterEntity.USER_CODE;
                            pDataParametersB[2].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["EQUIPMENT_MST_CODE"].ToString().Length > 0 ? dt.Rows[a]["EQUIPMENT_MST_CODE"].ToString().ToUpper() : pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE);
                            pDataParametersB[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["EQUIPMENT_CODE"].ToString().ToUpper());
                            pDataParametersB[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["EQUIPMENT_NAME"].ToString().ToUpper());

                            pDataParametersB[5].Value = dt.Rows[a]["EQUIPMENT_IMAGE"];
                            pDataParametersB[6].Value = dt.Rows[a]["EQUIPMENT_SERIAL_NUMBER"].ToString().ToUpper();
                            pDataParametersB[7].Value = dt.Rows[a]["PRODUCE_COUNTRY"].ToString().ToUpper();
                            pDataParametersB[8].Value = dt.Rows[a]["PRODUCE_COMPANY"].ToString().ToUpper();
                            pDataParametersB[9].Value = dt.Rows[a]["PURCHASE_COMPANY"].ToString().ToUpper();
                            //pDataParametersB[10].Value = dt.Rows[a]["PURCHASE_PRICE"].ToString().ToUpper();
                            pDataParametersB[10].Value = dt.Rows[a]["PURCHASE_PRICE"].ToString().ToUpper() == "" ? "0" : dt.Rows[a]["PURCHASE_PRICE"].ToString().ToUpper();
                            pDataParametersB[11].Value = dt.Rows[a]["PURCHASE_DATE"].ToString().ToUpper();
                            pDataParametersB[12].Value = dt.Rows[a]["REMARK"].ToString();
                            pDataParametersB[13].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCodeMstRegister_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pEquipmentCodeMstRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pEquipmentCodeMstRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pEquipmentCodeMstRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pEquipmentCodeMstRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pEquipmentCodeMstRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Equipment_Info_Save(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity, DataTable dt)",
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

        #region 이미지 삭제하기 - Equipment_Info_Image_Delete(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="EquipmentCodeMstRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Equipment_Info_Image_Delete(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)
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
                                new MySqlParameter("@v_equipment_mst_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_equipment_image", MySqlDbType.LongBlob),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_equipment_mst_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_equipment_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_equipment_image", SqlDbType.Image),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pEquipmentCodeMstRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pEquipmentCodeMstRegisterEntity.EQUIPMENT_MST_CODE;
                pDataParameters[3].Value = pEquipmentCodeMstRegisterEntity.EQUIPMENT_CODE;
                pDataParameters[4].Value = pEquipmentCodeMstRegisterEntity.EQUIPMENT_IMAGE;
                pDataParameters[5].Value = pEquipmentCodeMstRegisterEntity.USE_YN;

                DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCodeMstRegister_I21", pDataParameters);

                if (pDataTableB.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pEquipmentCodeMstRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                pEquipmentCodeMstRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                pEquipmentCodeMstRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                pEquipmentCodeMstRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                pEquipmentCodeMstRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();

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
                    "Equipment_Info_Image_Delete(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)",
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
        public override EquipmentCodeMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity = new EquipmentCodeMstRegisterEntity();

                //pProcessCodeMstRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pEquipmentCodeMstRegisterEntity;
            }
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

    public class EquipmentCheckProvider : EntityManager<EquipmentCheckEntity>
    {
        #region 생성자 - EquipmentCheckProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public EquipmentCheckProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 및 대표 서식 파일 조회하기 - ExcelForm_Mst(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        
        public DataTable EquipmentCheck_Mst(EquipmentCheckEntity pEquipmentCheckEntity)
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
                            new MySqlParameter("@v_sheetinfo_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_file_nickname", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_sheetinfo_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_file_nickname", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentCheckEntity.CRUD;
                pDataParameters[1].Value = pEquipmentCheckEntity.SHEETINFO_ID;
                pDataParameters[2].Value = pEquipmentCheckEntity.DATE_FROM;
                pDataParameters[3].Value = pEquipmentCheckEntity.DATE_TO;
                pDataParameters[4].Value = pEquipmentCheckEntity.FILE_NICKNAME;
                pDataParameters[5].Value = pEquipmentCheckEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCheck_R10", pDataParameters);

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
                    "EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 대표파일 조회하기 조회하기 - EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentchangeEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>

        public DataTable EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_sheetinfo_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_sheetinfo_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentCheckEntity.SHEETINFO_ID;
                pDataParameters[1].Value = pEquipmentCheckEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCheck_R20", pDataParameters);

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
                    "EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEquipmentCheckEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)
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
                                new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sheetinfo_id", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_dsp_seq", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_file_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_file_nickname", MySqlDbType.VarChar, 100)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sheetinfo_id", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_dsp_seq", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_file_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_file_nickname", SqlDbType.NVarChar, 100)
                        };
                        break;
                }

                pDataParametersA[0].Value = pEquipmentCheckEntity.CRUD;
                pDataParametersA[1].Value = pEquipmentCheckEntity.USER_CODE;
                pDataParametersA[2].Value = pEquipmentCheckEntity.WINDOW_NAME;
                pDataParametersA[3].Value = pEquipmentCheckEntity.SHEETINFO_ID;
                pDataParametersA[4].Value = pEquipmentCheckEntity.DSP_SEQ;
                pDataParametersA[5].Value = pEquipmentCheckEntity.FILE_NAME;
                pDataParametersA[6].Value = pEquipmentCheckEntity.FILE_NICKNAME;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCheck_I10", pDataParametersA);

                pEquipmentCheckEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pEquipmentCheckEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pEquipmentCheckEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pEquipmentCheckEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pEquipmentCheckEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
        public override EquipmentCheckEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                EquipmentCheckEntity pEquipmentCheckEntity = new EquipmentCheckEntity();

                //pListofManagementEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pEquipmentCheckEntity;
            }
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

    public class EquipmentChangeProvider : EntityManager<EquipmentChangeEntity>
    {
        #region 생성자 - EquipmentchangeProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public EquipmentChangeProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - ExcelForm_Mst(EquipmentChangeEntity pEquipmentChangeEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentchangeEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>

        public DataTable EquipmentChange_Mst(EquipmentChangeEntity pEquipmentChangeEntity)
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
                            new MySqlParameter("@v_sheetinfo_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_file_nickname", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_sheetinfo_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_file_nickname", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentChangeEntity.CRUD;
                pDataParameters[1].Value = pEquipmentChangeEntity.SHEETINFO_ID;
                pDataParameters[2].Value = pEquipmentChangeEntity.DATE_FROM;
                pDataParameters[3].Value = pEquipmentChangeEntity.DATE_TO;
                pDataParameters[4].Value = pEquipmentChangeEntity.FILE_NICKNAME;
                pDataParameters[5].Value = pEquipmentChangeEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentChange_R10", pDataParameters);

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
                    "EquipmentChange_Sub(EquipmentChangeEntity pEquipmentChangeEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 대표파일 조회하기 조회하기 - EquipmentChange_Sub(EquipmentChangeEntity pEquipmentChangeEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentchangeEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>

        public DataTable EquipmentChange_Sub(EquipmentChangeEntity pEquipmentChangeEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_sheetinfo_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_sheetinfo_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentChangeEntity.SHEETINFO_ID;
                pDataParameters[1].Value = pEquipmentChangeEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentChange_R20", pDataParameters);

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
                    "EquipmentChange_Sub(EquipmentChangeEntity pEquipmentChangeEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - EquipmentChange_Save(EquipmentChangeEntity pEquipmentChangeEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEquipmentChangeEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool EquipmentChange_Save(EquipmentChangeEntity pEquipmentChangeEntity)
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
                                new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sheetinfo_id", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_dsp_seq", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_file_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_file_nickname", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sheetinfo_id", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_dsp_seq", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_file_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_file_nickname", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pEquipmentChangeEntity.CRUD;
                pDataParametersA[1].Value = pEquipmentChangeEntity.USER_CODE;
                pDataParametersA[2].Value = pEquipmentChangeEntity.WINDOW_NAME;
                pDataParametersA[3].Value = pEquipmentChangeEntity.SHEETINFO_ID;
                pDataParametersA[4].Value = pEquipmentChangeEntity.DSP_SEQ;
                pDataParametersA[5].Value = pEquipmentChangeEntity.FILE_NAME;
                pDataParametersA[6].Value = pEquipmentChangeEntity.FILE_NICKNAME;
                pDataParametersA[7].Value = pEquipmentChangeEntity.LANGUAGE_TYPE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentChange_I10", pDataParametersA);

                pEquipmentChangeEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pEquipmentChangeEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pEquipmentChangeEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pEquipmentChangeEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pEquipmentChangeEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
        public override EquipmentChangeEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                EquipmentChangeEntity pEquipmentChangeEntity = new EquipmentChangeEntity();

                //pListofManagementEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pEquipmentChangeEntity;
            }
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

    public class ucEquipmentDocumentListPopupProvider : EntityManager<ucEquipmentDocumentListPopupEntity>
    {
        #region 생성자 - ucEquipmentDocumentListPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucEquipmentDocumentListPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 메인 조회하기 ucEquipmentDocumentListPopup_Info_Main(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity)
        public DataTable ucEquipmentDocumentListPopup_Info_Main(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity)
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
                            new MySqlParameter("@v_equipment_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_equipment_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_equipment_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)


                };
                        break;
                }

                pDataParameters[0].Value = pucEquipmentDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucEquipmentDocumentListPopupEntity.EQUIPMENT_MST_CODE;
                pDataParameters[2].Value = pucEquipmentDocumentListPopupEntity.EQUIPMENT_CODE;
                pDataParameters[3].Value = pucEquipmentDocumentListPopupEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucEquipmentDocumentListPopup_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucEquipmentDocumentListPopup_Info_Main(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 ucEquipmentDocumentListPopup_Info_Sub(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity)

        public DataTable ucEquipmentDocumentListPopup_Info_Sub(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity)
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
                            new MySqlParameter("@v_equipment_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
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
                            new SqlParameter("@v_equipment_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_equipment_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pucEquipmentDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucEquipmentDocumentListPopupEntity.DOCUMENT_TYPE;
                pDataParameters[2].Value = pucEquipmentDocumentListPopupEntity.DOCUMENT_NAME;
                pDataParameters[3].Value = pucEquipmentDocumentListPopupEntity.DOCUMENT_VER;

                pDataParameters[4].Value = pucEquipmentDocumentListPopupEntity.EQUIPMENT_MST_CODE;
                pDataParameters[5].Value = pucEquipmentDocumentListPopupEntity.EQUIPMENT_CODE;
                pDataParameters[6].Value = pucEquipmentDocumentListPopupEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucEquipmentDocumentListPopup_R20", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucEquipmentDocumentListPopup_Info_Sub(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ucContractDocumentListPopup_Info_Save(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity, DataTable pDataTable)
        public bool ucEquipmentDocumentListPopup_Info_Save(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity, DataTable pDataTable)
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
                                        new MySqlParameter("@v_equipment_mst_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
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
                                        new SqlParameter("@v_equipment_mst_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_equipment_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_document_id", SqlDbType.NVarChar, 15),
                                        new SqlParameter("@v_document_type", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                };
                                break;

                        }

                        pDataParameters[0].Value = pDataTable.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pucEquipmentDocumentListPopupEntity.USER_CODE;

                        pDataParameters[2].Value = pucEquipmentDocumentListPopupEntity.EQUIPMENT_MST_CODE;
                        pDataParameters[3].Value = pucEquipmentDocumentListPopupEntity.EQUIPMENT_CODE;
                        pDataParameters[4].Value = pDataTable.Rows[a]["DOCUMENT_ID"].ToString();
                        pDataParameters[5].Value = pDataTable.Rows[a]["DOCUMENT_TYPE"].ToString();
                        pDataParameters[6].Value = pDataTable.Rows[a]["REMARK"].ToString();
                        pDataParameters[7].Value = pDataTable.Rows[a]["USE_YN"].ToString().ToUpper() == "" ? "Y" : pDataTable.Rows[a]["USE_YN"].ToString().ToUpper();

                        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucEquipmentDocumentListPopup_I10", pDataParameters);

                        if (pDataTableB.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pucEquipmentDocumentListPopupEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                        pucEquipmentDocumentListPopupEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();

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
                    "ucEquipmentDocumentListPopup_Info_Save(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity, DataTable pDataTable)",
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

        public override ucEquipmentDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity = new ucEquipmentDocumentListPopupEntity();
                pucEquipmentDocumentListPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucEquipmentDocumentListPopupEntity;
            }
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

    public class EquipmentCheck_T01Provider : EntityManager<EquipmentCheck_T01Entity>
    {
        #region 생성자 - EquipmentCheck_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public EquipmentCheck_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)
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

                pDataParameters[0].Value = pEquipmentCheck_T01Entity.CRUD;
                pDataParameters[1].Value = pEquipmentCheck_T01Entity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pEquipmentCheck_T01Entity.EQUIPMENT_CODE;
                pDataParameters[3].Value = pEquipmentCheck_T01Entity.CHECK_CYCLE;              
                
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCheck_T01_R10", pDataParameters);

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
        public bool Sample_Info_Save(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, DataTable pDataTable)
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
                            new MySqlParameter("@v_result_data", MySqlDbType.VarChar, 50)

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
                            new SqlParameter("@v_result_data", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {
                   
                        pDataParametersA[0].Value = "";
                        pDataParametersA[1].Value = pEquipmentCheck_T01Entity.USER_CODE;                        
                        pDataParametersA[2].Value = pDataTable.Rows[i]["CHECK_DATE"].ToString();
                        pDataParametersA[3].Value = pDataTable.Rows[i]["equipment_code"].ToString();
                        pDataParametersA[4].Value = pDataTable.Rows[i]["check_cycle"].ToString();
                        pDataParametersA[5].Value = pDataTable.Rows[i]["check_code"].ToString();
                        pDataParametersA[6].Value = pDataTable.Rows[i]["check_result"].ToString();
                        pDataParametersA[7].Value = pDataTable.Rows[i]["result_data"].ToString();

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCheck_T01_I10", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pEquipmentCheck_T01Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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

        #region 파일명 조회하기 - EquipmentCheck_T01_Info_Filename(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentCheck_T01Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable EquipmentCheck_T01_Info_Filename(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)
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

                pDataParameters[0].Value = pEquipmentCheck_T01Entity.WINDOW_NAME;
                pDataParameters[1].Value = pEquipmentCheck_T01Entity.LANGUAGE_TYPE;

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
                    "EquipmentCheck_T01_Info_Filename(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object Templete_Download(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pEquipmentCheck_T01Entity.LANGUAGE_TYPE;


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
        public override EquipmentCheck_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                EquipmentCheck_T01Entity pEquipmentCheck_T01Entity = new EquipmentCheck_T01Entity();

                pEquipmentCheck_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pEquipmentCheck_T01Entity;
            }
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

    public class EquipmentHistoryProvider : EntityManager<EquipmentHistoryEntity>
    {
        #region 생성자 - EquipmentCheckProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public EquipmentHistoryProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 및 대표 서식 파일 조회하기 - EquipmentHistory_Mst(EquipmentHistoryEntity pEquipmentHistoryEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>

        public DataTable EquipmentHistory_Mst(EquipmentHistoryEntity pEquipmentHistoryEntity)
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
                            new MySqlParameter("@v_terminal_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_check_list", MySqlDbType.VarChar, 50)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_terminal_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_check_list", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentHistoryEntity.CRUD;
                pDataParameters[1].Value = pEquipmentHistoryEntity.DATE_FROM;
                pDataParameters[2].Value = pEquipmentHistoryEntity.DATE_TO;
                pDataParameters[3].Value = pEquipmentHistoryEntity.TERMINAL_NAME;
                pDataParameters[4].Value = pEquipmentHistoryEntity.CHECK_LIST;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentHistory_R10", pDataParameters);

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
                    "EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 대표파일 조회하기 조회하기 - EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentchangeEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>

        public DataTable EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_sheetinfo_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_sheetinfo_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentCheckEntity.SHEETINFO_ID;
                pDataParameters[1].Value = pEquipmentCheckEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCheck_R20", pDataParameters);

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
                    "EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEquipmentCheckEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)
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
                                new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sheetinfo_id", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_dsp_seq", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_file_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_file_nickname", MySqlDbType.VarChar, 100)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sheetinfo_id", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_dsp_seq", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_file_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_file_nickname", SqlDbType.NVarChar, 100)
                        };
                        break;
                }

                pDataParametersA[0].Value = pEquipmentCheckEntity.CRUD;
                pDataParametersA[1].Value = pEquipmentCheckEntity.USER_CODE;
                pDataParametersA[2].Value = pEquipmentCheckEntity.WINDOW_NAME;
                pDataParametersA[3].Value = pEquipmentCheckEntity.SHEETINFO_ID;
                pDataParametersA[4].Value = pEquipmentCheckEntity.DSP_SEQ;
                pDataParametersA[5].Value = pEquipmentCheckEntity.FILE_NAME;
                pDataParametersA[6].Value = pEquipmentCheckEntity.FILE_NICKNAME;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCheck_I10", pDataParametersA);

                pEquipmentCheckEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pEquipmentCheckEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pEquipmentCheckEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pEquipmentCheckEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pEquipmentCheckEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
        #region 엑셀 바인딩
        public DataTable EquipmentHistory_info_ExcelBinding(EquipmentHistoryEntity pEquipmentHistoryEntity)
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
                            new MySqlParameter("@v_terminal_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_check_list", MySqlDbType.VarChar, 50)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_terminal_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_check_list", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentHistoryEntity.CRUD;
                pDataParameters[1].Value = pEquipmentHistoryEntity.DATE_FROM;
                pDataParameters[2].Value = pEquipmentHistoryEntity.DATE_TO;
                pDataParameters[3].Value = pEquipmentHistoryEntity.TERMINAL_NAME;
                pDataParameters[4].Value = pEquipmentHistoryEntity.CHECK_LIST;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentHistory_R10", pDataParameters);


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
                    "Sample_Info_Mst(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)",
                    pException
                );
            }

        }
        #endregion

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(SampleExcelBindingEntity pRawMaterialInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pRawMaterialInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(EquipmentHistoryEntity pEquipmentHistoryEntity)
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

                pDataParameters[0].Value = pEquipmentHistoryEntity.CRUD;
                pDataParameters[1].Value = pEquipmentHistoryEntity.WINDOW_NAME;
                pDataParameters[2].Value = pEquipmentHistoryEntity.LANGUAGE_TYPE;

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
        public override EquipmentHistoryEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                EquipmentHistoryEntity pEquipmentHistoryEntity = new EquipmentHistoryEntity();

                //pListofManagementEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pEquipmentHistoryEntity;
            }
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

    public class EquipmentStopHistoryProvider : EntityManager<EquipmentStopHistoryEntity>
    {
        #region 생성자 - EquipmentCheckProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public EquipmentStopHistoryProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 및 대표 서식 파일 조회하기 - EquipmentHistory_Mst(EquipmentHistoryEntity pEquipmentHistoryEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>

        public DataTable EquipmentStopHistory_Mst(EquipmentStopHistoryEntity pEquipmentStopHistoryEntity)
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
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_stop_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_stop_detail", MySqlDbType.VarChar, 50)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar,10),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,10),
                            new SqlParameter("@v_euipment_code", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_stop_mst", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_stop_detail", SqlDbType.NVarChar, 20)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentStopHistoryEntity.CRUD;
                pDataParameters[1].Value = pEquipmentStopHistoryEntity.DATE_FROM;
                pDataParameters[2].Value = pEquipmentStopHistoryEntity.DATE_TO;
                pDataParameters[3].Value = pEquipmentStopHistoryEntity.EQUIPMENT_CODE;
                pDataParameters[4].Value = pEquipmentStopHistoryEntity.USER_CODE;
                pDataParameters[5].Value = pEquipmentStopHistoryEntity.STOP_MST;
                pDataParameters[6].Value = pEquipmentStopHistoryEntity.STOP_DETAIL;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentStopHistory_R10", pDataParameters);

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
                    "EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 대표파일 조회하기 조회하기 - EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentchangeEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>

        public DataTable EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_sheetinfo_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_sheetinfo_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentCheckEntity.SHEETINFO_ID;
                pDataParameters[1].Value = pEquipmentCheckEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCheck_R20", pDataParameters);

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
                    "EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)",
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
        public override EquipmentStopHistoryEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                EquipmentStopHistoryEntity pEquipmentStopHistoryEntity = new EquipmentStopHistoryEntity();

                //pListofManagementEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pEquipmentStopHistoryEntity;
            }
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
    public class EquipmentBaseRegister_T50Provider : EntityManager<EquipmentBaseRegister_T50Entity>
    {
        #region 생성자 - EquipmentCheckProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public EquipmentBaseRegister_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 및 대표 서식 파일 조회하기 - EquipmentBaseRegister_T50_Mst(EquipmentBaseRegister_T50Entity pEquipmentBaseRegister_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>

        public DataTable EquipmentBaseRegister_T50_Mst(EquipmentBaseRegister_T50Entity pEquipmentBaseRegister_T50Entity)
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
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 8),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_terminal_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_check_list", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentBaseRegister_T50Entity.CRUD;
                pDataParameters[1].Value = pEquipmentBaseRegister_T50Entity.EQUIPMENT_CODE;
                //pDataParameters[2].Value = pEquipmentBaseRegister_T50Entity.DATE_TO;
                //pDataParameters[3].Value = pEquipmentBaseRegister_T50Entity.TERMINAL_NAME;
                //pDataParameters[4].Value = pEquipmentBaseRegister_T50Entity.CHECK_LIST;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentBaseRegister_T50_R10", pDataParameters);

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
                    "EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEquipmentCheckEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool EquipmentBaseRegister_T50_Save(EquipmentBaseRegister_T50Entity pEquipmentBaseRegister_T50Entity,DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {

                for (int a = 0; a < dt.Rows.Count; a++)
                {
                    if (dt.Rows[a]["CRUD"].ToString() == "U")
                    {
                        //마스터 저장
                        IDataParameter[] pDataParametersA = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParametersA = new IDataParameter[]
                                {
                                new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_std_time", MySqlDbType.Int32)

                                };
                                break;

                            case "SQLServer":
                                pDataParametersA = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                };
                                break;
                        }

                        pDataParametersA[0].Value = dt.Rows[a]["EQUIPMENT_CODE"].ToString();
                        pDataParametersA[1].Value = dt.Rows[a]["STD_TIME"].ToString();

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentBaseRegister_T50_I10", pDataParametersA);

                        if (pDataTableA.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                    }
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
        public override EquipmentBaseRegister_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                EquipmentBaseRegister_T50Entity pEquipmentBaseRegister_T50Entity = new EquipmentBaseRegister_T50Entity();

                //pListofManagementEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pEquipmentBaseRegister_T50Entity;
            }
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

    public class EquipmentCheckListMonth_T50Provider : EntityManager<EquipmentCheckListMonth_T50Entity>
    {
        #region 생성자 - EquipmentCheckProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public EquipmentCheckListMonth_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 및 대표 서식 파일 조회하기 - EquipmentCheckListMonth_T50_Mst(EquipmentCheckListMonth_T50Entity pEquipmentCheckListMonth_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>

        public DataTable EquipmentCheckListMonth_T50_Mst(EquipmentCheckListMonth_T50Entity pEquipmentCheckListMonth_T50Entity)
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
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 8),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_terminal_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_check_list", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentCheckListMonth_T50Entity.CRUD;
                pDataParameters[1].Value = pEquipmentCheckListMonth_T50Entity.EQUIPMENT_CODE;
                //pDataParameters[2].Value = pEquipmentBaseRegister_T50Entity.DATE_TO;
                //pDataParameters[3].Value = pEquipmentBaseRegister_T50Entity.TERMINAL_NAME;
                //pDataParameters[4].Value = pEquipmentBaseRegister_T50Entity.CHECK_LIST;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentBaseRegister_T50_R10", pDataParameters);

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
                    "EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEquipmentCheckEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool EquipmentCheckListMonth_T50_Save(EquipmentCheckListMonth_T50Entity pEquipmentCheckListMonth_T50Entity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {

                for (int a = 0; a < dt.Rows.Count; a++)
                {
                    if (dt.Rows[a]["CRUD"].ToString() == "U")
                    {
                        //마스터 저장
                        IDataParameter[] pDataParametersA = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParametersA = new IDataParameter[]
                                {
                                new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_std_time", MySqlDbType.Int32)

                                };
                                break;

                            case "SQLServer":
                                pDataParametersA = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                };
                                break;
                        }

                        pDataParametersA[0].Value = dt.Rows[a]["EQUIPMENT_CODE"].ToString();
                        pDataParametersA[1].Value = dt.Rows[a]["STD_TIME"].ToString();

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentBaseRegister_T50_I10", pDataParametersA);

                        if (pDataTableA.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                    }
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
        public override EquipmentCheckListMonth_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                EquipmentCheckListMonth_T50Entity pEquipmentCheckListMonth_T50Entity = new EquipmentCheckListMonth_T50Entity();

                //pListofManagementEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pEquipmentCheckListMonth_T50Entity;
            }
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

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(SampleExcelBindingEntity pRawMaterialInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pRawMaterialInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(EquipmentCheckListMonth_T50Entity pEquipmentCheckListMonth_T50Entity, string equipment)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_equipmentname", MySqlDbType.VarChar, 50),


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

                pDataParameters[0].Value = pEquipmentCheckListMonth_T50Entity.CRUD;
                pDataParameters[1].Value = pEquipmentCheckListMonth_T50Entity.WINDOW_NAME;
                pDataParameters[2].Value = pEquipmentCheckListMonth_T50Entity.LANGUAGE_TYPE;
                pDataParameters[3].Value = equipment;

                DataTable pDatatable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SheetInfoRegister_R21", pDataParameters);


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


        public DataTable USP_equipment_check_result_R10(string date, string equipment, int condition)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_date", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@Param_equipment_name", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@Param_condition", MySqlDbType.Int32)


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

                pDataParameters[0].Value = date + "%";
                pDataParameters[1].Value = equipment;
                pDataParameters[2].Value = condition;

                DataTable pDatatable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_equipment_check_result_R10", pDataParameters);


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
    }
}
