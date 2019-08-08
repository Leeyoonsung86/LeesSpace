using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

using CoFAS_MES.UI.QC.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using DevExpress.Spreadsheet;
namespace CoFAS_MES.UI.QC.Data
{
    public class ProcessTempManagementProvider : EntityManager<ProcessTempManagementEntity>
    {
        #region 생성자 - ProcessTempManagementProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProcessTempManagementProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ProcessTempManagementEntity pProcessTempManagementEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(ProcessTempManagementEntity pProcessTempManagementEntity)
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
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50)
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
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessTempManagementEntity.CRUD;
                pDataParameters[1].Value = pProcessTempManagementEntity.DATE_FROM;
                pDataParameters[2].Value = pProcessTempManagementEntity.DATE_TO;
                pDataParameters[3].Value = pProcessTempManagementEntity.PROCESS_CODE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessTempManagement_R10", pDataParameters);

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
                    "Sample_Info_Mst(ProcessTempManagementEntity pProcessTempManagementEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(ProcessTempManagementEntity pProcessTempManagementEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(ProcessTempManagementEntity pProcessTempManagementEntity, DataTable dt)
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
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20)
                        };
                        break;
                }

                pDataParametersA[0].Value = pProcessTempManagementEntity.CRUD;
                pDataParametersA[1].Value = pProcessTempManagementEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessTempManagement_I10", pDataParametersA);

                pProcessTempManagementEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pProcessTempManagementEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pProcessTempManagementEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pProcessTempManagementEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pProcessTempManagementEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                    //        pDataParametersB[0].Value = pProcessTempManagementEntity.CORP_CODE;
                    //        pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                    //        pDataParametersB[2].Value = pProcessTempManagementEntity.USER_CODE;

                    //        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                    //        if (pDataTableB.Rows[0][0].ToString() != "00")
                    //        {
                    //            pErrorYN = true;
                    //        }

                    //        pProcessTempManagementEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                    //        pProcessTempManagementEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                    //        pProcessTempManagementEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                    //        pProcessTempManagementEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                    //        pProcessTempManagementEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(ProcessTempManagementEntity pProcessTempManagementEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 파일명 조회하기 - ProcessTempManagement_Info_Filename(ProcessTempManagementEntity pProcessTempManagementEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessTempManagementEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessTempManagement_Info_Filename(ProcessTempManagementEntity pProcessTempManagementEntity)
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

                pDataParameters[0].Value = pProcessTempManagementEntity.WINDOW_NAME;
                pDataParameters[1].Value = pProcessTempManagementEntity.LANGUAGE_TYPE;

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
                    "ProcessTempManagement_Info_Filename(ProcessTempManagementEntity pProcessTempManagementEntity)",
                    pException
                );
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ProcessTempManagementEntity pProcessTempManagementEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object Templete_Download(ProcessTempManagementEntity pProcessTempManagementEntity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pProcessTempManagementEntity.LANGUAGE_TYPE;

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
        public override ProcessTempManagementEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProcessTempManagementEntity pProcessTempManagementEntity = new ProcessTempManagementEntity();

                pProcessTempManagementEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProcessTempManagementEntity;
            }
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

    public class CheckDataRegisterlProvider : EntityManager<CheckDataRegisterEntity>
    {
        #region 생성자 - CheckDataRegisterlProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public CheckDataRegisterlProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 저장
        public bool Excel_Info_Mst_Save(CheckDataRegisterEntity pCheckDataRegisterEntity, DataTable dt1, DataTable dt2)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            try
            {
                //마스터 저장
                _pDBManager.BeginTransaction();
                IDataParameter[] pDataParametersA = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParametersA = new IDataParameter[]
                        {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_seq", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_check_no", MySqlDbType.Int64),
                                new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_lot_no", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_trs_no", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_fps_trs_no", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_lot_size", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_inspect_qty", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_numvar1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_numvar2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_charac1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_charac2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_charac3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_spec1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_spec2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_equip", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_min", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_max", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_seq", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_check_no", SqlDbType.Int),
                                new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_lot_no", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_trs_no", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_fps_trs_no", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_lot_size", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_qty", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_numvar1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_numvar2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_charac1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_charac2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_charac3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_spec1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_spec2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_equip", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_min", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_max", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                if (dt1 != null)
                {
                    DataTable pDataTable_M = null;
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        pDataParametersA[0].Value = pCheckDataRegisterEntity.CRUD;
                        pDataParametersA[1].Value = pCheckDataRegisterEntity.USER_CODE;
                        pDataParametersA[2].Value = pCheckDataRegisterEntity.RTN_KEY == "" ? "" : pCheckDataRegisterEntity.RTN_KEY;
                        pDataParametersA[3].Value = dt1.Rows[i]["check_no"].ToString();
                        pDataParametersA[4].Value = dt1.Rows[i]["part_name"].ToString();
                        pDataParametersA[5].Value = dt1.Rows[i]["lot_no"].ToString();
                        pDataParametersA[6].Value = dt1.Rows[i]["trs_no"].ToString();
                        pDataParametersA[7].Value = dt1.Rows[i]["fps_trs_no"].ToString();
                        pDataParametersA[8].Value = dt1.Rows[i]["lot_size"].ToString();
                        pDataParametersA[9].Value = dt1.Rows[i]["inspect_qty"].ToString();
                        pDataParametersA[10].Value = dt1.Rows[i]["numVar1"].ToString();
                        pDataParametersA[11].Value = dt1.Rows[i]["numVar2"].ToString();
                        pDataParametersA[12].Value = dt1.Rows[i]["charac1"].ToString();
                        pDataParametersA[13].Value = dt1.Rows[i]["charac2"].ToString();
                        pDataParametersA[14].Value = dt1.Rows[i]["charac3"].ToString();
                        pDataParametersA[15].Value = dt1.Rows[i]["spec1"].ToString();
                        pDataParametersA[16].Value = dt1.Rows[i]["spec2"].ToString();
                        pDataParametersA[17].Value = dt1.Rows[i]["equip"].ToString();
                        pDataParametersA[18].Value = dt1.Rows[i]["max"].ToString();
                        pDataParametersA[19].Value = dt1.Rows[i]["max"].ToString();


                        pDataTable_M = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CheckDataRegister_I10", pDataParametersA);

                        if (pDataTable_M.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pCheckDataRegisterEntity.ERR_NO = pDataTable_M.Rows[0]["ERR_NO"].ToString();
                        pCheckDataRegisterEntity.ERR_MSG = pDataTable_M.Rows[0]["ERR_MSG"].ToString();
                        pCheckDataRegisterEntity.RTN_KEY = pDataTable_M.Rows[0]["RTN_KEY"].ToString();
                        pCheckDataRegisterEntity.RTN_SEQ = pDataTable_M.Rows[0]["RTN_SEQ"].ToString();
                        pCheckDataRegisterEntity.RTN_OTHERS = pDataTable_M.Rows[0]["RTN_OTHERS"].ToString();
                    }

                    if (!pErrorYN)
                    {
                        //디테일 저장
                        IDataParameter[] pDataParametersB = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParametersB = new IDataParameter[]
                                {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_seq", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sub_no", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_jsondata", MySqlDbType.JSON)
                                };
                                break;

                            case "SQLServer":
                                pDataParametersB = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_seq", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sub_no", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_jsondata", SqlDbType.Text)
                                };
                                break;
                        }

                        if (dt2 != null)
                        {
                            DataTable pDataTable_S = null;
                            for (int i = 0; i < dt2.Rows.Count; i++)
                            {

                                pDataParametersB[0].Value = pCheckDataRegisterEntity.CRUD;
                                pDataParametersB[1].Value = pCheckDataRegisterEntity.USER_CODE;
                                pDataParametersB[2].Value = pCheckDataRegisterEntity.RTN_KEY;
                                pDataParametersB[3].Value = dt2.Rows[i]["sub_no"].ToString();
                                pDataParametersB[4].Value = dt2.Rows[i]["jsondata"].ToString().Substring(1, dt2.Rows[i]["jsondata"].ToString().Length - 2);

                                pDataTable_S = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CheckDataRegister_I11", pDataParametersB);

                                if (pDataTable_S.Rows[0][0].ToString() != "00")
                                {
                                    pErrorYN = true;
                                }

                                pCheckDataRegisterEntity.ERR_NO = pDataTable_S.Rows[0]["ERR_NO"].ToString();
                                pCheckDataRegisterEntity.ERR_MSG = pDataTable_S.Rows[0]["ERR_MSG"].ToString();
                                pCheckDataRegisterEntity.RTN_SEQ = pDataTable_S.Rows[0]["RTN_SEQ"].ToString();
                                pCheckDataRegisterEntity.RTN_OTHERS = pDataTable_S.Rows[0]["RTN_OTHERS"].ToString();
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
                throw new ExceptionManager(this, "Excel_Info_Mst_Save(CheckDataRegisterEntity pCheckDataRegisterEntity, DataTable dt)", pException);
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
        public override CheckDataRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                CheckDataRegisterEntity pCheckDataRegisterEntity = new CheckDataRegisterEntity();

                pCheckDataRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pCheckDataRegisterEntity;
            }
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


    public class ucMatInspectDocumentListPopupProvider : EntityManager<ucMatInspectDocumentListPopupEntity>
    {
        #region 생성자 - ucMatInspectDocumentListPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucMatInspectDocumentListPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 메인 조회하기 ucMatInspectDocumentListPopup_Info_Main(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)
        public DataTable ucMatInspectDocumentListPopup_Info_Main(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)
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
                            new MySqlParameter("@v_matstock_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_matstock_detail_seq", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_matstock_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_matstock_detail_seq", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)


                };
                        break;
                }

                pDataParameters[0].Value = pucMatInspectDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucMatInspectDocumentListPopupEntity.MATSTOCK_ID;
                pDataParameters[2].Value = pucMatInspectDocumentListPopupEntity.MATSTOCK_DETAIL_SEQ;
                pDataParameters[3].Value = pucMatInspectDocumentListPopupEntity.INSPECT_ID;
                pDataParameters[4].Value = pucMatInspectDocumentListPopupEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMatInspectDocumentListPopup_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucMatInspectDocumentListPopup_Info_Main(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 ucMatInspectDocumentListPopup_Info_Sub(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)

        public DataTable ucMatInspectDocumentListPopup_Info_Sub(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)
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
                            new MySqlParameter("@v_matstock_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_matstock_detail_seq", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
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
                            new SqlParameter("@v_matstock_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_matstock_detail_seq", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pucMatInspectDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucMatInspectDocumentListPopupEntity.DOCUMENT_TYPE;
                pDataParameters[2].Value = pucMatInspectDocumentListPopupEntity.DOCUMENT_NAME;
                pDataParameters[3].Value = pucMatInspectDocumentListPopupEntity.DOCUMENT_VER;

                pDataParameters[4].Value = pucMatInspectDocumentListPopupEntity.MATSTOCK_ID;
                pDataParameters[5].Value = pucMatInspectDocumentListPopupEntity.MATSTOCK_DETAIL_SEQ;
                pDataParameters[6].Value = pucMatInspectDocumentListPopupEntity.INSPECT_ID;
                pDataParameters[7].Value = pucMatInspectDocumentListPopupEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMatInspectDocumentListPopup_R20", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucMatInspectDocumentListPopup_Info_Sub(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ucMatInspectDocumentListPopup_Info_Save(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity, DataTable pDataTable)
        public bool ucMatInspectDocumentListPopup_Info_Save(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity, DataTable pDataTable)
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
                                        new MySqlParameter("@v_matstock_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_matstock_detail_seq", MySqlDbType.VarChar, 8),
                                        new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
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
                                        new SqlParameter("@v_matstock_id", SqlDbType.NVarChar, 15),
                                        new SqlParameter("@v_matstock_detail_seq", SqlDbType.NVarChar, 8),
                                        new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                                        new SqlParameter("@v_document_id", SqlDbType.NVarChar, 15),
                                        new SqlParameter("@v_document_type", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                };
                                break;

                        }

                        pDataParameters[0].Value = pDataTable.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pucMatInspectDocumentListPopupEntity.USER_CODE;

                        pDataParameters[2].Value = pucMatInspectDocumentListPopupEntity.MATSTOCK_ID;
                        pDataParameters[3].Value = pucMatInspectDocumentListPopupEntity.MATSTOCK_DETAIL_SEQ;
                        pDataParameters[4].Value = pucMatInspectDocumentListPopupEntity.INSPECT_ID;
                        pDataParameters[5].Value = pDataTable.Rows[a]["DOCUMENT_ID"].ToString();
                        pDataParameters[6].Value = pDataTable.Rows[a]["DOCUMENT_TYPE"].ToString();
                        pDataParameters[7].Value = pDataTable.Rows[a]["REMARK"].ToString();
                        pDataParameters[8].Value = pDataTable.Rows[a]["USE_YN"].ToString().ToUpper() == "" ? "Y" : pDataTable.Rows[a]["USE_YN"].ToString().ToUpper();

                        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMatInspectDocumentListPopup_I10", pDataParameters);

                        if (pDataTableB.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pucMatInspectDocumentListPopupEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                        pucMatInspectDocumentListPopupEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();

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
                    "ucMatInspectDocumentListPopup_Info_Save(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity, DataTable pDataTable)",
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

        public override ucMatInspectDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity = new ucMatInspectDocumentListPopupEntity();
                pucMatInspectDocumentListPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucMatInspectDocumentListPopupEntity;
            }
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

    public class ucInspectRequestInfoPopupProvider : EntityManager<ucInspectRequestInfoPopupEntity>
    {
        #region 생성자 - ucInspectRequestInfoPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucInspectRequestInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ucInspectRequestInfoPopupEntity pucInspectRequestInfoPopupEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet ucInspectRequestInfo_Return(string pCRUD, string pFROM_DATE, string pTO_DATE, string pPART_NAME, string pPART_TYPE)
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
                            new MySqlParameter("@v_part_type", MySqlDbType.VarChar, 10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_type", SqlDbType.NVarChar, 10),
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pFROM_DATE;
                pDataParameters[2].Value = pTO_DATE;
                pDataParameters[3].Value = pPART_NAME;
                pDataParameters[4].Value = pPART_TYPE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucInspectRequestInfoPopup_R10", pDataParameters);
                

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
                    "Sample_Info_Mst(ucInspectRequestInfoPopupEntity pucInspectRequestInfoPopupEntity)",
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
        public bool ucInspectRequeest_Info_Check_Save(ucInspectRequestInfoPopupEntity pucInspectRequestInfoPopupEntity, DataTable dt)
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
                                            new MySqlParameter("@v_order_id              ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_part_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_inspect_date          ".Trim(), MySqlDbType.VarChar, 8),


                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_order_id              ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_part_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_inspect_date          ".Trim(), SqlDbType.VarChar, 8),
                                            

                                    };
                                    break;
                            }
                            pDataParametersA[0].Value = pucInspectRequestInfoPopupEntity.CRUD;
                            pDataParametersA[1].Value = pucInspectRequestInfoPopupEntity.USER_CODE;
                            pDataParametersA[2].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper();
                            pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                            pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");


                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucInspectRequestInfoPopup_I10", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            pucInspectRequestInfoPopupEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                            pucInspectRequestInfoPopupEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                            pucInspectRequestInfoPopupEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                            pucInspectRequestInfoPopupEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                            pucInspectRequestInfoPopupEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

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
        public override ucInspectRequestInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucInspectRequestInfoPopupEntity pucInspectRequestInfoPopupEntity = new ucInspectRequestInfoPopupEntity();

                pucInspectRequestInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucInspectRequestInfoPopupEntity;
            }
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

    public class ucImportInspectInfoPopupProvider : EntityManager<ucImportinspectInfoPopupEntity>
    {
        #region 생성자 - ucInspectRequestInfoPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucImportInspectInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ucInspectRequestInfoPopupEntity pucInspectRequestInfoPopupEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet ucImportInspectInfo_Return(string pCRUD, string pFROM_DATE, string pTO_DATE, string pPART_NAME, string pPART_TYPE)
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
                            new MySqlParameter("@v_part_type", MySqlDbType.VarChar, 10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_type", SqlDbType.NVarChar, 10),
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pFROM_DATE;
                pDataParameters[2].Value = pTO_DATE;
                pDataParameters[3].Value = pPART_NAME;
                pDataParameters[4].Value = pPART_TYPE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucImportInspectInfoPopup_R10", pDataParameters);


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
                    "Sample_Info_Mst(ucInspectRequestInfoPopupEntity pucInspectRequestInfoPopupEntity)",
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
        public bool ucInspectRequeest_Info_Check_Save(ucInspectRequestInfoPopupEntity pucInspectRequestInfoPopupEntity, DataTable dt)
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
                                            new MySqlParameter("@v_order_id              ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_part_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_inspect_date          ".Trim(), MySqlDbType.VarChar, 8),


                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_order_id              ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_part_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_inspect_date          ".Trim(), SqlDbType.VarChar, 8),


                                    };
                                    break;
                            }
                            pDataParametersA[0].Value = pucInspectRequestInfoPopupEntity.CRUD;
                            pDataParametersA[1].Value = pucInspectRequestInfoPopupEntity.USER_CODE;
                            pDataParametersA[2].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper();
                            pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                            pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");


                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucInspectRequestInfoPopup_I10", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            pucInspectRequestInfoPopupEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                            pucInspectRequestInfoPopupEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                            pucInspectRequestInfoPopupEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                            pucInspectRequestInfoPopupEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                            pucInspectRequestInfoPopupEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

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
        public override ucImportinspectInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucImportinspectInfoPopupEntity pucImportInspectRequestInfoPopupEntity = new ucImportinspectInfoPopupEntity();

                pucImportInspectRequestInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucImportInspectRequestInfoPopupEntity;
            }
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

    public class ucInspectRequestInfoPopup_T01Provider : EntityManager<ucInspectRequestInfoPopup_T01Entity>
    {
        #region 생성자 - ucInspectRequestInfoPopup_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucInspectRequestInfoPopup_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(ucInspectRequestInfoPopup_T01Entity pucInspectRequestInfoPopup_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet ucInspectRequestInfo_Return(string pCRUD, string pFROM_DATE, string pTO_DATE, string pPART_NAME, string pPART_TYPE)
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
                            new MySqlParameter("@v_part_type", MySqlDbType.VarChar, 10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_type", SqlDbType.NVarChar, 10),
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pFROM_DATE;
                pDataParameters[2].Value = pTO_DATE;
                pDataParameters[3].Value = pPART_NAME;
                pDataParameters[4].Value = pPART_TYPE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucInspectRequestInfoPopup_T01_R10", pDataParameters);


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
                    "ucInspectRequestInfo_Return(string pCRUD, string pFROM_DATE, string pTO_DATE, string pPART_NAME, string pPART_TYPE)",
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
        public bool ucInspectRequeest_Info_Check_Save(ucInspectRequestInfoPopup_T01Entity pucInspectRequestInfoPopup_T01Entity, DataTable dt)
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
                        if (dt.Rows[a]["CHECK_VALUE"].ToString() == "Y")
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
                                            new MySqlParameter("@v_order_id              ".Trim(), MySqlDbType.VarChar, 15),
                                            new MySqlParameter("@v_part_code             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_inspect_date          ".Trim(), MySqlDbType.VarChar, 8),


                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_order_id              ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_part_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_inspect_date          ".Trim(), SqlDbType.VarChar, 8),


                                    };
                                    break;
                            }
                            pDataParametersA[0].Value = pucInspectRequestInfoPopup_T01Entity.CRUD;
                            pDataParametersA[1].Value = pucInspectRequestInfoPopup_T01Entity.USER_CODE;
                            pDataParametersA[2].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper();
                            pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                            pDataParametersA[4].Value = DateTime.Now.ToString("yyyyMMdd");


                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucInspectRequestInfoPopup_T01_I10", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            pucInspectRequestInfoPopup_T01Entity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                            pucInspectRequestInfoPopup_T01Entity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                            pucInspectRequestInfoPopup_T01Entity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                            pucInspectRequestInfoPopup_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                            pucInspectRequestInfoPopup_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

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
                    "ucInspectRequeest_Info_Check_Save(ucInspectRequestInfoPopup_T01Entity pucInspectRequestInfoPopup_T01Entity, DataTable dt)",
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
        public override ucInspectRequestInfoPopup_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucInspectRequestInfoPopup_T01Entity pucInspectRequestInfoPopup_T01Entity = new ucInspectRequestInfoPopup_T01Entity();

                pucInspectRequestInfoPopup_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucInspectRequestInfoPopup_T01Entity;
            }
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


    public class RawMaterialInspectRegisterProvider : EntityManager<RawMaterialInspectRegisterEntity>
    {
        #region 생성자 - RawMaterialInspectRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public RawMaterialInspectRegisterProvider(DBManager pDBManager)
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
        public DataTable Sheet_Info_sheet(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)
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

                pDataParameters[0].Value = pRawMaterialInspectRegisterEntity.CRUD;
                pDataParameters[1].Value = pRawMaterialInspectRegisterEntity.WINDOW_NAME;
                pDataParameters[2].Value = pRawMaterialInspectRegisterEntity.LANGUAGE_TYPE;

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

        #region 마스터 조회하기 - Sample_Info_Mst(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)
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
                            new MySqlParameter("@v_inspect_status", MySqlDbType.VarChar, 10),
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
                            new SqlParameter("@v_inspect_status", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                 pDataParameters[0].Value = pRawMaterialInspectRegisterEntity.CRUD;
                 pDataParameters[1].Value = pRawMaterialInspectRegisterEntity.DATE_FROM;
                 pDataParameters[2].Value = pRawMaterialInspectRegisterEntity.DATE_TO;
                 pDataParameters[3].Value = pRawMaterialInspectRegisterEntity.PART_CODE;
                 pDataParameters[4].Value = pRawMaterialInspectRegisterEntity.PART_NAME;
                 pDataParameters[5].Value = pRawMaterialInspectRegisterEntity.INSPECT_STATUS;
                 pDataParameters[6].Value = pRawMaterialInspectRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RawMaterialInspectRegister_R10", pDataParameters);

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

        public DataSet RawMaterialInspectRegister_info_ExcelBinding(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)
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

                pDataParameters[0].Value = pRawMaterialInspectRegisterEntity.INSPECT_ID;
                pDataParameters[1].Value = pRawMaterialInspectRegisterEntity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_RawMaterialInspectRegister_R20", pDataParameters);

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
                    "Sample_Info_Mst(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)",
                    pException
                );
            }

        }
        #endregion

        #region 정보 저장하기 - Sample_Info_Save(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool RawMaterialInspectRegister_Info_Mst_Save(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity,Worksheet sheet_1)
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
                                new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_packing_remark", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_sample_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_sample_location", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_sample_user", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_method", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_total_result", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_total_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_total_user", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_writer", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_checker", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_approver", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_end_date", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 2000)


                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_packing_remark", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_sample_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_sample_location", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_sample_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_method", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_total_result", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_total_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_total_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_writer", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_checker", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_approver", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_end_date", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 200),
                        };
                        break;
                }

                pDataParametersA[0].Value = pRawMaterialInspectRegisterEntity.CRUD;
                pDataParametersA[1].Value = pRawMaterialInspectRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pRawMaterialInspectRegisterEntity.INSPECT_ID;
                pDataParametersA[3].Value = sheet_1.GetCellValue(8, 8).ToString();//sheet_1.GetCellValue(6, 6).ToString();//포장상태
                pDataParametersA[4].Value = sheet_1.Cells[9, 8].DisplayText.Replace("-", ""); ;// sheet_1.Cells[7, 6].DisplayText.Replace("-", ""); //sheet_1.GetCellValue(6, 7).ToString().Replace("-", "");//검체채취일
                pDataParametersA[5].Value = sheet_1.GetCellValue(13, 6).ToString(); ;// sheet_1.GetCellValue(10, 4).ToString();//검체채취장소
                pDataParametersA[6].Value = sheet_1.GetCellValue(13, 7).ToString(); ;// sheet_1.GetCellValue(10, 5).ToString();//검체채취자
                pDataParametersA[7].Value = sheet_1.GetCellValue(13, 8).ToString(); //sheet_1.GetCellValue(10, 6).ToString();//검체채취방법
                pDataParametersA[8].Value = sheet_1.GetCellValue(13, 9).ToString() == "" ? "0" : sheet_1.GetCellValue(13, 9).ToString();    //검체채취량
                pDataParametersA[9].Value = sheet_1.GetCellValue(3, 39).ToString(); ;// sheet_1.GetCellValue(1, 27).ToString(); //종합판정
                pDataParametersA[10].Value = sheet_1.Cells[40, 3].DisplayText.Replace("-", ""); // sheet_1.GetCellValue(3, 27).ToString().Replace("-", "");//종합판정일

                pDataParametersA[11].Value = sheet_1.GetCellValue(3, 41).ToString(); ;//sheet_1.GetCellValue(5, 27).ToString();//판정자
                pDataParametersA[12].Value = sheet_1.GetCellValue(8, 40).ToString();//작성자//sheet_1.GetCellValue(5, 27).ToString();//작성자 - 담당자
                pDataParametersA[13].Value = "";//sheet_1.GetCellValue(5, 27).ToString();//검토자
                pDataParametersA[14].Value = sheet_1.GetCellValue(11, 40).ToString(); ;// sheet_1.GetCellValue(5, 27).ToString();//확인자(승인자)

                pDataParametersA[15].Value = "".Replace("-", "");        //사용기한
                pDataParametersA[16].Value = sheet_1.GetCellValue(0, 26).ToString();//비고

                //20190118
                /*
                pDataParametersA[0].Value = pRawMaterialInspectRegisterEntity.CRUD;
                pDataParametersA[1].Value = pRawMaterialInspectRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pRawMaterialInspectRegisterEntity.INSPECT_ID;
                pDataParametersA[3].Value = sheet_1.GetCellValue(6, 6).ToString();
                pDataParametersA[4].Value = sheet_1.Cells[7,6].DisplayText.Replace("-", ""); //sheet_1.GetCellValue(6, 7).ToString().Replace("-", "");
                pDataParametersA[5].Value = sheet_1.GetCellValue(10, 4).ToString();
                pDataParametersA[6].Value = sheet_1.GetCellValue(10, 5).ToString();
                pDataParametersA[7].Value = sheet_1.GetCellValue(10, 6).ToString();
                pDataParametersA[8].Value = sheet_1.GetCellValue(10, 7).ToString() == ""?"0" : sheet_1.GetCellValue(10, 7).ToString();
                pDataParametersA[9].Value = sheet_1.GetCellValue(1, 27).ToString();
                pDataParametersA[10].Value = sheet_1.Cells[27,3].DisplayText.Replace("-", ""); // sheet_1.GetCellValue(3, 27).ToString().Replace("-", "");
                pDataParametersA[11].Value = sheet_1.GetCellValue(5, 27).ToString();
                pDataParametersA[12].Value = "";//sheet_1.GetCellValue(5, 27).ToString();
                pDataParametersA[13].Value = "";//sheet_1.GetCellValue(5, 27).ToString();
                pDataParametersA[14].Value = sheet_1.GetCellValue(7, 27).ToString(); ;// sheet_1.GetCellValue(5, 27).ToString();
                pDataParametersA[15].Value = "".Replace("-", "");        //사용기한
                pDataParametersA[16].Value = sheet_1.GetCellValue(0, 22).ToString();
                */


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RawMaterialInspectRegister_I10", pDataParametersA);

                pRawMaterialInspectRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pRawMaterialInspectRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pRawMaterialInspectRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pRawMaterialInspectRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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

        #region 정보 저장하기 - Sample_Info_Save(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool RawMaterialInspectRegister_Info_Detail_Save(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                int rowcnt = pRawMaterialInspectRegisterEntity.dtListCnt;
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
                                new MySqlParameter("@v_inspect_decision", MySqlDbType.VarChar,50)

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

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pRawMaterialInspectRegisterEntity.CRUD;
                    pDataParametersA[1].Value = pRawMaterialInspectRegisterEntity.USER_CODE;
                    pDataParametersA[2].Value = pRawMaterialInspectRegisterEntity.INSPECT_ID;
                    pDataParametersA[3].Value = sheet_1.GetCellValue(0, i + 1).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(3, i + 1).ToString();
                    pDataParametersA[5].Value = sheet_1.Cells[i + 1, 4].DisplayText.Replace("-", ""); // sheet_1.GetCellValue(4, i + 1).ToString().Replace("-", "");
                    pDataParametersA[6].Value = sheet_1.GetCellValue(5, i + 1).ToString();
                    pDataParametersA[7].Value = sheet_1.GetCellValue(6, i + 1).ToString();//v_inspect_user

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RawMaterialInspectRegister_I20", pDataParametersA);

                pRawMaterialInspectRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pRawMaterialInspectRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pRawMaterialInspectRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pRawMaterialInspectRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override RawMaterialInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity = new RawMaterialInspectRegisterEntity();

                pRawMaterialInspectRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pRawMaterialInspectRegisterEntity;
            }
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

    public class RawMaterialInspectRegisterT01Provider : EntityManager<RawMaterialInspectRegisterT01Entity>
    {
        #region 생성자 - RawMaterialInspectRegisterT01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public RawMaterialInspectRegisterT01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)
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
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_inspect_status", MySqlDbType.VarChar, 10),
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
                            new SqlParameter("@v_vend_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_inspect_status", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pRawMaterialInspectRegisterT01Entity.CRUD;
                pDataParameters[1].Value = pRawMaterialInspectRegisterT01Entity.DATE_FROM;
                pDataParameters[2].Value = pRawMaterialInspectRegisterT01Entity.DATE_TO;
                pDataParameters[3].Value = pRawMaterialInspectRegisterT01Entity.VEND_PART_CODE;
                pDataParameters[4].Value = pRawMaterialInspectRegisterT01Entity.PART_NAME;
                pDataParameters[5].Value = pRawMaterialInspectRegisterT01Entity.INSPECT_STATUS;
                pDataParameters[6].Value = pRawMaterialInspectRegisterT01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RawMaterialInspectRegister_T01_R10", pDataParameters);

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
                    "Sample_Info_Mst(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)",
                    pException
                );
            }

        }

        public DataSet RawMaterialInspectRegister_info_ExcelBinding(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)
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

                pDataParameters[0].Value = pRawMaterialInspectRegisterEntity.INSPECT_ID;
                pDataParameters[1].Value = pRawMaterialInspectRegisterEntity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_RawMaterialInspectRegister_T01_R20", pDataParameters);

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
                    "Sample_Info_Mst(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)",
                    pException
                );
            }

        }
        #endregion

        #region 서브 조회하기 - Sample_Info_Sub(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)
        public DataTable Sample_Info_Sub(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)
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
                            new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 50)
                                    
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_reference_id", SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pRawMaterialInspectRegisterT01Entity.CRUD;
                pDataParameters[1].Value = pRawMaterialInspectRegisterT01Entity.REFERENCE_ID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RawMaterialInspectRegister_T01_R20", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Sample_Info_Sub(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)",
                    pException
                );
            }
        }
        #endregion

        #region 정보 저장하기 - RawMaterialInspectRegisterT01_Info_Mst_Save(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pRawMaterialInspectRegisterT01Entity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool RawMaterialInspectRegisterT01_Info_Mst_Save(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity, DataTable dt)
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
                                new MySqlParameter("@v_reference_id", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_part_lot_id", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_weight", MySqlDbType.Decimal)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_reference_id", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_part_lot_id", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_weight", SqlDbType.Decimal)
                        };
                        break;
                }

                pDataParametersA[0].Value = pRawMaterialInspectRegisterT01Entity.CRUD;
                pDataParametersA[1].Value = pRawMaterialInspectRegisterT01Entity.USER_CODE;
                pDataParametersA[2].Value = pRawMaterialInspectRegisterT01Entity.REFERENCE_ID;
                pDataParametersA[3].Value = pRawMaterialInspectRegisterT01Entity.PART_LOT_ID;
                pDataParametersA[4].Value = pRawMaterialInspectRegisterT01Entity.WEIGHT;


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RawMaterialInspectRegister_T01_I10", pDataParametersA);

                pRawMaterialInspectRegisterT01Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pRawMaterialInspectRegisterT01Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pRawMaterialInspectRegisterT01Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pRawMaterialInspectRegisterT01Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();

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
                            //마스터 저장
                            IDataParameter[] pDataParametersB = null;

                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                        new MySqlParameter("@v_part_weight_id", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_weight_seq", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_coil_id", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_weight", MySqlDbType.Decimal)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                        new SqlParameter("@v_part_weight_id", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_weight_seq", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_coil_id", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_weight", SqlDbType.Decimal)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = dt.Rows[i]["CRUD"].ToString();
                            pDataParametersB[1].Value = pRawMaterialInspectRegisterT01Entity.USER_CODE;
                            pDataParametersB[2].Value = pRawMaterialInspectRegisterT01Entity.PART_WEIGHT_ID;
                            pDataParametersB[3].Value = dt.Rows[i]["WEIGHT_SEQ"].ToString();
                            pDataParametersB[4].Value = dt.Rows[i]["COIL_ID"].ToString();
                            pDataParametersB[5].Value = dt.Rows[i]["WEIGHT"].ToString();

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RawMaterialInspectRegister_T01_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
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
                    "RawMaterialInspectRegisterT01_Info_Mst_Save(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)",
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

        #region 정보 저장하기 - RawMaterialInspectRegisterT01_Info_Detail_Save(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool RawMaterialInspectRegisterT01_Info_Detail_Save(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                int rowcnt = pRawMaterialInspectRegisterT01Entity.dtListCnt;
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

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pRawMaterialInspectRegisterT01Entity.CRUD;
                    pDataParametersA[1].Value = pRawMaterialInspectRegisterT01Entity.USER_CODE;
                    pDataParametersA[2].Value = pRawMaterialInspectRegisterT01Entity.INSPECT_ID;

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RawMaterialInspectRegister_T01_I20", pDataParametersA);

                    pRawMaterialInspectRegisterT01Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pRawMaterialInspectRegisterT01Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pRawMaterialInspectRegisterT01Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pRawMaterialInspectRegisterT01Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "RawMaterialInspectRegisterT01_Info_Detail_Save(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)",
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
        public override RawMaterialInspectRegisterT01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity = new RawMaterialInspectRegisterT01Entity();

                pRawMaterialInspectRegisterT01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pRawMaterialInspectRegisterT01Entity;
            }
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


    public class ucInspectPartListPopupProvider : EntityManager<ucInspectPartListPopupEntity>
    {
        #region 생성자 - ucInspectPartListPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucInspectPartListPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 조회하기 ucInspectPartListPopup_Info_Return(ucInspectPartListPopupEntity pucInspectPartListPopupEntity)

        public DataTable ucInspectPartListPopup_Info_Return(ucInspectPartListPopupEntity pucInspectPartListPopupEntity)
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

                pDataParameters[0].Value = pucInspectPartListPopupEntity.CRUD;
                pDataParameters[1].Value = pucInspectPartListPopupEntity.VEND_PART_CODE;
                pDataParameters[2].Value = pucInspectPartListPopupEntity.PART_NAME;
                pDataParameters[3].Value = pucInspectPartListPopupEntity.PART_REVISION_NO;
                pDataParameters[4].Value = pucInspectPartListPopupEntity.PART_HIGH;
                pDataParameters[5].Value = pucInspectPartListPopupEntity.PART_MIDDLE;
                pDataParameters[6].Value = pucInspectPartListPopupEntity.PART_LOW;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucInspectPartListPopup_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucInspectPartListPopup_Info_Return(ucInspectPartListPopupEntity pucInspectPartListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucInspectPartListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucInspectPartListPopupEntity pucInspectPartListPopupEntity = new ucInspectPartListPopupEntity();
                return pucInspectPartListPopupEntity;
            }
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

    public class MaterialInspectRegisterProvider : EntityManager<MaterialInspectRegisterEntity>
    {
        #region 생성자 - MaterialInspectRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MaterialInspectRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMaterialInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)
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

                pDataParameters[0].Value = pMaterialInspectRegisterEntity.CRUD;
                pDataParameters[1].Value = pMaterialInspectRegisterEntity.WINDOW_NAME;
                pDataParameters[2].Value = pMaterialInspectRegisterEntity.LANGUAGE_TYPE;

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

        #region 마스터 조회하기 - Sample_Info_Mst(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)
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
                            new MySqlParameter("@v_inspect_status", MySqlDbType.VarChar, 10),
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
                            new SqlParameter("@v_inspect_status", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pMaterialInspectRegisterEntity.CRUD;
                pDataParameters[1].Value = pMaterialInspectRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pMaterialInspectRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pMaterialInspectRegisterEntity.PART_CODE;
                pDataParameters[4].Value = pMaterialInspectRegisterEntity.PART_NAME;
                pDataParameters[5].Value = pMaterialInspectRegisterEntity.INSPECT_STATUS;
                pDataParameters[6].Value = pMaterialInspectRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialInspectRegister_R10", pDataParameters);

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
                    "Sample_Info_Mst(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)",
                    pException
                );
            }

        }

        public DataSet MaterialInspectRegister_info_ExcelBinding(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)
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

                pDataParameters[0].Value = pMaterialInspectRegisterEntity.INSPECT_ID;
                pDataParameters[1].Value = pMaterialInspectRegisterEntity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_MaterialInspectRegister_R20", pDataParameters);

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
                    "Sample_Info_Mst(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)",
                    pException
                );
            }

        }
        #endregion

        #region 정보 저장하기 - Sample_Info_Save(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MaterialInspectRegister_Info_Mst_Save(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_inout_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_make_no", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_request_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_standard", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_sample_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_request_user", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_result", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_total_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_total_user", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_writer", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_checker", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_approver", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_end_date", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 2000),
                                new MySqlParameter("@v_file_name", MySqlDbType.VarChar, 2000)


                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_inout_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_make_no", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_request_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_standard", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_sample_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_request_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_result", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_total_date", SqlDbType.VarChar, 8),
                                new SqlParameter("@v_total_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_writer", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_checker", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_approver", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_end_date", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 2000),
                                new SqlParameter("@v_file_name", SqlDbType.NVarChar, 2000)
                        };
                        break;
                }

                pDataParametersA[0].Value = pMaterialInspectRegisterEntity.CRUD;
                pDataParametersA[1].Value = pMaterialInspectRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pMaterialInspectRegisterEntity.INSPECT_ID;
                pDataParametersA[3].Value = sheet_1.Cells[3, 4].DisplayText.Replace("-","");// DateTime.Parse(sheet_1.GetCellValue(4, 3).ToString()).ToString("yyyyMMdd");//sheet_1.GetCellValue(4, 3).ToString().Replace("-", "");
                pDataParametersA[4].Value = sheet_1.GetCellValue(1, 3).ToString();
                pDataParametersA[5].Value = sheet_1.Cells[3, 8].DisplayText.Replace("-", "");//DateTime.Parse(sheet_1.GetCellValue(8, 3).ToString()).ToString("yyyyMMdd");// sheet_1.GetCellValue(8, 3).ToString().Replace("-", "");
                pDataParametersA[6].Value = sheet_1.GetCellValue(1, 4).ToString();
                pDataParametersA[7].Value = sheet_1.Cells[4, 4].DisplayText.Replace("-", "");//DateTime.Parse(sheet_1.GetCellValue(4, 4).ToString()).ToString("yyyyMMdd");//sheet_1.GetCellValue(4, 4).ToString().Replace("-", "");
                pDataParametersA[8].Value = sheet_1.GetCellValue(8, 4).ToString();
                pDataParametersA[9].Value = sheet_1.GetCellValue(2, 31).ToString();
                pDataParametersA[10].Value = sheet_1.Cells[33, 2].DisplayText.Replace("-", "");//DateTime.Parse(sheet_1.GetCellValue(2, 33).ToString()).ToString("yyyyMMdd");// sheet_1.GetCellValue(2, 33).ToString().Replace("-", "");
                pDataParametersA[11].Value = sheet_1.GetCellValue(2, 34).ToString();
                pDataParametersA[12].Value = sheet_1.GetCellValue(7, 33).ToString();//sheet_1.GetCellValue(2, 34).ToString();
                pDataParametersA[13].Value = sheet_1.GetCellValue(8, 33).ToString(); ;//sheet_1.GetCellValue(2, 34).ToString();
                pDataParametersA[14].Value = sheet_1.GetCellValue(9, 33).ToString(); ;// sheet_1.GetCellValue(2, 34).ToString();
                pDataParametersA[15].Value = "";        //사용기한
                pDataParametersA[16].Value = sheet_1.GetCellValue(0, 28).ToString();
                pDataParametersA[17].Value = pMaterialInspectRegisterEntity.FILE_NAME;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialInspectRegister_I10", pDataParametersA);

                pMaterialInspectRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pMaterialInspectRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pMaterialInspectRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pMaterialInspectRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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

        #region 정보 저장하기 - Sample_Info_Save(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MaterialInspectRegister_Info_Detail_Save(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                int rowcnt = pMaterialInspectRegisterEntity.dtListCnt;
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

                    pDataParametersA[0].Value = pMaterialInspectRegisterEntity.CRUD;
                    pDataParametersA[1].Value = pMaterialInspectRegisterEntity.USER_CODE;
                    pDataParametersA[2].Value = pMaterialInspectRegisterEntity.INSPECT_ID;
                    pDataParametersA[3].Value =  sheet_1.GetCellValue(0, i + 1).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(3, i + 1).ToString();
                    pDataParametersA[5].Value = sheet_1.Cells[i + 1, 5].DisplayText.Replace("-", ""); // sheet_1.GetCellValue(5, i + 1).ToString().Replace("-", "");
                    pDataParametersA[6].Value = sheet_1.GetCellValue(6, i + 1).ToString();
                    pDataParametersA[7].Value = sheet_1.GetCellValue(4, i + 1).ToString();//v_inspect_user
                    pDataParametersA[8].Value = sheet_1.GetCellValue(7, i + 1).ToString();//v_inspect_user

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialInspectRegister_I20", pDataParametersA);

                    pMaterialInspectRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pMaterialInspectRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pMaterialInspectRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pMaterialInspectRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override MaterialInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MaterialInspectRegisterEntity pMaterialInspectRegisterEntity = new MaterialInspectRegisterEntity();

                pMaterialInspectRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pMaterialInspectRegisterEntity;
            }
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
    //

    public class SemiProductInspectRegisterProvider : EntityManager<SemiProductInspectRegisterEntity>
    {
        #region 생성자 - SemiProductInspectRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SemiProductInspectRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSemiProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)
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

                pDataParameters[0].Value = pSemiProductInspectRegisterEntity.CRUD;
                pDataParameters[1].Value = pSemiProductInspectRegisterEntity.WINDOW_NAME;
                pDataParameters[2].Value = pSemiProductInspectRegisterEntity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - Sample_Info_Mst(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)
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
                            new MySqlParameter("@v_inspect_status", MySqlDbType.VarChar, 10),
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
                            new SqlParameter("@v_inspect_status", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pSemiProductInspectRegisterEntity.CRUD;
                pDataParameters[1].Value = pSemiProductInspectRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pSemiProductInspectRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pSemiProductInspectRegisterEntity.PART_CODE;
                pDataParameters[4].Value = pSemiProductInspectRegisterEntity.PART_NAME;
                pDataParameters[5].Value = pSemiProductInspectRegisterEntity.INSPECT_STATUS;
                pDataParameters[6].Value = pSemiProductInspectRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SemiProductInspectRegister_R10", pDataParameters);

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
                    "Sample_Info_Mst(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)",
                    pException
                );
            }

        }

        public DataSet SemiProductInspectRegister_info_ExcelBinding(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)
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

                pDataParameters[0].Value = pSemiProductInspectRegisterEntity.INSPECT_ID;
                pDataParameters[1].Value = pSemiProductInspectRegisterEntity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_SemiProductInspectRegister_R20", pDataParameters);

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
                    "Sample_Info_Mst(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)",
                    pException
                );
            }

        }
        #endregion

        #region 정보 저장하기 - Sample_Info_Save(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool SemiProductInspectRegister_Info_Mst_Save(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_inspect_no", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_make_no", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_packing_remark", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_sample_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_sample_location", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_sample_user", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_method", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_total_result", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_total_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_total_user", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_writer", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_checker", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_approver", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_end_date", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 2000)


                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_inspect_no", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_make_no", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_packing_remark", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_sample_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_sample_location", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_sample_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_method", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_total_result", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_total_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_total_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_writer", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_checker", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_approver", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_end_date", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 2000),
                        };
                        break;
                }

                pDataParametersA[0].Value = pSemiProductInspectRegisterEntity.CRUD;
                pDataParametersA[1].Value = pSemiProductInspectRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pSemiProductInspectRegisterEntity.INSPECT_ID;
                pDataParametersA[3].Value = sheet_1.GetCellValue(13, 5).ToString();  //시험번호
                pDataParametersA[4].Value = sheet_1.GetCellValue(1, 2).ToString();  //제조번호
                pDataParametersA[5].Value = sheet_1.GetCellValue(4, 6).ToString();  //
                pDataParametersA[6].Value = sheet_1.Cells[4, 13].DisplayText.Replace("-", ""); //sheet_1.GetCellValue(13, 4).ToString().Replace("-", "");  //검체채취일
                pDataParametersA[7].Value = sheet_1.GetCellValue(1, 4).ToString();  //검체채취장소
                pDataParametersA[8].Value = sheet_1.GetCellValue(6, 4).ToString();  //검체채취자
                pDataParametersA[9].Value = sheet_1.GetCellValue(1, 5).ToString();  //검체채취방법
                pDataParametersA[10].Value = sheet_1.GetCellValue(6, 5).ToString() == "" ? "0" : sheet_1.GetCellValue(6, 5).ToString();  //검체채취량
                
                pDataParametersA[11].Value = sheet_1.GetCellValue(2, 28).ToString();  //종합판정
                pDataParametersA[12].Value = sheet_1.Cells[29, 2].DisplayText.Replace("-", ""); //sheet_1.GetCellValue(2, 29).ToString().Replace("-", "");  //판정일자
                pDataParametersA[13].Value = sheet_1.GetCellValue(2, 30).ToString();  //판정자

                pDataParametersA[14].Value = sheet_1.GetCellValue(8, 29).ToString();  //작성자
                pDataParametersA[15].Value = sheet_1.GetCellValue(11, 29).ToString();  //검토자
                pDataParametersA[16].Value = sheet_1.GetCellValue(14, 29).ToString();  //승인자
                pDataParametersA[17].Value = "";    //사용기한
                pDataParametersA[18].Value = sheet_1.GetCellValue(0, 21).ToString();  //비고

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SemiProductInspectRegister_I10", pDataParametersA);

                pSemiProductInspectRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pSemiProductInspectRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pSemiProductInspectRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pSemiProductInspectRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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

        #region 정보 저장하기 - Sample_Info_Save(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool SemiProductInspectRegister_Info_Detail_Save(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                int rowcnt = pSemiProductInspectRegisterEntity.dtListCnt;
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
                                new MySqlParameter("@v_inspect_decision", MySqlDbType.VarChar,50)

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

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pSemiProductInspectRegisterEntity.CRUD;         
                    pDataParametersA[1].Value = pSemiProductInspectRegisterEntity.USER_CODE;
                    pDataParametersA[2].Value = pSemiProductInspectRegisterEntity.INSPECT_ID;   
                    pDataParametersA[3].Value = sheet_1.GetCellValue(0, i + 1).ToString();  //시험항목(코드)
                    pDataParametersA[4].Value = sheet_1.GetCellValue(3, i + 1).ToString();  //시험결과
                    pDataParametersA[5].Value = sheet_1.GetCellValue(4, i + 1).ToString().Replace("-", "");  //시험일자
                    pDataParametersA[6].Value = sheet_1.GetCellValue(5, i + 1).ToString();  //시험자
                    pDataParametersA[7].Value = sheet_1.GetCellValue(6, i + 1).ToString();  //판정

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SemiProductInspectRegister_I20", pDataParametersA);

                    pSemiProductInspectRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pSemiProductInspectRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pSemiProductInspectRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pSemiProductInspectRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override SemiProductInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity = new SemiProductInspectRegisterEntity();

                pSemiProductInspectRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pSemiProductInspectRegisterEntity;
            }
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
    public class ProductInspectRegisterProvider : EntityManager<ProductInspectRegisterEntity>
    {
        #region 생성자 - ProductInspectRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductInspectRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(ProductInspectRegisterEntity pProductInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(ProductInspectRegisterEntity pProductInspectRegisterEntity)
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

                pDataParameters[0].Value = pProductInspectRegisterEntity.CRUD;
                pDataParameters[1].Value = pProductInspectRegisterEntity.WINDOW_NAME;
                pDataParameters[2].Value = pProductInspectRegisterEntity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - Sample_Info_Mst(ProductInspectRegisterEntity pProductInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(ProductInspectRegisterEntity pProductInspectRegisterEntity)
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
                            new MySqlParameter("@v_inspect_status", MySqlDbType.VarChar, 10),
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
                            new SqlParameter("@v_inspect_status", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pProductInspectRegisterEntity.CRUD;
                pDataParameters[1].Value = pProductInspectRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pProductInspectRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pProductInspectRegisterEntity.PART_CODE;
                pDataParameters[4].Value = pProductInspectRegisterEntity.PART_NAME;
                pDataParameters[5].Value = pProductInspectRegisterEntity.INSPECT_STATUS;
                pDataParameters[6].Value = pProductInspectRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductInspectRegister_R10", pDataParameters);

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
                    "Sample_Info_Mst(ProductInspectRegisterEntity pProductInspectRegisterEntity)",
                    pException
                );
            }

        }

        public DataSet ProductInspectRegister_info_ExcelBinding(ProductInspectRegisterEntity pProductInspectRegisterEntity)
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

                pDataParameters[0].Value = pProductInspectRegisterEntity.INSPECT_ID;
                pDataParameters[1].Value = pProductInspectRegisterEntity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ProductInspectRegister_R20", pDataParameters);

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
                    "Sample_Info_Mst(ProductInspectRegisterEntity pProductInspectRegisterEntity)",
                    pException
                );
            }

        }
        #endregion

        #region 정보 저장하기 - Sample_Info_Save(ProductInspectRegisterEntity pProductInspectRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ProductInspectRegister_Info_Mst_Save(ProductInspectRegisterEntity pProductInspectRegisterEntity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_packing_remark", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_sample_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_sample_location", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_sample_user", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_method", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_total_result", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_total_date", MySqlDbType.VarChar, 8),
                                new MySqlParameter("@v_total_user", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_writer", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_checker", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_approver", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_end_date", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 2000)


                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_packing_remark", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_sample_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_sample_location", SqlDbType.NVarChar,100),
                                new SqlParameter("@v_sample_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_method", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_total_result", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_total_date", SqlDbType.NVarChar, 8),
                                new SqlParameter("@v_total_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_writer", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_checker", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_approver", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_end_date", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 200),
                        };
                        break;
                }

                pDataParametersA[0].Value = pProductInspectRegisterEntity.CRUD;
                pDataParametersA[1].Value = pProductInspectRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pProductInspectRegisterEntity.INSPECT_ID;
                pDataParametersA[3].Value = sheet_1.Cells[4, 13].DisplayText.Replace("-", ""); //sheet_1.GetCellValue(13, 4).ToString().Replace("-","");  //포장상태,포장일
                pDataParametersA[4].Value = "";// sheet_1.GetCellValue(4, 7).ToString().Replace("-","");  //검체채취일
                pDataParametersA[5].Value = sheet_1.GetCellValue(2, 6).ToString();  //검체채취장소
                pDataParametersA[6].Value = sheet_1.GetCellValue(8, 6).ToString();  //검체채취자
                pDataParametersA[7].Value = sheet_1.GetCellValue(2, 7).ToString();  //검체채취방법  
                pDataParametersA[8].Value = sheet_1.GetCellValue(8, 7).ToString() == "" ? "0" : sheet_1.GetCellValue(8, 7).ToString();//검체채취량

                pDataParametersA[9].Value  = sheet_1.GetCellValue(3, 28).ToString();    //종합판정
                pDataParametersA[10].Value = sheet_1.Cells[29, 3].DisplayText.Replace("-", ""); //sheet_1.GetCellValue(3, 29).ToString().Replace("-","");    //판정일자
                pDataParametersA[11].Value = sheet_1.GetCellValue(3, 30).ToString();    //판정자
                    
                pDataParametersA[12].Value = sheet_1.GetCellValue(8, 29).ToString();// sheet_1.GetCellValue(3, 33).ToString();  //담당자
                pDataParametersA[13].Value = sheet_1.GetCellValue(11, 29).ToString();//sheet_1.GetCellValue(3, 33).ToString();  //검토자
                pDataParametersA[14].Value = sheet_1.GetCellValue(14, 29).ToString();// sheet_1.GetCellValue(3, 33).ToString(); //승인자
                pDataParametersA[15].Value = sheet_1.GetCellValue(13, 6).ToString(); //사용기한
                pDataParametersA[16].Value = sheet_1.GetCellValue(0, 21).ToString(); //비고

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductInspectRegister_I10", pDataParametersA);

                pProductInspectRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pProductInspectRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pProductInspectRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pProductInspectRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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

        #region 정보 저장하기 - Sample_Info_Save(ProductInspectRegisterEntity pProductInspectRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ProductInspectRegister_Info_Detail_Save(ProductInspectRegisterEntity pProductInspectRegisterEntity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                int rowcnt = pProductInspectRegisterEntity.dtListCnt;
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
                                new MySqlParameter("@v_inspect_decision", MySqlDbType.VarChar,50)

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

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pProductInspectRegisterEntity.CRUD;
                    pDataParametersA[1].Value = pProductInspectRegisterEntity.USER_CODE;
                    pDataParametersA[2].Value = pProductInspectRegisterEntity.INSPECT_ID;
                    pDataParametersA[3].Value = sheet_1.GetCellValue(0, i + 1).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(3, i + 1).ToString();
                    pDataParametersA[5].Value = sheet_1.GetCellValue(4, i + 1).ToString().Replace("-","");
                    pDataParametersA[6].Value = sheet_1.GetCellValue(5, i + 1).ToString();
                    pDataParametersA[7].Value = sheet_1.GetCellValue(6, i + 1).ToString();//v_inspect_user

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductInspectRegister_I20", pDataParametersA);

                    pProductInspectRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pProductInspectRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pProductInspectRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pProductInspectRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override ProductInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductInspectRegisterEntity pProductInspectRegisterEntity = new ProductInspectRegisterEntity();

                pProductInspectRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProductInspectRegisterEntity;
            }
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

    public class InspectFinalApprovalRegisterProvider : EntityManager<InspectFinalApprovalRegisterEntity>
    {
        #region 생성자 - InspectFinalApprovalRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public InspectFinalApprovalRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pInspectFinalApprovalRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(string crud, string p_window_name, string p_language_type)
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

                pDataParameters[0].Value = crud;
                pDataParameters[1].Value = p_window_name;
                pDataParameters[2].Value = p_language_type;

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

        #region 마스터 조회하기 - Sample_Info_Mst(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)
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
                            new MySqlParameter("@v_part_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_approval_yn", MySqlDbType.VarChar, 10),
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
                            new SqlParameter("@v_part_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_approval_yn", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pInspectFinalApprovalRegisterEntity.CRUD;
                pDataParameters[1].Value = pInspectFinalApprovalRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pInspectFinalApprovalRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pInspectFinalApprovalRegisterEntity.PART_CODE;
                pDataParameters[4].Value = pInspectFinalApprovalRegisterEntity.PART_NAME;
                pDataParameters[5].Value = pInspectFinalApprovalRegisterEntity.PART_TYPE;
                pDataParameters[6].Value = pInspectFinalApprovalRegisterEntity.APPROVAL_YN;
                pDataParameters[7].Value = pInspectFinalApprovalRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectFinalApprovalRegister_R10", pDataParameters);

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

        public DataSet InspectFinalApprovalRegister_info_ExcelBinding(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)
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

                pDataParameters[0].Value = pInspectFinalApprovalRegisterEntity.INSPECT_ID;
                pDataParameters[1].Value = pInspectFinalApprovalRegisterEntity.LANGUAGE_TYPE;

                DataSet pDataSet =null;
                if (pInspectFinalApprovalRegisterEntity.PART_TYPE == "1001")
                {
                    pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ProductInspectRegister_R20", pDataParameters);
                }
                else if (pInspectFinalApprovalRegisterEntity.PART_TYPE == "1003")
                {
                    pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_SemiProductInspectRegister_R20", pDataParameters);
                }
                else if (pInspectFinalApprovalRegisterEntity.PART_TYPE == "1004")
                {
                    pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_RawMaterialInspectRegister_R20", pDataParameters);
                }
                else if (pInspectFinalApprovalRegisterEntity.PART_TYPE == "1005")
                {
                    pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_MaterialInspectRegister_R20", pDataParameters);
                }
                

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
                    "Sample_Info_Mst(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)",
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

        #region 정보 저장하기 - Sample_Info_Save(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool InspectFinalApprovalRegister_Info_Mst_Save(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_total_approver", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_total_approver_sign", MySqlDbType.VarChar, 50),



                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_total_approver", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_total_approver_sign", SqlDbType.NVarChar, 50),
                        };
                        break;
                }

                pDataParametersA[0].Value = pInspectFinalApprovalRegisterEntity.CRUD;
                pDataParametersA[1].Value = pInspectFinalApprovalRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pInspectFinalApprovalRegisterEntity.INSPECT_ID;
                
                if (pInspectFinalApprovalRegisterEntity.PART_TYPE == "1001")
                {
                    pDataParametersA[3].Value = sheet_1.GetCellValue(14, 29).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(14, 29).ToString();
                }
                else if (pInspectFinalApprovalRegisterEntity.PART_TYPE == "1003")
                {
                    pDataParametersA[3].Value = sheet_1.GetCellValue(14, 29).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(14, 29).ToString();
                }
                else if (pInspectFinalApprovalRegisterEntity.PART_TYPE == "1004")
                {
                    //  pDataParametersA[3].Value = sheet_1.GetCellValue(7, 27).ToString();
                    //   pDataParametersA[4].Value = sheet_1.GetCellValue(7, 27).ToString();
                    pDataParametersA[3].Value = sheet_1.GetCellValue(11, 40).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(11, 40).ToString();
                }
                else if (pInspectFinalApprovalRegisterEntity.PART_TYPE == "1005")
                {
                    pDataParametersA[3].Value = sheet_1.GetCellValue(9, 33).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(9, 33).ToString();
                }
                
                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectFinalApprovalRegister_I10", pDataParametersA);

                pInspectFinalApprovalRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pInspectFinalApprovalRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pInspectFinalApprovalRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pInspectFinalApprovalRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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

        #region 정보 저장하기 - Sample_Info_Save(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool InspectFinalApprovalRegister_Info_Detail_Save(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                int rowcnt = pInspectFinalApprovalRegisterEntity.dtListCnt;
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

                    pDataParametersA[0].Value = pInspectFinalApprovalRegisterEntity.CRUD;
                    pDataParametersA[1].Value = pInspectFinalApprovalRegisterEntity.USER_CODE;
                    pDataParametersA[2].Value = pInspectFinalApprovalRegisterEntity.INSPECT_ID;
                    pDataParametersA[3].Value = sheet_1.GetCellValue(0, i + 1).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(3, i + 1).ToString();
                    pDataParametersA[5].Value = sheet_1.GetCellValue(5, i + 1).ToString();
                    pDataParametersA[6].Value = sheet_1.GetCellValue(6, i + 1).ToString();
                    pDataParametersA[7].Value = sheet_1.GetCellValue(4, i + 1).ToString();//v_inspect_user
                    pDataParametersA[8].Value = sheet_1.GetCellValue(7, i + 1).ToString();//v_inspect_user

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectFinalApprovalRegister_I20", pDataParametersA);

                    pInspectFinalApprovalRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pInspectFinalApprovalRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pInspectFinalApprovalRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pInspectFinalApprovalRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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

        #region 정보 저장하기 - Sample_Info_Save(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool InspectFinalApprovalRegister_Info_Delay_Save(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_total_approver", MySqlDbType.VarChar, 50)



                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_total_approver", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pInspectFinalApprovalRegisterEntity.CRUD;
                pDataParametersA[1].Value = pInspectFinalApprovalRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pInspectFinalApprovalRegisterEntity.INSPECT_ID;
                pDataParametersA[3].Value = pInspectFinalApprovalRegisterEntity.TOTAL_APPROVER;


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectFinalApprovalRegister_I20", pDataParametersA);

                pInspectFinalApprovalRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pInspectFinalApprovalRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pInspectFinalApprovalRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pInspectFinalApprovalRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override InspectFinalApprovalRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity = new InspectFinalApprovalRegisterEntity();

                pInspectFinalApprovalRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pInspectFinalApprovalRegisterEntity;
            }
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

    public class InspectFinalApprovalRegisterT01Provider : EntityManager<InspectFinalApprovalRegisterT01Entity>
    {
        #region 생성자 - InspectFinalApprovalRegisterT01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public InspectFinalApprovalRegisterT01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - InspectFinalApprovalRegisterT01_Mst_info(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pInspectFinalApprovalRegisterT01Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable InspectFinalApprovalRegisterT01_Mst_info(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity)
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
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                            
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_vend_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_complete_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)

                        };
                        break;
                }

                pDataParameters[0].Value = pInspectFinalApprovalRegisterT01Entity.CRUD;
                pDataParameters[1].Value = pInspectFinalApprovalRegisterT01Entity.DATE_FROM;
                pDataParameters[2].Value = pInspectFinalApprovalRegisterT01Entity.DATE_TO;
                pDataParameters[3].Value = pInspectFinalApprovalRegisterT01Entity.VEND_PART_CODE;
                pDataParameters[4].Value = pInspectFinalApprovalRegisterT01Entity.COMPLETE_YN;
                pDataParameters[5].Value = pInspectFinalApprovalRegisterT01Entity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectFinalApprovalRegister_T01_R10", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "InspectFinalApprovalRegisterT01_Mst_info(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity)",
                    pException
                );
            }

        }

        #endregion
        
        #region 정보 저장하기 - InspectFinalApprovalRegisterT01_Info_Mst_Save(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool InspectFinalApprovalRegisterT01_Info_Mst_Save(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE

            _pDBManager.BeginTransaction();

            int pCount = 0;
            
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
                                        new MySqlParameter("@v_matstock_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_matstock_detail_seq", MySqlDbType.VarChar, 8),
                                        new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                                        new MySqlParameter("@v_inspect_seq", MySqlDbType.VarChar, 6),
                                        new MySqlParameter("@v_inspect_status", MySqlDbType.VarChar, 20),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_complete_yn", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParametersA = new IDataParameter[]
                                {

                                        new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.VarChar, 20),
                                        new SqlParameter("@v_matstock_id", SqlDbType.VarChar, 15),
                                        new SqlParameter("@v_matstock_detail_seq", SqlDbType.VarChar, 8),
                                        new SqlParameter("@v_inspect_id", SqlDbType.VarChar, 15),
                                        new SqlParameter("@v_inspect_seq", SqlDbType.VarChar, 6),
                                        new SqlParameter("@v_inspect_status", SqlDbType.VarChar, 20),
                                        new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                        new SqlParameter("@v_complete_yn", SqlDbType.VarChar, 1),
                                        new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),

                                };
                                break;
                        }
                        pDataParametersA[0].Value = dt.Rows[a]["CRUD"].ToString();
                        pDataParametersA[1].Value = pInspectFinalApprovalRegisterT01Entity.USER_CODE;
                        pDataParametersA[2].Value = dt.Rows[a]["MATSTOCK_ID"].ToString();
                        pDataParametersA[3].Value = dt.Rows[a]["MATSTOCK_DETAIL_SEQ"].ToString();
                        pDataParametersA[4].Value = dt.Rows[a]["INSPECT_ID"].ToString();
                        pDataParametersA[5].Value = dt.Rows[a]["INSPECT_SEQ"].ToString();
                        if(dt.Rows[a]["COMPLETE_YN"].ToString().Equals("Y"))
                        {
                            pDataParametersA[6].Value = "QC010004";
                        }
                        else
                        {
                            pDataParametersA[6].Value = "QC010003";
                        }
                        
                        pDataParametersA[7].Value = dt.Rows[a]["REMARK"].ToString();
                        pDataParametersA[8].Value = dt.Rows[a]["COMPLETE_YN"].ToString();
                        pDataParametersA[9].Value = dt.Rows[a]["USE_YN"].ToString();

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectFinalApprovalRegister_T01_I10", pDataParametersA);

                        if (pDataTableA.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        pInspectFinalApprovalRegisterT01Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                        pInspectFinalApprovalRegisterT01Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                        pInspectFinalApprovalRegisterT01Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                        pInspectFinalApprovalRegisterT01Entity.RTN_SEQ = pDataTableA.Rows[0]["P_RTN_AQ"].ToString();
                        pInspectFinalApprovalRegisterT01Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();

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
                    "InspectFinalApprovalRegisterT01_Info_Mst_Save(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity)",
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
        public override InspectFinalApprovalRegisterT01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity = new InspectFinalApprovalRegisterT01Entity();

                pInspectFinalApprovalRegisterT01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pInspectFinalApprovalRegisterT01Entity;
            }
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

        public class ucQCMaterialPartListPopupProvider : EntityManager<ucQCMaterialPartListPopupEntity>
    {
        #region 생성자 - ucQCMaterialPartListPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucQCMaterialPartListPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 조회하기 ucMaterialPartListPopup_Info_Return(ucMaterialPartListPopupEntity pucMaterialPartListPopupEntity)

        public DataTable ucQCMaterialPartListPopup_Info_Return(ucQCMaterialPartListPopupEntity pucQCMaterialPartListPopupEntity)
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

                pDataParameters[0].Value = pucQCMaterialPartListPopupEntity.CRUD;
                pDataParameters[1].Value = pucQCMaterialPartListPopupEntity.VEND_PART_CODE;
                pDataParameters[2].Value = pucQCMaterialPartListPopupEntity.PART_NAME;
                pDataParameters[3].Value = pucQCMaterialPartListPopupEntity.PART_REVISION_NO;
                pDataParameters[4].Value = pucQCMaterialPartListPopupEntity.PART_HIGH;
                pDataParameters[5].Value = pucQCMaterialPartListPopupEntity.PART_MIDDLE;
                pDataParameters[6].Value = pucQCMaterialPartListPopupEntity.PART_LOW;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMaterialPartListPopup_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucMaterialPartListPopup_Info_Return(ucMaterialPartListPopupEntity pucMaterialPartListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucQCMaterialPartListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucQCMaterialPartListPopupEntity pucQCMaterialPartListPopupEntity = new ucQCMaterialPartListPopupEntity();
                return pucQCMaterialPartListPopupEntity;
            }
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

    public class CheckDataViewProvider : EntityManager<CheckDataViewEntity>
    {
        #region 생성자 - CheckDataViewProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public CheckDataViewProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCheckDataViewEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Excel_Json_Mst_Info(CheckDataViewEntity pCheckDataViewEntity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_trs_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_fps_trs_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_lot_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_trs_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_fps_trs_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pCheckDataViewEntity.CRUD;
                pDataParameters[1].Value = pCheckDataViewEntity.DATE_FROM;
                pDataParameters[2].Value = pCheckDataViewEntity.DATE_TO;
                pDataParameters[3].Value = pCheckDataViewEntity.PART_NAME;
                pDataParameters[4].Value = pCheckDataViewEntity.LOT_NO;
                pDataParameters[5].Value = pCheckDataViewEntity.TRS_NO;
                pDataParameters[6].Value = pCheckDataViewEntity.FPS_TRS_NO;
                pDataParameters[7].Value = pCheckDataViewEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CheckDataView_R10", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Excel_Json_Mst_Info(CheckDataViewEntity pCheckDataViewEntity)",
                    pException
                );
            }

        }

        #endregion

        #region 마스터 디테일 조회

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCheckDataViewEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Excel_Json_Mst_Sub_Info(CheckDataViewEntity pCheckDataViewEntity)
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
                            new MySqlParameter("@v_seq", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_seq", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pCheckDataViewEntity.CRUD;
                pDataParameters[1].Value = pCheckDataViewEntity.SEQ;
                pDataParameters[2].Value = pCheckDataViewEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CheckDataView_R11", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Excel_Json_Mst_Sub_Info(CheckDataViewEntity pCheckDataViewEntity)",
                    pException
                );
            }

        }

        #endregion

        #region 디테일 조회

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCheckDataViewEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Excel_Json_Sub_Info(CheckDataViewEntity pCheckDataViewEntity)
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
                            new MySqlParameter("@v_seq", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_json_col", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_seq", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_json_col",SqlDbType.NVarChar,50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pCheckDataViewEntity.CRUD;
                pDataParameters[1].Value = pCheckDataViewEntity.SEQ;
                pDataParameters[2].Value = pCheckDataViewEntity.JSONCOL;
                pDataParameters[3].Value = pCheckDataViewEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CheckDataView_R12", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Excel_Json_Sub_Info(CheckDataViewEntity pCheckDataViewEntity)",
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
        public override CheckDataViewEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                CheckDataViewEntity pCheckDataViewEntity = new CheckDataViewEntity();

                pCheckDataViewEntity.CORP_CODE = pDataRow["seq"] is DBNull ? string.Empty : pDataRow["seq"] as string;  // 회사코드

                return pCheckDataViewEntity;
            }
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

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(CheckDataViewEntity pCheckDataViewEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCheckDataViewEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(CheckDataViewEntity pCheckDataViewEntity)
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

                pDataParameters[0].Value = pCheckDataViewEntity.CRUD;
                pDataParameters[1].Value = pCheckDataViewEntity.WINDOW_NAME;
                pDataParameters[2].Value = pCheckDataViewEntity.LANGUAGE_TYPE;

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
                    "Sheet_Info_sheet(CheckDataViewEntity pCheckDataViewEntity)",
                    pException
                );
            }
        }

        #endregion
    }

    public class CCPRegisterProvider : EntityManager<CCPRegisterEntity>
    {
        #region 생성자 - CCPRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public CCPRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - CCPRegister_Info_Save(CCPRegisterEntity pCCPRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable CCPRegister_Info(CCPRegisterEntity pCCPRegisterEntity)
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
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pCCPRegisterEntity.CRUD;
                pDataParameters[1].Value = pCCPRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pCCPRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pCCPRegisterEntity.PART_CODE;
                pDataParameters[4].Value = pCCPRegisterEntity.PART_NAME;
                pDataParameters[5].Value = pCCPRegisterEntity.PROCESS_CODE;
                pDataParameters[6].Value = pCCPRegisterEntity.PROCESS_NAME;
                pDataParameters[7].Value = pCCPRegisterEntity.USE_YN;
                pDataParameters[8].Value = pCCPRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CCP_Moisture_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "CCPRegister_Info_Save(CCPRegisterEntity pCCPRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        public bool CCPRegister_Info_Save(CCPRegisterEntity pCCPRegisterEntity)
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
                                new MySqlParameter("@v_ccp_date", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_temperature", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_temperature_unit", MySqlDbType.VarChar, 4),
                                new MySqlParameter("@v_humidity", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_humidity_unit", MySqlDbType.VarChar, 4),
                                new MySqlParameter("@v_moisture_content_value", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_moisture_content_unit", MySqlDbType.VarChar, 4),
                                new MySqlParameter("@v_measure", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_ccp_date", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_temperature", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_temperature_unit", SqlDbType.VarChar, 4),
                                new SqlParameter("@v_humidity", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_humidity_unit", SqlDbType.VarChar, 4),
                                new SqlParameter("@v_moisture_content_value", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_moisture_content_unit", SqlDbType.VarChar, 4),
                                new SqlParameter("@v_measure", SqlDbType.VarChar, 100),
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 100),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pCCPRegisterEntity.CRUD;
                pDataParametersA[1].Value = pCCPRegisterEntity.CCP_DATE;
                pDataParametersA[2].Value = pCCPRegisterEntity.USER_CODE;
                pDataParametersA[3].Value = pCCPRegisterEntity.PROCESS_CODE;
                pDataParametersA[4].Value = pCCPRegisterEntity.PART_CODE;
                pDataParametersA[5].Value = pCCPRegisterEntity.TEMPERATURE;
                pDataParametersA[6].Value = pCCPRegisterEntity.TEMPERATURE_UNIT;
                pDataParametersA[7].Value = pCCPRegisterEntity.HUMIDITY;
                pDataParametersA[8].Value = pCCPRegisterEntity.HUMIDITY_UNIT;
                pDataParametersA[9].Value = pCCPRegisterEntity.MOISTURE_VALUE;
                pDataParametersA[10].Value = pCCPRegisterEntity.MOISTURE_UNIT;
                pDataParametersA[11].Value = pCCPRegisterEntity.MEASURE;
                pDataParametersA[12].Value = pCCPRegisterEntity.REMARK;
                pDataParametersA[13].Value = pCCPRegisterEntity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CCP_Moisture_I10", pDataParametersA);

                pCCPRegisterEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                pCCPRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                pCCPRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                pCCPRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                pCCPRegisterEntity.RTN_AQ = pDataTableA.Rows[0]["rtn_aq"].ToString();
                pCCPRegisterEntity.RTN_SQ = pDataTableA.Rows[0]["rtn_sq"].ToString();
                pCCPRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override CCPRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                CCPRegisterEntity pCCPRegisterEntity = new CCPRegisterEntity();

                pCCPRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pCCPRegisterEntity;
            }
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

    public class CCPDetectionRegisterProvider : EntityManager<CCPDetectionRegisterEntity>
    {
        #region 생성자 - CCPDetectionRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public CCPDetectionRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - CCPDetectionRegister_Info_Save(CCPDetectionRegisterEntity pCCPDetectionRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable CCPDetectionRegister_Info(CCPDetectionRegisterEntity pCCPDetectionRegisterEntity)
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
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pCCPDetectionRegisterEntity.CRUD;
                pDataParameters[1].Value = pCCPDetectionRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pCCPDetectionRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pCCPDetectionRegisterEntity.PART_CODE;
                pDataParameters[4].Value = pCCPDetectionRegisterEntity.PART_NAME;
                pDataParameters[5].Value = pCCPDetectionRegisterEntity.PROCESS_CODE;
                pDataParameters[6].Value = pCCPDetectionRegisterEntity.PROCESS_NAME;
                pDataParameters[7].Value = pCCPDetectionRegisterEntity.USE_YN;
                pDataParameters[8].Value = pCCPDetectionRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CCP_Detection_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "CCPDetectionRegister_Info_Save(CCPDetectionRegisterEntity pCCPDetectionRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        public bool CCPDetectionRegister_Info_Save(CCPDetectionRegisterEntity pCCPDetectionRegisterEntity)
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
                                new MySqlParameter("@v_ccp_date", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_metal_detection_value", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_detection", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_ccp_date", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_process_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_metal_detection_value", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_detection", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 100),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pCCPDetectionRegisterEntity.CRUD;
                pDataParametersA[1].Value = pCCPDetectionRegisterEntity.CCP_DATE;
                pDataParametersA[2].Value = pCCPDetectionRegisterEntity.USER_CODE;
                pDataParametersA[3].Value = pCCPDetectionRegisterEntity.PROCESS_CODE;
                pDataParametersA[4].Value = pCCPDetectionRegisterEntity.PART_CODE;
                pDataParametersA[5].Value = pCCPDetectionRegisterEntity.DETECTION_VALUE;
                pDataParametersA[6].Value = pCCPDetectionRegisterEntity.DETECTION;
                pDataParametersA[7].Value = pCCPDetectionRegisterEntity.REMARK;
                pDataParametersA[8].Value = pCCPDetectionRegisterEntity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CCP_Detection_I10", pDataParametersA);

                pCCPDetectionRegisterEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                pCCPDetectionRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                pCCPDetectionRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                pCCPDetectionRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                pCCPDetectionRegisterEntity.RTN_AQ = pDataTableA.Rows[0]["rtn_aq"].ToString();
                pCCPDetectionRegisterEntity.RTN_SQ = pDataTableA.Rows[0]["rtn_sq"].ToString();
                pCCPDetectionRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override CCPDetectionRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                CCPDetectionRegisterEntity pCCPDetectionRegisterEntity = new CCPDetectionRegisterEntity();

                pCCPDetectionRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pCCPDetectionRegisterEntity;
            }
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

    public class FBDDataRegisterProvider : EntityManager<FBDDataRegisterEntity>
    {
        #region 생성자 - FBDDataRegisterProvider(pDBManager)
        public FBDDataRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        public bool MstCodeCreate(FBDDataRegisterEntity pFBDDataRegisterEntity)
        {
            bool pErrorYN = false;
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
                                new MySqlParameter("@Param_fbd_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@Param_fbd_name", MySqlDbType.VarChar, 200),
                                new MySqlParameter("@Param_user", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@Param_fbd_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@Param_fbd_name", SqlDbType.NVarChar, 200),
                                new SqlParameter("@Param_user", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pFBDDataRegisterEntity.fbdcode;
                pDataParametersA[1].Value = pFBDDataRegisterEntity.fbdName;
                pDataParametersA[2].Value = pFBDDataRegisterEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FBD_MST_I10", pDataParametersA);

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {//에러시
                    if (!(pFBDDataRegisterEntity.Level == 1 || pFBDDataRegisterEntity.Level == 2))
                    {
                        pErrorYN = true;
                    }
                }
                else
                {//정상 저장
                    //if(!(pFBDDataRegisterEntity.Level == 1 || pFBDDataRegisterEntity.Level == 2))
                    //{
                    //    pErrorYN = true;
                    //}
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
        public bool LanguageInfoCreate(FBDDataRegisterEntity pFBDDataRegisterEntity)
        {
            bool pErrorYN = false;
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
                                new MySqlParameter("@Param_fbd_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@Param_fbd_name", MySqlDbType.VarChar, 200),
                                new MySqlParameter("@Param_fbd_transname", MySqlDbType.VarChar, 200),
                                new MySqlParameter("@Param_user", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@Param_fbd_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@Param_fbd_name", SqlDbType.NVarChar, 200),
                                new SqlParameter("@Param_fbd_transname", SqlDbType.NVarChar, 200),
                                new SqlParameter("@Param_user", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pFBDDataRegisterEntity.fbdcode;
                pDataParametersA[1].Value = pFBDDataRegisterEntity.fbdName;
                pDataParametersA[2].Value = pFBDDataRegisterEntity.LocalName;
                pDataParametersA[3].Value = pFBDDataRegisterEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FBD_MST_I20", pDataParametersA);

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {//에러시
                    if (!(pFBDDataRegisterEntity.Level == 1 || pFBDDataRegisterEntity.Level == 2))
                    {
                        pErrorYN = true;
                    }
                }
                else
                {//정상 저장
                    //if(!(pFBDDataRegisterEntity.Level == 1 || pFBDDataRegisterEntity.Level == 2))
                    //{
                    //    pErrorYN = true;
                    //}
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
        public bool ClassificationCreate(FBDDataRegisterEntity pFBDDataRegisterEntity)
        {
            bool pErrorYN = false;
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
                                new MySqlParameter("@Param_middle", MySqlDbType.VarChar, 200),
                                new MySqlParameter("@Param_small", MySqlDbType.VarChar, 200),
                                new MySqlParameter("@Param_user", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@Param_middle", SqlDbType.NVarChar, 200),
                                new SqlParameter("@Param_small", SqlDbType.NVarChar, 200),
                                new SqlParameter("@Param_user", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pFBDDataRegisterEntity.MiddleClass;
                pDataParametersA[1].Value = pFBDDataRegisterEntity.SmallClass;
                pDataParametersA[2].Value = pFBDDataRegisterEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FBD_Assignment_I10", pDataParametersA);

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {//에러시
                    if (!(pFBDDataRegisterEntity.Level == 1 || pFBDDataRegisterEntity.Level == 2))
                    {
                        pErrorYN = true;
                    }
                }
                else
                {//정상 저장
                    //if(!(pFBDDataRegisterEntity.Level == 1 || pFBDDataRegisterEntity.Level == 2))
                    //{
                    //    pErrorYN = true;
                    //}
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
        public bool MstCodeCreate2(FBDDataRegisterEntity pFBDDataRegisterEntity)
        {
            bool pErrorYN = false;
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
                                new MySqlParameter("@Param_fbd_code", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@Param_fbd_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@Param_level", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@Param_fbd_code", SqlDbType.NVarChar, 1),
                                new SqlParameter("@Param_fbd_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@Param_level", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pFBDDataRegisterEntity.fbdcode;
                pDataParametersA[1].Value = pFBDDataRegisterEntity.fbdName;
                pDataParametersA[2].Value = pFBDDataRegisterEntity.Level;

                _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FBD_MST_CU2", pDataParametersA);
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
        public bool MstCodeDelete(string process)
        {
            bool pErrorYN = false;
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
                                new MySqlParameter("@Param_fbd_code", MySqlDbType.VarChar, 20),
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@Param_fbd_code", SqlDbType.NVarChar, 20),
                        };
                        break;
                }

                pDataParametersA[0].Value = process;

                _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FBD_MST_D", pDataParametersA);
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

        public DataTable FBDDataRead(FBDDataRegisterEntity pFBDDataRegisterEntity, string classifi)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_fbd_name", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@Param_class", MySqlDbType.VarChar, 2)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_fbd_name", SqlDbType.NVarChar, 10),
                            new SqlParameter("@Param_class", SqlDbType.VarChar, 2)

                };
                        break;
                }

                pDataParameters[0].Value = pFBDDataRegisterEntity.fbdName;
                pDataParameters[1].Value = classifi;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FBD_MST_R", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "FBDDataRead(FBDDataRegisterEntity pFBDDataRegisterEntity)",
                    pException
                );
            }
        }

        public bool StructureCreate(FBDDataRegisterEntity pFBDDataRegisterEntity, DataRow dr, string filename)
        {            
            bool tf = true;

            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_strucrure_code", MySqlDbType.VarChar, 200),
                            new MySqlParameter("@Param_fbd_assignment_name", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@Param_fbd_name", MySqlDbType.VarChar, 200),
                            new MySqlParameter("@Param_fbd_pname", MySqlDbType.VarChar, 200),
                            new MySqlParameter("@Param_presently_data", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@Param_iiot_data", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@Param_remarks1", MySqlDbType.VarChar, 200),
                            new MySqlParameter("@Param_remarks2", MySqlDbType.VarChar, 200),
                            new MySqlParameter("@Param_user", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_ranking", MySqlDbType.Int32),
                            new MySqlParameter("@Param_excelfile", MySqlDbType.VarChar, 200),
                            new MySqlParameter("@Param_excelcode", MySqlDbType.VarChar, 50),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_strucrure_code", SqlDbType.VarChar, 200),
                            new SqlParameter("@Param_fbd_assignment_name", SqlDbType.VarChar, 20),
                            new SqlParameter("@Param_fbd_name", SqlDbType.VarChar, 200),
                            new SqlParameter("@Param_fbd_pname", SqlDbType.VarChar, 200),
                            new SqlParameter("@Param_presently_data", SqlDbType.VarChar, 10),
                            new SqlParameter("@Param_iiot_data", SqlDbType.VarChar, 10),
                            new SqlParameter("@Param_remarks1", SqlDbType.VarChar, 200),
                            new SqlParameter("@Param_remarks2", SqlDbType.VarChar, 200),
                            new SqlParameter("@Param_user", SqlDbType.VarChar, 50),
                            new SqlParameter("@Param_ranking", SqlDbType.Int),
                        };
                        break;
                }

                pDataParameters[0].Value = filename;
                pDataParameters[1].Value = dr["assignment"];
                pDataParameters[2].Value = dr["fbd_name"];
                pDataParameters[3].Value = dr["fbd_pname"];
                pDataParameters[4].Value = dr["presently_data"];
                pDataParameters[5].Value = dr["iiot_data"];
                pDataParameters[6].Value = dr["remarks1"];
                pDataParameters[7].Value = dr["remarks2"];
                pDataParameters[8].Value = pFBDDataRegisterEntity.USER_CODE; 
                pDataParameters[9].Value = dr["ranking"];
                pDataParameters[10].Value = dr["excelfile"];
                pDataParameters[11].Value = dr["excel_code"];

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FBD_STRUCTURE_I10", pDataParameters);
            }
            catch (ExceptionManager pExceptionManager)
            {
                tf = false;
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                tf = false;
                throw new ExceptionManager
                (
                    this,
                    "SubCreate(FBDDataRegisterEntity pFBDDataRegisterEntity)",
                    pException
                );
            }

            return tf;
        }
        public bool MemoCreate(string assignName, string filename, string memo, string usercode)
        {
            bool tf = true;

            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_assignment_name", MySqlDbType.VarChar, 200),
                            new MySqlParameter("@Param_file_name", MySqlDbType.VarChar, 200),
                            new MySqlParameter("@Param_memo", MySqlDbType.VarChar, 2000),
                            new MySqlParameter("@Param_user", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_assignment_name", SqlDbType.VarChar, 200),
                            new SqlParameter("@Param_file_name", SqlDbType.VarChar, 200),
                            new SqlParameter("@Param_memo", SqlDbType.VarChar, 2000),
                            new SqlParameter("@Param_user", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = assignName;
                pDataParameters[1].Value = filename;
                pDataParameters[2].Value = memo;
                pDataParameters[3].Value = usercode;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FBD_ASSIGNMENT_MEMO", pDataParameters);
            }
            catch (ExceptionManager pExceptionManager)
            {
                tf = false;
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                tf = false;
                throw new ExceptionManager
                (
                    this,
                    "SubCreate(FBDDataRegisterEntity pFBDDataRegisterEntity)",
                    pException
                );
            }

            return tf;
        }
        public DataTable SubRead(string fbdMSTName, string process, string pLanguage_Type)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_fbdmstname", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@Param_process", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_fbd_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@Param_process", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)


                };
                        break;
                }

                pDataParameters[0].Value = fbdMSTName;
                pDataParameters[1].Value = process;
                pDataParameters[2].Value = pLanguage_Type;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FBD_SUB_R", pDataParameters);
                return pDataTable;
            }
             catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "FBDDataRead(FBDDataRegisterEntity pFBDDataRegisterEntity)",
                    pException
                );
            }
        }

        public DataTable StructureRead(FBDDataRegisterEntity pFBDDataRegisterEntity, string filename, int index)
        {    
            bool pErrorYN = false;
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
                                new MySqlParameter("@Param_index", MySqlDbType.Int32),
                                new MySqlParameter("@Param_user", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@Param_file_name", MySqlDbType.VarChar, 200),
                                new MySqlParameter("@Param_assignmentcode", MySqlDbType.VarChar, 200)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@Param_index", SqlDbType.Int),
                                new SqlParameter("@Param_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@Param_file_name", SqlDbType.NVarChar, 200),
                                new SqlParameter("@Param_assignmentcode", SqlDbType.NVarChar, 200)
                        };
                        break;
                }

                pDataParametersA[0].Value = index;
                pDataParametersA[1].Value = pFBDDataRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = filename;
                pDataParametersA[3].Value = "";

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FBD_STRUCTURE_R10", pDataParametersA);
                return pDataTableA;               
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
            
        }

        public bool USP_recursive_test_I10(DataRow dr)
        {
            bool tf = true;

            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_gparents", MySqlDbType.VarChar, 200),
                            new MySqlParameter("@Param_parents", MySqlDbType.VarChar, 200),
                            new MySqlParameter("@Param_oneself", MySqlDbType.VarChar, 200),
                            new MySqlParameter("@Param_depth", MySqlDbType.VarChar, 200),
                            new MySqlParameter("@Param_last_yn", MySqlDbType.VarChar, 2),
                            new MySqlParameter("@Param_4m1e", MySqlDbType.VarChar, 10),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_strucrure_code", SqlDbType.VarChar, 200),
                            new SqlParameter("@Param_fbd_assignment_name", SqlDbType.VarChar, 20),
                            new SqlParameter("@Param_fbd_name", SqlDbType.VarChar, 200),
                            new SqlParameter("@Param_fbd_pname", SqlDbType.VarChar, 200)
                        };
                        break;
                }

                pDataParameters[0].Value = dr["gparents"];
                pDataParameters[1].Value = dr["parents"];
                pDataParameters[2].Value = dr["oneself"];
                pDataParameters[3].Value = dr["depth"];
                pDataParameters[4].Value = dr["last_yn"];
                pDataParameters[5].Value = dr["4m1e"];

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_recursive_test_I10", pDataParameters);


            }
            catch (ExceptionManager pExceptionManager)
            {
                tf = false;
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                tf = false;
                throw new ExceptionManager
                (
                    this,
                    "SubCreate(FBDDataRegisterEntity pFBDDataRegisterEntity)",
                    pException
                );
            }

            return tf;
        }

        public bool USP_fbd_standard_structure_I10(DataRow dr)
        {
            bool tf = true;

            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_assignment_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_standard_process", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_work_center", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_equipment", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_tool", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_resource", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_ranking", MySqlDbType.VarChar, 3),
                            new MySqlParameter("@Param_4m1e_name", MySqlDbType.VarChar, 5),
                            new MySqlParameter("@Param_user", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_strucrure_code", SqlDbType.VarChar, 200),
                            new SqlParameter("@Param_fbd_assignment_name", SqlDbType.VarChar, 20),
                            new SqlParameter("@Param_fbd_name", SqlDbType.VarChar, 200),
                            new SqlParameter("@Param_fbd_pname", SqlDbType.VarChar, 200)
                        };
                        break;
                }

                pDataParameters[0].Value = dr["assignment"];
                pDataParameters[1].Value = dr["standard_process"];
                pDataParameters[2].Value = dr["work_center"];
                pDataParameters[3].Value = dr["equipment"];
                pDataParameters[4].Value = dr["tool"];
                pDataParameters[5].Value = dr["resource"];
                pDataParameters[6].Value = dr["ranking"];
                pDataParameters[7].Value = dr["4m1e"];
                pDataParameters[8].Value = dr["user"];


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_fbd_standard_structure_I10", pDataParameters);

                if(pDataTable.Rows[0][0].ToString() != "00")
                {
                    tf = false;
                }


            }
            catch (ExceptionManager pExceptionManager)
            {
                tf = false;
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                tf = false;
                throw new ExceptionManager
                (
                    this,
                    "SubCreate(FBDDataRegisterEntity pFBDDataRegisterEntity)",
                    pException
                );
            }

            return tf;
        }
        public bool USP_FBS_standard_I10(DataRow dr, string _pLANGUAGE_TYPE)
        {
            bool tf = true;

            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@Param_process_mst_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@Param_work_center_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_equipment_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_equipment_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_tool_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@Param_resource_name", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@Param_process_mst_code", SqlDbType.VarChar, 10),
                            new SqlParameter("@Param_work_center_name", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = dr["standard_process"];
                pDataParameters[1].Value = dr["work_center"];
                pDataParameters[2].Value = dr["standard_process"].ToString().Substring(0,2);
                pDataParameters[3].Value = _pLANGUAGE_TYPE;
                pDataParameters[4].Value = dr["equipment"];
                pDataParameters[5].Value = dr["tool"];
                pDataParameters[6].Value = dr["resource"];

                if(dr["resource"].ToString() != "")
                {

                }

               DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FBS_standard_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    tf = false;
                }


            }
            catch (ExceptionManager pExceptionManager)
            {
                tf = false;
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                tf = false;
                throw new ExceptionManager
                (
                    this,
                    "SubCreate(FBDDataRegisterEntity pFBDDataRegisterEntity)",
                    pException
                );
            }

            return tf;
        }

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override FBDDataRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                FBDDataRegisterEntity pFBDDataRegisterEntity = new FBDDataRegisterEntity();

                pFBDDataRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pFBDDataRegisterEntity;
            }
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

    public class MaterialInspectRegister_T01Provider : EntityManager<MaterialInspectRegister_T01Entity>
    {
        #region ○ 생성자

        public MaterialInspectRegister_T01Provider(DBManager pDBManager)
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
        public override MaterialInspectRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MaterialInspectRegister_T01Entity pMaterialInspectRegister_T01Entity = new MaterialInspectRegister_T01Entity();

                pMaterialInspectRegister_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pMaterialInspectRegister_T01Entity;
            }
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

        public DataTable MaterialInspectRegister_T01_Info_Mst(MaterialInspectRegister_T01Entity ppMaterialInspectRegister_T01Entity)
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

                pDataParameters[0].Value = ppMaterialInspectRegister_T01Entity.CRUD;
                pDataParameters[1].Value = ppMaterialInspectRegister_T01Entity.DATE_FROM;
                pDataParameters[2].Value = ppMaterialInspectRegister_T01Entity.DATE_TO;
                pDataParameters[3].Value = ppMaterialInspectRegister_T01Entity.CONTRACT_ID;
                pDataParameters[4].Value = ppMaterialInspectRegister_T01Entity.PART_CODE;
                pDataParameters[5].Value = ppMaterialInspectRegister_T01Entity.PART_NAME;
                pDataParameters[6].Value = ppMaterialInspectRegister_T01Entity.VEND_CODE;
                pDataParameters[7].Value = ppMaterialInspectRegister_T01Entity.VEND_NAME;
                pDataParameters[8].Value = ppMaterialInspectRegister_T01Entity.USE_YN;
                pDataParameters[9].Value = ppMaterialInspectRegister_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialInspectRegister_T01_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "MaterialInspectRegister_T01_Info_Mst(MaterialInspectRegister_T01Entity ppMaterialInspectRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장

        public bool MaterialInspectRegister_T01_Save(MaterialInspectRegister_T01Entity pMaterialInspectRegister_T01Entity)
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

                pDataParameters[0].Value = pMaterialInspectRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pMaterialInspectRegister_T01Entity.USER_CODE;
                pDataParameters[2].Value = pMaterialInspectRegister_T01Entity.CONTRACT_ID;
                pDataParameters[3].Value = pMaterialInspectRegister_T01Entity.CONTRACT_DATE;
                pDataParameters[4].Value = pMaterialInspectRegister_T01Entity.PART_CODE;
                pDataParameters[5].Value = pMaterialInspectRegister_T01Entity.VEND_CODE;
                pDataParameters[6].Value = pMaterialInspectRegister_T01Entity.CONTRACT_QTY;
                pDataParameters[7].Value = pMaterialInspectRegister_T01Entity.DELIVERY_DATE;
                pDataParameters[8].Value = pMaterialInspectRegister_T01Entity.DELIVERY_LOCATION;
                pDataParameters[9].Value = pMaterialInspectRegister_T01Entity.UNITCOST;
                pDataParameters[10].Value = pMaterialInspectRegister_T01Entity.COST;
                pDataParameters[11].Value = pMaterialInspectRegister_T01Entity.REMARK;
                pDataParameters[12].Value = pMaterialInspectRegister_T01Entity.USE_YN;
                //pDataParameters[13].Value = pMaterialInspectRegister_T01Entity.UNIT_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialInspectRegister_T01_I10", pDataParameters);

                pMaterialInspectRegister_T01Entity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                pMaterialInspectRegister_T01Entity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                pMaterialInspectRegister_T01Entity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                pMaterialInspectRegister_T01Entity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                pMaterialInspectRegister_T01Entity.RTN_AQ = pDataTable.Rows[0]["rtn_aq"].ToString();
                pMaterialInspectRegister_T01Entity.RTN_SQ = pDataTable.Rows[0]["rtn_sq"].ToString();
                pMaterialInspectRegister_T01Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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


    public class FirstMiddleLastInspectRegisterProvider : EntityManager<FirstMiddleLastInspectRegisterEntity>
    {
        #region ○ 생성자

        public FirstMiddleLastInspectRegisterProvider(DBManager pDBManager)
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
        public override FirstMiddleLastInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                FirstMiddleLastInspectRegisterEntity pFirstMiddleLastInspectRegisterEntity = new FirstMiddleLastInspectRegisterEntity();

                pFirstMiddleLastInspectRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pFirstMiddleLastInspectRegisterEntity;
            }
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

        public DataTable FirstMiddleLastInspectRegister_Info_Mst(FirstMiddleLastInspectRegisterEntity ppFirstMiddleLastInspectRegisterEntity)
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
                    //        new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 50),
                    //        new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                    //        new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                    //        new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                    //        new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 50),
                    //        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                    //        new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                   //         new SqlParameter("@v_contract_id", SqlDbType.VarChar, 50),
                   //         new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                   //         new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                   //         new SqlParameter("@v_vend_code", SqlDbType.VarChar, 50),
                   //         new SqlParameter("@v_vend_name", SqlDbType.VarChar, 50),
                   //         new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                   //         new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = ppFirstMiddleLastInspectRegisterEntity.CRUD;
                pDataParameters[1].Value = ppFirstMiddleLastInspectRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = ppFirstMiddleLastInspectRegisterEntity.DATE_TO;
       //         pDataParameters[3].Value = ppFirstMiddleLastInspectRegisterEntity.CONTRACT_ID;
       //         pDataParameters[4].Value = ppFirstMiddleLastInspectRegisterEntity.PART_CODE;
       //         pDataParameters[5].Value = ppFirstMiddleLastInspectRegisterEntity.PART_NAME;
       //         pDataParameters[6].Value = ppFirstMiddleLastInspectRegisterEntity.VEND_CODE;
       //         pDataParameters[7].Value = ppFirstMiddleLastInspectRegisterEntity.VEND_NAME;
       //         pDataParameters[8].Value = ppFirstMiddleLastInspectRegisterEntity.USE_YN;
       //         pDataParameters[9].Value = ppFirstMiddleLastInspectRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FirstMiddleLastInspectRegister_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "FirstMiddleLastInspectRegister_Info_Mst(FirstMiddleLastInspectRegisterEntity ppFirstMiddleLastInspectRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장

        public bool FirstMiddleLastInspectRegister_Save(FirstMiddleLastInspectRegisterEntity pFirstMiddleLastInspectRegisterEntity)
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

                pDataParameters[0].Value = pFirstMiddleLastInspectRegisterEntity.CRUD;
                pDataParameters[1].Value = pFirstMiddleLastInspectRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pFirstMiddleLastInspectRegisterEntity.CONTRACT_ID;
                pDataParameters[3].Value = pFirstMiddleLastInspectRegisterEntity.CONTRACT_DATE;
                pDataParameters[4].Value = pFirstMiddleLastInspectRegisterEntity.PART_CODE;
                pDataParameters[5].Value = pFirstMiddleLastInspectRegisterEntity.VEND_CODE;
                pDataParameters[6].Value = pFirstMiddleLastInspectRegisterEntity.CONTRACT_QTY;
                pDataParameters[7].Value = pFirstMiddleLastInspectRegisterEntity.DELIVERY_DATE;
                pDataParameters[8].Value = pFirstMiddleLastInspectRegisterEntity.DELIVERY_LOCATION;
                pDataParameters[9].Value = pFirstMiddleLastInspectRegisterEntity.UNITCOST;
                pDataParameters[10].Value = pFirstMiddleLastInspectRegisterEntity.COST;
                pDataParameters[11].Value = pFirstMiddleLastInspectRegisterEntity.REMARK;
                pDataParameters[12].Value = pFirstMiddleLastInspectRegisterEntity.USE_YN;
                //pDataParameters[13].Value = pFirstMiddleLastInspectRegisterEntity.UNIT_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FirstMiddleLastInspectRegister_I10", pDataParameters);

                pFirstMiddleLastInspectRegisterEntity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                pFirstMiddleLastInspectRegisterEntity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                pFirstMiddleLastInspectRegisterEntity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                pFirstMiddleLastInspectRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                pFirstMiddleLastInspectRegisterEntity.RTN_AQ = pDataTable.Rows[0]["rtn_aq"].ToString();
                pFirstMiddleLastInspectRegisterEntity.RTN_SQ = pDataTable.Rows[0]["rtn_sq"].ToString();
                pFirstMiddleLastInspectRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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

    public class MixingDegreeRegisterProvider : EntityManager<MixingDegreeRegisterEntity>
    {
        #region 생성자 - MixingDegreeRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MixingDegreeRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - MixingDegreeRegister_Info_Save(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MixingDegreeRegister_Info(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pMixingDegreeRegisterEntity.CRUD;
                pDataParameters[1].Value = pMixingDegreeRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pMixingDegreeRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pMixingDegreeRegisterEntity.PART_CODE;
                pDataParameters[4].Value = pMixingDegreeRegisterEntity.PART_NAME;
                pDataParameters[5].Value = pMixingDegreeRegisterEntity.USE_YN;
                pDataParameters[6].Value = pMixingDegreeRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MixingDegreeRegister_R20", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "MixingDegreeRegister_Info_Save(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 신규등록 조회하기 - MixingDegreeRegister_Info_Sub(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable MixingDegreeRegister_Info_Sub(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)
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

                pDataParameters[0].Value = pMixingDegreeRegisterEntity.CRUD;
                pDataParameters[1].Value = pMixingDegreeRegisterEntity.PART_CODE;
                pDataParameters[2].Value = pMixingDegreeRegisterEntity.LANGUAGE_TYPE;
                
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MixingDegreeRegister_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "MixingDegreeRegister_Info_Sub(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        public bool MixingDegreeRegister_Info_Save(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE

            try
            {
                    int dtCount = 0;
                    _pDBManager.BeginTransaction();

                    if (dt != null)
                    {
                        dtCount = dt.Rows.Count;
                        for (int i = 0; i < dtCount; i++)
                        {
                            IDataParameter[] pDataParameters_detail = null;
                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParameters_detail = new IDataParameter[]
                                    {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_p_part_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_mix_date", MySqlDbType.VarChar,8),
                                        new MySqlParameter("@v_mix_data", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_mix_unit", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParameters_detail = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_p_part_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_part_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_mix_date", SqlDbType.NVarChar,8),
                                        new SqlParameter("@v_mix_data", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_mix_unit", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar,1000)
                                    };
                                    break;
                            }

                            if (dt.Rows[i]["MIX_DATE"].ToString() != "")
                            {
                            pDataParameters_detail[0].Value = dt.Rows[i]["CRUD"].ToString();
                            }
                            else
                            {
                                if (dt.Rows[i]["CRUD"].ToString() == "D")
                                {
                                    pDataParameters_detail[0].Value = dt.Rows[i]["CRUD"].ToString();
                                }
                                else
                                {
                                    pDataParameters_detail[0].Value = "C";
                                }
                            }
                            pDataParameters_detail[1].Value = pMixingDegreeRegisterEntity.USER_CODE;
                            pDataParameters_detail[2].Value = dt.Rows[i]["P_PART_CODE"].ToString();
                            pDataParameters_detail[3].Value = dt.Rows[i]["PART_CODE"].ToString();
                            pDataParameters_detail[4].Value = dt.Rows[i]["MIX_DATE"].ToString();
                            pDataParameters_detail[5].Value = dt.Rows[i]["MIX_DATA"].ToString();
                            pDataParameters_detail[6].Value = dt.Rows[i]["MIX_UNIT"].ToString();
                            pDataParameters_detail[7].Value = dt.Rows[i]["REMARK"].ToString();

                            DataTable pDataTable_sub = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MixingDegreeRegister_I10", pDataParameters_detail);

                            pMixingDegreeRegisterEntity.ERR_NO = pDataTable_sub.Rows[0]["err_no"].ToString();
                            pMixingDegreeRegisterEntity.ERR_MSG = pDataTable_sub.Rows[0]["err_msg"].ToString();
                       
                            if (pDataTable_sub.Rows[0][0].ToString() != "00")
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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override MixingDegreeRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MixingDegreeRegisterEntity pMixingDegreeRegisterEntity = new MixingDegreeRegisterEntity();

                pMixingDegreeRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pMixingDegreeRegisterEntity;
            }
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


    public class ManufacturingHistoryProvider : EntityManager<ManufacturingHistoryEntity>
    {
        #region 생성자 - ManufacturingHistoryProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ManufacturingHistoryProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ManufacturingHistory_Info(ManufacturingHistoryEntity pManufacturingHistoryEntity)
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
                            new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_contract_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pManufacturingHistoryEntity.CRUD;
                pDataParameters[1].Value = pManufacturingHistoryEntity.DATE_FROM;
                pDataParameters[2].Value = pManufacturingHistoryEntity.DATE_TO;
                pDataParameters[3].Value = pManufacturingHistoryEntity.PART_CODE;
                pDataParameters[4].Value = pManufacturingHistoryEntity.PART_NAME;
                pDataParameters[5].Value = pManufacturingHistoryEntity.CONTRACT_ID;
                pDataParameters[6].Value = pManufacturingHistoryEntity.USE_YN;
                pDataParameters[7].Value = pManufacturingHistoryEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ManufacturingHistory_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 양품수량 조회하기 - ManufacturingHistory_Info_Sub(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ManufacturingHistory_Info_Sub(ManufacturingHistoryEntity pManufacturingHistoryEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pManufacturingHistoryEntity.CRUD;
                pDataParameters[1].Value = pManufacturingHistoryEntity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pManufacturingHistoryEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ManufacturingHistory_Sub_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ManufacturingHistory_Info_Sub(ManufacturingHistoryEntity pManufacturingHistoryEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 불량수량 조회하기 - ManufacturingHistory_Info_Sub2(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ManufacturingHistory_Info_Sub2(ManufacturingHistoryEntity pManufacturingHistoryEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pManufacturingHistoryEntity.CRUD;
                pDataParameters[1].Value = pManufacturingHistoryEntity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pManufacturingHistoryEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ManufacturingHistory_Sub_R20", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ManufacturingHistory_Info_Sub(ManufacturingHistoryEntity pManufacturingHistoryEntity)",
                    pException
                );
            }
        }

        #endregion

        public bool ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE

            try
            {
                int dtCount = 0;
                _pDBManager.BeginTransaction();

                if (dt != null)
                {
                    dtCount = dt.Rows.Count;
                    for (int i = 0; i < dtCount; i++)
                    {
                        IDataParameter[] pDataParameters_detail = null;
                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters_detail = new IDataParameter[]
                                {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_p_part_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_mix_date", MySqlDbType.VarChar,8),
                                        new MySqlParameter("@v_mix_data", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_mix_unit", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters_detail = new IDataParameter[]
                                {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_p_part_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_part_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_mix_date", SqlDbType.NVarChar,8),
                                        new SqlParameter("@v_mix_data", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_mix_unit", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar,1000)
                                };
                                break;
                        }

                        if (dt.Rows[i]["MIX_DATE"].ToString() != "")
                        {
                            pDataParameters_detail[0].Value = dt.Rows[i]["CRUD"].ToString();
                        }
                        else
                        {
                            if (dt.Rows[i]["CRUD"].ToString() == "D")
                            {
                                pDataParameters_detail[0].Value = dt.Rows[i]["CRUD"].ToString();
                            }
                            else
                            {
                                pDataParameters_detail[0].Value = "C";
                            }
                        }
                        pDataParameters_detail[1].Value = pManufacturingHistoryEntity.USER_CODE;
                        pDataParameters_detail[2].Value = dt.Rows[i]["P_PART_CODE"].ToString();
                        pDataParameters_detail[3].Value = dt.Rows[i]["PART_CODE"].ToString();
                        pDataParameters_detail[4].Value = dt.Rows[i]["MIX_DATE"].ToString();
                        pDataParameters_detail[5].Value = dt.Rows[i]["MIX_DATA"].ToString();
                        pDataParameters_detail[6].Value = dt.Rows[i]["MIX_UNIT"].ToString();
                        pDataParameters_detail[7].Value = dt.Rows[i]["REMARK"].ToString();

                        DataTable pDataTable_sub = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ManufacturingHistory_I10", pDataParameters_detail);

                        pManufacturingHistoryEntity.ERR_NO = pDataTable_sub.Rows[0]["err_no"].ToString();
                        pManufacturingHistoryEntity.ERR_MSG = pDataTable_sub.Rows[0]["err_msg"].ToString();

                        if (pDataTable_sub.Rows[0][0].ToString() != "00")
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
                    _pDBManager.RollbackTransaction();  // 저장 실패 Rollback Transaction 
                else
                    _pDBManager.CommitTransaction();  // 저장 성공  Commit Transaction
            }

            return pErrorYN;
        }

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ManufacturingHistoryEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ManufacturingHistoryEntity pManufacturingHistoryEntity = new ManufacturingHistoryEntity();

                pManufacturingHistoryEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pManufacturingHistoryEntity;
            }
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

    public class ManufacturingHistory_T01Provider : EntityManager<ManufacturingHistory_T01Entity>
    {
        #region 생성자 - ManufacturingHistoryProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ManufacturingHistory_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ManufacturingHistory_T01_Info(ManufacturingHistory_T01Entity pManufacturingHistory_T01Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pManufacturingHistory_T01Entity.CRUD;
                pDataParameters[1].Value = pManufacturingHistory_T01Entity.DATE_FROM;
                pDataParameters[2].Value = pManufacturingHistory_T01Entity.DATE_TO;
                pDataParameters[3].Value = pManufacturingHistory_T01Entity.PART_CODE;
                pDataParameters[4].Value = pManufacturingHistory_T01Entity.PART_NAME;
                pDataParameters[5].Value = pManufacturingHistory_T01Entity.PRODUCTION_ORDER_ID;
                pDataParameters[6].Value = pManufacturingHistory_T01Entity.USE_YN;
                pDataParameters[7].Value = pManufacturingHistory_T01Entity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ManufacturingHistory_T01_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 양품수량 조회하기 - ManufacturingHistory_Info_Sub(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ManufacturingHistory_T01_Info_Sub(ManufacturingHistory_T01Entity pManufacturingHistory_T01Entity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pManufacturingHistory_T01Entity.CRUD;
                pDataParameters[1].Value = pManufacturingHistory_T01Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pManufacturingHistory_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ManufacturingHistory_T01_Sub_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ManufacturingHistory_Info_Sub(ManufacturingHistoryEntity pManufacturingHistoryEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 불량수량 조회하기 - ManufacturingHistory_Info_Sub2(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ManufacturingHistory_T01_Info_Sub2(ManufacturingHistory_T01Entity pManufacturingHistory_T01Entity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pManufacturingHistory_T01Entity.CRUD;
                pDataParameters[1].Value = pManufacturingHistory_T01Entity.PRODUCTION_ORDER_ID;
                pDataParameters[2].Value = pManufacturingHistory_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ManufacturingHistory_T01_Sub_R20", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ManufacturingHistory_Info_Sub(ManufacturingHistoryEntity pManufacturingHistoryEntity)",
                    pException
                );
            }
        }

        #endregion

        public bool ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE

            try
            {
                int dtCount = 0;
                _pDBManager.BeginTransaction();

                if (dt != null)
                {
                    dtCount = dt.Rows.Count;
                    for (int i = 0; i < dtCount; i++)
                    {
                        IDataParameter[] pDataParameters_detail = null;
                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters_detail = new IDataParameter[]
                                {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_p_part_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_mix_date", MySqlDbType.VarChar,8),
                                        new MySqlParameter("@v_mix_data", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_mix_unit", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters_detail = new IDataParameter[]
                                {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_p_part_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_part_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_mix_date", SqlDbType.NVarChar,8),
                                        new SqlParameter("@v_mix_data", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_mix_unit", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar,1000)
                                };
                                break;
                        }

                        if (dt.Rows[i]["MIX_DATE"].ToString() != "")
                        {
                            pDataParameters_detail[0].Value = dt.Rows[i]["CRUD"].ToString();
                        }
                        else
                        {
                            if (dt.Rows[i]["CRUD"].ToString() == "D")
                            {
                                pDataParameters_detail[0].Value = dt.Rows[i]["CRUD"].ToString();
                            }
                            else
                            {
                                pDataParameters_detail[0].Value = "C";
                            }
                        }
                        pDataParameters_detail[1].Value = pManufacturingHistoryEntity.USER_CODE;
                        pDataParameters_detail[2].Value = dt.Rows[i]["P_PART_CODE"].ToString();
                        pDataParameters_detail[3].Value = dt.Rows[i]["PART_CODE"].ToString();
                        pDataParameters_detail[4].Value = dt.Rows[i]["MIX_DATE"].ToString();
                        pDataParameters_detail[5].Value = dt.Rows[i]["MIX_DATA"].ToString();
                        pDataParameters_detail[6].Value = dt.Rows[i]["MIX_UNIT"].ToString();
                        pDataParameters_detail[7].Value = dt.Rows[i]["REMARK"].ToString();

                        DataTable pDataTable_sub = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ManufacturingHistory_I10", pDataParameters_detail);

                        pManufacturingHistoryEntity.ERR_NO = pDataTable_sub.Rows[0]["err_no"].ToString();
                        pManufacturingHistoryEntity.ERR_MSG = pDataTable_sub.Rows[0]["err_msg"].ToString();

                        if (pDataTable_sub.Rows[0][0].ToString() != "00")
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
                    _pDBManager.RollbackTransaction();  // 저장 실패 Rollback Transaction 
                else
                    _pDBManager.CommitTransaction();  // 저장 성공  Commit Transaction
            }

            return pErrorYN;
        }

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ManufacturingHistory_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ManufacturingHistory_T01Entity pManufacturingHistory_T01Entity = new ManufacturingHistory_T01Entity();

                pManufacturingHistory_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pManufacturingHistory_T01Entity;
            }
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

    public class FirstMiddleLastItemProvider : EntityManager<FirstMiddleLastItemEntity>
    {
        #region 생성자 - ManufacturingHistoryProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public FirstMiddleLastItemProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable FirstMiddleLast_Item_Info(FirstMiddleLastItemEntity pFirstMiddleLastItemEntity)
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
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 150),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 150),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pFirstMiddleLastItemEntity.CRUD;
                pDataParameters[1].Value = pFirstMiddleLastItemEntity.PART_CODE;
                pDataParameters[2].Value = pFirstMiddleLastItemEntity.PART_NAME;
                pDataParameters[3].Value = pFirstMiddleLastItemEntity.USE_YN;
                pDataParameters[4].Value = pFirstMiddleLastItemEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FirstMiddleLastItemRegister_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity)",
                    pException
                );
            }
        }

        #endregion

        public bool FirstMiddleLast_Item_Info_Save(FirstMiddleLastItemEntity pFirstMiddleLastItemEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
   
            int dtCount = 0;
            _pDBManager.BeginTransaction();
            try
            {
                if (dt != null)
                {
                    dtCount = dt.Rows.Count;
                    for (int i = 0; i < dtCount; i++)
                    {
                        IDataParameter[] pDataParameters_detail = null;
                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters_detail = new IDataParameter[]
                                {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_part_code", MySqlDbType.VarChar,20),
                                        new MySqlParameter("@v_part_name", MySqlDbType.VarChar,150),
                                        new MySqlParameter("@v_inspect_Item", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_inspect_standard", MySqlDbType.VarChar,150),
                                        new MySqlParameter("@v_inspect_fixture", MySqlDbType.VarChar,20),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,10),
                                        new MySqlParameter("@v_item_id", MySqlDbType.VarChar, 50)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters_detail = new IDataParameter[]
                                {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_part_code", SqlDbType.NVarChar,20),
                                        new SqlParameter("@v_part_name", SqlDbType.NVarChar,150),
                                        new SqlParameter("@v_inspect_Item", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_inspect_standard", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_inspect_fixture", SqlDbType.NVarChar,20),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,10),
                                        new SqlParameter("@_item_id", SqlDbType.NVarChar,50)
                                };
                                break;
                        }

                        pDataParameters_detail[0].Value = dt.Rows[i]["CRUD"].ToString();
                        if (dt.Rows[i]["CRUD"].ToString().Equals("U"))
                        {
                            pDataParameters_detail[8].Value = dt.Rows[i]["ITEM_ID"].ToString();
                        }
                        else
                        {
                            pDataParameters_detail[8].Value = "";
                        }
                        pDataParameters_detail[1].Value = pFirstMiddleLastItemEntity.PART_CODE;
                        pDataParameters_detail[2].Value = pFirstMiddleLastItemEntity.PART_NAME;
                        pDataParameters_detail[3].Value = dt.Rows[i]["INSPECT_ITEM"].ToString();
                        pDataParameters_detail[4].Value = dt.Rows[i]["INSPECT_STANDARD"].ToString();
                        pDataParameters_detail[5].Value = dt.Rows[i]["INSPECT_FIXTURE"].ToString();
                        pDataParameters_detail[7].Value = dt.Rows[i]["USE_YN"].ToString();
                        pDataParameters_detail[6].Value = pFirstMiddleLastItemEntity.USER_CODE;

                        DataTable pDataTable_sub = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FirstMiddleLastItemRegister_I10", pDataParameters_detail);

                        if (pDataTable_sub.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pFirstMiddleLastItemEntity.ERR_NO = pDataTable_sub.Rows[0]["p_err_no"].ToString();
                        pFirstMiddleLastItemEntity.ERR_MSG = pDataTable_sub.Rows[0]["p_err_msg"].ToString();

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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override FirstMiddleLastItemEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                FirstMiddleLastItemEntity pFirstMiddleLastItemEntity = new FirstMiddleLastItemEntity();

                pFirstMiddleLastItemEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pFirstMiddleLastItemEntity;
            }
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

    public class QualityInspectProvider : EntityManager<QualityInspectEntity>
    {
        #region 생성자 - QualityInspectProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public QualityInspectProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - QualityInspect_Info_Save(QualityInspectEntity pQualityInspectEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable QualityInspect_Info(QualityInspectEntity pQualityInspectEntity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pQualityInspectEntity.CRUD;
                pDataParameters[1].Value = pQualityInspectEntity.DATE_FROM;
                pDataParameters[2].Value = pQualityInspectEntity.DATE_TO;
                pDataParameters[3].Value = pQualityInspectEntity.PART_CODE;
                pDataParameters[4].Value = pQualityInspectEntity.PART_NAME;
                pDataParameters[5].Value = pQualityInspectEntity.PRODUCTION_ORDER_ID;
                pDataParameters[6].Value = pQualityInspectEntity.USE_YN;
                pDataParameters[7].Value = pQualityInspectEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_QualityInspectStatus_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "QualityInspect_Info_Save(QualityInspectEntity pQualityInspectEntity)",
                    pException
                );
            }
        }

        #endregion


        public bool QualityInspect_Info_Save(QualityInspectEntity pQualityInspectEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE

            try
            {
                int dtCount = 0;
                _pDBManager.BeginTransaction();

                if (dt != null)
                {
                    dtCount = dt.Rows.Count;
                    for (int i = 0; i < dtCount; i++)
                    {
                        IDataParameter[] pDataParameters_detail = null;
                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters_detail = new IDataParameter[]
                                {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_p_part_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_mix_date", MySqlDbType.VarChar,8),
                                        new MySqlParameter("@v_mix_data", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_mix_unit", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters_detail = new IDataParameter[]
                                {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_p_part_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_part_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_mix_date", SqlDbType.NVarChar,8),
                                        new SqlParameter("@v_mix_data", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_mix_unit", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar,1000)
                                };
                                break;
                        }

                        if (dt.Rows[i]["MIX_DATE"].ToString() != "")
                        {
                            pDataParameters_detail[0].Value = dt.Rows[i]["CRUD"].ToString();
                        }
                        else
                        {
                            if (dt.Rows[i]["CRUD"].ToString() == "D")
                            {
                                pDataParameters_detail[0].Value = dt.Rows[i]["CRUD"].ToString();
                            }
                            else
                            {
                                pDataParameters_detail[0].Value = "C";
                            }
                        }
                        pDataParameters_detail[1].Value = pQualityInspectEntity.USER_CODE;
                        pDataParameters_detail[2].Value = dt.Rows[i]["P_PART_CODE"].ToString();
                        pDataParameters_detail[3].Value = dt.Rows[i]["PART_CODE"].ToString();
                        pDataParameters_detail[4].Value = dt.Rows[i]["MIX_DATE"].ToString();
                        pDataParameters_detail[5].Value = dt.Rows[i]["MIX_DATA"].ToString();
                        pDataParameters_detail[6].Value = dt.Rows[i]["MIX_UNIT"].ToString();
                        pDataParameters_detail[7].Value = dt.Rows[i]["REMARK"].ToString();

                        DataTable pDataTable_sub = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_QualityInspect_I10", pDataParameters_detail);

                        pQualityInspectEntity.ERR_NO = pDataTable_sub.Rows[0]["err_no"].ToString();
                        pQualityInspectEntity.ERR_MSG = pDataTable_sub.Rows[0]["err_msg"].ToString();

                        if (pDataTable_sub.Rows[0][0].ToString() != "00")
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
                    _pDBManager.RollbackTransaction();  // 저장 실패 Rollback Transaction 
                else
                    _pDBManager.CommitTransaction();  // 저장 성공  Commit Transaction
            }

            return pErrorYN;
        }

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override QualityInspectEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                QualityInspectEntity pQualityInspectEntity = new QualityInspectEntity();

                pQualityInspectEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pQualityInspectEntity;
            }
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

    public class ImportInspectRegisterProvider : EntityManager<ImportInspectRegisterEntity>
    {
        #region 생성자 - ImportInspectRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ImportInspectRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - QualityInspect_Info_Save(QualityInspectEntity pQualityInspectEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ImportInspectRegister_Info(ImportInspectRegisterEntity _pImportInspectRegisterEntity)
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
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 2),
                            new MySqlParameter("@v_inspect_id",MySqlDbType.VarChar, 20)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_lot_no", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 2)

                };
                        break;
                }

                pDataParameters[0].Value = _pImportInspectRegisterEntity.CRUD;
                pDataParameters[1].Value = _pImportInspectRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = _pImportInspectRegisterEntity.DATE_TO;
                pDataParameters[3].Value = _pImportInspectRegisterEntity.ORDER_ID;
                pDataParameters[4].Value = _pImportInspectRegisterEntity.LOT_NO;
                
                pDataParameters[5].Value = _pImportInspectRegisterEntity.USE_YN;
                pDataParameters[6].Value = _pImportInspectRegisterEntity.INSPECT_ID;             


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ImportInspectRegister_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "QualityInspect_Info_Save(QualityInspectEntity pQualityInspectEntity)",
                    pException
                );
            }
        }

        #endregion


        public bool ImportInspectRegister_Info_Save(ImportInspectRegisterEntity pImportInspectRegisterEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE

            try
            {
                int dtCount = 0;
                _pDBManager.BeginTransaction();

                
                        IDataParameter[] pDataParameters_detail = null;
                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParameters_detail = new IDataParameter[]
                                {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar,20),
                                        new MySqlParameter("@v_order_id", MySqlDbType.VarChar,50),                                        
                                        new MySqlParameter("@v_inspect_date", MySqlDbType.VarChar,10),
                                        new MySqlParameter("@v_lot_no", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_part_name", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_mi_measures", MySqlDbType.Decimal),
                                        new MySqlParameter("@v_moisture_measures", MySqlDbType.Decimal),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 2)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters_detail = new IDataParameter[]
                                {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_order_id", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_inspect_date", SqlDbType.NVarChar,10),
                                        new SqlParameter("@v_lot_no", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_part_name", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_mi_measures", SqlDbType.Decimal),
                                        new SqlParameter("@v_moisture_measures", SqlDbType.Decimal),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 2)
                                };
                                break;
                        }

                        
                        pDataParameters_detail[0].Value = pImportInspectRegisterEntity.CRUD;
                        pDataParameters_detail[1].Value = pImportInspectRegisterEntity.INSPECT_ID;
                        pDataParameters_detail[2].Value = pImportInspectRegisterEntity.ORDER_ID;
                        pDataParameters_detail[3].Value = pImportInspectRegisterEntity.INSPECT_DATE;
                        pDataParameters_detail[4].Value = pImportInspectRegisterEntity.LOT_NO;
                        pDataParameters_detail[5].Value = pImportInspectRegisterEntity.PART_NAME;
                        pDataParameters_detail[6].Value = pImportInspectRegisterEntity.MI_MEASURES;
                        pDataParameters_detail[7].Value = pImportInspectRegisterEntity.MOISTURE_MEASERES;
                        pDataParameters_detail[8].Value = pImportInspectRegisterEntity.USER_CODE;
                        pDataParameters_detail[9].Value = pImportInspectRegisterEntity.USE_YN;
                        

                        DataTable pDataTable_sub = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ImportInspectRegister_I10", pDataParameters_detail);

                        pImportInspectRegisterEntity.ERR_NO = pDataTable_sub.Rows[0]["err_no"].ToString();
                        pImportInspectRegisterEntity.ERR_MSG = pDataTable_sub.Rows[0]["err_msg"].ToString();

                        if (pDataTable_sub.Rows[0][0].ToString() != "00")
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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override ImportInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ImportInspectRegisterEntity pImportInspectRegisterEntity = new ImportInspectRegisterEntity();

                pImportInspectRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pImportInspectRegisterEntity;
            }
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


    public class HACCPCheckRegisterProvider : EntityManager<HACCPCheckRegisterEntity>
    {
        #region 생성자 - HACCPCheckRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public HACCPCheckRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)
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

                pDataParameters[0].Value = pHACCPCheckRegisterEntity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterEntity.WINDOW_NAME;
                pDataParameters[2].Value = pHACCPCheckRegisterEntity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - HACCPCheckRegister_Info_Mst(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable HACCPCheckRegister_Info_Mst(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterEntity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterEntity.HACCP_ID;
                pDataParameters[2].Value = pHACCPCheckRegisterEntity.DATE_FROM;
                pDataParameters[3].Value = pHACCPCheckRegisterEntity.DATE_TO;
                pDataParameters[4].Value = pHACCPCheckRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_R10", pDataParameters);

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
                    "HACCPCheckRegister_Info_Mst(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)",
                    pException
                );
            }

        }

        public DataSet HACCPCheckRegister_info_ExcelBinding(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterEntity.HACCP_ID;
                pDataParameters[1].Value = pHACCPCheckRegisterEntity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_HACCPCheckRegister_R20", pDataParameters);

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
                    "Sample_Info_Mst(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)",
                    pException
                );
            }

        }
        #endregion

        #region 마스터 정보 저장하기 - HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_date", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_process_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_sample_no", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_dept", MySqlDbType.VarChar,15),
                                new MySqlParameter("@v_sample_user", MySqlDbType.VarChar, 15)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_date", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_process_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_sample_no", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_dept", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_sample_user", SqlDbType.NVarChar, 15)

                        };
                        break;
                }

                pDataParametersA[0].Value = pHACCPCheckRegisterEntity.CRUD;
                pDataParametersA[1].Value = pHACCPCheckRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pHACCPCheckRegisterEntity.HACCP_ID;
                pDataParametersA[3].Value = pHACCPCheckRegisterEntity.HACCP_DATE;  //점검일
                pDataParametersA[4].Value = sheet_1.GetCellValue(2, 3).ToString();  //품목명
                pDataParametersA[5].Value = sheet_1.GetCellValue(2, 4).ToString();  //공정명
                pDataParametersA[6].Value = sheet_1.GetCellValue(2, 5).ToString();  //점검번호
                pDataParametersA[7].Value = sheet_1.GetCellValue(2, 6).ToString();  //점검의뢰부서 
                pDataParametersA[8].Value = sheet_1.GetCellValue(5, 4).ToString();  //담당자 

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_I10", pDataParametersA);

                pHACCPCheckRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pHACCPCheckRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pHACCPCheckRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pHACCPCheckRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "HACCPCheckRegister_Info_Save(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity, DataTable dt)",
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

        #region 디테일 정보 저장하기 - HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                //int rowcnt = pHACCPCheckRegisterEntity.dtListCnt;
                for (int i = 0; i < 33; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_user", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_haccp_result", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_haccp_code", MySqlDbType.VarChar,50)

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_haccp_result", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_haccp_code", SqlDbType.NVarChar, 50)

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pHACCPCheckRegisterEntity.CRUD;
                    pDataParametersA[1].Value = pHACCPCheckRegisterEntity.USER_CODE;
                    pDataParametersA[2].Value = pHACCPCheckRegisterEntity.HACCP_ID;
                    pDataParametersA[3].Value = sheet_1.GetCellValue(4, i + 9).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(5, i + 9).ToString();
                    pDataParametersA[5].Value = i + 1;

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_I20", pDataParametersA);

                    pHACCPCheckRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pHACCPCheckRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pHACCPCheckRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pHACCPCheckRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override HACCPCheckRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                HACCPCheckRegisterEntity pHACCPCheckRegisterEntity = new HACCPCheckRegisterEntity();

                pHACCPCheckRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pHACCPCheckRegisterEntity;
            }
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


    public class HACCPCheckRegisterT01Provider : EntityManager<HACCPCheckRegisterT01Entity>
    {
        #region 생성자 - HACCPCheckRegisterT02Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public HACCPCheckRegisterT01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)
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

                pDataParameters[0].Value = pHACCPCheckRegisterT01Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT01Entity.WINDOW_NAME;
                pDataParameters[2].Value = pHACCPCheckRegisterT01Entity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT01Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT01Entity.HACCP_ID;
                pDataParameters[2].Value = pHACCPCheckRegisterT01Entity.DATE_FROM;
                pDataParameters[3].Value = pHACCPCheckRegisterT01Entity.DATE_TO;
                pDataParameters[4].Value = pHACCPCheckRegisterT01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_R30", pDataParameters);

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
                    "HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)",
                    pException
                );
            }

        }

        public DataSet HACCPCheckRegister_info_ExcelBinding(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT01Entity.HACCP_ID;
                pDataParameters[1].Value = pHACCPCheckRegisterT01Entity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_HACCPCheckRegister_R40", pDataParameters);

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
                    "Sample_Info_Mst(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)",
                    pException
                );
            }

        }
        #endregion

        #region 마스터 정보 저장하기 - HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_date", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_process_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_sample_no", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_dept", MySqlDbType.VarChar,15),
                                new MySqlParameter("@v_sample_user", MySqlDbType.VarChar, 15)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_date", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_process_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_sample_no", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_dept", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_sample_user", SqlDbType.NVarChar, 15)

                        };
                        break;
                }

                pDataParametersA[0].Value = pHACCPCheckRegisterT01Entity.CRUD;
                pDataParametersA[1].Value = pHACCPCheckRegisterT01Entity.USER_CODE;
                pDataParametersA[2].Value = pHACCPCheckRegisterT01Entity.HACCP_ID;
                pDataParametersA[3].Value = pHACCPCheckRegisterT01Entity.HACCP_DATE;  //점검일
                pDataParametersA[4].Value = sheet_1.GetCellValue(2, 3).ToString();  //품목명
                pDataParametersA[5].Value = sheet_1.GetCellValue(2, 4).ToString();  //공정명
                pDataParametersA[6].Value = sheet_1.GetCellValue(2, 5).ToString();  //점검번호
                pDataParametersA[7].Value = sheet_1.GetCellValue(2, 6).ToString();  //점검의뢰부서 
                pDataParametersA[8].Value = sheet_1.GetCellValue(5, 4).ToString();  //담당자 

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_I30", pDataParametersA);

                pHACCPCheckRegisterT01Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pHACCPCheckRegisterT01Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pHACCPCheckRegisterT01Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pHACCPCheckRegisterT01Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity, DataTable dt)",
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

        #region 디테일 정보 저장하기 - HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                //int rowcnt = pHACCPCheckRegisterT02Entity.dtListCnt;
                for (int i = 0; i < 33; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_user", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_haccp_result", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_haccp_code", MySqlDbType.VarChar,50)

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_haccp_result", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_haccp_code", SqlDbType.NVarChar, 50)

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pHACCPCheckRegisterT01Entity.CRUD;
                    pDataParametersA[1].Value = pHACCPCheckRegisterT01Entity.USER_CODE;
                    pDataParametersA[2].Value = pHACCPCheckRegisterT01Entity.HACCP_ID;
                    pDataParametersA[3].Value = sheet_1.GetCellValue(4, i + 9).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(5, i + 9).ToString();
                    pDataParametersA[5].Value = i + 1;

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_I40", pDataParametersA);

                    pHACCPCheckRegisterT01Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pHACCPCheckRegisterT01Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pHACCPCheckRegisterT01Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pHACCPCheckRegisterT01Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override HACCPCheckRegisterT01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity = new HACCPCheckRegisterT01Entity();

                pHACCPCheckRegisterT01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pHACCPCheckRegisterT01Entity;
            }
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

    public class HACCPCheckRegisterT02Provider : EntityManager<HACCPCheckRegisterT02Entity>
    {
        #region 생성자 - HACCPCheckRegisterT02Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public HACCPCheckRegisterT02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)
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

                pDataParameters[0].Value = pHACCPCheckRegisterT02Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT02Entity.WINDOW_NAME;
                pDataParameters[2].Value = pHACCPCheckRegisterT02Entity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT02Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT02Entity.HACCP_ID;
                pDataParameters[2].Value = pHACCPCheckRegisterT02Entity.DATE_FROM;
                pDataParameters[3].Value = pHACCPCheckRegisterT02Entity.DATE_TO;
                pDataParameters[4].Value = pHACCPCheckRegisterT02Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_R50", pDataParameters);

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
                    "HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)",
                    pException
                );
            }

        }

        public DataSet HACCPCheckRegister_info_ExcelBinding(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT02Entity.HACCP_ID;
                pDataParameters[1].Value = pHACCPCheckRegisterT02Entity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_HACCPCheckRegister_R60", pDataParameters);

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
                    "Sample_Info_Mst(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)",
                    pException
                );
            }

        }
        #endregion

        #region 마스터 정보 저장하기 - HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_date", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_process_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_sample_no", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_dept", MySqlDbType.VarChar,15),
                                new MySqlParameter("@v_sample_user", MySqlDbType.VarChar, 15)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_date", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_process_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_sample_no", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_dept", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_sample_user", SqlDbType.NVarChar, 15)

                        };
                        break;
                }

                pDataParametersA[0].Value = pHACCPCheckRegisterT02Entity.CRUD;
                pDataParametersA[1].Value = pHACCPCheckRegisterT02Entity.USER_CODE;
                pDataParametersA[2].Value = pHACCPCheckRegisterT02Entity.HACCP_ID;
                pDataParametersA[3].Value = pHACCPCheckRegisterT02Entity.HACCP_DATE;  //점검일
                pDataParametersA[4].Value = sheet_1.GetCellValue(2, 3).ToString();  //품목명
                pDataParametersA[5].Value = sheet_1.GetCellValue(2, 4).ToString();  //공정명
                pDataParametersA[6].Value = sheet_1.GetCellValue(2, 5).ToString();  //점검번호
                pDataParametersA[7].Value = sheet_1.GetCellValue(2, 6).ToString();  //점검의뢰부서 
                pDataParametersA[8].Value = sheet_1.GetCellValue(5, 4).ToString();  //담당자 

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_I50", pDataParametersA);

                pHACCPCheckRegisterT02Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pHACCPCheckRegisterT02Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pHACCPCheckRegisterT02Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pHACCPCheckRegisterT02Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity, DataTable dt)",
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

        #region 디테일 정보 저장하기 - HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                //int rowcnt = pHACCPCheckRegisterT02Entity.dtListCnt;
                for (int i = 0; i < 33; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_user", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_haccp_result", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_haccp_code", MySqlDbType.VarChar,50)

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_haccp_result", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_haccp_code", SqlDbType.NVarChar, 50)

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pHACCPCheckRegisterT02Entity.CRUD;
                    pDataParametersA[1].Value = pHACCPCheckRegisterT02Entity.USER_CODE;
                    pDataParametersA[2].Value = pHACCPCheckRegisterT02Entity.HACCP_ID;
                    pDataParametersA[3].Value = sheet_1.GetCellValue(4, i + 9).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(5, i + 9).ToString();
                    pDataParametersA[5].Value = i + 1;

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_I60", pDataParametersA);

                    pHACCPCheckRegisterT02Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pHACCPCheckRegisterT02Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pHACCPCheckRegisterT02Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pHACCPCheckRegisterT02Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override HACCPCheckRegisterT02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity = new HACCPCheckRegisterT02Entity();

                pHACCPCheckRegisterT02Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pHACCPCheckRegisterT02Entity;
            }
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

    public class HACCPCheckRegisterT03Provider : EntityManager<HACCPCheckRegisterT03Entity>
    {
        #region 생성자 - HACCPCheckRegisterT03Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public HACCPCheckRegisterT03Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)
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

                pDataParameters[0].Value = pHACCPCheckRegisterT03Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT03Entity.WINDOW_NAME;
                pDataParameters[2].Value = pHACCPCheckRegisterT03Entity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT03Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT03Entity.HACCP_ID;
                pDataParameters[2].Value = pHACCPCheckRegisterT03Entity.DATE_FROM;
                pDataParameters[3].Value = pHACCPCheckRegisterT03Entity.DATE_TO;
                pDataParameters[4].Value = pHACCPCheckRegisterT03Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T03_R10", pDataParameters);

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
                    "HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)",
                    pException
                );
            }

        }

        public DataSet HACCPCheckRegister_info_ExcelBinding(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT03Entity.HACCP_ID;
                pDataParameters[1].Value = pHACCPCheckRegisterT03Entity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T03_R20", pDataParameters);

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
                    "Sample_Info_Mst(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)",
                    pException
                );
            }

        }
        #endregion

        #region 마스터 정보 저장하기 - HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_date", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_test_user1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_user", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_remark1", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_remark2", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_remark3", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_remark4", MySqlDbType.VarChar, 1000)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_date", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_test_user3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_user", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark1", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark2", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark3", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark4", SqlDbType.NVarChar, 15)

                        };
                        break;
                }

                pDataParametersA[0].Value = pHACCPCheckRegisterT03Entity.CRUD;
                pDataParametersA[1].Value = pHACCPCheckRegisterT03Entity.USER_CODE;
                pDataParametersA[2].Value = pHACCPCheckRegisterT03Entity.HACCP_ID;
                pDataParametersA[3].Value = pHACCPCheckRegisterT03Entity.HACCP_DATE;  //점검일
                pDataParametersA[4].Value = sheet_1.GetCellValue(57, 3).ToString();  //작성자
                pDataParametersA[5].Value = sheet_1.GetCellValue(65, 3).ToString();  //검토자
                pDataParametersA[6].Value = sheet_1.GetCellValue(73, 3).ToString();  //승인자
                pDataParametersA[7].Value = sheet_1.GetCellValue(46, 8).ToString();  //점검자
                pDataParametersA[8].Value = sheet_1.GetCellValue(1, 22).ToString();  //한계기준 이탈내용
                pDataParametersA[9].Value = sheet_1.GetCellValue(32, 22).ToString();  //개선조치 및 결과
                pDataParametersA[10].Value = sheet_1.GetCellValue(61, 22).ToString();  //조치자
                pDataParametersA[11].Value = sheet_1.GetCellValue(73, 22).ToString();  //확인

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T03_I10", pDataParametersA);

                pHACCPCheckRegisterT03Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pHACCPCheckRegisterT03Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pHACCPCheckRegisterT03Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pHACCPCheckRegisterT03Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity, DataTable dt)",
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

        #region 디테일 정보 저장하기 - HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                //int rowcnt = pHACCPCheckRegisterT03Entity.dtListCnt;
                for (int i = 0; i < 8; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_yes", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_haccp_no", MySqlDbType.VarChar,20),
                                new MySqlParameter("@v_haccp_code", MySqlDbType.VarChar,50)

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_yes", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_no", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_code", SqlDbType.NVarChar, 50)

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pHACCPCheckRegisterT03Entity.CRUD;
                    pDataParametersA[1].Value = pHACCPCheckRegisterT03Entity.USER_CODE;
                    pDataParametersA[2].Value = pHACCPCheckRegisterT03Entity.HACCP_ID;
                    pDataParametersA[3].Value = sheet_1.GetCellValue(0, i + 1).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(1, i + 1).ToString();
                    pDataParametersA[5].Value = i + 1;

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T03_I20", pDataParametersA);

                    pHACCPCheckRegisterT03Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pHACCPCheckRegisterT03Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pHACCPCheckRegisterT03Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pHACCPCheckRegisterT03Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override HACCPCheckRegisterT03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity = new HACCPCheckRegisterT03Entity();

                pHACCPCheckRegisterT03Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pHACCPCheckRegisterT03Entity;
            }
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

    public class HACCPCheckRegisterT04Provider : EntityManager<HACCPCheckRegisterT04Entity>
    {
        #region 생성자 - HACCPCheckRegisterT04Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public HACCPCheckRegisterT04Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)
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

                pDataParameters[0].Value = pHACCPCheckRegisterT04Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT04Entity.WINDOW_NAME;
                pDataParameters[2].Value = pHACCPCheckRegisterT04Entity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT04Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT04Entity.HACCP_ID;
                pDataParameters[2].Value = pHACCPCheckRegisterT04Entity.DATE_FROM;
                pDataParameters[3].Value = pHACCPCheckRegisterT04Entity.DATE_TO;
                pDataParameters[4].Value = pHACCPCheckRegisterT04Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T04_R10", pDataParameters);

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
                    "HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)",
                    pException
                );
            }

        }

        public DataSet HACCPCheckRegister_info_ExcelBinding(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT04Entity.HACCP_ID;
                pDataParameters[1].Value = pHACCPCheckRegisterT04Entity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T04_R20", pDataParameters);

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
                    "Sample_Info_Mst(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)",
                    pException
                );
            }

        }
        #endregion

        #region 마스터 정보 저장하기 - HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_date", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_test_user1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_user", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_remark1", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_remark2", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_remark3", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_remark4", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part1_name", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part1_comp_time", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part1_end_time", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part1_comp_qty", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part1_metal_qty", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part2_name", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part2_comp_time", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part2_end_time", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part2_comp_qty", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part2_metal_qty", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part_remark", MySqlDbType.VarChar, 1000)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_date", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_test_user1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_user", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark1", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark2", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark3", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark4", SqlDbType.NVarChar, 15),
                                new MySqlParameter("@v_part1_name", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part1_comp_time", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part1_end_time", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part1_comp_qty", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part1_metal_qty", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part2_name", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part2_comp_time", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part2_end_time", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part2_comp_qty", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part2_metal_qty", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part_remark", MySqlDbType.VarChar, 1000)

                        };
                        break;
                }

                pDataParametersA[0].Value = pHACCPCheckRegisterT04Entity.CRUD;
                pDataParametersA[1].Value = pHACCPCheckRegisterT04Entity.USER_CODE;
                pDataParametersA[2].Value = pHACCPCheckRegisterT04Entity.HACCP_ID;
                pDataParametersA[3].Value = pHACCPCheckRegisterT04Entity.HACCP_DATE;  //점검일
                pDataParametersA[4].Value = sheet_1.GetCellValue(57, 3).ToString();  //작성자
                pDataParametersA[5].Value = sheet_1.GetCellValue(65, 3).ToString();  //검토자
                pDataParametersA[6].Value = sheet_1.GetCellValue(73, 3).ToString();  //승인자
                pDataParametersA[7].Value = sheet_1.GetCellValue(46, 8).ToString();  //점검자
                pDataParametersA[8].Value = sheet_1.GetCellValue(1, 82).ToString();  //한계기준 이탈내용
                pDataParametersA[9].Value = sheet_1.GetCellValue(21, 82).ToString();  //개선조치 및 결과
                pDataParametersA[10].Value = sheet_1.GetCellValue(50, 82).ToString();  //조치자
                pDataParametersA[11].Value = sheet_1.GetCellValue(62, 82).ToString();  //확인

                pDataParametersA[12].Value = sheet_1.GetCellValue(1, 58).ToString();  //제품1명
                pDataParametersA[13].Value = sheet_1.GetCellValue(12, 58).ToString();  //제품1통과시간
                pDataParametersA[14].Value = sheet_1.GetCellValue(21, 58).ToString();  //제품1종료시간
                pDataParametersA[15].Value = sheet_1.GetCellValue(32, 58).ToString();  //제품1통과량
                pDataParametersA[16].Value = sheet_1.GetCellValue(43, 58).ToString();  //제품1금속량

                pDataParametersA[17].Value = sheet_1.GetCellValue(1, 60).ToString();  //제품2명
                pDataParametersA[18].Value = sheet_1.GetCellValue(12, 60).ToString();  //제품2통과시간
                pDataParametersA[19].Value = sheet_1.GetCellValue(21, 60).ToString();  //제품2종료시간
                pDataParametersA[20].Value = sheet_1.GetCellValue(32, 60).ToString();  //제품2통과량
                pDataParametersA[21].Value = sheet_1.GetCellValue(43, 60).ToString();  //제품2금속량

                pDataParametersA[22].Value = sheet_1.GetCellValue(53, 58).ToString();  //제품 특이사항

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T04_I10", pDataParametersA);

                pHACCPCheckRegisterT04Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pHACCPCheckRegisterT04Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pHACCPCheckRegisterT04Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pHACCPCheckRegisterT04Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity, DataTable dt)",
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

        #region 디테일 정보 저장하기 - HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                //int rowcnt = pHACCPCheckRegisterT04Entity.dtListCnt;
                for (int i = 0; i < 5; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_code", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_part_name", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_part_time", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_part_inspect", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_part_broken", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_part_clean", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_part_test", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_part_sign", MySqlDbType.VarChar,1000)
                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_part_name", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_part_time", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_part_inspect", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_part_broken", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_part_clean", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_part_test", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_part_sign", SqlDbType.NVarChar, 1000)

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pHACCPCheckRegisterT04Entity.CRUD;
                    pDataParametersA[1].Value = pHACCPCheckRegisterT04Entity.USER_CODE;
                    pDataParametersA[2].Value = pHACCPCheckRegisterT04Entity.HACCP_ID;
                    pDataParametersA[3].Value = i + 1;
                    pDataParametersA[4].Value = sheet_1.GetCellValue(1, i + 1).ToString();
                    pDataParametersA[5].Value = sheet_1.GetCellValue(2, i + 1).ToString();
                    pDataParametersA[6].Value = sheet_1.GetCellValue(3, i + 1).ToString();
                    pDataParametersA[7].Value = sheet_1.GetCellValue(4, i + 1).ToString();
                    pDataParametersA[8].Value = sheet_1.GetCellValue(5, i + 1).ToString();
                    pDataParametersA[9].Value = sheet_1.GetCellValue(6, i + 1).ToString();
                    pDataParametersA[10].Value = sheet_1.GetCellValue(7, i + 1).ToString();


                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T04_I20", pDataParametersA);

                    pHACCPCheckRegisterT04Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pHACCPCheckRegisterT04Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pHACCPCheckRegisterT04Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pHACCPCheckRegisterT04Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override HACCPCheckRegisterT04Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity = new HACCPCheckRegisterT04Entity();

                pHACCPCheckRegisterT04Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pHACCPCheckRegisterT04Entity;
            }
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

    public class HACCPCheckRegisterT05Provider : EntityManager<HACCPCheckRegisterT05Entity>
    {
        #region 생성자 - HACCPCheckRegisterT05Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public HACCPCheckRegisterT05Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)
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

                pDataParameters[0].Value = pHACCPCheckRegisterT05Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT05Entity.WINDOW_NAME;
                pDataParameters[2].Value = pHACCPCheckRegisterT05Entity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT05Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT05Entity.HACCP_ID;
                pDataParameters[2].Value = pHACCPCheckRegisterT05Entity.DATE_FROM;
                pDataParameters[3].Value = pHACCPCheckRegisterT05Entity.DATE_TO;
                pDataParameters[4].Value = pHACCPCheckRegisterT05Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T05_R10", pDataParameters);

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
                    "HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)",
                    pException
                );
            }

        }

        public DataSet HACCPCheckRegister_info_ExcelBinding(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT05Entity.HACCP_ID;
                pDataParameters[1].Value = pHACCPCheckRegisterT05Entity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T05_R20", pDataParameters);

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
                    "Sample_Info_Mst(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)",
                    pException
                );
            }

        }
        #endregion

        #region 마스터 정보 저장하기 - HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_date", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_test_user1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_user", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_remark1", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_remark2", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_remark3", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_remark4", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_part1_name", MySqlDbType.VarChar, 1000)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_date", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_test_user1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_user", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark1", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark2", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark3", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark4", SqlDbType.NVarChar, 15)

                        };
                        break;
                }

                pDataParametersA[0].Value = pHACCPCheckRegisterT05Entity.CRUD;
                pDataParametersA[1].Value = pHACCPCheckRegisterT05Entity.USER_CODE;
                pDataParametersA[2].Value = pHACCPCheckRegisterT05Entity.HACCP_ID;
                pDataParametersA[3].Value = pHACCPCheckRegisterT05Entity.HACCP_DATE;  //점검일
                pDataParametersA[4].Value = sheet_1.GetCellValue(57, 3).ToString();  //작성자
                pDataParametersA[5].Value = sheet_1.GetCellValue(65, 3).ToString();  //검토자
                pDataParametersA[6].Value = sheet_1.GetCellValue(73, 3).ToString();  //승인자
                pDataParametersA[7].Value = sheet_1.GetCellValue(46, 8).ToString();  //점검자
                pDataParametersA[8].Value = sheet_1.GetCellValue(1, 39).ToString();  //한계기준 이탈내용
                pDataParametersA[9].Value = sheet_1.GetCellValue(28, 39).ToString();  //개선조치 및 결과
                pDataParametersA[10].Value = sheet_1.GetCellValue(54, 39).ToString();  //조치자
                pDataParametersA[11].Value = sheet_1.GetCellValue(70, 39).ToString();  //확인

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T05_I10", pDataParametersA);

                pHACCPCheckRegisterT05Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pHACCPCheckRegisterT05Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pHACCPCheckRegisterT05Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pHACCPCheckRegisterT05Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity, DataTable dt)",
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

        #region 디테일 정보 저장하기 - HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                //int rowcnt = pHACCPCheckRegisterT05Entity.dtListCnt;
                for (int i = 0; i < 6; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_code", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_part_time", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_part_name", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_part_sterilization", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_unit1_one", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_unit1_two", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_unit2_one", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_unit2_two", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_part_verdict", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_part_sign", MySqlDbType.VarChar,1000)
                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_part_time", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_part_name", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_part_sterilization", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_unit1_one", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_unit1_two", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_unit2_one", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_unit2_two", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_part_verdict", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_part_sign", SqlDbType.NVarChar, 1000)
                            };
                            break;
                    }

                    pDataParametersA[0].Value = pHACCPCheckRegisterT05Entity.CRUD;
                    pDataParametersA[1].Value = pHACCPCheckRegisterT05Entity.USER_CODE;
                    pDataParametersA[2].Value = pHACCPCheckRegisterT05Entity.HACCP_ID;
                    pDataParametersA[3].Value = i + 1;
                    pDataParametersA[4].Value = sheet_1.GetCellValue(2, i + 1).ToString(); // 시간
                    pDataParametersA[5].Value = sheet_1.GetCellValue(3, i + 1).ToString(); // 품명
                    pDataParametersA[6].Value = sheet_1.GetCellValue(4, i + 1).ToString(); // 살균시간
                    pDataParametersA[7].Value = sheet_1.GetCellValue(5, i + 1).ToString(); // 1호기1번등
                    pDataParametersA[8].Value = sheet_1.GetCellValue(6, i + 1).ToString(); // 1호기2번등
                    pDataParametersA[9].Value = sheet_1.GetCellValue(7, i + 1).ToString(); // 2호기1번등
                    pDataParametersA[10].Value = sheet_1.GetCellValue(8, i + 1).ToString(); //2호기2번등
                    pDataParametersA[11].Value = sheet_1.GetCellValue(9, i + 1).ToString(); //판정
                    pDataParametersA[12].Value = sheet_1.GetCellValue(10, i + 1).ToString(); //서명

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T05_I20", pDataParametersA);

                    pHACCPCheckRegisterT05Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pHACCPCheckRegisterT05Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pHACCPCheckRegisterT05Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pHACCPCheckRegisterT05Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override HACCPCheckRegisterT05Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity = new HACCPCheckRegisterT05Entity();

                pHACCPCheckRegisterT05Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pHACCPCheckRegisterT05Entity;
            }
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

    public class HACCPCheckRegisterT06Provider : EntityManager<HACCPCheckRegisterT06Entity>
    {
        #region 생성자 - HACCPCheckRegisterT06Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public HACCPCheckRegisterT06Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)
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

                pDataParameters[0].Value = pHACCPCheckRegisterT06Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT06Entity.WINDOW_NAME;
                pDataParameters[2].Value = pHACCPCheckRegisterT06Entity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT06Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT06Entity.HACCP_ID;
                pDataParameters[2].Value = pHACCPCheckRegisterT06Entity.DATE_FROM;
                pDataParameters[3].Value = pHACCPCheckRegisterT06Entity.DATE_TO;
                pDataParameters[4].Value = pHACCPCheckRegisterT06Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T06_R10", pDataParameters);

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
                    "HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)",
                    pException
                );
            }

        }

        public DataSet HACCPCheckRegister_info_ExcelBinding(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT06Entity.HACCP_ID;
                pDataParameters[1].Value = pHACCPCheckRegisterT06Entity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T06_R20", pDataParameters);

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
                    "Sample_Info_Mst(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)",
                    pException
                );
            }

        }
        #endregion

        #region 마스터 정보 저장하기 - HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_date", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_test_user1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_check1", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_check2", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_check3", MySqlDbType.VarChar, 1000)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_date", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_test_user1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_check1", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_check2", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_check3", SqlDbType.NVarChar, 1000)

                        };
                        break;
                }

                pDataParametersA[0].Value = pHACCPCheckRegisterT06Entity.CRUD;
                pDataParametersA[1].Value = pHACCPCheckRegisterT06Entity.USER_CODE;
                pDataParametersA[2].Value = pHACCPCheckRegisterT06Entity.HACCP_ID;
                pDataParametersA[3].Value = pHACCPCheckRegisterT06Entity.HACCP_DATE;  //점검일

                pDataParametersA[4].Value = sheet_1.GetCellValue(7, 4).ToString();  //작성자
                pDataParametersA[5].Value = sheet_1.GetCellValue(9, 4).ToString();  //검토자
                pDataParametersA[6].Value = sheet_1.GetCellValue(11, 4).ToString();  //승인자

                pDataParametersA[7].Value = sheet_1.GetCellValue(8, 30).ToString();  //적합 항목수
                pDataParametersA[8].Value = sheet_1.GetCellValue(10, 30).ToString();  //적합 항목비율
                pDataParametersA[9].Value = sheet_1.GetCellValue(8, 31).ToString();  //최종판정

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T06_I10", pDataParametersA);

                pHACCPCheckRegisterT06Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pHACCPCheckRegisterT06Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pHACCPCheckRegisterT06Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pHACCPCheckRegisterT06Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity, DataTable dt)",
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

        #region 디테일 정보 저장하기 - HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                //int rowcnt = pHACCPCheckRegisterT06Entity.dtListCnt;
                for (int i = 0; i < 21; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_haccp_result", MySqlDbType.VarChar,100)

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_haccp_result", SqlDbType.NVarChar, 100)

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pHACCPCheckRegisterT06Entity.CRUD;
                    pDataParametersA[1].Value = pHACCPCheckRegisterT06Entity.USER_CODE;
                    pDataParametersA[2].Value = pHACCPCheckRegisterT06Entity.HACCP_ID;
                    pDataParametersA[3].Value = i + 1;
                    pDataParametersA[4].Value = sheet_1.GetCellValue(0, i + 1).ToString();
                    

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T06_I20", pDataParametersA);

                    pHACCPCheckRegisterT06Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pHACCPCheckRegisterT06Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pHACCPCheckRegisterT06Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pHACCPCheckRegisterT06Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override HACCPCheckRegisterT06Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity = new HACCPCheckRegisterT06Entity();

                pHACCPCheckRegisterT06Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pHACCPCheckRegisterT06Entity;
            }
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

    public class HACCPCheckRegisterT07Provider : EntityManager<HACCPCheckRegisterT07Entity>
    {
        #region 생성자 - HACCPCheckRegisterT07Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public HACCPCheckRegisterT07Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)
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

                pDataParameters[0].Value = pHACCPCheckRegisterT07Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT07Entity.WINDOW_NAME;
                pDataParameters[2].Value = pHACCPCheckRegisterT07Entity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT07Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT07Entity.HACCP_ID;
                pDataParameters[2].Value = pHACCPCheckRegisterT07Entity.DATE_FROM;
                pDataParameters[3].Value = pHACCPCheckRegisterT07Entity.DATE_TO;
                pDataParameters[4].Value = pHACCPCheckRegisterT07Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T07_R10", pDataParameters);

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
                    "HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)",
                    pException
                );
            }

        }

        public DataSet HACCPCheckRegister_info_ExcelBinding(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT07Entity.HACCP_ID;
                pDataParameters[1].Value = pHACCPCheckRegisterT07Entity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T07_R20", pDataParameters);

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
                    "Sample_Info_Mst(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)",
                    pException
                );
            }

        }
        #endregion

        #region 마스터 정보 저장하기 - HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_date", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_test_user1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_sample_user", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_remark1", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_remark2", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_remark3", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_remark4", MySqlDbType.VarChar, 1000)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_date", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_test_user3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_sample_user", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark1", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_remark2", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_remark3", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_remark4", SqlDbType.NVarChar, 1000)

                        };
                        break;
                }

                pDataParametersA[0].Value = pHACCPCheckRegisterT07Entity.CRUD;
                pDataParametersA[1].Value = pHACCPCheckRegisterT07Entity.USER_CODE;
                pDataParametersA[2].Value = pHACCPCheckRegisterT07Entity.HACCP_ID;
                pDataParametersA[3].Value = pHACCPCheckRegisterT07Entity.HACCP_DATE;  //점검일
                pDataParametersA[4].Value = sheet_1.GetCellValue(14, 3).ToString();  //작성자
                pDataParametersA[5].Value = sheet_1.GetCellValue(16, 3).ToString();  //검토자
                pDataParametersA[6].Value = sheet_1.GetCellValue(18, 3).ToString();  //승인자
                pDataParametersA[7].Value = sheet_1.GetCellValue(11, 5).ToString();  //점검자
                pDataParametersA[8].Value = sheet_1.GetCellValue(1, 42).ToString();  //한계기준 이탈내용
                pDataParametersA[9].Value = sheet_1.GetCellValue(7, 42).ToString();  //개선조치 및 결과
                pDataParametersA[10].Value = sheet_1.GetCellValue(12, 42).ToString();  //조치자
                pDataParametersA[11].Value = sheet_1.GetCellValue(15, 42).ToString();  //확인

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T07_I10", pDataParametersA);

                pHACCPCheckRegisterT07Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pHACCPCheckRegisterT07Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pHACCPCheckRegisterT07Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pHACCPCheckRegisterT07Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity, DataTable dt)",
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

        #region 디테일 정보 저장하기 - HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                //int rowcnt = pHACCPCheckRegisterT07Entity.dtListCnt;
                for (int i = 0; i < 33; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_yes", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_haccp_no", MySqlDbType.VarChar,20),
                                new MySqlParameter("@v_haccp_code", MySqlDbType.VarChar,50)

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_yes", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_no", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_code", SqlDbType.NVarChar, 50)

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pHACCPCheckRegisterT07Entity.CRUD;
                    pDataParametersA[1].Value = pHACCPCheckRegisterT07Entity.USER_CODE;
                    pDataParametersA[2].Value = pHACCPCheckRegisterT07Entity.HACCP_ID;
                    pDataParametersA[3].Value = sheet_1.GetCellValue(0, i + 1).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(1, i + 1).ToString();
                    pDataParametersA[5].Value = i + 1;


                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T07_I20", pDataParametersA);

                    pHACCPCheckRegisterT07Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pHACCPCheckRegisterT07Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pHACCPCheckRegisterT07Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pHACCPCheckRegisterT07Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override HACCPCheckRegisterT07Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity = new HACCPCheckRegisterT07Entity();

                pHACCPCheckRegisterT07Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pHACCPCheckRegisterT07Entity;
            }
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

    public class HACCPCheckRegisterT08Provider : EntityManager<HACCPCheckRegisterT08Entity>
    {
        #region 생성자 - HACCPCheckRegisterT08Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public HACCPCheckRegisterT08Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)
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

                pDataParameters[0].Value = pHACCPCheckRegisterT08Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT08Entity.WINDOW_NAME;
                pDataParameters[2].Value = pHACCPCheckRegisterT08Entity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT08Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT08Entity.HACCP_ID;
                pDataParameters[2].Value = pHACCPCheckRegisterT08Entity.DATE_FROM;
                pDataParameters[3].Value = pHACCPCheckRegisterT08Entity.DATE_TO;
                pDataParameters[4].Value = pHACCPCheckRegisterT08Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T08_R10", pDataParameters);

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
                    "HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)",
                    pException
                );
            }

        }

        public DataSet HACCPCheckRegister_info_ExcelBinding(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT08Entity.HACCP_ID;
                pDataParameters[1].Value = pHACCPCheckRegisterT08Entity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T08_R20", pDataParameters);

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
                    "Sample_Info_Mst(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)",
                    pException
                );
            }

        }
        #endregion

        #region 마스터 정보 저장하기 - HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_date", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_test_user1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user4", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_date", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_test_user1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user4", SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParametersA[0].Value = pHACCPCheckRegisterT08Entity.CRUD;
                pDataParametersA[1].Value = pHACCPCheckRegisterT08Entity.USER_CODE;
                pDataParametersA[2].Value = pHACCPCheckRegisterT08Entity.HACCP_ID;
                pDataParametersA[3].Value = pHACCPCheckRegisterT08Entity.HACCP_DATE;  //점검일
                pDataParametersA[4].Value = sheet_1.GetCellValue(4, 1).ToString();  //담당
                pDataParametersA[5].Value = sheet_1.GetCellValue(5, 1).ToString();  //전결1
                pDataParametersA[6].Value = sheet_1.GetCellValue(7, 1).ToString();  //전결2
                pDataParametersA[7].Value = sheet_1.GetCellValue(9, 1).ToString();  //전결3
                
                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T08_I10", pDataParametersA);

                pHACCPCheckRegisterT08Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pHACCPCheckRegisterT08Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pHACCPCheckRegisterT08Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pHACCPCheckRegisterT08Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity, DataTable dt)",
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

        #region 디테일 정보 저장하기 - HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                //int rowcnt = pHACCPCheckRegisterT08Entity.dtListCnt;
                for (int i = 0; i < 22; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_vend_part", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_vend_tell", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_vend_num", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_vend_rank", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_haccp_code", MySqlDbType.VarChar,50)

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_part", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_tell", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_num", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_rank", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_haccp_code", SqlDbType.NVarChar, 50)

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pHACCPCheckRegisterT08Entity.CRUD;
                    pDataParametersA[1].Value = pHACCPCheckRegisterT08Entity.USER_CODE;
                    pDataParametersA[2].Value = pHACCPCheckRegisterT08Entity.HACCP_ID;
                    pDataParametersA[3].Value = sheet_1.GetCellValue(0, i + 1).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(1, i + 1).ToString();
                    pDataParametersA[5].Value = sheet_1.GetCellValue(2, i + 1).ToString();
                    pDataParametersA[6].Value = sheet_1.GetCellValue(3, i + 1).ToString();
                    pDataParametersA[7].Value = sheet_1.GetCellValue(4, i + 1).ToString();
                    pDataParametersA[8].Value = sheet_1.GetCellValue(5, i + 1).ToString();
                    pDataParametersA[9].Value = i + 1;


                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T08_I20", pDataParametersA);

                    pHACCPCheckRegisterT08Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pHACCPCheckRegisterT08Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pHACCPCheckRegisterT08Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pHACCPCheckRegisterT08Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override HACCPCheckRegisterT08Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity = new HACCPCheckRegisterT08Entity();

                pHACCPCheckRegisterT08Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pHACCPCheckRegisterT08Entity;
            }
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

    public class HACCPCheckRegisterT09Provider : EntityManager<HACCPCheckRegisterT09Entity>
    {
        #region 생성자 - HACCPCheckRegisterT09Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public HACCPCheckRegisterT09Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)
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

                pDataParameters[0].Value = pHACCPCheckRegisterT09Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT09Entity.WINDOW_NAME;
                pDataParameters[2].Value = pHACCPCheckRegisterT09Entity.LANGUAGE_TYPE;

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
        #region 마스터 조회하기 - HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT09Entity.CRUD;
                pDataParameters[1].Value = pHACCPCheckRegisterT09Entity.HACCP_ID;
                pDataParameters[2].Value = pHACCPCheckRegisterT09Entity.DATE_FROM;
                pDataParameters[3].Value = pHACCPCheckRegisterT09Entity.DATE_TO;
                pDataParameters[4].Value = pHACCPCheckRegisterT09Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T08_R10", pDataParameters);

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
                    "HACCPCheckRegister_Info_Mst(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)",
                    pException
                );
            }

        }

        public DataSet HACCPCheckRegister_info_ExcelBinding(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pHACCPCheckRegisterT09Entity.HACCP_ID;
                pDataParameters[1].Value = pHACCPCheckRegisterT09Entity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T08_R20", pDataParameters);

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
                    "Sample_Info_Mst(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)",
                    pException
                );
            }

        }
        #endregion

        #region 마스터 정보 저장하기 - HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_haccp_date", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_test_user1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_test_user4", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_haccp_date", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_test_user1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_test_user4", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pHACCPCheckRegisterT09Entity.CRUD;
                pDataParametersA[1].Value = pHACCPCheckRegisterT09Entity.USER_CODE;
                pDataParametersA[2].Value = pHACCPCheckRegisterT09Entity.HACCP_ID;
                pDataParametersA[3].Value = pHACCPCheckRegisterT09Entity.HACCP_DATE;  //점검일
                pDataParametersA[4].Value = sheet_1.GetCellValue(4, 1).ToString();  //담당
                pDataParametersA[5].Value = sheet_1.GetCellValue(5, 1).ToString();  //전결1
                pDataParametersA[6].Value = sheet_1.GetCellValue(7, 1).ToString();  //전결2
                pDataParametersA[7].Value = sheet_1.GetCellValue(9, 1).ToString();  //전결3

                pDataParametersA[8].Value = sheet_1.GetCellValue(9, 1).ToString();  //
                pDataParametersA[9].Value = sheet_1.GetCellValue(9, 1).ToString();  //
                pDataParametersA[10].Value = sheet_1.GetCellValue(9, 1).ToString();  //
                pDataParametersA[11].Value = sheet_1.GetCellValue(9, 1).ToString();  //

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T08_I10", pDataParametersA);

                pHACCPCheckRegisterT09Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pHACCPCheckRegisterT09Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pHACCPCheckRegisterT09Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pHACCPCheckRegisterT09Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity, DataTable dt)",
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

        #region 디테일 정보 저장하기 - HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                //int rowcnt = pHACCPCheckRegisterT09Entity.dtListCnt;
                for (int i = 0; i < 22; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_vend_part", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_vend_tell", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_vend_num", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_vend_rank", MySqlDbType.VarChar,100),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_haccp_code", MySqlDbType.VarChar,50)

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_vend_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_part", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_tell", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_num", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_rank", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_haccp_code", SqlDbType.NVarChar, 50)

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pHACCPCheckRegisterT09Entity.CRUD;
                    pDataParametersA[1].Value = pHACCPCheckRegisterT09Entity.USER_CODE;
                    pDataParametersA[2].Value = pHACCPCheckRegisterT09Entity.HACCP_ID;
                    pDataParametersA[3].Value = sheet_1.GetCellValue(0, i + 1).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(1, i + 1).ToString();
                    pDataParametersA[5].Value = sheet_1.GetCellValue(2, i + 1).ToString();
                    pDataParametersA[6].Value = sheet_1.GetCellValue(3, i + 1).ToString();
                    pDataParametersA[7].Value = sheet_1.GetCellValue(4, i + 1).ToString();
                    pDataParametersA[8].Value = sheet_1.GetCellValue(5, i + 1).ToString();
                    pDataParametersA[9].Value = i + 1;


                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_HACCPCheckRegister_T08_I20", pDataParametersA);

                    pHACCPCheckRegisterT09Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pHACCPCheckRegisterT09Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pHACCPCheckRegisterT09Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pHACCPCheckRegisterT09Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override HACCPCheckRegisterT09Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity = new HACCPCheckRegisterT09Entity();

                pHACCPCheckRegisterT09Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pHACCPCheckRegisterT09Entity;
            }
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

    public class BarcodeLabelPrintProvider : EntityManager<BarcodeLabelPrintEntity>
    {
        #region 생성자 - BarcodeLabelPrintProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public BarcodeLabelPrintProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - BarcodeLabelPrint_Info_Mst(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pBarcodeLabelPrintEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BarcodeLabelPrint_Info_Mst(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)
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
                            new MySqlParameter("@v_part_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_approval_yn", MySqlDbType.VarChar, 10),
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
                            new SqlParameter("@v_part_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_approval_yn", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pBarcodeLabelPrintEntity.CRUD;
                pDataParameters[1].Value = pBarcodeLabelPrintEntity.DATE_FROM;
                pDataParameters[2].Value = pBarcodeLabelPrintEntity.DATE_TO;
                pDataParameters[3].Value = pBarcodeLabelPrintEntity.PART_CODE;
                pDataParameters[4].Value = pBarcodeLabelPrintEntity.PART_NAME;
                pDataParameters[5].Value = pBarcodeLabelPrintEntity.PART_TYPE;
                pDataParameters[6].Value = pBarcodeLabelPrintEntity.APPROVAL_YN;
                pDataParameters[7].Value = pBarcodeLabelPrintEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_BarcodeLabelPrint_R10", pDataParameters);

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

        #region 바코드 CMD 조회하기 - BarcodeLabelPrint_Info(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pBarcodeLabelPrintEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BarcodeLabelPrint_Info(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_process_code_mst", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pBarcodeLabelPrintEntity.PROCESS_CODE_MST;
                pDataParameters[1].Value = pBarcodeLabelPrintEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_BarcodeLabelPrint_R20", pDataParameters);

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

        #region 바코드 프린트 COM_PORT 조회하기 - BarcodeLabelPrint_Info(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pBarcodeLabelPrintEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BarcodeLabelPrint_COM_Info(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)
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
                
                pDataParameters[0].Value = pBarcodeLabelPrintEntity.LANGUAGE_TYPE;
                pDataParameters[1].Value = pBarcodeLabelPrintEntity.TERMINAL_CODE;

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
                    "MaterialOutRegister_Info_Mst(MaterialOutRegisterEntity pMaterialOutRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 터미널 정보 조회하기 - BarcodeLabelPrint_Info_sub(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pBarcodeLabelPrintEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BarcodeLabelPrint_Info_sub(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_terminal_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_terminal_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pBarcodeLabelPrintEntity.TERMINAL_NAME;
                pDataParameters[1].Value = pBarcodeLabelPrintEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R40", pDataParameters);

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

        #region 업체 번호 조회하기 - BarcodeLabelPrint_Vend_Info(string partCode)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BarcodeLabelPrint_Vend_Info(string partCode)
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

                pDataParameters[0].Value = partCode;
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

        #region 바코드 발행 정보 저장하기 - BarcodeLabelPrint_Info_Save(BarcodeLabelPrintEntity pMaterialOrderStatusEntity, DataTable dt)       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool BarcodeLabelPrint_Info_Save(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
                                   //int pCount = 0;
            _pDBManager.BeginTransaction();
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
                                    new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar,15),
                                    new MySqlParameter("@v_inspect_date", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_vend_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_store_temp", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_specific_gravity_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_specific_gravity", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_end_date", MySqlDbType.VarChar,20),
                                    new MySqlParameter("@v_inspect_no", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_make_no", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_make_vend", MySqlDbType.VarChar,50)
                                 //   new MySqlParameter("@v_remark", MySqlDbType.VarChar,50)
                            };
                            break;

                        case "SQLServer":
                            pDataParameters = new IDataParameter[]
                            {
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_inspect_id", SqlDbType.NVarChar,15),
                                    new SqlParameter("@v_inspect_date", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_vend_code", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_store_temp", SqlDbType.NVarChar,50),
                                    new SqlParameter("@v_specific_gravity_code", SqlDbType.VarChar,50),
                                    new SqlParameter("@v_specific_gravity", SqlDbType.VarChar,50),
                                    new SqlParameter("@v_end_date", SqlDbType.VarChar,20),
                                    new SqlParameter("@v_inspect_no", SqlDbType.VarChar,50),
                                    new SqlParameter("@v_make_no", SqlDbType.VarChar,50),
                                    new SqlParameter("@v_make_vend", SqlDbType.VarChar,50)
                                 //   new SqlParameter("@v_remark", SqlDbType.VarChar,50)

                            };
                            break;
                    }


                     pDataParameters[0].Value = pBarcodeLabelPrintEntity.CRUD;
                     pDataParameters[1].Value = pBarcodeLabelPrintEntity.USER_CODE;
                     pDataParameters[2].Value= pBarcodeLabelPrintEntity.INSPECT_ID; 
                      pDataParameters[3].Value= pBarcodeLabelPrintEntity.INSPECT_DATE.Replace("-","");
                     pDataParameters[4].Value= pBarcodeLabelPrintEntity.VEND_CODE;
                     pDataParameters[5].Value= pBarcodeLabelPrintEntity.STORE_TEMP;
                     pDataParameters[6].Value= pBarcodeLabelPrintEntity.SPECIFIC_GRAVITY_CODE;
                     pDataParameters[7].Value = pBarcodeLabelPrintEntity.SPECIFIC_GRAVITY;
                     pDataParameters[8].Value= pBarcodeLabelPrintEntity.END_DATE;
                     pDataParameters[9].Value= pBarcodeLabelPrintEntity.INSPECT_NO;
                     pDataParameters[10].Value= pBarcodeLabelPrintEntity.MAKE_NO;
                     pDataParameters[11].Value= pBarcodeLabelPrintEntity.MAKE_VEND;
                 //    pDataParameters[12].Value = pBarcodeLabelPrintEntity.REMARK;


                    //_gdSUB.DataSource = null;
                    //여러 그리드 사용시 마스터 그리드는 최초 실행 시에만 초기화


                    DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_BarcodeLabelPrint_I10", pDataParameters);

                    if (pDataTable.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }

                    pBarcodeLabelPrintEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                    pBarcodeLabelPrintEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                    pBarcodeLabelPrintEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                    pBarcodeLabelPrintEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                    pBarcodeLabelPrintEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "BarcodeLabelPrint_Info_Save(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity, DataTable dt)",
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
        public override BarcodeLabelPrintEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                BarcodeLabelPrintEntity pBarcodeLabelPrintEntity = new BarcodeLabelPrintEntity();

                //pBarcodeLabelPrintEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pBarcodeLabelPrintEntity;
            }
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

    public class ProductBadMonthStatusProvider : EntityManager<ProductBadMonthStatusEntity>
    {
        #region 생성자 - ProductPlanMonthStatusProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductBadMonthStatusProvider(DBManager pDBManager)
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
        public DataTable Sample_Info_Mst(ProductBadMonthStatusEntity pProductBadMonthStatusEntity)
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

                pDataParameters[0].Value = pProductBadMonthStatusEntity.CRUD;
                pDataParameters[1].Value = pProductBadMonthStatusEntity.DATE;


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
        public DataTable ProductBadMonthStatus_Info_Filename(ProductBadMonthStatusEntity pProductBadMonthStatusEntity)
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

                pDataParameters[0].Value = pProductBadMonthStatusEntity.WINDOW_NAME;
                pDataParameters[1].Value = pProductBadMonthStatusEntity.LANGUAGE_TYPE;

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
        public object Templete_Download(ProductBadMonthStatusEntity pProductBadMonthStatusEntity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pProductBadMonthStatusEntity.LANGUAGE_TYPE;

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
        public override ProductBadMonthStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductBadMonthStatusEntity pResultStatusPlanResultEntity = new ProductBadMonthStatusEntity();

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

    public class FirstMiddleLastInspectRegister_T01Provider : EntityManager<FirstMiddleLastInspectRegister_T01Entity>
    {
        #region ○ 생성자

        public FirstMiddleLastInspectRegister_T01Provider(DBManager pDBManager)
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
        public override FirstMiddleLastInspectRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                FirstMiddleLastInspectRegister_T01Entity pFirstMiddleLastInspectRegister_T01Entity = new FirstMiddleLastInspectRegister_T01Entity();

                pFirstMiddleLastInspectRegister_T01Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pFirstMiddleLastInspectRegister_T01Entity;
            }
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

        public DataTable FirstMiddleLastInspectRegister_T01_Info_Mst(FirstMiddleLastInspectRegister_T01Entity ppFirstMiddleLastInspectRegister_T01Entity)
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
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),                            
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_firstmiddlelast", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),                            
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_firstmiddlelast", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = ppFirstMiddleLastInspectRegister_T01Entity.CRUD;
                pDataParameters[1].Value = ppFirstMiddleLastInspectRegister_T01Entity.DATE_FROM;
                pDataParameters[2].Value = ppFirstMiddleLastInspectRegister_T01Entity.DATE_TO;
                pDataParameters[3].Value = ppFirstMiddleLastInspectRegister_T01Entity.ORDER_ID;
                pDataParameters[4].Value = ppFirstMiddleLastInspectRegister_T01Entity.PART_CODE;
                pDataParameters[5].Value = ppFirstMiddleLastInspectRegister_T01Entity.PART_NAME;                
                pDataParameters[6].Value = ppFirstMiddleLastInspectRegister_T01Entity.USE_YN;
                pDataParameters[7].Value = ppFirstMiddleLastInspectRegister_T01Entity.LANGUAGE_TYPE;
                pDataParameters[8].Value = ppFirstMiddleLastInspectRegister_T01Entity.FIRSTMIDDLELAST;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FirstMiddleLastInspectRegister_T01_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "FirstMiddleLastInspectRegister_T01_Info_Mst(FirstMiddleLastInspectRegister_T01Entity ppFirstMiddleLastInspectRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 데이터 저장

        public bool FirstMiddleLastInspectRegister_T01_Save(FirstMiddleLastInspectRegister_T01Entity pFirstMiddleLastInspectRegister_T01Entity)
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
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 15),                            
                            new MySqlParameter("@v_firstmiddlelast", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_appearance_1", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_appearance_2", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_appearance_3", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_appearance_4", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_appearance_5", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_appearance_6", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_appearance_7", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_appearance_8", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_appearance_9", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_carve", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_color", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_weight", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_cf", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_final", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 2000)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_order_id", SqlDbType.VarChar, 15),
                            new SqlParameter("@v_firstmiddlelast", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_appearance_1", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_appearance_2", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_appearance_3", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_appearance_4", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_appearance_5", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_appearance_6", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_appearance_7", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_appearance_8", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_appearance_9", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_carve", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_color", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_weight", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_cf", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_final", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_remark", SqlDbType.VarChar, 2000)
                        };
                        break;
                }

                pDataParameters[0].Value = pFirstMiddleLastInspectRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pFirstMiddleLastInspectRegister_T01Entity.USER_CODE;
                pDataParameters[2].Value = pFirstMiddleLastInspectRegister_T01Entity.ORDER_ID;
                pDataParameters[3].Value = pFirstMiddleLastInspectRegister_T01Entity.FIRSTMIDDLELAST;
                pDataParameters[4].Value = pFirstMiddleLastInspectRegister_T01Entity.APPEARANCE_1;
                pDataParameters[5].Value = pFirstMiddleLastInspectRegister_T01Entity.APPEARANCE_2;
                pDataParameters[6].Value = pFirstMiddleLastInspectRegister_T01Entity.APPEARANCE_3;
                pDataParameters[7].Value = pFirstMiddleLastInspectRegister_T01Entity.APPEARANCE_4;
                pDataParameters[8].Value = pFirstMiddleLastInspectRegister_T01Entity.APPEARANCE_5;
                pDataParameters[9].Value = pFirstMiddleLastInspectRegister_T01Entity.APPEARANCE_6;
                pDataParameters[10].Value = pFirstMiddleLastInspectRegister_T01Entity.APPEARANCE_7;
                pDataParameters[11].Value = pFirstMiddleLastInspectRegister_T01Entity.APPEARANCE_8;
                pDataParameters[12].Value = pFirstMiddleLastInspectRegister_T01Entity.APPEARANCE_9;
                pDataParameters[13].Value = pFirstMiddleLastInspectRegister_T01Entity.CARVE;
                pDataParameters[14].Value = pFirstMiddleLastInspectRegister_T01Entity.COLOR;
                pDataParameters[15].Value = pFirstMiddleLastInspectRegister_T01Entity.WEIGHT;
                pDataParameters[16].Value = pFirstMiddleLastInspectRegister_T01Entity.CF;
                pDataParameters[17].Value = pFirstMiddleLastInspectRegister_T01Entity.FINAL;
                pDataParameters[18].Value = pFirstMiddleLastInspectRegister_T01Entity.USE_YN;
                pDataParameters[19].Value = pFirstMiddleLastInspectRegister_T01Entity.REMARK;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FirstMiddleLastInspectRegister_T01_I10", pDataParameters);

                pFirstMiddleLastInspectRegister_T01Entity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                pFirstMiddleLastInspectRegister_T01Entity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                pFirstMiddleLastInspectRegister_T01Entity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                pFirstMiddleLastInspectRegister_T01Entity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                pFirstMiddleLastInspectRegister_T01Entity.RTN_AQ = pDataTable.Rows[0]["rtn_aq"].ToString();
                pFirstMiddleLastInspectRegister_T01Entity.RTN_SQ = pDataTable.Rows[0]["rtn_sq"].ToString();
                pFirstMiddleLastInspectRegister_T01Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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

        #region ○ 수주 수정 시, 해당 수주번호로 내려진 생산계획이 있는지 조회 - Sample_Check_Next_Process(FirstMiddleLastInspectRegister_T01Entity pFirstMiddleLastInspectRegister_T01Entity)

        public DataTable Sample_Check_Next_Process(FirstMiddleLastInspectRegister_T01Entity pFirstMiddleLastInspectRegister_T01Entity)
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
                            new MySqlParameter("@v_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_firstmiddlelast", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
                            new SqlParameter("@v_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_firstmiddlelast", SqlDbType.VarChar, 50)
                };
                        break;
                }

                pDataParameters[0].Value = pFirstMiddleLastInspectRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pFirstMiddleLastInspectRegister_T01Entity.DATE_FROM;
                pDataParameters[2].Value = pFirstMiddleLastInspectRegister_T01Entity.DATE_TO;
                pDataParameters[3].Value = pFirstMiddleLastInspectRegister_T01Entity.ORDER_ID;
                pDataParameters[4].Value = pFirstMiddleLastInspectRegister_T01Entity.PART_CODE;
                pDataParameters[5].Value = pFirstMiddleLastInspectRegister_T01Entity.PART_NAME;
                pDataParameters[6].Value = pFirstMiddleLastInspectRegister_T01Entity.USE_YN;
                pDataParameters[7].Value = pFirstMiddleLastInspectRegister_T01Entity.LANGUAGE_TYPE;
                pDataParameters[8].Value = pFirstMiddleLastInspectRegister_T01Entity.FIRSTMIDDLELAST;
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FirstMiddleLastInspectRegister_T01_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "FirstMiddleLastInspectRegister_T01_Info_Mst(FirstMiddleLastInspectRegister_T01Entity ppFirstMiddleLastInspectRegister_T01Entity)",
                    pException
                );
            }
            //try
            //{
            //    IDataParameter[] pDataParameters = null;

            //    switch (_pDBManager.DBManagerType.ToString())
            //    {
            //        case "MySql":
            //            pDataParameters = new IDataParameter[]
            //            {
            //                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
            //                new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
            //                new MySqlParameter("@v_date_to", MySqlDbType.VarChar,8),
            //                new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 50),
            //                new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
            //                new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
            //                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
            //                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


            //    };
            //            break;

            //        case "SQLServer":
            //            pDataParameters = new IDataParameter[]
            //            {
            //                new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
            //                new SqlParameter("@v_date_from", SqlDbType.VarChar, 8),
            //                new SqlParameter("@v_date_to", SqlDbType.VarChar,8),
            //                new SqlParameter("@v_contract_id", SqlDbType.VarChar, 50),
            //                new SqlParameter("@v_part_code", SqlDbType.VarChar, 50),
            //                new SqlParameter("@v_part_name", SqlDbType.VarChar, 50),
            //                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
            //                new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

            //    };
            //            break;
            //    }

            //    pDataParameters[0].Value = pFirstMiddleLastInspectRegister_T01Entity.CRUD;
            //    pDataParameters[1].Value = pFirstMiddleLastInspectRegister_T01Entity.DATE_FROM;
            //    pDataParameters[2].Value = pFirstMiddleLastInspectRegister_T01Entity.DATE_TO;
            //    pDataParameters[3].Value = pFirstMiddleLastInspectRegister_T01Entity.CONTRACT_ID;
            //    pDataParameters[4].Value = pFirstMiddleLastInspectRegister_T01Entity.PART_CODE;
            //    pDataParameters[5].Value = pFirstMiddleLastInspectRegister_T01Entity.PART_NAME;
            //    pDataParameters[6].Value = pFirstMiddleLastInspectRegister_T01Entity.USE_YN;
            //    pDataParameters[7].Value = pFirstMiddleLastInspectRegister_T01Entity.LANGUAGE_TYPE;

            //    DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProductPlanRegister_R10", pDataParameters);
            //    return pDataTable;
            //}
            //catch (ExceptionManager pExceptionManager)
            //{
            //    throw pExceptionManager;
            //}
            //catch (Exception pException)
            //{
            //    throw new ExceptionManager
            //    (
            //        this,
            //        "Sample_Check_Next_Process(FirstMiddleLastInspectRegister_T01Entity pFirstMiddleLastInspectRegister_T01Entity)",
            //        pException
            //    );
            //}
        }

        #endregion

    }

    public class FirstMiddleLastInspectRegister_T02Provider : EntityManager<FirstMiddleLastInspectRegister_T02Entity>
    {
        #region 생성자 - FirstMiddleLastInspectRegister_T02Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public FirstMiddleLastInspectRegister_T02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)
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
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_firstmiddlelast_gubn", MySqlDbType.VarChar, 50)

                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_firstmiddlelast_gubn", SqlDbType.VarChar, 50)

                         };
                        break;
                }

                pDataParameters[0].Value = pFirstMiddleLastInspectRegister_T02Entity.CRUD;
                pDataParameters[1].Value = pFirstMiddleLastInspectRegister_T02Entity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pFirstMiddleLastInspectRegister_T02Entity.PRODUCTION_ORDER_ID;
                pDataParameters[3].Value = pFirstMiddleLastInspectRegister_T02Entity.FIRSTMIDDLELAST_GUBN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FirstMiddleLastInspectRegister_T02_R10", pDataParameters);

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
                    "FirstMiddleLastInspectRegister_T02_Info_Mst(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity, DataTable pDataTable)
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
                            new MySqlParameter("@v_firstmiddlelast_gubn", MySqlDbType.VarChar, 50),                            
                            new MySqlParameter("@v_check_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_check_result", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_firstmiddlelast_gubn", SqlDbType.VarChar, 50),                            
                            new SqlParameter("@v_check_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_check_result", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {

                    pDataParametersA[0].Value = "";
                    pDataParametersA[1].Value = pFirstMiddleLastInspectRegister_T02Entity.USER_CODE;
                    pDataParametersA[2].Value = pDataTable.Rows[i]["production_order_id"].ToString();
                    pDataParametersA[3].Value = pDataTable.Rows[i]["firstmiddlelast_gubn"].ToString();
                    //pDataParametersA[4].Value = pDataTable.Rows[i]["check_cycle"].ToString();
                    pDataParametersA[4].Value = pDataTable.Rows[i]["check_code"].ToString();
                    pDataParametersA[5].Value = pDataTable.Rows[i]["check_result"].ToString();

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FirstMiddleLastInspectRegister_T02_I10", pDataParametersA);
                    if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    else
                    {
                        pFirstMiddleLastInspectRegister_T02Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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

        #region 파일명 조회하기 - FirstMiddleLastInspectRegister_T02_Info_Filename(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pFirstMiddleLastInspectRegister_T02Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable FirstMiddleLastInspectRegister_T02_Info_Filename(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)
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

                pDataParameters[0].Value = pFirstMiddleLastInspectRegister_T02Entity.WINDOW_NAME;
                pDataParameters[1].Value = pFirstMiddleLastInspectRegister_T02Entity.LANGUAGE_TYPE;

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
                    "FirstMiddleLastInspectRegister_T02_Info_Filename(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)",
                    pException
                );
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMenuRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public object Templete_Download(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity, string pMENU_NO, string pDSP_SORT)
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
                pDataParameters[3].Value = pFirstMiddleLastInspectRegister_T02Entity.LANGUAGE_TYPE;


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
        public override FirstMiddleLastInspectRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity = new FirstMiddleLastInspectRegister_T02Entity();

                pFirstMiddleLastInspectRegister_T02Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pFirstMiddleLastInspectRegister_T02Entity;
            }
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


    public class ucProductionOrderInfoPopup_T08Provider : EntityManager<ucProductionOrderInfoPopup_T08_Entity>
    {
        #region 생성자 - ucProductionOrderInfoPopup_T08Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucProductionOrderInfoPopup_T08Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기

        public override ucProductionOrderInfoPopup_T08_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucProductionOrderInfoPopup_T08_Entity pucProductionOrderInfoPopup_T08_Entity = new ucProductionOrderInfoPopup_T08_Entity();
                pucProductionOrderInfoPopup_T08_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucProductionOrderInfoPopup_T08_Entity;
            }
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

        public DataSet pucProductionOrderInfoPopup_T08_Return(ucProductionOrderInfoPopup_T08_Entity pucProductionOrderInfoPopup_T08_Entity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50)
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
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pucProductionOrderInfoPopup_T08_Entity.CRUD;
                pDataParameters[1].Value = pucProductionOrderInfoPopup_T08_Entity.DATE_FROM;
                pDataParameters[2].Value = pucProductionOrderInfoPopup_T08_Entity.DATE_TO;
                pDataParameters[3].Value = pucProductionOrderInfoPopup_T08_Entity.PART_CODE;
                pDataParameters[4].Value = pucProductionOrderInfoPopup_T08_Entity.PART_NAME;
                pDataParameters[5].Value = pucProductionOrderInfoPopup_T08_Entity.PLAN_ORDER_ID;
                pDataParameters[6].Value = pucProductionOrderInfoPopup_T08_Entity.LANGUAGE_TYPE;
                pDataParameters[7].Value = pucProductionOrderInfoPopup_T08_Entity.TERMINAL_CODE;
                pDataParameters[8].Value = pucProductionOrderInfoPopup_T08_Entity.PROCESS_CODE;


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucProductionOrderInfoPopup_T08_R10", pDataParameters);
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


    public class QualityAnalsisProvider : EntityManager<QualityAnalsisEntity>
    {
        #region 생성자 - EquipmentCheckProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public QualityAnalsisProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터  조회하기 - EquipmentHistory_Mst(QualityAnalsiEntity pQualityAnalsiEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>

        public DataTable QualityAnalsis_Mst(QualityAnalsisEntity pQualityAnalsisEntity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.DateTime),
                            new MySqlParameter("@v_date_to", MySqlDbType.DateTime),
                            new MySqlParameter("@v_equipment", MySqlDbType.VarChar, 50)
                            //new MySqlParameter("@v_check_list", MySqlDbType.VarChar, 50)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_terminal_name", SqlDbType.NVarChar, 50)
                            //new SqlParameter("@v_check_list", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pQualityAnalsisEntity.CRUD;
                pDataParameters[1].Value = pQualityAnalsisEntity.DATE_FROM;
                pDataParameters[2].Value = pQualityAnalsisEntity.DATE_TO;
                pDataParameters[3].Value = pQualityAnalsisEntity.TERMINAL_NAME;
                //pDataParameters[4].Value = pQualityAnalsisEntity.CHECK_LIST;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_QualityAnalysis_R10", pDataParameters);

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
        public override QualityAnalsisEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                QualityAnalsisEntity pQualityAnalsisEntity = new QualityAnalsisEntity();

                //pListofManagementEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pQualityAnalsisEntity;
            }
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

    public class MaterialInspectRegister_T02Provider : EntityManager<MaterialInspectRegister_T02Entity>
    {
        #region 생성자 - MaterialInspectRegister_T02Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MaterialInspectRegister_T02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMaterialInspectRegister_T02Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)
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

                pDataParameters[0].Value = pMaterialInspectRegister_T02Entity.CRUD;
                pDataParameters[1].Value = pMaterialInspectRegister_T02Entity.WINDOW_NAME;
                pDataParameters[2].Value = pMaterialInspectRegister_T02Entity.LANGUAGE_TYPE;

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

        #region 마스터 조회하기 - Sample_Info_Mst(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)
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
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pMaterialInspectRegister_T02Entity.CRUD;
                pDataParameters[1].Value = pMaterialInspectRegister_T02Entity.DATE_FROM;
                pDataParameters[2].Value = pMaterialInspectRegister_T02Entity.DATE_TO;
                pDataParameters[3].Value = pMaterialInspectRegister_T02Entity.PART_CODE;
                pDataParameters[4].Value = pMaterialInspectRegister_T02Entity.PART_NAME;
                pDataParameters[5].Value = pMaterialInspectRegister_T02Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialInspectRegister_T02_R10", pDataParameters);

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
                    "Sample_Info_Mst(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)",
                    pException
                );
            }

        }

        public DataSet MaterialInspectRegister_T02_info_ExcelBinding(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)
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

                pDataParameters[0].Value = pMaterialInspectRegister_T02Entity.INSPECT_ID;
                pDataParameters[1].Value = pMaterialInspectRegister_T02Entity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_MaterialInspectRegister_T02_R20", pDataParameters);

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
                    "Sample_Info_Mst(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)",
                    pException
                );
            }

        }
        #endregion

        #region 정보 저장하기 - MaterialInspectRegister_T02_Info_Mst_Save(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MaterialInspectRegister_T02_Info_Mst_Save(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_value1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_value2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_value3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_inspect_user", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_value1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_value2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_value3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_user", SqlDbType.NVarChar, 50),
                        };
                        break;
                }

                pDataParametersA[0].Value = pMaterialInspectRegister_T02Entity.CRUD;
                pDataParametersA[1].Value = pMaterialInspectRegister_T02Entity.USER_CODE;
                pDataParametersA[2].Value = pMaterialInspectRegister_T02Entity.INSPECT_ID;
                pDataParametersA[3].Value = sheet_1.GetCellValue(14, 3).ToString();
                pDataParametersA[4].Value = sheet_1.GetCellValue(17, 3).ToString();
                pDataParametersA[5].Value = sheet_1.GetCellValue(20, 3).ToString();
                pDataParametersA[6].Value = sheet_1.GetCellValue(16, 7).ToString();
                
                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialInspectRegister_T02_I10", pDataParametersA);

                pMaterialInspectRegister_T02Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pMaterialInspectRegister_T02Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pMaterialInspectRegister_T02Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pMaterialInspectRegister_T02Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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

        #region 정보 저장하기 - MaterialInspectRegister_T02_Info_Detail_Save(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MaterialInspectRegister_T02_Info_Detail_Save(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                
                int rowcnt = pMaterialInspectRegister_T02Entity.dtListCnt;

                for (int i = 0; i < 9; i++)
                {
                    if (rowcnt < 9)
                    {
                        rowcnt++;
                    }
                }
                
                for (int i = 0; i < rowcnt+4; i++)
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
                                new MySqlParameter("@v_inspect_decision1", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_inspect_decision2", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_inspect_decision3", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_inspect_decision4", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_inspect_decision5", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_inspect_decision6", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_inspect_user", MySqlDbType.VarChar,50),
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
                                new SqlParameter("@v_inspect_decision1", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_inspect_decision2", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_inspect_decision3", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_inspect_decision4", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_inspect_decision5", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_inspect_decision6", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_inspect_user", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pMaterialInspectRegister_T02Entity.CRUD;
                    pDataParametersA[1].Value = pMaterialInspectRegister_T02Entity.USER_CODE;
                    pDataParametersA[2].Value = pMaterialInspectRegister_T02Entity.INSPECT_ID;
                    pDataParametersA[3].Value = sheet_1.GetCellValue(0, i + 1).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(3, i + 1).ToString();
                    pDataParametersA[5].Value = pMaterialInspectRegister_T02Entity.INSPECT__DATE;
                    pDataParametersA[6].Value = sheet_1.GetCellValue(4, i + 1).ToString(); 
                    pDataParametersA[7].Value = sheet_1.GetCellValue(5, i + 1).ToString();
                    pDataParametersA[8].Value = sheet_1.GetCellValue(6, i + 1).ToString();
                    pDataParametersA[9].Value = sheet_1.GetCellValue(7, i + 1).ToString();
                    pDataParametersA[10].Value = sheet_1.GetCellValue(8, i + 1).ToString();
                    pDataParametersA[11].Value = sheet_1.GetCellValue(9, i + 1).ToString();
                    pDataParametersA[12].Value = sheet_1.GetCellValue(10, i + 1).ToString();
                    pDataParametersA[13].Value = sheet_1.GetCellValue(12, i + 1).ToString();

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialInspectRegister_T02_I20", pDataParametersA);

                    pMaterialInspectRegister_T02Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pMaterialInspectRegister_T02Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pMaterialInspectRegister_T02Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pMaterialInspectRegister_T02Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override MaterialInspectRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity = new MaterialInspectRegister_T02Entity();

                pMaterialInspectRegister_T02Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pMaterialInspectRegister_T02Entity;
            }
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


    public class MaterialInspectRegister_T03Provider : EntityManager<MaterialInspectRegister_T03Entity>
    {
        #region 생성자 - MaterialInspectRegister_T03Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MaterialInspectRegister_T03Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pMaterialInspectRegister_T03Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)
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

                pDataParameters[0].Value = pMaterialInspectRegister_T03Entity.CRUD;
                pDataParameters[1].Value = pMaterialInspectRegister_T03Entity.WINDOW_NAME;
                pDataParameters[2].Value = pMaterialInspectRegister_T03Entity.LANGUAGE_TYPE;

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

        #region 마스터 조회하기 - Sample_Info_Mst(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)
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
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pMaterialInspectRegister_T03Entity.CRUD;
                pDataParameters[1].Value = pMaterialInspectRegister_T03Entity.DATE_FROM;
                pDataParameters[2].Value = pMaterialInspectRegister_T03Entity.DATE_TO;
                pDataParameters[3].Value = pMaterialInspectRegister_T03Entity.PART_CODE;
                pDataParameters[4].Value = pMaterialInspectRegister_T03Entity.PART_NAME;
                pDataParameters[5].Value = pMaterialInspectRegister_T03Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialInspectRegister_T03_R10", pDataParameters);

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
                    "Sample_Info_Mst(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)",
                    pException
                );
            }

        }

        public DataSet MaterialInspectRegister_T03_info_ExcelBinding(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)
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

                pDataParameters[0].Value = pMaterialInspectRegister_T03Entity.INSPECT_ID;
                pDataParameters[1].Value = pMaterialInspectRegister_T03Entity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_MaterialInspectRegister_T03_R20", pDataParameters);

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
                    "Sample_Info_Mst(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)",
                    pException
                );
            }

        }
        #endregion

        #region 정보 저장하기 - MaterialInspectRegister_T03_Info_Mst_Save(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MaterialInspectRegister_T03_Info_Mst_Save(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity, Worksheet sheet_1)
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
                                new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_value1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_value2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_value3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_inspect_user", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_value1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_value2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_value3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_user", SqlDbType.NVarChar, 50),
                        };
                        break;
                }

                pDataParametersA[0].Value = pMaterialInspectRegister_T03Entity.CRUD;
                pDataParametersA[1].Value = pMaterialInspectRegister_T03Entity.USER_CODE;
                pDataParametersA[2].Value = pMaterialInspectRegister_T03Entity.INSPECT_ID;
                pDataParametersA[3].Value = sheet_1.GetCellValue(14, 3).ToString();
                pDataParametersA[4].Value = sheet_1.GetCellValue(17, 3).ToString();
                pDataParametersA[5].Value = sheet_1.GetCellValue(20, 3).ToString();
                pDataParametersA[6].Value = sheet_1.GetCellValue(16, 7).ToString();

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialInspectRegister_T03_I10", pDataParametersA);

                pMaterialInspectRegister_T03Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pMaterialInspectRegister_T03Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pMaterialInspectRegister_T03Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pMaterialInspectRegister_T03Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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

        #region 정보 저장하기 - MaterialInspectRegister_T03_Info_Detail_Save(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool MaterialInspectRegister_T03_Info_Detail_Save(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                int rowcnt = pMaterialInspectRegister_T03Entity.dtListCnt;
                for (int i = 0; i < rowcnt + 4; i++)
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
                                
                                new MySqlParameter("@v_vend_code", MySqlDbType.VarChar,8),
                                new MySqlParameter("@v_in_qty", MySqlDbType.Decimal),
                                new MySqlParameter("@v_inspect_date", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_inspect_part_clean", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_inspect_part_status", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_inspect_part_yn", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_inspect_decision", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_inspect_user", MySqlDbType.VarChar,1000),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000)

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),

                                new SqlParameter("@v_inspect_code", SqlDbType.NVarChar, 8),
                                
                                new SqlParameter("@v_vend_code", SqlDbType.NVarChar,8),
                                new SqlParameter("@v_in_qty", SqlDbType.Decimal),
                                new SqlParameter("@v_inspect_date", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_inspect_part_clean", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_inspect_part_status", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_inspect_part_yn", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_inspect_decision", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_inspect_user", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000)

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pMaterialInspectRegister_T03Entity.CRUD;
                    pDataParametersA[1].Value = pMaterialInspectRegister_T03Entity.USER_CODE;
                    pDataParametersA[2].Value = pMaterialInspectRegister_T03Entity.INSPECT_ID;

                    pDataParametersA[3].Value = sheet_1.GetCellValue(0, i + 1).ToString();

                    pDataParametersA[4].Value = sheet_1.GetCellValue(1, i + 1).ToString();

                    string check = sheet_1.GetCellValue(2, i + 1).ToString();

                    if (check == null || check == "")
                    {
                        pDataParametersA[5].Value = 0.00;
                    }
                    else
                    {
                        pDataParametersA[5].Value = Convert.ToInt32(sheet_1.GetCellValue(2, i + 1).ToString());
                    }
                    
                    pDataParametersA[6].Value = sheet_1.GetCellValue(3, i + 1).ToString();
                    pDataParametersA[7].Value = sheet_1.GetCellValue(4, i + 1).ToString();
                    pDataParametersA[8].Value = sheet_1.GetCellValue(5, i + 1).ToString();
                    pDataParametersA[9].Value = sheet_1.GetCellValue(6, i + 1).ToString();
                    pDataParametersA[10].Value = sheet_1.GetCellValue(7, i + 1).ToString();
                    pDataParametersA[11].Value = sheet_1.GetCellValue(8, i + 1).ToString();
                    pDataParametersA[12].Value = sheet_1.GetCellValue(9, i + 1).ToString();

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MaterialInspectRegister_T03_I20", pDataParametersA);

                    pMaterialInspectRegister_T03Entity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pMaterialInspectRegister_T03Entity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pMaterialInspectRegister_T03Entity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pMaterialInspectRegister_T03Entity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override MaterialInspectRegister_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity = new MaterialInspectRegister_T03Entity();

                pMaterialInspectRegister_T03Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pMaterialInspectRegister_T03Entity;
            }
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

    public class FirstMiddleLastInspectStatusProvider : EntityManager<FirstMiddleLastInspectStatusEntity>
    {
        #region 생성자 - EquipmentCheckProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public FirstMiddleLastInspectStatusProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 및 대표 서식 파일 조회하기 - FirstMiddleLastInspectStatus_Mst(FirstMiddleLastInspectStatusEntity pFirstMiddleLastInspectStatusEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentCheckEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>

        public DataTable FirstMiddleLastInspectStatus_Mst(FirstMiddleLastInspectStatusEntity pFirstMiddleLastInspectStatusEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_production_order_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 20)

                         };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_production_order_id", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.VarChar, 20)

                         };
                        break;
                }
                pDataParameters[0].Value = pFirstMiddleLastInspectStatusEntity.CRUD;
                pDataParameters[1].Value = pFirstMiddleLastInspectStatusEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pFirstMiddleLastInspectStatusEntity.PRODUCTION_ORDER_ID;
                pDataParameters[3].Value = pFirstMiddleLastInspectStatusEntity.PART_CODE;
                

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_FirstMiddleLastInspectStatus_R20", pDataParameters);

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

        //#region 대표파일 조회하기 조회하기 - EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)

        ///// <summary>
        ///// 조회하기
        ///// </summary>
        ///// <param name="pEquipmentchangeEntity">엔티티 정보</param>
        ///// <returns>조회 목록</returns>

        //public DataTable EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)
        //{
        //    try
        //    {
        //        IDataParameter[] pDataParameters = null;

        //        switch (_pDBManager.DBManagerType.ToString())
        //        {
        //            case "MySql":
        //                pDataParameters = new IDataParameter[]
        //                {
        //                    new MySqlParameter("@v_sheetinfo_id", MySqlDbType.VarChar, 50),
        //                    new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


        //                };
        //                break;

        //            case "SQLServer":
        //                pDataParameters = new IDataParameter[]
        //                {
        //                    new SqlParameter("@v_sheetinfo_id", SqlDbType.NVarChar, 50),
        //                    new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
        //                };
        //                break;
        //        }

        //        pDataParameters[0].Value = pEquipmentCheckEntity.SHEETINFO_ID;
        //        pDataParameters[1].Value = pEquipmentCheckEntity.LANGUAGE_TYPE;


        //        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCheck_R20", pDataParameters);

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
        //            "EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)",
        //            pException
        //        );
        //    }
        //}

        //#endregion

        //#region 정보 저장하기 - EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="pEquipmentCheckEntity"></param>
        ///// <param name="dt"></param>
        ///// <returns></returns>
        //public bool EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)
        //{
        //    bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
        //    int pCount = 0;

        //    try
        //    {
        //        //마스터 저장
        //        IDataParameter[] pDataParametersA = null;

        //        switch (_pDBManager.DBManagerType.ToString())
        //        {
        //            case "MySql":
        //                pDataParametersA = new IDataParameter[]
        //                {
        //                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
        //                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
        //                        new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
        //                        new MySqlParameter("@v_sheetinfo_id", MySqlDbType.VarChar, 50),
        //                        new MySqlParameter("@v_dsp_seq", MySqlDbType.VarChar, 50),
        //                        new MySqlParameter("@v_file_name", MySqlDbType.VarChar, 100),
        //                        new MySqlParameter("@v_file_nickname", MySqlDbType.VarChar, 100)

        //                };
        //                break;

        //            case "SQLServer":
        //                pDataParametersA = new IDataParameter[]
        //                {
        //                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
        //                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
        //                        new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
        //                        new SqlParameter("@v_sheetinfo_id", SqlDbType.NVarChar, 50),
        //                        new SqlParameter("@v_dsp_seq", SqlDbType.NVarChar, 50),
        //                        new SqlParameter("@v_file_name", SqlDbType.NVarChar, 100),
        //                        new SqlParameter("@v_file_nickname", SqlDbType.NVarChar, 100)
        //                };
        //                break;
        //        }

        //        pDataParametersA[0].Value = pEquipmentCheckEntity.CRUD;
        //        pDataParametersA[1].Value = pEquipmentCheckEntity.USER_CODE;
        //        pDataParametersA[2].Value = pEquipmentCheckEntity.WINDOW_NAME;
        //        pDataParametersA[3].Value = pEquipmentCheckEntity.SHEETINFO_ID;
        //        pDataParametersA[4].Value = pEquipmentCheckEntity.DSP_SEQ;
        //        pDataParametersA[5].Value = pEquipmentCheckEntity.FILE_NAME;
        //        pDataParametersA[6].Value = pEquipmentCheckEntity.FILE_NICKNAME;

        //        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentCheck_I10", pDataParametersA);

        //        pEquipmentCheckEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
        //        pEquipmentCheckEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
        //        pEquipmentCheckEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
        //        pEquipmentCheckEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
        //        pEquipmentCheckEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

        //        if (pDataTableA.Rows[0][0].ToString() != "00")
        //        {
        //            pErrorYN = true;
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
        //            "UsingExcel_Save(UsingExcelEntity pUsingExcelEntity)",
        //            pException
        //        );
        //    }

        //    return pErrorYN;
        //}

        //#endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(SampleExcelBindingEntity pRawMaterialInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pRawMaterialInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(FirstMiddleLastInspectStatusEntity pFirstMiddleLastInspectStatusEntity)
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

                pDataParameters[0].Value = pFirstMiddleLastInspectStatusEntity.CRUD;
                pDataParameters[1].Value = pFirstMiddleLastInspectStatusEntity.WINDOW_NAME;
                pDataParameters[2].Value = pFirstMiddleLastInspectStatusEntity.LANGUAGE_TYPE;

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
        public override FirstMiddleLastInspectStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                FirstMiddleLastInspectStatusEntity pFirstMiddleLastInspectStatusEntity = new FirstMiddleLastInspectStatusEntity();

                //pListofManagementEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pFirstMiddleLastInspectStatusEntity;
            }
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

    public class GatheringEquationRegisterProvider : EntityManager<GatheringEquationRegisterEntity>
    {
        #region 생성자 - GatheringEquationRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public GatheringEquationRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity)
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

                pDataParameters[0].Value = pGatheringEquationRegisterEntity.CRUD;
                pDataParameters[1].Value = pGatheringEquationRegisterEntity.WINDOW_NAME;
                pDataParameters[2].Value = pGatheringEquationRegisterEntity.LANGUAGE_TYPE;

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

        #region 마스터 조회하기 - GatheringEquationRegister_Info_Mst(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable GatheringEquationRegister_Info_Mst(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar, 8),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pGatheringEquationRegisterEntity.CRUD;
                pDataParameters[1].Value = pGatheringEquationRegisterEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pGatheringEquationRegisterEntity.DATE_FROM;
                pDataParameters[3].Value = pGatheringEquationRegisterEntity.DATE_TO;
                pDataParameters[4].Value = pGatheringEquationRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GatheringEquationRegister_R10", pDataParameters);

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
                    "GatheringEquationRegister_Info_Mst(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity)",
                    pException
                );
            }

        }

        public DataSet GatheringEquationRegister_info_ExcelBinding(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity)
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
                            new MySqlParameter("@v_haccp_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20),

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_haccp_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20),

                        };
                        break;
                }

                pDataParameters[0].Value = pGatheringEquationRegisterEntity.RESOURCE_CODE;
                pDataParameters[1].Value = pGatheringEquationRegisterEntity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_GatheringEquationRegister_R20", pDataParameters);

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
                    "Sample_Info_Mst(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity)",
                    pException
                );
            }

        }
        #endregion

        #region 마스터 정보 저장하기 - GatheringEquationRegister_Info_Detail_Save(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool GatheringEquationRegister_Info_Save(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity, Worksheet sheet_1)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;
                Range usedRange = sheet_1.GetUsedRange();

                for (int i = 0; i < usedRange.RowCount; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_resource_min_1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_max_1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_min_2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_max_2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_min_3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_max_3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_min_4", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_max_4", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_min_5", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_max_5", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20)

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_resource_min_1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_max_1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_min_2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_max_2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_min_3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_max_3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_min_4", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_max_4", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_min_5", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_max_5", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20)

                            };
                            break;
                    }

                    pDataParametersA[0].Value = sheet_1.GetCellValue(1, i + 2).ToString();
                    pDataParametersA[1].Value = sheet_1.GetCellValue(2, i + 2).ToString();
                    pDataParametersA[2].Value = sheet_1.GetCellValue(3, i + 2).ToString();
                    pDataParametersA[3].Value = sheet_1.GetCellValue(4, i + 2).ToString();
                    pDataParametersA[4].Value = sheet_1.GetCellValue(5, i + 2).ToString();
                    pDataParametersA[5].Value = sheet_1.GetCellValue(6, i + 2).ToString();
                    pDataParametersA[6].Value = sheet_1.GetCellValue(7, i + 2).ToString();
                    pDataParametersA[7].Value = sheet_1.GetCellValue(8, i + 2).ToString();
                    pDataParametersA[8].Value = sheet_1.GetCellValue(9, i + 2).ToString();
                    pDataParametersA[9].Value = sheet_1.GetCellValue(10, i + 2).ToString();
                    pDataParametersA[10].Value = sheet_1.GetCellValue(11, i + 2).ToString();
                    pDataParametersA[10].Value = sheet_1.GetCellValue(12, i + 2).ToString();
                    pDataParametersA[11].Value = pGatheringEquationRegisterEntity.USER_CODE;

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GatheringEquationRegister_I10", pDataParametersA);

                    pGatheringEquationRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pGatheringEquationRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pGatheringEquationRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pGatheringEquationRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
        public override GatheringEquationRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                GatheringEquationRegisterEntity pGatheringEquationRegisterEntity = new GatheringEquationRegisterEntity();

                pGatheringEquationRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pGatheringEquationRegisterEntity;
            }
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

    public class KPIDataRegisterProvider : EntityManager<KPIDataRegisterEntity>
    {
        #region 생성자 - KPIDataRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public KPIDataRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pKPIDataRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Excel_Json_Mst_Info(KPIDataRegisterEntity pKPIDataRegisterEntity)
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
                            new MySqlParameter("@v_date_from", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_date_to", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_lot_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_trs_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_fps_trs_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_lot_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_trs_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_fps_trs_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pKPIDataRegisterEntity.CRUD;
                pDataParameters[1].Value = pKPIDataRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pKPIDataRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pKPIDataRegisterEntity.PART_NAME;
                pDataParameters[4].Value = pKPIDataRegisterEntity.LOT_NO;
                pDataParameters[5].Value = pKPIDataRegisterEntity.TRS_NO;
                pDataParameters[6].Value = pKPIDataRegisterEntity.FPS_TRS_NO;
                pDataParameters[7].Value = pKPIDataRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_KPIDataRegister_R10", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Excel_Json_Mst_Info(KPIDataRegisterEntity pKPIDataRegisterEntity)",
                    pException
                );
            }

        }

        #endregion

        #region 마스터 디테일 조회

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pKPIDataRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Excel_Json_Mst_Sub_Info(KPIDataRegisterEntity pKPIDataRegisterEntity)
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
                            new MySqlParameter("@v_seq", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_seq", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pKPIDataRegisterEntity.CRUD;
                pDataParameters[1].Value = pKPIDataRegisterEntity.SEQ;
                pDataParameters[2].Value = pKPIDataRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_KPIDataRegister_R11", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Excel_Json_Mst_Sub_Info(KPIDataRegisterEntity pKPIDataRegisterEntity)",
                    pException
                );
            }

        }

        #endregion

        #region 디테일 조회

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pKPIDataRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Excel_Json_Sub_Info(KPIDataRegisterEntity pKPIDataRegisterEntity)
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
                            new MySqlParameter("@v_seq", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_json_col", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_seq", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_json_col",SqlDbType.NVarChar,50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pKPIDataRegisterEntity.CRUD;
                pDataParameters[1].Value = pKPIDataRegisterEntity.SEQ;
                pDataParameters[2].Value = pKPIDataRegisterEntity.JSONCOL;
                pDataParameters[3].Value = pKPIDataRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_KPIDataRegister_R12", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Excel_Json_Sub_Info(KPIDataRegisterEntity pKPIDataRegisterEntity)",
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
        public override KPIDataRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                KPIDataRegisterEntity pKPIDataRegisterEntity = new KPIDataRegisterEntity();

                pKPIDataRegisterEntity.CORP_CODE = pDataRow["seq"] is DBNull ? string.Empty : pDataRow["seq"] as string;  // 회사코드

                return pKPIDataRegisterEntity;
            }
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

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(KPIDataRegisterEntity pKPIDataRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pKPIDataRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(KPIDataRegisterEntity pKPIDataRegisterEntity)
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

                pDataParameters[0].Value = pKPIDataRegisterEntity.CRUD;
                pDataParameters[1].Value = pKPIDataRegisterEntity.WINDOW_NAME;
                pDataParameters[2].Value = pKPIDataRegisterEntity.LANGUAGE_TYPE;

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
                    "Sheet_Info_sheet(KPIDataRegisterEntity pKPIDataRegisterEntity)",
                    pException
                );
            }
        }

        #endregion
    }

    public class EquipmentInspectRegisterProvider : EntityManager<EquipmentInspectRegisterEntity>
    {
        #region 생성자 - EquipmentInspectRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public EquipmentInspectRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)
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

                pDataParameters[0].Value = pEquipmentInspectRegisterEntity.CRUD;
                pDataParameters[1].Value = pEquipmentInspectRegisterEntity.WINDOW_NAME;
                pDataParameters[2].Value = pEquipmentInspectRegisterEntity.LANGUAGE_TYPE;

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

        #region 마스터 조회하기 - Sample_Info_Mst(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)
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
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_equipment_name", MySqlDbType.VarChar, 50),
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
                            new SqlParameter("@v_equipment_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_equipment_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentInspectRegisterEntity.CRUD;
                pDataParameters[1].Value = pEquipmentInspectRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pEquipmentInspectRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pEquipmentInspectRegisterEntity.EQUIPMENT_CODE;
                pDataParameters[4].Value = pEquipmentInspectRegisterEntity.EQUIPMENT_NAME;
                pDataParameters[5].Value = pEquipmentInspectRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentInspectRegister_R10", pDataParameters);

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
                    "Sample_Info_Mst(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)",
                    pException
                );
            }

        }

        public DataSet EquipmentInspectRegister_info_ExcelBinding(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)
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

                pDataParameters[0].Value = pEquipmentInspectRegisterEntity.INSPECT_ID;
                pDataParameters[1].Value = pEquipmentInspectRegisterEntity.LANGUAGE_TYPE;


                DataSet pDataSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_EquipmentInspectRegister_R20", pDataParameters);

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
                    "Sample_Info_Mst(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)",
                    pException
                );
            }

        }
        #endregion

        #region 정보 저장하기 - EquipmentInspectRegister_Info_Mst_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, Worksheet sheet_1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool EquipmentInspectRegister_Info_Mst_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, Worksheet sheet_2)
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
                                new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_admin1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_admin2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_admin3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_frequency1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_frequency2", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_frequency3", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_frequency4", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_frequency5", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_frequency6", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_frequency7", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_frequency8", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_frequency9", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_frequency10", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_frequency11", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_frequency12", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_admin1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_admin2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_admin3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_frequency1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_frequency2", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_frequency3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_frequency4", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_frequency5", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_frequency6", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_frequency7", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_frequency8", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_frequency9", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_frequency10", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_frequency11", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_frequency12", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pEquipmentInspectRegisterEntity.CRUD;
                pDataParametersA[1].Value = pEquipmentInspectRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = sheet_2.GetCellValue(0, 4).ToString();
                pDataParametersA[3].Value = sheet_2.GetCellValue(0, 1).ToString();
                pDataParametersA[4].Value = sheet_2.GetCellValue(1, 1).ToString();
                pDataParametersA[5].Value = sheet_2.GetCellValue(2, 1).ToString();
                pDataParametersA[6].Value = sheet_2.GetCellValue(3, 1).ToString();
                pDataParametersA[7].Value = sheet_2.GetCellValue(4, 1).ToString();
                pDataParametersA[8].Value = sheet_2.GetCellValue(5, 1).ToString();
                pDataParametersA[9].Value = sheet_2.GetCellValue(6, 1).ToString();
                pDataParametersA[10].Value = sheet_2.GetCellValue(7, 1).ToString();
                pDataParametersA[11].Value = sheet_2.GetCellValue(8, 1).ToString();
                pDataParametersA[12].Value = sheet_2.GetCellValue(9, 1).ToString();
                pDataParametersA[13].Value = sheet_2.GetCellValue(10, 1).ToString();
                pDataParametersA[14].Value = sheet_2.GetCellValue(11, 1).ToString();
                pDataParametersA[15].Value = sheet_2.GetCellValue(12, 1).ToString();
                pDataParametersA[16].Value = sheet_2.GetCellValue(13, 1).ToString();
                pDataParametersA[17].Value = sheet_2.GetCellValue(14, 1).ToString();

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentInspectRegister_I10", pDataParametersA);

                pEquipmentInspectRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pEquipmentInspectRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pEquipmentInspectRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pEquipmentInspectRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "EquipmentInspectRegister_Info_Mst_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, Worksheet sheet_2)",
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

        #region 상세 정보 저장하기 - EquipmentInspectRegister_Info_Detail_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, Worksheet sheet_2)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool EquipmentInspectRegister_Info_Detail_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, Worksheet sheet_2)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            _pDBManager.BeginTransaction();
            try
            {
                //마스터 저장
                IDataParameter[] pDataParametersA = null;

                int rowcnt = pEquipmentInspectRegisterEntity.dtListCnt;

                for (int i = 0; i < 9; i++)
                {
                    if (rowcnt < 9)
                    {
                        rowcnt++;
                    }
                }

                for (int i = 0; i < rowcnt + 4; i++)
                {
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_inspect_day", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_inspect_result1", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_inspect_result2", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_result3", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_result4", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_result5", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_result6", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_result7", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_result8", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_result9", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_result10", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_result11", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_result12", MySqlDbType.VarChar,50)
                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_day", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_inspect_result1", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_result2", SqlDbType.NVarChar,50),
                                new SqlParameter("@v_inspect_result3", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_result4", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_result5", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_result6", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_result7", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_result8", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_result9", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_result10", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_result11", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_result12", SqlDbType.NVarChar, 50)
                            };
                            break;
                    }

                    pDataParametersA[0].Value = pEquipmentInspectRegisterEntity.CRUD;
                    pDataParametersA[1].Value = pEquipmentInspectRegisterEntity.USER_CODE;
                    pDataParametersA[2].Value = sheet_2.GetCellValue(0, i + 3).ToString();
                    pDataParametersA[3].Value = sheet_2.GetCellValue(1, i + 3).ToString();
                    pDataParametersA[4].Value = sheet_2.GetCellValue(2, i + 3).ToString();
                    pDataParametersA[5].Value = sheet_2.GetCellValue(3, i + 3).ToString();
                    pDataParametersA[6].Value = sheet_2.GetCellValue(4, i + 3).ToString();
                    pDataParametersA[7].Value = sheet_2.GetCellValue(5, i + 3).ToString();
                    pDataParametersA[8].Value = sheet_2.GetCellValue(6, i + 3).ToString();
                    pDataParametersA[9].Value = sheet_2.GetCellValue(7, i + 3).ToString();
                    pDataParametersA[10].Value = sheet_2.GetCellValue(8, i + 3).ToString();
                    pDataParametersA[11].Value = sheet_2.GetCellValue(9, i + 3).ToString();
                    pDataParametersA[12].Value = sheet_2.GetCellValue(10, i + 3).ToString();
                    pDataParametersA[13].Value = sheet_2.GetCellValue(12, i + 3).ToString();
                    pDataParametersA[14].Value = sheet_2.GetCellValue(13, i + 3).ToString();
                    pDataParametersA[15].Value = sheet_2.GetCellValue(14, i + 3).ToString();

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentInspectRegister_I20", pDataParametersA);

                    pEquipmentInspectRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                    pEquipmentInspectRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                    pEquipmentInspectRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                    pEquipmentInspectRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "EquipmentInspectRegister_Info_Detail_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, Worksheet sheet_1)",
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

        #region 센서 정보 저장하기 - EquipmentInspect_Info_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool EquipmentInspect_Info_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, DataTable dt)
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
                        IDataParameter[] pDataParametersB = null;

                        switch (_pDBManager.DBManagerType.ToString())
                        {
                            case "MySql":
                                pDataParametersB = new IDataParameter[]
                                {
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_inspect_id", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_inspect_date", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_inspect_status", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParametersB = new IDataParameter[]
                                {
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_inspect_id", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_inspect_date", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_inspect_status", SqlDbType.NVarChar, 1)
                                };
                                break;

                        }
                        pDataParametersB[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParametersB[1].Value = pEquipmentInspectRegisterEntity.USER_CODE;
                        pDataParametersB[2].Value = dt.Rows[a]["INSPECT_ID"].ToString().ToUpper(); ;
                        pDataParametersB[3].Value = dt.Rows[a]["INSPECT_DATE"].ToString().ToUpper();
                        pDataParametersB[4].Value = dt.Rows[a]["INSPECT_STATUS"].ToString().ToUpper();

                        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentInspectRegister_I30", pDataParametersB);

                        if (pDataTableB.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pEquipmentInspectRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                        pEquipmentInspectRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                        pEquipmentInspectRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                        pEquipmentInspectRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                        pEquipmentInspectRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();

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
                    "EquipmentInspect_Info_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)",
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
        public override EquipmentInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity = new EquipmentInspectRegisterEntity();

                pEquipmentInspectRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pEquipmentInspectRegisterEntity;
            }
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
