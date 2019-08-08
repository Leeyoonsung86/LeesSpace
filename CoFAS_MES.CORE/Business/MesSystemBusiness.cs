using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoFAS_MES.CORE.Data;
using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using DevExpress.Spreadsheet;

namespace CoFAS_MES.CORE.Business
{
    public class LoginBusiness
    {
        #region 로그인 하기 - Login_Info(string pCORP_CD, string pAccount, string pPassword)

        /// <summary>
        /// 로그인 하기
        /// </summary>
        public DataTable Login_Info(string pAccount, string pPassword) //Login_Info(string pCORP_CD, string pAccount, string pPassword)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new LoginProvider(pDBManager).Login_Info(pAccount, pPassword);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Login_Info(string pAccount, string pPassword)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public LoginEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                LoginEntity pLoginEntity = new LoginProvider(null).GetEntity(pDataRow);
                return pLoginEntity;
            }
            catch (Exception pException)
            {
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
    public class SystemSettingBusiness
    {
        #region CI 받기 - CI_Download()

        /// <summary>
        /// 로그인 하기
        /// </summary>
        public DataTable CI_Download()
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SystemSettingProvider(pDBManager).CI_Download();
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "CI_Download", pException);
            }
        }

        #endregion


        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public SystemSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                SystemSettingEntity pSystemSettingEntity = new SystemSettingProvider(null).GetEntity(pDataRow);
                return pSystemSettingEntity;
            }
            catch (Exception pException)
            {
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
    public class MenuSettingBusiness
    {
        #region 메뉴 조회하기 - Menu_List_Search(nUserID)
        /// <summary>
        /// 메뉴 조회 하기
        /// </summary>
        /// <param name="pCORP_CD"></param>
        /// <param name="pUserID"></param>
        /// <returns></returns>
        public DataTable Menu_List_Search(string pUserID)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuSettingProvider(pDBManager).Menu_List_Search(pUserID);
                    return pDataTable;
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
                    "Menu_List_Search(string pUserID)",
                    pException
                );
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MenuSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MenuSettingEntity pMenuSettingEntity = new MenuSettingProvider(null).GetEntity(pDataRow);
                return pMenuSettingEntity;
            }
            catch (Exception pException)
            {
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
    public class FavoritesMenuSettingBusiness
    {
        #region 즐겨찾기 조회하기 - Favorites_Menu_Search(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)
        /// <summary>
        /// 즐겨찾기 하기
        /// </summary>
        /// <param name="pFavoritesMenuSettingEntity"></param>
        /// <returns></returns>
        public DataTable Favorites_Menu_Search(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new FavoritesMenuSettingProvider(pDBManager).Favorites_Menu_Search(pFavoritesMenuSettingEntity);
                    return pDataTable;
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
                    "Favorites_Menu_Search(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)",
                    pException
                );
            }
        }
        #endregion

        #region 즐겨찾기 정보 저장 - Favorites_Menu_Save(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)

        /// <summary>
        /// 즐겨찾기 정보 저장
        /// </summary>
        public bool Favorites_Menu_Save(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new FavoritesMenuSettingProvider(pDBManager).Favorites_Menu_Save(pFavoritesMenuSettingEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Favorites_Menu_Save(FavoritesMenuSettingEntity pFavoritesMenuSettingEntity)", pException);
            }
        }

        #endregion



        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public FavoritesMenuSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                FavoritesMenuSettingEntity pFavoritesMenuSettingEntity = new FavoritesMenuSettingProvider(null).GetEntity(pDataRow);
                return pFavoritesMenuSettingEntity;
            }
            catch (Exception pException)
            {
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
    public class LanguageBusiness
    {
        #region 언어 변환 조회 - Language_Info(string pWINDOW_NAME, string pLANGUAGE_TYPE)

        /// <summary>
        /// 로그인 하기
        /// </summary>
        public DataTable Language_Info(string pWINDOW_NAME, string pLANGUAGE_TYPE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new LanguageProvider(pDBManager).Language_Info(pWINDOW_NAME, pLANGUAGE_TYPE);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Language_Info(string pWINDOW_NAME, string pLANGUAGE_TYPE)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public LanguageEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                LanguageEntity pLanguageEntity = new LanguageProvider(null).GetEntity(pDataRow);
                return pLanguageEntity;
            }
            catch (Exception pException)
            {
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
    public class MessageBusiness
    {
        #region 메세지정보조회 - MessageValue_Info(string pLANGUAGE_TYPE)

        /// <summary>
        /// 메세지 정보 조회
        /// </summary>
        public DataTable MessageValue_Info(string pLANGUAGE_TYPE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MessageProvider(pDBManager).MessageValue_Info(pLANGUAGE_TYPE);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Message_Info(string pLANGUAGE_TYPE)", pException);
            }
        }

        public DataTable MessageValue_Info(string pLANGUAGE_TYPE, string pWINDOW_NAME)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MessageProvider(pDBManager).MessageValue_Info(pLANGUAGE_TYPE, pWINDOW_NAME);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MessageValue_Info(string pLANGUAGE_TYPE, string pWINDOW_NAME)", pException);
            }
        }

        public DataTable MessageValue_Mst_Info(string pLANGUAGE_TYPE, string pWINDOW_NAME)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MessageProvider(pDBManager).MessageValue_Mst_Info(pLANGUAGE_TYPE, pWINDOW_NAME);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MessageValue_Info(string pLANGUAGE_TYPE, string pWINDOW_NAME)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MessageEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MessageEntity pMessageEntity = new MessageProvider(null).GetEntity(pDataRow);
                return pMessageEntity;
            }
            catch (Exception pException)
            {
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
    public class DevGridSettingBusiness
    {
        #region 그리드 정보 조회 -  DevGrid_Info(string pLANGUAGE_TYPE, string pWINDOW_NAME, string pDEV_GRID_NAME)

        /// <summary>
        /// 그리드 조회 하기
        /// </summary>
        public DataSet DevGrid_Info(string pLANGUAGE_TYPE, string pWINDOW_NAME, string pDEV_GRID_NAME)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new DevGridSettingProvider(pDBManager).DevGrid_Info(pLANGUAGE_TYPE, pWINDOW_NAME, pDEV_GRID_NAME);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DevGrid_Info(string pWINDOW_NAME, string pDEV_GRID_NAME)", pException);
            }
        }

        #endregion

      




        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public DevGridSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                DevGridSettingEntity pDevGridSettingEntity = new DevGridSettingProvider(null).GetEntity(pDataRow);
                return pDevGridSettingEntity;
            }
            catch (Exception pException)
            {
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
    public class SystemLogInfoBusiness
    {
        #region 시스템 이벤트 정보 저장 -  SystemEventLog_Info_Save(SystemLogInfoEntity pSystemLogInfoEntity)

        /// <summary>
        /// 시스템 이벤트 정보 저장
        /// </summary>
        public bool SystemEventLog_Info_Save(SystemLogInfoEntity pSystemLogInfoEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isCheck = new SystemLogInfoProvider(pDBManager).SystemEventLog_Info_Save(pSystemLogInfoEntity);
                    return isCheck;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SystemEventLog_Info_Save(SystemLogInfoEntity pSystemLogInfoEntity)", pException);
            }
        }

        #endregion

        #region 시스템 이벤트 정보 저장 -  SystemEventLog_Info_Save(string strCRUD, string strUSER_CODE, string strLOG_MST, string strLOG_DETAIL, string strREMARK)

        /// <summary>
        /// 시스템 이벤트 정보 저장
        /// </summary>
        public bool SystemEventLog_Info_Save(string strCRUD, string strUSER_CODE, string strMENU_NAME, string strWINDOW_NAME, string strMENU_FUNCTION, string strCONTROL_NAME, string strEVENT_DESCRIPTION)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {

                    string strREMARK = string.Format("{0} : {1} ( {2} : {3} ) - {4} [ {5} ]", strUSER_CODE, strMENU_NAME, strWINDOW_NAME, strCONTROL_NAME, strMENU_FUNCTION, strEVENT_DESCRIPTION);

                    bool isCheck = new SystemLogInfoProvider(pDBManager).SystemEventLog_Info_Save(strCRUD, strUSER_CODE, strMENU_NAME, strMENU_FUNCTION, strREMARK);
                    return isCheck;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SystemEventLog_Info_Save(SystemLogInfoEntity pSystemLogInfoEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public SystemLogInfoEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                SystemLogInfoEntity pSystemLogInfoEntity = new SystemLogInfoProvider(null).GetEntity(pDataRow);
                return pSystemLogInfoEntity;
            }
            catch (Exception pException)
            {
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

    public class XMLDesignBusiness
    {
        #region 디자인 정보 조회 - XMLDesign_Info(string pWINDOW_NAME, string pLANGUAGE_TYPE)

        /// <summary>
        /// 로그인 하기
        /// </summary>
        public DataTable XMLDesign_Info(string pWINDOW_NAME, string pLANGUAGE_TYPE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new XMLDesignProvider(pDBManager).XMLDesign_Info(pWINDOW_NAME, pLANGUAGE_TYPE);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "XMLDesign_Info(string pWINDOW_NAME, string pLANGUAGE_TYPE)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public XMLDesignEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                XMLDesignEntity pXMLDesignEntity = new XMLDesignProvider(null).GetEntity(pDataRow);
                return pXMLDesignEntity;
            }
            catch (Exception pException)
            {
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

    public class WindowPageSettingBusiness
    {
        #region 컨트롤러 정보 조회 -  Controls_Info(WindowPageSettingEntity pWindowPageSettingEntity)

        /// <summary>
        /// 컨트롤러 조회 하기
        /// </summary>
        public DataTable Controls_Info(WindowPageSettingEntity pWindowPageSettingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WindowPageSettingProvider(pDBManager).Controls_Info(pWindowPageSettingEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Controls_Info(WindowPageSettingEntity pWindowPageSettingEntity)", pException);
            }
        }

        #endregion

        #region 컨트롤러 정보 저장 - Controls_Info_Save(WindowPageSettingEntity pWindowPageSettingEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Controls_Info_Save(WindowPageSettingEntity pWindowPageSettingEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WindowPageSettingProvider(pDBManager).Controls_Info_Save(pWindowPageSettingEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Controls_Info_Save(WindowPageSettingEntity pWindowPageSettingEntity, DataTable dt)", pException);
            }
        }

        #endregion


        #region 그리드 마스터 정보 조회 -  Grid_MST_Info(WindowPageSettingEntity pWindowPageSettingEntity)

        /// <summary>
        /// 그리드 마스터 조회 하기
        /// </summary>
        public DataTable Grid_MST_Info(WindowPageSettingEntity pWindowPageSettingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WindowPageSettingProvider(pDBManager).Grid_MST_Info(pWindowPageSettingEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Grid_MST_Info(WindowPageSettingEntity pWindowPageSettingEntity)", pException);
            }
        }

        #endregion

        #region 그리드 상세 정보 조회 -  Grid_Detail_Info(WindowPageSettingEntity pWindowPageSettingEntity)

        /// <summary>
        /// 그리드 상세 조회 하기
        /// </summary>
        public DataTable Grid_Detail_Info(WindowPageSettingEntity pWindowPageSettingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WindowPageSettingProvider(pDBManager).Grid_Detail_Info(pWindowPageSettingEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Grid_MST_Info(WindowPageSettingEntity pWindowPageSettingEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Grid_Info_Save(WindowPageSettingEntity pWindowPageSettingEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Grid_Info_Save(WindowPageSettingEntity pWindowPageSettingEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WindowPageSettingProvider(pDBManager).Grid_Info_Save(pWindowPageSettingEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Grid_Info_Save(WindowPageSettingEntity pWindowPageSettingEntity, DataTable dt)", pException);
            }
        }

        #endregion


        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public DevGridSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                DevGridSettingEntity pDevGridSettingEntity = new DevGridSettingProvider(null).GetEntity(pDataRow);
                return pDevGridSettingEntity;
            }
            catch (Exception pException)
            {
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
    public class WindowSheetSettingBusiness
    {
        #region 컨트롤러 정보 조회 -  Controls_Info(WindowPageSettingEntity pWindowPageSettingEntity)

        /// <summary>
        /// 컨트롤러 조회 하기
        /// </summary>
        public DataTable SheetMainFind_DisplayData(WindowSheetSettingEntity pWindowSheetSettingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WindowSheetSettingProvider(pDBManager).SheetMainFind_DisplayData(pWindowSheetSettingEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SheetMainFind_DisplayData(WindowSheetSettingEntity pWindowSheetSettingEntity)", pException);
            }
        }

        #endregion




        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public DevGridSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                DevGridSettingEntity pDevGridSettingEntity = new DevGridSettingProvider(null).GetEntity(pDataRow);
                return pDevGridSettingEntity;
            }
            catch (Exception pException)
            {
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
    public class CommonCodeReturnBusiness
    {
        public DataSet CommonCode_Return(string pCRUD, string pLANGUAGE_TYPE, string pSERVICE_NAME, string pFIRST_CODE, string pSECOND_CODE, string pTHIRD_CODE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new CommonCodeReturnProvider(pDBManager).CommonCode_Return(pCRUD, pLANGUAGE_TYPE, pSERVICE_NAME, pFIRST_CODE, pSECOND_CODE, pTHIRD_CODE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "CommonCodeRetrun(string pCRUD, string pSERVICE_NAME, string pFIRST_CODE, string pSECOND_CODE, string pTHIRD_CODE )", pException);
            }
        }
    }
    public class CodePopUpBusiness
    {
        public DataSet CodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE, string pSERVICE_NAME, string pCODE_TYPE, string pCODE, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new CodePopUpProvider(pDBManager).CodePopUp_Return(pCRUD, pLANGUAGE_TYPE, pSERVICE_NAME, pCODE_TYPE, pCODE, pNAME, pVALUE1, pVALUE2, pVALUE3, pUSE_YN);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "CodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE,  string pSERVICE_NAME, string pCODE_TYPE, string pCODE, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN)", pException);
            }
        }
    }

    public class PartCodePopUpBusiness
    {
        public DataSet PartCodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE, string pSERVICE_NAME, string pPART_CODE, string pVEND_PART_CODE, string pPART_NAME, string pPART_TYPE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new PartCodePopUpProvider(pDBManager).PartCodePopUp_Return(pCRUD, pLANGUAGE_TYPE, pSERVICE_NAME, pPART_CODE, pVEND_PART_CODE, pPART_NAME, pPART_TYPE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartCodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE, string pPART_CODE, string pVEND_PART_CODE, string pPART_NAME, string pPART_TYPE)", pException);
            }
        }
    }
    public class ucReversBOMInfoPopupBusiness
    {
        public DataSet ucReversBOMInfoPopup_Return(string pCRUD, string pLANGUAGE_TYPE, string pSERVICE_NAME, string pPART_CODE, string pVEND_PART_CODE, string pPART_NAME, string pPART_TYPE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucReversBOMInfoPopupProvider(pDBManager).ucReversBOMInfoPopup_Return(pCRUD, pLANGUAGE_TYPE, pSERVICE_NAME, pPART_CODE, pVEND_PART_CODE, pPART_NAME, pPART_TYPE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartCodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE, string pPART_CODE, string pVEND_PART_CODE, string pPART_NAME, string pPART_TYPE)", pException);
            }
        }
    }

    public class VendCodeInfoPopupBusiness
    {
        public DataSet VendCodeInfoPopup_Return(string pCRUD, string pVEND_CODE, string pVEND_NAME, string pVEND_TYPE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new VendCodeInfoPopupProvider(pDBManager).VendCodeInfoPopup_Return(pCRUD, pVEND_CODE, pVEND_NAME, pVEND_TYPE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "VendCodeInfoPopup_Return(string pCRUD, string pSERVICE_NAME, string pCODE_TYPE, string pCODE, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN)", pException);
            }
        }
    }

    public class VendCodeInfoPopup_T02Business
    {
        public DataSet VendCodeInfoPopup_Return(string pCRUD, string pVEND_CODE, string pVEND_NAME, string pSERVICE_NAME, string pLANGUAGE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new VendCodeInfoPopup_T02Provider(pDBManager).VendCodeInfoPopup_Return(pCRUD, pVEND_CODE, pVEND_NAME, pSERVICE_NAME, pLANGUAGE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "VendCodeInfoPopup_Return(string pCRUD, string pVEND_CODE, string pVEND_NAME, string pVEND_TYPE)", pException);
            }
        }
    }

    public class VendCodeInfoPopup_T04Business
    {
        public DataSet VendCodeInfoPopup_Return(string pCRUD, string pVEND_CODE, string pVEND_NAME, string pSERVICE_NAME, string pLANGUAGE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new VendCodeInfoPopup_T04Provider(pDBManager).VendCodeInfoPopup_Return(pCRUD, pVEND_CODE, pVEND_NAME, pSERVICE_NAME, pLANGUAGE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "VendCodeInfoPopup_Return(string pCRUD, string pVEND_CODE, string pVEND_NAME, string pVEND_TYPE)", pException);
            }
        }
    }


    public class ProductionOrderInfoPopupBusiness
    {
        public DataSet ProductionOrderInfoPopup_Return(string JOBORDER_CD, string JOB_FRIST_DATE, string JOB_LAST_DATE, string VEND_CODE, string VEND_NAME, string MATERIAL_CD, string MATERIAL_NM)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ProductionOrderInfoPopupProvider(pDBManager).ProductionOrderInfoPopup_Return(JOBORDER_CD, JOB_FRIST_DATE, JOB_LAST_DATE, VEND_CODE, VEND_NAME, MATERIAL_CD, MATERIAL_NM);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "VendCodeInfoPopup_Return(string pCRUD, string pSERVICE_NAME, string pCODE_TYPE, string pCODE, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN)", pException);
            }
        }
    }
    public class VendCostPopUpBusiness
    {
        public DataSet VendCost_Main_Return(string pCRUD, string pSERVICE_NAME, string pCODE_TYPE, string pCODE, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN, string pLANGUAGE_TYPE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new VendCostInfoPopupProvider(pDBManager).VendCostInfoPopup_Main_Return(pCRUD, pSERVICE_NAME, pCODE_TYPE, pCODE, pNAME, pVALUE1, pVALUE2, pVALUE3, pUSE_YN, pLANGUAGE_TYPE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "CodePopUp_Return(string pCRUD, string pSERVICE_NAME, string pCODE_TYPE, string pCODE, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN)", pException);
            }
        }
        public DataSet VendCost_Sub_Return(string pCRUD,string pPART_CODE, string pPART_TYPE,string pLANGUAGE_TYPE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new VendCostInfoPopupProvider(pDBManager).VendCostInfoPopup_Sub_Return(pCRUD,pPART_CODE, pPART_TYPE, pLANGUAGE_TYPE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "CodePopUp_Return(string pCRUD, string pSERVICE_NAME, string pCODE_TYPE, string pCODE, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN)", pException);
            }
        }
    }
    public class MaterialOrderInfoPopupBusiness
    {
        public DataSet MaterialOrderInfoPopup_Return(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new OrderInfoPopupProvider(pDBManager).OrderInfoPopup_Return(pCRUD, pFromDate, pToDate, pPART_NAME, pVEND_NAME);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "OrderInfoPopup_Return(pCRUD, pDate, pPART_NAME, pVEND_NAME)", pException);
            }
        }
       
    }
    public class ContractInfoPopUpBusiness
    {
        //public DataSet CodePopUp_Return(string pCRUD, string pSERVICE_NAME, string pCODE_TYPE, string pCODE, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            DataSet pDataTableSet = new CodePopUpProvider(pDBManager).CodePopUp_Return(pCRUD, pSERVICE_NAME, pCODE_TYPE, pCODE, pNAME, pVALUE1, pVALUE2, pVALUE3, pUSE_YN);
        //            return pDataTableSet;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "CodePopUp_Return(string pCRUD, string pSERVICE_NAME, string pCODE_TYPE, string pCODE, string pNAME, string pVALUE1, string pVALUE2, string pVALUE3, string pUSE_YN)", pException);
        //    }
        //}
    }
    public class SubMonitoringBusiness
    {
        public DataSet SubMonitoring_info(string pCORP_CODE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new SubMonitoringProvider(pDBManager).SubMonitoring_info(pCORP_CODE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SubMonitoring_info(string pCORP_CODE)", pException);
            }
        }

        public DataSet SubMonitoring_info_chart(string pCORP_CODE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new SubMonitoringProvider(pDBManager).SubMonitoring_info_chart(pCORP_CODE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SubMonitoring_info(string pCORP_CODE)", pException);
            }
        }
    }

    public class ProductPlanInfoPopupBusiness
    {
        public DataSet ProductPlanInfoPopup_Return(string pCRUD, string pPLANORDER)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ProductPlanInfoPopupProvider(pDBManager).ProductPlanInfo_Return(pCRUD, pPLANORDER);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "OrderInfoPopup_Return(pCRUD, pDate, pPART_NAME, pVEND_NAME)", pException);
            }
        }

        public DataTable ProductPlanInfoPopup_Save(ProductPlanInfoPopupEntity pProductPlanInfoPopupEntity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new ProductPlanInfoPopupProvider(pDBManager).ProductPlanInfo_Save(pProductPlanInfoPopupEntity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanInfoPopup_Save(ProductPlanInfoPopupEntity pProductPlanInfoPopupEntity, DataTable pDataTable)", pException);
            }
        }
    }

    public class ProductPlanInfoPopup_T50Business
    {
        public DataSet ProductPlanInfoPopup_T50_Return(string pCRUD, string pPLANORDER)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ProductPlanInfoPopup_T50Provider(pDBManager).ProductPlanInfo_Return(pCRUD, pPLANORDER);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "OrderInfoPopup_Return(pCRUD, pDate, pPART_NAME, pVEND_NAME)", pException);
            }
        }

        public DataTable ProductPlanInfoPopup_T50_Save(ProductPlanInfoPopup_T50Entity pProductPlanInfoPopup_T50Entity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new ProductPlanInfoPopup_T50Provider(pDBManager).ProductPlanInfo_Save(pProductPlanInfoPopup_T50Entity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanInfoPopup_T50_Save(ProductPlanInfoPopup_T50Entity pProductPlanInfoPopup_T50Entity, DataTable pDataTable)", pException);
            }
        }
    }

    public class ucProductionOrderInfoPopup_T02Business
    {
        public DataSet ucProductionOrderInfoPopup_T02_Select(ucProductionOrderInfoPopup_T02_Entity pucProductionOrderInfoPopup_T02_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucProductionOrderInfoPopup_T02Provider(pDBManager).ucProductonOrderInfoPopup_T02_Return(pucProductionOrderInfoPopup_T02_Entity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProductionOrderInfoPopup_T02_Select(ucProductionOrderInfoPopup_T02_Entity pucProductionOrderInfoPopup_T02_Entity)", pException);
            }
        }
    }
    public class ucProductionOrderInfoPopup_T03Business
    {
        public DataSet ucProductionOrderInfoPopup_T03_Select(ucProductionOrderInfoPopup_T03_Entity pucProductionOrderInfoPopup_T03_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucProductionOrderInfoPopup_T03Provider(pDBManager).ucProductonOrderInfoPopup_T02_Return(pucProductionOrderInfoPopup_T03_Entity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProductionOrderInfoPopup_T03_Select(ucProductionOrderInfoPopup_T03_Entity pucProductionOrderInfoPopup_T03_Entity)", pException);
            }
        }
    }

    public class WorkOrderInfoPopupBusiness
    {
        public DataSet WorkOrderInfoPopup_Return(string pCRUD, string pPLANORDER,string pPARTCODE, WorkOrderInfoPopupEntity pWorkOrderInfoPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new WorkOrderInfoPopupProvider(pDBManager).WorkOrderInfo_Return(pCRUD, pPLANORDER, pPARTCODE, pWorkOrderInfoPopupEntity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkOrderInfoPopupProvider(pDBManager).WorkOrderInfo_Return(pCRUD, pPARTCODE)", pException);
            }
        }

        public bool WorkOrderInfoPopup_Save(WorkOrderInfoPopupEntity pWorkOrderInfoPopupEntity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkOrderInfoPopupProvider(pDBManager).WorkOrderInfo_Save(pWorkOrderInfoPopupEntity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkOrderInfoPopup_Save(WorkOrderInfoPopupEntity pWorkOrderInfoPopupEntity, DataTable pDataTable)", pException);
            }
        }
    }

    public class ucWorkOrderInfoPopup_T50Business
    {
        public DataSet ucWorkOrderInfoPopup_T50_Return(string pCRUD, string pPLANORDER, string CONFIGURATION_MST_NAME, string CONFIGURATION_NAME, ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucWorkOrderInfoPopup_T50Provider(pDBManager).WorkOrderInfo_Return(pCRUD, pPLANORDER, CONFIGURATION_MST_NAME, CONFIGURATION_NAME, pucWorkOrderInfoPopup_T50Entity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucWorkOrderInfoPopup_T50Provider(pDBManager).WorkOrderInfo_Return(pCRUD, pPARTCODE)", pException);
            }
        }

        public bool ucWorkOrderInfoPopup_T50_Save(ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkOrderInfoPopup_T50Provider(pDBManager).WorkOrderInfo_Save(pucWorkOrderInfoPopup_T50Entity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucWorkOrderInfoPopup_T50_Save(ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity, DataTable pDataTable)", pException);
            }
        }

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucWorkOrderInfoPopup_T50Provider(pDBManager).Sheet_Info_sheet(pucWorkOrderInfoPopup_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_Request)", pException);
            }
        }

        #endregion

    }

    public class pucPlanOrderinfoPopupBusiness
    {
        public DataSet ucPlanOrderinfoPopup_Select(ucPlanOrderinfoPopup_Entity pucPlanOrderinfoPopup_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucPlanOrderinfoPopupProvider(pDBManager).pucPlanOrderinfoPopup_Return(pucPlanOrderinfoPopup_Entity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProductionOrderInfoPopup_T02_Select(ucProductionOrderInfoPopup_T02_Entity pucProductionOrderInfoPopup_T02_Entity)", pException);
            }
        }
    }

    public class pucPlanOrderinfoPopup_T50Business
    {
        public DataSet ucPlanOrderinfoPopup_T50_Select(ucPlanOrderinfoPopup_T50_Entity pucPlanOrderinfoPopup_T50_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucPlanOrderinfoPopup_T50Provider(pDBManager).pucPlanOrderinfoPopup_T50_Return(pucPlanOrderinfoPopup_T50_Entity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProductionOrderInfoPopup_T02_Select(ucProductionOrderInfoPopup_T02_Entity pucProductionOrderInfoPopup_T02_Entity)", pException);
            }
        }
    }

    public class ucWorkResultPopupBusiness
    {
        public bool ucWorkResultPopup_Save(ucWorkResultPopup_Entity pucWorkResultPopup_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkResultPopupProvider(pDBManager).WorkResultInfo_Save(pucWorkResultPopup_Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopup_Save(ucWorkResultPopup_Entity pucWorkResultPopup_Entity)", pException);
            }
        }

        public bool usWorkResultPopup_Save_01(ucWorkResultPopup_Entity pucWorkResultPopup_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkResultPopupProvider(pDBManager).WorkResultInfo_Save_01(pucWorkResultPopup_Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopup_Save(ucWorkResultPopup_Entity pucWorkResultPopup_Entity)", pException);
            }
        }
    }

    public class NoticeBusiness
    {

        #region 마스터 정보 조회 - Notice_Info(NoticeEntity pNoticeEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Notice_Info_Mst(NoticeEntity pNoticeEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new NoticeProvider(pDBManager).Notice_Info_Mst(pNoticeEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Notice_Info_Mst(NoticeEntity pNoticeEntity)", pException);
            }
        }

        #endregion
        
    }

    public class MaterialOrderInfoPopup_T01Business
    {

        public DataSet MaterialOrderInfoPopup_T01_Return(string pCRUD, string pFromDate, string pToDate, string pPART_CODE, string pPART_NAME, string pVEND_NAME, string pType)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new MaterialOrderInfoPopup_T01Provider(pDBManager).OrderInfoPopup_T01_Return(pCRUD, pFromDate, pToDate, pPART_CODE, pPART_NAME, pVEND_NAME, pType);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "OrderInfoPopup_Return(pCRUD, pDate, pPART_NAME, pVEND_NAME)", pException);
            }
        }

        public bool MaterialOrderInfoPopup_T01_Save(MaterialOrderInfoPopup_T01Entity pucMaterialOrderInfoPopup_T01Entity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOrderInfoPopup_T01Provider(pDBManager).OrderInfoPopup_T01_Save(pucMaterialOrderInfoPopup_T01Entity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucWorkOrderInfoPopup_T50_Save(ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity, DataTable pDataTable)", pException);
            }
        }

        public bool OrderInfoPopup_T01_Second_Save(MaterialOrderInfoPopup_T01Entity pucMaterialOrderInfoPopup_T01Entity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOrderInfoPopup_T01Provider(pDBManager).OrderInfoPopup_T01_Second_Save(pucMaterialOrderInfoPopup_T01Entity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucWorkOrderInfoPopup_T50_Save(ucWorkOrderInfoPopup_T50Entity pucWorkOrderInfoPopup_T50Entity, DataTable pDataTable)", pException);
            }
        }
    }

    public class ResourceCodeInfoPopUpBusiness
    {
        public DataSet ResourceCodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE, string pSERVICE_NAME, string pRESOURCE_CODE, string pVEND_PART_CODE, string pRESOURCE_NAME, string pPART_TYPE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ResourceCodeInfoPopUpProvider(pDBManager).ResourceCodePopUp_Return(pCRUD, pLANGUAGE_TYPE, pSERVICE_NAME, pRESOURCE_CODE, pVEND_PART_CODE, pRESOURCE_NAME, pPART_TYPE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ResourceCodePopUp_Return(string pCRUD, string pLANGUAGE_TYPE, string pRESOURCE_CODE, string pVEND_PART_CODE, string pRESOURCE_NAME, string pPART_TYPE)", pException);
            }
        }
    }

    public class TabletBasedSensorInfoPopup_T02Business
    {

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(TabletBasedSensorInfoPopup_T02Entity pTabletBasedSensorInfoPopup_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new TabletBasedSensorInfoPopup_T02Provider(pDBManager).Sheet_Info_sheet(pTabletBasedSensorInfoPopup_T02Entity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(HACCPCheckRegisterT07Entity _pHACCPCheckRegisterT07Entity)", pException);
            }
        }
        #endregion

        #region ○ 엑셀 시트 저장 - TabletBasedSensorInfoPopup_T02_Save( Worksheet sheet_0)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public DataTable TabletBasedSensorInfoPopup_T02_Save(TabletBasedSensorInfoPopup_T02Entity _pTabletBasedSensorInfoPopup_T02Entity, Worksheet sheet_0)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new TabletBasedSensorInfoPopup_T02Provider(pDBManager).TabletBasedSensorInfoPopup_T02_Save(_pTabletBasedSensorInfoPopup_T02Entity, sheet_0);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity, DataTable dt)", pException);
            }
        }

        #endregion

    }

    public class ucEquipmentInspectInfoPopupBusiness
    {

        #region 마스터 정보 조회 - ucEquipmentInspectInfoPopup_Return(NoticeEntity pNoticeEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucEquipmentInspectInfoPopup_Return(ucEquipmentInspectInfoPopupEntity pucEquipmentInspectInfoPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucEquipmentInspectInfoPopupProvider(pDBManager).EquipmentInspectInfoPopup_Return(pucEquipmentInspectInfoPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucEquipmentInspectInfoPopup_Return(ucEquipmentInspectInfoPopupEntity pucEquipmentInspectInfoPopupEntity)", pException);
            }
        }

        #endregion

        #region 설비 정보 저장 - ucEquipmentInspectInfoPopup_Save(ucEquipmentInspectInfoPopupEntity pucucEquipmentInspectInfoPopupEntity, DataTable pDataTable)
        public bool ucEquipmentInspectInfoPopup_Save(ucEquipmentInspectInfoPopupEntity pucucEquipmentInspectInfoPopupEntity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucEquipmentInspectInfoPopupProvider(pDBManager).EquipmentInspectInfoPopup_Info_Save(pucucEquipmentInspectInfoPopupEntity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucEquipmentInspectInfoPopup_Save(ucEquipmentInspectInfoPopupEntity pucucEquipmentInspectInfoPopupEntity, DataTable pDataTable)", pException);
            }
        }
        #endregion

    }
}
