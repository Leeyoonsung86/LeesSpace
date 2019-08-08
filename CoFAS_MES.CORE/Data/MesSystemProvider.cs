using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

using MySql.Data.MySqlClient;

using Oracle.ManagedDataAccess.Client;

using CoFAS_MES.CORE.Function;
using CoFAS_MES.CORE.Entity;
using DevExpress.Spreadsheet;


namespace CoFAS_MES.CORE.Data
{
    public class LoginProvider : EntityManager<LoginEntity>
    {
        #region 생성자 - LoginProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public LoginProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 메뉴 조회하기 - Login(string pCORP_CD, string pAccount, string pPasswords)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pAccount">사용자아이디</param>
        /// <param name="pPasswords">비밀번호</param>
        /// <returns>조회 목록</returns>
        public DataTable Login_Info(string pAccount, string pPasswords)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            //new MySqlParameter("@CORP_CODE", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@USER_ACCOUNT", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@USER_PASS", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@CORP_CODE", SqlDbType.NVarChar, 10),
                            new SqlParameter("@USER_ACCOUNT", SqlDbType.NVarChar, 50),
                            new SqlParameter("@USER_PASS", SqlDbType.NVarChar, 50)
                        };
                        break;
                    case "ORACLE":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@CORP_CODE", SqlDbType.NVarChar, 10),
                            new OracleParameter("USER_ACCOUNT",OracleDbType.NVarchar2,50),
                            new OracleParameter("USER_PASS",OracleDbType.NVarchar2,50)
                        };
                        break;
                }

                //pDataParameters[0].Value = pCORP_CD;
                pDataParameters[0].Value = pAccount;
                pDataParameters[1].Value = pPasswords;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MainLogin_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "MainLogin_R10(string pAccount, string pPasswords)",
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
        public override LoginEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                LoginEntity pLoginEntity = new LoginEntity();

                pLoginEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pLoginEntity;
            }
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
    public class SystemSettingProvider : EntityManager<SystemSettingEntity>
    {
        #region 생성자 - LoginProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SystemSettingProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region CI 다운로드 하기 - CI_Download()

        /// <summary>
        /// CI 조회하기
        /// </summary>
        /// <returns>조회 목록</returns>
        public DataTable CI_Download()
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                        };
                        break;
                }

                pDataParameters[0].Value = "";

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_SystemSetting_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "CI_Download()",
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
        public override SystemSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SystemSettingEntity pSystemSettingEntity = new SystemSettingEntity();

                pSystemSettingEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pSystemSettingEntity;
            }
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
    public class MenuSettingProvider : EntityManager<MenuSettingEntity>
    {
        #region 생성자 - MenuSettingProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MenuSettingProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 메뉴 조회하기 - Menu_List_Search(string pUserID)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pUserID">사용자아이디</param>
        /// <returns>조회 목록</returns>
        public DataTable Menu_List_Search(string pUserID)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            //new MySqlParameter("@CORP_CODE", MySqlDbType.VarChar,10),
                            new MySqlParameter("@USER_ACCOUNT", MySqlDbType.VarChar,50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@CORP_CODE", SqlDbType.NVarChar, 10),
                            new SqlParameter("@USER_ACCOUNT", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                //pDataParameters[0].Value = pCORP_CD;
                pDataParameters[0].Value = pUserID;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MainMenu_R10", pDataParameters); //USP_MainMenu_R10_T
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Menu_List_Search(string pCORP_CD, string pUserID)",
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
        public override MenuSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MenuSettingEntity pMenuSettingEntity = new MenuSettingEntity();

                //pMenuSettingEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                //pMenuSettingEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드
                //pMenuSettingEntity.USYN_CODE = pDataRow["USYN_CODE"] is DBNull ? string.Empty : pDataRow["USYN_CODE"] as string;  // 유저코드
                //pMenuSettingEntity.MENU_NAME = pDataRow["MENU_NAME"] is DBNull ? string.Empty : pDataRow["MENU_NAME"] as string;  // 메뉴이름
                //pMenuSettingEntity.USYN_MENU = pDataRow["USYN_MENU"] is DBNull ? string.Empty : pDataRow["USYN_MENU"] as string;  // 메뉴코드
                //pMenuSettingEntity.MENU_LVCD = pDataRow["MENU_LVCD"] is DBNull ? string.Empty : pDataRow["MENU_LVCD"] as string;  // 레벨
                //pMenuSettingEntity.MENU_ICON = pDataRow["MENU_ICON"] is DBNull ? string.Empty : pDataRow["MENU_ICON"] as string;  // 아이콘
                //pMenuSettingEntity.MENU_FORM = pDataRow["MENU_FORM"] is DBNull ? string.Empty : pDataRow["MENU_FORM"] as string;  // 아이콘
                //pMenuSettingEntity.USYN_USYN = pDataRow["USYN_USYN"] is DBNull ? string.Empty : pDataRow["USYN_USYN"] as string;  // 회사코드
                //pMenuSettingEntity.USYN_INIT = pDataRow["USYN_INIT"] is DBNull ? "N" : pDataRow["USYN_INIT"] as string;  // 회사코드
                //pMenuSettingEntity.USYN_SRCH = pDataRow["USYN_SRCH"] is DBNull ? "N" : pDataRow["USYN_SRCH"] as string;  // 회사코드
                //pMenuSettingEntity.USYN_SAVE = pDataRow["USYN_SAVE"] is DBNull ? "N" : pDataRow["USYN_SAVE"] as string;  // 회사코드
                //pMenuSettingEntity.USYN_DELE = pDataRow["USYN_DELE"] is DBNull ? "N" : pDataRow["USYN_DELE"] as string;  // 회사코드
                //pMenuSettingEntity.USYN_PRIV = pDataRow["USYN_PRIV"] is DBNull ? "N" : pDataRow["USYN_PRIV"] as string;  // 회사코드
                //pMenuSettingEntity.USYN_PRIT = pDataRow["USYN_PRIT"] is DBNull ? "N" : pDataRow["USYN_PRIT"] as string;  // 회사코드
                //pMenuSettingEntity.USYN_EXPT = pDataRow["USYN_EXPT"] is DBNull ? "N" : pDataRow["USYN_EXPT"] as string;  // 회사코드
                //pMenuSettingEntity.USYN_IMPT = pDataRow["USYN_IMPT"] is DBNull ? "N" : pDataRow["USYN_IMPT"] as string;  // 회사코드
                //pMenuSettingEntity.USYN_NOTE = pDataRow["USYN_NOTE"] is DBNull ? "N" : pDataRow["USYN_NOTE"] as string;  // 회사코드
                //pMenuSettingEntity.MENU_SORT = pDataRow["MENU_SORT"] is DBNull ? "N" : pDataRow["MENU_SORT"] as string;  // 회사코드

                return pMenuSettingEntity;
            }
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
    public class FavoritesMenuSettingProvider : EntityManager<FavoritesMenuSettingEntity>
    {
        #region 생성자 - FavoritesSettingProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public FavoritesMenuSettingProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 즐겨 찾기 메뉴 조회하기 - Favorites_Menu_Search(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pUserID">사용자아이디</param>
        /// <param name="pUserID">사용자아이디</param>
        /// <returns>조회 목록</returns>
        public DataTable Favorites_Menu_Search(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                           // new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                            new MySqlParameter("@v_user_account", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_menu_no", MySqlDbType.Int32)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                           // new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_menu_no", SqlDbType.Int)
                        };
                        break;
                }

                //pDataParameters[0].Value = pFavoritesMenuSettingEntity.CORP_CODE;
                pDataParameters[0].Value = pFavoritesMenuSettingEntity.USER_CODE;
                pDataParameters[1].Value = pFavoritesMenuSettingEntity.MENU_NO;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MyMenuBook_R10", pDataParameters);
                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Favorites_Menu_Search(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 즐겨찾기 정보 저장하기 - Favorites_Menu_Save(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pFavoritesMenuSettingEntity"></param>
        /// <returns></returns>
        public bool Favorites_Menu_Save(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)
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
                               // new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                                new MySqlParameter("@v_user_account", MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_menu_no", MySqlDbType.Int32)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_user_account", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_menu_no", SqlDbType.Int)
                        };
                        break;
                }

                //pDataParameters[0].Value = pFavoritesMenuSettingEntity.CORP_CODE;
                pDataParameters[0].Value = pFavoritesMenuSettingEntity.CRUD;
                pDataParameters[1].Value = pFavoritesMenuSettingEntity.USER_CODE;
                pDataParameters[2].Value = pFavoritesMenuSettingEntity.MENU_NO;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_MyMenuBook_I10", pDataParameters);

                if (pDataTable.Rows[0][0].ToString() != "00")
                {
                    pErrorYN = true;
                }

                pFavoritesMenuSettingEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                pFavoritesMenuSettingEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                pFavoritesMenuSettingEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                pFavoritesMenuSettingEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                pFavoritesMenuSettingEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();

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
                    "Favorites_Menu_Save(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)",
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
        public override FavoritesMenuSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                FavoritesMenuSettingEntity pFavoritesMenuSettingEntity = new FavoritesMenuSettingEntity();

                pFavoritesMenuSettingEntity.CORP_CODE = pDataRow["CORP_CODE"] is DBNull ? string.Empty : pDataRow["CORP_CODE"] as string;  // 회사코드

                return pFavoritesMenuSettingEntity;
            }
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
    public class LanguageProvider : EntityManager<LanguageEntity>
    {
        #region 생성자 - LanguageProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public LanguageProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 화면 언어 조회하기 - Language_Info(string pCORP_CD, string pWINDOW_NAME, string pLANGUAGE_TYPE)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pLANGUAGE_TYPE">언어 구분</param>
        /// <returns>조회 목록</returns>
        public DataTable Language_Info(string pWINDOW_NAME, string pLANGUAGE_TYPE)
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
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pWINDOW_NAME;
                pDataParameters[1].Value = pLANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Language_Info_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Language_Info(string pWINDOW_NAME, string pLANGUAGE_TYPE)",
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
        public override LanguageEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                LanguageEntity pLanguageEntity = new LanguageEntity();

                //pLanguageEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pLanguageEntity;
            }
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
    public class MessageProvider : EntityManager<MessageEntity>
    {
        #region 생성자 - LanguageProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MessageProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 공통 메세지 조회하기 - MessageValue_Info(string pLANGUAGE_TYPE)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pLANGUAGE_TYPE">언어 구분</param>
        /// <param name="pLANGUAGE_TYPE">언어 구분</param>
        /// <returns>조회 목록</returns>
        public DataTable MessageValue_Info(string pLANGUAGE_TYPE)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pLANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Message_Info_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "MessageValue_Info(string pLANGUAGE_TYPE)",
                    pException
                );
            }
        }

        public DataTable MessageValue_Info(string pLANGUAGE_TYPE, string pWINDOW_NAME)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@tbl_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@base_group_col", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@pivot_col", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@value_col", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@condition_string", MySqlDbType.VarChar, 1000),
                            new MySqlParameter("@order_by", MySqlDbType.VarChar, 1000)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@tbl_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@base_group_col", SqlDbType.NVarChar, 100),
                            new SqlParameter("@pivot_col", SqlDbType.NVarChar, 100),
                            new SqlParameter("@value_col", SqlDbType.NVarChar, 100),
                            new SqlParameter("@condition_string", SqlDbType.NVarChar, 1000),
                            new SqlParameter("@order_by", SqlDbType.NVarChar, 1000)
                        };
                        break;

                }

                pDataParameters[0].Value = "message_info_mst";
                pDataParameters[1].Value = "language_type";
                pDataParameters[2].Value = "message_code";
                pDataParameters[3].Value = "message_value";
                //'language_type = ''한국어'' and window_name in (''ProcessConfigurationRegister'')'
                string strWhere = string.Format("language_type = '{0}' and window_name in ('{1}')", pLANGUAGE_TYPE, pWINDOW_NAME);
                //string strWhere = string.Format("window_name = '{0}'", pWINDOW_NAME);
                pDataParameters[4].Value = strWhere;


                pDataParameters[5].Value = "";


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_PIVOT_RETURN_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "MessageValue_Info(string pLANGUAGE_TYPE)",
                    pException
                );
            }
        }

        public DataTable MessageValue_Mst_Info(string pLANGUAGE_TYPE, string pWINDOW_NAME)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@tbl_name", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@base_group_col", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@pivot_col", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@value_col", MySqlDbType.VarChar, 100),
                            new MySqlParameter("@condition_string", MySqlDbType.VarChar, 1000),
                            new MySqlParameter("@order_by", MySqlDbType.VarChar, 1000)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@tbl_name", SqlDbType.NVarChar, 100),
                            new SqlParameter("@base_group_col", SqlDbType.NVarChar, 100),
                            new SqlParameter("@pivot_col", SqlDbType.NVarChar, 100),
                            new SqlParameter("@value_col", SqlDbType.NVarChar, 100),
                            new SqlParameter("@condition_string", SqlDbType.NVarChar, 1000),
                            new SqlParameter("@order_by", SqlDbType.NVarChar, 1000)
                        };
                        break;

                }

                pDataParameters[0].Value = "message_info_mst";
                pDataParameters[1].Value = "language_type";
                pDataParameters[2].Value = "message_code";
                pDataParameters[3].Value = "message_value";
                //'language_type = ''한국어'' and window_name in (''ProcessConfigurationRegister'')'
                string strWhere = string.Format("language_type = '{0}' and window_name in ('frmMain','{1}')", pLANGUAGE_TYPE, pWINDOW_NAME);
                //string strWhere = string.Format("window_name = '{0}'", pWINDOW_NAME);
                pDataParameters[4].Value = strWhere;


                pDataParameters[5].Value = "";


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_PIVOT_RETURN_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "MessageValue_Info(string pLANGUAGE_TYPE)",
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
        public override MessageEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                MessageEntity pMessageEntity = new MessageEntity();

                //pLanguageEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pMessageEntity;
            }
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
    public class DevGridSettingProvider : EntityManager<DevGridSettingEntity>
    {
        #region 생성자 - DevGridSettingProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public DevGridSettingProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 데브 그리드 정보 조회하기 - DevGrid_Info(string pLANGUAGE_TYPE, string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet DevGrid_Info(string pLANGUAGE_TYPE, string pWINDOW_NAME, string pDEV_GRID_NAME)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_grid_name", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_grid_name", SqlDbType.NVarChar, 50)
                        };
                        break;

                }

                pDataParameters[0].Value = pLANGUAGE_TYPE;
                pDataParameters[1].Value = pWINDOW_NAME;
                pDataParameters[2].Value = pDEV_GRID_NAME;


                DataSet  pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_DevGrid_Info_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "DevGrid_Info(string pLANGUAGE_TYPE, string pWINDOW_NAME, string pDEV_GRID_NAME)",
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
        public override DevGridSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                DevGridSettingEntity pDevGridSettingEntity = new DevGridSettingEntity();

                //pDevGridSettingEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pDevGridSettingEntity;
            }
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

    public class SystemLogInfoProvider : EntityManager<SystemLogInfoEntity>
    {
        #region 생성자 - SystemLogInfoProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SystemLogInfoProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 시스템 이벤트 정보 저장 하기 - SystemEventLog_Info_Save(SystemLogInfoEntity pSystemLogInfoEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public bool SystemEventLog_Info_Save(SystemLogInfoEntity pSystemLogInfoEntity)
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
                                new MySqlParameter("@v_log_mst", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_log_detail", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_log_mst", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_log_detail", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000)
                        };
                        break;
                }

                pDataParametersA[0].Value = pSystemLogInfoEntity.CRUD;
                pDataParametersA[1].Value = pSystemLogInfoEntity.USER_CODE;
                pDataParametersA[2].Value = pSystemLogInfoEntity.LOG_MST;
                pDataParametersA[3].Value = pSystemLogInfoEntity.LOG_DETAIL;
                pDataParametersA[4].Value = pSystemLogInfoEntity.REMARK;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_SYSTEM_LOG_INFO_I10", pDataParametersA);

                pSystemLogInfoEntity.ERR_NO = pDataTableA.Rows[0]["ERR_NO"].ToString();
                pSystemLogInfoEntity.ERR_MSG = pDataTableA.Rows[0]["ERR_MSG"].ToString();
                pSystemLogInfoEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
                pSystemLogInfoEntity.RTN_OTHERS = pDataTableA.Rows[0]["RTN_OTHERS"].ToString();


                if (pSystemLogInfoEntity.ERR_NO.ToString() != "00")
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
                    "SystemEventLog_Info_Save(SystemLogInfoEntity pSystemLogInfoEntity)",
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

        #region 시스템 이벤트 정보 저장 하기 - SystemEventLog_Info_Save(string strCRUD, string strUSER_CODE, string strLOG_MST, string strLOG_DETAIL, string strREMARK)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public bool SystemEventLog_Info_Save(string strCRUD, string strUSER_CODE, string strLOG_MST, string strLOG_DETAIL, string strREMARK)
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
                                new MySqlParameter("@v_log_mst", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_log_detail", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_remark", MySqlDbType.VarChar, 1000)
                        };
                        break;

                    case "SQLServer":
                        pDataParametersA = new IDataParameter[]
                        {
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_log_mst", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_log_detail", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_remark", SqlDbType.NVarChar, 1000)
                        };
                        break;
                }

                pDataParametersA[0].Value = strCRUD;
                pDataParametersA[1].Value = strUSER_CODE;
                pDataParametersA[2].Value = strLOG_MST;
                pDataParametersA[3].Value = strLOG_DETAIL;
                pDataParametersA[4].Value = strREMARK;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_SYSTEM_LOG_INFO_I10", pDataParametersA);

                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
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
                    "SystemEventLog_Info_Save(string strCRUD, string strUSER_CODE, string strLOG_MST, string strLOG_DETAIL, string strREMARK)",
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
        public override SystemLogInfoEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SystemLogInfoEntity pSystemLogInfoEntity = new SystemLogInfoEntity();

                //pDevGridSettingEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pSystemLogInfoEntity;
            }
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
    public class XMLDesignProvider : EntityManager<XMLDesignEntity>
    {
        #region 생성자 - XMLDesignProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public XMLDesignProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region XML Design 조회하기 - XMLDesign_Info(string pWINDOW_NAME, string pLANGUAGE_TYPE)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pLANGUAGE_TYPE">언어 구분</param>
        /// <returns>조회 목록</returns>
        public DataTable XMLDesign_Info(string pWINDOW_NAME, string pLANGUAGE_TYPE)
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

                pDataParameters[0].Value = pWINDOW_NAME;
                pDataParameters[1].Value = pLANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_XMLDesign_Info_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "XMLDesign_Info(string pWINDOW_NAME, string pLANGUAGE_TYPE)",
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
        public override XMLDesignEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                XMLDesignEntity pXMLDesignEntity = new XMLDesignEntity();


                return pXMLDesignEntity;
            }
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

    public class WindowPageSettingProvider : EntityManager<WindowPageSettingEntity>
    {
        #region 생성자 - WindowPageSettingProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WindowPageSettingProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 컨트롤러 정보 조회하기 - Controls_Info(WindowPageSettingEntity pWindowPageSettingEntity)

        /// <summary>
        /// 컨트롤러 조회하기
        /// </summary>
        /// <param name="pWindowPageSettingEntity">엔티티 값</param>
        /// <returns>조회 목록</returns>
        public DataTable Controls_Info(WindowPageSettingEntity pWindowPageSettingEntity)
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
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                            
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWindowPageSettingEntity.CRUD;
                pDataParameters[1].Value = pWindowPageSettingEntity.WINDOW_NAME;
                pDataParameters[2].Value = pWindowPageSettingEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Page_Setting_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Controls_Info(WindowPageSettingEntity pWindowPageSettingEntity)",
                    pException
                );
            }
        }


        #endregion

        #region 컨트롤러 정보 저장하기 - Controls_Info_Save(WindowPageSettingEntity pWindowPageSettingEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pWindowPageSettingEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Controls_Info_Save(WindowPageSettingEntity pWindowPageSettingEntity, DataTable dt)
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
                                //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_field_code", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_field_name", MySqlDbType.VarChar, 100)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_field_code", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_field_name", SqlDbType.NVarChar, 100)
                                };
                                break;

                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pWindowPageSettingEntity.USER_CODE;
                        pDataParameters[2].Value = pWindowPageSettingEntity.LANGUAGE_TYPE;
                        pDataParameters[3].Value = pWindowPageSettingEntity.WINDOW_NAME;
                        pDataParameters[4].Value = dt.Rows[a]["FIELD_CODE"].ToString();
                        pDataParameters[5].Value = dt.Rows[a]["FIELD_NAME"].ToString();

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Page_Setting_I10", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pWindowPageSettingEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pWindowPageSettingEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pWindowPageSettingEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pWindowPageSettingEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pWindowPageSettingEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Controls_Info_Save(WindowPageSettingEntity pWindowPageSettingEntity, DataTable dt)",
                    pException
                );
            }

            return pErrorYN;
        }

        #endregion


        #region 그리드 마스터 정보 조회하기 - Grid_MST_Info(WindowPageSettingEntity pWindowPageSettingEntity)

        /// <summary>
        /// 그리드 마스터 조회하기
        /// </summary>
        /// <param name="pWindowPageSettingEntity">엔티티 값</param>
        /// <returns>조회 목록</returns>
        public DataTable Grid_MST_Info(WindowPageSettingEntity pWindowPageSettingEntity)
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
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pWindowPageSettingEntity.CRUD;
                pDataParameters[1].Value = pWindowPageSettingEntity.WINDOW_NAME;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Page_Setting_R20", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Grid_MST_Info(WindowPageSettingEntity pWindowPageSettingEntity)",
                    pException
                );
            }
        }


        #endregion

        #region 그리드 상세 정보 조회하기 - Grid_Detail_Info(WindowPageSettingEntity pWindowPageSettingEntity)

        /// <summary>
        /// 그리드 상세 정보 조회하기
        /// </summary>
        /// <param name="pWindowPageSettingEntity">엔티티 값</param>
        /// <returns>조회 목록</returns>
        public DataTable Grid_Detail_Info(WindowPageSettingEntity pWindowPageSettingEntity)
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
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_grid_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_grid_name", SqlDbType.NVarChar, 50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)

                        };
                        break;
                }

                pDataParameters[0].Value = pWindowPageSettingEntity.CRUD;
                pDataParameters[1].Value = pWindowPageSettingEntity.WINDOW_NAME;
                pDataParameters[2].Value = pWindowPageSettingEntity.GRID_NAME;
                pDataParameters[3].Value = pWindowPageSettingEntity.LANGUAGE_TYPE;


                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Page_Setting_R30", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "Grid_Detail_Info(WindowPageSettingEntity pWindowPageSettingEntity)",
                    pException
                );
            }
        }


        #endregion

        #region 그리드 정보 저장하기 - Grid_Info_Save(WindowPageSettingEntity pWindowPageSettingEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pWindowPageSettingEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Grid_Info_Save(WindowPageSettingEntity pWindowPageSettingEntity, DataTable dt)
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
                                //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar, 10),
                                new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code", MySqlDbType.VarChar, 20),
                                new MySqlParameter("@v_window_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_grid_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_column_name", MySqlDbType.VarChar, 50),
                                new MySqlParameter("@v_column_caption", MySqlDbType.VarChar, 100),
                                new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                                };
                                break;

                            case "SQLServer":
                                pDataParameters = new IDataParameter[]
                                {
                                //new SqlParameter("@v_corp_code", SqlDbType.NVarChar, 10),
                                new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code", SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_window_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_grid_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_column_name", SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_column_caption", SqlDbType.NVarChar, 100),
                                new SqlParameter("@v_language_type", SqlDbType.NVarChar, 50)
                                };
                                break;
                        }

                        pDataParameters[0].Value = dt.Rows[a]["CRUD"].ToString().ToUpper();
                        pDataParameters[1].Value = pWindowPageSettingEntity.USER_CODE;
                        pDataParameters[2].Value = pWindowPageSettingEntity.WINDOW_NAME;
                        pDataParameters[3].Value = pWindowPageSettingEntity.GRID_NAME;
                        pDataParameters[4].Value = dt.Rows[a]["COLUMN_NAME"].ToString();
                        pDataParameters[5].Value = dt.Rows[a]["COLUMN_CAPTION"].ToString();
                        pDataParameters[6].Value = pWindowPageSettingEntity.LANGUAGE_TYPE;

                        DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Page_Setting_I20", pDataParameters);

                        if (pDataTable.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        pWindowPageSettingEntity.ERR_NO = pDataTable.Rows[0]["ERR_NO"].ToString();
                        pWindowPageSettingEntity.ERR_MSG = pDataTable.Rows[0]["ERR_MSG"].ToString();
                        pWindowPageSettingEntity.RTN_KEY = pDataTable.Rows[0]["RTN_KEY"].ToString();
                        pWindowPageSettingEntity.RTN_SEQ = pDataTable.Rows[0]["RTN_SEQ"].ToString();
                        pWindowPageSettingEntity.RTN_OTHERS = pDataTable.Rows[0]["RTN_OTHERS"].ToString();
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
                    "Controls_Info_Save(WindowPageSettingEntity pWindowPageSettingEntity, DataTable dt)",
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
        public override WindowPageSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WindowPageSettingEntity pWindowPageSettingEntity = new WindowPageSettingEntity();

                pWindowPageSettingEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWindowPageSettingEntity;
            }
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
    public class WindowSheetSettingProvider : EntityManager<WindowSheetSettingEntity>
    {
        #region 생성자 - WindowSheetSettingProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WindowSheetSettingProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        //화면에 맞는 시트 조회
        #region 컨트롤러 정보 조회하기 - SheetMainFind_DisplayData(WindowSheetSettingEntity pWindowSheetSettingEntity)

        /// <summary>
        /// 컨트롤러 조회하기
        /// </summary>
        /// <param name="pWindowPageSettingEntity">엔티티 값</param>
        /// <returns>조회 목록</returns>
        public DataTable SheetMainFind_DisplayData(WindowSheetSettingEntity pWindowSheetSettingEntity)
        {
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

                pDataParameters[0].Value = pWindowSheetSettingEntity.CRUD;
                pDataParameters[1].Value = pWindowSheetSettingEntity.WINDOW_NAME; 



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
                    "SheetMainFind_DisplayData(WindowSheetSettingEntity pWindowSheetSettingEntity)",
                    pException
                );
            }
        }


        #endregion

        //시트 정보 업로드...?


        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override WindowSheetSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WindowSheetSettingEntity pWindowSheetSettingEntity = new WindowSheetSettingEntity();

                pWindowSheetSettingEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pWindowSheetSettingEntity;
            }
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
    public class CommonCodeReturnProvider : EntityManager<CommonCodeReturnEntity>
    {
        #region 생성자 - CommonCodeReturnProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public CommonCodeReturnProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 코드 정보 조회하기 - CommonCode_Return(string pCORP_CD, string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>

        public DataSet CommonCode_Return(string pCRUD, string pLANGUAGE_TYPE , string pSERVICE_NAME, string pFIRST_CODE, string pSECOND_CODE, string pTHIRD_CODE)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            //new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar,1),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_service_name", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_first_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_second_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_third_code", MySqlDbType.VarChar,50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            //new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_service_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_first_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_second_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_third_code", SqlDbType.NVarChar,50)
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pLANGUAGE_TYPE;
                pDataParameters[2].Value = pSERVICE_NAME;
                pDataParameters[3].Value = pFIRST_CODE;
                pDataParameters[4].Value = pSECOND_CODE;
                pDataParameters[5].Value = pTHIRD_CODE;


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_CommonCodeReturn_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "CommonCode_Return(string pCRUD, string pLANGUAGE_TYPE , string pSERVICE_NAME, string pFIRST_CODE, string pSECOND_CODE, string pTHIRD_CODE)",
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
        public override CommonCodeReturnEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                CommonCodeReturnEntity pCommonCodeReturnEntity = new CommonCodeReturnEntity();

                //pCommonCodeReturnEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pCommonCodeReturnEntity;
            }
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

    public class CodePopUpProvider : EntityManager<CodePopUpEntity>
    {
        #region 생성자 - CommonCodeReturnProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public CodePopUpProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 코드 정보 조회하기 - CodePopUp_Return(string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet CodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE, string pSERVICE_NAME, string pCODE_TYPE, string pCODE, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_service_name", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_code_type", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_name", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value1", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value2", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value3", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_service_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_code_type", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_name", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value1", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value2", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value3", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pLANGUAGE_TYPE;
                pDataParameters[2].Value = pSERVICE_NAME;
                pDataParameters[3].Value = pCODE_TYPE;
                pDataParameters[4].Value = pCODE;
                pDataParameters[5].Value = pNAME;
                pDataParameters[6].Value = pVALUE1;
                pDataParameters[7].Value = pVALUE2;
                pDataParameters[8].Value = pVALUE3;
                pDataParameters[9].Value = pUSE_YN;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_CommonCodePopUp_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "CodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE, string pSERVICE_NAME, string pCODE_TYPE, string pCODE, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN)",
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
        public override CodePopUpEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                CodePopUpEntity pCodePopUpEntity = new CodePopUpEntity();

                pCodePopUpEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pCodePopUpEntity;
            }
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

    public class PartCodePopUpProvider : EntityManager<PartCodePopUpEntity>
    {
        #region 생성자 - PartCodePopUpProvider(DBManager pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public PartCodePopUpProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 코드 정보 조회하기 - CodePopUp_Return(string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet PartCodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE, string pSERVICE_NAME, string pPART_CODE, string pVEND_PART_CODE, string pPART_NAME, string pPART_TYPE)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_service_name", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_code_type", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_name", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value1", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value2", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value3", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_service_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_code_type", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_name", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value1", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value2", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value3", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)

                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pLANGUAGE_TYPE;
                pDataParameters[2].Value = pSERVICE_NAME;
                pDataParameters[3].Value = pPART_TYPE;
                pDataParameters[4].Value = pPART_CODE;
                pDataParameters[5].Value = pPART_NAME;
                pDataParameters[6].Value = pVEND_PART_CODE;
                pDataParameters[7].Value = "";
                pDataParameters[8].Value = "";
                pDataParameters[9].Value = "Y";


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_CommonCodePopUp_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "PartCodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE, string pPART_CODE, string pVEND_PART_CODE, string pPART_NAME, string pPART_TYPE)",
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
        public override PartCodePopUpEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                PartCodePopUpEntity pPartCodePopUpEntity = new PartCodePopUpEntity();

                pPartCodePopUpEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pPartCodePopUpEntity;
            }
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

    public class ucReversBOMInfoPopupProvider : EntityManager<CodePopUpEntity>
    {
        #region 생성자 - ucReversBOMInfoPopupProvider(DBManager pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucReversBOMInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 코드 정보 조회하기 - CodePopUp_Return(string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet ucReversBOMInfoPopup_Return(string pCRUD, string pLANGUAGE_TYPE, string pSERVICE_NAME, string pPART_CODE, string pVEND_PART_CODE, string pPART_NAME, string pPART_TYPE)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar,50)

                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pLANGUAGE_TYPE;
                pDataParameters[2].Value = pPART_CODE;


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucReversBOMInfoPopup_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "ucReversBOMInfoPopup_Return(string pCRUD, string pLANGUAGE_TYPE, string pPART_CODE, string pVEND_PART_CODE, string pPART_NAME, string pPART_TYPE)",
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
        public override CodePopUpEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                CodePopUpEntity pCodePopUpEntity = new CodePopUpEntity();

                pCodePopUpEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pCodePopUpEntity;
            }
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

    public class SubMonitoringProvider : EntityManager<SubMonitoringEntity>
    {
        #region 생성자 - CommonCodeReturnProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public SubMonitoringProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 코드 정보 조회하기 - SubMonitoring_info(string pCORP_CD)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet SubMonitoring_info(string pCORP_CODE)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                        };
                        break;

                    default:
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                        };
                        break;
                }

                pDataParameters[0].Value = pCORP_CODE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_SubMonitoring_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "DevGrid_Info(string pCORP_CD, string pWINDOW_NAME, string pDEV_GRID_NAME)",
                    pException
                );
            }
        }
        #endregion

        #region 코드 정보 조회하기 - SubMonitoring_info(string pCORP_CD)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet SubMonitoring_info_chart(string pCORP_CODE)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_corp_code", SqlDbType.NVarChar,10),
                        };
                        break;

                    default:
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_corp_code", MySqlDbType.VarChar,10),
                        };
                        break;
                }

                pDataParameters[0].Value = pCORP_CODE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_SubMonitoring_R20", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "DevGrid_Info(string pCORP_CD, string pWINDOW_NAME, string pDEV_GRID_NAME)",
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
        public override SubMonitoringEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                SubMonitoringEntity pSubMonitoringEntity = new SubMonitoringEntity();

                pSubMonitoringEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pSubMonitoringEntity;
            }
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
    public class VendCodeInfoPopupProvider : EntityManager<VendCodeInfoPopupEntity>
    {
        #region 생성자 - CommonCodeReturnProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public VendCodeInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 코드 정보 조회하기 - VendCodeInfoPopup_Return(string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet VendCodeInfoPopup_Return(string pCRUD, string pVEND_CODE, string pVEND_NAME, string pVEND_TYPE)
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
                            new MySqlParameter("@v_vend_type", MySqlDbType.VarChar,20),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar,100),


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_vend_type", SqlDbType.NVarChar,20),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar,100)

                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pVEND_TYPE;
                pDataParameters[2].Value = pVEND_CODE;
                pDataParameters[3].Value = pVEND_NAME;

                //18.06.21
                //USP_VendCodeInfoPopup_R10 -> USP_ucVendCodeInfoPopup_R10
                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucVendCodeInfoPopup_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "DevGrid_Info(string pWINDOW_NAME, string pDEV_GRID_NAME)",
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
        public override VendCodeInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                VendCodeInfoPopupEntity pVendCodeInfoPopupEntity = new VendCodeInfoPopupEntity();

                pVendCodeInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pVendCodeInfoPopupEntity;
            }
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
    public class VendCodeInfoPopup_T02Provider : EntityManager<VendCodeInfoPopup_T02Entity>
    {
        #region 생성자 - VendCodeInfoPopup_T02Provider(DBManager pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public VendCodeInfoPopup_T02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 코드 정보 조회하기 - VendCodeInfoPopup_Return(string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet VendCodeInfoPopup_Return(string pCRUD, string pVEND_CODE, string pVEND_NAME, string pSERVICE_NAME, string pLANGUAGE)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_service_name", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_code_type", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_name", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value1", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value2", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value3", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_service_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_code_type", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_name", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value1", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value2", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value3", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)

                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pLANGUAGE;
                pDataParameters[2].Value = pSERVICE_NAME;
                pDataParameters[3].Value = "";
                pDataParameters[4].Value = pVEND_CODE;
                pDataParameters[5].Value = pVEND_NAME;
                pDataParameters[6].Value = "";
                pDataParameters[7].Value = "";
                pDataParameters[8].Value = "";
                pDataParameters[9].Value = "";

                //18.06.21
                //USP_VendCodeInfoPopup_R10 -> USP_ucVendCodeInfoPopup_R10
                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_CommonCodePopUp_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "VendCodeInfoPopup_Return(string pCRUD, string pVEND_CODE, string pVEND_NAME, string pVEND_TYPE)",
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
        public override VendCodeInfoPopup_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                VendCodeInfoPopup_T02Entity pVendCodeInfoPopup_T02Entity = new VendCodeInfoPopup_T02Entity();

                pVendCodeInfoPopup_T02Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pVendCodeInfoPopup_T02Entity;
            }
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

    public class VendCodeInfoPopup_T04Provider : EntityManager<VendCodeInfoPopup_T04Entity>
    {
        #region 생성자 - VendCodeInfoPopup_T04Provider(DBManager pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public VendCodeInfoPopup_T04Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 코드 정보 조회하기 - VendCodeInfoPopup_Return(string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet VendCodeInfoPopup_Return(string pCRUD, string pVEND_CODE, string pVEND_NAME, string pSERVICE_NAME, string pLANGUAGE)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_service_name", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_code_type", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_name", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value1", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value2", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value3", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_service_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_code_type", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_name", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value1", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value2", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value3", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)

                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pLANGUAGE;
                pDataParameters[2].Value = pSERVICE_NAME;
                pDataParameters[3].Value = "";              //v_code_type
                pDataParameters[4].Value = pVEND_CODE;      //v_code
                pDataParameters[5].Value = pVEND_NAME;      //v_name
                pDataParameters[6].Value = "";              //v_value_1
                pDataParameters[7].Value = "";              //v_value_2
                pDataParameters[8].Value = "";              //v_value_3
                pDataParameters[9].Value = "";              //v_use_yn

                //18.06.21
                //USP_VendCodeInfoPopup_R10 -> USP_ucVendCodeInfoPopup_R10
                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_CommonCodePopUp_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "VendCodeInfoPopup_Return(string pCRUD, string pVEND_CODE, string pVEND_NAME, string pVEND_TYPE)",
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
        public override VendCodeInfoPopup_T04Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                VendCodeInfoPopup_T04Entity pVendCodeInfoPopup_T04Entity = new VendCodeInfoPopup_T04Entity();

                pVendCodeInfoPopup_T04Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pVendCodeInfoPopup_T04Entity;
            }
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


    public class OrderInfoPopupProvider : EntityManager<VendCodeInfoPopupEntity>
    {
        #region 생성자 - CommonCodeReturnProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public OrderInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 코드 정보 조회하기 - OrderInfoPopup_Return(string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet OrderInfoPopup_Return(string pCRUD, string pFROM_DATE, string pTO_DATE, string pPART_NAME, string pVEND_NAME)
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
                            new MySqlParameter("@v_order_date", MySqlDbType.VarChar,20),
                            new MySqlParameter("@v_to_date", MySqlDbType.VarChar,20),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar,50),


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_order_date", SqlDbType.NVarChar,20),
                            new SqlParameter("@v_to_date", SqlDbType.NVarChar,20),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar,50)

                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pFROM_DATE;
                pDataParameters[2].Value = pTO_DATE;
                pDataParameters[3].Value = pPART_NAME;
                pDataParameters[4].Value = pVEND_NAME;

                //USP_OrderInfoPopup_R10 -> USP_ucMaterialOrderInfoPopup_R10
                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucMaterialOrderInfoPopup_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "DevGrid_Info(string pWINDOW_NAME, string pDEV_GRID_NAME)",
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
        public override VendCodeInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                VendCodeInfoPopupEntity pVendCodeInfoPopupEntity = new VendCodeInfoPopupEntity();

                pVendCodeInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pVendCodeInfoPopupEntity;
            }
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

    //JobOrderInfoPopupProvider - > ProductionOrderInfoPopupProvider  // ProductionOrderInfoPopupEntity -> ProductionOrderInfoPopupEntity
    public class ProductionOrderInfoPopupProvider : EntityManager<ProductionOrderInfoPopupEntity>  //작업지시 조회 팝업
    {
        #region 생성자 - CommonCodeReturnProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductionOrderInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 코드 정보 조회하기 - ProductionOrderInfoPopup_Return(string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet ProductionOrderInfoPopup_Return(string pJOBORDER_CD, string pJOB_FRIST_DATE, string pJOB_LAST_DATE, string pVEND_CODE, string pVEND_NAME, string pMATERIAL_CD, string pMATERIAL_NM)
        {
            try
            {
                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_joborder", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_order_frist_date", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_order_last_date", MySqlDbType.VarChar,8),
                            new MySqlParameter("@v_vend_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_material_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_material_name", MySqlDbType.VarChar,50),
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_joborder", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_order_frist_date", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_order_last_date", SqlDbType.NVarChar,8),
                            new SqlParameter("@v_vend_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_material_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_material_name", SqlDbType.NVarChar,50)

                        };
                        break;
                }

                pDataParameters[0].Value = pJOBORDER_CD;
                pDataParameters[1].Value = pJOB_FRIST_DATE;
                pDataParameters[2].Value = pJOB_LAST_DATE;
                pDataParameters[3].Value = pVEND_CODE;
                pDataParameters[4].Value = pVEND_NAME;
                pDataParameters[5].Value = pMATERIAL_CD;
                pDataParameters[6].Value = pMATERIAL_NM;

                //18.06.21
                //USP_ProductionOrderInfoPopup_R10 -> USP_ucProductionOrderInfoPopup_R10
                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucProductionOrderInfoPopup_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "DevGrid_Info(string pWINDOW_NAME, string pDEV_GRID_NAME)",
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
        public override ProductionOrderInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductionOrderInfoPopupEntity pVendCodeInfoPopupEntity = new ProductionOrderInfoPopupEntity();

                pVendCodeInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pVendCodeInfoPopupEntity;
            }
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
    public class VendCostInfoPopupProvider : EntityManager<VendCostInfoPopupEntity>
    {
        #region 생성자 - CommonCodeReturnProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public VendCostInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 품목코드 정보 조회하기 - VendCostInfoPopup_Return(string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet VendCostInfoPopup_Main_Return(string pCRUD, string pPART_TYPE, string pPART_CODE , string pPART_NAME, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN, string pLANGUAGE_TYPE)
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
                            new MySqlParameter("@v_part_type", MySqlDbType.VarChar,20),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar, 50)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_part_type", SqlDbType.NVarChar,20),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_language_type",    SqlDbType.NVarChar, 50)
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPART_TYPE;
                pDataParameters[2].Value = pPART_CODE;
                pDataParameters[3].Value = pPART_NAME;
                pDataParameters[4].Value = pLANGUAGE_TYPE;

                //18.06.21
                //USP_VendCostInfoPopup_R10 -> USP_ucVendCostInfoPopup_R10
                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucVendCostInfoPopup_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "DevGrid_Info(string pWINDOW_NAME, string pDEV_GRID_NAME)",
                    pException
                );
            }
        }
        #endregion
        #region 단가별 업체 단가 정보 조회하기 - VendCostInfoPopup_Return(string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet VendCostInfoPopup_Sub_Return(string pCRUD,string pPART_CODE, string pPART_TYPE,string pLANGUAGE_TYPE)
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
                            new MySqlParameter("@v_part_type", MySqlDbType.VarChar,20),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50)

                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_part_type", SqlDbType.NVarChar,20),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50)
                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pPART_TYPE;
                pDataParameters[2].Value = pPART_CODE;
                pDataParameters[3].Value = pLANGUAGE_TYPE;

                //18.06.21
                //USP_VendCostInfoPopup_R20 -> USP_ucVendCostInfoPopup_R20

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucVendCostInfoPopup_R20", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "DevGrid_Info(string pWINDOW_NAME, string pDEV_GRID_NAME)",
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
        public override VendCostInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                VendCostInfoPopupEntity pVendCostInfoPopupEntity = new VendCostInfoPopupEntity();

                pVendCostInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pVendCostInfoPopupEntity;
            }
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
    public class ProductPlanInfoPopupProvider : EntityManager<ProductPlanInfoPopupEntity>
    {
        #region 생성자 - ProductPlanInfoPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductPlanInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ProductPlanInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductPlanInfoPopupEntity pProductPlanInfoPopupEntity = new ProductPlanInfoPopupEntity();
                pProductPlanInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pProductPlanInfoPopupEntity;
            }
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

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucProductPlanInfoPopup_R10", pDataParameters);
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

        #region 정보 저장하기 - ProductPlanInfo_Save(ProductPlanInfoPopupEntity pProductPlanInfoPopupEntity, DataTable pDataTable)


        public DataTable ProductPlanInfo_Save(ProductPlanInfoPopupEntity pProductPlanInfoPopupEntity, DataTable pDataTable)
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

                for(int i = 0; i < pDataTable.Rows.Count; i++)
                {
                    if(Convert.ToDecimal(pDataTable.Rows[i]["PLAN_QTY"].ToString()) > 0)
                    {
                        pDataParametersA[0].Value = pProductPlanInfoPopupEntity.CRUD;
                        pDataParametersA[1].Value = pProductPlanInfoPopupEntity.USER_CODE;
                        if (i == 0 || pProductPlanInfoPopupEntity.RTN_KEY == null)
                            pDataParametersA[2].Value = "";
                        else
                            pDataParametersA[2].Value = pProductPlanInfoPopupEntity.RTN_KEY;

                        pDataParametersA[3].Value = pDataTable.Rows[i]["TODAY"].ToString();
                        pDataParametersA[4].Value = "";
                        pDataParametersA[5].Value = pProductPlanInfoPopupEntity.PART_CODE_MST;
                        pDataParametersA[6].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                        pDataParametersA[7].Value = pDataTable.Rows[i]["PLAN_QTY"].ToString();
                        pDataParametersA[8].Value = pProductPlanInfoPopupEntity.CONTRACT_ID;
                        pDataParametersA[9].Value = pDataTable.Rows[i]["REMARK"].ToString();
                        pDataParametersA[10].Value = "Y";

                        pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProductPlanInfoPopup_I10", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pProductPlanInfoPopupEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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

    public class ProductPlanInfoPopup_T50Provider : EntityManager<ProductPlanInfoPopup_T50Entity>
    {
        #region 생성자 - ProductPlanInfoPopup_T50Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ProductPlanInfoPopup_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ProductPlanInfoPopup_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ProductPlanInfoPopup_T50Entity pProductPlanInfoPopup_T50Entity = new ProductPlanInfoPopup_T50Entity();
                pProductPlanInfoPopup_T50Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pProductPlanInfoPopup_T50Entity;
            }
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

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucProductPlanInfoPopup_T50_R10", pDataParameters);
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

        #region 정보 저장하기 - ProductPlanInfo_Save(ProductPlanInfoPopup_T50Entity pProductPlanInfoPopup_T50Entity, DataTable pDataTable)


        public DataTable ProductPlanInfo_Save(ProductPlanInfoPopup_T50Entity pProductPlanInfoPopup_T50Entity, DataTable pDataTable)
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
                        pDataParametersA[0].Value = pProductPlanInfoPopup_T50Entity.CRUD;
                        pDataParametersA[1].Value = pProductPlanInfoPopup_T50Entity.USER_CODE;
                        if (i == 0 || pProductPlanInfoPopup_T50Entity.RTN_KEY == null)
                            pDataParametersA[2].Value = "";
                        else
                            pDataParametersA[2].Value = pProductPlanInfoPopup_T50Entity.RTN_KEY;

                        pDataParametersA[3].Value = pDataTable.Rows[i]["TODAY"].ToString();
                        pDataParametersA[4].Value = "";
                        pDataParametersA[5].Value = pProductPlanInfoPopup_T50Entity.PART_CODE_MST;
                        pDataParametersA[6].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                        pDataParametersA[7].Value = pDataTable.Rows[i]["PLAN_QTY"].ToString();
                        pDataParametersA[8].Value = pProductPlanInfoPopup_T50Entity.CONTRACT_ID;
                        pDataParametersA[9].Value = pDataTable.Rows[i]["REMARK"].ToString();
                        pDataParametersA[10].Value = "Y";

                        pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucProductPlanInfoPopup_T50_I10", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pProductPlanInfoPopup_T50Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
    public class ucProductionOrderInfoPopup_T02Provider : EntityManager<ucProductionOrderInfoPopup_T02_Entity>
    {
        #region 생성자 - ucProductionOrderInfoPopup_T02Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucProductionOrderInfoPopup_T02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기

        public override ucProductionOrderInfoPopup_T02_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucProductionOrderInfoPopup_T02_Entity pucProductionOrderInfoPopup_T02_Entity = new ucProductionOrderInfoPopup_T02_Entity();
                pucProductionOrderInfoPopup_T02_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucProductionOrderInfoPopup_T02_Entity;
            }
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

        public DataSet ucProductonOrderInfoPopup_T02_Return(ucProductionOrderInfoPopup_T02_Entity pucProductionOrderInfoPopup_T02_Entity)
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

                pDataParameters[0].Value = pucProductionOrderInfoPopup_T02_Entity.CRUD;
                pDataParameters[1].Value = pucProductionOrderInfoPopup_T02_Entity.DATE_FROM;
                pDataParameters[2].Value = pucProductionOrderInfoPopup_T02_Entity.DATE_TO;
                pDataParameters[3].Value = pucProductionOrderInfoPopup_T02_Entity.PART_CODE;
                pDataParameters[4].Value = pucProductionOrderInfoPopup_T02_Entity.PART_NAME;
                pDataParameters[5].Value = pucProductionOrderInfoPopup_T02_Entity.VEND_CODE;
                pDataParameters[6].Value = pucProductionOrderInfoPopup_T02_Entity.VEND_NAME;
                pDataParameters[7].Value = pucProductionOrderInfoPopup_T02_Entity.LANGUAGE_TYPE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "ucProductonOrderInfoPopup_T02_R10", pDataParameters);
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
    public class ucProductionOrderInfoPopup_T03Provider : EntityManager<ucProductionOrderInfoPopup_T03_Entity>
    {
        #region 생성자 - ucProductionOrderInfoPopup_T03Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucProductionOrderInfoPopup_T03Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기

        public override ucProductionOrderInfoPopup_T03_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucProductionOrderInfoPopup_T03_Entity pucProductionOrderInfoPopup_T03_Entity = new ucProductionOrderInfoPopup_T03_Entity();
                pucProductionOrderInfoPopup_T03_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucProductionOrderInfoPopup_T03_Entity;
            }
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

        public DataSet ucProductonOrderInfoPopup_T02_Return(ucProductionOrderInfoPopup_T03_Entity pucProductionOrderInfoPopup_T03_Entity)
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

                pDataParameters[0].Value = pucProductionOrderInfoPopup_T03_Entity.CRUD;
                pDataParameters[1].Value = pucProductionOrderInfoPopup_T03_Entity.DATE_FROM;
                pDataParameters[2].Value = pucProductionOrderInfoPopup_T03_Entity.DATE_TO;
                pDataParameters[3].Value = pucProductionOrderInfoPopup_T03_Entity.PART_CODE;
                pDataParameters[4].Value = pucProductionOrderInfoPopup_T03_Entity.PART_NAME;
                pDataParameters[5].Value = pucProductionOrderInfoPopup_T03_Entity.VEND_CODE;
                pDataParameters[6].Value = pucProductionOrderInfoPopup_T03_Entity.VEND_NAME;
                pDataParameters[7].Value = pucProductionOrderInfoPopup_T03_Entity.LANGUAGE_TYPE;
                
                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucProductonOrderInfoPopup_T03_R10", pDataParameters);
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
    public class WorkOrderInfoPopupProvider : EntityManager<WorkOrderInfoPopupEntity>
    {
        #region 생성자 - WorkOrderInfoPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public WorkOrderInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override WorkOrderInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                WorkOrderInfoPopupEntity pWorkOrderInfoPopupEntity = new WorkOrderInfoPopupEntity();
                pWorkOrderInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pWorkOrderInfoPopupEntity;
            }
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

        public DataSet WorkOrderInfo_Return(string pCRUD, string pPLANORDER,string pPARTCODE, WorkOrderInfoPopupEntity pWorkOrderInfoPopupEntity)
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
                pDataParameters[3].Value = pWorkOrderInfoPopupEntity.LANGUAGE_TYPE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_WorkOrderinfoPopup_R10", pDataParameters);
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

        #region 정보 저장하기 - WorkOrderInfo_Save(WorkOrderInfoPopupEntity pWorkOrderInfoPopupEntity, DataTable pDataTable)


        public bool WorkOrderInfo_Save(WorkOrderInfoPopupEntity pWorkOrderInfoPopupEntity, DataTable pDataTable)
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
                        pDataParametersA[0].Value = pWorkOrderInfoPopupEntity.CRUD;
                        pDataParametersA[1].Value = pWorkOrderInfoPopupEntity.USER_CODE;
                        //if (i == 0)
                            pDataParametersA[2].Value = "";
                        //else
                        //    pDataParametersA[2].Value = pWorkOrderInfoPopupEntity.RTN_KEY;
                        if(pDataTable.Rows[i]["PRODUCT_ORDER_DATE"].ToString().Substring(0, 10).Substring(0, 10).Replace("-", "").Length > 8)
                        {
                            pDataParametersA[3].Value = pDataTable.Rows[i]["PRODUCT_ORDER_DATE"].ToString().Substring(0, 10).Replace("/", "");
                        }else
                        {
                            pDataParametersA[3].Value = pDataTable.Rows[i]["PRODUCT_ORDER_DATE"].ToString().Substring(0, 10).Replace("-", "");
                        }
                        pDataParametersA[4].Value = "";
                        pDataParametersA[5].Value = pDataTable.Rows[i]["PART_CODE"].ToString();
                        pDataParametersA[6].Value = pDataTable.Rows[i]["PROCESS_CODE"].ToString();
                        pDataParametersA[7].Value = Convert.ToDecimal(pDataTable.Rows[i]["IN_QTY"].ToString());
                        pDataParametersA[8].Value = pWorkOrderInfoPopupEntity.REFERENCE_ID;
                        pDataParametersA[9].Value = "N";
                        pDataParametersA[10].Value = pDataTable.Rows[i]["WORKCENTER_CODE"].ToString();
                        pDataParametersA[11].Value = "Y";

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucWorkOrderinfoPopup_I10", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pWorkOrderInfoPopupEntity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
    public class ucWorkOrderInfoPopup_T50Provider : EntityManager<ucWorkOrderInfoPopup_T50Entity>
    {
        #region 생성자 - ucWorkOrderInfoPopup_T50Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucWorkOrderInfoPopup_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        public override ucWorkOrderInfoPopup_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity = new ucWorkOrderInfoPopup_T50Entity();
                pucWorkOrderInfoPopup_T50Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucWorkOrderInfoPopup_T50Entity;
            }
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

        public DataSet WorkOrderInfo_Return(string pCRUD, string pPLANORDER, string CONFIGURATION_MST_NAME,string CONFIGURATION_NAME, ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity)
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
                            new MySqlParameter("@v_configuration_mst_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_configuration_name", MySqlDbType.VarChar, 50),
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
                pDataParameters[2].Value = CONFIGURATION_MST_NAME;
                pDataParameters[3].Value = CONFIGURATION_NAME;
                pDataParameters[4].Value = pucWorkOrderInfoPopup_T50Entity.LANGUAGE_TYPE;

                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucWorkOrderinfoPopup_T50_R10", pDataParameters);
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

        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(SheetInfoRegisterEntity pSheetInfoRegisterEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pGridInfoRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity)
        {
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

                pDataParameters[0].Value = pucWorkOrderInfoPopup_T50Entity.CRUD;
                pDataParameters[1].Value = pucWorkOrderInfoPopup_T50Entity.WINDOW_NAME;
                pDataParameters[2].Value = pucWorkOrderInfoPopup_T50Entity.LANGUAGE_TYPE;

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

        public DataSet ucWorkOrderPopup_info_ExcelBinding(ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity)
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

                pDataParameters[0].Value = pucWorkOrderInfoPopup_T50Entity.PRODUCTION_ORDER_ID;
                pDataParameters[1].Value = pucWorkOrderInfoPopup_T50Entity.PART_CODE;


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

        #region 정보 저장하기 - WorkOrderInfo_Save(ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity, DataTable pDataTable)


        public bool WorkOrderInfo_Save(ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity, DataTable pDataTable)
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
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_process_gubun", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_process_name",MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_equipment_group",MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_configuration_seq",MySqlDbType.Int32),
                            new MySqlParameter("@v_remark",MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_carve",MySqlDbType.VarChar, 500),
                            new MySqlParameter("@v_message",MySqlDbType.VarChar, 500)
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
                            new SqlParameter("@v_use_yn", SqlDbType.VarChar, 1),
                            new SqlParameter("@v_process_gubun",SqlDbType.VarChar, 50),
                            new SqlParameter("@v_process_name",SqlDbType.VarChar, 50),
                            new SqlParameter("@v_equipment_code",SqlDbType.VarChar, 50),
                            new SqlParameter("@v_configuration_seq",SqlDbType.VarChar, 50)
                        };
                        break;
                }

                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(pDataTable.Rows[i]["IN_QTY"].ToString()) > 0)
                    {
                        pDataParametersA[0].Value = pucWorkOrderInfoPopup_T50Entity.CRUD;
                        pDataParametersA[1].Value = pucWorkOrderInfoPopup_T50Entity.USER_CODE;
                        //if (i == 0)
                        pDataParametersA[2].Value = pucWorkOrderInfoPopup_T50Entity.RTN_KEY == null ? "" : pucWorkOrderInfoPopup_T50Entity.RTN_KEY;

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
                        pDataParametersA[6].Value = pDataTable.Rows[i]["CONFIGURATION_MST_CODE"].ToString();
                        pDataParametersA[7].Value = Convert.ToDecimal(pDataTable.Rows[i]["IN_QTY"].ToString());
                        pDataParametersA[8].Value = pucWorkOrderInfoPopup_T50Entity.REFERENCE_ID;
                        pDataParametersA[9].Value = "N";
                        pDataParametersA[10].Value = pDataTable.Rows[i]["PROCESS_GROUP"].ToString();
                        pDataParametersA[11].Value = "Y";
                        pDataParametersA[12].Value = pDataTable.Rows[i]["PROCESS_GUBUN"].ToString();
                        pDataParametersA[13].Value = pDataTable.Rows[i]["PROCESS_NAME"].ToString();
                        pDataParametersA[14].Value = pDataTable.Rows[i]["EQUIPMENT_GROUP"].ToString();
                        pDataParametersA[15].Value = pDataTable.Rows[i]["CONFIGURATION_SEQ"].ToString();
                        pDataParametersA[16].Value = pDataTable.Rows[i]["REMARK"].ToString();
                        pDataParametersA[17].Value = pucWorkOrderInfoPopup_T50Entity.CARVE;
                        pDataParametersA[18].Value = pucWorkOrderInfoPopup_T50Entity.MESSAGE;

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucWorkOrderinfoPopup_T50_I10", pDataParametersA);
                        if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                        {
                            pErrorYN = true;
                        }
                        else
                        {
                            pucWorkOrderInfoPopup_T50Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
    public class ucPlanOrderinfoPopupProvider : EntityManager<ucPlanOrderinfoPopup_Entity>
    {
        #region 생성자 - ucPlanOrderinfoPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucPlanOrderinfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기

        public override ucPlanOrderinfoPopup_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucPlanOrderinfoPopup_Entity pucPlanOrderinfoPopup_Entity = new ucPlanOrderinfoPopup_Entity();
                pucPlanOrderinfoPopup_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucPlanOrderinfoPopup_Entity;
            }
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

        public DataSet pucPlanOrderinfoPopup_Return(ucPlanOrderinfoPopup_Entity pucPlanOrderinfoPopup_Entity)
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

                pDataParameters[0].Value = pucPlanOrderinfoPopup_Entity.CRUD;
                pDataParameters[1].Value = pucPlanOrderinfoPopup_Entity.DATE_FROM;
                pDataParameters[2].Value = pucPlanOrderinfoPopup_Entity.DATE_TO;
                pDataParameters[3].Value = pucPlanOrderinfoPopup_Entity.PART_CODE;
                pDataParameters[4].Value = pucPlanOrderinfoPopup_Entity.PART_NAME;
                pDataParameters[5].Value = pucPlanOrderinfoPopup_Entity.PLAN_ORDER_ID;
                pDataParameters[6].Value = pucPlanOrderinfoPopup_Entity.LANGUAGE_TYPE;


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ProductionPlan_POP_R10", pDataParameters);
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

    public class ucPlanOrderinfoPopup_T50Provider : EntityManager<ucPlanOrderinfoPopup_T50_Entity>
    {
        #region 생성자 - ucPlanOrderinfoPopup_T50Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucPlanOrderinfoPopup_T50Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region ○ 개체구하기

        public override ucPlanOrderinfoPopup_T50_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucPlanOrderinfoPopup_T50_Entity pucPlanOrderinfoPopup_T50_Entity = new ucPlanOrderinfoPopup_T50_Entity();
                pucPlanOrderinfoPopup_T50_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucPlanOrderinfoPopup_T50_Entity;
            }
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

        public DataSet pucPlanOrderinfoPopup_T50_Return(ucPlanOrderinfoPopup_T50_Entity pucPlanOrderinfoPopup_T50_Entity)
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
                            new MySqlParameter("@v_configuration_mst_name", MySqlDbType.VarChar, 50),
                            new MySqlParameter("@v_configuration_name", MySqlDbType.VarChar, 50)

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
                        };
                        break;
                }

                pDataParameters[0].Value = pucPlanOrderinfoPopup_T50_Entity.CRUD;
                pDataParameters[1].Value = pucPlanOrderinfoPopup_T50_Entity.DATE_FROM;
                pDataParameters[2].Value = pucPlanOrderinfoPopup_T50_Entity.DATE_TO;
                pDataParameters[3].Value = pucPlanOrderinfoPopup_T50_Entity.PART_CODE;
                pDataParameters[4].Value = pucPlanOrderinfoPopup_T50_Entity.PART_NAME;
                pDataParameters[5].Value = pucPlanOrderinfoPopup_T50_Entity.PLAN_ORDER_ID;
                pDataParameters[6].Value = pucPlanOrderinfoPopup_T50_Entity.CONFIGURATION_MST_NAME;
                pDataParameters[7].Value = pucPlanOrderinfoPopup_T50_Entity.CONFIGURATION_NAME;


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ProductionPlan_POP_T50_R10", pDataParameters);
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

    public class ucWorkResultPopupProvider : EntityManager<ucWorkResultPopup_Entity>
    {
        #region ○ 개체구하기
        public override ucWorkResultPopup_Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucWorkResultPopup_Entity pucWorkResultPopup_Entity = new ucWorkResultPopup_Entity();
                pucWorkResultPopup_Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드
                return pucWorkResultPopup_Entity;
            }
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

        #region ○ 생성자 - ucWorkResultPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucWorkResultPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }

        #endregion

        #region 정보 저장하기 - WorkResultInfo_Save(ucWorkResultPopup_Entity pucWorkResultPopup_Entity)


        public bool WorkResultInfo_Save(ucWorkResultPopup_Entity pucWorkResultPopup_Entity)
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
                            new SqlParameter("@v_option_code", SqlDbType.VarChar,50),
                            new SqlParameter("@v_collection_value", SqlDbType.Decimal),
                            new SqlParameter("@v_collection_value_str", SqlDbType.VarChar, 50),
                            new SqlParameter("@v_user_code", SqlDbType.VarChar, 50)
                        };
                        break;
                }

                pDataParametersA[0].Value = pucWorkResultPopup_Entity.RESOURCE_CODE;
                pDataParametersA[1].Value = pucWorkResultPopup_Entity.COLLECTION_DATE;
                pDataParametersA[2].Value = pucWorkResultPopup_Entity.PROPERTY_VALUE;
                pDataParametersA[3].Value = pucWorkResultPopup_Entity.CONDITION_CODE;
                pDataParametersA[4].Value = pucWorkResultPopup_Entity.OPTION_CODE;
                pDataParametersA[5].Value = pucWorkResultPopup_Entity.COLLECTION_VALUE;
                pDataParametersA[6].Value = pucWorkResultPopup_Entity.COLLECTION_VALUE_STR;
                pDataParametersA[7].Value = pucWorkResultPopup_Entity.USER_CODE;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "SSP_DATA_COLLECTION_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pucWorkResultPopup_Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(ucWorkResultPopup_Entity pucWorkResultPopup_Entity)",
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

        public bool WorkResultInfo_Save_01(ucWorkResultPopup_Entity pucWorkResultPopup_Entity)
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

                pDataParametersA[0].Value = pucWorkResultPopup_Entity.CRUD;
                pDataParametersA[1].Value = pucWorkResultPopup_Entity.USER_CODE;
                pDataParametersA[2].Value = pucWorkResultPopup_Entity.PRODUCTION_ORDER_ID;
                pDataParametersA[3].Value = pucWorkResultPopup_Entity.COMPLETE_YN;

                DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_WorkResultRegister_I10", pDataParametersA);
                if (pDataTableA.Rows[0]["ERR_NO"].ToString() != "00")
                {
                    pErrorYN = true;
                }
                else
                {
                    pucWorkResultPopup_Entity.RTN_KEY = pDataTableA.Rows[0]["RTN_KEY"].ToString();
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
                    "WorkResultInfo_Save(ucWorkResultPopup_Entity pucWorkResultPopup_Entity)",
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

    public class NoticeProvider : EntityManager<NoticeEntity>
    {
        #region 생성자 - NoticeProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public NoticeProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - Notice_Info_Mst(NoticeEntity pNoticeEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pNoticeEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Notice_Info_Mst(NoticeEntity pNoticeEntity)
        {
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

                pDataParameters[0].Value = pNoticeEntity.CRUD;
                pDataParameters[1].Value = pNoticeEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_Notice_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
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

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override NoticeEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                NoticeEntity pNoticeRegisterEntity = new NoticeEntity();

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

    public class MaterialOrderInfoPopup_T01Provider : EntityManager<VendCodeInfoPopupEntity>
    {
        #region 생성자 - CommonCodeReturnProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public MaterialOrderInfoPopup_T01Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 코드 정보 조회하기 (시험검사용 발주 항목 조회) - OrderInfoPopup_Return(string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet OrderInfoPopup_T01_Return(string pCRUD, string pFROM_DATE, string pTO_DATE, string pPART_CODE, string pPART_NAME, string pVEND_NAME, string pPART_TYPE)
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
                            new MySqlParameter("@v_order_date", MySqlDbType.VarChar,20),
                            new MySqlParameter("@v_to_date", MySqlDbType.VarChar,20),
                            new MySqlParameter("@v_part_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_name", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_vend_name", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_part_type", MySqlDbType.VarChar,50)


                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_order_date", SqlDbType.NVarChar,20),
                            new SqlParameter("@v_to_date", SqlDbType.NVarChar,20),
                            new SqlParameter("@v_part_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_part_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_vend_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_part_type", SqlDbType.NVarChar,50)

                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pFROM_DATE;
                pDataParameters[2].Value = pTO_DATE;
                pDataParameters[3].Value = pPART_CODE;
                pDataParameters[4].Value = pPART_NAME;
                pDataParameters[5].Value = pVEND_NAME;
                pDataParameters[6].Value = pPART_TYPE;

                //USP_OrderInfoPopup_R10 -> USP_ucMaterialOrderInfoPopup_R10
                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_ucMaterialOrderInfoPopup_R20", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "DevGrid_Info(string pWINDOW_NAME, string pDEV_GRID_NAME)",
                    pException
                );
            }
        }
        #endregion

        #region 원재료 검사서용 정보 저장하기 - MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool OrderInfoPopup_T01_Save(MaterialOrderInfoPopup_T01Entity pMaterialOrderInfoPopup_T01Entity, DataTable dt)
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
                                            new MySqlParameter("@v_order_qty             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_in_qty                 ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_order_date             ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_vend_code              ".Trim(), MySqlDbType.VarChar, 50),
                                            new MySqlParameter("@v_vend_name              ".Trim(), MySqlDbType.VarChar, 100),
                                            new MySqlParameter("@v_vend_part_code         ".Trim(), MySqlDbType.VarChar, 50),

                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersA = new IDataParameter[]
                                    {

                                            new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                            new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_order_id              ".Trim(), SqlDbType.VarChar, 15),
                                            new SqlParameter("@v_part_code             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_order_qty             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_in_qty                 ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_order_date             ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_vend_code              ".Trim(), SqlDbType.VarChar, 50),
                                            new SqlParameter("@v_vend_part_code         ".Trim(), SqlDbType.VarChar, 50),

                                    };
                                    break;
                            }
                            pDataParametersA[0].Value = pMaterialOrderInfoPopup_T01Entity.CRUD;
                            pDataParametersA[1].Value = pMaterialOrderInfoPopup_T01Entity.USER_CODE;
                            pDataParametersA[2].Value = dt.Rows[a]["ORDER_ID"].ToString().ToUpper();
                            pDataParametersA[3].Value = dt.Rows[a]["PART_CODE"].ToString().ToUpper();
                            pDataParametersA[4].Value = dt.Rows[a]["ORDER_QTY"].ToString().ToUpper();
                            pDataParametersA[5].Value = dt.Rows[a]["IN_QTY"].ToString().ToUpper();
                            pDataParametersA[6].Value = dt.Rows[a]["ORDER_DATE"].ToString().ToUpper();
                            pDataParametersA[7].Value = dt.Rows[a]["VEND_CODE"].ToString().ToUpper();
                            pDataParametersA[8].Value = dt.Rows[a]["VEND_PART_CODE"].ToString().ToUpper();
                            
                            DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMaterialOrderInfoPopup_I10", pDataParametersA);

                            if (pDataTableA.Rows[0][0].ToString() != "00")
                            {
                                pErrorYN = true;
                            }
                            pMaterialOrderInfoPopup_T01Entity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                            pMaterialOrderInfoPopup_T01Entity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                            pMaterialOrderInfoPopup_T01Entity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                            pMaterialOrderInfoPopup_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                            pMaterialOrderInfoPopup_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

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

        #region 포장부자재 검사용 정보 저장하기 - MaterialOrderRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool OrderInfoPopup_T01_Second_Save(MaterialOrderInfoPopup_T01Entity pMaterialOrderInfoPopup_T01Entity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            
            _pDBManager.BeginTransaction(); //Transaction 시작

            try
            {
                if (dt != null)
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
                                    new MySqlParameter("@v_part_code             ".Trim(), MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_order_date             ".Trim(), MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_vend_part_code         ".Trim(), MySqlDbType.VarChar, 50)

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {

                                    new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_part_code             ".Trim(), SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_order_date             ".Trim(), SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_vend_part_code         ".Trim(), SqlDbType.VarChar, 50)

                            };
                            break;
                    }
                    pDataParametersA[0].Value = pMaterialOrderInfoPopup_T01Entity.CRUD;
                    pDataParametersA[1].Value = pMaterialOrderInfoPopup_T01Entity.USER_CODE;
                    pDataParametersA[2].Value = dt.Rows[0]["PART_CODE"].ToString().ToUpper();
                    pDataParametersA[3].Value = dt.Rows[0]["ORDER_DATE"].ToString().ToUpper();
                    pDataParametersA[4].Value = dt.Rows[0]["VEND_PART_CODE"].ToString().ToUpper();

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMaterialOrderInfoPopup_I20", pDataParametersA);

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    pMaterialOrderInfoPopup_T01Entity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                    pMaterialOrderInfoPopup_T01Entity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                    pMaterialOrderInfoPopup_T01Entity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                    pMaterialOrderInfoPopup_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                    pMaterialOrderInfoPopup_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                            
                    //마스터 저장
                    IDataParameter[] pDataParametersB = null;
                    //int rowcnt = pHACCPCheckRegisterT07Entity.dtListCnt;

                    for (int a = 0; a < 18; a++)
                    {
                            switch (_pDBManager.DBManagerType.ToString())
                            {
                                case "MySql":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                new MySqlParameter("@v_crud".Trim(), MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code".Trim(), MySqlDbType.VarChar, 20),

                                new MySqlParameter("@v_inspect_id".Trim(), MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_inspect_code".Trim(), MySqlDbType.VarChar, 8),

                                new MySqlParameter("@v_vend_code".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_in_qty".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_date".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_part_clean".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_part_status".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_part_yn".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_decision".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_user".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_remark".Trim(), MySqlDbType.VarChar,1000)

                                    };
                                    break;

                                case "SQLServer":
                                    pDataParametersB = new IDataParameter[]
                                    {
                                new SqlParameter("@v_crud".Trim(), SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code".Trim(), SqlDbType.NVarChar, 20),

                                new SqlParameter("@v_inspect_id".Trim(), SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_inspect_code".Trim(), SqlDbType.NVarChar, 8),

                                new SqlParameter("@v_vend_code".Trim(), SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_in_qty".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_date".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_part_clean".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_part_status".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_part_yn".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_decision".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_user".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_remark".Trim(), SqlDbType.NVarChar, 1000)

                                    };
                                    break;
                            }

                            pDataParametersB[0].Value = pMaterialOrderInfoPopup_T01Entity.CRUD;
                            pDataParametersB[1].Value = pMaterialOrderInfoPopup_T01Entity.USER_CODE;

                            pDataParametersB[2].Value = pDataTableA.Rows[0]["rtn_key"].ToString();
                            pDataParametersB[3].Value = a + 1;

                            pDataParametersB[4].Value = "";
                            pDataParametersB[5].Value = "";
                            pDataParametersB[6].Value = 0;

                            pDataParametersB[7].Value = "";
                            pDataParametersB[8].Value = "";
                            pDataParametersB[9].Value = "";
                            pDataParametersB[10].Value = "";

                            pDataParametersB[11].Value = pMaterialOrderInfoPopup_T01Entity.USER_CODE;

                            pDataParametersB[12].Value = "";
                        
                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMaterialOrderInfoPopup_I30", pDataParametersB);

                        }

                    int pCount = 0;
                    pCount = dt.Rows.Count;

                    for (int i = 0; i < pCount; i++)
                    {
                        if (dt.Rows[i]["CRUD"].ToString() == "Y")
                        {
                            switch (_pDBManager.DBManagerType.ToString())
                            {
                            case "MySql":
                                pDataParametersB = new IDataParameter[]
                                {
                                new MySqlParameter("@v_crud".Trim(), MySqlDbType.VarChar, 1),
                                new MySqlParameter("@v_user_code".Trim(), MySqlDbType.VarChar, 20),

                                new MySqlParameter("@v_inspect_id".Trim(), MySqlDbType.VarChar, 15),
                                new MySqlParameter("@v_inspect_code".Trim(), MySqlDbType.VarChar, 8),

                                new MySqlParameter("@v_vend_code".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_in_qty".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_date".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_part_clean".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_part_status".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_part_yn".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_decision".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_inspect_user".Trim(), MySqlDbType.VarChar,50),
                                new MySqlParameter("@v_remark".Trim(), MySqlDbType.VarChar,1000)

                                };
                                break;

                            case "SQLServer":
                                pDataParametersB = new IDataParameter[]
                                {
                                new SqlParameter("@v_crud".Trim(), SqlDbType.NVarChar, 1),
                                new SqlParameter("@v_user_code".Trim(), SqlDbType.NVarChar, 20),

                                new SqlParameter("@v_inspect_id".Trim(), SqlDbType.NVarChar, 15),
                                new SqlParameter("@v_inspect_code".Trim(), SqlDbType.NVarChar, 8),

                                new SqlParameter("@v_vend_code".Trim(), SqlDbType.NVarChar, 20),
                                new SqlParameter("@v_in_qty".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_date".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_part_clean".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_part_status".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_part_yn".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_decision".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_inspect_user".Trim(), SqlDbType.NVarChar, 50),
                                new SqlParameter("@v_remark".Trim(), SqlDbType.NVarChar, 1000)

                                };
                                break;
                            }

                            pDataParametersB[0].Value = pMaterialOrderInfoPopup_T01Entity.CRUD;
                            pDataParametersB[1].Value = pMaterialOrderInfoPopup_T01Entity.USER_CODE;

                            pDataParametersB[2].Value = pDataTableA.Rows[0]["rtn_key"].ToString();
                            pDataParametersB[3].Value = i + 1;

                            pDataParametersB[4].Value = dt.Rows[i]["VEND_CODE"].ToString().ToUpper();
                            if (dt.Rows[i]["ORDER_QTY"].ToString() == null || dt.Rows[i]["ORDER_QTY"].ToString() == "")
                            {
                                pDataParametersB[5].Value = dt.Rows[i]["IN_QTY"].ToString().ToUpper();
                            }
                            else
                            {
                                pDataParametersB[5].Value = dt.Rows[i]["ORDER_QTY"].ToString().ToUpper();
                            }
                            pDataParametersB[6].Value = dt.Rows[i]["ORDER_DATE"].ToString().ToUpper();

                            pDataParametersB[7].Value = "";
                            pDataParametersB[8].Value = "";
                            pDataParametersB[9].Value = "";
                            pDataParametersB[10].Value = "";

                            pDataParametersB[11].Value = pMaterialOrderInfoPopup_T01Entity.USER_CODE;

                            pDataParametersB[12].Value = "";
                        
                        
                            DataTable pDataTableB = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucMaterialOrderInfoPopup_I30", pDataParametersB);

                        }

                        pMaterialOrderInfoPopup_T01Entity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                        pMaterialOrderInfoPopup_T01Entity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                        pMaterialOrderInfoPopup_T01Entity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                        pMaterialOrderInfoPopup_T01Entity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                        pMaterialOrderInfoPopup_T01Entity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

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
        public override VendCodeInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                VendCodeInfoPopupEntity pVendCodeInfoPopupEntity = new VendCodeInfoPopupEntity();

                pVendCodeInfoPopupEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pVendCodeInfoPopupEntity;
            }
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

    public class TabletBasedSensorInfoPopup_T02Provider : EntityManager<TabletBasedSensorInfoPopup_T02Entity>
    {
        #region 생성자 - TabletBasedSensorInfoPopup_T02Provider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public TabletBasedSensorInfoPopup_T02Provider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion
        #region 엑셀 시트 조회하기 - Sheet_Info_sheet(TabletBasedSensorInfoPopup_T02Entity pTabletBasedSensorInfoPopup_T02Entity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pProductInspectRegisterEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable Sheet_Info_sheet(TabletBasedSensorInfoPopup_T02Entity pTabletBasedSensorInfoPopup_T02Entity)
        {
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

                pDataParameters[0].Value = pTabletBasedSensorInfoPopup_T02Entity.CRUD;
                pDataParameters[1].Value = pTabletBasedSensorInfoPopup_T02Entity.WINDOW_NAME;
                pDataParameters[2].Value = pTabletBasedSensorInfoPopup_T02Entity.LANGUAGE_TYPE;

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

        #region 엑셀 시트 저장하기 - TabletBasedSensorInfoPopup_T02_Save(Worksheet sheet_0)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public DataTable TabletBasedSensorInfoPopup_T02_Save(TabletBasedSensorInfoPopup_T02Entity _pTabletBasedSensorInfoPopup_T02Entity, Worksheet sheet_0)
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

                        pDataParametersA[0].Value = _pTabletBasedSensorInfoPopup_T02Entity.USER_CODE;
                        pDataParametersA[1].Value = sheet_0.GetCellValue(1, i + 1).ToString(); // 리소스코드
                        pDataParametersA[2].Value = sheet_0.GetCellValue(3, i + 1).ToString(); // 값
                        pDataParametersA[3].Value = _pTabletBasedSensorInfoPopup_T02Entity.COLLECTION_DATE;
                        pDataParametersA[4].Value = sheet_0.GetCellValue(4, i + 1).ToString(); // 수기자1
                        pDataParametersA[5].Value = sheet_0.GetCellValue(5, i + 1).ToString(); // 수기자2
                        pDataParametersA[6].Value = sheet_0.GetCellValue(6, i + 1).ToString(); // 수기일
                        pDataParametersA[7].Value = sheet_0.GetCellValue(7, i + 1).ToString(); // 비고

                        DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTabletBasedSensorInfoPopup_T02_I10", pDataParametersA);

                        _pTabletBasedSensorInfoPopup_T02Entity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                        _pTabletBasedSensorInfoPopup_T02Entity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                        _pTabletBasedSensorInfoPopup_T02Entity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                        _pTabletBasedSensorInfoPopup_T02Entity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                        _pTabletBasedSensorInfoPopup_T02Entity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

                        if (pDataTableA.Rows[0][0].ToString() != "00")
                        {
                            pErrorYN = true;
                        }

                        num++;
                    }
                    else
                    {
                        break;
                    }
                }

                IDataParameter[] pDataParameters = null;

                switch (_pDBManager.DBManagerType.ToString())
                {
                    case "MySql":
                        pDataParameters = new IDataParameter[]
                        {
                            new MySqlParameter("@v_crud", MySqlDbType.VarChar, 1),
                            new MySqlParameter("@v_num", MySqlDbType.Int32)
                };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar, 1),
                            new SqlParameter("@v_num", SqlDbType.Int)

                };
                        break;
                }

                pDataParameters[0].Value = "R";
                pDataParameters[1].Value = num;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_ucTabletBasedSensorInfoPopup_T02_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "TabletBasedSensorInfoPopup_T02_Save(TabletBasedSensorInfoPopup_T02Entity pTabletBasedSensorInfoPopup_T02Entity, TabletBasedSensorInfoPopup_T02Entity)",
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
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)
        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name = "pDataRow" > 데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public override TabletBasedSensorInfoPopup_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                TabletBasedSensorInfoPopup_T02Entity pTabletBasedSensorInfoPopup_T02Entity = new TabletBasedSensorInfoPopup_T02Entity();

                pTabletBasedSensorInfoPopup_T02Entity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pTabletBasedSensorInfoPopup_T02Entity;
            }
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

    public class ResourceCodeInfoPopUpProvider : EntityManager<ResourceCodeInfoPopUpEntity>
    {
        #region 생성자 - ResourceCodeInfoPopUpProvider(DBManager pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ResourceCodeInfoPopUpProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 코드 정보 조회하기 - ResourceCodeInfoPopUp_Return(string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pCORP_CD">회사코드</param>
        /// <param name="pWINDOW_NAME">화면 아이디</param>
        /// <param name="pDEV_GRID_NAME">그리드 아이디</param>
        /// <returns>조회 목록</returns>
        public DataSet ResourceCodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE, string pSERVICE_NAME, string pRESOURCE_CODE, string pVEND_PART_CODE, string pRESOURCE_NAME, string pPART_TYPE)
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
                            new MySqlParameter("@v_language_type", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_service_name", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_code_type", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_code", MySqlDbType.VarChar,50),
                            new MySqlParameter("@v_name", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value1", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value2", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_value3", MySqlDbType.VarChar,100),
                            new MySqlParameter("@v_use_yn", MySqlDbType.VarChar,1)
                        };
                        break;

                    case "SQLServer":
                        pDataParameters = new IDataParameter[]
                        {
                            new SqlParameter("@v_crud", SqlDbType.NVarChar,1),
                            new SqlParameter("@v_language_type", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_service_name", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_code_type", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_code", SqlDbType.NVarChar,50),
                            new SqlParameter("@v_name", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value1", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value2", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_value3", SqlDbType.NVarChar,100),
                            new SqlParameter("@v_use_yn", SqlDbType.NVarChar,1)

                        };
                        break;
                }

                pDataParameters[0].Value = pCRUD;
                pDataParameters[1].Value = pLANGUAGE_TYPE;
                pDataParameters[2].Value = pSERVICE_NAME;
                pDataParameters[3].Value = pPART_TYPE;
                pDataParameters[4].Value = pRESOURCE_CODE;
                pDataParameters[5].Value = pRESOURCE_NAME;
                pDataParameters[6].Value = pVEND_PART_CODE;
                pDataParameters[7].Value = "";
                pDataParameters[8].Value = "";
                pDataParameters[9].Value = "Y";


                DataSet pDataTableSet = _pDBManager.GetDataSet(CommandType.StoredProcedure, "USP_CommonCodePopUp_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

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
                    "ResourceCodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE, string pRESOURCE_CODE, string pVEND_PART_CODE, string pRESOURCE_NAME, string pPART_TYPE)",
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
        public override ResourceCodeInfoPopUpEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ResourceCodeInfoPopUpEntity pResourceCodeInfoPopUpEntity = new ResourceCodeInfoPopUpEntity();

                pResourceCodeInfoPopUpEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pResourceCodeInfoPopUpEntity;
            }
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

    public class ucEquipmentInspectInfoPopupProvider : EntityManager<ucEquipmentInspectInfoPopupEntity>
    {
        #region 생성자 - ucEquipmentInspectInfoPopupProvider(pDBManager)
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="pDBManager">DB 관리자</param>
        public ucEquipmentInspectInfoPopupProvider(DBManager pDBManager)
        {
            _pDBManager = pDBManager;
        }
        #endregion

        #region 마스터 조회하기 - EquipmentInspectInfoPopup_Return(ucEquipmentInspectInfoPopupEntity pucEquipmentInspectInfoPopupEntity)

        /// <summary>
        /// 조회하기
        /// </summary>
        /// <param name="pNoticeEntity">엔티티 정보</param>
        /// <returns>조회 목록</returns>
        public DataTable EquipmentInspectInfoPopup_Return(ucEquipmentInspectInfoPopupEntity pucEquipmentInspectInfoPopupEntity)
        {
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

                pDataParameters[0].Value = pucEquipmentInspectInfoPopupEntity.CRUD;
                pDataParameters[1].Value = pucEquipmentInspectInfoPopupEntity.LANGUAGE_TYPE;

                DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentInspectInfoPopup_R10", pDataParameters);

                //if (pDataTable != null)
                //{
                //    GetEntity(pDataTable.Rows[0]);
                //}

                return pDataTable;
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "EquipmentInspectInfoPopup_Return(ucEquipmentInspectInfoPopupEntity pucEquipmentInspectInfoPopupEntity)",
                    pException
                );
            }
        }

        #endregion

        #region 선택 설비 정보 저장하기 -  EquipmentInspectInfoPopup_Info_Save(ucEquipmentInspectInfoPopupEntity pucEquipmentInspectInfoPopupEntity, DataTable dt)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGridInfoRegisterEntity"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool EquipmentInspectInfoPopup_Info_Save(ucEquipmentInspectInfoPopupEntity pucEquipmentInspectInfoPopupEntity, DataTable dt)
        {
            bool pErrorYN = false; // 정상 저장 TRUE / 저장 오류 FALSE
            int pCount = 0;
            _pDBManager.BeginTransaction(); //Transaction 시작
            try
            {
                if (dt != null)
                {
                    //마스터 저장
                    IDataParameter[] pDataParameters = null;

                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParameters = new IDataParameter[]
                            {
                                    new MySqlParameter("@v_crud                  ".Trim(), MySqlDbType.VarChar, 1),
                                    new MySqlParameter("@v_user_code             ".Trim(), MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_inspect_date             ".Trim(), MySqlDbType.VarChar, 8)
                            };
                            break;

                        case "SQLServer":
                            pDataParameters = new IDataParameter[]
                            {
                                    new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_inspect_date              ".Trim(), SqlDbType.VarChar, 8)
                            };
                            break;
                    }

                    pDataParameters[0].Value = "C";
                    pDataParameters[1].Value = pucEquipmentInspectInfoPopupEntity.USER_CODE;
                    pDataParameters[2].Value = pucEquipmentInspectInfoPopupEntity.DATE;

                    DataTable pDataTable = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentInspectInfoPopup_I10", pDataParameters);

                    if (pDataTable.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }
                    pucEquipmentInspectInfoPopupEntity.ERR_NO = pDataTable.Rows[0]["err_no"].ToString();
                    pucEquipmentInspectInfoPopupEntity.ERR_MSG = pDataTable.Rows[0]["err_msg"].ToString();
                    pucEquipmentInspectInfoPopupEntity.RTN_KEY = pDataTable.Rows[0]["rtn_key"].ToString();
                    pucEquipmentInspectInfoPopupEntity.RTN_SEQ = pDataTable.Rows[0]["rtn_seq"].ToString();
                    pucEquipmentInspectInfoPopupEntity.RTN_OTHERS = pDataTable.Rows[0]["rtn_others"].ToString();

                    pCount = dt.Rows.Count;

                    string pEquipmentList = string.Empty;
                    int pEquipmentFlag = 0;

                    for (int a = 0; a < pCount; a++)
                    {
                        //체크된것만 저장
                        if (dt.Rows[a]["CRUD"].ToString() == "Y")
                        {
                            if (pEquipmentFlag == 0)
                            {
                                pEquipmentList = dt.Rows[a]["EQUIPMENT_CODE"].ToString();

                                pEquipmentFlag = 1;
                            }
                            else
                            {
                                pEquipmentList = pEquipmentList + "," + dt.Rows[a]["EQUIPMENT_CODE"].ToString();
                            }
                        }
                    }

                    //마스터 저장
                    IDataParameter[] pDataParametersA = null;

                    switch (_pDBManager.DBManagerType.ToString())
                    {
                        case "MySql":
                            pDataParametersA = new IDataParameter[]
                            {

                                    new MySqlParameter("@v_crud                  ".Trim(), MySqlDbType.VarChar, 1),
                                    new MySqlParameter("@v_user_code             ".Trim(), MySqlDbType.VarChar, 50),
                                    new MySqlParameter("@v_equipment_code        ".Trim(), MySqlDbType.VarChar, 1000),
                                    new MySqlParameter("@v_inspect_id            ".Trim(), MySqlDbType.VarChar, 50),

                            };
                            break;

                        case "SQLServer":
                            pDataParametersA = new IDataParameter[]
                            {

                                    new SqlParameter("@v_crud                  ".Trim(), SqlDbType.VarChar, 1),
                                    new SqlParameter("@v_user_code             ".Trim(), SqlDbType.VarChar, 50),
                                    new SqlParameter("@v_equipment_code        ".Trim(), SqlDbType.VarChar, 1000),
                                    new SqlParameter("@v_inspect_id            ".Trim(), SqlDbType.VarChar, 50),

                            };
                            break;
                    }

                    pDataParametersA[0].Value = "U";
                    pDataParametersA[1].Value = pucEquipmentInspectInfoPopupEntity.USER_CODE;
                    pDataParametersA[2].Value = pEquipmentList;
                    pDataParametersA[3].Value = pucEquipmentInspectInfoPopupEntity.RTN_KEY;

                    DataTable pDataTableA = _pDBManager.GetDataTable(CommandType.StoredProcedure, "USP_EquipmentInspectInfoPopup_I20", pDataParametersA);

                    if (pDataTableA.Rows[0][0].ToString() != "00")
                    {
                        pErrorYN = true;
                    }

                    pucEquipmentInspectInfoPopupEntity.ERR_NO = pDataTableA.Rows[0]["err_no"].ToString();
                    pucEquipmentInspectInfoPopupEntity.ERR_MSG = pDataTableA.Rows[0]["err_msg"].ToString();
                    pucEquipmentInspectInfoPopupEntity.RTN_KEY = pDataTableA.Rows[0]["rtn_key"].ToString();
                    pucEquipmentInspectInfoPopupEntity.RTN_SEQ = pDataTableA.Rows[0]["rtn_seq"].ToString();
                    pucEquipmentInspectInfoPopupEntity.RTN_OTHERS = pDataTableA.Rows[0]["rtn_others"].ToString();

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
                    "EquipmentInspectInfoPopup_Info_Save(ucEquipmentInspectInfoPopupEntity pucEquipmentInspectInfoPopupEntity, DataTable dt)",
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
        public override ucEquipmentInspectInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                if (pDataRow == null)
                {
                    return null;
                }

                ucEquipmentInspectInfoPopupEntity pucEquipmentInspectInfoPopupEntityEntity = new ucEquipmentInspectInfoPopupEntity();

                pucEquipmentInspectInfoPopupEntityEntity.CORP_CODE = pDataRow["corp_code"] is DBNull ? string.Empty : pDataRow["corp_code"] as string;  // 회사코드

                return pucEquipmentInspectInfoPopupEntityEntity;
            }
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
