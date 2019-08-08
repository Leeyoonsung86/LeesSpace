using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

using CoFAS_MES.UI.IM.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;

using DevExpress.Spreadsheet;

namespace CoFAS_MES.UI.IM.Data
{
    public class PartMstDownLoadProvider : EntityManager<PartMstDownLoadEntity>
    {
        #region ○ 생성자

        public PartMstDownLoadProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        public override PartMstDownLoadEntity GetEntity(DataRow pDataRow)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ○ 출하지시정보 조회

        public DataTable PartMstDownLoad_Info_Mst(PartMstDownLoadEntity pPartMstDownLoadEntity)
        {

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

                pDataParameters[0].Value = pPartMstDownLoadEntity.CRUD;
                pDataParameters[1].Value = pPartMstDownLoadEntity.DATE_FROM;
                pDataParameters[2].Value = pPartMstDownLoadEntity.DATE_TO;
                pDataParameters[3].Value = pPartMstDownLoadEntity.PART_CODE;
                pDataParameters[4].Value = pPartMstDownLoadEntity.PART_NAME;
                pDataParameters[5].Value = pPartMstDownLoadEntity.VEND_CODE;
                pDataParameters[6].Value = pPartMstDownLoadEntity.VEND_NAME;
                pDataParameters[7].Value = pPartMstDownLoadEntity.USE_YN;
                pDataParameters[8].Value = pPartMstDownLoadEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_PartMstDownLoad_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "PartMstDownLoad_Info_Mst(PartMstDownLoadEntity pPartMstDownLoadEntity)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 출하지시정보 저장

        public bool PartMstDownLoad_Info_Save(PartMstDownLoadEntity pPartMstDownLoadEntity)
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
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_part_size", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_product_type", MySqlDbType.VarChar, 50),
                                };
                                break;

