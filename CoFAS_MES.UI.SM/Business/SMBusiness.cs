using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CoFAS_MES.UI.SM.Data;
using CoFAS_MES.UI.SM.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;

namespace CoFAS_MES.UI.SM.Business
{

    public class CommonCodeRegisterBusiness
    {
        #region 대분류 코드 조회 - CommonCode_Info_First(CommonCodeRegisterEntity pCommonCodeRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable CommonCode_Info_First(CommonCodeRegisterEntity pCommonCodeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new CommonCodeRegisterProvider(pDBManager).CommonCode_Info_First(pCommonCodeRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "CommonCode_Info_First(CommonCodeRegisterEntity pCommonCodeRegisterEntity)", pException);
            }
        }

        #endregion



        #region 중분류 코드 조회 - CommonCode_Info_Second(CommonCodeRegisterEntity pCommonCodeRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable CommonCode_Info_Second(CommonCodeRegisterEntity pCommonCodeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new CommonCodeRegisterProvider(pDBManager).CommonCode_Info_Second(pCommonCodeRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "CommonCode_Info_Second(CommonCodeRegisterEntity pCommonCodeRegisterEntity)", pException);
            }
        }

        #endregion

        #region 소분류 코드 조회 - CommonCode_Info_Third(CommonCodeRegisterEntity pCommonCodeRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable CommonCode_Info_Third(CommonCodeRegisterEntity pCommonCodeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new CommonCodeRegisterProvider(pDBManager).CommonCode_Info_Third(pCommonCodeRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "CommonCode_Info_Third(CommonCodeRegisterEntity pCommonCodeRegisterEntity)", pException);
            }
        }

        #endregion

        #region 공통코드 저장 - CommonCode_Info_Save(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool CommonCode_Info_Save(CommonCodeRegisterEntity pCommonCodeRegisterEntity, DataTable dt,string code)
        {
            try
            {
                DataTable dtTemp = null;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");
                
                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }
                else
                {
                    dtTemp = dt;
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new CommonCodeRegisterProvider(pDBManager).CommonCode_Info_Save(pCommonCodeRegisterEntity, dtTemp,code);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "CommonCode_Info_Save(CommonCodeRegisterProvider pCommonCodeRegisterProvider, DataTable dt)", pException);
            }
        }

        public bool CommonCode_Info_Save(CommonCodeRegisterEntity pCommonCodeRegisterEntity, DataTable dtFirst, DataTable dtSecond, DataTable dtThird)
        {
            try
            {
                DataTable dtTemp = null;
                DataTable dtWork = null;
                bool isChack = false;

                for (int a = 0; a < 3; a++)
                {
                    switch(a)
                    {
                        case 0:

                            isChack = false;
                            isChack = CoFAS_ConvertManager.DataTable_FindCount(dtFirst, "CRUD IN ('C','U','D')", "");
                            if (isChack)
                            {
                                dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dtFirst, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                            }

                            break;

                        case 1:

                            isChack = false;
                            isChack = CoFAS_ConvertManager.DataTable_FindCount(dtSecond, "CRUD IN ('C','U','D')", "");
                            if (isChack)
                            {
                                dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dtSecond, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                            }

                            break;

                        case 2:

                            isChack = false;
                            isChack = CoFAS_ConvertManager.DataTable_FindCount(dtThird, "CRUD IN ('C','U','D')", "");
                            if (isChack)
                            {
                                dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dtThird, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                            }
                            break;
                    }
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new CommonCodeRegisterProvider(pDBManager).CommonCode_Info_Save(pCommonCodeRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "CommonCode_Info_Save(CommonCodeRegisterProvider pCommonCodeRegisterProvider, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public CommonCodeRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                CommonCodeRegisterEntity pCommonCodeRegisterEntity = new CommonCodeRegisterProvider(null).GetEntity(pDataRow);
                return pCommonCodeRegisterEntity;
            }
            catch (Exception pException)
            {
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
    public class CorporationInformationBusiness
    {
        #region 마스터 정보 조회 - Corporation_Info(CorporationInformationEntity pCorporationInformationEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Corporation_Info(CorporationInformationEntity pCorporationInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new CorporationInformationProvider(pDBManager).Corporation_Info(pCorporationInformationEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Corporation_Info(CorporationInformationEntity pCorporationInformationEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Corporation_Info_Save(CorporationInformationEntity pCorporationInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Corporation_Info_Save(CorporationInformationEntity pCorporationInformationEntity)
        {
            try
            {

                DataTable dtTemp = null;

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new CorporationInformationProvider(pDBManager).Corporation_Info_Save(pCorporationInformationEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Corporation_Info_Save(CorporationInformationEntity pCorporationInformationEntity)", pException);
            }
        }

        #endregion

        #region 로고 이미지 삭제 - Corporation_Logo_delete(CorporationInformationEntity pCorporationInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Corporation_Logo_delete(CorporationInformationEntity pCorporationInformationEntity)
        {
            try
            {

                DataTable dtTemp = null;

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new CorporationInformationProvider(pDBManager).Corporation_Logo_Delete(pCorporationInformationEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Corporation_Logo_delete(CorporationInformationEntity pCorporationInformationEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public CorporationInformationEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                CorporationInformationEntity pCorporationInformationEntity = new CorporationInformationProvider(null).GetEntity(pDataRow);
                return pCorporationInformationEntity;
            }
            catch (Exception pException)
            {
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
    public class UserInformationBusiness
    {
        #region 사용자 정보 조회 - User_Info_Main(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 사용자 정보 조회
        /// </summary>
        public DataTable User_Info_Main(UserInformationEntity pUserInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new UserInformationProvider(pDBManager).User_Info(pUserInformationEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info(UserInformationEntity pUserInformationEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - User_Info_Sub(VendorInformationEntity pUserInformationEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable User_Info_Sub(UserInformationEntity pUserInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new UserInformationProvider(pDBManager).User_Info_Sub(pUserInformationEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Sub(UserInformationEntity pUserInformationEntity)", pException);
            }
        }

        #endregion

        #region 사용자 정보 저장 -User_Info_Save(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool User_Info_Save(UserInformationEntity pUserInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new UserInformationProvider(pDBManager).User_Info_Save(pUserInformationEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Save(UserInformationEntity pUserInformationEntity)", pException);
            }
        }

        #endregion

        #region 사용자 이미지 삭제 -User_Image_Delete(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool User_Image_Delete(UserInformationEntity pUserInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new UserInformationProvider(pDBManager).User_Image_Delete(pUserInformationEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Image_Delete(UserInformationEntity pUserInformationEntity)", pException);
            }
        }

        #endregion


        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public UserInformationEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                UserInformationEntity pUserInformationEntity = new UserInformationProvider(null).GetEntity(pDataRow);
                return pUserInformationEntity;
            }
            catch (Exception pException)
            {
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

    public class SheetInfoRegisterBusiness
    {

        #region 마스터 정보 조회 - Vend_Info_Mst(VendorInformationEntity pVendorInformationEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sheet_Info_Mst(SheetInfoRegisterEntity pSheetInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SheetInfoRegisterProvider(pDBManager).Sheet_Info_Mst(pSheetInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Mst(SheetInfoRegisterEntity pSheetInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 저장
        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sheet_Info_Save(SheetInfoRegisterEntity pSheetInfoRegisterEntity)
        {
            try
            {

                DataTable dtTemp = null;

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new SheetInfoRegisterProvider(pDBManager).Sheet_Info_Save(pSheetInfoRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Save(SheetInfoRegisterEntity pSheetInfoRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public SheetInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                SheetInfoRegisterEntity pSheetInfoRegisterEntity = new SheetInfoRegisterProvider(null).GetEntity(pDataRow);
                return pSheetInfoRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class MenuAuthorityBusiness
    {
        #region 메뉴권한 조회 - MenuAuthority_R10(MenuAuthorityEntity pMenuAuthorityEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuAuthority_R10(MenuAuthorityEntity pMenuAuthorityEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuAuthorityProvider(pDBManager).MenuAuthority_R10(pMenuAuthorityEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_R10(MenuAuthorityEntity pMenuAuthorityEntity)", pException);
            }
        }

        #endregion

        #region 메뉴권한 조회 - MenuAuthority_R20(MenuAuthorityEntity pMenuAuthorityEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuAuthority_R20(MenuAuthorityEntity pMenuAuthorityEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuAuthorityProvider(pDBManager).MenuAuthority_R20(pMenuAuthorityEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_R20(MenuAuthorityEntity pMenuAuthorityEntity)", pException);
            }
        }

        #endregion

        #region 메뉴권한 저장 - MenuAuthority_I10(MenuAuthorityEntity pMenuAuthorityEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MenuAuthority_I10(MenuAuthorityEntity pMenuAuthorityEntity, DataTable dt)
        {
            try
            {


                DataTable dtTemp = null;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MenuAuthorityProvider(pDBManager).MenuAuthority_I10(pMenuAuthorityEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_I10(MenuAuthorityEntity pMenuAuthorityEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MenuAuthorityEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MenuAuthorityEntity pMenuAuthorityEntity = new MenuAuthorityProvider(null).GetEntity(pDataRow);
                return pMenuAuthorityEntity;
            }
            catch (Exception pException)
            {
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

    public class MenuAuthority_T01Business
    {
        #region 메뉴권한 조회 - MenuAuthority_T01_R10(MenuAuthority_T01Entity pMenuAuthority_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuAuthority_T01_R10(MenuAuthority_T01Entity pMenuAuthority_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuAuthority_T01Provider(pDBManager).MenuAuthority_T01_R10(pMenuAuthority_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_T01_R10(MenuAuthority_T01Entity pMenuAuthority_T01Entity)", pException);
            }
        }

        #endregion

        #region 메뉴권한 조회 - MenuAuthority_T01_R20(MenuAuthority_T01Entity pMenuAuthority_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuAuthority_T01_R20(MenuAuthority_T01Entity pMenuAuthority_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuAuthority_T01Provider(pDBManager).MenuAuthority_T01_R20(pMenuAuthority_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_T01_R20(MenuAuthority_T01Entity pMenuAuthority_T01Entity)", pException);
            }
        }

        #endregion

        #region 메뉴권한 저장 - MenuAuthority_T01_I10(MenuAuthority_T01Entity pMenuAuthority_T01Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MenuAuthority_T01_I10(MenuAuthority_T01Entity pMenuAuthority_T01Entity, DataTable dt)
        {
            try
            {


                DataTable dtTemp = null;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MenuAuthority_T01Provider(pDBManager).MenuAuthority_T01_I10(pMenuAuthority_T01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_T01_I10(MenuAuthority_T01Entity pMenuAuthority_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 메뉴권한 저장 - MenuAuthority_T01_I20(MenuAuthority_T01Entity pMenuAuthority_T01Entity, DataTable dt)

        /// <summary>
        /// 메뉴권한 저장 전 원래 저장된 메뉴권한의 사용유무 모두 N으로 업데이트
        /// </summary>
        public bool MenuAuthority_T01_I20(MenuAuthority_T01Entity pMenuAuthority_T01Entity)
        {
            try
            {


                //DataTable dtTemp = null;

                ////bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");

                ////if (isChack)
                ////{
                ////    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                ////}

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MenuAuthority_T01Provider(pDBManager).MenuAuthority_T01_I20(pMenuAuthority_T01Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_T01_I20(MenuAuthority_T01Entity pMenuAuthority_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MenuAuthority_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MenuAuthority_T01Entity pMenuAuthority_T01Entity = new MenuAuthority_T01Provider(null).GetEntity(pDataRow);
                return pMenuAuthority_T01Entity;
            }
            catch (Exception pException)
            {
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
        public class MenuAuthority_T02Business
    {
        #region 메뉴권한 조회 - MenuAuthority_T02_R10(MenuAuthority_T02Entity pMenuAuthority_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuAuthority_T02_R10(MenuAuthority_T02Entity pMenuAuthority_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuAuthority_T02Provider(pDBManager).MenuAuthority_T02_R10(pMenuAuthority_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_T02_R10(MenuAuthority_T02Entity pMenuAuthority_T02Entity)", pException);
            }
        }

        #endregion


        #region 메뉴권한 조회 - MenuAuthority_T02_R20(MenuAuthority_T02Entity pMenuAuthority_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuAuthority_T02_R20(MenuAuthority_T02Entity pMenuAuthority_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuAuthority_T02Provider(pDBManager).MenuAuthority_T02_R20(pMenuAuthority_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_T02_R20(MenuAuthority_T02Entity pMenuAuthority_T02Entity)", pException);
            }
        }

        #endregion

        #region 메뉴권한 조회 - MenuAuthority_T02_R10(MenuAuthority_T02Entity pMenuAuthority_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuAuthority_T02_R30(MenuAuthority_T02Entity pMenuAuthority_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuAuthority_T02Provider(pDBManager).MenuAuthority_T02_R30(pMenuAuthority_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_T02_R10(MenuAuthority_T02Entity pMenuAuthority_T02Entity)", pException);
            }
        }

        #endregion

        #region 메뉴권한 조회 - MenuAuthority_T02_R10(MenuAuthority_T02Entity pMenuAuthority_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuAuthority_T02_R40(MenuAuthority_T02Entity pMenuAuthority_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuAuthority_T02Provider(pDBManager).MenuAuthority_T02_R40(pMenuAuthority_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_T02_R10(MenuAuthority_T02Entity pMenuAuthority_T02Entity)", pException);
            }
        }

        #endregion
        #region 메뉴권한 저장 - MenuAuthority_T02_I10(MenuAuthority_T02Entity pMenuAuthority_T02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MenuAuthority_T02_I10(MenuAuthority_T02Entity pMenuAuthority_T02Entity, DataTable dt)
        {
            try
            {


                DataTable dtTemp = null;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MenuAuthority_T02Provider(pDBManager).MenuAuthority_T02_I10(pMenuAuthority_T02Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_T02_I10(MenuAuthority_T02Entity pMenuAuthority_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 메뉴권한 저장 - MenuAuthority_T02_I10(MenuAuthority_T02Entity pMenuAuthority_T02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MenuAuthority_T02_I20(MenuAuthority_T02Entity pMenuAuthority_T02Entity, DataTable dt)
        {
            try
            {


                DataTable dtTemp = null;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('Y')", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('Y')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MenuAuthority_T02Provider(pDBManager).MenuAuthority_T02_I20(pMenuAuthority_T02Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuAuthority_T02_I10(MenuAuthority_T02Entity pMenuAuthority_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MenuAuthority_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MenuAuthority_T02Entity pMenuAuthority_T02Entity = new MenuAuthority_T02Provider(null).GetEntity(pDataRow);
                return pMenuAuthority_T02Entity;
            }
            catch (Exception pException)
            {
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



    public class GroupMenuAuthorityBusiness
    {
        #region 메뉴권한 조회 - GroupMenuAuthority_R10(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable GroupMenuAuthority_R10(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GroupMenuAuthorityProvider(pDBManager).GroupMenuAuthority_R10(pGroupMenuAuthorityEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "GroupMenuAuthority_R10(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity)", pException);
            }
        }

        #endregion

        #region 메뉴권한 조회 - GroupMenuAuthority_R20(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable GroupMenuAuthority_R20(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GroupMenuAuthorityProvider(pDBManager).GroupMenuAuthority_R20(pGroupMenuAuthorityEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "GroupMenuAuthority_R20(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity)", pException);
            }
        }

        #endregion

        #region 메뉴권한 저장 - GroupMenuAuthority_I10(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool GroupMenuAuthority_I10(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity, DataTable dt)
        {
            try
            {


                DataTable dtTemp = null;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new GroupMenuAuthorityProvider(pDBManager).GroupMenuAuthority_I10(pGroupMenuAuthorityEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "GroupMenuAuthority_I10(GroupMenuAuthorityEntity pGroupMenuAuthorityEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public GroupMenuAuthorityEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                GroupMenuAuthorityEntity pGroupMenuAuthorityEntity = new GroupMenuAuthorityProvider(null).GetEntity(pDataRow);
                return pGroupMenuAuthorityEntity;
            }
            catch (Exception pException)
            {
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

    public class Teamviewer_Info_T01Business
    {
        #region 마스터 정보 조회 - MaterialInformationRegister_Info(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Teamviewer_Info_T01_Info(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Teamviewer_Info_T01Provider(pDBManager).Teamviewer_Info_T01_Info_Mst(pTeamviewer_Info_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Teamviewer_Info_T01_Info(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Teamviewer_Info_T01_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Teamviewer_Info_T01_Info_Sub(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Teamviewer_Info_T01Provider(pDBManager).Teamviewer_Info_T01_Info_Sub(pTeamviewer_Info_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Teamviewer_Info_T01_Info_Sub(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Teamviewer_Info_Save(Teamviewer_Info_T01Entity pTeamviewerEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Teamviewer_Info_T01_Info_Save(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new Teamviewer_Info_T01Provider(pDBManager).Teamviewer_Info_T01_Info_Save(pTeamviewer_Info_T01Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Teamviewer_Info_T01_Info_Save(Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public Teamviewer_Info_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                Teamviewer_Info_T01Entity pTeamviewer_Info_T01Entity = new Teamviewer_Info_T01Provider(null).GetEntity(pDataRow);
                return pTeamviewer_Info_T01Entity;
            }
            catch (Exception pException)
            {
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


    public class GroupUserMailingBusiness
    {
        #region 룰 그룹 코드 조회 - GroupRule_info(GroupUserMailingEntity pGroupUserMailingEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable GroupRule_info(GroupUserMailingEntity pGroupUserMailingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GroupUserMailingProvider(pDBManager).GroupRule_info(pGroupUserMailingEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "GroupRule_info(GroupUserMailingEntity pGroupUserMailingEntity)", pException);
            }
        }

        #endregion



        #region 룰 그룹 별 사용자 조회하기 - GroupUserMailing_Rule_info(GroupUserMailingEntity pGroupUserMailingEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable GroupUserMailing_Rule_info(GroupUserMailingEntity pGroupUserMailingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GroupUserMailingProvider(pDBManager).GroupUserMailing_Rule_info(pGroupUserMailingEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "GroupUserMailing_Rule_info(GroupUserMailingEntity pGroupUserMailingEntity)", pException);
            }
        }

        #endregion

        #region 룰 그룹 별 사용자 메일 저장 - CommonCode_Info_Save(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool GroupUserMailing_Info_Save(GroupUserMailingEntity pGroupUserMailingEntity, DataTable dt)
        {
            try
            {
                DataTable dtTemp = null;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }
                else
                {
                    dtTemp = dt;
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new GroupUserMailingProvider(pDBManager).GroupUserMailing_Info_Save(pGroupUserMailingEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "GroupUserMailing_Info_Save(GroupUserMailingEntity pGroupUserMailingEntity, DataTable dt)", pException);
            }
        }
        
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public GroupUserMailingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                GroupUserMailingEntity pGroupUserMailingEntity = new GroupUserMailingProvider(null).GetEntity(pDataRow);
                return pGroupUserMailingEntity;
            }
            catch (Exception pException)
            {
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