                            case "SQLServer":
                                pDataParametersA = new IDataParameter[]
                                {
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_shipment_id", SqlDbType.VarChar, 15),
                                new SqlParameter("@v_shipment_date", SqlDbType.VarChar, 8),
                                };
                                break;
                        }

                        pDataParametersA[0].Value = pPartMstDownLoadEntity.USER_CODE;
                        pDataParametersA[1].Value = pPartMstDownLoadEntity.PART_CODE;   // dtSave.Rows[a]["ITMNO"].ToString(); // PART_CODE
                        pDataParametersA[2].Value = pPartMstDownLoadEntity.PART_NAME;   // dtSave.Rows[a]["INM"].ToString(); //PART_NAME
                        pDataParametersA[3].Value = pPartMstDownLoadEntity.PART_SIZE;   //dtSave.Rows[a]["ISIZE"].ToString();
                        pDataParametersA[4].Value = pPartMstDownLoadEntity.PRODUCT_TYPE;    //dtSave.Rows[a]["PRDTYPE"].ToString();

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_PartMstDownLoad_I10", pDataParametersA);

                        if (pDataTableA.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        if (pDataTableA.Rows[0][4].ToString() == "dup")
                        {
                            //MessageBox.Show("이미 등록된 품목입니다.");
                            pErrorYN = true;
                        }
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;

                throw pExceptionManager;
            }
            return pErrorYN;
        }

        #endregion
    }
    public class VendorInformationProvider : EntityManager<VendorInformationEntity>
    {
        #region 생성자 - VendorInformationProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public VendorInformationProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Vend_Info_Mst(VendorInformationEntity pVendorInformationEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pVendorInformationEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Vend_Info_Mst(VendorInformationEntity pVendorInformationEntity)
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
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_vend_type", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_vend_name", SqlDbType.VarChar, 100),
                            new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_vend_type", MySqlDbType.VarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)

                        };
                        break;

                }

                pDataParameters[0].Value = pVendorInformationEntity.CRUD;
                pDataParameters[1].Value = pVendorInformationEntity.VEND_CODE;
                pDataParameters[2].Value = pVendorInformationEntity.VEND_NAME;
                pDataParameters[3].Value = pVendorInformationEntity.T_VEND_EIN;
                pDataParameters[4].Value = pVendorInformationEntity.T_VEND_TYPE;
                pDataParameters[5].Value = pVendorInformationEntity.USE_YN;
                pDataParameters[6].Value = pVendorInformationEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_R10", pDataParameters);

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
                    "Vend_Info_Mst(VendorInformationEntity pVendorInformationEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 상세 조회하기 - Vend_Info_Sub(VendorInformationEntity pVendorInformationEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Vend_Info_Sub(VendorInformationEntity pVendorInformationEntity)
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
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pVendorInformationEntity.CRUD;
                pDataParameters[1].Value = pVendorInformationEntity.VEND_CODE;
                pDataParameters[2].Value = pVendorInformationEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_R20", pDataParameters);

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
                    "Vend_Info_Sub(VendorInformationEntity pVendorInformationEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 거래처(사업자번호) 체크 - Vend_Info_Chk(VendorInformationEntity pVendorInformationEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pVendorInformationEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Vend_Info_Chk(VendorInformationEntity pVendorInformationEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 100),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pVendorInformationEntity.VEND_EIN;
                pDataParameters[1].Value = pVendorInformationEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_R11", pDataParameters);

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
                    "Vend_Info_Mst(VendorInformationEntity pVendorInformationEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Vend_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Vend_Info_Save(VendorInformationEntity pVendorInformationEntity, DataTable dt)
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

                                new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_vend_type", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_vend_eng_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_vend_ssn", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_vend_ceo_name", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_vend_business_opendate", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_vend_tel", MySqlDbType.VarChar, 14),
                                new MySqlParameter("@v_vend_fax", MySqlDbType.VarChar, 14),
                                new MySqlParameter("@v_vend_mail", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_vend_address_1", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_vend_address_2", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_vend_business", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_vend_business_type", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_vend_filename", MySqlDbType.VarChar, 100),

                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 100)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),

                                new SqlParameter("@v_vend_code",        SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_vend_type",        SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_vend_name",        SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_eng_name",    SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_ein",         SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_vend_ssn",         SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_vend_ceo_name",    SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_vend_business_opendate", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_vend_tel",         SqlDbType.NVarChar, 14),
                                new SqlParameter("@v_vend_fax",         SqlDbType.NVarChar, 14),
                                new SqlParameter("@v_vend_mail",        SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_address_1",   SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_vend_address_2",   SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_vend_business",    SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_vend_business_type", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_vend_filename",    SqlDbType.NVarChar, 100),

                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 100)

                        };
                        break;

                }

                pDataParametersA[0].Value = pVendorInformationEntity.CRUD;
                pDataParametersA[1].Value = pVendorInformationEntity.USER_CODE;
                pDataParametersA[2].Value = pVendorInformationEntity.VEND_CODE;
                pDataParametersA[3].Value = pVendorInformationEntity.VEND_TYPE;
                pDataParametersA[4].Value = pVendorInformationEntity.VEND_NAME;
                pDataParametersA[5].Value = pVendorInformationEntity.VEND_ENG_NAME;
                pDataParametersA[6].Value = pVendorInformationEntity.VEND_EIN;
                pDataParametersA[7].Value = pVendorInformationEntity.VEND_SSN;
                pDataParametersA[8].Value = pVendorInformationEntity.VEND_CEO_NAME;
                pDataParametersA[9].Value = pVendorInformationEntity.VEND_BUSINESS_OPENDATE;
                pDataParametersA[10].Value = pVendorInformationEntity.VEND_TEL;
                pDataParametersA[11].Value = pVendorInformationEntity.VEND_FAX;
                pDataParametersA[12].Value = pVendorInformationEntity.VEND_MAIL;
                pDataParametersA[13].Value = pVendorInformationEntity.VEND_ADDRESS_1;
                pDataParametersA[14].Value = pVendorInformationEntity.VEND_ADDRESS_2;
                pDataParametersA[15].Value = pVendorInformationEntity.VEND_BUSINESS;
                pDataParametersA[16].Value = pVendorInformationEntity.VEND_BUSINESS_TYPE;
                pDataParametersA[17].Value = pVendorInformationEntity.VEND_FILENAME;
                pDataParametersA[18].Value = pVendorInformationEntity.USE_YN;
                pDataParametersA[19].Value = pVendorInformationEntity.REMARK;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_I10", pDataParametersA);

                pVendorInformationEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pVendorInformationEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pVendorInformationEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pVendorInformationEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pVendorInformationEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                                        new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                                        new MySqlParameter("@v_vend_seq", MySqlDbType.Int32, 11),
                                        new MySqlParameter("@v_vend_person_name", MySqlDbType.VarChar, 20),
                                        new MySqlParameter("@v_vend_mail", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_vend_tel", MySqlDbType.VarChar, 14),
                                        new MySqlParameter("@v_vend_fax", MySqlDbType.VarChar,14),
                                        new MySqlParameter("@v_vend_mobile", MySqlDbType.VarChar, 14),

                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),

                                        new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 10),
                                        new SqlParameter("@v_vend_seq", SqlDbType.Int, 11),
                                        new SqlParameter("@v_vend_person_name", SqlDbType.NVarChar, 20),
                                        new SqlParameter("@v_vend_mail", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_vend_tel", SqlDbType.NVarChar, 14),
                                        new SqlParameter("@v_vend_fax", SqlDbType.NVarChar,14),
                                        new SqlParameter("@v_vend_mobile", SqlDbType.NVarChar, 14),

                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;

                            }

                            pDataParametersB[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[1].Value = pVendorInformationEntity.USER_CODE;
                            pDataParametersB[2].Value = pVendorInformationEntity.RTN_KEY == "" ? pVendorInformationEntity.VEND_CODE : pVendorInformationEntity.RTN_KEY;
                            pDataParametersB[3].Value = dt.Rows[a]["VEND_SEQ"].ToString() == "" ? "0" : dt.Rows[a]["VEND_SEQ"].ToString();
                            pDataParametersB[4].Value = dt.Rows[a]["VEND_PERSON_NAME"].ToString();
                            pDataParametersB[5].Value = dt.Rows[a]["VEND_MAIL"].ToString();
                            pDataParametersB[6].Value = dt.Rows[a]["VEND_TELL"].ToString();
                            pDataParametersB[7].Value = dt.Rows[a]["VEND_FAX"].ToString();
                            pDataParametersB[8].Value = dt.Rows[a]["VEND_MOBILE"].ToString();
                            pDataParametersB[9].Value = dt.Rows[a]["REMARK"].ToString();
                            pDataParametersB[10].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pVendorInformationEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pVendorInformationEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pVendorInformationEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pVendorInformationEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pVendorInformationEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Vend_Info_Save(VendorInformationEntity pVendorInformationEntity, DataTable dt)",
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
        public override VendorInformationEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                VendorInformationEntity pVendorInformationEntity = new VendorInformationEntity();

                //pVendorInformationEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pVendorInformationEntity;
            }
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

    public class VendorInformation_T01Provider : EntityManager<VendorInformation_T01Entity>
    {
        #region 생성자 - VendorInformation_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public VendorInformation_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Vend_Info_Mst(VendorInformation_T01Entity pVendorInformation_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pVendorInformationEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Vend_Info_Mst(VendorInformation_T01Entity pVendorInformation_T01Entity)
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
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_vend_type", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_vend_name", SqlDbType.VarChar, 100),
                            new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_vend_type", MySqlDbType.VarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)

                        };
                        break;

                }

                pDataParameters[0].Value = pVendorInformation_T01Entity.CRUD;
                pDataParameters[1].Value = pVendorInformation_T01Entity.VEND_CODE;
                pDataParameters[2].Value = pVendorInformation_T01Entity.VEND_NAME;
                pDataParameters[3].Value = pVendorInformation_T01Entity.T_VEND_EIN;
                pDataParameters[4].Value = pVendorInformation_T01Entity.T_VEND_TYPE;
                pDataParameters[5].Value = pVendorInformation_T01Entity.USE_YN;
                pDataParameters[6].Value = pVendorInformation_T01Entity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_T01_R10", pDataParameters);

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
                    "Vend_Info_Mst(VendorInformation_T01Entity pVendorInformation_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 상세 조회하기 - Vend_Info_Sub(VendorInformation_T01Entity pVendorInformation_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Vend_Info_Sub(VendorInformation_T01Entity pVendorInformation_T01Entity)
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
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pVendorInformation_T01Entity.CRUD;
                pDataParameters[1].Value = pVendorInformation_T01Entity.VEND_CODE;
                pDataParameters[2].Value = pVendorInformation_T01Entity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_T01_R20", pDataParameters);

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
                    "Vend_Info_Sub(VendorInformation_T01Entity pVendorInformation_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 거래처(사업자번호) 체크 - Vend_Info_Chk(VendorInformationEntity pVendorInformationEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pVendorInformationEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Vend_Info_Chk(VendorInformation_T01Entity pVendorInformation_T01Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 100),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pVendorInformation_T01Entity.VEND_EIN;
                pDataParameters[1].Value = pVendorInformation_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_T01_R11", pDataParameters);

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
                    "Vend_Info_Chk(VendorInformation_T01Entity pVendorInformation_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Vend_Info_Save(VendorInformation_T01Entity pVendorInformation_T01Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Vend_Info_Save(VendorInformation_T01Entity pVendorInformation_T01Entity, DataTable dt)
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

                                new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_vend_type", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_vend_eng_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_vend_ssn", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_vend_ceo_name", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_vend_business_opendate", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_vend_tel", MySqlDbType.VarChar, 14),
                                new MySqlParameter("@v_vend_fax", MySqlDbType.VarChar, 14),
                                new MySqlParameter("@v_vend_mail", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_vend_address_1", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_vend_address_2", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_vend_business", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_vend_business_type", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_vend_filename", MySqlDbType.VarChar, 100),

                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 100)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),

                                new SqlParameter("@v_vend_code",        SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_vend_type",        SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_vend_name",        SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_eng_name",    SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_ein",         SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_vend_ssn",         SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_vend_ceo_name",    SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_vend_business_opendate", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_vend_tel",         SqlDbType.NVarChar, 14),
                                new SqlParameter("@v_vend_fax",         SqlDbType.NVarChar, 14),
                                new SqlParameter("@v_vend_mail",        SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_address_1",   SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_vend_address_2",   SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_vend_business",    SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_vend_business_type", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_vend_filename",    SqlDbType.NVarChar, 100),

                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 100)

                        };
                        break;

                }

                pDataParametersA[0].Value = pVendorInformation_T01Entity.CRUD;
                pDataParametersA[1].Value = pVendorInformation_T01Entity.USER_CODE;
                pDataParametersA[2].Value = pVendorInformation_T01Entity.VEND_CODE;
                pDataParametersA[3].Value = pVendorInformation_T01Entity.VEND_TYPE;
                pDataParametersA[4].Value = pVendorInformation_T01Entity.VEND_NAME;
                pDataParametersA[5].Value = pVendorInformation_T01Entity.VEND_ENG_NAME;
                pDataParametersA[6].Value = pVendorInformation_T01Entity.VEND_EIN;
                pDataParametersA[7].Value = pVendorInformation_T01Entity.VEND_SSN;
                pDataParametersA[8].Value = pVendorInformation_T01Entity.VEND_CEO_NAME;
                pDataParametersA[9].Value = pVendorInformation_T01Entity.VEND_BUSINESS_OPENDATE;
                pDataParametersA[10].Value = pVendorInformation_T01Entity.VEND_TEL;
                pDataParametersA[11].Value = pVendorInformation_T01Entity.VEND_FAX;
                pDataParametersA[12].Value = pVendorInformation_T01Entity.VEND_MAIL;
                pDataParametersA[13].Value = pVendorInformation_T01Entity.VEND_ADDRESS_1;
                pDataParametersA[14].Value = pVendorInformation_T01Entity.VEND_ADDRESS_2;
                pDataParametersA[15].Value = pVendorInformation_T01Entity.VEND_BUSINESS;
                pDataParametersA[16].Value = pVendorInformation_T01Entity.VEND_BUSINESS_TYPE;
                pDataParametersA[17].Value = pVendorInformation_T01Entity.VEND_FILENAME;
                pDataParametersA[18].Value = pVendorInformation_T01Entity.USE_YN;
                pDataParametersA[19].Value = pVendorInformation_T01Entity.REMARK;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_T01_I10", pDataParametersA);

                pVendorInformation_T01Entity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pVendorInformation_T01Entity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pVendorInformation_T01Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pVendorInformation_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pVendorInformation_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                                        new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                                        new MySqlParameter("@v_vend_seq", MySqlDbType.Int32, 11),
                                        new MySqlParameter("@v_vend_person_name", MySqlDbType.VarChar, 20),
                                        new MySqlParameter("@v_vend_mail", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_vend_tel", MySqlDbType.VarChar, 14),
                                        new MySqlParameter("@v_vend_fax", MySqlDbType.VarChar,14),
                                        new MySqlParameter("@v_vend_mobile", MySqlDbType.VarChar, 14),

                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),

                                        new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 10),
                                        new SqlParameter("@v_vend_seq", SqlDbType.Int, 11),
                                        new SqlParameter("@v_vend_person_name", SqlDbType.NVarChar, 20),
                                        new SqlParameter("@v_vend_mail", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_vend_tel", SqlDbType.NVarChar, 14),
                                        new SqlParameter("@v_vend_fax", SqlDbType.NVarChar,14),
                                        new SqlParameter("@v_vend_mobile", SqlDbType.NVarChar, 14),

                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;

                            }

                            pDataParametersB[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[1].Value = pVendorInformation_T01Entity.USER_CODE;
                            pDataParametersB[2].Value = pVendorInformation_T01Entity.RTN_KEY == "" ? pVendorInformation_T01Entity.VEND_CODE : pVendorInformation_T01Entity.RTN_KEY;
                            pDataParametersB[3].Value = dt.Rows[a]["VEND_SEQ"].ToString() == "" ? "0" : dt.Rows[a]["VEND_SEQ"].ToString();
                            pDataParametersB[4].Value = dt.Rows[a]["VEND_PERSON_NAME"].ToString();
                            pDataParametersB[5].Value = dt.Rows[a]["VEND_MAIL"].ToString();
                            pDataParametersB[6].Value = dt.Rows[a]["VEND_TELL"].ToString();
                            pDataParametersB[7].Value = dt.Rows[a]["VEND_FAX"].ToString();
                            pDataParametersB[8].Value = dt.Rows[a]["VEND_MOBILE"].ToString();
                            pDataParametersB[9].Value = dt.Rows[a]["REMARK"].ToString();
                            pDataParametersB[10].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_T01_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pVendorInformation_T01Entity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pVendorInformation_T01Entity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pVendorInformation_T01Entity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pVendorInformation_T01Entity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pVendorInformation_T01Entity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Vend_Info_Save(VendorInformation_T01Entity pVendorInformation_T01Entity, DataTable dt)",
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
        public override VendorInformation_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                VendorInformation_T01Entity pVendorInformation_T01Entity = new VendorInformation_T01Entity();

                //pVendorInformationEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pVendorInformation_T01Entity;
            }
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

    public class GatheringInformationProvider : EntityManager<GatheringInformationEntity>
    {
        #region 생성자 - GatheringInformationProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public GatheringInformationProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Gathering_Info_Mst(GatheringInformationEntity pGatheringInformationEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGatheringInformationEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Gathering_Info_Mst(GatheringInformationEntity pGatheringInformationEntity)
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
                            new MySqlParameter("@v_gathering_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_gathering_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.VarChar, 10),
                            new SqlParameter("@v_gathering_code", SqlDbType.VarChar, 10),
                            new SqlParameter("@v_gathering_name", SqlDbType.VarChar, 100),
                            new SqlParameter("@v_crud", SqlDbType.VarChar, 1)

                        };
                        break;

                }

                pDataParameters[0].Value = pGatheringInformationEntity.CORP_CODE;
                pDataParameters[1].Value = pGatheringInformationEntity.GATHERING_CODE;
                pDataParameters[2].Value = pGatheringInformationEntity.GATHERING_NAME;
                pDataParameters[3].Value = pGatheringInformationEntity.CRUD;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GatheringInformation_R10", pDataParameters);

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
                    "Gathering_Info_Mst(GatheringInformationEntity pGatheringInformationEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 상세 조회하기 - Gathering_Info_Sub(GatheringInformationEntity pGatheringInformationEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Gathering_Info_Sub(GatheringInformationEntity pGatheringInformationEntity)
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
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pGatheringInformationEntity.CRUD;
                pDataParameters[1].Value = pGatheringInformationEntity.VEND_CODE;
                pDataParameters[2].Value = pGatheringInformationEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_R20", pDataParameters);

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
                    "Gathering_Info_Sub(GatheringInformationEntity pGatheringInformationEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 거래처(사업자번호) 체크 - Gathering_Info_Chk(GatheringInformationEntity pGatheringInformationEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGatheringInformationEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Gathering_Info_Chk(GatheringInformationEntity pGatheringInformationEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 100),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pGatheringInformationEntity.VEND_EIN;
                pDataParameters[1].Value = pGatheringInformationEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_R11", pDataParameters);

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
                    "Gathering_Info_Mst(GatheringInformationEntity pGatheringInformationEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Vend_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Gathering_Info_Save(GatheringInformationEntity pGatheringInformationEntity, DataTable dt)
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

                                new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_vend_type", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_vend_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_vend_eng_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_vend_ein", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_vend_ssn", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_vend_ceo_name", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_vend_business_opendate", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_vend_tel", MySqlDbType.VarChar, 14),
                                new MySqlParameter("@v_vend_fax", MySqlDbType.VarChar, 14),
                                new MySqlParameter("@v_vend_mail", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_vend_address_1", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_vend_address_2", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_vend_business", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_vend_business_type", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_vend_filename", MySqlDbType.VarChar, 100),

                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 100)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),

                                new SqlParameter("@v_vend_code",        SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_vend_type",        SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_vend_name",        SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_eng_name",    SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_ein",         SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_vend_ssn",         SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_vend_ceo_name",    SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_vend_business_opendate", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_vend_tel",         SqlDbType.NVarChar, 14),
                                new SqlParameter("@v_vend_fax",         SqlDbType.NVarChar, 14),
                                new SqlParameter("@v_vend_mail",        SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_vend_address_1",   SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_vend_address_2",   SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_vend_business",    SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_vend_business_type", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_vend_filename",    SqlDbType.NVarChar, 100),

                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 100)

                        };
                        break;

                }

                pDataParametersA[0].Value = pGatheringInformationEntity.CRUD;
                pDataParametersA[1].Value = pGatheringInformationEntity.USER_CODE;
                pDataParametersA[2].Value = pGatheringInformationEntity.VEND_CODE;
                pDataParametersA[3].Value = pGatheringInformationEntity.VEND_TYPE;
                pDataParametersA[4].Value = pGatheringInformationEntity.VEND_NAME;
                pDataParametersA[5].Value = pGatheringInformationEntity.VEND_ENG_NAME;
                pDataParametersA[6].Value = pGatheringInformationEntity.VEND_EIN;
                pDataParametersA[7].Value = pGatheringInformationEntity.VEND_SSN;
                pDataParametersA[8].Value = pGatheringInformationEntity.VEND_CEO_NAME;
                pDataParametersA[9].Value = pGatheringInformationEntity.VEND_BUSINESS_OPENDATE;
                pDataParametersA[10].Value = pGatheringInformationEntity.VEND_TEL;
                pDataParametersA[11].Value = pGatheringInformationEntity.VEND_FAX;
                pDataParametersA[12].Value = pGatheringInformationEntity.VEND_MAIL;
                pDataParametersA[13].Value = pGatheringInformationEntity.VEND_ADDRESS_1;
                pDataParametersA[14].Value = pGatheringInformationEntity.VEND_ADDRESS_2;
                pDataParametersA[15].Value = pGatheringInformationEntity.VEND_BUSINESS;
                pDataParametersA[16].Value = pGatheringInformationEntity.VEND_BUSINESS_TYPE;
                pDataParametersA[17].Value = pGatheringInformationEntity.VEND_FILENAME;
                pDataParametersA[18].Value = pGatheringInformationEntity.USE_YN;
                pDataParametersA[19].Value = pGatheringInformationEntity.REMARK;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_I10", pDataParametersA);

                pGatheringInformationEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pGatheringInformationEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pGatheringInformationEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pGatheringInformationEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pGatheringInformationEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                                        new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 10),
                                        new MySqlParameter("@v_vend_seq", MySqlDbType.Int32, 11),
                                        new MySqlParameter("@v_vend_person_name", MySqlDbType.VarChar, 20),
                                        new MySqlParameter("@v_vend_mail", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_vend_tel", MySqlDbType.VarChar, 14),
                                        new MySqlParameter("@v_vend_fax", MySqlDbType.VarChar,14),
                                        new MySqlParameter("@v_vend_mobile", MySqlDbType.VarChar, 14),

                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),

                                        new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 10),
                                        new SqlParameter("@v_vend_seq", SqlDbType.Int, 11),
                                        new SqlParameter("@v_vend_person_name", SqlDbType.NVarChar, 20),
                                        new SqlParameter("@v_vend_mail", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_vend_tel", SqlDbType.NVarChar, 14),
                                        new SqlParameter("@v_vend_fax", SqlDbType.NVarChar,14),
                                        new SqlParameter("@v_vend_mobile", SqlDbType.NVarChar, 14),

                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;

                            }

                            pDataParametersB[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[1].Value = pGatheringInformationEntity.USER_CODE;
                            pDataParametersB[2].Value = pGatheringInformationEntity.RTN_KEY == "" ? pGatheringInformationEntity.VEND_CODE : pGatheringInformationEntity.RTN_KEY;
                            pDataParametersB[3].Value = dt.Rows[a]["VEND_SEQ"].ToString() == "" ? "0" : dt.Rows[a]["VEND_SEQ"].ToString();
                            pDataParametersB[4].Value = dt.Rows[a]["VEND_PERSON_NAME"].ToString();
                            pDataParametersB[5].Value = dt.Rows[a]["VEND_MAIL"].ToString();
                            pDataParametersB[6].Value = dt.Rows[a]["VEND_TELL"].ToString();
                            pDataParametersB[7].Value = dt.Rows[a]["VEND_FAX"].ToString();
                            pDataParametersB[8].Value = dt.Rows[a]["VEND_MOBILE"].ToString();
                            pDataParametersB[9].Value = dt.Rows[a]["REMARK"].ToString();
                            pDataParametersB[10].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_VendorInformation_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pGatheringInformationEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pGatheringInformationEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pGatheringInformationEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pGatheringInformationEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pGatheringInformationEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Gathering_Info_Save(GatheringInformationEntity pGatheringInformationEntity, DataTable dt)",
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
        public override GatheringInformationEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                GatheringInformationEntity pGatheringInformationEntity = new GatheringInformationEntity();

                //pGatheringInformationEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pGatheringInformationEntity;
            }
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

    public class DocumentInfoRegisterProvider : EntityManager<DocumentInfoRegisterEntity>
    {
        #region 생성자 - DocumentInfoRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public DocumentInfoRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 정보 조회하기 - Document_Info_Main(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pDocumentInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Document_Info_Main(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)
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
                            new MySqlParameter("@v_document_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_document_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pDocumentInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pDocumentInfoRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pDocumentInfoRegisterEntity.DOCUMENT_TYPE;
                pDataParameters[3].Value = pDocumentInfoRegisterEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DocumentInfoRegister_R10", pDataParameters);

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
                    "Document_Info(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 조회하기 - Document_Info_Sub(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pDocumentInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Document_Info_Sub(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)
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
                            new MySqlParameter("@v_document_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_document_ver", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 15),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_document_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_document_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_document_ver", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_contract_id", SqlDbType.NVarChar, 15),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pDocumentInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pDocumentInfoRegisterEntity.DOCUMENT_TYPE;
                pDataParameters[2].Value = pDocumentInfoRegisterEntity.DOCUMENT_NAME;
                pDataParameters[3].Value = pDocumentInfoRegisterEntity.DOCUMENT_VER;
                pDataParameters[4].Value = pDocumentInfoRegisterEntity.CONTRACT_ID;
                pDataParameters[5].Value = pDocumentInfoRegisterEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DocumentInfoRegister_R20", pDataParameters);

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
                    "Document_Info_Sub(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Document_Info_Save(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDocumentInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Document_Info_Save(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity, DataTable dt)
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
                                new MySqlParameter("@v_document_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_document_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_document_seq", MySqlDbType.VarChar, 6),
                                new MySqlParameter("@v_document_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_document_ver", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_document_file_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {

                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_document_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_document_type", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_document_seq", SqlDbType.NVarChar, 6),
                                new SqlParameter("@v_document_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_document_ver", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_document_file_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_contract_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pDocumentInfoRegisterEntity.USER_CODE;
                        pDataParameters[2].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["DOCUMENT_ID"].ToString().ToUpper());
                        pDataParameters[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["DOCUMENT_TYPE"].ToString().ToUpper());
                        pDataParameters[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["DOCUMENT_SEQ"].ToString());

                        
                        pDataParameters[5].Value = dt.Rows[a]["DOCUMENT_NAME"].ToString();
                        pDataParameters[6].Value = dt.Rows[a]["DOCUMENT_VER"].ToString();
                        pDataParameters[7].Value = dt.Rows[a]["DOCUMENT_FILE_NAME"].ToString();
                        pDataParameters[8].Value = dt.Rows[a]["CONTRACT_ID"].ToString();

                        pDataParameters[9].Value = dt.Rows[a]["REMARK"].ToString();
                        pDataParameters[10].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DocumentInfoRegister_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pDocumentInfoRegisterEntity.CRUD = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            
                            pDocumentInfoRegisterEntity.DOCUMENT_BEFROE_FILE_NAME = dt.Rows[a]["DOCUMENT_BEFROE_FILE_NAME"].ToString();
                            pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME = dt.Rows[a]["DOCUMENT_FILE_NAME"].ToString();
                            pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL = dt.Rows[a]["DOCUMENT_FILE_NAME_FULL"].ToString();



                            pErrorYN = File_Save(pDocumentInfoRegisterEntity) == 0 ? false : true;
                        }

                        pDocumentInfoRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pDocumentInfoRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pDocumentInfoRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pDocumentInfoRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pDocumentInfoRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Document_Info_Save(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity, DataTable dt)",
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

        #region OPENBUTTON으로 파일,파일명 삭제 - Document_File_Delete(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Document_File_Delete(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)
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
                                new MySqlParameter("@v_document_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_document_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_document_seq", MySqlDbType.VarChar, 6),
                                new MySqlParameter("@v_document_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_document_ver", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_document_file_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_contract_id", MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {

                                                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_document_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_document_type", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_document_seq", SqlDbType.NVarChar, 6),
                                new SqlParameter("@v_document_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_document_ver", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_document_file_name", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_contract_id", SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pDocumentInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pDocumentInfoRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pDocumentInfoRegisterEntity.DOCUMENT_ID;                                        
                pDataParameters[3].Value = pDocumentInfoRegisterEntity.DOCUMENT_TYPE;                                       
                pDataParameters[4].Value = pDocumentInfoRegisterEntity.DOCUMENT_SEQ;


                pDataParameters[5].Value = pDocumentInfoRegisterEntity.DOCUMENT_NAME;
                pDataParameters[6].Value = pDocumentInfoRegisterEntity.DOCUMENT_VER;
                pDataParameters[7].Value = pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME;
                pDataParameters[8].Value = pDocumentInfoRegisterEntity.CONTRACT_ID;

                pDataParameters[9].Value = pDocumentInfoRegisterEntity.REMARK;
                pDataParameters[10].Value = pDocumentInfoRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DocumentInfoRegister_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pDocumentInfoRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pDocumentInfoRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pDocumentInfoRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pDocumentInfoRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pDocumentInfoRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "Document_File_Delete(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region ○ 파일 저장 - File_Save(string qFileName, string qFullFileName, string qBEFROE_FILENAME)
        private int File_Save(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)//,  string qFileName, string qFullFileName, string qBEFROE_FILENAME)
        {
            try
            {
                // return 값
                // 1 : FileName == ""
                // 2 : FTP 연결 확인
                // 0 : 정상

                string strFTP_PATH = "";

                byte[] data = null;

                strFTP_PATH = string.Format(@"{0}{1}/", pDocumentInfoRegisterEntity.FTP_IP_PORT, "FILE_DATA");

                if (pDocumentInfoRegisterEntity.CRUD == "C")// || pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL != null) // 저장, 추가 생성
                {
                    if (pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL == "") return 1;

                    data = CoFAS_ConvertManager.GetFileData(pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL);

                    if (CoFAS_FTPManager.FTPUpload_DataofStream_CheckDirectory(pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME, pDocumentInfoRegisterEntity.FTP_ID, pDocumentInfoRegisterEntity.FTP_PW, strFTP_PATH, pDocumentInfoRegisterEntity.DOCUMENT_TYPE, data, pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                    {
                        //저장 완료.
                    }
                    else
                    {
                        //FTP 연결을 확인해주세요.
                        return 2;
                    }
                }
                else if (pDocumentInfoRegisterEntity.CRUD == "U") // || pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL == null) // 업데이트
                {
                    //CoFAS_FTPUtilManager qFTPUtil = new CoFAS_FTPUtilManager(strFTP_PATH + pDocumentInfoRegisterEntity.DOCUMENT_TYPE + "/", pDocumentInfoRegisterEntity.FTP_ID, pDocumentInfoRegisterEntity.FTP_PW);

                    if (pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL != null && pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL != "")
                    {
                        data = CoFAS_ConvertManager.GetFileData(pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL);

                        if (CoFAS_FTPManager.FTPDelete(pDocumentInfoRegisterEntity.DOCUMENT_BEFROE_FILE_NAME, strFTP_PATH + pDocumentInfoRegisterEntity.DOCUMENT_TYPE + "/", pDocumentInfoRegisterEntity.FTP_ID, pDocumentInfoRegisterEntity.FTP_PW))
                        {
                            if (CoFAS_FTPManager.FTPUpload_DataofStream_CheckDirectory_Encoding(pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME, pDocumentInfoRegisterEntity.FTP_ID, pDocumentInfoRegisterEntity.FTP_PW, strFTP_PATH, pDocumentInfoRegisterEntity.DOCUMENT_TYPE, data, pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                            {
                                //oFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                            }

                            else
                            {
                                //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                                return 2;
                            }
                        }
                        else
                        {
                            if (CoFAS_FTPManager.FTPUpload_DataofStream_CheckDirectory_Encoding(pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME, pDocumentInfoRegisterEntity.FTP_ID, pDocumentInfoRegisterEntity.FTP_PW, strFTP_PATH, pDocumentInfoRegisterEntity.DOCUMENT_TYPE, data, pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                            {
                                //oFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                            }

                            else
                            {
                                //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                                return 2;
                            }
                        }
                    }
                    //else
                    //{
                    //    
                    //    //파일이 없는지 체크
                    //    if (!qFTPUtil.IsFTPFileExsit(strFTP_PATH + pDocumentInfoRegisterEntity.DOCUMENT_TYPE + "/" + pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME))
                    //    {
                    //        //정상 처리

                    //        //if (CoFAS_FTPManager.FTPUpload_DataofByte_CheckDirectory_Encoding(pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME, pDocumentInfoRegisterEntity.FTP_ID, pDocumentInfoRegisterEntity.FTP_PW, strFTP_PATH, "DATA", data, pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                    //        if (CoFAS_FTPManager.FTPUpload_DataofStream_CheckDirectory_Encoding(pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME, pDocumentInfoRegisterEntity.FTP_ID, pDocumentInfoRegisterEntity.FTP_PW, strFTP_PATH, pDocumentInfoRegisterEntity.DOCUMENT_TYPE, data, pDocumentInfoRegisterEntity.DOCUMENT_FILE_NAME_FULL)) // _pListofManagementEntity.WINDOW_NAME + _pListofManagementEntity.RTN_KEY + _pFileName
                    //        {
                    //            //CoFAS_DevExpressManager.ShowInformationMessage("수정 되었습니다.");
                    //        }
                    //        else
                    //        {
                    //            //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                    //            return 2;
                    //        }
                    //    }
                    //    else
                    //    {
                    //        //CoFAS_DevExpressManager.ShowInformationMessage("FTP 연결을 확인해주세요.");
                    //        return 2;
                    //    }
                    //}

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
                    "File_Save(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)",
                    pException
                );
            }
            finally
            {
            }

            return 0;
        }
        #endregion




        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override DocumentInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                DocumentInfoRegisterEntity pDocumentInfoRegisterEntity = new DocumentInfoRegisterEntity();

                //pLanguageInfoRegisterEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pDocumentInfoRegisterEntity;
            }
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

    public class ProcessCodeMstRegisterProvider : EntityManager<ProcessCodeMstRegisterEntity>
    {
        #region 생성자 - ProcessCodeMstRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProcessCodeMstRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Process_Info_Mst(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Process_Info_Mst(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)
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
                            new MySqlParameter("@v_process_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_mst_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_process_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_process_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_mst_name", SqlDbType.VarChar, 100),
                            new SqlParameter("@v_process_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessCodeMstRegisterEntity.PROCESS_MST_CODE;
                pDataParameters[2].Value = pProcessCodeMstRegisterEntity.PROCESS_MST_NAME;
                pDataParameters[3].Value = pProcessCodeMstRegisterEntity.PROCESS_TYPE;
                pDataParameters[4].Value = pProcessCodeMstRegisterEntity.USE_YN;
                pDataParameters[5].Value = pProcessCodeMstRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessCodeMstRegister_R10", pDataParameters);

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
                    "Process_Info_Mst(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 마스터 바인딩 조회하기 - Process_Info_Mst_Binding(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Process_Info_Mst_Binding(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_process_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_process_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessCodeMstRegisterEntity.PROCESS_MST_CODE;
                pDataParameters[1].Value = pProcessCodeMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessCodeMstRegister_R11", pDataParameters);

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
                    "Process_Info_Mst_Binding(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion



        #region 상세 조회하기 - Process_Info_Detail(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Process_Info_Detail(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)
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
                            new MySqlParameter("@v_process_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_process_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessCodeMstRegisterEntity.PROCESS_MST_CODE;
                pDataParameters[2].Value = pProcessCodeMstRegisterEntity.USE_YN;
                pDataParameters[3].Value = pProcessCodeMstRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessCodeMstRegister_R20", pDataParameters);

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
                    "Process_Info_Mst(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Process_Info_Save(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Process_Info_Save(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity, DataTable dt)
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
                                new MySqlParameter("@v_process_mst_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_process_mst_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_process_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_process_plant", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_process_line", MySqlDbType.VarChar, 50),
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
                                new SqlParameter("@v_process_mst_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_process_mst_name", SqlDbType.VarChar, 100),
                                new SqlParameter("@v_process_type", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_process_plant", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_process_line", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessCodeMstRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pProcessCodeMstRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pProcessCodeMstRegisterEntity.PROCESS_MST_CODE;
                pDataParameters[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pProcessCodeMstRegisterEntity.PROCESS_MST_NAME);
                pDataParameters[5].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pProcessCodeMstRegisterEntity.PROCESS_TYPE);
                pDataParameters[6].Value = pProcessCodeMstRegisterEntity.PROCESS_PLANT;
                pDataParameters[7].Value = pProcessCodeMstRegisterEntity.PROCESS_LINE;
                pDataParameters[8].Value = pProcessCodeMstRegisterEntity.REMARK;
                pDataParameters[9].Value = pProcessCodeMstRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessCodeMstRegister_I10", pDataParameters);

                pProcessCodeMstRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pProcessCodeMstRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pProcessCodeMstRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pProcessCodeMstRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pProcessCodeMstRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pProcessCodeMstRegisterEntity.PROCESS_MST_CODE = pProcessCodeMstRegisterEntity.RTN_KEY;

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
                                            new MySqlParameter("@v_process_mst_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_process_name", MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_process_mst_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_process_name", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[1].Value = pProcessCodeMstRegisterEntity.USER_CODE;
                            pDataParametersB[2].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["PROCESS_MST_CODE"].ToString().Length > 0 ? dt.Rows[a]["PROCESS_MST_CODE"].ToString().ToUpper() : pProcessCodeMstRegisterEntity.PROCESS_MST_CODE);
                            pDataParametersB[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["PROCESS_CODE"].ToString().ToUpper());
                            pDataParametersB[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["PROCESS_NAME"].ToString().ToUpper());

                            pDataParametersB[5].Value = dt.Rows[a]["REMARK"].ToString();
                            pDataParametersB[6].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessCodeMstRegister_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pProcessCodeMstRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pProcessCodeMstRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pProcessCodeMstRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pProcessCodeMstRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pProcessCodeMstRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Process_Info_Save(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity, DataTable dt)",
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
        public override ProcessCodeMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity = new ProcessCodeMstRegisterEntity();

                //pProcessCodeMstRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProcessCodeMstRegisterEntity;
            }
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

    public class TerminalInfoMstRegisterProvider : EntityManager<TerminalInfoMstRegisterEntity>
    {
        #region 생성자 - TerminalInfoMstRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public TerminalInfoMstRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Terminal_Info_Mst(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pTerminalInfoMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Terminal_Info_Mst(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)
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
                            new MySqlParameter("@v_terminal_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_terminal_mst_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_terminal_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_terminal_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_terminal_mst_name", SqlDbType.VarChar, 100),
                            new SqlParameter("@v_terminal_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pTerminalInfoMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pTerminalInfoMstRegisterEntity.TERMINAL_MST_CODE;
                pDataParameters[2].Value = pTerminalInfoMstRegisterEntity.TERMINAL_MST_NAME;
                pDataParameters[3].Value = pTerminalInfoMstRegisterEntity.TERMINAL_TYPE;
                pDataParameters[4].Value = pTerminalInfoMstRegisterEntity.USE_YN;
                pDataParameters[5].Value = pTerminalInfoMstRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_TerminalInfoMstRegister_R10", pDataParameters);

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
                    "Terminal_Info_Mst(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 마스터 바인딩 조회하기 - Terminal_Info_Mst_Binding(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Terminal_Info_Mst_Binding(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_terminal_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_terminal_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pTerminalInfoMstRegisterEntity.TERMINAL_MST_CODE;
                pDataParameters[1].Value = pTerminalInfoMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_TerminalInfoMstRegister_R11", pDataParameters);

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
                    "Terminal_Info_Mst_Binding(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion



        #region 상세 조회하기 - Terminal_Info_Detail(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pTerminalInfoMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Terminal_Info_Detail(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)
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
                            new MySqlParameter("@v_terminal_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_terminal_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pTerminalInfoMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pTerminalInfoMstRegisterEntity.TERMINAL_MST_CODE;
                pDataParameters[2].Value = pTerminalInfoMstRegisterEntity.USE_YN;
                pDataParameters[3].Value = pTerminalInfoMstRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_TerminalInfoMstRegister_R20", pDataParameters);

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
                    "Terminal_Info_Detail(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Terminal_Info_Save(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Terminal_Info_Save(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity, DataTable dt)
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
                                new MySqlParameter("@v_terminal_mst_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_terminal_mst_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_terminal_type", MySqlDbType.VarChar, 50),
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
                                new SqlParameter("@v_terminal_mst_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_terminal_mst_name", SqlDbType.VarChar, 100),
                                new SqlParameter("@v_terminal_type", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pTerminalInfoMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pTerminalInfoMstRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pTerminalInfoMstRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pTerminalInfoMstRegisterEntity.TERMINAL_MST_CODE;
                pDataParameters[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pTerminalInfoMstRegisterEntity.TERMINAL_MST_NAME);
                pDataParameters[5].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pTerminalInfoMstRegisterEntity.TERMINAL_TYPE);
                pDataParameters[6].Value = pTerminalInfoMstRegisterEntity.REMARK;
                pDataParameters[7].Value = pTerminalInfoMstRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_TerminalInfoMstRegister_I10", pDataParameters);

                pTerminalInfoMstRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pTerminalInfoMstRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pTerminalInfoMstRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pTerminalInfoMstRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pTerminalInfoMstRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pTerminalInfoMstRegisterEntity.TERMINAL_MST_CODE = pTerminalInfoMstRegisterEntity.RTN_KEY;

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
                                            new MySqlParameter("@v_terminal_mst_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_terminal_name", MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_terminal_mst_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_terminal_name", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[1].Value = pTerminalInfoMstRegisterEntity.USER_CODE;
                            pDataParametersB[2].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TERMINAL_MST_CODE"].ToString().Length > 0 ? dt.Rows[a]["TERMINAL_MST_CODE"].ToString().ToUpper() : pTerminalInfoMstRegisterEntity.TERMINAL_MST_CODE);
                            pDataParametersB[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TERMINAL_CODE"].ToString().ToUpper());
                            //pDataParametersB[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TERMINAL_NAME"].ToString().ToUpper());
                            pDataParametersB[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TERMINAL_NAME"].ToString());

                            pDataParametersB[5].Value = dt.Rows[a]["REMARK"].ToString();
                            pDataParametersB[6].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_TerminalInfoMstRegister_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pTerminalInfoMstRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pTerminalInfoMstRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pTerminalInfoMstRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pTerminalInfoMstRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pTerminalInfoMstRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Terminal_Info_Save(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity, DataTable dt)",
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
        public override TerminalInfoMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity = new TerminalInfoMstRegisterEntity();

                //pProcessCodeMstRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pTerminalInfoMstRegisterEntity;
            }
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

    public class ToolInfoMstRegisterProvider : EntityManager<ToolInfoMstRegisterEntity>
    {
        #region 생성자 - ToolInfoMstRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ToolInfoMstRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Tool_Info_Mst(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pTerminalInfoMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Tool_Info_Mst(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)
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
                            new MySqlParameter("@v_tool_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_tool_mst_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_tool_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_tool_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_tool_mst_name", SqlDbType.VarChar, 100),
                            new SqlParameter("@v_tool_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pToolInfoMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pToolInfoMstRegisterEntity.TOOL_MST_CODE;
                pDataParameters[2].Value = pToolInfoMstRegisterEntity.TOOL_MST_NAME;
                pDataParameters[3].Value = pToolInfoMstRegisterEntity.TOOL_TYPE;
                pDataParameters[4].Value = pToolInfoMstRegisterEntity.USE_YN;
                pDataParameters[5].Value = pToolInfoMstRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ToolInfoMstRegister_R10", pDataParameters);

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
                    " Tool_Info_Mst(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 마스터 바인딩 조회하기 - Tool_Info_Mst_Binding(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pToolInfoMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Tool_Info_Mst_Binding(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_tool_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_tool_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pToolInfoMstRegisterEntity.TOOL_MST_CODE;
                pDataParameters[1].Value = pToolInfoMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ToolInfoMstRegister_R11", pDataParameters);

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
                    "Tool_Info_Mst_Binding(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 상세 조회하기 - Tool_Info_Detail(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pToolInfoMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Tool_Info_Detail(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)
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
                            new MySqlParameter("@v_tool_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_tool_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pToolInfoMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pToolInfoMstRegisterEntity.TOOL_MST_CODE;
                pDataParameters[2].Value = pToolInfoMstRegisterEntity.USE_YN;
                pDataParameters[3].Value = pToolInfoMstRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ToolInfoMstRegister_R20", pDataParameters);

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
                    "Tool_Info_Detail(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Tool_Info_Save(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pToolInfoMstRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Tool_Info_Save(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity, DataTable dt)
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
                                new MySqlParameter("@v_tool_mst_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_tool_mst_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_tool_type", MySqlDbType.VarChar, 50),
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
                                new SqlParameter("@v_tool_mst_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_tool_mst_name", SqlDbType.VarChar, 100),
                                new SqlParameter("@v_tool_type", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pToolInfoMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pToolInfoMstRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pToolInfoMstRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pToolInfoMstRegisterEntity.TOOL_MST_CODE;
                pDataParameters[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pToolInfoMstRegisterEntity.TOOL_MST_NAME);
                pDataParameters[5].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pToolInfoMstRegisterEntity.TOOL_TYPE);
                pDataParameters[6].Value = pToolInfoMstRegisterEntity.REMARK;
                pDataParameters[7].Value = pToolInfoMstRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ToolInfoMstRegister_I10", pDataParameters);

                pToolInfoMstRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pToolInfoMstRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pToolInfoMstRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pToolInfoMstRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pToolInfoMstRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pToolInfoMstRegisterEntity.TOOL_MST_CODE = pToolInfoMstRegisterEntity.RTN_KEY;

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
                                            new MySqlParameter("@v_tool_mst_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_tool_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_tool_name", MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_tool_mst_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_tool_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_tool_name", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[1].Value = pToolInfoMstRegisterEntity.USER_CODE;
                            pDataParametersB[2].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TOOL_MST_CODE"].ToString().Length > 0 ? dt.Rows[a]["TOOL_MST_CODE"].ToString().ToUpper() : pToolInfoMstRegisterEntity.TOOL_MST_CODE);
                            pDataParametersB[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TOOL_CODE"].ToString().ToUpper());
                            //pDataParametersB[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TOOL_NAME"].ToString().ToUpper());
                            pDataParametersB[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TOOL_NAME"].ToString());

                            pDataParametersB[5].Value = dt.Rows[a]["REMARK"].ToString();
                            pDataParametersB[6].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ToolInfoMstRegister_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pToolInfoMstRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pToolInfoMstRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pToolInfoMstRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pToolInfoMstRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pToolInfoMstRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Tool_Info_Save(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity, DataTable dt)",
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
        public override ToolInfoMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity = new ToolInfoMstRegisterEntity();

                //pProcessCodeMstRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pToolInfoMstRegisterEntity;
            }
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

    public class ToolInfoMstRegister_T01Provider : EntityManager<ToolInfoMstRegister_T01Entity>
    {
        #region 생성자 - ToolInfoMstRegister_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ToolInfoMstRegister_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Tool_Info_Mst(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pTerminalInfoMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Tool_Info_Mst(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)
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
                            new MySqlParameter("@v_tool_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_tool_mst_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_tool_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_tool_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_tool_mst_name", SqlDbType.VarChar, 100),
                            new SqlParameter("@v_tool_type", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pToolInfoMstRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pToolInfoMstRegister_T01Entity.TOOL_MST_CODE;
                pDataParameters[2].Value = pToolInfoMstRegister_T01Entity.TOOL_MST_NAME;
                pDataParameters[3].Value = pToolInfoMstRegister_T01Entity.TOOL_TYPE;
                pDataParameters[4].Value = pToolInfoMstRegister_T01Entity.USE_YN;
                pDataParameters[5].Value = pToolInfoMstRegister_T01Entity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ToolInfoMstRegister_T01_R10", pDataParameters);

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
                    "Tool_Info_Mst(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 마스터 바인딩 조회하기 - Tool_Info_Mst_Binding(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pToolInfoMstRegister_T01Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Tool_Info_Mst_Binding(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_tool_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_tool_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pToolInfoMstRegister_T01Entity.TOOL_MST_CODE;
                pDataParameters[1].Value = pToolInfoMstRegister_T01Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ToolInfoMstRegister_T01_R11", pDataParameters);

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
                    "Tool_Info_Mst_Binding(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 상세 조회하기 - Tool_Info_Detail(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pToolInfoMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Tool_Info_Detail(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)
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
                            new MySqlParameter("@v_tool_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_tool_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pToolInfoMstRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pToolInfoMstRegister_T01Entity.TOOL_MST_CODE;
                pDataParameters[2].Value = pToolInfoMstRegister_T01Entity.USE_YN;
                pDataParameters[3].Value = pToolInfoMstRegister_T01Entity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ToolInfoMstRegister_T01_R20", pDataParameters);

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
                    "Tool_Info_Detail(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Tool_Info_Save(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pToolInfoMstRegister_T01Entity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Tool_Info_Save(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity, DataTable dt)
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
                                new MySqlParameter("@v_tool_mst_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_tool_mst_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_tool_type", MySqlDbType.VarChar, 50),
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
                                new SqlParameter("@v_tool_mst_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_tool_mst_name", SqlDbType.VarChar, 100),
                                new SqlParameter("@v_tool_type", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.VarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pToolInfoMstRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pToolInfoMstRegister_T01Entity.USER_CODE;
                pDataParameters[2].Value = pToolInfoMstRegister_T01Entity.LANGUAGE_TYPE;
                pDataParameters[3].Value = pToolInfoMstRegister_T01Entity.TOOL_MST_CODE;
                pDataParameters[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pToolInfoMstRegister_T01Entity.TOOL_MST_NAME);
                pDataParameters[5].Value = CoFAS_ConvertManager.StringEmpty2DbNull(pToolInfoMstRegister_T01Entity.TOOL_TYPE);
                pDataParameters[6].Value = pToolInfoMstRegister_T01Entity.REMARK;
                pDataParameters[7].Value = pToolInfoMstRegister_T01Entity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ToolInfoMstRegister_T01_I10", pDataParameters);

                pToolInfoMstRegister_T01Entity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pToolInfoMstRegister_T01Entity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pToolInfoMstRegister_T01Entity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pToolInfoMstRegister_T01Entity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pToolInfoMstRegister_T01Entity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pToolInfoMstRegister_T01Entity.TOOL_MST_CODE = pToolInfoMstRegister_T01Entity.RTN_KEY;

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
                                            new MySqlParameter("@v_tool_mst_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_tool_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_tool_name", MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_tool_number", MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_tool_mst_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_tool_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_tool_name", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_tool_number", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[1].Value = pToolInfoMstRegister_T01Entity.USER_CODE;
                            pDataParametersB[2].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TOOL_MST_CODE"].ToString().Length > 0 ? dt.Rows[a]["TOOL_MST_CODE"].ToString().ToUpper() : pToolInfoMstRegister_T01Entity.TOOL_MST_CODE);
                            pDataParametersB[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TOOL_CODE"].ToString().ToUpper());
                            //pDataParametersB[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TOOL_NAME"].ToString().ToUpper());
                            pDataParametersB[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TOOL_NAME"].ToString());
                            pDataParametersB[5].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["TOOL_NUMBER"].ToString().ToUpper());
                            pDataParametersB[6].Value = dt.Rows[a]["REMARK"].ToString();
                            pDataParametersB[7].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ToolInfoMstRegister_T01_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pToolInfoMstRegister_T01Entity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pToolInfoMstRegister_T01Entity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pToolInfoMstRegister_T01Entity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pToolInfoMstRegister_T01Entity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pToolInfoMstRegister_T01Entity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Tool_Info_Save(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity, DataTable dt)",
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
        public override ToolInfoMstRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity = new ToolInfoMstRegister_T01Entity();

                //pProcessCodeMstRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pToolInfoMstRegister_T01Entity;
            }
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

    public class ProcessConfigurationRegisterProvider : EntityManager<ProcessConfigurationRegisterEntity>
    {
        #region 생성자 - ProcessConfigurationRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProcessConfigurationRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 라우팅 리스트 조회하기 - ProcessConfigurationRegister_Info_Main(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Info_Main(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_configuration_mst_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                            

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_mst_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                            
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE;
                pDataParameters[3].Value = pProcessConfigurationRegisterEntity.CONFIGURATION_MST_NAME;
                pDataParameters[4].Value = pProcessConfigurationRegisterEntity.USE_YN;
                

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R10", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_Main(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion
        
        #region 구성 정보 조회하기 - ProcessConfigurationRegister_Info_SUB01(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Info_SUB01(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R21", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_SUB01(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessConfigurationRegister_Info_SUB02(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Info_SUB02(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R22", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_SUB02(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessConfigurationRegister_Info_WorkCenter_SUB02(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Info_WorkCenter_SUB02(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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
                            new MySqlParameter("@v_process_mst_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_mst_code",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessConfigurationRegisterEntity.PROCESS_MST_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R27", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_WorkCenter_SUB02(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessConfigurationRegister_Info_SUB03(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Info_SUB03(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R23", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_SUB03(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessConfigurationRegister_Info_SUB04(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Info_SUB04(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R24", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_SUB04(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessConfigurationRegister_Info_SUB05(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Info_SUB05(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R25", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_SUB05(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessConfigurationRegister_Info_SUB06(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Info_SUB06(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R26", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_SUB06(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 공정 라우팅 정보 조회하기 - ProcessConfigurationRegister_Info_Process(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Info_Process(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R30", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_Process(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 트리 리스트 라우팅 신규용 조회하기 - ProcessConfigurationRegister_Routing_Mst(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Routing_Mst(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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
                            new MySqlParameter("@v_routing_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_routing_revision_no", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),



                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_routing_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_routing_revision_no", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),

                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessConfigurationRegisterEntity.ROUTING_MST_CODE;
                pDataParameters[3].Value = pProcessConfigurationRegisterEntity.ROUTING_REVISION_NO;
                pDataParameters[4].Value = pProcessConfigurationRegisterEntity.USE_YN;




                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R31", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_Routing_DETAIL(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 트리 리스트 라우팅 신규용 조회하기 - ProcessConfigurationRegister_Routing_Tree(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Routing_Tree(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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
                            new MySqlParameter("@v_routing_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_routing_revision_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)




                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_routing_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_routing_revision_no", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)

                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessConfigurationRegisterEntity.ROUTING_MST_CODE;
                pDataParameters[3].Value = pProcessConfigurationRegisterEntity.ROUTING_REVISION_NO;
                pDataParameters[4].Value = pProcessConfigurationRegisterEntity.USE_YN;




                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R32", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_Routing_DETAIL(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 공정 라우팅 마스터 정보 조회하기 - ProcessConfigurationRegister_Info_Routing_MST(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Info_Routing_MST(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_revision_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_revision_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE;
                pDataParameters[3].Value = pProcessConfigurationRegisterEntity.REVISION_NO;
                pDataParameters[4].Value = pProcessConfigurationRegisterEntity.USE_YN;




                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R40", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_Routing_MST(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 트리 리스트 공정 순서 신규용 조회하기 - ProcessConfigurationRegister_Info_Routing_DETAIL(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Info_Routing_DETAIL(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R41", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_Routing_DETAIL(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 상세 조회하기 - ProcessConfigurationRegister_Info_Sub(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_Info_Sub(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_process_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_process_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegisterEntity.PROCESS_CODE;
                pDataParameters[2].Value = pProcessConfigurationRegisterEntity.PROCESS_NAME;
                pDataParameters[3].Value = pProcessConfigurationRegisterEntity.PROCESS_TYPE;
                pDataParameters[4].Value = pProcessConfigurationRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_R30", pDataParameters);

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
                    "ProcessConfigurationRegister_Info_Sub(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ProcessConfigurationRegister_Info_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ProcessConfigurationRegister_Info_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {
                //마스터 저장
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    pCount = i;
                    IDataParameter[] pDataParametersA = null;

                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                        //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,50),

                                        new MySqlParameter("@v_routing_mst_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_routing_revision_no", MySqlDbType.VarChar,10),

                                        new MySqlParameter("@v_lvl", MySqlDbType.Int32),
                                        new MySqlParameter("@v_dsp_sort", MySqlDbType.Int32),

                                        new MySqlParameter("@v_routing_code", MySqlDbType.VarChar,50),
                                        
                                        new MySqlParameter("@v_p_routing_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_routing_mst_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_routing_revision_no", SqlDbType.NVarChar,10),
                                        new SqlParameter("@v_lvl", SqlDbType.Int),
                                        new SqlParameter("@v_dsp_sort", SqlDbType.Int),
                                        new SqlParameter("@v_routing_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_p_routing_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1),

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pProcessConfigurationRegisterEntity.CRUD;//vCRUD;
                    pDataParametersA[1].Value = pProcessConfigurationRegisterEntity.USER_CODE;
                    pDataParametersA[2].Value = dt.Rows[i]["ROUTING_MST_CODE"].ToString();
                    pDataParametersA[3].Value = dt.Rows[i]["ROUTING_REVISION_NO"].ToString();

                    pDataParametersA[4].Value = CoFAS_ConvertManager.obj2int(dt.Rows[i]["NODE_LEVEL"].ToString());
                    pDataParametersA[5].Value = CoFAS_ConvertManager.obj2int(dt.Rows[i]["NODE_ID"].ToString());
                    pDataParametersA[6].Value = dt.Rows[i]["ROUTING_CODE"].ToString();
                    pDataParametersA[7].Value = dt.Rows[i]["P_ROUTING_CODE"].ToString();
                    pDataParametersA[8].Value = pProcessConfigurationRegisterEntity.USE_YN; ;



                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_I10", pDataParametersA);

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
                    "ProcessConfigurationRegister_Info_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 정보 사용안하기 - ProcessConfigurationRegister_Info_Enable(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <returns></returns>
        public bool ProcessConfigurationRegister_Info_Enable(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
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
                                        //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,50),

                                        new MySqlParameter("@v_routing_mst_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_routing_revision_no", MySqlDbType.VarChar,10),

                                        new MySqlParameter("@v_lvl", MySqlDbType.Int32),
                                        new MySqlParameter("@v_dsp_sort", MySqlDbType.Int32),

                                        new MySqlParameter("@v_routing_code", MySqlDbType.VarChar,50),

                                        new MySqlParameter("@v_p_routing_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_routing_mst_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_routing_revision_no", SqlDbType.NVarChar,10),
                                        new SqlParameter("@v_lvl", SqlDbType.Int),
                                        new SqlParameter("@v_dsp_sort", SqlDbType.Int),
                                        new SqlParameter("@v_routing_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_p_routing_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1),

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pProcessConfigurationRegisterEntity.CRUD;//vCRUD;
                    pDataParametersA[1].Value = pProcessConfigurationRegisterEntity.USER_CODE;
                    pDataParametersA[2].Value = pProcessConfigurationRegisterEntity.ROUTING_MST_CODE;
                    pDataParametersA[3].Value = pProcessConfigurationRegisterEntity.ROUTING_REVISION_NO;

                    pDataParametersA[4].Value = 0;
                    pDataParametersA[5].Value = 0;
                    pDataParametersA[6].Value = "";
                    pDataParametersA[7].Value = "";
                    pDataParametersA[8].Value = pProcessConfigurationRegisterEntity.USE_YN;



                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_I10", pDataParametersA);
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
                    "ProcessConfigurationRegister_Info_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion


        #region 구성 정보 저장하기 - ProcessConfigurationRegister_Configuration_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ProcessConfigurationRegister_Configuration_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)
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
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_configuration_mst_name", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_configuration_vend_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_revision_no", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_configuration_mst_name", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_configuration_vend_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_revision_no", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar,1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                            };
                            break;
                    }

                    pDataParametersA[0].Value = pProcessConfigurationRegisterEntity.CRUD;//vCRUD;
                    pDataParametersA[1].Value = pProcessConfigurationRegisterEntity.USER_CODE;
                    pDataParametersA[2].Value = pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE;
                    pDataParametersA[3].Value = pProcessConfigurationRegisterEntity.CONFIGURATION_MST_NAME;
                    pDataParametersA[4].Value = pProcessConfigurationRegisterEntity.CONFIGURATION_VEND_CODE;
                    pDataParametersA[5].Value = pProcessConfigurationRegisterEntity.REVISION_NO;
                    pDataParametersA[6].Value = pProcessConfigurationRegisterEntity.REMARK;
                    pDataParametersA[7].Value = pProcessConfigurationRegisterEntity.USE_YN;

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_I20", pDataParametersA);

                   pProcessConfigurationRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                   pProcessConfigurationRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                   pProcessConfigurationRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                   pProcessConfigurationRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                   pProcessConfigurationRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    else
                    {
                    pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE = pProcessConfigurationRegisterEntity.RTN_KEY;

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
                                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_configuration_seq", MySqlDbType.Int32),
                                            new MySqlParameter("@v_configuration_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_configuration_name", MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_routing_revision_no", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_dsp_sort", MySqlDbType.Int32),
                                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_configuration_seq", SqlDbType.Int),
                                            new SqlParameter("@v_configuration_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_configuration_name", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_routing_revision_no", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_dsp_sort", SqlDbType.Int),
                                            new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = dt.Rows[a]["CONFIGURATION_SEQ"].ToString() == "" ? "C" : "U"; // pProcessConfigurationRegisterEntity.CRUD;
                            pDataParametersB[1].Value = pProcessConfigurationRegisterEntity.USER_CODE;
                            pDataParametersB[2].Value = pProcessConfigurationRegisterEntity.CONFIGURATION_MST_CODE;

                            pDataParametersB[3].Value = Convert.ToInt32(dt.Rows[a]["CONFIGURATION_SEQ"].ToString() == "" ? "0" : dt.Rows[a]["CONFIGURATION_SEQ"].ToString());

                            pDataParametersB[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["CONFIGURATION_CODE"].ToString().ToUpper());
                            pDataParametersB[5].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["CONFIGURATION_NAME"].ToString());
                            pDataParametersB[6].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["ROUTING_REVISION_NO"].ToString());

                            pDataParametersB[7].Value = a+1;

                            pDataParametersB[8].Value = "";
                            pDataParametersB[9].Value = "Y";

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_I30", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pProcessConfigurationRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pProcessConfigurationRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pProcessConfigurationRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pProcessConfigurationRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pProcessConfigurationRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "ProcessConfigurationRegister_Configuration_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)",
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
        public override ProcessConfigurationRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity = new ProcessConfigurationRegisterEntity();

                //pProductBOMRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProcessConfigurationRegisterEntity;
            }
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


    public class ProcessRoutingRegisterProvider : EntityManager<ProcessRoutingRegisterEntity>
    {
        #region 생성자 - ProcessRoutingRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProcessRoutingRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 라우팅 리스트 조회하기 - ProcessRoutingRegister_Info_Main(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Info_Main(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_configuration_mst_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_mst_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)

                        };
                        break;
                }

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessRoutingRegisterEntity.CONFIGURATION_MST_CODE;
                pDataParameters[3].Value = pProcessRoutingRegisterEntity.CONFIGURATION_MST_NAME;
                pDataParameters[4].Value = pProcessRoutingRegisterEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R10", pDataParameters);

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
                    "ProcessRoutingRegister_Info_Main(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessRoutingRegister_Info_SUB01(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Info_SUB01(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R21", pDataParameters);

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
                    "ProcessRoutingRegister_Info_SUB01(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessRoutingRegister_Info_SUB02(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Info_SUB02(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R22", pDataParameters);

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
                    "ProcessRoutingRegister_Info_SUB02(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessRoutingRegister_Info_WorkCenter_SUB02(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Info_WorkCenter_SUB02(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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
                            new MySqlParameter("@v_process_mst_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_mst_code",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessRoutingRegisterEntity.PROCESS_MST_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R27", pDataParameters);

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
                    "ProcessRoutingRegister_Info_WorkCenter_SUB02(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessRoutingRegister_Info_SUB03(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Info_SUB03(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R23", pDataParameters);

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
                    "ProcessRoutingRegister_Info_SUB03(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessRoutingRegister_Info_SUB04(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Info_SUB04(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R24", pDataParameters);

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
                    "ProcessRoutingRegister_Info_SUB04(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessRoutingRegister_Info_SUB05(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Info_SUB05(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R25", pDataParameters);

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
                    "ProcessRoutingRegister_Info_SUB05(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 구성 정보 조회하기 - ProcessRoutingRegister_Info_SUB06(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Info_SUB06(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R26", pDataParameters);

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
                    "ProcessRoutingRegister_Info_SUB06(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 공정 라우팅 정보 조회하기 - ProcessRoutingRegister_Info_Process(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Info_Process(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R30", pDataParameters);

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
                    "ProcessRoutingRegister_Info_Process(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 트리 리스트 라우팅 신규용 조회하기 - ProcessRoutingRegister_Routing_Mst(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Routing_Mst(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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
                            new MySqlParameter("@v_routing_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_routing_revision_no", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),



                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_routing_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_routing_revision_no", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),

                        };
                        break;
                }

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessRoutingRegisterEntity.ROUTING_MST_CODE;
                pDataParameters[3].Value = pProcessRoutingRegisterEntity.ROUTING_REVISION_NO;
                pDataParameters[4].Value = pProcessRoutingRegisterEntity.USE_YN;




                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R31", pDataParameters);

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
                    "ProcessRoutingRegister_Routing_Mst(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 트리 리스트 라우팅 신규용 조회하기 -ProcessRoutingRegister_Routing_Tree(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Routing_Tree(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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
                            new MySqlParameter("@v_routing_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_routing_revision_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)




                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_routing_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_routing_revision_no", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)

                        };
                        break;
                }

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessRoutingRegisterEntity.ROUTING_MST_CODE;
                pDataParameters[3].Value = pProcessRoutingRegisterEntity.ROUTING_REVISION_NO;
                pDataParameters[4].Value = pProcessRoutingRegisterEntity.USE_YN;




                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R32", pDataParameters);

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
                    "ProcessRoutingRegister_Routing_Tree(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 공정 라우팅 마스터 정보 조회하기 - ProcessRoutingRegister_Info_Routing_MST(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Info_Routing_MST(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_revision_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_revision_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessRoutingRegisterEntity.CONFIGURATION_MST_CODE;
                pDataParameters[3].Value = pProcessRoutingRegisterEntity.REVISION_NO;
                pDataParameters[4].Value = pProcessRoutingRegisterEntity.USE_YN;




                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R40", pDataParameters);

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
                    "ProcessRoutingRegister_Info_Routing_MST(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 트리 리스트 공정 순서 신규용 조회하기 - ProcessRoutingRegister_Info_Routing_DETAIL(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Info_Routing_DETAIL(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessRoutingRegisterEntity.CONFIGURATION_MST_CODE;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R41", pDataParameters);

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
                    "ProcessRoutingRegister_Info_Routing_DETAIL(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion


        #region 상세 조회하기 - ProcessRoutingRegister_Info_Sub(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessRoutingRegister_Info_Sub(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_process_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_process_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pProcessRoutingRegisterEntity.CRUD;
                pDataParameters[1].Value = pProcessRoutingRegisterEntity.PROCESS_CODE;
                pDataParameters[2].Value = pProcessRoutingRegisterEntity.PROCESS_NAME;
                pDataParameters[3].Value = pProcessRoutingRegisterEntity.PROCESS_TYPE;
                pDataParameters[4].Value = pProcessRoutingRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_R30", pDataParameters);

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
                    "ProcessRoutingRegister_Info_Sub(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ProcessRoutingRegister_Info_Save(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ProcessRoutingRegister_Info_Save(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {
                //마스터 저장
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    pCount = i;
                    IDataParameter[] pDataParametersA = null;

                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                        //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,50),

                                        new MySqlParameter("@v_routing_mst_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_routing_revision_no", MySqlDbType.VarChar,10),

                                        new MySqlParameter("@v_lvl", MySqlDbType.Int32),
                                        new MySqlParameter("@v_dsp_sort", MySqlDbType.Int32),

                                        new MySqlParameter("@v_routing_code", MySqlDbType.VarChar,50),

                                        new MySqlParameter("@v_p_routing_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_routing_mst_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_routing_revision_no", SqlDbType.NVarChar,10),
                                        new SqlParameter("@v_lvl", SqlDbType.Int),
                                        new SqlParameter("@v_dsp_sort", SqlDbType.Int),
                                        new SqlParameter("@v_routing_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_p_routing_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1),

                            };
                            break;
                    }

                    pDataParametersA[0].Value = pProcessRoutingRegisterEntity.CRUD;//vCRUD;
                    pDataParametersA[1].Value = pProcessRoutingRegisterEntity.USER_CODE;
                    pDataParametersA[2].Value = dt.Rows[i]["ROUTING_MST_CODE"].ToString();
                    pDataParametersA[3].Value = dt.Rows[i]["ROUTING_REVISION_NO"].ToString();

                    pDataParametersA[4].Value = CoFAS_ConvertManager.obj2int(dt.Rows[i]["NODE_LEVEL"].ToString());
                    pDataParametersA[5].Value = CoFAS_ConvertManager.obj2int(dt.Rows[i]["NODE_ID"].ToString());
                    pDataParametersA[6].Value = dt.Rows[i]["ROUTING_CODE"].ToString();
                    pDataParametersA[7].Value = dt.Rows[i]["P_ROUTING_CODE"].ToString();
                    pDataParametersA[8].Value = pProcessRoutingRegisterEntity.USE_YN; 



                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_I10", pDataParametersA);

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
                    "ProcessRoutingRegister_Info_Save(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region 정보 사용안하기 - ProcessRoutingRegister_Info_Enable(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity"></param>
        /// <returns></returns>
        public bool ProcessRoutingRegister_Info_Enable(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
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
                                        //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,50),

                                        new MySqlParameter("@v_routing_mst_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_routing_revision_no", MySqlDbType.VarChar,10),

                                        new MySqlParameter("@v_lvl", MySqlDbType.Int32),
                                        new MySqlParameter("@v_dsp_sort", MySqlDbType.Int32),

                                        new MySqlParameter("@v_routing_code", MySqlDbType.VarChar,50),

                                        new MySqlParameter("@v_p_routing_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_routing_mst_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_routing_revision_no", SqlDbType.NVarChar,10),
                                        new SqlParameter("@v_lvl", SqlDbType.Int),
                                        new SqlParameter("@v_dsp_sort", SqlDbType.Int),
                                        new SqlParameter("@v_routing_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_p_routing_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1),

                        };
                        break;
                }

                pDataParametersA[0].Value = pProcessRoutingRegisterEntity.CRUD;//vCRUD;
                pDataParametersA[1].Value = pProcessRoutingRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pProcessRoutingRegisterEntity.ROUTING_MST_CODE;
                pDataParametersA[3].Value = pProcessRoutingRegisterEntity.ROUTING_REVISION_NO;

                pDataParametersA[4].Value = 0;
                pDataParametersA[5].Value = 0;
                pDataParametersA[6].Value = "";
                pDataParametersA[7].Value = "";
                pDataParametersA[8].Value = pProcessRoutingRegisterEntity.USE_YN;



                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_I10", pDataParametersA);
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
                    "ProcessRoutingRegister_Info_Enable(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion


        #region 구성 정보 저장하기 - ProcessRoutingRegister_Configuration_Save(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pProcessRoutingRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ProcessRoutingRegister_Configuration_Save(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity, DataTable dt)
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
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_configuration_mst_name", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_configuration_vend_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_revision_no", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_configuration_mst_name", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_configuration_vend_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_revision_no", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar,1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pProcessRoutingRegisterEntity.CRUD;//vCRUD;
                pDataParametersA[1].Value = pProcessRoutingRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pProcessRoutingRegisterEntity.CONFIGURATION_MST_CODE;
                pDataParametersA[3].Value = pProcessRoutingRegisterEntity.CONFIGURATION_MST_NAME;
                pDataParametersA[4].Value = pProcessRoutingRegisterEntity.CONFIGURATION_VEND_CODE;
                pDataParametersA[5].Value = pProcessRoutingRegisterEntity.REVISION_NO;
                pDataParametersA[6].Value = pProcessRoutingRegisterEntity.REMARK;
                pDataParametersA[7].Value = pProcessRoutingRegisterEntity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_I20", pDataParametersA);

                pProcessRoutingRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pProcessRoutingRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pProcessRoutingRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pProcessRoutingRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pProcessRoutingRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pProcessRoutingRegisterEntity.CONFIGURATION_MST_CODE = pProcessRoutingRegisterEntity.RTN_KEY;

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
                                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_configuration_seq", MySqlDbType.Int32),
                                            new MySqlParameter("@v_configuration_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_configuration_name", MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_routing_revision_no", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_dsp_sort", MySqlDbType.Int32),
                                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_configuration_seq", SqlDbType.Int),
                                            new SqlParameter("@v_configuration_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_configuration_name", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_routing_revision_no", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_dsp_sort", SqlDbType.Int),
                                            new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = dt.Rows[a]["CONFIGURATION_SEQ"].ToString() == "" ? "C" : "U"; // pProcessConfigurationRegisterEntity.CRUD;
                            pDataParametersB[1].Value = pProcessRoutingRegisterEntity.USER_CODE;
                            pDataParametersB[2].Value = pProcessRoutingRegisterEntity.CONFIGURATION_MST_CODE;

                            pDataParametersB[3].Value = Convert.ToInt32(dt.Rows[a]["CONFIGURATION_SEQ"].ToString() == "" ? "0" : dt.Rows[a]["CONFIGURATION_SEQ"].ToString());

                            pDataParametersB[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["CONFIGURATION_CODE"].ToString().ToUpper());
                            pDataParametersB[5].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["CONFIGURATION_NAME"].ToString());
                            pDataParametersB[6].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["ROUTING_REVISION_NO"].ToString());

                            pDataParametersB[7].Value = a + 1;

                            pDataParametersB[8].Value = "";
                            pDataParametersB[9].Value = "Y";

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessRoutingRegister_I30", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pProcessRoutingRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pProcessRoutingRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pProcessRoutingRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pProcessRoutingRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pProcessRoutingRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "ProcessRoutingRegister_Configuration_Save(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity, DataTable dt)",
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
        public override ProcessRoutingRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity = new ProcessRoutingRegisterEntity();

                //pProductBOMRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProcessRoutingRegisterEntity;
            }
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



    public class ProcessConfigurationRegister_T01Provider : EntityManager<ProcessConfigurationRegister_T01Entity>
    {
        #region 생성자 - ProcessConfigurationRegister_T01Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProcessConfigurationRegister_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 라우팅 리스트 조회하기 - ProcessConfigurationRegister_T01_Info_Main(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_T01_Info_Main(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_configuration_mst_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_mst_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)

                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegister_T01Entity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE;
                pDataParameters[3].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_NAME;
                pDataParameters[4].Value = pProcessConfigurationRegister_T01Entity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T01_R10", pDataParameters);

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
                    "ProcessConfigurationRegister_T01_Info_Main(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 공정 라우팅 마스터 정보 조회하기 - ProcessConfigurationRegister_T01_Info_Routing_MST(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_T01_Info_Routing_MST(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_revision_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_revision_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE;
                pDataParameters[2].Value = pProcessConfigurationRegister_T01Entity.REVISION_NO;
                pDataParameters[3].Value = pProcessConfigurationRegister_T01Entity.USE_YN;




                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T01_R20", pDataParameters);

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
                    "ProcessConfigurationRegister_T01_Info_Routing_MST(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 트리 리스트 공정 순서 신규용 조회하기 - ProcessConfigurationRegister_T01_Info_Routing_DETAIL(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_T01_Info_Routing_DETAIL(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_revision_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_configuration_mst_code",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_revision_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE;
                pDataParameters[2].Value = pProcessConfigurationRegister_T01Entity.REVISION_NO;
                pDataParameters[3].Value = pProcessConfigurationRegister_T01Entity.USE_YN;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T01_R21", pDataParameters);

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
                    "ProcessConfigurationRegister_T01_Info_Routing_DETAIL(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ProcessConfigurationRegister_T01_Info_Save(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity, DataTable dtDetail, DataTable dtRouting)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pProcessConfigurationRegister_T01Entity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ProcessConfigurationRegister_T01_Info_Save(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity, DataTable dtDetail, DataTable dtRouting, bool isEditcheck)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {
                IDataParameter[] pDataParametersA = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParametersA = new IDataParameter[]
                        {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                        new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_configuration_mst_name", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_configuration_vend_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_revision_no", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                        new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_configuration_mst_name", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_configuration_vend_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_revision_no", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar,1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pProcessConfigurationRegister_T01Entity.CRUD;//vCRUD;
                pDataParametersA[1].Value = pProcessConfigurationRegister_T01Entity.USER_CODE;
                pDataParametersA[2].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE;
                pDataParametersA[3].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_NAME;
                pDataParametersA[4].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_VEND_CODE;
                pDataParametersA[5].Value = pProcessConfigurationRegister_T01Entity.REVISION_NO;
                pDataParametersA[6].Value = pProcessConfigurationRegister_T01Entity.REMARK;
                pDataParametersA[7].Value = pProcessConfigurationRegister_T01Entity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T01_I10", pDataParametersA);

                pProcessConfigurationRegister_T01Entity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pProcessConfigurationRegister_T01Entity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pProcessConfigurationRegister_T01Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pProcessConfigurationRegister_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pProcessConfigurationRegister_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE = pProcessConfigurationRegister_T01Entity.RTN_KEY;



                    IDataParameter[] pDataParametersCheck = null;
                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersCheck = new IDataParameter[]
                            {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50)
                            };
                            break;

                        case "SQLServer":
                            pDataParametersCheck = new IDataParameter[]
                            {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50)
                            };
                            break;
                    }

                    pDataParametersCheck[0].Value = ""; // pProcessConfigurationRegisterEntity.CRUD;
                    pDataParametersCheck[1].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE;

                    DataTable pDataTableCheck = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T01_I40", pDataParametersCheck);



                    if (dtDetail != null)
                    {
                        pCount = dtDetail.Rows.Count;

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
                                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_configuration_code", MySqlDbType.VarChar, 50),
                                           // new MySqlParameter("@v_configuration_name", MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_routing_revision_no", MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_dsp_sort", MySqlDbType.Int32),
                                            new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                            new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_configuration_code", SqlDbType.NVarChar, 50),
                                           // new SqlParameter("@v_configuration_name", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_routing_revision_no", SqlDbType.NVarChar, 50),
                                            new SqlParameter("@v_dsp_sort", SqlDbType.Int),
                                            new SqlParameter("@v_remark", SqlDbType.NVarChar, 100),
                                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = "C"; // dtDetail.Rows[a]["CRUD"].ToString(); // pProcessConfigurationRegisterEntity.CRUD;
                            pDataParametersB[1].Value = pProcessConfigurationRegister_T01Entity.USER_CODE;
                            pDataParametersB[2].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE;
                            pDataParametersB[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dtDetail.Rows[a]["P_ROUTING_CODE"].ToString().ToUpper());
                            // pDataParametersB[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dtDetail.Rows[a]["CONFIGURATION_NAME"].ToString());
                            pDataParametersB[4].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE;
                            pDataParametersB[5].Value = a + 1;
                            pDataParametersB[6].Value = "";
                            pDataParametersB[7].Value = "Y";

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T01_I20", pDataParametersB);
                            

                            pProcessConfigurationRegister_T01Entity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pProcessConfigurationRegister_T01Entity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pProcessConfigurationRegister_T01Entity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pProcessConfigurationRegister_T01Entity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pProcessConfigurationRegister_T01Entity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                           

                        }



                    }
                }

                //마스터 저장
                for (int i = 0; i < dtRouting.Rows.Count; i++)
                {
                    pCount = i;
                    IDataParameter[] pDataParametersC = null;

                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersC = new IDataParameter[]
                            {
                                        //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,50),

                                        new MySqlParameter("@v_routing_mst_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_routing_revision_no", MySqlDbType.VarChar,10),

                                        new MySqlParameter("@v_lvl", MySqlDbType.Int32),
                                        new MySqlParameter("@v_dsp_sort", MySqlDbType.Int32),

                                        new MySqlParameter("@v_routing_code", MySqlDbType.VarChar,50),

                                        new MySqlParameter("@v_p_routing_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),

                            };
                            break;

                        case "SQLServer":
                            pDataParametersC = new IDataParameter[]
                            {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_routing_mst_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_routing_revision_no", SqlDbType.NVarChar,10),
                                        new SqlParameter("@v_lvl", SqlDbType.Int),
                                        new SqlParameter("@v_dsp_sort", SqlDbType.Int),
                                        new SqlParameter("@v_routing_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_p_routing_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1),

                            };
                            break;
                    }

                    pDataParametersC[0].Value = "C";//dtRouting.Rows[i]["CRUD"].ToString();
                    pDataParametersC[1].Value = pProcessConfigurationRegister_T01Entity.USER_CODE;
                    pDataParametersC[2].Value = dtRouting.Rows[i]["ROUTING_MST_CODE"].ToString();
                    pDataParametersC[3].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE; // dtRouting.Rows[i]["REVISION_NO"].ToString();

                    pDataParametersC[4].Value = CoFAS_ConvertManager.obj2int(dtRouting.Rows[i]["NODE_LEVEL"].ToString());
                    pDataParametersC[5].Value = CoFAS_ConvertManager.obj2int(dtRouting.Rows[i]["NODE_ID"].ToString());
                    pDataParametersC[6].Value = dtRouting.Rows[i]["ROUTING_CODE"].ToString();
                    pDataParametersC[7].Value = dtRouting.Rows[i]["P_ROUTING_CODE"].ToString();
                    pDataParametersC[8].Value = "Y";

                    DataTable pDataTableC = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T01_I30", pDataParametersC);

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
                    "ProcessConfigurationRegister_T01_Info_Save(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity, DataTable dtDetail, DataTable dtRouting)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion
        
        #region 마스터 정보 저장하기 - ProcessConfigurationRegister_T01_Info_MST_Save(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pProcessConfigurationRegister_T01Entity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ProcessConfigurationRegister_T01_Info_MST_Save(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {
                IDataParameter[] pDataParametersA = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParametersA = new IDataParameter[]
                        {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                        new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_configuration_mst_name", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_configuration_vend_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_revision_no", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                        new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_configuration_mst_name", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_configuration_vend_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_revision_no", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar,1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pProcessConfigurationRegister_T01Entity.CRUD;//vCRUD;
                pDataParametersA[1].Value = pProcessConfigurationRegister_T01Entity.USER_CODE;
                pDataParametersA[2].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE;
                pDataParametersA[3].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_NAME;
                pDataParametersA[4].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_VEND_CODE;
                pDataParametersA[5].Value = pProcessConfigurationRegister_T01Entity.REVISION_NO;
                pDataParametersA[6].Value = pProcessConfigurationRegister_T01Entity.REMARK;
                pDataParametersA[7].Value = pProcessConfigurationRegister_T01Entity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T01_I10", pDataParametersA);

                pProcessConfigurationRegister_T01Entity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pProcessConfigurationRegister_T01Entity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pProcessConfigurationRegister_T01Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pProcessConfigurationRegister_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pProcessConfigurationRegister_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
                    "ProcessConfigurationRegister_T01_Info_MST_Save(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion

        #region MyRegion
        public DataTable ProcessConfigurationRegister_T01_Info_Main_MappingCheck(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegister_T01Entity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegister_T01Entity.CONFIGURATION_MST_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T01_R30", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ProcessConfigurationRegister_T01_Info_Main_MappingCheck(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)",
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
        public override ProcessConfigurationRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity = new ProcessConfigurationRegister_T01Entity();

                //pProductBOMRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProcessConfigurationRegister_T01Entity;
            }
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

    public class ProcessConfigurationRegister_T50Provider : EntityManager<ProcessConfigurationRegister_T50Entity>
    {
        #region 생성자 - ProcessConfigurationRegister_T50Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProcessConfigurationRegister_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 라우팅 리스트 조회하기 - ProcessConfigurationRegister_T50_Info_Main(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_T50_Info_Main(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)
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
                            new MySqlParameter("@v_configuration_mst_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_configuration_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_mst_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)

                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegister_T50Entity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegister_T50Entity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pProcessConfigurationRegister_T50Entity.CONFIGURATION_MST_NAME;
                pDataParameters[3].Value = pProcessConfigurationRegister_T50Entity.CONFIGURATION_NAME;
                pDataParameters[4].Value = pProcessConfigurationRegister_T50Entity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T50_R10", pDataParameters);

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
                    "ProcessConfigurationRegister_T50_Info_Main(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 공정 라우팅 마스터 정보 조회하기 - ProcessConfigurationRegister_T50_Info_Routing_MST(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_T50_Info_Routing_MST(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                            //new MySqlParameter("@v_configuration_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_configuration_mst_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_revision_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegister_T50Entity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegister_T50Entity.CONFIGURATION_MST_CODE;
                //pDataParameters[2].Value = pProcessConfigurationRegister_T50Entity.CONFIGURATION_NAME;
                pDataParameters[2].Value = pProcessConfigurationRegister_T50Entity.USE_YN;




                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T50_R20", pDataParameters);

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
                    "ProcessConfigurationRegister_T50_Info_Routing_MST(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 트리 리스트 공정 순서 신규용 조회하기 - ProcessConfigurationRegister_T50_Info_Routing_DETAIL(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessConfigurationRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ProcessConfigurationRegister_T50_Info_Routing_DETAIL(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_revision_no", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_configuration_mst_code",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_revision_no", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pProcessConfigurationRegister_T50Entity.CRUD;
                pDataParameters[1].Value = pProcessConfigurationRegister_T50Entity.CONFIGURATION_MST_CODE;
                pDataParameters[2].Value = pProcessConfigurationRegister_T50Entity.REVISION_NO;
                pDataParameters[3].Value = pProcessConfigurationRegister_T50Entity.USE_YN;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T50_R21", pDataParameters);

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
                    "ProcessConfigurationRegister_T50_Info_Routing_DETAIL(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ProcessConfigurationRegister_T50_Info_Save(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity, DataTable dtDetail, DataTable dtRouting)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pProcessConfigurationRegister_T50Entity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ProcessConfigurationRegister_T50_Info_Save(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity, DataTable dtDetail)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {
                pCount = dtDetail.Rows.Count;

                for (int a = 0; a < pCount; a++)
                {
                    IDataParameter[] pDataParametersA = null;

                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {
                                        new MySqlParameter("@V_configuration_mst_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@V_part_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@V_configuration_mst_name", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@V_configuration_name", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@V_use_yn", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@V_user_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@V_crud", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@V_configuration_seq", MySqlDbType.Int32),
                                        new MySqlParameter("@V_seq", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@V_process_group", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@V_process_gubun", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@V_process_name", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@V_equipment_group", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@V_remark", MySqlDbType.VarChar,50),

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {
                                //new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                //new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                //new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar,50),
                                //new SqlParameter("@v_configuration_mst_name", SqlDbType.NVarChar,100),
                                //new SqlParameter("@v_configuration_vend_code", SqlDbType.NVarChar,50),
                                //new SqlParameter("@v_revision_no", SqlDbType.NVarChar,50),
                                //new SqlParameter("@v_remark", SqlDbType.NVarChar,1000),
                                //new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                            };
                            break;
                    }

                    pDataParametersA[0].Value = pProcessConfigurationRegister_T50Entity.CONFIGURATION_MST_CODE;
                    pDataParametersA[1].Value = pProcessConfigurationRegister_T50Entity.PART_CODE;
                    pDataParametersA[2].Value = pProcessConfigurationRegister_T50Entity.CONFIGURATION_MST_NAME;
                    pDataParametersA[3].Value = pProcessConfigurationRegister_T50Entity.CONFIGURATION_NAME;
                    pDataParametersA[4].Value = pProcessConfigurationRegister_T50Entity.USE_YN;
                    pDataParametersA[5].Value = pProcessConfigurationRegister_T50Entity.USER_CODE;

                    pDataParametersA[6].Value = dtDetail.Rows[a]["CRUD"].ToString().ToUpper();//pProcessConfigurationRegister_T50Entity.CRUD;
                    pDataParametersA[7].Value = dtDetail.Rows[a]["CONFIGURATION_SEQ"].ToString().ToUpper() == "" ? 0 : Convert.ToInt32(dtDetail.Rows[a]["CONFIGURATION_SEQ"].ToString().ToUpper());//pProcessConfigurationRegister_T50Entity.CONFIGURATION_SEQ == "" ? 0 : Convert.ToInt32(pProcessConfigurationRegister_T50Entity.CONFIGURATION_SEQ);
                    pDataParametersA[8].Value = dtDetail.Rows[a]["SEQ"].ToString().ToUpper();//pProcessConfigurationRegister_T50Entity.SEQ;
                    pDataParametersA[9].Value = dtDetail.Rows[a]["PROCESS_GROUP"].ToString().ToUpper();//pProcessConfigurationRegister_T50Entity.PROCESS_GROUP;
                    pDataParametersA[10].Value = dtDetail.Rows[a]["PROCESS_GUBUN"].ToString().ToUpper();//pProcessConfigurationRegister_T50Entity.PROCESS_GUBUN;
                    pDataParametersA[11].Value = dtDetail.Rows[a]["PROCESS_NAME"].ToString().ToUpper();//pProcessConfigurationRegister_T50Entity.PROCESS_NAME;
                    pDataParametersA[12].Value = dtDetail.Rows[a]["EQUIPMENT_GROUP"].ToString().ToUpper(); //pProcessConfigurationRegister_T50Entity.EQUIPMENT_GROUP;
                    pDataParametersA[13].Value = dtDetail.Rows[a]["REMARK"].ToString().ToUpper(); 

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_routing_configuration_T50_I10", pDataParametersA);

                    pProcessConfigurationRegister_T50Entity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                    pProcessConfigurationRegister_T50Entity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                    pProcessConfigurationRegister_T50Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                    pProcessConfigurationRegister_T50Entity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                    pProcessConfigurationRegister_T50Entity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                        break;
                    }
                    else
                    {
                        pProcessConfigurationRegister_T50Entity.CONFIGURATION_MST_CODE = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "ProcessConfigurationRegister_T50_Info_Save(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity, DataTable dtDetail, DataTable dtRouting)",
                    pException
                );
            }
        

            return pErrorYN;
        }

        #endregion
        #region 마스터 정보 저장하기 - ProcessConfigurationRegister_T50_Info_MST_Save(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pProcessConfigurationRegister_T50Entity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool ProcessConfigurationRegister_T50_Info_MST_Save(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;

            try
            {
                IDataParameter[] pDataParametersA = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParametersA = new IDataParameter[]
                        {
                                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,20),
                                        new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_configuration_mst_name", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_configuration_vend_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_revision_no", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,20),
                                        new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_configuration_mst_name", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_configuration_vend_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_revision_no", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar,1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pProcessConfigurationRegister_T50Entity.CRUD;//vCRUD;
                pDataParametersA[1].Value = pProcessConfigurationRegister_T50Entity.USER_CODE;
                pDataParametersA[2].Value = pProcessConfigurationRegister_T50Entity.CONFIGURATION_MST_CODE;
                pDataParametersA[3].Value = pProcessConfigurationRegister_T50Entity.CONFIGURATION_MST_NAME;
                pDataParametersA[4].Value = pProcessConfigurationRegister_T50Entity.CONFIGURATION_VEND_CODE;
                pDataParametersA[5].Value = pProcessConfigurationRegister_T50Entity.REVISION_NO;
                pDataParametersA[6].Value = pProcessConfigurationRegister_T50Entity.REMARK;
                pDataParametersA[7].Value = pProcessConfigurationRegister_T50Entity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ProcessConfigurationRegister_T50_I10", pDataParametersA);

                pProcessConfigurationRegister_T50Entity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pProcessConfigurationRegister_T50Entity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pProcessConfigurationRegister_T50Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pProcessConfigurationRegister_T50Entity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pProcessConfigurationRegister_T50Entity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
                    "ProcessConfigurationRegister_T50_Info_MST_Save(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)",
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
        public override ProcessConfigurationRegister_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity = new ProcessConfigurationRegister_T50Entity();

                //pProductBOMRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pProcessConfigurationRegister_T50Entity;
            }
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


    public class DataDictionaryProvider : EntityManager<DataDictionaryEntity>
    {
        #region 생성자 - GridInfoRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public DataDictionaryProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Sample_Info_Mst(DataDictionaryEntity pDataDictionaryEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pDataDictionaryEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sample_Info_Mst(DataDictionaryEntity pDataDictionaryEntity)
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

                pDataParameters[0].Value = pDataDictionaryEntity.CRUD;
                pDataParameters[1].Value = pDataDictionaryEntity.LANGUAGE_TYPE;


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
                    "Sample_Info_Mst(DataDictionaryEntity pDataDictionaryEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - Sample_Info_Save(DataDictionaryEntity pDataDictionaryEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sample_Info_Save(DataDictionaryEntity pDataDictionaryEntity, DataTable dt)
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

                pDataParametersA[0].Value = pDataDictionaryEntity.CORP_CODE;
                pDataParametersA[1].Value = pDataDictionaryEntity.CRUD;
                pDataParametersA[2].Value = pDataDictionaryEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RuleDataDictionary_I10", pDataParametersA);

                pDataDictionaryEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pDataDictionaryEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pDataDictionaryEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pDataDictionaryEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pDataDictionaryEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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

                            pDataParametersB[0].Value = pDataDictionaryEntity.CORP_CODE;
                            pDataParametersB[1].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[2].Value = pDataDictionaryEntity.USER_CODE;

                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_GridInfoRegister_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pDataDictionaryEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pDataDictionaryEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pDataDictionaryEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pDataDictionaryEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pDataDictionaryEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sample_Info_Save(DataDictionaryEntity pDataDictionaryEntity, DataTable dt)",
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
        public override DataDictionaryEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                DataDictionaryEntity pDataDictionaryEntity = new DataDictionaryEntity();

                pDataDictionaryEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pDataDictionaryEntity;
            }
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

    public class RuleGeneratorProvider : EntityManager<RuleGeneratorEntity>
    {
        #region 생성자 - GridInfoRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public RuleGeneratorProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 룰 사전 조회하기 - RuleGenerator_Info_Mst(RuleGeneratorEntity pRuleGeneratorEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pRuleGeneratorEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Dictionary_Info_Mst(RuleGeneratorEntity pRuleGeneratorEntity)
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
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_option", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_option_rule", MySqlDbType.JSON),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_option", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_option_rule", SqlDbType.Text),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pRuleGeneratorEntity.CRUD;
                pDataParameters[1].Value = pRuleGeneratorEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pRuleGeneratorEntity.RULE_OPTION;
                pDataParameters[3].Value = pRuleGeneratorEntity.IF_RULE_OPTION;
                pDataParameters[4].Value = pRuleGeneratorEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DataDictionary_S", pDataParameters);

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
                    "PAC_Info_Mst(RuleGeneratorEntity pRuleGeneratorEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 룰 사전Sub 조회하기 - Dictionary_Info_Sub(RuleGeneratorEntity pRuleGeneratorEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pRuleGeneratorEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Dictionary_Info_Sub(RuleGeneratorEntity pRuleGeneratorEntity)
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
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_option", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_option", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pRuleGeneratorEntity.CRUD;
                pDataParameters[1].Value = pRuleGeneratorEntity.RESOURCE_CODE;
                pDataParameters[2].Value = pRuleGeneratorEntity.RULE_OPTION;
                pDataParameters[5].Value = pRuleGeneratorEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_DataDictionary_S2", pDataParameters);

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
                    "PAC_Info_Mst(RuleGeneratorEntity pRuleGeneratorEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 마스터 조회하기 - RuleGenerator_Info_Mst(RuleGeneratorEntity pRuleGeneratorEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pRuleGeneratorEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable RuleGenerator_Info_Mst(RuleGeneratorEntity pRuleGeneratorEntity)
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
                            new MySqlParameter("@v_workshop_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_workshop_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pRuleGeneratorEntity.CRUD;
                pDataParameters[1].Value = pRuleGeneratorEntity.WORKSHOP_CODE;
                pDataParameters[2].Value = pRuleGeneratorEntity.RESOURCE_CODE;
                pDataParameters[3].Value = pRuleGeneratorEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RuleGenerator_R20", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "PAC_Info_Mst(RuleGeneratorEntity pRuleGeneratorEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 - RuleGenerator_Info_Mst(RuleGeneratorEntity pRuleGeneratorEntity)(사용안함)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pRuleGeneratorEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable RuleGenerator_Info_SUB(RuleGeneratorEntity pRuleGeneratorEntity)
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
                            new MySqlParameter("@v_workshop_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_resource_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_value", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_workshop_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_resource_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_value", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pRuleGeneratorEntity.CORP_CODE;
                pDataParameters[1].Value = pRuleGeneratorEntity.WORKSHOP_NAME;
                pDataParameters[2].Value = pRuleGeneratorEntity.RESOURCE_NAME;
                pDataParameters[3].Value = pRuleGeneratorEntity.CONDITION_VALUE;
                pDataParameters[4].Value = pRuleGeneratorEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RuleCondition", pDataParameters);

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
                    "RuleGenerator_Info_SUB(RuleGeneratorEntity pRuleGeneratorEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - RuleGenerator_Info_Save(RuleGeneratorEntity pRuleGeneratorEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool RuleGenerator_Info_Save(RuleGeneratorEntity pRuleGeneratorEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            //int pCount = 0;

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
                                new MySqlParameter("@v_workshop_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_workshop_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_name", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_partcode", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_pgmcode", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_modelyear", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_if_rule", MySqlDbType.VarChar, 5000)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_workshop_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_workshop_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_partcode", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_pgmcode", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_modelyear", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_if_rule", SqlDbType.NVarChar, 5000)
                        };
                        break;
                }

                pDataParametersA[0].Value = pRuleGeneratorEntity.CRUD;
                pDataParametersA[1].Value = pRuleGeneratorEntity.WORKSHOP_CODE;
                pDataParametersA[2].Value = pRuleGeneratorEntity.WORKSHOP_NAME;
                pDataParametersA[3].Value = pRuleGeneratorEntity.RESOURCE_CODE;
                pDataParametersA[4].Value = pRuleGeneratorEntity.RESOURCE_NAME;
                pDataParametersA[5].Value = pRuleGeneratorEntity.PARTCODE;
                pDataParametersA[6].Value = pRuleGeneratorEntity.PGMCODE;
                pDataParametersA[7].Value = pRuleGeneratorEntity.MODELYEAR;
                pDataParametersA[8].Value = pRuleGeneratorEntity.RULE_DETAIL;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RuleGenerator_I10", pDataParametersA);

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

            return pErrorYN;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override RuleGeneratorEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                RuleGeneratorEntity pRuleGeneratorEntity = new RuleGeneratorEntity();

                //pRuleGeneratorEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pRuleGeneratorEntity;
            }
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

    public class RuleOptionSettingProvider : EntityManager<RuleOptionSettingEntity>
    {
        #region 생성자 - GridInfoRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public RuleOptionSettingProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - RuleGenerator_Info_Mst(RuleGeneratorEntity pRuleGeneratorEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pRuleGeneratorEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable RuleOptionSetting_Info_Mst(RuleOptionSettingEntity pRuleOptionSettingEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_component", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_component", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                //pDataParameters[0].Value = pRuleOptionSettingEntity.CRUD;
                pDataParameters[0].Value = pRuleOptionSettingEntity.COMPONENT;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RuleOptionInformation", pDataParameters);

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
                    "RuleOptionSetting_Info_Mst(RuleOptionSetting pRuleOptionSetting)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - RuleOptionSetting_Info_Save(RuleOptionSettingEntity pRuleOptionSettingEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool RuleOptionSetting_Info_Save(RuleOptionSettingEntity pRuleOptionSettingEntity, DataTable dt)
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
                                //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                                //new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                //new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                                //new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                //new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20)
                        };
                        break;
                }

                //pDataParametersA[0].Value = pDataDictionaryEntity.CORP_CODE;
                //pDataParametersA[1].Value = pDataDictionaryEntity.CRUD;
                //pDataParametersA[2].Value = pDataDictionaryEntity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_RuleDataDictionary_I10", pDataParametersA);

                //pDataDictionaryEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                //pDataDictionaryEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                //pDataDictionaryEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                //pDataDictionaryEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                //pDataDictionaryEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

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
                    "RuleOptionSetting_Info_Save(RuleOptionSettingEntity pRuleOptionSettingEntity, DataTable dt)",
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
        public override RuleOptionSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                RuleOptionSettingEntity pRuleOptionSettingEntity = new RuleOptionSettingEntity();

                //pRuleOptionSettingEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pRuleOptionSettingEntity;
            }
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

    public class ResourceCodeMstRegisterProvider : EntityManager<ResourceCodeMstRegisterEntity>
    {
        #region 생성자 - ResourceCodeMstRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ResourceCodeMstRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Resource_Info_Mst(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pResourceCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Resource_Info_Mst(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)
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
                            new MySqlParameter("@v_resource_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_resource_mst_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_resource_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_resource_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_resource_mst_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_resource_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pResourceCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pResourceCodeMstRegisterEntity.RESOURCE_MST_CODE;
                pDataParameters[2].Value = pResourceCodeMstRegisterEntity.RESOURCE_MST_NAME;
                pDataParameters[3].Value = pResourceCodeMstRegisterEntity.RESOURCE_TYPE;
                pDataParameters[4].Value = pResourceCodeMstRegisterEntity.MST_USE_YN;
                pDataParameters[5].Value = pResourceCodeMstRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResourceCodeMstRegister_R10", pDataParameters);

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
                    "Resource_Info_Mst(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 마스터 바인딩 조회하기 - Resource_Info_Mst(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pResourceCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Resource_Info_Binding(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_resource_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pResourceCodeMstRegisterEntity.RESOURCE_MST_CODE;
                pDataParameters[1].Value = pResourceCodeMstRegisterEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResourceCodeMstRegister_R11", pDataParameters);

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
                    "Resource_Info_Binding(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 센서 상세 조회하기 - Resource_Info_Detail(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)
        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pResourceCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Resource_Info_Detail(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_resource_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {

                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_resource_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pResourceCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pResourceCodeMstRegisterEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pResourceCodeMstRegisterEntity.RESOURCE_MST_CODE;
                pDataParameters[3].Value = pResourceCodeMstRegisterEntity.MST_USE_YN;



                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResourceCodeMstRegister_R20", pDataParameters);

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
                    "Resource_Info_Detail(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 센서 정보 저장하기 - Sensor_Resource_Info_Save(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Sensor_Resource_Info_Save(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity, DataTable dt)
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
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_mst_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_mst_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)

                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {

                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_mst_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_mst_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_resource_type", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;

                }

                pDataParametersA[0].Value = pResourceCodeMstRegisterEntity.CRUD;
                pDataParametersA[1].Value = pResourceCodeMstRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pResourceCodeMstRegisterEntity.LANGUAGE_TYPE;
                pDataParametersA[3].Value = pResourceCodeMstRegisterEntity.RESOURCE_MST_CODE;
                pDataParametersA[4].Value = pResourceCodeMstRegisterEntity.RESOURCE_MST_NAME;
                pDataParametersA[5].Value = pResourceCodeMstRegisterEntity.RESOURCE_TYPE;
                pDataParametersA[6].Value = pResourceCodeMstRegisterEntity.MST_REMARK;
                pDataParametersA[7].Value = pResourceCodeMstRegisterEntity.MST_USE_YN;


                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResourceCodeMstRegister_I10", pDataParametersA);

                pResourceCodeMstRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pResourceCodeMstRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pResourceCodeMstRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pResourceCodeMstRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["RTN_SEQ"].ToString();
                pResourceCodeMstRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();

                if (pDataTableA.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    if (pResourceCodeMstRegisterEntity.RESOURCE_MST_CODE == "")
                    {
                        pResourceCodeMstRegisterEntity.RESOURCE_MST_CODE = pResourceCodeMstRegisterEntity.RTN_KEY;
                    }

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
                                        new MySqlParameter("@v_resource_mst_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_resource_name", MySqlDbType.VarChar, 100),
                                        new MySqlParameter("@v_sensor_unit", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_sensor_type", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_iot_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_sensor_float_digit", MySqlDbType.Int32, 10),
                                        new MySqlParameter("@v_m_limit_low", MySqlDbType.Float),
                                        new MySqlParameter("@v_m_limit_high", MySqlDbType.Float),
                                        new MySqlParameter("@v_limit_low", MySqlDbType.Float),
                                        new MySqlParameter("@v_limit_high", MySqlDbType.Float),
                                        new MySqlParameter("@v_dsp_sort", MySqlDbType.Int32),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                                        new MySqlParameter("@v_resource_interval", MySqlDbType.VarChar, 20)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_resource_mst_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_resource_name", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@v_sensor_unit", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_sensor_type", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_iot_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_sensor_float_digit", SqlDbType.Int, 10),
                                        new SqlParameter("@v_m_limit_low", SqlDbType.Float),
                                        new SqlParameter("@v_m_limit_high", SqlDbType.Float),
                                        new SqlParameter("@v_limit_low", SqlDbType.Float),
                                        new SqlParameter("@v_limit_high", SqlDbType.Float),
                                        new SqlParameter("@v_dsp_sort", SqlDbType.Int),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                                        new SqlParameter("@v_resource_interval", SqlDbType.NVarChar, 20)
                                    };
                                    break;

                            }
                            pDataParametersB[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                            pDataParametersB[1].Value = pResourceCodeMstRegisterEntity.USER_CODE;
                            pDataParametersB[2].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["RESOURCE_MST_CODE"].ToString().Length > 0 ? dt.Rows[a]["RESOURCE_MST_CODE"].ToString().ToUpper() : pResourceCodeMstRegisterEntity.RESOURCE_MST_CODE);
                            pDataParametersB[3].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["RESOURCE_CODE"].ToString().ToUpper());
                            pDataParametersB[4].Value = CoFAS_ConvertManager.StringEmpty2DbNull(dt.Rows[a]["RESOURCE_NAME"].ToString().ToUpper());
                            pDataParametersB[5].Value = dt.Rows[a]["SENSOR_UNIT"].ToString().ToUpper();

                            pDataParametersB[6].Value = dt.Rows[a]["SENSOR_TYPE"].ToString().ToUpper();
                            
                            pDataParametersB[7].Value = dt.Rows[a]["IOT_CODE"].ToString().ToUpper();
                            pDataParametersB[8].Value = dt.Rows[a]["SENSOR_FLOAT_DIGIT"].ToString() == "" ? 0 : Convert.ToDouble(dt.Rows[a]["SENSOR_FLOAT_DIGIT"].ToString());
                            
                            pDataParametersB[9].Value = dt.Rows[a]["M_LIMIT_LOW"].ToString() == "" ? 0.00 : Convert.ToDouble(dt.Rows[a]["M_LIMIT_LOW"].ToString());
                            pDataParametersB[10].Value = dt.Rows[a]["M_LIMIT_HIGH"].ToString() == "" ? 0.00 : Convert.ToDouble(dt.Rows[a]["M_LIMIT_HIGH"].ToString());
                            pDataParametersB[11].Value = dt.Rows[a]["LIMIT_LOW"].ToString() == "" ? 0.00 : Convert.ToDouble(dt.Rows[a]["LIMIT_LOW"].ToString());
                            pDataParametersB[12].Value = dt.Rows[a]["LIMIT_HIGH"].ToString() == "" ? 0.00 : Convert.ToDouble(dt.Rows[a]["LIMIT_HIGH"].ToString());
                            pDataParametersB[13].Value = 0;//Convert.ToInt32(dt.Rows[a]["DSP_SORT"].ToString());

                            pDataParametersB[14].Value = dt.Rows[a]["REMARK"].ToString();
                            pDataParametersB[15].Value = dt.Rows[a]["USE_YN"].ToString().ToUpper();
                            pDataParametersB[16].Value = dt.Rows[a]["RESOURCE_INTERVAL"].ToString().ToUpper();






                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ResourceCodeMstRegister_I20", pDataParametersB);

                            if (pDataTableB.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }

                            pResourceCodeMstRegisterEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                            pResourceCodeMstRegisterEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();
                            pResourceCodeMstRegisterEntity.RTN_KEY = pDataTableB.Rows[0]["RTN_KEY"].ToString();
                            pResourceCodeMstRegisterEntity.RTN_SEQ = pDataTableB.Rows[0]["RTN_SEQ"].ToString();
                            pResourceCodeMstRegisterEntity.RTN_OTHERS = pDataTableB.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Sensor_Resource_Info_Save(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)",
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
        public override ResourceCodeMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity = new ResourceCodeMstRegisterEntity();

                //pVendorInformationEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pResourceCodeMstRegisterEntity;
            }
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

    public class BadCodeMstRegisterProvider : EntityManager<BadCodeMstRegisterEntity>
    {
        #region 생성자 - BadCodeMstRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public BadCodeMstRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 개체 구하기 - GetEntity(pdataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override BadCodeMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                BadCodeMstRegisterEntity pBadCodeMstRegisterEntity = new BadCodeMstRegisterEntity();

                return pBadCodeMstRegisterEntity;
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

        #region 마스터 조회하기 - BadCode_Info_Mst(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pBadCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BadCode_Info_Mst(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)
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
                            new MySqlParameter("@v_bad_group_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_bad_group_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_bad_group_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_bad_group_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;

                }
                pDataParameters[0].Value = pBadCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pBadCodeMstRegisterEntity.BAD_GROUP_CODE;
                pDataParameters[2].Value = pBadCodeMstRegisterEntity.BAD_GROUP_NAME;
                pDataParameters[3].Value = pBadCodeMstRegisterEntity.USE_YN;
                pDataParameters[4].Value = pBadCodeMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_BadCodeMstRegister_R10", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "BadCode_Info_Mst(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)",
                    pException
                );
            }
        }
        #endregion

        #region 마스터 바인딩 조회하기 - BadCode_Info_Mst_Binding(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BadCode_Info_Mst_Binding(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_bad_group_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_bad_group_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pBadCodeMstRegisterEntity.BAD_GROUP_CODE;
                pDataParameters[1].Value = pBadCodeMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_BadCodeMstRegister_R11", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "BadCode_Info_Mst_Binding(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 - BadCode_Info_Detail(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)
        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pBadCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BadCode_Info_Detail(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)
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
                            new MySqlParameter("@v_bad_group_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_bad_group_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pBadCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pBadCodeMstRegisterEntity.BAD_GROUP_CODE;
                pDataParameters[2].Value = pBadCodeMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_BadCodeMstRegister_R20", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "BadCode_Info_Detail(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)",
                    pException
                );
            }
        }
        #endregion

        #region 저장 - BadCode_Info_Save(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity, DataSet ds)
        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pBadCodeMstRegisterEntity"></param>
        /// <param name="ds"></param>
        /// <returns>저장 결과</returns>
        /// 
        public bool BadCode_Info_Save(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE

            try
            {
                _pDBManager.BeginTransaction();
                IDataParameter[] pDataParameters = null;
                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,100),
                        new MySqlParameter("@v_bad_group_code", MySqlDbType.VarChar,50),
                        new MySqlParameter("@v_bad_group_name", MySqlDbType.VarChar,100),
                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                        new SqlParameter("@v_bad_group_code", SqlDbType.NVarChar,50),
                        new SqlParameter("@v_bad_group_name", SqlDbType.NVarChar,100),
                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParameters[0].Value = pBadCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pBadCodeMstRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pBadCodeMstRegisterEntity.BAD_GROUP_CODE;
                pDataParameters[3].Value = pBadCodeMstRegisterEntity.BAD_GROUP_NAME;
                pDataParameters[4].Value = pBadCodeMstRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_BadCodeMstRegister_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    int dtCount = 0;
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
                                        new MySqlParameter("@v_bad_group_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_bad_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_bad_name", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParameters_detail = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_bad_group_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_bad_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_bad_name", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                                    };
                                    break;
                            }

                            pDataParameters_detail[0].Value = dt.Rows[i]["CRUD"].ToString();
                            pDataParameters_detail[1].Value = pBadCodeMstRegisterEntity.USER_CODE;
                            pDataParameters_detail[2].Value = pBadCodeMstRegisterEntity.BAD_GROUP_CODE;//dt.Rows[i]["BAD_GROUP_CODE"].ToString();
                            pDataParameters_detail[3].Value = dt.Rows[i]["BAD_CODE"].ToString();
                            pDataParameters_detail[4].Value = dt.Rows[i]["BAD_NAME"].ToString();
                            pDataParameters_detail[5].Value = dt.Rows[i]["USE_YN"].ToString();

                            DataTable pDataTable_sub = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_BadCodeMstRegister_I20", pDataParameters_detail);

                            if (pDataTable_sub.Rows[0][0].ToString() != "00")
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
                throw new ExceptionManager(this, "BadCode_Info_Save(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity, DataTable dt)", pException);
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

        #region 그리드 데이터 체크 dtcolCheck(DataTable dt, string colname)
        public bool dtcolCheck(DataTable dt, string colname)
        {
            if (dt.Columns.Contains(colname))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
    public class InspectCodeMstRegisterProvider : EntityManager<InspectCodeMstRegisterEntity>
    {
        #region 생성자 - InspectCodeMstRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public InspectCodeMstRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 개체 구하기 - GetEntity(pdataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override InspectCodeMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity = new InspectCodeMstRegisterEntity();

                return pInspectCodeMstRegisterEntity;
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

        #region 마스터 조회하기 - BadCode_Info_Mst(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pInspectCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Inspect_Info_Mst(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)
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
                            new MySqlParameter("@v_Inspect_group_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_Inspect_group_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_Inspect_group_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_Inspect_group_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;

                }
                pDataParameters[0].Value = pInspectCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pInspectCodeMstRegisterEntity.INSPECT_GROUP_CODE;
                pDataParameters[2].Value = pInspectCodeMstRegisterEntity.INSPECT_GROUP_NAME;
                pDataParameters[3].Value = pInspectCodeMstRegisterEntity.USE_YN;
                pDataParameters[4].Value = pInspectCodeMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectCodeMstRegister_R10", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Inspect_Info_Mst(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)",
                    pException
                );
            }
        }
        #endregion

        #region 마스터 바인딩 조회하기 - Inspect_Info_Mst_Binding(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProcessCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Inspect_Info_Mst_Binding(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_Inspect_group_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_Inspect_group_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pInspectCodeMstRegisterEntity.INSPECT_GROUP_CODE;
                pDataParameters[1].Value = pInspectCodeMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectCodeMstRegister_R11", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Inspect_Info_Mst_Binding(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 - Inspect_Info_Detail(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)
        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pInspectCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Inspect_Info_Detail(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)
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
                            new MySqlParameter("@v_Inspect_group_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_Inspect_group_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pInspectCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pInspectCodeMstRegisterEntity.INSPECT_GROUP_CODE;
                pDataParameters[2].Value = pInspectCodeMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectCodeMstRegister_R20", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Inspect_Info_Detail(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)",
                    pException
                );
            }
        }
        #endregion

        #region 저장 - Inspect_Info_Save(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity, DataSet ds)
        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pInspectCodeMstRegisterEntity"></param>
        /// <param name="ds"></param>
        /// <returns>저장 결과</returns>
        /// 
        public bool Inspect_Info_Save(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE

            try
            {
                _pDBManager.BeginTransaction();
                IDataParameter[] pDataParameters = null;
                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                        new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar,100),
                        new MySqlParameter("@v_Inspect_group_code", MySqlDbType.VarChar,50),
                        new MySqlParameter("@v_Inspect_group_name", MySqlDbType.VarChar,100),
                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,2000),
                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                        new SqlParameter("@v_Inspect_group_code", SqlDbType.NVarChar,50),
                        new SqlParameter("@v_Inspect_group_name", SqlDbType.NVarChar,100),
                        new SqlParameter("@v_remark", SqlDbType.NVarChar,2000),
                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }
                //시험코드정보 마스터 저장
                pDataParameters[0].Value = pInspectCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pInspectCodeMstRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pInspectCodeMstRegisterEntity.INSPECT_GROUP_CODE;
                pDataParameters[3].Value = pInspectCodeMstRegisterEntity.INSPECT_GROUP_NAME;
                pDataParameters[4].Value = pInspectCodeMstRegisterEntity.REMARK;
                pDataParameters[5].Value = pInspectCodeMstRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectCodeMstRegister_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    int dtCount = 0;
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
                                        new MySqlParameter("@v_inspect_group_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_inspect_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_inspect_name", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_inspect_value", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_remark", MySqlDbType.VarChar,2000),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParameters_detail = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_inspect_group_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_inspect_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_inspect_name", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_inspect_value", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar,2000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                                    };
                                    break;
                            }

                            pDataParameters_detail[0].Value = dt.Rows[i]["CRUD"].ToString();
                            pDataParameters_detail[1].Value = pInspectCodeMstRegisterEntity.USER_CODE;
                            if (pInspectCodeMstRegisterEntity.CRUD == "C")
                            {
                                pDataParameters_detail[2].Value = pDataTable.Rows[0]["rtn_key"].ToString();
                            }
                            else
                            {
                                pDataParameters_detail[2].Value = dt.Rows[i]["Inspect_GROUP_CODE"].ToString();
                            }

                            pDataParameters_detail[3].Value = dt.Rows[i]["Inspect_CODE"].ToString();
                            pDataParameters_detail[4].Value = dt.Rows[i]["Inspect_NAME"].ToString();
                            pDataParameters_detail[5].Value = dt.Rows[i]["Inspect_VALUE"].ToString();
                            pDataParameters_detail[6].Value = dt.Rows[i]["REMARK"].ToString();
                            pDataParameters_detail[7].Value = dt.Rows[i]["USE_YN"].ToString();

                            DataTable pDataTable_sub = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectCodeMstRegister_I20", pDataParameters_detail);

                            if (pDataTable_sub.Rows[0][0].ToString() != "00")
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
                throw new ExceptionManager(this, "Inspect_Info_Save(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity, DataTable dt)", pException);
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

        #region 그리드 데이터 체크 dtcolCheck(DataTable dt, string colname)
        public bool dtcolCheck(DataTable dt, string colname)
        {
            if (dt.Columns.Contains(colname))
            {
                return true;
            }
            return false;
        }
        #endregion
    }

    public class EquipmentStopCodeMstRegisterProvider : EntityManager<EquipmentStopCodeMstRegisterEntity>
    {
        #region 생성자 - EquipmentStopCodeMstRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public EquipmentStopCodeMstRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 개체 구하기 - GetEntity(pdataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override EquipmentStopCodeMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity = new EquipmentStopCodeMstRegisterEntity();

                return pEquipmentStopCodeMstRegisterEntity;
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

        #region 마스터 조회하기 - Equip_Stop_Info_Mst(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentStopCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Equip_Stop_Info_Mst(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)
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
                            new MySqlParameter("@v_equip_stop_group_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_equip_stop_group_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_equip_stop_group_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_equip_stop_group_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;

                }
                pDataParameters[0].Value = pEquipmentStopCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pEquipmentStopCodeMstRegisterEntity.EQUIPMENT_STOP_GROUP_CODE;
                pDataParameters[2].Value = pEquipmentStopCodeMstRegisterEntity.EQUIPMENT_STOP_GROUP_NAME;
                pDataParameters[3].Value = pEquipmentStopCodeMstRegisterEntity.USE_YN;
                pDataParameters[4].Value = pEquipmentStopCodeMstRegisterEntity.LANGUAGE_TYPE;
                
                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipStopCodeMstRegister_R10", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Equip_Stop_Info_Mst(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 마스터 바인딩 조회하기 - Equip_Stop_Info_Mst_binding(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentStopCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Equip_Stop_Info_Mst_binding(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_equip_stop_group_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_equip_stop_group_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentStopCodeMstRegisterEntity.EQUIPMENT_STOP_GROUP_CODE;
                pDataParameters[1].Value = pEquipmentStopCodeMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipStopCodeMstRegister_R11", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Equip_Stop_Info_Mst_binding(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 - Equip_Stop_Info_Detail(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)
        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentStopCodeMstRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Equip_Stop_Info_Detail(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)
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
                            new MySqlParameter("@v_equip_stop_group_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_equip_stop_group_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pEquipmentStopCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pEquipmentStopCodeMstRegisterEntity.EQUIPMENT_STOP_GROUP_CODE;
                pDataParameters[2].Value = pEquipmentStopCodeMstRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipStopCodeMstRegister_R20", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Equip_Stop_Info_Detail(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)",
                    pException
                );
            }
        }
        #endregion

        #region 저장 - Equip_Stop_Info_Save(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity, DataSet ds)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pEquipmentStopCodeMstRegisterEntity"></param>
        /// <param name="ds"></param>
        /// <returns>저장 결과</returns>
        /// 
        public bool Equip_Stop_Info_Save(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE

            try
            {
                _pDBManager.BeginTransaction();
                IDataParameter[] pDataParameters = null;
                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                            new MySqlParameter("@v_user_code", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_equipment_stop_group_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_equipment_stop_group_name", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_equipment_stop_group_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_equipment_stop_group_name", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParameters[0].Value = pEquipmentStopCodeMstRegisterEntity.CRUD;
                pDataParameters[1].Value = pEquipmentStopCodeMstRegisterEntity.USER_CODE;
                pDataParameters[2].Value = pEquipmentStopCodeMstRegisterEntity.EQUIPMENT_STOP_GROUP_CODE;
                pDataParameters[3].Value = pEquipmentStopCodeMstRegisterEntity.EQUIPMENT_STOP_GROUP_NAME;
                pDataParameters[4].Value = pEquipmentStopCodeMstRegisterEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipStopCodeMstRegister_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    int dtCount = 0;
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
                                        new MySqlParameter("@v_equipment_stop_group_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_equipment_stop_code", MySqlDbType.VarChar,50),
                                        new MySqlParameter("@v_equipment_stop_name", MySqlDbType.VarChar,100),
                                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParameters_detail = new IDataParameter[]
                                    {
                                        new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                                        new SqlParameter("@v_user_code", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_equipment_stop_group_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_equipment_stop_code", SqlDbType.NVarChar,50),
                                        new SqlParameter("@v_equipment_stop_name", SqlDbType.NVarChar,100),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                                    };
                                    break;
                            }
                            pDataParameters_detail[0].Value = dt.Rows[i]["CRUD"].ToString();
                            pDataParameters_detail[1].Value = pEquipmentStopCodeMstRegisterEntity.USER_CODE;
                            pDataParameters_detail[2].Value = pEquipmentStopCodeMstRegisterEntity.EQUIPMENT_STOP_GROUP_CODE;
                            pDataParameters_detail[3].Value = dt.Rows[i]["EQUIPMENT_STOP_CODE"].ToString();
                            pDataParameters_detail[4].Value = dt.Rows[i]["EQUIPMENT_STOP_NAME"].ToString();
                            pDataParameters_detail[5].Value = dt.Rows[i]["USE_YN"].ToString();

                            DataTable pDataTable_sub = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipStopCodeMstRegister_I20", pDataParameters_detail);

                            if (pDataTable_sub.Rows[0][0].ToString() != "00")
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
                throw new ExceptionManager(this, "Equip_Stop_Info_Save(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity,  DataTable dt)", pException);
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

        #region 그리드 데이터 체크 dtcolCheck(DataTable dt, string colname)
        public bool dtcolCheck(DataTable dt, string colname)
        {
            if (dt.Columns.Contains(colname))
            {
                return true;
            }
            return false;
        }
        #endregion
    }

    public class InspectPartMappingRegisterProvider : EntityManager<InspectPartMappingRegisterEntity>
    {
        #region ○ 생성자

        public InspectPartMappingRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        public override InspectPartMappingRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                InspectPartMappingRegisterEntity pInspectPartMappingRegisterEntity = new InspectPartMappingRegisterEntity();

                return pInspectPartMappingRegisterEntity;
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

        #region ○ 품목조회

        public DataTable InspectPart_Info_Mst(InspectPartMappingRegisterEntity pInspectPartMappingRegister)
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
                            new MySqlParameter("@v_part_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_vend_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;

                }
                pDataParameters[0].Value = pInspectPartMappingRegister.CRUD;
                pDataParameters[1].Value = pInspectPartMappingRegister.PART_TYPE;
                pDataParameters[2].Value = pInspectPartMappingRegister.PART_NAME;
                pDataParameters[3].Value = pInspectPartMappingRegister.VEND_PART_CODE;
                pDataParameters[4].Value = pInspectPartMappingRegister.USE_YN;
                pDataParameters[5].Value = pInspectPartMappingRegister.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectPartMappingRegister_R10", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "InspectPart_Info_Mst(InspectPartMappingRegisterEntity pInspectPartMappingRegister)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 시험검사코드 조회

        public DataTable InspectPart_Info_Sub1(InspectPartMappingRegisterEntity pInspectPartMappingRegister)
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
                            new MySqlParameter("@v_part_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.VarChar, 50)
                        };
                        break;

                }
                pDataParameters[0].Value = pInspectPartMappingRegister.CRUD;
                pDataParameters[1].Value = pInspectPartMappingRegister.PART_TYPE;
                pDataParameters[2].Value = pInspectPartMappingRegister.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectPartMappingRegister_R20", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "InspectPart_Info_Sub1(InspectPartMappingRegisterEntity pInspectPartMappingRegister)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 품목별시험검사코드 조회

        public DataTable InspectPart_Info_Sub2(InspectPartMappingRegisterEntity pInspectPartMappingRegister)
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
                            new MySqlParameter("@v_part_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;

                }
                pDataParameters[0].Value = pInspectPartMappingRegister.CRUD;
                pDataParameters[1].Value = pInspectPartMappingRegister.PART_TYPE;
                pDataParameters[2].Value = pInspectPartMappingRegister.PART_CODE;
                pDataParameters[3].Value = pInspectPartMappingRegister.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectPartMappingRegister_R30", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "InspectPart_Info_Sub2(InspectPartMappingRegisterEntity pInspectPartMappingRegister)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 품목별시험검사항목 저장

        public bool InspectPart_Info_Save(InspectPartMappingRegisterEntity pInspectPartMappingRegisterEntity, DataTable pDataTable)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE

            try
            {
                _pDBManager.BeginTransaction();
                IDataParameter[] pDataParameters = null;
                DataTable qDataTable = null;

                int pDataTableCount = 0;
                if (pDataTable != null)
                {
                    pDataTableCount = pDataTable.Rows.Count;
                    for(int i = 0; i < pDataTableCount; i++)
                    {
                        if(pDataTable.Rows[i]["CRUD"].ToString() != "")
                        {
                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParameters = new IDataParameter[]
                                    {
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_part_type", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 15),
                                    new MySqlParameter("@v_inspect_code", MySqlDbType.VarChar,15),
                                    new MySqlParameter("@v_remark", MySqlDbType.VarChar, 2000),
                                    new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParameters = new IDataParameter[]
                                    {
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_part_type", SqlDbType.NVarChar, 15),
                                    new SqlParameter("@v_part_code", SqlDbType.NVarChar, 15),
                                    new SqlParameter("@v_inspect_code", SqlDbType.NVarChar, 100),
                                    new SqlParameter("@v_remark", SqlDbType.NVarChar, 2000),
                                    new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            pDataParameters[0].Value = pDataTable.Rows[i]["CRUD"].ToString();
                            pDataParameters[1].Value = pInspectPartMappingRegisterEntity.USER_CODE;
                            pDataParameters[2].Value = pDataTable.Rows[i]["PART_TYPE"].ToString();
                            pDataParameters[3].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                            pDataParameters[4].Value = pDataTable.Rows[i]["INSPECT_CODE"].ToString();
                            pDataParameters[5].Value = pDataTable.Rows[i]["REMARK"].ToString();
                            pDataParameters[6].Value = "Y";

                            qDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectPartMappingRegister_I10", pDataParameters);

                            if (qDataTable.Rows[0][0].ToString() != "00")
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
                throw new ExceptionManager(this, "InspectPart_Info_Save(InspectPartMappingRegisterEntity pInspectPartMappingRegisterEntity, DataTable pDataTable)", pException);
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
    }
    public class PartInformationMappingRegisterProvider : EntityManager<PartInformationMappingRegisterEntity>
    {
        #region ○ 생성자

        public PartInformationMappingRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        public override PartInformationMappingRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                PartInformationMappingRegisterEntity pPartInformationMappingRegisterEntity = new PartInformationMappingRegisterEntity();

                return pPartInformationMappingRegisterEntity;
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

        #region ○ 품목조회

        public DataTable InspectPart_Info_Mst(PartInformationMappingRegisterEntity pPartInformationMappingRegister)
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
                            new MySqlParameter("@v_part_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_vend_part_code",    SqlDbType.NVarChar, 50)
                        };
                        break;

                }
                pDataParameters[0].Value = pPartInformationMappingRegister.CRUD;
                pDataParameters[1].Value = pPartInformationMappingRegister.PART_TYPE;
                pDataParameters[2].Value = pPartInformationMappingRegister.PART_NAME;
                pDataParameters[3].Value = pPartInformationMappingRegister.USE_YN;
                pDataParameters[4].Value = pPartInformationMappingRegister.LANGUAGE_TYPE;
                pDataParameters[5].Value = pPartInformationMappingRegister.VEND_PART_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_PartInformationMappingRegister_R10", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "InspectPart_Info_Mst(PartInformationMappingRegisterEntity pPartInformationMappingRegister)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 시험검사코드 조회

        public DataTable InspectPart_Info_Sub1(PartInformationMappingRegisterEntity pPartInformationMappingRegister)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_menu_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_part_code",    SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name",    SqlDbType.VarChar, 50),
                            new SqlParameter("@v_menu_type",    SqlDbType.VarChar, 50)
                        };
                        break;

                }
                pDataParameters[0].Value = pPartInformationMappingRegister.CRUD;
                pDataParameters[1].Value = pPartInformationMappingRegister.PART_CODE;
                pDataParameters[2].Value = pPartInformationMappingRegister.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPartInformationMappingRegister.VEND_PART_CODE;
                pDataParameters[4].Value = pPartInformationMappingRegister.PART_NAME;
                pDataParameters[5].Value = pPartInformationMappingRegister.MENU_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_PartInformationMappingRegister_R20", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "InspectPart_Info_Sub1(PartInformationMappingRegisterEntity pPartInformationMappingRegister)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 품목별시험검사코드 조회

        public DataTable InspectPart_Info_Sub2(PartInformationMappingRegisterEntity pPartInformationMappingRegister)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_vend_part_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_menu_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.VarChar, 50),
                            new SqlParameter("@v_vend_part_code",    SqlDbType.VarChar, 50),
                            new SqlParameter("@v_part_name",    SqlDbType.VarChar, 50),
                            new SqlParameter("@v_menu_type",    SqlDbType.VarChar, 50)
                        };
                        break;

                }
                pDataParameters[0].Value = pPartInformationMappingRegister.CRUD;
                pDataParameters[1].Value = pPartInformationMappingRegister.PART_CODE;
                pDataParameters[2].Value = pPartInformationMappingRegister.LANGUAGE_TYPE;
                pDataParameters[3].Value = pPartInformationMappingRegister.VEND_PART_CODE;
                pDataParameters[4].Value = pPartInformationMappingRegister.PART_NAME;
                pDataParameters[5].Value = pPartInformationMappingRegister.MENU_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_PartInformationMappingRegister_R20", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "InspectPart_Info_Sub2(PartInformationMappingRegisterEntity pPartInformationMappingRegister)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 품목별시험검사항목 저장

        public bool InspectPart_Info_Save(PartInformationMappingRegisterEntity pPartInformationMappingRegisterEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
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
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 10),
                                    new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 10),
                                    new MySqlParameter("@v_routing_mst_code", MySqlDbType.VarChar, 10),
                                    new MySqlParameter("@v_process_value", MySqlDbType.VarChar,5000),
                                    new MySqlParameter("@v_menu_type", MySqlDbType.VarChar, 10),
                                    new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),
                                    new MySqlParameter("@v_work_remark", MySqlDbType.VarChar,200),
                                    new MySqlParameter("@v_out_box", MySqlDbType.VarChar,500),
                                    new MySqlParameter("@v_in_box", MySqlDbType.VarChar,500),
                                    new MySqlParameter("@v_qa_qty", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_vend_qty", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_mesh", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_position", MySqlDbType.VarChar,100),
                                    new MySqlParameter("@v_remark", MySqlDbType.VarChar,1000)
                                    
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParameters = new IDataParameter[]
                                    {
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_process_code", SqlDbType.NVarChar, 10),
                                    new SqlParameter("@v_routing_mst_code", SqlDbType.NVarChar, 10),
                                    new SqlParameter("@v_process_value", SqlDbType.NVarChar, 5000),
                                    new SqlParameter("@v_menu_type", SqlDbType.NVarChar, 10),
                                    new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                                    new SqlParameter("@v_work_remark", SqlDbType.NVarChar, 2000),
                                    new SqlParameter("@v_out_box", SqlDbType.NVarChar, 500),
                                    new SqlParameter("@v_in_box", SqlDbType.NVarChar, 500),
                                    new SqlParameter("@v_qa_qty", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_vend_qty", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_mesh", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_position", SqlDbType.NVarChar, 100),
                                    new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000)
                                    };
                                    break;
                            }

                            pDataParameters[0].Value = pPartInformationMappingRegisterEntity.CRUD;
                            pDataParameters[1].Value = pPartInformationMappingRegisterEntity.USER_CODE;
                            pDataParameters[2].Value = pPartInformationMappingRegisterEntity.PROCESS_CODE;
                            pDataParameters[3].Value = pPartInformationMappingRegisterEntity.ROUTING_MST_CODE;
                            pDataParameters[4].Value = pPartInformationMappingRegisterEntity.PROCESS_VALUE;
                            pDataParameters[5].Value = pPartInformationMappingRegisterEntity.MENU_TYPE;
                            pDataParameters[6].Value = pPartInformationMappingRegisterEntity.USE_YN;
                            pDataParameters[7].Value = pPartInformationMappingRegisterEntity.WORK_REMARK;
                            pDataParameters[8].Value = pPartInformationMappingRegisterEntity.OUT_BOX;
                             pDataParameters[9].Value = pPartInformationMappingRegisterEntity.IN_BOX;
                            pDataParameters[10].Value = pPartInformationMappingRegisterEntity.QA_QTY;
                            pDataParameters[11].Value = pPartInformationMappingRegisterEntity.VEND_QTY;
                            pDataParameters[12].Value = pPartInformationMappingRegisterEntity.MESH;
                            pDataParameters[13].Value = pPartInformationMappingRegisterEntity.PART_CODE;
                            pDataParameters[14].Value = pPartInformationMappingRegisterEntity.POSITION;
                            pDataParameters[15].Value = pPartInformationMappingRegisterEntity.REMARK;

                DataTable qDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_PartInformationMappingRegister_I10", pDataParameters);

                            if (qDataTable.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                pPartInformationMappingRegisterEntity.ERR_NO = qDataTable.Rows[0]["err_no"].ToString();
                pPartInformationMappingRegisterEntity.ERR_MSG = qDataTable.Rows[0]["err_msg"].ToString();
                pPartInformationMappingRegisterEntity.RTN_KEY = qDataTable.Rows[0]["rtn_key"].ToString();
                pPartInformationMappingRegisterEntity.RTN_SEQ = qDataTable.Rows[0]["rtn_sq"].ToString();
                pPartInformationMappingRegisterEntity.RTN_OTHERS = qDataTable.Rows[0]["rtn_others"].ToString();
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                pErrorYN = true;
                throw new ExceptionManager(this, "InspectPart_Info_Save(PartInformationMappingRegisterEntity pPartInformationMappingRegisterEntity, DataTable pDataTable)", pException);
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
    }
    public class ucPartProcessMapping_PopUpProvider : EntityManager<ucPartProcessMapping_PopUpEntity>
    {
        #region ○ 생성자

        public ucPartProcessMapping_PopUpProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        public override ucPartProcessMapping_PopUpEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucPartProcessMapping_PopUpEntity pucPartProcessMapping_PopUpEntity = new ucPartProcessMapping_PopUpEntity();

                return pucPartProcessMapping_PopUpEntity;
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

        #region ○ 품목조회

        public DataTable PartProcessMapping_Info_MST(ucPartProcessMapping_PopUpEntity pucPartProcessMapping_PopUpEntity)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                        };
                        break;

                }
                pDataParameters[0].Value = pucPartProcessMapping_PopUpEntity.CRUD;
                pDataParameters[1].Value = pucPartProcessMapping_PopUpEntity.PART_CODE;
                pDataParameters[2].Value = pucPartProcessMapping_PopUpEntity.PART_NAME;
                pDataParameters[3].Value = pucPartProcessMapping_PopUpEntity.CONFIGURATION_MST_CODE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucPartProcessMapping_PopUp_R10", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "PartProcessMapping_Info_MST(ucPartProcessMapping_PopUpEntity pucPartProcessMapping_PopUpEntity)",
                    pException
                );
            }
        }

        #endregion
        // PartProcessMapping_Info_Save
        #region ○ 품목별 라우팅 항목 저장

        public bool PartProcessMapping_Info_Save(ucPartProcessMapping_PopUpEntity pucPartProcessMapping_PopUpEntity, DataTable pDataTable)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            string sCRUD = "";
            try
            {
               
                IDataParameter[] pDataParameters = null;
                DataTable qDataTable = null;
                _pDBManager.BeginTransaction();

                int pDataTableCount = 0;
                if (pDataTable != null)
                {
                    pDataTableCount = pDataTable.Rows.Count;
                    for (int i = 0; i < pDataTableCount; i++)
                    {
                        if (pDataTable.Rows[i]["CRUD"].ToString() != "")
                        {
                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParameters = new IDataParameter[]
                                    {
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_dsp_sort", MySqlDbType.Int32),
                                    new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                    new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParameters = new IDataParameter[]
                                    {
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_dsp_sort", SqlDbType.Int),
                                    new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                    new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            if(pDataTable.Rows[i]["PART_CHECK"].ToString() == "Y" && pDataTable.Rows[i]["USED_CONFIGURATION"].ToString() == "N")
                            {
                                sCRUD = "C";
                            }
                            else if(pDataTable.Rows[i]["PART_CHECK"].ToString() == "N" && pDataTable.Rows[i]["USED_CONFIGURATION"].ToString() == "Y")
                            {
                                sCRUD = "U";
                            }
                            else
                            {
                                sCRUD = "";
                            }

                            pDataParameters[0].Value = sCRUD; // pDataTable.Rows[i]["PART_CHECK"].ToString() == "Y" ? "C":"U";
                            pDataParameters[1].Value = pucPartProcessMapping_PopUpEntity.USER_CODE;
                            pDataParameters[2].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                            pDataParameters[3].Value = pucPartProcessMapping_PopUpEntity.CONFIGURATION_MST_CODE;
                            pDataParameters[4].Value = i+1;
                            pDataParameters[5].Value = "";
                            pDataParameters[6].Value = pDataTable.Rows[i]["PART_CHECK"].ToString();

                            qDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucPartProcessMapping_PopUp_I10", pDataParameters);

                            if (qDataTable.Rows[0][0].ToString() != "00")
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
                throw new ExceptionManager(this, "PartProcessMapping_Info_Save(ucPartProcessMapping_PopUpEntity pucPartProcessMapping_PopUpEntity, DataTable pDataTable)", pException);
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

    }

    public class ucPartProcessMapping_PopUp_T01Provider : EntityManager<ucPartProcessMapping_PopUp_T01Entity>
    {
        #region ○ 생성자

        public ucPartProcessMapping_PopUp_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        public override ucPartProcessMapping_PopUp_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucPartProcessMapping_PopUp_T01Entity pucPartProcessMapping_PopUp_T01Entity = new ucPartProcessMapping_PopUp_T01Entity();

                return pucPartProcessMapping_PopUp_T01Entity;
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

        #region ○ 품목조회

        public DataTable PartProcessMapping_Info_MST(ucPartProcessMapping_PopUp_T01Entity pucPartProcessMapping_PopUp_T01Entity)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_high", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_middle", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_part_low", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_high", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_middle", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_part_low", SqlDbType.NVarChar, 50)
                        };
                        break;

                }
                pDataParameters[0].Value = pucPartProcessMapping_PopUp_T01Entity.CRUD;
                pDataParameters[1].Value = pucPartProcessMapping_PopUp_T01Entity.PART_CODE;
                pDataParameters[2].Value = pucPartProcessMapping_PopUp_T01Entity.PART_NAME;
                pDataParameters[3].Value = pucPartProcessMapping_PopUp_T01Entity.CONFIGURATION_MST_CODE;
                pDataParameters[4].Value = pucPartProcessMapping_PopUp_T01Entity.PART_HIGH;
                pDataParameters[5].Value = pucPartProcessMapping_PopUp_T01Entity.PART_MIDDLE;
                pDataParameters[6].Value = pucPartProcessMapping_PopUp_T01Entity.PART_LOW;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucPartProcessMapping_PopUp_T01_R10", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "PartProcessMapping_Info_MST(ucPartProcessMapping_PopUp_T01Entity pucPartProcessMapping_PopUp_T01Entity)",
                    pException
                );
            }
        }

        #endregion
        // PartProcessMapping_Info_Save
        #region ○ 품목별 라우팅 항목 저장

        public bool PartProcessMapping_Info_Save(ucPartProcessMapping_PopUp_T01Entity pucPartProcessMapping_PopUp_T01Entity, DataTable pDataTable)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            string sCRUD = "";
            try
            {

                IDataParameter[] pDataParameters = null;
                DataTable qDataTable = null;
                _pDBManager.BeginTransaction();

                int pDataTableCount = 0;
                if (pDataTable != null)
                {
                    pDataTableCount = pDataTable.Rows.Count;
                    for (int i = 0; i < pDataTableCount; i++)
                    {
                        if (pDataTable.Rows[i]["CRUD"].ToString() != "")
                        {
                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParameters = new IDataParameter[]
                                    {
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_part_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_dsp_sort", MySqlDbType.Int32),
                                    new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                                    new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParameters = new IDataParameter[]
                                    {
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_dsp_sort", SqlDbType.Int),
                                    new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                    new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            if (pDataTable.Rows[i]["PART_CHECK"].ToString() == "Y" && pDataTable.Rows[i]["USED_CONFIGURATION"].ToString() == "N")
                            {
                                sCRUD = "C";
                            }
                            else if (pDataTable.Rows[i]["PART_CHECK"].ToString() == "N" && pDataTable.Rows[i]["USED_CONFIGURATION"].ToString() == "Y")
                            {
                                sCRUD = "U";
                            }
                            else
                            {
                                sCRUD = "";
                            }

                            pDataParameters[0].Value = sCRUD; // pDataTable.Rows[i]["PART_CHECK"].ToString() == "Y" ? "C":"U";
                            pDataParameters[1].Value = pucPartProcessMapping_PopUp_T01Entity.USER_CODE;
                            pDataParameters[2].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                            pDataParameters[3].Value = pucPartProcessMapping_PopUp_T01Entity.CONFIGURATION_MST_CODE;
                            pDataParameters[4].Value = i + 1;
                            pDataParameters[5].Value = "";
                            pDataParameters[6].Value = pDataTable.Rows[i]["PART_CHECK"].ToString();

                            qDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucPartProcessMapping_PopUp_T01_I10", pDataParameters);

                            if (qDataTable.Rows[0][0].ToString() != "00")
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
                throw new ExceptionManager(this, "PartProcessMapping_Info_Save(ucPartProcessMapping_PopUp_T01Entity pucPartProcessMapping_PopUp_T01Entity, DataTable pDataTable)", pException);
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

    }

    public class LabelCodeRegisterProvider : EntityManager<LabelCodeRegisterEntity>
    {
        #region 생성자 - LabelCodeRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public LabelCodeRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        
        #region 마스터 조회하기 - LabelCodeRegister_Info_Mst(LabelCodeRegisterEntity pLabelCodeRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pLabelCodeRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable LabelCodeRegister_Info_Mst(LabelCodeRegisterEntity pLabelCodeRegisterEntity)
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
                            new MySqlParameter("@v_print_code", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_print_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_print_code", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_print_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 20),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pLabelCodeRegisterEntity.CRUD;
                pDataParameters[1].Value = pLabelCodeRegisterEntity.LABEL_CODE;
                pDataParameters[2].Value = pLabelCodeRegisterEntity.LABEL_NAME;
                pDataParameters[3].Value = pLabelCodeRegisterEntity.PROCESS_CODE;
                pDataParameters[4].Value = pLabelCodeRegisterEntity.TERMINAL_CODE;
                pDataParameters[5].Value = pLabelCodeRegisterEntity.USE_YN;
                pDataParameters[6].Value = pLabelCodeRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_LabelCodeRegister_R10", pDataParameters);

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

        #region 정보 저장하기 - LabelCodeRegister_Info_Save(LabelCodeRegisterEntity pMaterialOrderStatusEntity, DataTable dt)       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool LabelCodeRegister_Info_Save(LabelCodeRegisterEntity pLabelCodeRegisterEntity)
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
                                new MySqlParameter("@v_print_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_print_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_print_cmd", MySqlDbType.VarChar, 3000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_print_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_print_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_process_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_print_cmd", SqlDbType.NVarChar, 3000),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pLabelCodeRegisterEntity.CRUD;
                pDataParametersA[1].Value = pLabelCodeRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pLabelCodeRegisterEntity.LABEL_CODE;
                pDataParametersA[3].Value = pLabelCodeRegisterEntity.LABEL_NAME;
                pDataParametersA[4].Value = pLabelCodeRegisterEntity.PROCESS_CODE;
                pDataParametersA[5].Value = pLabelCodeRegisterEntity.TERMINAL_CODE;
                pDataParametersA[6].Value = pLabelCodeRegisterEntity.CMD;
                pDataParametersA[7].Value = pLabelCodeRegisterEntity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_LabelCodeRegister_I10", pDataParametersA);

                pLabelCodeRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pLabelCodeRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pLabelCodeRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pLabelCodeRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "LabelCodeRegister_Info_Save(LabelCodeRegisterEntity pLabelCodeRegisterEntity, DataTable dt)",
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
        public override LabelCodeRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                LabelCodeRegisterEntity pLabelCodeRegisterEntity = new LabelCodeRegisterEntity();

                //pLabelCodeRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pLabelCodeRegisterEntity;
            }
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

    public class BarcodePrintRegisterProvider : EntityManager<BarcodePrintRegisterEntity>
    {
        #region 생성자 - BarcodePrintRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public BarcodePrintRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        
        #region 마스터 조회하기 - BarcodePrintRegister_Info_Mst(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pBarcodePrintRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BarcodePrintRegister_Info_Mst(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)
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
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_print_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
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
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_print_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pBarcodePrintRegisterEntity.CRUD;
                pDataParameters[1].Value = pBarcodePrintRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pBarcodePrintRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pBarcodePrintRegisterEntity.PART_CODE;
                pDataParameters[4].Value = pBarcodePrintRegisterEntity.PART_NAME;
                pDataParameters[5].Value = pBarcodePrintRegisterEntity.PRINT_CODE;
                pDataParameters[6].Value = pBarcodePrintRegisterEntity.USE_YN;
                pDataParameters[7].Value = pBarcodePrintRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R20", pDataParameters);

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

        #region 바코드 CMD 조회하기 - BarcodePrintRegister_Info(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pBarcodePrintRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BarcodePrintRegister_Info(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)
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
                
                pDataParameters[0].Value = pBarcodePrintRegisterEntity.PRINT_CODE;
                pDataParameters[1].Value = pBarcodePrintRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_R30", pDataParameters);

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

        #region 터미널 정보 조회하기 - BarcodePrintRegister_Info_sub(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pBarcodePrintRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BarcodePrintRegister_Info_sub(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)
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

                pDataParameters[0].Value = pBarcodePrintRegisterEntity.TERMINAL_NAME;
                pDataParameters[1].Value = pBarcodePrintRegisterEntity.LANGUAGE_TYPE;

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

        #region 업체 번호 조회하기 - BarcodePrintRegister_Vend_Info(string partCode)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable BarcodePrintRegister_Vend_Info(string partCode)
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

        #region 바코드 발행 정보 저장하기 - BarcodePrintRegister_Info_Save(BarcodePrintRegisterEntity pMaterialOrderStatusEntity, DataTable dt)       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool BarcodePrintRegister_Info_Save(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
                                   //int pCount = 0;
            _pDBManager.BeginTransaction();
            try
            {
                IDataParameter[] pDataParameters = null;

                string cmd = null;

                for (int i = 0; i < Convert.ToInt32(pBarcodePrintRegisterEntity.PRINT_SEQ); i++)
                {
                    cmd = (i+1).ToString("D3");

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
                                    new MySqlParameter("@v_part_qty", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_print_code", MySqlDbType.VarChar,50)
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
                                    new SqlParameter("@v_part_qty", SqlDbType.VarChar,50),
                                    new SqlParameter("@v_print_code", SqlDbType.VarChar,50)
                            };
                            break;
                    }
                    
                    pDataParameters[0].Value = "C";
                    pDataParameters[1].Value = pBarcodePrintRegisterEntity.USER_CODE;
                    pDataParameters[2].Value = pBarcodePrintRegisterEntity.VEND_CODE + cmd + DateTime.Now.ToString("yyMMdd").ToString();
                    pDataParameters[3].Value = pBarcodePrintRegisterEntity.PRINT_DATE;
                    pDataParameters[4].Value = i+1;
                    pDataParameters[5].Value = pBarcodePrintRegisterEntity.PART_CODE;
                    pDataParameters[6].Value = pBarcodePrintRegisterEntity.PART_QTY;
                    pDataParameters[7].Value = pBarcodePrintRegisterEntity.PRINT_CODE;

                    DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_ProductionOrderCommon_I10", pDataParameters);

                    if (pDataTable.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }

                    pBarcodePrintRegisterEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                    pBarcodePrintRegisterEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                    pBarcodePrintRegisterEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                    pBarcodePrintRegisterEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                    pBarcodePrintRegisterEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "BarcodePrintRegister_Info_Save(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity, DataTable dt)",
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
        public override BarcodePrintRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                BarcodePrintRegisterEntity pBarcodePrintRegisterEntity = new BarcodePrintRegisterEntity();

                //pBarcodePrintRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pBarcodePrintRegisterEntity;
            }
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

    public class ucTerminalDetailInfoPopupProvider : EntityManager<ucTerminalDetailInfoPopup_Entity>
    {
        #region ○ 생성자

        public ucTerminalDetailInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        public override ucTerminalDetailInfoPopup_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity = new ucTerminalDetailInfoPopup_Entity();

                return pucTerminalDetailInfoPopup_Entity;
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

        #region ○ 터미널 조회

        public DataTable ucTerminalDetailInfoPopup_Info_MST(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity)
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
                            new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 20)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 20)
                        };
                        break;

                }
                pDataParameters[0].Value = pucTerminalDetailInfoPopup_Entity.CRUD;
                pDataParameters[1].Value = pucTerminalDetailInfoPopup_Entity.TERMINAL_CODE;
                pDataParameters[2].Value = pucTerminalDetailInfoPopup_Entity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTerminalDetailInfoPopup_R10", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "PartProcessMapping_Info_MST(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity)",
                    pException
                );
            }
        }

        #endregion

        #region 터미널 상세 조회하기 - ucTerminalDetailInfoPopup_Info_Mst_Binding(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="ucTerminalDetailInfoPopup_Entity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable ucTerminalDetailInfoPopup_Info_Mst_Binding(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity)
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
                            new MySqlParameter("@v_terminal_seq", MySqlDbType.VarChar, 20),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_terminal_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_terminal_seq", SqlDbType.VarChar, 20),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pucTerminalDetailInfoPopup_Entity.TERMINAL_CODE;
                pDataParameters[1].Value = pucTerminalDetailInfoPopup_Entity.TERMINAL_SEQ;
                pDataParameters[2].Value = pucTerminalDetailInfoPopup_Entity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTerminalDetailInfoPopup_R11", pDataParameters);

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
                    "ucTerminalDetailInfoPopup_Info_Mst_Binding(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity)",
                    pException
                );
            }
        }

        #endregion

        // PartProcessMapping_Info_Save
        #region ○ 터미널 상세 정보 저장

        public bool ucTerminalDetailInfoPopup_Info_Save(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE

            try
            {

                IDataParameter[] pDataParameters = null;
                DataTable qDataTable = null;
                _pDBManager.BeginTransaction();

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                        new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                        new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                        new MySqlParameter("@v_terminal_code", MySqlDbType.VarChar, 20),
                        new MySqlParameter("@v_info_seq", MySqlDbType.Int32),
                        new MySqlParameter("@v_info_gubn", MySqlDbType.VarChar, 50),
                        new MySqlParameter("@v_info_name", MySqlDbType.VarChar, 50),
                        new MySqlParameter("@v_info_tcpip", MySqlDbType.VarChar, 50),
                        new MySqlParameter("@v_info_tcpport", MySqlDbType.VarChar, 50),
                        new MySqlParameter("@v_info_interval", MySqlDbType.VarChar, 50),
                        new MySqlParameter("@v_info_port_name", MySqlDbType.VarChar, 50),
                        new MySqlParameter("@v_info_baud_rate", MySqlDbType.VarChar, 50),
                        new MySqlParameter("@v_info_parity", MySqlDbType.VarChar,50),
                        new MySqlParameter("@v_info_data_bits", MySqlDbType.VarChar, 50),
                        new MySqlParameter("@v_info_stop_bits", MySqlDbType.VarChar, 50),
                        new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000),
                        new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                        new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                        new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                        new SqlParameter("@v_terminal_code", SqlDbType.NVarChar, 20),
                        new SqlParameter("@v_info_seq", SqlDbType.Int),
                        new SqlParameter("@v_info_gubn", SqlDbType.NVarChar, 50),
                        new SqlParameter("@v_info_name", SqlDbType.NVarChar, 50),
                        new SqlParameter("@v_info_tcpip", SqlDbType.NVarChar, 50),
                        new SqlParameter("@v_info_tcpport", SqlDbType.NVarChar, 50),
                        new SqlParameter("@v_info_interval", SqlDbType.NVarChar, 50),
                        new SqlParameter("@v_info_port_name", SqlDbType.NVarChar, 50),
                        new SqlParameter("@v_info_baud_rate", SqlDbType.NVarChar, 50),
                        new SqlParameter("@v_info_parity", SqlDbType.NVarChar,50),
                        new SqlParameter("@v_info_data_bits", SqlDbType.NVarChar, 50),
                        new SqlParameter("@v_info_stop_bits", SqlDbType.NVarChar, 50),
                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParameters[0].Value = pucTerminalDetailInfoPopup_Entity.CRUD;
                pDataParameters[1].Value = pucTerminalDetailInfoPopup_Entity.USER_CODE;
                pDataParameters[2].Value = pucTerminalDetailInfoPopup_Entity.TERMINAL_CODE;
                pDataParameters[3].Value = pucTerminalDetailInfoPopup_Entity.TERMINAL_SEQ;
                pDataParameters[4].Value = pucTerminalDetailInfoPopup_Entity.INFO_GUBN;
                pDataParameters[5].Value = pucTerminalDetailInfoPopup_Entity.INFO_NAME;
                pDataParameters[6].Value = pucTerminalDetailInfoPopup_Entity.INFO_TCPIP;
                pDataParameters[7].Value = pucTerminalDetailInfoPopup_Entity.INFO_TCPPORT;
                pDataParameters[8].Value = pucTerminalDetailInfoPopup_Entity.INFO_INTERVAL;
                pDataParameters[9].Value = pucTerminalDetailInfoPopup_Entity.INFO_PORT_NAME;
                pDataParameters[10].Value = pucTerminalDetailInfoPopup_Entity.INFO_BAUD_RATE;
                pDataParameters[11].Value = pucTerminalDetailInfoPopup_Entity.INFO_PARITY;
                pDataParameters[12].Value = pucTerminalDetailInfoPopup_Entity.INFO_DATA_BITS;
                pDataParameters[13].Value = pucTerminalDetailInfoPopup_Entity.INFO_STOP_BITS;
                pDataParameters[14].Value = pucTerminalDetailInfoPopup_Entity.REMARK;
                pDataParameters[15].Value = pucTerminalDetailInfoPopup_Entity.USE_YN;

                qDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTerminalDetailInfoPopup_I10", pDataParameters);

                pucTerminalDetailInfoPopup_Entity.ERR_NO = qDataTable.Rows[0]["P_ERR_NO"].ToString();
                pucTerminalDetailInfoPopup_Entity.ERR_MSG = qDataTable.Rows[0]["P_ERR_MSG"].ToString();
                pucTerminalDetailInfoPopup_Entity.RTN_KEY = qDataTable.Rows[0]["P_RTN_KEY"].ToString();
                pucTerminalDetailInfoPopup_Entity.RTN_OTHERS = qDataTable.Rows[0]["P_RTN_OTHERS"].ToString();
            }
            catch (ExceptionManager pExceptionManager)
            {
                pErrorYN = true;
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                pErrorYN = true;
                throw new ExceptionManager(this, "PartProcessMapping_Info_Save(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity, DataTable pDataTable)", pException);
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

    }

    public class ucContractInfoPopupProvider : EntityManager<ucContractInfoPopupEntity>
    {
        #region 생성자 - ucContractInfoPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucContractInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 조회하기 ucContractInfoPopup_Info_Return(ucContractInfoPopupEntity pucContractInfoPopupEntity)

        public DataTable ucContractInfoPopup_Info_Return(ucContractInfoPopupEntity pucContractInfoPopupEntity)
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

                pDataParameters[0].Value = pucContractInfoPopupEntity.CRUD;
                pDataParameters[1].Value = pucContractInfoPopupEntity.LANGUAGE_TYPE;
                pDataParameters[2].Value = pucContractInfoPopupEntity.CONTRACT_NUMBER;
                pDataParameters[3].Value = pucContractInfoPopupEntity.CONTRACT_DATE_FROM;
                pDataParameters[4].Value = pucContractInfoPopupEntity.CONTRACT_DATE_TO;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucContractInfoPopup_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucContractInfoPopup_Info_Return(ucContractInfoPopupEntity pucContractInfoPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucContractInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucContractInfoPopupEntity pucContractInfoPopupEntity = new ucContractInfoPopupEntity();
                pucContractInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucContractInfoPopupEntity;
            }
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
    public class NoticeRegisterProvider : EntityManager<NoticeRegisterEntity>
    {
        #region 생성자 - NoticeRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public NoticeRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - NoticeRegister_Info_Mst(NoticeRegisterEntity pNoticeRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pNoticeRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable NoticeRegister_Info_Mst(NoticeRegisterEntity pNoticeRegisterEntity)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pNoticeRegisterEntity.CRUD;
                pDataParameters[1].Value = pNoticeRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pNoticeRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pNoticeRegisterEntity.USE_YN;
                pDataParameters[4].Value = pNoticeRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_NoticeRegister_R10", pDataParameters);

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

        #region 정보 저장하기 - NoticeRegister_Info_Save(NoticeRegisterEntity pMaterialOrderStatusEntity, DataTable dt)       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool NoticeRegister_Info_Save(NoticeRegisterEntity pNoticeRegisterEntity)
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
                                new MySqlParameter("@v_notice_id", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_notice_name", MySqlDbType.VarChar, 200),
                                new MySqlParameter("@v_notice_detail", MySqlDbType.VarChar, 5000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_notice_id", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_notice_name", SqlDbType.NVarChar, 200),
                                new SqlParameter("@v_notice_detail", SqlDbType.NVarChar, 5000),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pNoticeRegisterEntity.CRUD;
                pDataParametersA[1].Value = pNoticeRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pNoticeRegisterEntity.NOTICE_ID;
                pDataParametersA[3].Value = pNoticeRegisterEntity.NOTICE_NAME;
                pDataParametersA[4].Value = pNoticeRegisterEntity.NOTICE_DETAIL;
                pDataParametersA[5].Value = pNoticeRegisterEntity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_NoticeRegister_I10", pDataParametersA);

                pNoticeRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pNoticeRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pNoticeRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pNoticeRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "NoticeRegister_Info_Save(NoticeRegisterEntity pNoticeRegisterEntity, DataTable dt)",
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
        public override NoticeRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                NoticeRegisterEntity pNoticeRegisterEntity = new NoticeRegisterEntity();

                //pNoticeRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pNoticeRegisterEntity;
            }
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

    public class CommentInfoRegisterProvider : EntityManager<CommentInfoRegisterEntity>
    {
        #region 생성자 - CommentInfoRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public CommentInfoRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - CommentInfoRegister_Info_Mst(CommentInfoRegisterEntity pCommentInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCommentInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable CommentInfoRegister_Info_Mst(CommentInfoRegisterEntity pCommentInfoRegisterEntity)
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
                            new MySqlParameter("@v_comment_id", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_comment_detail", MySqlDbType.VarChar, 1000),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_comment_id", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_comment_detail", SqlDbType.NVarChar, 1000),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pCommentInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pCommentInfoRegisterEntity.COMMENT_ID;
                pDataParameters[2].Value = pCommentInfoRegisterEntity.COMMENT_DETAIL;
                pDataParameters[3].Value = pCommentInfoRegisterEntity.USE_YN;
                pDataParameters[4].Value = pCommentInfoRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CommentInfoRegister_R10", pDataParameters);

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

        #region 정보 저장하기 - CommentInfoRegister_Info_Save(CommentInfoRegisterEntity pMaterialOrderStatusEntity, DataTable dt)       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool CommentInfoRegister_Info_Save(CommentInfoRegisterEntity pCommentInfoRegisterEntity)
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
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_comment_id", MySqlDbType.VarChar, 200),
                                new MySqlParameter("@v_comment_detail", MySqlDbType.VarChar, 5000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_comment_id", SqlDbType.NVarChar, 200),
                                new SqlParameter("@v_comment_detail", SqlDbType.NVarChar, 5000),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pCommentInfoRegisterEntity.CRUD;
                pDataParametersA[1].Value = pCommentInfoRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pCommentInfoRegisterEntity.LANGUAGE_TYPE;
                pDataParametersA[3].Value = pCommentInfoRegisterEntity.COMMENT_ID;
                pDataParametersA[4].Value = pCommentInfoRegisterEntity.COMMENT_DETAIL;
                pDataParametersA[5].Value = pCommentInfoRegisterEntity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_CommentInfoRegister_I10", pDataParametersA);

                pCommentInfoRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pCommentInfoRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pCommentInfoRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pCommentInfoRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "CommentInfoRegister_Info_Save(CommentInfoRegisterEntity pCommentInfoRegisterEntity, DataTable dt)",
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
        public override CommentInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                CommentInfoRegisterEntity pCommentInfoRegisterEntity = new CommentInfoRegisterEntity();

                //pCommentInfoRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pCommentInfoRegisterEntity;
            }
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

    public class POP_NoticeRegisterProvider : EntityManager<POP_NoticeRegisterEntity>
    {
        #region 생성자 - NoticeRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public POP_NoticeRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - NoticeRegister_Info_Mst(NoticeRegisterEntity pNoticeRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pNoticeRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable POP_NoticeRegister_Info_Mst(POP_NoticeRegisterEntity pPOP_NoticeRegisterEntity)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_date_from", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_date_to", SqlDbType.NVarChar, 8),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pPOP_NoticeRegisterEntity.CRUD;
                pDataParameters[1].Value = pPOP_NoticeRegisterEntity.DATE_FROM;
                pDataParameters[2].Value = pPOP_NoticeRegisterEntity.DATE_TO;
                pDataParameters[3].Value = pPOP_NoticeRegisterEntity.USE_YN;
                pDataParameters[4].Value = pPOP_NoticeRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_NoticeRegister_R10", pDataParameters);

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

        #region 정보 저장하기 - NoticeRegister_Info_Save(NoticeRegisterEntity pMaterialOrderStatusEntity, DataTable dt)       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool POP_NoticeRegister_Info_Save(POP_NoticeRegisterEntity pPOP_NoticeRegisterEntity)
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
                                new MySqlParameter("@v_notice_id", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_notice_name", MySqlDbType.VarChar, 200),
                                new MySqlParameter("@v_notice_detail", MySqlDbType.VarChar, 5000),
                                new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_notice_id", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_notice_name", SqlDbType.NVarChar, 200),
                                new SqlParameter("@v_notice_detail", SqlDbType.NVarChar, 5000),
                                new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParametersA[0].Value = pPOP_NoticeRegisterEntity.CRUD;
                pDataParametersA[1].Value = pPOP_NoticeRegisterEntity.USER_CODE;
                pDataParametersA[2].Value = pPOP_NoticeRegisterEntity.NOTICE_ID;
                pDataParametersA[3].Value = pPOP_NoticeRegisterEntity.NOTICE_NAME;
                pDataParametersA[4].Value = pPOP_NoticeRegisterEntity.NOTICE_DETAIL;
                pDataParametersA[5].Value = pPOP_NoticeRegisterEntity.USE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_POP_NoticeRegister_I10", pDataParametersA);

                pPOP_NoticeRegisterEntity.ERR_NO = pDataTableA.Rows[0]["P_ERR_NO"].ToString();
                pPOP_NoticeRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["P_ERR_MSG"].ToString();
                pPOP_NoticeRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pPOP_NoticeRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();
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
                    "NoticeRegister_Info_Save(NoticeRegisterEntity pNoticeRegisterEntity, DataTable dt)",
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
        public override POP_NoticeRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                POP_NoticeRegisterEntity pPOP_NoticeRegisterEntity = new POP_NoticeRegisterEntity();

                //pNoticeRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pPOP_NoticeRegisterEntity;
            }
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

    public class ucProcessDocumentListPopupProvider : EntityManager<ucProcessDocumentListPopupEntity>
    {
        #region 생성자 - ucPartDocumentListPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucProcessDocumentListPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 메인 조회하기 ucProcessDocumentListPopup_Info_Main(string pCRUD, string pPART_CODE, string pPART_REVISION_NO, string pLANGUAGE_TYPE)

        public DataTable ucProcessDocumentListPopup_Info_Main(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)
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
                            new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)


                };
                        break;
                }

                pDataParameters[0].Value = pucProcessDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucProcessDocumentListPopupEntity.PROCESS_CODE;
                pDataParameters[2].Value = pucProcessDocumentListPopupEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProcessDocumentListPopup_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucProcessDocumentListPopup_Info_Main(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 ucProcessDocumentListPopup_Info_Sub(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)

        public DataTable ucProcessDocumentListPopup_Info_Sub(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)
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
                            new MySqlParameter("@v_document_file_name", MySqlDbType.VarChar, 50),
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
                            new SqlParameter("@v_document_file_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pucProcessDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucProcessDocumentListPopupEntity.DOCUMENT_TYPE;
                pDataParameters[2].Value = pucProcessDocumentListPopupEntity.DOCUMENT_NAME;
                pDataParameters[3].Value = pucProcessDocumentListPopupEntity.DOCUMENT_VER;

                pDataParameters[4].Value = pucProcessDocumentListPopupEntity.DOCUMENT_FILE_NAME;
                pDataParameters[5].Value = pucProcessDocumentListPopupEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProcessDocumentListPopup_R20", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucProcessDocumentListPopup_Info_Sub(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ucProcessDocumentListPopup_Info_Save(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity, DataTable pDataTable)
        public bool ucProcessDocumentListPopup_Info_Save(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity, DataTable pDataTable)
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
                                        new MySqlParameter("@v_process_code", MySqlDbType.VarChar, 50),
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
                                        new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_document_id", SqlDbType.NVarChar, 15),
                                        new SqlParameter("@v_document_type", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                };
                                break;

                        }

                        pDataParameters[0].Value = pDataTable.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pucProcessDocumentListPopupEntity.USER_CODE;

                        pDataParameters[2].Value = pucProcessDocumentListPopupEntity.PROCESS_CODE;
                        pDataParameters[3].Value = pDataTable.Rows[a]["DOCUMENT_ID"].ToString();
                        pDataParameters[4].Value = pDataTable.Rows[a]["DOCUMENT_TYPE"].ToString();
                        pDataParameters[5].Value = pDataTable.Rows[a]["REMARK"].ToString();
                        pDataParameters[6].Value = pDataTable.Rows[a]["USE_YN"].ToString().ToUpper() == "" ? "Y" : pDataTable.Rows[a]["USE_YN"].ToString().ToUpper();

                        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProcessDocumentListPopup_I10", pDataParameters);

                        if (pDataTableB.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pucProcessDocumentListPopupEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                        pucProcessDocumentListPopupEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();

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
                    "ucProcessDocumentListPopup_Info_Save(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity, DataTable pDataTable)",
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

        public override ucProcessDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity = new ucProcessDocumentListPopupEntity();
                pucProcessDocumentListPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucProcessDocumentListPopupEntity;
            }
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

    public class ucProRoutingDocumentListPopupProvider : EntityManager<ucProRoutingDocumentListPopupEntity>
    {
        #region 생성자 - ucProRoutingDocumentListPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucProRoutingDocumentListPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 메인 조회하기 ucProRoutingDocumentListPopup_Info_Main(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)

        public DataTable ucProRoutingDocumentListPopup_Info_Main(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)
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
                            new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_configuration_seq", MySqlDbType.Int32),
                            new MySqlParameter("@v_configuration_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_configuration_seq", SqlDbType.Int),
                            new SqlParameter("@v_configuration_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)


                };
                        break;
                }

                pDataParameters[0].Value = pucProRoutingDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucProRoutingDocumentListPopupEntity.CONFIGURATION_MST_CODE;
                pDataParameters[2].Value = pucProRoutingDocumentListPopupEntity.CONFIGURATION_SEQ;
                pDataParameters[3].Value = pucProRoutingDocumentListPopupEntity.CONFIGURATION_CODE;
                pDataParameters[4].Value = pucProRoutingDocumentListPopupEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProRoutingDocumentListPopup_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucProRoutingDocumentListPopup_Info_Main(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 ucProRoutingDocumentListPopup_Info_Sub(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)

        public DataTable ucProRoutingDocumentListPopup_Info_Sub(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)
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
                            new MySqlParameter("@v_document_file_name", MySqlDbType.VarChar, 50),
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
                            new SqlParameter("@v_document_file_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pucProRoutingDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucProRoutingDocumentListPopupEntity.DOCUMENT_TYPE;
                pDataParameters[2].Value = pucProRoutingDocumentListPopupEntity.DOCUMENT_NAME;
                pDataParameters[3].Value = pucProRoutingDocumentListPopupEntity.DOCUMENT_VER;

                pDataParameters[4].Value = pucProRoutingDocumentListPopupEntity.DOCUMENT_FILE_NAME;
                pDataParameters[5].Value = pucProRoutingDocumentListPopupEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProRoutingDocumentListPopup_R20", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucProRoutingDocumentListPopup_Info_Sub(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ucProRoutingDocumentListPopup_Info_Save(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity, DataTable pDataTable)
        public bool ucProRoutingDocumentListPopup_Info_Save(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity, DataTable pDataTable)
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
                                        new MySqlParameter("@v_configuration_mst_code", MySqlDbType.VarChar, 50),
                                        new MySqlParameter("@v_configuration_seq", MySqlDbType.Int32),
                                        new MySqlParameter("@v_configuration_code", MySqlDbType.VarChar, 50),
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
                                        new SqlParameter("@v_configuration_mst_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_configuration_seq", SqlDbType.Int),
                                        new SqlParameter("@v_configuration_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_document_id", SqlDbType.NVarChar, 15),
                                        new SqlParameter("@v_document_type", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                };
                                break;

                        }

                        pDataParameters[0].Value = pDataTable.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pucProRoutingDocumentListPopupEntity.USER_CODE;

                        pDataParameters[2].Value = pucProRoutingDocumentListPopupEntity.CONFIGURATION_MST_CODE;
                        pDataParameters[3].Value = pucProRoutingDocumentListPopupEntity.CONFIGURATION_SEQ;
                        pDataParameters[4].Value = pucProRoutingDocumentListPopupEntity.CONFIGURATION_CODE;

                        pDataParameters[5].Value = pDataTable.Rows[a]["DOCUMENT_ID"].ToString();
                        pDataParameters[6].Value = pDataTable.Rows[a]["DOCUMENT_TYPE"].ToString();
                        pDataParameters[7].Value = pDataTable.Rows[a]["REMARK"].ToString();
                        pDataParameters[8].Value = pDataTable.Rows[a]["USE_YN"].ToString().ToUpper() == "" ? "Y" : pDataTable.Rows[a]["USE_YN"].ToString().ToUpper();

                        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProRoutingDocumentListPopup_I10", pDataParameters);

                        if (pDataTableB.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pucProRoutingDocumentListPopupEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                        pucProRoutingDocumentListPopupEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();

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
                    "ucProRoutingDocumentListPopup_Info_Save(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity, DataTable pDataTable)",
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

        public override ucProRoutingDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity = new ucProRoutingDocumentListPopupEntity();
                pucProRoutingDocumentListPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucProRoutingDocumentListPopupEntity;
            }
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

    public class ucToolDocumentListPopupProvider : EntityManager<ucToolDocumentListPopupEntity>
    {
        #region 생성자 - ucToolDocumentListPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucToolDocumentListPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 메인 조회하기 ucToolDocumentListPopup_Info_Main(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity)

        public DataTable ucToolDocumentListPopup_Info_Main(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity)
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
                            new MySqlParameter("@v_tool_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_tool_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)


                };
                        break;
                }

                pDataParameters[0].Value = pucToolDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucToolDocumentListPopupEntity.TOOL_CODE;
                pDataParameters[2].Value = pucToolDocumentListPopupEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucToolDocumentListPopup_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucToolDocumentListPopup_Info_Main(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 ucToolDocumentListPopup_Info_Sub(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity)

        public DataTable ucToolDocumentListPopup_Info_Sub(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity)
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
                            new MySqlParameter("@v_document_file_name", MySqlDbType.VarChar, 50),
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
                            new SqlParameter("@v_document_file_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pucToolDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucToolDocumentListPopupEntity.DOCUMENT_TYPE;
                pDataParameters[2].Value = pucToolDocumentListPopupEntity.DOCUMENT_NAME;
                pDataParameters[3].Value = pucToolDocumentListPopupEntity.DOCUMENT_VER;

                pDataParameters[4].Value = pucToolDocumentListPopupEntity.DOCUMENT_FILE_NAME;
                pDataParameters[5].Value = pucToolDocumentListPopupEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucToolDocumentListPopup_R20", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucToolDocumentListPopup_Info_Sub(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ucToolDocumentListPopup_Info_Save(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity, DataTable pDataTable)
        public bool ucToolDocumentListPopup_Info_Save(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity, DataTable pDataTable)
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
                                        new MySqlParameter("@v_tool_code", MySqlDbType.VarChar, 50),
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
                                        new SqlParameter("@v_tool_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_document_id", SqlDbType.NVarChar, 15),
                                        new SqlParameter("@v_document_type", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                };
                                break;

                        }

                        pDataParameters[0].Value = pDataTable.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pucToolDocumentListPopupEntity.USER_CODE;

                        pDataParameters[2].Value = pucToolDocumentListPopupEntity.TOOL_CODE;
                        pDataParameters[3].Value = pDataTable.Rows[a]["DOCUMENT_ID"].ToString();
                        pDataParameters[4].Value = pDataTable.Rows[a]["DOCUMENT_TYPE"].ToString();
                        pDataParameters[5].Value = pDataTable.Rows[a]["REMARK"].ToString();
                        pDataParameters[6].Value = pDataTable.Rows[a]["USE_YN"].ToString().ToUpper() == "" ? "Y" : pDataTable.Rows[a]["USE_YN"].ToString().ToUpper();

                        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucToolDocumentListPopup_I10", pDataParameters);

                        if (pDataTableB.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pucToolDocumentListPopupEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                        pucToolDocumentListPopupEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();

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
                    "ucToolDocumentListPopup_Info_Save(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity, DataTable pDataTable)",
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

        public override ucToolDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity = new ucToolDocumentListPopupEntity();
                pucToolDocumentListPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucToolDocumentListPopupEntity;
            }
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

    public class ucVendDocumentListPopupProvider : EntityManager<ucVendDocumentListPopupEntity>
    {
        #region 생성자 - ucVendDocumentListPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucVendDocumentListPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 메인 조회하기 ucVendDocumentListPopup_Info_Main(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity)

        public DataTable ucVendDocumentListPopup_Info_Main(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity)
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
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1)



                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)


                };
                        break;
                }

                pDataParameters[0].Value = pucVendDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucVendDocumentListPopupEntity.VEND_CODE;
                pDataParameters[2].Value = pucVendDocumentListPopupEntity.USE_YN;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucVendDocumentListPopup_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucVendDocumentListPopup_Info_Main(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 서브 조회하기 ucVendDocumentListPopup_Info_Sub(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity)

        public DataTable ucVendDocumentListPopup_Info_Sub(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity)
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
                            new MySqlParameter("@v_document_file_name", MySqlDbType.VarChar, 50),
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
                            new SqlParameter("@v_document_file_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                        };
                        break;
                }

                pDataParameters[0].Value = pucVendDocumentListPopupEntity.CRUD;
                pDataParameters[1].Value = pucVendDocumentListPopupEntity.DOCUMENT_TYPE;
                pDataParameters[2].Value = pucVendDocumentListPopupEntity.DOCUMENT_NAME;
                pDataParameters[3].Value = pucVendDocumentListPopupEntity.DOCUMENT_VER;

                pDataParameters[4].Value = pucVendDocumentListPopupEntity.DOCUMENT_FILE_NAME;
                pDataParameters[5].Value = pucVendDocumentListPopupEntity.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucVendDocumentListPopup_R20", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "ucVendDocumentListPopup_Info_Sub(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - ucVendDocumentListPopup_Info_Save(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity, DataTable pDataTable)
        public bool ucVendDocumentListPopup_Info_Save(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity, DataTable pDataTable)
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
                                        new MySqlParameter("@v_vend_code", MySqlDbType.VarChar, 50),
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
                                        new SqlParameter("@v_vend_code", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_document_id", SqlDbType.NVarChar, 15),
                                        new SqlParameter("@v_document_type", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000),
                                        new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                };
                                break;

                        }

                        pDataParameters[0].Value = pDataTable.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pucVendDocumentListPopupEntity.USER_CODE;

                        pDataParameters[2].Value = pucVendDocumentListPopupEntity.VEND_CODE;
                        pDataParameters[3].Value = pDataTable.Rows[a]["DOCUMENT_ID"].ToString();
                        pDataParameters[4].Value = pDataTable.Rows[a]["DOCUMENT_TYPE"].ToString();
                        pDataParameters[5].Value = pDataTable.Rows[a]["REMARK"].ToString();
                        pDataParameters[6].Value = pDataTable.Rows[a]["USE_YN"].ToString().ToUpper() == "" ? "Y" : pDataTable.Rows[a]["USE_YN"].ToString().ToUpper();

                        DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucVendDocumentListPopup_I10", pDataParameters);

                        if (pDataTableB.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pucVendDocumentListPopupEntity.ERR_NO = pDataTableB.Rows[0]["ERR_NO"].ToString();
                        pucVendDocumentListPopupEntity.ERR_MSG = pDataTableB.Rows[0]["ERR_MSG"].ToString();

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
                    "ucVendDocumentListPopup_Info_Save(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity, DataTable pDataTable)",
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

        public override ucVendDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity = new ucVendDocumentListPopupEntity();
                pucVendDocumentListPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucVendDocumentListPopupEntity;
            }
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

    public class TabletBasedSensorInfoRegisterProvider : EntityManager<TabletBasedSensorInfoRegisterEntity>
    {
        
        #region 생성자 - TabletBasedSensorInfoRegisterProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public TabletBasedSensorInfoRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 마스터 조회하기 - TabletBasedSensorInfoRegister_Info_Mst(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable TabletBasedSensorInfoRegister_Info_Mst(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)

                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                          //  new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_language_type", SqlDbType.VarChar, 50)

                };
                        break;
                }

                pDataParameters[0].Value = pTabletBasedSensorInfoRegisterEntity.CRUD;
                pDataParameters[1].Value = pTabletBasedSensorInfoRegisterEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_TabletBasedSensorInfoRegister_R10", pDataParameters);

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
                    "TabletBasedSensorInfoRegister_Info_Mst(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity)",
                    pException
                );
            }

        }
        #endregion

        #region 정보 저장하기 - MaterialInformationRegister_Info_Save(MaterialInformationRegisterEntity pMaterialInformationRegisterEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool TabletBasedSensorInfoRegister_Info_One_Save(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity)
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
                                new MySqlParameter("@v_value", MySqlDbType.Decimal),
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_comment1", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_comment2", MySqlDbType.VarChar, 1000),
                                new MySqlParameter("@v_comment3", MySqlDbType.VarChar, 1000)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_date_time", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_value", SqlDbType.Decimal),
                                new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_comment1", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_comment2", SqlDbType.NVarChar, 1000),
                                new SqlParameter("@v_comment3", SqlDbType.NVarChar, 1000)
                        };
                        break;
                }

                pDataParametersA[0].Value = pTabletBasedSensorInfoRegisterEntity.CRUD;
                pDataParametersA[1].Value = "tablet";
                pDataParametersA[2].Value = pTabletBasedSensorInfoRegisterEntity.RESOURCE_CODE;
                pDataParametersA[3].Value = pTabletBasedSensorInfoRegisterEntity.DATE_TIME;
                pDataParametersA[4].Value = Convert.ToDecimal(pTabletBasedSensorInfoRegisterEntity.VALUE);
                pDataParametersA[5].Value = pTabletBasedSensorInfoRegisterEntity.LANGUAGE_TYPE;
                pDataParametersA[6].Value = pTabletBasedSensorInfoRegisterEntity.COMMENT1;
                pDataParametersA[7].Value = pTabletBasedSensorInfoRegisterEntity.COMMENT2;
                pDataParametersA[8].Value = pTabletBasedSensorInfoRegisterEntity.COMMENT3;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_TabletBasedSensorInfoRegister_I10", pDataParametersA);

                pTabletBasedSensorInfoRegisterEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pTabletBasedSensorInfoRegisterEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pTabletBasedSensorInfoRegisterEntity.RTN_KEY = pDataTableA.Rows[0]["P_RTN_KEY"].ToString();
                pTabletBasedSensorInfoRegisterEntity.RTN_SEQ = pDataTableA.Rows[0]["P_RTN_SEQ"].ToString();
                pTabletBasedSensorInfoRegisterEntity.RTN_OTHERS = pDataTableA.Rows[0]["P_RTN_OTHERS"].ToString();

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
                    "MaterialInformationRegister_Info_Save(MaterialInformationRegisterEntity pMaterialInformationRegisterEntity, DataTable dt)",
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
        public override TabletBasedSensorInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity = new TabletBasedSensorInfoRegisterEntity();

                pTabletBasedSensorInfoRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pTabletBasedSensorInfoRegisterEntity;
            }
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

    public class frmCategorySensorSettingsProvider : EntityManager<frmCategorySensorSettingsEntity>
    {
        #region 생성자 - frmCategorySensorSettingsProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmCategorySensorSettingsProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - frmCategorySensorSettings_Info(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pfrmCategorySensorSettingsEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmCategorySensorSettings_Info(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity)
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
                            new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pfrmCategorySensorSettingsEntity.CRUD;
                pDataParameters[1].Value = pfrmCategorySensorSettingsEntity.RESOURCE_CODE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmCategorySensorSettings_R10", pDataParameters);

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
                    "frmCategorySensorSettings_Info(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - frmCategorySensorSettings_Info_Save(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frmCategorySensorSettingsEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool frmCategorySensorSettings_Info_Save(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity, DataTable dt)
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
                                new MySqlParameter("@v_resource_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_category_value", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_category_name", MySqlDbType.VarChar, 50)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_resource_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_category_value", SqlDbType.VarChar, 20),
                                new SqlParameter("@v_category_name", SqlDbType.VarChar, 50)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pfrmCategorySensorSettingsEntity.USER_CODE;
                        pDataParameters[2].Value = pfrmCategorySensorSettingsEntity.RESOURCE_CODE;
                        pDataParameters[3].Value = dt.Rows[a]["CATEGORY_VALUE"].ToString().ToUpper();
                        pDataParameters[4].Value = dt.Rows[a]["CATEGORY_NAME"].ToString().ToUpper();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_frmCategorySensorSettings_I10", pDataParameters);

                        pfrmCategorySensorSettingsEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pfrmCategorySensorSettingsEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pfrmCategorySensorSettingsEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pfrmCategorySensorSettingsEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pfrmCategorySensorSettingsEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
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
                    "frmCategorySensorSettings_Info_Save(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity, DataTable dt)",
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
        public override frmCategorySensorSettingsEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity = new frmCategorySensorSettingsEntity();

                //pProcessCodeMstRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pfrmCategorySensorSettingsEntity;
            }
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
        public DataSet ucWorkOrderDocRegPopup_Return(string pCRUD, string pLANGUAGE_TYPE, string pPRODUCTION_ORDER_ID, string pPART_NAME, string pPART_CODE, string pPROCESS_CODE_MST)
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

        #region 마스터 조회하기 - Sample_Info_Mst(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pSampleRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataSet ucWorkOrderDocRegPopup_Return2(string pCRUD, string pLANGUAGE_TYPE, string pPART_CODE, string pPROCESS_CODE_MST)
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
                            new MySqlParameter("@v_process_code_mst", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_process_code_mst", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPART_CODE;
                pDataParameters[2].Value = pPROCESS_CODE_MST;
                pDataParameters[3].Value = pLANGUAGE_TYPE;


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucWorkOrderDocRegPopup_R20", pDataParameters);


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
        public bool WorkResultInfo_Save(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity, Worksheet pSheet)
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
                    if (pSheet.GetCellValue(11, i + 11).ToString() != "")
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

    public class InspectProcessMappingRegisterProvider : EntityManager<InspectProcessMappingRegisterEntity>
    {
        #region ○ 생성자

        public InspectProcessMappingRegisterProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        public override InspectProcessMappingRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                InspectProcessMappingRegisterEntity pInspectProcessMappingRegisterEntity = new InspectProcessMappingRegisterEntity();

                return pInspectProcessMappingRegisterEntity;
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

        #region ○ 설비정보 조회하기

        public DataTable InspectProcess_Info_Mst(InspectProcessMappingRegisterEntity pInspectProcessMappingRegister)
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
                            new MySqlParameter("@v_process_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_process_code", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1),
                        };
                        break;

                }
                pDataParameters[0].Value = pInspectProcessMappingRegister.CRUD;
                pDataParameters[1].Value = pInspectProcessMappingRegister.PROCESS_CODE;
                pDataParameters[2].Value = pInspectProcessMappingRegister.USE_YN;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectProcessMappingRegister_R10", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "InspectProcess_Info_Mst(InspectProcessMappingRegisterEntity pInspectProcessMappingRegister)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 점검항목 조회하기

        public DataTable InspectProcess_Info_Sub1(InspectProcessMappingRegisterEntity pInspectProcessMappingRegister)
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
                            //new MySqlParameter("@v_process_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            //new SqlParameter("@v_process_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type",    SqlDbType.VarChar, 50)
                        };
                        break;

                }
                pDataParameters[0].Value = pInspectProcessMappingRegister.CRUD;
                //pDataParameters[1].Value = pInspectProcessMappingRegister.PROCESS_TYPE;
                pDataParameters[1].Value = pInspectProcessMappingRegister.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectProcessMappingRegister_R20", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "InspectProcess_Info_Sub1(InspectProcessMappingRegisterEntity pInspectProcessMappingRegister)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 설비별 점검항목 조회하기

        public DataTable InspectProcess_Info_Sub2(InspectProcessMappingRegisterEntity pInspectProcessMappingRegister)
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
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_equipment_code", SqlDbType.NVarChar, 50)
                        };
                        break;

                }
                pDataParameters[0].Value = pInspectProcessMappingRegister.CRUD;
                pDataParameters[1].Value = pInspectProcessMappingRegister.EQUIPMENT_CODE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectProcessMappingRegister_R30", pDataParameters);

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "InspectProcess_Info_Sub2(InspectProcessMappingRegisterEntity pInspectProcessMappingRegister)",
                    pException
                );
            }
        }

        #endregion

        #region ○ 설비별 점검항목 저장하기

        public bool InspectProcess_Info_Save(InspectProcessMappingRegisterEntity pInspectProcessMappingRegisterEntity, DataTable pDataTable)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE

            try
            {
                _pDBManager.BeginTransaction();
                IDataParameter[] pDataParameters = null;
                DataTable qDataTable = null;

                int pDataTableCount = 0;
                if (pDataTable != null)
                {
                    pDataTableCount = pDataTable.Rows.Count;
                    for (int i = 0; i < pDataTableCount; i++)
                    {
                        if (pDataTable.Rows[i]["CRUD"].ToString() != "")
                        {
                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParameters = new IDataParameter[]
                                    {
                                    new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                    new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_inspect_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_resource_code", MySqlDbType.VarChar,50),
                                    new MySqlParameter("@v_inspect_seq", MySqlDbType.Int64),
                                    new MySqlParameter("@v_remark", MySqlDbType.VarChar, 2000),
                                    new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1),
                                    };
                                    break;

                                case "SQLServer":
                                    pDataParameters = new IDataParameter[]
                                    {
                                    new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                    new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_inspect_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_equipment_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_resource_code", SqlDbType.NVarChar, 50),
                                    new SqlParameter("@v_inspect_seq", SqlDbType.Int),
                                    new SqlParameter("@v_remark", SqlDbType.NVarChar, 2000),
                                    new SqlParameter("@v_use_yn", SqlDbType.NVarChar, 1)
                                    };
                                    break;
                            }

                            pDataParameters[0].Value = pDataTable.Rows[i]["CRUD"].ToString();
                            pDataParameters[1].Value = pInspectProcessMappingRegisterEntity.USER_CODE;
                            pDataParameters[2].Value = pDataTable.Rows[i]["INSPECT_CODE"].ToString();
                            pDataParameters[3].Value = pDataTable.Rows[i]["EQUIPMENT_CODE"].ToString();
                            pDataParameters[4].Value = pDataTable.Rows[i]["RESOURCE_CODE"].ToString();
                            if (pDataTable.Rows[i]["INSPECT_SEQ"].ToString() == "")
                            {
                                pDataParameters[5].Value = i + 1;
                            }
                            else
                            {
                                pDataParameters[5].Value = pDataTable.Rows[i]["INSPECT_SEQ"].ToString();
                            }
                            pDataParameters[6].Value = pDataTable.Rows[i]["REMARK"].ToString();
                            pDataParameters[7].Value = "Y";

                            qDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_InspectProcessMappingRegister_I10", pDataParameters);

                            if (qDataTable.Rows[0][0].ToString() != "00")
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
                throw new ExceptionManager(this, "InspectProcess_Info_Save(InspectProcessMappingRegisterEntity pInspectProcessMappingRegisterEntity, DataTable pDataTable)", pException);
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
    }

    public class frmResourceMst_PopupProvider : EntityManager<frmResourceMst_PopupEntity>
    {
        #region 생성자 - frmResourceMst_PopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public frmResourceMst_PopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - frmResourceMst_Popup_Info(frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pfrmResourceMst_PopupEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable frmResourceMst_Popup_Info(frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity)
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
                            new MySqlParameter("@v_process_mst_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_inspect_code", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_process_mst_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_equipment_code", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_inspect_code", SqlDbType.VarChar, 50),
                        };
                        break;
                }

                pDataParameters[0].Value = pfrmResourceMst_PopupEntity.CRUD;
                pDataParameters[1].Value = pfrmResourceMst_PopupEntity.PROCESS_MST_CODE;
                pDataParameters[2].Value = pfrmResourceMst_PopupEntity.EQUIPMENT_CODE;
                pDataParameters[3].Value = pfrmResourceMst_PopupEntity.INSPECT_CODE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucPartProcessMapping_PopUp_T02_R10", pDataParameters);

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
                    "frmResourceMst_Popup_Info(frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 정보 저장하기 - frmResourceMst_Popup_Info_Save(frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pfrmResourceMst_PopupEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool frmResourceMst_Popup_Info_Save(frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity, DataTable dt)
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
                                new MySqlParameter("@v_equipment_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_inspect_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_resource_code",MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_resource_yn", MySqlDbType.VarChar, 1)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_equipment_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_inspect_code", SqlDbType.VarChar, 50),
                                new SqlParameter("@v_resource_code",SqlDbType.VarChar,50),
                                new SqlParameter("@v_resource_yn", SqlDbType.VarChar, 1)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pfrmResourceMst_PopupEntity.USER_CODE;
                        pDataParameters[2].Value = pfrmResourceMst_PopupEntity.EQUIPMENT_CODE;
                        pDataParameters[3].Value = pfrmResourceMst_PopupEntity.INSPECT_CODE;
                        pDataParameters[4].Value = dt.Rows[a]["RESOURCE_CODE"].ToString();
                        pDataParameters[5].Value = dt.Rows[a]["RESOURCE_YN"].ToString();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucPartProcessMapping_PopUp_T02_I10", pDataParameters);

                        pfrmResourceMst_PopupEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pfrmResourceMst_PopupEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pfrmResourceMst_PopupEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pfrmResourceMst_PopupEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pfrmResourceMst_PopupEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
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
                    "frmCategorySensorSettings_Info_Save(frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity, DataTable dt)",
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
        public override frmResourceMst_PopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity = new frmResourceMst_PopupEntity();

                //pProcessCodeMstRegisterEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pfrmResourceMst_PopupEntity;
            }
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
